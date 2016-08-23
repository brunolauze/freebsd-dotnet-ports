# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.DataProtection.Abstractions
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.WebEncoders.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.WebEncoders.Sources

NET_DEPENDS+=   System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.Extensions.WebEncoders>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.WebEncoders

GH_PROJECT=	DataProtection

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME} -name "*.cs" | ${XARGS} ${REINPLACE_CMD} -e 's|CryptoUtil|CryptoUtilHelper|g'

DOTNET_RESOURCE_COMMAND=cp ${LOCALBASE}/include/dotnet/Microsoft.Extensions.WebEncoders.Sources/EncoderResources.resx ${WRKSRC}/src/${PORTNAME}/EncoderResources.resx && \
			cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} EncoderResources.resx,${PORTNAME}.EncoderResources.resources \
			cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.WebEncoders.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/${PORTNAME}.Resources.resources \
			${DOTNET_RES}:src/${PORTNAME}/${PORTNAME}.EncoderResources.resources

DOTNET_FILES+=		src/Microsoft.AspNetCore.DataProtection.Sources/EncodingUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Sources/ExceptionExtensions.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.WebEncoders.Sources/WebEncoders.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.WebEncoders.Sources/Properties/EncoderResources.Designer.cs

.include <../../dotnet/aspnet/Makefile.common>
