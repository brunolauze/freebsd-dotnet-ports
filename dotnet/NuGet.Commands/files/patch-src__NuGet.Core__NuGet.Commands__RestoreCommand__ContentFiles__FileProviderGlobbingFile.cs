--- src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/FileProviderGlobbingFile.cs.orig	2016-05-15 07:48:58.477102000 -0400
+++ src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/FileProviderGlobbingFile.cs	2016-05-15 07:49:14.388572000 -0400
@@ -2,7 +2,7 @@
 // Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
 
 using System;
-using Microsoft.AspNet.FileProviders;
+using Microsoft.Extensions.FileProviders;
 using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
 
 // This file is based on
@@ -40,4 +40,4 @@
 
         public override DirectoryInfoBase ParentDirectory { get; }
     }
-}
\ No newline at end of file
+}
