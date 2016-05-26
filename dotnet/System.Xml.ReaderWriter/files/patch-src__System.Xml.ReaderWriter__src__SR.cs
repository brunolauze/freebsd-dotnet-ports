--- /dev/null	2016-03-07 09:18:53.000000000 -0500
+++ src/System.Xml.ReaderWriter/src/SR.cs	2016-03-07 09:19:12.223114000 -0500
@@ -0,0 +1,1374 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Xml.ReaderWriter
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
+        private const String s_resourcesName = "FxResources.System.Xml.ReaderWriter.SR";
+
+        internal static String Argument_ConversionOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ConversionOverflow", null);
+            }
+        }
+
+        internal static String Argument_EncodingConversionOverflowBytes
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EncodingConversionOverflowBytes", null);
+            }
+        }
+
+        internal static String Argument_InvalidCharSequenceNoIndex
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCharSequenceNoIndex", null);
+            }
+        }
+
+        internal static String Argument_InvalidCodePageConversionIndex
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCodePageConversionIndex", null);
+            }
+        }
+
+        internal static String ArgumentNull_Array
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Array", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_Index
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Index", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_IndexCount
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_IndexCount", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_IndexCountBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_IndexCountBuffer", null);
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
+        internal static String ArgumentOutOfRange_Range
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Range", null);
+            }
+        }
+
+        internal static String Enc_InvalidByteInEncoding
+        {
+            get
+            {
+                return SR.GetResourceString("Enc_InvalidByteInEncoding", null);
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
+                return typeof(FxResources.System.Xml.ReaderWriter.SR);
+            }
+        }
+
+        internal static String Sch_InvalidDateTimeOption
+        {
+            get
+            {
+                return SR.GetResourceString("Sch_InvalidDateTimeOption", null);
+            }
+        }
+
+        internal static String Sch_ParEntityRefNesting
+        {
+            get
+            {
+                return SR.GetResourceString("Sch_ParEntityRefNesting", null);
+            }
+        }
+
+        internal static String Xml_AsyncIsRunningException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_AsyncIsRunningException", null);
+            }
+        }
+
+        internal static String Xml_BadAttributeChar
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadAttributeChar", null);
+            }
+        }
+
+        internal static String Xml_BadDecimalEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadDecimalEntity", null);
+            }
+        }
+
+        internal static String Xml_BadDTDLocation
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadDTDLocation", null);
+            }
+        }
+
+        internal static String Xml_BadHexEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadHexEntity", null);
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
+        internal static String Xml_BadNamespaceDecl
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_BadNamespaceDecl", null);
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
+        internal static String Xml_CannotResolveEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CannotResolveEntity", null);
+            }
+        }
+
+        internal static String Xml_CannotResolveEntityDtdIgnored
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CannotResolveEntityDtdIgnored", null);
+            }
+        }
+
+        internal static String Xml_CannotResolveExternalSubset
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CannotResolveExternalSubset", null);
+            }
+        }
+
+        internal static String Xml_CannotResolveUrl
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CannotResolveUrl", null);
+            }
+        }
+
+        internal static String Xml_CannotStartDocumentOnFragment
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CannotStartDocumentOnFragment", null);
+            }
+        }
+
+        internal static String Xml_CannotWriteXmlDecl
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CannotWriteXmlDecl", null);
+            }
+        }
+
+        internal static String Xml_CDATAEndInText
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CDATAEndInText", null);
+            }
+        }
+
+        internal static String Xml_CharEntityOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_CharEntityOverflow", null);
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
+        internal static String Xml_ClosedOrErrorReader
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ClosedOrErrorReader", null);
+            }
+        }
+
+        internal static String Xml_ColonInLocalName
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ColonInLocalName", null);
+            }
+        }
+
+        internal static String Xml_ConformanceLevelFragment
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ConformanceLevelFragment", null);
+            }
+        }
+
+        internal static String Xml_DefaultException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DefaultException", null);
+            }
+        }
+
+        internal static String Xml_DoubleBaseUri
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DoubleBaseUri", null);
+            }
+        }
+
+        internal static String Xml_DtdAfterRootElement
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DtdAfterRootElement", null);
+            }
+        }
+
+        internal static String Xml_DtdAlreadyWritten
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DtdAlreadyWritten", null);
+            }
+        }
+
+        internal static String Xml_DtdIsProhibited
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DtdIsProhibited", null);
+            }
+        }
+
+        internal static String Xml_DtdIsProhibitedEx
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DtdIsProhibitedEx", null);
+            }
+        }
+
+        internal static String Xml_DtdNotAllowedInFragment
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DtdNotAllowedInFragment", null);
+            }
+        }
+
+        internal static String Xml_DupAttributeName
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_DupAttributeName", null);
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
+        internal static String Xml_ElementNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ElementNotFound", null);
+            }
+        }
+
+        internal static String Xml_ElementNotFoundNs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ElementNotFoundNs", null);
+            }
+        }
+
+        internal static String Xml_EmptyLocalName
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_EmptyLocalName", null);
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
+        internal static String Xml_EntityRefNesting
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_EntityRefNesting", null);
+            }
+        }
+
+        internal static String Xml_EnumerationRequired
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_EnumerationRequired", null);
+            }
+        }
+
+        internal static String Xml_ErrorOpeningExternalDtd
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ErrorOpeningExternalDtd", null);
+            }
+        }
+
+        internal static String Xml_ErrorOpeningExternalEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ErrorOpeningExternalEntity", null);
+            }
+        }
+
+        internal static String Xml_ErrorParsingEntityName
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ErrorParsingEntityName", null);
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
+        internal static String Xml_ExpectAttType
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectAttType", null);
+            }
+        }
+
+        internal static String Xml_ExpectDtdMarkup
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectDtdMarkup", null);
+            }
+        }
+
+        internal static String Xml_ExpectExternalIdOrEntityValue
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectExternalIdOrEntityValue", null);
+            }
+        }
+
+        internal static String Xml_ExpectExternalOrClose
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectExternalOrClose", null);
+            }
+        }
+
+        internal static String Xml_ExpectExternalOrPublicId
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectExternalOrPublicId", null);
+            }
+        }
+
+        internal static String Xml_ExpectIgnoreOrInclude
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectIgnoreOrInclude", null);
+            }
+        }
+
+        internal static String Xml_ExpectingWhiteSpace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectingWhiteSpace", null);
+            }
+        }
+
+        internal static String Xml_ExpectNoWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectNoWhitespace", null);
+            }
+        }
+
+        internal static String Xml_ExpectOp
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectOp", null);
+            }
+        }
+
+        internal static String Xml_ExpectPcData
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectPcData", null);
+            }
+        }
+
+        internal static String Xml_ExpectSubOrClose
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExpectSubOrClose", null);
+            }
+        }
+
+        internal static String Xml_ExternalEntityInAttValue
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExternalEntityInAttValue", null);
+            }
+        }
+
+        internal static String Xml_ExternalEntityInStandAloneDocument
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ExternalEntityInStandAloneDocument", null);
+            }
+        }
+
+        internal static String Xml_FragmentId
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_FragmentId", null);
+            }
+        }
+
+        internal static String Xml_IncompatibleConformanceLevel
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_IncompatibleConformanceLevel", null);
+            }
+        }
+
+        internal static String Xml_IncompleteDtdContent
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_IncompleteDtdContent", null);
+            }
+        }
+
+        internal static String Xml_IncompleteEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_IncompleteEntity", null);
+            }
+        }
+
+        internal static String Xml_IndentCharsNotWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_IndentCharsNotWhitespace", null);
+            }
+        }
+
+        internal static String Xml_InternalError
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InternalError", null);
+            }
+        }
+
+        internal static String Xml_InvalidAttributeType
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidAttributeType", null);
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
+        internal static String Xml_InvalidCharInThisEncoding
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidCharInThisEncoding", null);
+            }
+        }
+
+        internal static String Xml_InvalidCharsInIndent
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidCharsInIndent", null);
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
+        internal static String Xml_InvalidConditionalSection
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidConditionalSection", null);
+            }
+        }
+
+        internal static String Xml_InvalidContentModel
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidContentModel", null);
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
+        internal static String Xml_InvalidNmToken
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidNmToken", null);
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
+        internal static String Xml_InvalidParEntityRef
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidParEntityRef", null);
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
+        internal static String Xml_InvalidPosition
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidPosition", null);
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
+        internal static String Xml_InvalidReadValueChunk
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidReadValueChunk", null);
+            }
+        }
+
+        internal static String Xml_InvalidRootData
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidRootData", null);
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
+        internal static String Xml_InvalidTextDecl
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidTextDecl", null);
+            }
+        }
+
+        internal static String Xml_InvalidVersionNumber
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidVersionNumber", null);
+            }
+        }
+
+        internal static String Xml_InvalidWhitespaceCharacter
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidWhitespaceCharacter", null);
+            }
+        }
+
+        internal static String Xml_InvalidXmlDecl
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_InvalidXmlDecl", null);
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
+        internal static String Xml_LimitExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_LimitExceeded", null);
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
+        internal static String Xml_MissingByteOrderMark
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MissingByteOrderMark", null);
+            }
+        }
+
+        internal static String Xml_MissingRoot
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MissingRoot", null);
+            }
+        }
+
+        internal static String Xml_MixedReadElementContentAs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MixedReadElementContentAs", null);
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
+        internal static String Xml_MixingReadValueChunkWithBinary
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MixingReadValueChunkWithBinary", null);
+            }
+        }
+
+        internal static String Xml_MixingV1StreamingWithV2Binary
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MixingV1StreamingWithV2Binary", null);
+            }
+        }
+
+        internal static String Xml_MultipleDTDsProvided
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MultipleDTDsProvided", null);
+            }
+        }
+
+        internal static String Xml_MultipleRoots
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_MultipleRoots", null);
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
+        internal static String Xml_NametableMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NametableMismatch", null);
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
+        internal static String Xml_NotEnoughSpaceForSurrogatePair
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NotEnoughSpaceForSurrogatePair", null);
+            }
+        }
+
+        internal static String Xml_NotSameNametable
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_NotSameNametable", null);
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
+        internal static String Xml_ReadBinaryContentNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ReadBinaryContentNotSupported", null);
+            }
+        }
+
+        internal static String Xml_ReadContentAsFormatException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ReadContentAsFormatException", null);
+            }
+        }
+
+        internal static String Xml_ReaderAsyncNotSetException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ReaderAsyncNotSetException", null);
+            }
+        }
+
+        internal static String Xml_ReadOnlyProperty
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ReadOnlyProperty", null);
+            }
+        }
+
+        internal static String Xml_ReadSubtreeNotOnElement
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ReadSubtreeNotOnElement", null);
+            }
+        }
+
+        internal static String Xml_ReadValueChunkNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_ReadValueChunkNotSupported", null);
+            }
+        }
+
+        internal static String Xml_RecursiveGenEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_RecursiveGenEntity", null);
+            }
+        }
+
+        internal static String Xml_RecursiveParEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_RecursiveParEntity", null);
+            }
+        }
+
+        internal static String Xml_RedefinePrefix
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_RedefinePrefix", null);
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
+        internal static String Xml_SystemPathResolverCannotOpenUri
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_SystemPathResolverCannotOpenUri", null);
+            }
+        }
+
+        internal static String Xml_TagMismatchEx
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_TagMismatchEx", null);
+            }
+        }
+
+        internal static String Xml_UnclosedConditionalSection
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnclosedConditionalSection", null);
+            }
+        }
+
+        internal static String Xml_UnclosedQuote
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnclosedQuote", null);
+            }
+        }
+
+        internal static String Xml_UndeclaredEntity
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UndeclaredEntity", null);
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
+        internal static String Xml_UnexpectedCDataEnd
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedCDataEnd", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedEndTag
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedEndTag", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedEOF
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedEOF", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedEOF1
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedEOF1", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedEOFInElementContent
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedEOFInElementContent", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedTokenEx
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedTokenEx", null);
+            }
+        }
+
+        internal static String Xml_UnexpectedTokens2
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnexpectedTokens2", null);
+            }
+        }
+
+        internal static String Xml_UnknownEncoding
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnknownEncoding", null);
+            }
+        }
+
+        internal static String Xml_UnknownNs
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnknownNs", null);
+            }
+        }
+
+        internal static String Xml_UnparsedEntityRef
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UnparsedEntityRef", null);
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
+        internal static String Xml_UserException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_UserException", null);
+            }
+        }
+
+        internal static String Xml_WriterAsyncNotSetException
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_WriterAsyncNotSetException", null);
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
+        internal static String Xml_XmlDeclNotFirst
+        {
+            get
+            {
+                return SR.GetResourceString("Xml_XmlDeclNotFirst", null);
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
+        internal static String XmlConvert_BadFormat
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_BadFormat", null);
+            }
+        }
+
+        internal static String XmlConvert_BadUri
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_BadUri", null);
+            }
+        }
+
+        internal static String XmlConvert_NotOneCharString
+        {
+            get
+            {
+                return SR.GetResourceString("XmlConvert_NotOneCharString", null);
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
