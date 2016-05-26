# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Private.CoreLib
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		coreclr>=1.0:${PORTSDIR}/dotnet/coreclr

RUN_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Native>=1.0:${PORTSDIR}/dotnet/System.Native

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	coreclr
GH_TAGNAME=	master

USES=           dotnet
GNU_CONFIGURE=  yes
USE_LDCONFIG=   yes

configure:

do-configure:

build-next:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/Microsoft/Win32/Registry.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/Microsoft/Win32/RegistryKey.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Runtime/InteropServices/WindowsRuntime/CLRIReferenceImpl.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Runtime/InteropServices/WindowsRuntime/CLRIKeyValuePairImpl.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Runtime/InteropServices/ComEventsInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Runtime/InteropServices/ComEventsSink.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Runtime/InteropServices/WindowsRuntime/ICustomPropertyProvider.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/EncodingDataItem.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/EncodingTable.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CompareInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/ChineseLunisolarCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/TaiwanLunisolarCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CultureNotFoundException.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/DateTimeFormatInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/PersianCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/DaylightTime.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/KoreanCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/NumberFormatInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/HebrewNumber.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/JapaneseLunisolarCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/UmAlQuraCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/DateTimeFormatInfoScanner.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/KoreanLunisolarCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CalendarData.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/Calendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/GregorianCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CultureData.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/JapaneseCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/ThaiBuddhistCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/GregorianCalendarHelper.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/TaiwanCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/JulianCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/EastAsianLunisolarCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CalendricalCalculationsHelper.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/TimeSpanStyles.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/UnicodeCategory.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/HebrewCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/HijriCalendar.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/GregorianCalendarTypes.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CultureInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/StringInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CalendarWeekRule.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/TextElementEnumerator.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/TextInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/RegionInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Globalization/CharUnicodeInfo.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/Microsoft/Win32/Interop.Libraries.cs
	@${RM} -rf ${WRKSRC}/src/System.Private.CoreLib/src/System/Runtime/InteropServices/NonPortable.cs
	@${FIND} ${WRKSRC}/src/${PORTNAME} -name "*.Win32.cs" -delete
	@cd ${WRKSRC}/src/${PORTNAME} && resgen /useSourcePath /compile Strings.resx,FxResources.System.IO.FileSystem.resources
	@cd ${WRKSRC}/src/${PORTNAME} && resgen /useSourcePath /compile System.Private.CoreLib.resx,${PORTNAME}.resources
	@cd ${WRKSRC} && ${FIND} src/${PORTNAME} -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-resource:${WRKSRC}/src/${PORTNAME}/src/System/Globalization/Tables/charinfo.nlp \
			-resource:${WRKSRC}/src/${PORTNAME}/${PORTNAME}.resources \
			-resource:${WRKSRC}/src/${PORTNAME}/FxResources.System.IO.FileSystem.resources \
			-target:library \
			-warn:4 \
			-define:CODE_ANALYSIS \
			-define:DBG \
			-define:_DEBUG \
			-define:_LOGGING \
			-define:DEBUG \
			-define:TRACE \
			-define:WIN64 \
			-define:AMD64 \
			-define:_USE_NLS_PLUS_TABLE \
			-define:RESOURCE_SATELLITE_CONFIG \
			-define:INSIDE_CLR \
			-define:CODE_ANALYSIS_BASELINE \
			-define:FEATURE_APPDOMAIN_RESOURCE_MONITORING \
			-define:FEATURE_ARRAYSTUB_AS_IL \
			-define:FEATURE_STUBS_AS_IL \
			-define:FEATURE_ASCII \
			-define:FEATURE_BCL_FORMATTING \
			-define:FEATURE_COLLECTIBLE \
			-define:_TYPES \
			-define:FEATURE_CORECLR \
			-define:FEATURE_COREFX_GLOBALIZATION \
			-define:FEATURE_CORESYSTEM \
			-define:FEATURE_CORRUPTING_EXCEPTIONS \
			-define:FEATURE_ENCODINGNLS \
			-define:FEATURE_EXCEPTIONDISPATCHINFO \
			-define:FEATURE_HOST_ASSEMBLY_RESOLVER \
			-define:FEATURE_HOSTED_BINDER \
			-define:FEATURE_LATIN1 \
			-define:FEATURE_LOADER_OPTIMIZATION \
			-define:FEATURE_MANAGED_ETW_CHANNELS \
			-define:FEATURE_MAIN_CLR_MODULE_USES_CORE_NAME \
			-define:FEATURE_NORM_IDNA_ONLY \
			-define:FEATURE_PAL \
			-define:FEATURE_EVENTSOURCE_XPLAT \
			-define:FEATURE_RANDOMIZED_STRING_HASHING \
			-define:FEATURE_STRONGNAME_MIGRATION \
			-define:FEATURE_SYNTHETIC_CULTURES \
			-define:FEATURE_UTF32 \
			-define:FEATURE_UTF7 \
			-define:FEATURE_VERSIONING \
			-define:FEATURE_WINDOWSPHONE \
			-define:FEATURE_WINMD_RESILIENT \
			-define:PROFILING_SUPPORTED \
			-define:FEATURE_MULTICOREJIT \
			-define:FEATURE_REJIT \
			-define:FEATURE_USE_ASM_GC_WRITE_BARRIERS \
			-define:FEATURE_SYMDIFF \
			-define:FEATURE_READYTORUN \
			-define:PLATFORM_UNIX \
			-define:SIGNED

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@${CP} ${PATCHDIR}/${PORTNAME}.dll  ${WRKSRC}/bin/Release/${PORTNAME}.dll

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>
