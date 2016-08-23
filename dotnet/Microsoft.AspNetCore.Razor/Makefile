# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Razor
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources

NET_DEPENDS+=   System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Dataflow>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Dataflow \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms

GH_PROJECT=	Razor

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} CommonResources.resx,${PORTNAME}.CommonResources.resources && cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} RazorResources.resx,${PORTNAME}.RazorResources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.Dataflow.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.CommonResources.resources \
			-resource:src/${PORTNAME}/${PORTNAME}.RazorResources.resources \

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs

.include <../../dotnet/aspnet/Makefile.common>


