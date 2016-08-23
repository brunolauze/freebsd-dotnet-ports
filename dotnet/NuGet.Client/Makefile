# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	NuGet.Client
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.InteropServices.RuntimeInformation>=1.0:${PORTSDIR}/dotnet/System.Runtime.InteropServices.RuntimeInformation \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		NuGet.Common>=1.0:${PORTSDIR}/dotnet/NuGet.Common \
		NuGet.Frameworks>=1.0:${PORTSDIR}/dotnet/NuGet.Frameworks \
		NuGet.Versioning>=1.0:${PORTSDIR}/dotnet/NuGet.Versioning \
		NuGet.Packaging.Core.Types>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging.Core.Types \
		NuGet.Packaging.Core>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging.Core \
		NuGet.Packaging>=1.0:${PORTSDIR}/dotnet/NuGet.Packaging \
		NuGet.Repositories>=1.0:${PORTSDIR}/dotnet/NuGet.Repositories \
		NuGet.RuntimeModel>=1.0:${PORTSDIR}/dotnet/NuGet.RuntimeModel \
		NuGet.ContentModel>=1.0:${PORTSDIR}/dotnet/NuGet.ContentModel

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
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.CoreLib.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.InteropServices.RuntimeInformation.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Algorithms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Frameworks.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Versioning.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.Core.Types.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Packaging.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.Repositories.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.RuntimeModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/NuGet.ContentModel.dll \
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


