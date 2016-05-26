--- src/XMakeCommandLine/XMake.cs.orig	2016-01-25 15:14:55.000000000 -0500
+++ src/XMakeCommandLine/XMake.cs	2016-01-26 15:31:03.523045000 -0500
@@ -1104,6 +1104,8 @@
                     catch (Exception ex)
                     {
                         exception = ex;
+			Console.WriteLine(ex.Message);
+			Console.WriteLine(ex.StackTrace);
                         success = false;
                     }
 
@@ -1393,6 +1395,13 @@
                             // add a (fake) parameter indicator for later parsing
                             switchParameters = ":" + commandLineArg;
                         }
+			// check if it's a path instead of switch for unix
+			else if (System.IO.File.Exists(unquotedCommandLineArg))
+			{
+				switchName = null;
+				// add a (fake) parameter indicator for later parsing
+				switchParameters = ":" + commandLineArg;
+			}
                         else
                         {
                             // check if switch has parameters (look for the : parameter indicator)
