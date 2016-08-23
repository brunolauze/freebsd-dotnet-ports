# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Localization
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http.Extensions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Extensions \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Localization.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization.Abstractions \
		Microsoft.Extensions.Globalization.CultureInfoCache>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Globalization.CultureInfoCache \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options

GH_PROJECT=	Localization

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Localization.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Globalization.CultureInfoCache.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll


OLD_LISTING+=		src/Microsoft.AspNetCore.Localization/Properties/AssemblyInfo.cs \
			src/Microsoft.AspNetCore.Localization/IRequestCultureFeature.cs \
			src/Microsoft.AspNetCore.Localization/QueryStringRequestCultureProvider.cs \
			src/Microsoft.AspNetCore.Localization/ApplicationBuilderExtensions.cs \
			src/Microsoft.AspNetCore.Localization/CookieRequestCultureProvider.cs \
			src/Microsoft.AspNetCore.Localization/CustomRequestCultureProvider.cs \
			src/Microsoft.AspNetCore.Localization/IRequestCultureProvider.cs \
			src/Microsoft.AspNetCore.Localization/ProviderCultureResult.cs \
			src/Microsoft.AspNetCore.Localization/RequestCultureProvider.cs \
			src/Microsoft.AspNetCore.Localization/RequestCultureFeature.cs \
			src/Microsoft.AspNetCore.Localization/RequestLocalizationMiddleware.cs \
			src/Microsoft.AspNetCore.Localization/AcceptLanguageHeaderRequestCultureProvider.cs \
			src/Microsoft.AspNetCore.Localization/RequestLocalizationOptions.cs \
			src/Microsoft.AspNetCore.Localization/RequestCulture.cs

.include <../../dotnet/aspnet/Makefile.common>


