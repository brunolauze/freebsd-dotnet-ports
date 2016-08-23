# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Routing.Abstractions/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Routing.Abstractions
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

BUILD_DEPENDS+=	Microsoft.Extensions.PropertyHelper.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PropertyHelper.Sources

NET_DEPENDS+=   System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web

GH_PROJECT=	Routing

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

DOTNET_FILES+=			${LOCALBASE}/include/dotnet/Microsoft.Extensions.PropertyHelper.Sources/PropertyHelper.cs

.include <../../dotnet/aspnet/Makefile.common>

