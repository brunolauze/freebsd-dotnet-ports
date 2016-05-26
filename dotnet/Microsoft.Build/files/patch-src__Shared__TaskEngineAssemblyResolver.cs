--- src/Shared/TaskEngineAssemblyResolver.cs.orig	2016-03-16 10:23:16.475388000 -0400
+++ src/Shared/TaskEngineAssemblyResolver.cs	2016-03-16 10:24:02.763503000 -0400
@@ -15,7 +15,6 @@
     /// This is a helper class to install an AssemblyResolver event handler in whatever AppDomain this class is created in.
     /// </summary>
     internal class TaskEngineAssemblyResolver
-        : MarshalByRefObject
     {
         /// <summary>
         /// This public default constructor is needed so that instances of this class can be created by NDP.
@@ -117,7 +116,7 @@
         /// lease (5 minutes I think) and instances can expire if they take long time processing.
         /// </summary>
         [System.Security.SecurityCritical]
-        public override object InitializeLifetimeService()
+        public object InitializeLifetimeService()
         {
             // null means infinite lease time
             return null;
