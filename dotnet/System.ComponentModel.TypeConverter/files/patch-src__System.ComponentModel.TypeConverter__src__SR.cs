--- /dev/null	2016-05-17 06:55:00.000000000 -0400
+++ src/System.ComponentModel.TypeConverter/src/SR.cs	2016-05-17 06:57:34.623082000 -0400
@@ -0,0 +1,303 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.ComponentModel.TypeConverter
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
+        private const String s_resourcesName = "FxResources.System.ComponentModel.TypeConverter.SR";
+
+		internal static String TypeDescriptorProviderError
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDescriptorProviderError", null);
+            }
+        }
+		
+		internal static String TypeDescriptorArgsCountMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDescriptorArgsCountMismatch", null);
+            }
+        }
+		
+		internal static String TypeDescriptorExpectedElementType
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDescriptorExpectedElementType", null);
+            }
+        }
+		
+		internal static String TypeDescriptorUnsupportedRemoteObject
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDescriptorUnsupportedRemoteObject", null);
+            }
+        }
+		
+		internal static String TypeDescriptorAlreadyAssociated
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDescriptorAlreadyAssociated", null);
+            }
+        }
+		
+		internal static String TypeDescriptorSameAssociation
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDescriptorSameAssociation", null);
+            }
+        }
+		
+		internal static String ErrorPropertyAccessorException
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorPropertyAccessorException", null);
+            }
+        }
+		
+		internal static String ErrorMissingPropertyAccessors
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorMissingPropertyAccessors", null);
+            }
+        }
+		
+		internal static String ErrorMissingEventAccessors
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorMissingEventAccessors", null);
+            }
+        }
+		
+		internal static String ErrorInvalidEventHandler
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorInvalidEventHandler", null);
+            }
+        }
+		
+		internal static String ErrorInvalidEventType
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorInvalidEventType", null);
+            }
+        }
+		
+		internal static String MetaExtenderName
+        {
+            get
+            {
+                return SR.GetResourceString("MetaExtenderName", null);
+            }
+        }
+		
+		internal static String ErrorInvalidPropertyType
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorInvalidPropertyType", null);
+            }
+        }
+		
+		internal static String InvalidNullArgument
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidNullArgument", null);
+            }
+        }
+		
+		
+        internal static String Array
+        {
+            get
+            {
+                return SR.GetResourceString("Array", null);
+            }
+        }
+
+        internal static String Collection
+        {
+            get
+            {
+                return SR.GetResourceString("Collection", null);
+            }
+        }
+
+        internal static String ConvertFromException
+        {
+            get
+            {
+                return SR.GetResourceString("ConvertFromException", null);
+            }
+        }
+
+        internal static String ConvertInvalidPrimitive
+        {
+            get
+            {
+                return SR.GetResourceString("ConvertInvalidPrimitive", null);
+            }
+        }
+
+        internal static String ConvertToException
+        {
+            get
+            {
+                return SR.GetResourceString("ConvertToException", null);
+            }
+        }
+
+        internal static String EnumConverterInvalidValue
+        {
+            get
+            {
+                return SR.GetResourceString("EnumConverterInvalidValue", null);
+            }
+        }
+
+        internal static String InvalidMemberName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidMemberName", null);
+            }
+        }
+
+        internal static String none
+        {
+            get
+            {
+                return SR.GetResourceString("none", null);
+            }
+        }
+
+        internal static String Null
+        {
+            get
+            {
+                return SR.GetResourceString("Null", null);
+            }
+        }
+
+        internal static String NullableConverterBadCtorArg
+        {
+            get
+            {
+                return SR.GetResourceString("NullableConverterBadCtorArg", null);
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
+                return typeof(FxResources.System.ComponentModel.TypeConverter.SR);
+            }
+        }
+
+        internal static String Text
+        {
+            get
+            {
+                return SR.GetResourceString("Text", null);
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
+                return String.Format(resourceFormat, new Object[] { p1 });
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, new Object[] { p1, p2 });
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, new Object[] { p1, p2, p3 });
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
+            if (defaultString != null && resourceKey.Equals(str, StringComparison.Ordinal))
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
