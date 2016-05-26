--- src/mscorlib/src/System/Security/securestring.cs.orig	2016-04-23 08:46:00.000000000 -0400
+++ src/mscorlib/src/System/Security/securestring.cs	2016-04-23 19:21:25.880641000 -0400
@@ -2,7 +2,9 @@
 // The .NET Foundation licenses this file to you under the MIT license.
 // See the LICENSE file in the project root for more information.
 namespace System.Security {
+#if WIN32
     using System.Security.Cryptography;
+#endif
     using System.Runtime.InteropServices;
 #if FEATURE_CORRUPTING_EXCEPTIONS
     using System.Runtime.ExceptionServices;
@@ -25,10 +27,17 @@
         private bool     m_encrypted; 
         
         static bool supportedOnCurrentPlatform = EncryptionSupported();
-
+#if WIN32
         const int BlockSize = (int)Win32Native.CRYPTPROTECTMEMORY_BLOCK_SIZE /2;  // a char is two bytes
+#else
+	const int BlockSize = 1024;
+#endif
         const int MaxLength = 65536;
+#if WIN32
         const uint ProtectionScope = Win32Native.CRYPTPROTECTMEMORY_SAME_PROCESS;
+#else
+	const uint ProtectionScope = 0x0;
+#endif
                 
         [System.Security.SecuritySafeCritical]  // auto-generated
         static SecureString()
@@ -38,6 +47,7 @@
         [System.Security.SecurityCritical]  // auto-generated
         unsafe static bool EncryptionSupported() {
             // check if the enrypt/decrypt function is supported on current OS
+#if WIN32
             bool supported = true;                        
             try {
                 Win32Native.SystemFunction041(
@@ -49,6 +59,9 @@
                 supported = false;
             }            
             return supported;
+#else
+	    return false;
+#endif
         }
         
         [System.Security.SecurityCritical]  // auto-generated
@@ -398,7 +411,7 @@
             RuntimeHelpers.PrepareConstrainedRegions();
             try {
                 m_buffer.AcquirePointer(ref bufferPtr);
-
+#if WIN32
                 return Win32Native.WideCharToMultiByte(
                     CP_ACP,
                     flgs,
@@ -408,6 +421,9 @@
                     0,
                     IntPtr.Zero,
                     new IntPtr((void*)&DefaultCharUsed));
+#else
+		return m_buffer.Length;
+#endif
             }
             finally {
                 if (bufferPtr != null)
@@ -427,7 +443,7 @@
             RuntimeHelpers.PrepareConstrainedRegions();
             try {
                 m_buffer.AcquirePointer(ref bufferPtr);
-
+#if WIN32
                 Win32Native.WideCharToMultiByte(
                     CP_ACP,
                     flgs,
@@ -439,6 +455,7 @@
                     new IntPtr((void*)&DefaultCharUsed));
 
                 *(ansiStrPtr + byteCount - 1) = (byte)0;
+#endif
             }
             finally {
                 if (bufferPtr != null)
@@ -448,7 +465,8 @@
 
         [System.Security.SecurityCritical]  // auto-generated
         [ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
-        private void ProtectMemory() {            
+        private void ProtectMemory() {
+#if WIN32
             Contract.Assert(!m_buffer.IsInvalid && m_buffer.Length != 0, "Invalid buffer!");
             Contract.Assert(m_buffer.Length % BlockSize == 0, "buffer length must be multiple of blocksize!");
 
@@ -470,7 +488,8 @@
 #endif
                 }
                 m_encrypted = true;
-            }            
+            }
+#endif        
         }
         
         [System.Security.SecurityCritical]  // auto-generated
@@ -489,6 +508,7 @@
             RuntimeHelpers.PrepareConstrainedRegions();
             try {            
                 RuntimeHelpers.PrepareConstrainedRegions();            
+#if WIN32
                 try {
                 }
                 finally {
@@ -498,7 +518,7 @@
                 if (ptr == IntPtr.Zero) {
                     throw new OutOfMemoryException();
                 }
-                
+#endif                
                 UnProtectMemory();
                 m_buffer.AcquirePointer(ref bufferPtr);
                 Buffer.Memcpy((byte*) ptr.ToPointer(), bufferPtr, length *2); 
@@ -511,11 +531,13 @@
             finally {                
                 ProtectMemory();                
                 if( result == IntPtr.Zero) { 
+#if WIN32
                     // If we failed for any reason, free the new buffer
                     if (ptr != IntPtr.Zero) {
                         Win32Native.ZeroMemory(ptr, (UIntPtr)(length * 2));
                         Win32Native.SysFreeString(ptr);
                     }                    
+#endif
                 }
                 if (bufferPtr != null)
                     m_buffer.ReleasePointer();
@@ -570,7 +592,9 @@
                 if( result == IntPtr.Zero) { 
                     // If we failed for any reason, free the new buffer
                     if (ptr != IntPtr.Zero) {
+#if WIN32
                         Win32Native.ZeroMemory(ptr, (UIntPtr)(length * 2));
+#endif
                         if( allocateFromHeap) {                                                    
                             Marshal.FreeHGlobal(ptr);
                         }
@@ -633,7 +657,9 @@
                 if( result == IntPtr.Zero) { 
                     // If we failed for any reason, free the new buffer
                     if (ptr != IntPtr.Zero) {
+#if WIN32
                         Win32Native.ZeroMemory(ptr, (UIntPtr)byteCount);
+#endif
                         if( allocateFromHeap) {                                                    
                             Marshal.FreeHGlobal(ptr);
                         }
@@ -650,6 +676,7 @@
         [System.Security.SecurityCritical]  // auto-generated
         [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
         private void UnProtectMemory() {
+#if WIN32
             Contract.Assert(!m_buffer.IsInvalid && m_buffer.Length != 0, "Invalid buffer!");
             Contract.Assert(m_buffer.Length % BlockSize == 0, "buffer length must be multiple of blocksize!");
 
@@ -675,6 +702,7 @@
                     m_encrypted = false;
                 }
             }
+#endif
         }        
     }
 
@@ -697,8 +725,10 @@
         [System.Security.SecurityCritical]
         override protected bool ReleaseHandle()
         {
+#if WIN32
             Win32Native.ZeroMemory(handle, (UIntPtr) (Win32Native.SysStringLen(handle) * 2));
             Win32Native.SysFreeString(handle);
+#endif
             return true;
         }
 
@@ -706,6 +736,7 @@
         internal unsafe void ClearBuffer() {
             byte* bufferPtr = null;
             RuntimeHelpers.PrepareConstrainedRegions();
+#if WIN32
             try
             {
                 AcquirePointer(ref bufferPtr);
@@ -716,12 +747,13 @@
                 if (bufferPtr != null)
                     ReleasePointer();
             }
+#endif
         }
 
 
         internal unsafe int Length {
             get {
-                return (int) Win32Native.SysStringLen(this);
+                return 0; // (int) Win32Native.SysStringLen(this);
             }
         }
 
@@ -730,12 +762,14 @@
             RuntimeHelpers.PrepareConstrainedRegions();
             try
             {
+#if WIN32
                 source.AcquirePointer(ref sourcePtr);
                 target.AcquirePointer(ref targetPtr);
 
                 Contract.Assert(Win32Native.SysStringLen((IntPtr)targetPtr) >= Win32Native.SysStringLen((IntPtr)sourcePtr), "Target buffer is not large enough!");
 
                 Buffer.Memcpy(targetPtr, sourcePtr, (int) Win32Native.SysStringLen((IntPtr)sourcePtr) * 2);
+#endif
             }
             finally
             {
