# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	NuGet.DependencyResolver
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
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Dynamic.Runtime>=1.0:${PORTSDIR}/dotnet/System.Dynamic.Runtime \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		Newtonsoft.Json>=8.0:${PORTSDIR}/dotnet/Newtonsoft.Json \
		NuGet.Common>=1.0:${PORTSDIR}/dotnet/NuGet.Common \
		NuGet.Configuration>=1.0:${PORTSDIR}/dotnet/NuGet.Configuration \
		NuGet.DependencyResolver.Core>=1.0:${PORTSDIR}/dotnet/NuGet.DependencyResolver.Core \
		NuGet.LibraryModel>=1.0:${PORTSDIR}/dotnet/NuGet.LibraryModel \
		NuGet.Packaging.Core.Types>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging.Core.Types \
		NuGet.Packaging.Core>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging.Core \
		NuGet.Packaging>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging \
		NuGet.Protocol.Core.Types>=1.0:${PORTSDIR}/dotnet/NuGet.Protocol.Core.Types \
		NuGet.Protocol.Core.v3>=1.0:${PORTSDIR}/dotnet/NuGet.Protocol.Core.v3 \
		NuGet.Repositories>=1.0:${PORTSDIR}/dotnet/NuGet.Repositories \
		NuGet.RuntimeModel>=1.0:${PORTSDIR}/dotnet/NuGet.RuntimeModel \
		NuGet.Frameworks>=1.0:${PORTSDIR}/dotnet/NuGet.Frameworks \
		NuGet.Versioning>=1.0:${PORTSDIR}/dotnet/NuGet.Versioning

USE_GITHUB=	yes
GH_ACCOUNT=	NuGet
GH_PROJECT=	NuGet.Client

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
	@cd ${WRKSRC} && ${FIND} src/NuGet.Core/${PORTNAME} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Dynamic.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/Newtonsoft.Json.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Common.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Configuration.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.DependencyResolver.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.LibraryModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Protocol.Core.Types.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Protocol.Core.v3.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.Core.Types.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Repositories.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.RuntimeModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Frameworks.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Versioning.dll \
			-target:library \
			-warn:4 \
			-define:IS_CORECLR \
			Shared/CommonAssemblyInfo.cs \
			Shared/HashCodeCombiner.cs \
			Shared/SharedExtensions.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


