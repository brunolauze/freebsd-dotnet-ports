--- Src/Newtonsoft.Json/Utilities/ReflectionUtils.cs.orig	2016-08-15 19:32:54.444343000 -0400
+++ Src/Newtonsoft.Json/Utilities/ReflectionUtils.cs	2016-08-15 19:35:04.388003000 -0400
@@ -826,32 +826,32 @@
             {
                 Type t = (Type)provider;
                 return (attributeType != null)
-                    ? t.GetTypeInfo().GetCustomAttributes(attributeType, inherit).ToArray()
-                    : t.GetTypeInfo().GetCustomAttributes(inherit).ToArray();
+                    ? t.GetTypeInfo().GetCustomAttributes(attributeType, inherit).Cast<Attribute>().ToArray()
+                    : t.GetTypeInfo().GetCustomAttributes(inherit).Cast<Attribute>().ToArray();
             }
 
             if (provider is Assembly)
             {
                 Assembly a = (Assembly)provider;
-                return (attributeType != null) ? a.GetCustomAttributes(attributeType).ToArray() : a.GetCustomAttributes().ToArray();
+                return (attributeType != null) ? a.GetCustomAttributes(attributeType).Cast<Attribute>().ToArray() : a.GetCustomAttributes().Cast<Attribute>().ToArray();
             }
 
             if (provider is MemberInfo)
             {
                 MemberInfo m = (MemberInfo)provider;
-                return (attributeType != null) ? m.GetCustomAttributes(attributeType, inherit).ToArray() : m.GetCustomAttributes(inherit).ToArray();
+                return (attributeType != null) ? m.GetCustomAttributes(attributeType, inherit).Cast<Attribute>().ToArray() : m.GetCustomAttributes(inherit).Cast<Attribute>().ToArray();
             }
 
             if (provider is Module)
             {
                 Module m = (Module)provider;
-                return (attributeType != null) ? m.GetCustomAttributes(attributeType).ToArray() : m.GetCustomAttributes().ToArray();
+                return (attributeType != null) ? m.GetCustomAttributes(attributeType).Cast<Attribute>().ToArray() : m.GetCustomAttributes().Cast<Attribute>().ToArray();
             }
 
             if (provider is ParameterInfo)
             {
                 ParameterInfo p = (ParameterInfo)provider;
-                return (attributeType != null) ? p.GetCustomAttributes(attributeType, inherit).ToArray() : p.GetCustomAttributes(inherit).ToArray();
+                return (attributeType != null) ? p.GetCustomAttributes(attributeType, inherit).Cast<Attribute>().ToArray() : p.GetCustomAttributes(inherit).Cast<Attribute>().ToArray();
             }
 
             throw new Exception("Cannot get attributes from '{0}'.".FormatWith(CultureInfo.InvariantCulture, provider));
@@ -1158,4 +1158,4 @@
             return (AssemblyName == other.AssemblyName && TypeName == other.TypeName);
         }
     }
-}
\ No newline at end of file
+}
