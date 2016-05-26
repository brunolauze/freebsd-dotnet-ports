# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Runtime.Extensions
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

RUN_DEPENDS+=	${NET_DEPENDS}

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx
GH_TAGNAME=	master

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
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -nowarn:0436 -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/${PORTNAME}/src/SR.cs \
			${WRKSRC}/src/${PORTNAME}/src/AssemblyInfo.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/BitConverter.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/IO/Path.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Diagnostics/Stopwatch.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Net/WebUtility.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Versioning/FrameworkName.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/LowLevelDictionary.cs \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/SafeHeapHandle.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/SafeHeapHandleCache.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/NativeBuffer.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/StringBuffer.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Diagnostics/Stopwatch.Unix.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/IO/Path.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetCwd.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetTimestamp.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MksTemps.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PathConf.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.RAND.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.Unix.cs
			

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
