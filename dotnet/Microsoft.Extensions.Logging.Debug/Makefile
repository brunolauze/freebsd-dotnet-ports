# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Extensions.Logging.Debug/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.Logging.Debug
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions

GH_PROJECT=	Logging

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll

OLD_LISTING+=		src/Microsoft.Extensions.Logging.Debug/DebugLogger.cs \
			src/Microsoft.Extensions.Logging.Debug/DebugLogger.debug.cs \
			src/Microsoft.Extensions.Logging.Debug/DebugLoggerFactoryExtensions.cs \
			src/Microsoft.Extensions.Logging.Debug/DebugLoggerProvider.cs \
			src/Microsoft.Extensions.Logging.Debug/Properties/AssemblyInfo.cs

.include <../../dotnet/aspnet/Makefile.common>


