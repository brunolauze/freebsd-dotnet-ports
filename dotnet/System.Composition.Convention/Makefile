# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Composition.Convention
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.Composition.AttributedModel>=1.0:${PORTSDIR}/dotnet/System.Composition.AttributedModel \
		System.Diagnostics.Contracts>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Contracts \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/src && ${DOTNET_RESGEN} Strings.resx,${PORTNAME}.Strings.resources && \
			cd ${WRKSRC}/src/Common/src/Microsoft/Internal && ${DOTNET_RESGEN} CommonStrings.resx,Microsoft.Internal.CommonStrings.resources

DOTNET_REFERENCES+=	-reference:${LOCALBASE}/lib/dotnet/System.Composition.AttributedModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Contracts.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Tools.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.Expressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Threading.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/src/${PORTNAME}.Strings.resources \
			${DOTNET_RES}:src/Common/src/Microsoft/Internal/Microsoft.Internal.CommonStrings.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/Microsoft/Internal/EmptyArray.cs \
			${WRKSRC}/src/Common/src/Microsoft/Internal/Assumes.cs \
			${WRKSRC}/src/Common/src/Microsoft/Internal/Assumes.InternalErrorException.cs \
			${WRKSRC}/src/Common/src/Microsoft/Internal/Requires.cs \
			${WRKSRC}/src/Common/src/Microsoft/Internal/CommonStrings.Designer.cs

.include <../../dotnet/coreclr/corefx.common>
