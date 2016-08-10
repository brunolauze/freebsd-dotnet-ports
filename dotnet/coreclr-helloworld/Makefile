# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	coreclr-helloworld
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Native>=1.0:${PORTSDIR}/dotnet/System.Native \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Console>=1.0:${PORTSDIR}/dotnet/System.Console

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefxlab


DOTNET_XARGS=	
DOTNET_TARGET=exe
DOTNET_KEYFILE=${PATCHDIR}/mono.snk
DOTNET_OUTPUT=HelloWorld
DOTNET_BIN_PROGRAM=helloworld

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

DOTNET_FILES+=		${WRKSRC}/demos/CoreClrConsoleApplications/HelloWorld/HelloWorld.cs

.include <../../dotnet/coreclr/Makefile.common>
