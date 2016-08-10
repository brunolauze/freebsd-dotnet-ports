--- src/Compilers/Core/Portable/Desktop/DesktopAssemblyIdentityComparer.cs.orig	2016-07-31 21:43:32.605816000 -0400
+++ src/Compilers/Core/Portable/Desktop/DesktopAssemblyIdentityComparer.cs	2016-07-31 21:44:20.501419000 -0400
@@ -85,7 +85,7 @@
         {
             if (reference.ContentType == AssemblyContentType.Default &&
                 SimpleNameComparer.Equals(reference.Name, definition.Name) &&
-                SimpleNameComparer.Equals(reference.Name, "mscorlib"))
+                (SimpleNameComparer.Equals(reference.Name, "mscorlib") || SimpleNameComparer.Equals(reference.Name, "System.Private.CoreLib")))
             {
                 isDefinitionFxAssembly = true;
                 reference = definition;
