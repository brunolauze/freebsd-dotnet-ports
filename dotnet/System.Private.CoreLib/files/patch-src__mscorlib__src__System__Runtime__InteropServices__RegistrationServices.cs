--- src/mscorlib/src/System/Runtime/InteropServices/RegistrationServices.cs.orig	2016-04-23 19:57:44.288688000 -0400
+++ src/mscorlib/src/System/Runtime/InteropServices/RegistrationServices.cs	2016-04-23 20:01:00.980390000 -0400
@@ -368,6 +368,7 @@
         [System.Security.SecurityCritical]  // auto-generated
         private void RegisterValueType(Type type, String strAsmName, String strAsmVersion, String strAsmCodeBase, String strRuntimeVersion)
         {
+#if WIN32
             // Retrieve some information that will be used during the registration process.
             String strRecordId = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";           
 
@@ -395,6 +396,7 @@
                     }
                 }
             }
+#endif
         }
 
         [System.Security.SecurityCritical]  // auto-generated
@@ -415,6 +417,7 @@
 
             if (strProgId != String.Empty)
             {
+#if WIN32
                 // Create the HKEY_CLASS_ROOT\<wzProgId> key.
                 using (RegistryKey TypeNameKey = Registry.ClassesRoot.CreateSubKey(strProgId))
                 {
@@ -426,8 +429,10 @@
                         ProgIdClsIdKey.SetValue("", strClsId);
                     }
                 }
+#endif
             }
 
+#if WIN32
             // Create the HKEY_CLASS_ROOT\CLSID key.
             using (RegistryKey ClsIdRootKey = Registry.ClassesRoot.CreateSubKey(strClsIdRootName))
             {           
@@ -474,7 +479,7 @@
                     }
                 }
             }
-
+#endif
 
             //
             // Ensure that the managed category exists.
@@ -486,6 +491,7 @@
         [System.Security.SecurityCritical]  // auto-generated
         private void RegisterComImportedType(Type type, String strAsmName, String strAsmVersion, String strAsmCodeBase, String strRuntimeVersion)
         {
+#if WIN32
             // Retrieve some information that will be used during the registration process.
             String strClsId = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
 
@@ -523,13 +529,14 @@
                     }
                 }
             }
+#endif
         }
 
         [System.Security.SecurityCritical]  // auto-generated
         private bool UnregisterValueType(Type type, String strAsmVersion)
         {
             bool bAllVersionsGone = true;
-
+#if WIN32
             // Try to open the HKEY_CLASS_ROOT\Record key.
             String strRecordId = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
             
@@ -573,7 +580,7 @@
                         Registry.ClassesRoot.DeleteSubKey(strRecordRootName);
                 }
             }
-
+#endif
             return bAllVersionsGone;
         }
 
@@ -586,7 +593,7 @@
         private bool UnregisterManagedType(Type type,String strAsmVersion)
         {
             bool bAllVersionsGone = true;
-            
+#if WIN32            
             //
             // Create the CLSID string.
             //
@@ -768,7 +775,7 @@
                     }
                 }
             }
-
+#endif
             return bAllVersionsGone;
         }
 
@@ -780,7 +787,7 @@
         private bool UnregisterComImportedType(Type type, String strAsmVersion)
         {
             bool bAllVersionsGone = true;
-            
+#if WIN32            
             String strClsId = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
         
             // Try to open the HKEY_CLASS_ROOT\CLSID key.
@@ -842,7 +849,7 @@
                         Registry.ClassesRoot.DeleteSubKey(strClsIdRootName);                    
                 }
             }
-
+#endif
             return bAllVersionsGone;
         }
 
@@ -852,7 +859,7 @@
             // Validate that the PIA has a strong name.
             if (assembly.GetPublicKey().Length == 0)
                 throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_PIAMustBeStrongNamed"));
-
+#if WIN32
             String strTlbId = "{" + Marshal.GetTypeLibGuidForAssembly(assembly).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
             String strVersion = attr.MajorVersion.ToString("x", CultureInfo.InvariantCulture) + "." + attr.MinorVersion.ToString("x", CultureInfo.InvariantCulture);
 
@@ -872,11 +879,13 @@
                     }
                 }
             }
+#endif
         }
 
         [System.Security.SecurityCritical]  // auto-generated
         private void UnregisterPrimaryInteropAssembly(Assembly assembly, PrimaryInteropAssemblyAttribute attr)
         {
+#if WIN32
             String strTlbId = "{" + Marshal.GetTypeLibGuidForAssembly(assembly).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
             String strVersion = attr.MajorVersion.ToString("x", CultureInfo.InvariantCulture) + "." + attr.MinorVersion.ToString("x", CultureInfo.InvariantCulture);
 
@@ -916,12 +925,14 @@
                         Registry.ClassesRoot.DeleteSubKey(strTlbRootName);                    
                 }
             }
+#endif
         }
 
         private void EnsureManagedCategoryExists()
         {
             if (!ManagedCategoryExists())
             {
+#if WIN32
                 // Create the HKEY_CLASS_ROOT\Component Category key.
                 using (RegistryKey ComponentCategoryKey = Registry.ClassesRoot.CreateSubKey(strComponentCategorySubKey))
                 {
@@ -931,11 +942,13 @@
                         ManagedCategoryKey.SetValue("0", strManagedCategoryDescription);
                     }
                 }
+#endif
             }
         }
 
         private static bool ManagedCategoryExists()
         {
+#if WIN32
             using (RegistryKey componentCategoryKey = Registry.ClassesRoot.OpenSubKey(strComponentCategorySubKey, 
 #if FEATURE_MACL
                                                                                       RegistryKeyPermissionCheck.ReadSubTree))
@@ -962,7 +975,7 @@
                         return false;
                 }
             }
-            
+#endif            
             return true;
         }
         
@@ -970,7 +983,7 @@
         private void CallUserDefinedRegistrationMethod(Type type, bool bRegister)
         {
             bool bFunctionCalled = false;
-
+#if WIN32
             // Retrieve the attribute type to use to determine if a function is the requested user defined
             // registration function.
             Type RegFuncAttrType = null;
@@ -1045,6 +1058,7 @@
                     }
                 }
             }
+#endif
         }
 
         private Type GetBaseComImportType(Type type)
