# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/System.Diagnostics.Debug/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Diagnostics.Debug
PORTVERSION=	1.0.0.0

DOTNET_RESOURCE_COMMAND= @cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_RESOURCES+=	${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			${WRKSRC}/src/Common/src/System/Diagnostics/Debug.Unix.cs \
			${WRKSRC}/src/Common/src/System/Diagnostics/Debug.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Dup.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FileDescriptors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FLock.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.OpenFlags.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SysLog.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs

.include <../../dotnet/coreclr/corefx.common>
