# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Runtime.Serialization.Primitives
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Numerics>=1.0:${PORTSDIR}/dotnet/System.Runtime.Numerics \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading

post-patch:
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/StreamingContext.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/OnDeserializedAttribute.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/OnDeserializingAttribute.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/OnSerializedAttribute.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/OnSerializingAttribute.cs
	@${RM} ${WRKSRC}/src/${PORTNAME}/src/System/Runtime/Serialization/SerializationException.cs

DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.Numerics.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/Globalization/FormatProvider.Number.cs \
			${WRKSRC}/src/System.Runtime.Numerics/src/System/Globalization/FormatProvider.NumberBuffer.cs

.include <../../dotnet/coreclr/corefx.common>
