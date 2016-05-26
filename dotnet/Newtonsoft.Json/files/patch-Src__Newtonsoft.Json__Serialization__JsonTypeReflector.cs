--- Src/Newtonsoft.Json/Serialization/JsonTypeReflector.cs.orig	2016-05-07 21:33:34.657622000 -0400
+++ Src/Newtonsoft.Json/Serialization/JsonTypeReflector.cs	2016-05-07 21:33:49.598418000 -0400
@@ -94,7 +94,7 @@
             // DataMemberAttribute does not have inheritance
 
             // can't override a field
-            if (memberInfo.MemberType() == MemberTypes.Field)
+            if (memberInfo.MemberType() == Newtonsoft.Json.Utilities.MemberTypes.Field)
             {
                 return CachedAttributeGetter<DataMemberAttribute>.GetAttribute(memberInfo);
             }
@@ -458,4 +458,4 @@
             }
         }
     }
-}
\ No newline at end of file
+}
