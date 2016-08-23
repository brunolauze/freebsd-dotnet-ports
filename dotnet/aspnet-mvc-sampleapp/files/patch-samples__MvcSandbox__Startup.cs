--- samples/MvcSandbox/Startup.cs.orig	2016-08-18 19:08:09.796042000 -0400
+++ samples/MvcSandbox/Startup.cs	2016-08-18 19:08:26.537765000 -0400
@@ -41,7 +41,6 @@
         {
             var host = new WebHostBuilder()
                 .UseContentRoot(Directory.GetCurrentDirectory())
-                .UseIISIntegration()
                 .UseKestrel()
                 .UseStartup<Startup>()
                 .Build();
