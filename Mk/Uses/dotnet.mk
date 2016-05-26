.if ${GH_ACCOUNT} == aspnet
GH_TAGNAME=            	dev
GH_COMMON_TAGNAME=      dev
.else
.if ${GH_PROJECT} == msbuild
GH_TAGNAME=		xplat
GH_COMMON_TAGNAME=	master
.else
.if ${GH_ACCOUNT} == NuGet
GH_TAGNAME=             dev
GH_COMMON_TAGNAME=      dev
.else
GH_TAGNAME=             master
GH_COMMON_TAGNAME=      master
.endif
.endif
.endif

.if ${GH_PROJECT} == cli
GH_TAGNAME=             rel/1.0.0
.endif


DISABLE_SIZE=		yes
NO_CHECKSUM=		yes

