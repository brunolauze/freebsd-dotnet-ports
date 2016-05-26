--- /dev/null	2015-12-29 22:12:19.000000000 -0500
+++ src/System.Numerics.Vectors/src/SR.cs	2015-12-29 22:13:47.334756000 -0500
@@ -0,0 +1,30 @@
+// Copyright (c) Microsoft. All rights reserved.
+// Licensed under the MIT license. See LICENSE file in the project root for full license information.
+
+using System.Resources;
+using System.Runtime.CompilerServices;
+
+namespace System.Numerics.Vectors
+{
+	public class Strings
+	{
+		
+	}
+}
+
+namespace System
+{
+    internal partial class SR
+    {
+	public static Type ResourceType { get { return typeof(System.Numerics.Vectors.Strings); } }
+
+	public static string Arg_NullArgumentNullRef { get { return GetResourceString("Arg_NullArgumentNullRef", "{0}"); } }
+
+	public static string Arg_ElementsInSourceIsGreaterThanDestination { get { return GetResourceString("Arg_ElementsInSourceIsGreaterThanDestination", "{0}"); } }
+
+	public static string Arg_TypeNotSupported { get { return GetResourceString("Arg_TypeNotSupported", "{0}"); } }
+
+	public static string Arg_ArgumentOutOfRangeException { get { return GetResourceString("Arg_ArgumentOutOfRangeException", "{0}"); } }
+     
+    }
+}
