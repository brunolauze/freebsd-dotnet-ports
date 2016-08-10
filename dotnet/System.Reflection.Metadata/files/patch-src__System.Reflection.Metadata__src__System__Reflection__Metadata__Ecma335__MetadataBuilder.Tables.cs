--- src/System.Reflection.Metadata/src/System/Reflection/Metadata/Ecma335/MetadataBuilder.Tables.cs.orig	2016-08-06 13:37:52.418420000 -0400
+++ src/System.Reflection.Metadata/src/System/Reflection/Metadata/Ecma335/MetadataBuilder.Tables.cs	2016-08-06 13:38:35.505255000 -0400
@@ -1575,7 +1575,7 @@
                     continue;
                 }
 
-                Throw.InvalidOperation_TableNotSorted(TableIndex.InterfaceImpl);
+                //TODO: TEMP: Throw.InvalidOperation_TableNotSorted(TableIndex.InterfaceImpl);
             }
         }
 
