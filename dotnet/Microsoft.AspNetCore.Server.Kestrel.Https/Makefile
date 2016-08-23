# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Kestrel.Https/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Server.Kestrel.Https
PORTVERSION=	1.0.0.0

RUN_DEPENDS+=	libuv>=1.8:${PORTSDIR}/devel/libuv

NET_DEPENDS+=	System.Net.Security>=1.0:${PORTSDIR}/dotnet/System.Net.Security \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.AspNetCore.Hosting.Server.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Server.Abstractions \
		Microsoft.AspNetCore.Hosting>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting \
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
		Microsoft.AspNetCore.Server.Kestrel>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Server.Kestrel \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Numerics.Vectors>=1.0:${PORTSDIR}/dotnet/System.Numerics.Vectors \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource

GH_PROJECT=	KestrelHttpServer

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Security.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.X509Certificates.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
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
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Server.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Server.Kestrel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Numerics.Vectors.dll \

.include <../../dotnet/aspnet/Makefile.common>
