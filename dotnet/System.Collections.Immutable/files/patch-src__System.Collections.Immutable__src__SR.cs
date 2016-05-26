--- /dev/null	2016-01-19 22:11:00.000000000 -0500
+++ src/System.Collections.Immutable/src/SR.cs	2016-01-19 22:11:39.100228000 -0500
@@ -0,0 +1,30 @@
+using System.Resources;
+using System.Runtime.CompilerServices;
+
+namespace System.Collections.Immutable
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
+        public static Type ResourceType { get { return typeof(System.Collections.Immutable.Strings); } }
+
+        public static string ArrayInitializedStateNotEqual { get { return GetResourceString(nameof(ArrayInitializedStateNotEqual), ""); } }
+        public static string ArrayLengthsNotEqual { get { return GetResourceString(nameof(ArrayLengthsNotEqual), ""); } }
+        public static string CannotFindOldValue { get { return GetResourceString(nameof(CannotFindOldValue), ""); } }
+        public static string CapacityMustBeGreaterThanOrEqualToCount { get { return GetResourceString(nameof(CapacityMustBeGreaterThanOrEqualToCount), ""); } }
+        public static string CapacityMustEqualCountOnMove { get { return GetResourceString(nameof(CapacityMustEqualCountOnMove), ""); } }
+        public static string CollectionModifiedDuringEnumeration { get { return GetResourceString(nameof(CollectionModifiedDuringEnumeration), ""); } }
+        public static string DuplicateKey { get { return GetResourceString(nameof(DuplicateKey), ""); } }
+        public static string InvalidEmptyOperation { get { return GetResourceString(nameof(InvalidEmptyOperation), ""); } }
+        public static string InvalidOperationOnDefaultArray { get { return GetResourceString(nameof(InvalidOperationOnDefaultArray), ""); } }
+
+    }
+}
