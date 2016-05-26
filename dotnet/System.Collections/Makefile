# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Collections
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

RUN_DEPENDS+=	${NET_DEPENDS}

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx
GH_TAGNAME=	master

USES=		dotnet

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
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,FxResources.${PORTNAME}.SR.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/${PORTNAME}/src/SR.cs \
			${WRKSRC}/src/${PORTNAME}/src/AssemblyInfo.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/BitHelper.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/ICollectionDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/IDictionaryDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/HashSet.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/LinkedList.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/Queue.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/QueueDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/SortedDictionary.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/SortedList.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/SortedSet.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/Stack.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/StackDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/StructuralComparisons.cs \
			${WRKSRC}/src/Common/src/System/Collections/HashHelpers.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
