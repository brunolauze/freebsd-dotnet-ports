--- src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/PushCommand.cs.orig	2016-05-15 08:30:00.405207000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/PushCommand.cs	2016-05-15 08:30:17.327273000 -0400
@@ -1,7 +1,7 @@
 using System;
 using System.IO;
 using System.Threading.Tasks;
-using Microsoft.Dnx.Runtime.Common.CommandLine;
+using Microsoft.Extensions.CommandLineUtils;
 using NuGet.Commands;
 using NuGet.Common;
 using NuGet.Configuration;
