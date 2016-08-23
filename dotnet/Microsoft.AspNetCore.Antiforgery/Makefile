# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Antiforgery
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Security.Claims>=1.0:${PORTSDIR}/dotnet/System.Security.Claims \
		Microsoft.AspNetCore.Diagnostics.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Diagnostics.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.AspNetCore.DataProtection>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.DataProtection \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http.Extensions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Extensions \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.WebUtilities>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.WebUtilities \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.Extensions.ObjectPool>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ObjectPool \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.WebEncoders>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.WebEncoders \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource

GH_PROJECT=	Antiforgery

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Claims.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Diagnostics.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Physical.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.WebUtilities.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Html.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.ObjectPool.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.WebEncoders.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll

.include <../../dotnet/aspnet/Makefile.common>
