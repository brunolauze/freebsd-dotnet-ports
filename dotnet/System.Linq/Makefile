# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Linq
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug

DOTNET_REFERENCES+=	${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll

DOTNET_FILES+=		src/Common/src/System/Collections/Generic/EnumerableHelpers.cs \
			src/Common/src/System/Diagnostics/CodeAnalysis/ExcludeFromCodeCoverageAttribute.cs

.include <../../dotnet/coreclr/corefx.common>
