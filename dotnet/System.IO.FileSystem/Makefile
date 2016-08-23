# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.IO.FileSystem
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug

DOTNET_XARGS=	
DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/${PORTNAME}/src/Resources/${PORTNAME}.SR.resources

DOTNET_FILES+=		src/${PORTNAME}/src/AssemblyInfo.cs \
			src/${PORTNAME}/src/SR.cs \
			src/${PORTNAME}/src/System/IO/Error.cs \
			src/${PORTNAME}/src/System/IO/Directory.cs \
			src/${PORTNAME}/src/System/IO/DirectoryInfo.cs \
			src/${PORTNAME}/src/System/IO/File.cs \
			src/${PORTNAME}/src/System/IO/FileInfo.cs \
			src/${PORTNAME}/src/System/IO/FileOptions.cs \
			src/${PORTNAME}/src/System/IO/FileStream.cs \
			src/${PORTNAME}/src/System/IO/FileStreamBase.cs \
			src/${PORTNAME}/src/System/IO/FileSystem.cs \
			src/${PORTNAME}/src/System/IO/FileSystemInfo.cs \
			src/${PORTNAME}/src/System/IO/IFileSystemObject.cs \
			src/${PORTNAME}/src/System/IO/Iterator.cs \
			src/${PORTNAME}/src/System/IO/PathHelpers.cs \
			src/${PORTNAME}/src/System/IO/PathPair.cs \
			src/${PORTNAME}/src/System/IO/ReadLinesIterator.cs \
			src/${PORTNAME}/src/System/IO/SearchOption.cs \
			src/${PORTNAME}/src/System/IO/SearchTarget.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.CaseSensitivity.cs \
			${WRKSRC}/src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			src/${PORTNAME}/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs \
			src/${PORTNAME}/src/System/IO/FileStream.Unix.cs \
			src/${PORTNAME}/src/System/IO/FileSystem.Current.Unix.cs \
			src/${PORTNAME}/src/System/IO/FileSystemInfo.Unix.cs \
			src/${PORTNAME}/src/System/IO/PathHelpers.Unix.cs \
			src/${PORTNAME}/src/System/IO/UnixFileStream.cs \
			src/${PORTNAME}/src/System/IO/UnixFileSystem.cs \
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
			src/${PORTNAME}.Primitives/src/System/IO/FileAttributes.cs \
			src/${PORTNAME}.Primitives/src/System/IO/FileMode.cs \
			src/${PORTNAME}.Primitives/src/System/IO/FileShare.cs

.include <../../dotnet/coreclr/corefx.common>
