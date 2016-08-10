# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Linq.Expressions
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \

DOTNET_DEFINES+=	-define:FEATURE_COMPILE \
			-define:FEATURE_INTERPRET \
			-define:FEATURE_DLG_INVOKE \
			-define:FEATURE_FAST_CREATE 

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Dynamic/Utils/CacheDict.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs \
			${WRKSRC}/src/Common/src/System/Diagnostics/CodeAnalysis/ExcludeFromCodeCoverageAttribute.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CollectionExtensions.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CollectionExtensions.Map.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ContractUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/EmptyReadOnlyCollection.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/Error.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ExpressionUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ExpressionVisitorUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ListArgumentProvider.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/Strings.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/TypeExtensions.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/TypeUtils.cs \
			${WRKSRC}/src/Common/src/System/Linq/Expressions/Compiler/DelegateHelpers.cs \
			${WRKSRC}/src/Common/src/System/Linq/Expressions/Compiler/DelegateHelpers.Generated.cs \
			${WRKSRC}/src/Common/src/System/NotImplemented.cs \
			${WRKSRC}/src/Common/src/System/Runtime/CompilerServices/ReadOnlyCollectionBuilder.cs \
			${WRKSRC}/src/Common/src/System/Runtime/CompilerServices/TrueReadOnlyCollection.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CollectionExtensions.AddFirst.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ContractUtils.RequiresArrayRange.cs \
			${WRKSRC}/src/Common/src/System/Linq/Expressions/Compiler/AssemblyGen.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/DelegateHelpers.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/ReferenceEqualityComparer.cs

.include <../../dotnet/coreclr/corefx.common>
