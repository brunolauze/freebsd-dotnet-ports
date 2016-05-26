# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.DependencyInjection
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=   ${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions

USE_GITHUB=	yes
GH_ACCOUNT=	aspnet
GH_PROJECT=	DependencyInjection

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
	@cd ${WRKSRC}/src/Microsoft.Extensions.DependencyInjection && resgen /useSourcePath /compile Resources.resx,Microsoft.Extensions.DependencyInjection.Resources.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ \
			-keyfile:./tools/Key.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:/usr/local/lib/dotnet/System.Private.CoreLib.dll \
			-reference:/usr/local/lib/dotnet/System.Collections.dll \
			-reference:/usr/local/lib/dotnet/System.Collections.Concurrent.dll \
			-reference:/usr/local/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:/usr/local/lib/dotnet/System.Linq.dll \
			-reference:/usr/local/lib/dotnet/System.Linq.Expressions.dll \
			-reference:/usr/local/lib/dotnet/System.Runtime.dll \
			-reference:/usr/local/lib/dotnet/${PORTNAME}.Abstractions.dll \
			-target:library \
			-warn:4 \
			src/Microsoft.Extensions.DependencyInjection/Internal/ConcurrentDictionaryExtensions.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceCollection.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceCollectionExtensions.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceProvider.cs \
			src/Microsoft.Extensions.DependencyInjection/Properties/AssemblyInfo.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ClosedIEnumerableService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ConstantCallSite.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ConstructorCallSite.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/CreateInstanceCallSite.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/FactoryService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/GenericService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/IGenericService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/InstanceService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/IService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/IServiceCallSite.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/OpenIEnumerableService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/Service.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ServiceEntry.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ServiceProviderService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ServiceScope.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ServiceScopeFactory.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ServiceScopeService.cs \
			src/Microsoft.Extensions.DependencyInjection/ServiceLookup/ServiceTable.cs \
			src/Microsoft.Extensions.DependencyInjection/Properties/Resources.Designer.cs \
			-resource:src/Microsoft.Extensions.DependencyInjection/Microsoft.Extensions.DependencyInjection.Resources.resources

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


