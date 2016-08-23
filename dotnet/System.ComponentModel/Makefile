# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.ComponentModel
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

post-patch:
	@${RM} ${WRKSRC}/src/System.ComponentModel/src/System/IServiceProvider.cs

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

.include <../../dotnet/coreclr/corefx.common>
