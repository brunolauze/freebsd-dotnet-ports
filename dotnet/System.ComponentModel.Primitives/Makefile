# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.ComponentModel.Primitives
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.ComponentModel>=1.0:${PORTSDIR}/dotnet/System.ComponentModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

post-patch:
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/ComponentModel/ComponentModelExtensions.cs

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

.include <../../dotnet/coreclr/corefx.common>
