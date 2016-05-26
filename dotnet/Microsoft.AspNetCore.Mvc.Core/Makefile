# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Mvc.Abstractions/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.Core
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS} \
		Microsoft.Extensions.SecurityHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.SecurityHelper.Sources \
		Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources \
		Microsoft.Extensions.PropertyActivator.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyActivator.Sources \
		Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources \
		Microsoft.Extensions.ClosedGenericMatcher.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources \
		Microsoft.Extensions.CopyOnWriteDictionary.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources \
		Microsoft.AspNetCore.Routing.DecisionTree.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Routing.DecisionTree.Sources

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
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

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	Mvc

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
	@cd ${WRKSRC}/src/${PORTNAME} && resgen /useSourcePath /compile Resources.resx,${PORTNAME}.Resources.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ComponentModel.TypeConverter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Claims.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.ObjectPool.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Options.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Logging.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileProviders.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Features.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Http.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Routing.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Routing.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Hosting.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Authorization.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.WebUtilities.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Mvc.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.DiagnosticSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Net.Http.Headers.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Buffers.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.Encodings.Web.dll \
			-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources \
			-target:library \
			-warn:4 \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.SecurityHelper.Sources/SecurityHelper.cs \
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

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


