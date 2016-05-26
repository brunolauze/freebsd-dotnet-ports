--- src/Compilers/CSharp/Portable/Symbols/Source/SourceAssemblySymbol.cs.orig	2016-01-21 09:06:45.315946000 -0500
+++ src/Compilers/CSharp/Portable/Symbols/Source/SourceAssemblySymbol.cs	2016-01-21 09:07:03.256879000 -0500
@@ -727,7 +727,7 @@
             if (_compilation.Options.PublicSign && assemblyDelaySignAttributeSetting == ThreeState.True)
             {
                 diagnostics.Add(ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton,
-                    nameof(_compilation.Options.PublicSign),
+                    "PublicSign",
                     AttributeDescription.AssemblyDelaySignAttribute.FullName);
             }
 
@@ -2560,4 +2560,4 @@
 
         public override AssemblyMetadata GetMetadata() => null;
     }
-}
\ No newline at end of file
+}
