# Created by: Bruno Lauze <brunolauze@msn.com>
# $FreeBSD: head/dotnet/Microsoft.Vsa/Makefile 402349 2015-12-10 08:15:09Z bruno $

PORTNAME=	Microsoft.AspNetCore.Routing.DecisionTree.Sources
PORTVERSION=	1.0.0.0
CATEGORIES=	dotnet devel
MAINTAINER=	brunolauze@msn.com

VALID_CATEGORIES+=dotnet #COMMENT=        Open source implementation of .NET Development Framework

GH_PROJECT=	Routing

build:
	@echo "Source files"

do-install:
	@mkdir -p ${STAGEDIR}
	@mkdir -p ${STAGEDIR}/usr
	@mkdir -p ${STAGEDIR}${PREFIX}
	@mkdir -p ${STAGEDIR}${PREFIX}/include
	@mkdir -p ${STAGEDIR}${PREFIX}/include/dotnet
	@mkdir -p ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata
	@mkdir -p ${STAGEDIR}${PREFIX}/libdata/pkgconfig
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/DecisionCriterion.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/DecisionCriterion.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/DecisionCriterionValue.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/DecisionCriterionValue.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/DecisionCriterionValueEqualityComparer.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/DecisionCriterionValueEqualityComparer.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/DecisionTreeBuilder.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/DecisionTreeBuilder.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/DecisionTreeNode.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/DecisionTreeNode.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/IClassifier.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/IClassifier.cs
	@${INSTALL_DATA} ${WRKSRC}/src/${PORTNAME}/ItemDescriptor.cs ${STAGEDIR}${PREFIX}/include/dotnet/${PORTNAME}/ItemDescriptor.cs
	@echo "Name:	${PORTNAME}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Version: ${PORTVERSION}" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc
	@echo "Description:  .NET Assembly" >> ${STAGEDIR}${PREFIX}/libdata/pkgconfig/${PORTNAME}.pc

.include <../../dotnet/aspnet/Makefile.common>

