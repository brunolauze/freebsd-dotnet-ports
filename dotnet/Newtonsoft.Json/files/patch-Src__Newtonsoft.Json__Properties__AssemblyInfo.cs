--- Src/Newtonsoft.Json/Properties/AssemblyInfo.cs.orig	2015-12-26 18:32:59.411477000 -0500
+++ Src/Newtonsoft.Json/Properties/AssemblyInfo.cs	2015-12-26 18:33:25.404494000 -0500
@@ -53,14 +53,8 @@
 [assembly: AllowPartiallyTrustedCallers]
 #endif
 
-#if !SIGNED
-
-[assembly: InternalsVisibleTo("Newtonsoft.Json.Schema")]
-[assembly: InternalsVisibleTo("Newtonsoft.Json.Tests")]
-#else
 [assembly: InternalsVisibleTo("Newtonsoft.Json.Schema, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
 [assembly: InternalsVisibleTo("Newtonsoft.Json.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
-#endif
 
 [assembly: InternalsVisibleTo("Newtonsoft.Json.Dynamic, PublicKey=0024000004800000940000000602000000240000525341310004000001000100cbd8d53b9d7de30f1f1278f636ec462cf9c254991291e66ebb157a885638a517887633b898ccbcf0d5c5ff7be85a6abe9e765d0ac7cd33c68dac67e7e64530e8222101109f154ab14a941c490ac155cd1d4fcba0fabb49016b4ef28593b015cab5937da31172f03f67d09edda404b88a60023f062ae71d0b2e4438b74cc11dc9")]
 [assembly: AssemblyDescription("Json.NET is a popular high-performance JSON framework for .NET")]
@@ -95,4 +89,4 @@
 
 [assembly: AssemblyVersion("7.0.0.0")]
 [assembly: AssemblyFileVersion("7.0.2.18802")]
-[assembly: CLSCompliant(true)]
\ No newline at end of file
+[assembly: CLSCompliant(true)]
