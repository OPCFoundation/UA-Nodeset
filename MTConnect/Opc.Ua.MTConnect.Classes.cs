/* ========================================================================
 * Copyright (c) 2005-2018 The OPC Foundation, Inc. All rights reserved.
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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.MTConnect
{
    #region MTDevicesState Class
    #if (!OPCUA_EXCLUDE_MTDevicesState)
    /// <summary>
    /// Stores an instance of the MTDevicesType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTDevicesState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTDevicesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTDevicesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MTConnectVersion != null)
            {
                MTConnectVersion.Initialize(context, MTConnectVersion_InitializationString);
            }

            if (OPCUAMappingDate != null)
            {
                OPCUAMappingDate.Initialize(context, OPCUAMappingDate_InitializationString);
            }

            if (OPCUAVersion != null)
            {
                OPCUAVersion.Initialize(context, OPCUAVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string MTConnectVersion_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAE1UQ29ubmVjdFZlcnNpb24BAdcZAC8AP9cZAAAADP////8BAf////8AAAAA";

        private const string OPCUAMappingDate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAE9QQ1VBTWFwcGluZ0RhdGUBAdgZAC8AP9gZAAAADf////8BAf////8AAAAA";

        private const string OPCUAVersion_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DAAAAE9QQ1VBVmVyc2lvbgEB2RkALwA/2RkAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FQAAAE1URGV2aWNlc1R5cGVJbnN0YW5jZQEB1hkBAdYZ/////wMAAAAVYIkKAgAAAAEAEAAAAE1UQ29u" +
           "bmVjdFZlcnNpb24BAdcZAC8AP9cZAAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABPUENVQU1h" +
           "cHBpbmdEYXRlAQHYGQAvAD/YGQAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAT1BDVUFWZXJz" +
           "aW9uAQHZGQAvAD/ZGQAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MTConnectVersion Variable.
        /// </summary>
        public BaseDataVariableState<string> MTConnectVersion
        {
            get
            {
                return m_mTConnectVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mTConnectVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mTConnectVersion = value;
            }
        }

        /// <summary>
        /// A description for the OPCUAMappingDate Variable.
        /// </summary>
        public BaseDataVariableState<DateTime> OPCUAMappingDate
        {
            get
            {
                return m_oPCUAMappingDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oPCUAMappingDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oPCUAMappingDate = value;
            }
        }

        /// <summary>
        /// A description for the OPCUAVersion Variable.
        /// </summary>
        public BaseDataVariableState<string> OPCUAVersion
        {
            get
            {
                return m_oPCUAVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oPCUAVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oPCUAVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mTConnectVersion != null)
            {
                children.Add(m_mTConnectVersion);
            }

            if (m_oPCUAMappingDate != null)
            {
                children.Add(m_oPCUAMappingDate);
            }

            if (m_oPCUAVersion != null)
            {
                children.Add(m_oPCUAVersion);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.MTConnectVersion:
                {
                    if (createOrReplace)
                    {
                        if (MTConnectVersion == null)
                        {
                            if (replacement == null)
                            {
                                MTConnectVersion = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MTConnectVersion = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MTConnectVersion;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.OPCUAMappingDate:
                {
                    if (createOrReplace)
                    {
                        if (OPCUAMappingDate == null)
                        {
                            if (replacement == null)
                            {
                                OPCUAMappingDate = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                OPCUAMappingDate = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = OPCUAMappingDate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.OPCUAVersion:
                {
                    if (createOrReplace)
                    {
                        if (OPCUAVersion == null)
                        {
                            if (replacement == null)
                            {
                                OPCUAVersion = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                OPCUAVersion = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = OPCUAVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_mTConnectVersion;
        private BaseDataVariableState<DateTime> m_oPCUAMappingDate;
        private BaseDataVariableState<string> m_oPCUAVersion;
        #endregion
    }
    #endif
    #endregion

    #region MTDeviceState Class
    #if (!OPCUA_EXCLUDE_MTDeviceState)
    /// <summary>
    /// Stores an instance of the MTDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTDeviceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTDeviceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }

            if (Conditions != null)
            {
                Conditions.Initialize(context, Conditions_InitializationString);
            }
        }

        #region Initialization String
        private const string Configuration_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DQAAAENvbmZpZ3VyYXRpb24BAeAZAC4AROAZAAAADP////8BAf////8AAAAA";

        private const string SampleInterval_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAFNhbXBsZUludGVydmFsAQHhGQAuAEThGQAAAQAiAf////8BAf////8AAAAA";

        private const string Conditions_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "CgAAAENvbmRpdGlvbnMBAeQZAC8APeQZAAD/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FAAAAE1URGV2aWNlVHlwZUluc3RhbmNlAQHaGQEB2hn/////CAAAABVgiQoCAAAAAQAMAAAAQXZhaWxh" +
           "YmlsaXR5AQHbGQAvAQA9CdsZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAd4ZAC4ARN4ZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAd8Z" +
           "AC4ARN8ZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAA0AAABDb25maWd1cmF0aW9uAQHgGQAuAETg" +
           "GQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAU2FtcGxlSW50ZXJ2YWwBAeEZAC4AROEZAAAB" +
           "ACIB/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEB4hkALwA94hkAAP////8AAAAA" +
           "BGCACgEAAAABAAoAAABDb21wb25lbnRzAQHjGQAvAD3jGQAA/////wAAAAAEYIAKAQAAAAEACgAAAENv" +
           "bmRpdGlvbnMBAeQZAC8APeQZAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Availability Variable.
        /// </summary>
        public DataItemState<string> Availability
        {
            get
            {
                return m_availability;
            }

            set
            {
                if (!Object.ReferenceEquals(m_availability, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_availability = value;
            }
        }

        /// <summary>
        /// A description for the Manufacturer Property.
        /// </summary>
        public PropertyState<string> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <summary>
        /// A description for the SerialNumber Property.
        /// </summary>
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <summary>
        /// A description for the Configuration Property.
        /// </summary>
        public PropertyState<string> Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <summary>
        /// A description for the SampleInterval Property.
        /// </summary>
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }

        /// <summary>
        /// A description for the DataItems Object.
        /// </summary>
        public FolderState DataItems
        {
            get
            {
                return m_dataItems;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dataItems, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dataItems = value;
            }
        }

        /// <summary>
        /// A description for the Components Object.
        /// </summary>
        public FolderState Components
        {
            get
            {
                return m_components;
            }

            set
            {
                if (!Object.ReferenceEquals(m_components, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_components = value;
            }
        }

        /// <summary>
        /// A description for the Conditions Object.
        /// </summary>
        public FolderState Conditions
        {
            get
            {
                return m_conditions;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conditions, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conditions = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_availability != null)
            {
                children.Add(m_availability);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            if (m_dataItems != null)
            {
                children.Add(m_dataItems);
            }

            if (m_components != null)
            {
                children.Add(m_components);
            }

            if (m_conditions != null)
            {
                children.Add(m_conditions);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Availability:
                {
                    if (createOrReplace)
                    {
                        if (Availability == null)
                        {
                            if (replacement == null)
                            {
                                Availability = new DataItemState<string>(this);
                            }
                            else
                            {
                                Availability = (DataItemState<string>)replacement;
                            }
                        }
                    }

                    instance = Availability;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new PropertyState<string>(this);
                            }
                            else
                            {
                                Configuration = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.DataItems:
                {
                    if (createOrReplace)
                    {
                        if (DataItems == null)
                        {
                            if (replacement == null)
                            {
                                DataItems = new FolderState(this);
                            }
                            else
                            {
                                DataItems = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DataItems;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Components:
                {
                    if (createOrReplace)
                    {
                        if (Components == null)
                        {
                            if (replacement == null)
                            {
                                Components = new FolderState(this);
                            }
                            else
                            {
                                Components = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Components;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Conditions:
                {
                    if (createOrReplace)
                    {
                        if (Conditions == null)
                        {
                            if (replacement == null)
                            {
                                Conditions = new FolderState(this);
                            }
                            else
                            {
                                Conditions = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Conditions;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private DataItemState<string> m_availability;
        private PropertyState<string> m_manufacturer;
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_configuration;
        private PropertyState<double> m_sampleInterval;
        private FolderState m_dataItems;
        private FolderState m_components;
        private FolderState m_conditions;
        #endregion
    }
    #endif
    #endregion

    #region MTComponentState Class
    #if (!OPCUA_EXCLUDE_MTComponentState)
    /// <summary>
    /// Stores an instance of the MTComponentType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTComponentState : MTDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTComponentState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTComponentType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (Station != null)
            {
                Station.Initialize(context, Station_InitializationString);
            }
        }

        #region Initialization String
        private const string Model_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAE1vZGVsAQHwGQAuAETwGQAAAAz/////AQH/////AAAAAA==";

        private const string Station_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAFN0YXRpb24BAfEZAC4ARPEZAAABACIB/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAE1UQ29tcG9uZW50VHlwZUluc3RhbmNlAQHlGQEB5Rn/////BwAAABVgiQoCAAAAAQAMAAAAQXZh" +
           "aWxhYmlsaXR5AQHmGQAvAQA9CeYZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFj" +
           "dHVyZXIBAekZAC4AROkZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIB" +
           "AeoZAC4AROoZAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAe0ZAC8APe0Z" +
           "AAD/////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEB7hkALwA97hkAAP////8AAAAAFWCJCgIA" +
           "AAABAAUAAABNb2RlbAEB8BkALgBE8BkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAFN0YXRp" +
           "b24BAfEZAC4ARPEZAAABACIB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Model Property.
        /// </summary>
        public PropertyState<string> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <summary>
        /// A description for the Station Property.
        /// </summary>
        public PropertyState<double> Station
        {
            get
            {
                return m_station;
            }

            set
            {
                if (!Object.ReferenceEquals(m_station, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_station = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_station != null)
            {
                children.Add(m_station);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<string>(this);
                            }
                            else
                            {
                                Model = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Station:
                {
                    if (createOrReplace)
                    {
                        if (Station == null)
                        {
                            if (replacement == null)
                            {
                                Station = new PropertyState<double>(this);
                            }
                            else
                            {
                                Station = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Station;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_model;
        private PropertyState<double> m_station;
        #endregion
    }
    #endif
    #endregion

    #region MTAxesState Class
    #if (!OPCUA_EXCLUDE_MTAxesState)
    /// <summary>
    /// Stores an instance of the MTAxesType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTAxesState : MTDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTAxesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LinearAxesX != null)
            {
                LinearAxesX.Initialize(context, LinearAxesX_InitializationString);
            }

            if (LinearAxesY != null)
            {
                LinearAxesY.Initialize(context, LinearAxesY_InitializationString);
            }

            if (LinearAxesZ != null)
            {
                LinearAxesZ.Initialize(context, LinearAxesZ_InitializationString);
            }

            if (RotoryAxesA != null)
            {
                RotoryAxesA.Initialize(context, RotoryAxesA_InitializationString);
            }

            if (RotoryAxesB != null)
            {
                RotoryAxesB.Initialize(context, RotoryAxesB_InitializationString);
            }

            if (RotoryAxesC != null)
            {
                RotoryAxesC.Initialize(context, RotoryAxesC_InitializationString);
            }
        }

        #region Initialization String
        private const string LinearAxesX_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAExpbmVhckF4ZXNYAQH9GQAuAET9GQAAAAz/////AQH/////AAAAAA==";

        private const string LinearAxesY_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAExpbmVhckF4ZXNZAQH+GQAuAET+GQAAAAz/////AQH/////AAAAAA==";

        private const string LinearAxesZ_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAExpbmVhckF4ZXNaAQH/GQAuAET/GQAAAAz/////AQH/////AAAAAA==";

        private const string RotoryAxesA_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAFJvdG9yeUF4ZXNBAQEAGgAuAEQAGgAAAAz/////AQH/////AAAAAA==";

        private const string RotoryAxesB_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAFJvdG9yeUF4ZXNCAQEBGgAuAEQBGgAAAAz/////AQH/////AAAAAA==";

        private const string RotoryAxesC_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAFJvdG9yeUF4ZXNDAQECGgAuAEQCGgAAAAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "EgAAAE1UQXhlc1R5cGVJbnN0YW5jZQEB8hkBAfIZ/////wsAAAAVYIkKAgAAAAEADAAAAEF2YWlsYWJp" +
           "bGl0eQEB8xkALwEAPQnzGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVy" +
           "AQH2GQAuAET2GQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQH3GQAu" +
           "AET3GQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQH6GQAvAD36GQAA////" +
           "/wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAfsZAC8APfsZAAD/////AAAAABVgiQoCAAAAAQAL" +
           "AAAATGluZWFyQXhlc1gBAf0ZAC4ARP0ZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABMaW5l" +
           "YXJBeGVzWQEB/hkALgBE/hkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAExpbmVhckF4ZXNa" +
           "AQH/GQAuAET/GQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAUm90b3J5QXhlc0EBAQAaAC4A" +
           "RAAaAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABSb3RvcnlBeGVzQgEBARoALgBEARoAAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAFJvdG9yeUF4ZXNDAQECGgAuAEQCGgAAAAz/////AQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the LinearAxesX Property.
        /// </summary>
        public PropertyState<string> LinearAxesX
        {
            get
            {
                return m_linearAxesX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesX = value;
            }
        }

        /// <summary>
        /// A description for the LinearAxesY Property.
        /// </summary>
        public PropertyState<string> LinearAxesY
        {
            get
            {
                return m_linearAxesY;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesY, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesY = value;
            }
        }

        /// <summary>
        /// A description for the LinearAxesZ Property.
        /// </summary>
        public PropertyState<string> LinearAxesZ
        {
            get
            {
                return m_linearAxesZ;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesZ, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesZ = value;
            }
        }

        /// <summary>
        /// A description for the RotoryAxesA Property.
        /// </summary>
        public PropertyState<string> RotoryAxesA
        {
            get
            {
                return m_rotoryAxesA;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotoryAxesA, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotoryAxesA = value;
            }
        }

        /// <summary>
        /// A description for the RotoryAxesB Property.
        /// </summary>
        public PropertyState<string> RotoryAxesB
        {
            get
            {
                return m_rotoryAxesB;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotoryAxesB, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotoryAxesB = value;
            }
        }

        /// <summary>
        /// A description for the RotoryAxesC Property.
        /// </summary>
        public PropertyState<string> RotoryAxesC
        {
            get
            {
                return m_rotoryAxesC;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotoryAxesC, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotoryAxesC = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_linearAxesX != null)
            {
                children.Add(m_linearAxesX);
            }

            if (m_linearAxesY != null)
            {
                children.Add(m_linearAxesY);
            }

            if (m_linearAxesZ != null)
            {
                children.Add(m_linearAxesZ);
            }

            if (m_rotoryAxesA != null)
            {
                children.Add(m_rotoryAxesA);
            }

            if (m_rotoryAxesB != null)
            {
                children.Add(m_rotoryAxesB);
            }

            if (m_rotoryAxesC != null)
            {
                children.Add(m_rotoryAxesC);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.LinearAxesX:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesX == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesX = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesX = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesX;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LinearAxesY:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesY == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesY = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesY = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesY;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LinearAxesZ:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesZ == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesZ = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesZ = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesZ;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.RotoryAxesA:
                {
                    if (createOrReplace)
                    {
                        if (RotoryAxesA == null)
                        {
                            if (replacement == null)
                            {
                                RotoryAxesA = new PropertyState<string>(this);
                            }
                            else
                            {
                                RotoryAxesA = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RotoryAxesA;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.RotoryAxesB:
                {
                    if (createOrReplace)
                    {
                        if (RotoryAxesB == null)
                        {
                            if (replacement == null)
                            {
                                RotoryAxesB = new PropertyState<string>(this);
                            }
                            else
                            {
                                RotoryAxesB = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RotoryAxesB;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.RotoryAxesC:
                {
                    if (createOrReplace)
                    {
                        if (RotoryAxesC == null)
                        {
                            if (replacement == null)
                            {
                                RotoryAxesC = new PropertyState<string>(this);
                            }
                            else
                            {
                                RotoryAxesC = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RotoryAxesC;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_linearAxesX;
        private PropertyState<string> m_linearAxesY;
        private PropertyState<string> m_linearAxesZ;
        private PropertyState<string> m_rotoryAxesA;
        private PropertyState<string> m_rotoryAxesB;
        private PropertyState<string> m_rotoryAxesC;
        #endregion
    }
    #endif
    #endregion

    #region MTControllerState Class
    #if (!OPCUA_EXCLUDE_MTControllerState)
    /// <summary>
    /// Stores an instance of the MTControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTControllerState : MTDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTControllerType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GAAAAE1UQ29udHJvbGxlclR5cGVJbnN0YW5jZQEBAxoBAQMa/////wUAAAAVYIkKAgAAAAEADAAAAEF2" +
           "YWlsYWJpbGl0eQEBBBoALwEAPQkEGgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZh" +
           "Y3R1cmVyAQEHGgAuAEQHGgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVy" +
           "AQEIGgAuAEQIGgAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQELGgAvAD0L" +
           "GgAA/////wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAQwaAC8APQwaAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MTDoorState Class
    #if (!OPCUA_EXCLUDE_MTDoorState)
    /// <summary>
    /// Stores an instance of the MTDoorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTDoorState : MTDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTDoorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTDoorType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DoorState != null)
            {
                DoorState.Initialize(context, DoorState_InitializationString);
            }
        }

        #region Initialization String
        private const string DoorState_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CQAAAERvb3JTdGF0ZQEBGRoALgBEGRoAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "EgAAAE1URG9vclR5cGVJbnN0YW5jZQEBDhoBAQ4a/////wYAAAAVYIkKAgAAAAEADAAAAEF2YWlsYWJp" +
           "bGl0eQEBDxoALwEAPQkPGgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVy" +
           "AQESGgAuAEQSGgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQETGgAu" +
           "AEQTGgAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQEWGgAvAD0WGgAA////" +
           "/wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBARcaAC8APRcaAAD/////AAAAABVgiQoCAAAAAQAJ" +
           "AAAARG9vclN0YXRlAQEZGgAuAEQZGgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DoorState Property.
        /// </summary>
        public PropertyState<string> DoorState
        {
            get
            {
                return m_doorState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_doorState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_doorState = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_doorState != null)
            {
                children.Add(m_doorState);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.DoorState:
                {
                    if (createOrReplace)
                    {
                        if (DoorState == null)
                        {
                            if (replacement == null)
                            {
                                DoorState = new PropertyState<string>(this);
                            }
                            else
                            {
                                DoorState = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DoorState;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_doorState;
        #endregion
    }
    #endif
    #endregion

    #region MTActuatorState Class
    #if (!OPCUA_EXCLUDE_MTActuatorState)
    /// <summary>
    /// Stores an instance of the MTActuatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTActuatorState : MTDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTActuatorType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LinearAxesX != null)
            {
                LinearAxesX.Initialize(context, LinearAxesX_InitializationString);
            }
        }

        #region Initialization String
        private const string LinearAxesX_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAExpbmVhckF4ZXNYAQElGgAuAEQlGgAAAAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FgAAAE1UQWN0dWF0b3JUeXBlSW5zdGFuY2UBARoaAQEaGv////8GAAAAFWCJCgIAAAABAAwAAABBdmFp" +
           "bGFiaWxpdHkBARsaAC8BAD0JGxoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0" +
           "dXJlcgEBHhoALgBEHhoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEB" +
           "HxoALgBEHxoAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBIhoALwA9IhoA" +
           "AP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQEjGgAvAD0jGgAA/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAExpbmVhckF4ZXNYAQElGgAuAEQlGgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the LinearAxesX Property.
        /// </summary>
        public PropertyState<string> LinearAxesX
        {
            get
            {
                return m_linearAxesX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesX = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_linearAxesX != null)
            {
                children.Add(m_linearAxesX);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.LinearAxesX:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesX == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesX = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesX = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesX;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_linearAxesX;
        #endregion
    }
    #endif
    #endregion

    #region MTSampleDataItemState Class
    #if (!OPCUA_EXCLUDE_MTSampleDataItemState)
    /// <summary>
    /// Stores an instance of the MTSampleDataItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTSampleDataItemState : AnalogItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTSampleDataItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MTSampleDataItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CoordinateSystem != null)
            {
                CoordinateSystem.Initialize(context, CoordinateSystem_InitializationString);
            }

            if (NativeUnits != null)
            {
                NativeUnits.Initialize(context, NativeUnits_InitializationString);
            }

            if (NativeScale != null)
            {
                NativeScale.Initialize(context, NativeScale_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }
        }

        #region Initialization String
        private const string CoordinateSystem_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAENvb3JkaW5hdGVTeXN0ZW0BASwaAC4ARCwaAAABAQMn/////wEB/////wAAAAA=";

        private const string NativeUnits_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAE5hdGl2ZVVuaXRzAQEtGgAuAEQtGgAAAQB3A/////8BAf////8AAAAA";

        private const string NativeScale_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAE5hdGl2ZVNjYWxlAQEuGgAuAEQuGgAAAAr/////AQH/////AAAAAA==";

        private const string SampleInterval_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAFNhbXBsZUludGVydmFsAQEvGgAuAEQvGgAAAQAiAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HAAAAE1UU2FtcGxlRGF0YUl0ZW1UeXBlSW5zdGFuY2UBASYaAQEmGgAaAQH/////BQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBKhoALgBEKhoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAQ29v" +
           "cmRpbmF0ZVN5c3RlbQEBLBoALgBELBoAAAEBAyf/////AQH/////AAAAABVgiQoCAAAAAQALAAAATmF0" +
           "aXZlVW5pdHMBAS0aAC4ARC0aAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAE5hdGl2ZVNj" +
           "YWxlAQEuGgAuAEQuGgAAAAr/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAU2FtcGxlSW50ZXJ2YWwB" +
           "AS8aAC4ARC8aAAABACIB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CoordinateSystem Property.
        /// </summary>
        public PropertyState<CoordinateSystemTypeEnum> CoordinateSystem
        {
            get
            {
                return m_coordinateSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordinateSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordinateSystem = value;
            }
        }

        /// <summary>
        /// A description for the NativeUnits Property.
        /// </summary>
        public PropertyState<EUInformation> NativeUnits
        {
            get
            {
                return m_nativeUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeUnits = value;
            }
        }

        /// <summary>
        /// A description for the NativeScale Property.
        /// </summary>
        public PropertyState<float> NativeScale
        {
            get
            {
                return m_nativeScale;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeScale, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeScale = value;
            }
        }

        /// <summary>
        /// A description for the SampleInterval Property.
        /// </summary>
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordinateSystem != null)
            {
                children.Add(m_coordinateSystem);
            }

            if (m_nativeUnits != null)
            {
                children.Add(m_nativeUnits);
            }

            if (m_nativeScale != null)
            {
                children.Add(m_nativeScale);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CoordinateSystem:
                {
                    if (createOrReplace)
                    {
                        if (CoordinateSystem == null)
                        {
                            if (replacement == null)
                            {
                                CoordinateSystem = new PropertyState<CoordinateSystemTypeEnum>(this);
                            }
                            else
                            {
                                CoordinateSystem = (PropertyState<CoordinateSystemTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CoordinateSystem;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeUnits:
                {
                    if (createOrReplace)
                    {
                        if (NativeUnits == null)
                        {
                            if (replacement == null)
                            {
                                NativeUnits = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                NativeUnits = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = NativeUnits;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeScale:
                {
                    if (createOrReplace)
                    {
                        if (NativeScale == null)
                        {
                            if (replacement == null)
                            {
                                NativeScale = new PropertyState<float>(this);
                            }
                            else
                            {
                                NativeScale = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = NativeScale;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<CoordinateSystemTypeEnum> m_coordinateSystem;
        private PropertyState<EUInformation> m_nativeUnits;
        private PropertyState<float> m_nativeScale;
        private PropertyState<double> m_sampleInterval;
        #endregion
    }

    #region MTSampleDataItemState<T> Class
    /// <summary>
    /// A typed version of the MTSampleDataItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MTSampleDataItemState<T> : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MTSampleDataItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AccelerationState Class
    #if (!OPCUA_EXCLUDE_AccelerationState)
    /// <summary>
    /// Stores an instance of the AccelerationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccelerationState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccelerationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AccelerationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEFjY2VsZXJhdGlvblR5cGVJbnN0YW5jZQEBMBoBATAaABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBNBoALgBENBoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AccelerationState<T> Class
    /// <summary>
    /// A typed version of the AccelerationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AccelerationState<T> : AccelerationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AccelerationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AccumulatedTimeState Class
    #if (!OPCUA_EXCLUDE_AccumulatedTimeState)
    /// <summary>
    /// Stores an instance of the AccumulatedTimeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccumulatedTimeState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccumulatedTimeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AccumulatedTimeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GwAAAEFjY3VtdWxhdGVkVGltZVR5cGVJbnN0YW5jZQEBOhoBAToaABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBPhoALgBEPhoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AccumulatedTimeState<T> Class
    /// <summary>
    /// A typed version of the AccumulatedTimeType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AccumulatedTimeState<T> : AccumulatedTimeState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AccumulatedTimeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AmperageState Class
    #if (!OPCUA_EXCLUDE_AmperageState)
    /// <summary>
    /// Stores an instance of the AmperageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AmperageState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AmperageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AmperageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAEFtcGVyYWdlVHlwZUluc3RhbmNlAQFEGgEBRBoAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQFIGgAuAERIGgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AmperageState<T> Class
    /// <summary>
    /// A typed version of the AmperageType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AmperageState<T> : AmperageState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AmperageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngleState Class
    #if (!OPCUA_EXCLUDE_AngleState)
    /// <summary>
    /// Stores an instance of the AngleType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngleState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngleState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AngleType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EQAAAEFuZ2xlVHlwZUluc3RhbmNlAQFOGgEBThoAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQFSGgAuAERSGgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngleState<T> Class
    /// <summary>
    /// A typed version of the AngleType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngleState<T> : AngleState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AngleState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngularAccelerationState Class
    #if (!OPCUA_EXCLUDE_AngularAccelerationState)
    /// <summary>
    /// Stores an instance of the AngularAccelerationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngularAccelerationState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngularAccelerationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AngularAccelerationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HwAAAEFuZ3VsYXJBY2NlbGVyYXRpb25UeXBlSW5zdGFuY2UBAVgaAQFYGgAa/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAVwaAC4ARFwaAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngularAccelerationState<T> Class
    /// <summary>
    /// A typed version of the AngularAccelerationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngularAccelerationState<T> : AngularAccelerationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AngularAccelerationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngularVelocityState Class
    #if (!OPCUA_EXCLUDE_AngularVelocityState)
    /// <summary>
    /// Stores an instance of the AngularVelocityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngularVelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngularVelocityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AngularVelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GwAAAEFuZ3VsYXJWZWxvY2l0eVR5cGVJbnN0YW5jZQEBYhoBAWIaABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBZhoALgBEZhoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngularVelocityState<T> Class
    /// <summary>
    /// A typed version of the AngularVelocityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngularVelocityState<T> : AngularVelocityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AngularVelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AxisFeedrateState Class
    #if (!OPCUA_EXCLUDE_AxisFeedrateState)
    /// <summary>
    /// Stores an instance of the AxisFeedrateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxisFeedrateState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AxisFeedrateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AxisFeedrateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEF4aXNGZWVkcmF0ZVR5cGVJbnN0YW5jZQEBbBoBAWwaABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBcBoALgBEcBoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AxisFeedrateState<T> Class
    /// <summary>
    /// A typed version of the AxisFeedrateType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AxisFeedrateState<T> : AxisFeedrateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AxisFeedrateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ConcentrationState Class
    #if (!OPCUA_EXCLUDE_ConcentrationState)
    /// <summary>
    /// Stores an instance of the ConcentrationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConcentrationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ConcentrationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAENvbmNlbnRyYXRpb25UeXBlSW5zdGFuY2UBAXYaAQF2GgAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAXoaAC4ARHoaAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ConcentrationState<T> Class
    /// <summary>
    /// A typed version of the ConcentrationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ConcentrationState<T> : ConcentrationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ConcentrationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ConductivityState Class
    #if (!OPCUA_EXCLUDE_ConductivityState)
    /// <summary>
    /// Stores an instance of the ConductivityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConductivityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConductivityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ConductivityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAENvbmR1Y3Rpdml0eVR5cGVJbnN0YW5jZQEBgBoBAYAaABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBhBoALgBEhBoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ConductivityState<T> Class
    /// <summary>
    /// A typed version of the ConductivityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ConductivityState<T> : ConductivityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ConductivityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region DisplacementState Class
    #if (!OPCUA_EXCLUDE_DisplacementState)
    /// <summary>
    /// Stores an instance of the DisplacementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisplacementState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DisplacementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.DisplacementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAERpc3BsYWNlbWVudFR5cGVJbnN0YW5jZQEBihoBAYoaABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBjhoALgBEjhoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region DisplacementState<T> Class
    /// <summary>
    /// A typed version of the DisplacementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class DisplacementState<T> : DisplacementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public DisplacementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ElectricalEnergyState Class
    #if (!OPCUA_EXCLUDE_ElectricalEnergyState)
    /// <summary>
    /// Stores an instance of the ElectricalEnergyType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ElectricalEnergyState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ElectricalEnergyState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ElectricalEnergyType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HAAAAEVsZWN0cmljYWxFbmVyZ3lUeXBlSW5zdGFuY2UBAZQaAQGUGgAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAZgaAC4ARJgaAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ElectricalEnergyState<T> Class
    /// <summary>
    /// A typed version of the ElectricalEnergyType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ElectricalEnergyState<T> : ElectricalEnergyState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ElectricalEnergyState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FillLevelState Class
    #if (!OPCUA_EXCLUDE_FillLevelState)
    /// <summary>
    /// Stores an instance of the FillLevelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FillLevelState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FillLevelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.FillLevelType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAEZpbGxMZXZlbFR5cGVJbnN0YW5jZQEBnhoBAZ4aABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBohoALgBEohoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FillLevelState<T> Class
    /// <summary>
    /// A typed version of the FillLevelType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FillLevelState<T> : FillLevelState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FillLevelState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FlowState Class
    #if (!OPCUA_EXCLUDE_FlowState)
    /// <summary>
    /// Stores an instance of the FlowType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FlowState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.FlowType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAEZsb3dUeXBlSW5zdGFuY2UBAagaAQGoGgAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAawaAC4ARKwaAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FlowState<T> Class
    /// <summary>
    /// A typed version of the FlowType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FlowState<T> : FlowState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FlowState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FrequencyState Class
    #if (!OPCUA_EXCLUDE_FrequencyState)
    /// <summary>
    /// Stores an instance of the FrequencyType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FrequencyState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FrequencyState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.FrequencyType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAEZyZXF1ZW5jeVR5cGVJbnN0YW5jZQEBshoBAbIaABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBthoALgBEthoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FrequencyState<T> Class
    /// <summary>
    /// A typed version of the FrequencyType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FrequencyState<T> : FrequencyState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FrequencyState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LinearForceState Class
    #if (!OPCUA_EXCLUDE_LinearForceState)
    /// <summary>
    /// Stores an instance of the LinearForceType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LinearForceState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LinearForceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LinearForceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAExpbmVhckZvcmNlVHlwZUluc3RhbmNlAQG8GgEBvBoAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQHAGgAuAETAGgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region LinearForceState<T> Class
    /// <summary>
    /// A typed version of the LinearForceType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LinearForceState<T> : LinearForceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LinearForceState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LoadState Class
    #if (!OPCUA_EXCLUDE_LoadState)
    /// <summary>
    /// Stores an instance of the LoadType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LoadState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LoadType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAExvYWRUeXBlSW5zdGFuY2UBAcYaAQHGGgAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAcoaAC4ARMoaAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region LoadState<T> Class
    /// <summary>
    /// A typed version of the LoadType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LoadState<T> : LoadState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LoadState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MassState Class
    #if (!OPCUA_EXCLUDE_MassState)
    /// <summary>
    /// Stores an instance of the MassType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MassType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAE1hc3NUeXBlSW5zdGFuY2UBAdAaAQHQGgAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAdQaAC4ARNQaAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region MassState<T> Class
    /// <summary>
    /// A typed version of the MassType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MassState<T> : MassState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MassState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PathFeedrateState Class
    #if (!OPCUA_EXCLUDE_PathFeedrateState)
    /// <summary>
    /// Stores an instance of the PathFeedrateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathFeedrateState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PathFeedrateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PathFeedrateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAFBhdGhGZWVkcmF0ZVR5cGVJbnN0YW5jZQEB2hoBAdoaABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB3hoALgBE3hoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PathFeedrateState<T> Class
    /// <summary>
    /// A typed version of the PathFeedrateType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PathFeedrateState<T> : PathFeedrateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PathFeedrateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PathPositionState Class
    #if (!OPCUA_EXCLUDE_PathPositionState)
    /// <summary>
    /// Stores an instance of the PathPositionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathPositionState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PathPositionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PathPositionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAFBhdGhQb3NpdGlvblR5cGVJbnN0YW5jZQEB5BoBAeQaABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB6BoALgBE6BoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PathPositionState<T> Class
    /// <summary>
    /// A typed version of the PathPositionType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PathPositionState<T> : PathPositionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PathPositionState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PHState Class
    #if (!OPCUA_EXCLUDE_PHState)
    /// <summary>
    /// Stores an instance of the PHType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PHState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PHState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PHType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "DgAAAFBIVHlwZUluc3RhbmNlAQHuGgEB7hoAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQHyGgAuAETyGgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PHState<T> Class
    /// <summary>
    /// A typed version of the PHType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PHState<T> : PHState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PHState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PositionState Class
    #if (!OPCUA_EXCLUDE_PositionState)
    /// <summary>
    /// Stores an instance of the PositionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PositionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PositionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFBvc2l0aW9uVHlwZUluc3RhbmNlAQH4GgEB+BoAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQH8GgAuAET8GgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PositionState<T> Class
    /// <summary>
    /// A typed version of the PositionType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PositionState<T> : PositionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PositionState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PowerFactorState Class
    #if (!OPCUA_EXCLUDE_PowerFactorState)
    /// <summary>
    /// Stores an instance of the PowerFactorType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerFactorState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PowerFactorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PowerFactorType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAFBvd2VyRmFjdG9yVHlwZUluc3RhbmNlAQECGwEBAhsAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQEGGwAuAEQGGwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PowerFactorState<T> Class
    /// <summary>
    /// A typed version of the PowerFactorType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PowerFactorState<T> : PowerFactorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PowerFactorState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PressureState Class
    #if (!OPCUA_EXCLUDE_PressureState)
    /// <summary>
    /// Stores an instance of the PressureType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PressureState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PressureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFByZXNzdXJlVHlwZUluc3RhbmNlAQEMGwEBDBsAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQEQGwAuAEQQGwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PressureState<T> Class
    /// <summary>
    /// A typed version of the PressureType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PressureState<T> : PressureState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PressureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ResistanceState Class
    #if (!OPCUA_EXCLUDE_ResistanceState)
    /// <summary>
    /// Stores an instance of the ResistanceType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistanceState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResistanceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ResistanceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFJlc2lzdGFuY2VUeXBlSW5zdGFuY2UBARYbAQEWGwAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBARobAC4ARBobAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ResistanceState<T> Class
    /// <summary>
    /// A typed version of the ResistanceType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ResistanceState<T> : ResistanceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ResistanceState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region RotationalVelocityState Class
    #if (!OPCUA_EXCLUDE_RotationalVelocityState)
    /// <summary>
    /// Stores an instance of the RotationalVelocityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RotationalVelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RotationalVelocityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.RotationalVelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HgAAAFJvdGF0aW9uYWxWZWxvY2l0eVR5cGVJbnN0YW5jZQEBIBsBASAbABr/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBJBsALgBEJBsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region RotationalVelocityState<T> Class
    /// <summary>
    /// A typed version of the RotationalVelocityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class RotationalVelocityState<T> : RotationalVelocityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public RotationalVelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region SoundPressureState Class
    #if (!OPCUA_EXCLUDE_SoundPressureState)
    /// <summary>
    /// Stores an instance of the SoundPressureType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SoundPressureState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SoundPressureState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.SoundPressureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAFNvdW5kUHJlc3N1cmVUeXBlSW5zdGFuY2UBASobAQEqGwAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAS4bAC4ARC4bAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region SoundPressureState<T> Class
    /// <summary>
    /// A typed version of the SoundPressureType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class SoundPressureState<T> : SoundPressureState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public SoundPressureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region StrainState Class
    #if (!OPCUA_EXCLUDE_StrainState)
    /// <summary>
    /// Stores an instance of the StrainType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StrainState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StrainState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.StrainType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EgAAAFN0cmFpblR5cGVJbnN0YW5jZQEBNBsBATQbABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBOBsALgBEOBsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region StrainState<T> Class
    /// <summary>
    /// A typed version of the StrainType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class StrainState<T> : StrainState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public StrainState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TemperatureState Class
    #if (!OPCUA_EXCLUDE_TemperatureState)
    /// <summary>
    /// Stores an instance of the TemperatureType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.TemperatureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAFRlbXBlcmF0dXJlVHlwZUluc3RhbmNlAQE+GwEBPhsAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQFCGwAuAERCGwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TemperatureState<T> Class
    /// <summary>
    /// A typed version of the TemperatureType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TemperatureState<T> : TemperatureState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public TemperatureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TiltState Class
    #if (!OPCUA_EXCLUDE_TiltState)
    /// <summary>
    /// Stores an instance of the TiltType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TiltState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TiltState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.TiltType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAFRpbHRUeXBlSW5zdGFuY2UBAUgbAQFIGwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAUwbAC4AREwbAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TiltState<T> Class
    /// <summary>
    /// A typed version of the TiltType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TiltState<T> : TiltState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public TiltState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TorqueState Class
    #if (!OPCUA_EXCLUDE_TorqueState)
    /// <summary>
    /// Stores an instance of the TorqueType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TorqueState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TorqueState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.TorqueType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EgAAAFRvcnF1ZVR5cGVJbnN0YW5jZQEBUhsBAVIbABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBVhsALgBEVhsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TorqueState<T> Class
    /// <summary>
    /// A typed version of the TorqueType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TorqueState<T> : TorqueState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public TorqueState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VelocityState Class
    #if (!OPCUA_EXCLUDE_VelocityState)
    /// <summary>
    /// Stores an instance of the VelocityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VelocityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFZlbG9jaXR5VHlwZUluc3RhbmNlAQFcGwEBXBsAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQFgGwAuAERgGwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VelocityState<T> Class
    /// <summary>
    /// A typed version of the VelocityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VelocityState<T> : VelocityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ViscosityState Class
    #if (!OPCUA_EXCLUDE_ViscosityState)
    /// <summary>
    /// Stores an instance of the ViscosityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ViscosityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ViscosityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ViscosityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAFZpc2Nvc2l0eVR5cGVJbnN0YW5jZQEBZhsBAWYbABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBahsALgBEahsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ViscosityState<T> Class
    /// <summary>
    /// A typed version of the ViscosityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ViscosityState<T> : ViscosityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ViscosityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltageState Class
    #if (!OPCUA_EXCLUDE_VoltageState)
    /// <summary>
    /// Stores an instance of the VoltageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VoltageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAFZvbHRhZ2VUeXBlSW5zdGFuY2UBAXAbAQFwGwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAXQbAC4ARHQbAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltageState<T> Class
    /// <summary>
    /// A typed version of the VoltageType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltageState<T> : VoltageState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VoltageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltAmpereState Class
    #if (!OPCUA_EXCLUDE_VoltAmpereState)
    /// <summary>
    /// Stores an instance of the VoltAmpereType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmpereState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltAmpereState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VoltAmpereType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFZvbHRBbXBlcmVUeXBlSW5zdGFuY2UBAXobAQF6GwAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAX4bAC4ARH4bAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltAmpereState<T> Class
    /// <summary>
    /// A typed version of the VoltAmpereType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltAmpereState<T> : VoltAmpereState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VoltAmpereState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltAmpereReactiveState Class
    #if (!OPCUA_EXCLUDE_VoltAmpereReactiveState)
    /// <summary>
    /// Stores an instance of the VoltAmpereReactiveType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmpereReactiveState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltAmpereReactiveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VoltAmpereReactiveType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HgAAAFZvbHRBbXBlcmVSZWFjdGl2ZVR5cGVJbnN0YW5jZQEBhBsBAYQbABr/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBiBsALgBEiBsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltAmpereReactiveState<T> Class
    /// <summary>
    /// A typed version of the VoltAmpereReactiveType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltAmpereReactiveState<T> : VoltAmpereReactiveState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VoltAmpereReactiveState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region WattageState Class
    #if (!OPCUA_EXCLUDE_WattageState)
    /// <summary>
    /// Stores an instance of the WattageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WattageState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WattageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.WattageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAFdhdHRhZ2VUeXBlSW5zdGFuY2UBAY4bAQGOGwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAZIbAC4ARJIbAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region WattageState<T> Class
    /// <summary>
    /// A typed version of the WattageType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class WattageState<T> : WattageState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public WattageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MTEventDataItemState Class
    #if (!OPCUA_EXCLUDE_MTEventDataItemState)
    /// <summary>
    /// Stores an instance of the MTEventDataItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTEventDataItemState : DiscreteItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTEventDataItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MTEventDataItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CoordinateSystem != null)
            {
                CoordinateSystem.Initialize(context, CoordinateSystem_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }
        }

        #region Initialization String
        private const string CoordinateSystem_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAENvb3JkaW5hdGVTeXN0ZW0BAZsbAC4ARJsbAAABAQMn/////wEB/////wAAAAA=";

        private const string SampleInterval_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAFNhbXBsZUludGVydmFsAQGcGwAuAEScGwAAAQAiAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GwAAAE1URXZlbnREYXRhSXRlbVR5cGVJbnN0YW5jZQEBmBsBAZgbABj/////AQH/////AgAAABVgiQoC" +
           "AAAAAQAQAAAAQ29vcmRpbmF0ZVN5c3RlbQEBmxsALgBEmxsAAAEBAyf/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAOAAAAU2FtcGxlSW50ZXJ2YWwBAZwbAC4ARJwbAAABACIB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CoordinateSystem Property.
        /// </summary>
        public PropertyState<CoordinateSystemTypeEnum> CoordinateSystem
        {
            get
            {
                return m_coordinateSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordinateSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordinateSystem = value;
            }
        }

        /// <summary>
        /// A description for the SampleInterval Property.
        /// </summary>
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordinateSystem != null)
            {
                children.Add(m_coordinateSystem);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CoordinateSystem:
                {
                    if (createOrReplace)
                    {
                        if (CoordinateSystem == null)
                        {
                            if (replacement == null)
                            {
                                CoordinateSystem = new PropertyState<CoordinateSystemTypeEnum>(this);
                            }
                            else
                            {
                                CoordinateSystem = (PropertyState<CoordinateSystemTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CoordinateSystem;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<CoordinateSystemTypeEnum> m_coordinateSystem;
        private PropertyState<double> m_sampleInterval;
        #endregion
    }

    #region MTEventDataItemState<T> Class
    /// <summary>
    /// A typed version of the MTEventDataItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MTEventDataItemState<T> : MTEventDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MTEventDataItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ActiveAxesState Class
    #if (!OPCUA_EXCLUDE_ActiveAxesState)
    /// <summary>
    /// Stores an instance of the ActiveAxesType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActiveAxesState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActiveAxesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ActiveAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAEFjdGl2ZUF4ZXNUeXBlSW5zdGFuY2UBAZ0bAQGdGwAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ActuatorStateState Class
    #if (!OPCUA_EXCLUDE_ActuatorStateState)
    /// <summary>
    /// Stores an instance of the ActuatorStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActuatorStateState : MTEventDataItemState<ActuatorStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActuatorStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ActuatorStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ActuatorStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAEFjdHVhdG9yU3RhdGVUeXBlSW5zdGFuY2UBAaIbAQGiGwEB6yb/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AvailabilityState Class
    #if (!OPCUA_EXCLUDE_AvailabilityState)
    /// <summary>
    /// Stores an instance of the AvailabilityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AvailabilityState : MTEventDataItemState<AvailabilityTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AvailabilityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AvailabilityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.AvailabilityTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEF2YWlsYWJpbGl0eVR5cGVJbnN0YW5jZQEBpxsBAacbAQHzJv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AxesCouplingState Class
    #if (!OPCUA_EXCLUDE_AxesCouplingState)
    /// <summary>
    /// Stores an instance of the AxesCouplingType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxesCouplingState : MTEventDataItemState<AxesCouplingTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AxesCouplingState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AxesCouplingType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.AxesCouplingTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEF4ZXNDb3VwbGluZ1R5cGVJbnN0YW5jZQEBrBsBAawbAQH1Jv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BlockState Class
    #if (!OPCUA_EXCLUDE_BlockState)
    /// <summary>
    /// Stores an instance of the BlockType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BlockState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BlockState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.BlockType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EQAAAEJsb2NrVHlwZUluc3RhbmNlAQHrAwEB6wMADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ClampStateState Class
    #if (!OPCUA_EXCLUDE_ClampStateState)
    /// <summary>
    /// Stores an instance of the ClampStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClampStateState : MTEventDataItemState<ClampStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ClampStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ClampStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ClampStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAENsYW1wU3RhdGVUeXBlSW5zdGFuY2UBAbUbAQG1GwEB/ib/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ControllerModeState Class
    #if (!OPCUA_EXCLUDE_ControllerModeState)
    /// <summary>
    /// Stores an instance of the ControllerModeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerModeState : MTEventDataItemState<ControllerModeTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ControllerModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ControllerModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ControllerModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GgAAAENvbnRyb2xsZXJNb2RlVHlwZUluc3RhbmNlAQG6GwEBuhsBAQEn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CoupledAxesState Class
    #if (!OPCUA_EXCLUDE_CoupledAxesState)
    /// <summary>
    /// Stores an instance of the CoupledAxesType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CoupledAxesState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CoupledAxesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.CoupledAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAENvdXBsZWRBeGVzVHlwZUluc3RhbmNlAQG/GwEBvxsADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DirectionState Class
    #if (!OPCUA_EXCLUDE_DirectionState)
    /// <summary>
    /// Stores an instance of the DirectionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectionState : MTEventDataItemState<DirectionTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DirectionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.DirectionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.DirectionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAERpcmVjdGlvblR5cGVJbnN0YW5jZQEBxBsBAcQbAQEaJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DoorStateState Class
    #if (!OPCUA_EXCLUDE_DoorStateState)
    /// <summary>
    /// Stores an instance of the DoorStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DoorStateState : MTEventDataItemState<DoorStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DoorStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.DoorStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.DoorStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAERvb3JTdGF0ZVR5cGVJbnN0YW5jZQEByRsBAckbAQEcJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region EmergencyStopState Class
    #if (!OPCUA_EXCLUDE_EmergencyStopState)
    /// <summary>
    /// Stores an instance of the EmergencyStopType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EmergencyStopState : MTEventDataItemState<EmergencyStopTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EmergencyStopState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.EmergencyStopType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.EmergencyStopTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAEVtZXJnZW5jeVN0b3BUeXBlSW5zdGFuY2UBAc4bAQHOGwEBISf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ExecutionState Class
    #if (!OPCUA_EXCLUDE_ExecutionState)
    /// <summary>
    /// Stores an instance of the ExecutionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExecutionState : MTEventDataItemState<ExecutionTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ExecutionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ExecutionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ExecutionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAEV4ZWN1dGlvblR5cGVJbnN0YW5jZQEB0xsBAdMbAQEkJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LineState Class
    #if (!OPCUA_EXCLUDE_LineState)
    /// <summary>
    /// Stores an instance of the LineType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LineState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LineType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAExpbmVUeXBlSW5zdGFuY2UBAdgbAQHYGwAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MessageState Class
    #if (!OPCUA_EXCLUDE_MessageState)
    /// <summary>
    /// Stores an instance of the MessageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MessageState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MessageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MessageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAE1lc3NhZ2VUeXBlSW5zdGFuY2UBAd0bAQHdGwAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PalletIdState Class
    #if (!OPCUA_EXCLUDE_PalletIdState)
    /// <summary>
    /// Stores an instance of the PalletIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PalletIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PalletIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PalletIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFBhbGxldElkVHlwZUluc3RhbmNlAQHiGwEB4hsADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PartCountState Class
    #if (!OPCUA_EXCLUDE_PartCountState)
    /// <summary>
    /// Stores an instance of the PartCountType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PartCountState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PartCountState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PartCountType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAFBhcnRDb3VudFR5cGVJbnN0YW5jZQEB5xsBAecbAAX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PartIdState Class
    #if (!OPCUA_EXCLUDE_PartIdState)
    /// <summary>
    /// Stores an instance of the PartIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PartIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PartIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PartIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EgAAAFBhcnRJZFR5cGVJbnN0YW5jZQEB7BsBAewbAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PathModeState Class
    #if (!OPCUA_EXCLUDE_PathModeState)
    /// <summary>
    /// Stores an instance of the PathModeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathModeState : MTEventDataItemState<PathModeTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PathModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PathModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.PathModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFBhdGhNb2RlVHlwZUluc3RhbmNlAQHxGwEB8RsBAUgn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PowerStateState Class
    #if (!OPCUA_EXCLUDE_PowerStateState)
    /// <summary>
    /// Stores an instance of the PowerStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerStateState : MTEventDataItemState<PowerStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PowerStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PowerStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.PowerStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFBvd2VyU3RhdGVUeXBlSW5zdGFuY2UBAfYbAQH2GwEBSif/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ProgramState Class
    #if (!OPCUA_EXCLUDE_ProgramState)
    /// <summary>
    /// Stores an instance of the ProgramType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ProgramType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAFByb2dyYW1UeXBlSW5zdGFuY2UBAfsbAQH7GwAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region RotaryModeState Class
    #if (!OPCUA_EXCLUDE_RotaryModeState)
    /// <summary>
    /// Stores an instance of the RotaryModeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RotaryModeState : MTEventDataItemState<RotaryModeTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RotaryModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.RotaryModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.RotaryModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFJvdGFyeU1vZGVUeXBlSW5zdGFuY2UBAQAcAQEAHAEBUSf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ToolAssetIdState Class
    #if (!OPCUA_EXCLUDE_ToolAssetIdState)
    /// <summary>
    /// Stores an instance of the ToolAssetIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolAssetIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ToolAssetIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ToolAssetIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAFRvb2xBc3NldElkVHlwZUluc3RhbmNlAQEFHAEBBRwADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ToolNumberState Class
    #if (!OPCUA_EXCLUDE_ToolNumberState)
    /// <summary>
    /// Stores an instance of the ToolNumberType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolNumberState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ToolNumberState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ToolNumberType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFRvb2xOdW1iZXJUeXBlSW5zdGFuY2UBAQocAQEKHAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WorkHoldingIdState Class
    #if (!OPCUA_EXCLUDE_WorkHoldingIdState)
    /// <summary>
    /// Stores an instance of the WorkHoldingIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WorkHoldingIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WorkHoldingIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.WorkHoldingIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAFdvcmtIb2xkaW5nSWRUeXBlSW5zdGFuY2UBAQ8cAQEPHAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MTConditionState Class
    #if (!OPCUA_EXCLUDE_MTConditionState)
    /// <summary>
    /// Stores an instance of the MTConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTConditionState : ConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LimitState != null)
            {
                LimitState.Initialize(context, LimitState_InitializationString);
            }

            if (NativeCode != null)
            {
                NativeCode.Initialize(context, NativeCode_InitializationString);
            }

            if (NativeSeverity != null)
            {
                NativeSeverity.Initialize(context, NativeSeverity_InitializationString);
            }
        }

        #region Initialization String
        private const string LimitState_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "CgAAAExpbWl0U3RhdGUBAUMcAC8BAGYkQxwAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3Rh" +
           "dGUBAUQcAC8BAMgKRBwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFFHAAuAERFHAAA" +
           "ABH/////AQH/////AAAAAA==";

        private const string NativeCode_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CgAAAE5hdGl2ZUNvZGUBAU8cAC4ARE8cAAAADP////8BAf////8AAAAA";

        private const string NativeSeverity_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAE5hdGl2ZVNldmVyaXR5AQFQHAAuAERQHAAAAAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAE1UQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEUHAEBFBz/////GwAAADVgiQoCAAAAAAAHAAAARXZl" +
           "bnRJZAEBFRwDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQu" +
           "AC4ARBUcAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBARYcAwAAAAAiAAAA" +
           "VGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQWHAAAABH/////AQH/////AAAAADVg" +
           "iQoCAAAAAAAKAAAAU291cmNlTm9kZQEBFxwDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBEFxwAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBARgcAwAAAAApAAAA" +
           "QSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEGBwAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBARkcAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2NjdXJyZWQu" +
           "AC4ARBkcAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEaHAMAAAAA" +
           "PgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJseWluZyBz" +
           "eXN0ZW0uAC4ARBocAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGltZQEBGxwD" +
           "AAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZlbnQgb3Jp" +
           "Z2luYXRlZC4ALgBEGxwAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2FnZQEBHBwD" +
           "AAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARBwcAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBHRwDAAAAACEAAABJbmRpY2F0ZXMgaG93IHVy" +
           "Z2VudCBhbiBldmVudCBpcy4ALgBEHRwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAR4cAC4ARB4cAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAR8cAC4ARB8cAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQEgHAAuAEQgHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBASEc" +
           "AC4ARCEcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BASIcAC4ARCIcAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBASMcAC8BACMjIxwAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEkHAAuAEQkHAAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBLBwALwEAKiMsHAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQEtHAAuAEQtHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAS4cAC8BACojLhwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBLxwALgBELxwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "MBwALwEAKiMwHAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEx" +
           "HAAuAEQxHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBATIcAC4A" +
           "RDIcAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEzHAAvAQBEIzMcAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBATQcAC8BAEMjNBwAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBATUcAC8BAEUjNRwAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE2HAAuAEQ2HAAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBORwALwA/ORwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQE6HAAvAQAjIzocAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBOxwALgBEOxwA" +
           "AAAB/////wEB/////wAAAAAEYIAKAQAAAAEACgAAAExpbWl0U3RhdGUBAUMcAC8BAGYkQxwAAP////8B" +
           "AAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAUQcAC8BAMgKRBwAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQFFHAAuAERFHAAAABH/////AQH/////AAAAABVgiQoCAAAAAQAKAAAATmF0" +
           "aXZlQ29kZQEBTxwALgBETxwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAE5hdGl2ZVNldmVy" +
           "aXR5AQFQHAAuAERQHAAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MTCurrentState Variable.
        /// </summary>
        public BaseDataVariableState<string> MTCurrentState
        {
            get
            {
                return m_mTCurrentState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mTCurrentState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mTCurrentState = value;
            }
        }

        /// <summary>
        /// A description for the ActiveState Variable.
        /// </summary>
        public TwoStateVariableState ActiveState
        {
            get
            {
                return m_activeState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_activeState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeState = value;
            }
        }

        /// <summary>
        /// A description for the LimitState Object.
        /// </summary>
        public ExclusiveLimitStateMachineState LimitState
        {
            get
            {
                return m_limitState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_limitState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_limitState = value;
            }
        }

        /// <summary>
        /// A description for the NativeCode Property.
        /// </summary>
        public PropertyState<string> NativeCode
        {
            get
            {
                return m_nativeCode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeCode = value;
            }
        }

        /// <summary>
        /// A description for the NativeSeverity Property.
        /// </summary>
        public PropertyState<string> NativeSeverity
        {
            get
            {
                return m_nativeSeverity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeSeverity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeSeverity = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mTCurrentState != null)
            {
                children.Add(m_mTCurrentState);
            }

            if (m_activeState != null)
            {
                children.Add(m_activeState);
            }

            if (m_limitState != null)
            {
                children.Add(m_limitState);
            }

            if (m_nativeCode != null)
            {
                children.Add(m_nativeCode);
            }

            if (m_nativeSeverity != null)
            {
                children.Add(m_nativeSeverity);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.MTCurrentState:
                {
                    if (createOrReplace)
                    {
                        if (MTCurrentState == null)
                        {
                            if (replacement == null)
                            {
                                MTCurrentState = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MTCurrentState = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MTCurrentState;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ActiveState:
                {
                    if (createOrReplace)
                    {
                        if (ActiveState == null)
                        {
                            if (replacement == null)
                            {
                                ActiveState = new TwoStateVariableState(this);
                            }
                            else
                            {
                                ActiveState = (TwoStateVariableState)replacement;
                            }
                        }
                    }

                    instance = ActiveState;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LimitState:
                {
                    if (createOrReplace)
                    {
                        if (LimitState == null)
                        {
                            if (replacement == null)
                            {
                                LimitState = new ExclusiveLimitStateMachineState(this);
                            }
                            else
                            {
                                LimitState = (ExclusiveLimitStateMachineState)replacement;
                            }
                        }
                    }

                    instance = LimitState;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeCode:
                {
                    if (createOrReplace)
                    {
                        if (NativeCode == null)
                        {
                            if (replacement == null)
                            {
                                NativeCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                NativeCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NativeCode;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeSeverity:
                {
                    if (createOrReplace)
                    {
                        if (NativeSeverity == null)
                        {
                            if (replacement == null)
                            {
                                NativeSeverity = new PropertyState<string>(this);
                            }
                            else
                            {
                                NativeSeverity = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NativeSeverity;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_mTCurrentState;
        private TwoStateVariableState m_activeState;
        private ExclusiveLimitStateMachineState m_limitState;
        private PropertyState<string> m_nativeCode;
        private PropertyState<string> m_nativeSeverity;
        #endregion
    }
    #endif
    #endregion

    #region AccelerationConditionState Class
    #if (!OPCUA_EXCLUDE_AccelerationConditionState)
    /// <summary>
    /// Stores an instance of the AccelerationConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccelerationConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccelerationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AccelerationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAEFjY2VsZXJhdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBURwBAVEc/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAVIcAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAERSHAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQFT" +
           "HAMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEUxwAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAVQcAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARFQcAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFV" +
           "HAMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARFUcAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQFWHAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAERWHAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBVxwDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAERXHAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAVgcAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARFgcAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAVkcAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAERZ" +
           "HAAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAVocAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARFocAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQFbHAAuAERbHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQFcHAAuAERcHAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBXRwALgBEXRwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQFeHAAuAEReHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFfHAAu" +
           "AERfHAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFgHAAvAQAjI2Ac" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBYRwALgBEYRwAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAWkcAC8BACojaRwAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBahwALgBEahwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQFrHAAvAQAqI2scAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAWwcAC4ARGwcAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAW0cAC8BACojbRwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBbhwALgBEbhwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQFvHAAuAERvHAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBcBwALwEA" +
           "RCNwHAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFxHAAvAQBDI3EcAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFyHAAvAQBFI3IcAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBcxwALgBEcxwAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAXYcAC8AP3YcAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBdxwALwEAIyN3HAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AXgcAC4ARHgcAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Accumulated_TimeConditionState Class
    #if (!OPCUA_EXCLUDE_Accumulated_TimeConditionState)
    /// <summary>
    /// Stores an instance of the Accumulated_TimeConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Accumulated_TimeConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Accumulated_TimeConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Accumulated_TimeConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JQAAAEFjY3VtdWxhdGVkX1RpbWVDb25kaXRpb25UeXBlSW5zdGFuY2UBAY4cAQGOHP////8YAAAANWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQGPHAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIg" +
           "Zm9yIHRoZSBldmVudC4ALgBEjxwAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBkBwDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARJAcAAAAEf//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGRHAMAAAAAGAAAAFRoZSBzb3VyY2Ug" +
           "b2YgdGhlIGV2ZW50LgAuAESRHAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEBkhwDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESS" +
           "HAAAAAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBkxwDAAAAABgAAABXaGVuIHRoZSBl" +
           "dmVudCBvY2N1cnJlZC4ALgBEkxwAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2" +
           "ZVRpbWUBAZQcAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRo" +
           "ZSB1bmRlcmx5aW5nIHN5c3RlbS4ALgBElBwAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAA" +
           "TG9jYWxUaW1lAQGVHAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJl" +
           "IHRoZSBldmVudCBvcmlnaW5hdGVkLgAuAESVHAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcA" +
           "AABNZXNzYWdlAQGWHAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4A" +
           "LgBElhwAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGXHAMAAAAAIQAAAElu" +
           "ZGljYXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAESXHAAAAAX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBmBwALgBEmBwAAAAR/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBmRwALgBEmRwAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADQAAAENvbmRpdGlvbk5hbWUBAZocAC4ARJocAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABCcmFuY2hJZAEBmxwALgBEmxwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB" +
           "nBwALgBEnBwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBnRwALwEA" +
           "IyOdHAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZ4cAC4ARJ4cAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQGmHAAvAQAqI6YcAAAAE/////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAaccAC4ARKccAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADAAAAExhc3RTZXZlcml0eQEBqBwALwEAKiOoHAAAAAX/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQGpHAAuAESpHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABDb21tZW50AQGqHAAvAQAqI6ocAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAascAC4ARKscAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVu" +
           "dFVzZXJJZAEBrBwALgBErBwAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAa0c" +
           "AC8BAEQjrRwAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBrhwALwEAQyOu" +
           "HAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBrxwALwEARSOvHAAA" +
           "AQEBAAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbAcAC4ARLAcAACW" +
           "AgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQA" +
           "AABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADgAAAE1UQ3VycmVudFN0YXRlAQGzHAAvAD+zHAAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AQALAAAAQWN0aXZlU3RhdGUBAbQcAC8BACMjtBwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQG1HAAuAES1HAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AmperageConditionState Class
    #if (!OPCUA_EXCLUDE_AmperageConditionState)
    /// <summary>
    /// Stores an instance of the AmperageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AmperageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AmperageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AmperageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAEFtcGVyYWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHLHAEByxz/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBzBwDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARMwcAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAc0cAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETNHAAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBzhwDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEzhwAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAc8cAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEzxwAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAdAcAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARNAcAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHR" +
           "HAMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARNEcAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEB0hwDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBE0hwAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEB0xwDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARNMcAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEB1BwDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBE1BwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAdUcAC4ARNUcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAdYcAC4ARNYcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQHXHAAuAETXHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAdgcAC4ARNgcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAdkcAC4ARNkc" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAdocAC8BACMj2hwAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHbHAAuAETbHAAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEB4xwALwEAKiPjHAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQHkHAAuAETkHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAeUcAC8BACoj5RwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEB5hwALgBE5hwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEB5xwALwEAKiPnHAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHoHAAuAEToHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AekcAC4AROkcAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHqHAAvAQBEI+oc" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAescAC8BAEMj6xwAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAewcAC8BAEUj7BwAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHtHAAuAETtHAAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEB8BwALwA/8BwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQHxHAAvAQAjI/EcAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB8hwA" +
           "LgBE8hwAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AngleConditionState Class
    #if (!OPCUA_EXCLUDE_AngleConditionState)
    /// <summary>
    /// Stores an instance of the AngleConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngleConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngleConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AngleConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GgAAAEFuZ2xlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEIHQEBCB3/////GAAAADVgiQoCAAAAAAAHAAAA" +
           "RXZlbnRJZAEBCR0DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQuAC4ARAkdAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAQodAwAAAAAi" +
           "AAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQKHQAAABH/////AQH/////AAAA" +
           "ADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBCx0DAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBldmVu" +
           "dC4ALgBECx0AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQwdAwAAAAAp" +
           "AAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEDB0AAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAQ0dAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2NjdXJy" +
           "ZWQuAC4ARA0dAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEOHQMA" +
           "AAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJseWlu" +
           "ZyBzeXN0ZW0uAC4ARA4dAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGltZQEB" +
           "Dx0DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZlbnQg" +
           "b3JpZ2luYXRlZC4ALgBEDx0AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2FnZQEB" +
           "EB0DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARBAdAAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBER0DAAAAACEAAABJbmRpY2F0ZXMgaG93" +
           "IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEER0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENv" +
           "bmRpdGlvbkNsYXNzSWQBARIdAC4ARBIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25k" +
           "aXRpb25DbGFzc05hbWUBARMdAC4ARBMdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25k" +
           "aXRpb25OYW1lAQEUHQAuAEQUHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQB" +
           "ARUdAC4ARBUdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BARYdAC4ARBYdAAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBARcdAC8BACMjFx0AAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEYHQAuAEQYHQAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAUXVhbGl0eQEBIB0ALwEAKiMgHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQEhHQAuAEQhHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABM" +
           "YXN0U2V2ZXJpdHkBASIdAC8BACojIh0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBIx0ALgBEIx0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVu" +
           "dAEBJB0ALwEAKiMkHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQElHQAuAEQlHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBASYd" +
           "AC4ARCYdAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEnHQAvAQBEIycdAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBASgdAC8BAEMjKB0AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBASkdAC8BAEUjKR0AAAEBAQAAAAEA+QsA" +
           "AQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEqHQAuAEQqHQAAlgIAAAABACoBAUYA" +
           "AAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1l" +
           "bnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBLR0ALwA/LR0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQEuHQAvAQAjIy4dAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBLx0ALgBE" +
           "Lx0AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Angular-AccelerationConditionState Class
    #if (!OPCUA_EXCLUDE_Angular-AccelerationConditionState)
    /// <summary>
    /// Stores an instance of the Angular-AccelerationConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Angular-AccelerationConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Angular-AccelerationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Angular-AccelerationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "KQAAAEFuZ3VsYXItQWNjZWxlcmF0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFFHQEBRR3/////GAAA" +
           "ADVgiQoCAAAAAAAHAAAARXZlbnRJZAEBRh0DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlm" +
           "aWVyIGZvciB0aGUgZXZlbnQuAC4AREYdAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAUcdAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAERHHQAA" +
           "ABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBSB0DAAAAABgAAABUaGUgc291" +
           "cmNlIG9mIHRoZSBldmVudC4ALgBESB0AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5hbWUBAUkdAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBESR0AAAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAUodAwAAAAAYAAAAV2hlbiB0" +
           "aGUgZXZlbnQgb2NjdXJyZWQuAC4AREodAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJl" +
           "Y2VpdmVUaW1lAQFLHQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJv" +
           "bSB0aGUgdW5kZXJseWluZyBzeXN0ZW0uAC4AREsdAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAA" +
           "CQAAAExvY2FsVGltZQEBTB0DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3" +
           "aGVyZSB0aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBETB0AAAEA0CL/////AQH/////AAAAADVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBTR0DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZl" +
           "bnQuAC4ARE0dAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBTh0DAAAAACEA" +
           "AABJbmRpY2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBETh0AAAAF/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAU8dAC4ARE8dAAAAEf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBAVAdAC4ARFAdAAAAFf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQFRHQAuAERRHQAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAQnJhbmNoSWQBAVIdAC4ARFIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRh" +
           "aW4BAVMdAC4ARFMdAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVQd" +
           "AC8BACMjVB0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVHQAuAERVHQAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBXR0ALwEAKiNdHQAAABP/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFeHQAuAEReHQAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAV8dAC8BACojXx0AAAAF/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBYB0ALgBEYB0AAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAQ29tbWVudAEBYR0ALwEAKiNhHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQFiHQAuAERiHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABD" +
           "bGllbnRVc2VySWQBAWMdAC4ARGMdAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxl" +
           "AQFkHQAvAQBEI2QdAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWUdAC8B" +
           "AEMjZR0AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWYdAC8BAEUj" +
           "Zh0AAAEBAQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFnHQAuAERn" +
           "HQAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmll" +
           "ciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAA" +
           "AAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAA" +
           "FWCJCgIAAAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBah0ALwA/ah0AAAAM/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAEFjdGl2ZVN0YXRlAQFrHQAvAQAjI2sdAAAAFf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBbB0ALgBEbB0AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Angular_VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_Angular_VelocityConditionState)
    /// <summary>
    /// Stores an instance of the Angular_VelocityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Angular_VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Angular_VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Angular_VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JQAAAEFuZ3VsYXJfVmVsb2NpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBAYIdAQGCHf////8YAAAANWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQGDHQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIg" +
           "Zm9yIHRoZSBldmVudC4ALgBEgx0AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBhB0DAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARIQdAAAAEf//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGFHQMAAAAAGAAAAFRoZSBzb3VyY2Ug" +
           "b2YgdGhlIGV2ZW50LgAuAESFHQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEBhh0DAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESG" +
           "HQAAAAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBhx0DAAAAABgAAABXaGVuIHRoZSBl" +
           "dmVudCBvY2N1cnJlZC4ALgBEhx0AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2" +
           "ZVRpbWUBAYgdAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRo" +
           "ZSB1bmRlcmx5aW5nIHN5c3RlbS4ALgBEiB0AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAA" +
           "TG9jYWxUaW1lAQGJHQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJl" +
           "IHRoZSBldmVudCBvcmlnaW5hdGVkLgAuAESJHQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcA" +
           "AABNZXNzYWdlAQGKHQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4A" +
           "LgBEih0AAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGLHQMAAAAAIQAAAElu" +
           "ZGljYXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAESLHQAAAAX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBjB0ALgBEjB0AAAAR/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBjR0ALgBEjR0AAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADQAAAENvbmRpdGlvbk5hbWUBAY4dAC4ARI4dAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABCcmFuY2hJZAEBjx0ALgBEjx0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB" +
           "kB0ALgBEkB0AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBkR0ALwEA" +
           "IyORHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZIdAC4ARJIdAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQGaHQAvAQAqI5odAAAAE/////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAZsdAC4ARJsdAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADAAAAExhc3RTZXZlcml0eQEBnB0ALwEAKiOcHQAAAAX/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQGdHQAuAESdHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABDb21tZW50AQGeHQAvAQAqI54dAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAZ8dAC4ARJ8dAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVu" +
           "dFVzZXJJZAEBoB0ALgBEoB0AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAaEd" +
           "AC8BAEQjoR0AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBoh0ALwEAQyOi" +
           "HQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBox0ALwEARSOjHQAA" +
           "AQEBAAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaQdAC4ARKQdAACW" +
           "AgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQA" +
           "AABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADgAAAE1UQ3VycmVudFN0YXRlAQGnHQAvAD+nHQAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AQALAAAAQWN0aXZlU3RhdGUBAagdAC8BACMjqB0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQGpHQAuAESpHQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CommunicationsConditionState Class
    #if (!OPCUA_EXCLUDE_CommunicationsConditionState)
    /// <summary>
    /// Stores an instance of the CommunicationsConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationsConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommunicationsConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CommunicationsConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IwAAAENvbW11bmljYXRpb25zQ29uZGl0aW9uVHlwZUluc3RhbmNlAQG/HQEBvx3/////GAAAADVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBwB0DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQuAC4ARMAdAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AcEdAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETBHQAAABH/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBwh0DAAAAABgAAABUaGUgc291cmNlIG9m" +
           "IHRoZSBldmVudC4ALgBEwh0AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUB" +
           "AcMdAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEwx0A" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAcQdAwAAAAAYAAAAV2hlbiB0aGUgZXZl" +
           "bnQgb2NjdXJyZWQuAC4ARMQdAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVU" +
           "aW1lAQHFHQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUg" +
           "dW5kZXJseWluZyBzeXN0ZW0uAC4ARMUdAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExv" +
           "Y2FsVGltZQEBxh0DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0" +
           "aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBExh0AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAA" +
           "TWVzc2FnZQEBxx0DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4A" +
           "RMcdAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEByB0DAAAAACEAAABJbmRp" +
           "Y2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEyB0AAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAckdAC4ARMkdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABIAAABDb25kaXRpb25DbGFzc05hbWUBAcodAC4ARModAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AA0AAABDb25kaXRpb25OYW1lAQHLHQAuAETLHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "QnJhbmNoSWQBAcwdAC4ARMwdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAc0d" +
           "AC4ARM0dAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAc4dAC8BACMj" +
           "zh0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHPHQAuAETPHQAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEB1x0ALwEAKiPXHQAAABP/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHYHQAuAETYHQAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAwAAABMYXN0U2V2ZXJpdHkBAdkdAC8BACoj2R0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEB2h0ALgBE2h0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAQ29tbWVudAEB2x0ALwEAKiPbHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQHcHQAuAETcHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRV" +
           "c2VySWQBAd0dAC4ARN0dAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHeHQAv" +
           "AQBEI94dAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAd8dAC8BAEMj3x0A" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAeAdAC8BAEUj4B0AAAEB" +
           "AQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHhHQAuAEThHQAAlgIA" +
           "AAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAA" +
           "VGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIA" +
           "AAABAA4AAABNVEN1cnJlbnRTdGF0ZQEB5B0ALwA/5B0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAEFjdGl2ZVN0YXRlAQHlHQAvAQAjI+UdAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEB5h0ALgBE5h0AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConcentrationConditionState Class
    #if (!OPCUA_EXCLUDE_ConcentrationConditionState)
    /// <summary>
    /// Stores an instance of the ConcentrationConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConcentrationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ConcentrationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAENvbmNlbnRyYXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAfwdAQH8Hf////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQH9HQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBE/R0AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "/h0DAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARP4dAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQH/HQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAET/HQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "AB4DAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQAHgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBAR4DAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBEAR4AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAQIeAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBEAh4AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQEDHgMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAEQDHgAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQEEHgMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "BB4AAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEFHgMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEQFHgAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBBh4ALgBEBh4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBBx4ALgBEBx4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAQgeAC4ARAgeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEBCR4ALgBECR4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBCh4A" +
           "LgBECh4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBCx4ALwEAIyML" +
           "HgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQweAC4ARAweAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQEUHgAvAQAqIxQeAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABARUeAC4ARBUeAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBFh4ALwEAKiMWHgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQEXHgAuAEQXHgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQEYHgAvAQAqIxgeAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABARkeAC4ARBkeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBGh4ALgBEGh4AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARseAC8B" +
           "AEQjGx4AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBHB4ALwEAQyMcHgAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBHR4ALwEARSMdHgAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAR4eAC4ARB4eAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQEhHgAvAD8hHgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBASIeAC8BACMjIh4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQEjHgAuAEQjHgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConductivityConditionState Class
    #if (!OPCUA_EXCLUDE_ConductivityConditionState)
    /// <summary>
    /// Stores an instance of the ConductivityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConductivityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConductivityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ConductivityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAENvbmR1Y3Rpdml0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBOR4BATke/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAToeAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAEQ6HgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQE7" +
           "HgMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEOx4AAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBATweAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARDweAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQE9" +
           "HgMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARD0eAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQE+HgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAEQ+HgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBPx4DAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAEQ/HgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAUAeAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4AREAeAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAUEeAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAERB" +
           "HgAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAUIeAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4AREIeAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQFDHgAuAERDHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQFEHgAuAEREHgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBRR4ALgBERR4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQFGHgAuAERGHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFHHgAu" +
           "AERHHgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFIHgAvAQAjI0ge" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSR4ALgBESR4AAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAVEeAC8BACojUR4AAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBUh4ALgBEUh4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQFTHgAvAQAqI1MeAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAVQeAC4ARFQeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAVUeAC8BACojVR4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBVh4ALgBEVh4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQFXHgAuAERXHgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBWB4ALwEA" +
           "RCNYHgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFZHgAvAQBDI1keAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFaHgAvAQBFI1oeAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWx4ALgBEWx4AAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAV4eAC8AP14eAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBXx4ALwEAIyNfHgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AWAeAC4ARGAeAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Data_RangeConditionState Class
    #if (!OPCUA_EXCLUDE_Data_RangeConditionState)
    /// <summary>
    /// Stores an instance of the Data_RangeConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Data_RangeConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Data_RangeConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Data_RangeConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAERhdGFfUmFuZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAXYeAQF2Hv////8YAAAANWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQF3HgMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudC4ALgBEdx4AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBeB4D" +
           "AAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARHgeAAAAEf////8BAf//" +
           "//8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQF5HgMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhl" +
           "IGV2ZW50LgAuAER5HgAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBeh4D" +
           "AAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAER6HgAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBex4DAAAAABgAAABXaGVuIHRoZSBldmVudCBv" +
           "Y2N1cnJlZC4ALgBEex4AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUB" +
           "AXweAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRl" +
           "cmx5aW5nIHN5c3RlbS4ALgBEfB4AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxU" +
           "aW1lAQF9HgMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBl" +
           "dmVudCBvcmlnaW5hdGVkLgAuAER9HgAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNz" +
           "YWdlAQF+HgMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEfh4A" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQF/HgMAAAAAIQAAAEluZGljYXRl" +
           "cyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAER/HgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBgB4ALgBEgB4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBgR4ALgBEgR4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAYIeAC4ARIIeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBgx4ALgBEgx4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBhB4ALgBE" +
           "hB4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBhR4ALwEAIyOFHgAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAYYeAC4ARIYeAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQGOHgAvAQAqI44eAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAY8eAC4ARI8eAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBkB4ALwEAKiOQHgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGRHgAuAESRHgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQGSHgAvAQAqI5IeAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAZMeAC4ARJMeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBlB4ALgBElB4AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAZUeAC8BAEQj" +
           "lR4AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBlh4ALwEAQyOWHgAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBlx4ALwEARSOXHgAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZgeAC4ARJgeAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGbHgAvAD+bHgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAZweAC8BACMjnB4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGd" +
           "HgAuAESdHgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DirectionConditionState Class
    #if (!OPCUA_EXCLUDE_DirectionConditionState)
    /// <summary>
    /// Stores an instance of the DirectionConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectionConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DirectionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.DirectionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HgAAAERpcmVjdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBsx4BAbMe/////xgAAAA1YIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAbQeAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50LgAuAES0HgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQG1HgMA" +
           "AAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEtR4AAAAR/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAbYeAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUg" +
           "ZXZlbnQuAC4ARLYeAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQG3HgMA" +
           "AAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARLceAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQG4HgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9j" +
           "Y3VycmVkLgAuAES4HgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "uR4DAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVy" +
           "bHlpbmcgc3lzdGVtLgAuAES5HgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRp" +
           "bWUBAboeAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2" +
           "ZW50IG9yaWdpbmF0ZWQuAC4ARLoeAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3Nh" +
           "Z2UBAbseAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAES7HgAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAbweAwAAAAAhAAAASW5kaWNhdGVz" +
           "IGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARLweAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABDb25kaXRpb25DbGFzc0lkAQG9HgAuAES9HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAA" +
           "Q29uZGl0aW9uQ2xhc3NOYW1lAQG+HgAuAES+HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "Q29uZGl0aW9uTmFtZQEBvx4ALgBEvx4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5j" +
           "aElkAQHAHgAuAETAHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHBHgAuAETB" +
           "HgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHCHgAvAQAjI8IeAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBwx4ALgBEwx4AAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBAcseAC8BACojyx4AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBzB4ALgBEzB4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQHNHgAvAQAqI80eAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAc4eAC4ARM4eAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBAc8eAC8BACojzx4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEB0B4ALgBE0B4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQHRHgAuAETRHgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0h4ALwEARCPS" +
           "HgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHTHgAvAQBDI9MeAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHUHgAvAQBFI9QeAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB1R4ALgBE1R4AAJYCAAAAAQAq" +
           "AQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBj" +
           "b21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAdgeAC8AP9geAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEB2R4ALwEAIyPZHgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAdoe" +
           "AC4ARNoeAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DisplacementConditionState Class
    #if (!OPCUA_EXCLUDE_DisplacementConditionState)
    /// <summary>
    /// Stores an instance of the DisplacementConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisplacementConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DisplacementConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.DisplacementConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAERpc3BsYWNlbWVudENvbmRpdGlvblR5cGVJbnN0YW5jZQEB8B4BAfAe/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAfEeAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAETxHgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHy" +
           "HgMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBE8h4AAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAfMeAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARPMeAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQH0" +
           "HgMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARPQeAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQH1HgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAET1HgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEB9h4DAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAET2HgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAfceAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARPceAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAfgeAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAET4" +
           "HgAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAfkeAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARPkeAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQH6HgAuAET6HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQH7HgAuAET7HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEB/B4ALgBE/B4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQH9HgAuAET9HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH+HgAu" +
           "AET+HgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQH/HgAvAQAjI/8e" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAB8ALgBEAB8AAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAQgfAC8BACojCB8AAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBCR8ALgBECR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQEKHwAvAQAqIwofAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAQsfAC4ARAsfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAQwfAC8BACojDB8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBDR8ALgBEDR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQEOHwAuAEQOHwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBDx8ALwEA" +
           "RCMPHwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEQHwAvAQBDIxAfAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQERHwAvAQBFIxEfAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEh8ALgBEEh8AAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBARUfAC8APxUfAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBFh8ALwEAIyMWHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "ARcfAC4ARBcfAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Electrical_EnergyConditionState Class
    #if (!OPCUA_EXCLUDE_Electrical_EnergyConditionState)
    /// <summary>
    /// Stores an instance of the Electrical_EnergyConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Electrical_EnergyConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Electrical_EnergyConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Electrical_EnergyConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JgAAAEVsZWN0cmljYWxfRW5lcmd5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQEtHwEBLR//////GAAAADVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBLh8DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVy" +
           "IGZvciB0aGUgZXZlbnQuAC4ARC4fAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAS8fAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQvHwAAABH/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBMB8DAAAAABgAAABUaGUgc291cmNl" +
           "IG9mIHRoZSBldmVudC4ALgBEMB8AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5h" +
           "bWUBATEfAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBE" +
           "MR8AAAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBATIfAwAAAAAYAAAAV2hlbiB0aGUg" +
           "ZXZlbnQgb2NjdXJyZWQuAC4ARDIfAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2Vp" +
           "dmVUaW1lAQEzHwMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0" +
           "aGUgdW5kZXJseWluZyBzeXN0ZW0uAC4ARDMfAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAA" +
           "AExvY2FsVGltZQEBNB8DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVy" +
           "ZSB0aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBENB8AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAH" +
           "AAAATWVzc2FnZQEBNR8DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQu" +
           "AC4ARDUfAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBNh8DAAAAACEAAABJ" +
           "bmRpY2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBENh8AAAAF/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBATcfAC4ARDcfAAAAEf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBATgfAC4ARDgfAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAA0AAABDb25kaXRpb25OYW1lAQE5HwAuAEQ5HwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAQnJhbmNoSWQBATofAC4ARDofAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4B" +
           "ATsfAC4ARDsfAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATwfAC8B" +
           "ACMjPB8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE9HwAuAEQ9HwAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBRR8ALwEAKiNFHwAAABP/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFGHwAuAERGHwAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAUcfAC8BACojRx8AAAAF/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBSB8ALgBESB8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAQ29tbWVudAEBSR8ALwEAKiNJHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQFKHwAuAERKHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGll" +
           "bnRVc2VySWQBAUsfAC4AREsfAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFM" +
           "HwAvAQBEI0wfAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAU0fAC8BAEMj" +
           "TR8AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAU4fAC8BAEUjTh8A" +
           "AAEBAQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFPHwAuAERPHwAA" +
           "lgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBm" +
           "b3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAk" +
           "AAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJ" +
           "CgIAAAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBUh8ALwA/Uh8AAAAM/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAEFjdGl2ZVN0YXRlAQFTHwAvAQAjI1MfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIA" +
           "AABJZAEBVB8ALgBEVB8AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Fill_LevelConditionState Class
    #if (!OPCUA_EXCLUDE_Fill_LevelConditionState)
    /// <summary>
    /// Stores an instance of the Fill_LevelConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Fill_LevelConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Fill_LevelConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Fill_LevelConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAEZpbGxfTGV2ZWxDb25kaXRpb25UeXBlSW5zdGFuY2UBAWofAQFqH/////8YAAAANWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQFrHwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudC4ALgBEax8AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBbB8D" +
           "AAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARGwfAAAAEf////8BAf//" +
           "//8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFtHwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhl" +
           "IGV2ZW50LgAuAERtHwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBbh8D" +
           "AAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERuHwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBbx8DAAAAABgAAABXaGVuIHRoZSBldmVudCBv" +
           "Y2N1cnJlZC4ALgBEbx8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUB" +
           "AXAfAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRl" +
           "cmx5aW5nIHN5c3RlbS4ALgBEcB8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxU" +
           "aW1lAQFxHwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBl" +
           "dmVudCBvcmlnaW5hdGVkLgAuAERxHwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNz" +
           "YWdlAQFyHwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEch8A" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQFzHwMAAAAAIQAAAEluZGljYXRl" +
           "cyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAERzHwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBdB8ALgBEdB8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBdR8ALgBEdR8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAXYfAC4ARHYfAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBdx8ALgBEdx8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBeB8ALgBE" +
           "eB8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeR8ALwEAIyN5HwAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAXofAC4ARHofAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQGCHwAvAQAqI4IfAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAYMfAC4ARIMfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBhB8ALwEAKiOEHwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGFHwAuAESFHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQGGHwAvAQAqI4YfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAYcfAC4ARIcfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBiB8ALgBEiB8AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYkfAC8BAEQj" +
           "iR8AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBih8ALwEAQyOKHwAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBix8ALwEARSOLHwAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYwfAC4ARIwfAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGPHwAvAD+PHwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAZAfAC8BACMjkB8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGR" +
           "HwAuAESRHwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FlowConditionState Class
    #if (!OPCUA_EXCLUDE_FlowConditionState)
    /// <summary>
    /// Stores an instance of the FlowConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FlowConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.FlowConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAEZsb3dDb25kaXRpb25UeXBlSW5zdGFuY2UBAacfAQGnH/////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQGoHwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEqB8AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBqR8DAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARKkfAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGqHwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAESqHwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBqx8DAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESrHwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBrB8DAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBErB8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAa0fAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBErR8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQGu" +
           "HwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAESuHwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQGv" +
           "HwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBErx8AAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGwHwMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAESwHwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBsR8ALgBEsR8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBsh8ALgBEsh8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAbMfAC4ARLMfAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "tB8ALgBEtB8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBtR8ALgBEtR8AAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBth8ALwEAIyO2HwAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAbcfAC4ARLcfAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQG/HwAvAQAqI78fAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAcAfAC4ARMAfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBwR8ALwEAKiPBHwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQHCHwAuAETCHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQHDHwAvAQAqI8MfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AcQfAC4ARMQfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBxR8A" +
           "LgBExR8AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAcYfAC8BAEQjxh8AAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBxx8ALwEAQyPHHwAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEByB8ALwEARSPIHwAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAckfAC4ARMkfAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHMHwAvAD/MHwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAc0fAC8BACMjzR8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHOHwAuAETO" +
           "HwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FrequencyConditionState Class
    #if (!OPCUA_EXCLUDE_FrequencyConditionState)
    /// <summary>
    /// Stores an instance of the FrequencyConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FrequencyConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FrequencyConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.FrequencyConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HgAAAEZyZXF1ZW5jeUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB5B8BAeQf/////xgAAAA1YIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAeUfAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50LgAuAETlHwAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHmHwMA" +
           "AAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBE5h8AAAAR/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAecfAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUg" +
           "ZXZlbnQuAC4AROcfAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHoHwMA" +
           "AAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4AROgfAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQHpHwMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9j" +
           "Y3VycmVkLgAuAETpHwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "6h8DAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVy" +
           "bHlpbmcgc3lzdGVtLgAuAETqHwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRp" +
           "bWUBAesfAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2" +
           "ZW50IG9yaWdpbmF0ZWQuAC4AROsfAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3Nh" +
           "Z2UBAewfAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAETsHwAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAe0fAwAAAAAhAAAASW5kaWNhdGVz" +
           "IGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARO0fAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABDb25kaXRpb25DbGFzc0lkAQHuHwAuAETuHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAA" +
           "Q29uZGl0aW9uQ2xhc3NOYW1lAQHvHwAuAETvHwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "Q29uZGl0aW9uTmFtZQEB8B8ALgBE8B8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5j" +
           "aElkAQHxHwAuAETxHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHyHwAuAETy" +
           "HwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHzHwAvAQAjI/MfAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB9B8ALgBE9B8AAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBAfwfAC8BACoj/B8AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEB/R8ALgBE/R8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQH+HwAvAQAqI/4fAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAf8fAC4ARP8fAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBAQAgAC8BACojACAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBASAALgBEASAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQECIAAuAEQCIAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBAyAALwEARCMD" +
           "IAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEEIAAvAQBDIwQgAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEFIAAvAQBFIwUgAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBBiAALgBEBiAAAJYCAAAAAQAq" +
           "AQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBj" +
           "b21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAQkgAC8APwkgAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBCiAALwEAIyMKIAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQsg" +
           "AC4ARAsgAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region HardwareConditionState Class
    #if (!OPCUA_EXCLUDE_HardwareConditionState)
    /// <summary>
    /// Stores an instance of the HardwareConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HardwareConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public HardwareConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.HardwareConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAEhhcmR3YXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEhIAEBISD/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBIiADAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARCIgAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBASMgAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQjIAAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBJCADAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEJCAAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBASUgAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEJSAAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBASYgAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARCYgAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEn" +
           "IAMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARCcgAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBKCADAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBEKCAAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBKSADAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARCkgAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBKiADAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEKiAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBASsgAC4ARCsgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBASwgAC4ARCwgAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQEtIAAuAEQtIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAS4gAC4ARC4gAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAS8gAC4ARC8g" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATAgAC8BACMjMCAAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQExIAAuAEQxIAAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBOSAALwEAKiM5IAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQE6IAAuAEQ6IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBATsgAC8BACojOyAAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBPCAALgBEPCAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBPSAALwEAKiM9IAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQE+IAAuAEQ+IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AT8gAC4ARD8gAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFAIAAvAQBEI0Ag" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAUEgAC8BAEMjQSAAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAUIgAC8BAEUjQiAAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFDIAAuAERDIAAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBRiAALwA/RiAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQFHIAAvAQAjI0cgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSCAA" +
           "LgBESCAAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Linear_ForceConditionState Class
    #if (!OPCUA_EXCLUDE_Linear_ForceConditionState)
    /// <summary>
    /// Stores an instance of the Linear_ForceConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Linear_ForceConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Linear_ForceConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Linear_ForceConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAExpbmVhcl9Gb3JjZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBXiABAV4g/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAV8gAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAERfIAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQFg" +
           "IAMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEYCAAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAWEgAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARGEgAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFi" +
           "IAMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARGIgAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQFjIAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAERjIAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBZCADAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAERkIAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAWUgAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARGUgAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAWYgAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAERm" +
           "IAAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAWcgAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARGcgAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQFoIAAuAERoIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQFpIAAuAERpIAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBaiAALgBEaiAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQFrIAAuAERrIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFsIAAu" +
           "AERsIAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFtIAAvAQAjI20g" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBbiAALgBEbiAAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAXYgAC8BACojdiAAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBdyAALgBEdyAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQF4IAAvAQAqI3ggAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAXkgAC4ARHkgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAXogAC8BACojeiAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBeyAALgBEeyAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQF8IAAuAER8IAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBfSAALwEA" +
           "RCN9IAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQF+IAAvAQBDI34gAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQF/IAAvAQBFI38gAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBgCAALgBEgCAAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAYMgAC8AP4MgAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBhCAALwEAIyOEIAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AYUgAC4ARIUgAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadConditionState Class
    #if (!OPCUA_EXCLUDE_LoadConditionState)
    /// <summary>
    /// Stores an instance of the LoadConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LoadConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.LoadConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAExvYWRDb25kaXRpb25UeXBlSW5zdGFuY2UBAZsgAQGbIP////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQGcIAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEnCAAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBnSADAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARJ0gAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGeIAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAESeIAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBnyADAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESfIAAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBoCADAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBEoCAAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaEgAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBEoSAAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQGi" +
           "IAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAESiIAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQGj" +
           "IAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEoyAAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGkIAMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAESkIAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBpSAALgBEpSAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBpiAALgBEpiAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAacgAC4ARKcgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "qCAALgBEqCAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqSAALgBEqSAAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqiAALwEAIyOqIAAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAasgAC4ARKsgAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQGzIAAvAQAqI7MgAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAbQgAC4ARLQgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBtSAALwEAKiO1IAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQG2IAAuAES2IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQG3IAAvAQAqI7cgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AbggAC4ARLggAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBuSAA" +
           "LgBEuSAAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbogAC8BAEQjuiAAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBuyAALwEAQyO7IAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBvCAALwEARSO8IAAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAb0gAC4ARL0gAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHAIAAvAD/AIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAcEgAC8BACMjwSAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHCIAAuAETC" +
           "IAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Logic_ProgramConditionState Class
    #if (!OPCUA_EXCLUDE_Logic_ProgramConditionState)
    /// <summary>
    /// Stores an instance of the Logic_ProgramConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Logic_ProgramConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Logic_ProgramConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Logic_ProgramConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAExvZ2ljX1Byb2dyYW1Db25kaXRpb25UeXBlSW5zdGFuY2UBAdggAQHYIP////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHZIAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBE2SAAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "2iADAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARNogAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHbIAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAETbIAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "3CADAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETcIAAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEB3SADAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBE3SAAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAd4gAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBE3iAAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQHfIAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAETfIAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQHgIAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "4CAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQHhIAMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEThIAAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB4iAALgBE4iAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB4yAALgBE4yAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAeQgAC4AROQgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEB5SAALgBE5SAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB5iAA" +
           "LgBE5iAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB5yAALwEAIyPn" +
           "IAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAeggAC4AROggAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQHwIAAvAQAqI/AgAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAfEgAC4ARPEgAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEB8iAALwEAKiPyIAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQHzIAAuAETzIAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQH0IAAvAQAqI/QgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAfUgAC4ARPUgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEB9iAALgBE9iAAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAfcgAC8B" +
           "AEQj9yAAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB+CAALwEAQyP4IAAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB+SAALwEARSP5IAAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfogAC4ARPogAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQH9IAAvAD/9IAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAf4gAC8BACMj/iAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQH/IAAuAET/IAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MassConditionState Class
    #if (!OPCUA_EXCLUDE_MassConditionState)
    /// <summary>
    /// Stores an instance of the MassConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MassConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAE1hc3NDb25kaXRpb25UeXBlSW5zdGFuY2UBARUhAQEVIf////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQEWIQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEFiEAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBFyEDAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARBchAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEYIQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAEQYIQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBGSEDAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQZIQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBGiEDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBEGiEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBARshAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBEGyEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQEc" +
           "IQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAEQcIQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQEd" +
           "IQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEHSEAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEeIQMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAEQeIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBHyEALgBEHyEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBICEALgBEICEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBASEhAC4ARCEhAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "IiEALgBEIiEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBIyEALgBEIyEAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBJCEALwEAIyMkIQAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASUhAC4ARCUhAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQEtIQAvAQAqIy0hAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAS4hAC4ARC4hAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBLyEALwEAKiMvIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQEwIQAuAEQwIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQExIQAvAQAqIzEhAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "ATIhAC4ARDIhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBMyEA" +
           "LgBEMyEAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATQhAC8BAEQjNCEAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNSEALwEAQyM1IQAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNiEALwEARSM2IQAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATchAC4ARDchAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQE6IQAvAD86IQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBATshAC8BACMjOyEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE8IQAuAEQ8" +
           "IQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Motion_ProgramConditionState Class
    #if (!OPCUA_EXCLUDE_Motion_ProgramConditionState)
    /// <summary>
    /// Stores an instance of the Motion_ProgramConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Motion_ProgramConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Motion_ProgramConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Motion_ProgramConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IwAAAE1vdGlvbl9Qcm9ncmFtQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFSIQEBUiH/////GAAAADVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBUyEDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQuAC4ARFMhAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AVQhAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAERUIQAAABH/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBVSEDAAAAABgAAABUaGUgc291cmNlIG9m" +
           "IHRoZSBldmVudC4ALgBEVSEAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUB" +
           "AVYhAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEViEA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAVchAwAAAAAYAAAAV2hlbiB0aGUgZXZl" +
           "bnQgb2NjdXJyZWQuAC4ARFchAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVU" +
           "aW1lAQFYIQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUg" +
           "dW5kZXJseWluZyBzeXN0ZW0uAC4ARFghAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExv" +
           "Y2FsVGltZQEBWSEDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0" +
           "aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBEWSEAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAA" +
           "TWVzc2FnZQEBWiEDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4A" +
           "RFohAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBWyEDAAAAACEAAABJbmRp" +
           "Y2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEWyEAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAVwhAC4ARFwhAAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABIAAABDb25kaXRpb25DbGFzc05hbWUBAV0hAC4ARF0hAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AA0AAABDb25kaXRpb25OYW1lAQFeIQAuAEReIQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "QnJhbmNoSWQBAV8hAC4ARF8hAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAWAh" +
           "AC4ARGAhAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAWEhAC8BACMj" +
           "YSEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFiIQAuAERiIQAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBaiEALwEAKiNqIQAAABP/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFrIQAuAERrIQAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAwAAABMYXN0U2V2ZXJpdHkBAWwhAC8BACojbCEAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBbSEALgBEbSEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAQ29tbWVudAEBbiEALwEAKiNuIQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFvIQAuAERvIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRV" +
           "c2VySWQBAXAhAC4ARHAhAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFxIQAv" +
           "AQBEI3EhAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAXIhAC8BAEMjciEA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAXMhAC8BAEUjcyEAAAEB" +
           "AQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF0IQAuAER0IQAAlgIA" +
           "AAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAA" +
           "VGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIA" +
           "AAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBdyEALwA/dyEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAEFjdGl2ZVN0YXRlAQF4IQAvAQAjI3ghAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBeSEALgBEeSEAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Path_FeedrateConditionState Class
    #if (!OPCUA_EXCLUDE_Path_FeedrateConditionState)
    /// <summary>
    /// Stores an instance of the Path_FeedrateConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Path_FeedrateConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Path_FeedrateConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Path_FeedrateConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAFBhdGhfRmVlZHJhdGVDb25kaXRpb25UeXBlSW5zdGFuY2UBAY8hAQGPIf////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQGQIQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBEkCEAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "kSEDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARJEhAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGSIQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAESSIQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "kyEDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESTIQAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBlCEDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBElCEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAZUhAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBElSEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQGWIQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAESWIQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQGXIQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "lyEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGYIQMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAESYIQAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBmSEALgBEmSEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBmiEALgBEmiEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAZshAC4ARJshAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEBnCEALgBEnCEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBnSEA" +
           "LgBEnSEAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBniEALwEAIyOe" +
           "IQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZ8hAC4ARJ8hAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQGnIQAvAQAqI6chAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAaghAC4ARKghAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBqSEALwEAKiOpIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQGqIQAuAESqIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQGrIQAvAQAqI6shAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAawhAC4ARKwhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBrSEALgBErSEAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAa4hAC8B" +
           "AEQjriEAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBryEALwEAQyOvIQAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBsCEALwEARSOwIQAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbEhAC4ARLEhAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQG0IQAvAD+0IQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAbUhAC8BACMjtSEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQG2IQAuAES2IQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Path_PositionConditionState Class
    #if (!OPCUA_EXCLUDE_Path_PositionConditionState)
    /// <summary>
    /// Stores an instance of the Path_PositionConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Path_PositionConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Path_PositionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Path_PositionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAFBhdGhfUG9zaXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAcwhAQHMIf////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHNIQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBEzSEAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "ziEDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARM4hAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHPIQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAETPIQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "0CEDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETQIQAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEB0SEDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBE0SEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAdIhAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBE0iEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQHTIQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAETTIQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQHUIQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "1CEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQHVIQMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAETVIQAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB1iEALgBE1iEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB1yEALgBE1yEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAdghAC4ARNghAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEB2SEALgBE2SEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB2iEA" +
           "LgBE2iEAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB2yEALwEAIyPb" +
           "IQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAdwhAC4ARNwhAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQHkIQAvAQAqI+QhAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAeUhAC4AROUhAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEB5iEALwEAKiPmIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQHnIQAuAETnIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQHoIQAvAQAqI+ghAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAekhAC4AROkhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEB6iEALgBE6iEAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAeshAC8B" +
           "AEQj6yEAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB7CEALwEAQyPsIQAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB7SEALwEARSPtIQAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAe4hAC4ARO4hAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQHxIQAvAD/xIQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAfIhAC8BACMj8iEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQHzIQAuAETzIQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PHConditionState Class
    #if (!OPCUA_EXCLUDE_PHConditionState)
    /// <summary>
    /// Stores an instance of the PHConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PHConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PHConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.PHConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAFBIQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEJIgEBCSL/////GAAAADVgiQoCAAAAAAAHAAAARXZl" +
           "bnRJZAEBCiIDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQu" +
           "AC4ARAoiAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAQsiAwAAAAAiAAAA" +
           "VGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQLIgAAABH/////AQH/////AAAAADVg" +
           "iQoCAAAAAAAKAAAAU291cmNlTm9kZQEBDCIDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBEDCIAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQ0iAwAAAAApAAAA" +
           "QSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEDSIAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAQ4iAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2NjdXJyZWQu" +
           "AC4ARA4iAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEPIgMAAAAA" +
           "PgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJseWluZyBz" +
           "eXN0ZW0uAC4ARA8iAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGltZQEBECID" +
           "AAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZlbnQgb3Jp" +
           "Z2luYXRlZC4ALgBEECIAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2FnZQEBESID" +
           "AAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARBEiAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBEiIDAAAAACEAAABJbmRpY2F0ZXMgaG93IHVy" +
           "Z2VudCBhbiBldmVudCBpcy4ALgBEEiIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBARMiAC4ARBMiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBARQiAC4ARBQiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQEVIgAuAEQVIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBARYi" +
           "AC4ARBYiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BARciAC4ARBciAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBARgiAC8BACMjGCIAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEZIgAuAEQZIgAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBISIALwEAKiMhIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQEiIgAuAEQiIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBASMiAC8BACojIyIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBJCIALgBEJCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "JSIALwEAKiMlIgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEm" +
           "IgAuAEQmIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBASciAC4A" +
           "RCciAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEoIgAvAQBEIygiAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBASkiAC8BAEMjKSIAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBASoiAC8BAEUjKiIAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQErIgAuAEQrIgAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBLiIALwA/LiIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQEvIgAvAQAjIy8iAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBMCIALgBEMCIA" +
           "AAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PositionConditionState Class
    #if (!OPCUA_EXCLUDE_PositionConditionState)
    /// <summary>
    /// Stores an instance of the PositionConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PositionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.PositionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAFBvc2l0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFGIgEBRiL/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBRyIDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4AREciAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAUgiAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAERIIgAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBSSIDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBESSIAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAUoiAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBESiIAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAUsiAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4AREsiAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFM" +
           "IgMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4AREwiAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBTSIDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBETSIAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBTiIDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARE4iAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBTyIDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBETyIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAVAiAC4ARFAiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAVEiAC4ARFEiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQFSIgAuAERSIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAVMiAC4ARFMiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAVQiAC4ARFQi" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVUiAC8BACMjVSIAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFWIgAuAERWIgAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBXiIALwEAKiNeIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQFfIgAuAERfIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAWAiAC8BACojYCIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBYSIALgBEYSIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBYiIALwEAKiNiIgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQFjIgAuAERjIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AWQiAC4ARGQiAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFlIgAvAQBEI2Ui" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWYiAC8BAEMjZiIAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWciAC8BAEUjZyIAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFoIgAuAERoIgAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBayIALwA/ayIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQFsIgAvAQAjI2wiAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBbSIA" +
           "LgBEbSIAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Power_FactorConditionState Class
    #if (!OPCUA_EXCLUDE_Power_FactorConditionState)
    /// <summary>
    /// Stores an instance of the Power_FactorConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Power_FactorConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Power_FactorConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Power_FactorConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAFBvd2VyX0ZhY3RvckNvbmRpdGlvblR5cGVJbnN0YW5jZQEBgyIBAYMi/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAYQiAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAESEIgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGF" +
           "IgMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEhSIAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAYYiAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARIYiAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGH" +
           "IgMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARIciAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQGIIgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAESIIgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBiSIDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAESJIgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAYoiAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARIoiAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAYsiAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAESL" +
           "IgAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAYwiAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARIwiAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQGNIgAuAESNIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQGOIgAuAESOIgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBjyIALgBEjyIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQGQIgAuAESQIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGRIgAu" +
           "AESRIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGSIgAvAQAjI5Ii" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBkyIALgBEkyIAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAZsiAC8BACojmyIAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBnCIALgBEnCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQGdIgAvAQAqI50iAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAZ4iAC4ARJ4iAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAZ8iAC8BACojnyIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBoCIALgBEoCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQGhIgAuAEShIgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBoiIALwEA" +
           "RCOiIgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGjIgAvAQBDI6MiAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGkIgAvAQBFI6QiAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpSIALgBEpSIAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAagiAC8AP6giAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBqSIALwEAIyOpIgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AaoiAC4ARKoiAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PressureConditionState Class
    #if (!OPCUA_EXCLUDE_PressureConditionState)
    /// <summary>
    /// Stores an instance of the PressureConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PressureConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.PressureConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAFByZXNzdXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHAIgEBwCL/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBwSIDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARMEiAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAcIiAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETCIgAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBwyIDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEwyIAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAcQiAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBExCIAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAcUiAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARMUiAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHG" +
           "IgMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARMYiAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBxyIDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBExyIAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEByCIDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARMgiAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBySIDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEySIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAcoiAC4ARMoiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAcsiAC4ARMsiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQHMIgAuAETMIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAc0iAC4ARM0iAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAc4iAC4ARM4i" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAc8iAC8BACMjzyIAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHQIgAuAETQIgAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEB2CIALwEAKiPYIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQHZIgAuAETZIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAdoiAC8BACoj2iIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEB2yIALgBE2yIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEB3CIALwEAKiPcIgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHdIgAuAETdIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "Ad4iAC4ARN4iAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHfIgAvAQBEI98i" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAeAiAC8BAEMj4CIAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAeEiAC8BAEUj4SIAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHiIgAuAETiIgAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEB5SIALwA/5SIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQHmIgAvAQAjI+YiAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB5yIA" +
           "LgBE5yIAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ResistanceConditionState Class
    #if (!OPCUA_EXCLUDE_ResistanceConditionState)
    /// <summary>
    /// Stores an instance of the ResistanceConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistanceConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResistanceConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ResistanceConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAFJlc2lzdGFuY2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAf0iAQH9Iv////8YAAAANWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQH+IgMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudC4ALgBE/iIAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB/yID" +
           "AAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARP8iAAAAEf////8BAf//" +
           "//8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEAIwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhl" +
           "IGV2ZW50LgAuAEQAIwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBASMD" +
           "AAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQBIwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBAiMDAAAAABgAAABXaGVuIHRoZSBldmVudCBv" +
           "Y2N1cnJlZC4ALgBEAiMAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUB" +
           "AQMjAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRl" +
           "cmx5aW5nIHN5c3RlbS4ALgBEAyMAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxU" +
           "aW1lAQEEIwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBl" +
           "dmVudCBvcmlnaW5hdGVkLgAuAEQEIwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNz" +
           "YWdlAQEFIwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEBSMA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEGIwMAAAAAIQAAAEluZGljYXRl" +
           "cyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEQGIwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBByMALgBEByMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBCCMALgBECCMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAQkjAC4ARAkjAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBCiMALgBECiMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBCyMALgBE" +
           "CyMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBDCMALwEAIyMMIwAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQ0jAC4ARA0jAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQEVIwAvAQAqIxUjAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABARYjAC4ARBYjAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBFyMALwEAKiMXIwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQEYIwAuAEQYIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQEZIwAvAQAqIxkjAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABARojAC4ARBojAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBGyMALgBEGyMAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARwjAC8BAEQj" +
           "HCMAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBHSMALwEAQyMdIwAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBHiMALwEARSMeIwAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAR8jAC4ARB8jAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQEiIwAvAD8iIwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBASMjAC8BACMjIyMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEk" +
           "IwAuAEQkIwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Rotary_VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_Rotary_VelocityConditionState)
    /// <summary>
    /// Stores an instance of the Rotary_VelocityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Rotary_VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Rotary_VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Rotary_VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JAAAAFJvdGFyeV9WZWxvY2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBOiMBAToj/////xgAAAA1YIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBATsjAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBm" +
           "b3IgdGhlIGV2ZW50LgAuAEQ7IwAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AQE8IwMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEPCMAAAAR////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAT0jAwAAAAAYAAAAVGhlIHNvdXJjZSBv" +
           "ZiB0aGUgZXZlbnQuAC4ARD0jAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1l" +
           "AQE+IwMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARD4j" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQE/IwMAAAAAGAAAAFdoZW4gdGhlIGV2" +
           "ZW50IG9jY3VycmVkLgAuAEQ/IwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZl" +
           "VGltZQEBQCMDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhl" +
           "IHVuZGVybHlpbmcgc3lzdGVtLgAuAERAIwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABM" +
           "b2NhbFRpbWUBAUEjAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUg" +
           "dGhlIGV2ZW50IG9yaWdpbmF0ZWQuAC4AREEjAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAA" +
           "AE1lc3NhZ2UBAUIjAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAu" +
           "AERCIwAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAUMjAwAAAAAhAAAASW5k" +
           "aWNhdGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4AREMjAAAABf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABAAAABDb25kaXRpb25DbGFzc0lkAQFEIwAuAEREIwAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQFFIwAuAERFIwAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAANAAAAQ29uZGl0aW9uTmFtZQEBRiMALgBERiMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AEJyYW5jaElkAQFHIwAuAERHIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFI" +
           "IwAuAERIIwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFJIwAvAQAj" +
           "I0kjAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSiMALgBESiMAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAVIjAC8BACojUiMAAAAT/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBUyMALgBEUyMAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAMAAAATGFzdFNldmVyaXR5AQFUIwAvAQAqI1QjAAAABf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAVUjAC4ARFUjAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAENvbW1lbnQBAVYjAC8BACojViMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBVyMALgBEVyMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50" +
           "VXNlcklkAQFYIwAuAERYIwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBWSMA" +
           "LwEARCNZIwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFaIwAvAQBDI1oj" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFbIwAvAQBFI1sjAAAB" +
           "AQEAAAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBXCMALgBEXCMAAJYC" +
           "AAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAA" +
           "AFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoC" +
           "AAAAAQAOAAAATVRDdXJyZW50U3RhdGUBAV8jAC8AP18jAAAADP////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABBY3RpdmVTdGF0ZQEBYCMALwEAIyNgIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAA" +
           "SWQBAWEjAC4ARGEjAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Sound_LevelConditionState Class
    #if (!OPCUA_EXCLUDE_Sound_LevelConditionState)
    /// <summary>
    /// Stores an instance of the Sound_LevelConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Sound_LevelConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Sound_LevelConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Sound_LevelConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IAAAAFNvdW5kX0xldmVsQ29uZGl0aW9uVHlwZUluc3RhbmNlAQF3IwEBdyP/////GAAAADVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBeCMDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQuAC4ARHgjAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAXkj" +
           "AwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAER5IwAAABH/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBeiMDAAAAABgAAABUaGUgc291cmNlIG9mIHRo" +
           "ZSBldmVudC4ALgBEeiMAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAXsj" +
           "AwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEeyMAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAXwjAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQg" +
           "b2NjdXJyZWQuAC4ARHwjAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQF9IwMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5k" +
           "ZXJseWluZyBzeXN0ZW0uAC4ARH0jAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2Fs" +
           "VGltZQEBfiMDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUg" +
           "ZXZlbnQgb3JpZ2luYXRlZC4ALgBEfiMAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVz" +
           "c2FnZQEBfyMDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARH8j" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBgCMDAAAAACEAAABJbmRpY2F0" +
           "ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEgCMAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EAAAAENvbmRpdGlvbkNsYXNzSWQBAYEjAC4ARIEjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIA" +
           "AABDb25kaXRpb25DbGFzc05hbWUBAYIjAC4ARIIjAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0A" +
           "AABDb25kaXRpb25OYW1lAQGDIwAuAESDIwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJh" +
           "bmNoSWQBAYQjAC4ARIQjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAYUjAC4A" +
           "RIUjAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAYYjAC8BACMjhiMA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGHIwAuAESHIwAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBjyMALwEAKiOPIwAAABP/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQGQIwAuAESQIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAwAAABMYXN0U2V2ZXJpdHkBAZEjAC8BACojkSMAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBkiMALgBEkiMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "Q29tbWVudAEBkyMALwEAKiOTIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQGUIwAuAESUIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2Vy" +
           "SWQBAZUjAC4ARJUjAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGWIwAvAQBE" +
           "I5YjAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAZcjAC8BAEMjlyMAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAZgjAC8BAEUjmCMAAAEBAQAA" +
           "AAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGZIwAuAESZIwAAlgIAAAAB" +
           "ACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhl" +
           "IGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBnCMALwA/nCMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQGdIwAvAQAjI50jAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "niMALgBEniMAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region StrainConditionState Class
    #if (!OPCUA_EXCLUDE_StrainConditionState)
    /// <summary>
    /// Stores an instance of the StrainConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StrainConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StrainConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.StrainConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAFN0cmFpbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBtCMBAbQj/////xgAAAA1YIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAbUjAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50LgAuAES1IwAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQG2IwMAAAAA" +
           "IgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEtiMAAAAR/////wEB/////wAA" +
           "AAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAbcjAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZl" +
           "bnQuAC4ARLcjAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQG4IwMAAAAA" +
           "KQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARLgjAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQG5IwMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3Vy" +
           "cmVkLgAuAES5IwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBuiMD" +
           "AAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlp" +
           "bmcgc3lzdGVtLgAuAES6IwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUB" +
           "AbsjAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50" +
           "IG9yaWdpbmF0ZWQuAC4ARLsjAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UB" +
           "AbwjAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAES8IwAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAb0jAwAAAAAhAAAASW5kaWNhdGVzIGhv" +
           "dyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARL0jAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQG+IwAuAES+IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQG/IwAuAES/IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEBwCMALgBEwCMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQHBIwAuAETBIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHCIwAuAETCIwAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHDIwAvAQAjI8MjAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBxCMALgBExCMAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAcwjAC8BACojzCMAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBzSMALgBEzSMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQHOIwAvAQAqI84jAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAc8jAC4ARM8jAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAdAjAC8BACoj0CMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEB0SMALgBE0SMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHS" +
           "IwAuAETSIwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0yMALwEARCPTIwAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHUIwAvAQBDI9QjAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHVIwAvAQBFI9UjAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB1iMALgBE1iMAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAdkjAC8AP9kjAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEB2iMALwEAIyPaIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAdsjAC4A" +
           "RNsjAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SystemConditionState Class
    #if (!OPCUA_EXCLUDE_SystemConditionState)
    /// <summary>
    /// Stores an instance of the SystemConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SystemConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SystemConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.SystemConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAFN5c3RlbUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB8SMBAfEj/////xgAAAA1YIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAfIjAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50LgAuAETyIwAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHzIwMAAAAA" +
           "IgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBE8yMAAAAR/////wEB/////wAA" +
           "AAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAfQjAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZl" +
           "bnQuAC4ARPQjAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQH1IwMAAAAA" +
           "KQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARPUjAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQH2IwMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3Vy" +
           "cmVkLgAuAET2IwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB9yMD" +
           "AAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlp" +
           "bmcgc3lzdGVtLgAuAET3IwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUB" +
           "AfgjAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50" +
           "IG9yaWdpbmF0ZWQuAC4ARPgjAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UB" +
           "AfkjAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAET5IwAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAfojAwAAAAAhAAAASW5kaWNhdGVzIGhv" +
           "dyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARPojAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQH7IwAuAET7IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQH8IwAuAET8IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEB/SMALgBE/SMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQH+IwAuAET+IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH/IwAuAET/IwAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEAJAAvAQAjIwAkAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBASQALgBEASQAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAQkkAC8BACojCSQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBCiQALgBECiQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQELJAAvAQAqIwskAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAQwkAC4ARAwkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAQ0kAC8BACojDSQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBDiQALgBEDiQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEP" +
           "JAAuAEQPJAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBECQALwEARCMQJAAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQERJAAvAQBDIxEkAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQESJAAvAQBFIxIkAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEyQALgBEEyQAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBARYkAC8APxYkAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBFyQALwEAIyMXJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBARgkAC4A" +
           "RBgkAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TemperatureConditionState Class
    #if (!OPCUA_EXCLUDE_TemperatureConditionState)
    /// <summary>
    /// Stores an instance of the TemperatureConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.TemperatureConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IAAAAFRlbXBlcmF0dXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEuJAEBLiT/////GAAAADVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBLyQDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQuAC4ARC8kAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBATAk" +
           "AwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQwJAAAABH/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBMSQDAAAAABgAAABUaGUgc291cmNlIG9mIHRo" +
           "ZSBldmVudC4ALgBEMSQAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBATIk" +
           "AwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEMiQAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBATMkAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQg" +
           "b2NjdXJyZWQuAC4ARDMkAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQE0JAMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5k" +
           "ZXJseWluZyBzeXN0ZW0uAC4ARDQkAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2Fs" +
           "VGltZQEBNSQDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUg" +
           "ZXZlbnQgb3JpZ2luYXRlZC4ALgBENSQAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVz" +
           "c2FnZQEBNiQDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARDYk" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBNyQDAAAAACEAAABJbmRpY2F0" +
           "ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBENyQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EAAAAENvbmRpdGlvbkNsYXNzSWQBATgkAC4ARDgkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIA" +
           "AABDb25kaXRpb25DbGFzc05hbWUBATkkAC4ARDkkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0A" +
           "AABDb25kaXRpb25OYW1lAQE6JAAuAEQ6JAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJh" +
           "bmNoSWQBATskAC4ARDskAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATwkAC4A" +
           "RDwkAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAT0kAC8BACMjPSQA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE+JAAuAEQ+JAAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBRiQALwEAKiNGJAAAABP/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQFHJAAuAERHJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAwAAABMYXN0U2V2ZXJpdHkBAUgkAC8BACojSCQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBSSQALgBESSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "Q29tbWVudAEBSiQALwEAKiNKJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQFLJAAuAERLJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2Vy" +
           "SWQBAUwkAC4AREwkAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFNJAAvAQBE" +
           "I00kAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAU4kAC8BAEMjTiQAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAU8kAC8BAEUjTyQAAAEBAQAA" +
           "AAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQJAAuAERQJAAAlgIAAAAB" +
           "ACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhl" +
           "IGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBUyQALwA/UyQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQFUJAAvAQAjI1QkAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "VSQALgBEVSQAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TiltConditionState Class
    #if (!OPCUA_EXCLUDE_TiltConditionState)
    /// <summary>
    /// Stores an instance of the TiltConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TiltConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TiltConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.TiltConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAFRpbHRDb25kaXRpb25UeXBlSW5zdGFuY2UBAWskAQFrJP////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQFsJAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEbCQAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBbSQDAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARG0kAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFuJAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAERuJAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBbyQDAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERvJAAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBcCQDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBEcCQAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAXEkAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBEcSQAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFy" +
           "JAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAERyJAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQFz" +
           "JAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEcyQAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQF0JAMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAER0JAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBdSQALgBEdSQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBdiQALgBEdiQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAXckAC4ARHckAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "eCQALgBEeCQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBeSQALgBEeSQAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeiQALwEAIyN6JAAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAXskAC4ARHskAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQGDJAAvAQAqI4MkAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAYQkAC4ARIQkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBhSQALwEAKiOFJAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQGGJAAuAESGJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQGHJAAvAQAqI4ckAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AYgkAC4ARIgkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBiSQA" +
           "LgBEiSQAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYokAC8BAEQjiiQAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBiyQALwEAQyOLJAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBjCQALwEARSOMJAAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY0kAC4ARI0kAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQGQJAAvAD+QJAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAZEkAC8BACMjkSQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGSJAAuAESS" +
           "JAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TorqueConditionState Class
    #if (!OPCUA_EXCLUDE_TorqueConditionState)
    /// <summary>
    /// Stores an instance of the TorqueConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TorqueConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TorqueConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.TorqueConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAFRvcnF1ZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBqCQBAagk/////xgAAAA1YIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAakkAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50LgAuAESpJAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGqJAMAAAAA" +
           "IgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEqiQAAAAR/////wEB/////wAA" +
           "AAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAaskAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZl" +
           "bnQuAC4ARKskAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGsJAMAAAAA" +
           "KQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARKwkAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQGtJAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3Vy" +
           "cmVkLgAuAEStJAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBriQD" +
           "AAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlp" +
           "bmcgc3lzdGVtLgAuAESuJAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUB" +
           "Aa8kAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50" +
           "IG9yaWdpbmF0ZWQuAC4ARK8kAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UB" +
           "AbAkAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAESwJAAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAbEkAwAAAAAhAAAASW5kaWNhdGVzIGhv" +
           "dyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARLEkAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQGyJAAuAESyJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQGzJAAuAESzJAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEBtCQALgBEtCQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQG1JAAuAES1JAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQG2JAAuAES2JAAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQG3JAAvAQAjI7ckAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBuCQALgBEuCQAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAcAkAC8BACojwCQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBwSQALgBEwSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQHCJAAvAQAqI8IkAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAcMkAC4ARMMkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAcQkAC8BACojxCQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBxSQALgBExSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHG" +
           "JAAuAETGJAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBxyQALwEARCPHJAAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHIJAAvAQBDI8gkAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHJJAAvAQBFI8kkAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEByiQALgBEyiQAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAc0kAC8AP80kAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBziQALwEAIyPOJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAc8kAC4A" +
           "RM8kAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_VelocityConditionState)
    /// <summary>
    /// Stores an instance of the VelocityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAFZlbG9jaXR5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQHlJAEB5ST/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEB5iQDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4AROYkAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAeckAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETnJAAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB6CQDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBE6CQAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAekkAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBE6SQAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAeokAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4AROokAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHr" +
           "JAMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4AROskAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEB7CQDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBE7CQAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEB7SQDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARO0kAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEB7iQDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBE7iQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAe8kAC4ARO8kAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAfAkAC4ARPAkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQHxJAAuAETxJAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAfIkAC4ARPIkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAfMkAC4ARPMk" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAfQkAC8BACMj9CQAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQH1JAAuAET1JAAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEB/SQALwEAKiP9JAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQH+JAAuAET+JAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAf8kAC8BACoj/yQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBACUALgBEACUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBASUALwEAKiMBJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQECJQAuAEQCJQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AQMlAC4ARAMlAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEEJQAvAQBEIwQl" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAQUlAC8BAEMjBSUAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAQYlAC8BAEUjBiUAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEHJQAuAEQHJQAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBCiUALwA/CiUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQELJQAvAQAjIwslAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBDCUA" +
           "LgBEDCUAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ViscosityConditionState Class
    #if (!OPCUA_EXCLUDE_ViscosityConditionState)
    /// <summary>
    /// Stores an instance of the ViscosityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ViscosityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ViscosityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ViscosityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HgAAAFZpc2Nvc2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBIiUBASIl/////xgAAAA1YIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBASMlAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50LgAuAEQjJQAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQEkJQMA" +
           "AAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEJCUAAAAR/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBASUlAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUg" +
           "ZXZlbnQuAC4ARCUlAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEmJQMA" +
           "AAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARCYlAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQEnJQMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9j" +
           "Y3VycmVkLgAuAEQnJQAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "KCUDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVy" +
           "bHlpbmcgc3lzdGVtLgAuAEQoJQAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRp" +
           "bWUBASklAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2" +
           "ZW50IG9yaWdpbmF0ZWQuAC4ARCklAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3Nh" +
           "Z2UBASolAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEQqJQAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBASslAwAAAAAhAAAASW5kaWNhdGVz" +
           "IGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARCslAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABDb25kaXRpb25DbGFzc0lkAQEsJQAuAEQsJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAA" +
           "Q29uZGl0aW9uQ2xhc3NOYW1lAQEtJQAuAEQtJQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "Q29uZGl0aW9uTmFtZQEBLiUALgBELiUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5j" +
           "aElkAQEvJQAuAEQvJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQEwJQAuAEQw" +
           "JQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQExJQAvAQAjIzElAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBMiUALgBEMiUAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBATolAC8BACojOiUAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBOyUALgBEOyUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQE8JQAvAQAqIzwlAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAT0lAC4ARD0lAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBAT4lAC8BACojPiUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBPyUALgBEPyUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQFAJQAuAERAJQAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBQSUALwEARCNB" +
           "JQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFCJQAvAQBDI0IlAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFDJQAvAQBFI0MlAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRCUALgBERCUAAJYCAAAAAQAq" +
           "AQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBj" +
           "b21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAUclAC8AP0clAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBSCUALwEAIyNIJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAUkl" +
           "AC4AREklAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltageConditionState Class
    #if (!OPCUA_EXCLUDE_VoltageConditionState)
    /// <summary>
    /// Stores an instance of the VoltageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.VoltageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HAAAAFZvbHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAV8lAQFfJf////8YAAAANWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQFgJQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudC4ALgBEYCUAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBYSUDAAAA" +
           "ACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARGElAAAAEf////8BAf////8A" +
           "AAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFiJQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2" +
           "ZW50LgAuAERiJQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBYyUDAAAA" +
           "ACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERjJQAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBZCUDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1" +
           "cnJlZC4ALgBEZCUAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAWUl" +
           "AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5" +
           "aW5nIHN5c3RlbS4ALgBEZSUAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1l" +
           "AQFmJQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVu" +
           "dCBvcmlnaW5hdGVkLgAuAERmJQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdl" +
           "AQFnJQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEZyUAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQFoJQMAAAAAIQAAAEluZGljYXRlcyBo" +
           "b3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAERoJQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBaSUALgBEaSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBaiUALgBEaiUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBAWslAC4ARGslAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEBbCUALgBEbCUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBbSUALgBEbSUA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBbiUALwEAIyNuJQAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAW8lAC4ARG8lAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQF3JQAvAQAqI3clAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAXglAC4ARHglAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEBeSUALwEAKiN5JQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQF6JQAuAER6JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQF7JQAvAQAqI3slAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAXwlAC4ARHwlAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "fSUALgBEfSUAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAX4lAC8BAEQjfiUA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBfyUALwEAQyN/JQAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBgCUALwEARSOAJQAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYElAC4ARIElAACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQGEJQAvAD+EJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAYUlAC8BACMjhSUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGGJQAu" +
           "AESGJQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Volt_AmperageConditionState Class
    #if (!OPCUA_EXCLUDE_Volt_AmperageConditionState)
    /// <summary>
    /// Stores an instance of the Volt_AmperageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Volt_AmperageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Volt_AmperageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Volt_AmperageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAFZvbHRfQW1wZXJhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAZwlAQGcJf////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQGdJQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBEnSUAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "niUDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARJ4lAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGfJQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAESfJQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "oCUDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESgJQAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBoSUDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBEoSUAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAaIlAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBEoiUAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQGjJQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAESjJQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQGkJQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "pCUAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGlJQMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAESlJQAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBpiUALgBEpiUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBpyUALgBEpyUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAaglAC4ARKglAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEBqSUALgBEqSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqiUA" +
           "LgBEqiUAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqyUALwEAIyOr" +
           "JQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAawlAC4ARKwlAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQG0JQAvAQAqI7QlAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbUlAC4ARLUlAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBtiUALwEAKiO2JQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQG3JQAuAES3JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQG4JQAvAQAqI7glAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAbklAC4ARLklAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBuiUALgBEuiUAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbslAC8B" +
           "AEQjuyUAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBvCUALwEAQyO8JQAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBvSUALwEARSO9JQAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAb4lAC4ARL4lAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQHBJQAvAD/BJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAcIlAC8BACMjwiUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQHDJQAuAETDJQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltAmperageReactiveConditionState Class
    #if (!OPCUA_EXCLUDE_VoltAmperageReactiveConditionState)
    /// <summary>
    /// Stores an instance of the VoltAmperageReactiveConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmperageReactiveConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltAmperageReactiveConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.VoltAmperageReactiveConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "KQAAAFZvbHRBbXBlcmFnZVJlYWN0aXZlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHZJQEB2SX/////GAAA" +
           "ADVgiQoCAAAAAAAHAAAARXZlbnRJZAEB2iUDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlm" +
           "aWVyIGZvciB0aGUgZXZlbnQuAC4ARNolAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAdslAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETbJQAA" +
           "ABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB3CUDAAAAABgAAABUaGUgc291" +
           "cmNlIG9mIHRoZSBldmVudC4ALgBE3CUAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5hbWUBAd0lAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBE3SUAAAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAd4lAwAAAAAYAAAAV2hlbiB0" +
           "aGUgZXZlbnQgb2NjdXJyZWQuAC4ARN4lAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJl" +
           "Y2VpdmVUaW1lAQHfJQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJv" +
           "bSB0aGUgdW5kZXJseWluZyBzeXN0ZW0uAC4ARN8lAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAA" +
           "CQAAAExvY2FsVGltZQEB4CUDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3" +
           "aGVyZSB0aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBE4CUAAAEA0CL/////AQH/////AAAAADVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEB4SUDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZl" +
           "bnQuAC4AROElAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEB4iUDAAAAACEA" +
           "AABJbmRpY2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBE4iUAAAAF/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAeMlAC4AROMlAAAAEf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBAeQlAC4AROQlAAAAFf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQHlJQAuAETlJQAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAQnJhbmNoSWQBAeYlAC4AROYlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRh" +
           "aW4BAeclAC4AROclAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAegl" +
           "AC8BACMj6CUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHpJQAuAETpJQAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEB8SUALwEAKiPxJQAAABP/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHyJQAuAETyJQAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAfMlAC8BACoj8yUAAAAF/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB9CUALgBE9CUAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAQ29tbWVudAEB9SUALwEAKiP1JQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQH2JQAuAET2JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABD" +
           "bGllbnRVc2VySWQBAfclAC4ARPclAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxl" +
           "AQH4JQAvAQBEI/glAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAfklAC8B" +
           "AEMj+SUAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAfolAC8BAEUj" +
           "+iUAAAEBAQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH7JQAuAET7" +
           "JQAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmll" +
           "ciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAA" +
           "AAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAA" +
           "FWCJCgIAAAABAA4AAABNVEN1cnJlbnRTdGF0ZQEB/iUALwA//iUAAAAM/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAEFjdGl2ZVN0YXRlAQH/JQAvAQAjI/8lAAAAFf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBACYALgBEACYAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WattageConditionState Class
    #if (!OPCUA_EXCLUDE_WattageConditionState)
    /// <summary>
    /// Stores an instance of the WattageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WattageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WattageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.WattageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HAAAAFdhdHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBARYmAQEWJv////8YAAAANWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQEXJgMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudC4ALgBEFyYAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBGCYDAAAA" +
           "ACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARBgmAAAAEf////8BAf////8A" +
           "AAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEZJgMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2" +
           "ZW50LgAuAEQZJgAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBGiYDAAAA" +
           "ACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQaJgAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBGyYDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1" +
           "cnJlZC4ALgBEGyYAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBARwm" +
           "AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5" +
           "aW5nIHN5c3RlbS4ALgBEHCYAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1l" +
           "AQEdJgMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVu" +
           "dCBvcmlnaW5hdGVkLgAuAEQdJgAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdl" +
           "AQEeJgMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEHiYAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEfJgMAAAAAIQAAAEluZGljYXRlcyBo" +
           "b3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEQfJgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBICYALgBEICYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBISYALgBEISYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBASImAC4ARCImAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEBIyYALgBEIyYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBJCYALgBEJCYA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBJSYALwEAIyMlJgAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASYmAC4ARCYmAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQEuJgAvAQAqIy4mAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAS8mAC4ARC8mAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEBMCYALwEAKiMwJgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQExJgAuAEQxJgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQEyJgAvAQAqIzImAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABATMmAC4ARDMmAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "NCYALgBENCYAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATUmAC8BAEQjNSYA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNiYALwEAQyM2JgAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNyYALwEARSM3JgAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATgmAC4ARDgmAACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQE7JgAvAD87JgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBATwmAC8BACMjPCYAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE9JgAu" +
           "AEQ9JgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ChannelState Class
    #if (!OPCUA_EXCLUDE_ChannelState)
    /// <summary>
    /// Stores an instance of the ChannelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChannelState : BaseDataVariableState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChannelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ChannelType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ChannelNumberDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CalibrationDate != null)
            {
                CalibrationDate.Initialize(context, CalibrationDate_InitializationString);
            }

            if (NextCalibrationDate != null)
            {
                NextCalibrationDate.Initialize(context, NextCalibrationDate_InitializationString);
            }

            if (CalibrationInitials != null)
            {
                CalibrationInitials.Initialize(context, CalibrationInitials_InitializationString);
            }
        }

        #region Initialization String
        private const string CalibrationDate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DwAAAENhbGlicmF0aW9uRGF0ZQEBVCYALgBEVCYAAAEB+Sb/////AQH/////AAAAAA==";

        private const string NextCalibrationDate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAE5leHRDYWxpYnJhdGlvbkRhdGUBAVUmAC4ARFUmAAABAfkm/////wEB/////wAAAAA=";

        private const string CalibrationInitials_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAENhbGlicmF0aW9uSW5pdGlhbHMBAVYmAC4ARFYmAAABAfom/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "EwAAAENoYW5uZWxUeXBlSW5zdGFuY2UBAVMmAQFTJgEB/SYBAf////8DAAAAFWCJCgIAAAABAA8AAABD" +
           "YWxpYnJhdGlvbkRhdGUBAVQmAC4ARFQmAAABAfkm/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAE5l" +
           "eHRDYWxpYnJhdGlvbkRhdGUBAVUmAC4ARFUmAAABAfkm/////wEB/////wAAAAAVYIkKAgAAAAEAEwAA" +
           "AENhbGlicmF0aW9uSW5pdGlhbHMBAVYmAC4ARFYmAAABAfom/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CalibrationDate Property.
        /// </summary>
        public PropertyState<string> CalibrationDate
        {
            get
            {
                return m_calibrationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationDate = value;
            }
        }

        /// <summary>
        /// A description for the NextCalibrationDate Property.
        /// </summary>
        public PropertyState<string> NextCalibrationDate
        {
            get
            {
                return m_nextCalibrationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nextCalibrationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nextCalibrationDate = value;
            }
        }

        /// <summary>
        /// A description for the CalibrationInitials Property.
        /// </summary>
        public PropertyState<string> CalibrationInitials
        {
            get
            {
                return m_calibrationInitials;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationInitials, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationInitials = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_calibrationDate != null)
            {
                children.Add(m_calibrationDate);
            }

            if (m_nextCalibrationDate != null)
            {
                children.Add(m_nextCalibrationDate);
            }

            if (m_calibrationInitials != null)
            {
                children.Add(m_calibrationInitials);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CalibrationDate:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationDate == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationDate = new PropertyState<string>(this);
                            }
                            else
                            {
                                CalibrationDate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CalibrationDate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NextCalibrationDate:
                {
                    if (createOrReplace)
                    {
                        if (NextCalibrationDate == null)
                        {
                            if (replacement == null)
                            {
                                NextCalibrationDate = new PropertyState<string>(this);
                            }
                            else
                            {
                                NextCalibrationDate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NextCalibrationDate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.CalibrationInitials:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationInitials == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationInitials = new PropertyState<string>(this);
                            }
                            else
                            {
                                CalibrationInitials = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CalibrationInitials;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_calibrationDate;
        private PropertyState<string> m_nextCalibrationDate;
        private PropertyState<string> m_calibrationInitials;
        #endregion
    }
    #endif
    #endregion

    #region ConfigurationState Class
    #if (!OPCUA_EXCLUDE_ConfigurationState)
    /// <summary>
    /// Stores an instance of the ConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConfigurationState : MTComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ConfigurationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAENvbmZpZ3VyYXRpb25UeXBlSW5zdGFuY2UBAVcmAQFXJv////8FAAAAFWCJCgIAAAABAAwAAABB" +
           "dmFpbGFiaWxpdHkBAVgmAC8BAD0JWCYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVm" +
           "YWN0dXJlcgEBWyYALgBEWyYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJl" +
           "cgEBXCYALgBEXCYAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBXyYALwA9" +
           "XyYAAP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQFgJgAvAD1gJgAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SensorConfigurationState Class
    #if (!OPCUA_EXCLUDE_SensorConfigurationState)
    /// <summary>
    /// Stores an instance of the SensorConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorConfigurationState : ConfigurationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SensorConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.SensorConfigurationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (FirmwareVersion != null)
            {
                FirmwareVersion.Initialize(context, FirmwareVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string FirmwareVersion_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DwAAAEZpcm13YXJlVmVyc2lvbgEBcSYALgBEcSYAAAEBJyf/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAFNlbnNvckNvbmZpZ3VyYXRpb25UeXBlSW5zdGFuY2UBAWQmAQFkJv////8GAAAAFWCJCgIAAAAB" +
           "AAwAAABBdmFpbGFiaWxpdHkBAWUmAC8BAD0JZSYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAA" +
           "AE1hbnVmYWN0dXJlcgEBaCYALgBEaCYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlh" +
           "bE51bWJlcgEBaSYALgBEaSYAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEB" +
           "bCYALwA9bCYAAP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQFtJgAvAD1tJgAA/////wAA" +
           "AAAVYIkKAgAAAAEADwAAAEZpcm13YXJlVmVyc2lvbgEBcSYALgBEcSYAAAEBJyf/////AQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the FirmwareVersion Property.
        /// </summary>
        public PropertyState<string> FirmwareVersion
        {
            get
            {
                return m_firmwareVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firmwareVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firmwareVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_firmwareVersion != null)
            {
                children.Add(m_firmwareVersion);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.FirmwareVersion:
                {
                    if (createOrReplace)
                    {
                        if (FirmwareVersion == null)
                        {
                            if (replacement == null)
                            {
                                FirmwareVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                FirmwareVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = FirmwareVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_firmwareVersion;
        #endregion
    }
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <summary>
    /// Stores an instance of the SensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : MTComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.SensorType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "EgAAAFNlbnNvclR5cGVJbnN0YW5jZQEBciYBAXIm/////wUAAAAVYIkKAgAAAAEADAAAAEF2YWlsYWJp" +
           "bGl0eQEBcyYALwEAPQlzJgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVy" +
           "AQF2JgAuAER2JgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQF3JgAu" +
           "AER3JgAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQF6JgAvAD16JgAA////" +
           "/wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAXsmAC8APXsmAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SourceState Class
    #if (!OPCUA_EXCLUDE_SourceState)
    /// <summary>
    /// Stores an instance of the SourceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SourceState : MTComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SourceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.SourceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ComponentId != null)
            {
                ComponentId.Initialize(context, ComponentId_InitializationString);
            }
        }

        #region Initialization String
        private const string ComponentId_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAENvbXBvbmVudElkAQGMJgAuAESMJgAAAQEHJ/////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "EgAAAFNvdXJjZVR5cGVJbnN0YW5jZQEBfyYBAX8m/////wYAAAAVYIkKAgAAAAEADAAAAEF2YWlsYWJp" +
           "bGl0eQEBgCYALwEAPQmAJgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVy" +
           "AQGDJgAuAESDJgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQGEJgAu" +
           "AESEJgAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQGHJgAvAD2HJgAA////" +
           "/wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAYgmAC8APYgmAAD/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQ29tcG9uZW50SWQBAYwmAC4ARIwmAAABAQcn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ComponentId Property.
        /// </summary>
        public PropertyState<NodeId> ComponentId
        {
            get
            {
                return m_componentId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_componentId != null)
            {
                children.Add(m_componentId);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.ComponentId:
                {
                    if (createOrReplace)
                    {
                        if (ComponentId == null)
                        {
                            if (replacement == null)
                            {
                                ComponentId = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                ComponentId = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = ComponentId;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<NodeId> m_componentId;
        #endregion
    }
    #endif
    #endregion

    #region AssetState Class
    #if (!OPCUA_EXCLUDE_AssetState)
    /// <summary>
    /// Stores an instance of the AssetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AssetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AssetType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Manufacturers != null)
            {
                Manufacturers.Initialize(context, Manufacturers_InitializationString);
            }

            if (AssetDescription != null)
            {
                AssetDescription.Initialize(context, AssetDescription_InitializationString);
            }
        }

        #region Initialization String
        private const string Manufacturers_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DQAAAE1hbnVmYWN0dXJlcnMBAY8mAC4ARI8mAAABATUn/////wEB/////wAAAAA=";

        private const string AssetDescription_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAEFzc2V0RGVzY3JpcHRpb24BAZEmAC8AP5EmAAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "EQAAAEFzc2V0VHlwZUluc3RhbmNlAQGNJgEBjSb/////BAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVt" +
           "YmVyAQGOJgAuAESOJgAAAQFaJ/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNYW51ZmFjdHVyZXJz" +
           "AQGPJgAuAESPJgAAAQE1J/////8BAf////8AAAAAFWCJCgIAAAABABMAAABMYXN0Q2hhbmdlVGltZXN0" +
           "YW1wAQGQJgAuAESQJgAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAQXNzZXREZXNjcmlwdGlv" +
           "bgEBkSYALwA/kSYAAAAY/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the SerialNumber Property.
        /// </summary>
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <summary>
        /// A description for the Manufacturers Property.
        /// </summary>
        public PropertyState<string> Manufacturers
        {
            get
            {
                return m_manufacturers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturers = value;
            }
        }

        /// <summary>
        /// A description for the LastChangeTimestamp Property.
        /// </summary>
        public PropertyState<DateTime> LastChangeTimestamp
        {
            get
            {
                return m_lastChangeTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastChangeTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastChangeTimestamp = value;
            }
        }

        /// <summary>
        /// A description for the AssetDescription Variable.
        /// </summary>
        public BaseDataVariableState AssetDescription
        {
            get
            {
                return m_assetDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_assetDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetDescription = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_manufacturers != null)
            {
                children.Add(m_manufacturers);
            }

            if (m_lastChangeTimestamp != null)
            {
                children.Add(m_lastChangeTimestamp);
            }

            if (m_assetDescription != null)
            {
                children.Add(m_assetDescription);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Manufacturers:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturers == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturers = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturers = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturers;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LastChangeTimestamp:
                {
                    if (createOrReplace)
                    {
                        if (LastChangeTimestamp == null)
                        {
                            if (replacement == null)
                            {
                                LastChangeTimestamp = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                LastChangeTimestamp = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastChangeTimestamp;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.AssetDescription:
                {
                    if (createOrReplace)
                    {
                        if (AssetDescription == null)
                        {
                            if (replacement == null)
                            {
                                AssetDescription = new BaseDataVariableState(this);
                            }
                            else
                            {
                                AssetDescription = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = AssetDescription;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_manufacturers;
        private PropertyState<DateTime> m_lastChangeTimestamp;
        private BaseDataVariableState m_assetDescription;
        #endregion
    }
    #endif
    #endregion

    #region MeasurementState Class
    #if (!OPCUA_EXCLUDE_MeasurementState)
    /// <summary>
    /// Stores an instance of the MeasurementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeasurementState : AnalogItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MeasurementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (SignificantDigits != null)
            {
                SignificantDigits.Initialize(context, SignificantDigits_InitializationString);
            }

            if (Units != null)
            {
                Units.Initialize(context, Units_InitializationString);
            }

            if (NativeUnits != null)
            {
                NativeUnits.Initialize(context, NativeUnits_InitializationString);
            }

            if (LastChangeTimestamp != null)
            {
                LastChangeTimestamp.Initialize(context, LastChangeTimestamp_InitializationString);
            }

            if (Code != null)
            {
                Code.Initialize(context, Code_InitializationString);
            }

            if (Maximum != null)
            {
                Maximum.Initialize(context, Maximum_InitializationString);
            }

            if (Minimum != null)
            {
                Minimum.Initialize(context, Minimum_InitializationString);
            }

            if (Nominal != null)
            {
                Nominal.Initialize(context, Nominal_InitializationString);
            }
        }

        #region Initialization String
        private const string SignificantDigits_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EQAAAFNpZ25pZmljYW50RGlnaXRzAQGYJgAuAESYJgAAAQFWJ/////8BAf////8AAAAA";

        private const string Units_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAFVuaXRzAQGZJgAvAD+ZJgAAAQB3A/////8BAf////8AAAAA";

        private const string NativeUnits_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAE5hdGl2ZVVuaXRzAQGaJgAvAD+aJgAAAQB3A/////8BAf////8AAAAA";

        private const string LastChangeTimestamp_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAExhc3RDaGFuZ2VUaW1lc3RhbXABAZsmAC4ARJsmAAAADf////8BAf////8AAAAA";

        private const string Code_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BAAAAENvZGUBAZwmAC4ARJwmAAABAQYn/////wEB/////wAAAAA=";

        private const string Maximum_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAE1heGltdW0BAZ0mAC4ARJ0mAAABATkn/////wEB/////wAAAAA=";

        private const string Minimum_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAE1pbmltdW0BAZ4mAC4ARJ4mAAABATkn/////wEB/////wAAAAA=";

        private const string Nominal_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAE5vbWluYWwBAZ8mAC4ARJ8mAAABATkn/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAE1lYXN1cmVtZW50VHlwZUluc3RhbmNlAQGSJgEBkiYAGv////8BAf////8JAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGWJgAuAESWJgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABEAAABTaWdu" +
           "aWZpY2FudERpZ2l0cwEBmCYALgBEmCYAAAEBVif/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5p" +
           "dHMBAZkmAC8AP5kmAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAE5hdGl2ZVVuaXRzAQGa" +
           "JgAvAD+aJgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABABMAAABMYXN0Q2hhbmdlVGltZXN0YW1w" +
           "AQGbJgAuAESbJgAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAEAAAAQ29kZQEBnCYALgBEnCYAAAEB" +
           "Bif/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEBnSYALgBEnSYAAAEBOSf/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAATWluaW11bQEBniYALgBEniYAAAEBOSf/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAATm9taW5hbAEBnyYALgBEnyYAAAEBOSf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the SignificantDigits Property.
        /// </summary>
        public PropertyState SignificantDigits
        {
            get
            {
                return m_significantDigits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_significantDigits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_significantDigits = value;
            }
        }

        /// <summary>
        /// A description for the Units Variable.
        /// </summary>
        public BaseDataVariableState<EUInformation> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }

        /// <summary>
        /// A description for the NativeUnits Variable.
        /// </summary>
        public BaseDataVariableState<EUInformation> NativeUnits
        {
            get
            {
                return m_nativeUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeUnits = value;
            }
        }

        /// <summary>
        /// A description for the LastChangeTimestamp Property.
        /// </summary>
        public PropertyState<DateTime> LastChangeTimestamp
        {
            get
            {
                return m_lastChangeTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastChangeTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastChangeTimestamp = value;
            }
        }

        /// <summary>
        /// A description for the Code Property.
        /// </summary>
        public PropertyState<string> Code
        {
            get
            {
                return m_code;
            }

            set
            {
                if (!Object.ReferenceEquals(m_code, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_code = value;
            }
        }

        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <summary>
        /// A description for the Minimum Property.
        /// </summary>
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <summary>
        /// A description for the Nominal Property.
        /// </summary>
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_significantDigits != null)
            {
                children.Add(m_significantDigits);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            if (m_nativeUnits != null)
            {
                children.Add(m_nativeUnits);
            }

            if (m_lastChangeTimestamp != null)
            {
                children.Add(m_lastChangeTimestamp);
            }

            if (m_code != null)
            {
                children.Add(m_code);
            }

            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.SignificantDigits:
                {
                    if (createOrReplace)
                    {
                        if (SignificantDigits == null)
                        {
                            if (replacement == null)
                            {
                                SignificantDigits = new PropertyState(this);
                            }
                            else
                            {
                                SignificantDigits = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = SignificantDigits;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new BaseDataVariableState<EUInformation>(this);
                            }
                            else
                            {
                                Units = (BaseDataVariableState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeUnits:
                {
                    if (createOrReplace)
                    {
                        if (NativeUnits == null)
                        {
                            if (replacement == null)
                            {
                                NativeUnits = new BaseDataVariableState<EUInformation>(this);
                            }
                            else
                            {
                                NativeUnits = (BaseDataVariableState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = NativeUnits;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LastChangeTimestamp:
                {
                    if (createOrReplace)
                    {
                        if (LastChangeTimestamp == null)
                        {
                            if (replacement == null)
                            {
                                LastChangeTimestamp = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                LastChangeTimestamp = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastChangeTimestamp;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Code:
                {
                    if (createOrReplace)
                    {
                        if (Code == null)
                        {
                            if (replacement == null)
                            {
                                Code = new PropertyState<string>(this);
                            }
                            else
                            {
                                Code = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Code;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_significantDigits;
        private BaseDataVariableState<EUInformation> m_units;
        private BaseDataVariableState<EUInformation> m_nativeUnits;
        private PropertyState<DateTime> m_lastChangeTimestamp;
        private PropertyState<string> m_code;
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region MeasurementState<T> Class
    /// <summary>
    /// A typed version of the MeasurementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MeasurementState<T> : MeasurementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MeasurementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region CuttingToolState Class
    #if (!OPCUA_EXCLUDE_CuttingToolState)
    /// <summary>
    /// Stores an instance of the CuttingToolType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingToolState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CuttingToolType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ToolGroup != null)
            {
                ToolGroup.Initialize(context, ToolGroup_InitializationString);
            }
        }

        #region Initialization String
        private const string ToolGroup_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CQAAAFRvb2xHcm91cAEBoiYALgBEoiYAAAEBXif/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAEN1dHRpbmdUb29sVHlwZUluc3RhbmNlAQGgJgEBoCb/////AgAAABVgiQoCAAAAAQAGAAAAVG9v" +
           "bElkAQGhJgAuAEShJgAAAQFfJ/////8BAf////8AAAAAFWCJCgIAAAABAAkAAABUb29sR3JvdXABAaIm" +
           "AC4ARKImAAABAV4n/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ToolId Property.
        /// </summary>
        public PropertyState<string> ToolId
        {
            get
            {
                return m_toolId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toolId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toolId = value;
            }
        }

        /// <summary>
        /// A description for the ToolGroup Property.
        /// </summary>
        public PropertyState<string> ToolGroup
        {
            get
            {
                return m_toolGroup;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toolGroup, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toolGroup = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_toolId != null)
            {
                children.Add(m_toolId);
            }

            if (m_toolGroup != null)
            {
                children.Add(m_toolGroup);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.ToolId:
                {
                    if (createOrReplace)
                    {
                        if (ToolId == null)
                        {
                            if (replacement == null)
                            {
                                ToolId = new PropertyState<string>(this);
                            }
                            else
                            {
                                ToolId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ToolId;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ToolGroup:
                {
                    if (createOrReplace)
                    {
                        if (ToolGroup == null)
                        {
                            if (replacement == null)
                            {
                                ToolGroup = new PropertyState<string>(this);
                            }
                            else
                            {
                                ToolGroup = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ToolGroup;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_toolId;
        private PropertyState<string> m_toolGroup;
        #endregion
    }
    #endif
    #endregion

    #region CuttingToolLifeCycleState Class
    #if (!OPCUA_EXCLUDE_CuttingToolLifeCycleState)
    /// <summary>
    /// Stores an instance of the CuttingToolLifeCycleType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolLifeCycleState : AssetState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingToolLifeCycleState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CuttingToolLifeCycleType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ReconditionCount != null)
            {
                ReconditionCount.Initialize(context, ReconditionCount_InitializationString);
            }

            if (ToolLife != null)
            {
                ToolLife.Initialize(context, ToolLife_InitializationString);
            }

            if (ProgramToolNumber != null)
            {
                ProgramToolNumber.Initialize(context, ProgramToolNumber_InitializationString);
            }

            if (Location != null)
            {
                Location.Initialize(context, Location_InitializationString);
            }

            if (ProgramSpindleSpeed != null)
            {
                ProgramSpindleSpeed.Initialize(context, ProgramSpindleSpeed_InitializationString);
            }

            if (ProgramFeedRate != null)
            {
                ProgramFeedRate.Initialize(context, ProgramFeedRate_InitializationString);
            }

            if (ConnectionCodeMachineSide != null)
            {
                ConnectionCodeMachineSide.Initialize(context, ConnectionCodeMachineSide_InitializationString);
            }
        }

        #region Initialization String
        private const string ReconditionCount_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAFJlY29uZGl0aW9uQ291bnQBAaomAC8BAcEmqiYAAAEBUCf/////AQH/////AAAAAA==";

        private const string ToolLife_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CAAAAFRvb2xMaWZlAQGsJgAvAQHDJqwmAAAAGP////8BAf////8DAAAAFWCJCgIAAAABAAQAAABUeXBl" +
           "AQGtJgAuAEStJgAAAQFiJ/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABDb3VudERpcmVjdGlvbgEB" +
           "riYALgBEriYAAAEBYCf/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEBsCYALgBEsCYA" +
           "AAEBZCf/////AQH/////AAAAAA==";

        private const string ProgramToolNumber_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EQAAAFByb2dyYW1Ub29sTnVtYmVyAQGxJgAvAQHMJrEmAAABAUwn/////wEB/////wMAAAAVYIkKAgAA" +
           "AAEABwAAAE1heGltdW0BAbImAC4ARLImAAABATgn/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1p" +
           "bmltdW0BAbMmAC4ARLMmAAABATon/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE5vbWluYWwBAbQm" +
           "AC4ARLQmAAABAUIn/////wEB/////wAAAAA=";

        private const string Location_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CAAAAExvY2F0aW9uAQG1JgAvAQHIJrUmAAABATEn/////wEB/////wMAAAAVYIkKAgAAAAEABAAAAFR5" +
           "cGUBAbYmAC4ARLYmAAABATIn/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE5lZ2F0aXZlT3Zlcmxh" +
           "cAEBtyYALgBEtyYAAAEBRyf/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUG9zaXRpdmVPdmVybGFw" +
           "AQG4JgAuAES4JgAAAQFHJ/////8BAf////8AAAAA";

        private const string ProgramSpindleSpeed_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAFByb2dyYW1TcGluZGxlU3BlZWQBAbkmAC8BAcwmuSYAAAAY/////wEB/////wMAAAAVYIkKAgAA" +
           "AAEABwAAAE1heGltdW0BAbomAC4ARLomAAABATgn/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1p" +
           "bmltdW0BAbsmAC4ARLsmAAABATon/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE5vbWluYWwBAbwm" +
           "AC4ARLwmAAABAUIn/////wEB/////wAAAAA=";

        private const string ProgramFeedRate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DwAAAFByb2dyYW1GZWVkUmF0ZQEBvSYALgBEvSYAAAEBJif/////AQH/////AAAAAA==";

        private const string ConnectionCodeMachineSide_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "GQAAAENvbm5lY3Rpb25Db2RlTWFjaGluZVNpZGUBAb4mAC4ARL4mAAABAQgn/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IAAAAEN1dHRpbmdUb29sTGlmZUN5Y2xlVHlwZUluc3RhbmNlAQGjJgEBoyb/////CgAAABVgiQoCAAAA" +
           "AQAMAAAAU2VyaWFsTnVtYmVyAQGkJgAuAESkJgAAAQFaJ/////8BAf////8AAAAAFWCJCgIAAAABABMA" +
           "AABMYXN0Q2hhbmdlVGltZXN0YW1wAQGmJgAuAESmJgAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAM" +
           "AAAAQ3V0dGVyU3RhdHVzAQGoJgAvAQG/JqgmAAABAQsn/////wEB/////wEAAAAVYIkKAgAAAAEABgAA" +
           "AFN0YXR1cwEBqSYALgBEqSYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFJlY29uZGl0aW9u" +
           "Q291bnQBAaomAC8BAcEmqiYAAAEBUCf/////AQH/////AAAAABVgiQoCAAAAAQAIAAAAVG9vbExpZmUB" +
           "AawmAC8BAcMmrCYAAAAY/////wEB/////wMAAAAVYIkKAgAAAAEABAAAAFR5cGUBAa0mAC4ARK0mAAAB" +
           "AWIn/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAENvdW50RGlyZWN0aW9uAQGuJgAuAESuJgAAAQFg" +
           "J/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQGwJgAuAESwJgAAAQFkJ/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABEAAABQcm9ncmFtVG9vbE51bWJlcgEBsSYALwEBzCaxJgAAAQFMJ/////8B" +
           "Af////8DAAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQGyJgAuAESyJgAAAQE4J/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAcAAABNaW5pbXVtAQGzJgAuAESzJgAAAQE6J/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAcAAABOb21pbmFsAQG0JgAuAES0JgAAAQFCJ/////8BAf////8AAAAAFWCJCgIAAAABAAgAAABMb2Nh" +
           "dGlvbgEBtSYALwEByCa1JgAAAQExJ/////8BAf////8DAAAAFWCJCgIAAAABAAQAAABUeXBlAQG2JgAu" +
           "AES2JgAAAQEyJ/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABOZWdhdGl2ZU92ZXJsYXABAbcmAC4A" +
           "RLcmAAABAUcn/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBvc2l0aXZlT3ZlcmxhcAEBuCYALgBE" +
           "uCYAAAEBRyf/////AQH/////AAAAABVgiQoCAAAAAQATAAAAUHJvZ3JhbVNwaW5kbGVTcGVlZAEBuSYA" +
           "LwEBzCa5JgAAABj/////AQH/////AwAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEBuiYALgBEuiYAAAEB" +
           "OCf/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWluaW11bQEBuyYALgBEuyYAAAEBOif/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAATm9taW5hbAEBvCYALgBEvCYAAAEBQif/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAPAAAAUHJvZ3JhbUZlZWRSYXRlAQG9JgAuAES9JgAAAQEmJ/////8BAf////8AAAAAFWCJ" +
           "CgIAAAABABkAAABDb25uZWN0aW9uQ29kZU1hY2hpbmVTaWRlAQG+JgAuAES+JgAAAQEIJ/////8BAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CutterStatus Variable.
        /// </summary>
        public CutterStatusState<CutterStatusValueTypeEnum> CutterStatus
        {
            get
            {
                return m_cutterStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cutterStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cutterStatus = value;
            }
        }

        /// <summary>
        /// A description for the ReconditionCount Variable.
        /// </summary>
        public ReconditionCountState ReconditionCount
        {
            get
            {
                return m_reconditionCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_reconditionCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_reconditionCount = value;
            }
        }

        /// <summary>
        /// A description for the ToolLife Variable.
        /// </summary>
        public LifeState ToolLife
        {
            get
            {
                return m_toolLife;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toolLife, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toolLife = value;
            }
        }

        /// <summary>
        /// A description for the ProgramToolNumber Variable.
        /// </summary>
        public ProgramSpindleSpeedState ProgramToolNumber
        {
            get
            {
                return m_programToolNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programToolNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programToolNumber = value;
            }
        }

        /// <summary>
        /// A description for the Location Variable.
        /// </summary>
        public LocationState Location
        {
            get
            {
                return m_location;
            }

            set
            {
                if (!Object.ReferenceEquals(m_location, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_location = value;
            }
        }

        /// <summary>
        /// A description for the ProgramSpindleSpeed Variable.
        /// </summary>
        public ProgramSpindleSpeedState ProgramSpindleSpeed
        {
            get
            {
                return m_programSpindleSpeed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programSpindleSpeed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programSpindleSpeed = value;
            }
        }

        /// <summary>
        /// A description for the ProgramFeedRate Property.
        /// </summary>
        public PropertyState<string> ProgramFeedRate
        {
            get
            {
                return m_programFeedRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programFeedRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programFeedRate = value;
            }
        }

        /// <summary>
        /// A description for the ConnectionCodeMachineSide Property.
        /// </summary>
        public PropertyState<string> ConnectionCodeMachineSide
        {
            get
            {
                return m_connectionCodeMachineSide;
            }

            set
            {
                if (!Object.ReferenceEquals(m_connectionCodeMachineSide, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_connectionCodeMachineSide = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cutterStatus != null)
            {
                children.Add(m_cutterStatus);
            }

            if (m_reconditionCount != null)
            {
                children.Add(m_reconditionCount);
            }

            if (m_toolLife != null)
            {
                children.Add(m_toolLife);
            }

            if (m_programToolNumber != null)
            {
                children.Add(m_programToolNumber);
            }

            if (m_location != null)
            {
                children.Add(m_location);
            }

            if (m_programSpindleSpeed != null)
            {
                children.Add(m_programSpindleSpeed);
            }

            if (m_programFeedRate != null)
            {
                children.Add(m_programFeedRate);
            }

            if (m_connectionCodeMachineSide != null)
            {
                children.Add(m_connectionCodeMachineSide);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CutterStatus:
                {
                    if (createOrReplace)
                    {
                        if (CutterStatus == null)
                        {
                            if (replacement == null)
                            {
                                CutterStatus = new CutterStatusState<CutterStatusValueTypeEnum>(this);
                            }
                            else
                            {
                                CutterStatus = (CutterStatusState<CutterStatusValueTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CutterStatus;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ReconditionCount:
                {
                    if (createOrReplace)
                    {
                        if (ReconditionCount == null)
                        {
                            if (replacement == null)
                            {
                                ReconditionCount = new ReconditionCountState(this);
                            }
                            else
                            {
                                ReconditionCount = (ReconditionCountState)replacement;
                            }
                        }
                    }

                    instance = ReconditionCount;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ToolLife:
                {
                    if (createOrReplace)
                    {
                        if (ToolLife == null)
                        {
                            if (replacement == null)
                            {
                                ToolLife = new LifeState(this);
                            }
                            else
                            {
                                ToolLife = (LifeState)replacement;
                            }
                        }
                    }

                    instance = ToolLife;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ProgramToolNumber:
                {
                    if (createOrReplace)
                    {
                        if (ProgramToolNumber == null)
                        {
                            if (replacement == null)
                            {
                                ProgramToolNumber = new ProgramSpindleSpeedState(this);
                            }
                            else
                            {
                                ProgramToolNumber = (ProgramSpindleSpeedState)replacement;
                            }
                        }
                    }

                    instance = ProgramToolNumber;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Location:
                {
                    if (createOrReplace)
                    {
                        if (Location == null)
                        {
                            if (replacement == null)
                            {
                                Location = new LocationState(this);
                            }
                            else
                            {
                                Location = (LocationState)replacement;
                            }
                        }
                    }

                    instance = Location;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ProgramSpindleSpeed:
                {
                    if (createOrReplace)
                    {
                        if (ProgramSpindleSpeed == null)
                        {
                            if (replacement == null)
                            {
                                ProgramSpindleSpeed = new ProgramSpindleSpeedState(this);
                            }
                            else
                            {
                                ProgramSpindleSpeed = (ProgramSpindleSpeedState)replacement;
                            }
                        }
                    }

                    instance = ProgramSpindleSpeed;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ProgramFeedRate:
                {
                    if (createOrReplace)
                    {
                        if (ProgramFeedRate == null)
                        {
                            if (replacement == null)
                            {
                                ProgramFeedRate = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProgramFeedRate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProgramFeedRate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ConnectionCodeMachineSide:
                {
                    if (createOrReplace)
                    {
                        if (ConnectionCodeMachineSide == null)
                        {
                            if (replacement == null)
                            {
                                ConnectionCodeMachineSide = new PropertyState<string>(this);
                            }
                            else
                            {
                                ConnectionCodeMachineSide = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ConnectionCodeMachineSide;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private CutterStatusState<CutterStatusValueTypeEnum> m_cutterStatus;
        private ReconditionCountState m_reconditionCount;
        private LifeState m_toolLife;
        private ProgramSpindleSpeedState m_programToolNumber;
        private LocationState m_location;
        private ProgramSpindleSpeedState m_programSpindleSpeed;
        private PropertyState<string> m_programFeedRate;
        private PropertyState<string> m_connectionCodeMachineSide;
        #endregion
    }
    #endif
    #endregion

    #region CutterStatusState Class
    #if (!OPCUA_EXCLUDE_CutterStatusState)
    /// <summary>
    /// Stores an instance of the CutterStatusType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CutterStatusState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CutterStatusState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.CutterStatusType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "GAAAAEN1dHRlclN0YXR1c1R5cGVJbnN0YW5jZQEBvyYBAb8mABgBAf////8BAAAAFWCJCgIAAAABAAYA" +
           "AABTdGF0dXMBAcAmAC4ARMAmAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Status Property.
        /// </summary>
        public PropertyState<string> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new PropertyState<string>(this);
                            }
                            else
                            {
                                Status = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_status;
        #endregion
    }

    #region CutterStatusState<T> Class
    /// <summary>
    /// A typed version of the CutterStatusType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class CutterStatusState<T> : CutterStatusState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public CutterStatusState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ReconditionCountState Class
    #if (!OPCUA_EXCLUDE_ReconditionCountState)
    /// <summary>
    /// Stores an instance of the ReconditionCountType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReconditionCountState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReconditionCountState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ReconditionCountType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MaximumCount != null)
            {
                MaximumCount.Initialize(context, MaximumCount_InitializationString);
            }
        }

        #region Initialization String
        private const string MaximumCount_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DAAAAE1heGltdW1Db3VudAEBwiYALgBEwiYAAAEBNyf/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HAAAAFJlY29uZGl0aW9uQ291bnRUeXBlSW5zdGFuY2UBAcEmAQHBJgAYAQH/////AQAAABVgiQoCAAAA" +
           "AQAMAAAATWF4aW11bUNvdW50AQHCJgAuAETCJgAAAQE3J/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MaximumCount Property.
        /// </summary>
        public PropertyState MaximumCount
        {
            get
            {
                return m_maximumCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximumCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximumCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximumCount != null)
            {
                children.Add(m_maximumCount);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.MaximumCount:
                {
                    if (createOrReplace)
                    {
                        if (MaximumCount == null)
                        {
                            if (replacement == null)
                            {
                                MaximumCount = new PropertyState(this);
                            }
                            else
                            {
                                MaximumCount = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = MaximumCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_maximumCount;
        #endregion
    }

    #region ReconditionCountState<T> Class
    /// <summary>
    /// A typed version of the ReconditionCountType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ReconditionCountState<T> : ReconditionCountState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ReconditionCountState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LifeState Class
    #if (!OPCUA_EXCLUDE_LifeState)
    /// <summary>
    /// Stores an instance of the LifeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LifeState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LifeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LifeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (WarningLevel != null)
            {
                WarningLevel.Initialize(context, WarningLevel_InitializationString);
            }
        }

        #region Initialization String
        private const string WarningLevel_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DAAAAFdhcm5pbmdMZXZlbAEBxiYALgBExiYAAAEBZCf/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "EAAAAExpZmVUeXBlSW5zdGFuY2UBAcMmAQHDJgAYAQH/////BAAAABVgiQoCAAAAAQAEAAAAVHlwZQEB" +
           "xCYALgBExCYAAAEBYif/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQ291bnREaXJlY3Rpb24BAcUm" +
           "AC4ARMUmAAABAWAn/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFdhcm5pbmdMZXZlbAEBxiYALgBE" +
           "xiYAAAEBZCf/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEBxyYALgBExyYAAAEBZCf/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Type Property.
        /// </summary>
        public PropertyState<ToolLifeTypeEnum> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <summary>
        /// A description for the CountDirection Property.
        /// </summary>
        public PropertyState<ToolLifeDirectionTypeEnum> CountDirection
        {
            get
            {
                return m_countDirection;
            }

            set
            {
                if (!Object.ReferenceEquals(m_countDirection, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_countDirection = value;
            }
        }

        /// <summary>
        /// A description for the WarningLevel Property.
        /// </summary>
        public PropertyState<float> WarningLevel
        {
            get
            {
                return m_warningLevel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_warningLevel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_warningLevel = value;
            }
        }

        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_countDirection != null)
            {
                children.Add(m_countDirection);
            }

            if (m_warningLevel != null)
            {
                children.Add(m_warningLevel);
            }

            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<ToolLifeTypeEnum>(this);
                            }
                            else
                            {
                                Type = (PropertyState<ToolLifeTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.CountDirection:
                {
                    if (createOrReplace)
                    {
                        if (CountDirection == null)
                        {
                            if (replacement == null)
                            {
                                CountDirection = new PropertyState<ToolLifeDirectionTypeEnum>(this);
                            }
                            else
                            {
                                CountDirection = (PropertyState<ToolLifeDirectionTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CountDirection;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.WarningLevel:
                {
                    if (createOrReplace)
                    {
                        if (WarningLevel == null)
                        {
                            if (replacement == null)
                            {
                                WarningLevel = new PropertyState<float>(this);
                            }
                            else
                            {
                                WarningLevel = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = WarningLevel;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ToolLifeTypeEnum> m_type;
        private PropertyState<ToolLifeDirectionTypeEnum> m_countDirection;
        private PropertyState<float> m_warningLevel;
        private PropertyState<float> m_maximum;
        #endregion
    }

    #region LifeState<T> Class
    /// <summary>
    /// A typed version of the LifeType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LifeState<T> : LifeState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LifeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LocationState Class
    #if (!OPCUA_EXCLUDE_LocationState)
    /// <summary>
    /// Stores an instance of the LocationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LocationState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LocationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LocationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "FAAAAExvY2F0aW9uVHlwZUluc3RhbmNlAQHIJgEByCYAGAEB/////wMAAAAVYIkKAgAAAAEABAAAAFR5" +
           "cGUBAckmAC4ARMkmAAABATIn/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE5lZ2F0aXZlT3Zlcmxh" +
           "cAEByiYALgBEyiYAAAEBRyf/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUG9zaXRpdmVPdmVybGFw" +
           "AQHLJgAuAETLJgAAAQFHJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Type Property.
        /// </summary>
        public PropertyState<LocationsTypeEnum> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <summary>
        /// A description for the NegativeOverlap Property.
        /// </summary>
        public PropertyState NegativeOverlap
        {
            get
            {
                return m_negativeOverlap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_negativeOverlap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_negativeOverlap = value;
            }
        }

        /// <summary>
        /// A description for the PositiveOverlap Property.
        /// </summary>
        public PropertyState PositiveOverlap
        {
            get
            {
                return m_positiveOverlap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positiveOverlap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positiveOverlap = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_negativeOverlap != null)
            {
                children.Add(m_negativeOverlap);
            }

            if (m_positiveOverlap != null)
            {
                children.Add(m_positiveOverlap);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<LocationsTypeEnum>(this);
                            }
                            else
                            {
                                Type = (PropertyState<LocationsTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NegativeOverlap:
                {
                    if (createOrReplace)
                    {
                        if (NegativeOverlap == null)
                        {
                            if (replacement == null)
                            {
                                NegativeOverlap = new PropertyState(this);
                            }
                            else
                            {
                                NegativeOverlap = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = NegativeOverlap;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.PositiveOverlap:
                {
                    if (createOrReplace)
                    {
                        if (PositiveOverlap == null)
                        {
                            if (replacement == null)
                            {
                                PositiveOverlap = new PropertyState(this);
                            }
                            else
                            {
                                PositiveOverlap = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = PositiveOverlap;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocationsTypeEnum> m_type;
        private PropertyState m_negativeOverlap;
        private PropertyState m_positiveOverlap;
        #endregion
    }

    #region LocationState<T> Class
    /// <summary>
    /// A typed version of the LocationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LocationState<T> : LocationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LocationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ProgramSpindleSpeedState Class
    #if (!OPCUA_EXCLUDE_ProgramSpindleSpeedState)
    /// <summary>
    /// Stores an instance of the ProgramSpindleSpeedType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramSpindleSpeedState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramSpindleSpeedState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ProgramSpindleSpeedType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HwAAAFByb2dyYW1TcGluZGxlU3BlZWRUeXBlSW5zdGFuY2UBAcwmAQHMJgAYAQH/////AwAAABVgiQoC" +
           "AAAAAQAHAAAATWF4aW11bQEBzSYALgBEzSYAAAEBOCf/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "TWluaW11bQEBziYALgBEziYAAAEBOif/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATm9taW5hbAEB" +
           "zyYALgBEzyYAAAEBQif/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <summary>
        /// A description for the Minimum Property.
        /// </summary>
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <summary>
        /// A description for the Nominal Property.
        /// </summary>
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region ProgramSpindleSpeedState<T> Class
    /// <summary>
    /// A typed version of the ProgramSpindleSpeedType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProgramSpindleSpeedState<T> : ProgramSpindleSpeedState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ProgramSpindleSpeedState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ProgramFeedRateState Class
    #if (!OPCUA_EXCLUDE_ProgramFeedRateState)
    /// <summary>
    /// Stores an instance of the ProgramFeedRateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramFeedRateState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramFeedRateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ProgramFeedRateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "GwAAAFByb2dyYW1GZWVkUmF0ZVR5cGVJbnN0YW5jZQEB0CYBAdAmABgBAf////8DAAAAFWCJCgIAAAAB" +
           "AAcAAABNYXhpbXVtAQHRJgAuAETRJgAAAQE4J/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNaW5p" +
           "bXVtAQHSJgAuAETSJgAAAQE6J/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFsAQHTJgAu" +
           "AETTJgAAAQFCJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <summary>
        /// A description for the Minimum Property.
        /// </summary>
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <summary>
        /// A description for the Nominal Property.
        /// </summary>
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region ProgramFeedRateState<T> Class
    /// <summary>
    /// A typed version of the ProgramFeedRateType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProgramFeedRateState<T> : ProgramFeedRateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ProgramFeedRateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region CuttingItemState Class
    #if (!OPCUA_EXCLUDE_CuttingItemState)
    /// <summary>
    /// Stores an instance of the CuttingItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingItemState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.CuttingItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ItemId != null)
            {
                ItemId.Initialize(context, ItemId_InitializationString);
            }

            if (Grade != null)
            {
                Grade.Initialize(context, Grade_InitializationString);
            }

            if (Manufacturers != null)
            {
                Manufacturers.Initialize(context, Manufacturers_InitializationString);
            }

            if (Description != null)
            {
                Description.Initialize(context, Description_InitializationString);
            }

            if (Locus != null)
            {
                Locus.Initialize(context, Locus_InitializationString);
            }

            if (ItemLife != null)
            {
                ItemLife.Initialize(context, ItemLife_InitializationString);
            }

            if (Measurements != null)
            {
                Measurements.Initialize(context, Measurements_InitializationString);
            }
        }

        #region Initialization String
        private const string ItemId_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BgAAAEl0ZW1JZAEB1iYALgBE1iYAAAEBLCf/////AQH/////AAAAAA==";

        private const string Grade_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAEdyYWRlAQHXJgAuAETXJgAAAQEpJ/////8BAf////8AAAAA";

        private const string Manufacturers_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DQAAAE1hbnVmYWN0dXJlcnMBAdgmAC4ARNgmAAABATUn/////wEB/////wAAAAA=";

        private const string Description_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAERlc2NyaXB0aW9uAQHZJgAuAETZJgAAAQHvJv////8BAf////8AAAAA";

        private const string Locus_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAExvY3VzAQHaJgAuAETaJgAAAQE0J/////8BAf////8AAAAA";

        private const string ItemLife_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "CAAAAEl0ZW1MaWZlAQHbJgAvAD3bJgAA/////wAAAAA=";

        private const string Measurements_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "DAAAAE1lYXN1cmVtZW50cwEB3CYALwA93CYAAP////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "FwAAAEN1dHRpbmdJdGVtVHlwZUluc3RhbmNlAQHUJgEB1CYAGAEB/////wgAAAAVYIkKAgAAAAEABwAA" +
           "AEluZGljZXMBAdUmAC4ARNUmAAABASon/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAEl0ZW1JZAEB" +
           "1iYALgBE1iYAAAEBLCf/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAR3JhZGUBAdcmAC4ARNcmAAAB" +
           "ASkn/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAE1hbnVmYWN0dXJlcnMBAdgmAC4ARNgmAAABATUn" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERlc2NyaXB0aW9uAQHZJgAuAETZJgAAAQHvJv////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAUAAABMb2N1cwEB2iYALgBE2iYAAAEBNCf/////AQH/////AAAAAARg" +
           "gAoBAAAAAQAIAAAASXRlbUxpZmUBAdsmAC8APdsmAAD/////AAAAAARggAoBAAAAAQAMAAAATWVhc3Vy" +
           "ZW1lbnRzAQHcJgAvAD3cJgAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Indices Property.
        /// </summary>
        public PropertyState<string> Indices
        {
            get
            {
                return m_indices;
            }

            set
            {
                if (!Object.ReferenceEquals(m_indices, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indices = value;
            }
        }

        /// <summary>
        /// A description for the ItemId Property.
        /// </summary>
        public PropertyState<string> ItemId
        {
            get
            {
                return m_itemId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_itemId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_itemId = value;
            }
        }

        /// <summary>
        /// A description for the Grade Property.
        /// </summary>
        public PropertyState<string> Grade
        {
            get
            {
                return m_grade;
            }

            set
            {
                if (!Object.ReferenceEquals(m_grade, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_grade = value;
            }
        }

        /// <summary>
        /// A description for the Manufacturers Property.
        /// </summary>
        public PropertyState<string> Manufacturers
        {
            get
            {
                return m_manufacturers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturers = value;
            }
        }

        /// <summary>
        /// A description for the Description Property.
        /// </summary>
        public PropertyState<string> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <summary>
        /// A description for the Locus Property.
        /// </summary>
        public PropertyState<string> Locus
        {
            get
            {
                return m_locus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_locus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locus = value;
            }
        }

        /// <summary>
        /// A description for the ItemLife Object.
        /// </summary>
        public FolderState ItemLife
        {
            get
            {
                return m_itemLife;
            }

            set
            {
                if (!Object.ReferenceEquals(m_itemLife, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_itemLife = value;
            }
        }

        /// <summary>
        /// A description for the Measurements Object.
        /// </summary>
        public FolderState Measurements
        {
            get
            {
                return m_measurements;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurements, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurements = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_indices != null)
            {
                children.Add(m_indices);
            }

            if (m_itemId != null)
            {
                children.Add(m_itemId);
            }

            if (m_grade != null)
            {
                children.Add(m_grade);
            }

            if (m_manufacturers != null)
            {
                children.Add(m_manufacturers);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_locus != null)
            {
                children.Add(m_locus);
            }

            if (m_itemLife != null)
            {
                children.Add(m_itemLife);
            }

            if (m_measurements != null)
            {
                children.Add(m_measurements);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Indices:
                {
                    if (createOrReplace)
                    {
                        if (Indices == null)
                        {
                            if (replacement == null)
                            {
                                Indices = new PropertyState<string>(this);
                            }
                            else
                            {
                                Indices = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Indices;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ItemId:
                {
                    if (createOrReplace)
                    {
                        if (ItemId == null)
                        {
                            if (replacement == null)
                            {
                                ItemId = new PropertyState<string>(this);
                            }
                            else
                            {
                                ItemId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ItemId;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Grade:
                {
                    if (createOrReplace)
                    {
                        if (Grade == null)
                        {
                            if (replacement == null)
                            {
                                Grade = new PropertyState<string>(this);
                            }
                            else
                            {
                                Grade = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Grade;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Manufacturers:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturers == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturers = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturers = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturers;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new PropertyState<string>(this);
                            }
                            else
                            {
                                Description = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Locus:
                {
                    if (createOrReplace)
                    {
                        if (Locus == null)
                        {
                            if (replacement == null)
                            {
                                Locus = new PropertyState<string>(this);
                            }
                            else
                            {
                                Locus = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Locus;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ItemLife:
                {
                    if (createOrReplace)
                    {
                        if (ItemLife == null)
                        {
                            if (replacement == null)
                            {
                                ItemLife = new FolderState(this);
                            }
                            else
                            {
                                ItemLife = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ItemLife;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Measurements:
                {
                    if (createOrReplace)
                    {
                        if (Measurements == null)
                        {
                            if (replacement == null)
                            {
                                Measurements = new FolderState(this);
                            }
                            else
                            {
                                Measurements = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Measurements;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_indices;
        private PropertyState<string> m_itemId;
        private PropertyState<string> m_grade;
        private PropertyState<string> m_manufacturers;
        private PropertyState<string> m_description;
        private PropertyState<string> m_locus;
        private FolderState m_itemLife;
        private FolderState m_measurements;
        #endregion
    }

    #region CuttingItemState<T> Class
    /// <summary>
    /// A typed version of the CuttingItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class CuttingItemState<T> : CuttingItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public CuttingItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AssemblyMeasurementState Class
    #if (!OPCUA_EXCLUDE_AssemblyMeasurementState)
    /// <summary>
    /// Stores an instance of the AssemblyMeasurementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssemblyMeasurementState : MeasurementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AssemblyMeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AssemblyMeasurementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HwAAAEFzc2VtYmx5TWVhc3VyZW1lbnRUeXBlSW5zdGFuY2UBAd0mAQHdJgAa/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAeEmAC4AROEmAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AssemblyMeasurementState<T> Class
    /// <summary>
    /// A typed version of the AssemblyMeasurementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AssemblyMeasurementState<T> : AssemblyMeasurementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AssemblyMeasurementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion
}
