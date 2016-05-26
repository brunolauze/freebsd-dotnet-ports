# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.CopyOnWriteDictionary.Sources
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	Common

USES=           dotnet

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/include
	@mkdir -p ${STAGEDIR}${PREFIX}/include/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig

do-install:
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/CopyOnWriteDictionary.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/CopyOnWriteDictionary.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/CopyOnWriteDictionaryHolder.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/CopyOnWriteDictionaryHolder.cs
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


