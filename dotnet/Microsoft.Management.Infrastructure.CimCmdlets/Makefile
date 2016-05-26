# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Management.Infrastructure.CimCmdlets
PORTVERSION=	3.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com
MASTER_SITES=	file:///usr/ports/dotnet/distfiles/

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Management.Extended>=4.0.0.0:${PORTSDIR}/dotnet/System.Management.Extended \
		Microsoft.Management.Infrastructure>=3.0.0.0:${PORTSDIR}/dotnet/Microsoft.Management.Infrastructure \
		System.Management.Automation>=3.0.0.0:${PORTSDIR}/dotnet/System.Management.Automation

USES=           

configure:

do-configure:

build:
	@cd ${WRKSRC} && xbuild ${PORTNAME}.csproj /p:Configuration=Release
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell/v1.0
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules/CimCmdlets
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules/CimCmdlets/en-US
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@${INSTALL_DATA} ${WRKSRC}/CimCmdlets.psd1 ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules/CimCmdlets/CimCmdlets.psd1
	@${INSTALL_DATA} ${WRKSRC}/CimCmdlets_fb6cc51d-c096-4b38-b78d-0fed6277096a_HelpInfo.xml ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules/CimCmdlets/CimCmdlets_fb6cc51d-c096-4b38-b78d-0fed6277096a_HelpInfo.xml
	@${INSTALL_DATA} ${WRKSRC}/en-US/about_CIMSession.help.txt ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules/CimCmdlets/en-US/about_CIMSession.help.txt
	@${INSTALL_DATA} ${WRKSRC}/en-US/Microsoft.Management.Infrastructure.CimCmdlets.dll-help.xml ${STAGEDIR}${PREFIX}/lib/powershell/v1.0/Modules/CimCmdlets/en-US/Microsoft.Management.Infrastructure.CimCmdlets.dll-help.xml
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


