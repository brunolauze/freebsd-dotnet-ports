--- src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs.orig	2016-08-11 13:22:27.000000000 -0400
+++ src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs	2016-08-11 15:09:18.892717000 -0400
@@ -1,4 +1,4 @@
-﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
+// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
 
 using System;
 using System.Collections.Generic;
@@ -3279,7 +3279,7 @@
 
             FixedArgumentsEncoder fixedArgsEncoder;
             CustomAttributeNamedArgumentsEncoder namedArgsEncoder;
-            new BlobEncoder(builder).CustomAttributeSignature(out fixedArgsEncoder, out namedArgsEncoder);
+            new BlobEncoder(builder).CustomAttributeSignature(x => fixedArgsEncoder = x, x => namedArgsEncoder = x);
 
             for (int i = 0; i < parameters.Length; i++)
             {
@@ -3296,7 +3296,7 @@
                 NamedArgumentTypeEncoder typeEncoder;
                 NameEncoder nameEncoder;
                 LiteralEncoder literalEncoder;
-                encoder.AddArgument(namedArgument.IsField, out typeEncoder, out nameEncoder, out literalEncoder);
+                encoder.AddArgument(namedArgument.IsField, x => typeEncoder = x, x => nameEncoder = x, x => literalEncoder = x);
 
                 SerializeNamedArgumentType(typeEncoder, namedArgument.Type);
                 nameEncoder.Name(namedArgument.ArgumentName);
@@ -3336,7 +3336,7 @@
                     Debug.Assert(this.module.IsPlatformType(targetType, PlatformType.SystemObject));
 
                     CustomAttributeArrayTypeEncoder arrayTypeEncoder;
-                    encoder.TaggedVector(out arrayTypeEncoder, out vectorEncoder);
+                    encoder.TaggedVector(x => arrayTypeEncoder = x, x => vectorEncoder = x);
                     SerializeCustomAttributeArrayType(arrayTypeEncoder, (IArrayTypeReference)a.Type);
 
                     targetElementType = a.ElementType;
@@ -3366,7 +3366,7 @@
                 if (this.module.IsPlatformType(targetType, PlatformType.SystemObject))
                 {
                     CustomAttributeElementTypeEncoder typeEncoder;
-                    encoder.TaggedScalar(out typeEncoder, out scalarEncoder);
+                    encoder.TaggedScalar(x => typeEncoder = x, x => scalarEncoder = x);
                     
                     // special case null argument assigned to Object parameter - treat as null string
                     if (c != null &&
@@ -3589,9 +3589,9 @@
 			var returnType = signature.GetType(Context);
 
             ReturnTypeEncoder returnTypeEncoder;
-            ParametersEncoder parametersEncoder;
+            ParametersEncoder parametersEncoder = default(ParametersEncoder);
 
-            encoder.Parameters(declaredParameters.Length + varargParameters.Length, out returnTypeEncoder, out parametersEncoder);
+            encoder.Parameters(declaredParameters.Length + varargParameters.Length, x => returnTypeEncoder = x, x => parametersEncoder = x);
             if (signature.ReturnValueCustomModifiers.Length > 0)
             {
                 SerializeCustomModifiers(returnTypeEncoder.CustomModifiers(), signature.ReturnValueCustomModifiers);
@@ -3689,7 +3689,7 @@
                     {
                         SignatureTypeEncoder elementType;
                         ArrayShapeEncoder arrayShape;
-                        encoder.Array(out elementType, out arrayShape);
+                        encoder.Array(x => elementType = x, x => arrayShape = x);
                         SerializeTypeReference(elementType, typeReference);
                         arrayShape.Shape(arrayTypeReference.Rank, arrayTypeReference.Sizes, arrayTypeReference.LowerBounds);
                         return;
