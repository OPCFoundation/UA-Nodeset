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
namespace Opc.Ua.WebApi
{
    /// <summary>
    /// The well known identifiers for StatusCodes.
    /// </summary>
    public static class StatusCodes
    {
        /// <remarks />
        public const long Good = 0x00000000;
        /// <remarks />
        public const long Uncertain = 0x40000000;
        /// <remarks />
        public const long Bad = 0x80000000;
        /// <remarks />
        public const long BadUnexpectedError = 0x80010000;
        /// <remarks />
        public const long BadInternalError = 0x80020000;
        /// <remarks />
        public const long BadOutOfMemory = 0x80030000;
        /// <remarks />
        public const long BadResourceUnavailable = 0x80040000;
        /// <remarks />
        public const long BadCommunicationError = 0x80050000;
        /// <remarks />
        public const long BadEncodingError = 0x80060000;
        /// <remarks />
        public const long BadDecodingError = 0x80070000;
        /// <remarks />
        public const long BadEncodingLimitsExceeded = 0x80080000;
        /// <remarks />
        public const long BadRequestTooLarge = 0x80B80000;
        /// <remarks />
        public const long BadResponseTooLarge = 0x80B90000;
        /// <remarks />
        public const long BadUnknownResponse = 0x80090000;
        /// <remarks />
        public const long BadTimeout = 0x800A0000;
        /// <remarks />
        public const long BadServiceUnsupported = 0x800B0000;
        /// <remarks />
        public const long BadShutdown = 0x800C0000;
        /// <remarks />
        public const long BadServerNotConnected = 0x800D0000;
        /// <remarks />
        public const long BadServerHalted = 0x800E0000;
        /// <remarks />
        public const long BadNothingToDo = 0x800F0000;
        /// <remarks />
        public const long BadTooManyOperations = 0x80100000;
        /// <remarks />
        public const long BadTooManyMonitoredItems = 0x80DB0000;
        /// <remarks />
        public const long BadDataTypeIdUnknown = 0x80110000;
        /// <remarks />
        public const long BadCertificateInvalid = 0x80120000;
        /// <remarks />
        public const long BadSecurityChecksFailed = 0x80130000;
        /// <remarks />
        public const long BadCertificatePolicyCheckFailed = 0x81140000;
        /// <remarks />
        public const long BadCertificateTimeInvalid = 0x80140000;
        /// <remarks />
        public const long BadCertificateIssuerTimeInvalid = 0x80150000;
        /// <remarks />
        public const long BadCertificateHostNameInvalid = 0x80160000;
        /// <remarks />
        public const long BadCertificateUriInvalid = 0x80170000;
        /// <remarks />
        public const long BadCertificateUseNotAllowed = 0x80180000;
        /// <remarks />
        public const long BadCertificateIssuerUseNotAllowed = 0x80190000;
        /// <remarks />
        public const long BadCertificateUntrusted = 0x801A0000;
        /// <remarks />
        public const long BadCertificateRevocationUnknown = 0x801B0000;
        /// <remarks />
        public const long BadCertificateIssuerRevocationUnknown = 0x801C0000;
        /// <remarks />
        public const long BadCertificateRevoked = 0x801D0000;
        /// <remarks />
        public const long BadCertificateIssuerRevoked = 0x801E0000;
        /// <remarks />
        public const long BadCertificateChainIncomplete = 0x810D0000;
        /// <remarks />
        public const long BadUserAccessDenied = 0x801F0000;
        /// <remarks />
        public const long BadIdentityTokenInvalid = 0x80200000;
        /// <remarks />
        public const long BadIdentityTokenRejected = 0x80210000;
        /// <remarks />
        public const long BadSecureChannelIdInvalid = 0x80220000;
        /// <remarks />
        public const long BadInvalidTimestamp = 0x80230000;
        /// <remarks />
        public const long BadNonceInvalid = 0x80240000;
        /// <remarks />
        public const long BadSessionIdInvalid = 0x80250000;
        /// <remarks />
        public const long BadSessionClosed = 0x80260000;
        /// <remarks />
        public const long BadSessionNotActivated = 0x80270000;
        /// <remarks />
        public const long BadSubscriptionIdInvalid = 0x80280000;
        /// <remarks />
        public const long BadRequestHeaderInvalid = 0x802A0000;
        /// <remarks />
        public const long BadTimestampsToReturnInvalid = 0x802B0000;
        /// <remarks />
        public const long BadRequestCancelledByClient = 0x802C0000;
        /// <remarks />
        public const long BadTooManyArguments = 0x80E50000;
        /// <remarks />
        public const long BadLicenseExpired = 0x810E0000;
        /// <remarks />
        public const long BadLicenseLimitsExceeded = 0x810F0000;
        /// <remarks />
        public const long BadLicenseNotAvailable = 0x81100000;
        /// <remarks />
        public const long BadServerTooBusy = 0x80EE0000;
        /// <remarks />
        public const long GoodPasswordChangeRequired = 0x00EF0000;
        /// <remarks />
        public const long GoodSubscriptionTransferred = 0x002D0000;
        /// <remarks />
        public const long GoodCompletesAsynchronously = 0x002E0000;
        /// <remarks />
        public const long GoodOverload = 0x002F0000;
        /// <remarks />
        public const long GoodClamped = 0x00300000;
        /// <remarks />
        public const long BadNoCommunication = 0x80310000;
        /// <remarks />
        public const long BadWaitingForInitialData = 0x80320000;
        /// <remarks />
        public const long BadNodeIdInvalid = 0x80330000;
        /// <remarks />
        public const long BadNodeIdUnknown = 0x80340000;
        /// <remarks />
        public const long BadAttributeIdInvalid = 0x80350000;
        /// <remarks />
        public const long BadIndexRangeInvalid = 0x80360000;
        /// <remarks />
        public const long BadIndexRangeNoData = 0x80370000;
        /// <remarks />
        public const long BadIndexRangeDataMismatch = 0x80EA0000;
        /// <remarks />
        public const long BadDataEncodingInvalid = 0x80380000;
        /// <remarks />
        public const long BadDataEncodingUnsupported = 0x80390000;
        /// <remarks />
        public const long BadNotReadable = 0x803A0000;
        /// <remarks />
        public const long BadNotWritable = 0x803B0000;
        /// <remarks />
        public const long BadOutOfRange = 0x803C0000;
        /// <remarks />
        public const long BadNotSupported = 0x803D0000;
        /// <remarks />
        public const long BadNotFound = 0x803E0000;
        /// <remarks />
        public const long BadObjectDeleted = 0x803F0000;
        /// <remarks />
        public const long BadNotImplemented = 0x80400000;
        /// <remarks />
        public const long BadMonitoringModeInvalid = 0x80410000;
        /// <remarks />
        public const long BadMonitoredItemIdInvalid = 0x80420000;
        /// <remarks />
        public const long BadMonitoredItemFilterInvalid = 0x80430000;
        /// <remarks />
        public const long BadMonitoredItemFilterUnsupported = 0x80440000;
        /// <remarks />
        public const long BadFilterNotAllowed = 0x80450000;
        /// <remarks />
        public const long BadStructureMissing = 0x80460000;
        /// <remarks />
        public const long BadEventFilterInvalid = 0x80470000;
        /// <remarks />
        public const long BadContentFilterInvalid = 0x80480000;
        /// <remarks />
        public const long BadFilterOperatorInvalid = 0x80C10000;
        /// <remarks />
        public const long BadFilterOperatorUnsupported = 0x80C20000;
        /// <remarks />
        public const long BadFilterOperandCountMismatch = 0x80C30000;
        /// <remarks />
        public const long BadFilterOperandInvalid = 0x80490000;
        /// <remarks />
        public const long BadFilterElementInvalid = 0x80C40000;
        /// <remarks />
        public const long BadFilterLiteralInvalid = 0x80C50000;
        /// <remarks />
        public const long BadContinuationPointInvalid = 0x804A0000;
        /// <remarks />
        public const long BadNoContinuationPoints = 0x804B0000;
        /// <remarks />
        public const long BadReferenceTypeIdInvalid = 0x804C0000;
        /// <remarks />
        public const long BadBrowseDirectionInvalid = 0x804D0000;
        /// <remarks />
        public const long BadNodeNotInView = 0x804E0000;
        /// <remarks />
        public const long BadNumericOverflow = 0x81120000;
        /// <remarks />
        public const long BadLocaleNotSupported = 0x80ED0000;
        /// <remarks />
        public const long BadNoValue = 0x80F00000;
        /// <remarks />
        public const long BadServerUriInvalid = 0x804F0000;
        /// <remarks />
        public const long BadServerNameMissing = 0x80500000;
        /// <remarks />
        public const long BadDiscoveryUrlMissing = 0x80510000;
        /// <remarks />
        public const long BadSemaphoreFileMissing = 0x80520000;
        /// <remarks />
        public const long BadRequestTypeInvalid = 0x80530000;
        /// <remarks />
        public const long BadSecurityModeRejected = 0x80540000;
        /// <remarks />
        public const long BadSecurityPolicyRejected = 0x80550000;
        /// <remarks />
        public const long BadTooManySessions = 0x80560000;
        /// <remarks />
        public const long BadUserSignatureInvalid = 0x80570000;
        /// <remarks />
        public const long BadApplicationSignatureInvalid = 0x80580000;
        /// <remarks />
        public const long BadNoValidCertificates = 0x80590000;
        /// <remarks />
        public const long BadIdentityChangeNotSupported = 0x80C60000;
        /// <remarks />
        public const long BadRequestCancelledByRequest = 0x805A0000;
        /// <remarks />
        public const long BadParentNodeIdInvalid = 0x805B0000;
        /// <remarks />
        public const long BadReferenceNotAllowed = 0x805C0000;
        /// <remarks />
        public const long BadNodeIdRejected = 0x805D0000;
        /// <remarks />
        public const long BadNodeIdExists = 0x805E0000;
        /// <remarks />
        public const long BadNodeClassInvalid = 0x805F0000;
        /// <remarks />
        public const long BadBrowseNameInvalid = 0x80600000;
        /// <remarks />
        public const long BadBrowseNameDuplicated = 0x80610000;
        /// <remarks />
        public const long BadNodeAttributesInvalid = 0x80620000;
        /// <remarks />
        public const long BadTypeDefinitionInvalid = 0x80630000;
        /// <remarks />
        public const long BadSourceNodeIdInvalid = 0x80640000;
        /// <remarks />
        public const long BadTargetNodeIdInvalid = 0x80650000;
        /// <remarks />
        public const long BadDuplicateReferenceNotAllowed = 0x80660000;
        /// <remarks />
        public const long BadInvalidSelfReference = 0x80670000;
        /// <remarks />
        public const long BadReferenceLocalOnly = 0x80680000;
        /// <remarks />
        public const long BadNoDeleteRights = 0x80690000;
        /// <remarks />
        public const long UncertainReferenceNotDeleted = 0x40BC0000;
        /// <remarks />
        public const long BadServerIndexInvalid = 0x806A0000;
        /// <remarks />
        public const long BadViewIdUnknown = 0x806B0000;
        /// <remarks />
        public const long BadViewTimestampInvalid = 0x80C90000;
        /// <remarks />
        public const long BadViewParameterMismatch = 0x80CA0000;
        /// <remarks />
        public const long BadViewVersionInvalid = 0x80CB0000;
        /// <remarks />
        public const long UncertainNotAllNodesAvailable = 0x40C00000;
        /// <remarks />
        public const long GoodResultsMayBeIncomplete = 0x00BA0000;
        /// <remarks />
        public const long BadNotTypeDefinition = 0x80C80000;
        /// <remarks />
        public const long UncertainReferenceOutOfServer = 0x406C0000;
        /// <remarks />
        public const long BadTooManyMatches = 0x806D0000;
        /// <remarks />
        public const long BadQueryTooComplex = 0x806E0000;
        /// <remarks />
        public const long BadNoMatch = 0x806F0000;
        /// <remarks />
        public const long BadMaxAgeInvalid = 0x80700000;
        /// <remarks />
        public const long BadSecurityModeInsufficient = 0x80E60000;
        /// <remarks />
        public const long BadHistoryOperationInvalid = 0x80710000;
        /// <remarks />
        public const long BadHistoryOperationUnsupported = 0x80720000;
        /// <remarks />
        public const long BadInvalidTimestampArgument = 0x80BD0000;
        /// <remarks />
        public const long BadWriteNotSupported = 0x80730000;
        /// <remarks />
        public const long BadTypeMismatch = 0x80740000;
        /// <remarks />
        public const long BadMethodInvalid = 0x80750000;
        /// <remarks />
        public const long BadArgumentsMissing = 0x80760000;
        /// <remarks />
        public const long BadNotExecutable = 0x81110000;
        /// <remarks />
        public const long BadTooManySubscriptions = 0x80770000;
        /// <remarks />
        public const long BadTooManyPublishRequests = 0x80780000;
        /// <remarks />
        public const long BadNoSubscription = 0x80790000;
        /// <remarks />
        public const long BadSequenceNumberUnknown = 0x807A0000;
        /// <remarks />
        public const long GoodRetransmissionQueueNotSupported = 0x00DF0000;
        /// <remarks />
        public const long BadMessageNotAvailable = 0x807B0000;
        /// <remarks />
        public const long BadInsufficientClientProfile = 0x807C0000;
        /// <remarks />
        public const long BadStateNotActive = 0x80BF0000;
        /// <remarks />
        public const long BadAlreadyExists = 0x81150000;
        /// <remarks />
        public const long BadTcpServerTooBusy = 0x807D0000;
        /// <remarks />
        public const long BadTcpMessageTypeInvalid = 0x807E0000;
        /// <remarks />
        public const long BadTcpSecureChannelUnknown = 0x807F0000;
        /// <remarks />
        public const long BadTcpMessageTooLarge = 0x80800000;
        /// <remarks />
        public const long BadTcpNotEnoughResources = 0x80810000;
        /// <remarks />
        public const long BadTcpInternalError = 0x80820000;
        /// <remarks />
        public const long BadTcpEndpointUrlInvalid = 0x80830000;
        /// <remarks />
        public const long BadRequestInterrupted = 0x80840000;
        /// <remarks />
        public const long BadRequestTimeout = 0x80850000;
        /// <remarks />
        public const long BadSecureChannelClosed = 0x80860000;
        /// <remarks />
        public const long BadSecureChannelTokenUnknown = 0x80870000;
        /// <remarks />
        public const long BadSequenceNumberInvalid = 0x80880000;
        /// <remarks />
        public const long BadProtocolVersionUnsupported = 0x80BE0000;
        /// <remarks />
        public const long BadConfigurationError = 0x80890000;
        /// <remarks />
        public const long BadNotConnected = 0x808A0000;
        /// <remarks />
        public const long BadDeviceFailure = 0x808B0000;
        /// <remarks />
        public const long BadSensorFailure = 0x808C0000;
        /// <remarks />
        public const long BadOutOfService = 0x808D0000;
        /// <remarks />
        public const long BadDeadbandFilterInvalid = 0x808E0000;
        /// <remarks />
        public const long UncertainNoCommunicationLastUsableValue = 0x408F0000;
        /// <remarks />
        public const long UncertainLastUsableValue = 0x40900000;
        /// <remarks />
        public const long UncertainSubstituteValue = 0x40910000;
        /// <remarks />
        public const long UncertainInitialValue = 0x40920000;
        /// <remarks />
        public const long UncertainSensorNotAccurate = 0x40930000;
        /// <remarks />
        public const long UncertainEngineeringUnitsExceeded = 0x40940000;
        /// <remarks />
        public const long UncertainSubNormal = 0x40950000;
        /// <remarks />
        public const long GoodLocalOverride = 0x00960000;
        /// <remarks />
        public const long GoodSubNormal = 0x00EB0000;
        /// <remarks />
        public const long BadRefreshInProgress = 0x80970000;
        /// <remarks />
        public const long BadConditionAlreadyDisabled = 0x80980000;
        /// <remarks />
        public const long BadConditionAlreadyEnabled = 0x80CC0000;
        /// <remarks />
        public const long BadConditionDisabled = 0x80990000;
        /// <remarks />
        public const long BadEventIdUnknown = 0x809A0000;
        /// <remarks />
        public const long BadEventNotAcknowledgeable = 0x80BB0000;
        /// <remarks />
        public const long BadDialogNotActive = 0x80CD0000;
        /// <remarks />
        public const long BadDialogResponseInvalid = 0x80CE0000;
        /// <remarks />
        public const long BadConditionBranchAlreadyAcked = 0x80CF0000;
        /// <remarks />
        public const long BadConditionBranchAlreadyConfirmed = 0x80D00000;
        /// <remarks />
        public const long BadConditionAlreadyShelved = 0x80D10000;
        /// <remarks />
        public const long BadConditionNotShelved = 0x80D20000;
        /// <remarks />
        public const long BadShelvingTimeOutOfRange = 0x80D30000;
        /// <remarks />
        public const long BadNoData = 0x809B0000;
        /// <remarks />
        public const long BadBoundNotFound = 0x80D70000;
        /// <remarks />
        public const long BadBoundNotSupported = 0x80D80000;
        /// <remarks />
        public const long BadDataLost = 0x809D0000;
        /// <remarks />
        public const long BadDataUnavailable = 0x809E0000;
        /// <remarks />
        public const long BadEntryExists = 0x809F0000;
        /// <remarks />
        public const long BadNoEntryExists = 0x80A00000;
        /// <remarks />
        public const long BadTimestampNotSupported = 0x80A10000;
        /// <remarks />
        public const long GoodEntryInserted = 0x00A20000;
        /// <remarks />
        public const long GoodEntryReplaced = 0x00A30000;
        /// <remarks />
        public const long UncertainDataSubNormal = 0x40A40000;
        /// <remarks />
        public const long GoodNoData = 0x00A50000;
        /// <remarks />
        public const long GoodMoreData = 0x00A60000;
        /// <remarks />
        public const long BadAggregateListMismatch = 0x80D40000;
        /// <remarks />
        public const long BadAggregateNotSupported = 0x80D50000;
        /// <remarks />
        public const long BadAggregateInvalidInputs = 0x80D60000;
        /// <remarks />
        public const long BadAggregateConfigurationRejected = 0x80DA0000;
        /// <remarks />
        public const long GoodDataIgnored = 0x00D90000;
        /// <remarks />
        public const long BadRequestNotAllowed = 0x80E40000;
        /// <remarks />
        public const long BadRequestNotComplete = 0x81130000;
        /// <remarks />
        public const long BadTransactionPending = 0x80E80000;
        /// <remarks />
        public const long BadTransactionFailed = 0x80F10000;
        /// <remarks />
        public const long BadTicketRequired = 0x811F0000;
        /// <remarks />
        public const long BadTicketInvalid = 0x81200000;
        /// <remarks />
        public const long BadLocked = 0x80E90000;
        /// <remarks />
        public const long BadRequiresLock = 0x80EC0000;
        /// <remarks />
        public const long GoodEdited = 0x00DC0000;
        /// <remarks />
        public const long GoodPostActionFailed = 0x00DD0000;
        /// <remarks />
        public const long UncertainDominantValueChanged = 0x40DE0000;
        /// <remarks />
        public const long GoodDependentValueChanged = 0x00E00000;
        /// <remarks />
        public const long BadDominantValueChanged = 0x80E10000;
        /// <remarks />
        public const long UncertainDependentValueChanged = 0x40E20000;
        /// <remarks />
        public const long BadDependentValueChanged = 0x80E30000;
        /// <remarks />
        public const long GoodEdited_DependentValueChanged = 0x01160000;
        /// <remarks />
        public const long GoodEdited_DominantValueChanged = 0x01170000;
        /// <remarks />
        public const long GoodEdited_DominantValueChanged_DependentValueChanged = 0x01180000;
        /// <remarks />
        public const long BadEdited_OutOfRange = 0x81190000;
        /// <remarks />
        public const long BadInitialValue_OutOfRange = 0x811A0000;
        /// <remarks />
        public const long BadOutOfRange_DominantValueChanged = 0x811B0000;
        /// <remarks />
        public const long BadEdited_OutOfRange_DominantValueChanged = 0x811C0000;
        /// <remarks />
        public const long BadOutOfRange_DominantValueChanged_DependentValueChanged = 0x811D0000;
        /// <remarks />
        public const long BadEdited_OutOfRange_DominantValueChanged_DependentValueChanged = 0x811E0000;
        /// <remarks />
        public const long GoodCommunicationEvent = 0x00A70000;
        /// <remarks />
        public const long GoodShutdownEvent = 0x00A80000;
        /// <remarks />
        public const long GoodCallAgain = 0x00A90000;
        /// <remarks />
        public const long GoodNonCriticalTimeout = 0x00AA0000;
        /// <remarks />
        public const long BadInvalidArgument = 0x80AB0000;
        /// <remarks />
        public const long BadConnectionRejected = 0x80AC0000;
        /// <remarks />
        public const long BadDisconnect = 0x80AD0000;
        /// <remarks />
        public const long BadConnectionClosed = 0x80AE0000;
        /// <remarks />
        public const long BadInvalidState = 0x80AF0000;
        /// <remarks />
        public const long BadEndOfStream = 0x80B00000;
        /// <remarks />
        public const long BadNoDataAvailable = 0x80B10000;
        /// <remarks />
        public const long BadWaitingForResponse = 0x80B20000;
        /// <remarks />
        public const long BadOperationAbandoned = 0x80B30000;
        /// <remarks />
        public const long BadExpectedStreamToBlock = 0x80B40000;
        /// <remarks />
        public const long BadWouldBlock = 0x80B50000;
        /// <remarks />
        public const long BadSyntaxError = 0x80B60000;
        /// <remarks />
        public const long BadMaxConnectionsReached = 0x80B70000;
        /// <remarks />
        public const long UncertainTransducerInManual = 0x42080000;
        /// <remarks />
        public const long UncertainSimulatedValue = 0x42090000;
        /// <remarks />
        public const long UncertainSensorCalibration = 0x420A0000;
        /// <remarks />
        public const long UncertainConfigurationError = 0x420F0000;
        /// <remarks />
        public const long GoodCascadeInitializationAcknowledged = 0x04010000;
        /// <remarks />
        public const long GoodCascadeInitializationRequest = 0x04020000;
        /// <remarks />
        public const long GoodCascadeNotInvited = 0x04030000;
        /// <remarks />
        public const long GoodCascadeNotSelected = 0x04040000;
        /// <remarks />
        public const long GoodFaultStateActive = 0x04070000;
        /// <remarks />
        public const long GoodInitiateFaultState = 0x04080000;
        /// <remarks />
        public const long GoodCascade = 0x04090000;
        /// <remarks />
        public const long BadDataSetIdInvalid = 0x80E70000;

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(long value)
        {
            foreach (var field in typeof(StatusCodes).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
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
    /// Helper class for working with OPC UA status codes.
    /// </summary>
    public static class StatusUtils
    {
        /// <summary>
        /// Returns true if the code is good.
        /// </summary>
        public static bool IsGood(object code)
        {
            return (ToCode(code) & 0xD0000000) == 0;
        }
        /// <summary>
        /// Returns true if the code is uncertain.
        /// </summary>
        public static bool IsUncertain(object code)
        {
            return (ToCode(code) & 0x40000000) != 0;
        }
        /// <summary>
        /// Returns true if the code is bad.
        /// </summary>
        public static bool IsBad(object code)
        {
            return (ToCode(code) & 0x80000000) != 0;
        }
        /// <summary>
        /// Returns top 16 bits which represent the unique code for the error.
        /// </summary>
        public static long CodeBits(object code)
        {
            return (ToCode(code) & 0xFFFF0000);
        }
        /// <summary>
        /// Returns bottom 16 bits which represent the additional information about the error.
        /// </summary>
        public static long InfoBits(object code)
        {
            return (ToCode(code) & 0x0000FFFF);
        }
        /// <summary>
        /// Returns the code formatted as text.
        /// </summary>
        public static string ToText(object code)
        {
            var number = ToCode(code);

            foreach (var field in typeof(StatusCodes).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(number))
                {
                    return field.Name;
                }
            }

            return "0x" + number.ToString("X8");
        }
        private static long ToCode(object value)
        {
            if (value == null)
            {
                return 0;
            }
            if (value is long code)
            {
                return code;
            }
            var field = value.GetType().GetField("Code");
            if (field != null)
            {
                var fv = field.GetValue(value) as long?;
                if (fv != null)
                {
                    return fv.Value;
                }
            }
            var property = value.GetType().GetProperty("Code");
            if (property != null)
            {
                var pv = property.GetValue(value) as long?;
                if (pv != null)
                {
                    return pv.Value;
                }
            }
            return 0;
        }
    }
}
