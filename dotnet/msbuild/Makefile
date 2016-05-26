# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	msbuild
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
		Microsoft.Build>=1.0:${PORTSDIR}/dotnet/Microsoft.Build \
		Microsoft.Build.Tasks.Core>=1.0:${PORTSDIR}/dotnet/Microsoft.Build.Tasks.Core

USE_GITHUB=	yes
GH_ACCOUNT=	Microsoft
GH_PROJECT=	msbuild

USES=           dotnet

post-patch:
	@rm -rf ${WRKSRC}/src/XMakeCommandLine/UnitTests
	@rm -rf ${WRKSRC}/src/XMakeCommandLine/MSBuildTaskHost
	@rm -rf ${WRKSRC}/src/XMakeCommandLine/clr2

configure:

do-configure:

build:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/bin
	@mkdir -p ${STAGEDIR}${PREFIX}/lib
	@mkdir -p ${STAGEDIR}${PREFIX}/lib/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@mkdir -p ${WRKSRC}/bin
	@mkdir -p ${WRKSRC}/bin/Release
	@cd ${WRKSRC}/src/XMakeCommandLine && resgen /useSourcePath /compile Strings.resx,MSBuild.Strings.resources
	@cd ${WRKSRC}/src/Shared && resgen /useSourcePath /compile Strings.shared.resx,MSBuild.Strings.shared.resources
	@cd ${WRKSRC} && ${FIND} src/XMakeCommandLine -name "*.cs" | ${XARGS} ${LOCALBASE}/bin/mcs -nostdlib -noconfig -codepage:65001 -debug:pdbonly -optimize+ -unsafe+ \
			-keyfile:${PATCHDIR}/mono.snk \
			-out:bin/Release/MSBuild.exe \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.CoreLib.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Configuration.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Core.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xaml.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Xml.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Reflection.Metadata.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Build.Framework.dll \
			-reference:${LOCALBASE}/lib/dotnet/Microsoft.Build.dll \
			-resource:src/Shared/MSBuild.Strings.shared.resources \
			-resource:src/XMakeCommandLine/MSBuild.Strings.resources \
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
			-target:exe \
			-warn:4 \
			src/Shared/FxCopExclusions/Microsoft.Build.Shared.Suppressions.cs \
			src/Shared/AssemblyNameComparer.cs \
			src/Shared/CollectionHelpers.cs \
			src/Shared/Constants.cs \
			src/Shared/FileDelegates.cs \
			src/Shared/FileUtilities.cs \
			src/Shared/FileUtilitiesRegex.cs \
			src/Shared/QuotingUtilities.cs \
			src/Shared/RegisteredTaskObjectCacheBase.cs \
			src/Shared/ResourceUtilities.cs \
			src/Shared/EscapingUtilities.cs \
			src/Shared/ErrorUtilities.cs \
			src/Shared/Modifiers.cs \
			src/Shared/CopyOnWriteDictionary.cs \
			src/Shared/HybridDictionary.cs \
			src/Shared/ReadOnlyEmptyCollection.cs \
			src/Shared/ReadOnlyEmptyDictionary.cs \
			src/Shared/ReadOnlyEmptyList.cs \
			src/Shared/NativeMethodsShared.cs \
			src/Shared/ExceptionHandling.cs \
			src/Shared/InternalErrorException.cs \
			src/Shared/EventArgsFormatting.cs \
			src/Shared/TempFileUtilities.cs \
			src/Shared/XMakeAttributes.cs \
			src/Shared/INodeEndpoint.cs \
			src/Shared/NodeEndpointOutOfProcBase.cs \
			src/Shared/INodePacket.cs \
			src/Shared/LogMessagePacketBase.cs \
			src/Shared/INodePacketFactory.cs \
			src/Shared/NodePacketFactory.cs \
			src/Shared/INodePacketHandler.cs \
			src/Shared/INodePacketTranslatable.cs \
			src/Shared/INodePacketTranslator.cs \
			src/Shared/NodePacketTranslator.cs \
			src/Shared/CommunicationsUtilities.cs \
			src/Shared/InterningBinaryReader.cs \
			src/Shared/OpportunisticIntern.cs \
			src/Shared/TaskHostConfiguration.cs \
			src/Shared/TaskHostTaskComplete.cs \
			src/Shared/OutOfProcTaskHostTaskResult.cs \
			src/Shared/TaskHostTaskCancelled.cs \
			src/Shared/TaskLoader.cs \
			src/Shared/TypeLoader.cs \
			src/Shared/LoadedType.cs \
			src/Shared/AssemblyLoadInfo.cs \
			src/Shared/NodeBuildComplete.cs \
			src/Shared/NodeShutdown.cs \
			src/Shared/TaskParameter.cs \
			src/Shared/TaskParameterTypeVerifier.cs \
			src/Shared/TaskEngineAssemblyResolver.cs \
			src/Shared/AssemblyNameExtension.cs \
			src/Shared/ThreadPoolExtensions.cs \
			src/Shared/StringBuilderCache.cs \

do-install:
	@${INSTALL_DATA} ${WRKSRC}/bin/Release/MSBuild.exe ${STAGEDIR}${PREFIX}/lib/dotnet/MSBuild.exe
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeCommandLine/app.config ${STAGEDIR}${PREFIX}/lib/dotnet/MSBuild.exe.config
	@${INSTALL_SCRIPT} ${PATCHDIR}/msbuild ${STAGEDIR}${PREFIX}/bin/msbuild
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.WorkflowBuildExtensions.Shim.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.WorkflowBuildExtensions.Shim.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.ServiceModel.Shim.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.ServiceModel.Shim.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.Common.CurrentVersion.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.Common.CurrentVersion.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.Data.Entity.Shim.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.Data.Entity.Shim.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.NETFramework.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.NETFramework.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.CSharp.CurrentVersion.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.CSharp.CurrentVersion.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.VisualBasic.CurrentVersion.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.VisualBasic.CurrentVersion.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.Xaml.Shim.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.Xaml.Shim.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.Common.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.Common.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.VisualBasic.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.VisualBasic.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.NETFramework.CurrentVersion.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.NETFramework.CurrentVersion.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.CSharp.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.CSharp.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.WinFx.Shim.targets ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.WinFx.Shim.targets
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.NETFramework.props ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.NETFramework.props
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.NETFramework.CurrentVersion.props ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.NETFramework.CurrentVersion.props
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.VisualStudioVersion.v12.Common.props ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.VisualStudioVersion.v12.Common.props
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.VisualStudioVersion.v11.Common.props ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.VisualStudioVersion.v11.Common.props
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.VisualStudioVersion.v14.Common.props ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.VisualStudioVersion.v14.Common.props
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.Common.overridetasks ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.Common.overridetasks
	@${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Workflow.VisualBasic.Shim.Targets ${STAGEDIR}${PREFIX}/lib/dotnet/Workflow.VisualBasic.Shim.Targets
	${INSTALL_DATA} ${WRKSRC}/src/XMakeTasks/Microsoft.Common.tasks ${STAGEDIR}${PREFIX}/lib/dotnet/Microsoft.Common.tasks
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <bsd.port.mk>


