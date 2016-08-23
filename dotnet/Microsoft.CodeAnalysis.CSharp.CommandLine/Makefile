# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.CodeAnalysis.CSharp.CommandLine
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Console>=1.0:${PORTSDIR}/dotnet/System.Console \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Process>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Process \
		System.Diagnostics.StackTrace>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.StackTrace \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Net.Sockets>=1.0:${PORTSDIR}/dotnet/System.Net.Sockets \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis \
		Microsoft.CodeAnalysis.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	roslyn

DOTNET_KEYFILE=	${PATCHDIR}/mono.snk
DOTNET_TARGET=exe
DOTNET_ENTRYPOINT=Microsoft.CodeAnalysis.CSharp.CommandLine.Program
DOTNET_OUTPUT=csc
DOTNET_BIN_PROGRAM=csc
DOTNET_SOURCE_PATH=${WRKSRC}/src/Compilers/Core/CommandLine

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Process.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Sockets.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll

DOTNET_FILES+=		src/Compilers/Shared/CoreClrAnalyzerAssemblyLoader.cs \
			src/Compilers/Shared/CoreClrBuildClient.cs \
			src/Compilers/Shared/Csc.cs \
			src/Compilers/CSharp/CscCore/Program.cs

.include <../../dotnet/coreclr/Makefile.common>
