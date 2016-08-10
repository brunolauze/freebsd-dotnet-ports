# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.IO
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Contracts>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Contracts \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks


post-patch:
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/EndOfStreamException.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/SeekOrigin.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/MemoryStream.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/Stream.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/StreamReader.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/StreamWriter.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/TextReader.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/TextWriter.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/BinaryReader.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/BinaryWriter.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/StringReader.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/IO/StringWriter.cs

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Contracts.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.dll

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/IO/StringBuilderCache.cs \
			${WRKSRC}/src/Common/src/System/HResults.cs \
			${WRKSRC}/src/Common/src/System/Threading/Tasks/TaskToApm.cs

.include <../../dotnet/coreclr/corefx.common>
