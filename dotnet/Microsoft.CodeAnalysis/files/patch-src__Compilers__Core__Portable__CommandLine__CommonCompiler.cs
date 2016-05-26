--- src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs.orig	2016-01-20 15:57:23.243102000 -0500
+++ src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs	2016-01-20 15:59:25.356527000 -0500
@@ -635,7 +635,9 @@
                     if (sqm != null)
                     {
                         sqm.BeginSession(this.GetSqmAppID(), false, out sqmSession);
-                        sqm.SetGlobalSessionGuid(Arguments.SqmSessionGuid);
+			var sqmSessionId = Arguments.SqmSessionGuid;
+                        sqm.SetGlobalSessionGuid(ref sqmSessionId);
+			Arguments.SqmSessionGuid = sqmSessionId;
 
                         // Build Version
                         sqm.SetStringDatapoint(sqmSession, SqmServiceProvider.DATAID_SQM_BUILDVERSION, GetAssemblyFileVersion());
