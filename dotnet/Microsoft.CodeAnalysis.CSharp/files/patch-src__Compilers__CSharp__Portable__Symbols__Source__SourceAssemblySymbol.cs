--- src/Compilers/CSharp/Portable/Symbols/Source/SourceAssemblySymbol.cs.orig	2016-07-31 15:56:43.458699000 -0400
+++ src/Compilers/CSharp/Portable/Symbols/Source/SourceAssemblySymbol.cs	2016-07-31 15:57:15.497979000 -0400
@@ -747,7 +747,7 @@
             if (_compilation.Options.PublicSign && assemblyDelaySignAttributeSetting == ThreeState.True)
             {
                 diagnostics.Add(ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton,
-                    nameof(_compilation.Options.PublicSign),
+                    "PublicSign",
                     AttributeDescription.AssemblyDelaySignAttribute.FullName);
             }
 
@@ -2600,4 +2600,4 @@
             get { return _compilation; }
         }
     }
-}
\ No newline at end of file
+}
