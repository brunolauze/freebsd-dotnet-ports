--- src/Microsoft.AspNetCore.Cors/Properties/AssemblyInfo.cs.orig	2016-04-25 14:30:55.000000000 -0400
+++ src/Microsoft.AspNetCore.Cors/Properties/AssemblyInfo.cs	2016-04-28 21:23:34.104677000 -0400
@@ -5,7 +5,17 @@
 using System.Resources;
 
 [assembly: AssemblyMetadata("Serviceable", "True")]
-[assembly: NeutralResourcesLanguage("en-US")]
+[assembly: NeutralResourcesLanguage("en-us")]
+
+[assembly: AssemblyTitle("Microsoft.AspNetCore.Cors")]
+[assembly: AssemblyDescription("")]
+[assembly: AssemblyConfiguration("")]
+[assembly: AssemblyTrademark("")]
+[assembly: AssemblyCulture("")]
+[assembly: System.Runtime.InteropServices.ComVisible(false)]
+[assembly: System.Runtime.InteropServices.Guid("02AC9CD9-339C-457A-8340-F3D5D021517D")]
+[assembly: AssemblyVersion("1.0.0.0")]
+[assembly: AssemblyFileVersion("1.0.0.0")]
 [assembly: AssemblyCompany("Microsoft Corporation.")]
 [assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
 [assembly: AssemblyProduct("Microsoft ASP.NET Core")]
