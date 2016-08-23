# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Newtonsoft.Json
PORTVERSION=	9.0.1.0

NET_DEPENDS+=	Microsoft.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CSharp \
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
DOTNET_SOURCE_PATH=${WRKSRC}/Src/${PORTNAME}
DOTNET_KEYFILE=	Src/${PORTNAME}/Dynamic.snk

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.TypeConverter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Dynamic.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Handles.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Numerics.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Serialization.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XmlDocument.dll

DOTNET_DEFINES+=	-define:DOTNET

.include <../../dotnet/coreclr/Makefile.common>
