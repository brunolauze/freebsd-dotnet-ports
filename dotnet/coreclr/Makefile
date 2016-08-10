# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/aspnet-sampleapp/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	coreclr
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+= bash:${PORTSDIR}/shells/bash \
		python:${PORTSDIR}/lang/python 

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	coreclr

USES=           bison compiler:c11 cpe gettext gmake iconv libtool pathfix cmake
GNU_CONFIGURE=  yes
USE_LDCONFIG=   yes

LIB_DEPENDS+=   libicudata.so:${PORTSDIR}/devel/icu \
		libunwind.so:${PORTSDIR}/devel/libunwind

CXXFLAGS+=	-DFEATURE_PAL

CONFIGURE_ENV+=	__IntermediatesDir=${WRKSRC}/bin/obj/FreeBSD.x64.${BUILD_TYPE}

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/bin
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet/bin
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet/inc
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet/gcinfo
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet/Loader
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet/Loader/NativeLibs
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@cd ${WRKSRC} && ${CONFIGURE_ENV} CPP=clang-cpp CC=clang CXX=clang++ ./build.sh x64 ${BUILD_TYPE} clang3.8 verbose skipmscorlib

BUILD_TYPE=Debug
WITH_DEBUG=	yes
DONTSTRIP=	yes

do-install:
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/System.Globalization.Native.so ${STAGEDIR}${PREFIX}/lib/dotnet/System.Globalization.Native.so
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/lib/libcoreclrpal.a ${STAGEDIR}${PREFIX}/lib/dotnet/lib/libcoreclrpal.a
	${INSTALL_PROGRAM} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/corerun ${STAGEDIR}${PREFIX}/lib/dotnet/corerun
	${INSTALL_PROGRAM} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/coreconsole ${STAGEDIR}${PREFIX}/lib/dotnet/coreconsole
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/corerror.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/corerror.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/corprof.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/corprof.h
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/hfa_simple_f32_native_cpp.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/hfa_simple_f32_native_cpp.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/hfa_simple_f64_native_cpp.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/hfa_simple_f64_native_cpp.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/hfa_nested_f32_native_cpp.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/hfa_nested_f32_native_cpp.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/hfa_nested_f64_native_cpp.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/hfa_nested_f64_native_cpp.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i0c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i0c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i1c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i1c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i3c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i3c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i5c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i5c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i6c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i6c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i7c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i7c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i8c.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i8c.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i0s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i0s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i1s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i1s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i3s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i3s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i5s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i5s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i6s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i6s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i7s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i7s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/native_i8s.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/native_i8s.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/test2.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/test2.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libStructABILib.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libStructABILib.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/mirror.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/mirror.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/jitstructtests_lib.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/jitstructtests_lib.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libForeignThreadExceptionsNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libForeignThreadExceptionsNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libNativeCallableDll.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libNativeCallableDll.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libBoolNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libBoolNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libUIntPtrNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libUIntPtrNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libMarshalBoolArrayNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libMarshalBoolArrayNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libMarshalArrayByValNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libMarshalArrayByValNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libMarshalEnumNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libMarshalEnumNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libFuncPtrAsDelegateParamNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libFuncPtrAsDelegateParamNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libSimpleStructNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libSimpleStructNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libMarshalStructAsParam.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libMarshalStructAsParam.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libBestFitMappingNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libBestFitMappingNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libRefIntNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libRefIntNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libRefCharArrayNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libRefCharArrayNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libLPSTRTestNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libLPSTRTestNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libLPTSTRTestNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libLPTSTRTestNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libFunctionPointerNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libFunctionPointerNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/bin/libIUnknownNative.so ${STAGEDIR}${PREFIX}/lib/dotnet/bin/libIUnknownNative.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/Loader/NativeLibs/FromNativePaths_lib.so ${STAGEDIR}${PREFIX}/lib/dotnet/Loader/NativeLibs/FromNativePaths_lib.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/libsos.so ${STAGEDIR}${PREFIX}/lib/dotnet/libsos.so
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/sosdocsunix.txt ${STAGEDIR}${PREFIX}/lib/dotnet/sosdocsunix.txt
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/gcinfo/gcinfoencoder.cpp ${STAGEDIR}${PREFIX}/lib/dotnet/gcinfo/gcinfoencoder.cpp
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/libclrjit.so ${STAGEDIR}${PREFIX}/lib/dotnet/libclrjit.so
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/cfi.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/cfi.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/cor.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/cor.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/cordebuginfo.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/cordebuginfo.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/coredistools.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/coredistools.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/corhdr.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/corhdr.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/corinfo.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/corinfo.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/corjit.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/corjit.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/corjithost.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/corjithost.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/opcode.def ${STAGEDIR}${PREFIX}/lib/dotnet/inc/opcode.def
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/openum.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/openum.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/gcinfoencoder.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/gcinfoencoder.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/inc/gcinfotypes.h ${STAGEDIR}${PREFIX}/lib/dotnet/inc/gcinfotypes.h
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/lib/libcorguids.a ${STAGEDIR}${PREFIX}/lib/dotnet/lib/libcorguids.a
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/libdbgshim.so ${STAGEDIR}${PREFIX}/lib/dotnet/libdbgshim.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/libmscordbi.so ${STAGEDIR}${PREFIX}/lib/dotnet/libmscordbi.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/libmscordaccore.so ${STAGEDIR}${PREFIX}/lib/dotnet/libmscordaccore.so
	${INSTALL_LIB} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/libcoreclr.so ${STAGEDIR}${PREFIX}/lib/dotnet/libcoreclr.so
	${INSTALL_PROGRAM} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/crossgen ${STAGEDIR}${PREFIX}/lib/dotnet/crossgen
	${INSTALL_PROGRAM} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/ildasm ${STAGEDIR}${PREFIX}/lib/dotnet/ildasm
	${INSTALL_PROGRAM} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/ilasm ${STAGEDIR}${PREFIX}/lib/dotnet/ilasm
	${INSTALL_DATA} ${WRKSRC}/bin/Product/FreeBSD.x64.${BUILD_TYPE}/lib/libpalrt.a ${STAGEDIR}${PREFIX}/lib/dotnet/lib/libpalrt.a
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/coreclr/Makefile.common>
