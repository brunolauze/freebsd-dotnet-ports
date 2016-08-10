
PORTNAME=      	roslyn
PORTVERSION=    1.0.0.0
CATEGORIES=     dotnet devel

VALID_CATEGORIES+=dotnet

MAINTAINER=     brunolauze@msn.com

USES=           metaport

RUN_DEPENDS+=   coreclr>=1.0:${PORTSDIR}/dotnet/coreclr \
		Microsoft.CodeAnalysis>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis \
		Microsoft.CodeAnalysis.CSharp>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp \
		Microsoft.CodeAnalysis.CSharp.CommandLine>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp.CommandLine \
		Microsoft.CodeAnalysis.CSharp.CommandLineProxy>=1.0:${PORTSDIR}/dotnet/Microsoft.CodeAnalysis.CSharp.CommandLineProxy

.include <bsd.port.mk>
