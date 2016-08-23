# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.DotNet.Compiler.Common
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CSharp \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis \
		Microsoft.CodeAnalysis.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp \
		Microsoft.DotNet.ProjectModel>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.ProjectModel \
		Microsoft.DotNet.Cli.Utils>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.Cli.Utils \
		Microsoft.DotNet.Files>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.Files \
		Newtonsoft.Json>=8.0:${PORTSDIR}/dotnet/Newtonsoft.Json \
		NuGet.Packaging>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging \
		NuGet.RuntimeModel>=1.0:${PORTSDIR}/dotnet/NuGet.RuntimeModel \
		NuGet.Versioning>=1.0:${PORTSDIR}/dotnet/NuGet.Versioning \
		NuGet.Frameworks>=1.0:${PORTSDIR}/dotnet/NuGet.Frameworks \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Diagnostics.Process>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Process \
		System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Runtime.Serialization.Primitives>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Primitives \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument \
		Microsoft.Extensions.DependencyModel>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyModel
		

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	cli

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
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.CoreLib.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.ProjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.Cli.Utils.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.Files.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Process.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Dynamic.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Serialization.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Newtonsoft.Json.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.RuntimeModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Versioning.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Frameworks.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyModel.dll \
			-define:COMPILERCORE \
			-target:library \
			-warn:4

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
