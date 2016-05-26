--- src/Compilers/Core/Portable/PEWriter/MetadataTablesBuilder.cs.orig	2016-04-28 21:57:40.070647000 -0400
+++ src/Compilers/Core/Portable/PEWriter/MetadataTablesBuilder.cs	2016-04-28 21:58:58.421947000 -0400
@@ -1176,7 +1176,7 @@
         private void SerializeConstantTable(BlobBuilder writer, MetadataSizes metadataSizes)
         {
             // Note: we can sort the table at this point since no other table can reference its rows via RowId or CodedIndex (which would need updating otherwise).
-            var ordered = _constantTableNeedsSorting ? _constantTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent) : _constantTable;
+            var ordered = _constantTableNeedsSorting ? _constantTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent).ToList() : _constantTable;
 
             foreach (ConstantRow constant in ordered)
             {
@@ -1191,7 +1191,7 @@
         {
             // Note: we can sort the table at this point since no other table can reference its rows via RowId or CodedIndex (which would need updating otherwise).
             // OrderBy performs a stable sort, so multiple attributes with the same parent will be sorted in the order they were added to the table.
-            var ordered = _customAttributeTableNeedsSorting ? _customAttributeTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent) : _customAttributeTable;
+            var ordered = _customAttributeTableNeedsSorting ? _customAttributeTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent).ToList() : _customAttributeTable;
 
             foreach (CustomAttributeRow customAttribute in ordered)
             {
@@ -1204,7 +1204,7 @@
         private void SerializeFieldMarshalTable(BlobBuilder writer, MetadataSizes metadataSizes)
         {
             // Note: we can sort the table at this point since no other table can reference its rows via RowId or CodedIndex (which would need updating otherwise).
-            var ordered = _fieldMarshalTableNeedsSorting ? _fieldMarshalTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent) : _fieldMarshalTable;
+            var ordered = _fieldMarshalTableNeedsSorting ? _fieldMarshalTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent).ToList() : _fieldMarshalTable;
             
             foreach (FieldMarshalRow fieldMarshal in ordered)
             {
@@ -1217,7 +1217,7 @@
         {
             // Note: we can sort the table at this point since no other table can reference its rows via RowId or CodedIndex (which would need updating otherwise).
             // OrderBy performs a stable sort, so multiple attributes with the same parent will be sorted in the order they were added to the table.
-            var ordered = _declSecurityTableNeedsSorting ? _declSecurityTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent) : _declSecurityTable;
+            var ordered = _declSecurityTableNeedsSorting ? _declSecurityTable.OrderBy((x, y) => (int)x.Parent - (int)y.Parent).ToList() : _declSecurityTable;
             
             foreach (DeclSecurityRow declSecurity in ordered)
             {
@@ -1308,7 +1308,7 @@
         {
             // Note: we can sort the table at this point since no other table can reference its rows via RowId or CodedIndex (which would need updating otherwise).
             // OrderBy performs a stable sort, so multiple attributes with the same parent will be sorted in the order they were added to the table.
-            var ordered = _methodSemanticsTableNeedsSorting ? _methodSemanticsTable.OrderBy((x, y) => (int)x.Association - (int)y.Association) : _methodSemanticsTable;
+            var ordered = _methodSemanticsTableNeedsSorting ? _methodSemanticsTable.OrderBy((x, y) => (int)x.Association - (int)y.Association).ToList() : _methodSemanticsTable;
             
             foreach (MethodSemanticsRow methodSemantic in ordered)
             {
