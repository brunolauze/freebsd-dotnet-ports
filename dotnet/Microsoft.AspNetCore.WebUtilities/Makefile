# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.WebUtilities/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.WebUtilities
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+= Microsoft.Extensions.WebEncoders.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.WebEncoders.Sources

NET_DEPENDS+=   System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Data.Common>=1.0:${PORTSDIR}/dotnet/System.Data.Common \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web

GH_PROJECT=	HttpAbstractions

DOTNET_RESOURCE_COMMAND=cp ${LOCALBASE}/include/dotnet/Microsoft.Extensions.WebEncoders.Sources/EncoderResources.resx ${WRKSRC}/src/${PORTNAME}/EncoderResources.resx && \
			cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} EncoderResources.resx,${PORTNAME}.EncoderResources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Buffers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Data.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

DOTNET_DEFINES+=	-define:WebEncoders_In_WebUtilities

DOTNET_RESOURCES+=      ${DOTNET_RES}:src/${PORTNAME}/${PORTNAME}.EncoderResources.resources

DOTNET_FILES+=          ${LOCALBASE}/include/dotnet/Microsoft.Extensions.WebEncoders.Sources/WebEncoders.cs \
			${LOCALBASE}/include/dotnet/Microsoft.Extensions.WebEncoders.Sources/Properties/EncoderResources.Designer.cs

.include <../../dotnet/aspnet/Makefile.common>
