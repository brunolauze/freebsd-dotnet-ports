--- src/Microsoft.AspNetCore.Cors/Infrastructure/CorsMiddleware.cs.orig	2016-04-28 21:24:38.800570000 -0400
+++ src/Microsoft.AspNetCore.Cors/Infrastructure/CorsMiddleware.cs	2016-04-28 21:25:32.077116000 -0400
@@ -89,7 +89,7 @@
         {
             if (context.Request.Headers.ContainsKey(CorsConstants.Origin))
             {
-                var corsPolicy = _policy ?? await _corsPolicyProvider?.GetPolicyAsync(context, _corsPolicyName);
+                var corsPolicy = _policy ?? (_corsPolicyProvider == null ? null : await _corsPolicyProvider.GetPolicyAsync(context, _corsPolicyName));
                 if (corsPolicy != null)
                 {
                     var corsResult = _corsService.EvaluatePolicy(context, corsPolicy);
@@ -114,4 +114,4 @@
             await _next(context);
         }
     }
-}
\ No newline at end of file
+}
