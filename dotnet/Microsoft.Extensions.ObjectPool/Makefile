# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.ObjectPool
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug

GH_PROJECT=	Common

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll

OLD_LISTING+=		src/Microsoft.Extensions.ObjectPool/DefaultObjectPool.cs \
			src/Microsoft.Extensions.ObjectPool/DefaultObjectPoolProvider.cs \
			src/Microsoft.Extensions.ObjectPool/DefaultPooledObjectPolicy.cs \
			src/Microsoft.Extensions.ObjectPool/IPooledObjectPolicy.cs \
			src/Microsoft.Extensions.ObjectPool/LeakTrackingObjectPool.cs \
			src/Microsoft.Extensions.ObjectPool/LeakTrackingObjectPoolProvider.cs \
			src/Microsoft.Extensions.ObjectPool/ObjectPool.cs \
			src/Microsoft.Extensions.ObjectPool/ObjectPoolProvider.cs \
			src/Microsoft.Extensions.ObjectPool/ObjectPoolProviderExtensions.cs \
			src/Microsoft.Extensions.ObjectPool/StringBuilderPooledObjectPolicy.cs \
			src/Microsoft.Extensions.ObjectPool/Properties/AssemblyInfo.cs

.include <../../dotnet/aspnet/Makefile.common>


