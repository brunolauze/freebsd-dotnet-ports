# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.StackTrace.Sources
PORTVERSION=	1.0.0.0

GH_PROJECT=	Common

build:
	@echo "Source files"

do-install:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/include
	@mkdir -p ${STAGEDIR}${PREFIX}/include/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/StackFrameInfo.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/StackFrameInfo.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/PortablePdbReader.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/PortablePdbReader.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/StackTraceHelper.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/StackTraceHelper.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/ParameterDisplayInfo.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/ParameterDisplayInfo.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/MethodDisplayInfo.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/MethodDisplayInfo.cs
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/aspnet/Makefile.common>
