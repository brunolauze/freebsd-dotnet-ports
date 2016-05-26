--- /dev/null	2016-03-07 15:01:48.000000000 -0500
+++ src/System.Dynamic.Runtime/src/SR.cs	2016-03-07 15:02:12.249852000 -0500
@@ -0,0 +1,366 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Dynamic.Runtime
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
+        private const String s_resourcesName = "FxResources.System.Dynamic.Runtime.SR";
+
+        internal static String AmbiguousMatchInExpandoObject
+        {
+            get
+            {
+                return SR.GetResourceString("AmbiguousMatchInExpandoObject", null);
+            }
+        }
+
+        internal static String ArgCntMustBeGreaterThanNameCnt
+        {
+            get
+            {
+                return SR.GetResourceString("ArgCntMustBeGreaterThanNameCnt", null);
+            }
+        }
+
+        internal static String ArgumentTypeCannotBeVoid
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentTypeCannotBeVoid", null);
+            }
+        }
+
+        internal static String BinderNotCompatibleWithCallSite
+        {
+            get
+            {
+                return SR.GetResourceString("BinderNotCompatibleWithCallSite", null);
+            }
+        }
+
+        internal static String BindingCannotBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("BindingCannotBeNull", null);
+            }
+        }
+
+        internal static String CollectionModifiedWhileEnumerating
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionModifiedWhileEnumerating", null);
+            }
+        }
+
+        internal static String CollectionReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionReadOnly", null);
+            }
+        }
+
+        internal static String DynamicBinderResultNotAssignable
+        {
+            get
+            {
+                return SR.GetResourceString("DynamicBinderResultNotAssignable", null);
+            }
+        }
+
+        internal static String DynamicBindingNeedsRestrictions
+        {
+            get
+            {
+                return SR.GetResourceString("DynamicBindingNeedsRestrictions", null);
+            }
+        }
+
+        internal static String DynamicObjectResultNotAssignable
+        {
+            get
+            {
+                return SR.GetResourceString("DynamicObjectResultNotAssignable", null);
+            }
+        }
+
+        internal static String EnumerationIsDone
+        {
+            get
+            {
+                return SR.GetResourceString("EnumerationIsDone", null);
+            }
+        }
+
+        internal static String ExpressionMustBeReadable
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionMustBeReadable", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchConstructorParameter
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchConstructorParameter", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchMethodParameter
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchMethodParameter", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchParameter
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchParameter", null);
+            }
+        }
+
+        internal static String FirstArgumentMustBeCallSite
+        {
+            get
+            {
+                return SR.GetResourceString("FirstArgumentMustBeCallSite", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfConstructorArguments
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfConstructorArguments", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfLambdaArguments
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfLambdaArguments", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfMethodCallArguments
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfMethodCallArguments", null);
+            }
+        }
+
+        internal static String InvalidArgumentValue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidArgumentValue", null);
+            }
+        }
+
+        internal static String InvalidMetaObjectCreated
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidMetaObjectCreated", null);
+            }
+        }
+
+        internal static String InvalidNullValue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidNullValue", null);
+            }
+        }
+
+        internal static String InvalidObjectType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidObjectType", null);
+            }
+        }
+
+        internal static String KeyDoesNotExistInExpando
+        {
+            get
+            {
+                return SR.GetResourceString("KeyDoesNotExistInExpando", null);
+            }
+        }
+
+        internal static String MethodPreconditionViolated
+        {
+            get
+            {
+                return SR.GetResourceString("MethodPreconditionViolated", null);
+            }
+        }
+
+        internal static String NonEmptyCollectionRequired
+        {
+            get
+            {
+                return SR.GetResourceString("NonEmptyCollectionRequired", null);
+            }
+        }
+
+        internal static String NoOrInvalidRuleProduced
+        {
+            get
+            {
+                return SR.GetResourceString("NoOrInvalidRuleProduced", null);
+            }
+        }
+
+        internal static String OutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("OutOfRange", null);
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
+                return typeof(FxResources.System.Dynamic.Runtime.SR);
+            }
+        }
+
+        internal static String SameKeyExistsInExpando
+        {
+            get
+            {
+                return SR.GetResourceString("SameKeyExistsInExpando", null);
+            }
+        }
+
+        internal static String TypeContainsGenericParameters
+        {
+            get
+            {
+                return SR.GetResourceString("TypeContainsGenericParameters", null);
+            }
+        }
+
+        internal static String TypeIsGeneric
+        {
+            get
+            {
+                return SR.GetResourceString("TypeIsGeneric", null);
+            }
+        }
+
+        internal static String TypeMustBeDerivedFromSystemDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("TypeMustBeDerivedFromSystemDelegate", null);
+            }
+        }
+
+        internal static String TypeParameterIsNotDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("TypeParameterIsNotDelegate", null);
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
