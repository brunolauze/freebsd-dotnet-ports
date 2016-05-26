--- /dev/null	2016-04-23 19:22:00.000000000 -0400
+++ src/mscorlib/src/Microsoft/Win32/Interop.Close.cs	2016-04-23 19:26:28.511246000 -0400
@@ -0,0 +1,15 @@
+// Licensed to the .NET Foundation under one or more agreements.
+// The .NET Foundation licenses this file to you under the MIT license.
+// See the LICENSE file in the project root for more information.
+
+using System;
+using System.Runtime.InteropServices;
+
+internal static partial class Interop
+{
+    internal static partial class Sys
+    {
+        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_Close", SetLastError = true)]
+        internal static extern int Close(IntPtr fd);
+    }
+}
