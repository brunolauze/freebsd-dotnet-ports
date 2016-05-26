--- src/System.Diagnostics.Process/src/System/Diagnostics/PerformanceCounterLib.cs.orig	2016-03-11 13:45:56.375838000 -0500
+++ src/System.Diagnostics.Process/src/System/Diagnostics/PerformanceCounterLib.cs	2016-03-11 13:49:23.039875000 -0500
@@ -131,10 +131,10 @@
         private Dictionary<int, string> GetStringTable(bool isHelp)
         {
             Dictionary<int, string> stringTable;
+#if WIN32
             RegistryKey libraryKey;
 
             libraryKey = Registry.PerformanceData;
-
             try
             {
                 string[] names = null;
@@ -221,13 +221,17 @@
             {
                 libraryKey.Dispose();
             }
-
+#else
+	    stringTable = new Dictionary<int, string>();
+#endif
             return stringTable;
         }
 
         internal class PerformanceMonitor
         {
+#if WIN32
             private RegistryKey _perfDataKey = null;
+#endif
             private string _machineName;
 
             internal PerformanceMonitor(string machineName)
@@ -238,7 +242,9 @@
 
             private void Init()
             {
+#if WIN32
                 _perfDataKey = Registry.PerformanceData;
+#endif
             }
 
             // Win32 RegQueryValueEx for perf data could deadlock (for a Mutex) up to 2mins in some 
@@ -252,6 +258,7 @@
             // in this case with InvalidOperationException after the wait time expires.
             internal byte[] GetData(string item)
             {
+#if WIN32
                 int waitRetries = 17;   //2^16*10ms == approximately 10mins
                 int waitSleep = 0;
                 byte[] data = null;
@@ -302,6 +309,9 @@
                 }
 
                 throw new Win32Exception(error);
+#else
+		return null;
+#endif
             }
         }
     }
