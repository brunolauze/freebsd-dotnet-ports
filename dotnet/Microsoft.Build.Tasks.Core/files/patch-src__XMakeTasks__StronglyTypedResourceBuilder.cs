--- src/XMakeTasks/StronglyTypedResourceBuilder.cs.orig	2016-01-26 12:47:18.386522000 -0500
+++ src/XMakeTasks/StronglyTypedResourceBuilder.cs	2016-01-26 12:47:55.028394000 -0500
@@ -303,7 +303,7 @@
             CodeAttributeDeclaration generatedCodeAttrib = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.CodeDom.Compiler.GeneratedCodeAttribute)));
             generatedCodeAttrib.AttributeType.Options = CodeTypeReferenceOptions.GlobalReference;
             CodeAttributeArgument toolArg = new CodeAttributeArgument(new CodePrimitiveExpression(typeof(StronglyTypedResourceBuilder).FullName));
-            CodeAttributeArgument versionArg = new CodeAttributeArgument(new CodePrimitiveExpression(ThisAssembly.Version));
+            CodeAttributeArgument versionArg = new CodeAttributeArgument(new CodePrimitiveExpression(new Version("1.0.0.0")));
 
             generatedCodeAttrib.Arguments.Add(toolArg);
             generatedCodeAttrib.Arguments.Add(versionArg);
