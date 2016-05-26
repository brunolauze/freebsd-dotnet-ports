--- src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/FileProviderGlobbingDirectory.cs.orig	2016-05-15 07:50:00.291333000 -0400
+++ src/NuGet.Core/NuGet.Commands/RestoreCommand/ContentFiles/FileProviderGlobbingDirectory.cs	2016-05-15 07:50:09.869170000 -0400
@@ -3,7 +3,7 @@
 
 using System;
 using System.Collections.Generic;
-using Microsoft.AspNet.FileProviders;
+using Microsoft.Extensions.FileProviders;
 using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
 
 // This file is based on
@@ -111,4 +111,4 @@
             return new FileProviderGlobbingFile(fileInfo, this);
         }
     }
-}
\ No newline at end of file
+}
