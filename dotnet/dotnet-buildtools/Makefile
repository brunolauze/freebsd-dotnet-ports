# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/dotnet-buildtools/Makefile 402349 2016-05-28 08:15:09Z bruno $

PORTNAME=	dotnet-buildtools
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet
COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Native>=1.0:${PORTSDIR}/dotnet/System.Native

LIB_DEPENDS+=   libicudata.so:${PORTSDIR}/devel/icu \
		libunwind.so:${PORTSDIR}/devel/libunwind

USE_GITHUB=	yes
GH_ACCOUNT=	brunolauze
GH_PROJECT=	freebsd-dotnet-binaries
GH_TAGNAME=	6c06cf2

configure:

do-configure:

build:
	@${MKDIR} ${STAGEDIR}
	@${MKDIR} ${STAGEDIR}/usr
	@${MKDIR} ${STAGEDIR}${PREFIX}
	@${MKDIR} ${STAGEDIR}${PREFIX}/bin
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib/${PORTNAME}
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata/pkgconfig

do-install:
	@${CP} -r ${LOCALBASE}/lib/dotnet/* ${STAGEDIR}${PREFIX}/lib/${PORTNAME}/
	@cd ${WRKSRC} && ${COPYTREE_SHARE} . ${STAGEDIR}${PREFIX}/lib/${PORTNAME} "! -name *\.bak"
	@${INSTALL_DATA} ${PATCHDIR}/System.Private.CoreLib.dll ${STAGEDIR}${PREFIX}/lib/${PORTNAME}/System.Private.CoreLib.dll
	@${INSTALL_DATA} ${PATCHDIR}/mscorlib.dll ${STAGEDIR}${PREFIX}/lib/${PORTNAME}/mscorlib.dll
	@${INSTALL_SCRIPT} ${PATCHDIR}/roslyn ${STAGEDIR}${PREFIX}/bin/roslyn
	@${INSTALL_SCRIPT} ${PATCHDIR}/dotnet-mkres ${STAGEDIR}${PREFIX}/bin/dotnet-mkres
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
