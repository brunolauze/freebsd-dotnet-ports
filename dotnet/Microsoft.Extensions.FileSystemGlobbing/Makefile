# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.FileSystemGlobbing
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS} \
		Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Microsoft.Extensions.Primitives>=1.0.0.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	FileSystem

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
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.NonGeneric.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-target:library \
			-warn:4 \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/MatcherContext.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PathSegments/RecursiveWildcardSegment.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PathSegments/ParentPathSegment.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PathSegments/CurrentPathSegment.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PathSegments/LiteralPathSegment.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PathSegments/WildcardPathSegment.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContextRagged.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContextRaggedExclude.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContextLinearInclude.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContextLinearExclude.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContextRaggedInclude.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContext.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternContexts/PatternContextLinear.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/IRaggedPattern.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/PatternTestResult.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/ILinearPattern.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/Patterns/PatternBuilder.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/IPattern.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/IPathSegment.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Internal/IPatternContext.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/MatcherExtensions.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/PatternMatchingResult.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/FilePatternMatch.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Abstractions/FileInfoBase.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Abstractions/FileInfoWrapper.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Abstractions/FileSystemInfoBase.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Abstractions/DirectoryInfoWrapper.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Abstractions/DirectoryInfoBase.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Properties/AssemblyInfo.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Matcher.cs \
			src/Microsoft.Extensions.FileSystemGlobbing/Util/StringComparisonHelper.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
