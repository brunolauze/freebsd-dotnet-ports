# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Net.Http.Headers/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Net.Http.Headers
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq

GH_PROJECT=	HttpAbstractions

DOTNET_REFERENCES+=	-reference:${LOCALBASE}/lib/dotnet/System.Buffers.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll

.include <../../dotnet/aspnet/Makefile.common>


