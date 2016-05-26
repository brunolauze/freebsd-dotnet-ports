--- src/mscorlib/src/System/TimeZoneInfo.cs.orig	2016-04-23 08:46:00.000000000 -0400
+++ src/mscorlib/src/System/TimeZoneInfo.cs	2016-04-23 19:56:06.332589000 -0400
@@ -1204,10 +1204,11 @@
                 }
             }
             m_displayName = m_standardDisplayName;
-
+#if WIN32
             GetDisplayName(Interop.GlobalizationInterop.TimeZoneDisplayNameType.Generic, ref m_displayName);
             GetDisplayName(Interop.GlobalizationInterop.TimeZoneDisplayNameType.Standard, ref m_standardDisplayName);
             GetDisplayName(Interop.GlobalizationInterop.TimeZoneDisplayNameType.DaylightSavings, ref m_daylightDisplayName);
+#endif
 
             // TZif supports seconds-level granularity with offsets but TimeZoneInfo only supports minutes since it aligns
             // with DateTimeOffset, SQL Server, and the W3C XML Specification
@@ -1223,6 +1224,7 @@
             ValidateTimeZoneInfo(m_id, m_baseUtcOffset, m_adjustmentRules, out m_supportsDaylightSavingTime);
         }
 
+#if WIN32
         private void GetDisplayName(Interop.GlobalizationInterop.TimeZoneDisplayNameType nameType, ref string displayName)
         {
             string timeZoneDisplayName;
@@ -1245,6 +1247,7 @@
                 displayName = timeZoneDisplayName;
             }
         }
+#endif
 
 #endif // PLATFORM_UNIX
 
@@ -2366,7 +2369,7 @@
             string id = null;
 
             StringBuilder symlinkPathBuilder = StringBuilderCache.Acquire(Path.MaxPath);
-            bool result = Interop.GlobalizationInterop.ReadLink(tzFilePath, symlinkPathBuilder, (uint)symlinkPathBuilder.Capacity);
+            bool result = false; //TODO: Interop.GlobalizationInterop.ReadLink(tzFilePath, symlinkPathBuilder, (uint)symlinkPathBuilder.Capacity);
             if (result)
             {
                 string symlinkPath = StringBuilderCache.GetStringAndRelease(symlinkPathBuilder);
