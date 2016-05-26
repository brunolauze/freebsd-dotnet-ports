--- /dev/null	2016-03-10 10:22:00.000000000 -0500
+++ src/System.IO.UnmanagedMemoryStream/src/SR.cs	2016-03-10 10:27:47.592043000 -0500
@@ -0,0 +1,334 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.UnmanagedMemoryStream
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
+        private const String s_resourcesName = "FxResources.System.IO.UnmanagedMemoryStream.SR";
+
+        internal static String Arg_BadDecimal
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_BadDecimal", null);
+            }
+        }
+
+        internal static String Arg_BufferTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_BufferTooSmall", null);
+            }
+        }
+
+        internal static String Argument_InvalidOffLen
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOffLen", null);
+            }
+        }
+
+        internal static String Argument_InvalidSafeBufferOffLen
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidSafeBufferOffLen", null);
+            }
+        }
+
+        internal static String Argument_InvalidSeekOrigin
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidSeekOrigin", null);
+            }
+        }
+
+        internal static String Argument_NotEnoughBytesToRead
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NotEnoughBytesToRead", null);
+            }
+        }
+
+        internal static String Argument_NotEnoughBytesToWrite
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NotEnoughBytesToWrite", null);
+            }
+        }
+
+        internal static String Argument_OffsetAndCapacityOutOfBounds
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_OffsetAndCapacityOutOfBounds", null);
+            }
+        }
+
+        internal static String Argument_UnmanagedMemAccessorWrapAround
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_UnmanagedMemAccessorWrapAround", null);
+            }
+        }
+
+        internal static String ArgumentNull_Buffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Buffer", null);
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
+        internal static String ArgumentOutOfRange_LengthGreaterThanCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_LengthGreaterThanCapacity", null);
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
+        internal static String ArgumentOutOfRange_NeedPosNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPosNum", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_PositionLessThanCapacityRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_StreamLength
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_StreamLength", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_UnmanagedMemStreamWrapAround
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_UnmanagedMemStreamWrapAround", null);
+            }
+        }
+
+        internal static String IndexOutOfRange_UMSPosition
+        {
+            get
+            {
+                return SR.GetResourceString("IndexOutOfRange_UMSPosition", null);
+            }
+        }
+
+        internal static String InvalidOperation_CalledTwice
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_CalledTwice", null);
+            }
+        }
+
+        internal static String IO_FixedCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FixedCapacity", null);
+            }
+        }
+
+        internal static String IO_SeekBeforeBegin
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SeekBeforeBegin", null);
+            }
+        }
+
+        internal static String IO_StreamTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("IO_StreamTooLong", null);
+            }
+        }
+
+        internal static String NotSupported_Reading
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_Reading", null);
+            }
+        }
+
+        internal static String NotSupported_UmsSafeBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UmsSafeBuffer", null);
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
+        internal static String NotSupported_Writing
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_Writing", null);
+            }
+        }
+
+        internal static String ObjectDisposed_StreamIsClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_StreamIsClosed", null);
+            }
+        }
+
+        internal static String ObjectDisposed_ViewAccessorClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_ViewAccessorClosed", null);
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
+                return typeof(FxResources.System.IO.UnmanagedMemoryStream.SR);
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
