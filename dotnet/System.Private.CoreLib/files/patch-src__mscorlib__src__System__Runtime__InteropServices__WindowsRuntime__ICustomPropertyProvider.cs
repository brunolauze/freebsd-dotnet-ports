--- src/mscorlib/src/System/Runtime/InteropServices/WindowsRuntime/ICustomPropertyProvider.cs.orig	2016-05-06 06:57:30.273226000 -0400
+++ src/mscorlib/src/System/Runtime/InteropServices/WindowsRuntime/ICustomPropertyProvider.cs	2016-05-06 06:58:23.872567000 -0400
@@ -45,7 +45,7 @@
             else
                 return new CustomPropertyImpl(propertyInfo);
         }
-
+#if FEATURE_COMINTEROP
         //
         // Creates a ICustomProperty implementation for Jupiter
         // Called from ICustomPropertyProvider_GetIndexedProperty from within runtime
@@ -61,6 +61,7 @@
 
             return CreateIndexedProperty(target, propertyName, indexedParamType);        
         }
+#endif
 
         static internal ICustomProperty CreateIndexedProperty(object target, string propertyName, Type indexedParamType)
         {
@@ -87,6 +88,7 @@
                 return new CustomPropertyImpl(propertyInfo);
         }
 
+#if FEATURE_COMINTEROP
         [System.Security.SecurityCritical]
         static internal unsafe void GetType(object target, TypeNameNative *pIndexedParamType)
         {            
@@ -97,6 +99,7 @@
             SystemTypeMarshaler.ConvertToNative(target.GetType(), pIndexedParamType);
         }        
     }
+#endif
 
     [Flags]
     enum InterfaceForwardingSupport
