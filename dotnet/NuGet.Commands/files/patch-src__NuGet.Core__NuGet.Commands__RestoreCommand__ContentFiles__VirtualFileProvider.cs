--- src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/VirtualFileProvider.cs.orig	2016-05-15 07:36:49.714847000 -0400
+++ src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/VirtualFileProvider.cs	2016-05-15 07:37:01.103895000 -0400
@@ -1,7 +1,7 @@
 ﻿using System;
 using System.Collections.Generic;
 using System.Linq;
-using Microsoft.AspNet.FileProviders;
+using Microsoft.Extensions.FileProviders;
 using Microsoft.Extensions.Primitives;
 
 namespace NuGet.Commands
