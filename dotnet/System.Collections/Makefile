# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Collections
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime

DOTNET_RESOURCE_COMMAND=@cd ${WRKSRC}/src/${PORTNAME}/src/Resources && ${DOTNET_RESGEN} Strings.resx,FxResources.${PORTNAME}.SR.resources
DOTNET_XARGS=

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:${WRKSRC}/src/${PORTNAME}/src/Resources/FxResources.${PORTNAME}.SR.resources

DOTNET_FILES+=		${WRKSRC}/src/${PORTNAME}/src/SR.cs \
			${WRKSRC}/src/${PORTNAME}/src/AssemblyInfo.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/BitHelper.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/ICollectionDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/IDictionaryDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/HashSet.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/LinkedList.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/Queue.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/QueueDebugView.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/SortedDictionary.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/SortedList.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/SortedSet.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/Stack.cs \
			${WRKSRC}/src/${PORTNAME}/src/System/Collections/Generic/StackDebugView.cs \
			${WRKSRC}/src/Common/src/System/Collections/HashHelpers.cs \
			${WRKSRC}/src/Common/src/System/Collections/Generic/EnumerableHelpers.cs

.include <../../dotnet/coreclr/corefx.common>
