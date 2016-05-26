--- src/dotnet/Properties/AssemblyInfo.cs.orig	2016-05-15 12:39:04.664513000 -0400
+++ src/dotnet/Properties/AssemblyInfo.cs	2016-05-15 12:40:06.975305000 -0400
@@ -1,3 +1,14 @@
-using System.Runtime.CompilerServices;
+using System;
+using System.Reflection;
+
+[assembly: AssemblyTitle("dotnet")]
+[assembly: AssemblyDescription("")]
+[assembly: AssemblyConfiguration("")]
+[assembly: AssemblyCompany("")]
+[assembly: AssemblyProduct("Microsoft .NET Core 1.0")]
+[assembly: AssemblyCopyright("Copyright Microsoft 2015")]
+[assembly: AssemblyTrademark("")]
+[assembly: AssemblyCulture("")]
+[assembly: AssemblyVersion("1.0.0.0")]
+[assembly: AssemblyFileVersion("1.0.0.0")]
 
-[assembly: InternalsVisibleTo("dotnet.Tests")]
\ No newline at end of file
