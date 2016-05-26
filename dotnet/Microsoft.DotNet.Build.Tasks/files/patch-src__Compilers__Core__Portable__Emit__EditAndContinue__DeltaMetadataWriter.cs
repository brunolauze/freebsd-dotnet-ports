--- src/Compilers/Core/Portable/Emit/EditAndContinue/DeltaMetadataWriter.cs.orig	2016-01-21 10:33:46.858550000 -0500
+++ src/Compilers/Core/Portable/Emit/EditAndContinue/DeltaMetadataWriter.cs	2016-01-21 10:34:12.969996000 -0500
@@ -123,7 +123,7 @@
             return ImmutableArray.Create(sizes);
         }
 
-        internal EmitBaseline GetDelta(EmitBaseline baseline, Compilation compilation, Guid encId, MetadataSizes metadataSizes)
+        internal EmitBaseline GetDelta(EmitBaseline baseline, Compilation compilation, Guid encId, Microsoft.Cci.MetadataSizes metadataSizes)
         {
             var moduleBuilder = (CommonPEModuleBuilder)this.module;
 
