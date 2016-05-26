--- /dev/null	2016-04-29 20:33:21.000000000 -0400
+++ src/System.Linq.Expressions/src/SR.cs	2016-04-29 20:33:05.961694000 -0400
@@ -0,0 +1,1548 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Linq.Expressions
+{
+    internal static class SR
+    {
+
+    }
+}
+
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.Linq.Expressions.SR";
+
+	internal static string TypeMustNotBePointer
+	{
+		get
+		{
+			return GetResourceString("TypeMustNotBePointer", null);
+		}
+	}
+
+	internal static string PropertyTypeMustMatchSetter
+	{
+		get 
+		{
+			return GetResourceString("PropertyTypeMustMatchSetter", null);
+		}
+	}
+
+	internal static string HomogeneousAppDomainRequired
+	{
+	    get
+	    {
+		return SR.GetResourceString("HomogeneousAppDomainRequired", null);
+	    }
+	}
+
+	internal static String ArgumentMustBeFieldInfoOrPropertyInfoOrMethod
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeFieldInfoOrPropertyInfoOrMethod", null);
+            }
+        }
+
+	internal static String ArgumentMustBeFieldInfoOrPropertyInfo
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeFieldInfoOrPropertyInfo", null);
+            }
+        }
+		
+	internal static String NonStaticConstructorRequired
+        {
+            get
+            {
+                return SR.GetResourceString("NonStaticConstructorRequired", null);
+            }
+        }
+		
+	internal static String NonAbstractConstructorRequired
+        {
+            get
+            {
+                return SR.GetResourceString("NonAbstractConstructorRequired", null);
+            }
+        }
+		
+
+        internal static String AccessorsCannotHaveByRefArgs
+        {
+            get
+            {
+                return SR.GetResourceString("AccessorsCannotHaveByRefArgs", null);
+            }
+        }
+
+        internal static String AccessorsCannotHaveVarArgs
+        {
+            get
+            {
+                return SR.GetResourceString("AccessorsCannotHaveVarArgs", null);
+            }
+        }
+
+        internal static String AllCaseBodiesMustHaveSameType
+        {
+            get
+            {
+                return SR.GetResourceString("AllCaseBodiesMustHaveSameType", null);
+            }
+        }
+
+        internal static String AllTestValuesMustHaveSameType
+        {
+            get
+            {
+                return SR.GetResourceString("AllTestValuesMustHaveSameType", null);
+            }
+        }
+
+        internal static String AmbiguousJump
+        {
+            get
+            {
+                return SR.GetResourceString("AmbiguousJump", null);
+            }
+        }
+
+        internal static String ArgumentCannotBeOfTypeVoid
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentCannotBeOfTypeVoid", null);
+            }
+        }
+
+        internal static String ArgumentMemberNotDeclOnType
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMemberNotDeclOnType", null);
+            }
+        }
+
+        internal static String ArgumentMustBeArray
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeArray", null);
+            }
+        }
+
+        internal static String ArgumentMustBeArrayIndexType
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeArrayIndexType", null);
+            }
+        }
+
+        internal static String ArgumentMustBeBoolean
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeBoolean", null);
+            }
+        }
+
+        internal static String ArgumentMustBeFieldInfoOrPropertInfo
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeFieldInfoOrPropertInfo", null);
+            }
+        }
+
+        internal static String ArgumentMustBeFieldInfoOrPropertInfoOrMethod
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeFieldInfoOrPropertInfoOrMethod", null);
+            }
+        }
+
+        internal static String ArgumentMustBeInstanceMember
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeInstanceMember", null);
+            }
+        }
+
+        internal static String ArgumentMustBeInteger
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeInteger", null);
+            }
+        }
+
+        internal static String ArgumentMustBeSingleDimensionalArrayType
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustBeSingleDimensionalArrayType", null);
+            }
+        }
+
+        internal static String ArgumentMustNotHaveValueType
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentMustNotHaveValueType", null);
+            }
+        }
+
+        internal static String ArgumentTypeDoesNotMatchMember
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentTypeDoesNotMatchMember", null);
+            }
+        }
+
+        internal static String ArgumentTypesMustMatch
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentTypesMustMatch", null);
+            }
+        }
+
+        internal static String ArrayTypeMustBeArray
+        {
+            get
+            {
+                return SR.GetResourceString("ArrayTypeMustBeArray", null);
+            }
+        }
+
+        internal static String BinaryOperatorNotDefined
+        {
+            get
+            {
+                return SR.GetResourceString("BinaryOperatorNotDefined", null);
+            }
+        }
+
+        internal static String BodyOfCatchMustHaveSameTypeAsBodyOfTry
+        {
+            get
+            {
+                return SR.GetResourceString("BodyOfCatchMustHaveSameTypeAsBodyOfTry", null);
+            }
+        }
+
+        internal static String BothAccessorsMustBeStatic
+        {
+            get
+            {
+                return SR.GetResourceString("BothAccessorsMustBeStatic", null);
+            }
+        }
+
+        internal static String BoundsCannotBeLessThanOne
+        {
+            get
+            {
+                return SR.GetResourceString("BoundsCannotBeLessThanOne", null);
+            }
+        }
+
+        internal static String CannotAutoInitializeValueTypeElementThroughProperty
+        {
+            get
+            {
+                return SR.GetResourceString("CannotAutoInitializeValueTypeElementThroughProperty", null);
+            }
+        }
+
+        internal static String CannotAutoInitializeValueTypeMemberThroughProperty
+        {
+            get
+            {
+                return SR.GetResourceString("CannotAutoInitializeValueTypeMemberThroughProperty", null);
+            }
+        }
+
+        internal static String CannotCloseOverByRef
+        {
+            get
+            {
+                return SR.GetResourceString("CannotCloseOverByRef", null);
+            }
+        }
+
+        internal static String CannotCompileConstant
+        {
+            get
+            {
+                return SR.GetResourceString("CannotCompileConstant", null);
+            }
+        }
+
+        internal static String CannotCompileDynamic
+        {
+            get
+            {
+                return SR.GetResourceString("CannotCompileDynamic", null);
+            }
+        }
+
+        internal static String CoalesceUsedOnNonNullType
+        {
+            get
+            {
+                return SR.GetResourceString("CoalesceUsedOnNonNullType", null);
+            }
+        }
+
+        internal static String CoercionOperatorNotDefined
+        {
+            get
+            {
+                return SR.GetResourceString("CoercionOperatorNotDefined", null);
+            }
+        }
+
+        internal static String CollectionModifiedWhileEnumerating
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionModifiedWhileEnumerating", null);
+            }
+        }
+
+        internal static String ControlCannotEnterExpression
+        {
+            get
+            {
+                return SR.GetResourceString("ControlCannotEnterExpression", null);
+            }
+        }
+
+        internal static String ControlCannotEnterTry
+        {
+            get
+            {
+                return SR.GetResourceString("ControlCannotEnterTry", null);
+            }
+        }
+
+        internal static String ControlCannotLeaveFilterTest
+        {
+            get
+            {
+                return SR.GetResourceString("ControlCannotLeaveFilterTest", null);
+            }
+        }
+
+        internal static String ControlCannotLeaveFinally
+        {
+            get
+            {
+                return SR.GetResourceString("ControlCannotLeaveFinally", null);
+            }
+        }
+
+        internal static String ConversionIsNotSupportedForArithmeticTypes
+        {
+            get
+            {
+                return SR.GetResourceString("ConversionIsNotSupportedForArithmeticTypes", null);
+            }
+        }
+
+        internal static String CountCannotBeNegative
+        {
+            get
+            {
+                return SR.GetResourceString("CountCannotBeNegative", null);
+            }
+        }
+
+        internal static String DefaultBodyMustBeSupplied
+        {
+            get
+            {
+                return SR.GetResourceString("DefaultBodyMustBeSupplied", null);
+            }
+        }
+
+        internal static String DuplicateVariable
+        {
+            get
+            {
+                return SR.GetResourceString("DuplicateVariable", null);
+            }
+        }
+
+        internal static String ElementInitializerMethodNoRefOutParam
+        {
+            get
+            {
+                return SR.GetResourceString("ElementInitializerMethodNoRefOutParam", null);
+            }
+        }
+
+        internal static String ElementInitializerMethodNotAdd
+        {
+            get
+            {
+                return SR.GetResourceString("ElementInitializerMethodNotAdd", null);
+            }
+        }
+
+        internal static String ElementInitializerMethodStatic
+        {
+            get
+            {
+                return SR.GetResourceString("ElementInitializerMethodStatic", null);
+            }
+        }
+
+        internal static String ElementInitializerMethodWithZeroArgs
+        {
+            get
+            {
+                return SR.GetResourceString("ElementInitializerMethodWithZeroArgs", null);
+            }
+        }
+
+        internal static String EnumerationIsDone
+        {
+            get
+            {
+                return SR.GetResourceString("EnumerationIsDone", null);
+            }
+        }
+
+        internal static String EqualityMustReturnBoolean
+        {
+            get
+            {
+                return SR.GetResourceString("EqualityMustReturnBoolean", null);
+            }
+        }
+
+        internal static String ExpressionMustBeReadable
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionMustBeReadable", null);
+            }
+        }
+
+        internal static String ExpressionMustBeWriteable
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionMustBeWriteable", null);
+            }
+        }
+
+        internal static String ExpressionNotSupportedForNullableType
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionNotSupportedForNullableType", null);
+            }
+        }
+
+        internal static String ExpressionNotSupportedForType
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionNotSupportedForType", null);
+            }
+        }
+
+        internal static String ExpressionTypeCannotInitializeArrayType
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeCannotInitializeArrayType", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchAssignment
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchAssignment", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchConstructorParameter
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchConstructorParameter", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchLabel
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchLabel", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchMethodParameter
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchMethodParameter", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchParameter
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchParameter", null);
+            }
+        }
+
+        internal static String ExpressionTypeDoesNotMatchReturn
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeDoesNotMatchReturn", null);
+            }
+        }
+
+        internal static String ExpressionTypeNotInvocable
+        {
+            get
+            {
+                return SR.GetResourceString("ExpressionTypeNotInvocable", null);
+            }
+        }
+
+        internal static String ExtensionNodeMustOverrideProperty
+        {
+            get
+            {
+                return SR.GetResourceString("ExtensionNodeMustOverrideProperty", null);
+            }
+        }
+
+        internal static String ExtensionNotReduced
+        {
+            get
+            {
+                return SR.GetResourceString("ExtensionNotReduced", null);
+            }
+        }
+
+        internal static String FaultBlockNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("FaultBlockNotSupported", null);
+            }
+        }
+
+        internal static String FaultCannotHaveCatchOrFinally
+        {
+            get
+            {
+                return SR.GetResourceString("FaultCannotHaveCatchOrFinally", null);
+            }
+        }
+
+        internal static String FieldInfoNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("FieldInfoNotDefinedForType", null);
+            }
+        }
+
+        internal static String FieldNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("FieldNotDefinedForType", null);
+            }
+        }
+
+        internal static String FilterBlockNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("FilterBlockNotSupported", null);
+            }
+        }
+
+        internal static String GenericMethodWithArgsDoesNotExistOnType
+        {
+            get
+            {
+                return SR.GetResourceString("GenericMethodWithArgsDoesNotExistOnType", null);
+            }
+        }
+
+        internal static String HomogenousAppDomainRequired
+        {
+            get
+            {
+                return SR.GetResourceString("HomogenousAppDomainRequired", null);
+            }
+        }
+
+        internal static String IllegalNewGenericParams
+        {
+            get
+            {
+                return SR.GetResourceString("IllegalNewGenericParams", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfArgumentsForMembers
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfArgumentsForMembers", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfConstructorArguments
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfConstructorArguments", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfIndexes
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfIndexes", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfLambdaArguments
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfLambdaArguments", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfLambdaDeclarationParameters
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfLambdaDeclarationParameters", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfMembersForGivenConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfMembersForGivenConstructor", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfMethodCallArguments
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfMethodCallArguments", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfTypeArgsForAction
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfTypeArgsForAction", null);
+            }
+        }
+
+        internal static String IncorrectNumberOfTypeArgsForFunc
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectNumberOfTypeArgsForFunc", null);
+            }
+        }
+
+        internal static String IncorrectTypeForTypeAs
+        {
+            get
+            {
+                return SR.GetResourceString("IncorrectTypeForTypeAs", null);
+            }
+        }
+
+        internal static String IndexesOfSetGetMustMatch
+        {
+            get
+            {
+                return SR.GetResourceString("IndexesOfSetGetMustMatch", null);
+            }
+        }
+
+        internal static String InstanceAndMethodTypeMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("InstanceAndMethodTypeMismatch", null);
+            }
+        }
+
+        internal static String InstanceFieldNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("InstanceFieldNotDefinedForType", null);
+            }
+        }
+
+        internal static String InstancePropertyNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("InstancePropertyNotDefinedForType", null);
+            }
+        }
+
+        internal static String InstancePropertyWithoutParameterNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("InstancePropertyWithoutParameterNotDefinedForType", null);
+            }
+        }
+
+        internal static String InstancePropertyWithSpecifiedParametersNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("InstancePropertyWithSpecifiedParametersNotDefinedForType", null);
+            }
+        }
+
+        internal static String InvalidArgumentValue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidArgumentValue", null);
+            }
+        }
+
+        internal static String InvalidAsmNameOrExtension
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidAsmNameOrExtension", null);
+            }
+        }
+
+        internal static String InvalidCast
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidCast", null);
+            }
+        }
+
+        internal static String InvalidLvalue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidLvalue", null);
+            }
+        }
+
+        internal static String InvalidMemberType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidMemberType", null);
+            }
+        }
+
+        internal static String InvalidNullValue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidNullValue", null);
+            }
+        }
+
+        internal static String InvalidObjectType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidObjectType", null);
+            }
+        }
+
+        internal static String InvalidOperation
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation", null);
+            }
+        }
+
+        internal static String InvalidOutputDir
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOutputDir", null);
+            }
+        }
+
+        internal static String InvalidUnboxType
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidUnboxType", null);
+            }
+        }
+
+        internal static String LabelMustBeVoidOrHaveExpression
+        {
+            get
+            {
+                return SR.GetResourceString("LabelMustBeVoidOrHaveExpression", null);
+            }
+        }
+
+        internal static String LabelTargetAlreadyDefined
+        {
+            get
+            {
+                return SR.GetResourceString("LabelTargetAlreadyDefined", null);
+            }
+        }
+
+        internal static String LabelTargetUndefined
+        {
+            get
+            {
+                return SR.GetResourceString("LabelTargetUndefined", null);
+            }
+        }
+
+        internal static String LabelTypeMustBeVoid
+        {
+            get
+            {
+                return SR.GetResourceString("LabelTypeMustBeVoid", null);
+            }
+        }
+
+        internal static String LambdaTypeMustBeDerivedFromSystemDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("LambdaTypeMustBeDerivedFromSystemDelegate", null);
+            }
+        }
+
+        internal static String ListInitializerWithZeroMembers
+        {
+            get
+            {
+                return SR.GetResourceString("ListInitializerWithZeroMembers", null);
+            }
+        }
+
+        internal static String LogicalOperatorMustHaveBooleanOperators
+        {
+            get
+            {
+                return SR.GetResourceString("LogicalOperatorMustHaveBooleanOperators", null);
+            }
+        }
+
+        internal static String MemberNotFieldOrProperty
+        {
+            get
+            {
+                return SR.GetResourceString("MemberNotFieldOrProperty", null);
+            }
+        }
+
+        internal static String MethodBuilderDoesNotHaveTypeBuilder
+        {
+            get
+            {
+                return SR.GetResourceString("MethodBuilderDoesNotHaveTypeBuilder", null);
+            }
+        }
+
+        internal static String MethodContainsGenericParameters
+        {
+            get
+            {
+                return SR.GetResourceString("MethodContainsGenericParameters", null);
+            }
+        }
+
+        internal static String MethodDoesNotExistOnType
+        {
+            get
+            {
+                return SR.GetResourceString("MethodDoesNotExistOnType", null);
+            }
+        }
+
+        internal static String MethodIsGeneric
+        {
+            get
+            {
+                return SR.GetResourceString("MethodIsGeneric", null);
+            }
+        }
+
+        internal static String MethodNotPropertyAccessor
+        {
+            get
+            {
+                return SR.GetResourceString("MethodNotPropertyAccessor", null);
+            }
+        }
+
+        internal static String MethodWithArgsDoesNotExistOnType
+        {
+            get
+            {
+                return SR.GetResourceString("MethodWithArgsDoesNotExistOnType", null);
+            }
+        }
+
+        internal static String MethodWithMoreThanOneMatch
+        {
+            get
+            {
+                return SR.GetResourceString("MethodWithMoreThanOneMatch", null);
+            }
+        }
+
+        internal static String MustBeReducible
+        {
+            get
+            {
+                return SR.GetResourceString("MustBeReducible", null);
+            }
+        }
+
+        internal static String MustReduceToDifferent
+        {
+            get
+            {
+                return SR.GetResourceString("MustReduceToDifferent", null);
+            }
+        }
+
+        internal static String MustRewriteChildToSameType
+        {
+            get
+            {
+                return SR.GetResourceString("MustRewriteChildToSameType", null);
+            }
+        }
+
+        internal static String MustRewriteToSameNode
+        {
+            get
+            {
+                return SR.GetResourceString("MustRewriteToSameNode", null);
+            }
+        }
+
+        internal static String MustRewriteWithoutMethod
+        {
+            get
+            {
+                return SR.GetResourceString("MustRewriteWithoutMethod", null);
+            }
+        }
+
+        internal static String NonEmptyCollectionRequired
+        {
+            get
+            {
+                return SR.GetResourceString("NonEmptyCollectionRequired", null);
+            }
+        }
+
+        internal static String NonLocalJumpWithValue
+        {
+            get
+            {
+                return SR.GetResourceString("NonLocalJumpWithValue", null);
+            }
+        }
+
+        internal static String NonReducibleExpressionExtensionsNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("NonReducibleExpressionExtensionsNotSupported", null);
+            }
+        }
+
+        internal static String NotAMemberOfType
+        {
+            get
+            {
+                return SR.GetResourceString("NotAMemberOfType", null);
+            }
+        }
+
+        internal static String OnlyStaticFieldsHaveNullInstance
+        {
+            get
+            {
+                return SR.GetResourceString("OnlyStaticFieldsHaveNullInstance", null);
+            }
+        }
+
+        internal static String OnlyStaticMethodsHaveNullInstance
+        {
+            get
+            {
+                return SR.GetResourceString("OnlyStaticMethodsHaveNullInstance", null);
+            }
+        }
+
+        internal static String OnlyStaticPropertiesHaveNullInstance
+        {
+            get
+            {
+                return SR.GetResourceString("OnlyStaticPropertiesHaveNullInstance", null);
+            }
+        }
+
+        internal static String OperandTypesDoNotMatchParameters
+        {
+            get
+            {
+                return SR.GetResourceString("OperandTypesDoNotMatchParameters", null);
+            }
+        }
+
+        internal static String OperatorNotImplementedForType
+        {
+            get
+            {
+                return SR.GetResourceString("OperatorNotImplementedForType", null);
+            }
+        }
+
+        internal static String OutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("OutOfRange", null);
+            }
+        }
+
+        internal static String OverloadOperatorTypeDoesNotMatchConversionType
+        {
+            get
+            {
+                return SR.GetResourceString("OverloadOperatorTypeDoesNotMatchConversionType", null);
+            }
+        }
+
+        internal static String ParameterExpressionNotValidAsDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("ParameterExpressionNotValidAsDelegate", null);
+            }
+        }
+
+        internal static String PdbGeneratorNeedsExpressionCompiler
+        {
+            get
+            {
+                return SR.GetResourceString("PdbGeneratorNeedsExpressionCompiler", null);
+            }
+        }
+
+        internal static String PropertyCannotHaveRefType
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyCannotHaveRefType", null);
+            }
+        }
+
+        internal static String PropertyDoesNotHaveAccessor
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyDoesNotHaveAccessor", null);
+            }
+        }
+
+        internal static String PropertyDoesNotHaveGetter
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyDoesNotHaveGetter", null);
+            }
+        }
+
+        internal static String PropertyDoesNotHaveSetter
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyDoesNotHaveSetter", null);
+            }
+        }
+
+        internal static String PropertyNotDefinedForType
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyNotDefinedForType", null);
+            }
+        }
+
+        internal static String PropertyTyepMustMatchSetter
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyTyepMustMatchSetter", null);
+            }
+        }
+
+        internal static String PropertyTypeCannotBeVoid
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyTypeCannotBeVoid", null);
+            }
+        }
+
+        internal static String PropertyWithMoreThanOneMatch
+        {
+            get
+            {
+                return SR.GetResourceString("PropertyWithMoreThanOneMatch", null);
+            }
+        }
+
+        internal static String QueueEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("QueueEmpty", null);
+            }
+        }
+
+        internal static String QuotedExpressionMustBeLambda
+        {
+            get
+            {
+                return SR.GetResourceString("QuotedExpressionMustBeLambda", null);
+            }
+        }
+
+        internal static String ReducedNotCompatible
+        {
+            get
+            {
+                return SR.GetResourceString("ReducedNotCompatible", null);
+            }
+        }
+
+        internal static String ReducibleMustOverrideReduce
+        {
+            get
+            {
+                return SR.GetResourceString("ReducibleMustOverrideReduce", null);
+            }
+        }
+
+        internal static String ReferenceEqualityNotDefined
+        {
+            get
+            {
+                return SR.GetResourceString("ReferenceEqualityNotDefined", null);
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
+                return typeof(FxResources.System.Linq.Expressions.SR);
+            }
+        }
+
+        internal static String RethrowRequiresCatch
+        {
+            get
+            {
+                return SR.GetResourceString("RethrowRequiresCatch", null);
+            }
+        }
+
+        internal static String SetterHasNoParams
+        {
+            get
+            {
+                return SR.GetResourceString("SetterHasNoParams", null);
+            }
+        }
+
+        internal static String SetterMustBeVoid
+        {
+            get
+            {
+                return SR.GetResourceString("SetterMustBeVoid", null);
+            }
+        }
+
+        internal static String StartEndMustBeOrdered
+        {
+            get
+            {
+                return SR.GetResourceString("StartEndMustBeOrdered", null);
+            }
+        }
+
+        internal static String SwitchValueTypeDoesNotMatchComparisonMethodParameter
+        {
+            get
+            {
+                return SR.GetResourceString("SwitchValueTypeDoesNotMatchComparisonMethodParameter", null);
+            }
+        }
+
+        internal static String TestValueTypeDoesNotMatchComparisonMethodParameter
+        {
+            get
+            {
+                return SR.GetResourceString("TestValueTypeDoesNotMatchComparisonMethodParameter", null);
+            }
+        }
+
+        internal static String TryMustHaveCatchFinallyOrFault
+        {
+            get
+            {
+                return SR.GetResourceString("TryMustHaveCatchFinallyOrFault", null);
+            }
+        }
+
+        internal static String TryNotAllowedInFilter
+        {
+            get
+            {
+                return SR.GetResourceString("TryNotAllowedInFilter", null);
+            }
+        }
+
+        internal static String TryNotSupportedForMethodsWithRefArgs
+        {
+            get
+            {
+                return SR.GetResourceString("TryNotSupportedForMethodsWithRefArgs", null);
+            }
+        }
+
+        internal static String TryNotSupportedForValueTypeInstances
+        {
+            get
+            {
+                return SR.GetResourceString("TryNotSupportedForValueTypeInstances", null);
+            }
+        }
+
+        internal static String TypeContainsGenericParameters
+        {
+            get
+            {
+                return SR.GetResourceString("TypeContainsGenericParameters", null);
+            }
+        }
+
+        internal static String TypeDoesNotHaveConstructorForTheSignature
+        {
+            get
+            {
+                return SR.GetResourceString("TypeDoesNotHaveConstructorForTheSignature", null);
+            }
+        }
+
+        internal static String TypeIsGeneric
+        {
+            get
+            {
+                return SR.GetResourceString("TypeIsGeneric", null);
+            }
+        }
+
+        internal static String TypeMissingDefaultConstructor
+        {
+            get
+            {
+                return SR.GetResourceString("TypeMissingDefaultConstructor", null);
+            }
+        }
+
+        internal static String TypeMustNotBeByRef
+        {
+            get
+            {
+                return SR.GetResourceString("TypeMustNotBeByRef", null);
+            }
+        }
+
+        internal static String TypeNotIEnumerable
+        {
+            get
+            {
+                return SR.GetResourceString("TypeNotIEnumerable", null);
+            }
+        }
+
+        internal static String UnaryOperatorNotDefined
+        {
+            get
+            {
+                return SR.GetResourceString("UnaryOperatorNotDefined", null);
+            }
+        }
+
+        internal static String UndefinedVariable
+        {
+            get
+            {
+                return SR.GetResourceString("UndefinedVariable", null);
+            }
+        }
+
+        internal static String UnexpectedCoalesceOperator
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedCoalesceOperator", null);
+            }
+        }
+
+        internal static String UnexpectedVarArgsCall
+        {
+            get
+            {
+                return SR.GetResourceString("UnexpectedVarArgsCall", null);
+            }
+        }
+
+        internal static String UnhandledBinary
+        {
+            get
+            {
+                return SR.GetResourceString("UnhandledBinary", null);
+            }
+        }
+
+        internal static String UnhandledBinding
+        {
+            get
+            {
+                return SR.GetResourceString("UnhandledBinding", null);
+            }
+        }
+
+        internal static String UnhandledBindingType
+        {
+            get
+            {
+                return SR.GetResourceString("UnhandledBindingType", null);
+            }
+        }
+
+        internal static String UnhandledConvert
+        {
+            get
+            {
+                return SR.GetResourceString("UnhandledConvert", null);
+            }
+        }
+
+        internal static String UnhandledExpressionType
+        {
+            get
+            {
+                return SR.GetResourceString("UnhandledExpressionType", null);
+            }
+        }
+
+        internal static String UnhandledUnary
+        {
+            get
+            {
+                return SR.GetResourceString("UnhandledUnary", null);
+            }
+        }
+
+        internal static String UnknownBindingType
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownBindingType", null);
+            }
+        }
+
+        internal static String UnknownLiftType
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownLiftType", null);
+            }
+        }
+
+        internal static String UnsupportedExpressionType
+        {
+            get
+            {
+                return SR.GetResourceString("UnsupportedExpressionType", null);
+            }
+        }
+
+        internal static String UserDefinedOperatorMustBeStatic
+        {
+            get
+            {
+                return SR.GetResourceString("UserDefinedOperatorMustBeStatic", null);
+            }
+        }
+
+        internal static String UserDefinedOperatorMustNotBeVoid
+        {
+            get
+            {
+                return SR.GetResourceString("UserDefinedOperatorMustNotBeVoid", null);
+            }
+        }
+
+        internal static String UserDefinedOpMustHaveConsistentTypes
+        {
+            get
+            {
+                return SR.GetResourceString("UserDefinedOpMustHaveConsistentTypes", null);
+            }
+        }
+
+        internal static String UserDefinedOpMustHaveValidReturnType
+        {
+            get
+            {
+                return SR.GetResourceString("UserDefinedOpMustHaveValidReturnType", null);
+            }
+        }
+
+        internal static String VariableMustNotBeByRef
+        {
+            get
+            {
+                return SR.GetResourceString("VariableMustNotBeByRef", null);
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
+            if (str == null)
+            {
+                throw new MissingManifestResourceException(String.Concat("Unable to find resource for the key ", resourceKey, "."));
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
