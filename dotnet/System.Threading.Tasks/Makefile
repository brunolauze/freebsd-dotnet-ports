# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Threading.Tasks
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading


DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll


post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.netcore50.cs" -delete

.include <../../dotnet/coreclr/corefx.common>
