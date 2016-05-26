# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Newtonsoft.Json
PORTVERSION=	8.0.3.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		Microsoft.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CSharp \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.ComponentModel.TypeConverter>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.TypeConverter \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Runtime.Handles>=1.0:${PORTSDIR}/dotnet/System.Runtime.Handles \
		System.Runtime.Numerics>=1.0:${PORTSDIR}/dotnet/System.Runtime.Numerics \
		System.Runtime.Serialization.Primitives>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Primitives \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument \
		System.Xml.XmlDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlDocument

USE_GITHUB=	yes
GH_ACCOUNT=	JamesNK
GH_PROJECT=	Newtonsoft.Json

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
	@cd ${WRKSRC} && ${FIND} Src/${PORTNAME} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:Src/Newtonsoft.Json/Dynamic.snk \
			-out:${WRKSRC}/bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.CSharp.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ComponentModel.TypeConverter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Dynamic.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Handles.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Numerics.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Serialization.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XmlDocument.dll \
			-target:library \
			-define:DOTNET \
			-warn:4

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
