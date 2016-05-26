# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	WSManService
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com
MASTER_SITES=	file:///usr/ports/dotnet/distfiles/

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Diagnostics.Eventing>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Eventing \
		System.Management>=1.0:${PORTSDIR}/dotnet/System.Management \
		Microsoft.Management.Infrastructure>=1.0:${PORTSDIR}/dotnet/Microsoft.Management.Infrastructure \
		System.Management.Automation>=1.0:${PORTSDIR}/dotnet/System.Management.Automation \
		Microsoft.WSMan>=1.0:${PORTSDIR}/dotnet/Microsoft.WSMan \
		Microsoft.WSMan.Cim>=1.0:${PORTSDIR}/dotnet/Microsoft.WSMan.Cim \
		Microsoft.WSMan.PowerShell>=1.0:${PORTSDIR}/dotnet/Microsoft.WSMan.PowerShell

USES=           dotnet

configure:

do-configure:

build:
	@cd ${WRKSRC} && xbuild ${PORTNAME}.csproj /p:Configuration=Release
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/bin
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell/v1.0
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig

do-install:
	@${INSTALL_SCRIPT} ${PATCHDIR}/wsmansvc ${STAGEDIR}${PREFIX}/bin
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.exe ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/${PORTNAME}.exe
	@${INSTALL_DATA} ${WRKSRC}/${PORTNAME}.exe.config ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/${PORTNAME}.exe.config
	@${INSTALL_DATA} ${WRKSRC}/powershell.pfx ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/powershell.pfx
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


