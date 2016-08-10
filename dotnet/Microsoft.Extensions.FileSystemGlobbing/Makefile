# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.FileSystemGlobbing
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Microsoft.Extensions.Primitives>=1.0.0.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives

GH_PROJECT=	FileSystem


DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.NonGeneric.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs

OLD_LISTING+=		src/Microsoft.Extensions.FileSystemGlobbing/Internal/MatcherContext.cs \
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

.include <../../dotnet/aspnet/Makefile.common>
