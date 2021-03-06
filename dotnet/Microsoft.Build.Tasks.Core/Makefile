# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Build.Tasks.Core
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
		Microsoft.Build.Utilities.Core>=1.0:${PORTSDIR}/dotnet/Microsoft.Build.Utilities.Core

USE_GITHUB=	yes
GH_ACCOUNT=	Microsoft
GH_PROJECT=	msbuild

USES=           dotnet

post-patch:
	@rm -rf ${WRKSRC}/src/XMakeTasks/UnitTests
	@rm -rf ${WRKSRC}/src/XMakeTasks/XMakeTasksUnitTests
	@rm -rf ${WRKSRC}/src/XMakeTasks/CodeTaskFactoryInstance.cs
	@rm -rf ${WRKSRC}/src/XMakeTasks/system.design/stronglytypedresourcebuilder.cs
	@rm -rf ${WRKSRC}/src/XMakeTasks/DataDriven/DataDrivenToolTask.cs

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
	@cd ${WRKSRC}/src/XMakeTasks && resgen /useSourcePath /compile Strings.resx,Microsoft.Build.Tasks.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/XMakeTasks -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.CoreLib.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Configuration.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Core.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Security.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Windows.Forms.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xaml.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Build.Framework.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.Build.Utilities.Core.dll \
			-resource:src/XMakeTasks/Microsoft.Build.Tasks.Strings.resources \
			-resource:src/XMakeTasks/BootstrapperUtil/xmltoconfig.xsl,Microsoft.Build.Tasks.Deployment.Bootstrapper.xmltoconfig.xsl \
			-resource:src/XMakeTasks/ManifestUtil/manifest.xml,Microsoft.Build.Tasks.Deployment.ManifestUtilities.manifest.xml \
			-resource:src/XMakeTasks/ManifestUtil/merge.xsl,Microsoft.Build.Tasks.Deployment.ManifestUtilities.merge.xsl \
			-resource:src/XMakeTasks/ManifestUtil/read2.xsl,Microsoft.Build.Tasks.Deployment.ManifestUtilities.read2.xsl \
			-resource:src/XMakeTasks/ManifestUtil/trustinfo2.xsl,Microsoft.Build.Tasks.Deployment.ManifestUtilities.trustinfo2.xsl \
			-resource:src/XMakeTasks/ManifestUtil/write2.xsl,Microsoft.Build.Tasks.Deployment.ManifestUtilities.write2.xsl \
			-resource:src/XMakeTasks/ManifestUtil/write3.xsl,Microsoft.Build.Tasks.Deployment.ManifestUtilities.write3.xsl \
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
                        -define:FEATURE_SYSTEM_CONFIGURATION \
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
                        -define:FEATURE_XAML_TYPES \
                        -define:FEATURE_XML_SOURCE_URI \
                        -define:FEATURE_XML_LOADPATH \
                        -define:FEATURE_XMLTEXTREADER \
                        -define:FEATURE_DEBUGGER \
                        -define:MONO \
			-target:library \
			-warn:4 \
			src/Shared/FxCopExclusions/Microsoft.Build.Shared.Suppressions.cs \
			src/Shared/AssemblyFoldersEx.cs \
			src/Shared/AssemblyNameComparer.cs \
			src/Shared/AssemblyNameExtension.cs \
			src/Shared/AssemblyNameReverseVersionComparer.cs \
			src/Shared/CanonicalError.cs \
			src/Shared/Constants.cs \
			src/Shared/CopyOnWriteDictionary.cs \
			src/Shared/ExtensionFoldersRegistryKey.cs \
			src/Shared/FileDelegates.cs \
			src/Shared/HybridDictionary.cs \
			src/Shared/NativeMethodsShared.cs \
			src/Shared/NGen.cs \
			src/Shared/OpportunisticIntern.cs \
			src/Shared/PropertyParser.cs \
			src/Shared/ReadOnlyEmptyCollection.cs \
			src/Shared/RegistryDelegates.cs \
			src/Shared/RegistryHelper.cs \
			src/Shared/StringBuilderCache.cs \
			src/Shared/StrongNameHelpers.cs \
			src/Shared/TaskLoggingHelperExtension.cs \
			src/Shared/TempFileUtilities.cs \
			src/Shared/MetadataConversionUtilities.cs \
			src/Shared/LanguageParser/StreamMappedString.cs \
			src/Shared/ExceptionHandling.cs \
			src/Shared/FileUtilities.cs \
			src/Shared/EscapingUtilities.cs \
			src/Shared/FileMatcher.cs \
			src/Shared/Modifiers.cs \
			src/Shared/ReadOnlyCollection.cs \
			src/Shared/ReadOnlyEmptyDictionary.cs \
			src/Shared/ReadOnlyEmptyList.cs \
			src/Shared/Tracing.cs \
			src/Shared/VersionUtilities.cs \
			src/Shared/VisualStudioConstants.cs \
			src/Shared/LanguageParser/CSharptokenCharReader.cs \
			src/Shared/LanguageParser/CSharptokenEnumerator.cs \
			src/Shared/LanguageParser/CSharptokenizer.cs \
			src/Shared/InternalErrorException.cs \
			src/Shared/FileUtilitiesRegex.cs \
			src/Shared/ConversionUtilities.cs \
			src/Shared/ErrorUtilities.cs \
			src/Shared/EncodingUtilities.cs \
			src/Shared/ResourceUtilities.cs \
			src/Shared/LanguageParser/token.cs \
			src/Shared/LanguageParser/tokenChar.cs \
			src/Shared/LanguageParser/tokenCharReader.cs \
			src/Shared/LanguageParser/tokenEnumerator.cs \
			src/Shared/LanguageParser/VisualBasictokenCharReader.cs \
			src/Shared/LanguageParser/VisualBasictokenEnumerator.cs \
			src/Shared/LanguageParser/VisualBasictokenizer.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/dotnet/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


