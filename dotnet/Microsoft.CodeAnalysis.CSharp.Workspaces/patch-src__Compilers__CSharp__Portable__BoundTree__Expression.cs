--- src/Compilers/CSharp/Portable/BoundTree/Expression.cs.orig	2016-05-06 18:04:08.000000000 -0400
+++ src/Compilers/CSharp/Portable/BoundTree/Expression.cs	2016-05-08 13:44:54.673607000 -0400
@@ -493,7 +493,7 @@
         {
             return visitor.VisitLiteralExpression(this, argument);
         }
-    }
+
 
     internal partial class BoundObjectCreationExpression : IObjectCreationExpression
     {
@@ -559,7 +559,7 @@
             return visitor.VisitObjectCreationExpression(this, argument);
         }
 
-        private sealed class FieldInitializer : IFieldInitializer
+        internal sealed class FieldInitializer : IFieldInitializer
         {
             public FieldInitializer(SyntaxNode syntax, IFieldSymbol initializedField, IOperation value)
             {
@@ -595,7 +595,7 @@
             }
         }
 
-        private sealed class PropertyInitializer : IPropertyInitializer
+        internal sealed class PropertyInitializer : IPropertyInitializer
         {
             public PropertyInitializer(SyntaxNode syntax, IPropertySymbol initializedProperty, IOperation value)
             {
