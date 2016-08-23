# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/aspnet-sampleapp/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	aspnet-mvc-sampleapp
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources

NET_DEPENDS+=	aspnet>=1.0:${PORTSDIR}/dotnet/aspnet

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	Mvc

DOTNET_SOURCE_PATH=samples/MvcSandbox
DOTNET_TARGET=	exe

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Antiforgery.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.StaticFiles.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Server.Kestrel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Server.Kestrel.Https.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Physical.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Configuration.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Configuration.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Configuration.CommandLine.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Configuration.EnvironmentVariables.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Configuration.Json.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Server.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.ViewFeatures.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.DataAnnotations.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Formatters.Json.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Localization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Memory.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Cors.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.ApiExplorer.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Diagnostics.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Numerics.Vectors.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs

do-install:
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib
	@${MKDIR} ${STAGEDIR}${PREFIX}/lib/dotnet
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${DOTNET_OUTPUT}.exe ${STAGEDIR}${PREFIX}/lib/dotnet/${DOTNET_OUTPUT}.exe
	@${INSTALL_SCRIPT} ${PATCHDIR}/${PORTNAME} ${STAGEDIR}${PREFIX}/bin/${PORTNAME}
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/aspnet/Makefile.common>
