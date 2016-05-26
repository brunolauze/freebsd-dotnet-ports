--- Src/Newtonsoft.Json/Utilities/ReflectionUtils.cs.orig	2016-05-07 21:34:49.275061000 -0400
+++ Src/Newtonsoft.Json/Utilities/ReflectionUtils.cs	2016-05-07 21:37:47.104832000 -0400
@@ -826,8 +826,8 @@
             {
                 Type t = (Type)provider;
                 return (attributeType != null)
-                    ? t.GetTypeInfo().GetCustomAttributes(attributeType, inherit).ToArray()
-                    : t.GetTypeInfo().GetCustomAttributes(inherit).ToArray();
+                    ? t.GetTypeInfo().GetCustomAttributes(attributeType, inherit).Select(x => (Attribute)x).ToArray()
+                    : t.GetTypeInfo().GetCustomAttributes(inherit).Select(x => (Attribute)x).ToArray();
             }
 
             if (provider is Assembly)
@@ -839,7 +839,7 @@
             if (provider is MemberInfo)
             {
                 MemberInfo m = (MemberInfo)provider;
-                return (attributeType != null) ? m.GetCustomAttributes(attributeType, inherit).ToArray() : m.GetCustomAttributes(inherit).ToArray();
+                return (attributeType != null) ? m.GetCustomAttributes(attributeType, inherit).Select(x => (Attribute)x).ToArray() : m.GetCustomAttributes(inherit).Select(x => (Attribute)x).ToArray();
             }
 
             if (provider is Module)
@@ -851,7 +851,7 @@
             if (provider is ParameterInfo)
             {
                 ParameterInfo p = (ParameterInfo)provider;
-                return (attributeType != null) ? p.GetCustomAttributes(attributeType, inherit).ToArray() : p.GetCustomAttributes(inherit).ToArray();
+                return (attributeType != null) ? p.GetCustomAttributes(attributeType, inherit).Select(x => (Attribute)x).ToArray() : p.GetCustomAttributes(inherit).Select(x => (Attribute)x).ToArray();
             }
 
             throw new Exception("Cannot get attributes from '{0}'.".FormatWith(CultureInfo.InvariantCulture, provider));
@@ -1121,4 +1121,4 @@
             return Activator.CreateInstance(type);
         }
     }
-}
\ No newline at end of file
+}
