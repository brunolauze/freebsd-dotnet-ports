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
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.CoreLib.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.InteropServices.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Numerics.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.NonGeneric.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Specialized.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Composition.AttributedModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Composition.Convention.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Composition.Hosting.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Composition.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Composition.TypedParts.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Data.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XmlDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.dll \
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
