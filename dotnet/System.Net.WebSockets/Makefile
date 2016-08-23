# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.WebSockets
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

.include <../../dotnet/coreclr/corefx.common>
