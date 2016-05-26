--- /dev/null	2016-05-16 21:35:34.000000000 -0400
+++ src/System.ComponentModel.Primitives/src/SR.cs	2016-05-16 21:35:00.583417000 -0400
@@ -0,0 +1,272 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.ComponentModel.Primitives
+{
+    internal static class SR
+    {
+
+    }
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.ComponentModel.Primitives.SR";
+
+		internal static String PropertyCategoryAction
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryAction", null);
+            }
+        }
+		
+		internal static String PropertyCategoryAppearance
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryAppearance", null);
+            }
+        }
+		
+		internal static String PropertyCategoryAsynchronous
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryAsynchronous", null);
+            }
+        }
+		
+		internal static String PropertyCategoryBehavior
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryBehavior", null);
+            }
+        }
+		
+		internal static String PropertyCategoryConfig
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryConfig", null);
+            }
+        }
+		
+		internal static String PropertyCategoryData
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryData", null);
+            }
+        }
+		
+		internal static String PropertyCategoryDDE
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryDDE", null);
+            }
+        }
+		
+		internal static String PropertyCategoryDefault
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryDefault", null);
+            }
+        }
+		
+		internal static String PropertyCategoryDesign
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryDesign", null);
+            }
+        }
+		
+		internal static String PropertyCategoryDragDrop
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryDragDrop", null);
+            }
+        }
+		
+		internal static String PropertyCategoryFocus
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryFocus", null);
+            }
+        }
+		
+		internal static String PropertyCategoryFont
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryFont", null);
+            }
+        }
+		
+		internal static String PropertyCategoryFormat
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryFormat", null);
+            }
+        }
+		
+		internal static String PropertyCategoryKey
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryKey", null);
+            }
+        }
+		
+		internal static String PropertyCategoryLayout
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryLayout", null);
+            }
+        }
+		
+		internal static String PropertyCategoryList
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryList", null);
+            }
+        }
+		
+		internal static String PropertyCategoryMouse
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryMouse", null);
+            }
+        }
+		
+		internal static String PropertyCategoryPosition
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryPosition", null);
+            }
+        }
+		
+		internal static String PropertyCategoryScale
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryScale", null);
+            }
+        }
+		
+		internal static String PropertyCategoryText
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryText", null);
+            }
+        }
+		
+		internal static String PropertyCategoryWindowStyle
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCategoryWindowStyle", null);
+            }
+        }
+
+
+	private static ResourceManager ResourceManager
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
+
+        internal static Type ResourceType
+        {
+            get
+            {
+                return typeof(FxResources.System.ComponentModel.Primitives.SR);
+            }
+        }
+
+        internal static String Format(String resourceFormat, params Object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, args);
+            }
+            return String.Concat(resourceFormat, String.Join(", ", args));
+        }
+
+        internal static String Format(String resourceFormat, Object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2, p3);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static String GetResourceString(String resourceKey, String defaultString)
+        {
+            String str = null;
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
+        private static Boolean UsingResourceKeys()
+        {
+            return false;
+        }
+    }
+}
