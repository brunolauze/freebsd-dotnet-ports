--- /dev/null	2016-04-23 19:35:06.000000000 -0400
+++ src/mscorlib/src/Microsoft/Win32/Interop.Libraries.cs	2016-04-23 19:35:40.922249000 -0400
@@ -0,0 +1,20 @@
+// Licensed to the .NET Foundation under one or more agreements.
+// The .NET Foundation licenses this file to you under the MIT license.
+// See the LICENSE file in the project root for more information.
+
+internal static partial class Interop
+{
+    internal const string GlobalizationInterop = "System.Globalization.Native"; // CoreFX wrappers for ICU
+
+    internal static partial class Libraries
+    {
+        internal const string GlobalizationInterop = "System.Globalization.Native"; // CoreFX wrappers for ICU
+        // Shims
+	internal const string SystemNative = "System.Native";
+	internal const string HttpNative = "System.Net.Http.Native";
+	internal const string NetSecurityNative = "System.Net.Security.Native";
+	internal const string CryptoNative = "System.Security.Cryptography.Native";
+	internal const string GlobalizationNative = "System.Globalization.Native";
+	internal const string CompressionNative = "System.IO.Compression.Native";
+    }
+}
