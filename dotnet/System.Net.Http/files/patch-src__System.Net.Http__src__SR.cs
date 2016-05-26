--- src/System.Net.Http/src/SR.cs.orig	2016-04-26 19:33:55.922338000 -0400
+++ src/System.Net.Http/src/SR.cs	2016-04-26 19:34:36.495649000 -0400
@@ -0,0 +1,766 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.Http
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
+        private const String s_resourcesName = "FxResources.System.Net.Http.SR";
+
+	internal static string net_http_unix_handler_disposed
+	{
+		get 
+		{
+			return GetResourceString("net_http_unix_handler_disposed", null);
+		}
+	}
+
+	internal static string net_http_unix_invalid_certcallback_option
+	{
+		get 
+		{
+			return GetResourceString("net_http_unix_invalid_certcallback_option", null);
+		}
+	}
+	
+	internal static string net_http_response_headers_exceeded_length
+	{
+		get 
+		{
+			return GetResourceString("net_http_response_headers_exceeded_length", null);
+		}
+	}
+
+	internal static String net_http_buffer_insufficient_length
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_buffer_insufficient_length", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_FileLengthTooBig
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", null);
+            }
+        }
+
+        internal static String event_ClientSendCompleted
+        {
+            get
+            {
+                return SR.GetResourceString("event_ClientSendCompleted", null);
+            }
+        }
+
+        internal static String event_ContentNull
+        {
+            get
+            {
+                return SR.GetResourceString("event_ContentNull", null);
+            }
+        }
+
+        internal static String event_HeadersInvalidValue
+        {
+            get
+            {
+                return SR.GetResourceString("event_HeadersInvalidValue", null);
+            }
+        }
+
+        internal static String InvalidHeaderName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidHeaderName", null);
+            }
+        }
+
+        internal static String IO_FileExists_Name
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileExists_Name", null);
+            }
+        }
+
+        internal static String IO_FileNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileNotFound", null);
+            }
+        }
+
+        internal static String IO_FileNotFound_FileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileNotFound_FileName", null);
+            }
+        }
+
+        internal static String IO_PathNotFound_NoPathName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathNotFound_NoPathName", null);
+            }
+        }
+
+        internal static String IO_PathNotFound_Path
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathNotFound_Path", null);
+            }
+        }
+
+        internal static String IO_PathTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathTooLong", null);
+            }
+        }
+
+        internal static String IO_SharingViolation_File
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SharingViolation_File", null);
+            }
+        }
+
+        internal static String IO_SharingViolation_NoFileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SharingViolation_NoFileName", null);
+            }
+        }
+
+        internal static String MailAddressInvalidFormat
+        {
+            get
+            {
+                return SR.GetResourceString("MailAddressInvalidFormat", null);
+            }
+        }
+
+        internal static String MailHeaderFieldInvalidCharacter
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderFieldInvalidCharacter", null);
+            }
+        }
+
+        internal static String MailHeaderFieldMalformedHeader
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderFieldMalformedHeader", null);
+            }
+        }
+
+        internal static String net_cookie_attribute
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_attribute", null);
+            }
+        }
+
+        internal static String net_http_argument_empty_string
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_argument_empty_string", null);
+            }
+        }
+
+        internal static String net_http_chunked_not_allowed_with_content_length
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_chunked_not_allowed_with_content_length", null);
+            }
+        }
+
+        internal static String net_http_chunked_not_allowed_with_empty_content
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_chunked_not_allowed_with_empty_content", null);
+            }
+        }
+
+        internal static String net_http_client_absolute_baseaddress_required
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_absolute_baseaddress_required", null);
+            }
+        }
+
+        internal static String net_http_client_execution_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_execution_error", null);
+            }
+        }
+
+        internal static String net_http_client_http_baseaddress_required
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_http_baseaddress_required", null);
+            }
+        }
+
+        internal static String net_http_client_invalid_requesturi
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_invalid_requesturi", null);
+            }
+        }
+
+        internal static String net_http_client_request_already_sent
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_request_already_sent", null);
+            }
+        }
+
+        internal static String net_http_client_send_canceled
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_send_canceled", null);
+            }
+        }
+
+        internal static String net_http_client_send_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_client_send_error", null);
+            }
+        }
+
+        internal static String net_http_content_buffersize_exceeded
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_buffersize_exceeded", null);
+            }
+        }
+
+        internal static String net_http_content_buffersize_limit
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_buffersize_limit", null);
+            }
+        }
+
+        internal static String net_http_content_field_too_long
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_field_too_long", null);
+            }
+        }
+
+        internal static String net_http_content_invalid_charset
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_invalid_charset", null);
+            }
+        }
+
+        internal static String net_http_content_no_concurrent_reads
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_no_concurrent_reads", null);
+            }
+        }
+
+        internal static String net_http_content_no_task_returned
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_no_task_returned", null);
+            }
+        }
+
+        internal static String net_http_content_readonly_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_readonly_stream", null);
+            }
+        }
+
+        internal static String net_http_content_stream_already_read
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_stream_already_read", null);
+            }
+        }
+
+        internal static String net_http_content_stream_copy_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_content_stream_copy_error", null);
+            }
+        }
+
+        internal static String net_http_copyto_array_too_small
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_copyto_array_too_small", null);
+            }
+        }
+
+        internal static String net_http_handler_norequest
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_handler_norequest", null);
+            }
+        }
+
+        internal static String net_http_handler_noresponse
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_handler_noresponse", null);
+            }
+        }
+
+        internal static String net_http_handler_not_assigned
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_handler_not_assigned", null);
+            }
+        }
+
+        internal static String net_http_headers_invalid_etag_name
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_invalid_etag_name", null);
+            }
+        }
+
+        internal static String net_http_headers_invalid_from_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_invalid_from_header", null);
+            }
+        }
+
+        internal static String net_http_headers_invalid_header_name
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_invalid_header_name", null);
+            }
+        }
+
+        internal static String net_http_headers_invalid_host_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_invalid_host_header", null);
+            }
+        }
+
+        internal static String net_http_headers_invalid_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_invalid_range", null);
+            }
+        }
+
+        internal static String net_http_headers_invalid_value
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_invalid_value", null);
+            }
+        }
+
+        internal static String net_http_headers_no_newlines
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_no_newlines", null);
+            }
+        }
+
+        internal static String net_http_headers_not_allowed_header_name
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_not_allowed_header_name", null);
+            }
+        }
+
+        internal static String net_http_headers_not_found
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_not_found", null);
+            }
+        }
+
+        internal static String net_http_headers_single_value_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_headers_single_value_header", null);
+            }
+        }
+
+        internal static String net_http_httpmethod_format_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_httpmethod_format_error", null);
+            }
+        }
+
+        internal static String net_http_invalid_cookiecontainer
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_invalid_cookiecontainer", null);
+            }
+        }
+
+        internal static String net_http_invalid_cookiecontainer_unix
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_invalid_cookiecontainer_unix", null);
+            }
+        }
+
+        internal static String net_http_invalid_enable_first
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_invalid_enable_first", null);
+            }
+        }
+
+        internal static String net_http_invalid_proxy
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_invalid_proxy", null);
+            }
+        }
+
+        internal static String net_http_invalid_proxyusepolicy
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_invalid_proxyusepolicy", null);
+            }
+        }
+
+        internal static String net_http_io_read
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_io_read", null);
+            }
+        }
+
+        internal static String net_http_io_write
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_io_write", null);
+            }
+        }
+
+        internal static String net_http_log_content_no_task_returned_copytoasync
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_log_content_no_task_returned_copytoasync", null);
+            }
+        }
+
+        internal static String net_http_log_headers_invalid_quality
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_log_headers_invalid_quality", null);
+            }
+        }
+
+        internal static String net_http_log_headers_no_newlines
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_log_headers_no_newlines", null);
+            }
+        }
+
+        internal static String net_http_log_headers_wrong_email_format
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_log_headers_wrong_email_format", null);
+            }
+        }
+
+        internal static String net_http_message_not_success_statuscode
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_message_not_success_statuscode", null);
+            }
+        }
+
+        internal static String net_http_no_concurrent_io_allowed
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_no_concurrent_io_allowed", null);
+            }
+        }
+
+        internal static String net_http_operation_started
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_operation_started", null);
+            }
+        }
+
+        internal static String net_http_parser_invalid_base64_string
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_parser_invalid_base64_string", null);
+            }
+        }
+
+        internal static String net_http_reasonphrase_format_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_reasonphrase_format_error", null);
+            }
+        }
+
+        internal static String net_http_unix_https_libcurl_no_versioninfo
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_unix_https_libcurl_no_versioninfo", null);
+            }
+        }
+
+        internal static String net_http_unix_https_libcurl_too_old
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_unix_https_libcurl_too_old", null);
+            }
+        }
+
+        internal static String net_http_unix_https_support_unavailable_libcurl
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_unix_https_support_unavailable_libcurl", null);
+            }
+        }
+
+        internal static String net_http_unix_invalid_client_cert_option
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_unix_invalid_client_cert_option", null);
+            }
+        }
+
+        internal static String net_http_unix_invalid_credential
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_unix_invalid_credential", null);
+            }
+        }
+
+        internal static String net_http_unix_invalid_response
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_unix_invalid_response", null);
+            }
+        }
+
+        internal static String net_http_username_empty_string
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_username_empty_string", null);
+            }
+        }
+
+        internal static String net_http_value_must_be_greater_than
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_value_must_be_greater_than", null);
+            }
+        }
+
+        internal static String net_http_value_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_http_value_not_supported", null);
+            }
+        }
+
+        internal static String net_securityprotocolnotsupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_securityprotocolnotsupported", null);
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
+                return typeof(FxResources.System.Net.Http.SR);
+            }
+        }
+
+        internal static String UnauthorizedAccess_IODenied_NoPathName
+        {
+            get
+            {
+                return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", null);
+            }
+        }
+
+        internal static String UnauthorizedAccess_IODenied_Path
+        {
+            get
+            {
+                return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", null);
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
