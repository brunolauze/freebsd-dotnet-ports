# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.FileProviders.Physical
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.AppContext>=1.0:${PORTSDIR}/dotnet/System.AppContext \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.FileSystem.Watcher>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem.Watcher \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.FileSystemGlobbing>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileSystemGlobbing \
		Microsoft.Extensions.FileProviders.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.FileProviders.Abstractions

GH_PROJECT=	FileSystem

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.AppContext.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.Watcher.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.RegularExpressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileSystemGlobbing.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.FileProviders.Abstractions.dll

DOTNET_FILES+=		src/Microsoft.Extensions.FileProviders.Sources/Constants.cs \
			src/Microsoft.Extensions.FileProviders.Sources/CompositeFileChangeToken.cs \
			src/Microsoft.Extensions.FileProviders.Sources/CompositeDisposable.cs \
			src/Microsoft.Extensions.FileProviders.Sources/EmptyDisposable.cs \
			src/Microsoft.Extensions.FileProviders.Sources/EnumerableDirectoryContents.cs

.include <../../dotnet/aspnet/Makefile.common>


