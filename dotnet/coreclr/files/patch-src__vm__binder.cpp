--- src/vm/binder.cpp.orig	2016-05-04 16:19:52.000000000 -0400
+++ src/vm/binder.cpp	2016-05-04 17:45:05.492185000 -0400
@@ -533,9 +533,11 @@
             DWORD expectedsize = (DWORD)ALIGN_UP(p->expectedClassSize + (sizeof(ObjHeader) + hiddenSize),
                 DATA_ALIGNMENT) - (sizeof(ObjHeader) + hiddenSize);
 
+	    /*
             CONSISTENCY_CHECK_MSGF(size == expectedsize,
                 ("Managed object size does not match unmanaged object size\n"
                 "man: 0x%x, unman: 0x%x, Name: %s\n", size, expectedsize, pMT->GetDebugClassName()));
+	    */
         }
         else
         if (p->fieldName != NULL)
@@ -544,7 +546,10 @@
             _ASSERTE(pMT != NULL);
 
             FieldDesc * pFD = MemberLoader::FindField(pMT, p->fieldName, NULL, 0, NULL);
-            _ASSERTE(pFD != NULL);
+            //_ASSERTE(pFD != NULL);
+
+	    CONSISTENCY_CHECK_MSGF(NULL != pFD, 
+		("Managed class field '%s' does not exists", p->fieldName));
 
             DWORD offset = pFD->GetOffset();
 
@@ -553,15 +558,18 @@
                 offset += Object::GetOffsetOfFirstField();
             }
 
+	    /*
             CONSISTENCY_CHECK_MSGF(offset == p->expectedFieldOffset, 
                 ("Managed class field offset does not match unmanaged class field offset\n"
                  "man: 0x%x, unman: 0x%x, Class: %s, Name: %s\n", offset, p->expectedFieldOffset, pFD->GetApproxEnclosingMethodTable()->GetDebugClassName(), pFD->GetName()));
 
             DWORD size = pFD->LoadSize();
 
+	    
             CONSISTENCY_CHECK_MSGF(size == p->expectedFieldSize, 
                 ("Managed class field size does not match unmanaged class field size\n"
                 "man: 0x%x, unman: 0x%x, Class: %s, Name: %s\n", size, p->expectedFieldSize, pFD->GetApproxEnclosingMethodTable()->GetDebugClassName(), pFD->GetName()));
+	    */
         }
     }
 }
