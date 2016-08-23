# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Resources.Reader
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug

post-patch:
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Resources/ResourceManager.cs

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll

DOTNET_RESOURCES+=	-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/HResults.cs

.include <../../dotnet/coreclr/corefx.common>
