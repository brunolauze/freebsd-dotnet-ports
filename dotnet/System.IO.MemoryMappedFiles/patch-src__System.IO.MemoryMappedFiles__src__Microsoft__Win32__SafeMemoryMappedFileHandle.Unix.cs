--- src/System.IO.MemoryMappedFiles/src/Microsoft/Win32/SafeMemoryMappedFileHandle.Unix.cs.orig	2016-03-07 09:41:43.000000000 -0500
+++ src/System.IO.MemoryMappedFiles/src/Microsoft/Win32/SafeMemoryMappedFileHandle.Unix.cs	2016-03-11 15:44:03.575435000 -0500
@@ -39,6 +39,18 @@
         /// <summary>The capacity of the memory-mapped file.</summary>
         internal readonly long _capacity;
 
+	public SafeMemoryMappedFileHandle(IntPtr ptr, bool ownsHandle)
+		 : base(ptr, ownsHandle: ownsHandle)
+	{
+		// Store the arguments.  We'll actually open the map when the view is created.
+            _fileStream = new FileStream(ptr, ownsHandle ? FileAccess.ReadWrite : FileAccess.Read);
+            _ownsFileStream = ownsHandle;
+            _inheritability = HandleInheritability.None;
+            _access = MemoryMappedFileAccess.ReadWriteExecute;
+            _options = MemoryMappedFileOptions.None;
+            _capacity = long.MaxValue;
+	}
+
         /// <summary>Initializes the memory-mapped file handle.</summary>
         /// <param name="fileStream">The underlying file stream; may be null.</param>
         /// <param name="ownsFileStream">Whether this SafeHandle is responsible for Disposing the fileStream.</param>
