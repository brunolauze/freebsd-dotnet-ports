# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Security.Cryptography.Algorithms
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Numerics>=1.0:${PORTSDIR}/dotnet/System.Runtime.Numerics \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Encoding>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Encoding

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.net46.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.OSX.cs" -delete
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Security/Cryptography/CngKeyLite.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Security/Cryptography/RSACng.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/Internal/Cryptography/CngCipher.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Security/Cryptography/ECDsaCng.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Security/Cryptography/ECDsaCng.Key.cs

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Numerics.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Encoding.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_DEFINES+=	-define:INTERNAL_ASYMMETRIC_IMPLEMENTATIONS

DOTNET_FILES+=		${WRKSRC}/src/Common/src/Internal/Cryptography/BasicSymmetricCipher.cs \
			${WRKSRC}/src/Common/src/Internal/Cryptography/HashProvider.cs \
			${WRKSRC}/src/Common/src/Internal/Cryptography/UniversalCryptoTransform.cs \
			${WRKSRC}/src/Common/src/Internal/Cryptography/UniversalCryptoEncryptor.cs \
			${WRKSRC}/src/Common/src/Internal/Cryptography/UniversalCryptoDecryptor.cs \
			${WRKSRC}/src/Common/src/Internal/Cryptography/OpenSslAsymmetricAlgorithmCore.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.EcDsa.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.EcDsa.ImportExport.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.EcKey.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.Nid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Bignum.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ERR.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.EVP.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.EVP.Cipher.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.RAND.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Hmac.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Rsa.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeBignumHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeEvpCipherCtxHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeEvpMdCtxHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHmacCtxHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeRsaHandle.Unix.cs \
			${WRKSRC}/src/Common/src/System/Security/Cryptography/ECDsaOpenSsl.cs \
			${WRKSRC}/src/Common/src/System/Security/Cryptography/DerSequenceReader.cs \
			${WRKSRC}/src/Common/src/System/Security/Cryptography/DerEncoder.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeEcKeyHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/Asn1SafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeInteriorHandle.cs \

.include <../../dotnet/coreclr/corefx.common>
