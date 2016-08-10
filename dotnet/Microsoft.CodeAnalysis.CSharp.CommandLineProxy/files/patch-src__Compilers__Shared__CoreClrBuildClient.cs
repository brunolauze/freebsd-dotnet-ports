--- src/Compilers/Shared/CoreClrBuildClient.cs.orig	2016-01-22 15:15:02.901508000 -0500
+++ src/Compilers/Shared/CoreClrBuildClient.cs	2016-01-22 15:16:17.294137000 -0500
@@ -30,7 +30,11 @@
             // as well as the EXE argument. 
             // https://github.com/dotnet/roslyn/issues/6677
             var client = new CoreClrBuildClient(language, compileFunc);
+#if NET451
+	    var clientDir = Environment.ExpandEnvironmentVariables(".");
+#else
             var clientDir = AppContext.BaseDirectory;
+#endif
             var workingDir = Directory.GetCurrentDirectory();
             var buildPaths = new BuildPaths(clientDir: clientDir, workingDir: workingDir, sdkDir: null);
             return client.RunCompilation(arguments, buildPaths).ExitCode;
