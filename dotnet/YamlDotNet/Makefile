# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	YamlDotNet
PORTVERSION=	3.8.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.ComponentModel.TypeConverter>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.TypeConverter \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Serialization.Primitives>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Primitives \
		System.Runtime.Serialization.Formatters>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Formatters \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions

RUN_DEPENDS+=	${NET_DEPENDS}

USE_GITHUB=	yes
GH_ACCOUNT=	aaubry
GH_PROJECT=	${PORTNAME}
GH_TAGNAME=	master

DOTNET_SOURCE_PATH=${WRKSRC}/${PORTNAME}
DOTNET_KEYFILE=	${PATCHDIR}/mono.snk

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.TypeConverter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Serialization.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Serialization.Formatters.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll

DOTNET_DEFINES+=	-define:PORTABLE \
			-define:DOTNET


.include <../../dotnet/coreclr/Makefile.common>
