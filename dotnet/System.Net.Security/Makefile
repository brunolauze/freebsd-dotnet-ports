# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.Security
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
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

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx

USES=           dotnet

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Net/SecurityContextTokenHandle.cs
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Encoding.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.OpenSsl.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.X509Certificates.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Claims.dll \
			-target:library \
			-define:NETSTANDARD1_3 \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/Net/Shims/TraceSource.cs \
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
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.Unix.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
