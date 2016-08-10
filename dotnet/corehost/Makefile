# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	corehost
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= bash:${PORTSDIR}/shells/bash \
		coreclr>=1.0:${PORTSDIR}/dotnet/coreclr

RUN_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	core-setup

USES=           bison compiler:c11 cpe gettext gmake iconv libtool pathfix cmake
USE_LDCONFIG=	yes

WRKSRC=		${WRKDIR}/${GH_PROJECT}-${GH_TAGNAME}/src/corehost

CFLAGS+=	-Wno-thread-safety -Wno-thread-safety-analysis

#WITH_DEBUG=	yes

do-configure:
	@${ECHO_MSG} ${_CMAKE_MSG}
	@${MKDIR} ${CONFIGURE_WRKSRC}

build:
	@cd ${WRKSRC}; ${SETENV} ${CONFIGURE_ENV} ./build.sh --arch amd64 --rid freebsd --fxrver 1.0.1-dev-100001 --policyver 1.0.1-dev-100001 --hostver 1.0.1-dev-100001 --commithash ${GH_TAGNAME}

do-install:
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib/dotnet
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@${INSTALL_LIB} ${WRKSRC}/cli/dll/libhostpolicy.so  ${STAGEDIR}${PREFIX}/lib/dotnet/libhostpolicy.so
	@${INSTALL_LIB} ${WRKSRC}/cli/fxr/libhostfxr.so ${STAGEDIR}${PREFIX}/lib/dotnet/libhostfxr.so
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/coreclr/Makefile.common>
