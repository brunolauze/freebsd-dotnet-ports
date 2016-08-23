# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.EntityFrameworkCore.Relational.Design
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.ComponentModel.Annotations>=1.0:${PORTSDIR}/dotnet/System.ComponentModel.Annotations \
		System.Data.Common>=1.0:${PORTSDIR}/dotnet/System.Data.Common \
		System.Interactive.Async>=1.0:${PORTSDIR}/dotnet/System.Interactive.Async \
		System.Linq.Queryable>=1.0:${PORTSDIR}/dotnet/System.Linq.Queryable \
		System.ObjectModel>=1.0:${PORTSDIR}/dotnet/System.ObjectModel \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		Microsoft.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CSharp \
		Microsoft.Extensions.Caching.Memory>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Caching.Memory \
		Microsoft.Extensions.DependencyInjection>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection \
		Microsoft.Extensions.Logging>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Remotion.Linq>=2.1:${PORTSDIR}/dotnet/Remotion.Linq \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		Microsoft.EntityFrameworkCore>=1.0:${PORTSDIR}/dotnet/Microsoft.EntityFrameworkCore \
		Microsoft.EntityFrameworkCore.Relational>=1.0:${PORTSDIR}/dotnet/Microsoft.EntityFrameworkCore.Relational
		
GH_PROJECT=	EntityFramework

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/Properties && ${DOTNET_RESGEN} RelationalDesignStrings.resx,${PORTNAME}.Properties.RelationalDesignStrings.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ComponentModel.Annotations.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.DiagnosticSource.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Data.Common.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Interactive.Async.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Queryable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.ObjectModel.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CSharp.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Caching.Memory.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Remotion.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.EntityFrameworkCore.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.EntityFrameworkCore.Relational.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/Properties/${PORTNAME}.Properties.RelationalDesignStrings.resources

DOTNET_FILES+=		src/Shared/CodeAnnotations.cs \
			src/Shared/PropertyInfoExtensions.cs \
			src/Shared/StringBuilderExtensions.cs \
			src/Shared/SharedTypeExtensions.cs \
			src/Shared/Check.cs \
			src/Shared/LoggingExtensions.cs

.include <../../dotnet/aspnet/Makefile.common>


