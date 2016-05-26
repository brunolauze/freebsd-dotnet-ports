--- /dev/null	2016-05-11 18:37:01.000000000 -0400
+++ src/System.ComponentModel.Annotations/src/SR.cs	2016-05-11 18:37:18.239904000 -0400
@@ -0,0 +1,558 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.ComponentModel.Annotations
+{
+    internal static class SR
+    {
+
+    }
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.ComponentModel.Annotations.SR";
+
+        internal static String ArgumentIsNullOrWhitespace
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentIsNullOrWhitespace", null);
+            }
+        }
+
+        internal static String AssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties
+        {
+            get
+            {
+                return SR.GetResourceString("AssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties", null);
+            }
+        }
+
+        internal static String AttributeStore_Type_Must_Be_Public
+        {
+            get
+            {
+                return SR.GetResourceString("AttributeStore_Type_Must_Be_Public", null);
+            }
+        }
+
+        internal static String AttributeStore_Unknown_Method
+        {
+            get
+            {
+                return SR.GetResourceString("AttributeStore_Unknown_Method", null);
+            }
+        }
+
+        internal static String AttributeStore_Unknown_Property
+        {
+            get
+            {
+                return SR.GetResourceString("AttributeStore_Unknown_Property", null);
+            }
+        }
+
+        internal static String Common_NullOrEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Common_NullOrEmpty", null);
+            }
+        }
+
+        internal static String Common_PropertyNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Common_PropertyNotFound", null);
+            }
+        }
+
+        internal static String CompareAttribute_MustMatch
+        {
+            get
+            {
+                return SR.GetResourceString("CompareAttribute_MustMatch", null);
+            }
+        }
+
+        internal static String CompareAttribute_UnknownProperty
+        {
+            get
+            {
+                return SR.GetResourceString("CompareAttribute_UnknownProperty", null);
+            }
+        }
+
+        internal static String CreditCardAttribute_Invalid
+        {
+            get
+            {
+                return SR.GetResourceString("CreditCardAttribute_Invalid", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_Method_Must_Return_ValidationResult
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_Method_Must_Return_ValidationResult", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_Method_Not_Found
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_Method_Not_Found", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_Method_Required
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_Method_Required", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_Method_Signature
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_Method_Signature", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_Type_Conversion_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_Type_Conversion_Failed", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_Type_Must_Be_Public
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_Type_Must_Be_Public", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String CustomValidationAttribute_ValidatorType_Required
+        {
+            get
+            {
+                return SR.GetResourceString("CustomValidationAttribute_ValidatorType_Required", null);
+            }
+        }
+
+        internal static String DataTypeAttribute_EmptyDataTypeString
+        {
+            get
+            {
+                return SR.GetResourceString("DataTypeAttribute_EmptyDataTypeString", null);
+            }
+        }
+
+        internal static String DisplayAttribute_PropertyNotSet
+        {
+            get
+            {
+                return SR.GetResourceString("DisplayAttribute_PropertyNotSet", null);
+            }
+        }
+
+        internal static String EmailAddressAttribute_Invalid
+        {
+            get
+            {
+                return SR.GetResourceString("EmailAddressAttribute_Invalid", null);
+            }
+        }
+
+        internal static String EnumDataTypeAttribute_TypeCannotBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("EnumDataTypeAttribute_TypeCannotBeNull", null);
+            }
+        }
+
+        internal static String EnumDataTypeAttribute_TypeNeedsToBeAnEnum
+        {
+            get
+            {
+                return SR.GetResourceString("EnumDataTypeAttribute_TypeNeedsToBeAnEnum", null);
+            }
+        }
+
+        internal static String FileExtensionsAttribute_Invalid
+        {
+            get
+            {
+                return SR.GetResourceString("FileExtensionsAttribute_Invalid", null);
+            }
+        }
+
+        internal static String LocalizableString_LocalizationFailed
+        {
+            get
+            {
+                return SR.GetResourceString("LocalizableString_LocalizationFailed", null);
+            }
+        }
+
+        internal static String MaxLengthAttribute_InvalidMaxLength
+        {
+            get
+            {
+                return SR.GetResourceString("MaxLengthAttribute_InvalidMaxLength", null);
+            }
+        }
+
+        internal static String MaxLengthAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("MaxLengthAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String MetadataTypeAttribute_TypeCannotBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("MetadataTypeAttribute_TypeCannotBeNull", null);
+            }
+        }
+
+        internal static String MinLengthAttribute_InvalidMinLength
+        {
+            get
+            {
+                return SR.GetResourceString("MinLengthAttribute_InvalidMinLength", null);
+            }
+        }
+
+        internal static String MinLengthAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("MinLengthAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String PhoneAttribute_Invalid
+        {
+            get
+            {
+                return SR.GetResourceString("PhoneAttribute_Invalid", null);
+            }
+        }
+
+        internal static String RangeAttribute_ArbitraryTypeNotIComparable
+        {
+            get
+            {
+                return SR.GetResourceString("RangeAttribute_ArbitraryTypeNotIComparable", null);
+            }
+        }
+
+        internal static String RangeAttribute_MinGreaterThanMax
+        {
+            get
+            {
+                return SR.GetResourceString("RangeAttribute_MinGreaterThanMax", null);
+            }
+        }
+
+        internal static String RangeAttribute_Must_Set_Min_And_Max
+        {
+            get
+            {
+                return SR.GetResourceString("RangeAttribute_Must_Set_Min_And_Max", null);
+            }
+        }
+
+        internal static String RangeAttribute_Must_Set_Operand_Type
+        {
+            get
+            {
+                return SR.GetResourceString("RangeAttribute_Must_Set_Operand_Type", null);
+            }
+        }
+
+        internal static String RangeAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("RangeAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String RegexAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("RegexAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String RegularExpressionAttribute_Empty_Pattern
+        {
+            get
+            {
+                return SR.GetResourceString("RegularExpressionAttribute_Empty_Pattern", null);
+            }
+        }
+
+        internal static String RequiredAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("RequiredAttribute_ValidationError", null);
+            }
+        }
+
+        private static ResourceManager ResourceManager
+        {
+            get
+            {
+                if (SR.s_resourceManager == null)
+                {
+                    SR.s_resourceManager = new ResourceManager(SR.ResourceType);
+                }
+                return SR.s_resourceManager;
+            }
+        }
+
+        internal static Type ResourceType
+        {
+            get
+            {
+                return typeof(FxResources.System.ComponentModel.Annotations.SR);
+            }
+        }
+
+        internal static String StringLengthAttribute_InvalidMaxLength
+        {
+            get
+            {
+                return SR.GetResourceString("StringLengthAttribute_InvalidMaxLength", null);
+            }
+        }
+
+        internal static String StringLengthAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("StringLengthAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String StringLengthAttribute_ValidationErrorIncludingMinimum
+        {
+            get
+            {
+                return SR.GetResourceString("StringLengthAttribute_ValidationErrorIncludingMinimum", null);
+            }
+        }
+
+        internal static String UIHintImplementation_ControlParameterKeyIsNotAString
+        {
+            get
+            {
+                return SR.GetResourceString("UIHintImplementation_ControlParameterKeyIsNotAString", null);
+            }
+        }
+
+        internal static String UIHintImplementation_ControlParameterKeyIsNull
+        {
+            get
+            {
+                return SR.GetResourceString("UIHintImplementation_ControlParameterKeyIsNull", null);
+            }
+        }
+
+        internal static String UIHintImplementation_ControlParameterKeyOccursMoreThanOnce
+        {
+            get
+            {
+                return SR.GetResourceString("UIHintImplementation_ControlParameterKeyOccursMoreThanOnce", null);
+            }
+        }
+
+        internal static String UIHintImplementation_NeedEvenNumberOfControlParameters
+        {
+            get
+            {
+                return SR.GetResourceString("UIHintImplementation_NeedEvenNumberOfControlParameters", null);
+            }
+        }
+
+        internal static String UrlAttribute_Invalid
+        {
+            get
+            {
+                return SR.GetResourceString("UrlAttribute_Invalid", null);
+            }
+        }
+
+        internal static String ValidationAttribute_Cannot_Set_ErrorMessage_And_Resource
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationAttribute_Cannot_Set_ErrorMessage_And_Resource", null);
+            }
+        }
+
+        internal static String ValidationAttribute_IsValid_NotImplemented
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationAttribute_IsValid_NotImplemented", null);
+            }
+        }
+
+        internal static String ValidationAttribute_NeedBothResourceTypeAndResourceName
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationAttribute_NeedBothResourceTypeAndResourceName", null);
+            }
+        }
+
+        internal static String ValidationAttribute_ResourcePropertyNotStringType
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationAttribute_ResourcePropertyNotStringType", null);
+            }
+        }
+
+        internal static String ValidationAttribute_ResourceTypeDoesNotHaveProperty
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationAttribute_ResourceTypeDoesNotHaveProperty", null);
+            }
+        }
+
+        internal static String ValidationAttribute_ValidationError
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationAttribute_ValidationError", null);
+            }
+        }
+
+        internal static String ValidationContext_Must_Be_Method
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationContext_Must_Be_Method", null);
+            }
+        }
+
+        internal static String ValidationContextServiceContainer_ItemAlreadyExists
+        {
+            get
+            {
+                return SR.GetResourceString("ValidationContextServiceContainer_ItemAlreadyExists", null);
+            }
+        }
+
+        internal static String Validator_InstanceMustMatchValidationContextInstance
+        {
+            get
+            {
+                return SR.GetResourceString("Validator_InstanceMustMatchValidationContextInstance", null);
+            }
+        }
+
+        internal static String Validator_Property_Value_Wrong_Type
+        {
+            get
+            {
+                return SR.GetResourceString("Validator_Property_Value_Wrong_Type", null);
+            }
+        }
+
+        internal static String Format(String resourceFormat, params Object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, args);
+            }
+            return String.Concat(resourceFormat, String.Join(", ", args));
+        }
+
+        internal static String Format(String resourceFormat, Object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2, p3);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static String GetResourceString(String resourceKey, String defaultString)
+        {
+            String str = null;
+            try
+            {
+                str = SR.ResourceManager.GetString(resourceKey);
+            }
+            catch (MissingManifestResourceException missingManifestResourceException)
+            {
+            }
+            if (defaultString != null && resourceKey.Equals(str))
+            {
+                return defaultString;
+            }
+            return str;
+        }
+
+        private static Boolean UsingResourceKeys()
+        {
+            return false;
+        }
+    }
+}
