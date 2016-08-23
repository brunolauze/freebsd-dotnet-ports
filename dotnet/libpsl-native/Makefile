# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	libpsl-native
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+= bash:${PORTSDIR}/shells/bash \
		coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		krb5>=1.14:${PORTSDIR}/security/krb5

RUN_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		krb5>=1.14:${PORTSDIR}/security/krb5 \

USE_GITHUB=	yes
GH_ACCOUNT=	Powershell
GH_PROJECT=	PowerShell

DOTNET_NOT_DOTNET=yes

USES=           bison compiler:c11 cpe gettext gmake iconv libtool pathfix cmake
USE_LDCONFIG=	yes

CFLAGS+=	-Wno-thread-safety -Wno-thread-safety-analysis
CXXFLAGS+=	-Wno-thread-safety -Wno-thread-safety-analysis
CONFIGURE_ENV+=	CFLAGS="${CFLAGS}" CXXFLAGS="${CXXFLAGS}"

CMAKE_SOURCE_PATH=${WRKSRC}/src/${PORTNAME}


WITH_DEBUG=	yes
BUILD_TYPE=	Debug

do-install:
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib/dotnet
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@${FIND} ${WRKSRC} -name "*.so"
	@${INSTALL_LIB} ${WRKSRC}/src/${PORTNAME}.so ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.so
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/coreclr/Makefile.common>
