# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	NuGet.Commands
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
		System.Diagnostics.Process>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Process \
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
		NuGet.Client>=1.0:${PORTSDIR}/dotnet/NuGet.Client \
		NuGet.Configuration>=1.0:${PORTSDIR}/dotnet/NuGet.Configuration \
		NuGet.ContentModel>=1.0:${PORTSDIR}/dotnet/NuGet.ContentModel \
		NuGet.DependencyResolver.Core>=1.0:${PORTSDIR}/dotnet/NuGet.DependencyResolver.Core \
		NuGet.DependencyResolver>=1.0:${PORTSDIR}/dotnet/NuGet.DependencyResolver \
		NuGet.LibraryModel>=1.0:${PORTSDIR}/dotnet/NuGet.LibraryModel \
		NuGet.Protocol.Core.Types>=1.0:${PORTSDIR}/dotnet/NuGet.Protocol.Core.Types \
		NuGet.Protocol.Core.v3>=1.0:${PORTSDIR}/dotnet/NuGet.Protocol.Core.v3 \
		NuGet.Repositories>=1.0:${PORTSDIR}/dotnet/NuGet.Repositories \
		NuGet.RuntimeModel>=1.0:${PORTSDIR}/dotnet/NuGet.RuntimeModel \
		NuGet.ProjectModel>=1.0:${PORTSDIR}/dotnet/NuGet.ProjectModel \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.FileSystemGlobbing>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileSystemGlobbing \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions

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
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Process.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.Compression.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Dynamic.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.ObjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.InteropServices.RuntimeInformation.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.XDocument.dll \
			-reference:${LOCALBASE}/lib/dotnet/Newtonsoft.Json.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Common.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Frameworks.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Versioning.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.ProjectModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.LibraryModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.DependencyResolver.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.DependencyResolver.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.ContentModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Client.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Protocol.Core.Types.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Protocol.Core.v3.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Repositories.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.Core.Types.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Packaging.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.Configuration.dll \
			-reference:${LOCALBASE}/lib/dotnet/NuGet.RuntimeModel.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileSystemGlobbing.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Extensions.FileProviders.Abstractions.dll \
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

