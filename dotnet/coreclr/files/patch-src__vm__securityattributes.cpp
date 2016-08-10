--- src/vm/securityattributes.cpp.orig	2016-08-06 10:17:40.790611000 -0400
+++ src/vm/securityattributes.cpp	2016-08-06 10:18:01.116542000 -0400
@@ -1818,7 +1818,7 @@
 
 bool SecurityAttributes::IsHostProtectionAttribute(CORSEC_ATTRIBUTE* pAttr)
 {
-    static const char s_HostProtectionAttributeName[] = "System.Security.Permissions.HostProtectionAttribute, mscorlib";
+    static const char s_HostProtectionAttributeName[] = "System.Security.Permissions.HostProtectionAttribute, System.Private.CoreLib";
 
     return (strncmp(pAttr->pName, s_HostProtectionAttributeName, sizeof(s_HostProtectionAttributeName)-1) == 0);
 }
@@ -1829,14 +1829,14 @@
     static const char s_permissionsNamespace[] = "System.Security.Permissions.";
     if(strncmp(pAttr->pName, s_permissionsNamespace, sizeof(s_permissionsNamespace) - 1) != 0)
         return false; // not built-in permission
-    static const char s_principalPermissionName[] = "System.Security.Permissions.PrincipalPermissionAttribute, mscorlib";
+    static const char s_principalPermissionName[] = "System.Security.Permissions.PrincipalPermissionAttribute, System.Private.CoreLib";
 
     // ASSERT: at this point we know we are in builtin namespace...so compare with PrincipalPermissionAttribute
     if (strncmp(pAttr->pName, s_principalPermissionName, sizeof(s_principalPermissionName)-1) == 0)
         return false; // found a principal permission => Not a built-in CAS permission
 
     // special-case the unrestricted permission set attribute.
-    static const char s_PermissionSetName[] = "System.Security.Permissions.PermissionSetAttribute, mscorlib";
+    static const char s_PermissionSetName[] = "System.Security.Permissions.PermissionSetAttribute, System.Private.CoreLib";
     if (strncmp(pAttr->pName, s_PermissionSetName, sizeof(s_PermissionSetName)-1) == 0)
         return IsUnrestrictedPermissionSetAttribute(pAttr);
 
