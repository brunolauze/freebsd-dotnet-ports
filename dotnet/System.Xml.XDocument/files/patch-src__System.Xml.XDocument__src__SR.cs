--- /dev/null	2016-03-16 07:56:54.000000000 -0400
+++ src/System.Xml.XDocument/src/SR.cs	2016-03-16 07:59:04.462607000 -0400
@@ -0,0 +1,319 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Xml.XDocument
+{
+    internal static class SR
+    {
+
+    }
+}
+
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.Xml.XDocument.SR";
+
+        internal static String Argument_AddAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddAttribute", null);
+            }
+        }
+
+        internal static String Argument_AddNode
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddNode", null);
+            }
+        }
+
+        internal static String Argument_AddNonWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddNonWhitespace", null);
+            }
+        }
+
+        internal static String Argument_ConvertToString
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ConvertToString", null);
+            }
+        }
+
+        internal static String Argument_InvalidExpandedName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidExpandedName", null);
+            }
+        }
+
+        internal static String Argument_InvalidPIName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidPIName", null);
+            }
+        }
+
+        internal static String Argument_InvalidPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidPrefix", null);
+            }
+        }
+
+        internal static String Argument_MustBeDerivedFrom
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_MustBeDerivedFrom", null);
+            }
+        }
+
+        internal static String Argument_NamespaceDeclarationPrefixed
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NamespaceDeclarationPrefixed", null);
+            }
+        }
+
+        internal static String Argument_NamespaceDeclarationXml
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NamespaceDeclarationXml", null);
+            }
+        }
+
+        internal static String Argument_NamespaceDeclarationXmlns
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NamespaceDeclarationXmlns", null);
+            }
+        }
+
+        internal static String Argument_XObjectValue
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_XObjectValue", null);
+            }
+        }
+
+        internal static String InvalidOperation_DeserializeInstance
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_DeserializeInstance", null);
+            }
+        }
+
+        internal static String InvalidOperation_DocumentStructure
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_DocumentStructure", null);
+            }
+        }
+
+        internal static String InvalidOperation_DuplicateAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_DuplicateAttribute", null);
+            }
+        }
+
+        internal static String InvalidOperation_ExpectedEndOfFile
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ExpectedEndOfFile", null);
+            }
+        }
+
+        internal static String InvalidOperation_ExpectedInteractive
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ExpectedInteractive", null);
+            }
+        }
+
+        internal static String InvalidOperation_ExpectedNodeType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ExpectedNodeType", null);
+            }
+        }
+
+        internal static String InvalidOperation_ExternalCode
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ExternalCode", null);
+            }
+        }
+
+        internal static String InvalidOperation_MissingAncestor
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_MissingAncestor", null);
+            }
+        }
+
+        internal static String InvalidOperation_MissingParent
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_MissingParent", null);
+            }
+        }
+
+        internal static String InvalidOperation_MissingRoot
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_MissingRoot", null);
+            }
+        }
+
+        internal static String InvalidOperation_UnexpectedNodeType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_UnexpectedNodeType", null);
+            }
+        }
+
+        internal static String InvalidOperation_UnresolvedEntityReference
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_UnresolvedEntityReference", null);
+            }
+        }
+
+        internal static String InvalidOperation_WriteAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_WriteAttribute", null);
+            }
+        }
+
+        internal static String NotSupported_WriteBase64
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_WriteBase64", null);
+            }
+        }
+
+        internal static String NotSupported_WriteEntityRef
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_WriteEntityRef", null);
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
+                return typeof(FxResources.System.Xml.XDocument.SR);
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
