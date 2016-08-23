# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/System.Threading.Tasks.Dataflow/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Threading.Tasks.Dataflow
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Extensions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.dll

DOTNET_DEFINES+=	-define:CONCURRENT_COLLECTIONS \
			-define:FEATURE_TRACING

.include <../../dotnet/coreclr/corefx.common>
