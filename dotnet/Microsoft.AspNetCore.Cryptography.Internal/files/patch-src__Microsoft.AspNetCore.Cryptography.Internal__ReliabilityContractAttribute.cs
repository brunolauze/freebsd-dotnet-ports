--- /dev/null	2016-05-07 21:40:24.000000000 -0400
+++ src/Microsoft.AspNetCore.Cryptography.Internal/ReliabilityContractAttribute.cs	2016-05-07 21:41:56.807471000 -0400
@@ -0,0 +1,47 @@
+using System;
+
+namespace System.Runtime.ConstrainedExecution
+{
+    /// <summary>Defines a contract for reliability between the author of some code, and the developers who have a dependency on that code.</summary>
+    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface, Inherited=false)]
+    internal sealed class ReliabilityContractAttribute : Attribute
+    {
+        private Consistency _consistency;
+
+        private Cer _cer;
+
+        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.ConstrainedExecution.ReliabilityContractAttribute" /> class with the specified <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> guarantee and <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> value.</summary>
+        /// <param name="consistencyGuarantee">One of the <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> values. </param>
+        /// <param name="cer">One of the <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> values. </param>
+        public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
+        {
+            this._consistency = consistencyGuarantee;
+            this._cer = cer;
+        }
+    }
+
+    /// <summary>Specifies a reliability contract.</summary>
+    internal enum Consistency
+    {
+        /// <summary>In the face of exceptional conditions, the CLR makes no guarantees regarding state consistency; that is, the condition might corrupt the process.</summary>
+        MayCorruptProcess,
+        /// <summary>In the face of exceptional conditions, the common language runtime (CLR) makes no guarantees regarding state consistency in the current application domain.</summary>
+        MayCorruptAppDomain,
+        /// <summary>In the face of exceptional conditions, the method is guaranteed to limit state corruption to the current instance.</summary>
+        MayCorruptInstance,
+        /// <summary>In the face of exceptional conditions, the method is guaranteed not to corrupt state. </summary>
+        WillNotCorruptState
+    }
+
+    /// <summary>Specifies a method's behavior when called within a constrained execution region.</summary>
+    internal enum Cer
+    {
+        /// <summary>The method, type, or assembly has no concept of a CER. It does not take advantage of CER guarantees. This implies the following:</summary>
+        None,
+        /// <summary>In the face of exceptional conditions, the method might fail. In this case, the method will report back to the calling method whether it succeeded or failed. The method must have a CER around the method body to ensure that it can report the return value.</summary>
+        MayFail,
+        /// <summary>In the face of exceptional conditions, the method is guaranteed to succeed. You should always construct a CER around the method that is called, even when it is called from within a non-CER region. A method is successful if it accomplishes what is intended. For example, marking <see cref="P:System.Collections.ArrayList.Count" /> with ReliabilityContractAttribute(Cer.Success) implies that when it is run under a CER, it always returns a count of the number of elements in the <see cref="T:System.Collections.ArrayList" /> and it can never leave the internal fields in an undetermined state.</summary>
+        Success
+    }
+
+}
