--- /dev/null	2016-05-12 17:24:12.000000000 -0400
+++ src/System.Private.DataContractSerialization/src/SR.cs	2016-05-12 17:24:37.996931000 -0400
@@ -0,0 +1,2718 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Private.DataContractSerialization
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
+        private const String s_resourcesName = "FxResources.System.Private.DataContractSerialization.SR";
+
+        internal static String ArrayExceededSize
+        {
+            get
+            {
+                return SR.GetResourceString("ArrayExceededSize", null);
+            }
+        }
+
+        internal static String ArrayExceededSizeAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("ArrayExceededSizeAttribute", null);
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
+        internal static String AssemblyNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("AssemblyNotFound", null);
+            }
+        }
+
+        internal static String AttributedTypesCannotInheritFromNonAttributedSerializableTypes
+        {
+            get
+            {
+                return SR.GetResourceString("AttributedTypesCannotInheritFromNonAttributedSerializableTypes", null);
+            }
+        }
+
+        internal static String AttributeNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("AttributeNotFound", null);
+            }
+        }
+
+        internal static String CallbackMustReturnVoid
+        {
+            get
+            {
+                return SR.GetResourceString("CallbackMustReturnVoid", null);
+            }
+        }
+
+        internal static String CallbackParameterInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("CallbackParameterInvalid", null);
+            }
+        }
+
+        internal static String CallbacksCannotBeVirtualMethods
+        {
+            get
+            {
+                return SR.GetResourceString("CallbacksCannotBeVirtualMethods", null);
+            }
+        }
+
+        internal static String CannotDeserializeRefAtTopLevel
+        {
+            get
+            {
+                return SR.GetResourceString("CannotDeserializeRefAtTopLevel", null);
+            }
+        }
+
+        internal static String CannotLoadMemberType
+        {
+            get
+            {
+                return SR.GetResourceString("CannotLoadMemberType", null);
+            }
+        }
+
+        internal static String CannotSerializeObjectWithCycles
+        {
+            get
+            {
+                return SR.GetResourceString("CannotSerializeObjectWithCycles", null);
+            }
+        }
+
+        internal static String CanOnlyStoreIntoArgOrLocGot0
+        {
+            get
+            {
+                return SR.GetResourceString("CanOnlyStoreIntoArgOrLocGot0", null);
+            }
+        }
+
+        internal static String CharIsInvalidPrimitive
+        {
+            get
+            {
+                return SR.GetResourceString("CharIsInvalidPrimitive", null);
+            }
+        }
+
+        internal static String ClrTypeNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("ClrTypeNotFound", null);
+            }
+        }
+
+        internal static String CollectionAssignedToIncompatibleInterface
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionAssignedToIncompatibleInterface", null);
+            }
+        }
+
+        internal static String CollectionMustHaveAddMethod
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionMustHaveAddMethod", null);
+            }
+        }
+
+        internal static String CollectionMustHaveGetEnumeratorMethod
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionMustHaveGetEnumeratorMethod", null);
+            }
+        }
+
+        internal static String CollectionMustHaveItemType
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionMustHaveItemType", null);
+            }
+        }
+
+        internal static String CollectionTypeCannotBeBuiltIn
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionTypeCannotBeBuiltIn", null);
+            }
+        }
+
+        internal static String CollectionTypeCannotHaveDataContract
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionTypeCannotHaveDataContract", null);
+            }
+        }
+
+        internal static String CollectionTypeDoesNotHaveAddMethod
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionTypeDoesNotHaveAddMethod", null);
+            }
+        }
+
+        internal static String CollectionTypeDoesNotHaveDefaultCtor
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionTypeDoesNotHaveDefaultCtor", null);
+            }
+        }
+
+        internal static String CollectionTypeHasMultipleDefinitionsOfInterface
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionTypeHasMultipleDefinitionsOfInterface", null);
+            }
+        }
+
+        internal static String CollectionTypeIsNotIEnumerable
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionTypeIsNotIEnumerable", null);
+            }
+        }
+
+        internal static String DataContractCacheOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("DataContractCacheOverflow", null);
+            }
+        }
+
+        internal static String DataContractNamespaceAlreadySet
+        {
+            get
+            {
+                return SR.GetResourceString("DataContractNamespaceAlreadySet", null);
+            }
+        }
+
+        internal static String DataContractNamespaceIsNotValid
+        {
+            get
+            {
+                return SR.GetResourceString("DataContractNamespaceIsNotValid", null);
+            }
+        }
+
+        internal static String DataContractNamespaceReserved
+        {
+            get
+            {
+                return SR.GetResourceString("DataContractNamespaceReserved", null);
+            }
+        }
+
+        internal static String DataMemberOnEnumField
+        {
+            get
+            {
+                return SR.GetResourceString("DataMemberOnEnumField", null);
+            }
+        }
+
+        internal static String DcTypeNotFoundOnDeserialize
+        {
+            get
+            {
+                return SR.GetResourceString("DcTypeNotFoundOnDeserialize", null);
+            }
+        }
+
+        internal static String DcTypeNotFoundOnSerialize
+        {
+            get
+            {
+                return SR.GetResourceString("DcTypeNotFoundOnSerialize", null);
+            }
+        }
+
+        internal static String DcTypeNotResolvedOnDeserialize
+        {
+            get
+            {
+                return SR.GetResourceString("DcTypeNotResolvedOnDeserialize", null);
+            }
+        }
+
+        internal static String DeserializedObjectWithIdNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("DeserializedObjectWithIdNotFound", null);
+            }
+        }
+
+        internal static String DupContractInKnownTypes
+        {
+            get
+            {
+                return SR.GetResourceString("DupContractInKnownTypes", null);
+            }
+        }
+
+        internal static String DupEnumMemberValue
+        {
+            get
+            {
+                return SR.GetResourceString("DupEnumMemberValue", null);
+            }
+        }
+
+        internal static String DupKeyValueName
+        {
+            get
+            {
+                return SR.GetResourceString("DupKeyValueName", null);
+            }
+        }
+
+        internal static String DuplicateAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("DuplicateAttribute", null);
+            }
+        }
+
+        internal static String DuplicateCallback
+        {
+            get
+            {
+                return SR.GetResourceString("DuplicateCallback", null);
+            }
+        }
+
+        internal static String DupMemberName
+        {
+            get
+            {
+                return SR.GetResourceString("DupMemberName", null);
+            }
+        }
+
+        internal static String EncounteredWithNameNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("EncounteredWithNameNamespace", null);
+            }
+        }
+
+        internal static String EnumTypeCannotHaveIsReference
+        {
+            get
+            {
+                return SR.GetResourceString("EnumTypeCannotHaveIsReference", null);
+            }
+        }
+
+        internal static String EnumTypeNotSupportedByDataContractJsonSerializer
+        {
+            get
+            {
+                return SR.GetResourceString("EnumTypeNotSupportedByDataContractJsonSerializer", null);
+            }
+        }
+
+        internal static String ErrorDeserializing
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorDeserializing", null);
+            }
+        }
+
+        internal static String ErrorInLine
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorInLine", null);
+            }
+        }
+
+        internal static String ErrorIsStartObject
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorIsStartObject", null);
+            }
+        }
+
+        internal static String ErrorSerializing
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorSerializing", null);
+            }
+        }
+
+        internal static String ErrorTypeInfo
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorTypeInfo", null);
+            }
+        }
+
+        internal static String ErrorWriteEndObject
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorWriteEndObject", null);
+            }
+        }
+
+        internal static String ErrorWriteStartObject
+        {
+            get
+            {
+                return SR.GetResourceString("ErrorWriteStartObject", null);
+            }
+        }
+
+        internal static String ExceededMaxItemsQuota
+        {
+            get
+            {
+                return SR.GetResourceString("ExceededMaxItemsQuota", null);
+            }
+        }
+
+        internal static String ExpectingElement
+        {
+            get
+            {
+                return SR.GetResourceString("ExpectingElement", null);
+            }
+        }
+
+        internal static String ExpectingElementAtDeserialize
+        {
+            get
+            {
+                return SR.GetResourceString("ExpectingElementAtDeserialize", null);
+            }
+        }
+
+        internal static String ExpectingEnd
+        {
+            get
+            {
+                return SR.GetResourceString("ExpectingEnd", null);
+            }
+        }
+
+        internal static String ExpectingState
+        {
+            get
+            {
+                return SR.GetResourceString("ExpectingState", null);
+            }
+        }
+
+        internal static String FactoryObjectContainsSelfReference
+        {
+            get
+            {
+                return SR.GetResourceString("FactoryObjectContainsSelfReference", null);
+            }
+        }
+
+        internal static String GenericCallbackException
+        {
+            get
+            {
+                return SR.GetResourceString("GenericCallbackException", null);
+            }
+        }
+
+        internal static String GenericNameBraceMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("GenericNameBraceMismatch", null);
+            }
+        }
+
+        internal static String GenericParameterNotValid
+        {
+            get
+            {
+                return SR.GetResourceString("GenericParameterNotValid", null);
+            }
+        }
+
+        internal static String GetOnlyCollectionMustHaveAddMethod
+        {
+            get
+            {
+                return SR.GetResourceString("GetOnlyCollectionMustHaveAddMethod", null);
+            }
+        }
+
+        internal static String InconsistentIsReference
+        {
+            get
+            {
+                return SR.GetResourceString("InconsistentIsReference", null);
+            }
+        }
+
+        internal static String IndexedPropertyCannotBeSerialized
+        {
+            get
+            {
+                return SR.GetResourceString("IndexedPropertyCannotBeSerialized", null);
+            }
+        }
+
+        internal static String InvalidCharacterEncountered
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCharacterEncountered", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractItemName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractItemName", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractKeyName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractKeyName", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractKeyNoDictionary
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractKeyNoDictionary", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractName", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractNamespace", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractValueName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractValueName", null);
+            }
+        }
+
+        internal static String InvalidCollectionContractValueNoDictionary
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionContractValueNoDictionary", null);
+            }
+        }
+
+        internal static String InvalidCollectionDataContract
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionDataContract", null);
+            }
+        }
+
+        internal static String InvalidCollectionType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCollectionType", null);
+            }
+        }
+
+        internal static String InvalidDataContractName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidDataContractName", null);
+            }
+        }
+
+        internal static String InvalidDataContractNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidDataContractNamespace", null);
+            }
+        }
+
+        internal static String InvalidDataMemberName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidDataMemberName", null);
+            }
+        }
+
+        internal static String InvalidDataNode
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidDataNode", null);
+            }
+        }
+
+        internal static String InvalidEnumMemberValue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidEnumMemberValue", null);
+            }
+        }
+
+        internal static String InvalidEnumValueOnRead
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidEnumValueOnRead", null);
+            }
+        }
+
+        internal static String InvalidEnumValueOnWrite
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidEnumValueOnWrite", null);
+            }
+        }
+
+        internal static String InvalidGetSchemaMethod
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidGetSchemaMethod", null);
+            }
+        }
+
+        internal static String InvalidGlobalDataContractNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidGlobalDataContractNamespace", null);
+            }
+        }
+
+        internal static String InvalidLocalNameEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidLocalNameEmpty", null);
+            }
+        }
+
+        internal static String InvalidMember
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidMember", null);
+            }
+        }
+
+        internal static String InvalidNonNullReturnValueByIsAny
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidNonNullReturnValueByIsAny", null);
+            }
+        }
+
+        internal static String InvalidPrimitiveType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidPrimitiveType", null);
+            }
+        }
+
+        internal static String InvalidReturnTypeOnGetSchemaMethod
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidReturnTypeOnGetSchemaMethod", null);
+            }
+        }
+
+        internal static String InvalidSizeDefinition
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidSizeDefinition", null);
+            }
+        }
+
+        internal static String InvalidStateInExtensionDataReader
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidStateInExtensionDataReader", null);
+            }
+        }
+
+        internal static String InvalidXmlDataContractName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidXmlDataContractName", null);
+            }
+        }
+
+        internal static String InvalidXmlDeserializingExtensionData
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidXmlDeserializingExtensionData", null);
+            }
+        }
+
+        internal static String InvalidXsIdDefinition
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidXsIdDefinition", null);
+            }
+        }
+
+        internal static String InvalidXsRefDefinition
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidXsRefDefinition", null);
+            }
+        }
+
+        internal static String IsAnyCannotBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("IsAnyCannotBeNull", null);
+            }
+        }
+
+        internal static String IsAnyCannotBeSerializedAsDerivedType
+        {
+            get
+            {
+                return SR.GetResourceString("IsAnyCannotBeSerializedAsDerivedType", null);
+            }
+        }
+
+        internal static String IsAnyCannotHaveXmlRoot
+        {
+            get
+            {
+                return SR.GetResourceString("IsAnyCannotHaveXmlRoot", null);
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
+        internal static String IsRequiredDataMemberOnIsReferenceDataContractType
+        {
+            get
+            {
+                return SR.GetResourceString("IsRequiredDataMemberOnIsReferenceDataContractType", null);
+            }
+        }
+
+        internal static String IXmlSerializableCannotHaveCollectionDataContract
+        {
+            get
+            {
+                return SR.GetResourceString("IXmlSerializableCannotHaveCollectionDataContract", null);
+            }
+        }
+
+        internal static String IXmlSerializableCannotHaveDataContract
+        {
+            get
+            {
+                return SR.GetResourceString("IXmlSerializableCannotHaveDataContract", null);
+            }
+        }
+
+        internal static String IXmlSerializableIllegalOperation
+        {
+            get
+            {
+                return SR.GetResourceString("IXmlSerializableIllegalOperation", null);
+            }
+        }
+
+        internal static String IXmlSerializableMissingEndElements
+        {
+            get
+            {
+                return SR.GetResourceString("IXmlSerializableMissingEndElements", null);
+            }
+        }
+
+        internal static String IXmlSerializableMustHaveDefaultConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("IXmlSerializableMustHaveDefaultConstructor", null);
+            }
+        }
+
+        internal static String IXmlSerializableWritePastSubTree
+        {
+            get
+            {
+                return SR.GetResourceString("IXmlSerializableWritePastSubTree", null);
+            }
+        }
+
+        internal static String JsonAttributeAlreadyWritten
+        {
+            get
+            {
+                return SR.GetResourceString("JsonAttributeAlreadyWritten", null);
+            }
+        }
+
+        internal static String JsonAttributeMustHaveElement
+        {
+            get
+            {
+                return SR.GetResourceString("JsonAttributeMustHaveElement", null);
+            }
+        }
+
+        internal static String JsonCannotWriteStandaloneTextAfterQuotedText
+        {
+            get
+            {
+                return SR.GetResourceString("JsonCannotWriteStandaloneTextAfterQuotedText", null);
+            }
+        }
+
+        internal static String JsonCannotWriteTextAfterNonTextAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("JsonCannotWriteTextAfterNonTextAttribute", null);
+            }
+        }
+
+        internal static String JsonCircularReferenceDetected
+        {
+            get
+            {
+                return SR.GetResourceString("JsonCircularReferenceDetected", null);
+            }
+        }
+
+        internal static String JsonDateTimeOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("JsonDateTimeOutOfRange", null);
+            }
+        }
+
+        internal static String JsonDuplicateMemberInInput
+        {
+            get
+            {
+                return SR.GetResourceString("JsonDuplicateMemberInInput", null);
+            }
+        }
+
+        internal static String JsonDuplicateMemberNames
+        {
+            get
+            {
+                return SR.GetResourceString("JsonDuplicateMemberNames", null);
+            }
+        }
+
+        internal static String JsonEncodingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("JsonEncodingNotSupported", null);
+            }
+        }
+
+        internal static String JsonEncounteredUnexpectedCharacter
+        {
+            get
+            {
+                return SR.GetResourceString("JsonEncounteredUnexpectedCharacter", null);
+            }
+        }
+
+        internal static String JsonEndElementNoOpenNodes
+        {
+            get
+            {
+                return SR.GetResourceString("JsonEndElementNoOpenNodes", null);
+            }
+        }
+
+        internal static String JsonExpectedEncoding
+        {
+            get
+            {
+                return SR.GetResourceString("JsonExpectedEncoding", null);
+            }
+        }
+
+        internal static String JsonInvalidBytes
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidBytes", null);
+            }
+        }
+
+        internal static String JsonInvalidDataTypeSpecifiedForServerType
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidDataTypeSpecifiedForServerType", null);
+            }
+        }
+
+        internal static String JsonInvalidDateTimeString
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidDateTimeString", null);
+            }
+        }
+
+        internal static String JsonInvalidFFFE
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidFFFE", null);
+            }
+        }
+
+        internal static String JsonInvalidItemNameForArrayElement
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidItemNameForArrayElement", null);
+            }
+        }
+
+        internal static String JsonInvalidLocalNameEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidLocalNameEmpty", null);
+            }
+        }
+
+        internal static String JsonInvalidMethodBetweenStartEndAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidMethodBetweenStartEndAttribute", null);
+            }
+        }
+
+        internal static String JsonInvalidRootElementName
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidRootElementName", null);
+            }
+        }
+
+        internal static String JsonInvalidStartElementCall
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidStartElementCall", null);
+            }
+        }
+
+        internal static String JsonInvalidWriteState
+        {
+            get
+            {
+                return SR.GetResourceString("JsonInvalidWriteState", null);
+            }
+        }
+
+        internal static String JsonMethodNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("JsonMethodNotSupported", null);
+            }
+        }
+
+        internal static String JsonMultipleRootElementsNotAllowedOnWriter
+        {
+            get
+            {
+                return SR.GetResourceString("JsonMultipleRootElementsNotAllowedOnWriter", null);
+            }
+        }
+
+        internal static String JsonMustSpecifyDataType
+        {
+            get
+            {
+                return SR.GetResourceString("JsonMustSpecifyDataType", null);
+            }
+        }
+
+        internal static String JsonMustUseWriteStringForWritingAttributeValues
+        {
+            get
+            {
+                return SR.GetResourceString("JsonMustUseWriteStringForWritingAttributeValues", null);
+            }
+        }
+
+        internal static String JsonNamespaceMustBeEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("JsonNamespaceMustBeEmpty", null);
+            }
+        }
+
+        internal static String JsonNestedArraysNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("JsonNestedArraysNotSupported", null);
+            }
+        }
+
+        internal static String JsonNodeTypeArrayOrObjectNotSpecified
+        {
+            get
+            {
+                return SR.GetResourceString("JsonNodeTypeArrayOrObjectNotSpecified", null);
+            }
+        }
+
+        internal static String JsonNoMatchingStartAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("JsonNoMatchingStartAttribute", null);
+            }
+        }
+
+        internal static String JsonOffsetExceedsBufferSize
+        {
+            get
+            {
+                return SR.GetResourceString("JsonOffsetExceedsBufferSize", null);
+            }
+        }
+
+        internal static String JsonOneRequiredMemberNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("JsonOneRequiredMemberNotFound", null);
+            }
+        }
+
+        internal static String JsonOnlyWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("JsonOnlyWhitespace", null);
+            }
+        }
+
+        internal static String JsonOpenAttributeMustBeClosedFirst
+        {
+            get
+            {
+                return SR.GetResourceString("JsonOpenAttributeMustBeClosedFirst", null);
+            }
+        }
+
+        internal static String JsonPrefixMustBeNullOrEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("JsonPrefixMustBeNullOrEmpty", null);
+            }
+        }
+
+        internal static String JsonRequiredMembersNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("JsonRequiredMembersNotFound", null);
+            }
+        }
+
+        internal static String JsonServerTypeSpecifiedForInvalidDataType
+        {
+            get
+            {
+                return SR.GetResourceString("JsonServerTypeSpecifiedForInvalidDataType", null);
+            }
+        }
+
+        internal static String JsonSizeExceedsRemainingBufferSpace
+        {
+            get
+            {
+                return SR.GetResourceString("JsonSizeExceedsRemainingBufferSpace", null);
+            }
+        }
+
+        internal static String JsonTypeNotSupportedByDataContractJsonSerializer
+        {
+            get
+            {
+                return SR.GetResourceString("JsonTypeNotSupportedByDataContractJsonSerializer", null);
+            }
+        }
+
+        internal static String JsonUnexpectedAttributeLocalName
+        {
+            get
+            {
+                return SR.GetResourceString("JsonUnexpectedAttributeLocalName", null);
+            }
+        }
+
+        internal static String JsonUnexpectedAttributeValue
+        {
+            get
+            {
+                return SR.GetResourceString("JsonUnexpectedAttributeValue", null);
+            }
+        }
+
+        internal static String JsonUnexpectedEndOfFile
+        {
+            get
+            {
+                return SR.GetResourceString("JsonUnexpectedEndOfFile", null);
+            }
+        }
+
+        internal static String JsonUnsupportedForIsReference
+        {
+            get
+            {
+                return SR.GetResourceString("JsonUnsupportedForIsReference", null);
+            }
+        }
+
+        internal static String JsonWriteArrayNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("JsonWriteArrayNotSupported", null);
+            }
+        }
+
+        internal static String JsonWriterClosed
+        {
+            get
+            {
+                return SR.GetResourceString("JsonWriterClosed", null);
+            }
+        }
+
+        internal static String JsonXmlInvalidDeclaration
+        {
+            get
+            {
+                return SR.GetResourceString("JsonXmlInvalidDeclaration", null);
+            }
+        }
+
+        internal static String JsonXmlProcessingInstructionNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("JsonXmlProcessingInstructionNotSupported", null);
+            }
+        }
+
+        internal static String KeyTypeCannotBeParsedInSimpleDictionary
+        {
+            get
+            {
+                return SR.GetResourceString("KeyTypeCannotBeParsedInSimpleDictionary", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeEmptyString
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeEmptyString", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeMethodNull
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeMethodNull", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeNoData
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeNoData", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeOneScheme
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeOneScheme", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeReturnType
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeReturnType", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeUnknownMethod
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeUnknownMethod", null);
+            }
+        }
+
+        internal static String KnownTypeAttributeValidMethodTypes
+        {
+            get
+            {
+                return SR.GetResourceString("KnownTypeAttributeValidMethodTypes", null);
+            }
+        }
+
+        internal static String MaxArrayLengthExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("MaxArrayLengthExceeded", null);
+            }
+        }
+
+        internal static String MissingGetSchemaMethod
+        {
+            get
+            {
+                return SR.GetResourceString("MissingGetSchemaMethod", null);
+            }
+        }
+
+        internal static String MultipleIdDefinition
+        {
+            get
+            {
+                return SR.GetResourceString("MultipleIdDefinition", null);
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
+        internal static String NoGetMethodForProperty
+        {
+            get
+            {
+                return SR.GetResourceString("NoGetMethodForProperty", null);
+            }
+        }
+
+        internal static String NonAttributedSerializableTypesMustHaveDefaultConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("NonAttributedSerializableTypesMustHaveDefaultConstructor", null);
+            }
+        }
+
+        internal static String NonOptionalFieldMemberOnIsReferenceSerializableType
+        {
+            get
+            {
+                return SR.GetResourceString("NonOptionalFieldMemberOnIsReferenceSerializableType", null);
+            }
+        }
+
+        internal static String NoSetMethodForProperty
+        {
+            get
+            {
+                return SR.GetResourceString("NoSetMethodForProperty", null);
+            }
+        }
+
+        internal static String NullKnownType
+        {
+            get
+            {
+                return SR.GetResourceString("NullKnownType", null);
+            }
+        }
+
+        internal static String NullValueReturnedForGetOnlyCollection
+        {
+            get
+            {
+                return SR.GetResourceString("NullValueReturnedForGetOnlyCollection", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_BadEscape
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_BadEscape", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_IllegalPrimitive
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_IllegalPrimitive", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_InvalidArrayExtraComma
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_InvalidArrayExtraComma", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_InvalidMemberName
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_InvalidMemberName", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_StringNotQuoted
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_StringNotQuoted", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_UnexpectedToken
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_UnexpectedToken", null);
+            }
+        }
+
+        internal static String ObjectDeserializer_UnterminatedString
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDeserializer_UnterminatedString", null);
+            }
+        }
+
+        internal static String ObjectSerializer_DictionaryNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectSerializer_DictionaryNotSupported", null);
+            }
+        }
+
+        internal static String ObjectTableOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectTableOverflow", null);
+            }
+        }
+
+        internal static String OffsetExceedsBufferSize
+        {
+            get
+            {
+                return SR.GetResourceString("OffsetExceedsBufferSize", null);
+            }
+        }
+
+        internal static String OrderCannotBeNegative
+        {
+            get
+            {
+                return SR.GetResourceString("OrderCannotBeNegative", null);
+            }
+        }
+
+        internal static String ParameterCountMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("ParameterCountMismatch", null);
+            }
+        }
+
+        internal static String PartialTrustCollectionContractAddMethodNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustCollectionContractAddMethodNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustCollectionContractNoPublicConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustCollectionContractNoPublicConstructor", null);
+            }
+        }
+
+        internal static String PartialTrustCollectionContractTypeNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustCollectionContractTypeNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractFieldGetNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractFieldGetNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractFieldSetNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractFieldSetNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractMemberGetNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractMemberGetNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractMemberSetNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractMemberSetNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractOnDeserializedNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractOnDeserializedNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractOnDeserializingNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractOnDeserializingNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractOnSerializedNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractOnSerializedNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractOnSerializingNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractOnSerializingNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractPropertyGetNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractPropertyGetNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractPropertySetNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractPropertySetNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustDataContractTypeNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustDataContractTypeNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustIXmlSerializableTypeNotPublic
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustIXmlSerializableTypeNotPublic", null);
+            }
+        }
+
+        internal static String PartialTrustIXmlSerialzableNoPublicConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustIXmlSerialzableNoPublicConstructor", null);
+            }
+        }
+
+        internal static String PartialTrustNonAttributedSerializableTypeNoPublicConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("PartialTrustNonAttributedSerializableTypeNoPublicConstructor", null);
+            }
+        }
+
+        internal static String QuotaCopyReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("QuotaCopyReadOnly", null);
+            }
+        }
+
+        internal static String QuotaIsReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("QuotaIsReadOnly", null);
+            }
+        }
+
+        internal static String QuotaMustBePositive
+        {
+            get
+            {
+                return SR.GetResourceString("QuotaMustBePositive", null);
+            }
+        }
+
+        internal static String RecursiveCollectionType
+        {
+            get
+            {
+                return SR.GetResourceString("RecursiveCollectionType", null);
+            }
+        }
+
+        internal static String RequiredMemberMustBeEmitted
+        {
+            get
+            {
+                return SR.GetResourceString("RequiredMemberMustBeEmitted", null);
+            }
+        }
+
+        internal static String ResolveTypeReturnedFalse
+        {
+            get
+            {
+                return SR.GetResourceString("ResolveTypeReturnedFalse", null);
+            }
+        }
+
+        internal static String ResolveTypeReturnedNull
+        {
+            get
+            {
+                return SR.GetResourceString("ResolveTypeReturnedNull", null);
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
+                return typeof(FxResources.System.Private.DataContractSerialization.SR);
+            }
+        }
+
+        internal static String SerializationCodeIsMissingForType
+        {
+            get
+            {
+                return SR.GetResourceString("SerializationCodeIsMissingForType", null);
+            }
+        }
+
+        internal static String SizeExceedsRemainingBufferSpace
+        {
+            get
+            {
+                return SR.GetResourceString("SizeExceedsRemainingBufferSpace", null);
+            }
+        }
+
+        internal static String SupportForMultidimensionalArraysNotPresent
+        {
+            get
+            {
+                return SR.GetResourceString("SupportForMultidimensionalArraysNotPresent", null);
+            }
+        }
+
+        internal static String SurrogatesWithGetOnlyCollectionsNotSupportedSerDeser
+        {
+            get
+            {
+                return SR.GetResourceString("SurrogatesWithGetOnlyCollectionsNotSupportedSerDeser", null);
+            }
+        }
+
+        internal static String TooManyCollectionContracts
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyCollectionContracts", null);
+            }
+        }
+
+        internal static String TooManyDataContracts
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyDataContracts", null);
+            }
+        }
+
+        internal static String TooManyDataMembers
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyDataMembers", null);
+            }
+        }
+
+        internal static String TooManyEnumMembers
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyEnumMembers", null);
+            }
+        }
+
+        internal static String TooManyIgnoreDataMemberAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyIgnoreDataMemberAttributes", null);
+            }
+        }
+
+        internal static String TypeNotSerializable
+        {
+            get
+            {
+                return SR.GetResourceString("TypeNotSerializable", null);
+            }
+        }
+
+        internal static String UnexpectedContractType
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedContractType", null);
+            }
+        }
+
+        internal static String UnexpectedElementExpectingElements
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedElementExpectingElements", null);
+            }
+        }
+
+        internal static String UnexpectedEndOfFile
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedEndOfFile", null);
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
+        internal static String UnknownDataContract
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownDataContract", null);
+            }
+        }
+
+        internal static String UnknownXmlType
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownXmlType", null);
+            }
+        }
+
+        internal static String ValueMustBeInRange
+        {
+            get
+            {
+                return SR.GetResourceString("ValueMustBeInRange", null);
+            }
+        }
+
+        internal static String ValueMustBeNonNegative
+        {
+            get
+            {
+                return SR.GetResourceString("ValueMustBeNonNegative", null);
+            }
+        }
+
+        internal static String ValueTypeCannotBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("ValueTypeCannotBeNull", null);
+            }
+        }
+
+        internal static String ValueTypeCannotHaveBaseType
+        {
+            get
+            {
+                return SR.GetResourceString("ValueTypeCannotHaveBaseType", null);
+            }
+        }
+
+        internal static String ValueTypeCannotHaveId
+        {
+            get
+            {
+                return SR.GetResourceString("ValueTypeCannotHaveId", null);
+            }
+        }
+
+        internal static String ValueTypeCannotHaveIsReference
+        {
+            get
+            {
+                return SR.GetResourceString("ValueTypeCannotHaveIsReference", null);
+            }
+        }
+
+        internal static String ValueTypeCannotHaveRef
+        {
+            get
+            {
+                return SR.GetResourceString("ValueTypeCannotHaveRef", null);
+            }
+        }
+
+        internal static String XmlArrayTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("XmlArrayTooSmall", null);
+            }
+        }
+
+        internal static String XmlArrayTooSmallInput
+        {
+            get
+            {
+                return SR.GetResourceString("XmlArrayTooSmallInput", null);
+            }
+        }
+
+        internal static String XmlArrayTooSmallOutput
+        {
+            get
+            {
+                return SR.GetResourceString("XmlArrayTooSmallOutput", null);
+            }
+        }
+
+        internal static String XmlAsyncIsRunningException
+        {
+            get
+            {
+                return SR.GetResourceString("XmlAsyncIsRunningException", null);
+            }
+        }
+
+        internal static String XmlBadBOM
+        {
+            get
+            {
+                return SR.GetResourceString("XmlBadBOM", null);
+            }
+        }
+
+        internal static String XmlBase64DataExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlBase64DataExpected", null);
+            }
+        }
+
+        internal static String XmlCDATAInvalidAtTopLevel
+        {
+            get
+            {
+                return SR.GetResourceString("XmlCDATAInvalidAtTopLevel", null);
+            }
+        }
+
+        internal static String XmlCloseCData
+        {
+            get
+            {
+                return SR.GetResourceString("XmlCloseCData", null);
+            }
+        }
+
+        internal static String XmlConversionOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConversionOverflow", null);
+            }
+        }
+
+        internal static String XmlDeclarationRequired
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDeclarationRequired", null);
+            }
+        }
+
+        internal static String XmlDeclMissing
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDeclMissing", null);
+            }
+        }
+
+        internal static String XmlDeclMissingVersion
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDeclMissingVersion", null);
+            }
+        }
+
+        internal static String XmlDeclNotFirst
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDeclNotFirst", null);
+            }
+        }
+
+        internal static String XmlDictionaryStringIDRange
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDictionaryStringIDRange", null);
+            }
+        }
+
+        internal static String XmlDictionaryStringIDUndefinedSession
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDictionaryStringIDUndefinedSession", null);
+            }
+        }
+
+        internal static String XmlDictionaryStringIDUndefinedStatic
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDictionaryStringIDUndefinedStatic", null);
+            }
+        }
+
+        internal static String XmlDuplicateAttribute
+        {
+            get
+            {
+                return SR.GetResourceString("XmlDuplicateAttribute", null);
+            }
+        }
+
+        internal static String XmlElementAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlElementAttributes", null);
+            }
+        }
+
+        internal static String XmlEmptyNamespaceRequiresNullPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("XmlEmptyNamespaceRequiresNullPrefix", null);
+            }
+        }
+
+        internal static String XmlEncodingMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("XmlEncodingMismatch", null);
+            }
+        }
+
+        internal static String XmlEncodingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("XmlEncodingNotSupported", null);
+            }
+        }
+
+        internal static String XmlEndElementExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlEndElementExpected", null);
+            }
+        }
+
+        internal static String XmlEndElementNoOpenNodes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlEndElementNoOpenNodes", null);
+            }
+        }
+
+        internal static String XmlExpectedEncoding
+        {
+            get
+            {
+                return SR.GetResourceString("XmlExpectedEncoding", null);
+            }
+        }
+
+        internal static String XmlForObjectCannotHaveContent
+        {
+            get
+            {
+                return SR.GetResourceString("XmlForObjectCannotHaveContent", null);
+            }
+        }
+
+        internal static String XmlFoundCData
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundCData", null);
+            }
+        }
+
+        internal static String XmlFoundComment
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundComment", null);
+            }
+        }
+
+        internal static String XmlFoundElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundElement", null);
+            }
+        }
+
+        internal static String XmlFoundEndElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundEndElement", null);
+            }
+        }
+
+        internal static String XmlFoundEndOfFile
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundEndOfFile", null);
+            }
+        }
+
+        internal static String XmlFoundNodeType
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundNodeType", null);
+            }
+        }
+
+        internal static String XmlFoundText
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFoundText", null);
+            }
+        }
+
+        internal static String XmlFullStartElementExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFullStartElementExpected", null);
+            }
+        }
+
+        internal static String XmlFullStartElementLocalNameNsExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFullStartElementLocalNameNsExpected", null);
+            }
+        }
+
+        internal static String XmlFullStartElementNameExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlFullStartElementNameExpected", null);
+            }
+        }
+
+        internal static String XmlIDDefined
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIDDefined", null);
+            }
+        }
+
+        internal static String XmlIllegalOutsideRoot
+        {
+            get
+            {
+                return SR.GetResourceString("XmlIllegalOutsideRoot", null);
+            }
+        }
+
+        internal static String XmlInvalidBase64Length
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidBase64Length", null);
+            }
+        }
+
+        internal static String XmlInvalidBase64Sequence
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidBase64Sequence", null);
+            }
+        }
+
+        internal static String XmlInvalidBinHexLength
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidBinHexLength", null);
+            }
+        }
+
+        internal static String XmlInvalidBinHexSequence
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidBinHexSequence", null);
+            }
+        }
+
+        internal static String XmlInvalidBytes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidBytes", null);
+            }
+        }
+
+        internal static String XmlInvalidCharRef
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidCharRef", null);
+            }
+        }
+
+        internal static String XmlInvalidCommentChars
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidCommentChars", null);
+            }
+        }
+
+        internal static String XmlInvalidConversion
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidConversion", null);
+            }
+        }
+
+        internal static String XmlInvalidConversionWithoutValue
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidConversionWithoutValue", null);
+            }
+        }
+
+        internal static String XmlInvalidDeclaration
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidDeclaration", null);
+            }
+        }
+
+        internal static String XmlInvalidDepth
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidDepth", null);
+            }
+        }
+
+        internal static String XmlInvalidEncoding
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidEncoding", null);
+            }
+        }
+
+        internal static String XmlInvalidFFFE
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidFFFE", null);
+            }
+        }
+
+        internal static String XmlInvalidFormat
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidFormat", null);
+            }
+        }
+
+        internal static String XmlInvalidHighSurrogate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidHighSurrogate", null);
+            }
+        }
+
+        internal static String XmlInvalidID
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidID", null);
+            }
+        }
+
+        internal static String XmlInvalidLowSurrogate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidLowSurrogate", null);
+            }
+        }
+
+        internal static String XmlInvalidOperation
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidOperation", null);
+            }
+        }
+
+        internal static String XmlInvalidPrefixState
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidPrefixState", null);
+            }
+        }
+
+        internal static String XmlInvalidQualifiedName
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidQualifiedName", null);
+            }
+        }
+
+        internal static String XmlInvalidRootData
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidRootData", null);
+            }
+        }
+
+        internal static String XmlInvalidStandalone
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidStandalone", null);
+            }
+        }
+
+        internal static String XmlInvalidSurrogate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidSurrogate", null);
+            }
+        }
+
+        internal static String XmlInvalidUniqueId
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidUniqueId", null);
+            }
+        }
+
+        internal static String XmlInvalidUTF8Bytes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidUTF8Bytes", null);
+            }
+        }
+
+        internal static String XmlInvalidVersion
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidVersion", null);
+            }
+        }
+
+        internal static String XmlInvalidWriteState
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidWriteState", null);
+            }
+        }
+
+        internal static String XmlInvalidXmlByte
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidXmlByte", null);
+            }
+        }
+
+        internal static String XmlInvalidXmlSpace
+        {
+            get
+            {
+                return SR.GetResourceString("XmlInvalidXmlSpace", null);
+            }
+        }
+
+        internal static String XmlKeyAlreadyExists
+        {
+            get
+            {
+                return SR.GetResourceString("XmlKeyAlreadyExists", null);
+            }
+        }
+
+        internal static String XmlLineInfo
+        {
+            get
+            {
+                return SR.GetResourceString("XmlLineInfo", null);
+            }
+        }
+
+        internal static String XmlMalformedDecl
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMalformedDecl", null);
+            }
+        }
+
+        internal static String XmlMaxArrayLengthExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMaxArrayLengthExceeded", null);
+            }
+        }
+
+        internal static String XmlMaxBytesPerReadExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMaxBytesPerReadExceeded", null);
+            }
+        }
+
+        internal static String XmlMaxDepthExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMaxDepthExceeded", null);
+            }
+        }
+
+        internal static String XmlMaxNameTableCharCountExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMaxNameTableCharCountExceeded", null);
+            }
+        }
+
+        internal static String XmlMaxStringContentLengthExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMaxStringContentLengthExceeded", null);
+            }
+        }
+
+        internal static String XmlMethodNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMethodNotSupported", null);
+            }
+        }
+
+        internal static String XmlMissingLowSurrogate
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMissingLowSurrogate", null);
+            }
+        }
+
+        internal static String XmlMultipleRootElements
+        {
+            get
+            {
+                return SR.GetResourceString("XmlMultipleRootElements", null);
+            }
+        }
+
+        internal static String XmlNamespaceNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNamespaceNotFound", null);
+            }
+        }
+
+        internal static String XmlNestedArraysNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNestedArraysNotSupported", null);
+            }
+        }
+
+        internal static String XmlNoRootElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlNoRootElement", null);
+            }
+        }
+
+        internal static String XmlObjectAssignedToIncompatibleInterface
+        {
+            get
+            {
+                return SR.GetResourceString("XmlObjectAssignedToIncompatibleInterface", null);
+            }
+        }
+
+        internal static String XmlOnlyOneRoot
+        {
+            get
+            {
+                return SR.GetResourceString("XmlOnlyOneRoot", null);
+            }
+        }
+
+        internal static String XmlOnlySingleValue
+        {
+            get
+            {
+                return SR.GetResourceString("XmlOnlySingleValue", null);
+            }
+        }
+
+        internal static String XmlOnlyWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("XmlOnlyWhitespace", null);
+            }
+        }
+
+        internal static String XmlPrefixBoundToNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("XmlPrefixBoundToNamespace", null);
+            }
+        }
+
+        internal static String XmlProcessingInstructionNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("XmlProcessingInstructionNotSupported", null);
+            }
+        }
+
+        internal static String XmlReservedPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("XmlReservedPrefix", null);
+            }
+        }
+
+        internal static String XmlSpaceBetweenAttributes
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSpaceBetweenAttributes", null);
+            }
+        }
+
+        internal static String XmlSpecificBindingNamespace
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSpecificBindingNamespace", null);
+            }
+        }
+
+        internal static String XmlSpecificBindingPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("XmlSpecificBindingPrefix", null);
+            }
+        }
+
+        internal static String XmlStartElementExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlStartElementExpected", null);
+            }
+        }
+
+        internal static String XmlStartElementLocalNameNsExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlStartElementLocalNameNsExpected", null);
+            }
+        }
+
+        internal static String XmlStartElementNameExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlStartElementNameExpected", null);
+            }
+        }
+
+        internal static String XmlTagMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("XmlTagMismatch", null);
+            }
+        }
+
+        internal static String XmlTokenExpected
+        {
+            get
+            {
+                return SR.GetResourceString("XmlTokenExpected", null);
+            }
+        }
+
+        internal static String XmlUndefinedPrefix
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUndefinedPrefix", null);
+            }
+        }
+
+        internal static String XmlUnexpectedEndElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnexpectedEndElement", null);
+            }
+        }
+
+        internal static String XmlUnexpectedEndOfFile
+        {
+            get
+            {
+                return SR.GetResourceString("XmlUnexpectedEndOfFile", null);
+            }
+        }
+
+        internal static String XmlWriterClosed
+        {
+            get
+            {
+                return SR.GetResourceString("XmlWriterClosed", null);
+            }
+        }
+
+        internal static String XmlWriterMustBeInElement
+        {
+            get
+            {
+                return SR.GetResourceString("XmlWriterMustBeInElement", null);
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
