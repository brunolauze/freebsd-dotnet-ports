# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Native
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+= bash:${PORTSDIR}/shells/bash \
		coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		krb5>=1.14:${PORTSDIR}/security/krb5

RUN_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		krb5>=1.14:${PORTSDIR}/security/krb5 \

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx

USES=           bison compiler:c11 cpe gettext gmake iconv libtool pathfix cmake
USE_LDCONFIG=	yes

CFLAGS+=	-Wno-thread-safety -Wno-thread-safety-analysis
CXXFLAGS+=	-Wno-thread-safety -Wno-thread-safety-analysis
CONFIGURE_ENV+=	CFLAGS="${CFLAGS}" CXXFLAGS="${CXXFLAGS}"

WITH_DEBUG=	yes
BUILD_TYPE=	Debug

do-configure:
	@${ECHO_MSG} ${_CMAKE_MSG}
	@${MKDIR} ${CONFIGURE_WRKSRC}

build:
	@cd ${WRKSRC}; ${SETENV} ${CONFIGURE_ENV} ${MAKE_ARGS} ${CMAKE_ARGS} ./src/Native/build-native.sh x64 ${BUILD_TYPE} FreeBSD 8 clang3.8 verbose cmakeargs makeargs DESTDIR=${WRKSRC}

do-install:
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib/dotnet
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata
	@${MKDIR} ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@${INSTALL_LIB} ${STAGEDIR}${WRKSRC}/bin/FreeBSD.x64.${BUILD_TYPE}/Native/./System.Native.so ${STAGEDIR}${PREFIX}/lib/dotnet/System.Native.so
	@${INSTALL_LIB} ${STAGEDIR}${WRKSRC}/bin/FreeBSD.x64.${BUILD_TYPE}/Native/System.IO.Compression.Native.so ${STAGEDIR}${PREFIX}/lib/dotnet/System.IO.Compression.Native.so
	@${INSTALL_LIB} ${STAGEDIR}${WRKSRC}/bin/FreeBSD.x64.${BUILD_TYPE}/Native/System.Net.Security.Native.so ${STAGEDIR}${PREFIX}/lib/dotnet/System.Net.Security.Native.so
	@${INSTALL_LIB} ${STAGEDIR}${WRKSRC}/bin/FreeBSD.x64.${BUILD_TYPE}/Native/System.Net.Http.Native.so ${STAGEDIR}${PREFIX}/lib/dotnet/System.Net.Http.Native.so
	@${INSTALL_LIB} ${STAGEDIR}${WRKSRC}/bin/FreeBSD.x64.${BUILD_TYPE}/Native/./System.Security.Cryptography.Native.so ${STAGEDIR}${PREFIX}/lib/dotnet/System.Security.Cryptography.Native.so
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/coreclr/Makefile.common>
