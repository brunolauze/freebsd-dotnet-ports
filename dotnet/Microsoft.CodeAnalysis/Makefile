# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.CodeAnalysis
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
		System.Xml.XmlSerializer>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlSerializer

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
	@cd ${WRKSRC}/src/Compilers/Core/Portable && resgen /useSourcePath /compile CodeAnalysisResources.resx,${PORTNAME}.CodeAnalysisResources.resources
	@cd ${WRKSRC}/src/Workspaces/Core/Portable && resgen /useSourcePath /compile WorkspacesResources.resx,${PORTNAME}.WorkspacesResources.resources
	@cd ${WRKSRC} && ${FIND} src/Compilers/Core/Portable -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
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
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Tools.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Data.Common.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XmlDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.Extensions.dll \
			-resource:src/Compilers/Core/Portable/${PORTNAME}.CodeAnalysisResources.resources \
			-resource:src/Workspaces/Core/Portable/${PORTNAME}.WorkspacesResources.resources \
			-define:COMPILERCORE \
			-define:SRM \
			-target:library \
			-warn:4 \
			src/Compilers/Shared/CoreClrShim.cs \
			src/Compilers/Shared/DesktopShim.cs \
			src/Compilers/Core/SharedCollections/ObjectPool\`1.cs \
			src/Compilers/Core/SharedCollections/ArrayBuilder.cs \
			src/Compilers/Core/SharedCollections/PooledDictionary.cs \
			src/Compilers/Core/SharedCollections/ArrayBuilder.Enumerator.cs \
			src/Compilers/Core/SharedCollections/PooledHashSet.cs \
			src/Compilers/Core/AnalyzerDriver/AnalyzerExceptionDescriptionBuilder.cs \
			src/Compilers/Core/AnalyzerDriver/DeclarationComputer.cs \
			src/Compilers/Core/AnalyzerDriver/DeclarationInfo.cs \
			src/Workspaces/Core/Portable/WorkspacesResources.Designer.cs \
			src/Workspaces/Core/Portable/Utilities/Contract.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
