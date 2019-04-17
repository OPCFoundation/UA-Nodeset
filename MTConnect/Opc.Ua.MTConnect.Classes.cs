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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FQAAAE1URGV2aWNlc1R5cGVJbnN0YW5jZQEB1hkBAdYZ/////wMAAAAVYIkKAgAAAAEAEAAAAE1UQ29u" +
           "bmVjdFZlcnNpb24BAdcZAC8AP9cZAAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABPUENVQU1h" +
           "cHBpbmdEYXRlAQHYGQAvAD/YGQAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAT1BDVUFWZXJz" +
           "aW9uAQHZGQAvAD/ZGQAAAAz/////AQH/////AAAAAA==";
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
           "FwAAAE1UQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEUHAEBFBz/////GgAAABVgiQoCAAAAAAAHAAAARXZl" +
           "bnRJZAEBFRwALgBEFRwAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBFhwA" +
           "LgBEFhwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBARccAC4ARBccAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEYHAAuAEQYHAAAAAz/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBGRwALgBEGRwAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAALAAAAUmVjZWl2ZVRpbWUBARocAC4ARBocAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAE1lc3NhZ2UBARwcAC4ARBwcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0" +
           "eQEBHRwALgBEHRwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQB" +
           "AR4cAC4ARB4cAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUB" +
           "AR8cAC4ARB8cAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEgHAAu" +
           "AEQgHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBASEcAC4ARCEcAAAAEf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BASIcAC4ARCIcAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBASMcAC8BACMjIxwAAAAV/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAAAgAAAElkAQEkHAAuAEQkHAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0" +
           "eQEBLBwALwEAKiMsHAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQEtHAAuAEQtHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAS4c" +
           "AC8BACojLhwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBLxwA" +
           "LgBELxwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBMBwALwEAKiMwHAAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQExHAAuAEQxHAAAAQAm" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBATIcAC4ARDIcAAAADP////8B" +
           "Af////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEzHAAvAQBEIzMcAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAYAAABFbmFibGUBATQcAC8BAEMjNBwAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIK" +
           "BAAAAAAACgAAAEFkZENvbW1lbnQBATUcAC8BAEUjNRwAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQE2HAAuAEQ2HAAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP" +
           "/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAq" +
           "AQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRo" +
           "ZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3VycmVu" +
           "dFN0YXRlAQE5HAAvAD85HAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3RhdGUB" +
           "ATocAC8BACMjOhwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE7HAAuAEQ7HAAAAAH/" +
           "////AQH/////AAAAAARggAoBAAAAAQAKAAAATGltaXRTdGF0ZQEBQxwALwEAZiRDHAAA/////wEAAAAV" +
           "YIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBRBwALwEAyApEHAAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBAUUcAC4AREUcAAAAEf////8BAf////8AAAAAFWCJCgIAAAABAAoAAABOYXRpdmVD" +
           "b2RlAQFPHAAuAERPHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAOAAAATmF0aXZlU2V2ZXJpdHkB" +
           "AVAcAC4ARFAcAAAADP////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAEFjY2VsZXJhdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBURwBAVEc/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAVIcAC4ARFIcAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAVMcAC4ARFMcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFU" +
           "HAAuAERUHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBVRwALgBEVRwA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAVYcAC4ARFYcAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFXHAAuAERXHAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQFZHAAuAERZHAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAVocAC4ARFocAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQFbHAAuAERbHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQFcHAAuAERcHAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEBXRwALgBEXRwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFeHAAu" +
           "AEReHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFfHAAuAERfHAAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFgHAAvAQAjI2AcAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBYRwALgBEYRwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAWkcAC8BACojaRwAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBahwALgBEahwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQFrHAAvAQAqI2scAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAWwcAC4ARGwcAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAW0c" +
           "AC8BACojbRwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBbhwA" +
           "LgBEbhwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFvHAAuAERv" +
           "HAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBcBwALwEARCNwHAAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFxHAAvAQBDI3EcAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFyHAAvAQBFI3IcAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBcxwALgBEcxwAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBdhwALwA/dhwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQF3HAAvAQAjI3ccAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBeBwA" +
           "LgBEeBwAAAAB/////wEB/////wAAAAA=";
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
           "JQAAAEFjY3VtdWxhdGVkX1RpbWVDb25kaXRpb25UeXBlSW5zdGFuY2UBAY4cAQGOHP////8XAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQGPHAAuAESPHAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQGQHAAuAESQHAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBkRwALgBEkRwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAZIcAC4A" +
           "RJIcAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGTHAAuAESTHAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBlBwALgBElBwAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBlhwALgBElhwAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAACAAAAFNldmVyaXR5AQGXHAAuAESXHAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBmBwALgBEmBwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBmRwALgBEmRwAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAZocAC4ARJocAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "mxwALgBEmxwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBnBwALgBEnBwAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBnRwALwEAIyOdHAAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZ4cAC4ARJ4cAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQGmHAAvAQAqI6YcAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAaccAC4ARKccAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBqBwALwEAKiOoHAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQGpHAAuAESpHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQGqHAAvAQAqI6ocAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AascAC4ARKscAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBrBwA" +
           "LgBErBwAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAa0cAC8BAEQjrRwAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBrhwALwEAQyOuHAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBrxwALwEARSOvHAAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbAcAC4ARLAcAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAbMcAC8AP7McAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBtBwALwEAIyO0HAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AbUcAC4ARLUcAAAAAf////8BAf////8AAAAA";
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
           "HQAAAEFtcGVyYWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHLHAEByxz/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBzBwALgBEzBwAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBzRwALgBEzRwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAc4cAC4A" +
           "RM4cAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHPHAAuAETPHAAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB0BwALgBE0BwAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAdEcAC4ARNEcAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAdMcAC4ARNMcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEB1BwALgBE1BwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAdUcAC4ARNUcAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAdYcAC4ARNYcAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQHXHAAuAETXHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAdgcAC4ARNgc" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAdkcAC4ARNkcAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAdocAC8BACMj2hwAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQHbHAAuAETbHAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEB4xwALwEAKiPjHAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQHkHAAuAETkHAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAeUcAC8BACoj5RwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEB5hwALgBE5hwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB5xwALwEA" +
           "KiPnHAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHoHAAuAETo" +
           "HAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAekcAC4AROkcAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHqHAAvAQBEI+ocAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAescAC8BAEMj6xwAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAewcAC8BAEUj7BwAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHtHAAuAETtHAAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHwHAAvAD/wHAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAfEcAC8BACMj8RwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHyHAAuAETy" +
           "HAAAAAH/////AQH/////AAAAAA==";
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
           "GgAAAEFuZ2xlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEIHQEBCB3/////FwAAABVgiQoCAAAAAAAHAAAA" +
           "RXZlbnRJZAEBCR0ALgBECR0AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "Ch0ALgBECh0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAQsdAC4ARAsd" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEMHQAuAEQMHQAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBDR0ALgBEDR0AAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQ4dAC4ARA4dAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBARAdAC4ARBAdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEBER0ALgBEER0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNz" +
           "SWQBARIdAC4ARBIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05h" +
           "bWUBARMdAC4ARBMdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEU" +
           "HQAuAEQUHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBARUdAC4ARBUdAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BARYdAC4ARBYdAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBARcdAC8BACMjFx0AAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQEYHQAuAEQYHQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVh" +
           "bGl0eQEBIB0ALwEAKiMgHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEhHQAuAEQhHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkB" +
           "ASIdAC8BACojIh0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "Ix0ALgBEIx0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBJB0ALwEAKiMk" +
           "HQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQElHQAuAEQlHQAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBASYdAC4ARCYdAAAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEnHQAvAQBEIycdAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBASgdAC8BAEMjKB0AAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAACgAAAEFkZENvbW1lbnQBASkdAC8BAEUjKR0AAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEqHQAuAEQqHQAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJ" +
           "ZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQu" +
           "AQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRv" +
           "IHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3Vy" +
           "cmVudFN0YXRlAQEtHQAvAD8tHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3Rh" +
           "dGUBAS4dAC8BACMjLh0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEvHQAuAEQvHQAA" +
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
           "KQAAAEFuZ3VsYXItQWNjZWxlcmF0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFFHQEBRR3/////FwAA" +
           "ABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBRh0ALgBERh0AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CQAAAEV2ZW50VHlwZQEBRx0ALgBERx0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5vZGUBAUgdAC4AREgdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFJ" +
           "HQAuAERJHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBSh0ALgBESh0AAAEAJgH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAUsdAC4AREsdAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAU0dAC4ARE0dAAAAFf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAgAAABTZXZlcml0eQEBTh0ALgBETh0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAU8dAC4ARE8dAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAVAdAC4ARFAdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQFRHQAuAERRHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAVIdAC4ARFIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAVMdAC4ARFMd" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVQdAC8BACMjVB0AAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVHQAuAERVHQAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBXR0ALwEAKiNdHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQFeHQAuAEReHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAV8dAC8BACojXx0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBYB0ALgBEYB0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBYR0ALwEAKiNhHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQFiHQAuAERiHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AWMdAC4ARGMdAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFkHQAvAQBEI2Qd" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWUdAC8BAEMjZR0AAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWYdAC8BAEUjZh0AAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFnHQAuAERnHQAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADgAAAE1UQ3VycmVudFN0YXRlAQFqHQAvAD9qHQAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AQALAAAAQWN0aXZlU3RhdGUBAWsdAC8BACMjax0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQFsHQAuAERsHQAAAAH/////AQH/////AAAAAA==";
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
           "JQAAAEFuZ3VsYXJfVmVsb2NpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBAYIdAQGCHf////8XAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQGDHQAuAESDHQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQGEHQAuAESEHQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBhR0ALgBEhR0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAYYdAC4A" +
           "RIYdAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGHHQAuAESHHQAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBiB0ALgBEiB0AAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBih0ALgBEih0AAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAACAAAAFNldmVyaXR5AQGLHQAuAESLHQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBjB0ALgBEjB0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBjR0ALgBEjR0AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAY4dAC4ARI4dAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "jx0ALgBEjx0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBkB0ALgBEkB0AAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBkR0ALwEAIyORHQAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZIdAC4ARJIdAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQGaHQAvAQAqI5odAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAZsdAC4ARJsdAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBnB0ALwEAKiOcHQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQGdHQAuAESdHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQGeHQAvAQAqI54dAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AZ8dAC4ARJ8dAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBoB0A" +
           "LgBEoB0AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAaEdAC8BAEQjoR0AAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBoh0ALwEAQyOiHQAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBox0ALwEARSOjHQAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaQdAC4ARKQdAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAacdAC8AP6cdAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBqB0ALwEAIyOoHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AakdAC4ARKkdAAAAAf////8BAf////8AAAAA";
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
           "IwAAAENvbW11bmljYXRpb25zQ29uZGl0aW9uVHlwZUluc3RhbmNlAQG/HQEBvx3/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBwB0ALgBEwB0AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBwR0ALgBEwR0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AcIdAC4ARMIdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHDHQAuAETD" +
           "HQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBxB0ALgBExB0AAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAcUdAC4ARMUdAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAccdAC4ARMcdAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEByB0ALgBEyB0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAckdAC4ARMkdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAcodAC4ARModAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQHLHQAuAETLHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAcwd" +
           "AC4ARMwdAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAc0dAC4ARM0dAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAc4dAC8BACMjzh0AAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHPHQAuAETPHQAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEB1x0ALwEAKiPXHQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQHYHQAuAETYHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAdkdAC8BACoj2R0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEB2h0ALgBE2h0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "2x0ALwEAKiPbHQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHc" +
           "HQAuAETcHQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAd0dAC4A" +
           "RN0dAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHeHQAvAQBEI94dAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAd8dAC8BAEMj3x0AAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAeAdAC8BAEUj4B0AAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHhHQAuAEThHQAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQHkHQAvAD/kHQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAeUdAC8BACMj5R0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHm" +
           "HQAuAETmHQAAAAH/////AQH/////AAAAAA==";
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
           "IgAAAENvbmNlbnRyYXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAfwdAQH8Hf////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQH9HQAuAET9HQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQH+HQAuAET+HQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "/x0ALgBE/x0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQAeAC4ARAAe" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEBHgAuAEQBHgAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBAh4ALgBEAh4AAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBBB4ALgBEBB4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQEFHgAuAEQFHgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBBh4ALgBEBh4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBBx4ALgBEBx4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAQgeAC4ARAgeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBCR4A" +
           "LgBECR4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBCh4ALgBECh4AAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBCx4ALwEAIyMLHgAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAQweAC4ARAweAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQEUHgAvAQAqIxQeAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABARUeAC4ARBUeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBFh4ALwEAKiMWHgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQEXHgAuAEQXHgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEY" +
           "HgAvAQAqIxgeAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABARke" +
           "AC4ARBkeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBGh4ALgBE" +
           "Gh4AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARseAC8BAEQjGx4AAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBHB4ALwEAQyMcHgAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBHR4ALwEARSMdHgAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAR4eAC4ARB4eAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBASEeAC8APyEeAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBIh4ALwEAIyMiHgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASMe" +
           "AC4ARCMeAAAAAf////8BAf////8AAAAA";
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
           "IQAAAENvbmR1Y3Rpdml0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBOR4BATke/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAToeAC4ARDoeAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBATseAC4ARDseAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQE8" +
           "HgAuAEQ8HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBPR4ALgBEPR4A" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAT4eAC4ARD4eAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQE/HgAuAEQ/HgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQFBHgAuAERBHgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAUIeAC4AREIeAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQFDHgAuAERDHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQFEHgAuAEREHgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEBRR4ALgBERR4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFGHgAu" +
           "AERGHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFHHgAuAERHHgAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFIHgAvAQAjI0geAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSR4ALgBESR4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAVEeAC8BACojUR4AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBUh4ALgBEUh4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQFTHgAvAQAqI1MeAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAVQeAC4ARFQeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAVUe" +
           "AC8BACojVR4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBVh4A" +
           "LgBEVh4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFXHgAuAERX" +
           "HgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBWB4ALwEARCNYHgAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFZHgAvAQBDI1keAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFaHgAvAQBFI1oeAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWx4ALgBEWx4AAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBXh4ALwA/Xh4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQFfHgAvAQAjI18eAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBYB4A" +
           "LgBEYB4AAAAB/////wEB/////wAAAAA=";
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
           "HwAAAERhdGFfUmFuZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAXYeAQF2Hv////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQF3HgAuAER3HgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQF4HgAuAER4HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBeR4A" +
           "LgBEeR4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAXoeAC4ARHoeAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQF7HgAuAER7HgAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBfB4ALgBEfB4AAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBfh4ALgBEfh4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQF/HgAuAER/HgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBgB4ALgBEgB4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBgR4ALgBEgR4AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAYIeAC4ARIIeAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBgx4ALgBE" +
           "gx4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBhB4ALgBEhB4AAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBhR4ALwEAIyOFHgAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAYYeAC4ARIYeAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQGOHgAvAQAqI44eAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAY8eAC4ARI8eAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBkB4ALwEAKiOQHgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQGRHgAuAESRHgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGSHgAv" +
           "AQAqI5IeAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAZMeAC4A" +
           "RJMeAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBlB4ALgBElB4A" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAZUeAC8BAEQjlR4AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBlh4ALwEAQyOWHgAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBlx4ALwEARSOXHgAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZgeAC4ARJgeAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAZseAC8AP5seAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBnB4ALwEAIyOcHgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZ0eAC4A" +
           "RJ0eAAAAAf////8BAf////8AAAAA";
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
           "HgAAAERpcmVjdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBsx4BAbMe/////xcAAAAVYIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAbQeAC4ARLQeAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAbUeAC4ARLUeAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQG2HgAu" +
           "AES2HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBtx4ALgBEtx4AAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAbgeAC4ARLgeAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQG5HgAuAES5HgAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQG7HgAuAES7HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAbweAC4ARLweAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQG9HgAuAES9HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQG+HgAuAES+HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBvx4ALgBEvx4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHAHgAuAETA" +
           "HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHBHgAuAETBHgAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHCHgAvAQAjI8IeAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBwx4ALgBEwx4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAcseAC8BACojyx4AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBzB4ALgBEzB4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQHNHgAvAQAqI80eAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAc4eAC4ARM4eAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAc8eAC8B" +
           "ACojzx4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB0B4ALgBE" +
           "0B4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHRHgAuAETRHgAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0h4ALwEARCPSHgAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHTHgAvAQBDI9MeAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHUHgAvAQBFI9QeAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB1R4ALgBE1R4AAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEB2B4ALwA/2B4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQHZHgAvAQAjI9keAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB2h4ALgBE" +
           "2h4AAAAB/////wEB/////wAAAAA=";
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
           "IQAAAERpc3BsYWNlbWVudENvbmRpdGlvblR5cGVJbnN0YW5jZQEB8B4BAfAe/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAfEeAC4ARPEeAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAfIeAC4ARPIeAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHz" +
           "HgAuAETzHgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB9B4ALgBE9B4A" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAfUeAC4ARPUeAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQH2HgAuAET2HgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQH4HgAuAET4HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAfkeAC4ARPkeAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQH6HgAuAET6HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQH7HgAuAET7HgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEB/B4ALgBE/B4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQH9HgAu" +
           "AET9HgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH+HgAuAET+HgAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQH/HgAvAQAjI/8eAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAB8ALgBEAB8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAQgfAC8BACojCB8AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBCR8ALgBECR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQEKHwAvAQAqIwofAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAQsfAC4ARAsfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQwf" +
           "AC8BACojDB8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBDR8A" +
           "LgBEDR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEOHwAuAEQO" +
           "HwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBDx8ALwEARCMPHwAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEQHwAvAQBDIxAfAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQERHwAvAQBFIxEfAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEh8ALgBEEh8AAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBFR8ALwA/FR8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQEWHwAvAQAjIxYfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBFx8A" +
           "LgBEFx8AAAAB/////wEB/////wAAAAA=";
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
           "JgAAAEVsZWN0cmljYWxfRW5lcmd5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQEtHwEBLR//////FwAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBLh8ALgBELh8AAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBLx8ALgBELx8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBATAfAC4ARDAfAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQExHwAu" +
           "AEQxHwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBMh8ALgBEMh8AAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBATMfAC4ARDMfAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBATUfAC4ARDUfAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAgAAABTZXZlcml0eQEBNh8ALgBENh8AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENv" +
           "bmRpdGlvbkNsYXNzSWQBATcfAC4ARDcfAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25k" +
           "aXRpb25DbGFzc05hbWUBATgfAC4ARDgfAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25k" +
           "aXRpb25OYW1lAQE5HwAuAEQ5HwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQB" +
           "ATofAC4ARDofAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATsfAC4ARDsfAAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATwfAC8BACMjPB8AAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE9HwAuAEQ9HwAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAUXVhbGl0eQEBRR8ALwEAKiNFHwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQFGHwAuAERGHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABM" +
           "YXN0U2V2ZXJpdHkBAUcfAC8BACojRx8AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBSB8ALgBESB8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVu" +
           "dAEBSR8ALwEAKiNJHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQFKHwAuAERKHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAUsf" +
           "AC4AREsfAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFMHwAvAQBEI0wfAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAU0fAC8BAEMjTR8AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAU4fAC8BAEUjTh8AAAEBAQAAAAEA+QsA" +
           "AQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFPHwAuAERPHwAAlgIAAAABACoBAUYA" +
           "AAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1l" +
           "bnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQFSHwAvAD9SHwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAVMfAC8BACMjUx8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQFUHwAuAERUHwAAAAH/////AQH/////AAAAAA==";
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
           "HwAAAEZpbGxfTGV2ZWxDb25kaXRpb25UeXBlSW5zdGFuY2UBAWofAQFqH/////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQFrHwAuAERrHwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQFsHwAuAERsHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBbR8A" +
           "LgBEbR8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAW4fAC4ARG4fAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFvHwAuAERvHwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBcB8ALgBEcB8AAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBch8ALgBEch8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQFzHwAuAERzHwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBdB8ALgBEdB8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBdR8ALgBEdR8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAXYfAC4ARHYfAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBdx8ALgBE" +
           "dx8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBeB8ALgBEeB8AAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeR8ALwEAIyN5HwAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAXofAC4ARHofAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQGCHwAvAQAqI4IfAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAYMfAC4ARIMfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBhB8ALwEAKiOEHwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQGFHwAuAESFHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGGHwAv" +
           "AQAqI4YfAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAYcfAC4A" +
           "RIcfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBiB8ALgBEiB8A" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYkfAC8BAEQjiR8AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBih8ALwEAQyOKHwAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBix8ALwEARSOLHwAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYwfAC4ARIwfAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAY8fAC8AP48fAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBkB8ALwEAIyOQHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZEfAC4A" +
           "RJEfAAAAAf////8BAf////8AAAAA";
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
           "GQAAAEZsb3dDb25kaXRpb25UeXBlSW5zdGFuY2UBAacfAQGnH/////8XAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQGoHwAuAESoHwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGp" +
           "HwAuAESpHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBqh8ALgBEqh8A" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAasfAC4ARKsfAAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGsHwAuAESsHwAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAsAAABSZWNlaXZlVGltZQEBrR8ALgBErR8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBrx8ALgBErx8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQGwHwAuAESwHwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBsR8ALgBEsR8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBsh8ALgBEsh8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAbMf" +
           "AC4ARLMfAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBtB8ALgBEtB8AAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBtR8ALgBEtR8AAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBth8ALwEAIyO2HwAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAbcfAC4ARLcfAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQG/HwAvAQAqI78fAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAcAfAC4ARMAfAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "wR8ALwEAKiPBHwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHC" +
           "HwAuAETCHwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHDHwAvAQAqI8Mf" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAcQfAC4ARMQfAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBxR8ALgBExR8AAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAcYfAC8BAEQjxh8AAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBxx8ALwEAQyPHHwAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEByB8ALwEARSPIHwAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAckfAC4ARMkfAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBAcwfAC8AP8wfAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBzR8ALwEAIyPNHwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAc4fAC4ARM4fAAAA" +
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
           "HgAAAEZyZXF1ZW5jeUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB5B8BAeQf/////xcAAAAVYIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAeUfAC4AROUfAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAeYfAC4AROYfAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHnHwAu" +
           "AETnHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB6B8ALgBE6B8AAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAekfAC4AROkfAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHqHwAuAETqHwAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQHsHwAuAETsHwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAe0fAC4ARO0fAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQHuHwAuAETuHwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQHvHwAuAETvHwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEB8B8ALgBE8B8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHxHwAuAETx" +
           "HwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHyHwAuAETyHwAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHzHwAvAQAjI/MfAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEB9B8ALgBE9B8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAfwfAC8BACoj/B8AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEB/R8ALgBE/R8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQH+HwAvAQAqI/4fAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAf8fAC4ARP8fAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQAgAC8B" +
           "ACojACAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBASAALgBE" +
           "ASAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQECIAAuAEQCIAAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBAyAALwEARCMDIAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEEIAAvAQBDIwQgAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEFIAAvAQBFIwUgAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBBiAALgBEBiAAAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBCSAALwA/CSAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQEKIAAvAQAjIwogAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBCyAALgBE" +
           "CyAAAAAB/////wEB/////wAAAAA=";
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
           "HQAAAEhhcmR3YXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEhIAEBISD/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBIiAALgBEIiAAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBIyAALgBEIyAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBASQgAC4A" +
           "RCQgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQElIAAuAEQlIAAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBJiAALgBEJiAAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAScgAC4ARCcgAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBASkgAC4ARCkgAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBKiAALgBEKiAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBASsgAC4ARCsgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBASwgAC4ARCwgAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQEtIAAuAEQtIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAS4gAC4ARC4g" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAS8gAC4ARC8gAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATAgAC8BACMjMCAAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQExIAAuAEQxIAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBOSAALwEAKiM5IAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQE6IAAuAEQ6IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBATsgAC8BACojOyAAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBPCAALgBEPCAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBPSAALwEA" +
           "KiM9IAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQE+IAAuAEQ+" +
           "IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAT8gAC4ARD8gAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFAIAAvAQBEI0AgAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAUEgAC8BAEMjQSAAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAUIgAC8BAEUjQiAAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFDIAAuAERDIAAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQFGIAAvAD9GIAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAUcgAC8BACMjRyAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFIIAAuAERI" +
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
           "IQAAAExpbmVhcl9Gb3JjZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBXiABAV4g/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAV8gAC4ARF8gAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAWAgAC4ARGAgAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFh" +
           "IAAuAERhIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBYiAALgBEYiAA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAWMgAC4ARGMgAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFkIAAuAERkIAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQFmIAAuAERmIAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAWcgAC4ARGcgAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQFoIAAuAERoIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQFpIAAuAERpIAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEBaiAALgBEaiAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFrIAAu" +
           "AERrIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFsIAAuAERsIAAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFtIAAvAQAjI20gAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBbiAALgBEbiAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAXYgAC8BACojdiAAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBdyAALgBEdyAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQF4IAAvAQAqI3ggAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAXkgAC4ARHkgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAXog" +
           "AC8BACojeiAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBeyAA" +
           "LgBEeyAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQF8IAAuAER8" +
           "IAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBfSAALwEARCN9IAAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQF+IAAvAQBDI34gAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQF/IAAvAQBFI38gAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBgCAALgBEgCAAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBgyAALwA/gyAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQGEIAAvAQAjI4QgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBhSAA" +
           "LgBEhSAAAAAB/////wEB/////wAAAAA=";
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
           "GQAAAExvYWRDb25kaXRpb25UeXBlSW5zdGFuY2UBAZsgAQGbIP////8XAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQGcIAAuAEScIAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGd" +
           "IAAuAESdIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBniAALgBEniAA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAZ8gAC4ARJ8gAAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGgIAAuAESgIAAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAsAAABSZWNlaXZlVGltZQEBoSAALgBEoSAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBoyAALgBEoyAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQGkIAAuAESkIAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBpSAALgBEpSAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBpiAALgBEpiAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAacg" +
           "AC4ARKcgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBqCAALgBEqCAAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqSAALgBEqSAAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqiAALwEAIyOqIAAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAasgAC4ARKsgAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQGzIAAvAQAqI7MgAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAbQgAC4ARLQgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "tSAALwEAKiO1IAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQG2" +
           "IAAuAES2IAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQG3IAAvAQAqI7cg" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbggAC4ARLggAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBuSAALgBEuSAAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbogAC8BAEQjuiAAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBuyAALwEAQyO7IAAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBvCAALwEARSO8IAAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAb0gAC4ARL0gAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBAcAgAC8AP8AgAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBwSAALwEAIyPBIAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAcIgAC4ARMIgAAAA" +
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
           "IgAAAExvZ2ljX1Byb2dyYW1Db25kaXRpb25UeXBlSW5zdGFuY2UBAdggAQHYIP////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHZIAAuAETZIAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQHaIAAuAETaIAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "2yAALgBE2yAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAdwgAC4ARNwg" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQHdIAAuAETdIAAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB3iAALgBE3iAAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEB4CAALgBE4CAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQHhIAAuAEThIAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEB4iAALgBE4iAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEB4yAALgBE4yAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAeQgAC4AROQgAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB5SAA" +
           "LgBE5SAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB5iAALgBE5iAAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB5yAALwEAIyPnIAAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAeggAC4AROggAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQHwIAAvAQAqI/AgAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAfEgAC4ARPEgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEB8iAALwEAKiPyIAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQHzIAAuAETzIAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQH0" +
           "IAAvAQAqI/QgAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAfUg" +
           "AC4ARPUgAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB9iAALgBE" +
           "9iAAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAfcgAC8BAEQj9yAAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB+CAALwEAQyP4IAAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB+SAALwEARSP5IAAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfogAC4ARPogAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAf0gAC8AP/0gAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEB/iAALwEAIyP+IAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAf8g" +
           "AC4ARP8gAAAAAf////8BAf////8AAAAA";
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
           "GQAAAE1hc3NDb25kaXRpb25UeXBlSW5zdGFuY2UBARUhAQEVIf////8XAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQEWIQAuAEQWIQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQEX" +
           "IQAuAEQXIQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBGCEALgBEGCEA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBARkhAC4ARBkhAAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEaIQAuAEQaIQAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAsAAABSZWNlaXZlVGltZQEBGyEALgBEGyEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBHSEALgBEHSEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQEeIQAuAEQeIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBHyEALgBEHyEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBICEALgBEICEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBASEh" +
           "AC4ARCEhAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBIiEALgBEIiEAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBIyEALgBEIyEAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBJCEALwEAIyMkIQAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBASUhAC4ARCUhAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQEtIQAvAQAqIy0hAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAS4hAC4ARC4hAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "LyEALwEAKiMvIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEw" +
           "IQAuAEQwIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQExIQAvAQAqIzEh" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABATIhAC4ARDIhAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBMyEALgBEMyEAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATQhAC8BAEQjNCEAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNSEALwEAQyM1IQAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNiEALwEARSM2IQAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATchAC4ARDchAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBATohAC8APzohAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBOyEALwEAIyM7IQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBATwhAC4ARDwhAAAA" +
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
           "IwAAAE1vdGlvbl9Qcm9ncmFtQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFSIQEBUiH/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBUyEALgBEUyEAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBVCEALgBEVCEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AVUhAC4ARFUhAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFWIQAuAERW" +
           "IQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBVyEALgBEVyEAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAVghAC4ARFghAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAVohAC4ARFohAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBWyEALgBEWyEAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAVwhAC4ARFwhAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAV0hAC4ARF0hAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQFeIQAuAEReIQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAV8h" +
           "AC4ARF8hAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAWAhAC4ARGAhAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAWEhAC8BACMjYSEAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFiIQAuAERiIQAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBaiEALwEAKiNqIQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQFrIQAuAERrIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAWwhAC8BACojbCEAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBbSEALgBEbSEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "biEALwEAKiNuIQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFv" +
           "IQAuAERvIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAXAhAC4A" +
           "RHAhAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFxIQAvAQBEI3EhAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAXIhAC8BAEMjciEAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAXMhAC8BAEUjcyEAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF0IQAuAER0IQAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQF3IQAvAD93IQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAXghAC8BACMjeCEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQF5" +
           "IQAuAER5IQAAAAH/////AQH/////AAAAAA==";
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
           "IgAAAFBhdGhfRmVlZHJhdGVDb25kaXRpb25UeXBlSW5zdGFuY2UBAY8hAQGPIf////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQGQIQAuAESQIQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQGRIQAuAESRIQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "kiEALgBEkiEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAZMhAC4ARJMh" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGUIQAuAESUIQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBlSEALgBElSEAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBlyEALgBElyEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQGYIQAuAESYIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBmSEALgBEmSEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBmiEALgBEmiEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAZshAC4ARJshAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBnCEA" +
           "LgBEnCEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBnSEALgBEnSEAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBniEALwEAIyOeIQAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAZ8hAC4ARJ8hAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQGnIQAvAQAqI6chAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAaghAC4ARKghAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBqSEALwEAKiOpIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQGqIQAuAESqIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGr" +
           "IQAvAQAqI6shAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAawh" +
           "AC4ARKwhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBrSEALgBE" +
           "rSEAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAa4hAC8BAEQjriEAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBryEALwEAQyOvIQAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBsCEALwEARSOwIQAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbEhAC4ARLEhAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAbQhAC8AP7QhAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBtSEALwEAIyO1IQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAbYh" +
           "AC4ARLYhAAAAAf////8BAf////8AAAAA";
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
           "IgAAAFBhdGhfUG9zaXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAcwhAQHMIf////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHNIQAuAETNIQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQHOIQAuAETOIQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "zyEALgBEzyEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAdAhAC4ARNAh" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQHRIQAuAETRIQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB0iEALgBE0iEAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEB1CEALgBE1CEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQHVIQAuAETVIQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEB1iEALgBE1iEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEB1yEALgBE1yEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAdghAC4ARNghAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB2SEA" +
           "LgBE2SEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB2iEALgBE2iEAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB2yEALwEAIyPbIQAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAdwhAC4ARNwhAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQHkIQAvAQAqI+QhAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAeUhAC4AROUhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEB5iEALwEAKiPmIQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQHnIQAuAETnIQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHo" +
           "IQAvAQAqI+ghAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAekh" +
           "AC4AROkhAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB6iEALgBE" +
           "6iEAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAeshAC8BAEQj6yEAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB7CEALwEAQyPsIQAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB7SEALwEARSPtIQAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAe4hAC4ARO4hAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAfEhAC8AP/EhAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEB8iEALwEAIyPyIQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAfMh" +
           "AC4ARPMhAAAAAf////8BAf////8AAAAA";
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
           "FwAAAFBIQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEJIgEBCSL/////FwAAABVgiQoCAAAAAAAHAAAARXZl" +
           "bnRJZAEBCiIALgBECiIAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBCyIA" +
           "LgBECyIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAQwiAC4ARAwiAAAA" +
           "Ef////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQENIgAuAEQNIgAAAAz/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBDiIALgBEDiIAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAALAAAAUmVjZWl2ZVRpbWUBAQ8iAC4ARA8iAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAE1lc3NhZ2UBAREiAC4ARBEiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0" +
           "eQEBEiIALgBEEiIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQB" +
           "ARMiAC4ARBMiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUB" +
           "ARQiAC4ARBQiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEVIgAu" +
           "AEQVIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBARYiAC4ARBYiAAAAEf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BARciAC4ARBciAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBARgiAC8BACMjGCIAAAAV/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAAAgAAAElkAQEZIgAuAEQZIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0" +
           "eQEBISIALwEAKiMhIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQEiIgAuAEQiIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBASMi" +
           "AC8BACojIyIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBJCIA" +
           "LgBEJCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBJSIALwEAKiMlIgAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEmIgAuAEQmIgAAAQAm" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBASciAC4ARCciAAAADP////8B" +
           "Af////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEoIgAvAQBEIygiAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAYAAABFbmFibGUBASkiAC8BAEMjKSIAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIK" +
           "BAAAAAAACgAAAEFkZENvbW1lbnQBASoiAC8BAEUjKiIAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQErIgAuAEQrIgAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP" +
           "/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAq" +
           "AQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRo" +
           "ZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1UQ3VycmVu" +
           "dFN0YXRlAQEuIgAvAD8uIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZlU3RhdGUB" +
           "AS8iAC8BACMjLyIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEwIgAuAEQwIgAAAAH/" +
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
           "HQAAAFBvc2l0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFGIgEBRiL/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBRyIALgBERyIAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBSCIALgBESCIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAUkiAC4A" +
           "REkiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFKIgAuAERKIgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBSyIALgBESyIAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAUwiAC4AREwiAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAU4iAC4ARE4iAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBTyIALgBETyIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAVAiAC4ARFAiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAVEiAC4ARFEiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQFSIgAuAERSIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAVMiAC4ARFMi" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAVQiAC4ARFQiAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVUiAC8BACMjVSIAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQFWIgAuAERWIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBXiIALwEAKiNeIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQFfIgAuAERfIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAWAiAC8BACojYCIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBYSIALgBEYSIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBYiIALwEA" +
           "KiNiIgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFjIgAuAERj" +
           "IgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAWQiAC4ARGQiAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFlIgAvAQBEI2UiAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWYiAC8BAEMjZiIAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWciAC8BAEUjZyIAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFoIgAuAERoIgAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQFrIgAvAD9rIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAWwiAC8BACMjbCIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFtIgAuAERt" +
           "IgAAAAH/////AQH/////AAAAAA==";
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
           "IQAAAFBvd2VyX0ZhY3RvckNvbmRpdGlvblR5cGVJbnN0YW5jZQEBgyIBAYMi/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAYQiAC4ARIQiAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAYUiAC4ARIUiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGG" +
           "IgAuAESGIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBhyIALgBEhyIA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAYgiAC4ARIgiAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGJIgAuAESJIgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQGLIgAuAESLIgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAYwiAC4ARIwiAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQGNIgAuAESNIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQGOIgAuAESOIgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEBjyIALgBEjyIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGQIgAu" +
           "AESQIgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGRIgAuAESRIgAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGSIgAvAQAjI5IiAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBkyIALgBEkyIAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAZsiAC8BACojmyIAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBnCIALgBEnCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQGdIgAvAQAqI50iAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAZ4iAC4ARJ4iAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAZ8i" +
           "AC8BACojnyIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBoCIA" +
           "LgBEoCIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGhIgAuAESh" +
           "IgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBoiIALwEARCOiIgAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGjIgAvAQBDI6MiAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGkIgAvAQBFI6QiAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpSIALgBEpSIAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBqCIALwA/qCIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQGpIgAvAQAjI6kiAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBqiIA" +
           "LgBEqiIAAAAB/////wEB/////wAAAAA=";
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
           "HQAAAFByZXNzdXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHAIgEBwCL/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBwSIALgBEwSIAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBwiIALgBEwiIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAcMiAC4A" +
           "RMMiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHEIgAuAETEIgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBxSIALgBExSIAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAcYiAC4ARMYiAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAcgiAC4ARMgiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBySIALgBEySIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAcoiAC4ARMoiAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAcsiAC4ARMsiAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQHMIgAuAETMIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAc0iAC4ARM0i" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAc4iAC4ARM4iAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAc8iAC8BACMjzyIAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQHQIgAuAETQIgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEB2CIALwEAKiPYIgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQHZIgAuAETZIgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAdoiAC8BACoj2iIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEB2yIALgBE2yIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB3CIALwEA" +
           "KiPcIgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHdIgAuAETd" +
           "IgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAd4iAC4ARN4iAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHfIgAvAQBEI98iAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAeAiAC8BAEMj4CIAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAeEiAC8BAEUj4SIAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHiIgAuAETiIgAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHlIgAvAD/lIgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAeYiAC8BACMj5iIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHnIgAuAETn" +
           "IgAAAAH/////AQH/////AAAAAA==";
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
           "HwAAAFJlc2lzdGFuY2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAf0iAQH9Iv////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQH+IgAuAET+IgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQH/IgAuAET/IgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBACMA" +
           "LgBEACMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQEjAC4ARAEjAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQECIwAuAEQCIwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBAyMALgBEAyMAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBBSMALgBEBSMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQEGIwAuAEQGIwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBByMALgBEByMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBCCMALgBECCMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAQkjAC4ARAkjAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBCiMALgBE" +
           "CiMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBCyMALgBECyMAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBDCMALwEAIyMMIwAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAQ0jAC4ARA0jAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQEVIwAvAQAqIxUjAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABARYjAC4ARBYjAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBFyMALwEAKiMXIwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEYIwAuAEQYIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEZIwAv" +
           "AQAqIxkjAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABARojAC4A" +
           "RBojAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBGyMALgBEGyMA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARwjAC8BAEQjHCMAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBHSMALwEAQyMdIwAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBHiMALwEARSMeIwAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAR8jAC4ARB8jAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBASIjAC8APyIjAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBIyMALwEAIyMjIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASQjAC4A" +
           "RCQjAAAAAf////8BAf////8AAAAA";
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
           "JAAAAFJvdGFyeV9WZWxvY2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBOiMBAToj/////xcAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBATsjAC4ARDsjAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBATwjAC4ARDwjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQE9IwAuAEQ9IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBPiMALgBE" +
           "PiMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAT8jAC4ARD8jAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFAIwAuAERAIwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQFCIwAuAERCIwAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAU2V2ZXJpdHkBAUMjAC4AREMjAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25k" +
           "aXRpb25DbGFzc0lkAQFEIwAuAEREIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0" +
           "aW9uQ2xhc3NOYW1lAQFFIwAuAERFIwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0" +
           "aW9uTmFtZQEBRiMALgBERiMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFH" +
           "IwAuAERHIwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFIIwAuAERIIwAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFJIwAvAQAjI0kjAAAAFf////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSiMALgBESiMAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAFF1YWxpdHkBAVIjAC8BACojUiMAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBUyMALgBEUyMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFz" +
           "dFNldmVyaXR5AQFUIwAvAQAqI1QjAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAVUjAC4ARFUjAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQB" +
           "AVYjAC8BACojViMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "VyMALgBEVyMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFYIwAu" +
           "AERYIwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBWSMALwEARCNZIwAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFaIwAvAQBDI1ojAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFbIwAvAQBFI1sjAAABAQEAAAABAPkLAAEA" +
           "DQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBXCMALgBEXCMAAJYCAAAAAQAqAQFGAAAA" +
           "BwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0" +
           "byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50" +
           "IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBXyMALwA/XyMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQFgIwAvAQAjI2AjAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "YSMALgBEYSMAAAAB/////wEB/////wAAAAA=";
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
           "IAAAAFNvdW5kX0xldmVsQ29uZGl0aW9uVHlwZUluc3RhbmNlAQF3IwEBdyP/////FwAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBeCMALgBEeCMAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBeSMALgBEeSMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAXoj" +
           "AC4ARHojAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQF7IwAuAER7IwAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBfCMALgBEfCMAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAX0jAC4ARH0jAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBAX8jAC4ARH8jAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEBgCMALgBEgCMAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBAYEjAC4ARIEjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBAYIjAC4ARIIjAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQGDIwAuAESDIwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAYQjAC4A" +
           "RIQjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAYUjAC4ARIUjAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAYYjAC8BACMjhiMAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQGHIwAuAESHIwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEBjyMALwEAKiOPIwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQGQIwAuAESQIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAZEjAC8BACojkSMAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBkiMALgBEkiMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBkyMA" +
           "LwEAKiOTIwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGUIwAu" +
           "AESUIwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAZUjAC4ARJUj" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGWIwAvAQBEI5YjAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAZcjAC8BAEMjlyMAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAZgjAC8BAEUjmCMAAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGZIwAuAESZIwAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQGcIwAvAD+cIwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAZ0jAC8BACMjnSMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGeIwAu" +
           "AESeIwAAAAH/////AQH/////AAAAAA==";
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
           "GwAAAFN0cmFpbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBtCMBAbQj/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAbUjAC4ARLUjAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AbYjAC4ARLYjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQG3IwAuAES3" +
           "IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBuCMALgBEuCMAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAbkjAC4ARLkjAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQG6IwAuAES6IwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQG8IwAuAES8IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAb0jAC4ARL0jAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQG+IwAuAES+IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQG/IwAuAES/IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "wCMALgBEwCMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHBIwAuAETBIwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHCIwAuAETCIwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHDIwAvAQAjI8MjAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBxCMALgBExCMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAcwjAC8BACojzCMAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBzSMALgBEzSMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQHOIwAvAQAqI84jAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "Ac8jAC4ARM8jAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAdAjAC8BACoj" +
           "0CMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB0SMALgBE0SMA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHSIwAuAETSIwAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0yMALwEARCPTIwAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHUIwAvAQBDI9QjAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHVIwAvAQBFI9UjAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB1iMALgBE1iMAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEB2SMALwA/2SMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQHaIwAvAQAjI9ojAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB2yMALgBE2yMA" +
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
           "GwAAAFN5c3RlbUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB8SMBAfEj/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAfIjAC4ARPIjAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AfMjAC4ARPMjAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQH0IwAuAET0" +
           "IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB9SMALgBE9SMAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAfYjAC4ARPYjAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQH3IwAuAET3IwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQH5IwAuAET5IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAfojAC4ARPojAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQH7IwAuAET7IwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQH8IwAuAET8IwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "/SMALgBE/SMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQH+IwAuAET+IwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH/IwAuAET/IwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEAJAAvAQAjIwAkAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBASQALgBEASQAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAQkkAC8BACojCSQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBCiQALgBECiQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQELJAAvAQAqIwskAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AQwkAC4ARAwkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQ0kAC8BACoj" +
           "DSQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBDiQALgBEDiQA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEPJAAuAEQPJAAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBECQALwEARCMQJAAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQERJAAvAQBDIxEkAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQESJAAvAQBFIxIkAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEyQALgBEEyQAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBFiQALwA/FiQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQEXJAAvAQAjIxckAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBGCQALgBEGCQA" +
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
           "IAAAAFRlbXBlcmF0dXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEuJAEBLiT/////FwAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBLyQALgBELyQAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBMCQALgBEMCQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBATEk" +
           "AC4ARDEkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEyJAAuAEQyJAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBMyQALgBEMyQAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBATQkAC4ARDQkAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBATYkAC4ARDYkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEBNyQALgBENyQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBATgkAC4ARDgkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBATkkAC4ARDkkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQE6JAAuAEQ6JAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBATskAC4A" +
           "RDskAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATwkAC4ARDwkAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAT0kAC8BACMjPSQAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQE+JAAuAEQ+JAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEBRiQALwEAKiNGJAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFHJAAuAERHJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAUgkAC8BACojSCQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBSSQALgBESSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBSiQA" +
           "LwEAKiNKJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFLJAAu" +
           "AERLJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAUwkAC4AREwk" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFNJAAvAQBEI00kAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAU4kAC8BAEMjTiQAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAU8kAC8BAEUjTyQAAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQJAAuAERQJAAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQFTJAAvAD9TJAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAVQkAC8BACMjVCQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVJAAu" +
           "AERVJAAAAAH/////AQH/////AAAAAA==";
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
           "GQAAAFRpbHRDb25kaXRpb25UeXBlSW5zdGFuY2UBAWskAQFrJP////8XAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQFsJAAuAERsJAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQFt" +
           "JAAuAERtJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBbiQALgBEbiQA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAW8kAC4ARG8kAAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFwJAAuAERwJAAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAsAAABSZWNlaXZlVGltZQEBcSQALgBEcSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBcyQALgBEcyQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQF0JAAuAER0JAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBdSQALgBEdSQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBdiQALgBEdiQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAXck" +
           "AC4ARHckAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBeCQALgBEeCQAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBeSQALgBEeSQAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeiQALwEAIyN6JAAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAXskAC4ARHskAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQGDJAAvAQAqI4MkAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAYQkAC4ARIQkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "hSQALwEAKiOFJAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGG" +
           "JAAuAESGJAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQGHJAAvAQAqI4ck" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAYgkAC4ARIgkAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBiSQALgBEiSQAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYokAC8BAEQjiiQAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBiyQALwEAQyOLJAAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBjCQALwEARSOMJAAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY0kAC4ARI0kAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBAZAkAC8AP5AkAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBkSQALwEAIyORJAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZIkAC4ARJIkAAAA" +
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
           "GwAAAFRvcnF1ZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBqCQBAagk/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAakkAC4ARKkkAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AaokAC4ARKokAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGrJAAuAESr" +
           "JAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBrCQALgBErCQAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAa0kAC4ARK0kAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGuJAAuAESuJAAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQGwJAAuAESwJAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAbEkAC4ARLEkAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQGyJAAuAESyJAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQGzJAAuAESzJAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "tCQALgBEtCQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQG1JAAuAES1JAAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQG2JAAuAES2JAAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQG3JAAvAQAjI7ckAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBuCQALgBEuCQAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAcAkAC8BACojwCQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBwSQALgBEwSQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQHCJAAvAQAqI8IkAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AcMkAC4ARMMkAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAcQkAC8BACoj" +
           "xCQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBxSQALgBExSQA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHGJAAuAETGJAAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBxyQALwEARCPHJAAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHIJAAvAQBDI8gkAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHJJAAvAQBFI8kkAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEByiQALgBEyiQAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBzSQALwA/zSQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQHOJAAvAQAjI84kAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBzyQALgBEzyQA" +
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
           "HQAAAFZlbG9jaXR5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQHlJAEB5ST/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEB5iQALgBE5iQAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEB5yQALgBE5yQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAegkAC4A" +
           "ROgkAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHpJAAuAETpJAAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB6iQALgBE6iQAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAeskAC4AROskAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAe0kAC4ARO0kAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEB7iQALgBE7iQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAe8kAC4ARO8kAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAfAkAC4ARPAkAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQHxJAAuAETxJAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAfIkAC4ARPIk" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAfMkAC4ARPMkAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAfQkAC8BACMj9CQAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQH1JAAuAET1JAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEB/SQALwEAKiP9JAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQH+JAAuAET+JAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAf8kAC8BACoj/yQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBACUALgBEACUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBASUALwEA" +
           "KiMBJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQECJQAuAEQC" +
           "JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAQMlAC4ARAMlAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEEJQAvAQBEIwQlAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAQUlAC8BAEMjBSUAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAQYlAC8BAEUjBiUAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEHJQAuAEQHJQAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQEKJQAvAD8KJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAQslAC8BACMjCyUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEMJQAuAEQM" +
           "JQAAAAH/////AQH/////AAAAAA==";
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
           "HgAAAFZpc2Nvc2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBIiUBASIl/////xcAAAAVYIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBASMlAC4ARCMlAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBASQlAC4ARCQlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQElJQAu" +
           "AEQlJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBJiUALgBEJiUAAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBASclAC4ARCclAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEoJQAuAEQoJQAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQEqJQAuAEQqJQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBASslAC4ARCslAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQEsJQAuAEQsJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQEtJQAuAEQtJQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBLiUALgBELiUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQEvJQAuAEQv" +
           "JQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQEwJQAuAEQwJQAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQExJQAvAQAjIzElAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBMiUALgBEMiUAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBATolAC8BACojOiUAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBOyUALgBEOyUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQE8JQAvAQAqIzwlAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAT0lAC4ARD0lAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAT4lAC8B" +
           "ACojPiUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBPyUALgBE" +
           "PyUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFAJQAuAERAJQAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBQSUALwEARCNBJQAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFCJQAvAQBDI0IlAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFDJQAvAQBFI0MlAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRCUALgBERCUAAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBRyUALwA/RyUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQFIJQAvAQAjI0glAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBSSUALgBE" +
           "SSUAAAAB/////wEB/////wAAAAA=";
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
           "HAAAAFZvbHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAV8lAQFfJf////8XAAAAFWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQFgJQAuAERgJQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AQFhJQAuAERhJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBYiUALgBE" +
           "YiUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAWMlAC4ARGMlAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFkJQAuAERkJQAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBZSUALgBEZSUAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBZyUALgBEZyUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQFoJQAuAERoJQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xh" +
           "c3NJZAEBaSUALgBEaSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNz" +
           "TmFtZQEBaiUALgBEaiUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUB" +
           "AWslAC4ARGslAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBbCUALgBEbCUA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBbSUALgBEbSUAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBbiUALwEAIyNuJQAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAW8lAC4ARG8lAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABR" +
           "dWFsaXR5AQF3JQAvAQAqI3clAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAXglAC4ARHglAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0" +
           "eQEBeSUALwEAKiN5JQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQF6JQAuAER6JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQF7JQAvAQAq" +
           "I3slAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAXwlAC4ARHwl" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBfSUALgBEfSUAAAAM" +
           "/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAX4lAC8BAEQjfiUAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBfyUALwEAQyN/JQAAAQEBAAAAAQD5CwABAPMKAAAA" +
           "AARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBgCUALwEARSOAJQAAAQEBAAAAAQD5CwABAA0LAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYElAC4ARIElAACWAgAAAAEAKgEBRgAAAAcAAABFdmVu" +
           "dElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVu" +
           "dC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQg" +
           "dG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRD" +
           "dXJyZW50U3RhdGUBAYQlAC8AP4QlAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVT" +
           "dGF0ZQEBhSUALwEAIyOFJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAYYlAC4ARIYl" +
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
           "IgAAAFZvbHRfQW1wZXJhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAZwlAQGcJf////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQGdJQAuAESdJQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQGeJQAuAESeJQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "nyUALgBEnyUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAaAlAC4ARKAl" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGhJQAuAEShJQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBoiUALgBEoiUAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBpCUALgBEpCUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQGlJQAuAESlJQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBpiUALgBEpiUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBpyUALgBEpyUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAaglAC4ARKglAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBqSUA" +
           "LgBEqSUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqiUALgBEqiUAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqyUALwEAIyOrJQAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAawlAC4ARKwlAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQG0JQAvAQAqI7QlAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAbUlAC4ARLUlAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBtiUALwEAKiO2JQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQG3JQAuAES3JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQG4" +
           "JQAvAQAqI7glAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbkl" +
           "AC4ARLklAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBuiUALgBE" +
           "uiUAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbslAC8BAEQjuyUAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBvCUALwEAQyO8JQAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBvSUALwEARSO9JQAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAb4lAC4ARL4lAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAcElAC8AP8ElAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBwiUALwEAIyPCJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAcMl" +
           "AC4ARMMlAAAAAf////8BAf////8AAAAA";
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
           "KQAAAFZvbHRBbXBlcmFnZVJlYWN0aXZlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHZJQEB2SX/////FwAA" +
           "ABVgiQoCAAAAAAAHAAAARXZlbnRJZAEB2iUALgBE2iUAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CQAAAEV2ZW50VHlwZQEB2yUALgBE2yUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5vZGUBAdwlAC4ARNwlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHd" +
           "JQAuAETdJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB3iUALgBE3iUAAAEAJgH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAd8lAC4ARN8lAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAeElAC4AROElAAAAFf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAgAAABTZXZlcml0eQEB4iUALgBE4iUAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAeMlAC4AROMlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAeQlAC4AROQlAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQHlJQAuAETlJQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAeYlAC4AROYlAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAeclAC4AROcl" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAeglAC8BACMj6CUAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHpJQAuAETpJQAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEB8SUALwEAKiPxJQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQHyJQAuAETyJQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAfMlAC8BACoj8yUAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEB9CUALgBE9CUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEB9SUALwEAKiP1JQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQH2JQAuAET2JQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AfclAC4ARPclAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQH4JQAvAQBEI/gl" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAfklAC8BAEMj+SUAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAfolAC8BAEUj+iUAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH7JQAuAET7JQAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADgAAAE1UQ3VycmVudFN0YXRlAQH+JQAvAD/+JQAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AQALAAAAQWN0aXZlU3RhdGUBAf8lAC8BACMj/yUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQEAJgAuAEQAJgAAAAH/////AQH/////AAAAAA==";
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
           "HAAAAFdhdHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBARYmAQEWJv////8XAAAAFWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQEXJgAuAEQXJgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AQEYJgAuAEQYJgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBGSYALgBE" +
           "GSYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBARomAC4ARBomAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEbJgAuAEQbJgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBHCYALgBEHCYAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBHiYALgBEHiYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQEfJgAuAEQfJgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xh" +
           "c3NJZAEBICYALgBEICYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNz" +
           "TmFtZQEBISYALgBEISYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUB" +
           "ASImAC4ARCImAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBIyYALgBEIyYA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBJCYALgBEJCYAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBJSYALwEAIyMlJgAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBASYmAC4ARCYmAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABR" +
           "dWFsaXR5AQEuJgAvAQAqIy4mAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAS8mAC4ARC8mAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0" +
           "eQEBMCYALwEAKiMwJgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQExJgAuAEQxJgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEyJgAvAQAq" +
           "IzImAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABATMmAC4ARDMm" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBNCYALgBENCYAAAAM" +
           "/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATUmAC8BAEQjNSYAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNiYALwEAQyM2JgAAAQEBAAAAAQD5CwABAPMKAAAA" +
           "AARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNyYALwEARSM3JgAAAQEBAAAAAQD5CwABAA0LAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATgmAC4ARDgmAACWAgAAAAEAKgEBRgAAAAcAAABFdmVu" +
           "dElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVu" +
           "dC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQg" +
           "dG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRD" +
           "dXJyZW50U3RhdGUBATsmAC8APzsmAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVT" +
           "dGF0ZQEBPCYALwEAIyM8JgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAT0mAC4ARD0m" +
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAEN1dHRpbmdUb29sVHlwZUluc3RhbmNlAQGgJgEBoCb/////AgAAABVgiQoCAAAAAQAGAAAAVG9v" +
           "bElkAQGhJgAuAEShJgAAAQFfJ/////8BAf////8AAAAAFWCJCgIAAAABAAkAAABUb29sR3JvdXABAaIm" +
           "AC4ARKImAAABAV4n/////wEB/////wAAAAA=";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "GAAAAEN1dHRlclN0YXR1c1R5cGVJbnN0YW5jZQEBvyYBAb8mABgBAf////8BAAAAFWCJCgIAAAABAAYA" +
           "AABTdGF0dXMBAcAmAC4ARMAmAAAADP////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HAAAAFJlY29uZGl0aW9uQ291bnRUeXBlSW5zdGFuY2UBAcEmAQHBJgAYAQH/////AQAAABVgiQoCAAAA" +
           "AQAMAAAATWF4aW11bUNvdW50AQHCJgAuAETCJgAAAQE3J/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "FAAAAExvY2F0aW9uVHlwZUluc3RhbmNlAQHIJgEByCYAGAEB/////wMAAAAVYIkKAgAAAAEABAAAAFR5" +
           "cGUBAckmAC4ARMkmAAABATIn/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE5lZ2F0aXZlT3Zlcmxh" +
           "cAEByiYALgBEyiYAAAEBRyf/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUG9zaXRpdmVPdmVybGFw" +
           "AQHLJgAuAETLJgAAAQFHJ/////8BAf////8AAAAA";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HwAAAFByb2dyYW1TcGluZGxlU3BlZWRUeXBlSW5zdGFuY2UBAcwmAQHMJgAYAQH/////AwAAABVgiQoC" +
           "AAAAAQAHAAAATWF4aW11bQEBzSYALgBEzSYAAAEBOCf/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "TWluaW11bQEBziYALgBEziYAAAEBOif/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATm9taW5hbAEB" +
           "zyYALgBEzyYAAAEBQif/////AQH/////AAAAAA==";
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
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "GwAAAFByb2dyYW1GZWVkUmF0ZVR5cGVJbnN0YW5jZQEB0CYBAdAmABgBAf////8DAAAAFWCJCgIAAAAB" +
           "AAcAAABNYXhpbXVtAQHRJgAuAETRJgAAAQE4J/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNaW5p" +
           "bXVtAQHSJgAuAETSJgAAAQE6J/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFsAQHTJgAu" +
           "AETTJgAAAQFCJ/////8BAf////8AAAAA";
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
