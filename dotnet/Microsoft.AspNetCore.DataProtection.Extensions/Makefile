# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.DataProtection.Extensions
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.AspNetCore.DataProtection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.DataProtection.Abstractions \
		Microsoft.AspNetCore.DataProtection>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.DataProtection \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.DependencyInjection>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection

GH_PROJECT=	DataProtection

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME} -name "*.cs" | ${XARGS} ${REINPLACE_CMD} -e 's|CryptoUtil|CryptoUtilHelper|g'

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.X509Certificates.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		src/Microsoft.AspNetCore.DataProtection.Sources/EncodingUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Sources/ExceptionExtensions.cs

.include <../../dotnet/aspnet/Makefile.common>
