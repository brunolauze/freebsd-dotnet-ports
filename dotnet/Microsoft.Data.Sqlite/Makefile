# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Data.Sqlite
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Data.Common>=1.0:${PORTSDIR}/dotnet/System.Data.Common \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Text.Encoding.CodePages>=1.0:${PORTSDIR}/dotnet/System.Text.Encoding.CodePages 

GH_PROJECT=	${PORTNAME}

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Strings.resx,${PORTNAME}.Strings.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Data.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encoding.CodePages.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Strings.resources \
			-resource:src/${PORTNAME}/Properties/Microsoft.Data.Sqlite.rd.xml

.include <../../dotnet/aspnet/Makefile.common>
