# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Console
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug

post-patch:
	@${RM} ${WRKSRC}/src/System.Console/src/System/ConsolePal.Windows.cs
	@${RM} ${WRKSRC}/src/System.Console/src/System/ConsolePal.WinRT.cs

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources


DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources


DOTNET_FILES+=		${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			${WRKSRC}/src/Common/src/System/IO/PersistedFiles.Unix.cs \
			${WRKSRC}/src/Common/src/System/IO/PersistedFiles.Names.Unix.cs \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/Text/ConsoleEncoding.cs \
			${WRKSRC}/src/Common/src/System/Text/EncodingHelper.Unix.cs \
			${WRKSRC}/src/Common/src/System/Text/StringOrCharArray.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Dup.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FileDescriptors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FLock.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.IsATty.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.LSeek.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.OpenFlags.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetEUid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetPwUid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.RegisterForCtrlC.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SNPrintF.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SetSignalForBreak.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Read.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetWindowWidth.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetControlCharacters.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.InitializeConsole.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ReadStdinUnbuffered.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.StdinReady.cs

.include <../../dotnet/coreclr/corefx.common>
