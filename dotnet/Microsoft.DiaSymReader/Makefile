# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.DiaSymReader
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	roslyn

DOTNET_SOURCE_PATH=${WRKSRC}/src/Dependencies/${PORTNAME}
DOTNET_KEYFILE=	${PATCHDIR}/mono.snk
DOTNET_UNSAFE=	yes

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll
DOTNET_DEFINES+=	-define:COMPILERCORE

.include <../../dotnet/coreclr/Makefile.common>
