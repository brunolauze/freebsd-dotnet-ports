# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.NameResolution
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
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

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/netcore50

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.Compression.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_DEFINES+=	-define:FEATURE_CORECLR \
			-define:SYSTEM_NET_SOCKETS_DLL

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Net/Shims/TraceSource.cs \
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

.include <../../dotnet/coreclr/corefx.common>
