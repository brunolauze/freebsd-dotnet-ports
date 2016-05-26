# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Remotion.Linq
PORTVERSION=	2.1.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Linq.Queryable>=1.0:${PORTSDIR}/dotnet/System.Linq.Queryable \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

USE_GITHUB=	yes
GH_ACCOUNT=	re-motion
GH_PROJECT=	Relinq
GH_TAGNAME=     master

USES=           dotnet

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Specialized.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Queryable.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-target:library \
			-warn:4 \
			AssemblyInfoShared.cs \
			Core/QueryProviderBase.cs \
			Core/Properties/AssemblyInfo.cs \
			Core/IQueryExecutor.cs \
			Core/QueryModelBuilder.cs \
			Core/IQueryModelVisitor.cs \
			Core/Parsing/Structure/ExpressionTreeParser.cs \
			Core/Parsing/Structure/ExpressionTreeProcessors/NullExpressionTreeProcessor.cs \
			Core/Parsing/Structure/ExpressionTreeProcessors/TransformingExpressionTreeProcessor.cs \
			Core/Parsing/Structure/ExpressionTreeProcessors/CompoundExpressionTreeProcessor.cs \
			Core/Parsing/Structure/ExpressionTreeProcessors/PartialEvaluatingExpressionTreeProcessor.cs \
			Core/Parsing/Structure/INodeTypeProvider.cs \
			Core/Parsing/Structure/QueryParser.cs \
			Core/Parsing/Structure/NodeTypeProviders/CompoundNodeTypeProvider.cs \
			Core/Parsing/Structure/NodeTypeProviders/MethodInfoBasedNodeTypeRegistry.cs \
			Core/Parsing/Structure/NodeTypeProviders/MethodNameBasedNodeTypeRegistry.cs \
			Core/Parsing/Structure/NodeTypeProviders/NameBasedRegistrationInfo.cs \
			Core/Parsing/Structure/IQueryParser.cs \
			Core/Parsing/Structure/IExpressionTreeProcessor.cs \
			Core/Parsing/Structure/IntermediateModel/LastExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/MethodCallExpressionNodeBase.cs \
			Core/Parsing/Structure/IntermediateModel/MethodCallExpressionNodeFactory.cs \
			Core/Parsing/Structure/IntermediateModel/MaxExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/OfTypeExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ThenByExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/SingleExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/QuerySourceExpressionNodeUtility.cs \
			Core/Parsing/Structure/IntermediateModel/ContainsExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/AggregateExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/TakeExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/IntersectExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/WhereExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/SupportedMethodSpecifications.cs \
			Core/Parsing/Structure/IntermediateModel/ClauseGenerationContext.cs \
			Core/Parsing/Structure/IntermediateModel/ExpressionResolver.cs \
			Core/Parsing/Structure/IntermediateModel/GroupByExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/AggregateFromSeedExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/MinExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/LongCountExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ExceptExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/SelectExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ThenByDescendingExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/OrderByDescendingExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/SkipExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/FirstExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/MethodCallExpressionParseInfo.cs \
			Core/Parsing/Structure/IntermediateModel/IQuerySourceExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/QuerySourceSetOperationExpressionNodeBase.cs \
			Core/Parsing/Structure/IntermediateModel/MainSourceExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/AllExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/CastExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/SelectManyExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/OrderByExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ResultOperatorExpressionNodeBase.cs \
			Core/Parsing/Structure/IntermediateModel/AnyExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ExpressionNodeInstantiationException.cs \
			Core/Parsing/Structure/IntermediateModel/ConcatExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/DefaultIfEmptyExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/JoinExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/GroupJoinExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/UnionExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ReverseExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/SumExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/AverageExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/CountExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/ResolvedExpressionCache.cs \
			Core/Parsing/Structure/IntermediateModel/GroupByWithResultSelectorExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/DistinctExpressionNode.cs \
			Core/Parsing/Structure/IntermediateModel/IExpressionNode.cs \
			Core/Parsing/Structure/MethodCallExpressionParser.cs \
			Core/Parsing/ThrowingExpressionVisitor.cs \
			Core/Parsing/RelinqExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/TreeEvaluation/NullEvaluatableExpressionFilter.cs \
			Core/Parsing/ExpressionVisitors/TreeEvaluation/EvaluatableExpressionFilterBase.cs \
			Core/Parsing/ExpressionVisitors/TreeEvaluation/EvaluatableTreeFindingExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/TreeEvaluation/IEvaluatableExpressionFilter.cs \
			Core/Parsing/ExpressionVisitors/TreeEvaluation/PartialEvaluationInfo.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/InvocationOfLambdaExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/KeyValuePairNewExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/TupleNewExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/MethodCallExpressionTransformerAttribute.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/DictionaryEntryNewExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/AttributeEvaluatingExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/VBCompareStringExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/MemberAddingNewExpressionTransformerBase.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/VBInformationIsNothingExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/PredefinedTransformations/NullableValueTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/IExpressionTransformer.cs \
			Core/Parsing/ExpressionVisitors/Transformation/IExpressionTranformationProvider.cs \
			Core/Parsing/ExpressionVisitors/Transformation/ExpressionTransformation.cs \
			Core/Parsing/ExpressionVisitors/Transformation/ExpressionTransformerRegistry.cs \
			Core/Parsing/ExpressionVisitors/PartialEvaluatingExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/MultiReplacingExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/MemberBindings/MemberBinding.cs \
			Core/Parsing/ExpressionVisitors/MemberBindings/PropertyInfoBinding.cs \
			Core/Parsing/ExpressionVisitors/MemberBindings/FieldInfoBinding.cs \
			Core/Parsing/ExpressionVisitors/MemberBindings/MethodInfoBinding.cs \
			Core/Parsing/ExpressionVisitors/ReplacingExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/TransformingExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/SubQueryFindingExpressionVisitor.cs \
			Core/Parsing/ExpressionVisitors/TransparentIdentifierRemovingExpressionVisitor.cs \
			Core/Parsing/TupleExpressionBuilder.cs \
			Core/Parsing/ParserException.Obsolete.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/ContractAnnotationAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/CannotApplyEqualityOperatorAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/UsedImplicitlyAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/PublicAPIAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/ImplicitUseKindFlags.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/CanBeNullAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/PureAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/NoEnumerationAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/InvokerParameterNameAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/AssertionMethodAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/AssertionConditionType.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/AssertionConditionAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/PathReferenceAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/LinqTunnelAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/NotNullAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/MeansImplicitUseAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/InstantHandleAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/LocalizationRequiredAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/NotifyPropertyChangedInvocatorAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/ImplicitUseTargetFlags.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/BaseTypeRequiredAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/StringFormatMethodAttribute.cs \
			Core/App_Packages/Remotion.JetBrains.Annotations.Sources.1.15.23.0/TerminatesProgramAttribute.cs \
			Core/App_Packages/Remotion.Utilities.Assertion.Sources.1.15.23.0/Assertion.cs \
			Core/App_Packages/Remotion.Utilities.ArgumentUtility.Sources.1.15.23.0/ArgumentUtility.cs \
			Core/App_Packages/Remotion.Utilities.NullableTypeUtility.Sources.1.15.23.0/NullableTypeUtility.cs \
			Core/QueryModelVisitorBase.cs \
			Core/QueryableBase.cs \
			Core/Utilities/StringUtility.cs \
			Core/Utilities/ExpressionExtensions.cs \
			Core/Utilities/ReflectionUtility.cs \
			Core/Utilities/ItemTypeReflectionUtility.cs \
			Core/Utilities/ReflectionExtensions.cs \
			Core/DefaultQueryProvider.cs \
			Core/UniqueIdentifierGenerator.cs \
			Core/Clauses/WhereClause.cs \
			Core/Clauses/OrderByClause.cs \
			Core/Clauses/SelectClause.cs \
			Core/Clauses/QuerySourceMapping.cs \
			Core/Clauses/FromClauseBase.cs \
			Core/Clauses/IQuerySource.cs \
			Core/Clauses/StreamedData/StreamedValue.cs \
			Core/Clauses/StreamedData/IStreamedDataInfo.cs \
			Core/Clauses/StreamedData/StreamedSequence.cs \
			Core/Clauses/StreamedData/StreamedSingleValueInfo.cs \
			Core/Clauses/StreamedData/IStreamedData.cs \
			Core/Clauses/StreamedData/StreamedSequenceInfo.cs \
			Core/Clauses/StreamedData/StreamedValueInfo.cs \
			Core/Clauses/StreamedData/StreamedScalarValueInfo.cs \
			Core/Clauses/OrderingDirection.cs \
			Core/Clauses/Expressions/QuerySourceReferenceExpression.cs \
			Core/Clauses/Expressions/PartialEvaluationExceptionExpression.cs \
			Core/Clauses/Expressions/VBStringComparisonExpression.cs \
			Core/Clauses/Expressions/IVBSpecificExpressionVisitor.cs \
			Core/Clauses/Expressions/SubQueryExpression.cs \
			Core/Clauses/Expressions/IPartialEvaluationExceptionExpressionVisitor.cs \
			Core/Clauses/ExpressionVisitors/CloningExpressionVisitor.cs \
			Core/Clauses/ExpressionVisitors/AccessorFindingExpressionVisitor.cs \
			Core/Clauses/ExpressionVisitors/ReverseResolvingExpressionVisitor.cs \
			Core/Clauses/ExpressionVisitors/ReferenceReplacingExpressionVisitor.cs \
			Core/Clauses/AdditionalFromClause.cs \
			Core/Clauses/GroupJoinClause.cs \
			Core/Clauses/Ordering.cs \
			Core/Clauses/IFromClause.cs \
			Core/Clauses/MainFromClause.cs \
			Core/Clauses/CloneContext.cs \
			Core/Clauses/ResultOperators/ContainsResultOperator.cs \
			Core/Clauses/ResultOperators/SequenceTypePreservingResultOperatorBase.cs \
			Core/Clauses/ResultOperators/MaxResultOperator.cs \
			Core/Clauses/ResultOperators/ExceptResultOperator.cs \
			Core/Clauses/ResultOperators/CastResultOperator.cs \
			Core/Clauses/ResultOperators/LongCountResultOperator.cs \
			Core/Clauses/ResultOperators/MinResultOperator.cs \
			Core/Clauses/ResultOperators/IntersectResultOperator.cs \
			Core/Clauses/ResultOperators/OfTypeResultOperator.cs \
			Core/Clauses/ResultOperators/AggregateResultOperator.cs \
			Core/Clauses/ResultOperators/SkipResultOperator.cs \
			Core/Clauses/ResultOperators/SingleResultOperator.cs \
			Core/Clauses/ResultOperators/AllResultOperator.cs \
			Core/Clauses/ResultOperators/ConcatResultOperator.cs \
			Core/Clauses/ResultOperators/GroupResultOperator.cs \
			Core/Clauses/ResultOperators/ValueFromSequenceResultOperatorBase.cs \
			Core/Clauses/ResultOperators/AnyResultOperator.cs \
			Core/Clauses/ResultOperators/UnionResultOperator.cs \
			Core/Clauses/ResultOperators/CountResultOperator.cs \
			Core/Clauses/ResultOperators/TakeResultOperator.cs \
			Core/Clauses/ResultOperators/SumResultOperator.cs \
			Core/Clauses/ResultOperators/ChoiceResultOperatorBase.cs \
			Core/Clauses/ResultOperators/DistinctResultOperator.cs \
			Core/Clauses/ResultOperators/FirstResultOperator.cs \
			Core/Clauses/ResultOperators/DefaultIfEmptyResultOperator.cs \
			Core/Clauses/ResultOperators/AverageResultOperator.cs \
			Core/Clauses/ResultOperators/LastResultOperator.cs \
			Core/Clauses/ResultOperators/SequenceFromSequenceResultOperatorBase.cs \
			Core/Clauses/ResultOperators/ReverseResultOperator.cs \
			Core/Clauses/ResultOperators/AggregateFromSeedResultOperator.cs \
			Core/Clauses/JoinClause.cs \
			Core/Clauses/IBodyClause.cs \
			Core/Clauses/ResultOperatorBase.cs \
			Core/Clauses/IClause.cs \
			Core/Transformations/SubQueryFromClauseFlattener.cs \
			Core/Collections/IndexValuePair.cs \
			Core/Collections/ChangeResistantObservableCollectionEnumerator.cs \
			Core/Collections/MultiDictionaryExtensions.cs \
			Core/Collections/ObservableCollectionExtensions.cs \
			Core/QueryModel.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


