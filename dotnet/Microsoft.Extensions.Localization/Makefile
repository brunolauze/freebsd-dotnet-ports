# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.Localization
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Resources.Reader>=1.0:${PORTSDIR}/dotnet/System.Resources.Reader \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Localization.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization.Abstractions \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	Localization

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
	@cd ${WRKSRC}/src/${PORTNAME} && resgen /useSourcePath /compile Resources.resx,${PORTNAME}.Resources.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Resources.Reader.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Localization.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Options.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources \
			-target:library \
			-warn:4 \
			src/Microsoft.Extensions.Localization/Internal/AssemblyWrapper.cs \
			src/Microsoft.Extensions.Localization/LocalizationServiceCollectionExtensions.cs \
			src/Microsoft.Extensions.Localization/ResourceManagerStringLocalizerFactory.cs \
			src/Microsoft.Extensions.Localization/LocalizationOptions.cs \
			src/Microsoft.Extensions.Localization/IResourceNamesCache.cs \
			src/Microsoft.Extensions.Localization/ResourceManagerWithCultureStringLocalizer.cs \
			src/Microsoft.Extensions.Localization/ResourceManagerStringLocalizer.cs \
			src/Microsoft.Extensions.Localization/Properties/AssemblyInfo.cs \
			src/Microsoft.Extensions.Localization/Properties/Resources.Designer.cs \
			src/Microsoft.Extensions.Localization/ResourceNamesCache.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


