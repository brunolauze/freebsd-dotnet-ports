# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Extensions.WebEncoders/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Extensions.WebEncoders
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   Microsoft.Extensions.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Primitives \
		Microsoft.Extensions.DependencyInjection.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection.Abstractions \
		Microsoft.Extensions.DependencyInjection>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.DependencyInjection \
		Microsoft.Extensions.Logging.Abstractions>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Logging.Abstractions \
		Microsoft.Extensions.Options>=1.0:${PORTSDIR}/dotnet/Microsoft.Extensions.Options \
		System.Text.Encodings.Web>=1.0:${PORTSDIR}/dotnet/System.Text.Encodings.Web

GH_PROJECT=	HtmlAbstractions

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Primitives.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.DependencyInjection.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Logging.Abstractions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Extensions.Options.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Text.Encodings.Web.dll

OLD_LISTING+=		src/Microsoft.Extensions.WebEncoders/Properties/AssemblyInfo.cs \
			src/Microsoft.Extensions.WebEncoders/EncoderServiceCollectionExtensions.cs \
			src/Microsoft.Extensions.WebEncoders/WebEncoderOptions.cs \
			src/Microsoft.Extensions.WebEncoders/Testing/UrlTestEncoder.cs \
			src/Microsoft.Extensions.WebEncoders/Testing/JavaScriptTestEncoder.cs \
			src/Microsoft.Extensions.WebEncoders/Testing/HtmlTestEncoder.cs

.include <../../dotnet/aspnet/Makefile.common>


