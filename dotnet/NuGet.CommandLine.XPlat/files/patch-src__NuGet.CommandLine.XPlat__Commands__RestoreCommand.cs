--- src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/RestoreCommand.cs.orig	2016-05-15 08:41:54.117708000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Commands/RestoreCommand.cs	2016-05-15 08:42:14.665464000 -0400
@@ -1,7 +1,7 @@
 ﻿using System;
 using System.Collections.Generic;
 using System.Linq;
-using Microsoft.Dnx.Runtime.Common.CommandLine;
+using Microsoft.Extensions.CommandLineUtils;
 using Microsoft.Extensions.PlatformAbstractions;
 using NuGet.Commands;
 using NuGet.Common;
