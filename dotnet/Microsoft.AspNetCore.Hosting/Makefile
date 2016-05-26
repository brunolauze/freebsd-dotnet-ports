# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Hosting/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Hosting
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS} \
		Microsoft.Extensions.TypeNameHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.TypeNameHelper.Sources

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.AspNetCore.Hosting.Server.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Server.Abstractions \
		Microsoft.AspNetCore.Http>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http \
		Microsoft.AspNetCore.Http.Extensions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Extensions \
		Microsoft.Extensions.Configuration.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Configuration.Abstractions \
		Microsoft.Extensions.Configuration>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Configuration \
		Microsoft.Extensions.Configuration.CommandLine>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Configuration.CommandLine \
		Microsoft.Extensions.Configuration.EnvironmentVariables>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Configuration.EnvironmentVariables \
		Microsoft.Extensions.Configuration.Json>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Configuration.Json \
		Microsoft.Extensions.DependencyInjection>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection \
		Microsoft.Extensions.Logging>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.ObjectPool>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ObjectPool \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Console>=1.0:${PORTSDIR}/dotnet/System.Console \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	Hosting

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
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Console.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Features.dll \
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
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.ObjectPool.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Options.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyInjection.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.Server.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Net.Http.Headers.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.Encodings.Web.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.DiagnosticSource.dll \
			-target:library \
			-warn:4 \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.TypeNameHelper.Sources/TypeNameHelper.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
