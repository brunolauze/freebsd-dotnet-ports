--- /dev/null	2016-01-24 21:34:50.000000000 -0500
+++ src/XMakeTasks/SR.cs	2016-01-24 21:35:07.050110000 -0500
@@ -0,0 +1,123 @@
+using System;
+using System.Globalization;
+using System.Resources;
+using System.Threading;
+
+namespace Microsoft.Build.Tasks
+{
+    internal sealed class SR
+    {
+        internal const string ClassDocComment = "ClassDocComment";
+
+        internal const string ClassComments1 = "ClassComments1";
+
+        internal const string ClassComments3 = "ClassComments3";
+
+        internal const string StringPropertyComment = "StringPropertyComment";
+
+        internal const string StringPropertyTruncatedComment = "StringPropertyTruncatedComment";
+
+        internal const string NonStringPropertyComment = "NonStringPropertyComment";
+
+        internal const string NonStringPropertyDetailedComment = "NonStringPropertyDetailedComment";
+
+        internal const string CulturePropertyComment1 = "CulturePropertyComment1";
+
+        internal const string CulturePropertyComment2 = "CulturePropertyComment2";
+
+        internal const string ResMgrPropertyComment = "ResMgrPropertyComment";
+
+        internal const string MismatchedResourceName = "MismatchedResourceName";
+
+        internal const string InvalidIdentifier = "InvalidIdentifier";
+
+        private static SR s_loader;
+
+        private ResourceManager _resources;
+
+        private static CultureInfo Culture
+        {
+            get
+            {
+                return null;
+            }
+        }
+
+        public static ResourceManager Resources
+        {
+            get
+            {
+                return SR.GetLoader()._resources;
+            }
+        }
+
+        static SR()
+        {
+            SR.s_loader = null;
+        }
+
+        internal SR()
+        {
+            this._resources = new ResourceManager("System.Design", this.GetType().Assembly);
+        }
+
+        private static SR GetLoader()
+        {
+            if (SR.s_loader == null)
+            {
+                SR sR = new SR();
+                Interlocked.CompareExchange<SR>(ref SR.s_loader, sR, null);
+            }
+            return SR.s_loader;
+        }
+
+        public static object GetObject(string name)
+        {
+            SR loader = SR.GetLoader();
+            if (loader == null)
+            {
+                return null;
+            }
+            return loader._resources.GetObject(name, SR.Culture);
+        }
+
+        public static string GetString(string name, params object[] args)
+        {
+            SR loader = SR.GetLoader();
+            if (loader == null)
+            {
+                return null;
+            }
+            string str = loader._resources.GetString(name, SR.Culture);
+            if (args == null || (int)args.Length <= 0)
+            {
+                return str;
+            }
+            for (int i = 0; i < (int)args.Length; i++)
+            {
+                string str1 = args[i] as string;
+                if (str1 != null && str1.Length > 1024)
+                {
+                    args[i] = string.Concat(str1.Substring(0, 1021), "...");
+                }
+            }
+            return string.Format(CultureInfo.CurrentCulture, str, args);
+        }
+
+        public static string GetString(string name)
+        {
+            SR loader = SR.GetLoader();
+            if (loader == null)
+            {
+                return null;
+            }
+            return loader._resources.GetString(name, SR.Culture);
+        }
+
+        public static string GetString(string name, out bool usedFallback)
+        {
+            usedFallback = false;
+            return SR.GetString(name);
+        }
+    }
+}
