# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Razor.Runtime
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources \
		Microsoft.Extensions.ClosedGenericMatcher.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources \
		Microsoft.Extensions.CopyOnWriteDictionary.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources

NET_DEPENDS+=   System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.ComponentModel.Primitives>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.Primitives \
		System.ComponentModel.TypeConverter>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.TypeConverter \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		Microsoft.AspNetCore.Razor>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Razor \
		Microsoft.AspNetCore.Html.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Html.Abstractions \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web \
		System.Xml.ReaderWriter>=1.0:${PORTSDIR}/dotnet/System.Xml.ReaderWriter \
		System.Xml.XDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XDocument

GH_PROJECT=	Razor

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.TypeConverter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Razor.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Html.Abstractions.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.ClosedGenericMatcher.Sources/ClosedGenericMatcher.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources/CopyOnWriteDictionary.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.CopyOnWriteDictionary.Sources/CopyOnWriteDictionaryHolder.cs

.include <../../dotnet/aspnet/Makefile.common>
