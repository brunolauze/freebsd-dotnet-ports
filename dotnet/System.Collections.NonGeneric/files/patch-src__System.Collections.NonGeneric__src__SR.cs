--- /dev/null	2016-03-07 15:44:00.000000000 -0500
+++ src/System.Collections.NonGeneric/src/SR.cs	2016-03-07 15:43:39.904905000 -0500
@@ -0,0 +1,366 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Collections.NonGeneric
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
+        private const String s_resourcesName = "FxResources.System.Collections.NonGeneric.SR";
+
+        internal static String Arg_ArrayPlusOffTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ArrayPlusOffTooSmall", null);
+            }
+        }
+
+        internal static String Arg_HTCapacityOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_HTCapacityOverflow", null);
+            }
+        }
+
+        internal static String Arg_RankMultiDimNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RankMultiDimNotSupported", null);
+            }
+        }
+
+        internal static String Arg_RemoveArgNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RemoveArgNotFound", null);
+            }
+        }
+
+        internal static String Argument_AddingDuplicate__
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddingDuplicate__", null);
+            }
+        }
+
+        internal static String Argument_ImplementIComparable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ImplementIComparable", null);
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
+        internal static String ArgumentNull_Array
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Array", null);
+            }
+        }
+
+        internal static String ArgumentNull_Collection
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Collection", null);
+            }
+        }
+
+        internal static String ArgumentNull_Dictionary
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Dictionary", null);
+            }
+        }
+
+        internal static String ArgumentNull_Key
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Key", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_ArrayListInsert
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ArrayListInsert", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_BiggerThanCollection
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_BiggerThanCollection", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_Count
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Count", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_HashtableLoadFactor
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_HashtableLoadFactor", null);
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
+        internal static String ArgumentOutOfRange_MustBeNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_MustBeNonNegNum", null);
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
+        internal static String ArgumentOutOfRange_QueueGrowFactor
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_QueueGrowFactor", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_SmallCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_SmallCapacity", null);
+            }
+        }
+
+        internal static String InvalidOperation_EmptyQueue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EmptyQueue", null);
+            }
+        }
+
+        internal static String InvalidOperation_EmptyStack
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EmptyStack", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumEnded
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumEnded", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumFailedVersion
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumFailedVersion", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumNotStarted
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumNotStarted", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumOpCantHappen
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null);
+            }
+        }
+
+        internal static String InvalidOperation_HashInsertFailed
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_HashInsertFailed", null);
+            }
+        }
+
+        internal static String InvalidOperation_UnderlyingArrayListChanged
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_UnderlyingArrayListChanged", null);
+            }
+        }
+
+        internal static String NotSupported_FixedSizeCollection
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_FixedSizeCollection", null);
+            }
+        }
+
+        internal static String NotSupported_KeyCollectionSet
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_KeyCollectionSet", null);
+            }
+        }
+
+        internal static String NotSupported_RangeCollection
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_RangeCollection", null);
+            }
+        }
+
+        internal static String NotSupported_ReadOnlyCollection
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_ReadOnlyCollection", null);
+            }
+        }
+
+        internal static String NotSupported_SortedListNestedWrite
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_SortedListNestedWrite", null);
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
+                return typeof(FxResources.System.Collections.NonGeneric.SR);
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
