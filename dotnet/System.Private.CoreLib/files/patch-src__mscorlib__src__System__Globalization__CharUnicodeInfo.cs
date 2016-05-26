--- src/mscorlib/corefx/System/Globalization/CharUnicodeInfo.cs.orig	2016-05-05 22:13:45.550139000 -0400
+++ src/mscorlib/corefx/System/Globalization/CharUnicodeInfo.cs	2016-05-05 22:15:04.692607000 -0400
@@ -46,6 +46,16 @@
         // The starting codepoint for Unicode plane 1.  Plane 1 contains 0x010000 ~ 0x01ffff.
         internal const int UNICODE_PLANE01_START = 0x10000;
 
+	internal static BidiCategory GetBidiCategory(String s, int index) {
+            if (s==null)
+                throw new ArgumentNullException("s");
+            if (((uint)index)>=((uint)s.Length)) {
+                throw new ArgumentOutOfRangeException("index");
+            }
+            Contract.EndContractBlock();
+            return ((BidiCategory)InternalGetCategoryValue(InternalConvertToUtf32(s, index), BIDI_CATEGORY_OFFSET));
+        }
+
 
         ////////////////////////////////////////////////////////////////////////
         //
