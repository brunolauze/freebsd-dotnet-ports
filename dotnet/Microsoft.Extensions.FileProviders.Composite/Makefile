# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.FileProviders.Composite
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.AppContext>=1.0:${PORTSDIR}/dotnet/System.AppContext \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions

GH_PROJECT=	FileSystem

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.AppContext.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll

DOTNET_FILES+=		src/Microsoft.Extensions.FileProviders.Sources/Constants.cs \
			src/Microsoft.Extensions.FileProviders.Sources/CompositeFileChangeToken.cs \
			src/Microsoft.Extensions.FileProviders.Sources/EmptyDisposable.cs \
			src/Microsoft.Extensions.FileProviders.Sources/CompositeDisposable.cs \
			src/Microsoft.Extensions.FileProviders.Sources/EnumerableDirectoryContents.cs

.include <../../dotnet/aspnet/Makefile.common>


