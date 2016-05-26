--- src/Compilers/CSharp/Portable/Symbols/TypeMap.cs.orig	2016-01-21 01:51:04.000000000 -0500
+++ src/Compilers/CSharp/Portable/Symbols/TypeMap.cs	2016-01-21 10:43:32.747013000 -0500
@@ -18,7 +18,7 @@
     internal sealed class TypeMap : AbstractTypeParameterMap
     {
         public static readonly System.Func<TypeSymbol, TypeWithModifiers> TypeSymbolAsTypeWithModifiers = t => new TypeWithModifiers(t);
-
+	public static readonly System.Func<TypeParameterSymbol, TypeWithModifiers> TypeParameterSymbolAsTypeWithModifiers = t => new TypeWithModifiers(t);
         // Only when the caller passes allowAlpha=true do we tolerate substituted (alpha-renamed) type parameters as keys
         internal TypeMap(ImmutableArray<TypeParameterSymbol> from, ImmutableArray<TypeWithModifiers> to, bool allowAlpha = false)
             : base(ConstructMapping(from, to))
@@ -29,7 +29,7 @@
 
         // Only when the caller passes allowAlpha=true do we tolerate substituted (alpha-renamed) type parameters as keys
         internal TypeMap(ImmutableArray<TypeParameterSymbol> from, ImmutableArray<TypeParameterSymbol> to, bool allowAlpha = false)
-            : this(from, to.SelectAsArray(TypeSymbolAsTypeWithModifiers), allowAlpha)
+            : this(from, to.SelectAsArray(TypeParameterSymbolAsTypeWithModifiers), allowAlpha)
         {
             // mapping contents are read-only hereafter
         }
