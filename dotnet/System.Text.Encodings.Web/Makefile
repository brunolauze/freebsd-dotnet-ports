# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Text.Encodings.Web
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,${PORTNAME}.Resources.Strings.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/src/Resources/${PORTNAME}.Resources.Strings.resources \
			${DOTNET_RES}:src/${PORTNAME}/src/Resources/unicode8definedcharacters.bin,${PORTNAME}.Resources.unicode8definedcharacters.bin

.include <../../dotnet/coreclr/corefx.common>


