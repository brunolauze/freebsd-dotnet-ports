# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Mvc.Cors/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.Localization
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+= Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources

NET_DEPENDS+=	Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.ObjectPool>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ObjectPool \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.DependencyInjection>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		Microsoft.AspNetCore.Routing.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing.Abstractions \
		Microsoft.AspNetCore.Routing>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.AspNetCore.Authorization>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Authorization \
		Microsoft.AspNetCore.Mvc.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Abstractions \
		Microsoft.AspNetCore.Mvc.Core>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Core \
		Microsoft.AspNetCore.Mvc.ViewFeatures>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.ViewFeatures \
		Microsoft.AspNetCore.Cors>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Cors \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.Localization.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization.Abstractions \
		Microsoft.Extensions.Localization>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization \
		Microsoft.AspNetCore.Localization>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Localization \
		Microsoft.AspNetCore.Mvc.Razor>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Razor \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web \
		System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource

GH_PROJECT=	Mvc

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.ObjectPool.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Html.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Authorization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.ViewFeatures.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Localization.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Localization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Localization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

DOTNET_FILES+=			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs

.include <../../dotnet/aspnet/Makefile.common>


