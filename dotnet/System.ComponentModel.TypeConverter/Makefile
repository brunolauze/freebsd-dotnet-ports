# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.ComponentModel.TypeConverter
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.ComponentModel>=1.0:${PORTSDIR}/dotnet/System.ComponentModel \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.ComponentModel.Primitives>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.Primitives \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.NetStandard10.cs" -delete

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.NonGeneric.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Specialized.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

.include <../../dotnet/coreclr/corefx.common>
