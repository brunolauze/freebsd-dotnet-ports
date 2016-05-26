--- /dev/null	2016-03-04 14:30:57.000000000 -0500
+++ src/System.Collections/src/SR.cs	2016-03-04 14:31:54.296448000 -0500
@@ -0,0 +1,408 @@
+using System.Resources;
+
+namespace FxResources.System.Collections
+{
+	internal class SR
+	{
+	}
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const string s_resourcesName = "FxResources.System.Collections.SR";
+
+        internal static string SortedSet_LowerValueGreaterThanUpperValue
+        {
+            get
+            {
+                return SR.GetResourceString("SortedSet_LowerValueGreaterThanUpperValue", null);
+            }
+        }
+
+        internal static string Arg_ArrayLengthsDiffer
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ArrayLengthsDiffer", null);
+            }
+        }
+
+        internal static string Arg_ArrayPlusOffTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ArrayPlusOffTooSmall", null);
+            }
+        }
+
+        internal static string Arg_BitArrayTypeUnsupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_BitArrayTypeUnsupported", null);
+            }
+        }
+
+        internal static string Arg_HSCapacityOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_HSCapacityOverflow", null);
+            }
+        }
+
+        internal static string Arg_HTCapacityOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_HTCapacityOverflow", null);
+            }
+        }
+
+        internal static string Arg_InsufficientSpace
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InsufficientSpace", null);
+            }
+        }
+
+        internal static string Arg_MultiRank
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_MultiRank", null);
+            }
+        }
+
+        internal static string Arg_NonZeroLowerBound
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_NonZeroLowerBound", null);
+            }
+        }
+
+        internal static string Arg_RankMultiDimNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RankMultiDimNotSupported", null);
+            }
+        }
+
+        internal static string Arg_WrongType
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_WrongType", null);
+            }
+        }
+
+        internal static string Argument_AddingDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddingDuplicate", null);
+            }
+        }
+
+        internal static string Argument_ArrayTooLarge
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ArrayTooLarge", null);
+            }
+        }
+
+        internal static string Argument_ImplementIComparable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ImplementIComparable", null);
+            }
+        }
+
+        internal static string Argument_InvalidArgumentForComparison
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidArgumentForComparison", null);
+            }
+        }
+
+        internal static string Argument_InvalidArrayType
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidArrayType", null);
+            }
+        }
+
+        internal static string Argument_InvalidOffLen
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOffLen", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_BiggerThanCollection
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_BiggerThanCollection", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_Count
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Count", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_Index
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Index", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_ListInsert
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ListInsert", null);
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
+        internal static string ArgumentOutOfRange_NeedNonNegNumRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNumRequired", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_SmallCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_SmallCapacity", null);
+            }
+        }
+
+        internal static string ExternalLinkedListNode
+        {
+            get
+            {
+                return SR.GetResourceString("ExternalLinkedListNode", null);
+            }
+        }
+
+        internal static string IndexOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("IndexOutOfRange", null);
+            }
+        }
+
+        internal static string Invalid_Array_Type
+        {
+            get
+            {
+                return SR.GetResourceString("Invalid_Array_Type", null);
+            }
+        }
+
+        internal static string InvalidOperation_EmptyQueue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EmptyQueue", null);
+            }
+        }
+
+        internal static string InvalidOperation_EmptyStack
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EmptyStack", null);
+            }
+        }
+
+        internal static string InvalidOperation_EnumEnded
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumEnded", null);
+            }
+        }
+
+        internal static string InvalidOperation_EnumFailedVersion
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumFailedVersion", null);
+            }
+        }
+
+        internal static string InvalidOperation_EnumNotStarted
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumNotStarted", null);
+            }
+        }
+
+        internal static string InvalidOperation_EnumOpCantHappen
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null);
+            }
+        }
+
+        internal static string LinkedListEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("LinkedListEmpty", null);
+            }
+        }
+
+        internal static string LinkedListNodeIsAttached
+        {
+            get
+            {
+                return SR.GetResourceString("LinkedListNodeIsAttached", null);
+            }
+        }
+
+        internal static string NotSupported_KeyCollectionSet
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_KeyCollectionSet", null);
+            }
+        }
+
+        internal static string NotSupported_SortedListNestedWrite
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_SortedListNestedWrite", null);
+            }
+        }
+
+        internal static string NotSupported_ValueCollectionSet
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_ValueCollectionSet", null);
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
+                return typeof(FxResources.System.Collections.SR);
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
+            if (str == null)
+            {
+                throw new MissingManifestResourceException(string.Concat("Unable to find resource for the key ", resourceKey, "."));
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
