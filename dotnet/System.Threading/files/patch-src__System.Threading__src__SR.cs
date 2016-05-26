--- /dev/null	2016-01-28 07:47:49.000000000 -0500
+++ src/System.Threading/src/SR.cs	2016-01-28 07:49:38.498826000 -0500
@@ -0,0 +1,382 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Threading
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
+        private const string s_resourcesName = "FxResources.System.Threading.SR";
+
+        internal static string Argument_SemaphoreInitialMaximum
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_SemaphoreInitialMaximum", null);
+            }
+        }
+
+        internal static string Argument_WaitHandleNameTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_WaitHandleNameTooLong", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_NeedNonNegNumRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNumRequired", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_NeedPosNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPosNum", null);
+            }
+        }
+
+        internal static string Barrier_AddParticipants_NonPositive_ArgumentOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_AddParticipants_NonPositive_ArgumentOutOfRange", null);
+            }
+        }
+
+        internal static string Barrier_AddParticipants_Overflow_ArgumentOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_AddParticipants_Overflow_ArgumentOutOfRange", null);
+            }
+        }
+
+        internal static string Barrier_ctor_ArgumentOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_ctor_ArgumentOutOfRange", null);
+            }
+        }
+
+        internal static string Barrier_Dispose
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_Dispose", null);
+            }
+        }
+
+        internal static string Barrier_InvalidOperation_CalledFromPHA
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_InvalidOperation_CalledFromPHA", null);
+            }
+        }
+
+        internal static string Barrier_RemoveParticipants_ArgumentOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_RemoveParticipants_ArgumentOutOfRange", null);
+            }
+        }
+
+        internal static string Barrier_RemoveParticipants_InvalidOperation
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_RemoveParticipants_InvalidOperation", null);
+            }
+        }
+
+        internal static string Barrier_RemoveParticipants_NonPositive_ArgumentOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_RemoveParticipants_NonPositive_ArgumentOutOfRange", null);
+            }
+        }
+
+        internal static string Barrier_SignalAndWait_ArgumentOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_SignalAndWait_ArgumentOutOfRange", null);
+            }
+        }
+
+        internal static string Barrier_SignalAndWait_InvalidOperation_ThreadsExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_SignalAndWait_InvalidOperation_ThreadsExceeded", null);
+            }
+        }
+
+        internal static string Barrier_SignalAndWait_InvalidOperation_ZeroTotal
+        {
+            get
+            {
+                return SR.GetResourceString("Barrier_SignalAndWait_InvalidOperation_ZeroTotal", null);
+            }
+        }
+
+        internal static string BarrierPostPhaseException
+        {
+            get
+            {
+                return SR.GetResourceString("BarrierPostPhaseException", null);
+            }
+        }
+
+        internal static string Common_OperationCanceled
+        {
+            get
+            {
+                return SR.GetResourceString("Common_OperationCanceled", null);
+            }
+        }
+
+        internal static string CountdownEvent_Decrement_BelowZero
+        {
+            get
+            {
+                return SR.GetResourceString("CountdownEvent_Decrement_BelowZero", null);
+            }
+        }
+
+        internal static string CountdownEvent_Increment_AlreadyMax
+        {
+            get
+            {
+                return SR.GetResourceString("CountdownEvent_Increment_AlreadyMax", null);
+            }
+        }
+
+        internal static string CountdownEvent_Increment_AlreadyZero
+        {
+            get
+            {
+                return SR.GetResourceString("CountdownEvent_Increment_AlreadyZero", null);
+            }
+        }
+
+        internal static string InvalidNullEmptyArgument
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidNullEmptyArgument", null);
+            }
+        }
+
+        internal static string LockRecursionException_ReadAfterWriteNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_ReadAfterWriteNotAllowed", null);
+            }
+        }
+
+        internal static string LockRecursionException_RecursiveReadNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_RecursiveReadNotAllowed", null);
+            }
+        }
+
+        internal static string LockRecursionException_RecursiveUpgradeNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_RecursiveUpgradeNotAllowed", null);
+            }
+        }
+
+        internal static string LockRecursionException_RecursiveWriteNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_RecursiveWriteNotAllowed", null);
+            }
+        }
+
+        internal static string LockRecursionException_UpgradeAfterReadNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_UpgradeAfterReadNotAllowed", null);
+            }
+        }
+
+        internal static string LockRecursionException_UpgradeAfterWriteNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_UpgradeAfterWriteNotAllowed", null);
+            }
+        }
+
+        internal static string LockRecursionException_WriteAfterReadNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("LockRecursionException_WriteAfterReadNotAllowed", null);
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
+                return typeof(FxResources.System.Threading.SR);
+            }
+        }
+
+        internal static string SynchronizationLockException_IncorrectDispose
+        {
+            get
+            {
+                return SR.GetResourceString("SynchronizationLockException_IncorrectDispose", null);
+            }
+        }
+
+        internal static string SynchronizationLockException_MisMatchedRead
+        {
+            get
+            {
+                return SR.GetResourceString("SynchronizationLockException_MisMatchedRead", null);
+            }
+        }
+
+        internal static string SynchronizationLockException_MisMatchedUpgrade
+        {
+            get
+            {
+                return SR.GetResourceString("SynchronizationLockException_MisMatchedUpgrade", null);
+            }
+        }
+
+        internal static string SynchronizationLockException_MisMatchedWrite
+        {
+            get
+            {
+                return SR.GetResourceString("SynchronizationLockException_MisMatchedWrite", null);
+            }
+        }
+
+        internal static string UnknownError_Num
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownError_Num", null);
+            }
+        }
+
+        internal static string WaitHandle_NamesNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("WaitHandle_NamesNotSupported", null);
+            }
+        }
+
+        internal static string WaitHandleCannotBeOpenedException_InvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("WaitHandleCannotBeOpenedException_InvalidHandle", null);
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
+            if (defaultString != null && resourceKey.Equals(str))
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
