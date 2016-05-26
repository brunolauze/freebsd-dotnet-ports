# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.IO.Pipes
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
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Linux.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.OSX.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Win32.cs" -delete
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/System/IO/Pipes/ConnectionCompletionSource.cs
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/System/IO/Pipes/PipeCompletionSource.cs
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/System/IO/Pipes/ReadWriteCompletionSource.cs
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,${PORTNAME}.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Tools.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.NameResolution.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Sockets.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Handles.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Overlapped.dll \
			-resource:src/${PORTNAME}/src/Resources/${PORTNAME}.Strings.resources \
			-target:library \
			-nowarn:0436 \
			-warn:4 \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
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

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
