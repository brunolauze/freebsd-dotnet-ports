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
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CSharp.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CodeAnalysis.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CodeAnalysis.CSharp.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.DotNet.ProjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.DotNet.Cli.Utils.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.DotNet.InternalAbstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.DotNet.Files.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.DotNet.Compiler.Common.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Testing.Abstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.ApplicationInsights.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Console.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.FileVersionInfo.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.TraceSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.TextWriterTraceListener.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Process.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.Compression.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.DataContractSerialization.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.InteropServices.RuntimeInformation.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Http.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.NameResolution.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Requests.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Sockets.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Dynamic.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Immutable.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Serialization.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Resources.Writer.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.Encoding.CodePages.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/Newtonsoft.Json.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Common.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Client.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Commands.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.CommandLine.XPlat.exe \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Protocol.Core.Types.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Protocol.Core.v3.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.Core.Types.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.RuntimeModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Versioning.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Frameworks.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.DependencyModel.dll \
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
