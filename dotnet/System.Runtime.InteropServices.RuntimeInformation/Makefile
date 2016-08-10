# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Runtime.InteropServices.RuntimeInformation
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

post-patch:
	@${RM} ${WRKSRC}/src/System.Runtime.InteropServices.RuntimeInformation/src/System/Runtime/InteropServices/RuntimeInformation/RuntimeInformation.Windows.cs

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetUnixName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetUnixVersion.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetOSArchitecture.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetProcessArchitecture.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.ProcessorArchitecture.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs

.include <../../dotnet/coreclr/corefx.common>
