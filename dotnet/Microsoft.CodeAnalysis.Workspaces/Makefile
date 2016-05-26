# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.CodeAnalysis.Workspaces/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.CodeAnalysis.Workspaces
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.ComponentModel.Primitives>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.Primitives \
		System.Composition.AttributedModel>=1.0:${PORTSDIR}/dotnet/System.Composition.AttributedModel \
		System.Composition.Convention>=1.0:${PORTSDIR}/dotnet/System.Composition.Convention \
		System.Composition.Hosting>=1.0:${PORTSDIR}/dotnet/System.Composition.Hosting \
		System.Composition.Runtime>=1.0:${PORTSDIR}/dotnet/System.Composition.Runtime \
		System.Composition.TypedParts>=1.0:${PORTSDIR}/dotnet/System.Composition.TypedParts \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.Data.Common>=1.0:${PORTSDIR}/dotnet/System.Data.Common \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.InteropServices>=1.0:${PORTSDIR}/dotnet/System.Runtime.InteropServices \
		System.Runtime.Numerics>=1.0:${PORTSDIR}/dotnet/System.Runtime.Numerics \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks \
		System.Threading.Tasks.Extensions>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Extensions \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument \
		System.Xml.XmlDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlDocument \
		System.Xml.XmlSerializer>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlSerializer \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	roslyn

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
	@${RM} ${WRKSRC}/src/Compilers/Core/Portable/System/Reflection/Metadata/ILOpCode.cs
	@${RM} ${WRKSRC}/src/Workspaces/Core/Portable/Shared/Extensions/IProjectDependencyGraphExtensions.cs
	@${RM} ${WRKSRC}/src/Workspaces/Core/Portable/Shared/Extensions/SymbolDisplayPartKindExtensions.cs
	@cd ${WRKSRC}/src/Workspaces/Core/Portable && resgen /useSourcePath /compile WorkspacesResources.resx,${PORTNAME}.WorkspacesResources.resources
	@cd ${WRKSRC} && ${FIND} src/Workspaces/Core/Portable -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.InteropServices.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Numerics.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Immutable.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.NonGeneric.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Specialized.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ComponentModel.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Composition.AttributedModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Composition.Convention.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Composition.Hosting.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Composition.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Composition.TypedParts.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Tools.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Data.Common.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XmlDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CodeAnalysis.dll \
			-resource:src/Workspaces/Core/Portable/${PORTNAME}.WorkspacesResources.resources \
			-target:library \
			-define:NETSTANDARD1_3 \
			-warn:4 \
			src/Compilers/Core/Portable/Collections/ArrayBuilderExtensions.cs \
			src/Compilers/Core/Portable/Collections/BitVector.cs \
			src/Compilers/Core/Portable/Collections/Boxes.cs \
			src/Compilers/Core/Portable/Collections/ImmutableArrayExtensions.cs \
			src/Compilers/Core/Portable/Collections/OrderPreservingMultiDictionary.cs \
			src/Compilers/Core/Portable/Collections/PooledStringBuilder.cs \
			src/Compilers/Core/Portable/CorLightup.cs \
			src/Compilers/Core/Portable/UnicodeCharacterUtilities.cs \
			src/Compilers/Core/Portable/FileSystem/RelativePathResolver.cs \
			src/Compilers/Core/Portable/InternalUtilities/BitArithmeticUtilities.cs \
			src/Compilers/Core/Portable/InternalUtilities/ArrayExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/CompilerOptionParseUtilities.cs \
			src/Compilers/Core/Portable/InternalUtilities/ConcurrentSet.cs \
			src/Compilers/Core/Portable/InternalUtilities/ConsList\`1.cs \
			src/Compilers/Core/Portable/InternalUtilities/DecimalUtilities.cs \
			src/Compilers/Core/Portable/InternalUtilities/DocumentationCommentXmlNames.cs \
			src/Compilers/Core/Portable/InternalUtilities/EnumerableExtensions.ComparisonComparer.cs \
			src/Compilers/Core/Portable/InternalUtilities/EnumerableExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/EnumUtilties.cs \
			src/Compilers/Core/Portable/InternalUtilities/FailFast.cs \
			src/Compilers/Core/Portable/InternalUtilities/FatalError.cs \
			src/Compilers/Core/Portable/InternalUtilities/FileNameUtilities.cs \
			src/Compilers/Core/Portable/InternalUtilities/Hash.cs \
			src/Compilers/Core/Portable/InternalUtilities/HashAlgorithms.cs \
			src/Compilers/Core/Portable/InternalUtilities/ImmutableListExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/ISetExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/KeyValuePair.cs \
			src/Compilers/Core/Portable/InternalUtilities/MultiDictionary.cs \
			src/Compilers/Core/Portable/InternalUtilities/IReadOnlySet.cs \
			src/Compilers/Core/Portable/FileSystem/PathKind.cs \
			src/Compilers/Core/Portable/InternalUtilities/ExceptionUtilities.cs \
			src/Compilers/Core/Portable/InternalUtilities/ReaderWriterLockSlimExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/ReferenceEqualityComparer.cs \
			src/Compilers/Core/Portable/InternalUtilities/SemaphoreSlimExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Array.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Collection.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Dictionary.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Enumerable.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Enumerator.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Enumerator\`1.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.List.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Empty.Set.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.ReadOnly.Collection.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.ReadOnly.Enumerable\`1.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.ReadOnly.Enumerable\`2.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.ReadOnly.Set.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Singleton.Collection\`1.cs \
			src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.Singleton.Enumerator\`1.cs \
			src/Compilers/Core/Portable/InternalUtilities/StringExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/TextChangeRangeExtensions.cs \
			src/Compilers/Core/Portable/InternalUtilities/ValueTuple.cs \
			src/Compilers/Core/Portable/InternalUtilities/ValueTuple\`2.cs \
			src/Compilers/Core/Portable/InternalUtilities/ValueTuple\`3.cs \
			src/Compilers/Core/Portable/InternalUtilities/WeakReferenceExtensions.cs \
			src/Compilers/Core/Portable/Serialization/FixedObjectBinder.cs \
			src/Compilers/Core/Portable/Serialization/IObjectReadable.cs \
			src/Compilers/Core/Portable/Serialization/IObjectWritable.cs \
			src/Compilers/Core/Portable/Serialization/ObjectBinder.cs \
			src/Compilers/Core/Portable/Serialization/ObjectReader.cs \
			src/Compilers/Core/Portable/Serialization/ObjectReaderData.cs \
			src/Compilers/Core/Portable/Serialization/ObjectReaderWriterBase.cs \
			src/Compilers/Core/Portable/Serialization/ObjectWriter.cs \
			src/Compilers/Core/Portable/Serialization/ObjectWriterData.cs \
			src/Compilers/Core/Portable/Serialization/RecordingObjectBinder.cs \
			src/Compilers/Core/Portable/Serialization/SimpleRecordingObjectBinder.cs \
			src/Compilers/Core/Portable/FileSystem/FileUtilities.cs \
			src/Compilers/Core/Portable/FileSystem/PathUtilities.cs \
			src/Compilers/Core/Portable/InternalUtilities/ReflectionUtilities.cs \
			src/Compilers/Core/Portable/PortableShim.cs			

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
