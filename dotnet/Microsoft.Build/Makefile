# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.Build
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

BUILD_DEPENDS+= mono:${PORTSDIR}/lang/mono \
		${NET_DEPENDS}

RUN_DEPENDS+=	${NET_DEPENDS}

NET_DEPENDS+=	coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.NonGeneric>=1.0:${PORTSDIR}/dotnet/System.Collections.NonGeneric \
		System.Collections.Specialized>=1.0:${PORTSDIR}/dotnet/System.Collections.Specialized \
		System.Console>=1.0:${PORTSDIR}/dotnet/System.Console \
		System.Runtime.InteropServices.RuntimeInformation>=1.0:${PORTSDIR}/dotnet/System.Runtime.InteropServices.RuntimeInformation \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Diagnostics.FileVersionInfo>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.FileVersionInfo \
		System.Diagnostics.Process>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Process \
		System.Diagnostics.TraceSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.TraceSource \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates \
		System.IO.Compression>=1.0:${PORTSDIR}/dotnet/System.IO.Compression \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.Pipes>=1.0:${PORTSDIR}/dotnet/System.IO.Pipes \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Xml.XmlDocument>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlDocument \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Text.RegularExpressions>=1.0:${PORTSDIR}/dotnet/System.Text.RegularExpressions \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Dataflow>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Dataflow \
		Microsoft.Build.Framework>=1.0:${PORTSDIR}/dotnet/Microsoft.Build.Framework

USE_GITHUB=	yes
GH_ACCOUNT=	Microsoft
GH_PROJECT=	msbuild

USES=           dotnet

post-patch:
	@${FIND} ${WRKSRC}/src/XMakeBuildEngine -name "*Test*.cs" -delete
	@rm -rf ${WRKSRC}/src/XMakeBuildEngine/UnitTests
	@rm -rf ${WRKSRC}/src/XMakeBuildEngine/UnitTestsPublicOM
	@rm -rf ${WRKSRC}/src/XMakeBuildEngine/ApexTests
	@rm -rf ${WRKSRC}/src/XMakeBuildEngine/Collections/RetrievableEntryHashSet/Originals
	@rm -rf ${WRKSRC}/src/XMakeBuildEngine/Instance/TaskFactories/AssemblyTaskFactoryInstance.cs
	@rm -rf ${WRKSRC}/src/XMakeBuildEngine/Definition/ToolsetConfigurationReader.cs

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/coreclr
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@cd ${WRKSRC}/src/XMakeBuildEngine/Resources && resgen /useSourcePath /compile Strings.resx,${PORTNAME}.Resources.Strings.resources
	@cd ${WRKSRC} && ${FIND} src/XMakeBuildEngine -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/${PORTNAME}.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Collections.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Collections.Concurrent.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Collections.NonGeneric.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Collections.Specialized.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Console.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Diagnostics.FileVersionInfo.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Diagnostics.Process.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Diagnostics.TraceSource.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Runtime.InteropServices.RuntimeInformation.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.IO.Compression.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.IO.Pipes.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Linq.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Xml.ReaderWriter.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Xml.XmlDocument.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Security.Cryptography.X509Certificates \
			-reference:${LOCALBASE}/lib/coreclr/System.Text.RegularExpressions.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Threading.dll \
			-reference:${LOCALBASE}/lib/coreclr/System.Threading.Tasks.Dataflow.dll \
			-reference:${LOCALBASE}/lib/coreclr/Microsoft.Build.Framework.dll \
			-resource:src/XMakeBuildEngine/Resources/${PORTNAME}.Resources.Strings.resources \
			-define:BUILD_ENGINE \
			-define:FEATURE_SECURITY_PERMISSIONS \
			-define:FEATURE_MSBUILD_DEBUGGER \
			-define:FEATURE_STRONG_NAMES \
			-define:STANDALONEBUILD \
			-define:FEATURE_APPDOMAIN_UNHANDLED_EXCEPTION \
			-define:FEATURE_TASK_GENERATERESOURCES \
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
			-define:FEATURE_MULTIPLE_TOOLSETS \
			-define:FEATURE_TYPE_INVOKEMEMBER \
			-define:FEATURE_TYPE_GETINTERFACE \
			-define:FEATURE_VARIOUS_EXCEPTIONS \
			-define:FEATURE_XML_SOURCE_URI \
			-define:FEATURE_XMLTEXTREADER \
			-define:FEATURE_DEBUGGER \
			-define:NETSTANDARD1_3 \
			-target:library \
			-warn:4 \
			src/Shared/NodeEndpointOutOfProcBase.cs \
			src/Shared/ConversionUtilities.cs \
			src/Shared/NodePacketFactory.cs \
			src/Shared/FxCopExclusions/Microsoft.Build.Shared.Suppressions.cs \
			src/Shared/TempFileUtilities.cs \
			src/Shared/NodeEngineShutdownReason.cs \
			src/Shared/TaskHostConfiguration.cs \
			src/Shared/TaskEngineAssemblyResolver.cs \
			src/Shared/OpportunisticIntern.cs \
			src/Shared/INodePacket.cs \
			src/Shared/FileUtilities.cs \
			src/Shared/TaskHostTaskCancelled.cs \
			src/Shared/ExceptionHandling.cs \
			src/Shared/VisualStudioConstants.cs \
			src/Shared/ReadOnlyEmptyDictionary.cs \
			src/Shared/RegistryDelegates.cs \
			src/Shared/ReadOnlyEmptyList.cs \
			src/Shared/HybridDictionary.cs \
			src/Shared/InprocTrackingNativeMethods.cs \
			src/Shared/NativeMethodsShared.cs \
			src/Shared/NGen.cs \
			src/Shared/ErrorUtilities.cs \
			src/Shared/IElementLocation.cs \
			src/Shared/TaskLoader.cs \
			src/Shared/TaskLoggingHelperExtension.cs \
			src/Shared/NodeShutdown.cs \
			src/Shared/ToolsetElement.cs \
			src/Shared/CopyOnWriteDictionary.cs \
			src/Shared/LoadedType.cs \
			src/Shared/INodePacketTranslator.cs \
			src/Shared/VersionUtilities.cs \
			src/Shared/AssemblyLoadInfo.cs \
			src/Shared/FileMatcher.cs \
			src/Shared/ProjectFileErrorUtilities.cs \
			src/Shared/TypeLoader.cs \
			src/Shared/FrameworkLocationHelper.cs \
			src/Shared/IKeyed.cs \
			src/Shared/XMakeElements.cs \
			src/Shared/FileUtilitiesRegex.cs \
			src/Shared/INodeEndpoint.cs \
			src/Shared/EscapingUtilities.cs \
			src/Shared/InternalErrorException.cs \
			src/Shared/Constants.cs \
			src/Shared/AssemblyNameComparer.cs \
			src/Shared/INodePacketHandler.cs \
			src/Shared/INodePacketFactory.cs \
			src/Shared/AwaitExtensions.cs \
			src/Shared/ResourceUtilities.cs \
			src/Shared/PropertyParser.cs \
			src/Shared/MetadataConversionUtilities.cs \
			src/Shared/LanguageParser/StreamMappedString.cs \
			src/Shared/LanguageParser/token.cs \
			src/Shared/LanguageParser/CSharptokenizer.cs \
			src/Shared/LanguageParser/VisualBasictokenizer.cs \
			src/Shared/LanguageParser/tokenChar.cs \
			src/Shared/LanguageParser/VisualBasictokenCharReader.cs \
			src/Shared/LanguageParser/CSharptokenEnumerator.cs \
			src/Shared/LanguageParser/tokenCharReader.cs \
			src/Shared/LanguageParser/VisualBasictokenEnumerator.cs \
			src/Shared/LanguageParser/tokenEnumerator.cs \
			src/Shared/LanguageParser/CSharptokenCharReader.cs \
			src/Shared/QuotingUtilities.cs \
			src/Shared/Pair.cs \
			src/Shared/Modifiers.cs \
			src/Shared/TaskParameter.cs \
			src/Shared/AssemblyNameExtension.cs \
			src/Shared/AssemblyNameReverseVersionComparer.cs \
			src/Shared/ReuseableStringBuilder.cs \
			src/Shared/XMakeAttributes.cs \
			src/Shared/StringBuilderCache.cs \
			src/Shared/INodePacketTranslatable.cs \
			src/Shared/ReadOnlyCollection.cs \
			src/Shared/FileDelegates.cs \
			src/Shared/MSBuildNameIgnoreCaseComparer.cs \
			src/Shared/ReadOnlyEmptyCollection.cs \
			src/Shared/Tracing.cs \
			src/Shared/ThreadPoolExtensions.cs \
			src/Shared/TaskHostTaskComplete.cs \
			src/Shared/ProjectWriter.cs \
			src/Shared/CommunicationsUtilities.cs \
			src/Shared/TaskLoggingHelper.cs \
			src/Shared/OutOfProcTaskHostTaskResult.cs \
			src/Shared/LogMessagePacketBase.cs \
			src/Shared/BuildEventFileInfo.cs \
			src/Shared/TaskParameterTypeVerifier.cs \
			src/Shared/NodeBuildComplete.cs \
			src/Shared/ExtensionFoldersRegistryKey.cs \
			src/Shared/EventArgsFormatting.cs \
			src/Shared/XmlUtilities.cs \
			src/Shared/NodePacketTranslator.cs \
			src/Shared/EncodingUtilities.cs \
			src/Shared/RegisteredTaskObjectCacheBase.cs \
			src/Shared/CollectionHelpers.cs \
			src/Shared/CanonicalError.cs \
			src/Shared/InterningBinaryReader.cs \
			src/Shared/ProjectErrorUtilities.cs

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/${PORTNAME}.dll ${STAGEDIR}${PREFIX}/lib/coreclr/${PORTNAME}.dll
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


