# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Diagnostics.Process
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
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

RUN_DEPENDS+=	${NET_DEPENDS}

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx
GH_TAGNAME=	master

USES=           dotnet
GNU_CONFIGURE=  yes
USE_LDCONFIG=   yes

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
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Linux.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.OSX.cs" -delete
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src/System/Diagnostics/PerformanceCounterLib.cs
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src//Microsoft/Win32/SafeHandles/SafeThreadHandle.cs
	@rm -rf ${WRKSRC}/src/${PORTNAME}/src//Microsoft/Win32/SafeHandles/SafeTokenHandle.cs
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.NonGeneric.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Tools.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Handles.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.dll \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/IO/StringParser.cs \
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
				

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
