--- src/vm/ecall.cpp.orig	2016-05-05 16:49:27.939974000 -0400
+++ src/vm/ecall.cpp	2016-05-05 16:51:01.292654000 -0400
@@ -540,8 +540,12 @@
     if (id == 0)
     {
         id = ECall::GetIDForMethod(pMD);
-        _ASSERTE(id != 0);
-
+        //_ASSERTE(id != 0);
+#ifdef _DEBUG
+	CONSISTENCY_CHECK_MSGF(0 != id,
+        ("%s::%s is not registered in mscorlib",
+        pMD->m_pszDebugClassName, pMD->m_pszDebugMethodName));
+#endif
         // Cache the id
         ((NDirectMethodDesc *)pMD)->SetECallID(id);
     }
