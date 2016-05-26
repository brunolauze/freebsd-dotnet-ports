# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.Http
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.Compression>=1.0:${PORTSDIR}/dotnet/System.IO.Compression \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.Handles>=1.0:${PORTSDIR}/dotnet/System.Runtime.Handles \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.Encoding>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Encoding \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.OpenSsl>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.OpenSsl \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates

RUN_DEPENDS+=	${NET_DEPENDS}

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx
GH_TAGNAME=	master

USES=           dotnet
GNU_CONFIGURE=  yes
USE_LDCONFIG=   yes

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
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/netcore50
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.DiagnosticSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.Compression.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Handles.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Encoding.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.OpenSsl.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.X509Certificates.dll \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/Net/Logging/LoggingHash.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/HttpEventSource.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/NetEventSource.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.OpenFlags.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Poll.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PrintF.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Read.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.CURLcode.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.Easy.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.Multi.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.SList.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.VersionInfo.cs \
			${WRKSRC}/src/Common/src/System/CharArrayHelpers.cs \
			${WRKSRC}/src/Common/src/System/StringExtensions.cs \
			${WRKSRC}/src/Common/src/System/Net/HttpKnownHeaderNames.cs \
			${WRKSRC}/src/Common/src/System/Net/HttpKnownHeaderNames.TryGetHeaderName.cs \
			${WRKSRC}/src/Common/src/System/Net/HttpStatusDescription.cs \
			${WRKSRC}/src/Common/src/System/Net/HttpVersion.cs \
			${WRKSRC}/src/Common/src/System/Net/Http/HttpHandlerDefaults.cs \
			${WRKSRC}/src/Common/src/System/Net/Http/HttpHandlerDiagnosticListenerExtensions.cs \
			${WRKSRC}/src/Common/src/System/Net/Http/HttpHandlerLoggingStrings.cs \
			${WRKSRC}/src/Common/src/System/Net/Http/TlsCertificateExtensions.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509ChannelBindingHash.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.BIO.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ERR.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Crypto.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Ssl.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.SslCtx.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Name.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Ext.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Stack.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509StoreCtx.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Security.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeX509Handles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeX509NameHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/X509ExtensionSafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeInteriorHandle.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeBioHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/Asn1SafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/Security/CertificateValidation.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.SetProtocolOptions.cs \
			${WRKSRC}/src/Common/src/System/Net/SecurityProtocol.cs \
			${WRKSRC}/src/Common/src/System/StrongToWeakReference.cs
do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
