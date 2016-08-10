# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.CodeAnalysis.CSharp
PORTVERSION=	1.0.0.0

BUILD_DEPENDS+=	${ROSLYN_TOOLS}

NET_DEPENDS+=	System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Collections.Immutable>=1.0:${PORTSDIR}/dotnet/System.Collections.Immutable \
		System.Collections.Concurrent>=1.0:${PORTSDIR}/dotnet/System.Collections.Concurrent \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.Tools>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Tools \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Linq.Expressions>=1.0:${PORTSDIR}/dotnet/System.Linq.Expressions \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Reflection.Metadata>=1.0:${PORTSDIR}/dotnet/System.Reflection.Metadata \
		System.Threading>=1.0:${PORTSDIR}/dotnet/System.Threading \
		System.Threading.Tasks.Parallel>=1.0:${PORTSDIR}/dotnet/System.Threading.Tasks.Parallel \
		System.Xml.XmlSerializer>=1.0:${PORTSDIR}/dotnet/System.Xml.XmlSerializer \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis

ROSLYN_TOOLS+=	Roslyn.Compilers.Internal.BoundTreeGenerator>=1.0:${PORTSDIR}/dotnet/Roslyn.Compilers.Internal.BoundTreeGenerator \
		Roslyn.Compilers.CSharp.Internal.CSharpSyntaxGenerator>=1.0:${PORTSDIR}/dotnet/Roslyn.Compilers.CSharp.Internal.CSharpSyntaxGenerator \
		Roslyn.Compilers.CSharp.Internal.CSharpErrorFactsGenerator>=1.0:${PORTSDIR}/dotnet/Roslyn.Compilers.CSharp.Internal.CSharpErrorFactsGenerator

USE_GITHUB=	yes
GH_ACCOUNT=	dotnet
GH_PROJECT=	roslyn


DOTNET_RESOURCE_COMMAND=cd ${WRKSRC}/src/Compilers/CSharp/Portable && ${DOTNET_RESGEN} CSharpResources.resx,${PORTNAME}.CSharpResources.resources
DOTNET_PREBUILD_COMMAND=cd ${WRKSRC}/src/Compilers/CSharp/Portable && ${LOCALBASE}/bin/roslyn.boundtreegenerator CSharp BoundTree/BoundNodes.xml BoundTree/BoundNodes.Generated.cs && \
			cd ${WRKSRC}/src/Compilers/CSharp/Portable && ${LOCALBASE}/bin/roslyn.csharpsyntaxgenerator Syntax/Syntax.xml Syntax/Syntax.xml.Generated.cs && \
			cd ${WRKSRC}/src/Compilers/CSharp/Portable && ${LOCALBASE}/bin/roslyn.csharperrorfactsgenerator Errors/ErrorCode.cs Errors/ErrorFacts.Generated.cs


post-patch:
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/Utilities/IVsSQM.cs
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/Utilities/SqmServiceProvider.cs
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/Lowering/TempHelpers.cs
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/Compiler/Compiler.cs
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/FlowAnalysis/AbstractFlowPass.AbstractLocalState.cs
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/Lowering/StateMachineRewriter/StateMachineHoistedLocalSymbol.cs
	@${RM} ${WRKSRC}/src/Compilers/CSharp/Portable/Syntax/SyntaxNodeFacts.cs

DOTNET_REFERENCES+=	${DOTNET_REF}:${DOTNET_PATH}/System.Collections.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Concurrent.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Debug.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Diagnostics.Tools.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Linq.Expressions.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Private.Uri.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Runtime.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Collections.Immutable.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.ReaderWriter.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XDocument.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Xml.XmlSerializer.dll \
			${DOTNET_REF}:${DOTNET_PATH}/Microsoft.CodeAnalysis.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Reflection.Metadata.dll \
			${DOTNET_REF}:${DOTNET_PATH}/System.Threading.Tasks.Parallel.dll

DOTNET_RESOURCES+=	${DOTNET_RES}:src/Compilers/CSharp/Portable/${PORTNAME}.CSharpResources.resources

DOTNET_DEFINES+=	-define:COMPILERCORE \
			-define:SRM

DOTNET_FILES+=		src/Compilers/CSharp/CSharpAnalyzerDriver/CSharpDeclarationComputer.cs \
			src/Compilers/Core/Portable/Symbols/TypeCompareKind.cs

.include <../../dotnet/coreclr/Makefile.common>
