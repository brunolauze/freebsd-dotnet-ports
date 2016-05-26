--- src/Microsoft.AspNetCore.Antiforgery/Internal/DefaultAntiforgeryTokenStore.cs.orig	2016-05-18 20:03:20.000000000 -0400
+++ src/Microsoft.AspNetCore.Antiforgery/Internal/DefaultAntiforgeryTokenStore.cs	2016-05-21 18:29:37.245260000 -0400
@@ -46,7 +46,7 @@
 
             // We want to delay reading the form as much as possible, for example in case of large file uploads,
             // request token could be part of the header.
-            StringValues requestToken;
+            StringValues requestToken = default(StringValues);
             if (_options.HeaderName != null)
             {
                 requestToken = httpContext.Request.Headers[_options.HeaderName];
@@ -81,4 +81,4 @@
             httpContext.Response.Cookies.Append(_options.CookieName, token, options);
         }
     }
-}
\ No newline at end of file
+}
