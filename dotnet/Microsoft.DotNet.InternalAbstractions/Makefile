# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.DotNet.InternalAbstractions
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.AppContext>=1.0:${PORTSDIR}/dotnet/System.AppContext \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.InteropServices>=1.0:${PORTSDIR}/dotnet/System.Runtime.InteropServices \
		System.Runtime.InteropServices.RuntimeInformation>=1.0:${PORTSDIR}/dotnet/System.Runtime.InteropServices.RuntimeInformation \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument

GH_ACCOUNT=	dotnet
GH_PROJECT=	cli
GH_TAGNAME=	rel/1.0.0

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.InteropServices.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.InteropServices.RuntimeInformation.dll

DOTNET_DEFINES+=	-define:COMPILERCORE

.include <../../dotnet/aspnet/Makefile.common>
