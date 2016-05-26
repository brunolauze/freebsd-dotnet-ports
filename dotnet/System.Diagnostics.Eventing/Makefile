# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/System.Diagnostics.Eventing/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Diagnostics.Eventing
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com
MASTER_SITES=	file:///usr/ports/dotnet/distfiles/

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Process>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Process \
		System.Diagnostics.TextWriterTraceListener>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.TextWriterTraceListener \
		System.Diagnostics.TraceSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.TraceSource \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.FileSystem.DriveInfo>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem.DriveInfo \
		System.IO.MemoryMappedFiles>=1.0:${PORTSDIR}/dotnet/System.IO.MemoryMappedFiles \
		System.IO.Pipes>=1.0:${PORTSDIR}/dotnet/System.IO.Pipes \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Overlapped>=1.0:${PORTSDIR}/dotnet/System.Threading.Overlapped

USES=           

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
	@cd ${WRKSRC} && ${FIND} ${WRKSRC} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${WRKSRC}/mono.snk \
			-out:${WRKSRC}/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Process.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.TraceSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.TextWriterTraceListener.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.DriveInfo.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.MemoryMappedFiles.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.Pipes.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Overlapped.dll \
			-target:library \
			-warn:4

do-install:
	@${INSTALL_DATA} ${WRKSRC}/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:    ${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


