# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Dynamic.Runtime
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources \
			${DOTNET_RES}:src/${PORTNAME}/src/Resources/${PORTNAME}.rd.xml \

DOTNET_DEFINES+=	-define:FEATURE_DYNAMIC_DELEGATE \

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CacheDict.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CollectionExtensions.AddFirst.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CollectionExtensions.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/EmptyReadOnlyCollection.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ContractUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ContractUtils.RequiresArrayRange.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ExpressionUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ExpressionVisitorUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/ListArgumentProvider.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/Error.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/Strings.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/TypeExtensions.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/TypeUtils.cs \
			${WRKSRC}/src/Common/src/System/Dynamic/Utils/CollectionExtensions.Map.cs \
			${WRKSRC}/src/Common/src/System/Linq/Expressions/Compiler/DelegateHelpers.cs \
			${WRKSRC}/src/Common/src/System/Linq/Expressions/Compiler/DelegateHelpers.Generated.cs \
			${WRKSRC}/src/Common/src/System/Runtime/CompilerServices/ReadOnlyCollectionBuilder.cs \
			${WRKSRC}/src/Common/src/System/Runtime/CompilerServices/TrueReadOnlyCollection.cs

.include <../../dotnet/coreclr/corefx.common>
