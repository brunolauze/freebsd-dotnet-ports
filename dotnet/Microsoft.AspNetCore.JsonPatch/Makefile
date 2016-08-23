# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.JsonPatch
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Newtonsoft.Json>=8.0:${PORTSDIR}/dotnet/Newtonsoft.Json

GH_PROJECT=	JsonPatch

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Specialized.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Dynamic.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Newtonsoft.Json.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/${PORTNAME}.Resources.resources

OLD_LISTING+=		src/Microsoft.AspNetCore.JsonPatch/Operations/OperationBase.cs \
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

.include <../../dotnet/aspnet/Makefile.common>


