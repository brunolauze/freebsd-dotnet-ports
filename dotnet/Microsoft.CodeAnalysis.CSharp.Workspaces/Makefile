# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.CodeAnalysis.CSharp.Workspaces
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS} \
		${ROSLYN_TOOLS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Parallel>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Parallel \
		System.Xml.XmlSerializer>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlSerializer \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis \
		Microsoft.CodeAnalysis.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp \
		Microsoft.CodeAnalysis.Workspaces>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.Workspaces

ROSLYN_TOOLS+=	Roslyn.Compilers.Internal.BoundTreeGenerator>=1.0:${PORTSDIR}/dotnet/Roslyn.Compilers.Internal.BoundTreeGenerator \
		Roslyn.Compilers.CSharp.Internal.CSharpSyntaxGenerator>=1.0:${PORTSDIR}/dotnet/Roslyn.Compilers.CSharp.Internal.CSharpSyntaxGenerator \
		Roslyn.Compilers.CSharp.Internal.CSharpErrorFactsGenerator>=1.0:${PORTSDIR}/dotnet/Roslyn.Compilers.CSharp.Internal.CSharpErrorFactsGenerator

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
	@cd ${WRKSRC} && ${FIND} src/Workspaces/CSharp/Portable -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Tools.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Immutable.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XmlSerializer.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CodeAnalysis.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CodeAnalysis.CSharp.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CodeAnalysis.Workspaces.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.Parallel.dll \
			-target:library \
			-warn:4 \
			-define:COMPILERCORE \
			src/Compilers/CSharp/CSharpAnalyzerDriver/CSharpDeclarationComputer.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
