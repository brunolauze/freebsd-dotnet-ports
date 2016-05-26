--- /dev/null	2016-01-28 08:51:21.000000000 -0500
+++ src/System.Diagnostics.Debug/src/SR.cs	2016-01-28 08:52:27.018448000 -0500
@@ -0,0 +1,113 @@
+using System.Resources;
+
+namespace FxResources.System.Diagnostics.Debug
+{
+   public class SR
+   {
+
+   }
+}
+
+
+namespace System
+{
+    internal partial class SR
+    {
+		private static ResourceManager s_resourceManager;
+
+        private const string s_resourcesName = "FxResources.System.Diagnostics.Debug.SR";
+
+        internal static Type ResourceType { get { return typeof(FxResources.System.Diagnostics.Debug.SR); } }
+		
+	 private static ResourceManager ResourceManager
+        {
+            get
+            {
+                if (SR.s_resourceManager == null)
+                {
+                    SR.s_resourceManager = new ResourceManager(SR.ResourceType);
+                }
+                return SR.s_resourceManager;
+            }
+        }
+		
+		 internal static string Format(string resourceFormat, params object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, args);
+            }
+            return string.Concat(resourceFormat, string.Join(", ", args));
+        }
+
+        internal static string Format(string resourceFormat, object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1 });
+        }
+
+        internal static string Format(string resourceFormat, object p1, object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1, p2);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static string Format(string resourceFormat, object p1, object p2, object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1, p2, p3);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static string GetResourceString(string resourceKey, string defaultString)
+        {
+            string str = null;
+            try
+            {
+                str = SR.ResourceManager.GetString(resourceKey);
+            }
+            catch (MissingManifestResourceException missingManifestResourceException)
+            {
+            }
+            if (defaultString != null && resourceKey.Equals(str))
+            {
+                return defaultString;
+            }
+            return str;
+        }
+
+        private static bool UsingResourceKeys() { return false; }
+
+	public static string IO_PathTooLong { get { return GetResourceString(nameof(IO_PathTooLong), ""); } }	
+	public static string IO_FileExists_Name { get { return GetResourceString(nameof(IO_FileExists_Name), ""); } }		
+	public static string ArgumentOutOfRange_FileLengthTooBig { get { return GetResourceString(nameof(ArgumentOutOfRange_FileLengthTooBig), ""); } }
+ 	public static string RTL { get { return GetResourceString(nameof(RTL), ""); } }
+	public static string UnauthorizedAccess_IODenied_Path { get { return GetResourceString(nameof(UnauthorizedAccess_IODenied_Path), ""); } }
+	public static string UnauthorizedAccess_IODenied_NoPathName { get { return GetResourceString(nameof(UnauthorizedAccess_IODenied_NoPathName), ""); } }
+	public static string IO_SharingViolation_NoFileName { get { return GetResourceString(nameof(IO_SharingViolation_NoFileName), ""); } }
+	public static string IO_SharingViolation_File { get { return GetResourceString(nameof(IO_SharingViolation_File), ""); } }
+	public static string IO_PathNotFound_Path { get { return GetResourceString(nameof(IO_PathNotFound_Path), ""); } }
+	public static string IO_PathNotFound_NoPathName { get { return GetResourceString(nameof(IO_PathNotFound_NoPathName), ""); } }
+	public static string IO_FileNotFound_FileName { get { return GetResourceString(nameof(IO_FileNotFound_FileName), ""); } }
+	public static string IO_FileNotFound { get { return GetResourceString(nameof(IO_FileNotFound), ""); } }
+	public static string DebugAssertTitleShort { get { return GetResourceString(nameof(DebugAssertTitleShort), ""); } }
+	public static string DebugAssertTitle { get { return GetResourceString(nameof(DebugAssertTitle), ""); } }
+	public static string DebugAssertShortMessage { get { return GetResourceString(nameof(DebugAssertShortMessage), ""); } }
+	public static string DebugAssertLongMessage { get { return GetResourceString(nameof(DebugAssertLongMessage), ""); } }
+	public static string DebugAssertBanner { get { return GetResourceString(nameof(DebugAssertBanner), ""); } }
+		
+  
+    }
+}
