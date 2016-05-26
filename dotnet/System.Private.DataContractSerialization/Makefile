# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Private.DataContractSerialization
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
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Numerics>=1.0:${PORTSDIR}/dotnet/System.Runtime.Numerics \
		System.Runtime.Serialization.Primitives>=1.0:${PORTSDIR}/dotnet/System.Runtime.Serialization.Primitives \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XmlDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlDocument \
		System.Xml.XmlSerializer>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlSerializer \

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
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/SerializationException.cs
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Desktop.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*.Windows.cs" -delete
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,FxResources.${PORTNAME}.SR.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Numerics.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Serialization.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XmlDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XmlSerializer.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources \
			-target:library \
			-define:NETSTANDARD1_3 \
			-warn:4 \
			${WRKSRC}/src/Common/src/System/HResults.cs \
			${WRKSRC}/src/Common/src/System/NotImplemented.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/SR.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Attributes.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/CodeGenerator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/ClassDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/CollectionDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DateTimeOffsetAdapter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DiagnosticUtility.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DictionaryGlobals.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataContractResolver.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataContractSerializer.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataContractSerializerSettings.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataMember.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/EnumDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Globals.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/GenericParameterDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/HybridObjectCache.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/ObjectToIdCache.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/ObjectReferenceStack.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/PrimitiveDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/SchemaExporter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/ScopedKnownTypes.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlFormatGeneratorStatics.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlFormatReaderGenerator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlFormatWriterGenerator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlObjectSerializer.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlObjectSerializerContext.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlObjectSerializerWriteContext.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlObjectSerializerReadContext.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlReaderDelegator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlSerializableReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlSerializableWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlWriterDelegator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/SerializationMode.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/SpecialTypeDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/TypeCode.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/ExceptionDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/KnownTypeDataContractResolver.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlObjectSerializerReadContextComplex.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlObjectSerializerWriteContextComplex.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/BitFlagsGenerator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataContractSurrogateCaller.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/DataContractSerializerExtensions.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/XmlSerializableServices.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/ArrayHelper.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/BytesWithOffset.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlDictionaryAsyncCheckWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/IStreamProvider.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/IXmlDictionary.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/PrefixHandle.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/StringHandle.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/UniqueId.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/ValueHandle.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBaseReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBaseWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBinaryNodeType.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBinaryReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBinaryReaderSession.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBinaryWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBinaryWriterSession.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlBufferReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlConverter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlDictionary.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlDictionaryWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlDictionaryReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlDictionaryReaderQuotas.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlDictionaryString.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlExceptionHelper.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlNodeReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlNodeWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlStreamNodeWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlSchemaSet.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlUTF8TextReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/XmlUTF8TextWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Xml/EncodingStreamWrapper.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Text/Base64Encoding.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Text/SurrogateChar.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Text/BinHexEncoding.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/DataContractJsonSerializer.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonByteArrayDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonClassDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonCollectionDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonEnumDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonFormatWriterGenerator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonFormatReaderGenerator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonObjectDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonQNameDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonReaderDelegator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonWriterDelegator.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonStringDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonUriDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonXmlDataContract.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonGlobals.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/XmlObjectSerializerReadContextComplexJson.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/XmlObjectSerializerWriteContextComplexJson.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/DateTimeFormat.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/EmitTypeInformation.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/DataContractJsonSerializerSettings.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/XmlJsonReader.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/XmlJsonWriter.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonReaderWriterFactory.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonNodeType.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/IXmlJsonReaderInitializer.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/IXmlJsonWriterInitializer.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/ByteArrayHelperWithString.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonEncodingStreamWrapper.cs \
			${WRKSRC}/src/System.Private.DataContractSerialization/src/System/Runtime/Serialization/Json/JsonFormatGeneratorStatics.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
