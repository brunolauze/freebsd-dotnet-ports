--- src/Microsoft.Extensions.Options/OptionsServiceCollectionExtensions.cs.orig	2016-05-26 17:26:13.000000000 -0400
+++ src/Microsoft.Extensions.Options/OptionsServiceCollectionExtensions.cs	2016-05-26 21:47:36.194194000 -0400
@@ -2,6 +2,7 @@
 // Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
 
 using System;
+using Microsoft.Extensions.DependencyInjection;
 using Microsoft.Extensions.DependencyInjection.Extensions;
 using Microsoft.Extensions.Options;
 
@@ -52,4 +53,4 @@
             return services;
         }
     }
-}
\ No newline at end of file
+}
