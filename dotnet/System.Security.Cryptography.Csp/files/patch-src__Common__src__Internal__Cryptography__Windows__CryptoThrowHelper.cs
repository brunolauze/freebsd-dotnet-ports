--- src/Common/src/Internal/Cryptography/Windows/CryptoThrowHelper.cs.orig	2016-03-09 09:37:53.012555000 -0500
+++ src/Common/src/Internal/Cryptography/Windows/CryptoThrowHelper.cs	2016-03-09 09:38:54.779348000 -0500
@@ -12,7 +12,11 @@
     {
         public static CryptographicException ToCryptographicException(this int hr)
         {
+#if WIN32
             string message = Interop.mincore.GetMessage(hr);
+#else
+	    string message = $"CRYPTO ERROR: {hr.ToString()}";
+#endif
             return new WindowsCryptographicException(hr, message);
         }
 
