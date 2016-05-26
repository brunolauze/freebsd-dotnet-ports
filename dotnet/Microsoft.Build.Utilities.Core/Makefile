# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Build.Utilities.Core
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		Microsoft.Build.Framework>=1.0:${PORTSDIR}/dotnet/Microsoft.Build.Framework \
		Microsoft.Build>=1.0:${PORTSDIR}/dotnet/Microsoft.Build

USE_GITHUB=	yes
GH_ACCOUNT=	Microsoft
GH_PROJECT=	msbuild

USES=           dotnet

post-patch:
	@rm -rf ${WRKSRC}/src/Utilities/UnitTests

configure:

do-configure:

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
	@cd ${WRKSRC}/src/Utilities && resgen /useSourcePath /compile Strings.resx,Microsoft.Build.Utilities.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/Utilities -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Build.Framework.dll \
			-resource:src/Utilities/Microsoft.Build.Utilities.Strings.resources \
			-define:FEATURE_SECURITY_PERMISSIONS \
                        -define:FEATURE_APPDOMAIN \
                        -define:FEATURE_MSBUILD_DEBUGGER \
                        -define:FEATURE_STRONG_NAMES \
                        -define:STANDALONEBUILD \
                        -define:FEATURE_APPDOMAIN_UNHANDLED_EXCEPTION \
                        -define:FEATURE_TASK_GENERATERESOURCES \
                        -define:FEATURE_APARTMENT_STATE \
                        -define:FEATURE_APM \
                        -define:FEATURE_ASSEMBLY_LOADFROM \
                        -define:FEATURE_ASSEMBLY_LOCATION \
                        -define:FEATURE_ASSEMBLYNAME_CULTUREINFO \
                        -define:FEATURE_ASSEMBLYNAME_CLONE \
                        -define:FEATURE_COM_INTEROP \
                        -define:FEATURE_CONSOLE_BUFFERWIDTH \
                        -define:FEATURE_CONSTRAINED_EXECUTION \
                        -define:FEATURE_CHARSET_AUTO \
                        -define:FEATURE_CODEDOM \
                        -define:FEATURE_CODETASKFACTORY \
                        -define:FEATURE_CULTUREINFO_CONSOLE_FALLBACK \
                        -define:FEATURE_CULTUREINFO_GETCULTURES \
                        -define:FEATURE_DOTNETVERSION \
                        -define:FEATURE_ENVIRONMENT_SYSTEMDIRECTORY \
                        -define:FEATURE_FUSION_COMPAREASSEMBLYIDENTITY \
                        -define:FEATURE_GAC \
                        -define:FEATURE_GET_COMMANDLINE \
                        -define:FEATURE_HANDLE_SAFEWAITHANDLE \
                        -define:FEATURE_HANDLEPROCESSCORRUPTEDSTATEEXCEPTIONS \
                        -define:FEATURE_HANDLEREF \
                        -define:FEATURE_HTTP_LISTENER \
                        -define:FEATURE_INSTALLED_MSBUILD \
                        -define:FEATURE_MEMORYSTREAM_GETBUFFER \
                        -define:FEATURE_OSVERSION \
                        -define:FEATURE_PARALLEL_BUILD \
                        -define:FEATURE_PERFORMANCE_COUNTERS \
                        -define:FEATURE_PFX_SIGNING \
                        -define:FEATURE_REFLECTION_EMIT_DEBUG_INFO \
                        -define:FEATURE_RESGEN \
                        -define:FEATURE_RESOURCE_EXPOSURE \
                        -define:FEATURE_RESX_RESOURCE_READER \
                        -define:FEATURE_RUN_EXE_IN_TESTS \
                        -define:FEATURE_SECURITY_PRINCIPAL_WINDOWS \
                        -define:FEATURE_SPECIAL_FOLDERS \
                        -define:FEATURE_STRING_INTERN \
                        -define:FEATURE_TASKHOST \
                        -define:FEATURE_THREAD_ABORT \
                        -define:FEATURE_THREAD_CULTURE \
                        -define:FEATURE_THREAD_PRIORITY \
                        -define:FEATURE_MULTIPLE_TOOLSETS \
                        -define:FEATURE_TYPE_INVOKEMEMBER \
                        -define:FEATURE_TYPE_GETINTERFACE \
                        -define:FEATURE_VARIOUS_EXCEPTIONS \
                        -define:FEATURE_XML_SOURCE_URI \
                        -define:FEATURE_XML_LOADPATH \
                        -define:FEATURE_XMLTEXTREADER \
                        -define:FEATURE_DEBUGGER \
                        -define:CORECLR \
			-target:library \
			-warn:4 \
			src/Shared/FxCopExclusions/Microsoft.Build.Shared.Suppressions.cs \
			src/Shared/AssemblyFoldersEx.cs \
			src/Shared/CanonicalError.cs \
			src/Shared/Constants.cs \
			src/Shared/ExtensionFoldersRegistryKey.cs \
			src/Shared/FileDelegates.cs \
			src/Shared/CopyOnWriteDictionary.cs \
			src/Shared/EncodingUtilities.cs \
			src/Shared/ErrorUtilities.cs \
			src/Shared/EscapingUtilities.cs \
			src/Shared/EventArgsFormatting.cs \
			src/Shared/ExceptionHandling.cs \
			src/Shared/EnvironmentUtilities.cs \
			src/Shared/FileUtilities.cs \
			src/Shared/FileMatcher.cs \
			src/Shared/FileUtilitiesRegex.cs \
			src/Shared/FrameworkLocationHelper.cs \
			src/Shared/HybridDictionary.cs \
			src/Shared/InternalErrorException.cs \
			src/Shared/IKeyed.cs \
			src/Shared/MSBuildNameIgnoreCaseComparer.cs \
			src/Shared/Modifiers.cs \
			src/Shared/NativeMethodsShared.cs \
			src/Shared/InprocTrackingNativeMethods.cs \
			src/Shared/OpportunisticIntern.cs \
			src/Shared/ReadOnlyEmptyCollection.cs \
			src/Shared/ReadOnlyEmptyDictionary.cs \
			src/Shared/ReadOnlyEmptyList.cs \
			src/Shared/RegistryDelegates.cs \
			src/Shared/RegistryHelper.cs \
			src/Shared/ResourceUtilities.cs \
			src/Shared/StringBuilderCache.cs \
			src/Shared/TaskLoggingHelper.cs \
			src/Shared/TempFileUtilities.cs \
			src/Shared/Tracing.cs \
			src/Shared/VersionUtilities.cs \
			src/Shared/ToolsetElement.cs \

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


