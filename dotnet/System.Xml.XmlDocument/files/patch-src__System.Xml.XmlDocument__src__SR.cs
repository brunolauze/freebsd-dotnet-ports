--- /dev/null	2016-03-12 14:12:56.000000000 -0500
+++ src/System.Xml.XmlDocument/src/SR.cs	2016-03-12 14:13:11.069922000 -0500
@@ -0,0 +1,774 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Xml.XmlDocument
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
+        private const String s_resourcesName = "FxResources.System.Xml.XmlDocument.SR";
+
+        internal static String Arg_CannotCreateNode
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_CannotCreateNode", null);
+            }
+        }
+
+        internal static String Arg_ExpectingXmlTextReader
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ExpectingXmlTextReader", null);
+            }
+        }
+
+        internal static String Arg_IncompatibleParamType
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_IncompatibleParamType", null);
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
+                return typeof(FxResources.System.Xml.XmlDocument.SR);
+            }
+        }
+
+        internal static String Xdom_Attr_InUse
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Attr_InUse", null);
+            }
+        }
+
+        internal static String Xdom_Attr_Name
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Attr_Name", null);
+            }
+        }
+
+        internal static String Xdom_Attr_Reserved_XmlNS
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Attr_Reserved_XmlNS", null);
+            }
+        }
+
+        internal static String Xdom_AttrCol_Insert
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_AttrCol_Insert", null);
+            }
+        }
+
+        internal static String Xdom_AttrCol_Object
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_AttrCol_Object", null);
+            }
+        }
+
+        internal static String Xdom_Document_Innertext
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Document_Innertext", null);
+            }
+        }
+
+        internal static String Xdom_DualDeclarationNode
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_DualDeclarationNode", null);
+            }
+        }
+
+        internal static String Xdom_DualDocumentElementNode
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_DualDocumentElementNode", null);
+            }
+        }
+
+        internal static String Xdom_DualDocumentTypeNode
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_DualDocumentTypeNode", null);
+            }
+        }
+
+        internal static String Xdom_Ele_Prefix
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Ele_Prefix", null);
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
+        internal static String Xdom_Ent_Innertext
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Ent_Innertext", null);
+            }
+        }
+
+        internal static String Xdom_EntRef_SetVal
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_EntRef_SetVal", null);
+            }
+        }
+
+        internal static String Xdom_Enum_ElementList
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Enum_ElementList", null);
+            }
+        }
+
+        internal static String Xdom_Import
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Import", null);
+            }
+        }
+
+        internal static String Xdom_Import_NullNode
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Import_NullNode", null);
+            }
+        }
+
+        internal static String Xdom_IndexOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_IndexOutOfRange", null);
+            }
+        }
+
+        internal static String Xdom_Invalid_NT_String
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Invalid_NT_String", null);
+            }
+        }
+
+        internal static String Xdom_InvalidCharacter_EntityReference
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_InvalidCharacter_EntityReference", null);
+            }
+        }
+
+        internal static String Xdom_Load_NoDocument
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Load_NoDocument", null);
+            }
+        }
+
+        internal static String Xdom_Load_NoReader
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Load_NoReader", null);
+            }
+        }
+
+        internal static String Xdom_NamedNode_Context
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_NamedNode_Context", null);
+            }
+        }
+
+        internal static String Xdom_Node_Cloning
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Cloning", null);
+            }
+        }
+
+        internal static String Xdom_Node_Insert_Child
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Insert_Child", null);
+            }
+        }
+
+        internal static String Xdom_Node_Insert_Contain
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Insert_Contain", null);
+            }
+        }
+
+        internal static String Xdom_Node_Insert_Context
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Insert_Context", null);
+            }
+        }
+
+        internal static String Xdom_Node_Insert_Location
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Insert_Location", null);
+            }
+        }
+
+        internal static String Xdom_Node_Insert_Path
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Insert_Path", null);
+            }
+        }
+
+        internal static String Xdom_Node_Insert_TypeConflict
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Insert_TypeConflict", null);
+            }
+        }
+
+        internal static String Xdom_Node_Modify_ReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Modify_ReadOnly", null);
+            }
+        }
+
+        internal static String Xdom_Node_Null_Doc
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Null_Doc", null);
+            }
+        }
+
+        internal static String Xdom_Node_Remove_Child
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Remove_Child", null);
+            }
+        }
+
+        internal static String Xdom_Node_Remove_Contain
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_Remove_Contain", null);
+            }
+        }
+
+        internal static String Xdom_Node_SetVal
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Node_SetVal", null);
+            }
+        }
+
+        internal static String Xdom_NoRootEle
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_NoRootEle", null);
+            }
+        }
+
+        internal static String Xdom_Set_InnerXml
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Set_InnerXml", null);
+            }
+        }
+
+        internal static String Xdom_standalone
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_standalone", null);
+            }
+        }
+
+        internal static String Xdom_TextNode_SplitText
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_TextNode_SplitText", null);
+            }
+        }
+
+        internal static String Xdom_Version
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_Version", null);
+            }
+        }
+
+        internal static String Xdom_WS_Char
+        {
+            get
+            {
+                return SR.GetResourceString("Xdom_WS_Char", null);
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
+        internal static String Xml_CanNotBindToReservedNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CanNotBindToReservedNamespace", null);
+            }
+        }
+
+        internal static String Xml_Closed
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_Closed", null);
+            }
+        }
+
+        internal static String Xml_ClosedOrError
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ClosedOrError", null);
+            }
+        }
+
+        internal static String Xml_DupXmlDecl
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DupXmlDecl", null);
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
+        internal static String Xml_InvalidCDataChars
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidCDataChars", null);
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
+        internal static String Xml_InvalidCommentChars
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidCommentChars", null);
+            }
+        }
+
+        internal static String Xml_InvalidIndentation
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidIndentation", null);
+            }
+        }
+
+        internal static String Xml_InvalidNameChars
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidNameChars", null);
+            }
+        }
+
+        internal static String Xml_InvalidNameCharsDetail
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidNameCharsDetail", null);
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
+        internal static String Xml_InvalidPiChars
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidPiChars", null);
+            }
+        }
+
+        internal static String Xml_InvalidPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidPrefix", null);
+            }
+        }
+
+        internal static String Xml_InvalidQuote
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidQuote", null);
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
+        internal static String Xml_InvalidXmlSpace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidXmlSpace", null);
+            }
+        }
+
+        internal static String Xml_NoNamespaces
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NoNamespaces", null);
+            }
+        }
+
+        internal static String Xml_NonWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NonWhitespace", null);
+            }
+        }
+
+        internal static String Xml_NoRoot
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NoRoot", null);
+            }
+        }
+
+        internal static String Xml_NoStartTag
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NoStartTag", null);
+            }
+        }
+
+        internal static String Xml_NotInWriteState
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NotInWriteState", null);
+            }
+        }
+
+        internal static String Xml_NotTheFirst
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NotTheFirst", null);
+            }
+        }
+
+        internal static String Xml_NullResolver
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NullResolver", null);
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
+        internal static String Xml_RelativeUriNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_RelativeUriNotSupported", null);
+            }
+        }
+
+        internal static String Xml_SurrogatePairSplit
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_SurrogatePairSplit", null);
+            }
+        }
+
+        internal static String Xml_UndeclaredParEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UndeclaredParEntity", null);
+            }
+        }
+
+        internal static String Xml_UndefNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UndefNamespace", null);
+            }
+        }
+
+        internal static String Xml_UndefPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UndefPrefix", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedNodeType
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedNodeType", null);
+            }
+        }
+
+        internal static String Xml_UnsupportedClass
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnsupportedClass", null);
+            }
+        }
+
+        internal static String Xml_UntrustedCodeSettingResolver
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UntrustedCodeSettingResolver", null);
+            }
+        }
+
+        internal static String Xml_WrongToken
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_WrongToken", null);
+            }
+        }
+
+        internal static String Xml_XmlnsBelongsToReservedNs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_XmlnsBelongsToReservedNs", null);
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
+        internal static String XmlNonCLSCompliantException
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNonCLSCompliantException", null);
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
