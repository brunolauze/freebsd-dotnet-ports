# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Interactive.Async
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq

GH_ACCOUNT=	Reactive-Extensions
GH_PROJECT=	Rx.NET
GH_TAGNAME=	master

DOTNET_SOURCE_PATH=	${WRKSRC}/Ix.NET/Source/${PORTNAME}
DOTNET_KEYFILE=		${PATCHDIR}/mono.snk

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:${DOTNET_SOURCE_PATH}/Properties/${PORTNAME}.rd.xml

.include <../../dotnet/aspnet/Makefile.common>
