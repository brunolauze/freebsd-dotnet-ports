# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.ViewFeatures
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.SecurityHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.SecurityHelper.Sources \
		Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources \
		Microsoft.Extensions.PropertyActivator.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyActivator.Sources \
		Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources \
		Microsoft.Extensions.ClosedGenericMatcher.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources \
		Microsoft.Extensions.CopyOnWriteDictionary.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources

NET_DEPENDS+=	Microsoft.AspNetCore.Diagnostics.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Diagnostics.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http.Extensions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Extensions \
		Microsoft.AspNetCore.WebUtilities>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.WebUtilities \
		Microsoft.AspNetCore.Routing.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing.Abstractions \
		Microsoft.AspNetCore.Routing>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing \
		Microsoft.AspNetCore.DataProtection>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.DataProtection \
		Microsoft.Extensions.Localization.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization.Abstractions \
		Microsoft.Extensions.Localization>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization \
		Microsoft.AspNetCore.Authorization>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Authorization \
		Microsoft.AspNetCore.Antiforgery>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Antiforgery \
		Microsoft.Extensions.WebEncoders>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.WebEncoders \
		Microsoft.AspNetCore.Mvc.DataAnnotations>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.DataAnnotations \
		Microsoft.AspNetCore.Mvc.Formatters.Json>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Formatters.Json \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource \
		System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers

GH_PROJECT=	Mvc

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.Annotations.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Dynamic.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Claims.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Authorization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Antiforgery.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Diagnostics.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Physical.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.WebUtilities.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Html.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.DataAnnotations.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Formatters.Json.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Localization.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Localization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.WebEncoders.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Buffers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Newtonsoft.Json.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.SecurityHelper.Sources/SecurityHelper.cs \
 			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs \
 			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyActivator.Sources/PropertyActivator.cs \
 			${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs \
 			${LOCALBASE}/include/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources/ClosedGenericMatcher.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources/CopyOnWriteDictionary.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources/CopyOnWriteDictionaryHolder.cs

.include <../../dotnet/aspnet/Makefile.common>
