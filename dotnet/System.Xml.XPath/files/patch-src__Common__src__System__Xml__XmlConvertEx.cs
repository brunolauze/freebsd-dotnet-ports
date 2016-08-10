--- src/Common/src/System/Xml/XmlConvertEx.cs.orig	2016-08-04 22:40:47.638835000 -0400
+++ src/Common/src/System/Xml/XmlConvertEx.cs	2016-08-04 22:41:03.690774000 -0400
@@ -161,7 +161,7 @@
                     return new ArgumentException(SR.Format(res, args));
                 case ExceptionType.XmlException:
                 default:
-                    return new System.Xml.XmlException(SR.Format(res, args), null, lineNo, linePos);
+                    return new System.Xml.XmlException(SR.Format(res, args), (string)null, lineNo, linePos);
             }
         }
 
