--- src/Shared/XamlUtilities.cs.orig	2016-01-24 21:55:18.703120000 -0500
+++ src/Shared/XamlUtilities.cs	2016-01-24 21:56:52.822188000 -0500
@@ -139,7 +139,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this Argument type)
+        internal static void Validate(this Argument type)
         {
             string propertyId = GetPropertyId("Property", type);
             VerifyThrowPropertyNotSetOrEmptyString(type.Property, propertyId);
@@ -149,7 +149,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this BaseProperty type)
+        internal static void Validate(this BaseProperty type)
         {
             string namePropertyId = GetPropertyId("Name", type);
             VerifyThrowPropertyNotSetOrEmptyString(type.Name, namePropertyId);
@@ -221,7 +221,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this Category type)
+        internal static void Validate(this Category type)
         {
             string namePropertyId = GetPropertyId("Name", type);
             VerifyThrowPropertyNotSetOrEmptyString(type.Name, namePropertyId);
@@ -232,7 +232,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this DataSource type)
+        internal static void Validate(this DataSource type)
         {
             string persistencePropertyId = GetPropertyId("Persistence", type);
             VerifyThrowPropertyNotSetOrEmptyString(type.Persistence, persistencePropertyId);
@@ -241,7 +241,7 @@
         /// <summary>
         /// Validate the content type data integrity afte deserializing from XAML file
         /// </summary>
-        internal void Validate(this ContentType type)
+        internal static void Validate(this ContentType type)
         {
             // content type must at least declare name, and msbuild ItemType to be workable at minimum level
             string namePropertyId = GetPropertyId("Name", type);
@@ -255,7 +255,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this DynamicEnumProperty type)
+        internal static void Validate(this DynamicEnumProperty type)
         {
             (type as BaseProperty).Validate();
             ErrorUtilities.VerifyThrowArgumentLength(type.EnumProvider, "EnumProvider");
@@ -266,7 +266,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        private void Validate(this EnumProperty type)
+        private static void Validate(this EnumProperty type)
         {
             (type as BaseProperty).Validate();
 
@@ -306,7 +306,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this IntProperty type)
+        internal static void Validate(this IntProperty type)
         {
             (type as BaseProperty).Validate();
 
@@ -323,7 +323,7 @@
         /// <summary>
         /// Validate the content type data integrity afte deserializing from XAML file
         /// </summary>
-        internal void Validate(this ItemType type)
+        internal static void Validate(this ItemType type)
         {
             // content type must at least declare name, and msbuild ItemType to be workable at minimum level
             string namePropertyId = GetPropertyId("Name", type);
@@ -339,7 +339,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this Rule type)
+        internal static void Validate(this Rule type)
         {
             // Validate "Name" property.
             string namePropertyId = GetPropertyId("Name", type);
@@ -407,7 +407,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this RuleBag type)
+        internal static void Validate(this RuleBag type)
         {
             // Make sure that at least one Rule was defined in this RuleBag.
             string rulesId = GetPropertyId("Rules", type);
@@ -423,7 +423,7 @@
         /// Validates the properties of this object. This method should be called
         /// after initialization is complete.
         /// </summary>
-        internal void Validate(this ValueEditor type)
+        internal static void Validate(this ValueEditor type)
         {
             string propertyId = GetPropertyId("EditorType", type);
             VerifyThrowPropertyNotSetOrEmptyString(type.EditorType, propertyId);
