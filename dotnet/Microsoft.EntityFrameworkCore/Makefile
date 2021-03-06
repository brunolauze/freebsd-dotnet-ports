# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.EntityFrameworkCore
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.ComponentModel.Annotations>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.Annotations \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Linq.Queryable>=1.0:${PORTSDIR}/dotnet/System.Linq.Queryable \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		Microsoft.Extensions.Caching.Memory>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Memory \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.DependencyInjection>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.Logging>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging \
		Remotion.Linq>=2.2:${PORTSDIR}/dotnet/Remotion.Linq \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Threading.Tasks>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks \
		System.Interactive.Async>=1.0:${PORTSDIR}/dotnet/System.Interactive.Async
		
GH_PROJECT=	EntityFramework

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/Properties && ${DOTNET_RESGEN} CoreStrings.resx,${PORTNAME}.Properties.CoreStrings.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.Annotations.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Queryable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Memory.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Interactive.Async.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Remotion.Linq.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/Properties/${PORTNAME}.Properties.CoreStrings.resources \
			-resource:src/${PORTNAME}/Properties/${PORTNAME}.rd.xml

DOTNET_FILES+=		src/Shared/CodeAnnotations.cs \
			src/Shared/PropertyInfoExtensions.cs \
			src/Shared/StringBuilderExtensions.cs \
			src/Shared/SharedTypeExtensions.cs \
			src/Shared/Check.cs \
			src/Shared/LoggingExtensions.cs

.include <../../dotnet/aspnet/Makefile.common>


