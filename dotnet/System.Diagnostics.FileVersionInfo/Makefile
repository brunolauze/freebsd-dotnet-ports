# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Diagnostics.FileVersionInfo
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
        	System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Threading.Tasks>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.dll \


post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete

.include <../../dotnet/coreclr/corefx.common>
