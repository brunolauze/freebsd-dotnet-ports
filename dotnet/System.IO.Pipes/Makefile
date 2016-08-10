# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.IO.Pipes
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Net.NameResolution>=1.0:${PORTSDIR}/dotnet/System.Net.NameResolution \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Net.Sockets>=1.0:${PORTSDIR}/dotnet/System.Net.Sockets \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.Handles>=1.0:${PORTSDIR}/dotnet/System.Runtime.Handles \
		System.Security.Principal>=1.0:${PORTSDIR}/dotnet/System.Security.Principal \
		System.Threading.Overlapped>=1.0:${PORTSDIR}/dotnet/System.Threading.Overlapped \
		Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Linux.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.OSX.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Win32.cs" -delete
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/Pipes/ConnectionCompletionSource.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/Pipes/PipeCompletionSource.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/Pipes/ReadWriteCompletionSource.cs

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.NameResolution.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Sockets.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Handles.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Overlapped.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Fcntl.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Fcntl.SetCloseOnExec.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FLock.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetDomainSocketSizes.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetHostName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetPeerUserName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MkDir.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.OpenFlags.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Permissions.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Poll.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Read.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Unlink.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.Pipe.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.Pipe.cs \
			${WRKSRC}/src/Common/src/System/IO/PersistedFiles.Names.Unix.cs \
			${WRKSRC}/src/Common/src/System/Threading/Tasks/ForceAsyncAwaiter.cs

.include <../../dotnet/coreclr/corefx.common>
