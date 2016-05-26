--- src/Microsoft.Extensions.Options/OptionsServiceCollectionExtensions.cs.orig	2016-01-12 19:53:22.815782000 -0500
+++ src/Microsoft.Extensions.Options/OptionsServiceCollectionExtensions.cs	2016-01-12 19:53:49.131171000 -0500
@@ -5,6 +5,7 @@
 using System.Collections.Generic;
 using System.Linq;
 using System.Reflection;
+using Microsoft.Extensions.DependencyInjection;
 using Microsoft.Extensions.DependencyInjection.Extensions;
 using Microsoft.Extensions.Options;
 
@@ -107,4 +108,4 @@
             return services;
         }
     }
-}
\ No newline at end of file
+}
