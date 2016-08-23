# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.DependencyModel
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	Microsoft.Extensions.HashCodeCombiner.Sources>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources

NET_DEPENDS+=   System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Microsoft.DotNet.InternalAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.DotNet.InternalAbstractions \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions \
		Newtonsoft.Json>=9.0:${PORTSDIR}/dotnet/Newtonsoft.Json

GH_ACCOUNT=	dotnet
GH_PROJECT=	cli
GH_TAGNAME=	rel/1.0.0

post-patch:
	@rm -rf ${WRKSRC}/bin


DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Dynamic.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.DotNet.InternalAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.PlatformAbstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Newtonsoft.Json.dll \

DOTNET_FILES+=		${LOCALBASE}/include/dotnet/Microsoft.Extensions.HashCodeCombiner.Sources/HashCodeCombiner.cs

.include <../../dotnet/aspnet/Makefile.common>
