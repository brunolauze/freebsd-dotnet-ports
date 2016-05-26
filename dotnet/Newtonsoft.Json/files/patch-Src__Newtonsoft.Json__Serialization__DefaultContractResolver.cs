--- Src/Newtonsoft.Json/Serialization/DefaultContractResolver.cs.orig	2016-05-07 21:30:39.634098000 -0400
+++ Src/Newtonsoft.Json/Serialization/DefaultContractResolver.cs	2016-05-07 21:32:30.677792000 -0400
@@ -324,7 +324,7 @@
                                 serializableMembers.Add(member);
                             }
 #endif
-                            else if (memberSerialization == MemberSerialization.Fields && member.MemberType() == MemberTypes.Field)
+                            else if (memberSerialization == MemberSerialization.Fields && member.MemberType() == Newtonsoft.Json.Utilities.MemberTypes.Field)
                             {
                                 serializableMembers.Add(member);
                             }
@@ -457,8 +457,8 @@
 
             MemberInfo extensionDataMember = members.LastOrDefault(m =>
             {
-                MemberTypes memberType = m.MemberType();
-                if (memberType != MemberTypes.Property && memberType != MemberTypes.Field)
+                Newtonsoft.Json.Utilities.MemberTypes memberType = m.MemberType();
+                if (memberType != Newtonsoft.Json.Utilities.MemberTypes.Property && memberType != Newtonsoft.Json.Utilities.MemberTypes.Field)
                 {
                     return false;
                 }
@@ -1568,4 +1568,4 @@
             return ResolvePropertyName(propertyName);
         }
     }
-}
\ No newline at end of file
+}
