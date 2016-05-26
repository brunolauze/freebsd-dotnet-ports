# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.NameResolution
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
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.Compression>=1.0:${PORTSDIR}/dotnet/System.IO.Compression \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions

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
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/netcore50
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,${PORTNAME}.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.DiagnosticSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.Compression.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/${PORTNAME}.Strings.resources \
			-define:FEATURE_CORECLR \
			-define:SYSTEM_NET_SOCKETS_DLL \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/Net/Shims/TraceSource.cs \
			${WRKSRC}/src/Common/src/System/Net/Internals/IPAddressExtensions.cs \
			${WRKSRC}/src/Common/src/System/Net/Internals/SocketExceptionFactory.cs \
			${WRKSRC}/src/Common/src/System/Net/Internals/SocketExceptionFactory.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Interop.CheckedAccess.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/LoggingHash.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/GlobalLog.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/EventSourceLogging.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/NetEventSource.cs \
			${WRKSRC}/src/Common/src/System/Net/InternalException.cs \
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.cs \
			${WRKSRC}/src/Common/src/System/Net/LazyAsyncResult.cs \
			${WRKSRC}/src/Common/src/System/Net/Sockets/ProtocolType.cs \
			${WRKSRC}/src/Common/src/System/Net/Sockets/SocketType.cs \
			${WRKSRC}/src/Common/src/System/Net/IPEndPointStatics.cs \
			${WRKSRC}/src/Common/src/System/Net/ByteOrder.cs \
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/InteropIPAddressExtensions.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketAddressPal.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketProtocolSupportPal.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Interop.CheckedAccess.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetHostName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetNameInfo.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.HostEntry.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.IPAddress.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Socket.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SocketAddress.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
