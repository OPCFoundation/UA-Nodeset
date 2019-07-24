/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FQAAAE1URGV2aWNlc1R5cGVJbnN0YW5jZQEB1hkBAdYZ1hkAAP////8DAAAAFWCJCgIAAAABABAAAABN" +
           "VENvbm5lY3RWZXJzaW9uAQHXGQAvAD/XGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAT1BD" +
           "VUFNYXBwaW5nRGF0ZQEB2BkALwA/2BkAAAAN/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE9QQ1VB" +
           "VmVyc2lvbgEB2RkALwA/2RkAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FAAAAE1URGV2aWNlVHlwZUluc3RhbmNlAQHaGQEB2hnaGQAA/////wgAAAAVYIkKAgAAAAEADAAAAEF2" +
           "YWlsYWJpbGl0eQEB2xkALwEAPQnbGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZh" +
           "Y3R1cmVyAQHeGQAuAETeGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVy" +
           "AQHfGQAuAETfGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQANAAAAQ29uZmlndXJhdGlvbgEB4BkA" +
           "LgBE4BkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAFNhbXBsZUludGVydmFsAQHhGQAuAETh" +
           "GQAAAQAiAf////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAeIZAC8APeIZAAD/////" +
           "AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEB4xkALwA94xkAAP////8AAAAABGCACgEAAAABAAoA" +
           "AABDb25kaXRpb25zAQHkGQAvAD3kGQAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FwAAAE1UQ29tcG9uZW50VHlwZUluc3RhbmNlAQHlGQEB5RnlGQAA/////wcAAAAVYIkKAgAAAAEADAAA" +
           "AEF2YWlsYWJpbGl0eQEB5hkALwEAPQnmGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFu" +
           "dWZhY3R1cmVyAQHpGQAuAETpGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVt" +
           "YmVyAQHqGQAuAETqGQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQHtGQAv" +
           "AD3tGQAA/////wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAe4ZAC8APe4ZAAD/////AAAAABVg" +
           "iQoCAAAAAQAFAAAATW9kZWwBAfAZAC4ARPAZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAcAAABT" +
           "dGF0aW9uAQHxGQAuAETxGQAAAQAiAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "EgAAAE1UQXhlc1R5cGVJbnN0YW5jZQEB8hkBAfIZ8hkAAP////8LAAAAFWCJCgIAAAABAAwAAABBdmFp" +
           "bGFiaWxpdHkBAfMZAC8BAD0J8xkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0" +
           "dXJlcgEB9hkALgBE9hkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEB" +
           "9xkALgBE9xkAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEB+hkALwA9+hkA" +
           "AP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQH7GQAvAD37GQAA/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAExpbmVhckF4ZXNYAQH9GQAuAET9GQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "TGluZWFyQXhlc1kBAf4ZAC4ARP4ZAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABMaW5lYXJB" +
           "eGVzWgEB/xkALgBE/xkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAFJvdG9yeUF4ZXNBAQEA" +
           "GgAuAEQAGgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAUm90b3J5QXhlc0IBAQEaAC4ARAEa" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABSb3RvcnlBeGVzQwEBAhoALgBEAhoAAAAM////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GAAAAE1UQ29udHJvbGxlclR5cGVJbnN0YW5jZQEBAxoBAQMaAxoAAP////8FAAAAFWCJCgIAAAABAAwA" +
           "AABBdmFpbGFiaWxpdHkBAQQaAC8BAD0JBBoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1h" +
           "bnVmYWN0dXJlcgEBBxoALgBEBxoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51" +
           "bWJlcgEBCBoALgBECBoAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBCxoA" +
           "LwA9CxoAAP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQEMGgAvAD0MGgAA/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "EgAAAE1URG9vclR5cGVJbnN0YW5jZQEBDhoBAQ4aDhoAAP////8GAAAAFWCJCgIAAAABAAwAAABBdmFp" +
           "bGFiaWxpdHkBAQ8aAC8BAD0JDxoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0" +
           "dXJlcgEBEhoALgBEEhoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEB" +
           "ExoALgBEExoAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBFhoALwA9FhoA" +
           "AP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQEXGgAvAD0XGgAA/////wAAAAAVYIkKAgAA" +
           "AAEACQAAAERvb3JTdGF0ZQEBGRoALgBEGRoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FgAAAE1UQWN0dWF0b3JUeXBlSW5zdGFuY2UBARoaAQEaGhoaAAD/////BgAAABVgiQoCAAAAAQAMAAAA" +
           "QXZhaWxhYmlsaXR5AQEbGgAvAQA9CRsaAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51" +
           "ZmFjdHVyZXIBAR4aAC4ARB4aAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1i" +
           "ZXIBAR8aAC4ARB8aAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBASIaAC8A" +
           "PSIaAAD/////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBIxoALwA9IxoAAP////8AAAAAFWCJ" +
           "CgIAAAABAAsAAABMaW5lYXJBeGVzWAEBJRoALgBEJRoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HAAAAE1UU2FtcGxlRGF0YUl0ZW1UeXBlSW5zdGFuY2UBASYaAQEmGiYaAAAAGv7///8BAf////8FAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQEqGgAuAEQqGgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "ABAAAABDb29yZGluYXRlU3lzdGVtAQEsGgAuAEQsGgAAAQEDJ/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABOYXRpdmVVbml0cwEBLRoALgBELRoAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "TmF0aXZlU2NhbGUBAS4aAC4ARC4aAAAACv////8BAf////8AAAAAFWCJCgIAAAABAA4AAABTYW1wbGVJ" +
           "bnRlcnZhbAEBLxoALgBELxoAAAEAIgH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAEFjY2VsZXJhdGlvblR5cGVJbnN0YW5jZQEBMBoBATAaMBoAAAAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBATQaAC4ARDQaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GwAAAEFjY3VtdWxhdGVkVGltZVR5cGVJbnN0YW5jZQEBOhoBAToaOhoAAAAa/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAT4aAC4ARD4aAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAEFtcGVyYWdlVHlwZUluc3RhbmNlAQFEGgEBRBpEGgAAABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBSBoALgBESBoAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EQAAAEFuZ2xlVHlwZUluc3RhbmNlAQFOGgEBThpOGgAAABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBUhoALgBEUhoAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HwAAAEFuZ3VsYXJBY2NlbGVyYXRpb25UeXBlSW5zdGFuY2UBAVgaAQFYGlgaAAAAGv////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFcGgAuAERcGgAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GwAAAEFuZ3VsYXJWZWxvY2l0eVR5cGVJbnN0YW5jZQEBYhoBAWIaYhoAAAAa/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAWYaAC4ARGYaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAEF4aXNGZWVkcmF0ZVR5cGVJbnN0YW5jZQEBbBoBAWwabBoAAAAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAXAaAC4ARHAaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GQAAAENvbmNlbnRyYXRpb25UeXBlSW5zdGFuY2UBAXYaAQF2GnYaAAAAGv////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQF6GgAuAER6GgAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAENvbmR1Y3Rpdml0eVR5cGVJbnN0YW5jZQEBgBoBAYAagBoAAAAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAYQaAC4ARIQaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAERpc3BsYWNlbWVudFR5cGVJbnN0YW5jZQEBihoBAYoaihoAAAAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAY4aAC4ARI4aAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HAAAAEVsZWN0cmljYWxFbmVyZ3lUeXBlSW5zdGFuY2UBAZQaAQGUGpQaAAAAGv////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQGYGgAuAESYGgAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAEZpbGxMZXZlbFR5cGVJbnN0YW5jZQEBnhoBAZ4anhoAAAAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAaIaAC4ARKIaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EAAAAEZsb3dUeXBlSW5zdGFuY2UBAagaAQGoGqgaAAAAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQGsGgAuAESsGgAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAEZyZXF1ZW5jeVR5cGVJbnN0YW5jZQEBshoBAbIashoAAAAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAbYaAC4ARLYaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAExpbmVhckZvcmNlVHlwZUluc3RhbmNlAQG8GgEBvBq8GgAAABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBwBoALgBEwBoAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EAAAAExvYWRUeXBlSW5zdGFuY2UBAcYaAQHGGsYaAAAAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQHKGgAuAETKGgAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EAAAAE1hc3NUeXBlSW5zdGFuY2UBAdAaAQHQGtAaAAAAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQHUGgAuAETUGgAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAFBhdGhGZWVkcmF0ZVR5cGVJbnN0YW5jZQEB2hoBAdoa2hoAAAAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAd4aAC4ARN4aAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAFBhdGhQb3NpdGlvblR5cGVJbnN0YW5jZQEB5BoBAeQa5BoAAAAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAegaAC4AROgaAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "DgAAAFBIVHlwZUluc3RhbmNlAQHuGgEB7hruGgAAABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEB8hoALgBE8hoAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAFBvc2l0aW9uVHlwZUluc3RhbmNlAQH4GgEB+Br4GgAAABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB/BoALgBE/BoAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAFBvd2VyRmFjdG9yVHlwZUluc3RhbmNlAQECGwEBAhsCGwAAABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBBhsALgBEBhsAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAFByZXNzdXJlVHlwZUluc3RhbmNlAQEMGwEBDBsMGwAAABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBEBsALgBEEBsAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAFJlc2lzdGFuY2VUeXBlSW5zdGFuY2UBARYbAQEWGxYbAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQEaGwAuAEQaGwAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HgAAAFJvdGF0aW9uYWxWZWxvY2l0eVR5cGVJbnN0YW5jZQEBIBsBASAbIBsAAAAa/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBASQbAC4ARCQbAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GQAAAFNvdW5kUHJlc3N1cmVUeXBlSW5zdGFuY2UBASobAQEqGyobAAAAGv////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQEuGwAuAEQuGwAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EgAAAFN0cmFpblR5cGVJbnN0YW5jZQEBNBsBATQbNBsAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBATgbAC4ARDgbAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAFRlbXBlcmF0dXJlVHlwZUluc3RhbmNlAQE+GwEBPhs+GwAAABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBQhsALgBEQhsAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EAAAAFRpbHRUeXBlSW5zdGFuY2UBAUgbAQFIG0gbAAAAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQFMGwAuAERMGwAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EgAAAFRvcnF1ZVR5cGVJbnN0YW5jZQEBUhsBAVIbUhsAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAVYbAC4ARFYbAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAFZlbG9jaXR5VHlwZUluc3RhbmNlAQFcGwEBXBtcGwAAABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBYBsALgBEYBsAAAEAdAP/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAFZpc2Nvc2l0eVR5cGVJbnN0YW5jZQEBZhsBAWYbZhsAAAAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAWobAC4ARGobAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EwAAAFZvbHRhZ2VUeXBlSW5zdGFuY2UBAXAbAQFwG3AbAAAAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQF0GwAuAER0GwAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAFZvbHRBbXBlcmVUeXBlSW5zdGFuY2UBAXobAQF6G3obAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQF+GwAuAER+GwAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HgAAAFZvbHRBbXBlcmVSZWFjdGl2ZVR5cGVJbnN0YW5jZQEBhBsBAYQbhBsAAAAa/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAYgbAC4ARIgbAAABAHQD/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EwAAAFdhdHRhZ2VUeXBlSW5zdGFuY2UBAY4bAQGOG44bAAAAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGSGwAuAESSGwAAAQB0A/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GwAAAE1URXZlbnREYXRhSXRlbVR5cGVJbnN0YW5jZQEBmBsBAZgbmBsAAAAY/////wEB/////wIAAAAV" +
           "YIkKAgAAAAEAEAAAAENvb3JkaW5hdGVTeXN0ZW0BAZsbAC4ARJsbAAABAQMn/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEADgAAAFNhbXBsZUludGVydmFsAQGcGwAuAEScGwAAAQAiAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAEFjdGl2ZUF4ZXNUeXBlSW5zdGFuY2UBAZ0bAQGdG50bAAAADP////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GQAAAEFjdHVhdG9yU3RhdGVUeXBlSW5zdGFuY2UBAaIbAQGiG6IbAAABAesm/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAEF2YWlsYWJpbGl0eVR5cGVJbnN0YW5jZQEBpxsBAacbpxsAAAEB8yb/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAEF4ZXNDb3VwbGluZ1R5cGVJbnN0YW5jZQEBrBsBAawbrBsAAAEB9Sb/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EQAAAEJsb2NrVHlwZUluc3RhbmNlAQHrAwEB6wPrAwAAAAz/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAENsYW1wU3RhdGVUeXBlSW5zdGFuY2UBAbUbAQG1G7UbAAABAf4m/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GgAAAENvbnRyb2xsZXJNb2RlVHlwZUluc3RhbmNlAQG6GwEBuhu6GwAAAQEBJ/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAENvdXBsZWRBeGVzVHlwZUluc3RhbmNlAQG/GwEBvxu/GwAAAAz/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAERpcmVjdGlvblR5cGVJbnN0YW5jZQEBxBsBAcQbxBsAAAEBGif/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAERvb3JTdGF0ZVR5cGVJbnN0YW5jZQEByRsBAckbyRsAAAEBHCf/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GQAAAEVtZXJnZW5jeVN0b3BUeXBlSW5zdGFuY2UBAc4bAQHOG84bAAABASEn/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAEV4ZWN1dGlvblR5cGVJbnN0YW5jZQEB0xsBAdMb0xsAAAEBJCf/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EAAAAExpbmVUeXBlSW5zdGFuY2UBAdgbAQHYG9gbAAAABf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EwAAAE1lc3NhZ2VUeXBlSW5zdGFuY2UBAd0bAQHdG90bAAAADP////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAFBhbGxldElkVHlwZUluc3RhbmNlAQHiGwEB4hviGwAAAAz/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FQAAAFBhcnRDb3VudFR5cGVJbnN0YW5jZQEB5xsBAecb5xsAAAAF/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EgAAAFBhcnRJZFR5cGVJbnN0YW5jZQEB7BsBAewb7BsAAAAM/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAFBhdGhNb2RlVHlwZUluc3RhbmNlAQHxGwEB8RvxGwAAAQFIJ/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAFBvd2VyU3RhdGVUeXBlSW5zdGFuY2UBAfYbAQH2G/YbAAABAUon/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EwAAAFByb2dyYW1UeXBlSW5zdGFuY2UBAfsbAQH7G/sbAAAADP////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAFJvdGFyeU1vZGVUeXBlSW5zdGFuY2UBAQAcAQEAHAAcAAABAVEn/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAFRvb2xBc3NldElkVHlwZUluc3RhbmNlAQEFHAEBBRwFHAAAAAz/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FgAAAFRvb2xOdW1iZXJUeXBlSW5zdGFuY2UBAQocAQEKHAocAAAABf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GQAAAFdvcmtIb2xkaW5nSWRUeXBlSW5zdGFuY2UBAQ8cAQEPHA8cAAAADP////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FwAAAE1UQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEUHAEBFBwUHAAA/////xsAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBARUcAC4ARBUcAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "ARYcAC4ARBYcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEXHAAuAEQX" +
           "HAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBGBwALgBEGBwAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBARkcAC4ARBkcAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEaHAAuAEQaHAAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAkAAABMb2NhbFRpbWUBARscAC4ARBscAAABANAi/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AE1lc3NhZ2UBARwcAC4ARBwcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0eQEB" +
           "HRwALgBEHRwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAR4c" +
           "AC4ARB4cAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBAR8c" +
           "AC4ARB8cAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEgHAAuAEQg" +
           "HAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBASEcAC4ARCEcAAAAEf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BASIcAC4ARCIcAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAwAAABFbmFibGVkU3RhdGUBASMcAC8BACMjIxwAAAAV/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAAAgAAAElkAQEkHAAuAEQkHAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEB" +
           "LBwALwEAKiMsHAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEt" +
           "HAAuAEQtHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAS4cAC8B" +
           "ACojLhwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBLxwALgBE" +
           "LxwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBMBwALwEAKiMwHAAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQExHAAuAEQxHAAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBATIcAC4ARDIcAAAADP////8BAf//" +
           "//8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEzHAAvAQBEIzMcAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAYAAABFbmFibGUBATQcAC8BAEMjNBwAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAA" +
           "AAAACgAAAEFkZENvbW1lbnQBATUcAC8BAEUjNRwAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQE2HAAuAEQ2HAAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP////" +
           "/wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFC" +
           "AAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBj" +
           "b25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3VycmVudFN0" +
           "YXRlAQE5HAAvAD85HAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3RhdGUBAToc" +
           "AC8BACMjOhwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE7HAAuAEQ7HAAAAAH/////" +
           "AQH/////AAAAAARggAoBAAAAAQAKAAAATGltaXRTdGF0ZQEBQxwALwEAZiRDHAAA/////wEAAAAVYIkK" +
           "AgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBRBwALwEAyApEHAAAABX/////AQH/////AQAAABVgiQoCAAAA" +
           "AAACAAAASWQBAUUcAC4AREUcAAAAEf////8BAf////8AAAAAFWCJCgIAAAABAAoAAABOYXRpdmVDb2Rl" +
           "AQFPHAAuAERPHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAOAAAATmF0aXZlU2V2ZXJpdHkBAVAc" +
           "AC4ARFAcAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IQAAAEFjY2VsZXJhdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBURwBAVEcURwAAP////8YAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQFSHAAuAERSHAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQFTHAAuAERTHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBVBwALgBEVBwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAVUcAC4A" +
           "RFUcAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFWHAAuAERWHAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBVxwALgBEVxwAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFYHAAuAERYHAAAAQDQIv////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQFZHAAuAERZHAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAVocAC4ARFocAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQFbHAAuAERbHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQFcHAAuAERcHAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBXRwALgBEXRwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFeHAAuAERe" +
           "HAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFfHAAuAERfHAAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFgHAAvAQAjI2AcAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBYRwALgBEYRwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAWkcAC8BACojaRwAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBahwALgBEahwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQFrHAAvAQAqI2scAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAWwcAC4ARGwcAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAW0cAC8B" +
           "ACojbRwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBbhwALgBE" +
           "bhwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFvHAAuAERvHAAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBcBwALwEARCNwHAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFxHAAvAQBDI3EcAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFyHAAvAQBFI3IcAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBcxwALgBEcxwAAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBdhwALwA/dhwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQF3HAAvAQAjI3ccAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBeBwALgBE" +
           "eBwAAAAB/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "JQAAAEFjY3VtdWxhdGVkX1RpbWVDb25kaXRpb25UeXBlSW5zdGFuY2UBAY4cAQGOHI4cAAD/////GAAA" +
           "ABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBjxwALgBEjxwAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CQAAAEV2ZW50VHlwZQEBkBwALgBEkBwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5vZGUBAZEcAC4ARJEcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGS" +
           "HAAuAESSHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBkxwALgBEkxwAAAEAJgH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAZQcAC4ARJQcAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBlRwALgBElRwAAAEA0CL/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBlhwALgBElhwAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQGXHAAuAESXHAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBmBwALgBEmBwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBmRwALgBEmRwAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAZocAC4ARJocAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBmxwA" +
           "LgBEmxwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBnBwALgBEnBwAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBnRwALwEAIyOdHAAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAZ4cAC4ARJ4cAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQGmHAAvAQAqI6YcAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAaccAC4ARKccAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBqBwALwEAKiOoHAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQGpHAAuAESpHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGq" +
           "HAAvAQAqI6ocAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAasc" +
           "AC4ARKscAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBrBwALgBE" +
           "rBwAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAa0cAC8BAEQjrRwAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBrhwALwEAQyOuHAAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBrxwALwEARSOvHAAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbAcAC4ARLAcAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAbMcAC8AP7McAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBtBwALwEAIyO0HAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAbUc" +
           "AC4ARLUcAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HQAAAEFtcGVyYWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHLHAEByxzLHAAA/////xgAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAcwcAC4ARMwcAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAc0cAC4ARM0cAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHO" +
           "HAAuAETOHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBzxwALgBEzxwA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAdAcAC4ARNAcAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHRHAAuAETRHAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAdIcAC4ARNIcAAABANAi/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBAdMcAC4ARNMcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEB1BwALgBE1BwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNz" +
           "SWQBAdUcAC4ARNUcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05h" +
           "bWUBAdYcAC4ARNYcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQHX" +
           "HAAuAETXHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAdgcAC4ARNgcAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAdkcAC4ARNkcAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAdocAC8BACMj2hwAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQHbHAAuAETbHAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVh" +
           "bGl0eQEB4xwALwEAKiPjHAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHkHAAuAETkHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkB" +
           "AeUcAC8BACoj5RwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "5hwALgBE5hwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB5xwALwEAKiPn" +
           "HAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHoHAAuAEToHAAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAekcAC4AROkcAAAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHqHAAvAQBEI+ocAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAescAC8BAEMj6xwAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAewcAC8BAEUj7BwAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHtHAAuAETtHAAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJ" +
           "ZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQu" +
           "AQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRv" +
           "IHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3Vy" +
           "cmVudFN0YXRlAQHwHAAvAD/wHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3Rh" +
           "dGUBAfEcAC8BACMj8RwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHyHAAuAETyHAAA" +
           "AAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GgAAAEFuZ2xlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEIHQEBCB0IHQAA/////xgAAAAVYIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAQkdAC4ARAkdAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAQodAC4ARAodAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQELHQAu" +
           "AEQLHQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBDB0ALgBEDB0AAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAQ0dAC4ARA0dAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEOHQAuAEQOHQAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAkAAABMb2NhbFRpbWUBAQ8dAC4ARA8dAAABANAi/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAE1lc3NhZ2UBARAdAC4ARBAdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0" +
           "eQEBER0ALgBEER0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQB" +
           "ARIdAC4ARBIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUB" +
           "ARMdAC4ARBMdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEUHQAu" +
           "AEQUHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBARUdAC4ARBUdAAAAEf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BARYdAC4ARBYdAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBARcdAC8BACMjFx0AAAAV/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAAAgAAAElkAQEYHQAuAEQYHQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0" +
           "eQEBIB0ALwEAKiMgHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQEhHQAuAEQhHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBASId" +
           "AC8BACojIh0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBIx0A" +
           "LgBEIx0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBJB0ALwEAKiMkHQAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQElHQAuAEQlHQAAAQAm" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBASYdAC4ARCYdAAAADP////8B" +
           "Af////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEnHQAvAQBEIycdAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAYAAABFbmFibGUBASgdAC8BAEMjKB0AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIK" +
           "BAAAAAAACgAAAEFkZENvbW1lbnQBASkdAC8BAEUjKR0AAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQEqHQAuAEQqHQAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP" +
           "/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAq" +
           "AQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRo" +
           "ZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3VycmVu" +
           "dFN0YXRlAQEtHQAvAD8tHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3RhdGUB" +
           "AS4dAC8BACMjLh0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEvHQAuAEQvHQAAAAH/" +
           "////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "KQAAAEFuZ3VsYXItQWNjZWxlcmF0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFFHQEBRR1FHQAA////" +
           "/xgAAAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAUYdAC4AREYdAAAAD/////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAkAAABFdmVudFR5cGUBAUcdAC4AREcdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABT" +
           "b3VyY2VOb2RlAQFIHQAuAERIHQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEBSR0ALgBESR0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAUodAC4AREodAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFLHQAuAERLHQAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAUwdAC4AREwdAAABANAi/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAU0dAC4ARE0dAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAgAAABTZXZlcml0eQEBTh0ALgBETh0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENv" +
           "bmRpdGlvbkNsYXNzSWQBAU8dAC4ARE8dAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25k" +
           "aXRpb25DbGFzc05hbWUBAVAdAC4ARFAdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25k" +
           "aXRpb25OYW1lAQFRHQAuAERRHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQB" +
           "AVIdAC4ARFIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAVMdAC4ARFMdAAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVQdAC8BACMjVB0AAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVHQAuAERVHQAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAUXVhbGl0eQEBXR0ALwEAKiNdHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQFeHQAuAEReHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABM" +
           "YXN0U2V2ZXJpdHkBAV8dAC8BACojXx0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBYB0ALgBEYB0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVu" +
           "dAEBYR0ALwEAKiNhHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQFiHQAuAERiHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAWMd" +
           "AC4ARGMdAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFkHQAvAQBEI2QdAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWUdAC8BAEMjZR0AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWYdAC8BAEUjZh0AAAEBAQAAAAEA+QsA" +
           "AQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFnHQAuAERnHQAAlgIAAAABACoBAUYA" +
           "AAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1l" +
           "bnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQFqHQAvAD9qHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAWsdAC8BACMjax0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQFsHQAuAERsHQAAAAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "JQAAAEFuZ3VsYXJfVmVsb2NpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBAYIdAQGCHYIdAAD/////GAAA" +
           "ABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBgx0ALgBEgx0AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CQAAAEV2ZW50VHlwZQEBhB0ALgBEhB0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5vZGUBAYUdAC4ARIUdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGG" +
           "HQAuAESGHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBhx0ALgBEhx0AAAEAJgH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAYgdAC4ARIgdAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBiR0ALgBEiR0AAAEA0CL/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBih0ALgBEih0AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQGLHQAuAESLHQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBjB0ALgBEjB0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBjR0ALgBEjR0AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAY4dAC4ARI4dAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBjx0A" +
           "LgBEjx0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBkB0ALgBEkB0AAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBkR0ALwEAIyORHQAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAZIdAC4ARJIdAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQGaHQAvAQAqI5odAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAZsdAC4ARJsdAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBnB0ALwEAKiOcHQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQGdHQAuAESdHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGe" +
           "HQAvAQAqI54dAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAZ8d" +
           "AC4ARJ8dAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBoB0ALgBE" +
           "oB0AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAaEdAC8BAEQjoR0AAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBoh0ALwEAQyOiHQAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBox0ALwEARSOjHQAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaQdAC4ARKQdAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAacdAC8AP6cdAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBqB0ALwEAIyOoHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAakd" +
           "AC4ARKkdAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IwAAAENvbW11bmljYXRpb25zQ29uZGl0aW9uVHlwZUluc3RhbmNlAQG/HQEBvx2/HQAA/////xgAAAAV" +
           "YIkKAgAAAAAABwAAAEV2ZW50SWQBAcAdAC4ARMAdAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkA" +
           "AABFdmVudFR5cGUBAcEdAC4ARMEdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "b2RlAQHCHQAuAETCHQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBwx0A" +
           "LgBEwx0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAcQdAC4ARMQdAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHFHQAuAETFHQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAcYdAC4ARMYdAAABANAi/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBAccdAC4ARMcdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEByB0ALgBEyB0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBAckdAC4ARMkdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBAcodAC4ARModAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQHLHQAuAETLHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAcwdAC4A" +
           "RMwdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAc0dAC4ARM0dAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAc4dAC8BACMjzh0AAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQHPHQAuAETPHQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEB1x0ALwEAKiPXHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQHYHQAuAETYHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAdkdAC8BACoj2R0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEB2h0ALgBE2h0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB2x0A" +
           "LwEAKiPbHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHcHQAu" +
           "AETcHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAd0dAC4ARN0d" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHeHQAvAQBEI94dAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAd8dAC8BAEMj3x0AAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAeAdAC8BAEUj4B0AAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHhHQAuAEThHQAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQHkHQAvAD/kHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAeUdAC8BACMj5R0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHmHQAu" +
           "AETmHQAAAAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IgAAAENvbmNlbnRyYXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAfwdAQH8HfwdAAD/////GAAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEB/R0ALgBE/R0AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEB/h0ALgBE/h0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAf8dAC4ARP8dAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEAHgAu" +
           "AEQAHgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBAR4ALgBEAR4AAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQIeAC4ARAIeAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBAx4ALgBEAx4AAAEA0CL/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBBB4ALgBEBB4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQEFHgAuAEQFHgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBBh4ALgBEBh4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBBx4ALgBEBx4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAQgeAC4ARAgeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBCR4ALgBE" +
           "CR4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBCh4ALgBECh4AAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBCx4ALwEAIyMLHgAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAQweAC4ARAweAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQEUHgAvAQAqIxQeAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABARUeAC4ARBUeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBFh4ALwEAKiMWHgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEXHgAuAEQXHgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEYHgAv" +
           "AQAqIxgeAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABARkeAC4A" +
           "RBkeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBGh4ALgBEGh4A" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARseAC8BAEQjGx4AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBHB4ALwEAQyMcHgAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBHR4ALwEARSMdHgAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAR4eAC4ARB4eAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBASEeAC8APyEeAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBIh4ALwEAIyMiHgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASMeAC4A" +
           "RCMeAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IQAAAENvbmR1Y3Rpdml0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBOR4BATkeOR4AAP////8YAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQE6HgAuAEQ6HgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQE7HgAuAEQ7HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBPB4ALgBEPB4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAT0eAC4A" +
           "RD0eAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQE+HgAuAEQ+HgAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBPx4ALgBEPx4AAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFAHgAuAERAHgAAAQDQIv////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQFBHgAuAERBHgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAUIeAC4AREIeAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQFDHgAuAERDHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQFEHgAuAEREHgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBRR4ALgBERR4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFGHgAuAERG" +
           "HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFHHgAuAERHHgAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFIHgAvAQAjI0geAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBSR4ALgBESR4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAVEeAC8BACojUR4AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBUh4ALgBEUh4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQFTHgAvAQAqI1MeAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAVQeAC4ARFQeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAVUeAC8B" +
           "ACojVR4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBVh4ALgBE" +
           "Vh4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFXHgAuAERXHgAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBWB4ALwEARCNYHgAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFZHgAvAQBDI1keAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFaHgAvAQBFI1oeAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWx4ALgBEWx4AAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBXh4ALwA/Xh4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQFfHgAvAQAjI18eAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBYB4ALgBE" +
           "YB4AAAAB/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HwAAAERhdGFfUmFuZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAXYeAQF2HnYeAAD/////GAAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBdx4ALgBEdx4AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBeB4ALgBEeB4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AXkeAC4ARHkeAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQF6HgAuAER6" +
           "HgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBex4ALgBEex4AAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAXweAC4ARHweAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBfR4ALgBEfR4AAAEA0CL/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBfh4ALgBEfh4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQF/HgAuAER/HgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xh" +
           "c3NJZAEBgB4ALgBEgB4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNz" +
           "TmFtZQEBgR4ALgBEgR4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUB" +
           "AYIeAC4ARIIeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBgx4ALgBEgx4A" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBhB4ALgBEhB4AAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBhR4ALwEAIyOFHgAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAYYeAC4ARIYeAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABR" +
           "dWFsaXR5AQGOHgAvAQAqI44eAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAY8eAC4ARI8eAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0" +
           "eQEBkB4ALwEAKiOQHgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQGRHgAuAESRHgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGSHgAvAQAq" +
           "I5IeAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAZMeAC4ARJMe" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBlB4ALgBElB4AAAAM" +
           "/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAZUeAC8BAEQjlR4AAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBlh4ALwEAQyOWHgAAAQEBAAAAAQD5CwABAPMKAAAA" +
           "AARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBlx4ALwEARSOXHgAAAQEBAAAAAQD5CwABAA0LAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZgeAC4ARJgeAACWAgAAAAEAKgEBRgAAAAcAAABFdmVu" +
           "dElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVu" +
           "dC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQg" +
           "dG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRD" +
           "dXJyZW50U3RhdGUBAZseAC8AP5seAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVT" +
           "dGF0ZQEBnB4ALwEAIyOcHgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZ0eAC4ARJ0e" +
           "AAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HgAAAERpcmVjdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBsx4BAbMesx4AAP////8YAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQG0HgAuAES0HgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQG1HgAuAES1HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "th4ALgBEth4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAbceAC4ARLce" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQG4HgAuAES4HgAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBuR4ALgBEuR4AAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQG6HgAuAES6HgAAAQDQIv////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQG7HgAuAES7HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAbweAC4ARLweAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQG9HgAuAES9HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQG+HgAuAES+HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "vx4ALgBEvx4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHAHgAuAETAHgAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHBHgAuAETBHgAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHCHgAvAQAjI8IeAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBwx4ALgBEwx4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAcseAC8BACojyx4AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBzB4ALgBEzB4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQHNHgAvAQAqI80eAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "Ac4eAC4ARM4eAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAc8eAC8BACoj" +
           "zx4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB0B4ALgBE0B4A" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHRHgAuAETRHgAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0h4ALwEARCPSHgAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHTHgAvAQBDI9MeAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHUHgAvAQBFI9QeAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB1R4ALgBE1R4AAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEB2B4ALwA/2B4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQHZHgAvAQAjI9keAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB2h4ALgBE2h4A" +
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IQAAAERpc3BsYWNlbWVudENvbmRpdGlvblR5cGVJbnN0YW5jZQEB8B4BAfAe8B4AAP////8YAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQHxHgAuAETxHgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQHyHgAuAETyHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEB8x4ALgBE8x4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAfQeAC4A" +
           "RPQeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQH1HgAuAET1HgAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB9h4ALgBE9h4AAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQH3HgAuAET3HgAAAQDQIv////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQH4HgAuAET4HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAfkeAC4ARPkeAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQH6HgAuAET6HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQH7HgAuAET7HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEB/B4ALgBE/B4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQH9HgAuAET9" +
           "HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH+HgAuAET+HgAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQH/HgAvAQAjI/8eAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBAB8ALgBEAB8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAQgfAC8BACojCB8AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBCR8ALgBECR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQEKHwAvAQAqIwofAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAQsfAC4ARAsfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQwfAC8B" +
           "ACojDB8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBDR8ALgBE" +
           "DR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEOHwAuAEQOHwAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBDx8ALwEARCMPHwAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEQHwAvAQBDIxAfAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQERHwAvAQBFIxEfAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEh8ALgBEEh8AAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBFR8ALwA/FR8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQEWHwAvAQAjIxYfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBFx8ALgBE" +
           "Fx8AAAAB/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "JgAAAEVsZWN0cmljYWxfRW5lcmd5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQEtHwEBLR8tHwAA/////xgA" +
           "AAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAS4fAC4ARC4fAAAAD/////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAkAAABFdmVudFR5cGUBAS8fAC4ARC8fAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3Vy" +
           "Y2VOb2RlAQEwHwAuAEQwHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "MR8ALgBEMR8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBATIfAC4ARDIfAAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEzHwAuAEQzHwAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBATQfAC4ARDQfAAABANAi/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBATUfAC4ARDUfAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBNh8ALgBENh8AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBATcfAC4ARDcfAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBATgfAC4ARDgfAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQE5HwAuAEQ5HwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBATof" +
           "AC4ARDofAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATsfAC4ARDsfAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATwfAC8BACMjPB8AAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE9HwAuAEQ9HwAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBRR8ALwEAKiNFHwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQFGHwAuAERGHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAUcfAC8BACojRx8AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBSB8ALgBESB8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "SR8ALwEAKiNJHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFK" +
           "HwAuAERKHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAUsfAC4A" +
           "REsfAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFMHwAvAQBEI0wfAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAU0fAC8BAEMjTR8AAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAU4fAC8BAEUjTh8AAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFPHwAuAERPHwAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQFSHwAvAD9SHwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAVMfAC8BACMjUx8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFU" +
           "HwAuAERUHwAAAAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HwAAAEZpbGxfTGV2ZWxDb25kaXRpb25UeXBlSW5zdGFuY2UBAWofAQFqH2ofAAD/////GAAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBax8ALgBEax8AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBbB8ALgBEbB8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AW0fAC4ARG0fAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFuHwAuAERu" +
           "HwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBbx8ALgBEbx8AAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAXAfAC4ARHAfAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBcR8ALgBEcR8AAAEA0CL/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBch8ALgBEch8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQFzHwAuAERzHwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xh" +
           "c3NJZAEBdB8ALgBEdB8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNz" +
           "TmFtZQEBdR8ALgBEdR8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUB" +
           "AXYfAC4ARHYfAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBdx8ALgBEdx8A" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBeB8ALgBEeB8AAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeR8ALwEAIyN5HwAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAXofAC4ARHofAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABR" +
           "dWFsaXR5AQGCHwAvAQAqI4IfAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAYMfAC4ARIMfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0" +
           "eQEBhB8ALwEAKiOEHwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQGFHwAuAESFHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGGHwAvAQAq" +
           "I4YfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAYcfAC4ARIcf" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBiB8ALgBEiB8AAAAM" +
           "/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYkfAC8BAEQjiR8AAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBih8ALwEAQyOKHwAAAQEBAAAAAQD5CwABAPMKAAAA" +
           "AARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBix8ALwEARSOLHwAAAQEBAAAAAQD5CwABAA0LAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYwfAC4ARIwfAACWAgAAAAEAKgEBRgAAAAcAAABFdmVu" +
           "dElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVu" +
           "dC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQg" +
           "dG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRD" +
           "dXJyZW50U3RhdGUBAY8fAC8AP48fAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVT" +
           "dGF0ZQEBkB8ALwEAIyOQHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZEfAC4ARJEf" +
           "AAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GQAAAEZsb3dDb25kaXRpb25UeXBlSW5zdGFuY2UBAacfAQGnH6cfAAD/////GAAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBqB8ALgBEqB8AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBqR8ALgBEqR8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAaofAC4A" +
           "RKofAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGrHwAuAESrHwAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBrB8ALgBErB8AAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAa0fAC4ARK0fAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAExvY2FsVGltZQEBrh8ALgBErh8AAAEA0CL/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAATWVzc2FnZQEBrx8ALgBErx8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5" +
           "AQGwHwAuAESwHwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB" +
           "sR8ALgBEsR8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB" +
           "sh8ALgBEsh8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAbMfAC4A" +
           "RLMfAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBtB8ALgBEtB8AAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBtR8ALgBEtR8AAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBth8ALwEAIyO2HwAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBAbcfAC4ARLcfAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5" +
           "AQG/HwAvAQAqI78fAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AcAfAC4ARMAfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBwR8A" +
           "LwEAKiPBHwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHCHwAu" +
           "AETCHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHDHwAvAQAqI8MfAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAcQfAC4ARMQfAAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBxR8ALgBExR8AAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAcYfAC8BAEQjxh8AAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBxx8ALwEAQyPHHwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoE" +
           "AAAAAAAKAAAAQWRkQ29tbWVudAEByB8ALwEARSPIHwAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAckfAC4ARMkfAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//" +
           "////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoB" +
           "AUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhl" +
           "IGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJyZW50" +
           "U3RhdGUBAcwfAC8AP8wfAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0ZQEB" +
           "zR8ALwEAIyPNHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAc4fAC4ARM4fAAAAAf//" +
           "//8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HgAAAEZyZXF1ZW5jeUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB5B8BAeQf5B8AAP////8YAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHlHwAuAETlHwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQHmHwAuAETmHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "5x8ALgBE5x8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAegfAC4AROgf" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQHpHwAuAETpHwAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB6h8ALgBE6h8AAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQHrHwAuAETrHwAAAQDQIv////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQHsHwAuAETsHwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAe0fAC4ARO0fAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQHuHwAuAETuHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQHvHwAuAETvHwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "8B8ALgBE8B8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHxHwAuAETxHwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHyHwAuAETyHwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHzHwAvAQAjI/MfAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEB9B8ALgBE9B8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAfwfAC8BACoj/B8AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEB/R8ALgBE/R8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQH+HwAvAQAqI/4fAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "Af8fAC4ARP8fAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQAgAC8BACoj" +
           "ACAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBASAALgBEASAA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQECIAAuAEQCIAAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBAyAALwEARCMDIAAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEEIAAvAQBDIwQgAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEFIAAvAQBFIwUgAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBBiAALgBEBiAAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBCSAALwA/CSAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQEKIAAvAQAjIwogAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBCyAALgBECyAA" +
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HQAAAEhhcmR3YXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEhIAEBISAhIAAA/////xgAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBASIgAC4ARCIgAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBASMgAC4ARCMgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEk" +
           "IAAuAEQkIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBJSAALgBEJSAA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBASYgAC4ARCYgAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEnIAAuAEQnIAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBASggAC4ARCggAAABANAi/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBASkgAC4ARCkgAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEBKiAALgBEKiAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNz" +
           "SWQBASsgAC4ARCsgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05h" +
           "bWUBASwgAC4ARCwgAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEt" +
           "IAAuAEQtIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAS4gAC4ARC4gAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAS8gAC4ARC8gAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATAgAC8BACMjMCAAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQExIAAuAEQxIAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVh" +
           "bGl0eQEBOSAALwEAKiM5IAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQE6IAAuAEQ6IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkB" +
           "ATsgAC8BACojOyAAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "PCAALgBEPCAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBPSAALwEAKiM9" +
           "IAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQE+IAAuAEQ+IAAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAT8gAC4ARD8gAAAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFAIAAvAQBEI0AgAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAUEgAC8BAEMjQSAAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAUIgAC8BAEUjQiAAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFDIAAuAERDIAAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJ" +
           "ZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQu" +
           "AQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRv" +
           "IHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3Vy" +
           "cmVudFN0YXRlAQFGIAAvAD9GIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3Rh" +
           "dGUBAUcgAC8BACMjRyAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFIIAAuAERIIAAA" +
           "AAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IQAAAExpbmVhcl9Gb3JjZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBXiABAV4gXiAAAP////8YAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQFfIAAuAERfIAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQFgIAAuAERgIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBYSAALgBEYSAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAWIgAC4A" +
           "RGIgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFjIAAuAERjIAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBZCAALgBEZCAAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFlIAAuAERlIAAAAQDQIv////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQFmIAAuAERmIAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAWcgAC4ARGcgAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQFoIAAuAERoIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQFpIAAuAERpIAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBaiAALgBEaiAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFrIAAuAERr" +
           "IAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFsIAAuAERsIAAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFtIAAvAQAjI20gAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBbiAALgBEbiAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAXYgAC8BACojdiAAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBdyAALgBEdyAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQF4IAAvAQAqI3ggAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAXkgAC4ARHkgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAXogAC8B" +
           "ACojeiAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBeyAALgBE" +
           "eyAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQF8IAAuAER8IAAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBfSAALwEARCN9IAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQF+IAAvAQBDI34gAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQF/IAAvAQBFI38gAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBgCAALgBEgCAAAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBgyAALwA/gyAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQGEIAAvAQAjI4QgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBhSAALgBE" +
           "hSAAAAAB/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GQAAAExvYWRDb25kaXRpb25UeXBlSW5zdGFuY2UBAZsgAQGbIJsgAAD/////GAAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBnCAALgBEnCAAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBnSAALgBEnSAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAZ4gAC4A" +
           "RJ4gAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGfIAAuAESfIAAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBoCAALgBEoCAAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaEgAC4ARKEgAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAExvY2FsVGltZQEBoiAALgBEoiAAAAEA0CL/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAATWVzc2FnZQEBoyAALgBEoyAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5" +
           "AQGkIAAuAESkIAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB" +
           "pSAALgBEpSAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB" +
           "piAALgBEpiAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAacgAC4A" +
           "RKcgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBqCAALgBEqCAAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqSAALgBEqSAAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqiAALwEAIyOqIAAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBAasgAC4ARKsgAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5" +
           "AQGzIAAvAQAqI7MgAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AbQgAC4ARLQgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBtSAA" +
           "LwEAKiO1IAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQG2IAAu" +
           "AES2IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQG3IAAvAQAqI7cgAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbggAC4ARLggAAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBuSAALgBEuSAAAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbogAC8BAEQjuiAAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBuyAALwEAQyO7IAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoE" +
           "AAAAAAAKAAAAQWRkQ29tbWVudAEBvCAALwEARSO8IAAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAb0gAC4ARL0gAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//" +
           "////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoB" +
           "AUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhl" +
           "IGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJyZW50" +
           "U3RhdGUBAcAgAC8AP8AgAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0ZQEB" +
           "wSAALwEAIyPBIAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAcIgAC4ARMIgAAAAAf//" +
           "//8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IgAAAExvZ2ljX1Byb2dyYW1Db25kaXRpb25UeXBlSW5zdGFuY2UBAdggAQHYINggAAD/////GAAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEB2SAALgBE2SAAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEB2iAALgBE2iAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAdsgAC4ARNsgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHcIAAu" +
           "AETcIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB3SAALgBE3SAAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAd4gAC4ARN4gAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEB3yAALgBE3yAAAAEA0CL/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEB4CAALgBE4CAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQHhIAAuAEThIAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEB4iAALgBE4iAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEB4yAALgBE4yAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAeQgAC4AROQgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB5SAALgBE" +
           "5SAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB5iAALgBE5iAAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB5yAALwEAIyPnIAAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAeggAC4AROggAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQHwIAAvAQAqI/AgAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAfEgAC4ARPEgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEB8iAALwEAKiPyIAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHzIAAuAETzIAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQH0IAAv" +
           "AQAqI/QgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAfUgAC4A" +
           "RPUgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB9iAALgBE9iAA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAfcgAC8BAEQj9yAAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB+CAALwEAQyP4IAAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB+SAALwEARSP5IAAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfogAC4ARPogAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAf0gAC8AP/0gAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEB/iAALwEAIyP+IAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAf8gAC4A" +
           "RP8gAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GQAAAE1hc3NDb25kaXRpb25UeXBlSW5zdGFuY2UBARUhAQEVIRUhAAD/////GAAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBFiEALgBEFiEAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBFyEALgBEFyEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBARghAC4A" +
           "RBghAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEZIQAuAEQZIQAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBGiEALgBEGiEAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBARshAC4ARBshAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAExvY2FsVGltZQEBHCEALgBEHCEAAAEA0CL/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAATWVzc2FnZQEBHSEALgBEHSEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5" +
           "AQEeIQAuAEQeIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB" +
           "HyEALgBEHyEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB" +
           "ICEALgBEICEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBASEhAC4A" +
           "RCEhAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBIiEALgBEIiEAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBIyEALgBEIyEAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBJCEALwEAIyMkIQAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBASUhAC4ARCUhAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5" +
           "AQEtIQAvAQAqIy0hAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AS4hAC4ARC4hAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBLyEA" +
           "LwEAKiMvIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEwIQAu" +
           "AEQwIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQExIQAvAQAqIzEhAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABATIhAC4ARDIhAAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBMyEALgBEMyEAAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATQhAC8BAEQjNCEAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNSEALwEAQyM1IQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoE" +
           "AAAAAAAKAAAAQWRkQ29tbWVudAEBNiEALwEARSM2IQAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBATchAC4ARDchAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//" +
           "////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoB" +
           "AUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhl" +
           "IGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJyZW50" +
           "U3RhdGUBATohAC8APzohAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0ZQEB" +
           "OyEALwEAIyM7IQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBATwhAC4ARDwhAAAAAf//" +
           "//8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IwAAAE1vdGlvbl9Qcm9ncmFtQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFSIQEBUiFSIQAA/////xgAAAAV" +
           "YIkKAgAAAAAABwAAAEV2ZW50SWQBAVMhAC4ARFMhAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkA" +
           "AABFdmVudFR5cGUBAVQhAC4ARFQhAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "b2RlAQFVIQAuAERVIQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBViEA" +
           "LgBEViEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAVchAC4ARFchAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFYIQAuAERYIQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAVkhAC4ARFkhAAABANAi/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBAVohAC4ARFohAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEBWyEALgBEWyEAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBAVwhAC4ARFwhAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBAV0hAC4ARF0hAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQFeIQAuAEReIQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAV8hAC4A" +
           "RF8hAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAWAhAC4ARGAhAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAWEhAC8BACMjYSEAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQFiIQAuAERiIQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEBaiEALwEAKiNqIQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFrIQAuAERrIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAWwhAC8BACojbCEAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBbSEALgBEbSEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBbiEA" +
           "LwEAKiNuIQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFvIQAu" +
           "AERvIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAXAhAC4ARHAh" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFxIQAvAQBEI3EhAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAXIhAC8BAEMjciEAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAXMhAC8BAEUjcyEAAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF0IQAuAER0IQAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQF3IQAvAD93IQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAXghAC8BACMjeCEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQF5IQAu" +
           "AER5IQAAAAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IgAAAFBhdGhfRmVlZHJhdGVDb25kaXRpb25UeXBlSW5zdGFuY2UBAY8hAQGPIY8hAAD/////GAAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBkCEALgBEkCEAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBkSEALgBEkSEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAZIhAC4ARJIhAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGTIQAu" +
           "AESTIQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBlCEALgBElCEAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAZUhAC4ARJUhAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBliEALgBEliEAAAEA0CL/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBlyEALgBElyEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQGYIQAuAESYIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBmSEALgBEmSEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBmiEALgBEmiEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAZshAC4ARJshAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBnCEALgBE" +
           "nCEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBnSEALgBEnSEAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBniEALwEAIyOeIQAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAZ8hAC4ARJ8hAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQGnIQAvAQAqI6chAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAaghAC4ARKghAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBqSEALwEAKiOpIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQGqIQAuAESqIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGrIQAv" +
           "AQAqI6shAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAawhAC4A" +
           "RKwhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBrSEALgBErSEA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAa4hAC8BAEQjriEAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBryEALwEAQyOvIQAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBsCEALwEARSOwIQAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbEhAC4ARLEhAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAbQhAC8AP7QhAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBtSEALwEAIyO1IQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAbYhAC4A" +
           "RLYhAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IgAAAFBhdGhfUG9zaXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAcwhAQHMIcwhAAD/////GAAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBzSEALgBEzSEAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBziEALgBEziEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAc8hAC4ARM8hAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHQIQAu" +
           "AETQIQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB0SEALgBE0SEAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAdIhAC4ARNIhAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEB0yEALgBE0yEAAAEA0CL/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEB1CEALgBE1CEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQHVIQAuAETVIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEB1iEALgBE1iEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEB1yEALgBE1yEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAdghAC4ARNghAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB2SEALgBE" +
           "2SEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB2iEALgBE2iEAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB2yEALwEAIyPbIQAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAdwhAC4ARNwhAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQHkIQAvAQAqI+QhAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAeUhAC4AROUhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEB5iEALwEAKiPmIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHnIQAuAETnIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHoIQAv" +
           "AQAqI+ghAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAekhAC4A" +
           "ROkhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB6iEALgBE6iEA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAeshAC8BAEQj6yEAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB7CEALwEAQyPsIQAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB7SEALwEARSPtIQAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAe4hAC4ARO4hAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAfEhAC8AP/EhAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEB8iEALwEAIyPyIQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAfMhAC4A" +
           "RPMhAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FwAAAFBIQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEJIgEBCSIJIgAA/////xgAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAQoiAC4ARAoiAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AQsiAC4ARAsiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEMIgAuAEQM" +
           "IgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBDSIALgBEDSIAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAQ4iAC4ARA4iAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEPIgAuAEQPIgAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAkAAABMb2NhbFRpbWUBARAiAC4ARBAiAAABANAi/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AE1lc3NhZ2UBAREiAC4ARBEiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0eQEB" +
           "EiIALgBEEiIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBARMi" +
           "AC4ARBMiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBARQi" +
           "AC4ARBQiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEVIgAuAEQV" +
           "IgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBARYiAC4ARBYiAAAAEf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BARciAC4ARBciAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAwAAABFbmFibGVkU3RhdGUBARgiAC8BACMjGCIAAAAV/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAAAgAAAElkAQEZIgAuAEQZIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEB" +
           "ISIALwEAKiMhIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEi" +
           "IgAuAEQiIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBASMiAC8B" +
           "ACojIyIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBJCIALgBE" +
           "JCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBJSIALwEAKiMlIgAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEmIgAuAEQmIgAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBASciAC4ARCciAAAADP////8BAf//" +
           "//8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEoIgAvAQBEIygiAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAYAAABFbmFibGUBASkiAC8BAEMjKSIAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAA" +
           "AAAACgAAAEFkZENvbW1lbnQBASoiAC8BAEUjKiIAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQErIgAuAEQrIgAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP////" +
           "/wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFC" +
           "AAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBj" +
           "b25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3VycmVudFN0" +
           "YXRlAQEuIgAvAD8uIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3RhdGUBAS8i" +
           "AC8BACMjLyIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEwIgAuAEQwIgAAAAH/////" +
           "AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HQAAAFBvc2l0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFGIgEBRiJGIgAA/////xgAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAUciAC4AREciAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAUgiAC4AREgiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFJ" +
           "IgAuAERJIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBSiIALgBESiIA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAUsiAC4AREsiAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFMIgAuAERMIgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAU0iAC4ARE0iAAABANAi/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBAU4iAC4ARE4iAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEBTyIALgBETyIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNz" +
           "SWQBAVAiAC4ARFAiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05h" +
           "bWUBAVEiAC4ARFEiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQFS" +
           "IgAuAERSIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAVMiAC4ARFMiAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAVQiAC4ARFQiAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVUiAC8BACMjVSIAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQFWIgAuAERWIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVh" +
           "bGl0eQEBXiIALwEAKiNeIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQFfIgAuAERfIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkB" +
           "AWAiAC8BACojYCIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "YSIALgBEYSIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBYiIALwEAKiNi" +
           "IgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFjIgAuAERjIgAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAWQiAC4ARGQiAAAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFlIgAvAQBEI2UiAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWYiAC8BAEMjZiIAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWciAC8BAEUjZyIAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFoIgAuAERoIgAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJ" +
           "ZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQu" +
           "AQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRv" +
           "IHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3Vy" +
           "cmVudFN0YXRlAQFrIgAvAD9rIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3Rh" +
           "dGUBAWwiAC8BACMjbCIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFtIgAuAERtIgAA" +
           "AAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IQAAAFBvd2VyX0ZhY3RvckNvbmRpdGlvblR5cGVJbnN0YW5jZQEBgyIBAYMigyIAAP////8YAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQGEIgAuAESEIgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQGFIgAuAESFIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBhiIALgBEhiIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAYciAC4A" +
           "RIciAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGIIgAuAESIIgAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBiSIALgBEiSIAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQGKIgAuAESKIgAAAQDQIv////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQGLIgAuAESLIgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAYwiAC4ARIwiAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQGNIgAuAESNIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQGOIgAuAESOIgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBjyIALgBEjyIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGQIgAuAESQ" +
           "IgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGRIgAuAESRIgAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGSIgAvAQAjI5IiAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBkyIALgBEkyIAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAZsiAC8BACojmyIAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBnCIALgBEnCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQGdIgAvAQAqI50iAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAZ4iAC4ARJ4iAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAZ8iAC8B" +
           "ACojnyIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBoCIALgBE" +
           "oCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGhIgAuAEShIgAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBoiIALwEARCOiIgAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGjIgAvAQBDI6MiAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGkIgAvAQBFI6QiAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpSIALgBEpSIAAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBqCIALwA/qCIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQGpIgAvAQAjI6kiAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBqiIALgBE" +
           "qiIAAAAB/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HQAAAFByZXNzdXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHAIgEBwCLAIgAA/////xgAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAcEiAC4ARMEiAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAcIiAC4ARMIiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHD" +
           "IgAuAETDIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBxCIALgBExCIA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAcUiAC4ARMUiAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHGIgAuAETGIgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAcciAC4ARMciAAABANAi/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBAcgiAC4ARMgiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEBySIALgBEySIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNz" +
           "SWQBAcoiAC4ARMoiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05h" +
           "bWUBAcsiAC4ARMsiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQHM" +
           "IgAuAETMIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAc0iAC4ARM0iAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAc4iAC4ARM4iAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAc8iAC8BACMjzyIAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQHQIgAuAETQIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVh" +
           "bGl0eQEB2CIALwEAKiPYIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHZIgAuAETZIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkB" +
           "AdoiAC8BACoj2iIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "2yIALgBE2yIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB3CIALwEAKiPc" +
           "IgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHdIgAuAETdIgAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAd4iAC4ARN4iAAAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHfIgAvAQBEI98iAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAeAiAC8BAEMj4CIAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAeEiAC8BAEUj4SIAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHiIgAuAETiIgAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJ" +
           "ZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQu" +
           "AQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRv" +
           "IHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3Vy" +
           "cmVudFN0YXRlAQHlIgAvAD/lIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3Rh" +
           "dGUBAeYiAC8BACMj5iIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHnIgAuAETnIgAA" +
           "AAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HwAAAFJlc2lzdGFuY2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAf0iAQH9Iv0iAAD/////GAAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEB/iIALgBE/iIAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEB/yIALgBE/yIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AQAjAC4ARAAjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEBIwAuAEQB" +
           "IwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBAiMALgBEAiMAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQMjAC4ARAMjAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBBCMALgBEBCMAAAEA0CL/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBBSMALgBEBSMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQEGIwAuAEQGIwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xh" +
           "c3NJZAEBByMALgBEByMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNz" +
           "TmFtZQEBCCMALgBECCMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUB" +
           "AQkjAC4ARAkjAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBCiMALgBECiMA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBCyMALgBECyMAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBDCMALwEAIyMMIwAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAQ0jAC4ARA0jAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABR" +
           "dWFsaXR5AQEVIwAvAQAqIxUjAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABARYjAC4ARBYjAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0" +
           "eQEBFyMALwEAKiMXIwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQEYIwAuAEQYIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEZIwAvAQAq" +
           "IxkjAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABARojAC4ARBoj" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBGyMALgBEGyMAAAAM" +
           "/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARwjAC8BAEQjHCMAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBHSMALwEAQyMdIwAAAQEBAAAAAQD5CwABAPMKAAAA" +
           "AARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBHiMALwEARSMeIwAAAQEBAAAAAQD5CwABAA0LAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAR8jAC4ARB8jAACWAgAAAAEAKgEBRgAAAAcAAABFdmVu" +
           "dElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVu" +
           "dC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQg" +
           "dG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRD" +
           "dXJyZW50U3RhdGUBASIjAC8APyIjAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVT" +
           "dGF0ZQEBIyMALwEAIyMjIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASQjAC4ARCQj" +
           "AAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "JAAAAFJvdGFyeV9WZWxvY2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBOiMBATojOiMAAP////8YAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQE7IwAuAEQ7IwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQE8IwAuAEQ8IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBPSMALgBEPSMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAT4j" +
           "AC4ARD4jAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQE/IwAuAEQ/IwAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBQCMALgBEQCMAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFBIwAuAERBIwAAAQDQIv////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQFCIwAuAERCIwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAUMjAC4AREMjAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQFEIwAuAEREIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQFFIwAuAERFIwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEBRiMALgBERiMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFHIwAu" +
           "AERHIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFIIwAuAERIIwAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFJIwAvAQAjI0kjAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSiMALgBESiMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAVIjAC8BACojUiMAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBUyMALgBEUyMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQFUIwAvAQAqI1QjAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAVUjAC4ARFUjAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAVYj" +
           "AC8BACojViMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBVyMA" +
           "LgBEVyMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFYIwAuAERY" +
           "IwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBWSMALwEARCNZIwAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFaIwAvAQBDI1ojAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFbIwAvAQBFI1sjAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBXCMALgBEXCMAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBXyMALwA/XyMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQFgIwAvAQAjI2AjAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBYSMA" +
           "LgBEYSMAAAAB/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IAAAAFNvdW5kX0xldmVsQ29uZGl0aW9uVHlwZUluc3RhbmNlAQF3IwEBdyN3IwAA/////xgAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAXgjAC4ARHgjAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAXkjAC4ARHkjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQF6IwAuAER6IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBeyMALgBE" +
           "eyMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAXwjAC4ARHwjAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQF9IwAuAER9IwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAX4jAC4ARH4jAAABANAi/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAX8jAC4ARH8jAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBgCMALgBEgCMAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAYEjAC4ARIEjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAYIjAC4ARIIjAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQGDIwAuAESDIwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAYQjAC4ARIQj" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAYUjAC4ARIUjAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAYYjAC8BACMjhiMAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQGHIwAuAESHIwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBjyMALwEAKiOPIwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQGQIwAuAESQIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAZEjAC8BACojkSMAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBkiMALgBEkiMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBkyMALwEA" +
           "KiOTIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGUIwAuAESU" +
           "IwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAZUjAC4ARJUjAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGWIwAvAQBEI5YjAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAZcjAC8BAEMjlyMAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAZgjAC8BAEUjmCMAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGZIwAuAESZIwAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQGcIwAvAD+cIwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAZ0jAC8BACMjnSMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGeIwAuAESe" +
           "IwAAAAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GwAAAFN0cmFpbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBtCMBAbQjtCMAAP////8YAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQG1IwAuAES1IwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQG2IwAuAES2IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBtyMA" +
           "LgBEtyMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAbgjAC4ARLgjAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQG5IwAuAES5IwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBuiMALgBEuiMAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAJAAAATG9jYWxUaW1lAQG7IwAuAES7IwAAAQDQIv////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABNZXNzYWdlAQG8IwAuAES8IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJp" +
           "dHkBAb0jAC4ARL0jAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lk" +
           "AQG+IwAuAES+IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1l" +
           "AQG/IwAuAES/IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBwCMA" +
           "LgBEwCMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHBIwAuAETBIwAAABH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHCIwAuAETCIwAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHDIwAvAQAjI8MjAAAAFf////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBxCMALgBExCMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxp" +
           "dHkBAcwjAC8BACojzCMAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBzSMALgBEzSMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQHO" +
           "IwAvAQAqI84jAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAc8j" +
           "AC4ARM8jAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAdAjAC8BACoj0CMA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB0SMALgBE0SMAAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHSIwAuAETSIwAAAAz/////" +
           "AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0yMALwEARCPTIwAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHUIwAvAQBDI9QjAAABAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CgQAAAAAAAoAAABBZGRDb21tZW50AQHVIwAvAQBFI9UjAAABAQEAAAABAPkLAAEADQsBAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB1iMALgBE1iMAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQA" +
           "D/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEA" +
           "KgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0" +
           "aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1cnJl" +
           "bnRTdGF0ZQEB2SMALwA/2SMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0YXRl" +
           "AQHaIwAvAQAjI9ojAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB2yMALgBE2yMAAAAB" +
           "/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GwAAAFN5c3RlbUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB8SMBAfEj8SMAAP////8YAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQHyIwAuAETyIwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQHzIwAuAETzIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB9CMA" +
           "LgBE9CMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAfUjAC4ARPUjAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQH2IwAuAET2IwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB9yMALgBE9yMAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAJAAAATG9jYWxUaW1lAQH4IwAuAET4IwAAAQDQIv////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABNZXNzYWdlAQH5IwAuAET5IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJp" +
           "dHkBAfojAC4ARPojAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lk" +
           "AQH7IwAuAET7IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1l" +
           "AQH8IwAuAET8IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB/SMA" +
           "LgBE/SMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQH+IwAuAET+IwAAABH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH/IwAuAET/IwAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEAJAAvAQAjIwAkAAAAFf////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBASQALgBEASQAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxp" +
           "dHkBAQkkAC8BACojCSQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBCiQALgBECiQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQEL" +
           "JAAvAQAqIwskAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAQwk" +
           "AC4ARAwkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQ0kAC8BACojDSQA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBDiQALgBEDiQAAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEPJAAuAEQPJAAAAAz/////" +
           "AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBECQALwEARCMQJAAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQERJAAvAQBDIxEkAAABAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CgQAAAAAAAoAAABBZGRDb21tZW50AQESJAAvAQBFIxIkAAABAQEAAAABAPkLAAEADQsBAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEyQALgBEEyQAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQA" +
           "D/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEA" +
           "KgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0" +
           "aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1cnJl" +
           "bnRTdGF0ZQEBFiQALwA/FiQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0YXRl" +
           "AQEXJAAvAQAjIxckAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBGCQALgBEGCQAAAAB" +
           "/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IAAAAFRlbXBlcmF0dXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEuJAEBLiQuJAAA/////xgAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAS8kAC4ARC8kAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBATAkAC4ARDAkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQExJAAuAEQxJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBMiQALgBE" +
           "MiQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBATMkAC4ARDMkAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQE0JAAuAEQ0JAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBATUkAC4ARDUkAAABANAi/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBATYkAC4ARDYkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBNyQALgBENyQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBATgkAC4ARDgkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBATkkAC4ARDkkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQE6JAAuAEQ6JAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBATskAC4ARDsk" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATwkAC4ARDwkAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAT0kAC8BACMjPSQAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQE+JAAuAEQ+JAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBRiQALwEAKiNGJAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQFHJAAuAERHJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAUgkAC8BACojSCQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBSSQALgBESSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBSiQALwEA" +
           "KiNKJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFLJAAuAERL" +
           "JAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAUwkAC4AREwkAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFNJAAvAQBEI00kAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAU4kAC8BAEMjTiQAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAU8kAC8BAEUjTyQAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQJAAuAERQJAAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQFTJAAvAD9TJAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAVQkAC8BACMjVCQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVJAAuAERV" +
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GQAAAFRpbHRDb25kaXRpb25UeXBlSW5zdGFuY2UBAWskAQFrJGskAAD/////GAAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBbCQALgBEbCQAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBbSQALgBEbSQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAW4kAC4A" +
           "RG4kAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFvJAAuAERvJAAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBcCQALgBEcCQAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAXEkAC4ARHEkAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAExvY2FsVGltZQEBciQALgBEciQAAAEA0CL/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAATWVzc2FnZQEBcyQALgBEcyQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5" +
           "AQF0JAAuAER0JAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB" +
           "dSQALgBEdSQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB" +
           "diQALgBEdiQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAXckAC4A" +
           "RHckAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBeCQALgBEeCQAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBeSQALgBEeSQAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeiQALwEAIyN6JAAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBAXskAC4ARHskAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5" +
           "AQGDJAAvAQAqI4MkAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AYQkAC4ARIQkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBhSQA" +
           "LwEAKiOFJAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGGJAAu" +
           "AESGJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGHJAAvAQAqI4ckAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAYgkAC4ARIgkAAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBiSQALgBEiSQAAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYokAC8BAEQjiiQAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBiyQALwEAQyOLJAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoE" +
           "AAAAAAAKAAAAQWRkQ29tbWVudAEBjCQALwEARSOMJAAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAY0kAC4ARI0kAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//" +
           "////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoB" +
           "AUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhl" +
           "IGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJyZW50" +
           "U3RhdGUBAZAkAC8AP5AkAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0ZQEB" +
           "kSQALwEAIyORJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZIkAC4ARJIkAAAAAf//" +
           "//8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GwAAAFRvcnF1ZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBqCQBAagkqCQAAP////8YAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQGpJAAuAESpJAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQGqJAAuAESqJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBqyQA" +
           "LgBEqyQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAawkAC4ARKwkAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGtJAAuAEStJAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBriQALgBEriQAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAJAAAATG9jYWxUaW1lAQGvJAAuAESvJAAAAQDQIv////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABNZXNzYWdlAQGwJAAuAESwJAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJp" +
           "dHkBAbEkAC4ARLEkAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lk" +
           "AQGyJAAuAESyJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1l" +
           "AQGzJAAuAESzJAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBtCQA" +
           "LgBEtCQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQG1JAAuAES1JAAAABH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQG2JAAuAES2JAAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQG3JAAvAQAjI7ckAAAAFf////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBuCQALgBEuCQAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxp" +
           "dHkBAcAkAC8BACojwCQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBwSQALgBEwSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQHC" +
           "JAAvAQAqI8IkAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAcMk" +
           "AC4ARMMkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAcQkAC8BACojxCQA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBxSQALgBExSQAAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHGJAAuAETGJAAAAAz/////" +
           "AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBxyQALwEARCPHJAAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHIJAAvAQBDI8gkAAABAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CgQAAAAAAAoAAABBZGRDb21tZW50AQHJJAAvAQBFI8kkAAABAQEAAAABAPkLAAEADQsBAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEByiQALgBEyiQAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQA" +
           "D/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEA" +
           "KgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0" +
           "aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1cnJl" +
           "bnRTdGF0ZQEBzSQALwA/zSQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0YXRl" +
           "AQHOJAAvAQAjI84kAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBzyQALgBEzyQAAAAB" +
           "/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HQAAAFZlbG9jaXR5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQHlJAEB5STlJAAA/////xgAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAeYkAC4AROYkAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAeckAC4AROckAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHo" +
           "JAAuAEToJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB6SQALgBE6SQA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAeokAC4AROokAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHrJAAuAETrJAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAewkAC4AROwkAAABANAi/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBAe0kAC4ARO0kAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEB7iQALgBE7iQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNz" +
           "SWQBAe8kAC4ARO8kAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05h" +
           "bWUBAfAkAC4ARPAkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQHx" +
           "JAAuAETxJAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAfIkAC4ARPIkAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAfMkAC4ARPMkAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAfQkAC8BACMj9CQAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQH1JAAuAET1JAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVh" +
           "bGl0eQEB/SQALwEAKiP9JAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQH+JAAuAET+JAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkB" +
           "Af8kAC8BACoj/yQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "ACUALgBEACUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBASUALwEAKiMB" +
           "JQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQECJQAuAEQCJQAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAQMlAC4ARAMlAAAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEEJQAvAQBEIwQlAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAQUlAC8BAEMjBSUAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAQYlAC8BAEUjBiUAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEHJQAuAEQHJQAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJ" +
           "ZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQu" +
           "AQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRv" +
           "IHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3Vy" +
           "cmVudFN0YXRlAQEKJQAvAD8KJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3Rh" +
           "dGUBAQslAC8BACMjCyUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEMJQAuAEQMJQAA" +
           "AAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HgAAAFZpc2Nvc2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBIiUBASIlIiUAAP////8YAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQEjJQAuAEQjJQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQEkJQAuAEQkJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "JSUALgBEJSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBASYlAC4ARCYl" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEnJQAuAEQnJQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBKCUALgBEKCUAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQEpJQAuAEQpJQAAAQDQIv////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQEqJQAuAEQqJQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBASslAC4ARCslAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQEsJQAuAEQsJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQEtJQAuAEQtJQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "LiUALgBELiUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQEvJQAuAEQvJQAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQEwJQAuAEQwJQAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQExJQAvAQAjIzElAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBMiUALgBEMiUAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBATolAC8BACojOiUAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBOyUALgBEOyUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQE8JQAvAQAqIzwlAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AT0lAC4ARD0lAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAT4lAC8BACoj" +
           "PiUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBPyUALgBEPyUA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFAJQAuAERAJQAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBQSUALwEARCNBJQAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFCJQAvAQBDI0IlAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFDJQAvAQBFI0MlAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRCUALgBERCUAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBRyUALwA/RyUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQFIJQAvAQAjI0glAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSSUALgBESSUA" +
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HAAAAFZvbHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAV8lAQFfJV8lAAD/////GAAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBYCUALgBEYCUAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBYSUALgBEYSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAWIl" +
           "AC4ARGIlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFjJQAuAERjJQAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBZCUALgBEZCUAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAWUlAC4ARGUlAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACQAAAExvY2FsVGltZQEBZiUALgBEZiUAAAEA0CL/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBZyUALgBEZyUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQFoJQAuAERoJQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBaSUALgBEaSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBaiUALgBEaiUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAWsl" +
           "AC4ARGslAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBbCUALgBEbCUAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBbSUALgBEbSUAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBbiUALwEAIyNuJQAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAW8lAC4ARG8lAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQF3JQAvAQAqI3clAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAXglAC4ARHglAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "eSUALwEAKiN5JQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQF6" +
           "JQAuAER6JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQF7JQAvAQAqI3sl" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAXwlAC4ARHwlAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBfSUALgBEfSUAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAX4lAC8BAEQjfiUAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBfyUALwEAQyN/JQAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBgCUALwEARSOAJQAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYElAC4ARIElAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBAYQlAC8AP4QlAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBhSUALwEAIyOFJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAYYlAC4ARIYlAAAA" +
           "Af////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IgAAAFZvbHRfQW1wZXJhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAZwlAQGcJZwlAAD/////GAAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBnSUALgBEnSUAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBniUALgBEniUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAZ8lAC4ARJ8lAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGgJQAu" +
           "AESgJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBoSUALgBEoSUAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaIlAC4ARKIlAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBoyUALgBEoyUAAAEA0CL/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBpCUALgBEpCUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQGlJQAuAESlJQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBpiUALgBEpiUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBpyUALgBEpyUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAaglAC4ARKglAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBqSUALgBE" +
           "qSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqiUALgBEqiUAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqyUALwEAIyOrJQAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAawlAC4ARKwlAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQG0JQAvAQAqI7QlAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAbUlAC4ARLUlAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBtiUALwEAKiO2JQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQG3JQAuAES3JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQG4JQAv" +
           "AQAqI7glAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbklAC4A" +
           "RLklAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBuiUALgBEuiUA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbslAC8BAEQjuyUAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBvCUALwEAQyO8JQAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBvSUALwEARSO9JQAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAb4lAC4ARL4lAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAcElAC8AP8ElAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBwiUALwEAIyPCJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAcMlAC4A" +
           "RMMlAAAAAf////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "KQAAAFZvbHRBbXBlcmFnZVJlYWN0aXZlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHZJQEB2SXZJQAA////" +
           "/xgAAAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAdolAC4ARNolAAAAD/////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAkAAABFdmVudFR5cGUBAdslAC4ARNslAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABT" +
           "b3VyY2VOb2RlAQHcJQAuAETcJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEB3SUALgBE3SUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAd4lAC4ARN4lAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHfJQAuAETfJQAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAeAlAC4AROAlAAABANAi/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAeElAC4AROElAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAgAAABTZXZlcml0eQEB4iUALgBE4iUAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENv" +
           "bmRpdGlvbkNsYXNzSWQBAeMlAC4AROMlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25k" +
           "aXRpb25DbGFzc05hbWUBAeQlAC4AROQlAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25k" +
           "aXRpb25OYW1lAQHlJQAuAETlJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQB" +
           "AeYlAC4AROYlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAeclAC4AROclAAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAeglAC8BACMj6CUAAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHpJQAuAETpJQAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAUXVhbGl0eQEB8SUALwEAKiPxJQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQHyJQAuAETyJQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABM" +
           "YXN0U2V2ZXJpdHkBAfMlAC8BACoj8yUAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEB9CUALgBE9CUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVu" +
           "dAEB9SUALwEAKiP1JQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQH2JQAuAET2JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAfcl" +
           "AC4ARPclAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQH4JQAvAQBEI/glAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAfklAC8BAEMj+SUAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAfolAC8BAEUj+iUAAAEBAQAAAAEA+QsA" +
           "AQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH7JQAuAET7JQAAlgIAAAABACoBAUYA" +
           "AAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1l" +
           "bnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQH+JQAvAD/+JQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAf8lAC8BACMj/yUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQEAJgAuAEQAJgAAAAH/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HAAAAFdhdHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBARYmAQEWJhYmAAD/////GAAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBFyYALgBEFyYAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBGCYALgBEGCYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBARkm" +
           "AC4ARBkmAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEaJgAuAEQaJgAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBGyYALgBEGyYAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBARwmAC4ARBwmAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACQAAAExvY2FsVGltZQEBHSYALgBEHSYAAAEA0CL/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBHiYALgBEHiYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQEfJgAuAEQfJgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBICYALgBEICYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBISYALgBEISYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBASIm" +
           "AC4ARCImAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBIyYALgBEIyYAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBJCYALgBEJCYAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBJSYALwEAIyMlJgAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBASYmAC4ARCYmAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQEuJgAvAQAqIy4mAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAS8mAC4ARC8mAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "MCYALwEAKiMwJgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEx" +
           "JgAuAEQxJgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEyJgAvAQAqIzIm" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABATMmAC4ARDMmAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBNCYALgBENCYAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATUmAC8BAEQjNSYAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNiYALwEAQyM2JgAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNyYALwEARSM3JgAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATgmAC4ARDgmAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBATsmAC8APzsmAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBPCYALwEAIyM8JgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAT0mAC4ARD0mAAAA" +
           "Af////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EwAAAENoYW5uZWxUeXBlSW5zdGFuY2UBAVMmAQFTJlMmAAABAf0m/v///wEB/////wMAAAAVYIkKAgAA" +
           "AAEADwAAAENhbGlicmF0aW9uRGF0ZQEBVCYALgBEVCYAAAEB+Sb/////AQH/////AAAAABVgiQoCAAAA" +
           "AQATAAAATmV4dENhbGlicmF0aW9uRGF0ZQEBVSYALgBEVSYAAAEB+Sb/////AQH/////AAAAABVgiQoC" +
           "AAAAAQATAAAAQ2FsaWJyYXRpb25Jbml0aWFscwEBViYALgBEViYAAAEB+ib/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "GQAAAENvbmZpZ3VyYXRpb25UeXBlSW5zdGFuY2UBAVcmAQFXJlcmAAD/////BQAAABVgiQoCAAAAAQAM" +
           "AAAAQXZhaWxhYmlsaXR5AQFYJgAvAQA9CVgmAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABN" +
           "YW51ZmFjdHVyZXIBAVsmAC4ARFsmAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxO" +
           "dW1iZXIBAVwmAC4ARFwmAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAV8m" +
           "AC8APV8mAAD/////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBYCYALwA9YCYAAP////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "HwAAAFNlbnNvckNvbmZpZ3VyYXRpb25UeXBlSW5zdGFuY2UBAWQmAQFkJmQmAAD/////BgAAABVgiQoC" +
           "AAAAAQAMAAAAQXZhaWxhYmlsaXR5AQFlJgAvAQA9CWUmAAAADP////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAwAAABNYW51ZmFjdHVyZXIBAWgmAC4ARGgmAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABT" +
           "ZXJpYWxOdW1iZXIBAWkmAC4ARGkmAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRl" +
           "bXMBAWwmAC8APWwmAAD/////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBbSYALwA9bSYAAP//" +
           "//8AAAAAFWCJCgIAAAABAA8AAABGaXJtd2FyZVZlcnNpb24BAXEmAC4ARHEmAAABAScn/////wEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "EgAAAFNlbnNvclR5cGVJbnN0YW5jZQEBciYBAXImciYAAP////8FAAAAFWCJCgIAAAABAAwAAABBdmFp" +
           "bGFiaWxpdHkBAXMmAC8BAD0JcyYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0" +
           "dXJlcgEBdiYALgBEdiYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEB" +
           "dyYALgBEdyYAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBeiYALwA9eiYA" +
           "AP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQF7JgAvAD17JgAA/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "EgAAAFNvdXJjZVR5cGVJbnN0YW5jZQEBfyYBAX8mfyYAAP////8GAAAAFWCJCgIAAAABAAwAAABBdmFp" +
           "bGFiaWxpdHkBAYAmAC8BAD0JgCYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0" +
           "dXJlcgEBgyYALgBEgyYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEB" +
           "hCYALgBEhCYAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBhyYALwA9hyYA" +
           "AP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQGIJgAvAD2IJgAA/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAENvbXBvbmVudElkAQGMJgAuAESMJgAAAQEHJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "EQAAAEFzc2V0VHlwZUluc3RhbmNlAQGNJgEBjSaNJgAA/////wQAAAAVYIkKAgAAAAEADAAAAFNlcmlh" +
           "bE51bWJlcgEBjiYALgBEjiYAAAEBWif/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWFudWZhY3R1" +
           "cmVycwEBjyYALgBEjyYAAAEBNSf/////AQH/////AAAAABVgiQoCAAAAAQATAAAATGFzdENoYW5nZVRp" +
           "bWVzdGFtcAEBkCYALgBEkCYAAAAN/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEFzc2V0RGVzY3Jp" +
           "cHRpb24BAZEmAC8AP5EmAAAAGP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAE1lYXN1cmVtZW50VHlwZUluc3RhbmNlAQGSJgEBkiaSJgAAABr/////AQH/////CQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBliYALgBEliYAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAA" +
           "U2lnbmlmaWNhbnREaWdpdHMBAZgmAC4ARJgmAAABAVYn/////wEB/////wAAAAAVYIkKAgAAAAEABQAA" +
           "AFVuaXRzAQGZJgAvAD+ZJgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABOYXRpdmVVbml0" +
           "cwEBmiYALwA/miYAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQATAAAATGFzdENoYW5nZVRpbWVz" +
           "dGFtcAEBmyYALgBEmyYAAAAN/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAENvZGUBAZwmAC4ARJwm" +
           "AAABAQYn/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1heGltdW0BAZ0mAC4ARJ0mAAABATkn////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1pbmltdW0BAZ4mAC4ARJ4mAAABATkn/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABwAAAE5vbWluYWwBAZ8mAC4ARJ8mAAABATkn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "FwAAAEN1dHRpbmdUb29sVHlwZUluc3RhbmNlAQGgJgEBoCagJgAA/////wIAAAAVYIkKAgAAAAEABgAA" +
           "AFRvb2xJZAEBoSYALgBEoSYAAAEBXyf/////AQH/////AAAAABVgiQoCAAAAAQAJAAAAVG9vbEdyb3Vw" +
           "AQGiJgAuAESiJgAAAQFeJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIACAQAAAAEA" +
           "IAAAAEN1dHRpbmdUb29sTGlmZUN5Y2xlVHlwZUluc3RhbmNlAQGjJgEBoyajJgAA/////woAAAAVYIkK" +
           "AgAAAAEADAAAAFNlcmlhbE51bWJlcgEBpCYALgBEpCYAAAEBWif/////AQH/////AAAAABVgiQoCAAAA" +
           "AQATAAAATGFzdENoYW5nZVRpbWVzdGFtcAEBpiYALgBEpiYAAAAN/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEADAAAAEN1dHRlclN0YXR1cwEBqCYALwEBvyaoJgAAAQELJ/////8BAf////8BAAAAFWCJCgIAAAAB" +
           "AAYAAABTdGF0dXMBAakmAC4ARKkmAAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABSZWNvbmRp" +
           "dGlvbkNvdW50AQGqJgAvAQHBJqomAAABAVAn/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAFRvb2xM" +
           "aWZlAQGsJgAvAQHDJqwmAAAAGP////8BAf////8DAAAAFWCJCgIAAAABAAQAAABUeXBlAQGtJgAuAESt" +
           "JgAAAQFiJ/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABDb3VudERpcmVjdGlvbgEBriYALgBEriYA" +
           "AAEBYCf/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEBsCYALgBEsCYAAAEBZCf/////" +
           "AQH/////AAAAABVgiQoCAAAAAQARAAAAUHJvZ3JhbVRvb2xOdW1iZXIBAbEmAC8BAcwmsSYAAAEBTCf/" +
           "////AQH/////AwAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEBsiYALgBEsiYAAAEBOCf/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAHAAAATWluaW11bQEBsyYALgBEsyYAAAEBOif/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAHAAAATm9taW5hbAEBtCYALgBEtCYAAAEBQif/////AQH/////AAAAABVgiQoCAAAAAQAIAAAA" +
           "TG9jYXRpb24BAbUmAC8BAcgmtSYAAAEBMSf/////AQH/////AwAAABVgiQoCAAAAAQAEAAAAVHlwZQEB" +
           "tiYALgBEtiYAAAEBMif/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATmVnYXRpdmVPdmVybGFwAQG3" +
           "JgAuAES3JgAAAQFHJ/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQb3NpdGl2ZU92ZXJsYXABAbgm" +
           "AC4ARLgmAAABAUcn/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAFByb2dyYW1TcGluZGxlU3BlZWQB" +
           "AbkmAC8BAcwmuSYAAAAY/////wEB/////wMAAAAVYIkKAgAAAAEABwAAAE1heGltdW0BAbomAC4ARLom" +
           "AAABATgn/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1pbmltdW0BAbsmAC4ARLsmAAABATon////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABwAAAE5vbWluYWwBAbwmAC4ARLwmAAABAUIn/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEADwAAAFByb2dyYW1GZWVkUmF0ZQEBvSYALgBEvSYAAAEBJif/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAZAAAAQ29ubmVjdGlvbkNvZGVNYWNoaW5lU2lkZQEBviYALgBEviYAAAEBCCf/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GAAAAEN1dHRlclN0YXR1c1R5cGVJbnN0YW5jZQEBvyYBAb8mvyYAAAAY/v///wEB/////wEAAAAVYIkK" +
           "AgAAAAEABgAAAFN0YXR1cwEBwCYALgBEwCYAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HAAAAFJlY29uZGl0aW9uQ291bnRUeXBlSW5zdGFuY2UBAcEmAQHBJsEmAAAAGP7///8BAf////8BAAAA" +
           "FWCJCgIAAAABAAwAAABNYXhpbXVtQ291bnQBAcImAC4ARMImAAABATcn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "EAAAAExpZmVUeXBlSW5zdGFuY2UBAcMmAQHDJsMmAAAAGP7///8BAf////8EAAAAFWCJCgIAAAABAAQA" +
           "AABUeXBlAQHEJgAuAETEJgAAAQFiJ/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABDb3VudERpcmVj" +
           "dGlvbgEBxSYALgBExSYAAAEBYCf/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAV2FybmluZ0xldmVs" +
           "AQHGJgAuAETGJgAAAQFkJ/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQHHJgAuAETH" +
           "JgAAAQFkJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FAAAAExvY2F0aW9uVHlwZUluc3RhbmNlAQHIJgEByCbIJgAAABj+////AQH/////AwAAABVgiQoCAAAA" +
           "AQAEAAAAVHlwZQEBySYALgBEySYAAAEBMif/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATmVnYXRp" +
           "dmVPdmVybGFwAQHKJgAuAETKJgAAAQFHJ/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQb3NpdGl2" +
           "ZU92ZXJsYXABAcsmAC4ARMsmAAABAUcn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HwAAAFByb2dyYW1TcGluZGxlU3BlZWRUeXBlSW5zdGFuY2UBAcwmAQHMJswmAAAAGP7///8BAf////8D" +
           "AAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQHNJgAuAETNJgAAAQE4J/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAcAAABNaW5pbXVtAQHOJgAuAETOJgAAAQE6J/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABO" +
           "b21pbmFsAQHPJgAuAETPJgAAAQFCJ/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "GwAAAFByb2dyYW1GZWVkUmF0ZVR5cGVJbnN0YW5jZQEB0CYBAdAm0CYAAAAY/v///wEB/////wMAAAAV" +
           "YIkKAgAAAAEABwAAAE1heGltdW0BAdEmAC4ARNEmAAABATgn/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "BwAAAE1pbmltdW0BAdImAC4ARNImAAABATon/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE5vbWlu" +
           "YWwBAdMmAC4ARNMmAAABAUIn/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "FwAAAEN1dHRpbmdJdGVtVHlwZUluc3RhbmNlAQHUJgEB1CbUJgAAABj+////AQH/////CAAAABVgiQoC" +
           "AAAAAQAHAAAASW5kaWNlcwEB1SYALgBE1SYAAAEBKif/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "SXRlbUlkAQHWJgAuAETWJgAAAQEsJ/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABHcmFkZQEB1yYA" +
           "LgBE1yYAAAEBKSf/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWFudWZhY3R1cmVycwEB2CYALgBE" +
           "2CYAAAEBNSf/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGVzY3JpcHRpb24BAdkmAC4ARNkmAAAB" +
           "Ae8m/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAExvY3VzAQHaJgAuAETaJgAAAQE0J/////8BAf//" +
           "//8AAAAABGCACgEAAAABAAgAAABJdGVtTGlmZQEB2yYALwA92yYAAP////8AAAAABGCACgEAAAABAAwA" +
           "AABNZWFzdXJlbWVudHMBAdwmAC8APdwmAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkCAgAAAAEA" +
           "HwAAAEFzc2VtYmx5TWVhc3VyZW1lbnRUeXBlSW5zdGFuY2UBAd0mAQHdJt0mAAAAGv////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHhJgAuAEThJgAAAQB0A/////8BAf////8AAAAA";
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
