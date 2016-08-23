# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Mvc.Razor.Host
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources

NET_DEPENDS+=   Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions \
		Microsoft.Extensions.FileProviders.Physical>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Physical \
		Microsoft.AspNetCore.Razor.Runtime>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Razor.Runtime \
		Microsoft.Extensions.Caching.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Abstractions \
		Microsoft.Extensions.Caching.Memory>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Memory \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.AspNetCore.Mvc.Core>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Mvc.Core \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options

GH_PROJECT=     Mvc

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_FILES+=		${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Physical.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Razor.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Mvc.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Html.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Memory.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			 ${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs

OLD_LISTING+=		src/Microsoft.AspNetCore.Mvc.Razor.Host/InjectChunkVisitor.cs \
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

.include <../../dotnet/aspnet/Makefile.common>


