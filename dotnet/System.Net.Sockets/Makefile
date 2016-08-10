# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.Sockets
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.Compression>=1.0:${PORTSDIR}/dotnet/System.IO.Compression \
		System.Net.NameResolution>=1.0:${PORTSDIR}/dotnet/System.Net.NameResolution \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.Handles>=1.0:${PORTSDIR}/dotnet/System.Runtime.Handles

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*Winsock*.cs" -delete
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/netcore50

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.Compression.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.NameResolution.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Handles.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources


DOTNET_DEFINES+=	-define:FEATURE_CORECLR \
			-define:SYSTEM_NET_SOCKETS_DLL

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Net/Logging/GlobalLog.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/EventSourceLogging.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/LoggingHash.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/SocketsEventSource.cs \
			${WRKSRC}/src/Common/src/System/Net/Logging/NetEventSource.cs \
			${WRKSRC}/src/Common/src/System/Net/InternalException.cs \
			${WRKSRC}/src/Common/src/System/Net/DebugSafeHandle.cs \
			${WRKSRC}/src/Common/src/System/Net/DebugSafeHandleMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.cs \
			${WRKSRC}/src/Common/src/System/Net/LazyAsyncResult.cs \
			${WRKSRC}/src/Common/src/System/Net/ByteOrder.cs \
			${WRKSRC}/src/Common/src/System/Net/IPEndPointStatics.cs \
			${WRKSRC}/src/Common/src/System/Net/IPAddressParserStatics.cs \
			${WRKSRC}/src/Common/src/System/Net/ExceptionCheck.cs \
			${WRKSRC}/src/Common/src/System/Net/RangeValidationHelpers.cs \
			${WRKSRC}/src/Common/src/System/Net/SafeCloseSocket.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketAddress.cs \
			${WRKSRC}/src/Common/src/System/Net/TcpValidationHelpers.cs \
			${WRKSRC}/src/Common/src/System/Net/NetworkInformation/StartIPOptions.cs \
			${WRKSRC}/src/Common/src/System/Net/Internals/IPEndPointExtensions.cs \
			${WRKSRC}/src/Common/src/System/Net/Internals/SocketExceptionFactory.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHandleMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeHandleZeroOrMinusOneIsInvalid.cs \
			${WRKSRC}/src/Common/src/System/Threading/Tasks/TaskToApm.cs \
			${WRKSRC}/src/Common/src/System/Net/ContextAwareResult.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/InteropIPAddressExtensions.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/SafeCloseSocket.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketAddressPal.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/SocketProtocolSupportPal.Unix.cs \
			${WRKSRC}/src/Common/src/System/Net/Sockets/SocketErrorPal.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Interop.CheckedAccess.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Accept.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Bind.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Connect.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Fcntl.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetBytesAvailable.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetPeerName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetSocketErrorOption.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetSockName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetSockOpt.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.IPAddress.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.IPPacketInformation.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.LingerOption.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SetSendTimeout.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SetReceiveTimeout.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Listen.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MemSet.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MessageHeader.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MulticastOption.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Poll.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PlatformSocketSupport.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ReceiveMessage.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SendMessage.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SetSockOpt.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Shutdown.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Socket.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SocketEvent.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SocketAddress.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.cs

.include <../../dotnet/coreclr/corefx.common>
