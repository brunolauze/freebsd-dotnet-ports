--- /dev/null	2016-03-11 14:48:39.000000000 -0500
+++ src/System.Diagnostics.Process/src/SR.cs	2016-03-11 14:48:59.917099000 -0500
@@ -0,0 +1,534 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Diagnostics.Process
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
+        private const String s_resourcesName = "FxResources.System.Diagnostics.Process.SR";
+
+		internal static String PriorityClassNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("PriorityClassNotSupported", null);
+            }
+        }
+		
+		internal static String NoAssociatedProcess
+        {
+            get
+            {
+                return SR.GetResourceString("NoAssociatedProcess", null);
+            }
+        }
+		
+		internal static String ProcessIdRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessIdRequired", null);
+            }
+        }
+		
+		internal static String NotSupportedRemote
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupportedRemote", null);
+            }
+        }
+		
+		internal static String NoProcessInfo
+        {
+            get
+            {
+                return SR.GetResourceString("NoProcessInfo", null);
+            }
+        }
+		
+		internal static String WaitTillExit
+        {
+            get
+            {
+                return SR.GetResourceString("WaitTillExit", null);
+            }
+        }
+		
+		internal static String NoProcessHandle
+        {
+            get
+            {
+                return SR.GetResourceString("NoProcessHandle", null);
+            }
+        }
+		
+		internal static String MissingProccess
+        {
+            get
+            {
+                return SR.GetResourceString("MissingProccess", null);
+            }
+        }
+		
+		internal static String BadMinWorkset
+        {
+            get
+            {
+                return SR.GetResourceString("BadMinWorkset", null);
+            }
+        }
+		
+		internal static String BadMaxWorkset
+        {
+            get
+            {
+                return SR.GetResourceString("BadMaxWorkset", null);
+            }
+        }
+		
+		internal static String ProcessHasExited
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessHasExited", null);
+            }
+        }
+		
+		internal static String ProcessHasExitedNoId
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessHasExitedNoId", null);
+            }
+        }
+		
+		internal static String ThreadExited
+        {
+            get
+            {
+                return SR.GetResourceString("ThreadExited", null);
+            }
+        }
+		
+		internal static String ProcessNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessNotFound", null);
+            }
+        }
+		
+		internal static String CantGetProcessId
+        {
+            get
+            {
+                return SR.GetResourceString("CantGetProcessId", null);
+            }
+        }
+		
+		internal static String ProcessDisabled
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessDisabled", null);
+            }
+        }
+		
+		internal static String WaitReasonUnavailable
+        {
+            get
+            {
+                return SR.GetResourceString("WaitReasonUnavailable", null);
+            }
+        }
+		
+		internal static String NotSupportedRemoteThread
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupportedRemoteThread", null);
+            }
+        }
+		
+		internal static String CouldntConnectToRemoteMachine
+        {
+            get
+            {
+                return SR.GetResourceString("CouldntConnectToRemoteMachine", null);
+            }
+        }
+		
+		internal static String CouldntGetProcessInfos
+        {
+            get
+            {
+                return SR.GetResourceString("CouldntGetProcessInfos", null);
+            }
+        }
+		
+		internal static String InputIdleUnkownError
+        {
+            get
+            {
+                return SR.GetResourceString("InputIdleUnkownError", null);
+            }
+        }
+		
+		internal static String FileNameMissing
+        {
+            get
+            {
+                return SR.GetResourceString("FileNameMissing", null);
+            }
+        }
+		
+		internal static String EnumProcessModuleFailed
+        {
+            get
+            {
+                return SR.GetResourceString("EnumProcessModuleFailed", null);
+            }
+        }
+		
+		internal static String EnumProcessModuleFailedDueToWow
+        {
+            get
+            {
+                return SR.GetResourceString("EnumProcessModuleFailedDueToWow", null);
+            }
+        }
+		
+		internal static String NoAsyncOperation
+        {
+            get
+            {
+                return SR.GetResourceString("NoAsyncOperation", null);
+            }
+        }
+		
+		internal static String InvalidApplication
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidApplication", null);
+            }
+        }
+		
+		internal static String StandardOutputEncodingNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("StandardOutputEncodingNotAllowed", null);
+            }
+        }
+		
+		internal static String StandardErrorEncodingNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("StandardErrorEncodingNotAllowed", null);
+            }
+        }
+		
+		internal static String CantGetStandardOut
+        {
+            get
+            {
+                return SR.GetResourceString("CantGetStandardOut", null);
+            }
+        }
+		
+		internal static String CantGetStandardIn
+        {
+            get
+            {
+                return SR.GetResourceString("CantGetStandardIn", null);
+            }
+        }
+		
+		internal static String CantGetStandardError
+        {
+            get
+            {
+                return SR.GetResourceString("CantGetStandardError", null);
+            }
+        }
+		
+		internal static String CantMixSyncAsyncOperation
+        {
+            get
+            {
+                return SR.GetResourceString("CantMixSyncAsyncOperation", null);
+            }
+        }
+		
+		internal static String CantRedirectStreams
+        {
+            get
+            {
+                return SR.GetResourceString("CantRedirectStreams", null);
+            }
+        }
+		
+		internal static String CantUseEnvVars
+        {
+            get
+            {
+                return SR.GetResourceString("CantUseEnvVars", null);
+            }
+        }
+		
+		internal static String EnvironmentBlockTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("EnvironmentBlockTooLong", null);
+            }
+        }
+		
+		internal static String PendingAsyncOperation
+        {
+            get
+            {
+                return SR.GetResourceString("PendingAsyncOperation", null);
+            }
+        }
+		
+		internal static String UseShellExecute
+        {
+            get
+            {
+                return SR.GetResourceString("UseShellExecute", null);
+            }
+        }
+		
+		internal static String InvalidParameter
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidParameter", null);
+            }
+        }
+		
+		internal static String InvalidEnumArgument
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidEnumArgument", null);
+            }
+        }
+		
+		internal static String CategoryHelpCorrupt
+        {
+            get
+            {
+                return SR.GetResourceString("CategoryHelpCorrupt", null);
+            }
+        }
+		
+		internal static String CounterNameCorrupt
+        {
+            get
+            {
+                return SR.GetResourceString("CounterNameCorrupt", null);
+            }
+        }
+		
+		internal static String CounterDataCorrupt
+        {
+            get
+            {
+                return SR.GetResourceString("CounterDataCorrupt", null);
+            }
+        }
+		
+		internal static String CantGetProcessStartInfo
+        {
+            get
+            {
+                return SR.GetResourceString("CantGetProcessStartInfo", null);
+            }
+        }
+		
+		internal static String CantSetProcessStartInfo
+        {
+            get
+            {
+                return SR.GetResourceString("CantSetProcessStartInfo", null);
+            }
+        }
+		
+		internal static String CantGetAllPids
+        {
+            get
+            {
+                return SR.GetResourceString("CantGetAllPids", null);
+            }
+        }
+		
+		internal static String CantFindProcessExecutablePath
+        {
+            get
+            {
+                return SR.GetResourceString("CantFindProcessExecutablePath", null);
+            }
+        }
+		
+		internal static String NegativePidNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("NegativePidNotSupported", null);
+            }
+        }
+		
+		internal static String ProcessorAffinityNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessorAffinityNotSupported", null);
+            }
+        }
+		
+		internal static String ResourceLimitQueryFailure
+        {
+            get
+            {
+                return SR.GetResourceString("ResourceLimitQueryFailure", null);
+            }
+        }
+		
+		internal static String RUsageFailure
+        {
+            get
+            {
+                return SR.GetResourceString("RUsageFailure", null);
+            }
+        }
+		
+		internal static String MinimumWorkingSetNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("MinimumWorkingSetNotSupported", null);
+            }
+        }
+		
+		internal static String OsxExternalProcessWorkingSetNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("OsxExternalProcessWorkingSetNotSupported", null);
+            }
+        }
+		
+		internal static String ProcessInformationUnavailable
+        {
+            get
+            {
+                return SR.GetResourceString("ProcessInformationUnavailable", null);
+            }
+        }
+		
+		internal static String RemoteMachinesNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("RemoteMachinesNotSupported", null);
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
+                return typeof(FxResources.System.Diagnostics.Process.SR);
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
