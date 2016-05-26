# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Security.Cryptography.X509Certificates
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.FileSystem.Watcher>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem.Watcher \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.Numerics>=1.0:${PORTSDIR}/dotnet/System.Runtime.Numerics \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Encoding>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Encoding \
		System.Security.Cryptography.Csp>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Csp \
		System.Security.Cryptography.OpenSsl>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.OpenSsl

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
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/Internal/Cryptography/Pal.Windows
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,FxResources.${PORTNAME}.SR.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.Watcher.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Numerics.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Encoding.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Csp.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.OpenSsl.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources \
			-target:library \
			-nowarn:0436 \
			-warn:4 \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHandleCache.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Permissions.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.GetIntegerBytes.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ASN1.Print.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Bignum.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.BIO.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Encode.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.ERR.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Pkcs12.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Pkcs7.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Rsa.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Ext.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Name.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509NameEntry.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509Stack.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.X509StoreCtx.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetEUid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetPwUid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FChMod.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.CURLcode.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Net.Http.Native/Interop.Easy.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Crypto.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/Asn1SafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeBignumHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeBioHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeInteriorHandle.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafePkcs12Handle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafePkcs7Handle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeRsaHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeX509Handles.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeX509NameHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/X509ExtensionSafeHandles.Unix.cs \
			${WRKSRC}/src/Common/src/System/IO/PersistedFiles.Unix.cs \
			${WRKSRC}/src/Common/src/System/IO/PersistedFiles.Names.Unix.cs \
			${WRKSRC}/src/Common/src/System/Security/Cryptography/DerEncoder.cs \
			${WRKSRC}/src/Common/src/System/Security/Cryptography/DerSequenceReader.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
