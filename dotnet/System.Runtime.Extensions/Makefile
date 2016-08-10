# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Runtime.Extensions
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

DOTNET_XARGS=

DOTNET_REFERENCES+=	${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			${DOTNET_REF}:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll

DOTNET_FILES+=		${WRKSRC}/src/${PORTNAME}/src/SR.cs \
			${WRKSRC}/src/${PORTNAME}/src/AssemblyInfo.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/BitConverter.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/IO/Path.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Diagnostics/Stopwatch.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Net/WebUtility.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Versioning/FrameworkName.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/LowLevelDictionary.cs \
			${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/SafeHeapHandle.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/SafeHeapHandleCache.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/NativeBuffer.cs \
			${WRKSRC}/src/Common/src/System/Runtime/InteropServices/StringBuffer.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Diagnostics/Stopwatch.Unix.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/IO/Path.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetCwd.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetTimestamp.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MksTemps.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.PathConf.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.Initialization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Security.Cryptography.Native/Interop.RAND.cs \
			${WRKSRC}/src/Common/src/System/IO/PathInternal.Unix.cs
			
.include <../../dotnet/coreclr/corefx.common>
