# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.IO.FileSystem
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

NET_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Private.CoreLib>=1.0:${PORTSDIR}/dotnet/System.Private.CoreLib \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug

RUN_DEPENDS+=   ${NET_DEPENDS}

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	corefx

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
	@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && resgen /useSourcePath /compile Strings.resx,${PORTNAME}.Strings.resources
	@cd ${WRKSRC} && ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-resource:src/${PORTNAME}/src/Resources/${PORTNAME}.Strings.resources \
			-target:library \
			-nowarn:0436 \
			-warn:4 \
			src/System.IO.FileSystem/src/SR.cs \
			src/System.IO.FileSystem/src/System/IO/Error.cs \
			src/System.IO.FileSystem/src/System/IO/Directory.cs \
			src/System.IO.FileSystem/src/System/IO/DirectoryInfo.cs \
			src/System.IO.FileSystem/src/System/IO/File.cs \
			src/System.IO.FileSystem/src/System/IO/FileInfo.cs \
			src/System.IO.FileSystem/src/System/IO/FileOptions.cs \
			src/System.IO.FileSystem/src/System/IO/FileStream.cs \
			src/System.IO.FileSystem/src/System/IO/FileStreamBase.cs \
			src/System.IO.FileSystem/src/System/IO/FileSystem.cs \
			src/System.IO.FileSystem/src/System/IO/FileSystemInfo.cs \
			src/System.IO.FileSystem/src/System/IO/IFileSystemObject.cs \
			src/System.IO.FileSystem/src/System/IO/Iterator.cs \
			src/System.IO.FileSystem/src/System/IO/PathHelpers.cs \
			src/System.IO.FileSystem/src/System/IO/PathPair.cs \
			src/System.IO.FileSystem/src/System/IO/ReadLinesIterator.cs \
			src/System.IO.FileSystem/src/System/IO/SearchOption.cs \
			src/System.IO.FileSystem/src/System/IO/SearchTarget.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.CaseSensitivity.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			src/System.IO.FileSystem/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			src/System.IO.FileSystem/src/System/IO/FileStream.Unix.cs \
			src/System.IO.FileSystem/src/System/IO/FileSystem.Current.Unix.cs \
			src/System.IO.FileSystem/src/System/IO/FileSystemInfo.Unix.cs \
			src/System.IO.FileSystem/src/System/IO/PathHelpers.Unix.cs \
			src/System.IO.FileSystem/src/System/IO/UnixFileStream.cs \
			src/System.IO.FileSystem/src/System/IO/UnixFileSystem.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ChMod.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.CopyFile.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FTruncate.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetCwd.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.OpenFlags.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MkDir.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PathConf.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Permissions.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Unlink.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetEGid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetEUid.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ReadDir.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Access.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ChDir.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FLock.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FnMatch.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FSync.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.LSeek.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Link.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PosixFAdvise.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Read.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Rename.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.RmDir.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.UTime.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeDirectoryHandle.Unix.cs \
			src/System.IO.FileSystem.Primitives/src/System/IO/FileAttributes.cs \
			src/System.IO.FileSystem.Primitives/src/System/IO/FileMode.cs \
			src/System.IO.FileSystem.Primitives/src/System/IO/FileShare.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
