# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Diagnostics.Process
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.Handles>=1.0:${PORTSDIR}/dotnet/System.Runtime.Handles \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Linux.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.OSX.cs" -delete
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Diagnostics/PerformanceCounterLib.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src//Microsoft/Win32/SafeHandles/SafeThreadHandle.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src//Microsoft/Win32/SafeHandles/SafeTokenHandle.cs

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Win32.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.NonGeneric.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Handles.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.dll

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/IO/StringParser.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetHostName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SysConf.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ForkAndExecProcess.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetLine.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetPid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetSetPriority.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetSid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Kill.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ReadLink.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ResourceLimits.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PathConf.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.POpen.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.WaitPid.cs
				
.include <../../dotnet/coreclr/corefx.common>
