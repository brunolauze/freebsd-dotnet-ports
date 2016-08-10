# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.DataProtection.Abstractions
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions

GH_PROJECT=	DataProtection

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME} -name "*.cs" | ${XARGS} ${REINPLACE_CMD} -e 's|CryptoUtil|CryptoUtilHelper|g'

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	-reference:/usr/local/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:/usr/local/lib/dotnet/System.Runtime.dll \
			-reference:/usr/local/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		src/Microsoft.AspNetCore.DataProtection.Sources/EncodingUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Sources/ExceptionExtensions.cs

.include <../../dotnet/aspnet/Makefile.common>
