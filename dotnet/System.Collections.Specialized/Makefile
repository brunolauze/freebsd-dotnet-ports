# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Collections.Specialized
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

NET_DEPENDS+=   System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Globalization.Extensions>=1.0:${PORTSDIR}/dotnet/System.Globalization.Extensions \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime


DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=     ${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.NonGeneric.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Globalization.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

.include <../../dotnet/coreclr/corefx.common>
