--- src/System.Resources.ResourceManager/src/System/Resources/ResourceManager.cs.orig	2016-03-03 17:57:16.000000000 -0500
+++ src/System.Resources.ResourceManager/src/System/Resources/ResourceManager.cs	2016-03-04 15:56:07.645644000 -0500
@@ -4,16 +4,19 @@
 
 using System.Globalization;
 using System.Reflection;
+#if WIN32
 using Internal.Runtime.Augments;
-
 using Windows.ApplicationModel;
 using Windows.ApplicationModel.Resources.Core;
+#endif
 
 namespace System.Resources
 {
     public class ResourceManager
     {
+#if WIN32
         private readonly ResourceMap _resourceMap;
+#endif
         private readonly string _resourcesSubtree;
         private readonly string _neutralResourcesCultureName;
 
@@ -26,7 +29,9 @@
 
             // Portable libraries resources are indexed under the the type full name 
             _resourcesSubtree = resourceSource.FullName;
+#if WIN32
             _resourceMap = GetResourceMap(_resourcesSubtree);
+#endif
         }
 
         public ResourceManager(string baseName, Assembly assembly)
@@ -41,14 +46,18 @@
             }
 
             _resourcesSubtree = baseName;
+#if WIN32
             _resourceMap = GetResourceMap(_resourcesSubtree);
+#endif
             _neutralResourcesCultureName = GetNeutralLanguageForAssembly(assembly);
         }
 
         public ResourceManager(string resourcesName)
         {
             _resourcesSubtree = resourcesName;
+#if WIN32
             _resourceMap = GetResourceMap(_resourcesSubtree);
+#endif
         }
 
         public string GetString(string name)
@@ -66,7 +75,7 @@
             {
                 throw new ArgumentNullException(nameof(name));
             }
-
+#if WIN32
             if (WinRTInterop.Callbacks.IsAppxModel() && _resourceMap == null)
             {
                 if (name.Equals("MissingManifestResource_ResWFileNotLoaded") &&
@@ -78,7 +87,7 @@
                 }
                 throw new MissingManifestResourceException(SR.Format(SR.MissingManifestResource_ResWFileNotLoaded, _resourcesSubtree));
             }
-
+#endif
             return GetResourceString(name, culture == null ? null : culture.Name);
         }
         
@@ -108,14 +117,16 @@
 
         private ResourceMap GetResourceMap(string subtreeName)
         {
+#if WIN32
             if (WinRTInterop.Callbacks.IsAppxModel())
                 return Windows.ApplicationModel.Resources.Core.ResourceManager.Current.MainResourceMap.GetSubtree(subtreeName);
-
+#endif
             return null;
         }
 
         private string GetResourceString(string resourceName, string languageName)
         {
+#if WIN32
             if (!WinRTInterop.Callbacks.IsAppxModel())
             {
                 // on desktop we usually don't have resource strings. so we just return the key name
@@ -124,7 +135,7 @@
 
             if (_resourceMap == null)
                 return null;
-
+#endif
             ResourceContext context;
             ResourceCandidate candidate;
 
@@ -137,7 +148,9 @@
                 context = new ResourceContext();
                 context.QualifierValues["language"] = (languageName != null ? languageName + ";" : "") + 
                                                       (_neutralResourcesCultureName != null ? _neutralResourcesCultureName : ""); 
+#if WIN32
                 candidate = _resourceMap.GetValue(resourceName, context);
+#endif
             }
 
             return candidate == null ? null : candidate.ValueAsString;
