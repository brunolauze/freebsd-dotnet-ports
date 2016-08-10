# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	System.Net.NetworkInformation
PORTVERSION=	1.0.0.0

NET_DEPENDS+=	Microsoft.Win32.Primitives>=1.0:${PORTSDIR}/dotnet/Microsoft.Win32.Primitives \
		System.Collections>=1.0:${PORTSDIR}/dotnet/System.Collections \
		System.Diagnostics.Debug>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.Debug \
		System.Diagnostics.DiagnosticSource>=1.0:${PORTSDIR}/dotnet/System.Diagnostics.DiagnosticSource \
		System.IO>=1.0:${PORTSDIR}/dotnet/System.IO \
		System.IO.FileSystem>=1.0:${PORTSDIR}/dotnet/System.IO.FileSystem \
		System.IO.Compression>=1.0:${PORTSDIR}/dotnet/System.IO.Compression \
		System.Net.Primitives>=1.0:${PORTSDIR}/dotnet/System.Net.Primitives \
		System.Linq>=1.0:${PORTSDIR}/dotnet/System.Linq \
		System.Private.Uri>=1.0:${PORTSDIR}/dotnet/System.Private.Uri \
		System.Runtime>=1.0:${PORTSDIR}/dotnet/System.Runtime \
		System.Runtime.Extensions>=1.0:${PORTSDIR}/dotnet/System.Runtime.Extensions \
		System.Security.Cryptography.Algorithms>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Algorithms \
		System.Security.Cryptography.Encoding>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Encoding \
		System.Security.Cryptography.Primitives>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.Primitives \
		System.Security.Cryptography.OpenSsl>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.OpenSsl \
		System.Security.Cryptography.X509Certificates>=1.0:${PORTSDIR}/dotnet/System.Security.Cryptography.X509Certificates

post-patch:
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*Windows.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*Win32*.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*Linux*.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*Osx*.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*OSX*.cs" -delete
	@${FIND} ${WRKSRC}/src/${PORTNAME}/src -name "*NetNative*.cs" -delete
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SafeCancelMibChangeNotify.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SafeFreeMibTable.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemGatewayIPAddressInformation.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIcmpV4Statistics.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIcmpV6Statistics.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPAddressInformation.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPGlobalProperties.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPGlobalStatistics.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPInterfaceProperties.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPInterfaceStatistics.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPv4InterfaceProperties.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemIPv6InterfaceProperties.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemMulticastIPAddressInformation.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemNetworkInterface.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemTcpConnection.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemTcpStatistics.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemUdpStatistics.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/SystemUnicastIPAddressInformation.cs
	@${RM} ${WRKSRC}/src/System.Net.NetworkInformation/src/System/Net/NetworkInformation/TeredoHelper.cs

DOTNET_REFERENCES+=	-reference:${LOCALBASE}/lib/dotnet/Microsoft.Win32.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Collections.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.Debug.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Diagnostics.DiagnosticSource.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.FileSystem.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.IO.Compression.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Linq.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Net.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Runtime.Extensions.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Private.Uri.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Algorithms.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Encoding.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.Primitives.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.OpenSsl.dll \
			-reference:${LOCALBASE}/lib/dotnet/System.Security.Cryptography.X509Certificates.dll

DOTNET_DEFINES+=	-define:FEATURE_CORECLR

DOTNET_FILES+=		${WRKSRC}/src/Common/src/System/NotImplemented.cs \
			${WRKSRC}/src/Common/src/System/Net/NetworkInformation/HostInformation.cs \
			${WRKSRC}/src/Common/src/System/Net/NetworkInformation/NetworkInformationException.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Libraries.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.EnumerateInterfaceAddresses.cs \
			${WRKSRC}/src/Common/src/System/Net/NetworkInformation/HostInformationPal.Unix.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetDomainName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.GetHostName.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/System.Native/Interop.MapTcpState.cs \
			${WRKSRC}/src/Common/src/Interop/Unix/Interop.Errors.cs \
			${WRKSRC}/src/Common/src/System/Threading/Tasks/TaskToApm.cs \
			${WRKSRC}/src/Common/src/System/IO/RowConfigReader.cs \
			${WRKSRC}/src/Common/src/System/IO/StringParser.cs

.include <../../dotnet/coreclr/corefx.common>
