--- src/System.IO.Compression/src/AssemblyInfo.cs.orig	2016-05-25 20:49:04.000000000 -0400
+++ src/System.IO.Compression/src/AssemblyInfo.cs	2016-05-25 22:12:21.687506000 -0400
@@ -1,7 +1,16 @@
-// Licensed to the .NET Foundation under one or more agreements.
-// The .NET Foundation licenses this file to you under the MIT license.
-// See the LICENSE file in the project root for more information.
+// Copyright (c) .NET Foundation. All rights reserved.
+// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
 
+using System.Reflection;
+using System.Resources;
+using System.Runtime.CompilerServices;
 using System.Security;
 
-[assembly: SecurityTransparentAttribute()]
\ No newline at end of file
+[assembly: AssemblyMetadata("Serviceable", "True")]
+[assembly: NeutralResourcesLanguage("en-us")]
+[assembly: AssemblyCompany("Microsoft Corporation.")]
+[assembly: AssemblyCopyright("Microsoft Corporation. All rights reserved.")]
+[assembly: AssemblyProduct("Microsoft .NET Core")]
+[assembly: AssemblyFileVersion("1.0.0.0")]
+[assembly: AssemblyVersion("1.0.0.0")]
+[assembly: SecurityTransparent]
