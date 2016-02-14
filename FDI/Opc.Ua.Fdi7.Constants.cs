/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Fdi7
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_InitLock Method.
        /// </summary>
        public const uint CommunicationServerType_Lock_InitLock = 25;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_RenewLock Method.
        /// </summary>
        public const uint CommunicationServerType_Lock_RenewLock = 28;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_ExitLock Method.
        /// </summary>
        public const uint CommunicationServerType_Lock_ExitLock = 30;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_BreakLock Method.
        /// </summary>
        public const uint CommunicationServerType_Lock_BreakLock = 32;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_InitLock = 64;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_RenewLock = 67;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_ExitLock = 69;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_BreakLock = 71;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Initialize Method.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_Initialize = 75;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Reset Method.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_Reset = 77;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_AddComponent Method.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_AddComponent = 79;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_RemoveComponent Method.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_RemoveComponent = 82;

        /// <summary>
        /// The identifier for the SetAddressMethodFFH1Type Method.
        /// </summary>
        public const uint SetAddressMethodFFH1Type = 309;

        /// <summary>
        /// The identifier for the SetAddressMethodFFHSEType Method.
        /// </summary>
        public const uint SetAddressMethodFFHSEType = 312;

        /// <summary>
        /// The identifier for the SetAddressMethodPROFIBUSType Method.
        /// </summary>
        public const uint SetAddressMethodPROFIBUSType = 315;

        /// <summary>
        /// The identifier for the SetAddressMethodPROFINETType Method.
        /// </summary>
        public const uint SetAddressMethodPROFINETType = 318;

        /// <summary>
        /// The identifier for the SetAddressMethodHARTType Method.
        /// </summary>
        public const uint SetAddressMethodHARTType = 321;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_InitLock = 107;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_RenewLock = 110;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_ExitLock = 112;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_BreakLock = 114;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock = 146;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock = 149;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock = 151;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock = 153;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_Scan Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_Scan = 157;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_ResetScan Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_ResetScan = 159;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_AddComponent Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_AddComponent = 164;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_RemoveComponent Method.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_RemoveComponent = 167;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_InitLock = 338;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_RenewLock = 341;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_ExitLock = 343;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_BreakLock = 345;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock = 377;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock = 380;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock = 382;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock = 384;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_SetAddress = 398;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock = 413;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock = 416;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock = 418;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock = 420;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer = 446;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_InitLock = 466;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_RenewLock = 469;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_ExitLock = 471;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_BreakLock = 473;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock = 505;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock = 508;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock = 510;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock = 512;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress = 526;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock = 541;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock = 544;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock = 546;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock = 548;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer = 574;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_InitLock = 594;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock = 597;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock = 599;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock = 601;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock = 633;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock = 636;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock = 638;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock = 640;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress = 654;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock = 669;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock = 672;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock = 674;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock = 676;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer = 702;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_InitLock = 719;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_RenewLock = 722;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_ExitLock = 724;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_BreakLock = 726;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock = 758;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock = 761;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock = 763;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock = 765;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress = 779;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock = 794;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock = 797;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock = 799;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock = 801;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer = 827;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_InitLock = 844;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_RenewLock = 847;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_ExitLock = 849;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_BreakLock = 851;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_InitLock = 883;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_RenewLock = 886;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_ExitLock = 888;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_BreakLock = 890;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_SetAddress Method.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_SetAddress = 904;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_InitLock = 919;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_RenewLock = 922;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_ExitLock = 924;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_BreakLock = 926;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer = 952;

        /// <summary>
        /// The identifier for the ConnectMethodFFH1Type Method.
        /// </summary>
        public const uint ConnectMethodFFH1Type = 958;

        /// <summary>
        /// The identifier for the ConnectMethodFFHSEType Method.
        /// </summary>
        public const uint ConnectMethodFFHSEType = 961;

        /// <summary>
        /// The identifier for the ConnectMethodPROFIBUSType Method.
        /// </summary>
        public const uint ConnectMethodPROFIBUSType = 964;

        /// <summary>
        /// The identifier for the ConnectMethodPROFINETType Method.
        /// </summary>
        public const uint ConnectMethodPROFINETType = 967;

        /// <summary>
        /// The identifier for the ConnectMethodHARTType Method.
        /// </summary>
        public const uint ConnectMethodHARTType = 970;

        /// <summary>
        /// The identifier for the TransferMethodFFH1Type Method.
        /// </summary>
        public const uint TransferMethodFFH1Type = 973;

        /// <summary>
        /// The identifier for the TransferMethodFFHSEType Method.
        /// </summary>
        public const uint TransferMethodFFHSEType = 976;

        /// <summary>
        /// The identifier for the TransferMethodPROFIBUSType Method.
        /// </summary>
        public const uint TransferMethodPROFIBUSType = 979;

        /// <summary>
        /// The identifier for the TransferMethodPROFINETType Method.
        /// </summary>
        public const uint TransferMethodPROFINETType = 982;

        /// <summary>
        /// The identifier for the TransferMethodHARTType Method.
        /// </summary>
        public const uint TransferMethodHARTType = 985;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFH1Type Method.
        /// </summary>
        public const uint GetPublishedDataMethodFFH1Type = 988;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFHSEType Method.
        /// </summary>
        public const uint GetPublishedDataMethodFFHSEType = 991;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodHARTType Method.
        /// </summary>
        public const uint GetPublishedDataMethodHARTType = 994;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_InitLock = 247;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_RenewLock = 250;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_ExitLock = 252;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_BreakLock = 254;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_InitLock = 286;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock = 289;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock = 291;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock = 293;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet_Disconnect Method.
        /// </summary>
        public const uint ServerCommunicationServiceType_MethodSet_Disconnect = 300;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_InitLock = 1011;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_RenewLock = 1014;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_ExitLock = 1016;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_BreakLock = 1018;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock = 1050;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock = 1053;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock = 1055;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock = 1057;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Connect Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Connect = 1064;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Transfer = 1067;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData Method.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData = 1070;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_InitLock = 1087;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_RenewLock = 1090;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_ExitLock = 1092;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_BreakLock = 1094;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock = 1126;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock = 1129;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock = 1131;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock = 1133;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Connect Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Connect = 1140;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Transfer = 1143;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData Method.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData = 1146;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_InitLock = 1163;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_RenewLock = 1166;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_ExitLock = 1168;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_BreakLock = 1170;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock = 1202;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock = 1205;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock = 1207;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock = 1209;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Connect Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Connect = 1216;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer = 1219;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_InitLock = 1236;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_RenewLock = 1239;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_ExitLock = 1241;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_BreakLock = 1243;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock = 1275;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock = 1278;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock = 1280;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock = 1282;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Connect Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Connect = 1289;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Transfer = 1292;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_InitLock = 1309;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_RenewLock = 1312;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_ExitLock = 1314;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_BreakLock = 1316;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock = 1348;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock = 1351;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock = 1353;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock = 1355;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Connect Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Connect = 1362;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Transfer Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Transfer = 1365;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_GetPublishedData Method.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_GetPublishedData = 1368;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the CommunicationServerType_ParameterSet Object.
        /// </summary>
        public const uint CommunicationServerType_ParameterSet = 12;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet Object.
        /// </summary>
        public const uint CommunicationServerType_MethodSet = 14;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_NetworkAddress = 73;

        /// <summary>
        /// The identifier for the CommunicationServerType_SubDevices Object.
        /// </summary>
        public const uint CommunicationServerType_SubDevices = 85;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet = 96;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_NetworkAddress = 155;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet = 327;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_NetworkAddress = 386;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider Object.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider = 401;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet = 404;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet = 455;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_NetworkAddress = 514;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider Object.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider = 529;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet = 532;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet = 583;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_NetworkAddress = 642;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider Object.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider = 657;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet = 660;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet = 708;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_NetworkAddress = 767;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider Object.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider = 782;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet = 785;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet = 833;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_NetworkAddress = 892;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider Object.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider = 907;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet = 910;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationServiceType_MethodSet = 236;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_NetworkAddress = 295;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet = 1000;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_NetworkAddress = 1059;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet = 1076;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_NetworkAddress = 1135;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet = 1152;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_NetworkAddress = 1211;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet = 1225;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_NetworkAddress = 1284;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet Object.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet = 1298;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_NetworkAddress = 1357;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the CommunicationServerType ObjectType.
        /// </summary>
        public const uint CommunicationServerType = 11;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationDeviceType = 93;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType = 324;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType = 452;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType = 580;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType = 705;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType ObjectType.
        /// </summary>
        public const uint ServerCommunicationHARType = 830;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationServiceType = 233;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType = 997;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType = 1073;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType = 1149;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType = 1222;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType ObjectType.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType = 1295;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_Locked Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_Locked = 21;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_LockingClient Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_LockingClient = 22;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_LockingUser Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_LockingUser = 23;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_RemainingLockTime = 24;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_InitLock_InputArguments = 26;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_InitLock_OutputArguments = 27;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_RenewLock_OutputArguments = 29;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_ExitLock_OutputArguments = 31;

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_Lock_BreakLock_OutputArguments = 33;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_Locked = 60;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_LockingClient = 61;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_LockingUser = 62;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_RemainingLockTime = 63;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_InitLock_InputArguments = 65;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_InitLock_OutputArguments = 66;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_RenewLock_OutputArguments = 68;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_ExitLock_OutputArguments = 70;

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_CPIdentifier_Lock_BreakLock_OutputArguments = 72;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Initialize_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_Initialize_OutputArguments = 76;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Reset_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_Reset_OutputArguments = 78;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_AddComponent_InputArguments = 80;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_AddComponent_OutputArguments = 81;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_RemoveComponent_InputArguments = 83;

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationServerType_MethodSet_RemoveComponent_OutputArguments = 84;

        /// <summary>
        /// The identifier for the SetAddressMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodFFH1Type_InputArguments = 310;

        /// <summary>
        /// The identifier for the SetAddressMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodFFH1Type_OutputArguments = 311;

        /// <summary>
        /// The identifier for the SetAddressMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodFFHSEType_InputArguments = 313;

        /// <summary>
        /// The identifier for the SetAddressMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodFFHSEType_OutputArguments = 314;

        /// <summary>
        /// The identifier for the SetAddressMethodPROFIBUSType_InputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodPROFIBUSType_InputArguments = 316;

        /// <summary>
        /// The identifier for the SetAddressMethodPROFIBUSType_OutputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodPROFIBUSType_OutputArguments = 317;

        /// <summary>
        /// The identifier for the SetAddressMethodPROFINETType_InputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodPROFINETType_InputArguments = 319;

        /// <summary>
        /// The identifier for the SetAddressMethodPROFINETType_OutputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodPROFINETType_OutputArguments = 320;

        /// <summary>
        /// The identifier for the SetAddressMethodHARTType_InputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodHARTType_InputArguments = 322;

        /// <summary>
        /// The identifier for the SetAddressMethodHARTType_OutputArguments Variable.
        /// </summary>
        public const uint SetAddressMethodHARTType_OutputArguments = 323;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_Locked = 103;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_LockingClient = 104;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_LockingUser = 105;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_RemainingLockTime = 106;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_InitLock_InputArguments = 108;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_InitLock_OutputArguments = 109;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_RenewLock_OutputArguments = 111;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_ExitLock_OutputArguments = 113;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_Lock_BreakLock_OutputArguments = 115;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_Locked = 142;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_LockingClient = 143;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_LockingUser = 144;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_RemainingLockTime = 145;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 147;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 148;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 150;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 152;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 154;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_Scan_OutputArguments = 158;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_ResetScan_OutputArguments = 160;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_AddComponent_InputArguments = 165;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_AddComponent_OutputArguments = 166;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_RemoveComponent_InputArguments = 168;

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationDeviceType_MethodSet_RemoveComponent_OutputArguments = 169;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_Locked = 334;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_LockingClient = 335;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_LockingUser = 336;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_RemainingLockTime = 337;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_InitLock_InputArguments = 339;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_InitLock_OutputArguments = 340;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_RenewLock_OutputArguments = 342;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_ExitLock_OutputArguments = 344;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_Lock_BreakLock_OutputArguments = 346;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_Locked = 373;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingClient = 374;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingUser = 375;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RemainingLockTime = 376;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_InputArguments = 378;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 379;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 381;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 383;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 385;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_Scan_OutputArguments = 389;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_ResetScan_OutputArguments = 391;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_InputArguments = 393;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_OutputArguments = 394;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_InputArguments = 396;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_OutputArguments = 397;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_InputArguments = 399;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_OutputArguments = 400;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_Locked = 409;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingClient = 410;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingUser = 411;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RemainingLockTime = 412;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_InputArguments = 414;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_OutputArguments = 415;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = 417;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = 419;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = 421;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_SerialNumber = 422;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_RevisionCounter = 423;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Manufacturer = 424;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_Model = 425;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceManual = 426;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceRevision = 427;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_SoftwareRevision = 428;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_HardwareRevision = 429;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = 441;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = 442;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_InputArguments = 444;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = 445;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = 447;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = 448;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments = 450;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments = 451;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_Locked = 462;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_LockingClient = 463;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_LockingUser = 464;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_RemainingLockTime = 465;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_InitLock_InputArguments = 467;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_InitLock_OutputArguments = 468;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_RenewLock_OutputArguments = 470;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_ExitLock_OutputArguments = 472;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_Lock_BreakLock_OutputArguments = 474;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_Locked = 501;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingClient = 502;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingUser = 503;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RemainingLockTime = 504;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 506;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 507;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 509;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 511;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 513;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_Scan_OutputArguments = 517;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_ResetScan_OutputArguments = 519;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_InputArguments = 521;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_OutputArguments = 522;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_InputArguments = 524;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_OutputArguments = 525;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_InputArguments = 527;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_OutputArguments = 528;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_Locked = 537;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingClient = 538;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingUser = 539;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RemainingLockTime = 540;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_InputArguments = 542;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_OutputArguments = 543;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = 545;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = 547;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = 549;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_SerialNumber = 550;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_RevisionCounter = 551;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Manufacturer = 552;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_Model = 553;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceManual = 554;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceRevision = 555;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_SoftwareRevision = 556;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_HardwareRevision = 557;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = 569;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = 570;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_InputArguments = 572;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = 573;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = 575;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = 576;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments = 578;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments = 579;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_Locked = 590;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_LockingClient = 591;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_LockingUser = 592;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_RemainingLockTime = 593;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_InputArguments = 595;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_OutputArguments = 596;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock_OutputArguments = 598;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock_OutputArguments = 600;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock_OutputArguments = 602;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_Locked = 629;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingClient = 630;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingUser = 631;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RemainingLockTime = 632;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 634;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 635;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 637;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 639;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 641;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_Scan_OutputArguments = 645;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_ResetScan_OutputArguments = 647;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_InputArguments = 649;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_OutputArguments = 650;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_InputArguments = 652;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_OutputArguments = 653;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_InputArguments = 655;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_OutputArguments = 656;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_Locked = 665;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingClient = 666;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingUser = 667;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RemainingLockTime = 668;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_InputArguments = 670;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_OutputArguments = 671;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = 673;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = 675;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = 677;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SerialNumber = 678;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_RevisionCounter = 679;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Manufacturer = 680;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Model = 681;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceManual = 682;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceRevision = 683;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SoftwareRevision = 684;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_HardwareRevision = 685;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = 697;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = 698;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_InputArguments = 700;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = 701;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = 703;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = 704;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_Locked = 715;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_LockingClient = 716;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_LockingUser = 717;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_RemainingLockTime = 718;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_InitLock_InputArguments = 720;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_InitLock_OutputArguments = 721;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_RenewLock_OutputArguments = 723;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_ExitLock_OutputArguments = 725;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_Lock_BreakLock_OutputArguments = 727;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_Locked = 754;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingClient = 755;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingUser = 756;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RemainingLockTime = 757;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 759;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 760;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 762;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 764;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 766;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_Scan_OutputArguments = 770;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_ResetScan_OutputArguments = 772;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_InputArguments = 774;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_OutputArguments = 775;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_InputArguments = 777;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_OutputArguments = 778;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_InputArguments = 780;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_OutputArguments = 781;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_Locked = 790;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingClient = 791;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingUser = 792;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RemainingLockTime = 793;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_InputArguments = 795;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_OutputArguments = 796;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = 798;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = 800;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = 802;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_SerialNumber = 803;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_RevisionCounter = 804;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Manufacturer = 805;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_Model = 806;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceManual = 807;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceRevision = 808;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_SoftwareRevision = 809;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_HardwareRevision = 810;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = 822;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = 823;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_InputArguments = 825;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = 826;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = 828;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = 829;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_Locked = 840;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_LockingClient = 841;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_LockingUser = 842;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_RemainingLockTime = 843;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_InitLock_InputArguments = 845;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_InitLock_OutputArguments = 846;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_RenewLock_OutputArguments = 848;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_ExitLock_OutputArguments = 850;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_Lock_BreakLock_OutputArguments = 852;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_Locked = 879;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_LockingClient = 880;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_LockingUser = 881;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_RemainingLockTime = 882;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_InitLock_InputArguments = 884;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_InitLock_OutputArguments = 885;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_RenewLock_OutputArguments = 887;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_ExitLock_OutputArguments = 889;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_CPIdentifier_Lock_BreakLock_OutputArguments = 891;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_Scan_OutputArguments = 895;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_ResetScan_OutputArguments = 897;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_AddComponent_InputArguments = 899;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_AddComponent_OutputArguments = 900;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_RemoveComponent_InputArguments = 902;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_RemoveComponent_OutputArguments = 903;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_SetAddress_InputArguments = 905;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_MethodSet_SetAddress_OutputArguments = 906;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_Locked = 915;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_LockingClient = 916;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_LockingUser = 917;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_RemainingLockTime = 918;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_InitLock_InputArguments = 920;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_InitLock_OutputArguments = 921;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_RenewLock_OutputArguments = 923;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_ExitLock_OutputArguments = 925;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Lock_BreakLock_OutputArguments = 927;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_SerialNumber = 928;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_RevisionCounter = 929;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Manufacturer = 930;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Model Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_Model = 931;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_DeviceManual = 932;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_DeviceRevision = 933;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_SoftwareRevision = 934;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_HardwareRevision = 935;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_InputArguments = 947;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_OutputArguments = 948;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_InputArguments = 950;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_OutputArguments = 951;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_InputArguments = 953;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_OutputArguments = 954;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_InputArguments = 956;

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments = 957;

        /// <summary>
        /// The identifier for the ConnectMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public const uint ConnectMethodFFH1Type_InputArguments = 959;

        /// <summary>
        /// The identifier for the ConnectMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public const uint ConnectMethodFFH1Type_OutputArguments = 960;

        /// <summary>
        /// The identifier for the ConnectMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public const uint ConnectMethodFFHSEType_InputArguments = 962;

        /// <summary>
        /// The identifier for the ConnectMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public const uint ConnectMethodFFHSEType_OutputArguments = 963;

        /// <summary>
        /// The identifier for the ConnectMethodPROFIBUSType_InputArguments Variable.
        /// </summary>
        public const uint ConnectMethodPROFIBUSType_InputArguments = 965;

        /// <summary>
        /// The identifier for the ConnectMethodPROFIBUSType_OutputArguments Variable.
        /// </summary>
        public const uint ConnectMethodPROFIBUSType_OutputArguments = 966;

        /// <summary>
        /// The identifier for the ConnectMethodPROFINETType_InputArguments Variable.
        /// </summary>
        public const uint ConnectMethodPROFINETType_InputArguments = 968;

        /// <summary>
        /// The identifier for the ConnectMethodPROFINETType_OutputArguments Variable.
        /// </summary>
        public const uint ConnectMethodPROFINETType_OutputArguments = 969;

        /// <summary>
        /// The identifier for the ConnectMethodHARTType_InputArguments Variable.
        /// </summary>
        public const uint ConnectMethodHARTType_InputArguments = 971;

        /// <summary>
        /// The identifier for the ConnectMethodHARTType_OutputArguments Variable.
        /// </summary>
        public const uint ConnectMethodHARTType_OutputArguments = 972;

        /// <summary>
        /// The identifier for the TransferMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public const uint TransferMethodFFH1Type_InputArguments = 974;

        /// <summary>
        /// The identifier for the TransferMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public const uint TransferMethodFFH1Type_OutputArguments = 975;

        /// <summary>
        /// The identifier for the TransferMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public const uint TransferMethodFFHSEType_InputArguments = 977;

        /// <summary>
        /// The identifier for the TransferMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public const uint TransferMethodFFHSEType_OutputArguments = 978;

        /// <summary>
        /// The identifier for the TransferMethodPROFIBUSType_InputArguments Variable.
        /// </summary>
        public const uint TransferMethodPROFIBUSType_InputArguments = 980;

        /// <summary>
        /// The identifier for the TransferMethodPROFIBUSType_OutputArguments Variable.
        /// </summary>
        public const uint TransferMethodPROFIBUSType_OutputArguments = 981;

        /// <summary>
        /// The identifier for the TransferMethodPROFINETType_InputArguments Variable.
        /// </summary>
        public const uint TransferMethodPROFINETType_InputArguments = 983;

        /// <summary>
        /// The identifier for the TransferMethodPROFINETType_OutputArguments Variable.
        /// </summary>
        public const uint TransferMethodPROFINETType_OutputArguments = 984;

        /// <summary>
        /// The identifier for the TransferMethodHARTType_InputArguments Variable.
        /// </summary>
        public const uint TransferMethodHARTType_InputArguments = 986;

        /// <summary>
        /// The identifier for the TransferMethodHARTType_OutputArguments Variable.
        /// </summary>
        public const uint TransferMethodHARTType_OutputArguments = 987;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public const uint GetPublishedDataMethodFFH1Type_InputArguments = 989;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public const uint GetPublishedDataMethodFFH1Type_OutputArguments = 990;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public const uint GetPublishedDataMethodFFHSEType_InputArguments = 992;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public const uint GetPublishedDataMethodFFHSEType_OutputArguments = 993;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodHARTType_InputArguments Variable.
        /// </summary>
        public const uint GetPublishedDataMethodHARTType_InputArguments = 995;

        /// <summary>
        /// The identifier for the GetPublishedDataMethodHARTType_OutputArguments Variable.
        /// </summary>
        public const uint GetPublishedDataMethodHARTType_OutputArguments = 996;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_Locked = 243;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_LockingClient = 244;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_LockingUser = 245;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_RemainingLockTime = 246;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_InitLock_InputArguments = 248;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_InitLock_OutputArguments = 249;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_RenewLock_OutputArguments = 251;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_ExitLock_OutputArguments = 253;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_Lock_BreakLock_OutputArguments = 255;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_Locked = 282;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_LockingClient = 283;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_LockingUser = 284;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_RemainingLockTime = 285;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_InputArguments = 287;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_OutputArguments = 288;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = 290;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = 292;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = 294;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_MethodSet_Disconnect_InputArguments = 301;

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationServiceType_MethodSet_Disconnect_OutputArguments = 302;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_Locked = 1007;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_LockingClient = 1008;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_LockingUser = 1009;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_RemainingLockTime = 1010;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_InitLock_InputArguments = 1012;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_InitLock_OutputArguments = 1013;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_RenewLock_OutputArguments = 1015;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_ExitLock_OutputArguments = 1017;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_Lock_BreakLock_OutputArguments = 1019;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_Locked = 1046;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingClient = 1047;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingUser = 1048;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RemainingLockTime = 1049;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_InputArguments = 1051;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_OutputArguments = 1052;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = 1054;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = 1056;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = 1058;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_InputArguments = 1062;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_OutputArguments = 1063;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Connect_InputArguments = 1065;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Connect_OutputArguments = 1066;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Transfer_InputArguments = 1068;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_Transfer_OutputArguments = 1069;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_InputArguments = 1071;

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_OutputArguments = 1072;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_Locked = 1083;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_LockingClient = 1084;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_LockingUser = 1085;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_RemainingLockTime = 1086;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_InitLock_InputArguments = 1088;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_InitLock_OutputArguments = 1089;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_RenewLock_OutputArguments = 1091;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_ExitLock_OutputArguments = 1093;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_Lock_BreakLock_OutputArguments = 1095;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_Locked = 1122;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingClient = 1123;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingUser = 1124;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RemainingLockTime = 1125;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_InputArguments = 1127;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_OutputArguments = 1128;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = 1130;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = 1132;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = 1134;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_InputArguments = 1138;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_OutputArguments = 1139;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Connect_InputArguments = 1141;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Connect_OutputArguments = 1142;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Transfer_InputArguments = 1144;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_Transfer_OutputArguments = 1145;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_InputArguments = 1147;

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_OutputArguments = 1148;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_Locked = 1159;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_LockingClient = 1160;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_LockingUser = 1161;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_RemainingLockTime = 1162;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_InitLock_InputArguments = 1164;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_InitLock_OutputArguments = 1165;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_RenewLock_OutputArguments = 1167;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_ExitLock_OutputArguments = 1169;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_Lock_BreakLock_OutputArguments = 1171;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_Locked = 1198;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingClient = 1199;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingUser = 1200;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RemainingLockTime = 1201;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_InputArguments = 1203;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_OutputArguments = 1204;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = 1206;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = 1208;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = 1210;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_InputArguments = 1214;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_OutputArguments = 1215;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_InputArguments = 1217;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_OutputArguments = 1218;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_InputArguments = 1220;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_OutputArguments = 1221;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_Locked = 1232;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_LockingClient = 1233;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_LockingUser = 1234;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_RemainingLockTime = 1235;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_InitLock_InputArguments = 1237;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_InitLock_OutputArguments = 1238;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_RenewLock_OutputArguments = 1240;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_ExitLock_OutputArguments = 1242;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_Lock_BreakLock_OutputArguments = 1244;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_Locked = 1271;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingClient = 1272;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingUser = 1273;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RemainingLockTime = 1274;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_InputArguments = 1276;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_OutputArguments = 1277;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = 1279;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = 1281;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = 1283;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_InputArguments = 1287;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_OutputArguments = 1288;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Connect_InputArguments = 1290;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Connect_OutputArguments = 1291;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Transfer_InputArguments = 1293;

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationPROFINETServiceType_MethodSet_Transfer_OutputArguments = 1294;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_Locked = 1305;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_LockingClient = 1306;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_LockingUser = 1307;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_RemainingLockTime = 1308;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_InitLock_InputArguments = 1310;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_InitLock_OutputArguments = 1311;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_RenewLock_OutputArguments = 1313;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_ExitLock_OutputArguments = 1315;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_Lock_BreakLock_OutputArguments = 1317;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_Locked = 1344;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingClient = 1345;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingUser = 1346;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_RemainingLockTime = 1347;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_InputArguments = 1349;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_OutputArguments = 1350;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = 1352;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = 1354;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = 1356;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Disconnect_InputArguments = 1360;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Disconnect_OutputArguments = 1361;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Connect_InputArguments = 1363;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Connect_OutputArguments = 1364;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Transfer_InputArguments = 1366;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_Transfer_OutputArguments = 1367;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_InputArguments = 1369;

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public const uint ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_OutputArguments = 1370;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Initialize Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_Initialize = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_MethodSet_Initialize, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_Reset = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_MethodSet_Reset, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_AddComponent Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_AddComponent = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_MethodSet_AddComponent, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_RemoveComponent Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_RemoveComponent = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.CommunicationServerType_MethodSet_RemoveComponent, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodFFH1Type Method.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodFFH1Type = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.SetAddressMethodFFH1Type, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodFFHSEType Method.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodFFHSEType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.SetAddressMethodFFHSEType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodPROFIBUSType Method.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodPROFIBUSType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.SetAddressMethodPROFIBUSType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodPROFINETType Method.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodPROFINETType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.SetAddressMethodPROFINETType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodHARTType Method.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodHARTType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.SetAddressMethodHARTType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_Scan = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_MethodSet_Scan, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_ResetScan Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_ResetScan = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_MethodSet_ResetScan, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_AddComponent Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_AddComponent = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_MethodSet_AddComponent, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_RemoveComponent Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_RemoveComponent = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationDeviceType_MethodSet_RemoveComponent, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_SetAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_MethodSet_SetAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_SetAddress Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_SetAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_MethodSet_SetAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_ServiceProvider_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_ServiceProvider_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_ServiceProvider_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_ServiceProvider_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodFFH1Type Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodFFH1Type = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ConnectMethodFFH1Type, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodFFHSEType Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodFFHSEType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ConnectMethodFFHSEType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodPROFIBUSType Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodPROFIBUSType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ConnectMethodPROFIBUSType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodPROFINETType Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodPROFINETType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ConnectMethodPROFINETType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodHARTType Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodHARTType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ConnectMethodHARTType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodFFH1Type Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodFFH1Type = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.TransferMethodFFH1Type, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodFFHSEType Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodFFHSEType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.TransferMethodFFHSEType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodPROFIBUSType Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodPROFIBUSType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.TransferMethodPROFIBUSType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodPROFINETType Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodPROFINETType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.TransferMethodPROFINETType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodHARTType Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodHARTType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.TransferMethodHARTType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFH1Type Method.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodFFH1Type = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.GetPublishedDataMethodFFH1Type, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFHSEType Method.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodFFHSEType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.GetPublishedDataMethodFFHSEType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodHARTType Method.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodHARTType = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.GetPublishedDataMethodHARTType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet_Disconnect Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_MethodSet_Disconnect = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationServiceType_MethodSet_Disconnect, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Connect = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_MethodSet_Connect, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Connect = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_MethodSet_Connect, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Connect = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_MethodSet_Connect, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Connect = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_MethodSet_Connect, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationPROFINETServiceType_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Connect = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_MethodSet_Connect, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Transfer Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Transfer = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_MethodSet_Transfer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_GetPublishedData Method.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_GetPublishedData = new ExpandedNodeId(Opc.Ua.Fdi7.Methods.ServerCommunicationHARTServiceType_MethodSet_GetPublishedData, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the CommunicationServerType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_ParameterSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.CommunicationServerType_ParameterSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.CommunicationServerType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.CommunicationServerType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_SubDevices Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_SubDevices = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.CommunicationServerType_SubDevices, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationDeviceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFH1DeviceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFH1DeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFH1DeviceType_ServiceProvider, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFHSEDeviceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFHSEDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFHSEDeviceType_ServiceProvider, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFIBUSDeviceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFIBUSDeviceType_ServiceProvider, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFINETDeviceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFINETDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFINETDeviceType_ServiceProvider, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationHARType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationHARType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationHARType_ServiceProvider, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationHARType_ServiceProvider_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationServiceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationServiceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFH1ServiceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFH1ServiceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFHSEServiceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationFFHSEServiceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFIBUSServiceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFIBUSServiceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFINETServiceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationPROFINETServiceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationHARTServiceType_MethodSet, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Fdi7.Objects.ServerCommunicationHARTServiceType_CPIdentifier_NetworkAddress, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the CommunicationServerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.CommunicationServerType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFH1DeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFHSEDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFIBUSDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFINETDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationHARType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFH1ServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFHSEServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFIBUSServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFINETServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType = new ExpandedNodeId(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationHARTServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Initialize_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_Initialize_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_MethodSet_Initialize_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_Reset_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_Reset_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_MethodSet_Reset_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the CommunicationServerType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationServerType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.CommunicationServerType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodFFH1Type_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodFFH1Type_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodFFH1Type_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodFFH1Type_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodFFHSEType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodFFHSEType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodFFHSEType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodFFHSEType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodPROFIBUSType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodPROFIBUSType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodPROFIBUSType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodPROFIBUSType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodPROFIBUSType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodPROFIBUSType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodPROFINETType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodPROFINETType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodPROFINETType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodPROFINETType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodPROFINETType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodPROFINETType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodHARTType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodHARTType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodHARTType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the SetAddressMethodHARTType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetAddressMethodHARTType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.SetAddressMethodHARTType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_MethodSet_Scan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_ResetScan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_MethodSet_ResetScan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationDeviceType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationDeviceType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_Scan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_ResetScan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_ResetScan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_MethodSet_SetAddress_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_SerialNumber = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_SerialNumber, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_RevisionCounter = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_RevisionCounter, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Manufacturer = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Manufacturer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_Model = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_Model, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceManual = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceManual, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_DeviceRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_SoftwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_HardwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_HardwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1DeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_Scan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_ResetScan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_ResetScan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_MethodSet_SetAddress_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_SerialNumber = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_SerialNumber, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_RevisionCounter = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_RevisionCounter, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Manufacturer = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Manufacturer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_Model = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_Model, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceManual = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceManual, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_DeviceRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_SoftwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_HardwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_HardwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEDeviceType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_Scan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_ResetScan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_ResetScan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_MethodSet_SetAddress_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SerialNumber = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SerialNumber, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_RevisionCounter = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_RevisionCounter, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Manufacturer = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Manufacturer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Model = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_Model, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceManual = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceManual, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_DeviceRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_SoftwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_HardwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_HardwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_Scan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_ResetScan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_ResetScan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_MethodSet_SetAddress_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_SerialNumber = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_SerialNumber, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_RevisionCounter = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_RevisionCounter, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Manufacturer = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Manufacturer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_Model = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_Model, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceManual = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceManual, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_DeviceRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_SoftwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_HardwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_HardwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETDeviceType_ServiceProvider_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_Scan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_ResetScan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_ResetScan_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_ResetScan_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_AddComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_AddComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_AddComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_AddComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_AddComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_AddComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_RemoveComponent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_RemoveComponent_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_RemoveComponent_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_RemoveComponent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_RemoveComponent_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_RemoveComponent_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_SetAddress_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_SetAddress_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_SetAddress_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_MethodSet_SetAddress_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_MethodSet_SetAddress_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_MethodSet_SetAddress_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_SerialNumber = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_SerialNumber, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_RevisionCounter = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_RevisionCounter, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Manufacturer = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Manufacturer, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_Model = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_Model, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_DeviceManual = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_DeviceManual, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_DeviceRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_DeviceRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_SoftwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_HardwareRevision = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_HardwareRevision, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARType_ServiceProvider_MethodSet_GetPublishedData_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodFFH1Type_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodFFH1Type_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodFFH1Type_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodFFH1Type_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodFFHSEType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodFFHSEType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodFFHSEType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodFFHSEType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodPROFIBUSType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodPROFIBUSType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodPROFIBUSType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodPROFIBUSType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodPROFIBUSType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodPROFIBUSType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodPROFINETType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodPROFINETType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodPROFINETType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodPROFINETType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodPROFINETType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodPROFINETType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodHARTType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodHARTType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodHARTType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ConnectMethodHARTType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectMethodHARTType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ConnectMethodHARTType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodFFH1Type_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodFFH1Type_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodFFH1Type_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodFFH1Type_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodFFHSEType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodFFHSEType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodFFHSEType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodFFHSEType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodPROFIBUSType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodPROFIBUSType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodPROFIBUSType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodPROFIBUSType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodPROFIBUSType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodPROFIBUSType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodPROFINETType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodPROFINETType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodPROFINETType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodPROFINETType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodPROFINETType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodPROFINETType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodHARTType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodHARTType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodHARTType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the TransferMethodHARTType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferMethodHARTType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.TransferMethodHARTType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFH1Type_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodFFH1Type_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.GetPublishedDataMethodFFH1Type_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFH1Type_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodFFH1Type_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.GetPublishedDataMethodFFH1Type_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFHSEType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodFFHSEType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.GetPublishedDataMethodFFHSEType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodFFHSEType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodFFHSEType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.GetPublishedDataMethodFFHSEType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodHARTType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodHARTType_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.GetPublishedDataMethodHARTType_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the GetPublishedDataMethodHARTType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GetPublishedDataMethodHARTType_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.GetPublishedDataMethodHARTType_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationServiceType_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationServiceType_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFH1ServiceType_MethodSet_GetPublishedData_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationFFHSEServiceType_MethodSet_GetPublishedData_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFIBUSServiceType_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationPROFINETServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationPROFINETServiceType_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationPROFINETServiceType_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_Locked, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Disconnect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Disconnect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_Disconnect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Disconnect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Disconnect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_Disconnect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_Connect_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_Connect_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Transfer_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Transfer_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_Transfer_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_Transfer_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_Transfer_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_Transfer_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_InputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_InputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);

        /// <summary>
        /// The identifier for the ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_OutputArguments = new ExpandedNodeId(Opc.Ua.Fdi7.Variables.ServerCommunicationHARTServiceType_MethodSet_GetPublishedData_OutputArguments, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CommunicationServerType component.
        /// </summary>
        public const string CommunicationServerType = "CommunicationServerType";

        /// <summary>
        /// The BrowseName for the ConnectMethodFFH1Type component.
        /// </summary>
        public const string ConnectMethodFFH1Type = "ConnectMethodFFH1Type";

        /// <summary>
        /// The BrowseName for the ConnectMethodFFHSEType component.
        /// </summary>
        public const string ConnectMethodFFHSEType = "ConnectMethodFFHSEType";

        /// <summary>
        /// The BrowseName for the ConnectMethodHARTType component.
        /// </summary>
        public const string ConnectMethodHARTType = "ConnectMethodHARTType";

        /// <summary>
        /// The BrowseName for the ConnectMethodPROFIBUSType component.
        /// </summary>
        public const string ConnectMethodPROFIBUSType = "ConnectMethodPROFIBUSType";

        /// <summary>
        /// The BrowseName for the ConnectMethodPROFINETType component.
        /// </summary>
        public const string ConnectMethodPROFINETType = "ConnectMethodPROFINETType";

        /// <summary>
        /// The BrowseName for the GetPublishedDataMethodFFH1Type component.
        /// </summary>
        public const string GetPublishedDataMethodFFH1Type = "GetPublishedDataMethodFFH1Type";

        /// <summary>
        /// The BrowseName for the GetPublishedDataMethodFFHSEType component.
        /// </summary>
        public const string GetPublishedDataMethodFFHSEType = "GetPublishedDataMethodFFHSEType";

        /// <summary>
        /// The BrowseName for the GetPublishedDataMethodHARTType component.
        /// </summary>
        public const string GetPublishedDataMethodHARTType = "GetPublishedDataMethodHARTType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationDeviceType component.
        /// </summary>
        public const string ServerCommunicationDeviceType = "ServerCommunicationDeviceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationFFH1DeviceType component.
        /// </summary>
        public const string ServerCommunicationFFH1DeviceType = "ServerCommunicationFFH1DeviceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationFFH1ServiceType component.
        /// </summary>
        public const string ServerCommunicationFFH1ServiceType = "ServerCommunicationFFH1ServiceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationFFHSEDeviceType component.
        /// </summary>
        public const string ServerCommunicationFFHSEDeviceType = "ServerCommunicationFFHSEDeviceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationFFHSEServiceType component.
        /// </summary>
        public const string ServerCommunicationFFHSEServiceType = "ServerCommunicationFFHSEServiceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationHARTServiceType component.
        /// </summary>
        public const string ServerCommunicationHARTServiceType = "ServerCommunicationHARTServiceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationHARType component.
        /// </summary>
        public const string ServerCommunicationHARType = "ServerCommunicationHARType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationPROFIBUSDeviceType component.
        /// </summary>
        public const string ServerCommunicationPROFIBUSDeviceType = "ServerCommunicationPROFIBUSDeviceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationPROFIBUSServiceType component.
        /// </summary>
        public const string ServerCommunicationPROFIBUSServiceType = "ServerCommunicationPROFIBUSServiceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationPROFINETDeviceType component.
        /// </summary>
        public const string ServerCommunicationPROFINETDeviceType = "ServerCommunicationPROFINETDeviceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationPROFINETServiceType component.
        /// </summary>
        public const string ServerCommunicationPROFINETServiceType = "ServerCommunicationPROFINETServiceType";

        /// <summary>
        /// The BrowseName for the ServerCommunicationServiceType component.
        /// </summary>
        public const string ServerCommunicationServiceType = "ServerCommunicationServiceType";

        /// <summary>
        /// The BrowseName for the ServiceProvider component.
        /// </summary>
        public const string ServiceProvider = "ServiceProvider";

        /// <summary>
        /// The BrowseName for the SetAddressMethodFFH1Type component.
        /// </summary>
        public const string SetAddressMethodFFH1Type = "SetAddressMethodFFH1Type";

        /// <summary>
        /// The BrowseName for the SetAddressMethodFFHSEType component.
        /// </summary>
        public const string SetAddressMethodFFHSEType = "SetAddressMethodFFHSEType";

        /// <summary>
        /// The BrowseName for the SetAddressMethodHARTType component.
        /// </summary>
        public const string SetAddressMethodHARTType = "SetAddressMethodHARTType";

        /// <summary>
        /// The BrowseName for the SetAddressMethodPROFIBUSType component.
        /// </summary>
        public const string SetAddressMethodPROFIBUSType = "SetAddressMethodPROFIBUSType";

        /// <summary>
        /// The BrowseName for the SetAddressMethodPROFINETType component.
        /// </summary>
        public const string SetAddressMethodPROFINETType = "SetAddressMethodPROFINETType";

        /// <summary>
        /// The BrowseName for the SubDevices component.
        /// </summary>
        public const string SubDevices = "SubDevices";

        /// <summary>
        /// The BrowseName for the TransferMethodFFH1Type component.
        /// </summary>
        public const string TransferMethodFFH1Type = "TransferMethodFFH1Type";

        /// <summary>
        /// The BrowseName for the TransferMethodFFHSEType component.
        /// </summary>
        public const string TransferMethodFFHSEType = "TransferMethodFFHSEType";

        /// <summary>
        /// The BrowseName for the TransferMethodHARTType component.
        /// </summary>
        public const string TransferMethodHARTType = "TransferMethodHARTType";

        /// <summary>
        /// The BrowseName for the TransferMethodPROFIBUSType component.
        /// </summary>
        public const string TransferMethodPROFIBUSType = "TransferMethodPROFIBUSType";

        /// <summary>
        /// The BrowseName for the TransferMethodPROFINETType component.
        /// </summary>
        public const string TransferMethodPROFINETType = "TransferMethodPROFINETType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaFdi7 namespace (.NET code namespace is 'Opc.Ua.Fdi7').
        /// </summary>
        public const string OpcUaFdi7 = "http://fdi-cooperation.com/OPCUA/FDI7/";

        /// <summary>
        /// The URI for the OpcUaFdi7Xsd namespace (.NET code namespace is 'Opc.Ua.Fdi7').
        /// </summary>
        public const string OpcUaFdi7Xsd = "http://fdi-cooperation.com/OPCUA/FDI7/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}