# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Diagnostics.Debug
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= p5-XML-Parser>=0:${PORTSDIR}/textproc/p5-XML-Parser \
                bash:${PORTSDIR}/shells/bash \
		mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib

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
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,FxResources.System.Diagnostics.Debug.SR.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.System.Diagnostics.Debug.SR.resources \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
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
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs \

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>