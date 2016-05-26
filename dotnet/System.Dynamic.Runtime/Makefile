# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Dynamic.Runtime
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx
GH_TAGNAME=	master

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
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,${PORTNAME}.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-resource:src/${PORTNAME}/src/Resources/${PORTNAME}.Strings.resources \
			-resource:src/${PORTNAME}/src/Resources/${PORTNAME}.rd.xml \
			-target:library \
			-define:FEATURE_DYNAMIC_DELEGATE \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs \
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

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>