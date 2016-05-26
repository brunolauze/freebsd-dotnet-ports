--- samples/SampleApp/Startup.cs.orig	2016-05-12 17:55:56.000000000 -0400
+++ samples/SampleApp/Startup.cs	2016-05-17 17:47:57.920971000 -0400
@@ -45,10 +45,11 @@
                 {
                     // options.ThreadCount = 4;
                     options.NoDelay = true;
-                    options.UseHttps("testCert.pfx", "testPassword");
+                    //options.UseHttps("/usr/local/etc/aspnet-sampleapp.pfx", "testPassword");
                     options.UseConnectionLogging();
                 })
-                .UseUrls("http://localhost:5000", "https://localhost:5001")
+                .UseUrls("http://localhost:5000") 
+		//, "https://localhost:5001")
                 .UseContentRoot(Directory.GetCurrentDirectory())
                 .UseStartup<Startup>()
                 .Build();
@@ -61,4 +62,4 @@
             host.Run();
         }
     }
-}
\ No newline at end of file
+}
