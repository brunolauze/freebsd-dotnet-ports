--- src/NuGet.Core/NuGet.CommandLine.XPlat/Utility/XPlatUtility.cs.orig	2016-05-15 08:28:36.376426000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Utility/XPlatUtility.cs	2016-05-15 08:29:08.561878000 -0400
@@ -4,7 +4,7 @@
 #if IS_CORECLR
 using System.Runtime.InteropServices;
 #endif
-using Microsoft.Dnx.Runtime.Common.CommandLine;
+using Microsoft.Extensions.CommandLineUtils;
 using NuGet.Common;
 using NuGet.Configuration;
 using NuGet.Protocol.Core.Types;
