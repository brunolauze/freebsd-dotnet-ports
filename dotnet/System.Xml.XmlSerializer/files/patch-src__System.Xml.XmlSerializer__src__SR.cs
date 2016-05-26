--- /dev/null	2016-05-13 06:33:00.000000000 -0400
+++ src/System.Xml.XmlSerializer/src/SR.cs	2016-05-13 06:32:46.644012000 -0400
@@ -0,0 +1,1646 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Xml.XmlSerializer
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
+        private const String s_resourcesName = "FxResources.System.Xml.XmlSerializer.SR";
+
+	internal static string Arg_RemoveArgNotFound
+	{
+	    get
+	    {
+		return SR.GetResourceString("Arg_RemoveArgNotFound", null);
+	    }
+	}
+
+        internal static String Arg_NeverValueType
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_NeverValueType", null);
+            }
+        }
+
+        internal static String ArrayTypeIsNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ArrayTypeIsNotSupported", null);
+            }
+        }
+
+        internal static String IsNotAssignableFrom
+        {
+            get
+            {
+                return SR.GetResourceString("IsNotAssignableFrom", null);
+            }
+        }
+
+        internal static String NoConversionPossibleTo
+        {
+            get
+            {
+                return SR.GetResourceString("NoConversionPossibleTo", null);
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
+                return typeof(FxResources.System.Xml.XmlSerializer.SR);
+            }
+        }
+
+        internal static String SFxBodyObjectTypeCannotBeInherited
+        {
+            get
+            {
+                return SR.GetResourceString("SFxBodyObjectTypeCannotBeInherited", null);
+            }
+        }
+
+        internal static String SFxBodyObjectTypeCannotBeInterface
+        {
+            get
+            {
+                return SR.GetResourceString("SFxBodyObjectTypeCannotBeInterface", null);
+            }
+        }
+
+        internal static String SFxErrorDeserializingReplyBody
+        {
+            get
+            {
+                return SR.GetResourceString("SFxErrorDeserializingReplyBody", null);
+            }
+        }
+
+        internal static String SFxErrorDeserializingRequestBody
+        {
+            get
+            {
+                return SR.GetResourceString("SFxErrorDeserializingRequestBody", null);
+            }
+        }
+
+        internal static String SFxErrorSerializingBody
+        {
+            get
+            {
+                return SR.GetResourceString("SFxErrorSerializingBody", null);
+            }
+        }
+
+        internal static String SFxFaultTypeAnonymous
+        {
+            get
+            {
+                return SR.GetResourceString("SFxFaultTypeAnonymous", null);
+            }
+        }
+
+        internal static String SFxInvalidXmlAttributeInBare
+        {
+            get
+            {
+                return SR.GetResourceString("SFxInvalidXmlAttributeInBare", null);
+            }
+        }
+
+        internal static String SFxInvalidXmlAttributeInWrapped
+        {
+            get
+            {
+                return SR.GetResourceString("SFxInvalidXmlAttributeInWrapped", null);
+            }
+        }
+
+        internal static String SFxKnownTypeNull
+        {
+            get
+            {
+                return SR.GetResourceString("SFxKnownTypeNull", null);
+            }
+        }
+
+        internal static String SFxRpcMessageMustHaveASingleBody
+        {
+            get
+            {
+                return SR.GetResourceString("SFxRpcMessageMustHaveASingleBody", null);
+            }
+        }
+
+        internal static String SFxXmlArrayNotAllowedForMultiple
+        {
+            get
+            {
+                return SR.GetResourceString("SFxXmlArrayNotAllowedForMultiple", null);
+            }
+        }
+
+        internal static String UnknownConstantType
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownConstantType", null);
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
+        internal static String Xml_InvalidNameChars
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidNameChars", null);
+            }
+        }
+
+        internal static String Xml_InvalidNmToken
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidNmToken", null);
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
+        internal static String Xml_MissingSerializationCodeException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MissingSerializationCodeException", null);
+            }
+        }
+
+        internal static String XmlAbstractType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlAbstractType", null);
+            }
+        }
+
+        internal static String XmlAnonymousInclude
+        {
+            get
+            {
+                return SR.GetResourceString("XmlAnonymousInclude", null);
+            }
+        }
+
+        internal static String XmlAnyElementDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlAnyElementDuplicate", null);
+            }
+        }
+
+        internal static String XmlArrayItemAmbiguousTypes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlArrayItemAmbiguousTypes", null);
+            }
+        }
+
+        internal static String XmlAttributeSetAgain
+        {
+            get
+            {
+                return SR.GetResourceString("XmlAttributeSetAgain", null);
+            }
+        }
+
+        internal static String XmlCannotReconcileAccessor
+        {
+            get
+            {
+                return SR.GetResourceString("XmlCannotReconcileAccessor", null);
+            }
+        }
+
+        internal static String XmlCannotReconcileAccessorDefault
+        {
+            get
+            {
+                return SR.GetResourceString("XmlCannotReconcileAccessorDefault", null);
+            }
+        }
+
+        internal static String XmlCannotReconcileAttributeAccessor
+        {
+            get
+            {
+                return SR.GetResourceString("XmlCannotReconcileAttributeAccessor", null);
+            }
+        }
+
+        internal static String XmlChoiceIdDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdDuplicate", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentiferAmbiguous
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentiferAmbiguous", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentiferMemberMissing
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentiferMemberMissing", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentiferMissing
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentiferMissing", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentifierArrayType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentifierArrayType", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentifierMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentifierMismatch", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentifierType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentifierType", null);
+            }
+        }
+
+        internal static String XmlChoiceIdentifierTypeEnum
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceIdentifierTypeEnum", null);
+            }
+        }
+
+        internal static String XmlChoiceMismatchChoiceException
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceMismatchChoiceException", null);
+            }
+        }
+
+        internal static String XmlChoiceMissingAnyValue
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceMissingAnyValue", null);
+            }
+        }
+
+        internal static String XmlChoiceMissingValue
+        {
+            get
+            {
+                return SR.GetResourceString("XmlChoiceMissingValue", null);
+            }
+        }
+
+        internal static String XmlCircularReference
+        {
+            get
+            {
+                return SR.GetResourceString("XmlCircularReference", null);
+            }
+        }
+
+        internal static String XmlConstructorHasSecurityAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConstructorHasSecurityAttributes", null);
+            }
+        }
+
+        internal static String XmlConstructorInaccessible
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConstructorInaccessible", null);
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
+        internal static String XmlDataTypeMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDataTypeMismatch", null);
+            }
+        }
+
+        internal static String XmlDisallowNegativeValues
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDisallowNegativeValues", null);
+            }
+        }
+
+        internal static String XmlDuplicateAttributeName
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDuplicateAttributeName", null);
+            }
+        }
+
+        internal static String XmlDuplicateElementName
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDuplicateElementName", null);
+            }
+        }
+
+        internal static String XmlDuplicateNs
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDuplicateNs", null);
+            }
+        }
+
+        internal static String XmlElementNameMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("XmlElementNameMismatch", null);
+            }
+        }
+
+        internal static String XmlFieldReflectionError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFieldReflectionError", null);
+            }
+        }
+
+        internal static String XmlGenError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlGenError", null);
+            }
+        }
+
+        internal static String XmlGetSchemaEmptyTypeName
+        {
+            get
+            {
+                return SR.GetResourceString("XmlGetSchemaEmptyTypeName", null);
+            }
+        }
+
+        internal static String XmlGetSchemaMethodMissing
+        {
+            get
+            {
+                return SR.GetResourceString("XmlGetSchemaMethodMissing", null);
+            }
+        }
+
+        internal static String XmlGetSchemaMethodName
+        {
+            get
+            {
+                return SR.GetResourceString("XmlGetSchemaMethodName", null);
+            }
+        }
+
+        internal static String XmlGetSchemaMethodReturnType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlGetSchemaMethodReturnType", null);
+            }
+        }
+
+        internal static String XmlHiddenMember
+        {
+            get
+            {
+                return SR.GetResourceString("XmlHiddenMember", null);
+            }
+        }
+
+        internal static String XmlIllegalAnyElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalAnyElement", null);
+            }
+        }
+
+        internal static String XmlIllegalArrayArrayAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalArrayArrayAttribute", null);
+            }
+        }
+
+        internal static String XmlIllegalArrayTextAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalArrayTextAttribute", null);
+            }
+        }
+
+        internal static String XmlIllegalAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalAttribute", null);
+            }
+        }
+
+        internal static String XmlIllegalAttributeFlagsArray
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalAttributeFlagsArray", null);
+            }
+        }
+
+        internal static String XmlIllegalAttributesArrayAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalAttributesArrayAttribute", null);
+            }
+        }
+
+        internal static String XmlIllegalAttrOrText
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalAttrOrText", null);
+            }
+        }
+
+        internal static String XmlIllegalAttrOrTextInterface
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalAttrOrTextInterface", null);
+            }
+        }
+
+        internal static String XmlIllegalElementsArrayAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalElementsArrayAttribute", null);
+            }
+        }
+
+        internal static String XmlIllegalMultipleText
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalMultipleText", null);
+            }
+        }
+
+        internal static String XmlIllegalMultipleTextMembers
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalMultipleTextMembers", null);
+            }
+        }
+
+        internal static String XmlIllegalSimpleContentExtension
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalSimpleContentExtension", null);
+            }
+        }
+
+        internal static String XmlIllegalSoapAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalSoapAttribute", null);
+            }
+        }
+
+        internal static String XmlIllegalType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalType", null);
+            }
+        }
+
+        internal static String XmlIllegalTypeContext
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalTypeContext", null);
+            }
+        }
+
+        internal static String XmlIllegalTypedTextAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalTypedTextAttribute", null);
+            }
+        }
+
+        internal static String XmlInternalError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInternalError", null);
+            }
+        }
+
+        internal static String XmlInternalErrorDetails
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInternalErrorDetails", null);
+            }
+        }
+
+        internal static String XmlInternalErrorMethod
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInternalErrorMethod", null);
+            }
+        }
+
+        internal static String XmlInvalidArrayLength
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidArrayLength", null);
+            }
+        }
+
+        internal static String XmlInvalidArrayTypeSyntax
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidArrayTypeSyntax", null);
+            }
+        }
+
+        internal static String XmlInvalidAttributeType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidAttributeType", null);
+            }
+        }
+
+        internal static String XmlInvalidAttributeUse
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidAttributeUse", null);
+            }
+        }
+
+        internal static String XmlInvalidCast
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidCast", null);
+            }
+        }
+
+        internal static String XmlInvalidCastWithId
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidCastWithId", null);
+            }
+        }
+
+        internal static String XmlInvalidCharSchemaPrimitive
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidCharSchemaPrimitive", null);
+            }
+        }
+
+        internal static String XmlInvalidChoiceIdentifierValue
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidChoiceIdentifierValue", null);
+            }
+        }
+
+        internal static String XmlInvalidConstantAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidConstantAttribute", null);
+            }
+        }
+
+        internal static String XmlInvalidDataTypeUsage
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidDataTypeUsage", null);
+            }
+        }
+
+        internal static String XmlInvalidDefaultValue
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidDefaultValue", null);
+            }
+        }
+
+        internal static String XmlInvalidEncoding3
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidEncoding3", null);
+            }
+        }
+
+        internal static String XmlInvalidEncodingNotEncoded1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidEncodingNotEncoded1", null);
+            }
+        }
+
+        internal static String XmlInvalidFormUnqualified
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidFormUnqualified", null);
+            }
+        }
+
+        internal static String XmlInvalidIdentifier
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidIdentifier", null);
+            }
+        }
+
+        internal static String XmlInvalidIsNullable
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidIsNullable", null);
+            }
+        }
+
+        internal static String XmlInvalidNotNullable
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidNotNullable", null);
+            }
+        }
+
+        internal static String XmlInvalidNullCast
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidNullCast", null);
+            }
+        }
+
+        internal static String XmlInvalidReturnPosition
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidReturnPosition", null);
+            }
+        }
+
+        internal static String XmlInvalidSerializable
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidSerializable", null);
+            }
+        }
+
+        internal static String XmlInvalidSpecifiedType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidSpecifiedType", null);
+            }
+        }
+
+        internal static String XmlInvalidTypeAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidTypeAttributes", null);
+            }
+        }
+
+        internal static String XmlInvalidUseOfType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidUseOfType", null);
+            }
+        }
+
+        internal static String XmlInvalidXmlns
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidXmlns", null);
+            }
+        }
+
+        internal static String XmlInvalidXmlOverride
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidXmlOverride", null);
+            }
+        }
+
+        internal static String XmlInvalidXsdDataType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidXsdDataType", null);
+            }
+        }
+
+        internal static String XmlMelformMapping
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMelformMapping", null);
+            }
+        }
+
+        internal static String XmlMethodTypeNameConflict
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMethodTypeNameConflict", null);
+            }
+        }
+
+        internal static String XmlMissingMethodEnum
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMissingMethodEnum", null);
+            }
+        }
+
+        internal static String XmlMissingType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMissingType", null);
+            }
+        }
+
+        internal static String XmlMultipleAttributeOverrides
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMultipleAttributeOverrides", null);
+            }
+        }
+
+        internal static String XmlMultipleXmlns
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMultipleXmlns", null);
+            }
+        }
+
+        internal static String XmlMultipleXmlnsMembers
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMultipleXmlnsMembers", null);
+            }
+        }
+
+        internal static String XmlNeedAttributeHere
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNeedAttributeHere", null);
+            }
+        }
+
+        internal static String XmlNoAddMethod
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoAddMethod", null);
+            }
+        }
+
+        internal static String XmlNoAttributeHere
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoAttributeHere", null);
+            }
+        }
+
+        internal static String XmlNoDefaultAccessors
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoDefaultAccessors", null);
+            }
+        }
+
+        internal static String XmlNoPartialTrust
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoPartialTrust", null);
+            }
+        }
+
+        internal static String XmlNoSerializableMembers
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoSerializableMembers", null);
+            }
+        }
+
+        internal static String XmlNotSerializable
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNotSerializable", null);
+            }
+        }
+
+        internal static String XmlPropertyReflectionError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlPropertyReflectionError", null);
+            }
+        }
+
+        internal static String XmlReadOnlyCollection
+        {
+            get
+            {
+                return SR.GetResourceString("XmlReadOnlyCollection", null);
+            }
+        }
+
+        internal static String XmlReadOnlyPropertyError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlReadOnlyPropertyError", null);
+            }
+        }
+
+        internal static String XmlReflectionError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlReflectionError", null);
+            }
+        }
+
+        internal static String XmlRpcLitArrayElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitArrayElement", null);
+            }
+        }
+
+        internal static String XmlRpcLitAttributeAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitAttributeAttributes", null);
+            }
+        }
+
+        internal static String XmlRpcLitAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitAttributes", null);
+            }
+        }
+
+        internal static String XmlRpcLitElementNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitElementNamespace", null);
+            }
+        }
+
+        internal static String XmlRpcLitElementNullable
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitElementNullable", null);
+            }
+        }
+
+        internal static String XmlRpcLitElements
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitElements", null);
+            }
+        }
+
+        internal static String XmlRpcLitXmlns
+        {
+            get
+            {
+                return SR.GetResourceString("XmlRpcLitXmlns", null);
+            }
+        }
+
+        internal static String XmlS_AttributeAsElement_2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_AttributeAsElement_2", null);
+            }
+        }
+
+        internal static String XmlS_BadArrayType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_BadArrayType_1", null);
+            }
+        }
+
+        internal static String XmlS_CircularRef_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_CircularRef_1", null);
+            }
+        }
+
+        internal static String XmlS_CollNoAdd_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_CollNoAdd_1", null);
+            }
+        }
+
+        internal static String XmlS_DataTypeNotValid_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_DataTypeNotValid_1", null);
+            }
+        }
+
+        internal static String XmlS_ElementAsAttribute_2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_ElementAsAttribute_2", null);
+            }
+        }
+
+        internal static String XmlS_IEnumNoAdd_3
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_IEnumNoAdd_3", null);
+            }
+        }
+
+        internal static String XmlS_IllegalAttrType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_IllegalAttrType_1", null);
+            }
+        }
+
+        internal static String XmlS_IllegalChoiceDirection
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_IllegalChoiceDirection", null);
+            }
+        }
+
+        internal static String XmlS_IllegalDataType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_IllegalDataType_1", null);
+            }
+        }
+
+        internal static String XmlS_IllegalSequenceType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_IllegalSequenceType_1", null);
+            }
+        }
+
+        internal static String XmlS_IllegalTextType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_IllegalTextType_1", null);
+            }
+        }
+
+        internal static String XmlS_InvalidHref_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_InvalidHref_1", null);
+            }
+        }
+
+        internal static String XmlS_MissingEnum_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_MissingEnum_1", null);
+            }
+        }
+
+        internal static String XmlS_NoArrayEltAcc_2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_NoArrayEltAcc_2", null);
+            }
+        }
+
+        internal static String XmlS_NoRepeatingAccessor_2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_NoRepeatingAccessor_2", null);
+            }
+        }
+
+        internal static String XmlS_RepeatedIdentifier_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_RepeatedIdentifier_1", null);
+            }
+        }
+
+        internal static String XmlS_TwoDefaultXmlAny
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_TwoDefaultXmlAny", null);
+            }
+        }
+
+        internal static String XmlS_TwoMappings_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_TwoMappings_1", null);
+            }
+        }
+
+        internal static String XmlS_TwoXmlAny_2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_TwoXmlAny_2", null);
+            }
+        }
+
+        internal static String XmlS_UnknownAccessor_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_UnknownAccessor_1", null);
+            }
+        }
+
+        internal static String XmlS_UnknownEnum_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_UnknownEnum_1", null);
+            }
+        }
+
+        internal static String XmlS_UnknownID_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_UnknownID_1", null);
+            }
+        }
+
+        internal static String XmlS_UnknownPrefix_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_UnknownPrefix_1", null);
+            }
+        }
+
+        internal static String XmlS_WrongXAAAType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_WrongXAAAType_1", null);
+            }
+        }
+
+        internal static String XmlS_WrongXAEAType_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_WrongXAEAType_1", null);
+            }
+        }
+
+        internal static String XmlS_XmlInvalidCast_2
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_XmlInvalidCast_2", null);
+            }
+        }
+
+        internal static String XmlS_XNDANotXSN_1
+        {
+            get
+            {
+                return SR.GetResourceString("XmlS_XNDANotXSN_1", null);
+            }
+        }
+
+        internal static String XmlSequenceHierarchy
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSequenceHierarchy", null);
+            }
+        }
+
+        internal static String XmlSequenceInconsistent
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSequenceInconsistent", null);
+            }
+        }
+
+        internal static String XmlSequenceMatch
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSequenceMatch", null);
+            }
+        }
+
+        internal static String XmlSequenceMembers
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSequenceMembers", null);
+            }
+        }
+
+        internal static String XmlSequenceUnique
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSequenceUnique", null);
+            }
+        }
+
+        internal static String XmlSerializableAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializableAttributes", null);
+            }
+        }
+
+        internal static String XmlSerializableBadDerivation
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializableBadDerivation", null);
+            }
+        }
+
+        internal static String XmlSerializableMissingClrType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializableMissingClrType", null);
+            }
+        }
+
+        internal static String XmlSerializeError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializeError", null);
+            }
+        }
+
+        internal static String XmlSerializeErrorDetails
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializeErrorDetails", null);
+            }
+        }
+
+        internal static String XmlSerializerUnsupportedMember
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializerUnsupportedMember", null);
+            }
+        }
+
+        internal static String XmlSerializerUnsupportedType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSerializerUnsupportedType", null);
+            }
+        }
+
+        internal static String XmlSoleXmlnsAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSoleXmlnsAttribute", null);
+            }
+        }
+
+        internal static String XmlTypeInaccessible
+        {
+            get
+            {
+                return SR.GetResourceString("XmlTypeInaccessible", null);
+            }
+        }
+
+        internal static String XmlTypeReflectionError
+        {
+            get
+            {
+                return SR.GetResourceString("XmlTypeReflectionError", null);
+            }
+        }
+
+        internal static String XmlTypesDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlTypesDuplicate", null);
+            }
+        }
+
+        internal static String XmlTypeStatic
+        {
+            get
+            {
+                return SR.GetResourceString("XmlTypeStatic", null);
+            }
+        }
+
+        internal static String XmlUdeclaredXsdType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUdeclaredXsdType", null);
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
+        internal static String XmlUnexpectedType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnexpectedType", null);
+            }
+        }
+
+        internal static String XmlUnknownAnyElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnknownAnyElement", null);
+            }
+        }
+
+        internal static String XmlUnknownConstant
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnknownConstant", null);
+            }
+        }
+
+        internal static String XmlUnknownNode
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnknownNode", null);
+            }
+        }
+
+        internal static String XmlUnknownType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnknownType", null);
+            }
+        }
+
+        internal static String XmlUnsupportedIDictionary
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedIDictionary", null);
+            }
+        }
+
+        internal static String XmlUnsupportedIDictionaryDetails
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedIDictionaryDetails", null);
+            }
+        }
+
+        internal static String XmlUnsupportedInheritance
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedInheritance", null);
+            }
+        }
+
+        internal static String XmlUnsupportedInterface
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedInterface", null);
+            }
+        }
+
+        internal static String XmlUnsupportedInterfaceDetails
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedInterfaceDetails", null);
+            }
+        }
+
+        internal static String XmlUnsupportedOpenGenericType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedOpenGenericType", null);
+            }
+        }
+
+        internal static String XmlUnsupportedRank
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedRank", null);
+            }
+        }
+
+        internal static String XmlUnsupportedSoapTypeKind
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedSoapTypeKind", null);
+            }
+        }
+
+        internal static String XmlUnsupportedType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedType", null);
+            }
+        }
+
+        internal static String XmlUnsupportedTypeKind
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnsupportedTypeKind", null);
+            }
+        }
+
+        internal static String XmlUnxpectedType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnxpectedType", null);
+            }
+        }
+
+        internal static String XmlXmlnsInvalidType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlXmlnsInvalidType", null);
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
