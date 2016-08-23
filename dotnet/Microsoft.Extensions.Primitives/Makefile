# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.Primitives
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

GH_PROJECT=	Common

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/Microsoft.Extensions.Primitives/${PORTNAME}.Resources.resources \

DOTNET_FILES+=		src/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs

.include <../../dotnet/aspnet/Makefile.common>
