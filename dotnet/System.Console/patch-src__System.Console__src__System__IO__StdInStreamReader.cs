--- src/System.Console/src/System/IO/StdInStreamReader.cs.orig	2016-03-03 17:57:16.000000000 -0500
+++ src/System.Console/src/System/IO/StdInStreamReader.cs	2016-03-05 17:28:22.332895000 -0500
@@ -286,12 +286,20 @@
         internal bool MapBufferToConsoleKey(out ConsoleKey key, out char ch, out bool isShift, out bool isAlt, out bool isCtrl)
         {
             Debug.Assert(!IsUnprocessedBufferEmpty());
-
+	    ch = '\0';
+	    isShift = false;
+	    isAlt = false;
+	    isCtrl = false;
+	    key = default(ConsoleKey);
+	    if (_unprocessedBufferToBeRead == null) 
+		return false;
             // Try to get the special key match from the TermInfo static information.
             ConsoleKeyInfo keyInfo;
             int keyLength;
+	    try {
             if (ConsolePal.TryGetSpecialConsoleKey(_unprocessedBufferToBeRead, _startIndex, _endIndex, out keyInfo, out keyLength))
             {
+		if (_unprocessedBufferToBeRead == null || _unprocessedBufferToBeRead.Length <= _startIndex) return false;
                 key = keyInfo.Key;
                 isShift = (keyInfo.Modifiers & ConsoleModifiers.Shift) != 0;
                 isAlt = (keyInfo.Modifiers & ConsoleModifiers.Alt) != 0;
@@ -301,6 +309,8 @@
                 _startIndex += keyLength;
                 return true;
             }
+	
+	    if (_unprocessedBufferToBeRead == null || _unprocessedBufferToBeRead.Length <= _startIndex) return false;
 
             // Check if we can match Esc + combination and guess if alt was pressed.
             isAlt = isCtrl = isShift = false;
@@ -325,11 +335,16 @@
                 }
             }
 
+	    if (_unprocessedBufferToBeRead == null || _unprocessedBufferToBeRead.Length <= _startIndex + 1) return false;
+
             // Try reading the first char in the buffer and interpret it as a key.
             ch = _unprocessedBufferToBeRead[_startIndex++];
             key = GetKeyFromCharValue(ch, out isShift, out isCtrl);
 
             return key != default(ConsoleKey);
+	   }
+	   catch(Exception ex) { } 
+	   return false;
         }
 
         /// <summary>
