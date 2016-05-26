--- src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/VirtualFileInfo.cs.orig	2016-05-15 07:50:47.090697000 -0400
+++ src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/VirtualFileInfo.cs	2016-05-15 07:50:56.449560000 -0400
@@ -1,7 +1,7 @@
 ﻿using System;
 using System.IO;
 using System.Linq;
-using Microsoft.AspNet.FileProviders;
+using Microsoft.Extensions.FileProviders;
 
 namespace NuGet.Commands
 {
