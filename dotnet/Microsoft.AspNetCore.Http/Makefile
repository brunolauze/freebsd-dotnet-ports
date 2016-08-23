# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.AspNetCore.Http.Extensions/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Http
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.Buffers>=1.0:${PORTSDIR}/dotnet/System.Buffers \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Net.Http>=1.0:${PORTSDIR}/dotnet/System.Net.Http \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Net.WebSockets>=1.0:${PORTSDIR}/dotnet/System.Net.WebSockets \
		System.Security.Claims>=1.0:${PORTSDIR}/dotnet/System.Security.Claims \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates \
		Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.ObjectPool>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.ObjectPool \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		Microsoft.AspNetCore.Http.Features>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Features \
		Microsoft.AspNetCore.Http.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.Http.Abstractions \
		Microsoft.AspNetCore.WebUtilities>=1.0:${PORTSDIR}/dotnet/Microsoft.AspNetCore.WebUtilities \
		Microsoft.Net.Http.Headers>=1.0:${PORTSDIR}/dotnet/Microsoft.Net.Http.Headers \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web

GH_PROJECT=	HttpAbstractions


DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Buffers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Http.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Net.WebSockets.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Claims.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.Cryptography.X509Certificates.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.ObjectPool.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Features.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.Http.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.AspNetCore.WebUtilities.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Net.Http.Headers.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

.include <../../dotnet/aspnet/Makefile.common>


