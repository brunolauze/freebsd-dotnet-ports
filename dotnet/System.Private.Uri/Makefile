# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Private.Uri
PORTVERSION=	1.0.0.0

NET_DEPENDS+=   System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=     ${DOTNET_REF}:${DOTNET_PATH}/System.IO.FileSystem.dll

DOTNET_RESOURCES+=      ${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources \
			${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/${PORTNAME}.rd.xml,${PORTNAME}.rd.xml

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Diagnostics/Debug.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/LowLevelDictionary.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/LowLevelList.cs \
			${WRKSRC}/src/Common/src/System/StringNormalizationExtensions.cs \
			${WRKSRC}/src/Common/src/System/Globalization/IdnMapping.cs \
			${WRKSRC}/src/Common/src/System/Text/NormalizationForm.cs \
			${WRKSRC}/src/Common/src/System/StringNormalizationExtensions.Unix.cs \
			${WRKSRC}/src/Common/src/System/Globalization/IdnMapping.Unix.cs \
			${WRKSRC}/src/Common/src/System/Diagnostics/Debug.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.IOErrors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Close.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Dup.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FileDescriptors.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.FLock.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Open.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.OpenFlags.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.SysLog.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Write.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.Stat.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Globalization.Native/Interop.Normalization.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Globalization.Native/Interop.Idna.cs

post-patch:
	@${RM} ${WRKSRC}/src/System/Text/NormalizationForm.cs
	@${RM} ${WRKSRC}/src/System/Text/NormalizationForm.Unix.cs

.include <../../dotnet/coreclr/corefx.common>
