--- src/System.Net.Primitives/src/System/Net/CredentialCache.cs.orig	2016-07-25 19:35:28.000000000 -0400
+++ src/System.Net.Primitives/src/System/Net/CredentialCache.cs	2016-07-25 23:10:53.390268000 -0400
@@ -351,7 +351,7 @@
                 }
 
                 protected override bool MoveNext(out NetworkCredential current) =>
-                    DictionaryEnumeratorHelper.MoveNext(ref _enumerator, out current);
+                    DictionaryEnumeratorHelper.MoveNext<TKey, NetworkCredential>(ref _enumerator, out current);
 
                 public override void Reset()
                 {
@@ -389,7 +389,7 @@
                         }
                     }
 
-                    return DictionaryEnumeratorHelper.MoveNext(ref _enumerator, out current);
+                    return DictionaryEnumeratorHelper.MoveNext<CredentialHostKey, NetworkCredential>(ref _enumerator, out current);
                 }
 
                 public override void Reset()
