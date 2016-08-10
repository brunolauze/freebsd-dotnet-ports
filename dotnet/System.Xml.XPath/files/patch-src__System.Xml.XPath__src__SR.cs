--- /dev/null	2016-08-04 17:45:37.000000000 -0400
+++ src/System.Xml.XPath/src/SR.cs	2016-08-04 17:50:08.918579000 -0400
@@ -0,0 +1,558 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Xml.XPath
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
+        private const String s_resourcesName = "FxResources.System.Xml.XPath.SR";
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
+                return typeof(FxResources.System.Xml.XPath.SR);
+            }
+        }
+
+        internal static String Sch_EnumFinished
+        {
+            get
+            {
+                return SR.GetResourceString("Sch_EnumFinished", null);
+            }
+        }
+
+        internal static String Sch_EnumNotStarted
+        {
+            get
+            {
+                return SR.GetResourceString("Sch_EnumNotStarted", null);
+            }
+        }
+
+        internal static String Sch_XsdDateTimeCompare
+        {
+            get
+            {
+                return SR.GetResourceString("Sch_XsdDateTimeCompare", null);
+            }
+        }
+
+        internal static String Xdom_Empty_LocalName
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Empty_LocalName", null);
+            }
+        }
+
+        internal static String Xml_BadNameChar
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadNameChar", null);
+            }
+        }
+
+        internal static String Xml_BadStartNameChar
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadStartNameChar", null);
+            }
+        }
+
+        internal static String Xml_EmptyName
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_EmptyName", null);
+            }
+        }
+
+        internal static String Xml_ErrorPosition
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ErrorPosition", null);
+            }
+        }
+
+        internal static String Xml_InvalidBase64Value
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidBase64Value", null);
+            }
+        }
+
+        internal static String Xml_InvalidBinHexValue
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidBinHexValue", null);
+            }
+        }
+
+        internal static String Xml_InvalidBinHexValueOddCount
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidBinHexValueOddCount", null);
+            }
+        }
+
+        internal static String Xml_InvalidCharacter
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidCharacter", null);
+            }
+        }
+
+        internal static String Xml_InvalidNodeType
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidNodeType", null);
+            }
+        }
+
+        internal static String Xml_InvalidOperation
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidOperation", null);
+            }
+        }
+
+        internal static String Xml_InvalidPIName
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidPIName", null);
+            }
+        }
+
+        internal static String Xml_InvalidReadContentAs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidReadContentAs", null);
+            }
+        }
+
+        internal static String Xml_InvalidReadElementContentAs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidReadElementContentAs", null);
+            }
+        }
+
+        internal static String Xml_InvalidSurrogateHighChar
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidSurrogateHighChar", null);
+            }
+        }
+
+        internal static String Xml_InvalidSurrogateMissingLowChar
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidSurrogateMissingLowChar", null);
+            }
+        }
+
+        internal static String Xml_InvalidSurrogatePairWithArgs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidSurrogatePairWithArgs", null);
+            }
+        }
+
+        internal static String Xml_MessageWithErrorPosition
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MessageWithErrorPosition", null);
+            }
+        }
+
+        internal static String Xml_MixingBinaryContentMethods
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MixingBinaryContentMethods", null);
+            }
+        }
+
+        internal static String Xml_NamespaceDeclXmlXmlns
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NamespaceDeclXmlXmlns", null);
+            }
+        }
+
+        internal static String Xml_PrefixForEmptyNs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_PrefixForEmptyNs", null);
+            }
+        }
+
+        internal static String Xml_UnknownResourceString
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnknownResourceString", null);
+            }
+        }
+
+        internal static String Xml_XmlnsPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_XmlnsPrefix", null);
+            }
+        }
+
+        internal static String Xml_XmlPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_XmlPrefix", null);
+            }
+        }
+
+        internal static String XmlBadName
+        {
+            get
+            {
+                return SR.GetResourceString("XmlBadName", null);
+            }
+        }
+
+        internal static String XmlConvert_BadFormat
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_BadFormat", null);
+            }
+        }
+
+        internal static String XmlConvert_Overflow
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_Overflow", null);
+            }
+        }
+
+        internal static String XmlConvert_TypeFromString
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_TypeFromString", null);
+            }
+        }
+
+        internal static String XmlConvert_TypeListBadMapping
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_TypeListBadMapping", null);
+            }
+        }
+
+        internal static String XmlConvert_TypeListBadMapping2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_TypeListBadMapping2", null);
+            }
+        }
+
+        internal static String XmlConvert_TypeNoNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_TypeNoNamespace", null);
+            }
+        }
+
+        internal static String XmlConvert_TypeNoPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_TypeNoPrefix", null);
+            }
+        }
+
+        internal static String XmlConvert_TypeToString
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_TypeToString", null);
+            }
+        }
+
+        internal static String XmlNoNameAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoNameAllowed", null);
+            }
+        }
+
+        internal static String XmlUndefinedAlias
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUndefinedAlias", null);
+            }
+        }
+
+        internal static String Xp_BadQueryObject
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_BadQueryObject", null);
+            }
+        }
+
+        internal static String Xp_CurrentNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_CurrentNotAllowed", null);
+            }
+        }
+
+        internal static String Xp_ExprExpected
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_ExprExpected", null);
+            }
+        }
+
+        internal static String Xp_FunctionFailed
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_FunctionFailed", null);
+            }
+        }
+
+        internal static String Xp_InvalidArgumentType
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_InvalidArgumentType", null);
+            }
+        }
+
+        internal static String Xp_InvalidKeyPattern
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_InvalidKeyPattern", null);
+            }
+        }
+
+        internal static String Xp_InvalidName
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_InvalidName", null);
+            }
+        }
+
+        internal static String Xp_InvalidNumArgs
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_InvalidNumArgs", null);
+            }
+        }
+
+        internal static String Xp_InvalidPattern
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_InvalidPattern", null);
+            }
+        }
+
+        internal static String Xp_InvalidToken
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_InvalidToken", null);
+            }
+        }
+
+        internal static String Xp_NoContext
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_NoContext", null);
+            }
+        }
+
+        internal static String Xp_NodeSetExpected
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_NodeSetExpected", null);
+            }
+        }
+
+        internal static String Xp_NotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_NotSupported", null);
+            }
+        }
+
+        internal static String Xp_QueryTooComplex
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_QueryTooComplex", null);
+            }
+        }
+
+        internal static String Xp_UnclosedString
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_UnclosedString", null);
+            }
+        }
+
+        internal static String Xp_UndefFunc
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_UndefFunc", null);
+            }
+        }
+
+        internal static String Xp_UndefinedXsltContext
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_UndefinedXsltContext", null);
+            }
+        }
+
+        internal static String Xp_UndefVar
+        {
+            get
+            {
+                return SR.GetResourceString("Xp_UndefVar", null);
+            }
+        }
+
+        internal static String Xpn_BadPosition
+        {
+            get
+            {
+                return SR.GetResourceString("Xpn_BadPosition", null);
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
