--- src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/PackCommand.cs.orig	2016-05-15 08:31:03.403235000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/PackCommand.cs	2016-05-15 08:31:20.521758000 -0400
@@ -1,7 +1,7 @@
 ﻿using System;
 using System.Globalization;
 using System.IO;
-using Microsoft.Dnx.Runtime.Common.CommandLine;
+using Microsoft.Extensions.CommandLineUtils;
 using NuGet.Commands;
 using NuGet.Common;
 using NuGet.Versioning;
