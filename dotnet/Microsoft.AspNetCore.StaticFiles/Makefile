# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Http.Features/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.StaticFiles
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http.Extensions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Extensions \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.Extensions.Configuration.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Configuration.Abstractions \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.WebEncoders>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.WebEncoders \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web \
		System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers

GH_PROJECT=	StaticFiles

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Configuration.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.WebEncoders.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Buffers.dll

DOTNET_RESOURCES+	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

.include <../../dotnet/aspnet/Makefile.common>


