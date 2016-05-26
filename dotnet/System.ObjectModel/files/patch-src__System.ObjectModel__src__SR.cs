--- /dev/null	2016-03-07 14:47:24.000000000 -0500
+++ src/System.ObjectModel/src/SR.cs	2016-03-07 14:47:39.218804000 -0500
@@ -0,0 +1,222 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.ObjectModel
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
+        private const String s_resourcesName = "FxResources.System.ObjectModel.SR";
+
+        internal static String Arg_ArrayPlusOffTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ArrayPlusOffTooSmall", null);
+            }
+        }
+
+        internal static String Arg_NonZeroLowerBound
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_NonZeroLowerBound", null);
+            }
+        }
+
+        internal static String Arg_RankMultiDimNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RankMultiDimNotSupported", null);
+            }
+        }
+
+        internal static String Argument_AddingDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddingDuplicate", null);
+            }
+        }
+
+        internal static String Argument_InvalidArrayType
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidArrayType", null);
+            }
+        }
+
+        internal static String Argument_ItemNotExist
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ItemNotExist", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_InvalidThreshold
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_InvalidThreshold", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static String IndexCannotBeNegative
+        {
+            get
+            {
+                return SR.GetResourceString("IndexCannotBeNegative", null);
+            }
+        }
+
+        internal static String MustBeResetAddOrRemoveActionForCtor
+        {
+            get
+            {
+                return SR.GetResourceString("MustBeResetAddOrRemoveActionForCtor", null);
+            }
+        }
+
+        internal static String NotSupported_ReadOnlyCollection
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_ReadOnlyCollection", null);
+            }
+        }
+
+        internal static String ObservableCollectionReentrancyNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("ObservableCollectionReentrancyNotAllowed", null);
+            }
+        }
+
+        internal static String ResetActionRequiresIndexMinus1
+        {
+            get
+            {
+                return SR.GetResourceString("ResetActionRequiresIndexMinus1", null);
+            }
+        }
+
+        internal static String ResetActionRequiresNullItem
+        {
+            get
+            {
+                return SR.GetResourceString("ResetActionRequiresNullItem", null);
+            }
+        }
+
+        private static ResourceManager ResourceManager
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
+        internal static Type ResourceType
+        {
+            get
+            {
+                return typeof(FxResources.System.ObjectModel.SR);
+            }
+        }
+
+        internal static String WrongActionForCtor
+        {
+            get
+            {
+                return SR.GetResourceString("WrongActionForCtor", null);
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
