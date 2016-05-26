# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Xml.XmlDocument
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
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Extensions>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Extensions \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter

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
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,${PORTNAME}.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME}/src -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-resource:src/${PORTNAME}/src/Resources/${PORTNAME}.Strings.resources \
			-target:library \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/Xml/Ref.cs \
			${WRKSRC}/src/Common/src/System/Xml/SecureStringHasher.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlTextWriter.cs \
			${WRKSRC}/src/Common/src/System/Xml/Base64Encoder.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlTextWriterBase64Encoder.cs \
			${WRKSRC}/src/Common/src/System/Xml/BinHexEncoder.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlConvertEx.cs \
			${WRKSRC}/src/Common/src/System/Xml/ExceptionType.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlConst.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlCharType.cs \
			${WRKSRC}/src/Common/src/System/Xml/ValidateNames.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlParsingHelper.cs \
			${WRKSRC}/src/Common/src/System/Xml/XmlNameHelper.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
