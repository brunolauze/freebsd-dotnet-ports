--- /dev/null	2016-05-07 15:56:04.000000000 -0400
+++ src/System.Runtime.InteropServices/src/System/Runtime/InteropServices/STATSTG.cs	2016-05-07 15:58:26.612715000 -0400
@@ -0,0 +1,21 @@
+using System;
+
+namespace System.Runtime.InteropServices
+{
+    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public partial struct STATSTG
+    {
+        public System.Runtime.InteropServices.ComTypes.FILETIME atime;
+        public long cbSize;
+        public System.Guid clsid;
+        public System.Runtime.InteropServices.ComTypes.FILETIME ctime;
+        public int grfLocksSupported;
+        public int grfMode;
+        public int grfStateBits;
+        public System.Runtime.InteropServices.ComTypes.FILETIME mtime;
+        public string pwcsName;
+        public int reserved;
+        public int type;
+    }
+}
