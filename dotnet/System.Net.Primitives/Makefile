# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.Primitives
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
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx
GH_TAGNAME=	master

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
	@rm -rf ${WRKSRC}/src/System.Net.Primitives/src/System/Net/IPAddressPal.Windows.cs
	@rm -rf ${WRKSRC}/src/System.Net.Primitives/src/System/Net/SocketException.Windows.cs
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,FxResources.${PORTNAME}.SR.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources \
			-define:SYSTEM_NET_PRIMITIVES_DLL \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/StringExtensions.cs \
			${WRKSRC}/src/Common/src/System/Net/ByteOrder.cs \
			${WRKSRC}/src/Common/src/System/Net/IPAddressParserStatics.cs \
			${WRKSRC}/src/Common/src/System/Net/HttpKnownHeaderNames.cs \
			${WRKSRC}/src/Common/src/System/Net/TcpValidationHelpers.cs \
			${WRKSRC}/src/Common/src/System/Net/UriScheme.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketAddress.cs \
			${WRKSRC}/src/Common/src/System/Net/NetworkInformation/HostInformation.cs \
			${WRKSRC}/src/Common/src/System/Net/Shims/TraceSource.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/LoggingHash.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/GlobalLog.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/EventSourceLogging.cs \
			${WRKSRC}/src/Common/src/System/Net/InternalException.cs \
			${WRKSRC}/src/Common/src/System/NotImplemented.cs \
			${WRKSRC}/src/Common/src/Interop/Windows/Crypt32/Interop.Alg.cs \
			${WRKSRC}/src/Common/src/Interop/Windows/SChannel/Interop.SchProtocols.cs \
			${WRKSRC}/src/Common/src/Interop/Windows/Winsock/Interop.ErrorCodes.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketAddressPal.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/NetworkInformation/HostInformationPal.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/Sockets/SocketErrorPal.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetDomainName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetHostName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetNameInfo.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.HostEntry.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.IPAddress.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SocketAddress.cs


do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
