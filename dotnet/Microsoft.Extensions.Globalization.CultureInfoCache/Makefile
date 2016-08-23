# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.Globalization.CultureInfoCache
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Localization.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Localization.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options

GH_PROJECT=	Localization

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

.include <../../dotnet/aspnet/Makefile.common>
