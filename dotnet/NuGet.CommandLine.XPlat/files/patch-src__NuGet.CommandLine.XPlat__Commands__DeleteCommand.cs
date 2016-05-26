--- src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/DeleteCommand.cs.orig	2016-05-15 08:32:33.291892000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/DeleteCommand.cs	2016-05-15 08:32:48.838998000 -0400
@@ -1,7 +1,7 @@
 ﻿using System;
 using System.Globalization;
 using System.IO;
-using Microsoft.Dnx.Runtime.Common.CommandLine;
+using Microsoft.Extensions.CommandLineUtils;
 using NuGet.Commands;
 using NuGet.Common;
 using NuGet.Configuration;
