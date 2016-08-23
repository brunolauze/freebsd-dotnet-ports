--- src/Compilers/CSharp/Portable/Symbols/Source/SourceAssemblySymbol.cs.orig	2016-08-22 17:57:37.029415000 -0400
+++ src/Compilers/CSharp/Portable/Symbols/Source/SourceAssemblySymbol.cs	2016-08-22 17:57:55.238953000 -0400
@@ -746,7 +746,7 @@
             if (_compilation.Options.PublicSign && assemblyDelaySignAttributeSetting == ThreeState.True)
             {
                 diagnostics.Add(ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton,
-                    nameof(_compilation.Options.PublicSign),
+                    "PublicSign",
                     AttributeDescription.AssemblyDelaySignAttribute.FullName);
             }
 
@@ -2596,4 +2596,4 @@
 
         Compilation ISourceAssemblySymbol.Compilation => _compilation;
     }
-}
\ No newline at end of file
+}
