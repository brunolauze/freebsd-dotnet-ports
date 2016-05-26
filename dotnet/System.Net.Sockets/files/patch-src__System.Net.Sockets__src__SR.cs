--- src/System.Net.Sockets/src/SR.cs.orig	2016-04-25 21:36:01.834188000 -0400
+++ src/System.Net.Sockets/src/SR.cs	2016-04-25 21:36:45.016008000 -0400
@@ -0,0 +1,550 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.Sockets
+{
+    internal static class SR
+    {
+
+    }
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.Net.Sockets.SR";
+
+	internal static string net_sockets_accept_receive_notsupported
+	{
+	    get
+	    {
+		return SR.GetResourceString("net_sockets_accept_receive_notsupported", null);
+	    }
+	}
+
+        internal static String ArgumentOutOfRange_Bounds_Lower_Upper
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Bounds_Lower_Upper", null);
+            }
+        }
+
+        internal static String event_Accepted
+        {
+            get
+            {
+                return SR.GetResourceString("event_Accepted", null);
+            }
+        }
+
+        internal static String event_ConnectedAsyncDns
+        {
+            get
+            {
+                return SR.GetResourceString("event_ConnectedAsyncDns", null);
+            }
+        }
+
+        internal static String event_NotLoggedFile
+        {
+            get
+            {
+                return SR.GetResourceString("event_NotLoggedFile", null);
+            }
+        }
+
+        internal static String net_ambiguousbuffers
+        {
+            get
+            {
+                return SR.GetResourceString("net_ambiguousbuffers", null);
+            }
+        }
+
+        internal static String net_buffercounttoosmall
+        {
+            get
+            {
+                return SR.GetResourceString("net_buffercounttoosmall", null);
+            }
+        }
+
+        internal static String net_completed_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_completed_result", null);
+            }
+        }
+
+        internal static String net_InvalidAddressFamily
+        {
+            get
+            {
+                return SR.GetResourceString("net_InvalidAddressFamily", null);
+            }
+        }
+
+        internal static String net_invalidAddressList
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalidAddressList", null);
+            }
+        }
+
+        internal static String net_InvalidEndPointAddressFamily
+        {
+            get
+            {
+                return SR.GetResourceString("net_InvalidEndPointAddressFamily", null);
+            }
+        }
+
+        internal static String net_InvalidSocketAddressSize
+        {
+            get
+            {
+                return SR.GetResourceString("net_InvalidSocketAddressSize", null);
+            }
+        }
+
+        internal static String net_InvalidSocketHandle
+        {
+            get
+            {
+                return SR.GetResourceString("net_InvalidSocketHandle", null);
+            }
+        }
+
+        internal static String net_invalidversion
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalidversion", null);
+            }
+        }
+
+        internal static String net_invasync
+        {
+            get
+            {
+                return SR.GetResourceString("net_invasync", null);
+            }
+        }
+
+        internal static String net_io_connectionclosed
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_connectionclosed", null);
+            }
+        }
+
+        internal static String net_io_invalidasyncresult
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidasyncresult", null);
+            }
+        }
+
+        internal static String net_io_invalidendcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidendcall", null);
+            }
+        }
+
+        internal static String net_io_readfailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_readfailure", null);
+            }
+        }
+
+        internal static String net_io_timeout_use_gt_zero
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_timeout_use_gt_zero", null);
+            }
+        }
+
+        internal static String net_io_writefailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_writefailure", null);
+            }
+        }
+
+        internal static String net_log_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_exception", null);
+            }
+        }
+
+        internal static String net_log_socket_connected
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_socket_connected", null);
+            }
+        }
+
+        internal static String net_multibuffernotsupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_multibuffernotsupported", null);
+            }
+        }
+
+        internal static String net_noseek
+        {
+            get
+            {
+                return SR.GetResourceString("net_noseek", null);
+            }
+        }
+
+        internal static String net_notconnected
+        {
+            get
+            {
+                return SR.GetResourceString("net_notconnected", null);
+            }
+        }
+
+        internal static String net_notstream
+        {
+            get
+            {
+                return SR.GetResourceString("net_notstream", null);
+            }
+        }
+
+        internal static String net_protocol_invalid_family
+        {
+            get
+            {
+                return SR.GetResourceString("net_protocol_invalid_family", null);
+            }
+        }
+
+        internal static String net_protocol_invalid_multicast_family
+        {
+            get
+            {
+                return SR.GetResourceString("net_protocol_invalid_multicast_family", null);
+            }
+        }
+
+        internal static String net_readonlystream
+        {
+            get
+            {
+                return SR.GetResourceString("net_readonlystream", null);
+            }
+        }
+
+        internal static String net_socketopinprogress
+        {
+            get
+            {
+                return SR.GetResourceString("net_socketopinprogress", null);
+            }
+        }
+
+        internal static String net_sockets_blocking
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_blocking", null);
+            }
+        }
+
+        internal static String net_sockets_connect_multiaddress_notsupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_connect_multiaddress_notsupported", null);
+            }
+        }
+
+        internal static String net_sockets_connect_multiconnect_notsupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_connect_multiconnect_notsupported", null);
+            }
+        }
+
+	internal static String net_sockets_dualmode_receivefrom_notsupported
+	{
+	    get
+	    {
+		return SR.GetResourceString("net_sockets_dualmode_receivefrom_notsupported", null);
+	    }
+	}
+
+        internal static String net_sockets_disconnectedAccept
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_disconnectedAccept", null);
+            }
+        }
+
+        internal static String net_sockets_disconnectedConnect
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_disconnectedConnect", null);
+            }
+        }
+
+        internal static String net_sockets_empty_select
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_empty_select", null);
+            }
+        }
+
+        internal static String net_sockets_invalid_dnsendpoint
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_invalid_dnsendpoint", null);
+            }
+        }
+
+        internal static String net_sockets_invalid_ipaddress_length
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_invalid_ipaddress_length", null);
+            }
+        }
+
+        internal static String net_sockets_invalid_optionValue
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_invalid_optionValue", null);
+            }
+        }
+
+        internal static String net_sockets_invalid_optionValue_all
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_invalid_optionValue_all", null);
+            }
+        }
+
+        internal static String net_sockets_mustbind
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_mustbind", null);
+            }
+        }
+
+        internal static String net_sockets_mustlisten
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_mustlisten", null);
+            }
+        }
+
+        internal static String net_sockets_mustnotbebound
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_mustnotbebound", null);
+            }
+        }
+
+        internal static String net_sockets_mustnotlisten
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_mustnotlisten", null);
+            }
+        }
+
+        internal static String net_sockets_namedmustnotbebound
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_namedmustnotbebound", null);
+            }
+        }
+
+        internal static String net_sockets_select
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_select", null);
+            }
+        }
+
+        internal static String net_sockets_toolarge_select
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_toolarge_select", null);
+            }
+        }
+
+        internal static String net_sockets_useblocking
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_useblocking", null);
+            }
+        }
+
+        internal static String net_sockets_zerolist
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_zerolist", null);
+            }
+        }
+
+        internal static String net_stopped
+        {
+            get
+            {
+                return SR.GetResourceString("net_stopped", null);
+            }
+        }
+
+        internal static String net_tcplistener_mustbestopped
+        {
+            get
+            {
+                return SR.GetResourceString("net_tcplistener_mustbestopped", null);
+            }
+        }
+
+        internal static String net_udpconnected
+        {
+            get
+            {
+                return SR.GetResourceString("net_udpconnected", null);
+            }
+        }
+
+        internal static String net_value_cannot_be_negative
+        {
+            get
+            {
+                return SR.GetResourceString("net_value_cannot_be_negative", null);
+            }
+        }
+
+        internal static String net_writeonlystream
+        {
+            get
+            {
+                return SR.GetResourceString("net_writeonlystream", null);
+            }
+        }
+
+        private static ResourceManager ResourceManager
+        {
+            get
+            {
+                if (SR.s_resourceManager == null)
+                {
+                    SR.s_resourceManager = new ResourceManager(SR.ResourceType);
+                }
+                return SR.s_resourceManager;
+            }
+        }
+
+        internal static Type ResourceType
+        {
+            get
+            {
+                return typeof(FxResources.System.Net.Sockets.SR);
+            }
+        }
+
+        internal static String Format(String resourceFormat, params Object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, args);
+            }
+            return String.Concat(resourceFormat, String.Join(", ", args));
+        }
+
+        internal static String Format(String resourceFormat, Object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2, p3);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static String GetResourceString(String resourceKey, String defaultString)
+        {
+            String str = null;
+            try
+            {
+                str = SR.ResourceManager.GetString(resourceKey);
+            }
+            catch (MissingManifestResourceException missingManifestResourceException)
+            {
+            }
+            if (defaultString != null && resourceKey.Equals(str))
+            {
+                return defaultString;
+            }
+            return str;
+        }
+
+        private static Boolean UsingResourceKeys()
+        {
+            return false;
+        }
+    }
+}
