# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	dotnet
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Native>=1.0:${PORTSDIR}/dotnet/System.Native \
		corehost>=1.0:${PORTSDIR}/dotnet/corehost \
		Microsoft.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CSharp \
		System.Diagnostics.FileVersionInfo>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.FileVersionInfo \
		System.Diagnostics.Eventing>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Eventing \
		System.Diagnostics.TraceSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.TraceSource \
		System.Diagnostics.TextWriterTraceListener>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.TextWriterTraceListener \
		System.DirectoryServices>=1.0:${PORTSDIR}/dotnet/System.DirectoryServices \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis \
		Microsoft.CodeAnalysis.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp \
		Microsoft.DotNet.ProjectModel>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.ProjectModel \
		Microsoft.DotNet.ProjectModel.Loader>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.ProjectModel.Loader \
		Microsoft.DotNet.Cli.Utils>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.Cli.Utils \
		Microsoft.DotNet.Files>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.Files \
		Microsoft.DotNet.Compiler.Common>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.Compiler.Common \
		Microsoft.Extensions.Testing.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Testing.Abstractions \
		Microsoft.ApplicationInsights>=1.0:${PORTSDIR}/dotnet/Microsoft.ApplicationInsights \
		Newtonsoft.Json>=8.0:${PORTSDIR}/dotnet/Newtonsoft.Json \
		NuGet.Packaging>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging \
		NuGet.RuntimeModel>=1.0:${PORTSDIR}/dotnet/NuGet.RuntimeModel \
		NuGet.Versioning>=1.0:${PORTSDIR}/dotnet/NuGet.Versioning \
		NuGet.Frameworks>=1.0:${PORTSDIR}/dotnet/NuGet.Frameworks \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Diagnostics.Process>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Process \
		System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Management>=1.0:${PORTSDIR}/dotnet/System.Management \
		System.Private.DataContractSerialization>=1.0:${PORTSDIR}/dotnet/System.Private.DataContractSerialization \
		System.Net.Sockets>=1.0:${PORTSDIR}/dotnet/System.Net.Sockets \
		System.Runtime.Serialization.Primitives>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Primitives \
		System.Runtime.Serialization.Formatters>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Formatters \
		System.Resources.Reader>=1.0:${PORTSDIR}/dotnet/System.Resources.Reader \
		System.Resources.Writer>=1.0:${PORTSDIR}/dotnet/System.Resources.Writer \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Text.Encoding.CodePages>=1.0:${PORTSDIR}/dotnet/System.Text.Encoding.CodePages \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument \
		NuGet.Commands>=1.0:${PORTSDIR}/dotnet/NuGet.Commands \
		NuGet.CommandLine.XPlat>=1.0:${PORTSDIR}/dotnet/NuGet.CommandLine.XPlat \
		Newtonsoft.Json>=1.0:${PORTSDIR}/dotnet/Newtonsoft.Json \
		Microsoft.Extensions.DependencyModel>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyModel

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	cli

USES=           dotnet

configure:

do-configure:

post-patch:
	@mkdir -p ${WRKSRC}/Resources
	@mv ${WRKSRC}/src/dotnet/commands/dotnet-new/CSharp_Console ${WRKSRC}/Resources/CSharp_Console
	@mv ${WRKSRC}/src/dotnet/commands/dotnet-new/FSharp_Console ${WRKSRC}/Resources/FSharp_Console

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
			-out:bin/Release/${PORTNAME}.exe \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.CoreLib.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.ProjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.Cli.Utils.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.InternalAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.Files.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.Compiler.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Testing.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.ApplicationInsights.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.FileVersionInfo.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.TraceSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.TextWriterTraceListener.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Process.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.Compression.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.DataContractSerialization.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.InteropServices.RuntimeInformation.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.NameResolution.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Requests.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Sockets.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Dynamic.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Serialization.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Resources.Writer.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encoding.CodePages.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Newtonsoft.Json.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Client.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Commands.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.CommandLine.XPlat.exe \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Protocol.Core.Types.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Protocol.Core.v3.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.Core.Types.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.RuntimeModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Versioning.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Frameworks.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyModel.dll \
			-resource:${WRKSRC}/Resources/CSharp_Console/Program.cs,Microsoft.DotNet.CSharp_Console.Program.cs \
			-resource:${WRKSRC}/Resources/CSharp_Console/project.json.pretemplate,Microsoft.DotNet.CSharp_Console.project.json.pretemplate \
			-resource:${WRKSRC}/Resources/FSharp_Console/NuGet.Config,Microsoft.DotNet.FSharp_Console.NuGet.Config \
			-resource:${WRKSRC}/Resources/FSharp_Console/Program.fs,Microsoft.DotNet.FSharp_Console.Program.fs \
			-resource:${WRKSRC}/Resources/FSharp_Console/project.json.pretemplate,Microsoft.DotNet.FSharp_Console.project.json.pretemplate \
			-define:COMPILERCORE \
			-target:exe \
			-main:Microsoft.DotNet.Cli.Program \
			-warn:4

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.exe ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.exe
	@${INSTALL_DATA} ${PATCHDIR}/.version ${STAGEDIR}${PREFIX}/lib/dotnet/.version
	@${INSTALL_DATA} ${PATCHDIR}/dotnet.runtimeconfig.json ${STAGEDIR}${PREFIX}/lib/dotnet/dotnet.runtimeconfig.json
	@${INSTALL_DATA} ${PATCHDIR}/csc.runtimeconfig.json ${STAGEDIR}${PREFIX}/lib/dotnet/csc.runtimeconfig.json
	@${INSTALL_SCRIPT} ${PATCHDIR}/${PORTNAME} ${STAGEDIR}${PREFIX}/bin/${PORTNAME}
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}-1.0.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}-1.0.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}-1.0.pc

.include <bsd.port.mk>
