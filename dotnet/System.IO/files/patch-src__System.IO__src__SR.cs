--- /dev/null	2016-03-10 13:26:25.000000000 -0500
+++ src/System.IO/src/SR.cs	2016-03-10 13:26:52.552161000 -0500
@@ -0,0 +1,369 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO
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
+        private const string s_resourcesName = "FxResources.System.IO.SR";
+
+		internal static string ArgumentOutOfRange_StreamLength
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_StreamLength", null);
+            }
+        }
+		
+		internal static string IO_IO_StreamTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("IO_IO_StreamTooLong", null);
+            }
+        }
+		
+		internal static string ArgumentNull_Stream
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Stream", null);
+            }
+        }
+		
+		internal static string InvalidOperation_TimeoutsNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_TimeoutsNotSupported", null);
+            }
+        }
+		
+		internal static string InvalidOperation_AsyncIOInProgress
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_AsyncIOInProgress", null);
+            }
+        }
+		
+		internal static string Arg_SurrogatesNotAllowedAsSingleChar
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_SurrogatesNotAllowedAsSingleChar", null);
+            }
+        }
+		
+		internal static string IO_IO_SeekBeforeBegin
+        {
+            get
+            {
+                return SR.GetResourceString("IO_IO_SeekBeforeBegin", null);
+            }
+        }
+		
+		internal static string Argument_InvalidSeekOrigin
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidSeekOrigin", null);
+            }
+        }
+		
+		internal static string ArgumentOutOfRange_SmallCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_SmallCapacity", null);
+            }
+        }
+		
+		internal static string NotSupported_MemStreamNotExpandable
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_MemStreamNotExpandable", null);
+            }
+        }
+		
+		internal static string ArgumentOutOfRange_NegativeCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NegativeCapacity", null);
+            }
+        }
+		
+		internal static string Arg_EndOfStreamException
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_EndOfStreamException", null);
+            }
+        }
+		
+		
+		internal static string ArgumentOutOfRange_BinaryReaderFillBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_BinaryReaderFillBuffer", null);
+            }
+        }
+		
+		internal static string Arg_DecBitCtor
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_DecBitCtor", null);
+            }
+        }
+		
+		internal static string IO_IO_InvalidStringLen_Len
+        {
+            get
+            {
+                return SR.GetResourceString("IO_IO_InvalidStringLen_Len", null);
+            }
+        }
+		
+		internal static string Argument_StreamNotReadable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_StreamNotReadable", null);
+            }
+        }
+		
+		internal static string Argument_StreamNotWritable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_StreamNotWritable", null);
+            }
+        }
+		
+		internal static string ObjectDisposed_WriterClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_WriterClosed", null);
+            }
+        }
+		
+		internal static string ArgumentOutOfRange_NeedPosNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPosNum", null);
+            }
+        }
+		
+		internal static string ObjectDisposed_FileClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_FileClosed", null);
+            }
+        }
+		
+		
+		internal static string ObjectDisposed_ReaderClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_ReaderClosed", null);
+            }
+        }
+		
+		internal static string Format_Bad7BitInt32
+        {
+            get
+            {
+                return SR.GetResourceString("Format_Bad7BitInt32", null);
+            }
+        }
+		
+		internal static string IO_EOF_ReadBeyondEOF
+        {
+            get
+            {
+                return SR.GetResourceString("IO_EOF_ReadBeyondEOF", null);
+            }
+        }
+		
+		
+        internal static string Argument_InvalidOffLen
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOffLen", null);
+            }
+        }
+
+        internal static string ArgumentNull_Buffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Buffer", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_MustBePositive
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_MustBePositive", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static string GenericInvalidData
+        {
+            get
+            {
+                return SR.GetResourceString("GenericInvalidData", null);
+            }
+        }
+
+        internal static string NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed", null);
+            }
+        }
+
+        internal static string NotSupported_UnreadableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnreadableStream", null);
+            }
+        }
+
+        internal static string NotSupported_UnseekableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnseekableStream", null);
+            }
+        }
+
+        internal static string NotSupported_UnwritableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnwritableStream", null);
+            }
+        }
+
+        internal static string ObjectDisposed_StreamClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_StreamClosed", null);
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
+                return typeof(FxResources.System.IO.SR);
+            }
+        }
+
+        internal static string Format(string resourceFormat, params object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, args);
+            }
+            return string.Concat(resourceFormat, string.Join(", ", args));
+        }
+
+        internal static string Format(string resourceFormat, object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1 });
+        }
+
+        internal static string Format(string resourceFormat, object p1, object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1, p2);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static string Format(string resourceFormat, object p1, object p2, object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1, p2, p3);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static string GetResourceString(string resourceKey, string defaultString)
+        {
+            string str = null;
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
+        private static bool UsingResourceKeys()
+        {
+            return false;
+        }
+    }
+}
