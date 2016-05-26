# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.JsonPatch
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Newtonsoft.Json>=8.0:${PORTSDIR}/dotnet/Newtonsoft.Json

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	JsonPatch

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
	@cd ${WRKSRC}/src/${PORTNAME} && resgen /useSourcePath /compile Resources.resx,${PORTNAME}.Resources.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Specialized.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Dynamic.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/Newtonsoft.Json.dll \
			-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources \
			-target:library \
			-warn:4 \
			src/Microsoft.AspNetCore.JsonPatch/Operations/OperationBase.cs \
			src/Microsoft.AspNetCore.JsonPatch/Operations/Operation.cs \
			src/Microsoft.AspNetCore.JsonPatch/Operations/OperationType.cs \
			src/Microsoft.AspNetCore.JsonPatch/Operations/OperationOfT.cs \
			src/Microsoft.AspNetCore.JsonPatch/JsonPatchDocumentOfT.cs \
			src/Microsoft.AspNetCore.JsonPatch/Adapters/IObjectAdapter.cs \
			src/Microsoft.AspNetCore.JsonPatch/Adapters/ObjectAdapter.cs \
			src/Microsoft.AspNetCore.JsonPatch/JsonPatchError.cs \
			src/Microsoft.AspNetCore.JsonPatch/Properties/AssemblyInfo.cs \
			src/Microsoft.AspNetCore.JsonPatch/Properties/Resources.Designer.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/GetValueResult.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/ActualPropertyPathResult.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/ExpandoObjectDictionaryExtensions.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/RemovedPropertyTypeResult.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/PathHelpers.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/ConversionResult.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/ExpressionHelpers.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/JsonPatchProperty.cs \
			src/Microsoft.AspNetCore.JsonPatch/Helpers/ObjectTreeAnalyisResult.cs \
			src/Microsoft.AspNetCore.JsonPatch/Exceptions/JsonPatchException.cs \
			src/Microsoft.AspNetCore.JsonPatch/Converters/TypedJsonPatchDocumentConverter.cs \
			src/Microsoft.AspNetCore.JsonPatch/Converters/JsonPatchDocumentConverter.cs \
			src/Microsoft.AspNetCore.JsonPatch/IJsonPatchDocument.cs \
			src/Microsoft.AspNetCore.JsonPatch/JsonPatchDocument.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


