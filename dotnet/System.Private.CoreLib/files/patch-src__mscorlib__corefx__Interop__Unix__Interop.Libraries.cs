--- src/mscorlib/corefx/Interop/Unix/Interop.Libraries.cs.orig	2016-04-23 18:44:25.088868000 -0400
+++ src/mscorlib/corefx/Interop/Unix/Interop.Libraries.cs	2016-04-23 18:45:06.495856000 -0400
@@ -7,5 +7,12 @@
     private static partial class Libraries
     {
         internal const string GlobalizationInterop = "System.Globalization.Native"; // CoreFX wrappers for ICU
+        // Shims
+	internal const string SystemNative = "System.Native";
+	internal const string HttpNative = "System.Net.Http.Native";
+	internal const string NetSecurityNative = "System.Net.Security.Native";
+	internal const string CryptoNative = "System.Security.Cryptography.Native";
+	internal const string GlobalizationNative = "System.Globalization.Native";
+	internal const string CompressionNative = "System.IO.Compression.Native";
     }
 }
