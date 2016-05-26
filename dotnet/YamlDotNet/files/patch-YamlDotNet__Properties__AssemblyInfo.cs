--- YamlDotNet/Properties/AssemblyInfo.cs.orig	2016-05-15 10:34:26.422344000 -0400
+++ YamlDotNet/Properties/AssemblyInfo.cs	2016-05-15 10:34:59.194851000 -0400
@@ -50,17 +50,10 @@
 //
 // You can specify all the values or you can default the Revision and Build Numbers
 // by using the '*' as shown below:
-[assembly: AssemblyVersion("0.0.1")]
-[assembly: AssemblyFileVersion("0.0.0")]
-[assembly: AssemblyInformationalVersion("0.0.0")]
+[assembly: AssemblyVersion("1.0.0")]
+[assembly: AssemblyFileVersion("1.0.0")]
+[assembly: AssemblyInformationalVersion("1.0.0")]
 
 [assembly: CLSCompliant(true)]
-#if !SIGNED
-#if PORTABLE
-[assembly: InternalsVisibleTo("YamlDotNet.Test.Portable")]
-#else
-[assembly: InternalsVisibleTo("YamlDotNet.Test")]
-#endif
-#endif
 
-#endif
\ No newline at end of file
+#endif
