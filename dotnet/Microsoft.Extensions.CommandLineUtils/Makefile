# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.CommandLineUtils
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Console>=1.0:${PORTSDIR}/dotnet/System.Console \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

GH_PROJECT=	Common

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Console.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \

DOTNET_FILES+=		src/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs

.include <../../dotnet/aspnet/Makefile.common>


