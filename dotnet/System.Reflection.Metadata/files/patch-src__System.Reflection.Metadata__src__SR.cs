--- /dev/null	2016-05-18 19:40:42.000000000 -0400
+++ src/System.Reflection.Metadata/src/SR.cs	2016-05-18 19:42:03.080784000 -0400
@@ -0,0 +1,349 @@
+using System.Resources;
+using System.Runtime.CompilerServices;
+
+namespace System.Reflection.Metadata
+{
+   public class Strings
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
+        public static Type ResourceType { get { return typeof(System.Reflection.Metadata.Strings); } }
+
+	internal static string HashTooShort
+        {
+            get
+            {
+                return SR.GetResourceString("HashTooShort", null);
+            }
+        }
+
+	internal static string ValueMustBeMultiple
+	{
+	    get
+	    {
+		return SR.GetResourceString("ValueMustBeMultiple", null);
+	    }
+	}
+
+	internal static string MustNotReturnNull
+	{
+	    get
+	    {
+		return SR.GetResourceString("MustNotReturnNull", null);
+	    }
+	}
+
+	internal static string UnknownSectionName
+	{
+	    get
+	    {
+		return SR.GetResourceString("UnknownSectionName", null);
+	    }
+	}
+
+	internal static string SignatureProviderReturnedInvalidSignature
+	{
+	    get
+	    {
+		return SR.GetResourceString("SignatureProviderReturnedInvalidSignature", null);
+	    }
+	}
+
+	internal static String UnexpectedOpCode
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedOpCode", null);
+            }
+        }
+		
+	internal static String ReturnedBuilderSizeTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("ReturnedBuilderSizeTooSmall", null);
+            }
+        }
+
+	internal static String UnexpectedHandleKind
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedHandleKind", null);
+            }
+        }
+
+	internal static String BaseReaderMustBeFullMetadataReader
+        {
+            get
+            {
+                return SR.GetResourceString("BaseReaderMustBeFullMetadataReader", null);
+            }
+        }
+
+	internal static String BuilderMustAligned
+        {
+            get
+            {
+                return SR.GetResourceString("BuilderMustAligned", null);
+            }
+        }
+
+
+	internal static String ExpectedListOfSize
+        {
+            get
+            {
+                return SR.GetResourceString("ExpectedListOfSize", null);
+            }
+        }
+		
+	internal static String ExpectedNonEmptyList
+        {
+            get
+            {
+                return SR.GetResourceString("ExpectedNonEmptyList", null);
+            }
+        }
+
+	internal static String ReadersMustBeDeltaReaders
+        {
+            get
+            {
+                return SR.GetResourceString("ReadersMustBeDeltaReaders", null);
+            }
+        }
+
+	internal static String InvalidConstantValueOfType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidConstantValueOfType", null);
+            }
+        }
+
+	internal static String HeapSizeLimitExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("HeapSizeLimitExceeded", null);
+            }
+        }
+
+	internal static String SignatureNotVarArg
+        {
+            get
+            {
+                return SR.GetResourceString("SignatureNotVarArg", null);
+            }
+        }
+
+	internal static String BranchBuilderNotAvailable
+        {
+            get
+            {
+                return SR.GetResourceString("BranchBuilderNotAvailable", null);
+            }
+        }
+		
+	internal static String BuilderAlreadyLinked
+        {
+            get
+            {
+                return SR.GetResourceString("BuilderAlreadyLinked", null);
+            }
+        }		
+
+	internal static String LabelDoesntBelongToBuilder
+        {
+            get
+            {
+                return SR.GetResourceString("LabelDoesntBelongToBuilder", null);
+            }
+        }		
+
+	internal static String BlobTooLarge
+        {
+            get
+            {
+                return SR.GetResourceString("BlobTooLarge", null);
+            }
+        }		
+
+	internal static String OutOfBoundsWrite
+        {
+            get
+            {
+                return SR.GetResourceString("OutOfBoundsWrite", null);
+            }
+        }				
+
+	public static string NotCodeViewEntry { get { return GetResourceString(nameof(NotCodeViewEntry), ""); } }
+
+		public static string NotTypeDefOrRefOrSpecHandle { get { return GetResourceString(nameof(NotTypeDefOrRefOrSpecHandle), ""); } }
+
+		public static string ImageTooSmall { get { return GetResourceString(nameof(ImageTooSmall), ""); } }
+  
+		public static string InvalidCorHeaderSize { get { return GetResourceString(nameof(InvalidCorHeaderSize), ""); } }
+  
+		public static string InvalidHandle { get { return GetResourceString(nameof(InvalidHandle), ""); } }
+
+		public static string InvalidLocalSignatureToken { get { return GetResourceString(nameof(InvalidLocalSignatureToken), ""); } }
+
+		public static string InvalidMetadataSectionSpan { get { return GetResourceString(nameof(InvalidMetadataSectionSpan), ""); } }
+
+		public static string InvalidMethodHeader1 { get { return GetResourceString(nameof(InvalidMethodHeader1), ""); } }
+
+		public static string InvalidMethodHeader2 { get { return GetResourceString(nameof(InvalidMethodHeader2), ""); } }
+
+		public static string InvalidPESignature { get { return GetResourceString(nameof(InvalidPESignature), ""); } }
+
+		public static string InvalidSehHeader { get { return GetResourceString(nameof(InvalidSehHeader), ""); } }
+
+		public static string InvalidToken { get { return GetResourceString(nameof(InvalidToken), ""); } }
+
+		public static string MetadataImageDoesNotRepresentAnAssembly { get { return GetResourceString(nameof(MetadataImageDoesNotRepresentAnAssembly), ""); } }
+
+		public static string StandaloneDebugMetadataImageDoesNotContainModuleTable { get { return GetResourceString(nameof(StandaloneDebugMetadataImageDoesNotContainModuleTable), ""); } }
+
+		public static string PEImageNotAvailable { get { return GetResourceString(nameof(PEImageNotAvailable), ""); } }
+
+		public static string MissingDataDirectory { get { return GetResourceString(nameof(MissingDataDirectory), ""); } }
+
+		public static string NotMetadataHeapHandle { get { return GetResourceString(nameof(NotMetadataHeapHandle), ""); } }
+
+		public static string NotMetadataTableOrUserStringHandle { get { return GetResourceString(nameof(NotMetadataTableOrUserStringHandle), ""); } }
+
+		public static string SectionTooSmall { get { return GetResourceString(nameof(SectionTooSmall), ""); } }
+
+		public static string StreamMustSupportReadAndSeek { get { return GetResourceString(nameof(StreamMustSupportReadAndSeek), ""); } }
+
+		public static string UnknownFileFormat { get { return GetResourceString(nameof(UnknownFileFormat), ""); } }
+
+		public static string UnknownPEMagicValue { get { return GetResourceString(nameof(UnknownPEMagicValue), ""); } }
+
+		public static string MetadataTableNotSorted { get { return GetResourceString(nameof(MetadataTableNotSorted), ""); } }
+
+		public static string AssemblyTableInvalidNumberOfRows { get { return GetResourceString(nameof(AssemblyTableInvalidNumberOfRows), ""); } }
+
+		public static string ModuleTableInvalidNumberOfRows { get { return GetResourceString(nameof(ModuleTableInvalidNumberOfRows), ""); } }
+
+		public static string UnknownTables { get { return GetResourceString(nameof(UnknownTables), ""); } }
+
+		public static string IllegalTablesInCompressedMetadataStream { get { return GetResourceString(nameof(IllegalTablesInCompressedMetadataStream), ""); } }
+
+		public static string TableRowCountSpaceTooSmall { get { return GetResourceString(nameof(TableRowCountSpaceTooSmall), ""); } }
+
+		public static string OutOfBoundsRead { get { return GetResourceString(nameof(OutOfBoundsRead), ""); } }
+
+		public static string MetadataHeaderTooSmall { get { return GetResourceString(nameof(MetadataHeaderTooSmall), ""); } }
+
+		public static string MetadataSignature { get { return GetResourceString(nameof(MetadataSignature), ""); } }
+
+		public static string NotEnoughSpaceForVersionString { get { return GetResourceString(nameof(NotEnoughSpaceForVersionString), ""); } }
+
+		public static string StreamHeaderTooSmall { get { return GetResourceString(nameof(StreamHeaderTooSmall), ""); } }
+
+		public static string NotEnoughSpaceForStreamHeaderName { get { return GetResourceString(nameof(NotEnoughSpaceForStreamHeaderName), ""); } }
+
+		public static string NotEnoughSpaceForStringStream { get { return GetResourceString(nameof(NotEnoughSpaceForStringStream), ""); } }
+
+		public static string NotEnoughSpaceForBlobStream { get { return GetResourceString(nameof(NotEnoughSpaceForBlobStream), ""); } }
+
+		public static string NotEnoughSpaceForGUIDStream { get { return GetResourceString(nameof(NotEnoughSpaceForGUIDStream), ""); } }
+
+		public static string NotEnoughSpaceForMetadataStream { get { return GetResourceString(nameof(NotEnoughSpaceForMetadataStream), ""); } }
+
+		public static string InvalidMetadataStreamFormat { get { return GetResourceString(nameof(InvalidMetadataStreamFormat), ""); } }
+
+		public static string MetadataTablesTooSmall { get { return GetResourceString(nameof(MetadataTablesTooSmall), ""); } }
+
+		public static string MetadataTableHeaderTooSmall { get { return GetResourceString(nameof(MetadataTableHeaderTooSmall), ""); } }
+
+		public static string WinMDMissingMscorlibRef { get { return GetResourceString(nameof(WinMDMissingMscorlibRef), ""); } }
+
+		public static string UnableToReadMetadataFile { get { return GetResourceString(nameof(UnableToReadMetadataFile), ""); } }
+
+		public static string UnexpectedStreamEnd { get { return GetResourceString(nameof(UnexpectedStreamEnd), ""); } }
+
+		public static string InvalidMethodRva { get { return GetResourceString(nameof(InvalidMethodRva), ""); } }
+
+		public static string CantGetOffsetForVirtualHeapHandle { get { return GetResourceString(nameof(CantGetOffsetForVirtualHeapHandle), ""); } }
+
+		public static string InvalidSectionName { get { return GetResourceString(nameof(InvalidSectionName), ""); } }
+
+		public static string InvalidNumberOfSections { get { return GetResourceString(nameof(InvalidNumberOfSections), ""); } }
+
+		public static string InvalidSignature { get { return GetResourceString(nameof(InvalidSignature), ""); } }
+
+		public static string PEImageDoesNotHaveMetadata { get { return GetResourceString(nameof(PEImageDoesNotHaveMetadata), ""); } }
+
+		public static string InvalidCodedIndex { get { return GetResourceString(nameof(InvalidCodedIndex), ""); } }
+
+		public static string InvalidCompressedInteger { get { return GetResourceString(nameof(InvalidCompressedInteger), ""); } }
+
+		public static string InvalidDocumentName { get { return GetResourceString(nameof(InvalidDocumentName), ""); } }
+
+		public static string RowIdOrHeapOffsetTooLarge { get { return GetResourceString(nameof(RowIdOrHeapOffsetTooLarge), ""); } }
+
+		public static string EnCMapNotSorted { get { return GetResourceString(nameof(EnCMapNotSorted), ""); } }
+
+		public static string InvalidSerializedString { get { return GetResourceString(nameof(InvalidSerializedString), ""); } }
+
+		public static string StreamTooLarge { get { return GetResourceString(nameof(StreamTooLarge), ""); } }
+
+		public static string NegativeByteCountOrOffset { get { return GetResourceString(nameof(NegativeByteCountOrOffset), ""); } }
+
+		public static string ImageTooSmallOrContainsInvalidOffsetOrCount { get { return GetResourceString(nameof(ImageTooSmallOrContainsInvalidOffsetOrCount), ""); } }
+
+		public static string LitteEndianArchitectureRequired { get { return GetResourceString(nameof(LitteEndianArchitectureRequired), ""); } }
+
+		public static string MetadataStringDecoderEncodingMustBeUtf8 { get { return GetResourceString(nameof(MetadataStringDecoderEncodingMustBeUtf8), ""); } }
+
+		public static string InvalidConstantValue { get { return GetResourceString(nameof(InvalidConstantValue), ""); } }
+
+		public static string InvalidImportDefinitionKind { get { return GetResourceString(nameof(InvalidImportDefinitionKind), ""); } }
+
+		public static string ValueTooLarge { get { return GetResourceString(nameof(ValueTooLarge), ""); } }
+
+		public static string InvalidTypeSize { get { return GetResourceString(nameof(InvalidTypeSize), ""); } }
+
+		public static string HandleBelongsToFutureGeneration { get { return GetResourceString(nameof(HandleBelongsToFutureGeneration), ""); } }
+
+		public static string InvalidRowCount { get { return GetResourceString(nameof(InvalidRowCount), ""); } }
+
+		public static string InvalidEntryPointToken { get { return GetResourceString(nameof(InvalidEntryPointToken), ""); } }
+
+		public static string TooManySubnamespaces { get { return GetResourceString(nameof(TooManySubnamespaces), ""); } }
+
+		public static string SequencePointValueOutOfRange { get { return GetResourceString(nameof(SequencePointValueOutOfRange), ""); } }
+
+		public static string InvalidDirectoryRVA { get { return GetResourceString(nameof(InvalidDirectoryRVA), ""); } }
+
+		public static string InvalidDirectorySize { get { return GetResourceString(nameof(InvalidDirectorySize), ""); } }
+
+		public static string InvalidDebugDirectoryEntryCharacteristics { get { return GetResourceString(nameof(InvalidDebugDirectoryEntryCharacteristics), ""); } }
+
+		public static string UnexpectedCodeViewDataSignature { get { return GetResourceString(nameof(UnexpectedCodeViewDataSignature), ""); } }
+
+		public static string InvalidPathPadding { get { return GetResourceString(nameof(InvalidPathPadding), ""); } }
+
+		public static string UnexpectedSignatureHeader { get { return GetResourceString(nameof(UnexpectedSignatureHeader), ""); } }
+
+		public static string UnexpectedSignatureHeader2 { get { return GetResourceString(nameof(UnexpectedSignatureHeader2), ""); } }
+
+		public static string NotTypeDefOrRefHandle { get { return GetResourceString(nameof(NotTypeDefOrRefHandle), ""); } }
+
+		public static string UnexpectedSignatureTypeCode { get { return GetResourceString(nameof(UnexpectedSignatureTypeCode), ""); } }
+
+		public static string SignatureTypeSequenceMustHaveAtLeastOneElement { get { return GetResourceString(nameof(SignatureTypeSequenceMustHaveAtLeastOneElement), ""); } }
+  
+    }
+}
