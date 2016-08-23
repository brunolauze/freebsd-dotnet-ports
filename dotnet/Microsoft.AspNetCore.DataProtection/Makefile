# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.DataProtection
PORTVERSION=	1.0.0.0

COMMENTS+=	Patches are a decision to ignore any code touching Registry

NET_DEPENDS+=   System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Microsoft.AspNetCore.Cryptography.Internal>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Cryptography.Internal \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.AspNetCore.DataProtection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.DataProtection.Abstractions \
		Microsoft.AspNetCore.Hosting.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Hosting.Abstractions

GH_PROJECT=	DataProtection

post-patch:
	@${RM} ${WRKSRC}/src/${PORTNAME}/RegistryPolicyResolver.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/Repositories/RegistryXmlRepository.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/XmlEncryption/DpapiNGXmlEncryptor.cs


DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.X509Certificates.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Cryptography.Internal.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.DataProtection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Hosting.Abstractions.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		src/Microsoft.AspNetCore.DataProtection.Sources/EncodingUtil.cs \
			src/Microsoft.AspNetCore.DataProtection.Sources/ExceptionExtensions.cs

.include <../../dotnet/aspnet/Makefile.common>

