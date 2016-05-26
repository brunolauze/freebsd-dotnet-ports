--- /dev/null	2016-04-27 06:33:13.000000000 -0400
+++ src/System.Text.Encoding.CodePages/src/SR.cs	2016-04-27 06:33:36.273713000 -0400
@@ -0,0 +1,1374 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Text.Encoding.CodePages
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
+        private const String s_resourcesName = "FxResources.System.Text.Encoding.CodePages.SR";
+
+        internal static String Arg_OutOfMemoryException
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_OutOfMemoryException", null);
+            }
+        }
+
+        internal static String Argument_CodepageNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_CodepageNotSupported", null);
+            }
+        }
+
+        internal static String Argument_EncoderFallbackNotEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EncoderFallbackNotEmpty", null);
+            }
+        }
+
+        internal static String Argument_EncodingConversionOverflowBytes
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EncodingConversionOverflowBytes", null);
+            }
+        }
+
+        internal static String Argument_EncodingConversionOverflowChars
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EncodingConversionOverflowChars", null);
+            }
+        }
+
+        internal static String Argument_InvalidCharSequenceNoIndex
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCharSequenceNoIndex", null);
+            }
+        }
+
+        internal static String Argument_RecursiveFallback
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_RecursiveFallback", null);
+            }
+        }
+
+        internal static String Argument_RecursiveFallbackBytes
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_RecursiveFallbackBytes", null);
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
+        internal static String ArgumentOutOfRange_GetByteCountOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_GetByteCountOverflow", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_GetCharCountOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_GetCharCountOverflow", null);
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
+        internal static String ArgumentOutOfRange_IndexCount
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_IndexCount", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_IndexCountBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_IndexCountBuffer", null);
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
+        internal static String ArgumentOutOfRange_Range
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Range", null);
+            }
+        }
+
+        internal static String Globalization_cp_10000
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10000", null);
+            }
+        }
+
+        internal static String Globalization_cp_10001
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10001", null);
+            }
+        }
+
+        internal static String Globalization_cp_10002
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10002", null);
+            }
+        }
+
+        internal static String Globalization_cp_10003
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10003", null);
+            }
+        }
+
+        internal static String Globalization_cp_10004
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10004", null);
+            }
+        }
+
+        internal static String Globalization_cp_10005
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10005", null);
+            }
+        }
+
+        internal static String Globalization_cp_10006
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10006", null);
+            }
+        }
+
+        internal static String Globalization_cp_10007
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10007", null);
+            }
+        }
+
+        internal static String Globalization_cp_10008
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10008", null);
+            }
+        }
+
+        internal static String Globalization_cp_10010
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10010", null);
+            }
+        }
+
+        internal static String Globalization_cp_10017
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10017", null);
+            }
+        }
+
+        internal static String Globalization_cp_10021
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10021", null);
+            }
+        }
+
+        internal static String Globalization_cp_10029
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10029", null);
+            }
+        }
+
+        internal static String Globalization_cp_10079
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10079", null);
+            }
+        }
+
+        internal static String Globalization_cp_10081
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10081", null);
+            }
+        }
+
+        internal static String Globalization_cp_10082
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_10082", null);
+            }
+        }
+
+        internal static String Globalization_cp_1026
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1026", null);
+            }
+        }
+
+        internal static String Globalization_cp_1047
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1047", null);
+            }
+        }
+
+        internal static String Globalization_cp_1140
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1140", null);
+            }
+        }
+
+        internal static String Globalization_cp_1141
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1141", null);
+            }
+        }
+
+        internal static String Globalization_cp_1142
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1142", null);
+            }
+        }
+
+        internal static String Globalization_cp_1143
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1143", null);
+            }
+        }
+
+        internal static String Globalization_cp_1144
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1144", null);
+            }
+        }
+
+        internal static String Globalization_cp_1145
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1145", null);
+            }
+        }
+
+        internal static String Globalization_cp_1146
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1146", null);
+            }
+        }
+
+        internal static String Globalization_cp_1147
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1147", null);
+            }
+        }
+
+        internal static String Globalization_cp_1148
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1148", null);
+            }
+        }
+
+        internal static String Globalization_cp_1149
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1149", null);
+            }
+        }
+
+        internal static String Globalization_cp_1250
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1250", null);
+            }
+        }
+
+        internal static String Globalization_cp_1251
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1251", null);
+            }
+        }
+
+        internal static String Globalization_cp_1252
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1252", null);
+            }
+        }
+
+        internal static String Globalization_cp_1253
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1253", null);
+            }
+        }
+
+        internal static String Globalization_cp_1254
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1254", null);
+            }
+        }
+
+        internal static String Globalization_cp_1255
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1255", null);
+            }
+        }
+
+        internal static String Globalization_cp_1256
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1256", null);
+            }
+        }
+
+        internal static String Globalization_cp_1257
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1257", null);
+            }
+        }
+
+        internal static String Globalization_cp_1258
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1258", null);
+            }
+        }
+
+        internal static String Globalization_cp_1361
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_1361", null);
+            }
+        }
+
+        internal static String Globalization_cp_20000
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20000", null);
+            }
+        }
+
+        internal static String Globalization_cp_20001
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20001", null);
+            }
+        }
+
+        internal static String Globalization_cp_20002
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20002", null);
+            }
+        }
+
+        internal static String Globalization_cp_20003
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20003", null);
+            }
+        }
+
+        internal static String Globalization_cp_20004
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20004", null);
+            }
+        }
+
+        internal static String Globalization_cp_20005
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20005", null);
+            }
+        }
+
+        internal static String Globalization_cp_20105
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20105", null);
+            }
+        }
+
+        internal static String Globalization_cp_20106
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20106", null);
+            }
+        }
+
+        internal static String Globalization_cp_20107
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20107", null);
+            }
+        }
+
+        internal static String Globalization_cp_20108
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20108", null);
+            }
+        }
+
+        internal static String Globalization_cp_20261
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20261", null);
+            }
+        }
+
+        internal static String Globalization_cp_20269
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20269", null);
+            }
+        }
+
+        internal static String Globalization_cp_20273
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20273", null);
+            }
+        }
+
+        internal static String Globalization_cp_20277
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20277", null);
+            }
+        }
+
+        internal static String Globalization_cp_20278
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20278", null);
+            }
+        }
+
+        internal static String Globalization_cp_20280
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20280", null);
+            }
+        }
+
+        internal static String Globalization_cp_20284
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20284", null);
+            }
+        }
+
+        internal static String Globalization_cp_20285
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20285", null);
+            }
+        }
+
+        internal static String Globalization_cp_20290
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20290", null);
+            }
+        }
+
+        internal static String Globalization_cp_20297
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20297", null);
+            }
+        }
+
+        internal static String Globalization_cp_20420
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20420", null);
+            }
+        }
+
+        internal static String Globalization_cp_20423
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20423", null);
+            }
+        }
+
+        internal static String Globalization_cp_20424
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20424", null);
+            }
+        }
+
+        internal static String Globalization_cp_20833
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20833", null);
+            }
+        }
+
+        internal static String Globalization_cp_20838
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20838", null);
+            }
+        }
+
+        internal static String Globalization_cp_20866
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20866", null);
+            }
+        }
+
+        internal static String Globalization_cp_20871
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20871", null);
+            }
+        }
+
+        internal static String Globalization_cp_20880
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20880", null);
+            }
+        }
+
+        internal static String Globalization_cp_20905
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20905", null);
+            }
+        }
+
+        internal static String Globalization_cp_20924
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20924", null);
+            }
+        }
+
+        internal static String Globalization_cp_20932
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20932", null);
+            }
+        }
+
+        internal static String Globalization_cp_20936
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20936", null);
+            }
+        }
+
+        internal static String Globalization_cp_20949
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_20949", null);
+            }
+        }
+
+        internal static String Globalization_cp_21025
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_21025", null);
+            }
+        }
+
+        internal static String Globalization_cp_21027
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_21027", null);
+            }
+        }
+
+        internal static String Globalization_cp_21866
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_21866", null);
+            }
+        }
+
+        internal static String Globalization_cp_28592
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28592", null);
+            }
+        }
+
+        internal static String Globalization_cp_28593
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28593", null);
+            }
+        }
+
+        internal static String Globalization_cp_28594
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28594", null);
+            }
+        }
+
+        internal static String Globalization_cp_28595
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28595", null);
+            }
+        }
+
+        internal static String Globalization_cp_28596
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28596", null);
+            }
+        }
+
+        internal static String Globalization_cp_28597
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28597", null);
+            }
+        }
+
+        internal static String Globalization_cp_28598
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28598", null);
+            }
+        }
+
+        internal static String Globalization_cp_28599
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28599", null);
+            }
+        }
+
+        internal static String Globalization_cp_28603
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28603", null);
+            }
+        }
+
+        internal static String Globalization_cp_28605
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_28605", null);
+            }
+        }
+
+        internal static String Globalization_cp_29001
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_29001", null);
+            }
+        }
+
+        internal static String Globalization_cp_37
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_37", null);
+            }
+        }
+
+        internal static String Globalization_cp_38598
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_38598", null);
+            }
+        }
+
+        internal static String Globalization_cp_437
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_437", null);
+            }
+        }
+
+        internal static String Globalization_cp_500
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_500", null);
+            }
+        }
+
+        internal static String Globalization_cp_50000
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50000", null);
+            }
+        }
+
+        internal static String Globalization_cp_50220
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50220", null);
+            }
+        }
+
+        internal static String Globalization_cp_50221
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50221", null);
+            }
+        }
+
+        internal static String Globalization_cp_50222
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50222", null);
+            }
+        }
+
+        internal static String Globalization_cp_50225
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50225", null);
+            }
+        }
+
+        internal static String Globalization_cp_50227
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50227", null);
+            }
+        }
+
+        internal static String Globalization_cp_50229
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50229", null);
+            }
+        }
+
+        internal static String Globalization_cp_50930
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50930", null);
+            }
+        }
+
+        internal static String Globalization_cp_50931
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50931", null);
+            }
+        }
+
+        internal static String Globalization_cp_50933
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50933", null);
+            }
+        }
+
+        internal static String Globalization_cp_50935
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50935", null);
+            }
+        }
+
+        internal static String Globalization_cp_50937
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50937", null);
+            }
+        }
+
+        internal static String Globalization_cp_50939
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_50939", null);
+            }
+        }
+
+        internal static String Globalization_cp_51932
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_51932", null);
+            }
+        }
+
+        internal static String Globalization_cp_51936
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_51936", null);
+            }
+        }
+
+        internal static String Globalization_cp_51949
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_51949", null);
+            }
+        }
+
+        internal static String Globalization_cp_52936
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_52936", null);
+            }
+        }
+
+        internal static String Globalization_cp_54936
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_54936", null);
+            }
+        }
+
+        internal static String Globalization_cp_57002
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57002", null);
+            }
+        }
+
+        internal static String Globalization_cp_57003
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57003", null);
+            }
+        }
+
+        internal static String Globalization_cp_57004
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57004", null);
+            }
+        }
+
+        internal static String Globalization_cp_57005
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57005", null);
+            }
+        }
+
+        internal static String Globalization_cp_57006
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57006", null);
+            }
+        }
+
+        internal static String Globalization_cp_57007
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57007", null);
+            }
+        }
+
+        internal static String Globalization_cp_57008
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57008", null);
+            }
+        }
+
+        internal static String Globalization_cp_57009
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57009", null);
+            }
+        }
+
+        internal static String Globalization_cp_57010
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57010", null);
+            }
+        }
+
+        internal static String Globalization_cp_57011
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_57011", null);
+            }
+        }
+
+        internal static String Globalization_cp_708
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_708", null);
+            }
+        }
+
+        internal static String Globalization_cp_720
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_720", null);
+            }
+        }
+
+        internal static String Globalization_cp_737
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_737", null);
+            }
+        }
+
+        internal static String Globalization_cp_775
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_775", null);
+            }
+        }
+
+        internal static String Globalization_cp_850
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_850", null);
+            }
+        }
+
+        internal static String Globalization_cp_852
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_852", null);
+            }
+        }
+
+        internal static String Globalization_cp_855
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_855", null);
+            }
+        }
+
+        internal static String Globalization_cp_857
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_857", null);
+            }
+        }
+
+        internal static String Globalization_cp_858
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_858", null);
+            }
+        }
+
+        internal static String Globalization_cp_860
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_860", null);
+            }
+        }
+
+        internal static String Globalization_cp_861
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_861", null);
+            }
+        }
+
+        internal static String Globalization_cp_862
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_862", null);
+            }
+        }
+
+        internal static String Globalization_cp_863
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_863", null);
+            }
+        }
+
+        internal static String Globalization_cp_864
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_864", null);
+            }
+        }
+
+        internal static String Globalization_cp_865
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_865", null);
+            }
+        }
+
+        internal static String Globalization_cp_866
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_866", null);
+            }
+        }
+
+        internal static String Globalization_cp_869
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_869", null);
+            }
+        }
+
+        internal static String Globalization_cp_870
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_870", null);
+            }
+        }
+
+        internal static String Globalization_cp_874
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_874", null);
+            }
+        }
+
+        internal static String Globalization_cp_875
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_875", null);
+            }
+        }
+
+        internal static String Globalization_cp_932
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_932", null);
+            }
+        }
+
+        internal static String Globalization_cp_936
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_936", null);
+            }
+        }
+
+        internal static String Globalization_cp_949
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_949", null);
+            }
+        }
+
+        internal static String Globalization_cp_950
+        {
+            get
+            {
+                return SR.GetResourceString("Globalization_cp_950", null);
+            }
+        }
+
+        internal static String MissingEncodingNameResource
+        {
+            get
+            {
+                return SR.GetResourceString("MissingEncodingNameResource", null);
+            }
+        }
+
+        internal static String NotSupported_NoCodepageData
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_NoCodepageData", null);
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
+                return typeof(FxResources.System.Text.Encoding.CodePages.SR);
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
