--- /dev/null	2016-03-09 08:46:56.000000000 -0500
+++ src/System.Net.Primitives/src/SR.cs	2016-03-09 08:47:42.805208000 -0500
@@ -0,0 +1,6446 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.Primitives
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
+        private const String s_resourcesName = "FxResources.System.Net.Primitives.SR";
+
+        internal static String ArgumentOutOfRange_Bounds_Lower_Upper
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Bounds_Lower_Upper", null);
+            }
+        }
+
+        internal static String CannotGetEffectiveTimeOfSSPIContext
+        {
+            get
+            {
+                return SR.GetResourceString("CannotGetEffectiveTimeOfSSPIContext", null);
+            }
+        }
+
+        internal static String CannotGetExpiryTimeOfSSPIContext
+        {
+            get
+            {
+                return SR.GetResourceString("CannotGetExpiryTimeOfSSPIContext", null);
+            }
+        }
+
+        internal static String ContentDispositionInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("ContentDispositionInvalid", null);
+            }
+        }
+
+        internal static String ContentTypeInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("ContentTypeInvalid", null);
+            }
+        }
+
+        internal static String dns_bad_ip_address
+        {
+            get
+            {
+                return SR.GetResourceString("dns_bad_ip_address", null);
+            }
+        }
+
+        internal static String InvalidAsyncResult
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidAsyncResult", null);
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
+        internal static String InvalidHeaderValue
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidHeaderValue", null);
+            }
+        }
+
+        internal static String InvalidHexDigit
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidHexDigit", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumFailedVersion
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumFailedVersion", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumOpCantHappen
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null);
+            }
+        }
+
+        internal static String InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple", null);
+            }
+        }
+
+        internal static String InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple", null);
+            }
+        }
+
+        internal static String InvalidPort
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidPort", null);
+            }
+        }
+
+        internal static String InvalidSSPIContext
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidSSPIContext", null);
+            }
+        }
+
+        internal static String InvalidSSPIContextKey
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidSSPIContextKey", null);
+            }
+        }
+
+        internal static String InvalidSSPINegotiationElement
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidSSPINegotiationElement", null);
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
+        internal static String MailBase64InvalidCharacter
+        {
+            get
+            {
+                return SR.GetResourceString("MailBase64InvalidCharacter", null);
+            }
+        }
+
+        internal static String MailCollectionIsReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("MailCollectionIsReadOnly", null);
+            }
+        }
+
+        internal static String MailDateInvalidFormat
+        {
+            get
+            {
+                return SR.GetResourceString("MailDateInvalidFormat", null);
+            }
+        }
+
+        internal static String MailHeaderFieldAlreadyExists
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderFieldAlreadyExists", null);
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
+        internal static String MailHeaderFieldMismatchedName
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderFieldMismatchedName", null);
+            }
+        }
+
+        internal static String MailHeaderIndexOutOfBounds
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderIndexOutOfBounds", null);
+            }
+        }
+
+        internal static String MailHeaderInvalidCID
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderInvalidCID", null);
+            }
+        }
+
+        internal static String MailHeaderItemAccessorOnlySingleton
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderItemAccessorOnlySingleton", null);
+            }
+        }
+
+        internal static String MailHeaderListHasChanged
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderListHasChanged", null);
+            }
+        }
+
+        internal static String MailHeaderResetCalledBeforeEOF
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderResetCalledBeforeEOF", null);
+            }
+        }
+
+        internal static String MailHeaderTargetArrayTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("MailHeaderTargetArrayTooSmall", null);
+            }
+        }
+
+        internal static String MailHostNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("MailHostNotFound", null);
+            }
+        }
+
+        internal static String MailReaderGetContentStreamAlreadyCalled
+        {
+            get
+            {
+                return SR.GetResourceString("MailReaderGetContentStreamAlreadyCalled", null);
+            }
+        }
+
+        internal static String MailReaderTruncated
+        {
+            get
+            {
+                return SR.GetResourceString("MailReaderTruncated", null);
+            }
+        }
+
+        internal static String MailServerDoesNotSupportStartTls
+        {
+            get
+            {
+                return SR.GetResourceString("MailServerDoesNotSupportStartTls", null);
+            }
+        }
+
+        internal static String MailServerResponse
+        {
+            get
+            {
+                return SR.GetResourceString("MailServerResponse", null);
+            }
+        }
+
+        internal static String MailSubjectInvalidFormat
+        {
+            get
+            {
+                return SR.GetResourceString("MailSubjectInvalidFormat", null);
+            }
+        }
+
+        internal static String MailWriterIsInContent
+        {
+            get
+            {
+                return SR.GetResourceString("MailWriterIsInContent", null);
+            }
+        }
+
+        internal static String MediaTypeInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("MediaTypeInvalid", null);
+            }
+        }
+
+        internal static String MimePartCantResetStream
+        {
+            get
+            {
+                return SR.GetResourceString("MimePartCantResetStream", null);
+            }
+        }
+
+        internal static String MimeTransferEncodingNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("MimeTransferEncodingNotSupported", null);
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
+        internal static String net_array_too_small
+        {
+            get
+            {
+                return SR.GetResourceString("net_array_too_small", null);
+            }
+        }
+
+        internal static String net_auth_alert
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_alert", null);
+            }
+        }
+
+        internal static String net_auth_bad_client_creds
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_bad_client_creds", null);
+            }
+        }
+
+        internal static String net_auth_bad_client_creds_or_target_mismatch
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_bad_client_creds_or_target_mismatch", null);
+            }
+        }
+
+        internal static String net_auth_client_server
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_client_server", null);
+            }
+        }
+
+        internal static String net_auth_context_expectation
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_context_expectation", null);
+            }
+        }
+
+        internal static String net_auth_context_expectation_remote
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_context_expectation_remote", null);
+            }
+        }
+
+        internal static String net_auth_empty_read
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_empty_read", null);
+            }
+        }
+
+        internal static String net_auth_eof
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_eof", null);
+            }
+        }
+
+        internal static String net_auth_failure
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_failure", null);
+            }
+        }
+
+        internal static String net_auth_ignored_reauth
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_ignored_reauth", null);
+            }
+        }
+
+        internal static String net_auth_message_not_encrypted
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_message_not_encrypted", null);
+            }
+        }
+
+        internal static String net_auth_must_specify_extended_protection_scheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_must_specify_extended_protection_scheme", null);
+            }
+        }
+
+        internal static String net_auth_no_anonymous_support
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_no_anonymous_support", null);
+            }
+        }
+
+        internal static String net_auth_noauth
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_noauth", null);
+            }
+        }
+
+        internal static String net_auth_noencryption
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_noencryption", null);
+            }
+        }
+
+        internal static String net_auth_reauth
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_reauth", null);
+            }
+        }
+
+        internal static String net_auth_SSPI
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_SSPI", null);
+            }
+        }
+
+        internal static String net_auth_supported_impl_levels
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_supported_impl_levels", null);
+            }
+        }
+
+        internal static String net_authmodulenotregistered
+        {
+            get
+            {
+                return SR.GetResourceString("net_authmodulenotregistered", null);
+            }
+        }
+
+        internal static String net_authschemenotregistered
+        {
+            get
+            {
+                return SR.GetResourceString("net_authschemenotregistered", null);
+            }
+        }
+
+        internal static String net_bad_ip_address_prefix
+        {
+            get
+            {
+                return SR.GetResourceString("net_bad_ip_address_prefix", null);
+            }
+        }
+
+        internal static String net_bad_mac_address
+        {
+            get
+            {
+                return SR.GetResourceString("net_bad_mac_address", null);
+            }
+        }
+
+        internal static String net_baddate
+        {
+            get
+            {
+                return SR.GetResourceString("net_baddate", null);
+            }
+        }
+
+        internal static String net_badmethod
+        {
+            get
+            {
+                return SR.GetResourceString("net_badmethod", null);
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
+        internal static String net_cache_access_denied
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_access_denied", null);
+            }
+        }
+
+        internal static String net_cache_key_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_key_failed", null);
+            }
+        }
+
+        internal static String net_cache_method_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_method_failed", null);
+            }
+        }
+
+        internal static String net_cache_no_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_no_stream", null);
+            }
+        }
+
+        internal static String net_cache_non_seekable_stream_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_non_seekable_stream_not_supported", null);
+            }
+        }
+
+        internal static String net_cache_not_accept_response
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_not_accept_response", null);
+            }
+        }
+
+        internal static String net_cache_not_configured
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_not_configured", null);
+            }
+        }
+
+        internal static String net_cache_not_supported_body
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_not_supported_body", null);
+            }
+        }
+
+        internal static String net_cache_not_supported_command
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_not_supported_command", null);
+            }
+        }
+
+        internal static String net_cache_retrieve_failure
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_retrieve_failure", null);
+            }
+        }
+
+        internal static String net_cache_shadowstream_not_writable
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_shadowstream_not_writable", null);
+            }
+        }
+
+        internal static String net_cache_unsupported_partial_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_unsupported_partial_stream", null);
+            }
+        }
+
+        internal static String net_cache_validator_fail
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_validator_fail", null);
+            }
+        }
+
+        internal static String net_cache_validator_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_cache_validator_result", null);
+            }
+        }
+
+        internal static String net_cannot_be_false
+        {
+            get
+            {
+                return SR.GetResourceString("net_cannot_be_false", null);
+            }
+        }
+
+        internal static String net_cannot_load_proxy_helper
+        {
+            get
+            {
+                return SR.GetResourceString("net_cannot_load_proxy_helper", null);
+            }
+        }
+
+        internal static String net_cant_create_environment
+        {
+            get
+            {
+                return SR.GetResourceString("net_cant_create_environment", null);
+            }
+        }
+
+        internal static String net_cant_determine_osinstalltype
+        {
+            get
+            {
+                return SR.GetResourceString("net_cant_determine_osinstalltype", null);
+            }
+        }
+
+        internal static String net_cant_perform_during_shutdown
+        {
+            get
+            {
+                return SR.GetResourceString("net_cant_perform_during_shutdown", null);
+            }
+        }
+
+        internal static String net_clsmall
+        {
+            get
+            {
+                return SR.GetResourceString("net_clsmall", null);
+            }
+        }
+
+        internal static String net_collection_readonly
+        {
+            get
+            {
+                return SR.GetResourceString("net_collection_readonly", null);
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
+        internal static String net_config_authenticationmodules
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_authenticationmodules", null);
+            }
+        }
+
+        internal static String net_config_element_permission
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_element_permission", null);
+            }
+        }
+
+        internal static String net_config_property_permission
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_property_permission", null);
+            }
+        }
+
+        internal static String net_config_proxy
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_proxy", null);
+            }
+        }
+
+        internal static String net_config_proxy_module_not_public
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_proxy_module_not_public", null);
+            }
+        }
+
+        internal static String net_config_requestcaching
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_requestcaching", null);
+            }
+        }
+
+        internal static String net_config_section_permission
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_section_permission", null);
+            }
+        }
+
+        internal static String net_config_webrequestmodules
+        {
+            get
+            {
+                return SR.GetResourceString("net_config_webrequestmodules", null);
+            }
+        }
+
+        internal static String net_connarg
+        {
+            get
+            {
+                return SR.GetResourceString("net_connarg", null);
+            }
+        }
+
+        internal static String net_connclosed
+        {
+            get
+            {
+                return SR.GetResourceString("net_connclosed", null);
+            }
+        }
+
+        internal static String net_container_add_cookie
+        {
+            get
+            {
+                return SR.GetResourceString("net_container_add_cookie", null);
+            }
+        }
+
+        internal static String net_contentlengthmissing
+        {
+            get
+            {
+                return SR.GetResourceString("net_contentlengthmissing", null);
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
+        internal static String net_cookie_capacity_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_capacity_range", null);
+            }
+        }
+
+        internal static String net_cookie_exists
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_exists", null);
+            }
+        }
+
+        internal static String net_cookie_format
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_format", null);
+            }
+        }
+
+        internal static String net_cookie_invalid
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_invalid", null);
+            }
+        }
+
+        internal static String net_cookie_parse_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_parse_header", null);
+            }
+        }
+
+        internal static String net_cookie_size
+        {
+            get
+            {
+                return SR.GetResourceString("net_cookie_size", null);
+            }
+        }
+
+        internal static String net_empty_osinstalltype
+        {
+            get
+            {
+                return SR.GetResourceString("net_empty_osinstalltype", null);
+            }
+        }
+
+        internal static String net_emptystringcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_emptystringcall", null);
+            }
+        }
+
+        internal static String net_emptystringset
+        {
+            get
+            {
+                return SR.GetResourceString("net_emptystringset", null);
+            }
+        }
+
+        internal static String net_entire_body_not_written
+        {
+            get
+            {
+                return SR.GetResourceString("net_entire_body_not_written", null);
+            }
+        }
+
+        internal static String net_entitytoobig
+        {
+            get
+            {
+                return SR.GetResourceString("net_entitytoobig", null);
+            }
+        }
+
+        internal static String net_format_shexp
+        {
+            get
+            {
+                return SR.GetResourceString("net_format_shexp", null);
+            }
+        }
+
+        internal static String net_frame_max_size
+        {
+            get
+            {
+                return SR.GetResourceString("net_frame_max_size", null);
+            }
+        }
+
+        internal static String net_frame_read_io
+        {
+            get
+            {
+                return SR.GetResourceString("net_frame_read_io", null);
+            }
+        }
+
+        internal static String net_frame_read_size
+        {
+            get
+            {
+                return SR.GetResourceString("net_frame_read_size", null);
+            }
+        }
+
+        internal static String net_frame_size
+        {
+            get
+            {
+                return SR.GetResourceString("net_frame_size", null);
+            }
+        }
+
+        internal static String net_fromto
+        {
+            get
+            {
+                return SR.GetResourceString("net_fromto", null);
+            }
+        }
+
+        internal static String net_ftp_active_address_different
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_active_address_different", null);
+            }
+        }
+
+        internal static String net_ftp_invalid_method_name
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_invalid_method_name", null);
+            }
+        }
+
+        internal static String net_ftp_invalid_renameto
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_invalid_renameto", null);
+            }
+        }
+
+        internal static String net_ftp_invalid_response_filename
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_invalid_response_filename", null);
+            }
+        }
+
+        internal static String net_ftp_invalid_status_response
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_invalid_status_response", null);
+            }
+        }
+
+        internal static String net_ftp_invalid_uri
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_invalid_uri", null);
+            }
+        }
+
+        internal static String net_ftp_no_defaultcreds
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_no_defaultcreds", null);
+            }
+        }
+
+        internal static String net_ftp_no_http_cmd
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_no_http_cmd", null);
+            }
+        }
+
+        internal static String net_ftp_no_offsetforhttp
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_no_offsetforhttp", null);
+            }
+        }
+
+        internal static String net_ftp_proxy_does_not_support_ssl
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_proxy_does_not_support_ssl", null);
+            }
+        }
+
+        internal static String net_ftp_response_invalid_format
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_response_invalid_format", null);
+            }
+        }
+
+        internal static String net_ftp_server_failed_passive
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_server_failed_passive", null);
+            }
+        }
+
+        internal static String net_ftp_unsupported_method
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftp_unsupported_method", null);
+            }
+        }
+
+        internal static String net_ftpnoresponse
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpnoresponse", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_AccountNeeded
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_AccountNeeded", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ActionAbortedLocalProcessingError
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ActionAbortedLocalProcessingError", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ActionAbortedUnknownPageType
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ActionAbortedUnknownPageType", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ActionNotTakenFilenameNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ActionNotTakenFilenameNotAllowed", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ActionNotTakenFileUnavailable
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ActionNotTakenFileUnavailable", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ActionNotTakenFileUnavailableOrBusy
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ActionNotTakenFileUnavailableOrBusy", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ActionNotTakenInsufficentSpace
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ActionNotTakenInsufficentSpace", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ArgumentSyntaxError
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ArgumentSyntaxError", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_BadCommandSequence
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_BadCommandSequence", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_CantOpenData
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_CantOpenData", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_CommandNotImplemented
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_CommandNotImplemented", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_CommandSyntaxError
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_CommandSyntaxError", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ConnectionClosed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ConnectionClosed", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_FileActionAborted
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_FileActionAborted", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_NotLoggedIn
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_NotLoggedIn", null);
+            }
+        }
+
+        internal static String net_ftpstatuscode_ServiceNotAvailable
+        {
+            get
+            {
+                return SR.GetResourceString("net_ftpstatuscode_ServiceNotAvailable", null);
+            }
+        }
+
+        internal static String net_headerrestrict
+        {
+            get
+            {
+                return SR.GetResourceString("net_headerrestrict", null);
+            }
+        }
+
+        internal static String net_headers_req
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_req", null);
+            }
+        }
+
+        internal static String net_headers_rsp
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_rsp", null);
+            }
+        }
+
+        internal static String net_headers_toolong
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_toolong", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Ambiguous
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Ambiguous", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_BadGateway
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_BadGateway", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_BadRequest
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_BadRequest", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Conflict
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Conflict", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Forbidden
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Forbidden", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Found
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Found", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_GatewayTimeout
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_GatewayTimeout", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Gone
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Gone", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_HttpVersionNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_HttpVersionNotSupported", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_InternalServerError
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_InternalServerError", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_LengthRequired
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_LengthRequired", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_MethodNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_MethodNotAllowed", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Moved
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Moved", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_MovedPermanently
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_MovedPermanently", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_MultipleChoices
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_MultipleChoices", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_NoContent
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_NoContent", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_NonAuthoritativeInformation
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_NonAuthoritativeInformation", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_NotAcceptable
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_NotAcceptable", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_NotFound
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_NotFound", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_NotImplemented
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_NotImplemented", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_NotModified
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_NotModified", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_PartialContent
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_PartialContent", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_PaymentRequired
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_PaymentRequired", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_ProxyAuthenticationRequired
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_ProxyAuthenticationRequired", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Redirect
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Redirect", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_RedirectKeepVerb
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_RedirectKeepVerb", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_RedirectMethod
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_RedirectMethod", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_RequestTimeout
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_RequestTimeout", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_ResetContent
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_ResetContent", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_SeeOther
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_SeeOther", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_ServiceUnavailable
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_ServiceUnavailable", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_TemporaryRedirect
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_TemporaryRedirect", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_Unauthorized
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_Unauthorized", null);
+            }
+        }
+
+        internal static String net_httpstatuscode_UseProxy
+        {
+            get
+            {
+                return SR.GetResourceString("net_httpstatuscode_UseProxy", null);
+            }
+        }
+
+        internal static String net_illegalConfigWith
+        {
+            get
+            {
+                return SR.GetResourceString("net_illegalConfigWith", null);
+            }
+        }
+
+        internal static String net_illegalConfigWithout
+        {
+            get
+            {
+                return SR.GetResourceString("net_illegalConfigWithout", null);
+            }
+        }
+
+        internal static String net_inasync
+        {
+            get
+            {
+                return SR.GetResourceString("net_inasync", null);
+            }
+        }
+
+        internal static String net_invalid_cast
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalid_cast", null);
+            }
+        }
+
+        internal static String net_invalid_enum
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalid_enum", null);
+            }
+        }
+
+        internal static String net_invalid_host
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalid_host", null);
+            }
+        }
+
+        internal static String net_invalid_ip_addr
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalid_ip_addr", null);
+            }
+        }
+
+        internal static String net_invalid_offset
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalid_offset", null);
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
+        internal static String net_invalidPingBufferSize
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalidPingBufferSize", null);
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
+        internal static String net_invalidstatus
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalidstatus", null);
+            }
+        }
+
+        internal static String net_InvalidStatusCode
+        {
+            get
+            {
+                return SR.GetResourceString("net_InvalidStatusCode", null);
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
+        internal static String net_io_async_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_async_result", null);
+            }
+        }
+
+        internal static String net_io_completionportwasbound
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_completionportwasbound", null);
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
+        internal static String net_io_decrypt
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_decrypt", null);
+            }
+        }
+
+        internal static String net_io_encrypt
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_encrypt", null);
+            }
+        }
+
+        internal static String net_io_eof
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_eof", null);
+            }
+        }
+
+        internal static String net_io_header_id
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_header_id", null);
+            }
+        }
+
+        internal static String net_io_internal_bind
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_internal_bind", null);
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
+        internal static String net_io_invalidnestedcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidnestedcall", null);
+            }
+        }
+
+        internal static String net_io_must_be_rw_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_must_be_rw_stream", null);
+            }
+        }
+
+        internal static String net_io_no_0timeouts
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_no_0timeouts", null);
+            }
+        }
+
+        internal static String net_io_notenoughbyteswritten
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_notenoughbyteswritten", null);
+            }
+        }
+
+        internal static String net_io_out_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_out_range", null);
+            }
+        }
+
+        internal static String net_io_read
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_read", null);
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
+        internal static String net_io_timeout_use_ge_zero
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_timeout_use_ge_zero", null);
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
+        internal static String net_io_transportfailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_transportfailure", null);
+            }
+        }
+
+        internal static String net_io_write
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_write", null);
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
+        internal static String net_ipv4_not_installed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ipv4_not_installed", null);
+            }
+        }
+
+        internal static String net_ipv6_not_installed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ipv6_not_installed", null);
+            }
+        }
+
+        internal static String net_jscript_load
+        {
+            get
+            {
+                return SR.GetResourceString("net_jscript_load", null);
+            }
+        }
+
+        internal static String net_listener_already
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_already", null);
+            }
+        }
+
+        internal static String net_listener_callinprogress
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_callinprogress", null);
+            }
+        }
+
+        internal static String net_listener_cannot_set_custom_cbt
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_cannot_set_custom_cbt", null);
+            }
+        }
+
+        internal static String net_listener_cbt_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_cbt_not_supported", null);
+            }
+        }
+
+        internal static String net_listener_close_urlgroup_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_close_urlgroup_error", null);
+            }
+        }
+
+        internal static String net_listener_detach_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_detach_error", null);
+            }
+        }
+
+        internal static String net_listener_host
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_host", null);
+            }
+        }
+
+        internal static String net_listener_invalid_cbt_type
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_invalid_cbt_type", null);
+            }
+        }
+
+        internal static String net_listener_mustcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_mustcall", null);
+            }
+        }
+
+        internal static String net_listener_mustcompletecall
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_mustcompletecall", null);
+            }
+        }
+
+        internal static String net_listener_no_spns
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_no_spns", null);
+            }
+        }
+
+        internal static String net_listener_repcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_repcall", null);
+            }
+        }
+
+        internal static String net_listener_scheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_scheme", null);
+            }
+        }
+
+        internal static String net_listener_slash
+        {
+            get
+            {
+                return SR.GetResourceString("net_listener_slash", null);
+            }
+        }
+
+        internal static String net_log_attempting_restart_using_cert
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_attempting_restart_using_cert", null);
+            }
+        }
+
+        internal static String net_log_auth_invalid_challenge
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_auth_invalid_challenge", null);
+            }
+        }
+
+        internal static String net_log_buffered_n_bytes
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_buffered_n_bytes", null);
+            }
+        }
+
+        internal static String net_log_cache_206_resp_non_matching_entry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_206_resp_non_matching_entry", null);
+            }
+        }
+
+        internal static String net_log_cache_206_resp_starting_position_not_adjusted
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_206_resp_starting_position_not_adjusted", null);
+            }
+        }
+
+        internal static String net_log_cache_304_head_resp_has_different_last_modified
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_304_head_resp_has_different_last_modified", null);
+            }
+        }
+
+        internal static String net_log_cache_304_received_on_unconditional_request
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_304_received_on_unconditional_request", null);
+            }
+        }
+
+        internal static String net_log_cache_304_received_on_unconditional_request_expected_200_206
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_304_received_on_unconditional_request_expected_200_206", null);
+            }
+        }
+
+        internal static String net_log_cache_accept_based_on_retry_count
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_accept_based_on_retry_count", null);
+            }
+        }
+
+        internal static String net_log_cache_after_validation
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_after_validation", null);
+            }
+        }
+
+        internal static String net_log_cache_age
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_age", null);
+            }
+        }
+
+        internal static String net_log_cache_age1
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_age1", null);
+            }
+        }
+
+        internal static String net_log_cache_age1_date_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_age1_date_header", null);
+            }
+        }
+
+        internal static String net_log_cache_age1_last_synchronized
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_age1_last_synchronized", null);
+            }
+        }
+
+        internal static String net_log_cache_age1_last_synchronized_age_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_age1_last_synchronized_age_header", null);
+            }
+        }
+
+        internal static String net_log_cache_age2
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_age2", null);
+            }
+        }
+
+        internal static String net_log_cache_auth_header_and_no_s_max_age
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_auth_header_and_no_s_max_age", null);
+            }
+        }
+
+        internal static String net_log_cache_cache_control
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cache_control", null);
+            }
+        }
+
+        internal static String net_log_cache_cache_control_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cache_control_error", null);
+            }
+        }
+
+        internal static String net_log_cache_cache_last_modified
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cache_last_modified", null);
+            }
+        }
+
+        internal static String net_log_cache_cached_auth_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cached_auth_header", null);
+            }
+        }
+
+        internal static String net_log_cache_cached_auth_header_no_control_directive
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cached_auth_header_no_control_directive", null);
+            }
+        }
+
+        internal static String net_log_cache_cannot_construct_conditional_range_request
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cannot_construct_conditional_range_request", null);
+            }
+        }
+
+        internal static String net_log_cache_cannot_construct_conditional_request
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cannot_construct_conditional_request", null);
+            }
+        }
+
+        internal static String net_log_cache_cannot_remove
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cannot_remove", null);
+            }
+        }
+
+        internal static String net_log_cache_cannot_update_cache_if_304
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cannot_update_cache_if_304", null);
+            }
+        }
+
+        internal static String net_log_cache_cannot_update_cache_with_head_resp
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_cannot_update_cache_with_head_resp", null);
+            }
+        }
+
+        internal static String net_log_cache_closing_cache_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_closing_cache_stream", null);
+            }
+        }
+
+        internal static String net_log_cache_combined_resp_requested
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_combined_resp_requested", null);
+            }
+        }
+
+        internal static String net_log_cache_commit_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_commit_failed", null);
+            }
+        }
+
+        internal static String net_log_cache_committed_as_partial
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_committed_as_partial", null);
+            }
+        }
+
+        internal static String net_log_cache_condition_if_modified_since
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_condition_if_modified_since", null);
+            }
+        }
+
+        internal static String net_log_cache_condition_if_none_match
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_condition_if_none_match", null);
+            }
+        }
+
+        internal static String net_log_cache_condition_if_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_condition_if_range", null);
+            }
+        }
+
+        internal static String net_log_cache_conditional_range_not_implemented_on_http_10
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_conditional_range_not_implemented_on_http_10", null);
+            }
+        }
+
+        internal static String net_log_cache_content_range_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_content_range_error", null);
+            }
+        }
+
+        internal static String net_log_cache_control_must_revalidate
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_control_must_revalidate", null);
+            }
+        }
+
+        internal static String net_log_cache_control_no_cache
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_control_no_cache", null);
+            }
+        }
+
+        internal static String net_log_cache_control_no_cache_removing_some_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_control_no_cache_removing_some_headers", null);
+            }
+        }
+
+        internal static String net_log_cache_could_be_partial
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_could_be_partial", null);
+            }
+        }
+
+        internal static String net_log_cache_create_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_create_failed", null);
+            }
+        }
+
+        internal static String net_log_cache_date_header_older_than_cache_entry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_date_header_older_than_cache_entry", null);
+            }
+        }
+
+        internal static String net_log_cache_delete_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_delete_failed", null);
+            }
+        }
+
+        internal static String net_log_cache_disable_max_stale
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_disable_max_stale", null);
+            }
+        }
+
+        internal static String net_log_cache_dont_update_cached_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_dont_update_cached_headers", null);
+            }
+        }
+
+        internal static String net_log_cache_dumping
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_dumping", null);
+            }
+        }
+
+        internal static String net_log_cache_dumping_cache_context
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_dumping_cache_context", null);
+            }
+        }
+
+        internal static String net_log_cache_dumping_metadata
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_dumping_metadata", null);
+            }
+        }
+
+        internal static String net_log_cache_enable_max_stale
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_enable_max_stale", null);
+            }
+        }
+
+        internal static String net_log_cache_entry_not_found_freshness_undefined
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_entry_not_found_freshness_undefined", null);
+            }
+        }
+
+        internal static String net_log_cache_entry_size_too_big
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_entry_size_too_big", null);
+            }
+        }
+
+        internal static String net_log_cache_error_deleting_filename
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_error_deleting_filename", null);
+            }
+        }
+
+        internal static String net_log_cache_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_exception", null);
+            }
+        }
+
+        internal static String net_log_cache_exception_ignored
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_exception_ignored", null);
+            }
+        }
+
+        internal static String net_log_cache_existing_entry_has_to_be_discarded
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_existing_entry_has_to_be_discarded", null);
+            }
+        }
+
+        internal static String net_log_cache_existing_entry_should_be_discarded
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_existing_entry_should_be_discarded", null);
+            }
+        }
+
+        internal static String net_log_cache_existing_not_removed_because_unexpected_response_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_existing_not_removed_because_unexpected_response_status", null);
+            }
+        }
+
+        internal static String net_log_cache_expected_length
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_expected_length", null);
+            }
+        }
+
+        internal static String net_log_cache_expires
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_expires", null);
+            }
+        }
+
+        internal static String net_log_cache_failing_request_with_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_failing_request_with_exception", null);
+            }
+        }
+
+        internal static String net_log_cache_filename
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_filename", null);
+            }
+        }
+
+        internal static String net_log_cache_freshness_outside_policy_limits
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_freshness_outside_policy_limits", null);
+            }
+        }
+
+        internal static String net_log_cache_ftp_method
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_ftp_method", null);
+            }
+        }
+
+        internal static String net_log_cache_ftp_proxy_doesnt_support_partial
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_ftp_proxy_doesnt_support_partial", null);
+            }
+        }
+
+        internal static String net_log_cache_ftp_response_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_ftp_response_status", null);
+            }
+        }
+
+        internal static String net_log_cache_ftp_supports_bin_only
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_ftp_supports_bin_only", null);
+            }
+        }
+
+        internal static String net_log_cache_head_resp_has_different_content_length
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_head_resp_has_different_content_length", null);
+            }
+        }
+
+        internal static String net_log_cache_head_resp_has_different_content_md5
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_head_resp_has_different_content_md5", null);
+            }
+        }
+
+        internal static String net_log_cache_head_resp_has_different_etag
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_head_resp_has_different_etag", null);
+            }
+        }
+
+        internal static String net_log_cache_http_header_parse_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_http_header_parse_error", null);
+            }
+        }
+
+        internal static String net_log_cache_http_resp_is_null
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_http_resp_is_null", null);
+            }
+        }
+
+        internal static String net_log_cache_http_status_line
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_http_status_line", null);
+            }
+        }
+
+        internal static String net_log_cache_http_status_parse_failure
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_http_status_parse_failure", null);
+            }
+        }
+
+        internal static String net_log_cache_invalid_http_version
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_invalid_http_version", null);
+            }
+        }
+
+        internal static String net_log_cache_key
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_key", null);
+            }
+        }
+
+        internal static String net_log_cache_key_remove_failed_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_key_remove_failed_status", null);
+            }
+        }
+
+        internal static String net_log_cache_key_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_key_status", null);
+            }
+        }
+
+        internal static String net_log_cache_last_modified
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_last_modified", null);
+            }
+        }
+
+        internal static String net_log_cache_last_modified_header_older_than_cache_entry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_last_modified_header_older_than_cache_entry", null);
+            }
+        }
+
+        internal static String net_log_cache_last_synchronized
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_last_synchronized", null);
+            }
+        }
+
+        internal static String net_log_cache_lookup_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_lookup_failed", null);
+            }
+        }
+
+        internal static String net_log_cache_max_age_absolute
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_max_age_absolute", null);
+            }
+        }
+
+        internal static String net_log_cache_max_age_cache_max_age
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_max_age_cache_max_age", null);
+            }
+        }
+
+        internal static String net_log_cache_max_age_cache_s_max_age
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_max_age_cache_s_max_age", null);
+            }
+        }
+
+        internal static String net_log_cache_max_age_expires_date
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_max_age_expires_date", null);
+            }
+        }
+
+        internal static String net_log_cache_max_stale
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_max_stale", null);
+            }
+        }
+
+        internal static String net_log_cache_max_stale_and_update_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_max_stale_and_update_status", null);
+            }
+        }
+
+        internal static String net_log_cache_metadata_name_value_parse_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_metadata_name_value_parse_error", null);
+            }
+        }
+
+        internal static String net_log_cache_multiple_complex_range_not_implemented
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_multiple_complex_range_not_implemented", null);
+            }
+        }
+
+        internal static String net_log_cache_need_to_remove_invalid_cache_entry_304
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_need_to_remove_invalid_cache_entry_304", null);
+            }
+        }
+
+        internal static String net_log_cache_needs_revalidation
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_needs_revalidation", null);
+            }
+        }
+
+        internal static String net_log_cache_no_cache_entry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_cache_entry", null);
+            }
+        }
+
+        internal static String net_log_cache_no_commit
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_commit", null);
+            }
+        }
+
+        internal static String net_log_cache_no_headers_in_metadata
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_headers_in_metadata", null);
+            }
+        }
+
+        internal static String net_log_cache_no_http_response_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_http_response_header", null);
+            }
+        }
+
+        internal static String net_log_cache_no_max_age_use_10_percent
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_max_age_use_10_percent", null);
+            }
+        }
+
+        internal static String net_log_cache_no_max_age_use_default
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_max_age_use_default", null);
+            }
+        }
+
+        internal static String net_log_cache_no_update_based_on_method
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_no_update_based_on_method", null);
+            }
+        }
+
+        internal static String net_log_cache_not_a_get_head_post
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_not_a_get_head_post", null);
+            }
+        }
+
+        internal static String net_log_cache_not_updated_based_on_cache_protocol_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_not_updated_based_on_cache_protocol_status", null);
+            }
+        }
+
+        internal static String net_log_cache_not_updated_based_on_ftp_response_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_not_updated_based_on_ftp_response_status", null);
+            }
+        }
+
+        internal static String net_log_cache_not_updated_based_on_policy
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_not_updated_based_on_policy", null);
+            }
+        }
+
+        internal static String net_log_cache_not_updated_because_no_response
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_not_updated_because_no_response", null);
+            }
+        }
+
+        internal static String net_log_cache_now_time
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_now_time", null);
+            }
+        }
+
+        internal static String net_log_cache_null_cached_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_null_cached_stream", null);
+            }
+        }
+
+        internal static String net_log_cache_null_response_failure
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_null_response_failure", null);
+            }
+        }
+
+        internal static String net_log_cache_object_and_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_object_and_exception", null);
+            }
+        }
+
+        internal static String net_log_cache_only_byte_range_implemented
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_only_byte_range_implemented", null);
+            }
+        }
+
+        internal static String net_log_cache_partial_and_non_zero_content_offset
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_partial_and_non_zero_content_offset", null);
+            }
+        }
+
+        internal static String net_log_cache_partial_resp
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_partial_resp", null);
+            }
+        }
+
+        internal static String net_log_cache_partial_resp_not_combined_with_existing_entry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_partial_resp_not_combined_with_existing_entry", null);
+            }
+        }
+
+        internal static String net_log_cache_policy_cache_sync_date
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_policy_cache_sync_date", null);
+            }
+        }
+
+        internal static String net_log_cache_policy_max_age
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_policy_max_age", null);
+            }
+        }
+
+        internal static String net_log_cache_policy_max_stale
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_policy_max_stale", null);
+            }
+        }
+
+        internal static String net_log_cache_policy_min_fresh
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_policy_min_fresh", null);
+            }
+        }
+
+        internal static String net_log_cache_post_resp_without_cache_control_or_expires
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_post_resp_without_cache_control_or_expires", null);
+            }
+        }
+
+        internal static String net_log_cache_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_range", null);
+            }
+        }
+
+        internal static String net_log_cache_range_in_cache
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_range_in_cache", null);
+            }
+        }
+
+        internal static String net_log_cache_range_invalid_format
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_range_invalid_format", null);
+            }
+        }
+
+        internal static String net_log_cache_range_not_in_cache
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_range_not_in_cache", null);
+            }
+        }
+
+        internal static String net_log_cache_range_request_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_range_request_range", null);
+            }
+        }
+
+        internal static String net_log_cache_refused_server_response
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_refused_server_response", null);
+            }
+        }
+
+        internal static String net_log_cache_removed_entry_because_ftp_restart_response_changed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_removed_entry_because_ftp_restart_response_changed", null);
+            }
+        }
+
+        internal static String net_log_cache_removed_existing_based_on_method
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_removed_existing_based_on_method", null);
+            }
+        }
+
+        internal static String net_log_cache_removed_existing_based_on_policy
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_removed_existing_based_on_policy", null);
+            }
+        }
+
+        internal static String net_log_cache_removed_existing_invalid_entry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_removed_existing_invalid_entry", null);
+            }
+        }
+
+        internal static String net_log_cache_replacing_entry_with_HTTP_200
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_replacing_entry_with_HTTP_200", null);
+            }
+        }
+
+        internal static String net_log_cache_request_contains_conditional_header
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_request_contains_conditional_header", null);
+            }
+        }
+
+        internal static String net_log_cache_request_method
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_request_method", null);
+            }
+        }
+
+        internal static String net_log_cache_requested_combined_but_null_cached_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_requested_combined_but_null_cached_stream", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_304_or_request_head
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_304_or_request_head", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_allows_caching
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_allows_caching", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_cache_control_is_no_store
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_cache_control_is_no_store", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_cache_control_is_private
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_cache_control_is_private", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_cache_control_is_private_plus_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_cache_control_is_private_plus_headers", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_cache_control_is_public
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_cache_control_is_public", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_no_cache_control
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_no_cache_control", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_older_than_cache
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_older_than_cache", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_status", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_status_304
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_status_304", null);
+            }
+        }
+
+        internal static String net_log_cache_resp_valid_based_on_retry
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_resp_valid_based_on_retry", null);
+            }
+        }
+
+        internal static String net_log_cache_response_last_modified
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_response_last_modified", null);
+            }
+        }
+
+        internal static String net_log_cache_response_valid_based_on_policy
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_response_valid_based_on_policy", null);
+            }
+        }
+
+        internal static String net_log_cache_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_result", null);
+            }
+        }
+
+        internal static String net_log_cache_returned_range_cache
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_returned_range_cache", null);
+            }
+        }
+
+        internal static String net_log_cache_revalidation_not_needed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_revalidation_not_needed", null);
+            }
+        }
+
+        internal static String net_log_cache_revalidation_required
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_revalidation_required", null);
+            }
+        }
+
+        internal static String net_log_cache_saving_request_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_saving_request_headers", null);
+            }
+        }
+
+        internal static String net_log_cache_server_didnt_satisfy_range
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_server_didnt_satisfy_range", null);
+            }
+        }
+
+        internal static String net_log_cache_set_expires
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_set_expires", null);
+            }
+        }
+
+        internal static String net_log_cache_set_last_modified
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_set_last_modified", null);
+            }
+        }
+
+        internal static String net_log_cache_set_last_synchronized
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_set_last_synchronized", null);
+            }
+        }
+
+        internal static String net_log_cache_set_new_metadata
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_set_new_metadata", null);
+            }
+        }
+
+        internal static String net_log_cache_status_code_not_304_206
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_status_code_not_304_206", null);
+            }
+        }
+
+        internal static String net_log_cache_stream
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_stream", null);
+            }
+        }
+
+        internal static String net_log_cache_suppress_update_because_synched_last_minute
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_suppress_update_because_synched_last_minute", null);
+            }
+        }
+
+        internal static String net_log_cache_suppressing_headers_update_on_304
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_suppressing_headers_update_on_304", null);
+            }
+        }
+
+        internal static String net_log_cache_sxx_resp_cache_only
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_sxx_resp_cache_only", null);
+            }
+        }
+
+        internal static String net_log_cache_sxx_resp_can_be_replaced
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_sxx_resp_can_be_replaced", null);
+            }
+        }
+
+        internal static String net_log_cache_unexpected_status
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_unexpected_status", null);
+            }
+        }
+
+        internal static String net_log_cache_update_cached_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_update_cached_headers", null);
+            }
+        }
+
+        internal static String net_log_cache_update_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_update_failed", null);
+            }
+        }
+
+        internal static String net_log_cache_update_not_supported_for_ftp_restart
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_update_not_supported_for_ftp_restart", null);
+            }
+        }
+
+        internal static String net_log_cache_updating_headers_on_304
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_updating_headers_on_304", null);
+            }
+        }
+
+        internal static String net_log_cache_updating_last_synchronized
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_updating_last_synchronized", null);
+            }
+        }
+
+        internal static String net_log_cache_uri_with_query_and_cached_resp_from_http_10
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_uri_with_query_and_cached_resp_from_http_10", null);
+            }
+        }
+
+        internal static String net_log_cache_uri_with_query_has_no_expiration
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_uri_with_query_has_no_expiration", null);
+            }
+        }
+
+        internal static String net_log_cache_usecount_file
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_usecount_file", null);
+            }
+        }
+
+        internal static String net_log_cache_valid_as_fresh_or_because_policy
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_valid_as_fresh_or_because_policy", null);
+            }
+        }
+
+        internal static String net_log_cache_valid_based_on_status_code
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_valid_based_on_status_code", null);
+            }
+        }
+
+        internal static String net_log_cache_validation_failed_resubmit
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_validation_failed_resubmit", null);
+            }
+        }
+
+        internal static String net_log_cache_validator_invalid_for_policy
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_validator_invalid_for_policy", null);
+            }
+        }
+
+        internal static String net_log_cache_vary_header_contains_asterisks
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_vary_header_contains_asterisks", null);
+            }
+        }
+
+        internal static String net_log_cache_vary_header_empty
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_vary_header_empty", null);
+            }
+        }
+
+        internal static String net_log_cache_vary_header_match
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_vary_header_match", null);
+            }
+        }
+
+        internal static String net_log_cache_vary_header_mismatched_count
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_vary_header_mismatched_count", null);
+            }
+        }
+
+        internal static String net_log_cache_vary_header_mismatched_field
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cache_vary_header_mismatched_field", null);
+            }
+        }
+
+        internal static String net_log_cert_is_of_type_2
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_cert_is_of_type_2", null);
+            }
+        }
+
+        internal static String net_log_closed_idle
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_closed_idle", null);
+            }
+        }
+
+        internal static String net_log_did_not_find_cert_in_store
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_did_not_find_cert_in_store", null);
+            }
+        }
+
+        internal static String net_log_digest_hash_algorithm_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_digest_hash_algorithm_not_supported", null);
+            }
+        }
+
+        internal static String net_log_digest_qop_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_digest_qop_not_supported", null);
+            }
+        }
+
+        internal static String net_log_digest_requires_nonce
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_digest_requires_nonce", null);
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
+        internal static String net_log_exception_in_callback
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_exception_in_callback", null);
+            }
+        }
+
+        internal static String net_log_finding_matching_certs
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_finding_matching_certs", null);
+            }
+        }
+
+        internal static String net_log_found_cert_in_store
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_found_cert_in_store", null);
+            }
+        }
+
+        internal static String net_log_got_certificate_from_delegate
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_got_certificate_from_delegate", null);
+            }
+        }
+
+        internal static String net_log_listener_cant_convert_bytes
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_cant_convert_bytes", null);
+            }
+        }
+
+        internal static String net_log_listener_cant_convert_percent_value
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_cant_convert_percent_value", null);
+            }
+        }
+
+        internal static String net_log_listener_cant_convert_raw_path
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_cant_convert_raw_path", null);
+            }
+        }
+
+        internal static String net_log_listener_cant_convert_to_utf8
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_cant_convert_to_utf8", null);
+            }
+        }
+
+        internal static String net_log_listener_cant_create_uri
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_cant_create_uri", null);
+            }
+        }
+
+        internal static String net_log_listener_cbt
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_cbt", null);
+            }
+        }
+
+        internal static String net_log_listener_create_valid_identity_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_create_valid_identity_failed", null);
+            }
+        }
+
+        internal static String net_log_listener_delegate_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_delegate_exception", null);
+            }
+        }
+
+        internal static String net_log_listener_httpsys_registry_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_httpsys_registry_error", null);
+            }
+        }
+
+        internal static String net_log_listener_httpsys_registry_null
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_httpsys_registry_null", null);
+            }
+        }
+
+        internal static String net_log_listener_no_cbt_disabled
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_cbt_disabled", null);
+            }
+        }
+
+        internal static String net_log_listener_no_cbt_http
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_cbt_http", null);
+            }
+        }
+
+        internal static String net_log_listener_no_cbt_platform
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_cbt_platform", null);
+            }
+        }
+
+        internal static String net_log_listener_no_cbt_trustedproxy
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_cbt_trustedproxy", null);
+            }
+        }
+
+        internal static String net_log_listener_no_spn_cbt
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_spn_cbt", null);
+            }
+        }
+
+        internal static String net_log_listener_no_spn_disabled
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_spn_disabled", null);
+            }
+        }
+
+        internal static String net_log_listener_no_spn_kerberos
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_spn_kerberos", null);
+            }
+        }
+
+        internal static String net_log_listener_no_spn_loopback
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_spn_loopback", null);
+            }
+        }
+
+        internal static String net_log_listener_no_spn_platform
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_spn_platform", null);
+            }
+        }
+
+        internal static String net_log_listener_no_spn_whensupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_no_spn_whensupported", null);
+            }
+        }
+
+        internal static String net_log_listener_spn
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_add
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_add", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_failed", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_failed_always
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_failed_always", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_failed_dump
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_failed_dump", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_failed_empty
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_failed_empty", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_not_add
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_not_add", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_not_remove
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_not_remove", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_passed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_passed", null);
+            }
+        }
+
+        internal static String net_log_listener_spn_remove
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_spn_remove", null);
+            }
+        }
+
+        internal static String net_log_listener_unmatched_authentication_scheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_unmatched_authentication_scheme", null);
+            }
+        }
+
+        internal static String net_log_listener_unsupported_authentication_scheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_listener_unsupported_authentication_scheme", null);
+            }
+        }
+
+        internal static String net_log_locating_private_key_for_certificate
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_locating_private_key_for_certificate", null);
+            }
+        }
+
+        internal static String net_log_method_equal
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_method_equal", null);
+            }
+        }
+
+        internal static String net_log_n_certs_after_filtering
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_n_certs_after_filtering", null);
+            }
+        }
+
+        internal static String net_log_no_delegate_and_have_no_client_cert
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_no_delegate_and_have_no_client_cert", null);
+            }
+        }
+
+        internal static String net_log_no_delegate_but_have_client_cert
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_no_delegate_but_have_client_cert", null);
+            }
+        }
+
+        internal static String net_log_no_issuers_try_all_certs
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_no_issuers_try_all_certs", null);
+            }
+        }
+
+        internal static String net_log_open_store_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_open_store_failed", null);
+            }
+        }
+
+        internal static String net_log_operation_failed_with_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_operation_failed_with_error", null);
+            }
+        }
+
+        internal static String net_log_operation_returned_something
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_operation_returned_something", null);
+            }
+        }
+
+        internal static String net_log_proxy_autodetect_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_autodetect_failed", null);
+            }
+        }
+
+        internal static String net_log_proxy_autodetect_script_location_parse_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_autodetect_script_location_parse_error", null);
+            }
+        }
+
+        internal static String net_log_proxy_called_with_invalid_parameter
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_called_with_invalid_parameter", null);
+            }
+        }
+
+        internal static String net_log_proxy_called_with_null_parameter
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_called_with_null_parameter", null);
+            }
+        }
+
+        internal static String net_log_proxy_ras_notsupported_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_ras_notsupported_exception", null);
+            }
+        }
+
+        internal static String net_log_proxy_ras_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_ras_supported", null);
+            }
+        }
+
+        internal static String net_log_proxy_script_download_compile_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_script_download_compile_error", null);
+            }
+        }
+
+        internal static String net_log_proxy_script_execution_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_script_execution_error", null);
+            }
+        }
+
+        internal static String net_log_proxy_system_setting_update
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_system_setting_update", null);
+            }
+        }
+
+        internal static String net_log_proxy_update_due_to_ip_config_change
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_update_due_to_ip_config_change", null);
+            }
+        }
+
+        internal static String net_log_proxy_winhttp_cant_open_session
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_winhttp_cant_open_session", null);
+            }
+        }
+
+        internal static String net_log_proxy_winhttp_getproxy_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_winhttp_getproxy_failed", null);
+            }
+        }
+
+        internal static String net_log_proxy_winhttp_timeout_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_proxy_winhttp_timeout_error", null);
+            }
+        }
+
+        internal static String net_log_received_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_received_headers", null);
+            }
+        }
+
+        internal static String net_log_received_response
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_received_response", null);
+            }
+        }
+
+        internal static String net_log_received_status_line
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_received_status_line", null);
+            }
+        }
+
+        internal static String net_log_releasing_connection
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_releasing_connection", null);
+            }
+        }
+
+        internal static String net_log_remote_cert_has_errors
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_has_errors", null);
+            }
+        }
+
+        internal static String net_log_remote_cert_has_no_errors
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_has_no_errors", null);
+            }
+        }
+
+        internal static String net_log_remote_cert_name_mismatch
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_name_mismatch", null);
+            }
+        }
+
+        internal static String net_log_remote_cert_not_available
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_not_available", null);
+            }
+        }
+
+        internal static String net_log_remote_cert_user_declared_invalid
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_user_declared_invalid", null);
+            }
+        }
+
+        internal static String net_log_remote_cert_user_declared_valid
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_user_declared_valid", null);
+            }
+        }
+
+        internal static String net_log_remote_certificate
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_certificate", null);
+            }
+        }
+
+        internal static String net_log_resolved_servicepoint_may_not_be_remote_server
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_resolved_servicepoint_may_not_be_remote_server", null);
+            }
+        }
+
+        internal static String net_log_resubmitting_request
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_resubmitting_request", null);
+            }
+        }
+
+        internal static String net_log_retrieving_localhost_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_retrieving_localhost_exception", null);
+            }
+        }
+
+        internal static String net_log_selected_cert
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_selected_cert", null);
+            }
+        }
+
+        internal static String net_log_sending_command
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sending_command", null);
+            }
+        }
+
+        internal static String net_log_sending_headers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sending_headers", null);
+            }
+        }
+
+        internal static String net_log_server_issuers_look_for_matching_certs
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_server_issuers_look_for_matching_certs", null);
+            }
+        }
+
+        internal static String net_log_server_response_error_code
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_server_response_error_code", null);
+            }
+        }
+
+        internal static String net_log_shell_expression_pattern_format_warning
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_shell_expression_pattern_format_warning", null);
+            }
+        }
+
+        internal static String net_log_socket_accepted
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_socket_accepted", null);
+            }
+        }
+
+        internal static String net_log_socket_connect_dnsendpoint
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_socket_connect_dnsendpoint", null);
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
+        internal static String net_log_socket_not_logged_file
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_socket_not_logged_file", null);
+            }
+        }
+
+        internal static String net_log_sspi_enumerating_security_packages
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sspi_enumerating_security_packages", null);
+            }
+        }
+
+        internal static String net_log_sspi_security_context_input_buffer
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sspi_security_context_input_buffer", null);
+            }
+        }
+
+        internal static String net_log_sspi_security_context_input_buffers
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sspi_security_context_input_buffers", null);
+            }
+        }
+
+        internal static String net_log_sspi_security_package_not_found
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sspi_security_package_not_found", null);
+            }
+        }
+
+        internal static String net_log_sspi_selected_cipher_suite
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_sspi_selected_cipher_suite", null);
+            }
+        }
+
+        internal static String net_log_unexpected_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_unexpected_exception", null);
+            }
+        }
+
+        internal static String net_log_unknown
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_unknown", null);
+            }
+        }
+
+        internal static String net_log_using_cached_credential
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_using_cached_credential", null);
+            }
+        }
+
+        internal static String net_max_ip_address_list_length_exceeded
+        {
+            get
+            {
+                return SR.GetResourceString("net_max_ip_address_list_length_exceeded", null);
+            }
+        }
+
+        internal static String net_maxsrvpoints
+        {
+            get
+            {
+                return SR.GetResourceString("net_maxsrvpoints", null);
+            }
+        }
+
+        internal static String net_MethodNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_MethodNotImplementedException", null);
+            }
+        }
+
+        internal static String net_MethodNotSupportedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_MethodNotSupportedException", null);
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
+        internal static String net_must_provide_request_body
+        {
+            get
+            {
+                return SR.GetResourceString("net_must_provide_request_body", null);
+            }
+        }
+
+        internal static String net_mustbeuri
+        {
+            get
+            {
+                return SR.GetResourceString("net_mustbeuri", null);
+            }
+        }
+
+        internal static String net_mutualauthfailed
+        {
+            get
+            {
+                return SR.GetResourceString("net_mutualauthfailed", null);
+            }
+        }
+
+        internal static String net_need_writebuffering
+        {
+            get
+            {
+                return SR.GetResourceString("net_need_writebuffering", null);
+            }
+        }
+
+        internal static String net_needchunked
+        {
+            get
+            {
+                return SR.GetResourceString("net_needchunked", null);
+            }
+        }
+
+        internal static String net_needmorethreads
+        {
+            get
+            {
+                return SR.GetResourceString("net_needmorethreads", null);
+            }
+        }
+
+        internal static String net_no_classname
+        {
+            get
+            {
+                return SR.GetResourceString("net_no_classname", null);
+            }
+        }
+
+        internal static String net_no_concurrent_io_allowed
+        {
+            get
+            {
+                return SR.GetResourceString("net_no_concurrent_io_allowed", null);
+            }
+        }
+
+        internal static String net_no_typename
+        {
+            get
+            {
+                return SR.GetResourceString("net_no_typename", null);
+            }
+        }
+
+        internal static String net_no100
+        {
+            get
+            {
+                return SR.GetResourceString("net_no100", null);
+            }
+        }
+
+        internal static String net_nochunked
+        {
+            get
+            {
+                return SR.GetResourceString("net_nochunked", null);
+            }
+        }
+
+        internal static String net_nochunkuploadonhttp10
+        {
+            get
+            {
+                return SR.GetResourceString("net_nochunkuploadonhttp10", null);
+            }
+        }
+
+        internal static String net_nocontentlengthonget
+        {
+            get
+            {
+                return SR.GetResourceString("net_nocontentlengthonget", null);
+            }
+        }
+
+        internal static String net_nodefaultcreds
+        {
+            get
+            {
+                return SR.GetResourceString("net_nodefaultcreds", null);
+            }
+        }
+
+        internal static String net_nonClsCompliantException
+        {
+            get
+            {
+                return SR.GetResourceString("net_nonClsCompliantException", null);
+            }
+        }
+
+        internal static String net_nonhttpproxynotallowed
+        {
+            get
+            {
+                return SR.GetResourceString("net_nonhttpproxynotallowed", null);
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
+        internal static String net_not_ipermission
+        {
+            get
+            {
+                return SR.GetResourceString("net_not_ipermission", null);
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
+        internal static String net_nottoken
+        {
+            get
+            {
+                return SR.GetResourceString("net_nottoken", null);
+            }
+        }
+
+        internal static String net_nouploadonget
+        {
+            get
+            {
+                return SR.GetResourceString("net_nouploadonget", null);
+            }
+        }
+
+        internal static String net_offset_plus_count
+        {
+            get
+            {
+                return SR.GetResourceString("net_offset_plus_count", null);
+            }
+        }
+
+        internal static String net_osinstalltype
+        {
+            get
+            {
+                return SR.GetResourceString("net_osinstalltype", null);
+            }
+        }
+
+        internal static String net_param_not_string
+        {
+            get
+            {
+                return SR.GetResourceString("net_param_not_string", null);
+            }
+        }
+
+        internal static String net_perfcounter_cant_queue_workitem
+        {
+            get
+            {
+                return SR.GetResourceString("net_perfcounter_cant_queue_workitem", null);
+            }
+        }
+
+        internal static String net_perfcounter_initialization_started
+        {
+            get
+            {
+                return SR.GetResourceString("net_perfcounter_initialization_started", null);
+            }
+        }
+
+        internal static String net_perfcounter_initialized_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_perfcounter_initialized_error", null);
+            }
+        }
+
+        internal static String net_perfcounter_initialized_success
+        {
+            get
+            {
+                return SR.GetResourceString("net_perfcounter_initialized_success", null);
+            }
+        }
+
+        internal static String net_perfcounter_nocategory
+        {
+            get
+            {
+                return SR.GetResourceString("net_perfcounter_nocategory", null);
+            }
+        }
+
+        internal static String net_perm_attrib_count
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_attrib_count", null);
+            }
+        }
+
+        internal static String net_perm_attrib_multi
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_attrib_multi", null);
+            }
+        }
+
+        internal static String net_perm_both_regex
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_both_regex", null);
+            }
+        }
+
+        internal static String net_perm_epname
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_epname", null);
+            }
+        }
+
+        internal static String net_perm_invalid_val
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_invalid_val", null);
+            }
+        }
+
+        internal static String net_perm_invalid_val_in_element
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_invalid_val_in_element", null);
+            }
+        }
+
+        internal static String net_perm_none
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_none", null);
+            }
+        }
+
+        internal static String net_perm_target
+        {
+            get
+            {
+                return SR.GetResourceString("net_perm_target", null);
+            }
+        }
+
+        internal static String net_ping
+        {
+            get
+            {
+                return SR.GetResourceString("net_ping", null);
+            }
+        }
+
+        internal static String net_PropertyNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_PropertyNotImplementedException", null);
+            }
+        }
+
+        internal static String net_PropertyNotSupportedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_PropertyNotSupportedException", null);
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
+        internal static String net_ProtocolNotSupportedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_ProtocolNotSupportedException", null);
+            }
+        }
+
+        internal static String net_proxy_invalid_dayofweek
+        {
+            get
+            {
+                return SR.GetResourceString("net_proxy_invalid_dayofweek", null);
+            }
+        }
+
+        internal static String net_proxy_invalid_url_format
+        {
+            get
+            {
+                return SR.GetResourceString("net_proxy_invalid_url_format", null);
+            }
+        }
+
+        internal static String net_proxy_not_gmt
+        {
+            get
+            {
+                return SR.GetResourceString("net_proxy_not_gmt", null);
+            }
+        }
+
+        internal static String net_proxyschemenotsupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_proxyschemenotsupported", null);
+            }
+        }
+
+        internal static String net_rangetoosmall
+        {
+            get
+            {
+                return SR.GetResourceString("net_rangetoosmall", null);
+            }
+        }
+
+        internal static String net_rangetype
+        {
+            get
+            {
+                return SR.GetResourceString("net_rangetype", null);
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
+        internal static String net_redirect_perm
+        {
+            get
+            {
+                return SR.GetResourceString("net_redirect_perm", null);
+            }
+        }
+
+        internal static String net_repcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_repcall", null);
+            }
+        }
+
+        internal static String net_reqsubmitted
+        {
+            get
+            {
+                return SR.GetResourceString("net_reqsubmitted", null);
+            }
+        }
+
+        internal static String net_requestaborted
+        {
+            get
+            {
+                return SR.GetResourceString("net_requestaborted", null);
+            }
+        }
+
+        internal static String net_resubmitcanceled
+        {
+            get
+            {
+                return SR.GetResourceString("net_resubmitcanceled", null);
+            }
+        }
+
+        internal static String net_resubmitprotofailed
+        {
+            get
+            {
+                return SR.GetResourceString("net_resubmitprotofailed", null);
+            }
+        }
+
+        internal static String net_revert_token
+        {
+            get
+            {
+                return SR.GetResourceString("net_revert_token", null);
+            }
+        }
+
+        internal static String net_rspsubmitted
+        {
+            get
+            {
+                return SR.GetResourceString("net_rspsubmitted", null);
+            }
+        }
+
+        internal static String net_securitypackagesupport
+        {
+            get
+            {
+                return SR.GetResourceString("net_securitypackagesupport", null);
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
+        internal static String net_SelectModeNotSupportedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_SelectModeNotSupportedException", null);
+            }
+        }
+
+        internal static String net_servererror
+        {
+            get
+            {
+                return SR.GetResourceString("net_servererror", null);
+            }
+        }
+
+        internal static String net_servicePointAddressNotSupportedInHostMode
+        {
+            get
+            {
+                return SR.GetResourceString("net_servicePointAddressNotSupportedInHostMode", null);
+            }
+        }
+
+        internal static String net_set_token
+        {
+            get
+            {
+                return SR.GetResourceString("net_set_token", null);
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
+        internal static String net_sockets_invalid_socketinformation
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_invalid_socketinformation", null);
+            }
+        }
+
+        internal static String net_sockets_ipv6only
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_ipv6only", null);
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
+        internal static String net_sockets_no_duplicate_async
+        {
+            get
+            {
+                return SR.GetResourceString("net_sockets_no_duplicate_async", null);
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
+        internal static String net_ssl_io_async_context
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_async_context", null);
+            }
+        }
+
+        internal static String net_ssl_io_cert_validation
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_cert_validation", null);
+            }
+        }
+
+        internal static String net_ssl_io_context_expired
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_context_expired", null);
+            }
+        }
+
+        internal static String net_ssl_io_corrupted
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_corrupted", null);
+            }
+        }
+
+        internal static String net_ssl_io_decrypt
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_decrypt", null);
+            }
+        }
+
+        internal static String net_ssl_io_encrypt
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_encrypt", null);
+            }
+        }
+
+        internal static String net_ssl_io_frame
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_frame", null);
+            }
+        }
+
+        internal static String net_ssl_io_handshake
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_handshake", null);
+            }
+        }
+
+        internal static String net_ssl_io_handshake_start
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_handshake_start", null);
+            }
+        }
+
+        internal static String net_ssl_io_invalid_begin_call
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_invalid_begin_call", null);
+            }
+        }
+
+        internal static String net_ssl_io_invalid_end_call
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_invalid_end_call", null);
+            }
+        }
+
+        internal static String net_ssl_io_no_server_cert
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_no_server_cert", null);
+            }
+        }
+
+        internal static String net_ssp_dont_support_cbt
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssp_dont_support_cbt", null);
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
+        internal static String net_timeout
+        {
+            get
+            {
+                return SR.GetResourceString("net_timeout", null);
+            }
+        }
+
+        internal static String net_tls_version
+        {
+            get
+            {
+                return SR.GetResourceString("net_tls_version", null);
+            }
+        }
+
+        internal static String net_toolong
+        {
+            get
+            {
+                return SR.GetResourceString("net_toolong", null);
+            }
+        }
+
+        internal static String net_tooManyRedirections
+        {
+            get
+            {
+                return SR.GetResourceString("net_tooManyRedirections", null);
+            }
+        }
+
+        internal static String net_toosmall
+        {
+            get
+            {
+                return SR.GetResourceString("net_toosmall", null);
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
+        internal static String net_unknown_osinstalltype
+        {
+            get
+            {
+                return SR.GetResourceString("net_unknown_osinstalltype", null);
+            }
+        }
+
+        internal static String net_unknown_prefix
+        {
+            get
+            {
+                return SR.GetResourceString("net_unknown_prefix", null);
+            }
+        }
+
+        internal static String net_uri_AlreadyRegistered
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_AlreadyRegistered", null);
+            }
+        }
+
+        internal static String net_uri_BadAuthority
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadAuthority", null);
+            }
+        }
+
+        internal static String net_uri_BadAuthorityTerminator
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadAuthorityTerminator", null);
+            }
+        }
+
+        internal static String net_uri_BadFormat
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadFormat", null);
+            }
+        }
+
+        internal static String net_uri_BadHostName
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadHostName", null);
+            }
+        }
+
+        internal static String net_uri_BadPort
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadPort", null);
+            }
+        }
+
+        internal static String net_uri_BadScheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadScheme", null);
+            }
+        }
+
+        internal static String net_uri_BadString
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadString", null);
+            }
+        }
+
+        internal static String net_uri_BadUnicodeHostForIdn
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadUnicodeHostForIdn", null);
+            }
+        }
+
+        internal static String net_uri_BadUserPassword
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadUserPassword", null);
+            }
+        }
+
+        internal static String net_uri_CannotCreateRelative
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_CannotCreateRelative", null);
+            }
+        }
+
+        internal static String net_uri_EmptyUri
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_EmptyUri", null);
+            }
+        }
+
+        internal static String net_uri_GenericAuthorityNotDnsSafe
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_GenericAuthorityNotDnsSafe", null);
+            }
+        }
+
+        internal static String net_uri_InvalidUriKind
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_InvalidUriKind", null);
+            }
+        }
+
+        internal static String net_uri_MustRootedPath
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_MustRootedPath", null);
+            }
+        }
+
+        internal static String net_uri_NeedFreshParser
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_NeedFreshParser", null);
+            }
+        }
+
+        internal static String net_uri_NotAbsolute
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_NotAbsolute", null);
+            }
+        }
+
+        internal static String net_uri_NotJustSerialization
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_NotJustSerialization", null);
+            }
+        }
+
+        internal static String net_uri_PortOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_PortOutOfRange", null);
+            }
+        }
+
+        internal static String net_uri_SchemeLimit
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_SchemeLimit", null);
+            }
+        }
+
+        internal static String net_uri_SizeLimit
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_SizeLimit", null);
+            }
+        }
+
+        internal static String net_uri_UserDrivenParsing
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_UserDrivenParsing", null);
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
+        internal static String net_webclient
+        {
+            get
+            {
+                return SR.GetResourceString("net_webclient", null);
+            }
+        }
+
+        internal static String net_webclient_ContentType
+        {
+            get
+            {
+                return SR.GetResourceString("net_webclient_ContentType", null);
+            }
+        }
+
+        internal static String net_webclient_invalid_baseaddress
+        {
+            get
+            {
+                return SR.GetResourceString("net_webclient_invalid_baseaddress", null);
+            }
+        }
+
+        internal static String net_webclient_Multipart
+        {
+            get
+            {
+                return SR.GetResourceString("net_webclient_Multipart", null);
+            }
+        }
+
+        internal static String net_webclient_no_concurrent_io_allowed
+        {
+            get
+            {
+                return SR.GetResourceString("net_webclient_no_concurrent_io_allowed", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidControlChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidControlChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidCRLFChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidCRLFChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidHeaderChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidHeaderChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidNonAsciiChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidNonAsciiChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderMissingColon
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderMissingColon", null);
+            }
+        }
+
+        internal static String net_WebResponseParseError_CrLfError
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebResponseParseError_CrLfError", null);
+            }
+        }
+
+        internal static String net_WebResponseParseError_IncompleteHeaderLine
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebResponseParseError_IncompleteHeaderLine", null);
+            }
+        }
+
+        internal static String net_WebResponseParseError_InvalidChunkFormat
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebResponseParseError_InvalidChunkFormat", null);
+            }
+        }
+
+        internal static String net_WebResponseParseError_InvalidContentLength
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebResponseParseError_InvalidContentLength", null);
+            }
+        }
+
+        internal static String net_WebResponseParseError_InvalidHeaderName
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebResponseParseError_InvalidHeaderName", null);
+            }
+        }
+
+        internal static String net_WebResponseParseError_UnexpectedServerResponse
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebResponseParseError_UnexpectedServerResponse", null);
+            }
+        }
+
+        internal static String net_WebSockets_AcceptHeaderNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_AcceptHeaderNotFound", null);
+            }
+        }
+
+        internal static String net_WebSockets_AcceptNotAWebSocket
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_AcceptNotAWebSocket", null);
+            }
+        }
+
+        internal static String net_WebSockets_AcceptUnsupportedProtocol
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_AcceptUnsupportedProtocol", null);
+            }
+        }
+
+        internal static String net_WebSockets_AcceptUnsupportedWebSocketVersion
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_AcceptUnsupportedWebSocketVersion", null);
+            }
+        }
+
+        internal static String net_Websockets_AlreadyOneOutstandingOperation
+        {
+            get
+            {
+                return SR.GetResourceString("net_Websockets_AlreadyOneOutstandingOperation", null);
+            }
+        }
+
+        internal static String net_WebSockets_AlreadyStarted
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_AlreadyStarted", null);
+            }
+        }
+
+        internal static String net_WebSockets_Argument_InvalidMessageType
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_Argument_InvalidMessageType", null);
+            }
+        }
+
+        internal static String net_WebSockets_ArgumentOutOfRange_InternalBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ArgumentOutOfRange_InternalBuffer", null);
+            }
+        }
+
+        internal static String net_WebSockets_ArgumentOutOfRange_TooBig
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ArgumentOutOfRange_TooBig", null);
+            }
+        }
+
+        internal static String net_WebSockets_ArgumentOutOfRange_TooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ArgumentOutOfRange_TooSmall", null);
+            }
+        }
+
+        internal static String net_WebSockets_ClientAcceptingNoProtocols
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ClientAcceptingNoProtocols", null);
+            }
+        }
+
+        internal static String net_WebSockets_ClientSecWebSocketProtocolsBlank
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ClientSecWebSocketProtocolsBlank", null);
+            }
+        }
+
+        internal static String net_WebSockets_Connect101Expected
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_Connect101Expected", null);
+            }
+        }
+
+        internal static String net_WebSockets_ConnectionClosedPrematurely_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ConnectionClosedPrematurely_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_HeaderError_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_HeaderError_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidBufferType
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidBufferType", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidCharInProtocolString
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidCharInProtocolString", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidCloseStatusCode
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidCloseStatusCode", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidCloseStatusDescription
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidCloseStatusDescription", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidEmptySubProtocol
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidEmptySubProtocol", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidMessageType
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidMessageType", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidMessageType_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidMessageType_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidRegistration
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidRegistration", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidResponseHeader
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidResponseHeader", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidState
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidState", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidState_ClosedOrAborted
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidState_ClosedOrAborted", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidState_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidState_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_NativeSendResponseHeaders
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_NativeSendResponseHeaders", null);
+            }
+        }
+
+        internal static String net_WebSockets_NoDuplicateProtocol
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_NoDuplicateProtocol", null);
+            }
+        }
+
+        internal static String net_WebSockets_NotAWebSocket_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_NotAWebSocket_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_NotConnected
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_NotConnected", null);
+            }
+        }
+
+        internal static String net_WebSockets_ReasonNotNull
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ReasonNotNull", null);
+            }
+        }
+
+        internal static String net_WebSockets_ReceiveAsyncDisallowedAfterCloseAsync
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ReceiveAsyncDisallowedAfterCloseAsync", null);
+            }
+        }
+
+        internal static String net_WebSockets_Scheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_Scheme", null);
+            }
+        }
+
+        internal static String net_WebSockets_UnsupportedPlatform
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_UnsupportedPlatform", null);
+            }
+        }
+
+        internal static String net_WebSockets_UnsupportedProtocol_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_UnsupportedProtocol_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_UnsupportedWebSocketVersion_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_UnsupportedWebSocketVersion_Generic", null);
+            }
+        }
+
+        internal static String net_Websockets_WebSocketBaseFaulted
+        {
+            get
+            {
+                return SR.GetResourceString("net_Websockets_WebSocketBaseFaulted", null);
+            }
+        }
+
+        internal static String net_webstatus_CacheEntryNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_CacheEntryNotFound", null);
+            }
+        }
+
+        internal static String net_webstatus_ConnectFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_ConnectFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_ConnectionClosed
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_ConnectionClosed", null);
+            }
+        }
+
+        internal static String net_webstatus_KeepAliveFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_KeepAliveFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_MessageLengthLimitExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_MessageLengthLimitExceeded", null);
+            }
+        }
+
+        internal static String net_webstatus_NameResolutionFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_NameResolutionFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_PipelineFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_PipelineFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_ProxyNameResolutionFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_ProxyNameResolutionFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_ReceiveFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_ReceiveFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_RequestCanceled
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_RequestCanceled", null);
+            }
+        }
+
+        internal static String net_webstatus_RequestProhibitedByCachePolicy
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_RequestProhibitedByCachePolicy", null);
+            }
+        }
+
+        internal static String net_webstatus_RequestProhibitedByProxy
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_RequestProhibitedByProxy", null);
+            }
+        }
+
+        internal static String net_webstatus_SecureChannelFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_SecureChannelFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_SendFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_SendFailure", null);
+            }
+        }
+
+        internal static String net_webstatus_ServerProtocolViolation
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_ServerProtocolViolation", null);
+            }
+        }
+
+        internal static String net_webstatus_Success
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_Success", null);
+            }
+        }
+
+        internal static String net_webstatus_Timeout
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_Timeout", null);
+            }
+        }
+
+        internal static String net_webstatus_TrustFailure
+        {
+            get
+            {
+                return SR.GetResourceString("net_webstatus_TrustFailure", null);
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
+        internal static String net_writestarted
+        {
+            get
+            {
+                return SR.GetResourceString("net_writestarted", null);
+            }
+        }
+
+        internal static String net_wrongversion
+        {
+            get
+            {
+                return SR.GetResourceString("net_wrongversion", null);
+            }
+        }
+
+        internal static String NotSupported_UnreadableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnreadableStream", null);
+            }
+        }
+
+        internal static String NotSupported_UnwritableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnwritableStream", null);
+            }
+        }
+
+        internal static String ObjectDisposed_StreamIsClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_StreamIsClosed", null);
+            }
+        }
+
+        internal static String ReadNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ReadNotSupported", null);
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
+                return typeof(FxResources.System.Net.Primitives.SR);
+            }
+        }
+
+        internal static String security_ExtendedProtectionPolicy_NoEmptyServiceNameCollection
+        {
+            get
+            {
+                return SR.GetResourceString("security_ExtendedProtectionPolicy_NoEmptyServiceNameCollection", null);
+            }
+        }
+
+        internal static String security_ExtendedProtectionPolicy_UseDifferentConstructorForNever
+        {
+            get
+            {
+                return SR.GetResourceString("security_ExtendedProtectionPolicy_UseDifferentConstructorForNever", null);
+            }
+        }
+
+        internal static String security_ServiceNameCollection_EmptyServiceName
+        {
+            get
+            {
+                return SR.GetResourceString("security_ServiceNameCollection_EmptyServiceName", null);
+            }
+        }
+
+        internal static String security_X509Certificate_NotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("security_X509Certificate_NotSupported", null);
+            }
+        }
+
+        internal static String SeekNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("SeekNotSupported", null);
+            }
+        }
+
+        internal static String SmtpAllRecipientsFailed
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpAllRecipientsFailed", null);
+            }
+        }
+
+        internal static String SmtpAlreadyConnected
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpAlreadyConnected", null);
+            }
+        }
+
+        internal static String SmtpAuthenticationFailed
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpAuthenticationFailed", null);
+            }
+        }
+
+        internal static String SmtpAuthenticationFailedNoCreds
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpAuthenticationFailedNoCreds", null);
+            }
+        }
+
+        internal static String SmtpAuthResponseInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpAuthResponseInvalid", null);
+            }
+        }
+
+        internal static String SmtpBadCommandSequence
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpBadCommandSequence", null);
+            }
+        }
+
+        internal static String SmtpClientNotPermitted
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpClientNotPermitted", null);
+            }
+        }
+
+        internal static String SmtpCommandNotImplemented
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpCommandNotImplemented", null);
+            }
+        }
+
+        internal static String SmtpCommandParameterNotImplemented
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpCommandParameterNotImplemented", null);
+            }
+        }
+
+        internal static String SmtpCommandUnrecognized
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpCommandUnrecognized", null);
+            }
+        }
+
+        internal static String SmtpDataStreamOpen
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpDataStreamOpen", null);
+            }
+        }
+
+        internal static String SmtpDefaultMimePreamble
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpDefaultMimePreamble", null);
+            }
+        }
+
+        internal static String SmtpDefaultSubject
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpDefaultSubject", null);
+            }
+        }
+
+        internal static String SmtpEhloResponseInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpEhloResponseInvalid", null);
+            }
+        }
+
+        internal static String SmtpExceededStorageAllocation
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpExceededStorageAllocation", null);
+            }
+        }
+
+        internal static String SmtpFromRequired
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpFromRequired", null);
+            }
+        }
+
+        internal static String SmtpGetIisPickupDirectoryFailed
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpGetIisPickupDirectoryFailed", null);
+            }
+        }
+
+        internal static String SmtpHelpMessage
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpHelpMessage", null);
+            }
+        }
+
+        internal static String SmtpInsufficientStorage
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpInsufficientStorage", null);
+            }
+        }
+
+        internal static String SmtpInvalidHostName
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpInvalidHostName", null);
+            }
+        }
+
+        internal static String SmtpInvalidOperationDuringSend
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpInvalidOperationDuringSend", null);
+            }
+        }
+
+        internal static String SmtpInvalidResponse
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpInvalidResponse", null);
+            }
+        }
+
+        internal static String SmtpLocalErrorInProcessing
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpLocalErrorInProcessing", null);
+            }
+        }
+
+        internal static String SmtpMailboxBusy
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpMailboxBusy", null);
+            }
+        }
+
+        internal static String SmtpMailboxNameNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpMailboxNameNotAllowed", null);
+            }
+        }
+
+        internal static String SmtpMailboxUnavailable
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpMailboxUnavailable", null);
+            }
+        }
+
+        internal static String SmtpMustIssueStartTlsFirst
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpMustIssueStartTlsFirst", null);
+            }
+        }
+
+        internal static String SmtpNeedAbsolutePickupDirectory
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpNeedAbsolutePickupDirectory", null);
+            }
+        }
+
+        internal static String SmtpNonAsciiUserNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpNonAsciiUserNotSupported", null);
+            }
+        }
+
+        internal static String SmtpNotConnected
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpNotConnected", null);
+            }
+        }
+
+        internal static String SmtpOK
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpOK", null);
+            }
+        }
+
+        internal static String SmtpOperationInProgress
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpOperationInProgress", null);
+            }
+        }
+
+        internal static String SmtpPermissionDenied
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpPermissionDenied", null);
+            }
+        }
+
+        internal static String SmtpPickupDirectoryDoesnotSupportSsl
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpPickupDirectoryDoesnotSupportSsl", null);
+            }
+        }
+
+        internal static String SmtpRecipientFailed
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpRecipientFailed", null);
+            }
+        }
+
+        internal static String SmtpRecipientRequired
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpRecipientRequired", null);
+            }
+        }
+
+        internal static String SmtpSendMailFailure
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpSendMailFailure", null);
+            }
+        }
+
+        internal static String SmtpServiceClosingTransmissionChannel
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpServiceClosingTransmissionChannel", null);
+            }
+        }
+
+        internal static String SmtpServiceNotAvailable
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpServiceNotAvailable", null);
+            }
+        }
+
+        internal static String SmtpServiceReady
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpServiceReady", null);
+            }
+        }
+
+        internal static String SmtpStartMailInput
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpStartMailInput", null);
+            }
+        }
+
+        internal static String SmtpSyntaxError
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpSyntaxError", null);
+            }
+        }
+
+        internal static String SmtpSystemStatus
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpSystemStatus", null);
+            }
+        }
+
+        internal static String SmtpTransactionFailed
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpTransactionFailed", null);
+            }
+        }
+
+        internal static String SmtpUserNotLocalTryAlternatePath
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpUserNotLocalTryAlternatePath", null);
+            }
+        }
+
+        internal static String SmtpUserNotLocalWillForward
+        {
+            get
+            {
+                return SR.GetResourceString("SmtpUserNotLocalWillForward", null);
+            }
+        }
+
+        internal static String SSPIAuthenticationOrSPNNull
+        {
+            get
+            {
+                return SR.GetResourceString("SSPIAuthenticationOrSPNNull", null);
+            }
+        }
+
+        internal static String SSPIInvalidHandleType
+        {
+            get
+            {
+                return SR.GetResourceString("SSPIInvalidHandleType", null);
+            }
+        }
+
+        internal static String SSPIPInvokeError
+        {
+            get
+            {
+                return SR.GetResourceString("SSPIPInvokeError", null);
+            }
+        }
+
+        internal static String UnspecifiedHost
+        {
+            get
+            {
+                return SR.GetResourceString("UnspecifiedHost", null);
+            }
+        }
+
+        internal static String WriteNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("WriteNotSupported", null);
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
