--- /dev/null	2016-04-23 18:49:10.000000000 -0400
+++ src/mscorlib/src/Microsoft/Win32/Interop.Open.cs	2016-04-23 18:50:04.698523000 -0400
@@ -0,0 +1,15 @@
+// Licensed to the .NET Foundation under one or more agreements.
+// The .NET Foundation licenses this file to you under the MIT license.
+// See the LICENSE file in the project root for more information.
+
+using System.Runtime.InteropServices;
+using Microsoft.Win32.SafeHandles;
+
+internal static partial class Interop
+{
+    internal static partial class Sys
+    {
+        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_Open", SetLastError = true)]
+        internal static extern SafeFileHandle Open(string filename, OpenFlags flags, int mode);
+    }
+}
