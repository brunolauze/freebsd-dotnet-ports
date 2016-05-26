--- src/Microsoft.AspNetCore.DataProtection/LoggingExtensions.cs.orig	2016-05-01 10:07:45.279744000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/LoggingExtensions.cs	2016-05-01 10:08:40.945615000 -0400
@@ -92,9 +92,9 @@
         private static Action<ILogger, string, string, Exception> _nameIsNotSafeFileName;
 
         private static Action<ILogger, string, Exception> _writingDataToFile;
-
+#if WIN32
         private static Action<ILogger, RegistryKey, string, Exception> _readingDataFromRegistryKeyValue;
-
+#endif
         private static Action<ILogger, string, string, Exception> _nameIsNotSafeRegistryValueName;
 
         private static Action<ILogger, string, Exception> _decryptingSecretElementUsingWindowsDPAPING;
@@ -297,10 +297,12 @@
                 eventId: 39,
                 logLevel: LogLevel.Information,
                 formatString: "Writing data to file '{FileName}'.");
+#if WIN32
             _readingDataFromRegistryKeyValue = LoggerMessage.Define<RegistryKey, string>(
                 eventId: 40,
                 logLevel: LogLevel.Debug,
                 formatString: "Reading data from registry key '{RegistryKeyName}', value '{Value}'.");
+#endif
             _nameIsNotSafeRegistryValueName = LoggerMessage.Define<string, string>(
                 eventId: 41,
                 logLevel: LogLevel.Debug,
@@ -635,12 +637,12 @@
         {
             _writingDataToFile(logger, finalFilename, null);
         }
-
+#if WIN32
         public static void ReadingDataFromRegistryKeyValue(this ILogger logger, RegistryKey regKey, string valueName)
         {
             _readingDataFromRegistryKeyValue(logger, regKey, valueName, null);
         }
-
+#endif
         public static void NameIsNotSafeRegistryValueName(this ILogger logger, string friendlyName, string newFriendlyName)
         {
             _nameIsNotSafeRegistryValueName(logger, friendlyName, newFriendlyName, null);
@@ -761,4 +763,4 @@
             _usingAzureAsKeyRepository(logger, fullName, null);
         }
     }
-}
\ No newline at end of file
+}
