# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.Security
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Encoding>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Encoding \
		System.Security.Cryptography.OpenSsl>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.OpenSsl \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates \
		System.Security.Claims>=1.0:${PORTSDIR}/dotnet/System.Security.Claims \
		System.Security.Principal>=1.0:${PORTSDIR}/dotnet/System.Security.Principal

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Net/SecurityContextTokenHandle.cs

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Encoding.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.OpenSsl.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.X509Certificates.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Claims.dll

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Net/Shims/TraceSource.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/LoggingHash.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/GlobalLog.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/EventSourceLogging.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/NetEventSource.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/SecurityEventSource.cs \
			${WRKSRC}/src/Common/src/System/Net/InternalException.cs \
			${WRKSRC}/src/Common/src/System/Net/DebugSafeHandle.cs \
			${WRKSRC}/src/Common/src/System/Net/DebugCriticalHandleMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/System/Net/DebugCriticalHandleZeroOrMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.cs \
			${WRKSRC}/src/Common/src/System/Net/ExceptionCheck.cs \
			${WRKSRC}/src/Common/src/System/Net/IntPtrHelper.cs \
			${WRKSRC}/src/Common/src/System/Net/LazyAsyncResult.cs \
			${WRKSRC}/src/Common/src/System/Net/UriScheme.cs \
			${WRKSRC}/src/Common/src/System/Net/SecurityProtocol.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeDeleteContext.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeFreeNegoCredentials.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeDeleteNegoContext.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeFreeContextBufferChannelBinding.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeFreeCredentials.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeFreeCertContext.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeDeleteSslContext.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/Unix/SafeFreeSslCredentials.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/CriticalHandleMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/CriticalHandleZeroOrMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/System/NotImplemented.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHandleZeroOrMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/System/IO/StreamApmExtensions.cs \
			${WRKSRC}/src/Common/src/System/Threading/Tasks/TaskToApm.cs \
			${WRKSRC}/src/Common/src/System/IO/Error.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/CertificateValidation.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/StreamSizes.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/SslConnectionInfo.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.OpenSsl.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509ChannelBindingHash.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.BIO.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ERR.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Crypto.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Ssl.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.SslCtx.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.SetProtocolOptions.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.SslCtxOptions.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Name.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Ext.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Stack.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509StoreCtx.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Security.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Security.Native/Interop.GssApiException.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Security.Native/Interop.GssBuffer.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/GssSafeHandles.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Security.Native/Interop.NetSecurityNative.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeX509Handles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeX509NameHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/X509ExtensionSafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeInteriorHandle.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeBioHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/Asn1SafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/Http/TlsCertificateExtensions.cs

.include <../../dotnet/coreclr/corefx.common>
