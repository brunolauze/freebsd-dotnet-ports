--- /dev/null	2016-08-22 06:38:27.000000000 -0400
+++ src/System.IO.Compression/src/SR.cs	2016-08-22 06:39:21.344262000 -0400
@@ -0,0 +1,656 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.Compression
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
+        private const String s_resourcesName = "FxResources.System.IO.Compression.SR";
+
+	internal static string UnsupportedCompressionMethod { get { return SR.GetResourceString("UnsupportedCompressionMethod", null); } }
+
+        internal static String Argument_InvalidPathChars
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidPathChars", null);
+            }
+        }
+
+        internal static String ArgumentNeedNonNegative
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNeedNonNegative", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_Enum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Enum", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_NeedPosNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPosNum", null);
+            }
+        }
+
+        internal static String CannotBeEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("CannotBeEmpty", null);
+            }
+        }
+
+        internal static String CannotReadFromDeflateStream
+        {
+            get
+            {
+                return SR.GetResourceString("CannotReadFromDeflateStream", null);
+            }
+        }
+
+        internal static String CannotWriteToDeflateStream
+        {
+            get
+            {
+                return SR.GetResourceString("CannotWriteToDeflateStream", null);
+            }
+        }
+
+        internal static String CDCorrupt
+        {
+            get
+            {
+                return SR.GetResourceString("CDCorrupt", null);
+            }
+        }
+
+        internal static String CentralDirectoryInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("CentralDirectoryInvalid", null);
+            }
+        }
+
+        internal static String CorruptedGZipHeader
+        {
+            get
+            {
+                return SR.GetResourceString("CorruptedGZipHeader", null);
+            }
+        }
+
+        internal static String CreateInReadMode
+        {
+            get
+            {
+                return SR.GetResourceString("CreateInReadMode", null);
+            }
+        }
+
+        internal static String CreateModeCapabilities
+        {
+            get
+            {
+                return SR.GetResourceString("CreateModeCapabilities", null);
+            }
+        }
+
+        internal static String CreateModeCreateEntryWhileOpen
+        {
+            get
+            {
+                return SR.GetResourceString("CreateModeCreateEntryWhileOpen", null);
+            }
+        }
+
+        internal static String CreateModeWriteOnceAndOneEntryAtATime
+        {
+            get
+            {
+                return SR.GetResourceString("CreateModeWriteOnceAndOneEntryAtATime", null);
+            }
+        }
+
+        internal static String DateTimeOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("DateTimeOutOfRange", null);
+            }
+        }
+
+        internal static String DeletedEntry
+        {
+            get
+            {
+                return SR.GetResourceString("DeletedEntry", null);
+            }
+        }
+
+        internal static String DeleteOnlyInUpdate
+        {
+            get
+            {
+                return SR.GetResourceString("DeleteOnlyInUpdate", null);
+            }
+        }
+
+        internal static String DeleteOpenEntry
+        {
+            get
+            {
+                return SR.GetResourceString("DeleteOpenEntry", null);
+            }
+        }
+
+        internal static String EntriesInCreateMode
+        {
+            get
+            {
+                return SR.GetResourceString("EntriesInCreateMode", null);
+            }
+        }
+
+        internal static String EntryNameEncodingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("EntryNameEncodingNotSupported", null);
+            }
+        }
+
+        internal static String EntryNamesTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("EntryNamesTooLong", null);
+            }
+        }
+
+        internal static String EntryTooLarge
+        {
+            get
+            {
+                return SR.GetResourceString("EntryTooLarge", null);
+            }
+        }
+
+        internal static String EOCDNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("EOCDNotFound", null);
+            }
+        }
+
+        internal static String FieldTooBigCompressedSize
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigCompressedSize", null);
+            }
+        }
+
+        internal static String FieldTooBigLocalHeaderOffset
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigLocalHeaderOffset", null);
+            }
+        }
+
+        internal static String FieldTooBigNumEntries
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigNumEntries", null);
+            }
+        }
+
+        internal static String FieldTooBigOffsetToCD
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigOffsetToCD", null);
+            }
+        }
+
+        internal static String FieldTooBigOffsetToZip64EOCD
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigOffsetToZip64EOCD", null);
+            }
+        }
+
+        internal static String FieldTooBigStartDiskNumber
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigStartDiskNumber", null);
+            }
+        }
+
+        internal static String FieldTooBigUncompressedSize
+        {
+            get
+            {
+                return SR.GetResourceString("FieldTooBigUncompressedSize", null);
+            }
+        }
+
+        internal static String FileNameContainsInvalidCharacters
+        {
+            get
+            {
+                return SR.GetResourceString("FileNameContainsInvalidCharacters", null);
+            }
+        }
+
+        internal static String FrozenAfterWrite
+        {
+            get
+            {
+                return SR.GetResourceString("FrozenAfterWrite", null);
+            }
+        }
+
+        internal static String GenericInvalidData
+        {
+            get
+            {
+                return SR.GetResourceString("GenericInvalidData", null);
+            }
+        }
+
+        internal static String HiddenStreamName
+        {
+            get
+            {
+                return SR.GetResourceString("HiddenStreamName", null);
+            }
+        }
+
+        internal static String InvalidArgumentOffsetCount
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidArgumentOffsetCount", null);
+            }
+        }
+
+        internal static String InvalidBeginCall
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidBeginCall", null);
+            }
+        }
+
+        internal static String InvalidBlockLength
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidBlockLength", null);
+            }
+        }
+
+        internal static String InvalidCRC
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCRC", null);
+            }
+        }
+
+        internal static String InvalidHuffmanData
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidHuffmanData", null);
+            }
+        }
+
+        internal static String InvalidStreamSize
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidStreamSize", null);
+            }
+        }
+
+        internal static String LengthAfterWrite
+        {
+            get
+            {
+                return SR.GetResourceString("LengthAfterWrite", null);
+            }
+        }
+
+        internal static String LocalFileHeaderCorrupt
+        {
+            get
+            {
+                return SR.GetResourceString("LocalFileHeaderCorrupt", null);
+            }
+        }
+
+        internal static String NotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported", null);
+            }
+        }
+
+        internal static String NotSupported_UnreadableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnreadableStream", null);
+            }
+        }
+
+        internal static String NotSupported_UnwritableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnwritableStream", null);
+            }
+        }
+
+        internal static String NumEntriesWrong
+        {
+            get
+            {
+                return SR.GetResourceString("NumEntriesWrong", null);
+            }
+        }
+
+        internal static String ObjectDisposed_StreamClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_StreamClosed", null);
+            }
+        }
+
+        internal static String OffsetLengthInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("OffsetLengthInvalid", null);
+            }
+        }
+
+        internal static String ReadingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ReadingNotSupported", null);
+            }
+        }
+
+        internal static String ReadModeCapabilities
+        {
+            get
+            {
+                return SR.GetResourceString("ReadModeCapabilities", null);
+            }
+        }
+
+        internal static String ReadOnlyArchive
+        {
+            get
+            {
+                return SR.GetResourceString("ReadOnlyArchive", null);
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
+                return typeof(FxResources.System.IO.Compression.SR);
+            }
+        }
+
+        internal static String SeekingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("SeekingNotSupported", null);
+            }
+        }
+
+        internal static String SetLengthRequiresSeekingAndWriting
+        {
+            get
+            {
+                return SR.GetResourceString("SetLengthRequiresSeekingAndWriting", null);
+            }
+        }
+
+        internal static String SplitSpanned
+        {
+            get
+            {
+                return SR.GetResourceString("SplitSpanned", null);
+            }
+        }
+
+        internal static String UnexpectedEndOfStream
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedEndOfStream", null);
+            }
+        }
+
+        internal static String UnknownBlockType
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownBlockType", null);
+            }
+        }
+
+        internal static String UnknownCompressionMode
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownCompressionMode", null);
+            }
+        }
+
+        internal static String UnknownState
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownState", null);
+            }
+        }
+
+        internal static String UnsupportedCompression
+        {
+            get
+            {
+                return SR.GetResourceString("UnsupportedCompression", null);
+            }
+        }
+
+        internal static String UpdateModeCapabilities
+        {
+            get
+            {
+                return SR.GetResourceString("UpdateModeCapabilities", null);
+            }
+        }
+
+        internal static String UpdateModeOneStream
+        {
+            get
+            {
+                return SR.GetResourceString("UpdateModeOneStream", null);
+            }
+        }
+
+        internal static String WritingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("WritingNotSupported", null);
+            }
+        }
+
+        internal static String Zip64EOCDNotWhereExpected
+        {
+            get
+            {
+                return SR.GetResourceString("Zip64EOCDNotWhereExpected", null);
+            }
+        }
+
+        internal static String ZLibErrorDLLLoadError
+        {
+            get
+            {
+                return SR.GetResourceString("ZLibErrorDLLLoadError", null);
+            }
+        }
+
+        internal static String ZLibErrorInconsistentStream
+        {
+            get
+            {
+                return SR.GetResourceString("ZLibErrorInconsistentStream", null);
+            }
+        }
+
+        internal static String ZLibErrorIncorrectInitParameters
+        {
+            get
+            {
+                return SR.GetResourceString("ZLibErrorIncorrectInitParameters", null);
+            }
+        }
+
+        internal static String ZLibErrorNotEnoughMemory
+        {
+            get
+            {
+                return SR.GetResourceString("ZLibErrorNotEnoughMemory", null);
+            }
+        }
+
+        internal static String ZLibErrorUnexpected
+        {
+            get
+            {
+                return SR.GetResourceString("ZLibErrorUnexpected", null);
+            }
+        }
+
+        internal static String ZLibErrorVersionMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("ZLibErrorVersionMismatch", null);
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
