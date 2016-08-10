# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Roslyn.Compilers.CSharp.Internal.CSharpErrorFactsGenerator
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Console>=1.0:${PORTSDIR}/dotnet/System.Console \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	roslyn

DOTNET_KEYFILE=	${PATCHDIR}/mono.snk
DOTNET_TARGET=	exe
DOTNET_SOURCE_PATH=	${WRKSRC}/src/Tools/Source/CompilerGeneratorTools/Source/CSharpErrorFactsGenerator
DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll

DOTNET_OUTPUT=	CSharpErrorFactsGenerator
DOTNET_BIN_PROGRAM=	roslyn.csharperrorfactsgenerator

.include <../../dotnet/coreclr/Makefile.common>
