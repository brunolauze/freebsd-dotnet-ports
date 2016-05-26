--- src/System.Composition.TypedParts/src/System/Composition/TypedParts/Util/DirectAttributeContext.cs.orig	2016-05-14 12:27:02.372666000 -0400
+++ src/System.Composition.TypedParts/src/System/Composition/TypedParts/Util/DirectAttributeContext.cs	2016-05-14 12:27:43.657998000 -0400
@@ -3,6 +3,7 @@
 // See the LICENSE file in the project root for more information.
 
 using System.Collections.Generic;
+using System.Linq;
 using System.Reflection;
 using System.Composition.Convention;
 using Microsoft.Internal;
@@ -19,14 +20,14 @@
             if (!(member is TypeInfo) && member.DeclaringType != reflectedType)
                 return EmptyArray<Attribute>.Value;
 
-            return member.GetCustomAttributes(false);
+            return member.GetCustomAttributes(false).Select(x => (Attribute)x);
         }
 
         public override IEnumerable<Attribute> GetCustomAttributes(Type reflectedType, Reflection.ParameterInfo parameter)
         {
             if (reflectedType == null) throw new ArgumentNullException(nameof(reflectedType));
             if (parameter == null) throw new ArgumentNullException(nameof(parameter));
-            return parameter.GetCustomAttributes(false);
+            return parameter.GetCustomAttributes(false).Select(x => (Attribute)x);
         }
     }
 }
