# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.Primitives
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions

post-patch:
	@${RM} ${WRKSRC}/src/System.Net.Primitives/src/System/Net/IPAddressPal.Windows.cs
	@${RM} ${WRKSRC}/src/System.Net.Primitives/src/System/Net/SocketException.Windows.cs

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_DEFINES+=	-define:SYSTEM_NET_PRIMITIVES_DLL \

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
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

.include <../../dotnet/coreclr/corefx.common>
