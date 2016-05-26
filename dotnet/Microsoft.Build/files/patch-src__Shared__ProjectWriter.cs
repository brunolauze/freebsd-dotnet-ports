--- src/Shared/ProjectWriter.cs.orig	2016-03-16 10:20:51.579200000 -0400
+++ src/Shared/ProjectWriter.cs	2016-03-16 10:21:00.195071000 -0400
@@ -12,7 +12,7 @@
     /// This class is used to save MSBuild project files. It contains special handling for MSBuild notations that are not saved
     /// correctly by the XML DOM's default save mechanism.
     /// </summary>
-    internal sealed class ProjectWriter : XmlTextWriter
+    internal sealed class ProjectWriter : XmlWriter
     {
         #region Regular expressions for item vector transforms
 
