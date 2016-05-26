# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.Razor.Host
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS} \
		Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.AspNetCore.Razor.Runtime>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Razor.Runtime \
		Microsoft.Extensions.Caching.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Abstractions \
		Microsoft.Extensions.Caching.Memory>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Memory \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.AspNetCore.Mvc.Core>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Core \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options

USE_GITHUB=     yes
GH_ACCOUNT=     aspnet
GH_PROJECT=     Mvc

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
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileProviders.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileProviders.Physical.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Razor.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Razor.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Mvc.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.AspNetCore.Html.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Caching.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Caching.Memory.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			 -reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Options.dll \
			-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources \
			-target:library \
			-warn:4 \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/InjectChunkVisitor.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcCSharpCodeGenerator.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcRazorCodeParser.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/InjectChunk.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Properties/Resources.Designer.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Properties/AssemblyInfo.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcRazorHost.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcCSharpCodeVistor.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/ModelChunkGenerator.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/ModelChunk.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/InjectParameterGenerator.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/GeneratedTagHelperAttributeContext.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcRazorParser.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/ViewHierarchyUtility.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcCSharpChunkVisitor.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/IMvcRazorHost.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcCSharpDesignTimeCodeVisitor.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Internal/RazorPathNormalizer.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Internal/DesignTimeRazorPathNormalizer.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/MvcTagHelperAttributeValueCodeRenderer.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/ChunkHelper.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/SetBaseTypeChunkMerger.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/ChunkTreeResult.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/IChunkTreeCache.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/UsingChunkMerger.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/IChunkMerger.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/DefaultChunkTreeCache.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/ChunkInheritanceUtility.cs \
			src/Microsoft.AspNetCore.Mvc.Razor.Host/Directives/InjectChunkMerger.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


