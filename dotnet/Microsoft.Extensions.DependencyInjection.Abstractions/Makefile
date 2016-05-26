# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.DependencyInjection.Abstractions
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS} \
		Microsoft.Extensions.ActivatorUtilities.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ActivatorUtilities.Sources

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	DependencyInjection

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
	@cd ${WRKSRC}/src/Microsoft.Extensions.DependencyInjection.Abstractions && resgen /useSourcePath /compile Resources.resx,Microsoft.Extensions.DependencyInjection.Abstractions.Resources.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME} -name "*.cs"  | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:/usr/local/lib/dotnet/System.Private.CoreLib.dll \
			-reference:/usr/local/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:/usr/local/lib/dotnet/System.Linq.dll \
			-reference:/usr/local/lib/dotnet/System.Linq.Expressions.dll \
			-reference:/usr/local/lib/dotnet/System.Runtime.dll \
			-target:library \
			-warn:4 \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.ActivatorUtilities.Sources/ActivatorUtilities.cs \
			-resource:src/Microsoft.Extensions.DependencyInjection.Abstractions/Microsoft.Extensions.DependencyInjection.Abstractions.Resources.resources

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


