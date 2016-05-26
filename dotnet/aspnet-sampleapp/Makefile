# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/aspnet-sampleapp/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	aspnet-sampleapp
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	libuv>=1.8:${PORTSDIR}/devel/libuv \
		${NET_DEPENDS}

NET_DEPENDS+=	aspnet>=1.0:${PORTSDIR}/dotnet/aspnet

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	KestrelHttpServer

USES=           dotnet

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/bin
	@mkdir -p ${STAGEDIR}${PREFIX}/etc
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@cd ${WRKSRC} && ${FIND} samples/SampleApp -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.exe \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Console.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Features.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Server.Kestrel.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Server.Kestrel.Https.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileProviders.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileProviders.Physical.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Configuration.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Configuration.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Configuration.CommandLine.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Configuration.EnvironmentVariables.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Configuration.Json.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Logging.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Logging.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Logging.Console.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Logging.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyInjection.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.Server.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Net.Http.Headers.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.Encodings.Web.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.DiagnosticSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Numerics.Vectors.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-target:exe \
			-main:SampleApp.Startup \
			-warn:4
do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.exe ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.exe
	@${INSTALL_SCRIPT} ${PATCHDIR}/aspnet-sampleapp ${STAGEDIR}${PREFIX}/bin/aspnet-sampleapp
	@${INSTALL_DATA} ${WRKSRC}/samples/SampleApp/testCert.pfx ${STAGEDIR}${PREFIX}/etc/aspnet-sampleapp.pfx
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
