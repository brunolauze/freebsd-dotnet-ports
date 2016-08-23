# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Cryptography.Internal
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Handles>=1.0:${PORTSDIR}/dotnet/System.Runtime.Handles \
		System.Runtime.InteropServices>=1.0:${PORTSDIR}/dotnet/System.Runtime.InteropServices \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		Microsoft.Extensions.PlatformAbstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.PlatformAbstractions

GH_PROJECT=	DataProtection

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME} && ${DOTNET_RESGEN} Resources.resx,${PORTNAME}.Resources.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Handles.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.InteropServices.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll

DOTNET_RESOURCES+=	-resource:src/${PORTNAME}/${PORTNAME}.Resources.resources

.include <../../dotnet/aspnet/Makefile.common>


