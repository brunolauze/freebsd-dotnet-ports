--- /dev/null	2016-01-22 15:11:00.000000000 -0500
+++ src/Compilers/CSharp/CscCore/AssemblyLoadContext.cs	2016-01-22 15:12:01.266496000 -0500
@@ -0,0 +1,46 @@
+using System;
+using System.IO;
+using System.Reflection;
+
+namespace System.Runtime.Loader
+{
+    public abstract class AssemblyLoadContext
+    {
+        protected abstract Assembly Load(AssemblyName assemblyName);
+
+	protected static void InitializeDefaultContext(AssemblyLoadContext context)
+	{
+		
+	}
+
+        protected Assembly LoadFromAssemblyPath(string assemblyPath)
+        {
+            if (assemblyPath == null)
+                throw new ArgumentNullException("assemblyPath");
+
+            if (!Path.IsPathRooted(assemblyPath))
+                throw new ArgumentException("Gimme an absolute path " + assemblyPath + " XXX " + Path.GetPathRoot(assemblyPath), "assemblyPath");
+
+            return Assembly.LoadFrom (assemblyPath);
+        }
+
+        public Assembly LoadFromAssemblyName(AssemblyName assemblyName)
+        {
+            // AssemblyName is mutable. Cache the expected name before anybody gets a chance to modify it.
+            string requestedSimpleName = assemblyName.Name;
+
+            Assembly assembly = Load(assemblyName);
+            if (assembly == null)
+                throw new FileLoadException("File not found", requestedSimpleName);
+
+            return assembly;
+        }
+
+        public static AssemblyName GetAssemblyName(string assemblyPath)
+        {
+            if (!File.Exists (assemblyPath))
+                throw new Exception ("file not found");
+            return new AssemblyName (Path.GetFileName (assemblyPath));
+        }
+    }
+}
