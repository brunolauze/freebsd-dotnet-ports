# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.TagHelpers
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources \
		Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources \
		Microsoft.Extensions.PropertyActivator.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyActivator.Sources

NET_DEPENDS+=   Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.Extensions.FileProviders.Composite>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Composite \
		Microsoft.Extensions.FileSystemGlobbing>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileSystemGlobbing \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.AspNetCore.Hosting>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting \
		Microsoft.AspNetCore.Routing.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing.Abstractions \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http \
		Microsoft.AspNetCore.Razor.Runtime>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Razor.Runtime \
		Microsoft.AspNetCore.Mvc.Razor.Host>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Razor.Host \
		Microsoft.AspNetCore.Mvc.Razor>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Razor \
		Microsoft.AspNetCore.WebUtilities>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.WebUtilities \
		Microsoft.AspNetCore.Mvc.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Abstractions \
		Microsoft.AspNetCore.Diagnostics.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Diagnostics.Abstractions \
		Microsoft.AspNetCore.Antiforgery>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Antiforgery \
		Microsoft.Extensions.DependencyModel>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyModel \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.Caching.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Abstractions \
		Microsoft.Extensions.Caching.Memory>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Memory \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.AspNetCore.Mvc.Core>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Core \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		Microsoft.AspNetCore.Mvc.ViewFeatures>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.ViewFeatures \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis \
		Microsoft.CodeAnalysis.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web

GH_PROJECT=     Mvc

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Claims.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Physical.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Composite.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileSystemGlobbing.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Razor.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Razor.Host.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.WebUtilities.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.ViewFeatures.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Html.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Diagnostics.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Antiforgery.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Memory.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyActivator.Sources/PropertyActivator.cs

.include <../../dotnet/aspnet/Makefile.common>
