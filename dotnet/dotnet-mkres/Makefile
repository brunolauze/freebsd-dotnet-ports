# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	dotnet-mkres
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Resources.Writer>=1.0:${PORTSDIR}/dotnet/System.Resources.Writer \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument

USE_GITHUB=	yes
GH_ACCOUNT=	brunolauze
GH_PROJECT=	dotnet-mkres
GH_TAGNAME=	master

DOTNET_TARGET=exe
DOTNET_ENTRYPOINT=Microsoft.DotNet.Tools.Resgen.Program
DOTNET_KEYFILE=${PATCHDIR}/mono.snk
DOTNET_XARGS?=${FIND} ${WRKSRC} -name '*.cs' | ${XARGS}

DOTNET_REFERENCES+=	${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Resources.Writer.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll

DOTNET_BIN_PROGRAM=	dotnet-mkres

.include <../../dotnet/coreclr/Makefile.common>
