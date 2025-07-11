/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/
namespace Opc.Ua.Gds.WebApi
{
    /// <summary>
    /// The namespaces used in the model.
    /// </summary>
    public static class Namespaces
    {
        /// <remarks />
        public const string Uri = "http://opcfoundation.org/UA/GDS/";
    }

    /// <summary>
    /// The browse names defined in the model.
    /// </summary>
    public static class BrowseNames
    {
        /// <remarks />
        public const string AccessTokenIssuedAuditEventType = "AccessTokenIssuedAuditEventType";
        /// <remarks />
        public const string ApplicationRecordDataType = "ApplicationRecordDataType";
        /// <remarks />
        public const string ApplicationRegistrationChangedAuditEventType = "ApplicationRegistrationChangedAuditEventType";
        /// <remarks />
        public const string Applications = "Applications";
        /// <remarks />
        public const string AuthorizationServices = "AuthorizationServices";
        /// <remarks />
        public const string AuthorizationServicesFolderType = "AuthorizationServicesFolderType";
        /// <remarks />
        public const string AuthorizationServiceType = "AuthorizationServiceType";
        /// <remarks />
        public const string CertificateDeliveredAuditEventType = "CertificateDeliveredAuditEventType";
        /// <remarks />
        public const string CertificateDirectoryType = "CertificateDirectoryType";
        /// <remarks />
        public const string CertificateGroup = "CertificateGroup";
        /// <remarks />
        public const string CertificateGroups = "CertificateGroups";
        /// <remarks />
        public const string CertificateRequestedAuditEventType = "CertificateRequestedAuditEventType";
        /// <remarks />
        public const string CertificateRevokedAuditEventType = "CertificateRevokedAuditEventType";
        /// <remarks />
        public const string CertificateType = "CertificateType";
        /// <remarks />
        public const string CheckRevocationStatus = "CheckRevocationStatus";
        /// <remarks />
        public const string Directory = "Directory";
        /// <remarks />
        public const string DirectoryType = "DirectoryType";
        /// <remarks />
        public const string FindApplications = "FindApplications";
        /// <remarks />
        public const string FinishRequest = "FinishRequest";
        /// <remarks />
        public const string GetApplication = "GetApplication";
        /// <remarks />
        public const string GetCertificateGroups = "GetCertificateGroups";
        /// <remarks />
        public const string GetCertificates = "GetCertificates";
        /// <remarks />
        public const string GetCertificateStatus = "GetCertificateStatus";
        /// <remarks />
        public const string GetServiceDescription = "GetServiceDescription";
        /// <remarks />
        public const string GetTrustList = "GetTrustList";
        /// <remarks />
        public const string KeyCredentialDeliveredAuditEventType = "KeyCredentialDeliveredAuditEventType";
        /// <remarks />
        public const string KeyCredentialManagement = "KeyCredentialManagement";
        /// <remarks />
        public const string KeyCredentialManagementFolderType = "KeyCredentialManagementFolderType";
        /// <remarks />
        public const string KeyCredentialRequestedAuditEventType = "KeyCredentialRequestedAuditEventType";
        /// <remarks />
        public const string KeyCredentialRevokedAuditEventType = "KeyCredentialRevokedAuditEventType";
        /// <remarks />
        public const string KeyCredentialServiceType = "KeyCredentialServiceType";
        /// <remarks />
        public const string ModelVersion = "ModelVersion";
        /// <remarks />
        public const string OpcUaGds_BinarySchema = "Opc.Ua.Gds";
        /// <remarks />
        public const string OpcUaGds_XmlSchema = "Opc.Ua.Gds";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata = "http://opcfoundation.org/UA/GDS/";
        /// <remarks />
        public const string ProfileUris = "ProfileUris";
        /// <remarks />
        public const string QueryApplications = "QueryApplications";
        /// <remarks />
        public const string QueryServers = "QueryServers";
        /// <remarks />
        public const string RegisterApplication = "RegisterApplication";
        /// <remarks />
        public const string RequestAccessToken = "RequestAccessToken";
        /// <remarks />
        public const string ResourceUri = "ResourceUri";
        /// <remarks />
        public const string Revoke = "Revoke";
        /// <remarks />
        public const string RevokeCertificate = "RevokeCertificate";
        /// <remarks />
        public const string SecurityPolicyUris = "SecurityPolicyUris";
        /// <remarks />
        public const string ServiceCertificate = "ServiceCertificate";
        /// <remarks />
        public const string ServiceName_Placeholder = "<ServiceName>";
        /// <remarks />
        public const string ServiceUri = "ServiceUri";
        /// <remarks />
        public const string StartNewKeyPairRequest = "StartNewKeyPairRequest";
        /// <remarks />
        public const string StartRequest = "StartRequest";
        /// <remarks />
        public const string StartSigningRequest = "StartSigningRequest";
        /// <remarks />
        public const string UnregisterApplication = "UnregisterApplication";
        /// <remarks />
        public const string UpdateApplication = "UpdateApplication";
        /// <remarks />
        public const string UserTokenPolicies = "UserTokenPolicies";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin = "AuthorizationServiceAdmin";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin = "CertificateAuthorityAdmin";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin = "DiscoveryAdmin";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin = "KeyCredentialAdmin";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin = "RegistrationAuthorityAdmin";
    }

    /// <summary>
    /// The well known identifiers for DataType nodes.
    /// </summary>
    public static class DataTypeIds {
        /// <remarks />
        public const string ApplicationRecordDataType = "nsu=" + Namespaces.Uri + ";i=1";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(DataTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Method nodes.
    /// </summary>
    public static class MethodIds {
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Open = "nsu=" + Namespaces.Uri + ";i=735";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Close = "nsu=" + Namespaces.Uri + ";i=738";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Read = "nsu=" + Namespaces.Uri + ";i=740";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Write = "nsu=" + Namespaces.Uri + ";i=743";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_GetPosition = "nsu=" + Namespaces.Uri + ";i=745";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_SetPosition = "nsu=" + Namespaces.Uri + ";i=748";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_AddIdentity = "nsu=" + Namespaces.Uri + ";i=1668";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_RemoveIdentity = "nsu=" + Namespaces.Uri + ";i=1670";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_AddApplication = "nsu=" + Namespaces.Uri + ";i=1672";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_RemoveApplication = "nsu=" + Namespaces.Uri + ";i=1674";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_AddEndpoint = "nsu=" + Namespaces.Uri + ";i=1676";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_RemoveEndpoint = "nsu=" + Namespaces.Uri + ";i=1678";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_AddIdentity = "nsu=" + Namespaces.Uri + ";i=1687";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_RemoveIdentity = "nsu=" + Namespaces.Uri + ";i=1689";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_AddApplication = "nsu=" + Namespaces.Uri + ";i=1691";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_RemoveApplication = "nsu=" + Namespaces.Uri + ";i=1693";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_AddEndpoint = "nsu=" + Namespaces.Uri + ";i=1695";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_RemoveEndpoint = "nsu=" + Namespaces.Uri + ";i=1697";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_AddIdentity = "nsu=" + Namespaces.Uri + ";i=1706";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_RemoveIdentity = "nsu=" + Namespaces.Uri + ";i=1708";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_AddApplication = "nsu=" + Namespaces.Uri + ";i=1710";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_RemoveApplication = "nsu=" + Namespaces.Uri + ";i=1712";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_AddEndpoint = "nsu=" + Namespaces.Uri + ";i=1714";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_RemoveEndpoint = "nsu=" + Namespaces.Uri + ";i=1716";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_AddIdentity = "nsu=" + Namespaces.Uri + ";i=1725";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_RemoveIdentity = "nsu=" + Namespaces.Uri + ";i=1727";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_AddApplication = "nsu=" + Namespaces.Uri + ";i=1729";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_RemoveApplication = "nsu=" + Namespaces.Uri + ";i=1731";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_AddEndpoint = "nsu=" + Namespaces.Uri + ";i=1733";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_RemoveEndpoint = "nsu=" + Namespaces.Uri + ";i=1735";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_AddIdentity = "nsu=" + Namespaces.Uri + ";i=1744";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_RemoveIdentity = "nsu=" + Namespaces.Uri + ";i=1746";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_AddApplication = "nsu=" + Namespaces.Uri + ";i=1748";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_RemoveApplication = "nsu=" + Namespaces.Uri + ";i=1750";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_AddEndpoint = "nsu=" + Namespaces.Uri + ";i=1752";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_RemoveEndpoint = "nsu=" + Namespaces.Uri + ";i=1754";
        /// <remarks />
        public const string DirectoryType_FindApplications = "nsu=" + Namespaces.Uri + ";i=15";
        /// <remarks />
        public const string DirectoryType_RegisterApplication = "nsu=" + Namespaces.Uri + ";i=18";
        /// <remarks />
        public const string DirectoryType_UpdateApplication = "nsu=" + Namespaces.Uri + ";i=188";
        /// <remarks />
        public const string DirectoryType_UnregisterApplication = "nsu=" + Namespaces.Uri + ";i=21";
        /// <remarks />
        public const string DirectoryType_GetApplication = "nsu=" + Namespaces.Uri + ";i=210";
        /// <remarks />
        public const string DirectoryType_QueryApplications = "nsu=" + Namespaces.Uri + ";i=868";
        /// <remarks />
        public const string DirectoryType_QueryServers = "nsu=" + Namespaces.Uri + ";i=23";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Open = "nsu=" + Namespaces.Uri + ";i=519";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Close = "nsu=" + Namespaces.Uri + ";i=522";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Read = "nsu=" + Namespaces.Uri + ";i=524";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Write = "nsu=" + Namespaces.Uri + ";i=527";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_GetPosition = "nsu=" + Namespaces.Uri + ";i=529";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_SetPosition = "nsu=" + Namespaces.Uri + ";i=532";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=535";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=538";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_AddCertificate = "nsu=" + Namespaces.Uri + ";i=541";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=543";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Disable = "nsu=" + Namespaces.Uri + ";i=15041";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Enable = "nsu=" + Namespaces.Uri + ";i=15042";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AddComment = "nsu=" + Namespaces.Uri + ";i=15043";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15063";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=15110";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=15112";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=15113";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Disable = "nsu=" + Namespaces.Uri + ";i=15189";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Enable = "nsu=" + Namespaces.Uri + ";i=15190";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AddComment = "nsu=" + Namespaces.Uri + ";i=15191";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15211";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=15258";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=15260";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=15261";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Open = "nsu=" + Namespaces.Uri + ";i=553";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Close = "nsu=" + Namespaces.Uri + ";i=556";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Read = "nsu=" + Namespaces.Uri + ";i=558";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Write = "nsu=" + Namespaces.Uri + ";i=561";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_GetPosition = "nsu=" + Namespaces.Uri + ";i=563";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_SetPosition = "nsu=" + Namespaces.Uri + ";i=566";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=569";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=572";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_AddCertificate = "nsu=" + Namespaces.Uri + ";i=575";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=577";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Disable = "nsu=" + Namespaces.Uri + ";i=15337";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Enable = "nsu=" + Namespaces.Uri + ";i=15338";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AddComment = "nsu=" + Namespaces.Uri + ";i=15339";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15359";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=15406";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=15408";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=15409";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Disable = "nsu=" + Namespaces.Uri + ";i=15485";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Enable = "nsu=" + Namespaces.Uri + ";i=15486";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AddComment = "nsu=" + Namespaces.Uri + ";i=15487";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15507";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=15554";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=15556";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=15557";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Open = "nsu=" + Namespaces.Uri + ";i=587";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Close = "nsu=" + Namespaces.Uri + ";i=590";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Read = "nsu=" + Namespaces.Uri + ";i=592";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Write = "nsu=" + Namespaces.Uri + ";i=595";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_GetPosition = "nsu=" + Namespaces.Uri + ";i=597";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_SetPosition = "nsu=" + Namespaces.Uri + ";i=600";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=603";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=606";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_AddCertificate = "nsu=" + Namespaces.Uri + ";i=609";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=611";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Disable = "nsu=" + Namespaces.Uri + ";i=15633";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Enable = "nsu=" + Namespaces.Uri + ";i=15634";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AddComment = "nsu=" + Namespaces.Uri + ";i=15635";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15655";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=15702";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=15704";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=15705";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Disable = "nsu=" + Namespaces.Uri + ";i=15781";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Enable = "nsu=" + Namespaces.Uri + ";i=15782";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AddComment = "nsu=" + Namespaces.Uri + ";i=15783";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15803";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=15850";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=15852";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=15853";
        /// <remarks />
        public const string CertificateDirectoryType_StartSigningRequest = "nsu=" + Namespaces.Uri + ";i=79";
        /// <remarks />
        public const string CertificateDirectoryType_StartNewKeyPairRequest = "nsu=" + Namespaces.Uri + ";i=76";
        /// <remarks />
        public const string CertificateDirectoryType_FinishRequest = "nsu=" + Namespaces.Uri + ";i=85";
        /// <remarks />
        public const string CertificateDirectoryType_RevokeCertificate = "nsu=" + Namespaces.Uri + ";i=15003";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificateGroups = "nsu=" + Namespaces.Uri + ";i=369";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificates = "nsu=" + Namespaces.Uri + ";i=89";
        /// <remarks />
        public const string CertificateDirectoryType_GetTrustList = "nsu=" + Namespaces.Uri + ";i=197";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificateStatus = "nsu=" + Namespaces.Uri + ";i=222";
        /// <remarks />
        public const string CertificateDirectoryType_CheckRevocationStatus = "nsu=" + Namespaces.Uri + ";i=126";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_StartRequest = "nsu=" + Namespaces.Uri + ";i=168";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_FinishRequest = "nsu=" + Namespaces.Uri + ";i=196";
        /// <remarks />
        public const string KeyCredentialServiceType_StartRequest = "nsu=" + Namespaces.Uri + ";i=1023";
        /// <remarks />
        public const string KeyCredentialServiceType_FinishRequest = "nsu=" + Namespaces.Uri + ";i=1026";
        /// <remarks />
        public const string KeyCredentialServiceType_Revoke = "nsu=" + Namespaces.Uri + ";i=1029";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder_GetServiceDescription = "nsu=" + Namespaces.Uri + ";i=238";
        /// <remarks />
        public const string AuthorizationServiceType_GetServiceDescription = "nsu=" + Namespaces.Uri + ";i=1004";
        /// <remarks />
        public const string AuthorizationServiceType_RequestAccessToken = "nsu=" + Namespaces.Uri + ";i=969";
        /// <remarks />
        public const string Directory_FindApplications = "nsu=" + Namespaces.Uri + ";i=143";
        /// <remarks />
        public const string Directory_RegisterApplication = "nsu=" + Namespaces.Uri + ";i=146";
        /// <remarks />
        public const string Directory_UpdateApplication = "nsu=" + Namespaces.Uri + ";i=200";
        /// <remarks />
        public const string Directory_UnregisterApplication = "nsu=" + Namespaces.Uri + ";i=149";
        /// <remarks />
        public const string Directory_GetApplication = "nsu=" + Namespaces.Uri + ";i=216";
        /// <remarks />
        public const string Directory_QueryApplications = "nsu=" + Namespaces.Uri + ";i=992";
        /// <remarks />
        public const string Directory_QueryServers = "nsu=" + Namespaces.Uri + ";i=151";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Open = "nsu=" + Namespaces.Uri + ";i=622";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Close = "nsu=" + Namespaces.Uri + ";i=625";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Read = "nsu=" + Namespaces.Uri + ";i=627";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Write = "nsu=" + Namespaces.Uri + ";i=630";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_GetPosition = "nsu=" + Namespaces.Uri + ";i=632";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_SetPosition = "nsu=" + Namespaces.Uri + ";i=635";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=638";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=641";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_AddCertificate = "nsu=" + Namespaces.Uri + ";i=644";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=646";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Disable = "nsu=" + Namespaces.Uri + ";i=15946";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Enable = "nsu=" + Namespaces.Uri + ";i=15947";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AddComment = "nsu=" + Namespaces.Uri + ";i=15948";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Acknowledge = "nsu=" + Namespaces.Uri + ";i=15968";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=16015";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=16017";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=16018";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Disable = "nsu=" + Namespaces.Uri + ";i=16094";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Enable = "nsu=" + Namespaces.Uri + ";i=16095";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AddComment = "nsu=" + Namespaces.Uri + ";i=16096";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Acknowledge = "nsu=" + Namespaces.Uri + ";i=16116";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=16163";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=16165";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=16166";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Open = "nsu=" + Namespaces.Uri + ";i=656";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Close = "nsu=" + Namespaces.Uri + ";i=659";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Read = "nsu=" + Namespaces.Uri + ";i=661";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Write = "nsu=" + Namespaces.Uri + ";i=664";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_GetPosition = "nsu=" + Namespaces.Uri + ";i=666";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_SetPosition = "nsu=" + Namespaces.Uri + ";i=669";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=672";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=675";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_AddCertificate = "nsu=" + Namespaces.Uri + ";i=678";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=680";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Disable = "nsu=" + Namespaces.Uri + ";i=16242";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Enable = "nsu=" + Namespaces.Uri + ";i=16243";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AddComment = "nsu=" + Namespaces.Uri + ";i=16244";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Acknowledge = "nsu=" + Namespaces.Uri + ";i=16264";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=16311";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=16313";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=16314";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Disable = "nsu=" + Namespaces.Uri + ";i=16390";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Enable = "nsu=" + Namespaces.Uri + ";i=16391";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AddComment = "nsu=" + Namespaces.Uri + ";i=16392";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Acknowledge = "nsu=" + Namespaces.Uri + ";i=16412";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=16459";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=16461";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=16462";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Open = "nsu=" + Namespaces.Uri + ";i=690";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Close = "nsu=" + Namespaces.Uri + ";i=693";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Read = "nsu=" + Namespaces.Uri + ";i=695";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Write = "nsu=" + Namespaces.Uri + ";i=698";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_GetPosition = "nsu=" + Namespaces.Uri + ";i=700";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_SetPosition = "nsu=" + Namespaces.Uri + ";i=703";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=706";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=709";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_AddCertificate = "nsu=" + Namespaces.Uri + ";i=712";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=714";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Disable = "nsu=" + Namespaces.Uri + ";i=16538";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Enable = "nsu=" + Namespaces.Uri + ";i=16539";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AddComment = "nsu=" + Namespaces.Uri + ";i=16540";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Acknowledge = "nsu=" + Namespaces.Uri + ";i=16560";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=16607";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=16609";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=16610";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Disable = "nsu=" + Namespaces.Uri + ";i=16686";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Enable = "nsu=" + Namespaces.Uri + ";i=16687";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AddComment = "nsu=" + Namespaces.Uri + ";i=16688";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Acknowledge = "nsu=" + Namespaces.Uri + ";i=16708";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_TimedShelve = "nsu=" + Namespaces.Uri + ";i=16755";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_Unshelve = "nsu=" + Namespaces.Uri + ";i=16757";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_OneShotShelve = "nsu=" + Namespaces.Uri + ";i=16758";
        /// <remarks />
        public const string Directory_StartSigningRequest = "nsu=" + Namespaces.Uri + ";i=157";
        /// <remarks />
        public const string Directory_StartNewKeyPairRequest = "nsu=" + Namespaces.Uri + ";i=154";
        /// <remarks />
        public const string Directory_FinishRequest = "nsu=" + Namespaces.Uri + ";i=163";
        /// <remarks />
        public const string Directory_GetCertificateGroups = "nsu=" + Namespaces.Uri + ";i=508";
        /// <remarks />
        public const string Directory_GetTrustList = "nsu=" + Namespaces.Uri + ";i=204";
        /// <remarks />
        public const string Directory_GetCertificateStatus = "nsu=" + Namespaces.Uri + ";i=225";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(MethodIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Object nodes.
    /// </summary>
    public static class ObjectIds {
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata = "nsu=" + Namespaces.Uri + ";i=721";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin = "nsu=" + Namespaces.Uri + ";i=1661";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin = "nsu=" + Namespaces.Uri + ";i=1680";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin = "nsu=" + Namespaces.Uri + ";i=1699";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin = "nsu=" + Namespaces.Uri + ";i=1718";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin = "nsu=" + Namespaces.Uri + ";i=1737";
        /// <remarks />
        public const string DirectoryType_Applications = "nsu=" + Namespaces.Uri + ";i=14";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups = "nsu=" + Namespaces.Uri + ";i=511";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup = "nsu=" + Namespaces.Uri + ";i=512";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList = "nsu=" + Namespaces.Uri + ";i=513";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList = "nsu=" + Namespaces.Uri + ";i=547";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList = "nsu=" + Namespaces.Uri + ";i=581";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder = "nsu=" + Namespaces.Uri + ";i=61";
        /// <remarks />
        public const string KeyCredentialManagement = "nsu=" + Namespaces.Uri + ";i=1008";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder = "nsu=" + Namespaces.Uri + ";i=234";
        /// <remarks />
        public const string AuthorizationServices = "nsu=" + Namespaces.Uri + ";i=959";
        /// <remarks />
        public const string Directory = "nsu=" + Namespaces.Uri + ";i=141";
        /// <remarks />
        public const string Directory_Applications = "nsu=" + Namespaces.Uri + ";i=142";
        /// <remarks />
        public const string Directory_CertificateGroups = "nsu=" + Namespaces.Uri + ";i=614";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup = "nsu=" + Namespaces.Uri + ";i=615";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList = "nsu=" + Namespaces.Uri + ";i=616";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup = "nsu=" + Namespaces.Uri + ";i=649";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList = "nsu=" + Namespaces.Uri + ";i=650";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup = "nsu=" + Namespaces.Uri + ";i=683";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList = "nsu=" + Namespaces.Uri + ";i=684";
        /// <remarks />
        public const string ApplicationRecordDataType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=134";
        /// <remarks />
        public const string ApplicationRecordDataType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=127";
        /// <remarks />
        public const string ApplicationRecordDataType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=8001";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for ObjectType nodes.
    /// </summary>
    public static class ObjectTypeIds {
        /// <remarks />
        public const string DirectoryType = "nsu=" + Namespaces.Uri + ";i=13";
        /// <remarks />
        public const string ApplicationRegistrationChangedAuditEventType = "nsu=" + Namespaces.Uri + ";i=26";
        /// <remarks />
        public const string CertificateDirectoryType = "nsu=" + Namespaces.Uri + ";i=63";
        /// <remarks />
        public const string CertificateRequestedAuditEventType = "nsu=" + Namespaces.Uri + ";i=91";
        /// <remarks />
        public const string CertificateDeliveredAuditEventType = "nsu=" + Namespaces.Uri + ";i=109";
        /// <remarks />
        public const string CertificateRevokedAuditEventType = "nsu=" + Namespaces.Uri + ";i=27";
        /// <remarks />
        public const string KeyCredentialManagementFolderType = "nsu=" + Namespaces.Uri + ";i=55";
        /// <remarks />
        public const string KeyCredentialServiceType = "nsu=" + Namespaces.Uri + ";i=1020";
        /// <remarks />
        public const string KeyCredentialRequestedAuditEventType = "nsu=" + Namespaces.Uri + ";i=1039";
        /// <remarks />
        public const string KeyCredentialDeliveredAuditEventType = "nsu=" + Namespaces.Uri + ";i=1057";
        /// <remarks />
        public const string KeyCredentialRevokedAuditEventType = "nsu=" + Namespaces.Uri + ";i=1075";
        /// <remarks />
        public const string AuthorizationServicesFolderType = "nsu=" + Namespaces.Uri + ";i=233";
        /// <remarks />
        public const string AuthorizationServiceType = "nsu=" + Namespaces.Uri + ";i=966";
        /// <remarks />
        public const string AccessTokenIssuedAuditEventType = "nsu=" + Namespaces.Uri + ";i=975";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Variable nodes.
    /// </summary>
    public static class VariableIds {
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=722";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceVersion = "nsu=" + Namespaces.Uri + ";i=723";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespacePublicationDate = "nsu=" + Namespaces.Uri + ";i=724";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_IsNamespaceSubset = "nsu=" + Namespaces.Uri + ";i=725";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_StaticNodeIdTypes = "nsu=" + Namespaces.Uri + ";i=726";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_StaticNumericNodeIdRange = "nsu=" + Namespaces.Uri + ";i=727";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_StaticStringNodeIdPattern = "nsu=" + Namespaces.Uri + ";i=728";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Size = "nsu=" + Namespaces.Uri + ";i=730";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Writable = "nsu=" + Namespaces.Uri + ";i=731";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_UserWritable = "nsu=" + Namespaces.Uri + ";i=732";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_OpenCount = "nsu=" + Namespaces.Uri + ";i=733";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=736";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=737";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=739";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=741";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=742";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=744";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=746";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=747";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=749";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_DefaultRolePermissions = "nsu=" + Namespaces.Uri + ";i=862";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_DefaultUserRolePermissions = "nsu=" + Namespaces.Uri + ";i=863";
        /// <remarks />
        public const string OPCUAGDSNamespaceMetadata_DefaultAccessRestrictions = "nsu=" + Namespaces.Uri + ";i=864";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_Identities = "nsu=" + Namespaces.Uri + ";i=1662";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_ApplicationsExclude = "nsu=" + Namespaces.Uri + ";i=1663";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_Applications = "nsu=" + Namespaces.Uri + ";i=1664";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_EndpointsExclude = "nsu=" + Namespaces.Uri + ";i=1665";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_Endpoints = "nsu=" + Namespaces.Uri + ";i=1666";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1669";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1671";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1673";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1675";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1677";
        /// <remarks />
        public const string WellKnownRole_DiscoveryAdmin_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1679";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_Identities = "nsu=" + Namespaces.Uri + ";i=1681";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_ApplicationsExclude = "nsu=" + Namespaces.Uri + ";i=1682";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_Applications = "nsu=" + Namespaces.Uri + ";i=1683";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_EndpointsExclude = "nsu=" + Namespaces.Uri + ";i=1684";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_Endpoints = "nsu=" + Namespaces.Uri + ";i=1685";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1688";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1690";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1692";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1694";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1696";
        /// <remarks />
        public const string WellKnownRole_CertificateAuthorityAdmin_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1698";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_Identities = "nsu=" + Namespaces.Uri + ";i=1700";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_ApplicationsExclude = "nsu=" + Namespaces.Uri + ";i=1701";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_Applications = "nsu=" + Namespaces.Uri + ";i=1702";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_EndpointsExclude = "nsu=" + Namespaces.Uri + ";i=1703";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_Endpoints = "nsu=" + Namespaces.Uri + ";i=1704";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1707";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1709";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1711";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1713";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1715";
        /// <remarks />
        public const string WellKnownRole_RegistrationAuthorityAdmin_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1717";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_Identities = "nsu=" + Namespaces.Uri + ";i=1719";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_ApplicationsExclude = "nsu=" + Namespaces.Uri + ";i=1720";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_Applications = "nsu=" + Namespaces.Uri + ";i=1721";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_EndpointsExclude = "nsu=" + Namespaces.Uri + ";i=1722";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_Endpoints = "nsu=" + Namespaces.Uri + ";i=1723";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1726";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1728";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1730";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1732";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1734";
        /// <remarks />
        public const string WellKnownRole_KeyCredentialAdmin_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1736";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_Identities = "nsu=" + Namespaces.Uri + ";i=1738";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_ApplicationsExclude = "nsu=" + Namespaces.Uri + ";i=1739";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_Applications = "nsu=" + Namespaces.Uri + ";i=1740";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_EndpointsExclude = "nsu=" + Namespaces.Uri + ";i=1741";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_Endpoints = "nsu=" + Namespaces.Uri + ";i=1742";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1745";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=1747";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1749";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1751";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1753";
        /// <remarks />
        public const string WellKnownRole_AuthorizationServiceAdmin_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1755";
        /// <remarks />
        public const string DirectoryType_FindApplications_InputArguments = "nsu=" + Namespaces.Uri + ";i=16";
        /// <remarks />
        public const string DirectoryType_FindApplications_OutputArguments = "nsu=" + Namespaces.Uri + ";i=17";
        /// <remarks />
        public const string DirectoryType_RegisterApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=19";
        /// <remarks />
        public const string DirectoryType_RegisterApplication_OutputArguments = "nsu=" + Namespaces.Uri + ";i=20";
        /// <remarks />
        public const string DirectoryType_UpdateApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=189";
        /// <remarks />
        public const string DirectoryType_UnregisterApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=22";
        /// <remarks />
        public const string DirectoryType_GetApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=211";
        /// <remarks />
        public const string DirectoryType_GetApplication_OutputArguments = "nsu=" + Namespaces.Uri + ";i=212";
        /// <remarks />
        public const string DirectoryType_QueryApplications_InputArguments = "nsu=" + Namespaces.Uri + ";i=869";
        /// <remarks />
        public const string DirectoryType_QueryApplications_OutputArguments = "nsu=" + Namespaces.Uri + ";i=870";
        /// <remarks />
        public const string DirectoryType_QueryServers_InputArguments = "nsu=" + Namespaces.Uri + ";i=24";
        /// <remarks />
        public const string DirectoryType_QueryServers_OutputArguments = "nsu=" + Namespaces.Uri + ";i=25";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Size = "nsu=" + Namespaces.Uri + ";i=514";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Writable = "nsu=" + Namespaces.Uri + ";i=515";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_UserWritable = "nsu=" + Namespaces.Uri + ";i=516";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_OpenCount = "nsu=" + Namespaces.Uri + ";i=517";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=520";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=521";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=523";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=525";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=526";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=528";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=530";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=531";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=533";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=534";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=536";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=537";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=539";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=540";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=542";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustList_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=544";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateTypes = "nsu=" + Namespaces.Uri + ";i=545";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EventId = "nsu=" + Namespaces.Uri + ";i=15009";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EventType = "nsu=" + Namespaces.Uri + ";i=15010";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SourceNode = "nsu=" + Namespaces.Uri + ";i=15011";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SourceName = "nsu=" + Namespaces.Uri + ";i=15012";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Time = "nsu=" + Namespaces.Uri + ";i=15013";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15014";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Message = "nsu=" + Namespaces.Uri + ";i=15016";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Severity = "nsu=" + Namespaces.Uri + ";i=15017";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15018";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15019";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConditionName = "nsu=" + Namespaces.Uri + ";i=15022";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_BranchId = "nsu=" + Namespaces.Uri + ";i=15023";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Retain = "nsu=" + Namespaces.Uri + ";i=15024";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EnabledState = "nsu=" + Namespaces.Uri + ";i=15025";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15026";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Quality = "nsu=" + Namespaces.Uri + ";i=15034";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15035";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15036";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15037";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Comment = "nsu=" + Namespaces.Uri + ";i=15038";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15039";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15040";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15044";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AckedState = "nsu=" + Namespaces.Uri + ";i=15045";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15046";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15055";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15064";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15066";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ActiveState = "nsu=" + Namespaces.Uri + ";i=15067";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15068";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_InputNode = "nsu=" + Namespaces.Uri + ";i=15076";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15078";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15087";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=15096";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=15097";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=15102";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=15109";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=15111";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=256";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=258";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=260";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=15114";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=15122";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=15135";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=262";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=264";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=266";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=268";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=270";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=272";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_NormalState = "nsu=" + Namespaces.Uri + ";i=15151";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ExpirationDate = "nsu=" + Namespaces.Uri + ";i=15152";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_CertificateType = "nsu=" + Namespaces.Uri + ";i=15154";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Certificate = "nsu=" + Namespaces.Uri + ";i=15155";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EventId = "nsu=" + Namespaces.Uri + ";i=15157";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EventType = "nsu=" + Namespaces.Uri + ";i=15158";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SourceNode = "nsu=" + Namespaces.Uri + ";i=15159";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SourceName = "nsu=" + Namespaces.Uri + ";i=15160";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Time = "nsu=" + Namespaces.Uri + ";i=15161";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15162";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Message = "nsu=" + Namespaces.Uri + ";i=15164";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Severity = "nsu=" + Namespaces.Uri + ";i=15165";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15166";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15167";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConditionName = "nsu=" + Namespaces.Uri + ";i=15170";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_BranchId = "nsu=" + Namespaces.Uri + ";i=15171";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Retain = "nsu=" + Namespaces.Uri + ";i=15172";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EnabledState = "nsu=" + Namespaces.Uri + ";i=15173";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15174";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Quality = "nsu=" + Namespaces.Uri + ";i=15182";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15183";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15184";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15185";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Comment = "nsu=" + Namespaces.Uri + ";i=15186";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15187";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15188";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15192";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AckedState = "nsu=" + Namespaces.Uri + ";i=15193";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15194";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15203";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15212";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15214";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ActiveState = "nsu=" + Namespaces.Uri + ";i=15215";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15216";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_InputNode = "nsu=" + Namespaces.Uri + ";i=15224";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15226";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15235";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=15244";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=15245";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=15250";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=15257";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=15259";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=274";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=276";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=278";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=15262";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=15270";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=15283";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=280";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=282";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=284";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=286";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=288";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=290";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_NormalState = "nsu=" + Namespaces.Uri + ";i=15299";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_TrustListId = "nsu=" + Namespaces.Uri + ";i=15300";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=15301";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_UpdateFrequency = "nsu=" + Namespaces.Uri + ";i=15302";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultApplicationGroup_GetRejectedList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=60";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Size = "nsu=" + Namespaces.Uri + ";i=548";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Writable = "nsu=" + Namespaces.Uri + ";i=549";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_UserWritable = "nsu=" + Namespaces.Uri + ";i=550";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_OpenCount = "nsu=" + Namespaces.Uri + ";i=551";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=554";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=555";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=557";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=559";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=560";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=562";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=564";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=565";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=567";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=568";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=570";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=571";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=573";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=574";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=576";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustList_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=578";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateTypes = "nsu=" + Namespaces.Uri + ";i=579";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EventId = "nsu=" + Namespaces.Uri + ";i=15305";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EventType = "nsu=" + Namespaces.Uri + ";i=15306";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SourceNode = "nsu=" + Namespaces.Uri + ";i=15307";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SourceName = "nsu=" + Namespaces.Uri + ";i=15308";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Time = "nsu=" + Namespaces.Uri + ";i=15309";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15310";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Message = "nsu=" + Namespaces.Uri + ";i=15312";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Severity = "nsu=" + Namespaces.Uri + ";i=15313";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15314";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15315";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConditionName = "nsu=" + Namespaces.Uri + ";i=15318";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_BranchId = "nsu=" + Namespaces.Uri + ";i=15319";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Retain = "nsu=" + Namespaces.Uri + ";i=15320";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EnabledState = "nsu=" + Namespaces.Uri + ";i=15321";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15322";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Quality = "nsu=" + Namespaces.Uri + ";i=15330";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15331";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15332";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15333";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Comment = "nsu=" + Namespaces.Uri + ";i=15334";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15335";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15336";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15340";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AckedState = "nsu=" + Namespaces.Uri + ";i=15341";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15342";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15351";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15360";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15362";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ActiveState = "nsu=" + Namespaces.Uri + ";i=15363";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15364";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_InputNode = "nsu=" + Namespaces.Uri + ";i=15372";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15374";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15383";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=15392";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=15393";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=15398";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=15405";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=15407";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=294";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=296";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=298";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=15410";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=15418";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=15431";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=300";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=302";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=304";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=306";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=308";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=310";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_NormalState = "nsu=" + Namespaces.Uri + ";i=15447";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ExpirationDate = "nsu=" + Namespaces.Uri + ";i=15448";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_CertificateType = "nsu=" + Namespaces.Uri + ";i=15450";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Certificate = "nsu=" + Namespaces.Uri + ";i=15451";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EventId = "nsu=" + Namespaces.Uri + ";i=15453";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EventType = "nsu=" + Namespaces.Uri + ";i=15454";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SourceNode = "nsu=" + Namespaces.Uri + ";i=15455";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SourceName = "nsu=" + Namespaces.Uri + ";i=15456";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Time = "nsu=" + Namespaces.Uri + ";i=15457";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15458";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Message = "nsu=" + Namespaces.Uri + ";i=15460";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Severity = "nsu=" + Namespaces.Uri + ";i=15461";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15462";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15463";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConditionName = "nsu=" + Namespaces.Uri + ";i=15466";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_BranchId = "nsu=" + Namespaces.Uri + ";i=15467";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Retain = "nsu=" + Namespaces.Uri + ";i=15468";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EnabledState = "nsu=" + Namespaces.Uri + ";i=15469";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15470";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Quality = "nsu=" + Namespaces.Uri + ";i=15478";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15479";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15480";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15481";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Comment = "nsu=" + Namespaces.Uri + ";i=15482";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15483";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15484";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15488";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AckedState = "nsu=" + Namespaces.Uri + ";i=15489";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15490";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15499";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15508";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15510";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ActiveState = "nsu=" + Namespaces.Uri + ";i=15511";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15512";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_InputNode = "nsu=" + Namespaces.Uri + ";i=15520";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15522";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15531";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=15540";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=15541";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=15546";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=15553";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=15555";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=312";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=314";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=316";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=15558";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=15566";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=15579";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=318";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=320";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=322";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=324";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=326";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=328";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_NormalState = "nsu=" + Namespaces.Uri + ";i=15595";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_TrustListId = "nsu=" + Namespaces.Uri + ";i=15596";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=15597";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_UpdateFrequency = "nsu=" + Namespaces.Uri + ";i=15598";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultHttpsGroup_GetRejectedList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=82";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Size = "nsu=" + Namespaces.Uri + ";i=582";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Writable = "nsu=" + Namespaces.Uri + ";i=583";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_UserWritable = "nsu=" + Namespaces.Uri + ";i=584";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenCount = "nsu=" + Namespaces.Uri + ";i=585";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=588";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=589";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=591";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=593";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=594";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=596";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=598";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=599";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=601";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=602";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=604";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=605";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=607";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=608";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=610";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustList_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=612";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateTypes = "nsu=" + Namespaces.Uri + ";i=613";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EventId = "nsu=" + Namespaces.Uri + ";i=15601";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EventType = "nsu=" + Namespaces.Uri + ";i=15602";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SourceNode = "nsu=" + Namespaces.Uri + ";i=15603";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SourceName = "nsu=" + Namespaces.Uri + ";i=15604";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Time = "nsu=" + Namespaces.Uri + ";i=15605";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15606";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Message = "nsu=" + Namespaces.Uri + ";i=15608";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Severity = "nsu=" + Namespaces.Uri + ";i=15609";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15610";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15611";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConditionName = "nsu=" + Namespaces.Uri + ";i=15614";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_BranchId = "nsu=" + Namespaces.Uri + ";i=15615";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Retain = "nsu=" + Namespaces.Uri + ";i=15616";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EnabledState = "nsu=" + Namespaces.Uri + ";i=15617";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15618";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Quality = "nsu=" + Namespaces.Uri + ";i=15626";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15627";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15628";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15629";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Comment = "nsu=" + Namespaces.Uri + ";i=15630";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15631";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15632";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15636";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AckedState = "nsu=" + Namespaces.Uri + ";i=15637";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15638";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15647";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15656";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15658";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ActiveState = "nsu=" + Namespaces.Uri + ";i=15659";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15660";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_InputNode = "nsu=" + Namespaces.Uri + ";i=15668";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15670";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15679";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=15688";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=15689";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=15694";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=15701";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=15703";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=332";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=334";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=336";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=15706";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=15714";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=15727";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=338";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=340";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=342";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=344";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=346";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=348";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_NormalState = "nsu=" + Namespaces.Uri + ";i=15743";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ExpirationDate = "nsu=" + Namespaces.Uri + ";i=15744";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_CertificateType = "nsu=" + Namespaces.Uri + ";i=15746";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Certificate = "nsu=" + Namespaces.Uri + ";i=15747";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EventId = "nsu=" + Namespaces.Uri + ";i=15749";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EventType = "nsu=" + Namespaces.Uri + ";i=15750";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SourceNode = "nsu=" + Namespaces.Uri + ";i=15751";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SourceName = "nsu=" + Namespaces.Uri + ";i=15752";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Time = "nsu=" + Namespaces.Uri + ";i=15753";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15754";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Message = "nsu=" + Namespaces.Uri + ";i=15756";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Severity = "nsu=" + Namespaces.Uri + ";i=15757";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15758";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15759";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConditionName = "nsu=" + Namespaces.Uri + ";i=15762";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_BranchId = "nsu=" + Namespaces.Uri + ";i=15763";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Retain = "nsu=" + Namespaces.Uri + ";i=15764";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EnabledState = "nsu=" + Namespaces.Uri + ";i=15765";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15766";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Quality = "nsu=" + Namespaces.Uri + ";i=15774";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15775";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15776";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15777";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Comment = "nsu=" + Namespaces.Uri + ";i=15778";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15779";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15780";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15784";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AckedState = "nsu=" + Namespaces.Uri + ";i=15785";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15786";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15795";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15804";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15806";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ActiveState = "nsu=" + Namespaces.Uri + ";i=15807";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15808";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_InputNode = "nsu=" + Namespaces.Uri + ";i=15816";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15818";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15827";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=15836";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=15837";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=15842";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=15849";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=15851";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=350";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=352";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=354";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=15854";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=15862";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=15875";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=356";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=358";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=360";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=362";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=364";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=366";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_NormalState = "nsu=" + Namespaces.Uri + ";i=15891";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_TrustListId = "nsu=" + Namespaces.Uri + ";i=15892";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=15893";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_UpdateFrequency = "nsu=" + Namespaces.Uri + ";i=15894";
        /// <remarks />
        public const string CertificateDirectoryType_CertificateGroups_DefaultUserTokenGroup_GetRejectedList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=88";
        /// <remarks />
        public const string CertificateDirectoryType_StartSigningRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=80";
        /// <remarks />
        public const string CertificateDirectoryType_StartSigningRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=81";
        /// <remarks />
        public const string CertificateDirectoryType_StartNewKeyPairRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=77";
        /// <remarks />
        public const string CertificateDirectoryType_StartNewKeyPairRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=78";
        /// <remarks />
        public const string CertificateDirectoryType_FinishRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=86";
        /// <remarks />
        public const string CertificateDirectoryType_FinishRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=87";
        /// <remarks />
        public const string CertificateDirectoryType_RevokeCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=15004";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificateGroups_InputArguments = "nsu=" + Namespaces.Uri + ";i=370";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificateGroups_OutputArguments = "nsu=" + Namespaces.Uri + ";i=371";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificates_InputArguments = "nsu=" + Namespaces.Uri + ";i=90";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificates_OutputArguments = "nsu=" + Namespaces.Uri + ";i=108";
        /// <remarks />
        public const string CertificateDirectoryType_GetTrustList_InputArguments = "nsu=" + Namespaces.Uri + ";i=198";
        /// <remarks />
        public const string CertificateDirectoryType_GetTrustList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=199";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificateStatus_InputArguments = "nsu=" + Namespaces.Uri + ";i=223";
        /// <remarks />
        public const string CertificateDirectoryType_GetCertificateStatus_OutputArguments = "nsu=" + Namespaces.Uri + ";i=224";
        /// <remarks />
        public const string CertificateDirectoryType_CheckRevocationStatus_InputArguments = "nsu=" + Namespaces.Uri + ";i=160";
        /// <remarks />
        public const string CertificateDirectoryType_CheckRevocationStatus_OutputArguments = "nsu=" + Namespaces.Uri + ";i=161";
        /// <remarks />
        public const string CertificateRequestedAuditEventType_CertificateGroup = "nsu=" + Namespaces.Uri + ";i=717";
        /// <remarks />
        public const string CertificateRequestedAuditEventType_CertificateType = "nsu=" + Namespaces.Uri + ";i=718";
        /// <remarks />
        public const string CertificateDeliveredAuditEventType_CertificateGroup = "nsu=" + Namespaces.Uri + ";i=719";
        /// <remarks />
        public const string CertificateDeliveredAuditEventType_CertificateType = "nsu=" + Namespaces.Uri + ";i=720";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_ResourceUri = "nsu=" + Namespaces.Uri + ";i=83";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_ProfileUris = "nsu=" + Namespaces.Uri + ";i=162";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_StartRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=171";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_StartRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=195";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_FinishRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=202";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_FinishRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=203";
        /// <remarks />
        public const string KeyCredentialManagementFolderType_ServiceName_Placeholder_Revoke_InputArguments = "nsu=" + Namespaces.Uri + ";i=229";
        /// <remarks />
        public const string KeyCredentialServiceType_ResourceUri = "nsu=" + Namespaces.Uri + ";i=1021";
        /// <remarks />
        public const string KeyCredentialServiceType_ProfileUris = "nsu=" + Namespaces.Uri + ";i=1022";
        /// <remarks />
        public const string KeyCredentialServiceType_SecurityPolicyUris = "nsu=" + Namespaces.Uri + ";i=495";
        /// <remarks />
        public const string KeyCredentialServiceType_StartRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=1024";
        /// <remarks />
        public const string KeyCredentialServiceType_StartRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1025";
        /// <remarks />
        public const string KeyCredentialServiceType_FinishRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=1027";
        /// <remarks />
        public const string KeyCredentialServiceType_FinishRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1028";
        /// <remarks />
        public const string KeyCredentialServiceType_Revoke_InputArguments = "nsu=" + Namespaces.Uri + ";i=1030";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder_ServiceUri = "nsu=" + Namespaces.Uri + ";i=235";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder_ServiceCertificate = "nsu=" + Namespaces.Uri + ";i=236";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder_GetServiceDescription_OutputArguments = "nsu=" + Namespaces.Uri + ";i=239";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder_RequestAccessToken_InputArguments = "nsu=" + Namespaces.Uri + ";i=241";
        /// <remarks />
        public const string AuthorizationServicesFolderType_ServiceName_Placeholder_RequestAccessToken_OutputArguments = "nsu=" + Namespaces.Uri + ";i=242";
        /// <remarks />
        public const string AuthorizationServiceType_ServiceUri = "nsu=" + Namespaces.Uri + ";i=1003";
        /// <remarks />
        public const string AuthorizationServiceType_ServiceCertificate = "nsu=" + Namespaces.Uri + ";i=968";
        /// <remarks />
        public const string AuthorizationServiceType_UserTokenPolicies = "nsu=" + Namespaces.Uri + ";i=967";
        /// <remarks />
        public const string AuthorizationServiceType_GetServiceDescription_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1005";
        /// <remarks />
        public const string AuthorizationServiceType_RequestAccessToken_InputArguments = "nsu=" + Namespaces.Uri + ";i=970";
        /// <remarks />
        public const string AuthorizationServiceType_RequestAccessToken_OutputArguments = "nsu=" + Namespaces.Uri + ";i=971";
        /// <remarks />
        public const string Directory_FindApplications_InputArguments = "nsu=" + Namespaces.Uri + ";i=144";
        /// <remarks />
        public const string Directory_FindApplications_OutputArguments = "nsu=" + Namespaces.Uri + ";i=145";
        /// <remarks />
        public const string Directory_RegisterApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=147";
        /// <remarks />
        public const string Directory_RegisterApplication_OutputArguments = "nsu=" + Namespaces.Uri + ";i=148";
        /// <remarks />
        public const string Directory_UpdateApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=201";
        /// <remarks />
        public const string Directory_UnregisterApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=150";
        /// <remarks />
        public const string Directory_GetApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=217";
        /// <remarks />
        public const string Directory_GetApplication_OutputArguments = "nsu=" + Namespaces.Uri + ";i=218";
        /// <remarks />
        public const string Directory_QueryApplications_InputArguments = "nsu=" + Namespaces.Uri + ";i=993";
        /// <remarks />
        public const string Directory_QueryApplications_OutputArguments = "nsu=" + Namespaces.Uri + ";i=994";
        /// <remarks />
        public const string Directory_QueryServers_InputArguments = "nsu=" + Namespaces.Uri + ";i=152";
        /// <remarks />
        public const string Directory_QueryServers_OutputArguments = "nsu=" + Namespaces.Uri + ";i=153";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Size = "nsu=" + Namespaces.Uri + ";i=617";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Writable = "nsu=" + Namespaces.Uri + ";i=618";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_UserWritable = "nsu=" + Namespaces.Uri + ";i=619";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_OpenCount = "nsu=" + Namespaces.Uri + ";i=620";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=623";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=624";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=626";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=628";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=629";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=631";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=633";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=634";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=636";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=637";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=639";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=640";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=642";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=643";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=645";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustList_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=647";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateTypes = "nsu=" + Namespaces.Uri + ";i=648";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EventId = "nsu=" + Namespaces.Uri + ";i=15914";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EventType = "nsu=" + Namespaces.Uri + ";i=15915";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SourceNode = "nsu=" + Namespaces.Uri + ";i=15916";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SourceName = "nsu=" + Namespaces.Uri + ";i=15917";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Time = "nsu=" + Namespaces.Uri + ";i=15918";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=15919";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Message = "nsu=" + Namespaces.Uri + ";i=15921";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Severity = "nsu=" + Namespaces.Uri + ";i=15922";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=15923";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=15924";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConditionName = "nsu=" + Namespaces.Uri + ";i=15927";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_BranchId = "nsu=" + Namespaces.Uri + ";i=15928";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Retain = "nsu=" + Namespaces.Uri + ";i=15929";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EnabledState = "nsu=" + Namespaces.Uri + ";i=15930";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=15931";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Quality = "nsu=" + Namespaces.Uri + ";i=15939";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15940";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_LastSeverity = "nsu=" + Namespaces.Uri + ";i=15941";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15942";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Comment = "nsu=" + Namespaces.Uri + ";i=15943";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=15944";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ClientUserId = "nsu=" + Namespaces.Uri + ";i=15945";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=15949";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AckedState = "nsu=" + Namespaces.Uri + ";i=15950";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=15951";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=15960";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=15969";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=15971";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ActiveState = "nsu=" + Namespaces.Uri + ";i=15972";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=15973";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_InputNode = "nsu=" + Namespaces.Uri + ";i=15981";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=15983";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=15992";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=16001";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=16002";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=16007";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=16014";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=16016";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=373";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=375";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=377";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=16019";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=16027";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=16040";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=379";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=381";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=383";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=385";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=387";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=389";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_NormalState = "nsu=" + Namespaces.Uri + ";i=16056";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_ExpirationDate = "nsu=" + Namespaces.Uri + ";i=16057";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_CertificateType = "nsu=" + Namespaces.Uri + ";i=16059";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_CertificateExpired_Certificate = "nsu=" + Namespaces.Uri + ";i=16060";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EventId = "nsu=" + Namespaces.Uri + ";i=16062";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EventType = "nsu=" + Namespaces.Uri + ";i=16063";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SourceNode = "nsu=" + Namespaces.Uri + ";i=16064";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SourceName = "nsu=" + Namespaces.Uri + ";i=16065";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Time = "nsu=" + Namespaces.Uri + ";i=16066";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=16067";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Message = "nsu=" + Namespaces.Uri + ";i=16069";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Severity = "nsu=" + Namespaces.Uri + ";i=16070";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=16071";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=16072";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConditionName = "nsu=" + Namespaces.Uri + ";i=16075";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_BranchId = "nsu=" + Namespaces.Uri + ";i=16076";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Retain = "nsu=" + Namespaces.Uri + ";i=16077";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EnabledState = "nsu=" + Namespaces.Uri + ";i=16078";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=16079";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Quality = "nsu=" + Namespaces.Uri + ";i=16087";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16088";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LastSeverity = "nsu=" + Namespaces.Uri + ";i=16089";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16090";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Comment = "nsu=" + Namespaces.Uri + ";i=16091";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16092";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ClientUserId = "nsu=" + Namespaces.Uri + ";i=16093";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=16097";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AckedState = "nsu=" + Namespaces.Uri + ";i=16098";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=16099";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=16108";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=16117";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=16119";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ActiveState = "nsu=" + Namespaces.Uri + ";i=16120";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=16121";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_InputNode = "nsu=" + Namespaces.Uri + ";i=16129";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=16131";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=16140";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=16149";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=16150";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=16155";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=16162";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=16164";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=391";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=393";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=395";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=16167";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=16175";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=16188";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=397";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=399";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=401";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=403";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=405";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=407";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_NormalState = "nsu=" + Namespaces.Uri + ";i=16204";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_TrustListId = "nsu=" + Namespaces.Uri + ";i=16205";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=16206";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_TrustListOutOfDate_UpdateFrequency = "nsu=" + Namespaces.Uri + ";i=16207";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultApplicationGroup_GetRejectedList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=167";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Size = "nsu=" + Namespaces.Uri + ";i=651";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Writable = "nsu=" + Namespaces.Uri + ";i=652";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_UserWritable = "nsu=" + Namespaces.Uri + ";i=653";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_OpenCount = "nsu=" + Namespaces.Uri + ";i=654";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=657";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=658";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=660";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=662";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=663";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=665";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=667";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=668";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=670";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=671";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=673";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=674";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=676";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=677";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=679";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustList_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=681";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateTypes = "nsu=" + Namespaces.Uri + ";i=682";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EventId = "nsu=" + Namespaces.Uri + ";i=16210";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EventType = "nsu=" + Namespaces.Uri + ";i=16211";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SourceNode = "nsu=" + Namespaces.Uri + ";i=16212";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SourceName = "nsu=" + Namespaces.Uri + ";i=16213";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Time = "nsu=" + Namespaces.Uri + ";i=16214";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=16215";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Message = "nsu=" + Namespaces.Uri + ";i=16217";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Severity = "nsu=" + Namespaces.Uri + ";i=16218";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=16219";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=16220";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConditionName = "nsu=" + Namespaces.Uri + ";i=16223";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_BranchId = "nsu=" + Namespaces.Uri + ";i=16224";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Retain = "nsu=" + Namespaces.Uri + ";i=16225";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EnabledState = "nsu=" + Namespaces.Uri + ";i=16226";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=16227";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Quality = "nsu=" + Namespaces.Uri + ";i=16235";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16236";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_LastSeverity = "nsu=" + Namespaces.Uri + ";i=16237";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16238";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Comment = "nsu=" + Namespaces.Uri + ";i=16239";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16240";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ClientUserId = "nsu=" + Namespaces.Uri + ";i=16241";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=16245";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AckedState = "nsu=" + Namespaces.Uri + ";i=16246";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=16247";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=16256";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=16265";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=16267";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ActiveState = "nsu=" + Namespaces.Uri + ";i=16268";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=16269";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_InputNode = "nsu=" + Namespaces.Uri + ";i=16277";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=16279";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=16288";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=16297";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=16298";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=16303";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=16310";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=16312";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=411";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=413";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=415";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=16315";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=16323";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=16336";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=417";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=419";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=421";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=423";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=425";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=427";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_NormalState = "nsu=" + Namespaces.Uri + ";i=16352";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_ExpirationDate = "nsu=" + Namespaces.Uri + ";i=16353";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_CertificateType = "nsu=" + Namespaces.Uri + ";i=16355";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_CertificateExpired_Certificate = "nsu=" + Namespaces.Uri + ";i=16356";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EventId = "nsu=" + Namespaces.Uri + ";i=16358";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EventType = "nsu=" + Namespaces.Uri + ";i=16359";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SourceNode = "nsu=" + Namespaces.Uri + ";i=16360";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SourceName = "nsu=" + Namespaces.Uri + ";i=16361";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Time = "nsu=" + Namespaces.Uri + ";i=16362";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=16363";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Message = "nsu=" + Namespaces.Uri + ";i=16365";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Severity = "nsu=" + Namespaces.Uri + ";i=16366";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=16367";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=16368";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConditionName = "nsu=" + Namespaces.Uri + ";i=16371";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_BranchId = "nsu=" + Namespaces.Uri + ";i=16372";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Retain = "nsu=" + Namespaces.Uri + ";i=16373";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EnabledState = "nsu=" + Namespaces.Uri + ";i=16374";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=16375";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Quality = "nsu=" + Namespaces.Uri + ";i=16383";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16384";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LastSeverity = "nsu=" + Namespaces.Uri + ";i=16385";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16386";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Comment = "nsu=" + Namespaces.Uri + ";i=16387";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16388";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ClientUserId = "nsu=" + Namespaces.Uri + ";i=16389";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=16393";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AckedState = "nsu=" + Namespaces.Uri + ";i=16394";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=16395";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=16404";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=16413";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=16415";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ActiveState = "nsu=" + Namespaces.Uri + ";i=16416";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=16417";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_InputNode = "nsu=" + Namespaces.Uri + ";i=16425";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=16427";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=16436";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=16445";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=16446";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=16451";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=16458";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=16460";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=429";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=431";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=433";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=16463";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=16471";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=16484";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=435";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=437";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=439";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=441";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=443";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=445";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_NormalState = "nsu=" + Namespaces.Uri + ";i=16500";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_TrustListId = "nsu=" + Namespaces.Uri + ";i=16501";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=16502";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_TrustListOutOfDate_UpdateFrequency = "nsu=" + Namespaces.Uri + ";i=16503";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultHttpsGroup_GetRejectedList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=170";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Size = "nsu=" + Namespaces.Uri + ";i=685";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Writable = "nsu=" + Namespaces.Uri + ";i=686";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_UserWritable = "nsu=" + Namespaces.Uri + ";i=687";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenCount = "nsu=" + Namespaces.Uri + ";i=688";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=691";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=692";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=694";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=696";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=697";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=699";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=701";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=702";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=704";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=705";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=707";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=708";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=710";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=711";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=713";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustList_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=715";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateTypes = "nsu=" + Namespaces.Uri + ";i=716";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EventId = "nsu=" + Namespaces.Uri + ";i=16506";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EventType = "nsu=" + Namespaces.Uri + ";i=16507";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SourceNode = "nsu=" + Namespaces.Uri + ";i=16508";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SourceName = "nsu=" + Namespaces.Uri + ";i=16509";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Time = "nsu=" + Namespaces.Uri + ";i=16510";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=16511";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Message = "nsu=" + Namespaces.Uri + ";i=16513";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Severity = "nsu=" + Namespaces.Uri + ";i=16514";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=16515";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=16516";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConditionName = "nsu=" + Namespaces.Uri + ";i=16519";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_BranchId = "nsu=" + Namespaces.Uri + ";i=16520";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Retain = "nsu=" + Namespaces.Uri + ";i=16521";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EnabledState = "nsu=" + Namespaces.Uri + ";i=16522";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=16523";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Quality = "nsu=" + Namespaces.Uri + ";i=16531";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16532";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_LastSeverity = "nsu=" + Namespaces.Uri + ";i=16533";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16534";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Comment = "nsu=" + Namespaces.Uri + ";i=16535";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16536";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ClientUserId = "nsu=" + Namespaces.Uri + ";i=16537";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=16541";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AckedState = "nsu=" + Namespaces.Uri + ";i=16542";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=16543";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=16552";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=16561";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=16563";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ActiveState = "nsu=" + Namespaces.Uri + ";i=16564";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=16565";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_InputNode = "nsu=" + Namespaces.Uri + ";i=16573";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=16575";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=16584";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=16593";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=16594";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=16599";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=16606";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=16608";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=449";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=451";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=453";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=16611";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=16619";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=16632";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=455";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=457";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=459";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=461";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=463";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=465";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_NormalState = "nsu=" + Namespaces.Uri + ";i=16648";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_ExpirationDate = "nsu=" + Namespaces.Uri + ";i=16649";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_CertificateType = "nsu=" + Namespaces.Uri + ";i=16651";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_CertificateExpired_Certificate = "nsu=" + Namespaces.Uri + ";i=16652";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EventId = "nsu=" + Namespaces.Uri + ";i=16654";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EventType = "nsu=" + Namespaces.Uri + ";i=16655";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SourceNode = "nsu=" + Namespaces.Uri + ";i=16656";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SourceName = "nsu=" + Namespaces.Uri + ";i=16657";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Time = "nsu=" + Namespaces.Uri + ";i=16658";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ReceiveTime = "nsu=" + Namespaces.Uri + ";i=16659";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Message = "nsu=" + Namespaces.Uri + ";i=16661";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Severity = "nsu=" + Namespaces.Uri + ";i=16662";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConditionClassId = "nsu=" + Namespaces.Uri + ";i=16663";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConditionClassName = "nsu=" + Namespaces.Uri + ";i=16664";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConditionName = "nsu=" + Namespaces.Uri + ";i=16667";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_BranchId = "nsu=" + Namespaces.Uri + ";i=16668";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Retain = "nsu=" + Namespaces.Uri + ";i=16669";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EnabledState = "nsu=" + Namespaces.Uri + ";i=16670";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_EnabledState_Id = "nsu=" + Namespaces.Uri + ";i=16671";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Quality = "nsu=" + Namespaces.Uri + ";i=16679";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Quality_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16680";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LastSeverity = "nsu=" + Namespaces.Uri + ";i=16681";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LastSeverity_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16682";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Comment = "nsu=" + Namespaces.Uri + ";i=16683";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Comment_SourceTimestamp = "nsu=" + Namespaces.Uri + ";i=16684";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ClientUserId = "nsu=" + Namespaces.Uri + ";i=16685";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AddComment_InputArguments = "nsu=" + Namespaces.Uri + ";i=16689";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AckedState = "nsu=" + Namespaces.Uri + ";i=16690";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_AckedState_Id = "nsu=" + Namespaces.Uri + ";i=16691";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ConfirmedState_Id = "nsu=" + Namespaces.Uri + ";i=16700";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Acknowledge_InputArguments = "nsu=" + Namespaces.Uri + ";i=16709";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Confirm_InputArguments = "nsu=" + Namespaces.Uri + ";i=16711";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ActiveState = "nsu=" + Namespaces.Uri + ";i=16712";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ActiveState_Id = "nsu=" + Namespaces.Uri + ";i=16713";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_InputNode = "nsu=" + Namespaces.Uri + ";i=16721";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SuppressedState_Id = "nsu=" + Namespaces.Uri + ";i=16723";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_OutOfServiceState_Id = "nsu=" + Namespaces.Uri + ";i=16732";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_CurrentState = "nsu=" + Namespaces.Uri + ";i=16741";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=16742";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=16747";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_UnshelveTime = "nsu=" + Namespaces.Uri + ";i=16754";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_TimedShelve_InputArguments = "nsu=" + Namespaces.Uri + ";i=16756";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_TimedShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=467";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_Unshelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=469";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_ShelvingState_OneShotShelve2_InputArguments = "nsu=" + Namespaces.Uri + ";i=471";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SuppressedOrShelved = "nsu=" + Namespaces.Uri + ";i=16759";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_SilenceState_Id = "nsu=" + Namespaces.Uri + ";i=16767";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LatchedState_Id = "nsu=" + Namespaces.Uri + ";i=16780";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Suppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=473";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Unsuppress2_InputArguments = "nsu=" + Namespaces.Uri + ";i=475";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_RemoveFromService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=477";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_PlaceInService2_InputArguments = "nsu=" + Namespaces.Uri + ";i=479";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_Reset2_InputArguments = "nsu=" + Namespaces.Uri + ";i=481";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_GetGroupMemberships_OutputArguments = "nsu=" + Namespaces.Uri + ";i=483";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_NormalState = "nsu=" + Namespaces.Uri + ";i=16796";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_TrustListId = "nsu=" + Namespaces.Uri + ";i=16797";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=16798";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_TrustListOutOfDate_UpdateFrequency = "nsu=" + Namespaces.Uri + ";i=16799";
        /// <remarks />
        public const string Directory_CertificateGroups_DefaultUserTokenGroup_GetRejectedList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=173";
        /// <remarks />
        public const string Directory_StartSigningRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=158";
        /// <remarks />
        public const string Directory_StartSigningRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=159";
        /// <remarks />
        public const string Directory_StartNewKeyPairRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=155";
        /// <remarks />
        public const string Directory_StartNewKeyPairRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=156";
        /// <remarks />
        public const string Directory_FinishRequest_InputArguments = "nsu=" + Namespaces.Uri + ";i=164";
        /// <remarks />
        public const string Directory_FinishRequest_OutputArguments = "nsu=" + Namespaces.Uri + ";i=165";
        /// <remarks />
        public const string Directory_RevokeCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=15006";
        /// <remarks />
        public const string Directory_GetCertificateGroups_InputArguments = "nsu=" + Namespaces.Uri + ";i=509";
        /// <remarks />
        public const string Directory_GetCertificateGroups_OutputArguments = "nsu=" + Namespaces.Uri + ";i=510";
        /// <remarks />
        public const string Directory_GetCertificates_InputArguments = "nsu=" + Namespaces.Uri + ";i=175";
        /// <remarks />
        public const string Directory_GetCertificates_OutputArguments = "nsu=" + Namespaces.Uri + ";i=176";
        /// <remarks />
        public const string Directory_GetTrustList_InputArguments = "nsu=" + Namespaces.Uri + ";i=205";
        /// <remarks />
        public const string Directory_GetTrustList_OutputArguments = "nsu=" + Namespaces.Uri + ";i=206";
        /// <remarks />
        public const string Directory_GetCertificateStatus_InputArguments = "nsu=" + Namespaces.Uri + ";i=226";
        /// <remarks />
        public const string Directory_GetCertificateStatus_OutputArguments = "nsu=" + Namespaces.Uri + ";i=227";
        /// <remarks />
        public const string Directory_CheckRevocationStatus_InputArguments = "nsu=" + Namespaces.Uri + ";i=178";
        /// <remarks />
        public const string Directory_CheckRevocationStatus_OutputArguments = "nsu=" + Namespaces.Uri + ";i=179";
        /// <remarks />
        public const string OpcUaGds_BinarySchema = "nsu=" + Namespaces.Uri + ";i=135";
        /// <remarks />
        public const string OpcUaGds_BinarySchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=137";
        /// <remarks />
        public const string OpcUaGds_BinarySchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=8002";
        /// <remarks />
        public const string OpcUaGds_BinarySchema_ApplicationRecordDataType = "nsu=" + Namespaces.Uri + ";i=138";
        /// <remarks />
        public const string OpcUaGds_XmlSchema = "nsu=" + Namespaces.Uri + ";i=128";
        /// <remarks />
        public const string OpcUaGds_XmlSchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=130";
        /// <remarks />
        public const string OpcUaGds_XmlSchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=8004";
        /// <remarks />
        public const string OpcUaGds_XmlSchema_ApplicationRecordDataType = "nsu=" + Namespaces.Uri + ";i=131";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(VariableIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }
    
}
