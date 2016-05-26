--- src/Compilers/Shared/CoreClrAnalyzerAssemblyLoader.cs.orig	2016-01-22 15:11:18.988910000 -0500
+++ src/Compilers/Shared/CoreClrAnalyzerAssemblyLoader.cs	2016-01-22 15:14:01.272225000 -0500
@@ -76,7 +76,11 @@
         /// </summary>
         private Assembly AppContextLoad(AssemblyName assemblyName)
         {
+#if NET451
+	    var baseDir = Environment.ExpandEnvironmentVariables(".");
+#else
             var baseDir = AppContext.BaseDirectory;
+#endif
             foreach (var extension in s_extensions)
             {
                 var path = Path.Combine(baseDir, assemblyName.Name + extension);
