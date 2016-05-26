--- src/Compilers/CSharp/Portable/Lowering/LambdaRewriter/LambdaRewriter.cs.orig	2016-01-21 01:51:04.000000000 -0500
+++ src/Compilers/CSharp/Portable/Lowering/LambdaRewriter/LambdaRewriter.cs	2016-01-21 12:29:37.772643000 -0500
@@ -450,7 +450,7 @@
         /// <returns>The translated statement, as returned from F</returns>
         private T IntroduceFrame<T>(BoundNode node, LambdaFrame frame, Func<ArrayBuilder<BoundExpression>, ArrayBuilder<LocalSymbol>, T> F)
         {
-            NamedTypeSymbol frameType = frame.ConstructIfGeneric(_currentTypeParameters.SelectAsArray(TypeMap.TypeSymbolAsTypeWithModifiers));
+            NamedTypeSymbol frameType = frame.ConstructIfGeneric(_currentTypeParameters.SelectAsArray(TypeMap.TypeParameterSymbolAsTypeWithModifiers));
 
             Debug.Assert(frame.ScopeSyntaxOpt != null);
             LocalSymbol framePointer = new SynthesizedLocal(_topLevelMethod, frameType, SynthesizedLocalKind.LambdaDisplayClass, frame.ScopeSyntaxOpt);
@@ -1089,7 +1089,7 @@
 
             // Rewrite the lambda expression (and the enclosing anonymous method conversion) as a delegate creation expression
             NamedTypeSymbol constructedFrame = (object)containerAsFrame != null ?
-                translatedLambdaContainer.ConstructIfGeneric(_currentTypeParameters.SelectAsArray(TypeMap.TypeSymbolAsTypeWithModifiers)) :
+                translatedLambdaContainer.ConstructIfGeneric(_currentTypeParameters.SelectAsArray(TypeMap.TypeParameterSymbolAsTypeWithModifiers)) :
                 translatedLambdaContainer;
 
             // for instance lambdas, receiver is the frame
