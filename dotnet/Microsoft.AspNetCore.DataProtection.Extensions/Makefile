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

DOTNET_REFERENCES+=	-reference:/usr/local/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:/usr/local/lib/dotnet/System.IO.FileSystem.dll \
			-reference:/usr/local/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:/usr/local/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:/usr/local/lib/dotnet/System.Security.Cryptography.X509Certificates.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.Extensions.PlatformAbstractions.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.AspNetCore.DataProtection.Abstractions.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.AspNetCore.DataProtection.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			-reference:/usr/local/lib/dotnet/Microsoft.Extensions.DependencyInjection.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_DEFINES+=	-define:NETSTANDARD1_3 \
			-define:CORECLR

DOTNET_FILES+=		src/Microsoft.AspNetCore.DataProtection.Sources/EncodingUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Sources/ExceptionExtensions.cs

.include <../../dotnet/aspnet/Makefile.common>
