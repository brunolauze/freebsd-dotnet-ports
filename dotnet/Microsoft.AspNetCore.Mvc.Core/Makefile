# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Mvc.Abstractions/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.Core
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.SecurityHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.SecurityHelper.Sources \
		Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources \
		Microsoft.Extensions.PropertyActivator.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyActivator.Sources \
		Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources \
		Microsoft.Extensions.ClosedGenericMatcher.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources \
		Microsoft.Extensions.CopyOnWriteDictionary.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources \
		Microsoft.AspNetCore.Routing.DecisionTree.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.ComponentModel.TypeConverter>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.TypeConverter \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Security.Claims>=1.0:${PORTSDIR}/dotnet/System.Security.Claims \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.ObjectPool>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ObjectPool \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.DependencyModel>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyModel \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.Http>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http \
		Microsoft.AspNetCore.Http.Extensions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Extensions \
		Microsoft.AspNetCore.Routing.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing.Abstractions \
		Microsoft.AspNetCore.Routing>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions \
		Microsoft.AspNetCore.Authorization>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Authorization \
		Microsoft.AspNetCore.WebUtilities>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.WebUtilities \
		Microsoft.AspNetCore.Mvc.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Abstractions \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource

GH_PROJECT=	Mvc

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.TypeConverter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Claims.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.ObjectPool.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Routing.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Authorization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.WebUtilities.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Buffers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.SecurityHelper.Sources/SecurityHelper.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyActivator.Sources/PropertyActivator.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources/ClosedGenericMatcher.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources/CopyOnWriteDictionary.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources/CopyOnWriteDictionaryHolder.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/DecisionCriterion.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/DecisionCriterionValue.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/DecisionCriterionValueEqualityComparer.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/DecisionTreeBuilder.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/DecisionTreeNode.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/IClassifier.cs \
			${LOCALBASE}/include/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources/ItemDescriptor.cs

.include <../../dotnet/aspnet/Makefile.common>


