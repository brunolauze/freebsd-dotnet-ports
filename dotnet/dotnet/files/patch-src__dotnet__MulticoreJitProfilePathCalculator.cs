--- src/dotnet/MulticoreJitProfilePathCalculator.cs.orig	2016-05-16 17:53:29.248110000 -0400
+++ src/dotnet/MulticoreJitProfilePathCalculator.cs	2016-05-16 17:55:07.267227000 -0400
@@ -29,10 +29,13 @@
         private void CalculateProfileRootPath()
         {
             var profileRoot = GetRuntimeDataRootPathString();
+	    if (string.IsNullOrEmpty(profileRoot)) profileRoot = "/tmp/.dotnet";
 
             var version = Product.Version;
+	    if (string.IsNullOrEmpty(version)) version = "1.0";
 
             var rid = PlatformServices.Default.Runtime.GetRuntimeIdentifier();
+	    if (string.IsNullOrEmpty(rid)) rid = "1.0.0.0";
 
             _multicoreJitProfilePath = Path.Combine(profileRoot, "sdk", version, rid, "optimizationdata");
         }
