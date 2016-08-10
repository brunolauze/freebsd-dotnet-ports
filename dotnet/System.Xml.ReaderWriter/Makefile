# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Xml.ReaderWriter
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Extensions>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Extensions

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=     ${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Threading.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Threading.Tasks.Extensions.dll 

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/NotImplemented.cs \
			${WRKSRC}/src/Common/src/System/ValueTuple.cs

.include <../../dotnet/coreclr/corefx.common>
