--- src/NuGet.Core/NuGet.CommandLine.XPlat/Program.cs.orig	2016-05-12 17:06:35.000000000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Program.cs	2016-05-15 08:43:37.816454000 -0400
@@ -6,7 +6,7 @@
 using System.Globalization;
 using System.Linq;
 using System.Reflection;
-using Microsoft.Dnx.Runtime.Common.CommandLine;
+using Microsoft.Extensions.CommandLineUtils;
 using NuGet.Common;
 
 namespace NuGet.CommandLine.XPlat
