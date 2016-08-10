# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Xml.XPath
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Extensions>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Extensions \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Private.CoreLib.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			
DOTNET_RESOURCES+=	${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=	${WRKSRC}/src/Common/src/System/Xml/Base64Decoder.cs \
		${WRKSRC}/src/Common/src/System/Xml/Base64Encoder.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlRawWriterBase64Encoder.cs \
		${WRKSRC}/src/Common/src/System/Xml/BinHexDecoder.cs \
		${WRKSRC}/src/Common/src/System/Xml/Bits.cs \
		${WRKSRC}/src/Common/src/System/Xml/ValidateNames.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlCharType.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlConvertEx.cs \
		${WRKSRC}/src/Common/src/System/Xml/ExceptionType.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlReaderExtensions.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlWriterExtensions.cs \
		${WRKSRC}/src/Common/src/System/Xml/IncrementalReadDecoders.cs \
		${WRKSRC}/src/Common/src/System/Xml/ReadContentAsBinaryHelper.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlRawWriter.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlStandalone.cs \
		${WRKSRC}/src/Common/src/System/Xml/XmlConst.cs \
		${WRKSRC}/src/Common/src/System/Xml/Schema/XmlUntypedConverter.cs \
		${WRKSRC}/src/Common/src/System/Xml/Schema/XsdDateTime.cs \
		${WRKSRC}/src/Common/src/System/Xml/XPathNavigatorEx.cs \
		${WRKSRC}/src/Common/src/System/NotImplemented.cs

.include <../../dotnet/coreclr/corefx.common>
