--- /dev/null	2016-08-03 16:33:00.000000000 -0400
+++ src/System.ValueTuple/src/SR.cs	2016-08-03 16:34:05.860265000 -0400
@@ -0,0 +1,23 @@
+using System.Resources;
+using System.Runtime.CompilerServices;
+
+namespace FxResources.System.ValueTuple
+{
+   public class SR
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
+        public static Type ResourceType { get { return typeof(FxResources.System.ValueTuple.SR); } }
+
+	public static string ArgumentException_ValueTupleIncorrectType { get { return GetResourceString(nameof(ArgumentException_ValueTupleIncorrectType), ""); } }
+	public static string ArgumentException_ValueTupleLastArgumentNotAValueTuple { get { return GetResourceString(nameof(ArgumentException_ValueTupleLastArgumentNotAValueTuple), ""); } }
+
+    }
+}
