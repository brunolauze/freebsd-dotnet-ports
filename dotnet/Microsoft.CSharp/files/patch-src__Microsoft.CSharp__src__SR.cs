--- /dev/null	2016-03-07 15:17:03.000000000 -0500
+++ src/Microsoft.CSharp/src/SR.cs	2016-03-07 15:17:17.944676000 -0500
@@ -0,0 +1,1118 @@
+using System;
+using System.Resources;
+
+namespace FxResources.Microsoft.CSharp
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
+        private const String s_resourcesName = "FxResources.Microsoft.CSharp.SR";
+
+        internal static String AbstractBaseCall
+        {
+            get
+            {
+                return SR.GetResourceString("AbstractBaseCall", null);
+            }
+        }
+
+        internal static String AmbigBinaryOps
+        {
+            get
+            {
+                return SR.GetResourceString("AmbigBinaryOps", null);
+            }
+        }
+
+        internal static String AmbigCall
+        {
+            get
+            {
+                return SR.GetResourceString("AmbigCall", null);
+            }
+        }
+
+        internal static String AmbigMember
+        {
+            get
+            {
+                return SR.GetResourceString("AmbigMember", null);
+            }
+        }
+
+        internal static String AmbigUDConv
+        {
+            get
+            {
+                return SR.GetResourceString("AmbigUDConv", null);
+            }
+        }
+
+        internal static String AmbigUnaryOp
+        {
+            get
+            {
+                return SR.GetResourceString("AmbigUnaryOp", null);
+            }
+        }
+
+        internal static String AssgLvalueExpected
+        {
+            get
+            {
+                return SR.GetResourceString("AssgLvalueExpected", null);
+            }
+        }
+
+        internal static String AssgReadonly
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonly", null);
+            }
+        }
+
+        internal static String AssgReadonly2
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonly2", null);
+            }
+        }
+
+        internal static String AssgReadonlyLocal
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonlyLocal", null);
+            }
+        }
+
+        internal static String AssgReadonlyLocalCause
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonlyLocalCause", null);
+            }
+        }
+
+        internal static String AssgReadonlyProp
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonlyProp", null);
+            }
+        }
+
+        internal static String AssgReadonlyStatic
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonlyStatic", null);
+            }
+        }
+
+        internal static String AssgReadonlyStatic2
+        {
+            get
+            {
+                return SR.GetResourceString("AssgReadonlyStatic2", null);
+            }
+        }
+
+        internal static String BadAccess
+        {
+            get
+            {
+                return SR.GetResourceString("BadAccess", null);
+            }
+        }
+
+        internal static String BadArgCount
+        {
+            get
+            {
+                return SR.GetResourceString("BadArgCount", null);
+            }
+        }
+
+        internal static String BadArgExtraRef
+        {
+            get
+            {
+                return SR.GetResourceString("BadArgExtraRef", null);
+            }
+        }
+
+        internal static String BadArgRef
+        {
+            get
+            {
+                return SR.GetResourceString("BadArgRef", null);
+            }
+        }
+
+        internal static String BadArgType
+        {
+            get
+            {
+                return SR.GetResourceString("BadArgType", null);
+            }
+        }
+
+        internal static String BadArgTypes
+        {
+            get
+            {
+                return SR.GetResourceString("BadArgTypes", null);
+            }
+        }
+
+        internal static String BadArgTypesForCollectionAdd
+        {
+            get
+            {
+                return SR.GetResourceString("BadArgTypesForCollectionAdd", null);
+            }
+        }
+
+        internal static String BadArity
+        {
+            get
+            {
+                return SR.GetResourceString("BadArity", null);
+            }
+        }
+
+        internal static String BadBinaryOps
+        {
+            get
+            {
+                return SR.GetResourceString("BadBinaryOps", null);
+            }
+        }
+
+        internal static String BadBoolOp
+        {
+            get
+            {
+                return SR.GetResourceString("BadBoolOp", null);
+            }
+        }
+
+        internal static String BadCastInFixed
+        {
+            get
+            {
+                return SR.GetResourceString("BadCastInFixed", null);
+            }
+        }
+
+        internal static String BadCtorArgCount
+        {
+            get
+            {
+                return SR.GetResourceString("BadCtorArgCount", null);
+            }
+        }
+
+        internal static String BadDelArgCount
+        {
+            get
+            {
+                return SR.GetResourceString("BadDelArgCount", null);
+            }
+        }
+
+        internal static String BadDelArgTypes
+        {
+            get
+            {
+                return SR.GetResourceString("BadDelArgTypes", null);
+            }
+        }
+
+        internal static String BadDelegateConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("BadDelegateConstructor", null);
+            }
+        }
+
+        internal static String BadExtensionArgTypes
+        {
+            get
+            {
+                return SR.GetResourceString("BadExtensionArgTypes", null);
+            }
+        }
+
+        internal static String BadIndexCount
+        {
+            get
+            {
+                return SR.GetResourceString("BadIndexCount", null);
+            }
+        }
+
+        internal static String BadIndexLHS
+        {
+            get
+            {
+                return SR.GetResourceString("BadIndexLHS", null);
+            }
+        }
+
+        internal static String BadInstanceArgType
+        {
+            get
+            {
+                return SR.GetResourceString("BadInstanceArgType", null);
+            }
+        }
+
+        internal static String BadNamedArgument
+        {
+            get
+            {
+                return SR.GetResourceString("BadNamedArgument", null);
+            }
+        }
+
+        internal static String BadNamedArgumentForDelegateInvoke
+        {
+            get
+            {
+                return SR.GetResourceString("BadNamedArgumentForDelegateInvoke", null);
+            }
+        }
+
+        internal static String BadProtectedAccess
+        {
+            get
+            {
+                return SR.GetResourceString("BadProtectedAccess", null);
+            }
+        }
+
+        internal static String BadRetType
+        {
+            get
+            {
+                return SR.GetResourceString("BadRetType", null);
+            }
+        }
+
+        internal static String BadTypeArgument
+        {
+            get
+            {
+                return SR.GetResourceString("BadTypeArgument", null);
+            }
+        }
+
+        internal static String BadUnaryOp
+        {
+            get
+            {
+                return SR.GetResourceString("BadUnaryOp", null);
+            }
+        }
+
+        internal static String BaseConstraintConflict
+        {
+            get
+            {
+                return SR.GetResourceString("BaseConstraintConflict", null);
+            }
+        }
+
+        internal static String BindBinaryAssignmentFailedNullReference
+        {
+            get
+            {
+                return SR.GetResourceString("BindBinaryAssignmentFailedNullReference", null);
+            }
+        }
+
+        internal static String BindBinaryAssignmentRequireTwoArguments
+        {
+            get
+            {
+                return SR.GetResourceString("BindBinaryAssignmentRequireTwoArguments", null);
+            }
+        }
+
+        internal static String BindBinaryOperatorRequireTwoArguments
+        {
+            get
+            {
+                return SR.GetResourceString("BindBinaryOperatorRequireTwoArguments", null);
+            }
+        }
+
+        internal static String BindCallFailedOverloadResolution
+        {
+            get
+            {
+                return SR.GetResourceString("BindCallFailedOverloadResolution", null);
+            }
+        }
+
+        internal static String BindCallToConditionalMethod
+        {
+            get
+            {
+                return SR.GetResourceString("BindCallToConditionalMethod", null);
+            }
+        }
+
+        internal static String BindExplicitConversionRequireOneArgument
+        {
+            get
+            {
+                return SR.GetResourceString("BindExplicitConversionRequireOneArgument", null);
+            }
+        }
+
+        internal static String BindImplicitConversionRequireOneArgument
+        {
+            get
+            {
+                return SR.GetResourceString("BindImplicitConversionRequireOneArgument", null);
+            }
+        }
+
+        internal static String BindInvokeFailedNonDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("BindInvokeFailedNonDelegate", null);
+            }
+        }
+
+        internal static String BindPropertyFailedEvent
+        {
+            get
+            {
+                return SR.GetResourceString("BindPropertyFailedEvent", null);
+            }
+        }
+
+        internal static String BindPropertyFailedMethodGroup
+        {
+            get
+            {
+                return SR.GetResourceString("BindPropertyFailedMethodGroup", null);
+            }
+        }
+
+        internal static String BindRequireArguments
+        {
+            get
+            {
+                return SR.GetResourceString("BindRequireArguments", null);
+            }
+        }
+
+        internal static String BindToBogus
+        {
+            get
+            {
+                return SR.GetResourceString("BindToBogus", null);
+            }
+        }
+
+        internal static String BindToBogusProp1
+        {
+            get
+            {
+                return SR.GetResourceString("BindToBogusProp1", null);
+            }
+        }
+
+        internal static String BindToBogusProp2
+        {
+            get
+            {
+                return SR.GetResourceString("BindToBogusProp2", null);
+            }
+        }
+
+        internal static String BindToVoidMethodButExpectResult
+        {
+            get
+            {
+                return SR.GetResourceString("BindToVoidMethodButExpectResult", null);
+            }
+        }
+
+        internal static String BindUnaryOperatorRequireOneArgument
+        {
+            get
+            {
+                return SR.GetResourceString("BindUnaryOperatorRequireOneArgument", null);
+            }
+        }
+
+        internal static String BogusType
+        {
+            get
+            {
+                return SR.GetResourceString("BogusType", null);
+            }
+        }
+
+        internal static String CallingBaseFinalizeDeprecated
+        {
+            get
+            {
+                return SR.GetResourceString("CallingBaseFinalizeDeprecated", null);
+            }
+        }
+
+        internal static String CallingFinalizeDepracated
+        {
+            get
+            {
+                return SR.GetResourceString("CallingFinalizeDepracated", null);
+            }
+        }
+
+        internal static String CantCallSpecialMethod
+        {
+            get
+            {
+                return SR.GetResourceString("CantCallSpecialMethod", null);
+            }
+        }
+
+        internal static String CantInferMethTypeArgs
+        {
+            get
+            {
+                return SR.GetResourceString("CantInferMethTypeArgs", null);
+            }
+        }
+
+        internal static String CheckedOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("CheckedOverflow", null);
+            }
+        }
+
+        internal static String CircularConstraint
+        {
+            get
+            {
+                return SR.GetResourceString("CircularConstraint", null);
+            }
+        }
+
+        internal static String ConstOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("ConstOutOfRange", null);
+            }
+        }
+
+        internal static String ConstOutOfRangeChecked
+        {
+            get
+            {
+                return SR.GetResourceString("ConstOutOfRangeChecked", null);
+            }
+        }
+
+        internal static String ConvertToStaticClass
+        {
+            get
+            {
+                return SR.GetResourceString("ConvertToStaticClass", null);
+            }
+        }
+
+        internal static String ConWithValCon
+        {
+            get
+            {
+                return SR.GetResourceString("ConWithValCon", null);
+            }
+        }
+
+        internal static String DelegateOnNullable
+        {
+            get
+            {
+                return SR.GetResourceString("DelegateOnNullable", null);
+            }
+        }
+
+        internal static String DuplicateNamedArgument
+        {
+            get
+            {
+                return SR.GetResourceString("DuplicateNamedArgument", null);
+            }
+        }
+
+        internal static String FieldInitRefNonstatic
+        {
+            get
+            {
+                return SR.GetResourceString("FieldInitRefNonstatic", null);
+            }
+        }
+
+        internal static String FixedNotNeeded
+        {
+            get
+            {
+                return SR.GetResourceString("FixedNotNeeded", null);
+            }
+        }
+
+        internal static String GenericArgIsStaticClass
+        {
+            get
+            {
+                return SR.GetResourceString("GenericArgIsStaticClass", null);
+            }
+        }
+
+        internal static String GenericConstraintNotSatisfiedNullableEnum
+        {
+            get
+            {
+                return SR.GetResourceString("GenericConstraintNotSatisfiedNullableEnum", null);
+            }
+        }
+
+        internal static String GenericConstraintNotSatisfiedNullableInterface
+        {
+            get
+            {
+                return SR.GetResourceString("GenericConstraintNotSatisfiedNullableInterface", null);
+            }
+        }
+
+        internal static String GenericConstraintNotSatisfiedRefType
+        {
+            get
+            {
+                return SR.GetResourceString("GenericConstraintNotSatisfiedRefType", null);
+            }
+        }
+
+        internal static String GenericConstraintNotSatisfiedTyVar
+        {
+            get
+            {
+                return SR.GetResourceString("GenericConstraintNotSatisfiedTyVar", null);
+            }
+        }
+
+        internal static String GenericConstraintNotSatisfiedValType
+        {
+            get
+            {
+                return SR.GetResourceString("GenericConstraintNotSatisfiedValType", null);
+            }
+        }
+
+        internal static String HasNoTypeVars
+        {
+            get
+            {
+                return SR.GetResourceString("HasNoTypeVars", null);
+            }
+        }
+
+        internal static String InaccessibleGetter
+        {
+            get
+            {
+                return SR.GetResourceString("InaccessibleGetter", null);
+            }
+        }
+
+        internal static String InaccessibleSetter
+        {
+            get
+            {
+                return SR.GetResourceString("InaccessibleSetter", null);
+            }
+        }
+
+        internal static String IncrementLvalueExpected
+        {
+            get
+            {
+                return SR.GetResourceString("IncrementLvalueExpected", null);
+            }
+        }
+
+        internal static String InitializerAddHasParamModifiers
+        {
+            get
+            {
+                return SR.GetResourceString("InitializerAddHasParamModifiers", null);
+            }
+        }
+
+        internal static String IntDivByZero
+        {
+            get
+            {
+                return SR.GetResourceString("IntDivByZero", null);
+            }
+        }
+
+        internal static String InternalCompilerError
+        {
+            get
+            {
+                return SR.GetResourceString("InternalCompilerError", null);
+            }
+        }
+
+        internal static String LiteralDoubleCast
+        {
+            get
+            {
+                return SR.GetResourceString("LiteralDoubleCast", null);
+            }
+        }
+
+        internal static String ManagedAddr
+        {
+            get
+            {
+                return SR.GetResourceString("ManagedAddr", null);
+            }
+        }
+
+        internal static String MethDelegateMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("MethDelegateMismatch", null);
+            }
+        }
+
+        internal static String MethGrpToNonDel
+        {
+            get
+            {
+                return SR.GetResourceString("MethGrpToNonDel", null);
+            }
+        }
+
+        internal static String MissingPredefinedMember
+        {
+            get
+            {
+                return SR.GetResourceString("MissingPredefinedMember", null);
+            }
+        }
+
+        internal static String MustHaveOpTF
+        {
+            get
+            {
+                return SR.GetResourceString("MustHaveOpTF", null);
+            }
+        }
+
+        internal static String NamedArgumentSpecificationBeforeFixedArgument
+        {
+            get
+            {
+                return SR.GetResourceString("NamedArgumentSpecificationBeforeFixedArgument", null);
+            }
+        }
+
+        internal static String NamedArgumentUsedInPositional
+        {
+            get
+            {
+                return SR.GetResourceString("NamedArgumentUsedInPositional", null);
+            }
+        }
+
+        internal static String NewConstraintNotSatisfied
+        {
+            get
+            {
+                return SR.GetResourceString("NewConstraintNotSatisfied", null);
+            }
+        }
+
+        internal static String NoConstructors
+        {
+            get
+            {
+                return SR.GetResourceString("NoConstructors", null);
+            }
+        }
+
+        internal static String NoExplicitConv
+        {
+            get
+            {
+                return SR.GetResourceString("NoExplicitConv", null);
+            }
+        }
+
+        internal static String NoImplicitConv
+        {
+            get
+            {
+                return SR.GetResourceString("NoImplicitConv", null);
+            }
+        }
+
+        internal static String NoImplicitConvCast
+        {
+            get
+            {
+                return SR.GetResourceString("NoImplicitConvCast", null);
+            }
+        }
+
+        internal static String NonInvocableMemberCalled
+        {
+            get
+            {
+                return SR.GetResourceString("NonInvocableMemberCalled", null);
+            }
+        }
+
+        internal static String NoSuchMember
+        {
+            get
+            {
+                return SR.GetResourceString("NoSuchMember", null);
+            }
+        }
+
+        internal static String NoSuchMemberOrExtension
+        {
+            get
+            {
+                return SR.GetResourceString("NoSuchMemberOrExtension", null);
+            }
+        }
+
+        internal static String NullReferenceOnMemberException
+        {
+            get
+            {
+                return SR.GetResourceString("NullReferenceOnMemberException", null);
+            }
+        }
+
+        internal static String ObjectProhibited
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectProhibited", null);
+            }
+        }
+
+        internal static String ObjectRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectRequired", null);
+            }
+        }
+
+        internal static String PartialMethodToDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("PartialMethodToDelegate", null);
+            }
+        }
+
+        internal static String PredefinedTypeBadType
+        {
+            get
+            {
+                return SR.GetResourceString("PredefinedTypeBadType", null);
+            }
+        }
+
+        internal static String PredefinedTypeNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("PredefinedTypeNotFound", null);
+            }
+        }
+
+        internal static String PropertyLacksGet
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyLacksGet", null);
+            }
+        }
+
+        internal static String RefConstraintNotSatisfied
+        {
+            get
+            {
+                return SR.GetResourceString("RefConstraintNotSatisfied", null);
+            }
+        }
+
+        internal static String RefLvalueExpected
+        {
+            get
+            {
+                return SR.GetResourceString("RefLvalueExpected", null);
+            }
+        }
+
+        internal static String RefProperty
+        {
+            get
+            {
+                return SR.GetResourceString("RefProperty", null);
+            }
+        }
+
+        internal static String RefReadonly
+        {
+            get
+            {
+                return SR.GetResourceString("RefReadonly", null);
+            }
+        }
+
+        internal static String RefReadonly2
+        {
+            get
+            {
+                return SR.GetResourceString("RefReadonly2", null);
+            }
+        }
+
+        internal static String RefReadonlyLocal
+        {
+            get
+            {
+                return SR.GetResourceString("RefReadonlyLocal", null);
+            }
+        }
+
+        internal static String RefReadonlyLocalCause
+        {
+            get
+            {
+                return SR.GetResourceString("RefReadonlyLocalCause", null);
+            }
+        }
+
+        internal static String RefReadonlyStatic
+        {
+            get
+            {
+                return SR.GetResourceString("RefReadonlyStatic", null);
+            }
+        }
+
+        internal static String RefReadonlyStatic2
+        {
+            get
+            {
+                return SR.GetResourceString("RefReadonlyStatic2", null);
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
+                return typeof(FxResources.Microsoft.CSharp.SR);
+            }
+        }
+
+        internal static String ReturnNotLValue
+        {
+            get
+            {
+                return SR.GetResourceString("ReturnNotLValue", null);
+            }
+        }
+
+        internal static String SizeofUnsafe
+        {
+            get
+            {
+                return SR.GetResourceString("SizeofUnsafe", null);
+            }
+        }
+
+        internal static String ThisStructNotInAnonMeth
+        {
+            get
+            {
+                return SR.GetResourceString("ThisStructNotInAnonMeth", null);
+            }
+        }
+
+        internal static String TypeArgsNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("TypeArgsNotAllowed", null);
+            }
+        }
+
+        internal static String TypeVarCantBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("TypeVarCantBeNull", null);
+            }
+        }
+
+        internal static String UnifyingInterfaceInstantiations
+        {
+            get
+            {
+                return SR.GetResourceString("UnifyingInterfaceInstantiations", null);
+            }
+        }
+
+        internal static String UnsafeNeeded
+        {
+            get
+            {
+                return SR.GetResourceString("UnsafeNeeded", null);
+            }
+        }
+
+        internal static String ValConstraintNotSatisfied
+        {
+            get
+            {
+                return SR.GetResourceString("ValConstraintNotSatisfied", null);
+            }
+        }
+
+        internal static String ValueCantBeNull
+        {
+            get
+            {
+                return SR.GetResourceString("ValueCantBeNull", null);
+            }
+        }
+
+        internal static String ValueTypeExtDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("ValueTypeExtDelegate", null);
+            }
+        }
+
+        internal static String WrongNestedThis
+        {
+            get
+            {
+                return SR.GetResourceString("WrongNestedThis", null);
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
