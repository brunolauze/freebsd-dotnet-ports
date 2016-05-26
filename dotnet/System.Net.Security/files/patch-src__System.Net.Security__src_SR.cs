--- /dev/null	2016-05-11 07:03:45.000000000 -0400
+++ src/System.Net.Security/src/SR.cs	2016-05-11 07:04:17.077105000 -0400
@@ -0,0 +1,999 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.Security
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
+        private const String s_resourcesName = "FxResources.System.Net.Security.SR";
+
+
+	internal static String net_nego_protection_level_not_supported
+	{
+            get
+            {
+                return SR.GetResourceString("net_nego_protection_level_not_supported", null);
+            }
+        }
+		
+	internal static String net_nego_not_supported_empty_target_with_defaultcreds
+	{
+            get
+            {
+                return SR.GetResourceString("net_nego_not_supported_empty_target_with_defaultcreds", null);
+            }
+        }
+		
+	internal static String net_ntlm_not_possible_default_cred
+	{
+            get
+            {
+                return SR.GetResourceString("net_ntlm_not_possible_default_cred", null);
+            }
+        }
+
+        internal static String Arg_ArrayPlusOffTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ArrayPlusOffTooSmall", null);
+            }
+        }
+
+        internal static String Arg_RankMultiDimNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RankMultiDimNotSupported", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static String event_AttemptingRestartUsingCert
+        {
+            get
+            {
+                return SR.GetResourceString("event_AttemptingRestartUsingCert", null);
+            }
+        }
+
+        internal static String event_CertificateFromDelegate
+        {
+            get
+            {
+                return SR.GetResourceString("event_CertificateFromDelegate", null);
+            }
+        }
+
+        internal static String event_CertIsType2
+        {
+            get
+            {
+                return SR.GetResourceString("event_CertIsType2", null);
+            }
+        }
+
+        internal static String event_CertsAfterFiltering
+        {
+            get
+            {
+                return SR.GetResourceString("event_CertsAfterFiltering", null);
+            }
+        }
+
+        internal static String event_EnumerateSecurityPackages
+        {
+            get
+            {
+                return SR.GetResourceString("event_EnumerateSecurityPackages", null);
+            }
+        }
+
+        internal static String event_FindingMatchingCerts
+        {
+            get
+            {
+                return SR.GetResourceString("event_FindingMatchingCerts", null);
+            }
+        }
+
+        internal static String event_FoundCertInStore
+        {
+            get
+            {
+                return SR.GetResourceString("event_FoundCertInStore", null);
+            }
+        }
+
+        internal static String event_LocatingPrivateKey
+        {
+            get
+            {
+                return SR.GetResourceString("event_LocatingPrivateKey", null);
+            }
+        }
+
+        internal static String event_LookForMatchingCerts
+        {
+            get
+            {
+                return SR.GetResourceString("event_LookForMatchingCerts", null);
+            }
+        }
+
+        internal static String event_NoDelegateButClientCert
+        {
+            get
+            {
+                return SR.GetResourceString("event_NoDelegateButClientCert", null);
+            }
+        }
+
+        internal static String event_NoDelegateNoClientCert
+        {
+            get
+            {
+                return SR.GetResourceString("event_NoDelegateNoClientCert", null);
+            }
+        }
+
+        internal static String event_NoIssuersTryAllCerts
+        {
+            get
+            {
+                return SR.GetResourceString("event_NoIssuersTryAllCerts", null);
+            }
+        }
+
+        internal static String event_NotFoundCertInStore
+        {
+            get
+            {
+                return SR.GetResourceString("event_NotFoundCertInStore", null);
+            }
+        }
+
+        internal static String event_OperationReturnedSomething
+        {
+            get
+            {
+                return SR.GetResourceString("event_OperationReturnedSomething", null);
+            }
+        }
+
+        internal static String event_RemoteCertDeclaredValid
+        {
+            get
+            {
+                return SR.GetResourceString("event_RemoteCertDeclaredValid", null);
+            }
+        }
+
+        internal static String event_RemoteCertHasNoErrors
+        {
+            get
+            {
+                return SR.GetResourceString("event_RemoteCertHasNoErrors", null);
+            }
+        }
+
+        internal static String event_RemoteCertificate
+        {
+            get
+            {
+                return SR.GetResourceString("event_RemoteCertificate", null);
+            }
+        }
+
+        internal static String event_RemoteCertUserDeclaredInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("event_RemoteCertUserDeclaredInvalid", null);
+            }
+        }
+
+        internal static String event_SecurityContextInputBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("event_SecurityContextInputBuffer", null);
+            }
+        }
+
+        internal static String event_SecurityContextInputBuffers
+        {
+            get
+            {
+                return SR.GetResourceString("event_SecurityContextInputBuffers", null);
+            }
+        }
+
+        internal static String event_SelectedCert
+        {
+            get
+            {
+                return SR.GetResourceString("event_SelectedCert", null);
+            }
+        }
+
+        internal static String event_SspiPackageNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("event_SspiPackageNotFound", null);
+            }
+        }
+
+        internal static String event_SspiSelectedCipherSuite
+        {
+            get
+            {
+                return SR.GetResourceString("event_SspiSelectedCipherSuite", null);
+            }
+        }
+
+        internal static String event_UsingCachedCredential
+        {
+            get
+            {
+                return SR.GetResourceString("event_UsingCachedCredential", null);
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
+        internal static String net_allocate_ssl_context_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_allocate_ssl_context_failed", null);
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
+        internal static String net_auth_eof
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_eof", null);
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
+        internal static String net_auth_noauth
+        {
+            get
+            {
+                return SR.GetResourceString("net_auth_noauth", null);
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
+        internal static String net_completed_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_completed_result", null);
+            }
+        }
+
+        internal static String net_context_buffer_too_small
+        {
+            get
+            {
+                return SR.GetResourceString("net_context_buffer_too_small", null);
+            }
+        }
+
+        internal static String net_context_establishment_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_context_establishment_failed", null);
+            }
+        }
+
+        internal static String net_context_unwrap_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_context_unwrap_failed", null);
+            }
+        }
+
+        internal static String net_context_wrap_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_context_wrap_failed", null);
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
+        internal static String net_generic_operation_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_generic_operation_failed", null);
+            }
+        }
+
+        internal static String net_get_ssl_method_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_get_ssl_method_failed", null);
+            }
+        }
+
+        internal static String net_gssapi_operation_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_gssapi_operation_failed", null);
+            }
+        }
+
+        internal static String net_gssapi_operation_failed_detailed
+        {
+            get
+            {
+                return SR.GetResourceString("net_gssapi_operation_failed_detailed", null);
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
+        internal static String net_io_async_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_async_result", null);
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
+        internal static String net_io_write
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_write", null);
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
+        internal static String net_log_remote_cert_has_errors
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_remote_cert_has_errors", null);
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
+        internal static String net_MethodNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_MethodNotImplementedException", null);
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
+        internal static String net_nego_channel_binding_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_nego_channel_binding_not_supported", null);
+            }
+        }
+
+        internal static String net_nego_ntlm_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_nego_ntlm_not_supported", null);
+            }
+        }
+
+        internal static String net_nego_server_not_supported
+        {
+            get
+            {
+                return SR.GetResourceString("net_nego_server_not_supported", null);
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
+        internal static String net_offset_plus_count
+        {
+            get
+            {
+                return SR.GetResourceString("net_offset_plus_count", null);
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
+        internal static String net_ssl_check_private_key_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_check_private_key_failed", null);
+            }
+        }
+
+        internal static String net_ssl_decrypt_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_decrypt_failed", null);
+            }
+        }
+
+        internal static String net_ssl_encrypt_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_encrypt_failed", null);
+            }
+        }
+
+        internal static String net_ssl_encryptionpolicy_notsupported
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_encryptionpolicy_notsupported", null);
+            }
+        }
+
+        internal static String net_ssl_get_channel_binding_token_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_get_channel_binding_token_failed", null);
+            }
+        }
+
+        internal static String net_ssl_get_connection_info_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_get_connection_info_failed", null);
+            }
+        }
+
+        internal static String net_ssl_handshake_failed_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_handshake_failed_error", null);
+            }
+        }
+
+        internal static String net_ssl_invalid_certificate
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_invalid_certificate", null);
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
+        internal static String net_ssl_io_frame
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_io_frame", null);
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
+        internal static String net_ssl_read_bio_failed_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_read_bio_failed_error", null);
+            }
+        }
+
+        internal static String net_ssl_use_cert_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_use_cert_failed", null);
+            }
+        }
+
+        internal static String net_ssl_use_private_key_failed
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_use_private_key_failed", null);
+            }
+        }
+
+        internal static String net_ssl_write_bio_failed_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_write_bio_failed_error", null);
+            }
+        }
+
+        internal static String net_ssl_x509Name_push_failed_error
+        {
+            get
+            {
+                return SR.GetResourceString("net_ssl_x509Name_push_failed_error", null);
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
+                return typeof(FxResources.System.Net.Security.SR);
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
+        internal static String SSPIInvalidHandleType
+        {
+            get
+            {
+                return SR.GetResourceString("SSPIInvalidHandleType", null);
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
