--- /dev/null	2016-01-24 17:35:52.000000000 -0500
+++ src/Csc2.cs	2016-01-24 17:36:25.299935000 -0500
@@ -0,0 +1,17 @@
+using System;
+using System.Linq;
+
+namespace Microsoft.CodeAnalysis.CSharp.CommandLine
+{
+    public class Csc2
+    {
+        public Csc2()
+        {
+        }
+
+        public static int Main(string[] args)
+        {
+            return Program.Main(args.Concat<string>(new string[] { "/shared" }).ToArray<string>());
+        }
+    }
+}
