# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Security.Cryptography.Csp
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Encoding>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Encoding

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Encoding.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_DEFINES+=	-nowarn:0436

DOTNET_FILES+=		${WRKSRC}/src/Common/src/Internal/Cryptography/Windows/CryptoThrowHelper.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHandleCache.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHandleZeroOrMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/Interop/Windows/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Windows/Crypt32/Interop.FindOidInfo.cs

.include <../../dotnet/coreclr/corefx.common>
