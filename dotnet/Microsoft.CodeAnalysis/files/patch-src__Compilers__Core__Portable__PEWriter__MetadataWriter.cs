--- src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs.orig	2016-08-06 01:05:45.000000000 -0400
+++ src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs	2016-08-07 11:55:53.963584000 -0400
@@ -1,4 +1,4 @@
-﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
+// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
 
 using System;
 using System.Collections.Generic;
@@ -2612,7 +2612,9 @@
             else
             {
                 // The guid will be filled in later:
-                mvidHandle = metadata.ReserveGuid(out mvidFixup);
+		var mvidGuid = metadata.ReserveGuid();
+		mvidHandle = mvidGuid.Handle;
+                mvidFixup = mvidGuid.Content;
                 new BlobWriter(mvidFixup).WriteBytes(0, mvidFixup.Length);
             }
 
@@ -2787,7 +2789,7 @@
             var lastLocalVariableHandle = default(LocalVariableHandle);
             var lastLocalConstantHandle = default(LocalConstantHandle);
 
-            var encoder = new MethodBodiesEncoder(ilBuilder);
+            var encoder = new MethodBodyStreamEncoder(ilBuilder);
 
             var mvidStringHandle = default(UserStringHandle);
             mvidStringFixup = default(Blob);
@@ -2843,7 +2845,7 @@
             return bodyOffsets;
         }
 
-        private int SerializeMethodBody(MethodBodiesEncoder encoder, IMethodBody methodBody, StandaloneSignatureHandle localSignatureHandleOpt, ref UserStringHandle mvidStringHandle, ref Blob mvidStringFixup)
+        private int SerializeMethodBody(MethodBodyStreamEncoder encoder, IMethodBody methodBody, StandaloneSignatureHandle localSignatureHandleOpt, ref UserStringHandle mvidStringHandle, ref Blob mvidStringFixup)
         {
             int ilLength = methodBody.IL.Length;
             var exceptionRegions = methodBody.ExceptionRegions;
@@ -2862,14 +2864,10 @@
             }
 
             MethodBodyAttributes attributes =
-                (methodBody.LocalsAreZeroed ? MethodBodyAttributes.InitLocals : 0) |
-                (MayUseSmallExceptionHeaders(exceptionRegions) ? 0 : MethodBodyAttributes.LargeExceptionRegions);
-
-            var bodyEncoder = encoder.AddMethodBody(methodBody.MaxStack, exceptionRegions.Length, localSignatureHandleOpt, attributes);
-
-            Blob ilBlob;
-            var ehEncoder = bodyEncoder.WriteInstructions(methodBody.IL, out bodyOffset, out ilBlob);
+                (methodBody.LocalsAreZeroed ? MethodBodyAttributes.InitLocals : 0);
 
+            var body = encoder.AddMethodBody(ilLength, methodBody.MaxStack, exceptionRegions.Length, isSmallBody, localSignatureHandleOpt, attributes);
+	    bodyOffset = body.Offset;
             // Don't do small body method caching during deterministic builds until this issue is fixed
             // https://github.com/dotnet/roslyn/issues/7595
             if (isSmallBody && !_deterministic)
@@ -2877,8 +2875,8 @@
                 _smallMethodBodies.Add(methodBody.IL, bodyOffset);
             }
 
-            SubstituteFakeTokens(ilBlob, methodBody.IL, ref mvidStringHandle, ref mvidStringFixup);
-            SerializeMethodBodyExceptionHandlerTable(ehEncoder, exceptionRegions);
+            SubstituteFakeTokens(body.Instructions, methodBody.IL, ref mvidStringHandle, ref mvidStringFixup);
+            SerializeMethodBodyExceptionHandlerTable(body.ExceptionRegions, exceptionRegions);
 
             return bodyOffset;
         }
@@ -3039,7 +3037,9 @@
             {
                 try
                 {
-                    return metadata.ReserveUserString(length, out fixup);
+                    var mvid = metadata.ReserveUserString(length);
+		    fixup = mvid.Content;
+		    return mvid.Handle;
                 }
                 catch (ImageFormatLimitationException)
                 {
@@ -3179,23 +3179,19 @@
 
         private void SerializeMethodBodyExceptionHandlerTable(ExceptionRegionEncoder encoder, ImmutableArray<ExceptionHandlerRegion> regions)
         {
-            encoder.StartRegions();
-
             foreach (var region in regions)
             {
                 var exceptionType = region.ExceptionType;
 
-                encoder.AddRegion(
+                encoder.Add(
                     region.HandlerKind,
                     region.TryStartOffset,
-                    region.TryLength,
+                    (region.TryLength < 0 ? 0 : region.TryLength),
                     region.HandlerStartOffset,
                     region.HandlerLength,
                     (exceptionType != null) ? GetTypeHandle(exceptionType) : default(EntityHandle), 
                     region.FilterDecisionStartOffset);
             }
-
-            encoder.EndRegions();
         }
 
         private static bool MayUseSmallExceptionHeaders(ImmutableArray<ExceptionHandlerRegion> exceptionRegions)
@@ -3271,7 +3267,7 @@
 
             FixedArgumentsEncoder fixedArgsEncoder;
             CustomAttributeNamedArgumentsEncoder namedArgsEncoder;
-            new BlobEncoder(builder).CustomAttributeSignature(out fixedArgsEncoder, out namedArgsEncoder);
+            new BlobEncoder(builder).CustomAttributeSignature(x => fixedArgsEncoder = x, x => namedArgsEncoder = x);
 
             for (int i = 0; i < parameters.Length; i++)
             {
@@ -3288,7 +3284,7 @@
                 NamedArgumentTypeEncoder typeEncoder;
                 NameEncoder nameEncoder;
                 LiteralEncoder literalEncoder;
-                encoder.AddArgument(namedArgument.IsField, out typeEncoder, out nameEncoder, out literalEncoder);
+                encoder.AddArgument(namedArgument.IsField, x => typeEncoder = x, x => nameEncoder = x, x => literalEncoder = x);
 
                 SerializeNamedArgumentType(typeEncoder, namedArgument.Type);
                 nameEncoder.Name(namedArgument.ArgumentName);
@@ -3328,7 +3324,7 @@
                     Debug.Assert(this.module.IsPlatformType(targetType, PlatformType.SystemObject));
 
                     CustomAttributeArrayTypeEncoder arrayTypeEncoder;
-                    encoder.TaggedVector(out arrayTypeEncoder, out vectorEncoder);
+                    encoder.TaggedVector(x => arrayTypeEncoder = x, x => vectorEncoder = x);
                     SerializeCustomAttributeArrayType(arrayTypeEncoder, (IArrayTypeReference)a.Type);
 
                     targetElementType = a.ElementType;
@@ -3358,7 +3354,7 @@
                 if (this.module.IsPlatformType(targetType, PlatformType.SystemObject))
                 {
                     CustomAttributeElementTypeEncoder typeEncoder;
-                    encoder.TaggedScalar(out typeEncoder, out scalarEncoder);
+                    encoder.TaggedScalar(x => typeEncoder = x, x => scalarEncoder = x);
                     
                     // special case null argument assigned to Object parameter - treat as null string
                     if (c != null &&
@@ -3581,9 +3577,9 @@
 			var returnType = signature.GetType(Context);
 
             ReturnTypeEncoder returnTypeEncoder;
-            ParametersEncoder parametersEncoder;
+            ParametersEncoder parametersEncoder = default(ParametersEncoder);
 
-            encoder.Parameters(declaredParameters.Length + varargParameters.Length, out returnTypeEncoder, out parametersEncoder);
+            encoder.Parameters(declaredParameters.Length + varargParameters.Length, x => returnTypeEncoder = x, x => parametersEncoder = x);
             if (signature.ReturnValueCustomModifiers.Length > 0)
             {
                 SerializeCustomModifiers(returnTypeEncoder.CustomModifiers(), signature.ReturnValueCustomModifiers);
@@ -3681,7 +3677,7 @@
                     {
                         SignatureTypeEncoder elementType;
                         ArrayShapeEncoder arrayShape;
-                        encoder.Array(out elementType, out arrayShape);
+                        encoder.Array(x => elementType = x, x => arrayShape = x);
                         SerializeTypeReference(elementType, typeReference);
                         arrayShape.Shape(arrayTypeReference.Rank, arrayTypeReference.Sizes, arrayTypeReference.LowerBounds);
                         return;
