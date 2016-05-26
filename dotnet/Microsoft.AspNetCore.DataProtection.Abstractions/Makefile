# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.DataProtection.Abstractions
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	DataProtection

USES=           dotnet

configure:

do-configure:

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME} -name "*.cs" | ${XARGS} ${REINPLACE_CMD} -e 's|CryptoUtil|CryptoUtilHelper|g'

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
	@cd ${WRKSRC}/src/${PORTNAME} && resgen /useSourcePath /compile Resources.resx,${PORTNAME}.Resources.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:/usr/local/lib/dotnet/System.Private.CoreLib.dll \
			-reference:/usr/local/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:/usr/local/lib/dotnet/System.Runtime.dll \
			-reference:/usr/local/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources \
			-target:library \
			-warn:4 \
			src/Microsoft.AspNetCore.DataProtection.Sources/EncodingUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Sources/ExceptionExtensions.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/IDataProtector.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/DataProtectionExtensions.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/Properties/Resources.Designer.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/Properties/AssemblyInfo.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/CryptoUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/Error.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/WebEncoders.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/IDataProtectionProvider.cs \
			src/Microsoft.AspNetCore.DataProtection.Abstractions/Infrastructure/IApplicationDiscriminator.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
