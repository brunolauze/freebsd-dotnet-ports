--- /dev/null	2016-03-07 11:46:58.000000000 -0500
+++ src/System.Text.RegularExpressions/src/SR.cs	2016-03-07 11:47:19.086501000 -0500
@@ -0,0 +1,446 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Text.RegularExpressions
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
+        private const String s_resourcesName = "FxResources.System.Text.RegularExpressions.SR";
+
+        internal static String AlternationCantCapture
+        {
+            get
+            {
+                return SR.GetResourceString("AlternationCantCapture", null);
+            }
+        }
+
+        internal static String AlternationCantHaveComment
+        {
+            get
+            {
+                return SR.GetResourceString("AlternationCantHaveComment", null);
+            }
+        }
+
+        internal static String BadClassInCharRange
+        {
+            get
+            {
+                return SR.GetResourceString("BadClassInCharRange", null);
+            }
+        }
+
+        internal static String BeginIndexNotNegative
+        {
+            get
+            {
+                return SR.GetResourceString("BeginIndexNotNegative", null);
+            }
+        }
+
+        internal static String CapnumNotZero
+        {
+            get
+            {
+                return SR.GetResourceString("CapnumNotZero", null);
+            }
+        }
+
+        internal static String CaptureGroupOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("CaptureGroupOutOfRange", null);
+            }
+        }
+
+        internal static String CountTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("CountTooSmall", null);
+            }
+        }
+
+        internal static String EnumNotStarted
+        {
+            get
+            {
+                return SR.GetResourceString("EnumNotStarted", null);
+            }
+        }
+
+        internal static String IllegalCondition
+        {
+            get
+            {
+                return SR.GetResourceString("IllegalCondition", null);
+            }
+        }
+
+        internal static String IllegalEndEscape
+        {
+            get
+            {
+                return SR.GetResourceString("IllegalEndEscape", null);
+            }
+        }
+
+        internal static String IllegalRange
+        {
+            get
+            {
+                return SR.GetResourceString("IllegalRange", null);
+            }
+        }
+
+        internal static String IncompleteSlashP
+        {
+            get
+            {
+                return SR.GetResourceString("IncompleteSlashP", null);
+            }
+        }
+
+        internal static String InternalError
+        {
+            get
+            {
+                return SR.GetResourceString("InternalError", null);
+            }
+        }
+
+        internal static String InvalidGroupName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidGroupName", null);
+            }
+        }
+
+        internal static String LengthNotNegative
+        {
+            get
+            {
+                return SR.GetResourceString("LengthNotNegative", null);
+            }
+        }
+
+        internal static String MakeException
+        {
+            get
+            {
+                return SR.GetResourceString("MakeException", null);
+            }
+        }
+
+        internal static String MalformedNameRef
+        {
+            get
+            {
+                return SR.GetResourceString("MalformedNameRef", null);
+            }
+        }
+
+        internal static String MalformedReference
+        {
+            get
+            {
+                return SR.GetResourceString("MalformedReference", null);
+            }
+        }
+
+        internal static String MalformedSlashP
+        {
+            get
+            {
+                return SR.GetResourceString("MalformedSlashP", null);
+            }
+        }
+
+        internal static String MissingControl
+        {
+            get
+            {
+                return SR.GetResourceString("MissingControl", null);
+            }
+        }
+
+        internal static String NestedQuantify
+        {
+            get
+            {
+                return SR.GetResourceString("NestedQuantify", null);
+            }
+        }
+
+        internal static String NoResultOnFailed
+        {
+            get
+            {
+                return SR.GetResourceString("NoResultOnFailed", null);
+            }
+        }
+
+        internal static String NotEnoughParens
+        {
+            get
+            {
+                return SR.GetResourceString("NotEnoughParens", null);
+            }
+        }
+
+        internal static String OnlyAllowedOnce
+        {
+            get
+            {
+                return SR.GetResourceString("OnlyAllowedOnce", null);
+            }
+        }
+
+        internal static String QuantifyAfterNothing
+        {
+            get
+            {
+                return SR.GetResourceString("QuantifyAfterNothing", null);
+            }
+        }
+
+        internal static String RegexMatchTimeoutException_Occurred
+        {
+            get
+            {
+                return SR.GetResourceString("RegexMatchTimeoutException_Occurred", null);
+            }
+        }
+
+        internal static String ReplacementError
+        {
+            get
+            {
+                return SR.GetResourceString("ReplacementError", null);
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
+                return typeof(FxResources.System.Text.RegularExpressions.SR);
+            }
+        }
+
+        internal static String ReversedCharRange
+        {
+            get
+            {
+                return SR.GetResourceString("ReversedCharRange", null);
+            }
+        }
+
+        internal static String SubtractionMustBeLast
+        {
+            get
+            {
+                return SR.GetResourceString("SubtractionMustBeLast", null);
+            }
+        }
+
+        internal static String TooFewHex
+        {
+            get
+            {
+                return SR.GetResourceString("TooFewHex", null);
+            }
+        }
+
+        internal static String TooManyAlternates
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyAlternates", null);
+            }
+        }
+
+        internal static String TooManyParens
+        {
+            get
+            {
+                return SR.GetResourceString("TooManyParens", null);
+            }
+        }
+
+        internal static String UndefinedBackref
+        {
+            get
+            {
+                return SR.GetResourceString("UndefinedBackref", null);
+            }
+        }
+
+        internal static String UndefinedNameRef
+        {
+            get
+            {
+                return SR.GetResourceString("UndefinedNameRef", null);
+            }
+        }
+
+        internal static String UndefinedReference
+        {
+            get
+            {
+                return SR.GetResourceString("UndefinedReference", null);
+            }
+        }
+
+        internal static String UnexpectedOpcode
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedOpcode", null);
+            }
+        }
+
+        internal static String UnimplementedState
+        {
+            get
+            {
+                return SR.GetResourceString("UnimplementedState", null);
+            }
+        }
+
+        internal static String UnknownProperty
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownProperty", null);
+            }
+        }
+
+        internal static String UnrecognizedControl
+        {
+            get
+            {
+                return SR.GetResourceString("UnrecognizedControl", null);
+            }
+        }
+
+        internal static String UnrecognizedEscape
+        {
+            get
+            {
+                return SR.GetResourceString("UnrecognizedEscape", null);
+            }
+        }
+
+        internal static String UnrecognizedGrouping
+        {
+            get
+            {
+                return SR.GetResourceString("UnrecognizedGrouping", null);
+            }
+        }
+
+        internal static String UnterminatedBracket
+        {
+            get
+            {
+                return SR.GetResourceString("UnterminatedBracket", null);
+            }
+        }
+
+        internal static String UnterminatedComment
+        {
+            get
+            {
+                return SR.GetResourceString("UnterminatedComment", null);
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
