--- /dev/null	2016-03-07 16:37:41.000000000 -0500
+++ src/System.Collections.Concurrent/src/SR.cs	2016-03-07 16:38:06.780359000 -0500
@@ -0,0 +1,422 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Collections.Concurrent
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
+        private const String s_resourcesName = "FxResources.System.Collections.Concurrent.SR";
+
+        internal static String BlockingCollection_Add_ConcurrentCompleteAdd
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_Add_ConcurrentCompleteAdd", null);
+            }
+        }
+
+        internal static String BlockingCollection_Add_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_Add_Failed", null);
+            }
+        }
+
+        internal static String BlockingCollection_CantAddAnyWhenCompleted
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CantAddAnyWhenCompleted", null);
+            }
+        }
+
+        internal static String BlockingCollection_CantTakeAnyWhenAllDone
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CantTakeAnyWhenAllDone", null);
+            }
+        }
+
+        internal static String BlockingCollection_CantTakeWhenDone
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CantTakeWhenDone", null);
+            }
+        }
+
+        internal static String BlockingCollection_Completed
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_Completed", null);
+            }
+        }
+
+        internal static String BlockingCollection_CopyTo_IncorrectType
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CopyTo_IncorrectType", null);
+            }
+        }
+
+        internal static String BlockingCollection_CopyTo_MultiDim
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CopyTo_MultiDim", null);
+            }
+        }
+
+        internal static String BlockingCollection_CopyTo_NonNegative
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CopyTo_NonNegative", null);
+            }
+        }
+
+        internal static String BlockingCollection_CopyTo_TooManyElems
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_CopyTo_TooManyElems", null);
+            }
+        }
+
+        internal static String BlockingCollection_ctor_BoundedCapacityRange
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_ctor_BoundedCapacityRange", null);
+            }
+        }
+
+        internal static String BlockingCollection_ctor_CountMoreThanCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_ctor_CountMoreThanCapacity", null);
+            }
+        }
+
+        internal static String BlockingCollection_Disposed
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_Disposed", null);
+            }
+        }
+
+        internal static String BlockingCollection_Take_CollectionModified
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_Take_CollectionModified", null);
+            }
+        }
+
+        internal static String BlockingCollection_TimeoutInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_TimeoutInvalid", null);
+            }
+        }
+
+        internal static String BlockingCollection_ValidateCollectionsArray_DispElems
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_ValidateCollectionsArray_DispElems", null);
+            }
+        }
+
+        internal static String BlockingCollection_ValidateCollectionsArray_LargeSize
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_ValidateCollectionsArray_LargeSize", null);
+            }
+        }
+
+        internal static String BlockingCollection_ValidateCollectionsArray_NullElems
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_ValidateCollectionsArray_NullElems", null);
+            }
+        }
+
+        internal static String BlockingCollection_ValidateCollectionsArray_ZeroSize
+        {
+            get
+            {
+                return SR.GetResourceString("BlockingCollection_ValidateCollectionsArray_ZeroSize", null);
+            }
+        }
+
+        internal static String Common_OperationCanceled
+        {
+            get
+            {
+                return SR.GetResourceString("Common_OperationCanceled", null);
+            }
+        }
+
+        internal static String ConcurrentBag_CopyTo_ArgumentNullException
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentBag_CopyTo_ArgumentNullException", null);
+            }
+        }
+
+        internal static String ConcurrentBag_CopyTo_ArgumentOutOfRangeException
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentBag_CopyTo_ArgumentOutOfRangeException", null);
+            }
+        }
+
+        internal static String ConcurrentBag_Ctor_ArgumentNullException
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentBag_Ctor_ArgumentNullException", null);
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
+        internal static String ConcurrentDictionary_ArrayIncorrectType
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_ArrayIncorrectType", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_ArrayNotLargeEnough
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_ArrayNotLargeEnough", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_CapacityMustNotBeNegative
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_CapacityMustNotBeNegative", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_ConcurrencyLevelMustBePositive
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_ConcurrencyLevelMustBePositive", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_IndexIsNegative
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_IndexIsNegative", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_ItemKeyIsNull
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_ItemKeyIsNull", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_KeyAlreadyExisted
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_KeyAlreadyExisted", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_SourceContainsDuplicateKeys
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_SourceContainsDuplicateKeys", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_TypeOfKeyIncorrect
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_TypeOfKeyIncorrect", null);
+            }
+        }
+
+        internal static String ConcurrentDictionary_TypeOfValueIncorrect
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentDictionary_TypeOfValueIncorrect", null);
+            }
+        }
+
+        internal static String ConcurrentStack_PushPopRange_CountOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentStack_PushPopRange_CountOutOfRange", null);
+            }
+        }
+
+        internal static String ConcurrentStack_PushPopRange_InvalidCount
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentStack_PushPopRange_InvalidCount", null);
+            }
+        }
+
+        internal static String ConcurrentStack_PushPopRange_StartOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("ConcurrentStack_PushPopRange_StartOutOfRange", null);
+            }
+        }
+
+        internal static String Partitioner_DynamicPartitionsNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Partitioner_DynamicPartitionsNotSupported", null);
+            }
+        }
+
+        internal static String PartitionerStatic_CanNotCallGetEnumeratorAfterSourceHasBeenDisposed
+        {
+            get
+            {
+                return SR.GetResourceString("PartitionerStatic_CanNotCallGetEnumeratorAfterSourceHasBeenDisposed", null);
+            }
+        }
+
+        internal static String PartitionerStatic_CurrentCalledBeforeMoveNext
+        {
+            get
+            {
+                return SR.GetResourceString("PartitionerStatic_CurrentCalledBeforeMoveNext", null);
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
+                return typeof(FxResources.System.Collections.Concurrent.SR);
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
