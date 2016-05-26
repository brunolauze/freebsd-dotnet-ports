--- src/Compilers/Core/Portable/TextLineSpan.cs.orig	2016-01-19 02:33:16.000000000 -0500
+++ src/Compilers/Core/Portable/TextLineSpan.cs	2016-01-20 17:19:02.066991000 -0500
@@ -1,9 +1,9 @@
 ﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
 
 using System;
-using Microsoft.CodeAnalysis.Compilers.Internal;
+using Roslyn.Utilities;
 
-namespace Microsoft.Languages.Text
+namespace Microsoft.CodeAnalysis.Text
 {
     /// <summary>
     /// Contains the span information for a line in the text
@@ -44,7 +44,7 @@
         {
             get
             {
-                Contract.Ensures(Contract.Result<int>() >= 0);
+                //Contract.Ensures(Contract.Result<int>() >= 0);
                 return _textSpan.Length;
             }
         }
@@ -60,7 +60,7 @@
         {
             get
             {
-                Contract.Ensures(Contract.Result<int>() >= 0);
+                //Contract.Ensures(Contract.Result<int>() >= 0);
                 return _lineBreakLength;
             }
         }
@@ -88,7 +88,7 @@
         {
             get
             {
-                Contract.Ensures(Contract.Result<int>() >= 0);
+                //Contract.Ensures(Contract.Result<int>() >= 0);
                 return _textSpan.Length + _lineBreakLength;
             }
         }
@@ -120,10 +120,10 @@
             _lineBreakLength = lineBreakLength;
         }
 
-        [ContractInvariantMethod]
+        //[ContractInvariantMethod]
         private void ObjectInvariant()
         {
-            Contract.Invariant(_lineBreakLength >= 0);
+            //Contract.Invariant(_lineBreakLength >= 0);
         }
 
         /// <summary>
