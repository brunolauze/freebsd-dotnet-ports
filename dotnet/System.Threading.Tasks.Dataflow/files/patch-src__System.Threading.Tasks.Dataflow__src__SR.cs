--- /dev/null	2016-03-16 08:01:56.000000000 -0400
+++ src/System.Threading.Tasks.Dataflow/src/SR.cs	2016-03-16 08:02:26.394959000 -0400
@@ -0,0 +1,254 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Threading.Tasks.Dataflow
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
+        private const String s_resourcesName = "FxResources.System.Threading.Tasks.Dataflow.SR";
+
+        internal static String Argument_BoundedCapacityNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_BoundedCapacityNotSupported", null);
+            }
+        }
+
+        internal static String Argument_CantConsumeFromANullSource
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_CantConsumeFromANullSource", null);
+            }
+        }
+
+        internal static String Argument_InvalidMessageHeader
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidMessageHeader", null);
+            }
+        }
+
+        internal static String Argument_InvalidMessageId
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidMessageId", null);
+            }
+        }
+
+        internal static String Argument_InvalidSourceForFilteredLink
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidSourceForFilteredLink", null);
+            }
+        }
+
+        internal static String Argument_NonGreedyNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NonGreedyNotSupported", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_GenericPositive
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_GenericPositive", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_NeedNonNegOrNegative1
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1", null);
+            }
+        }
+
+        internal static String ConcurrentCollection_SyncRoot_NotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentCollection_SyncRoot_NotSupported", null);
+            }
+        }
+
+        internal static String event_DataflowBlockCompleted
+        {
+            get
+            {
+                return SR.GetResourceString("event_DataflowBlockCompleted", null);
+            }
+        }
+
+        internal static String event_DataflowBlockCreated
+        {
+            get
+            {
+                return SR.GetResourceString("event_DataflowBlockCreated", null);
+            }
+        }
+
+        internal static String event_DataflowBlockLinking
+        {
+            get
+            {
+                return SR.GetResourceString("event_DataflowBlockLinking", null);
+            }
+        }
+
+        internal static String event_DataflowBlockUnlinking
+        {
+            get
+            {
+                return SR.GetResourceString("event_DataflowBlockUnlinking", null);
+            }
+        }
+
+        internal static String event_TaskLaunchedForMessageHandling
+        {
+            get
+            {
+                return SR.GetResourceString("event_TaskLaunchedForMessageHandling", null);
+            }
+        }
+
+        internal static String InvalidOperation_DataNotAvailableForReceive
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_DataNotAvailableForReceive", null);
+            }
+        }
+
+        internal static String InvalidOperation_FailedToConsumeReservedMessage
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_FailedToConsumeReservedMessage", null);
+            }
+        }
+
+        internal static String InvalidOperation_MessageNotReservedByTarget
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_MessageNotReservedByTarget", null);
+            }
+        }
+
+        internal static String NotSupported_MemberNotNeeded
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_MemberNotNeeded", null);
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
+                return typeof(FxResources.System.Threading.Tasks.Dataflow.SR);
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
+                return String.Format(resourceFormat, new Object[] { p1 });
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, new Object[] { p1, p2 });
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, new Object[] { p1, p2, p3 });
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
+            if (defaultString != null && resourceKey.Equals(str, StringComparison.Ordinal))
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
