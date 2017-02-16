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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Fdi7
{
    #region Foundation_H1State Class
    #if (!OPCUA_EXCLUDE_Foundation_H1State)
    /// <summary>
    /// Stores an instance of the Foundation_H1 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Foundation_H1State : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Foundation_H1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.Foundation_H1, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAVAAAARm91bmRhdGlvbl9IMUluc3RhbmNl" +
           "AQFbBQEBWwX/////AAAAAA==";
        #endregion
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

    #region Foundation_HSEState Class
    #if (!OPCUA_EXCLUDE_Foundation_HSEState)
    /// <summary>
    /// Stores an instance of the Foundation_HSE ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Foundation_HSEState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Foundation_HSEState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.Foundation_HSE, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAWAAAARm91bmRhdGlvbl9IU0VJbnN0YW5j" +
           "ZQEBXAUBAVwF/////wAAAAA=";
        #endregion
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

    #region Profibus_DPState Class
    #if (!OPCUA_EXCLUDE_Profibus_DPState)
    /// <summary>
    /// Stores an instance of the Profibus_DP ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Profibus_DPState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Profibus_DPState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.Profibus_DP, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQATAAAAUHJvZmlidXNfRFBJbnN0YW5jZQEB" +
           "XQUBAV0F/////wAAAAA=";
        #endregion
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

    #region Profibus_PAState Class
    #if (!OPCUA_EXCLUDE_Profibus_PAState)
    /// <summary>
    /// Stores an instance of the Profibus_PA ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Profibus_PAState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Profibus_PAState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.Profibus_PA, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQATAAAAUHJvZmlidXNfUEFJbnN0YW5jZQEB" +
           "XgUBAV4F/////wAAAAA=";
        #endregion
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

    #region Profinet_IOState Class
    #if (!OPCUA_EXCLUDE_Profinet_IOState)
    /// <summary>
    /// Stores an instance of the Profinet_IO ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Profinet_IOState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Profinet_IOState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.Profinet_IO, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQATAAAAUHJvZmluZXRfSU9JbnN0YW5jZQEB" +
           "XwUBAV8F/////wAAAAA=";
        #endregion
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

    #region HARTState Class
    #if (!OPCUA_EXCLUDE_HARTState)
    /// <summary>
    /// Stores an instance of the HART ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HARTState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public HARTState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.HART, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAMAAAASEFSVEluc3RhbmNlAQFgBQEBYAX/" +
           "////AAAAAA==";
        #endregion
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

    #region ISA100_WirelessState Class
    #if (!OPCUA_EXCLUDE_ISA100_WirelessState)
    /// <summary>
    /// Stores an instance of the ISA100_Wireless ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISA100_WirelessState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISA100_WirelessState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ISA100_Wireless, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAXAAAASVNBMTAwX1dpcmVsZXNzSW5zdGFu" +
           "Y2UBAWEFAQFhBf////8AAAAA";
        #endregion
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

    #region GenericProtocolState Class
    #if (!OPCUA_EXCLUDE_GenericProtocolState)
    /// <summary>
    /// Stores an instance of the GenericProtocol ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericProtocolState : ProtocolState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericProtocolState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.GenericProtocol, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAXAAAAR2VuZXJpY1Byb3RvY29sSW5zdGFu" +
           "Y2UBAWIFAQFiBf////8BAAAAFWCJCgIAAAABABIAAABQcm90b2NvbElkZW50aWZpZXIBAWMFAC4ARGMF" +
           "AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ProtocolIdentifier Property.
        /// </summary>
        public PropertyState<string> ProtocolIdentifier
        {
            get
            {
                return m_protocolIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_protocolIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_protocolIdentifier = value;
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
            if (m_protocolIdentifier != null)
            {
                children.Add(m_protocolIdentifier);
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
                case Opc.Ua.Fdi7.BrowseNames.ProtocolIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (ProtocolIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                ProtocolIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProtocolIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProtocolIdentifier;
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
        private PropertyState<string> m_protocolIdentifier;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_Foundation_H1State Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_Foundation_H1State)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_Foundation_H1 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_Foundation_H1State : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_Foundation_H1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_Foundation_H1, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (OrdinalNumber != null)
            {
                OrdinalNumber.Initialize(context, OrdinalNumber_InitializationString);
            }

            if (SIFConnection != null)
            {
                SIFConnection.Initialize(context, SIFConnection_InitializationString);
            }
        }

        #region Initialization String
        private const string OrdinalNumber_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAT3JkaW5hbE51bWJlcgEBjgUALgBE" +
           "jgUAAAAG/////wEB/////wAAAAA=";

        private const string SIFConnection_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAU0lGQ29ubmVjdGlvbgEBjwUALgBE" +
           "jwUAAAAB/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQ29ubmVjdGlvblBvaW50X0ZvdW5k" +
           "YXRpb25fSDFJbnN0YW5jZQEBZAUBAWQF/////wQAAAAkYIAKAQAAAAIADgAAAE5ldHdvcmtBZGRyZXNz" +
           "AQF7BQMAAAAAKgAAAFRoZSBhZGRyZXNzIG9mIHRoZSBkZXZpY2Ugb24gdGhpcyBuZXR3b3JrLgAvAQLt" +
           "A3sFAAD/////AAAAABVgiQoCAAAAAQAHAAAAQWRkcmVzcwEBjQUALgBEjQUAAAAD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEADQAAAE9yZGluYWxOdW1iZXIBAY4FAC4ARI4FAAAABv////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAA0AAABTSUZDb25uZWN0aW9uAQGPBQAuAESPBQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Address Property.
        /// </summary>
        public PropertyState<byte> Address
        {
            get
            {
                return m_address;
            }

            set
            {
                if (!Object.ReferenceEquals(m_address, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_address = value;
            }
        }

        /// <summary>
        /// A description for the OrdinalNumber Property.
        /// </summary>
        public PropertyState<int> OrdinalNumber
        {
            get
            {
                return m_ordinalNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ordinalNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ordinalNumber = value;
            }
        }

        /// <summary>
        /// A description for the SIFConnection Property.
        /// </summary>
        public PropertyState<bool> SIFConnection
        {
            get
            {
                return m_sIFConnection;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIFConnection, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIFConnection = value;
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
            if (m_address != null)
            {
                children.Add(m_address);
            }

            if (m_ordinalNumber != null)
            {
                children.Add(m_ordinalNumber);
            }

            if (m_sIFConnection != null)
            {
                children.Add(m_sIFConnection);
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
                case Opc.Ua.Fdi7.BrowseNames.Address:
                {
                    if (createOrReplace)
                    {
                        if (Address == null)
                        {
                            if (replacement == null)
                            {
                                Address = new PropertyState<byte>(this);
                            }
                            else
                            {
                                Address = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = Address;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.OrdinalNumber:
                {
                    if (createOrReplace)
                    {
                        if (OrdinalNumber == null)
                        {
                            if (replacement == null)
                            {
                                OrdinalNumber = new PropertyState<int>(this);
                            }
                            else
                            {
                                OrdinalNumber = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = OrdinalNumber;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.SIFConnection:
                {
                    if (createOrReplace)
                    {
                        if (SIFConnection == null)
                        {
                            if (replacement == null)
                            {
                                SIFConnection = new PropertyState<bool>(this);
                            }
                            else
                            {
                                SIFConnection = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = SIFConnection;
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
        private PropertyState<byte> m_address;
        private PropertyState<int> m_ordinalNumber;
        private PropertyState<bool> m_sIFConnection;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_Foundation_HSEState Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_Foundation_HSEState)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_Foundation_HSE ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_Foundation_HSEState : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_Foundation_HSEState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_Foundation_HSE, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (OrdinalNumber != null)
            {
                OrdinalNumber.Initialize(context, OrdinalNumber_InitializationString);
            }
        }

        #region Initialization String
        private const string OrdinalNumber_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAT3JkaW5hbE51bWJlcgEBugUALgBE" +
           "ugUAAAAG/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAmAAAAQ29ubmVjdGlvblBvaW50X0ZvdW5k" +
           "YXRpb25fSFNFSW5zdGFuY2UBAZAFAQGQBf////8DAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRkcmVz" +
           "cwEBpwUDAAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEC" +
           "7QOnBQAA/////wAAAAAXYIkKAgAAAAEABwAAAEFkZHJlc3MBAbkFAC4ARLkFAAAAAwEAAAABAAAAEAAA" +
           "AAEB/////wAAAAAVYIkKAgAAAAEADQAAAE9yZGluYWxOdW1iZXIBAboFAC4ARLoFAAAABv////8BAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Address Property.
        /// </summary>
        public PropertyState<byte[]> Address
        {
            get
            {
                return m_address;
            }

            set
            {
                if (!Object.ReferenceEquals(m_address, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_address = value;
            }
        }

        /// <summary>
        /// A description for the OrdinalNumber Property.
        /// </summary>
        public PropertyState<int> OrdinalNumber
        {
            get
            {
                return m_ordinalNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ordinalNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ordinalNumber = value;
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
            if (m_address != null)
            {
                children.Add(m_address);
            }

            if (m_ordinalNumber != null)
            {
                children.Add(m_ordinalNumber);
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
                case Opc.Ua.Fdi7.BrowseNames.Address:
                {
                    if (createOrReplace)
                    {
                        if (Address == null)
                        {
                            if (replacement == null)
                            {
                                Address = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                Address = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = Address;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.OrdinalNumber:
                {
                    if (createOrReplace)
                    {
                        if (OrdinalNumber == null)
                        {
                            if (replacement == null)
                            {
                                OrdinalNumber = new PropertyState<int>(this);
                            }
                            else
                            {
                                OrdinalNumber = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = OrdinalNumber;
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
        private PropertyState<byte[]> m_address;
        private PropertyState<int> m_ordinalNumber;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_Profibus_DPState Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_Profibus_DPState)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_Profibus_DP ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_Profibus_DPState : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_Profibus_DPState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_Profibus_DP, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAjAAAAQ29ubmVjdGlvblBvaW50X1Byb2Zp" +
           "YnVzX0RQSW5zdGFuY2UBAbsFAQG7Bf////8CAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRkcmVzcwEB" +
           "0gUDAAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEC7QPS" +
           "BQAA/////wAAAAAVYIkKAgAAAAEABwAAAEFkZHJlc3MBAeQFAC4AROQFAAAAA/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Address Property.
        /// </summary>
        public PropertyState<byte> Address
        {
            get
            {
                return m_address;
            }

            set
            {
                if (!Object.ReferenceEquals(m_address, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_address = value;
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
            if (m_address != null)
            {
                children.Add(m_address);
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
                case Opc.Ua.Fdi7.BrowseNames.Address:
                {
                    if (createOrReplace)
                    {
                        if (Address == null)
                        {
                            if (replacement == null)
                            {
                                Address = new PropertyState<byte>(this);
                            }
                            else
                            {
                                Address = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = Address;
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
        private PropertyState<byte> m_address;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_Profinet_IOState Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_Profinet_IOState)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_Profinet_IO ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_Profinet_IOState : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_Profinet_IOState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_Profinet_IO, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAjAAAAQ29ubmVjdGlvblBvaW50X1Byb2Zp" +
           "bmV0X0lPSW5zdGFuY2UBAeUFAQHlBf////8FAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRkcmVzcwEB" +
           "/AUDAAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEC7QP8" +
           "BQAA/////wAAAAAXYIkKAgAAAAEAAwAAAE1BQwEBDgYALgBEDgYAAAADAQAAAAEAAAAQAAAAAQH/////" +
           "AAAAABdgiQoCAAAAAQAEAAAASVB2NAEBDwYALgBEDwYAAAADAQAAAAEAAAAEAAAAAQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAARE5TTkFNRQEBEAYALgBEEAYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAA" +
           "AFZBTElEAQERBgAuAEQRBgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MAC Property.
        /// </summary>
        public PropertyState<byte[]> MAC
        {
            get
            {
                return m_mAC;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mAC, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mAC = value;
            }
        }

        /// <summary>
        /// A description for the IPv4 Property.
        /// </summary>
        public PropertyState<byte[]> IPv4
        {
            get
            {
                return m_iPv4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iPv4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iPv4 = value;
            }
        }

        /// <summary>
        /// A description for the DNSNAME Property.
        /// </summary>
        public PropertyState<string> DNSNAME
        {
            get
            {
                return m_dNSNAME;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dNSNAME, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dNSNAME = value;
            }
        }

        /// <summary>
        /// A description for the VALID Property.
        /// </summary>
        public PropertyState<bool> VALID
        {
            get
            {
                return m_vALID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vALID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vALID = value;
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
            if (m_mAC != null)
            {
                children.Add(m_mAC);
            }

            if (m_iPv4 != null)
            {
                children.Add(m_iPv4);
            }

            if (m_dNSNAME != null)
            {
                children.Add(m_dNSNAME);
            }

            if (m_vALID != null)
            {
                children.Add(m_vALID);
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
                case Opc.Ua.Fdi7.BrowseNames.MAC:
                {
                    if (createOrReplace)
                    {
                        if (MAC == null)
                        {
                            if (replacement == null)
                            {
                                MAC = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                MAC = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = MAC;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.IPv4:
                {
                    if (createOrReplace)
                    {
                        if (IPv4 == null)
                        {
                            if (replacement == null)
                            {
                                IPv4 = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                IPv4 = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = IPv4;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DNSNAME:
                {
                    if (createOrReplace)
                    {
                        if (DNSNAME == null)
                        {
                            if (replacement == null)
                            {
                                DNSNAME = new PropertyState<string>(this);
                            }
                            else
                            {
                                DNSNAME = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DNSNAME;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.VALID:
                {
                    if (createOrReplace)
                    {
                        if (VALID == null)
                        {
                            if (replacement == null)
                            {
                                VALID = new PropertyState<bool>(this);
                            }
                            else
                            {
                                VALID = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = VALID;
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
        private PropertyState<byte[]> m_mAC;
        private PropertyState<byte[]> m_iPv4;
        private PropertyState<string> m_dNSNAME;
        private PropertyState<bool> m_vALID;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_HART_TP5State Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_HART_TP5State)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_HART_TP5 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_HART_TP5State : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_HART_TP5State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_HART_TP5, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DevMfg != null)
            {
                DevMfg.Initialize(context, DevMfg_InitializationString);
            }

            if (DevType != null)
            {
                DevType.Initialize(context, DevType_InitializationString);
            }

            if (DevRev != null)
            {
                DevRev.Initialize(context, DevRev_InitializationString);
            }

            if (DevTag != null)
            {
                DevTag.Initialize(context, DevTag_InitializationString);
            }

            if (DevPollAddr != null)
            {
                DevPollAddr.Initialize(context, DevPollAddr_InitializationString);
            }
        }

        #region Initialization String
        private const string DevMfg_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2TWZnAQE8BgAuAEQ8BgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevType_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAHAAAARGV2VHlwZQEBPQYALgBEPQYAAAAF" +
           "/////wEB/////wAAAAA=";

        private const string DevRev_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2UmV2AQE+BgAuAEQ+BgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevTag_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2VGFnAQE/BgAuAEQ/BgAAAAz/" +
           "////AQH/////AAAAAA==";

        private const string DevPollAddr_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAUAGAC4AREAG" +
           "AAAAA/////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAgAAAAQ29ubmVjdGlvblBvaW50X0hBUlRf" +
           "VFA1SW5zdGFuY2UBARIGAQESBv////8HAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRkcmVzcwEBKQYD" +
           "AAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEC7QMpBgAA" +
           "/////wAAAAAXYIkKAgAAAAEABwAAAERldkFkZHIBATsGAC4ARDsGAAAAAwEAAAABAAAABQAAAAEB////" +
           "/wAAAAAVYIkKAgAAAAEABgAAAERldk1mZwEBPAYALgBEPAYAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABwAAAERldlR5cGUBAT0GAC4ARD0GAAAABf////8BAf////8AAAAAFWCJCgIAAAABAAYAAABEZXZS" +
           "ZXYBAT4GAC4ARD4GAAAABf////8BAf////8AAAAAFWCJCgIAAAABAAYAAABEZXZUYWcBAT8GAC4ARD8G" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZQb2xsQWRkcgEBQAYALgBEQAYAAAAD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DevAddr Property.
        /// </summary>
        public PropertyState<byte[]> DevAddr
        {
            get
            {
                return m_devAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devAddr = value;
            }
        }

        /// <summary>
        /// A description for the DevMfg Property.
        /// </summary>
        public PropertyState<ushort> DevMfg
        {
            get
            {
                return m_devMfg;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devMfg, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devMfg = value;
            }
        }

        /// <summary>
        /// A description for the DevType Property.
        /// </summary>
        public PropertyState<ushort> DevType
        {
            get
            {
                return m_devType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devType = value;
            }
        }

        /// <summary>
        /// A description for the DevRev Property.
        /// </summary>
        public PropertyState<ushort> DevRev
        {
            get
            {
                return m_devRev;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devRev, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devRev = value;
            }
        }

        /// <summary>
        /// A description for the DevTag Property.
        /// </summary>
        public PropertyState<string> DevTag
        {
            get
            {
                return m_devTag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devTag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devTag = value;
            }
        }

        /// <summary>
        /// A description for the DevPollAddr Property.
        /// </summary>
        public PropertyState<byte> DevPollAddr
        {
            get
            {
                return m_devPollAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devPollAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devPollAddr = value;
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
            if (m_devAddr != null)
            {
                children.Add(m_devAddr);
            }

            if (m_devMfg != null)
            {
                children.Add(m_devMfg);
            }

            if (m_devType != null)
            {
                children.Add(m_devType);
            }

            if (m_devRev != null)
            {
                children.Add(m_devRev);
            }

            if (m_devTag != null)
            {
                children.Add(m_devTag);
            }

            if (m_devPollAddr != null)
            {
                children.Add(m_devPollAddr);
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
                case Opc.Ua.Fdi7.BrowseNames.DevAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevAddr = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                DevAddr = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = DevAddr;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevMfg:
                {
                    if (createOrReplace)
                    {
                        if (DevMfg == null)
                        {
                            if (replacement == null)
                            {
                                DevMfg = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevMfg = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevMfg;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevType:
                {
                    if (createOrReplace)
                    {
                        if (DevType == null)
                        {
                            if (replacement == null)
                            {
                                DevType = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevType = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevType;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevRev:
                {
                    if (createOrReplace)
                    {
                        if (DevRev == null)
                        {
                            if (replacement == null)
                            {
                                DevRev = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevRev = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevRev;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevTag:
                {
                    if (createOrReplace)
                    {
                        if (DevTag == null)
                        {
                            if (replacement == null)
                            {
                                DevTag = new PropertyState<string>(this);
                            }
                            else
                            {
                                DevTag = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DevTag;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevPollAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevPollAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevPollAddr = new PropertyState<byte>(this);
                            }
                            else
                            {
                                DevPollAddr = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = DevPollAddr;
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
        private PropertyState<byte[]> m_devAddr;
        private PropertyState<ushort> m_devMfg;
        private PropertyState<ushort> m_devType;
        private PropertyState<ushort> m_devRev;
        private PropertyState<string> m_devTag;
        private PropertyState<byte> m_devPollAddr;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_HART_TP6State Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_HART_TP6State)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_HART_TP6 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_HART_TP6State : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_HART_TP6State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_HART_TP6, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DevMfg != null)
            {
                DevMfg.Initialize(context, DevMfg_InitializationString);
            }

            if (DevType != null)
            {
                DevType.Initialize(context, DevType_InitializationString);
            }

            if (DevRev != null)
            {
                DevRev.Initialize(context, DevRev_InitializationString);
            }

            if (DevTag != null)
            {
                DevTag.Initialize(context, DevTag_InitializationString);
            }

            if (DevPollAddr != null)
            {
                DevPollAddr.Initialize(context, DevPollAddr_InitializationString);
            }
        }

        #region Initialization String
        private const string DevMfg_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2TWZnAQFrBgAuAERrBgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevType_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAHAAAARGV2VHlwZQEBbAYALgBEbAYAAAAF" +
           "/////wEB/////wAAAAA=";

        private const string DevRev_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2UmV2AQFtBgAuAERtBgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevTag_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2VGFnAQFuBgAuAERuBgAAAAz/" +
           "////AQH/////AAAAAA==";

        private const string DevPollAddr_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAW8GAC4ARG8G" +
           "AAAAA/////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAgAAAAQ29ubmVjdGlvblBvaW50X0hBUlRf" +
           "VFA2SW5zdGFuY2UBAUEGAQFBBv////8HAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRkcmVzcwEBWAYD" +
           "AAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEC7QNYBgAA" +
           "/////wAAAAAXYIkKAgAAAAEABwAAAERldkFkZHIBAWoGAC4ARGoGAAAAAwEAAAABAAAABQAAAAEB////" +
           "/wAAAAAVYIkKAgAAAAEABgAAAERldk1mZwEBawYALgBEawYAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABwAAAERldlR5cGUBAWwGAC4ARGwGAAAABf////8BAf////8AAAAAFWCJCgIAAAABAAYAAABEZXZS" +
           "ZXYBAW0GAC4ARG0GAAAABf////8BAf////8AAAAAFWCJCgIAAAABAAYAAABEZXZUYWcBAW4GAC4ARG4G" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZQb2xsQWRkcgEBbwYALgBEbwYAAAAD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DevAddr Property.
        /// </summary>
        public PropertyState<byte[]> DevAddr
        {
            get
            {
                return m_devAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devAddr = value;
            }
        }

        /// <summary>
        /// A description for the DevMfg Property.
        /// </summary>
        public PropertyState<ushort> DevMfg
        {
            get
            {
                return m_devMfg;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devMfg, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devMfg = value;
            }
        }

        /// <summary>
        /// A description for the DevType Property.
        /// </summary>
        public PropertyState<ushort> DevType
        {
            get
            {
                return m_devType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devType = value;
            }
        }

        /// <summary>
        /// A description for the DevRev Property.
        /// </summary>
        public PropertyState<ushort> DevRev
        {
            get
            {
                return m_devRev;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devRev, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devRev = value;
            }
        }

        /// <summary>
        /// A description for the DevTag Property.
        /// </summary>
        public PropertyState<string> DevTag
        {
            get
            {
                return m_devTag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devTag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devTag = value;
            }
        }

        /// <summary>
        /// A description for the DevPollAddr Property.
        /// </summary>
        public PropertyState<byte> DevPollAddr
        {
            get
            {
                return m_devPollAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devPollAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devPollAddr = value;
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
            if (m_devAddr != null)
            {
                children.Add(m_devAddr);
            }

            if (m_devMfg != null)
            {
                children.Add(m_devMfg);
            }

            if (m_devType != null)
            {
                children.Add(m_devType);
            }

            if (m_devRev != null)
            {
                children.Add(m_devRev);
            }

            if (m_devTag != null)
            {
                children.Add(m_devTag);
            }

            if (m_devPollAddr != null)
            {
                children.Add(m_devPollAddr);
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
                case Opc.Ua.Fdi7.BrowseNames.DevAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevAddr = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                DevAddr = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = DevAddr;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevMfg:
                {
                    if (createOrReplace)
                    {
                        if (DevMfg == null)
                        {
                            if (replacement == null)
                            {
                                DevMfg = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevMfg = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevMfg;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevType:
                {
                    if (createOrReplace)
                    {
                        if (DevType == null)
                        {
                            if (replacement == null)
                            {
                                DevType = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevType = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevType;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevRev:
                {
                    if (createOrReplace)
                    {
                        if (DevRev == null)
                        {
                            if (replacement == null)
                            {
                                DevRev = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevRev = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevRev;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevTag:
                {
                    if (createOrReplace)
                    {
                        if (DevTag == null)
                        {
                            if (replacement == null)
                            {
                                DevTag = new PropertyState<string>(this);
                            }
                            else
                            {
                                DevTag = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DevTag;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevPollAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevPollAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevPollAddr = new PropertyState<byte>(this);
                            }
                            else
                            {
                                DevPollAddr = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = DevPollAddr;
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
        private PropertyState<byte[]> m_devAddr;
        private PropertyState<ushort> m_devMfg;
        private PropertyState<ushort> m_devType;
        private PropertyState<ushort> m_devRev;
        private PropertyState<string> m_devTag;
        private PropertyState<byte> m_devPollAddr;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_HART_TP7State Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_HART_TP7State)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_HART_TP7 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_HART_TP7State : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_HART_TP7State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_HART_TP7, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DevMfg != null)
            {
                DevMfg.Initialize(context, DevMfg_InitializationString);
            }

            if (DevType != null)
            {
                DevType.Initialize(context, DevType_InitializationString);
            }

            if (DevRev != null)
            {
                DevRev.Initialize(context, DevRev_InitializationString);
            }

            if (DevTag != null)
            {
                DevTag.Initialize(context, DevTag_InitializationString);
            }

            if (DevPollAddr != null)
            {
                DevPollAddr.Initialize(context, DevPollAddr_InitializationString);
            }
        }

        #region Initialization String
        private const string DevMfg_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2TWZnAQGaBgAuAESaBgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevType_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAHAAAARGV2VHlwZQEBmwYALgBEmwYAAAAF" +
           "/////wEB/////wAAAAA=";

        private const string DevRev_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2UmV2AQGcBgAuAEScBgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevTag_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2VGFnAQGdBgAuAESdBgAAAAz/" +
           "////AQH/////AAAAAA==";

        private const string DevPollAddr_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAZ4GAC4ARJ4G" +
           "AAAAA/////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAgAAAAQ29ubmVjdGlvblBvaW50X0hBUlRf" +
           "VFA3SW5zdGFuY2UBAXAGAQFwBv////8HAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRkcmVzcwEBhwYD" +
           "AAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEC7QOHBgAA" +
           "/////wAAAAAXYIkKAgAAAAEABwAAAERldkFkZHIBAZkGAC4ARJkGAAAAAwEAAAABAAAABQAAAAEB////" +
           "/wAAAAAVYIkKAgAAAAEABgAAAERldk1mZwEBmgYALgBEmgYAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABwAAAERldlR5cGUBAZsGAC4ARJsGAAAABf////8BAf////8AAAAAFWCJCgIAAAABAAYAAABEZXZS" +
           "ZXYBAZwGAC4ARJwGAAAABf////8BAf////8AAAAAFWCJCgIAAAABAAYAAABEZXZUYWcBAZ0GAC4ARJ0G" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZQb2xsQWRkcgEBngYALgBEngYAAAAD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DevAddr Property.
        /// </summary>
        public PropertyState<byte[]> DevAddr
        {
            get
            {
                return m_devAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devAddr = value;
            }
        }

        /// <summary>
        /// A description for the DevMfg Property.
        /// </summary>
        public PropertyState<ushort> DevMfg
        {
            get
            {
                return m_devMfg;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devMfg, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devMfg = value;
            }
        }

        /// <summary>
        /// A description for the DevType Property.
        /// </summary>
        public PropertyState<ushort> DevType
        {
            get
            {
                return m_devType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devType = value;
            }
        }

        /// <summary>
        /// A description for the DevRev Property.
        /// </summary>
        public PropertyState<ushort> DevRev
        {
            get
            {
                return m_devRev;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devRev, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devRev = value;
            }
        }

        /// <summary>
        /// A description for the DevTag Property.
        /// </summary>
        public PropertyState<string> DevTag
        {
            get
            {
                return m_devTag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devTag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devTag = value;
            }
        }

        /// <summary>
        /// A description for the DevPollAddr Property.
        /// </summary>
        public PropertyState<byte> DevPollAddr
        {
            get
            {
                return m_devPollAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devPollAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devPollAddr = value;
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
            if (m_devAddr != null)
            {
                children.Add(m_devAddr);
            }

            if (m_devMfg != null)
            {
                children.Add(m_devMfg);
            }

            if (m_devType != null)
            {
                children.Add(m_devType);
            }

            if (m_devRev != null)
            {
                children.Add(m_devRev);
            }

            if (m_devTag != null)
            {
                children.Add(m_devTag);
            }

            if (m_devPollAddr != null)
            {
                children.Add(m_devPollAddr);
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
                case Opc.Ua.Fdi7.BrowseNames.DevAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevAddr = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                DevAddr = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = DevAddr;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevMfg:
                {
                    if (createOrReplace)
                    {
                        if (DevMfg == null)
                        {
                            if (replacement == null)
                            {
                                DevMfg = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevMfg = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevMfg;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevType:
                {
                    if (createOrReplace)
                    {
                        if (DevType == null)
                        {
                            if (replacement == null)
                            {
                                DevType = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevType = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevType;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevRev:
                {
                    if (createOrReplace)
                    {
                        if (DevRev == null)
                        {
                            if (replacement == null)
                            {
                                DevRev = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevRev = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevRev;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevTag:
                {
                    if (createOrReplace)
                    {
                        if (DevTag == null)
                        {
                            if (replacement == null)
                            {
                                DevTag = new PropertyState<string>(this);
                            }
                            else
                            {
                                DevTag = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DevTag;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevPollAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevPollAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevPollAddr = new PropertyState<byte>(this);
                            }
                            else
                            {
                                DevPollAddr = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = DevPollAddr;
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
        private PropertyState<byte[]> m_devAddr;
        private PropertyState<ushort> m_devMfg;
        private PropertyState<ushort> m_devType;
        private PropertyState<ushort> m_devRev;
        private PropertyState<string> m_devTag;
        private PropertyState<byte> m_devPollAddr;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPoint_ISA100_WirelessState Class
    #if (!OPCUA_EXCLUDE_ConnectionPoint_ISA100_WirelessState)
    /// <summary>
    /// Stores an instance of the ConnectionPoint_ISA100_Wireless ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPoint_ISA100_WirelessState : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPoint_ISA100_WirelessState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ConnectionPoint_ISA100_Wireless, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DevMfg != null)
            {
                DevMfg.Initialize(context, DevMfg_InitializationString);
            }

            if (DevType != null)
            {
                DevType.Initialize(context, DevType_InitializationString);
            }

            if (DevRev != null)
            {
                DevRev.Initialize(context, DevRev_InitializationString);
            }

            if (DevTag != null)
            {
                DevTag.Initialize(context, DevTag_InitializationString);
            }

            if (DevPollAddr != null)
            {
                DevPollAddr.Initialize(context, DevPollAddr_InitializationString);
            }
        }

        #region Initialization String
        private const string DevMfg_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2TWZnAQHJBgAuAETJBgAAAAf/" +
           "////AQH/////AAAAAA==";

        private const string DevType_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAHAAAARGV2VHlwZQEBygYALgBEygYAAAAF" +
           "/////wEB/////wAAAAA=";

        private const string DevRev_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2UmV2AQHLBgAuAETLBgAAAAX/" +
           "////AQH/////AAAAAA==";

        private const string DevTag_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAGAAAARGV2VGFnAQHMBgAuAETMBgAAAAz/" +
           "////AQH/////AAAAAA==";

        private const string DevPollAddr_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAc0GAC4ARM0G" +
           "AAAAA/////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAnAAAAQ29ubmVjdGlvblBvaW50X0lTQTEw" +
           "MF9XaXJlbGVzc0luc3RhbmNlAQGfBgEBnwb/////BwAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJl" +
           "c3MBAbYGAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8B" +
           "Au0DtgYAAP////8AAAAAFWCJCgIAAAABAAkAAABJUEFkZHJlc3MBAcgGAC4ARMgGAAAAD/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAYAAABEZXZNZmcBAckGAC4ARMkGAAAAB/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAcAAABEZXZUeXBlAQHKBgAuAETKBgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAARGV2" +
           "UmV2AQHLBgAuAETLBgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAARGV2VGFnAQHMBgAuAETM" +
           "BgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAc0GAC4ARM0GAAAAA///" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the IPAddress Property.
        /// </summary>
        public PropertyState<byte[]> IPAddress
        {
            get
            {
                return m_iPAddress;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iPAddress, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iPAddress = value;
            }
        }

        /// <summary>
        /// A description for the DevMfg Property.
        /// </summary>
        public PropertyState<uint> DevMfg
        {
            get
            {
                return m_devMfg;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devMfg, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devMfg = value;
            }
        }

        /// <summary>
        /// A description for the DevType Property.
        /// </summary>
        public PropertyState<ushort> DevType
        {
            get
            {
                return m_devType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devType = value;
            }
        }

        /// <summary>
        /// A description for the DevRev Property.
        /// </summary>
        public PropertyState<ushort> DevRev
        {
            get
            {
                return m_devRev;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devRev, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devRev = value;
            }
        }

        /// <summary>
        /// A description for the DevTag Property.
        /// </summary>
        public PropertyState<string> DevTag
        {
            get
            {
                return m_devTag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devTag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devTag = value;
            }
        }

        /// <summary>
        /// A description for the DevPollAddr Property.
        /// </summary>
        public PropertyState<byte> DevPollAddr
        {
            get
            {
                return m_devPollAddr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_devPollAddr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_devPollAddr = value;
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
            if (m_iPAddress != null)
            {
                children.Add(m_iPAddress);
            }

            if (m_devMfg != null)
            {
                children.Add(m_devMfg);
            }

            if (m_devType != null)
            {
                children.Add(m_devType);
            }

            if (m_devRev != null)
            {
                children.Add(m_devRev);
            }

            if (m_devTag != null)
            {
                children.Add(m_devTag);
            }

            if (m_devPollAddr != null)
            {
                children.Add(m_devPollAddr);
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
                case Opc.Ua.Fdi7.BrowseNames.IPAddress:
                {
                    if (createOrReplace)
                    {
                        if (IPAddress == null)
                        {
                            if (replacement == null)
                            {
                                IPAddress = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                IPAddress = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = IPAddress;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevMfg:
                {
                    if (createOrReplace)
                    {
                        if (DevMfg == null)
                        {
                            if (replacement == null)
                            {
                                DevMfg = new PropertyState<uint>(this);
                            }
                            else
                            {
                                DevMfg = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = DevMfg;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevType:
                {
                    if (createOrReplace)
                    {
                        if (DevType == null)
                        {
                            if (replacement == null)
                            {
                                DevType = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevType = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevType;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevRev:
                {
                    if (createOrReplace)
                    {
                        if (DevRev == null)
                        {
                            if (replacement == null)
                            {
                                DevRev = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                DevRev = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DevRev;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevTag:
                {
                    if (createOrReplace)
                    {
                        if (DevTag == null)
                        {
                            if (replacement == null)
                            {
                                DevTag = new PropertyState<string>(this);
                            }
                            else
                            {
                                DevTag = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DevTag;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.DevPollAddr:
                {
                    if (createOrReplace)
                    {
                        if (DevPollAddr == null)
                        {
                            if (replacement == null)
                            {
                                DevPollAddr = new PropertyState<byte>(this);
                            }
                            else
                            {
                                DevPollAddr = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = DevPollAddr;
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
        private PropertyState<byte[]> m_iPAddress;
        private PropertyState<uint> m_devMfg;
        private PropertyState<ushort> m_devType;
        private PropertyState<ushort> m_devRev;
        private PropertyState<string> m_devTag;
        private PropertyState<byte> m_devPollAddr;
        #endregion
    }
    #endif
    #endregion

    #region GenericConnectionPointState Class
    #if (!OPCUA_EXCLUDE_GenericConnectionPointState)
    /// <summary>
    /// Stores an instance of the GenericConnectionPoint ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericConnectionPointState : ConnectionPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericConnectionPointState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.GenericConnectionPoint, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAeAAAAR2VuZXJpY0Nvbm5lY3Rpb25Qb2lu" +
           "dEluc3RhbmNlAQHOBgEBzgb/////AwAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJlc3MBAeUGAwAA" +
           "AAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8BAu0D5QYAAP//" +
           "//8AAAAAFWCJCgIAAAABAAcAAABBZGRyZXNzAQH3BgAuAET3BgAAAA//////AQH/////AAAAABVgiQoC" +
           "AAAAAQASAAAAUHJvdG9jb2xJZGVudGlmaWVyAQH4BgAuAET4BgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Address Property.
        /// </summary>
        public PropertyState<byte[]> Address
        {
            get
            {
                return m_address;
            }

            set
            {
                if (!Object.ReferenceEquals(m_address, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_address = value;
            }
        }

        /// <summary>
        /// A description for the ProtocolIdentifier Property.
        /// </summary>
        public PropertyState<string> ProtocolIdentifier
        {
            get
            {
                return m_protocolIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_protocolIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_protocolIdentifier = value;
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
            if (m_address != null)
            {
                children.Add(m_address);
            }

            if (m_protocolIdentifier != null)
            {
                children.Add(m_protocolIdentifier);
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
                case Opc.Ua.Fdi7.BrowseNames.Address:
                {
                    if (createOrReplace)
                    {
                        if (Address == null)
                        {
                            if (replacement == null)
                            {
                                Address = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                Address = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = Address;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.ProtocolIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (ProtocolIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                ProtocolIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProtocolIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProtocolIdentifier;
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
        private PropertyState<byte[]> m_address;
        private PropertyState<string> m_protocolIdentifier;
        #endregion
    }
    #endif
    #endregion

    #region CommunicationServerTypeInitializeMethodState Class
    #if (!OPCUA_EXCLUDE_CommunicationServerTypeInitializeMethodState)
    /// <summary>
    /// Stores an instance of the CommunicationServerTypeInitializeMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationServerTypeInitializeMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommunicationServerTypeInitializeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new CommunicationServerTypeInitializeMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQArAAAAQ29tbXVuaWNhdGlvblNlcnZlclR5" +
           "cGVJbml0aWFsaXplTWV0aG9kVHlwZQEBAQAALwEBAQABAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQECAAAuAEQCAAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public CommunicationServerTypeInitializeMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult CommunicationServerTypeInitializeMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref object serviceError);
    #endif
    #endregion

    #region CommunicationServerTypeResetMethodState Class
    #if (!OPCUA_EXCLUDE_CommunicationServerTypeResetMethodState)
    /// <summary>
    /// Stores an instance of the CommunicationServerTypeResetMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationServerTypeResetMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommunicationServerTypeResetMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new CommunicationServerTypeResetMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAmAAAAQ29tbXVuaWNhdGlvblNlcnZlclR5" +
           "cGVSZXNldE1ldGhvZFR5cGUBAQMAAC8BAQMAAwAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBBAAALgBEBAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public CommunicationServerTypeResetMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult CommunicationServerTypeResetMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref object serviceError);
    #endif
    #endregion

    #region AddComponentMethodState Class
    #if (!OPCUA_EXCLUDE_AddComponentMethodState)
    /// <summary>
    /// Stores an instance of the AddComponentMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AddComponentMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AddComponentMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AddComponentMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAAQWRkQ29tcG9uZW50TWV0aG9kVHlw" +
           "ZQEBBQAALwEBBQAFAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQYAAC4A" +
           "RAYAAACWAwAAAAEAKgEBHQAAAA4AAABNb2R1bGVUeXBlTmFtZQAM/////wAAAAAAAQAqAQEbAAAADAAA" +
           "AEluc3RhbmNlTmFtZQAM/////wAAAAAAAQAqAQEcAAAADQAAAEluc3RhbmNlTGFiZWwADP////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEHAAAuAEQHAAAA" +
           "lgIAAAABACoBAR0AAAAOAAAASW5zdGFuY2VOb2RlSWQAEf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AddComponentMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string moduleTypeName = (string)inputArguments[0];
            string instanceName = (string)inputArguments[1];
            string instanceLabel = (string)inputArguments[2];

            NodeId instanceNodeId = (NodeId)outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    moduleTypeName,
                    instanceName,
                    instanceLabel,
                    ref instanceNodeId,
                    ref serviceError);
            }

            outputArguments[0] = instanceNodeId;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult AddComponentMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string moduleTypeName,
        string instanceName,
        string instanceLabel,
        ref NodeId instanceNodeId,
        ref object serviceError);
    #endif
    #endregion

    #region RemoveComponentMethodState Class
    #if (!OPCUA_EXCLUDE_RemoveComponentMethodState)
    /// <summary>
    /// Stores an instance of the RemoveComponentMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RemoveComponentMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RemoveComponentMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new RemoveComponentMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAAUmVtb3ZlQ29tcG9uZW50TWV0aG9k" +
           "VHlwZQEBCAAALwEBCAAIAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQkA" +
           "AC4ARAkAAACWAQAAAAEAKgEBGwAAAAwAAABNb2R1bGVOb2RlSWQAEf////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEKAAAuAEQKAAAAlgEAAAABACoBARsA" +
           "AAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public RemoveComponentMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            NodeId moduleNodeId = (NodeId)inputArguments[0];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    moduleNodeId,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult RemoveComponentMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId moduleNodeId,
        ref object serviceError);
    #endif
    #endregion

    #region CommunicationServerState Class
    #if (!OPCUA_EXCLUDE_CommunicationServerState)
    /// <summary>
    /// Stores an instance of the CommunicationServerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationServerState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommunicationServerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.CommunicationServerType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQEMAAMAAAAA" +
           "FwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOgwAAAD/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAfAAAAQ29tbXVuaWNhdGlvblNlcnZlclR5" +
           "cGVJbnN0YW5jZQEBCwABAQsA/////wsAAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEBDAADAAAA" +
           "ABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADoMAAAA/////wAAAAAkYIAKAQAAAAIACQAAAE1l" +
           "dGhvZFNldAEBDgADAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoOAAAA/////wQAAAAEYYIK" +
           "BAAAAAEACgAAAEluaXRpYWxpemUBAUsAAC8BAUsASwAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBTAAALgBETAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAUAAABSZXNldAEBTQAALwEBTQBNAAAAAQH/" +
           "////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFOAAAuAEROAAAAlgEAAAABACoBARsA" +
           "AAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADAAA" +
           "AEFkZENvbXBvbmVudAEBTwAALwEBTwBPAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAVAAAC4ARFAAAACWAwAAAAEAKgEBHQAAAA4AAABNb2R1bGVUeXBlTmFtZQAM/////wAAAAAA" +
           "AQAqAQEbAAAADAAAAEluc3RhbmNlTmFtZQAM/////wAAAAAAAQAqAQEcAAAADQAAAEluc3RhbmNlTGFi" +
           "ZWwADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQFRAAAuAERRAAAAlgIAAAABACoBAR0AAAAOAAAASW5zdGFuY2VOb2RlSWQAEf////8AAAAAAAEAKgEB" +
           "GwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAP" +
           "AAAAUmVtb3ZlQ29tcG9uZW50AQFSAAAvAQFSAFIAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBUwAALgBEUwAAAJYBAAAAAQAqAQEbAAAADAAAAE1vZHVsZU5vZGVJZAAR/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVQAAC4ARFQA" +
           "AACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEiAAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlx" +
           "dWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4A" +
           "RCIAAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBASMAAwAAAABp" +
           "AAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhl" +
           "IHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARCMAAAAABv//" +
           "//8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASQAAwAAAAAwAAAATmFtZSBvZiB0" +
           "aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARCQAAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAUAAABNb2RlbAEBJQADAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UA" +
           "LgBEJQAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBJgADAAAAAFoA" +
           "AABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVz" +
           "cykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEJgAAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADgAAAERldmljZVJldmlzaW9uAQEnAAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwg" +
           "b2YgdGhlIGRldmljZQAuAEQnAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVS" +
           "ZXZpc2lvbgEBKAADAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUg" +
           "b2YgdGhlIGRldmljZQAuAEQoAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVS" +
           "ZXZpc2lvbgEBKQADAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRl" +
           "dmljZQAuAEQpAAAAAAz/////AQH/////AAAAAARggAoBAAAAAQAKAAAAU3ViRGV2aWNlcwEBVQAALwA9" +
           "VQAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the SubDevices Object.
        /// </summary>
        public FolderState SubDevices
        {
            get
            {
                return m_subDevices;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subDevices, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subDevices = value;
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
            if (m_subDevices != null)
            {
                children.Add(m_subDevices);
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
                case Opc.Ua.Fdi7.BrowseNames.SubDevices:
                {
                    if (createOrReplace)
                    {
                        if (SubDevices == null)
                        {
                            if (replacement == null)
                            {
                                SubDevices = new FolderState(this);
                            }
                            else
                            {
                                SubDevices = (FolderState)replacement;
                            }
                        }
                    }

                    instance = SubDevices;
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
        private FolderState m_subDevices;
        #endregion
    }
    #endif
    #endregion

    #region ScanMethodState Class
    #if (!OPCUA_EXCLUDE_ScanMethodState)
    /// <summary>
    /// Stores an instance of the ScanMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ScanMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ScanMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ScanMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAOAAAAU2Nhbk1ldGhvZFR5cGUBAVYAAC8B" +
           "AVYAVgAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVwAALgBEVwAAAJYC" +
           "AAAAAQAqAQEhAAAAEgAAAFRvcG9sb2d5U2NhblJlc3VsdAAQ/////wAAAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ScanMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            XmlElement topologyScanResult = (XmlElement)outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref topologyScanResult,
                    ref serviceError);
            }

            outputArguments[0] = topologyScanResult;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ScanMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref XmlElement topologyScanResult,
        ref object serviceError);
    #endif
    #endregion

    #region ResetScanMethodState Class
    #if (!OPCUA_EXCLUDE_ResetScanMethodState)
    /// <summary>
    /// Stores an instance of the ResetScanMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResetScanMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResetScanMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ResetScanMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQATAAAAUmVzZXRTY2FuTWV0aG9kVHlwZQEB" +
           "WAAALwEBWABYAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFZAAAuAERZ" +
           "AAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ResetScanMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ResetScanMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref object serviceError);
    #endif
    #endregion

    #region SetAddressMethodFFH1MethodState Class
    #if (!OPCUA_EXCLUDE_SetAddressMethodFFH1MethodState)
    /// <summary>
    /// Stores an instance of the SetAddressMethodFFH1Type Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetAddressMethodFFH1MethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetAddressMethodFFH1MethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetAddressMethodFFH1MethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAYAAAAU2V0QWRkcmVzc01ldGhvZEZGSDFU" +
           "eXBlAQE1AQAvAQE1ATUBAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBNgEA" +
           "LgBENgEAAJYGAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEVAAAABgAAAExp" +
           "bmtJZAAF/////wAAAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAA/////8AAAAAAAEAKgEBGQAAAAoA" +
           "AABOZXdBZGRyZXNzAAP/////AAAAAAABACoBARcAAAAIAAAATmV3UERUYWcADP////8AAAAAAAEAKgEB" +
           "GAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQE3AQAuAEQ3AQAAlgIAAAABACoBAR8AAAAQAAAARGVsYXlGb3JOZXh0Q2Fs" +
           "bAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetAddressMethodFFH1MethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string oPERATION = (string)inputArguments[0];
            ushort linkId = (ushort)inputArguments[1];
            byte oldAddress = (byte)inputArguments[2];
            byte newAddress = (byte)inputArguments[3];
            string newPDTag = (string)inputArguments[4];
            uint serviceId = (uint)inputArguments[5];

            uint delayForNextCall = (uint)outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    oPERATION,
                    linkId,
                    oldAddress,
                    newAddress,
                    newPDTag,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = delayForNextCall;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetAddressMethodFFH1MethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string oPERATION,
        ushort linkId,
        byte oldAddress,
        byte newAddress,
        string newPDTag,
        uint serviceId,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region SetAddressMethodFFHSEMethodState Class
    #if (!OPCUA_EXCLUDE_SetAddressMethodFFHSEMethodState)
    /// <summary>
    /// Stores an instance of the SetAddressMethodFFHSEType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetAddressMethodFFHSEMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetAddressMethodFFHSEMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetAddressMethodFFHSEMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAAU2V0QWRkcmVzc01ldGhvZEZGSFNF" +
           "VHlwZQEBOAEALwEBOAE4AQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATkB" +
           "AC4ARDkBAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABO" +
           "ZXdQRFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAAB" +
           "Af////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAToBAC4ARDoBAACWAgAAAAEAKgEB" +
           "HwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9y" +
           "ABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetAddressMethodFFHSEMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string oPERATION = (string)inputArguments[0];
            string newPDTag = (string)inputArguments[1];
            uint serviceId = (uint)inputArguments[2];

            uint delayForNextCall = (uint)outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    oPERATION,
                    newPDTag,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = delayForNextCall;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetAddressMethodFFHSEMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string oPERATION,
        string newPDTag,
        uint serviceId,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region SetAddressMethodPROFIBUSMethodState Class
    #if (!OPCUA_EXCLUDE_SetAddressMethodPROFIBUSMethodState)
    /// <summary>
    /// Stores an instance of the SetAddressMethodPROFIBUSType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetAddressMethodPROFIBUSMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetAddressMethodPROFIBUSMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetAddressMethodPROFIBUSMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAcAAAAU2V0QWRkcmVzc01ldGhvZFBST0ZJ" +
           "QlVTVHlwZQEBOwEALwEBOwE7AQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "ATwBAC4ARDwBAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkAAAAK" +
           "AAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAT0BAC4ARD0BAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetAddressMethodPROFIBUSMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte oldAddress = (byte)inputArguments[0];
            byte newAddress = (byte)inputArguments[1];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    oldAddress,
                    newAddress,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetAddressMethodPROFIBUSMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte oldAddress,
        byte newAddress,
        ref object serviceError);
    #endif
    #endregion

    #region SetAddressMethodPROFINETMethodState Class
    #if (!OPCUA_EXCLUDE_SetAddressMethodPROFINETMethodState)
    /// <summary>
    /// Stores an instance of the SetAddressMethodPROFINETType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetAddressMethodPROFINETMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetAddressMethodPROFINETMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetAddressMethodPROFINETMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAcAAAAU2V0QWRkcmVzc01ldGhvZFBST0ZJ" +
           "TkVUVHlwZQEBPgEALwEBPgE+AQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AT8BAC4ARD8BAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoBARUAAAACAAAA" +
           "SVAAAwEAAAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAqAQEdAAAACgAA" +
           "AFN1Ym5ldE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAAAAEAAAAEAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFAAQAuAERAAQAA" +
           "lgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetAddressMethodPROFINETMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] mAC = (byte[])inputArguments[0];
            byte[] iP = (byte[])inputArguments[1];
            string dNSNAME = (string)inputArguments[2];
            byte[] subnetMask = (byte[])inputArguments[3];
            byte[] gateway = (byte[])inputArguments[4];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    mAC,
                    iP,
                    dNSNAME,
                    subnetMask,
                    gateway,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetAddressMethodPROFINETMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] mAC,
        byte[] iP,
        string dNSNAME,
        byte[] subnetMask,
        byte[] gateway,
        ref object serviceError);
    #endif
    #endregion

    #region SetAddressMethodHARTMethodState Class
    #if (!OPCUA_EXCLUDE_SetAddressMethodHARTMethodState)
    /// <summary>
    /// Stores an instance of the SetAddressMethodHARTType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetAddressMethodHARTMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetAddressMethodHARTMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetAddressMethodHARTMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAYAAAAU2V0QWRkcmVzc01ldGhvZEhBUlRU" +
           "eXBlAQFBAQAvAQFBAUEBAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBQgEA" +
           "LgBEQgEAAJYCAAAAAQAqAQEdAAAADgAAAE9sZFBvbGxBZGRyZXNzAAP/////AAAAAAABACoBAR0AAAAO" +
           "AAAATmV3UG9sbEFkZHJlc3MAA/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQFDAQAuAERDAQAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetAddressMethodHARTMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte oldPollAddress = (byte)inputArguments[0];
            byte newPollAddress = (byte)inputArguments[1];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    oldPollAddress,
                    newPollAddress,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetAddressMethodHARTMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte oldPollAddress,
        byte newPollAddress,
        ref object serviceError);
    #endif
    #endregion

    #region SetAddressMethodGENERICMethodState Class
    #if (!OPCUA_EXCLUDE_SetAddressMethodGENERICMethodState)
    /// <summary>
    /// Stores an instance of the SetAddressMethodGENERICType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetAddressMethodGENERICMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetAddressMethodGENERICMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetAddressMethodGENERICMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAbAAAAU2V0QWRkcmVzc01ldGhvZEdFTkVS" +
           "SUNUeXBlAQH5BgAvAQH5BvkGAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "+gYALgBE+gYAAJYCAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAD/////8AAAAAAAEAKgEBGQAAAAoA" +
           "AABOZXdBZGRyZXNzAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEB+wYALgBE+wYAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetAddressMethodGENERICMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] oldAddress = (byte[])inputArguments[0];
            byte[] newAddress = (byte[])inputArguments[1];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    oldAddress,
                    newAddress,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetAddressMethodGENERICMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] oldAddress,
        byte[] newAddress,
        ref object serviceError);
    #endif
    #endregion

    #region ServerCommunicationDeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationDeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQFgAAMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOmAAAAD/////BQAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGsCAAuAESsCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAEAAAA" +
           "U2NhbgEBnQAALwEBnQCdAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGe" +
           "AAAuAESeAAAAlgIAAAABACoBASEAAAASAAAAVG9wb2xvZ3lTY2FuUmVzdWx0ABD/////AAAAAAABACoB" +
           "ARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEA" +
           "CQAAAFJlc2V0U2NhbgEBnwAALwEBnwCfAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQGgAAAuAESgAAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADAAAAEFkZENvbXBvbmVudAEBpAAALwEBpACkAAAAAQH/" +
           "////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaUAAC4ARKUAAACWAwAAAAEAKgEBHQAA" +
           "AA4AAABNb2R1bGVUeXBlTmFtZQAM/////wAAAAAAAQAqAQEbAAAADAAAAEluc3RhbmNlTmFtZQAM////" +
           "/wAAAAAAAQAqAQEcAAAADQAAAEluc3RhbmNlTGFiZWwADP////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "ABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGmAAAuAESmAAAAlgIAAAABACoBAR0AAAAOAAAA" +
           "SW5zdGFuY2VOb2RlSWQAEf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAPAAAAUmVtb3ZlQ29tcG9uZW50AQGnAAAvAQGnAKcA" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBqAAALgBEqAAAAJYBAAAAAQAq" +
           "AQEbAAAADAAAAE1vZHVsZU5vZGVJZAAR/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAakAAC4ARKkAAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJy" +
           "b3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAU2VydmVyQ29tbXVuaWNhdGlvbkRl" +
           "dmljZVR5cGVJbnN0YW5jZQEBXQABAV0A/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBYAAD" +
           "AAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpgAAAA/////wUAAAAVYIkKAgAAAAEAGwAAAExp" +
           "c3RPZkNvbW11bmljYXRpb25Qcm9maWxlcwEBrAgALgBErAgAAAAMAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAEABAAAAFNjYW4BAZ0AAC8BAZ0AnQAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBngAALgBEngAAAJYCAAAAAQAqAQEhAAAAEgAAAFRvcG9sb2d5U2NhblJlc3VsdAAQ/////wAA" +
           "AAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAkAAABSZXNldFNjYW4BAZ8AAC8BAZ8AnwAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBoAAALgBEoAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAwAAABBZGRDb21wb25lbnQBAaQAAC8BAaQA" +
           "pAAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGlAAAuAESlAAAAlgMAAAAB" +
           "ACoBAR0AAAAOAAAATW9kdWxlVHlwZU5hbWUADP////8AAAAAAAEAKgEBGwAAAAwAAABJbnN0YW5jZU5h" +
           "bWUADP////8AAAAAAAEAKgEBHAAAAA0AAABJbnN0YW5jZUxhYmVsAAz/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBpgAALgBEpgAAAJYCAAAAAQAqAQEd" +
           "AAAADgAAAEluc3RhbmNlTm9kZUlkABH/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADwAAAFJlbW92ZUNvbXBvbmVudAEBpwAA" +
           "LwEBpwCnAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAagAAC4ARKgAAACW" +
           "AQAAAAEAKgEBGwAAAAwAAABNb2R1bGVOb2RlSWQAEf////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGpAAAuAESpAAAAlgEAAAABACoBARsAAAAMAAAAU2Vy" +
           "dmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51" +
           "bWJlcgEBdAADAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGlu" +
           "IGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAER0AAAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQF1AAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50" +
           "ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhl" +
           "IERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAER1AAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAATWFudWZhY3R1cmVyAQF2AAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFj" +
           "dHVyZWQgdGhlIGRldmljZQAuAER2AAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwB" +
           "AXcAAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARHcAAAAAFf////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAXgAAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4g" +
           "dGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0" +
           "aGUgZGV2aWNlAC4ARHgAAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lv" +
           "bgEBeQADAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEeQAAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAXoAAwAAAAA1AAAAUmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEegAAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAXsAAwAAAAAsAAAAUmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEewAAAAAM/////wEB////" +
           "/wAAAAA=";
        #endregion
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

    #region ServerCommunicationFFH1DeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationFFH1DeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationFFH1DeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationFFH1DeviceState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationFFH1DeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFH1DeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQFHAQMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcBAAD/////AgAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGtCAAuAEStCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAA" +
           "U2V0QWRkcmVzcwEBjgEALwEBjgGOAQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAY8BAC4ARI8BAACWBgAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFQAA" +
           "AAYAAABMaW5rSWQABf////8AAAAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoB" +
           "ARkAAAAKAAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAqAQEXAAAACAAAAE5ld1BEVGFnAAz/////AAAA" +
           "AAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBkAEALgBEkAEAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9y" +
           "TmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQApAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SDFEZXZpY2VUeXBlSW5zdGFuY2UBAUQBAQFEAf////8KAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQB" +
           "AUcBAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6RwEAAP////8CAAAAFWCJCgIAAAABABsA" +
           "AABMaXN0T2ZDb21tdW5pY2F0aW9uUHJvZmlsZXMBAa0IAC4ARK0IAAAADAEAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAoAAABTZXRBZGRyZXNzAQGOAQAvAQGOAY4BAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBjwEALgBEjwEAAJYGAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAA" +
           "AAAAAQAqAQEVAAAABgAAAExpbmtJZAAF/////wAAAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAA///" +
           "//8AAAAAAAEAKgEBGQAAAAoAAABOZXdBZGRyZXNzAAP/////AAAAAAABACoBARcAAAAIAAAATmV3UERU" +
           "YWcADP////8AAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGQAQAuAESQAQAAlgIAAAABACoBAR8AAAAQ" +
           "AAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAVsBAwAAAABN" +
           "AAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJl" +
           "ciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEWwEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJl" +
           "dmlzaW9uQ291bnRlcgEBXAEDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcg" +
           "dGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJl" +
           "ZW4gbW9kaWZpZWQALgBEXAEAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJl" +
           "cgEBXQEDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZp" +
           "Y2UALgBEXQEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQFeAQMAAAAAGAAAAE1v" +
           "ZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEReAQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAA" +
           "RGV2aWNlTWFudWFsAQFfAQMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3Rl" +
           "bSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAERf" +
           "AQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAWABAwAAAAAkAAAA" +
           "T3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARGABAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQFhAQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARGEBAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQFiAQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARGIBAAAADP////8BAf////8AAAAABGCACgEAAAAB" +
           "AA8AAABTZXJ2aWNlUHJvdmlkZXIBAZEBAC8BAeUDkQEAAP////8JAAAAJGCACgEAAAACAAkAAABNZXRo" +
           "b2RTZXQBAZQBAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6lAEAAP////8DAAAABGGCCgQA" +
           "AAABAAoAAABEaXNjb25uZWN0AQG4AQAvAQEsAbgBAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBuQEALgBEuQEAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlv" +
           "bklkAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50" +
           "cwEBugEALgBEugEAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQG7AQAvAQEoBLsBAAABAf////8CAAAAFWCp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvAEALgBEvAEAAJYGAAAAAQAqAQEmAAAAFwAAAENvbW11" +
           "bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARUAAAAGAAAATGlua0lkAAX/////AAAAAAAB" +
           "ACoBARYAAAAHAAAAQWRkcmVzcwAD/////wAAAAAAAQAqAQEcAAAADQAAAE9yZGluYWxOdW1iZXIABv//" +
           "//8AAAAAAAEAKgEBHAAAAA0AAABTSUZDb25uZWN0aW9uAAH/////AAAAAAABACoBARgAAAAJAAAAU2Vy" +
           "dmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBvQEALgBEvQEAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAA" +
           "AAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAIAAAAVHJhbnNmZXIBAb4BAC8BASsEvgEAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQG/AQAuAES/AQAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABC" +
           "bG9ja1RhZwAM/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAf/////AAAAAAABACoBARgAAAAJAAAA" +
           "U1VCX0lOREVYAAf/////AAAAAAABACoBARgAAAAJAAAAV3JpdGVEYXRhAAMBAAAAAAAAAAABACoBARgA" +
           "AAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBwAEALgBEwAEAAJYDAAAAAQAqAQEXAAAACAAAAFJlYWREYXRhAAMBAAAAAAAA" +
           "AAABACoBAR8AAAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZp" +
           "Y2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1i" +
           "ZXIBAaYBAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBh" +
           "IG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEpgEAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBpwEDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVy" +
           "IGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBE" +
           "ZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEpwEAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAA" +
           "AE1hbnVmYWN0dXJlcgEBqAEDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1" +
           "cmVkIHRoZSBkZXZpY2UALgBEqAEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQGp" +
           "AQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAESpAQAAABX/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQGqAQMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRo" +
           "ZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhl" +
           "IGRldmljZQAuAESqAQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24B" +
           "AasBAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARKsBAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQGsAQMAAAAANQAAAFJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARKwBAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQGtAQMAAAAALAAAAFJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARK0BAAAADP////8BAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationFFH1ServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationFFH1ServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationFFH1ServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private ServerCommunicationFFH1ServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ServerCommunicationFFHSEDeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationFFHSEDeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationFFHSEDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationFFHSEDeviceState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationFFHSEDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFHSEDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQHHAQMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOscBAAD/////AgAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGuCAAuAESuCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAA" +
           "U2V0QWRkcmVzcwEBDgIALwEBDgIOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAQ8CAC4ARA8CAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAA" +
           "AAgAAABOZXdQRFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARACAC4ARBACAACWAgAA" +
           "AAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SFNFRGV2aWNlVHlwZUluc3RhbmNlAQHEAQEBxAH/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0" +
           "AQHHAQMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOscBAAD/////AgAAABVgiQoCAAAAAQAb" +
           "AAAATGlzdE9mQ29tbXVuaWNhdGlvblByb2ZpbGVzAQGuCAAuAESuCAAAAAwBAAAAAQH/////AAAAAARh" +
           "ggoEAAAAAQAKAAAAU2V0QWRkcmVzcwEBDgIALwEBDgIOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAQ8CAC4ARA8CAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8A" +
           "AAAAAAEAKgEBFwAAAAgAAABOZXdQRFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARAC" +
           "AC4ARBACAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsA" +
           "AAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAA" +
           "AFNlcmlhbE51bWJlcgEB2wEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmll" +
           "cywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAETbAQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQHcAQMAAAAAaQAAAEFuIGluY3JlbWVu" +
           "dGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3" +
           "aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAETcAQAAAAb/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQHdAQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhh" +
           "dCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAETdAQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAF" +
           "AAAATW9kZWwBAd4BAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARN4BAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAd8BAwAAAABaAAAAQWRkcmVzcyAocGF0" +
           "aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFu" +
           "dWFsIGZvciB0aGUgZGV2aWNlAC4ARN8BAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZp" +
           "Y2VSZXZpc2lvbgEB4AEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UA" +
           "LgBE4AEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAeEBAwAA" +
           "AAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBE4QEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAeIBAwAA" +
           "AAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE4gEAAAAM" +
           "/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92aWRlcgEBEQIALwEBMQQRAgAA////" +
           "/wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBFAIDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9k" +
           "cwAvADoUAgAA/////wMAAAAEYYIKBAAAAAEACgAAAERpc2Nvbm5lY3QBATgCAC8BASwBOAIAAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE5AgAuAEQ5AgAAlgEAAAABACoBASYAAAAX" +
           "AAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE6AgAuAEQ6AgAAlgEAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBATsC" +
           "AC8BAXQEOwIAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE8AgAuAEQ8AgAA" +
           "lgQAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAA" +
           "AAcAAABBZGRyZXNzAA//////AAAAAAABACoBARwAAAANAAAAT3JkaW5hbE51bWJlcgAG/////wAAAAAA" +
           "AQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAT0CAC4ARD0CAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5l" +
           "eHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQE+AgAvAQF3BD4CAAABAf////8CAAAAFWCp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPwIALgBEPwIAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11" +
           "bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAA" +
           "AAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAH/////wAA" +
           "AAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFdyaXRlRGF0YQAD" +
           "AQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "FWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUACAC4AREACAACWAwAAAAEAKgEBFwAAAAgAAABS" +
           "ZWFkRGF0YQADAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEA" +
           "KgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAA" +
           "AgAMAAAAU2VyaWFsTnVtYmVyAQEmAgMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVu" +
           "dGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARCYCAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAScCAwAAAABpAAAAQW4gaW5j" +
           "cmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBk" +
           "YXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARCcCAAAABv////8BAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASgCAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFu" +
           "eSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARCgCAAAAFf////8BAf////8AAAAANWCJCgIA" +
           "AAACAAUAAABNb2RlbAEBKQIDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEKQIAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBKgIDAAAAAFoAAABBZGRyZXNz" +
           "IChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNl" +
           "ciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEKgIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAA" +
           "AERldmljZVJldmlzaW9uAQErAgMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRl" +
           "dmljZQAuAEQrAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEB" +
           "LAIDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRl" +
           "dmljZQAuAEQsAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB" +
           "LQIDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEQt" +
           "AgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationFFHSEServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationFFHSEServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationFFHSEServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private ServerCommunicationFFHSEServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ServerCommunicationPROFIBUSDeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationPROFIBUSDeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationPROFIBUSDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationPROFIBUSDeviceState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationPROFIBUSDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFIBUSDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQFHAgMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcCAAD/////AgAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGvCAAuAESvCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAA" +
           "U2V0QWRkcmVzcwEBjgIALwEBjgKOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAY8CAC4ARI8CAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkA" +
           "AAAKAAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAZACAC4ARJACAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJQlVTRGV2aWNlVHlwZUluc3RhbmNlAQFEAgEBRAL/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQFHAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcCAAD/////AgAAABVgiQoCAAAA" +
           "AQAbAAAATGlzdE9mQ29tbXVuaWNhdGlvblByb2ZpbGVzAQGvCAAuAESvCAAAAAwBAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQAKAAAAU2V0QWRkcmVzcwEBjgIALwEBjgKOAgAAAQH/////AgAAABVgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAY8CAC4ARI8CAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/" +
           "////AAAAAAABACoBARkAAAAKAAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "FWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZACAC4ARJACAACWAQAAAAEAKgEBGwAAAAwAAABT" +
           "ZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFs" +
           "TnVtYmVyAQFbAgMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRo" +
           "aW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARFsCAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAVwCAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291" +
           "bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0" +
           "aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARFwCAAAABv////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAwAAABNYW51ZmFjdHVyZXIBAV0CAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVm" +
           "YWN0dXJlZCB0aGUgZGV2aWNlAC4ARF0CAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2Rl" +
           "bAEBXgIDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEXgIAAAAV/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBXwIDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBp" +
           "biB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9y" +
           "IHRoZSBkZXZpY2UALgBEXwIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlz" +
           "aW9uAQFgAgMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERgAgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBYQIDAAAAADUAAABS" +
           "ZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERhAgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBYgIDAAAAACwAAABS" +
           "ZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERiAgAAAAz/////AQH/" +
           "////AAAAAARggAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQGRAgAvAQF9BJECAAD/////CQAAACRg" +
           "gAoBAAAAAgAJAAAATWV0aG9kU2V0AQGUAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOpQC" +
           "AAD/////AwAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEBuAIALwEBLAG4AgAAAQH/////AgAAABVg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbkCAC4ARLkCAACWAQAAAAEAKgEBJgAAABcAAABDb21t" +
           "dW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAboCAC4ARLoCAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IA" +
           "G/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBuwIALwEBwAS7" +
           "AgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbwCAC4ARLwCAACWAwAAAAEA" +
           "KgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAAAEFk" +
           "ZHJlc3MAA/////8AAAAAAAEAKgEBHQAAAA4AAABNYW51ZmFjdHVyZXJJZAAF/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAb0CAC4ARL0CAACWAQAAAAEA" +
           "KgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQAIAAAAVHJhbnNmZXIBAb4CAC8BAcMEvgIAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQG/AgAuAES/AgAAlgUAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQA" +
           "D/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9U" +
           "AAP/////AAAAAAABACoBARQAAAAFAAAASU5ERVgAA/////8AAAAAAAEAKgEBFgAAAAcAAABSRVFVRVNU" +
           "AA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "wAIALgBEwAIAAJYDAAAAAQAqAQEUAAAABQAAAFJFUExZAA//////AAAAAAABACoBAR0AAAAOAAAAUkVT" +
           "UE9OU0VfQ09ERVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQGmAgMAAAAATQAAAElkZW50" +
           "aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2" +
           "aWNlIGluc3RhbmNlAC4ARKYCAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNv" +
           "dW50ZXIBAacCAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1i" +
           "ZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlm" +
           "aWVkAC4ARKcCAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAagCAwAA" +
           "AAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARKgC" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBqQIDAAAAABgAAABNb2RlbCBuYW1l" +
           "IG9mIHRoZSBkZXZpY2UALgBEqQIAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1h" +
           "bnVhbAEBqgIDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBV" +
           "UkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEqgIAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQGrAgMAAAAAJAAAAE92ZXJhbGwg" +
           "cmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAESrAgAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBrAIDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29m" +
           "dHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAESsAgAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBrQIDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFy" +
           "ZHdhcmUgb2YgdGhlIGRldmljZQAuAEStAgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationPROFIBUSServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationPROFIBUSServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationPROFIBUSServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private ServerCommunicationPROFIBUSServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ServerCommunicationPROFINETDeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationPROFINETDeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationPROFINETDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationPROFINETDeviceState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationPROFINETDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFINETDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQHEAgMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOsQCAAD/////AgAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGwCAAuAESwCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAA" +
           "U2V0QWRkcmVzcwEBCwMALwEBCwMLAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAQwDAC4ARAwDAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoBARUAAAAC" +
           "AAAASVAAAwEAAAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAqAQEdAAAA" +
           "CgAAAFN1Ym5ldE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAAAAEAAAAE" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQENAwAuAEQN" +
           "AwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJTkVURGV2aWNlVHlwZUluc3RhbmNlAQHBAgEBwQL/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQHEAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOsQCAAD/////AgAAABVgiQoCAAAA" +
           "AQAbAAAATGlzdE9mQ29tbXVuaWNhdGlvblByb2ZpbGVzAQGwCAAuAESwCAAAAAwBAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQAKAAAAU2V0QWRkcmVzcwEBCwMALwEBCwMLAwAAAQH/////AgAAABVgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAQwDAC4ARAwDAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAA" +
           "BgAAAAABACoBARUAAAACAAAASVAAAwEAAAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM////" +
           "/wAAAAAAAQAqAQEdAAAACgAAAFN1Ym5ldE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0" +
           "ZXdheQADAQAAAAEAAAAEAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQENAwAuAEQNAwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB2AIDAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAETYAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQHZAgMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAETZAgAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQHaAgMA" +
           "AAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAETa" +
           "AgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAdsCAwAAAAAYAAAATW9kZWwgbmFt" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARNsCAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VN" +
           "YW51YWwBAdwCAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARNwCAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB3QIDAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE3QIAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAd4CAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE3gIAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAd8CAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE3wIAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFNl" +
           "cnZpY2VQcm92aWRlcgEBDgMALwEBxgQOAwAA/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEB" +
           "EQMDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoRAwAA/////wMAAAAEYYIKBAAAAAEACgAA" +
           "AERpc2Nvbm5lY3QBATUDAC8BASwBNQMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQE2AwAuAEQ2AwAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD///" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE3AwAu" +
           "AEQ3AwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBATgDAC8BAQkFOAMAAAEB/////wIAAAAVYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQE5AwAuAEQ5AwAAlgQAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlv" +
           "blJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABETlNOQU1FAAz/////AAAAAAABACoBARcA" +
           "AAAIAAAARGV2aWNlSUQABf////8AAAAAAAEAKgEBFwAAAAgAAABWZW5kb3JJRAAF/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAToDAC4ARDoDAACWAQAA" +
           "AAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAIAAAAVHJhbnNmZXIBATsDAC8BAQwFOwMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQE8AwAuAEQ8AwAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABT" +
           "TE9UAAX/////AAAAAAABACoBARYAAAAHAAAAU1VCU0xPVAAF/////wAAAAAAAQAqAQEUAAAABQAAAElO" +
           "REVYAAX/////AAAAAAABACoBARIAAAADAAAAQVBJAAf/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVT" +
           "VAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AT0DAC4ARD0DAACWAwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJF" +
           "U1BPTlNFX0NPREVTAA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBIwMDAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAEQjAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQEkAwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAEQkAwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQElAwMA" +
           "AAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQl" +
           "AwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBASYDAwAAAAAYAAAATW9kZWwgbmFt" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARCYDAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VN" +
           "YW51YWwBAScDAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARCcDAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBKAMDAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEKAMAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BASkDAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEKQMAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BASoDAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEKgMAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationPROFINETServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationPROFINETServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationPROFINETServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private ServerCommunicationPROFINETServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ServerCommunicationHARState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationHARState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationHARType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationHARState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationHARState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationHARType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQFBAwMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkEDAAD/////AgAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGxCAAuAESxCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAA" +
           "U2V0QWRkcmVzcwEBiAMALwEBiAOIAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAYkDAC4ARIkDAACWAgAAAAEAKgEBHQAAAA4AAABPbGRQb2xsQWRkcmVzcwAD/////wAAAAAAAQAq" +
           "AQEdAAAADgAAAE5ld1BvbGxBZGRyZXNzAAP/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBigMALgBEigMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VF" +
           "cnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAiAAAAU2VydmVyQ29tbXVuaWNhdGlvbkhB" +
           "UlR5cGVJbnN0YW5jZQEBPgMBAT4D/////woAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBQQMDAAAA" +
           "ABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpBAwAA/////wIAAAAVYIkKAgAAAAEAGwAAAExpc3RP" +
           "ZkNvbW11bmljYXRpb25Qcm9maWxlcwEBsQgALgBEsQgAAAAMAQAAAAEB/////wAAAAAEYYIKBAAAAAEA" +
           "CgAAAFNldEFkZHJlc3MBAYgDAC8BAYgDiAMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQGJAwAuAESJAwAAlgIAAAABACoBAR0AAAAOAAAAT2xkUG9sbEFkZHJlc3MAA/////8AAAAA" +
           "AAEAKgEBHQAAAA4AAABOZXdQb2xsQWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYoDAC4ARIoDAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVt" +
           "YmVyAQFVAwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4g" +
           "YSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARFUDAAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAVYDAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRl" +
           "ciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUg" +
           "RGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARFYDAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwA" +
           "AABNYW51ZmFjdHVyZXIBAVcDAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0" +
           "dXJlZCB0aGUgZGV2aWNlAC4ARFcDAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEB" +
           "WAMDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEWAMAAAAV/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBWQMDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0" +
           "aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRo" +
           "ZSBkZXZpY2UALgBEWQMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9u" +
           "AQFaAwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERaAwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBWwMDAAAAADUAAABSZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERbAwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBXAMDAAAAACwAAABSZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERcAwAAAAz/////AQH/////" +
           "AAAAAARggAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQGLAwAvAQEPBYsDAAD/////CQAAACRggAoB" +
           "AAAAAgAJAAAATWV0aG9kU2V0AQGOAwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOo4DAAD/" +
           "////AwAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEBsgMALwEBLAGyAwAAAQH/////AgAAABVgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbMDAC4ARLMDAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5p" +
           "Y2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAbQDAC4ARLQDAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBtQMALwEBUgW1AwAA" +
           "AQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbYDAC4ARLYDAACWAgAAAAEAKgEB" +
           "JgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEaAAAACwAAAExvbmdB" +
           "ZGRyZXNzAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBtwMALgBEtwMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAABGGCCgQAAAABAAgAAABUcmFuc2ZlcgEBuAMALwEBVQW4AwAAAQH/////AgAA" +
           "ABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbkDAC4ARLkDAACWAwAAAAEAKgEBJgAAABcAAABD" +
           "b21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAAAENvbW1hbmQABf////8A" +
           "AAAAAAEAKgEBFgAAAAcAAABSZXF1ZXN0AA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBugMALgBEugMAAJYCAAAAAQAqAQEUAAAABQAAAFJlcGx5AA//" +
           "////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBoAMDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5p" +
           "cXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAu" +
           "AESgAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQGhAwMAAAAA" +
           "aQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRo" +
           "ZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEShAwAAAAb/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGiAwMAAAAAMAAAAE5hbWUgb2Yg" +
           "dGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESiAwAAABX/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAaMDAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNl" +
           "AC4ARKMDAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAaQDAwAAAABa" +
           "AAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJl" +
           "c3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARKQDAAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBpQMDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVs" +
           "IG9mIHRoZSBkZXZpY2UALgBEpQMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJl" +
           "UmV2aXNpb24BAaYDAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJl" +
           "IG9mIHRoZSBkZXZpY2UALgBEpgMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJl" +
           "UmV2aXNpb24BAacDAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBk" +
           "ZXZpY2UALgBEpwMAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationHARTServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationHARTServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationHARTServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private ServerCommunicationHARTServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ServerCommunicationISA100_WirelessDeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationISA100_WirelessDeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationISA100_WirelessDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationISA100_WirelessDeviceState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationISA100_WirelessDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationISA100_WirelessDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQA0AAAAU2VydmVyQ29tbXVuaWNhdGlvbklT" +
           "QTEwMF9XaXJlbGVzc0RldmljZVR5cGVJbnN0YW5jZQEB/AYBAfwG/////wkAAAA1YIkKAgAAAAIADAAA" +
           "AFNlcmlhbE51bWJlcgEBEwcDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmll" +
           "cywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQTBwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQEUBwMAAAAAaQAAAEFuIGluY3JlbWVu" +
           "dGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3" +
           "aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQUBwAAAAb/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQEVBwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhh" +
           "dCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQVBwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAF" +
           "AAAATW9kZWwBARYHAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARBYHAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBARcHAwAAAABaAAAAQWRkcmVzcyAocGF0" +
           "aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFu" +
           "dWFsIGZvciB0aGUgZGV2aWNlAC4ARBcHAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZp" +
           "Y2VSZXZpc2lvbgEBGAcDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UA" +
           "LgBEGAcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BARkHAwAA" +
           "AAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBEGQcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BARoHAwAA" +
           "AAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEGgcAAAAM" +
           "/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92aWRlcgEBRgcALwEBCQhGBwAA////" +
           "/wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBSQcDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9k" +
           "cwAvADpJBwAA/////wMAAAAEYYIKBAAAAAEACgAAAERpc2Nvbm5lY3QBAW0HAC8BASwBbQcAAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFuBwAuAERuBwAAlgEAAAABACoBASYAAAAX" +
           "AAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFvBwAuAERvBwAAlgEAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAXAH" +
           "AC8BAUwIcAcAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFxBwAuAERxBwAA" +
           "lgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAA" +
           "AAkAAABJUEFkZHJlc3MAD/////8AAAAAAAEAKgEBGgAAAAsAAABDb25uZWN0VHlwZQAH/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXIHAC4ARHIHAACW" +
           "AQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARh" +
           "ggoEAAAAAQAIAAAAVHJhbnNmZXIBAXMHAC8BAU8IcwcAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQF0BwAuAER0BwAAlggAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFAAAAAUA" +
           "AABBcHBJRAAF/////wAAAAAAAQAqAQEXAAAACAAAAE9iamVjdElEAAX/////AAAAAAABACoBARsAAAAM" +
           "AAAAQXR0ck9yTWV0aElEAAX/////AAAAAAABACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////AAAAAAAB" +
           "ACoBARgAAAAJAAAAV3JpdGVEYXRhAAMBAAAAAAAAAAABACoBARgAAAAJAAAAUmVxdWVzdElkAAf/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBdQcALgBE" +
           "dQcAAJYCAAAAAQAqAQEXAAAACAAAAFJlYWREYXRhAAMBAAAAAAAAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJl" +
           "cgEBWwcDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEg" +
           "bWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERbBwAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFcBwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIg" +
           "aW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERl" +
           "dmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERcBwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAA" +
           "TWFudWZhY3R1cmVyAQFdBwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVy" +
           "ZWQgdGhlIGRldmljZQAuAERdBwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAV4H" +
           "AwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARF4HAAAAFf////8BAf////8AAAAANWCJ" +
           "CgIAAAACAAwAAABEZXZpY2VNYW51YWwBAV8HAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhl" +
           "IGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUg" +
           "ZGV2aWNlAC4ARF8HAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB" +
           "YAcDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEYAcAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAWEHAwAAAAA1AAAAUmV2aXNp" +
           "b24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEYQcAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAWIHAwAAAAAsAAAAUmV2aXNp" +
           "b24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEYgcAAAAM/////wEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationISA100_WirelessServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationISA100_WirelessServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationISA100_WirelessServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private ServerCommunicationISA100_WirelessServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ServerCommunicationGENERICDeviceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationGENERICDeviceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationGENERICDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationGENERICDeviceState : ServerCommunicationDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationGENERICDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationGENERICDeviceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQF8BwMAAAAAFAAA" +
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOnwHAAD/////AgAAABVgiQoCAAAAAQAbAAAATGlzdE9mQ29t" +
           "bXVuaWNhdGlvblByb2ZpbGVzAQGzCAAuAESzCAAAAAwBAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAA" +
           "U2V0QWRkcmVzcwEBxAcALwEBxAfEBwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAcUHAC4ARMUHAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAA//////AAAAAAABACoBARkA" +
           "AAAKAAAATmV3QWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAcYHAC4ARMYHAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAsAAAAU2VydmVyQ29tbXVuaWNhdGlvbkdF" +
           "TkVSSUNEZXZpY2VUeXBlSW5zdGFuY2UBAXkHAQF5B/////8LAAAAJGCACgEAAAACAAkAAABNZXRob2RT" +
           "ZXQBAXwHAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6fAcAAP////8CAAAAFWCJCgIAAAAB" +
           "ABsAAABMaXN0T2ZDb21tdW5pY2F0aW9uUHJvZmlsZXMBAbMIAC4ARLMIAAAADAEAAAABAf////8AAAAA" +
           "BGGCCgQAAAABAAoAAABTZXRBZGRyZXNzAQHEBwAvAQHEB8QHAAABAf////8CAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBxQcALgBExQcAAJYCAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAD///" +
           "//8AAAAAAAEAKgEBGQAAAAoAAABOZXdBZGRyZXNzAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAV" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBxgcALgBExgcAAJYBAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxO" +
           "dW1iZXIBAZAHAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhp" +
           "biBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEkAcAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBkQcDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3Vu" +
           "dGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRo" +
           "ZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEkQcAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAE1hbnVmYWN0dXJlcgEBkgcDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZh" +
           "Y3R1cmVkIHRoZSBkZXZpY2UALgBEkgcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVs" +
           "AQGTBwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAESTBwAAABX/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQGUBwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGlu" +
           "IHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3Ig" +
           "dGhlIGRldmljZQAuAESUBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNp" +
           "b24BAZUHAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARJUHAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQGWBwMAAAAANQAAAFJl" +
           "dmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARJYHAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQGXBwMAAAAALAAAAFJl" +
           "dmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARJcHAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABIAAABQcm90b2NvbElkZW50aWZpZXIBAcMHAC4ARMMHAAAADP////8BAf//" +
           "//8AAAAABGCACgEAAAABAA8AAABTZXJ2aWNlUHJvdmlkZXIBAccHAC8BAVUIxwcAAP////8JAAAAJGCA" +
           "CgEAAAACAAkAAABNZXRob2RTZXQBAcoHAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6ygcA" +
           "AP////8DAAAABGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQHuBwAvAQEsAe4HAAABAf////8CAAAAFWCp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB7wcALgBE7wcAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11" +
           "bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEB8AcALgBE8AcAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQHxBwAvAQGYCPEH" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB8gcALgBE8gcAAJYCAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAAQWRk" +
           "cmVzcwAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAfMHAC4ARPMHAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAfQHAC8BAZsI9AcAAAEB/////wIAAAAV" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH1BwAuAET1BwAAlgUAAAABACoBASYAAAAXAAAAQ29t" +
           "bXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFQAAAAYAAABIZWFkZXIADP////8AAAAA" +
           "AAEAKgEBGgAAAAsAAABSZXF1ZXN0RGF0YQAP/////wAAAAAAAQAqAQEhAAAAEAAAAFJlcXVlc3REYXRh" +
           "VHlwZXMBAQIIAQAAAAAAAAAAAQAqAQEiAAAAEQAAAFJlc3BvbnNlRGF0YVR5cGVzAQECCAEAAAAAAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQH2BwAuAET2BwAA" +
           "lgMAAAABACoBARsAAAAMAAAAUmVzcG9uc2VEYXRhAA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9O" +
           "U0VfQ09ERVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQHcBwMAAAAATQAAAElkZW50aWZp" +
           "ZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNl" +
           "IGluc3RhbmNlAC4ARNwHAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50" +
           "ZXIBAd0HAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIg" +
           "b2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVk" +
           "AC4ARN0HAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAd4HAwAAAAAw" +
           "AAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARN4HAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEB3wcDAAAAABgAAABNb2RlbCBuYW1lIG9m" +
           "IHRoZSBkZXZpY2UALgBE3wcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVh" +
           "bAEB4AcDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwg" +
           "fCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBE4AcAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQHhBwMAAAAAJAAAAE92ZXJhbGwgcmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAEThBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAAU29mdHdhcmVSZXZpc2lvbgEB4gcDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdh" +
           "cmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAETiBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAASGFyZHdhcmVSZXZpc2lvbgEB4wcDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAETjBwAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ProtocolIdentifier Property.
        /// </summary>
        public PropertyState<string> ProtocolIdentifier
        {
            get
            {
                return m_protocolIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_protocolIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_protocolIdentifier = value;
            }
        }

        /// <summary>
        /// A description for the ServiceProvider Object.
        /// </summary>
        public ServerCommunicationGENERICServiceState ServiceProvider
        {
            get
            {
                return m_serviceProvider;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serviceProvider, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serviceProvider = value;
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
            if (m_protocolIdentifier != null)
            {
                children.Add(m_protocolIdentifier);
            }

            if (m_serviceProvider != null)
            {
                children.Add(m_serviceProvider);
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
                case Opc.Ua.Fdi7.BrowseNames.ProtocolIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (ProtocolIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                ProtocolIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProtocolIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProtocolIdentifier;
                    break;
                }

                case Opc.Ua.Fdi7.BrowseNames.ServiceProvider:
                {
                    if (createOrReplace)
                    {
                        if (ServiceProvider == null)
                        {
                            if (replacement == null)
                            {
                                ServiceProvider = new ServerCommunicationGENERICServiceState(this);
                            }
                            else
                            {
                                ServiceProvider = (ServerCommunicationGENERICServiceState)replacement;
                            }
                        }
                    }

                    instance = ServiceProvider;
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
        private PropertyState<string> m_protocolIdentifier;
        private ServerCommunicationGENERICServiceState m_serviceProvider;
        #endregion
    }
    #endif
    #endregion

    #region ConnectMethodFFH1MethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodFFH1MethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodFFH1Type Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodFFH1MethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodFFH1MethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodFFH1MethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAVAAAAQ29ubmVjdE1ldGhvZEZGSDFUeXBl" +
           "AQG+AwAvAQG+A74DAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvwMALgBE" +
           "vwMAAJYGAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARUAAAAGAAAATGlua0lkAAX/////AAAAAAABACoBARYAAAAHAAAAQWRkcmVzcwAD/////wAAAAAAAQAq" +
           "AQEcAAAADQAAAE9yZGluYWxOdW1iZXIABv////8AAAAAAAEAKgEBHAAAAA0AAABTSUZDb25uZWN0aW9u" +
           "AAH/////AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBwAMALgBEwAMAAJYCAAAAAQAqAQEfAAAAEAAA" +
           "AERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodFFH1MethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            ushort linkId = (ushort)inputArguments[1];
            byte address = (byte)inputArguments[2];
            int ordinalNumber = (int)inputArguments[3];
            bool sIFConnection = (bool)inputArguments[4];
            uint serviceId = (uint)inputArguments[5];

            uint delayForNextCall = (uint)outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    linkId,
                    address,
                    ordinalNumber,
                    sIFConnection,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = delayForNextCall;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodFFH1MethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        ushort linkId,
        byte address,
        int ordinalNumber,
        bool sIFConnection,
        uint serviceId,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region ConnectMethodFFHSEMethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodFFHSEMethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodFFHSEType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodFFHSEMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodFFHSEMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodFFHSEMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAAQ29ubmVjdE1ldGhvZEZGSFNFVHlw" +
           "ZQEBwQMALwEBwQPBAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcIDAC4A" +
           "RMIDAACWBAAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAEFkZHJlc3MAD/////8AAAAAAAEAKgEBHAAAAA0AAABPcmRpbmFsTnVtYmVyAAb/////" +
           "AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBwwMALgBEwwMAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5" +
           "Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodFFHSEMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            byte[] address = (byte[])inputArguments[1];
            int ordinalNumber = (int)inputArguments[2];
            uint serviceId = (uint)inputArguments[3];

            uint delayForNextCall = (uint)outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    address,
                    ordinalNumber,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = delayForNextCall;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodFFHSEMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        byte[] address,
        int ordinalNumber,
        uint serviceId,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region ConnectMethodPROFIBUSMethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodPROFIBUSMethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodPROFIBUSType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodPROFIBUSMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodPROFIBUSMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodPROFIBUSMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAAQ29ubmVjdE1ldGhvZFBST0ZJQlVT" +
           "VHlwZQEBxAMALwEBxAPEAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcUD" +
           "AC4ARMUDAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAA" +
           "AQAqAQEWAAAABwAAAEFkZHJlc3MAA/////8AAAAAAAEAKgEBHQAAAA4AAABNYW51ZmFjdHVyZXJJZAAF" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAcYD" +
           "AC4ARMYDAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodPROFIBUSMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            byte address = (byte)inputArguments[1];
            ushort manufacturerId = (ushort)inputArguments[2];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    address,
                    manufacturerId,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodPROFIBUSMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        byte address,
        ushort manufacturerId,
        ref object serviceError);
    #endif
    #endregion

    #region ConnectMethodPROFINETMethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodPROFINETMethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodPROFINETType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodPROFINETMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodPROFINETMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodPROFINETMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAAQ29ubmVjdE1ldGhvZFBST0ZJTkVU" +
           "VHlwZQEBxwMALwEBxwPHAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcgD" +
           "AC4ARMgDAACWBAAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAA" +
           "AQAqAQEWAAAABwAAAEROU05BTUUADP////8AAAAAAAEAKgEBFwAAAAgAAABEZXZpY2VJRAAF/////wAA" +
           "AAAAAQAqAQEXAAAACAAAAFZlbmRvcklEAAX/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEByQMALgBEyQMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VF" +
           "cnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodPROFINETMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string dNSNAME = (string)inputArguments[1];
            ushort deviceID = (ushort)inputArguments[2];
            ushort vendorID = (ushort)inputArguments[3];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    dNSNAME,
                    deviceID,
                    vendorID,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodPROFINETMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string dNSNAME,
        ushort deviceID,
        ushort vendorID,
        ref object serviceError);
    #endif
    #endregion

    #region ConnectMethodHARTMethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodHARTMethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodHARTType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodHARTMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodHARTMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodHARTMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAVAAAAQ29ubmVjdE1ldGhvZEhBUlRUeXBl" +
           "AQHKAwAvAQHKA8oDAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBywMALgBE" +
           "ywMAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARoAAAALAAAATG9uZ0FkZHJlc3MAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQHMAwAuAETMAwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9y" +
           "ABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodHARTMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            byte[] longAddress = (byte[])inputArguments[1];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    longAddress,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodHARTMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        byte[] longAddress,
        ref object serviceError);
    #endif
    #endregion

    #region ConnectMethodISA100_WirelessMethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodISA100_WirelessMethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodISA100_WirelessType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodISA100_WirelessMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodISA100_WirelessMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodISA100_WirelessMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAgAAAAQ29ubmVjdE1ldGhvZElTQTEwMF9X" +
           "aXJlbGVzc1R5cGUBAfcHAC8BAfcH9wcAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQH4BwAuAET4BwAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD///" +
           "//8AAAAAAAEAKgEBGAAAAAkAAABJUEFkZHJlc3MAD/////8AAAAAAAEAKgEBGgAAAAsAAABDb25uZWN0" +
           "VHlwZQAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAfkHAC4ARPkHAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodISA100_WirelessMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            byte[] iPAddress = (byte[])inputArguments[1];
            uint connectType = (uint)inputArguments[2];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    iPAddress,
                    connectType,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodISA100_WirelessMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        byte[] iPAddress,
        uint connectType,
        ref object serviceError);
    #endif
    #endregion

    #region ConnectMethodGENERICMethodState Class
    #if (!OPCUA_EXCLUDE_ConnectMethodGENERICMethodState)
    /// <summary>
    /// Stores an instance of the ConnectMethodGENERICType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectMethodGENERICMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectMethodGENERICMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ConnectMethodGENERICMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAYAAAAQ29ubmVjdE1ldGhvZEdFTkVSSUNU" +
           "eXBlAQH6BwAvAQH6B/oHAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB+wcA" +
           "LgBE+wcAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAAB" +
           "ACoBARYAAAAHAAAAQWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAfwHAC4ARPwHAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IA" +
           "G/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ConnectMethodGENERICMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            byte[] address = (byte[])inputArguments[1];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    address,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ConnectMethodGENERICMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        byte[] address,
        ref object serviceError);
    #endif
    #endregion

    #region DisconnectMethodState Class
    #if (!OPCUA_EXCLUDE_DisconnectMethodState)
    /// <summary>
    /// Stores an instance of the DisconnectMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisconnectMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DisconnectMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new DisconnectMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAUAAAARGlzY29ubmVjdE1ldGhvZFR5cGUB" +
           "AeAAAC8BAeAA4AAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHhAAAuAETh" +
           "AAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHiAAAuAETiAAAAlgEAAAAB" +
           "ACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public DisconnectMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];

            object serviceError = (object)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    ref serviceError);
            }

            outputArguments[0] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult DisconnectMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodFFH1MethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodFFH1MethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodFFH1Type Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodFFH1MethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodFFH1MethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodFFH1MethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAAVHJhbnNmZXJNZXRob2RGRkgxVHlw" +
           "ZQEBzQMALwEBzQPNAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAc4DAC4A" +
           "RM4DAACWBwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEXAAAACAAAAEJsb2NrVGFnAAz/////AAAA" +
           "AAABACoBARQAAAAFAAAASU5ERVgAB/////8AAAAAAAEAKgEBGAAAAAkAAABTVUJfSU5ERVgAB/////8A" +
           "AAAAAAEAKgEBGAAAAAkAAABXcml0ZURhdGEAAwEAAAAAAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQA" +
           "B/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHP" +
           "AwAuAETPAwAAlgMAAAABACoBARcAAAAIAAAAUmVhZERhdGEAAwEAAAAAAAAAAAEAKgEBHwAAABAAAABE" +
           "ZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodFFH1MethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string oPERATION = (string)inputArguments[1];
            string blockTag = (string)inputArguments[2];
            uint iNDEX = (uint)inputArguments[3];
            uint sUB_INDEX = (uint)inputArguments[4];
            byte[] writeData = (byte[])inputArguments[5];
            uint serviceId = (uint)inputArguments[6];

            byte[] readData = (byte[])outputArguments[0];
            uint delayForNextCall = (uint)outputArguments[1];
            object serviceError = (object)outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    oPERATION,
                    blockTag,
                    iNDEX,
                    sUB_INDEX,
                    writeData,
                    serviceId,
                    ref readData,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = readData;
            outputArguments[1] = delayForNextCall;
            outputArguments[2] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodFFH1MethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string oPERATION,
        string blockTag,
        uint iNDEX,
        uint sUB_INDEX,
        byte[] writeData,
        uint serviceId,
        ref byte[] readData,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodFFHSEMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodFFHSEMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodFFHSEType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodFFHSEMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodFFHSEMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodFFHSEMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAXAAAAVHJhbnNmZXJNZXRob2RGRkhTRVR5" +
           "cGUBAdADAC8BAdAD0AMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHRAwAu" +
           "AETRAwAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEA" +
           "KgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAA" +
           "AAAAAQAqAQEUAAAABQAAAElOREVYAAf/////AAAAAAABACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////" +
           "AAAAAAABACoBARgAAAAJAAAAV3JpdGVEYXRhAAMBAAAAAAAAAAABACoBARgAAAAJAAAAU2VydmljZUlk" +
           "AAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "0gMALgBE0gMAAJYDAAAAAQAqAQEXAAAACAAAAFJlYWREYXRhAAMBAAAAAAAAAAABACoBAR8AAAAQAAAA" +
           "RGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodFFHSEMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string oPERATION = (string)inputArguments[1];
            string blockTag = (string)inputArguments[2];
            uint iNDEX = (uint)inputArguments[3];
            uint sUB_INDEX = (uint)inputArguments[4];
            byte[] writeData = (byte[])inputArguments[5];
            uint serviceId = (uint)inputArguments[6];

            byte[] readData = (byte[])outputArguments[0];
            uint delayForNextCall = (uint)outputArguments[1];
            object serviceError = (object)outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    oPERATION,
                    blockTag,
                    iNDEX,
                    sUB_INDEX,
                    writeData,
                    serviceId,
                    ref readData,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = readData;
            outputArguments[1] = delayForNextCall;
            outputArguments[2] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodFFHSEMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string oPERATION,
        string blockTag,
        uint iNDEX,
        uint sUB_INDEX,
        byte[] writeData,
        uint serviceId,
        ref byte[] readData,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodPROFIBUSMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodPROFIBUSMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodPROFIBUSType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodPROFIBUSMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodPROFIBUSMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodPROFIBUSMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAaAAAAVHJhbnNmZXJNZXRob2RQUk9GSUJV" +
           "U1R5cGUBAdMDAC8BAdMD0wMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHU" +
           "AwAuAETUAwAAlgUAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAA" +
           "AAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9UAAP/////AAAA" +
           "AAABACoBARQAAAAFAAAASU5ERVgAA/////8AAAAAAAEAKgEBFgAAAAcAAABSRVFVRVNUAA//////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB1QMALgBE1QMA" +
           "AJYDAAAAAQAqAQEUAAAABQAAAFJFUExZAA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9OU0VfQ09E" +
           "RVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodPROFIBUSMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string oPERATION = (string)inputArguments[1];
            byte sLOT = (byte)inputArguments[2];
            byte iNDEX = (byte)inputArguments[3];
            byte[] rEQUEST = (byte[])inputArguments[4];

            byte[] rEPLY = (byte[])outputArguments[0];
            byte[] rESPONSE_CODES = (byte[])outputArguments[1];
            object serviceError = (object)outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    oPERATION,
                    sLOT,
                    iNDEX,
                    rEQUEST,
                    ref rEPLY,
                    ref rESPONSE_CODES,
                    ref serviceError);
            }

            outputArguments[0] = rEPLY;
            outputArguments[1] = rESPONSE_CODES;
            outputArguments[2] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodPROFIBUSMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string oPERATION,
        byte sLOT,
        byte iNDEX,
        byte[] rEQUEST,
        ref byte[] rEPLY,
        ref byte[] rESPONSE_CODES,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodPROFINETMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodPROFINETMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodPROFINETType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodPROFINETMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodPROFINETMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodPROFINETMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAaAAAAVHJhbnNmZXJNZXRob2RQUk9GSU5F" +
           "VFR5cGUBAdYDAC8BAdYD1gMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHX" +
           "AwAuAETXAwAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAA" +
           "AAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9UAAX/////AAAA" +
           "AAABACoBARYAAAAHAAAAU1VCU0xPVAAF/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAX/////AAAA" +
           "AAABACoBARIAAAADAAAAQVBJAAf/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAdgDAC4ARNgDAACW" +
           "AwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NPREVT" +
           "AA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodPROFINETMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string oPERATION = (string)inputArguments[1];
            ushort sLOT = (ushort)inputArguments[2];
            ushort sUBSLOT = (ushort)inputArguments[3];
            ushort iNDEX = (ushort)inputArguments[4];
            uint aPI = (uint)inputArguments[5];
            byte[] rEQUEST = (byte[])inputArguments[6];

            byte[] rEPLY = (byte[])outputArguments[0];
            byte[] rESPONSE_CODES = (byte[])outputArguments[1];
            object serviceError = (object)outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    oPERATION,
                    sLOT,
                    sUBSLOT,
                    iNDEX,
                    aPI,
                    rEQUEST,
                    ref rEPLY,
                    ref rESPONSE_CODES,
                    ref serviceError);
            }

            outputArguments[0] = rEPLY;
            outputArguments[1] = rESPONSE_CODES;
            outputArguments[2] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodPROFINETMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string oPERATION,
        ushort sLOT,
        ushort sUBSLOT,
        ushort iNDEX,
        uint aPI,
        byte[] rEQUEST,
        ref byte[] rEPLY,
        ref byte[] rESPONSE_CODES,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodHARTMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodHARTMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodHARTType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodHARTMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodHARTMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodHARTMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAAVHJhbnNmZXJNZXRob2RIQVJUVHlw" +
           "ZQEB2QMALwEB2QPZAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAdoDAC4A" +
           "RNoDAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAENvbW1hbmQABf////8AAAAAAAEAKgEBFgAAAAcAAABSZXF1ZXN0AA//////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB2wMALgBE2wMAAJYC" +
           "AAAAAQAqAQEUAAAABQAAAFJlcGx5AA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodHARTMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            ushort command = (ushort)inputArguments[1];
            byte[] request = (byte[])inputArguments[2];

            byte[] reply = (byte[])outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    command,
                    request,
                    ref reply,
                    ref serviceError);
            }

            outputArguments[0] = reply;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodHARTMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        ushort command,
        byte[] request,
        ref byte[] reply,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodISA100_WirelessMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodISA100_WirelessMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodISA100_WirelessType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodISA100_WirelessMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodISA100_WirelessMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodISA100_WirelessMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAhAAAAVHJhbnNmZXJNZXRob2RJU0ExMDBf" +
           "V2lyZWxlc3NUeXBlAQH9BwAvAQH9B/0HAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEB/gcALgBE/gcAAJYIAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//" +
           "////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARQAAAAFAAAAQXBwSUQA" +
           "Bf////8AAAAAAAEAKgEBFwAAAAgAAABPYmplY3RJRAAF/////wAAAAAAAQAqAQEbAAAADAAAAEF0dHJP" +
           "ck1ldGhJRAAF/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEYAAAA" +
           "CQAAAFdyaXRlRGF0YQADAQAAAAAAAAAAAQAqAQEYAAAACQAAAFJlcXVlc3RJZAAH/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf8HAC4ARP8HAACWAgAA" +
           "AAEAKgEBFwAAAAgAAABSZWFkRGF0YQADAQAAAAAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodISA100_WirelessMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string oPERATION = (string)inputArguments[1];
            ushort appID = (ushort)inputArguments[2];
            ushort objectID = (ushort)inputArguments[3];
            ushort attrOrMethID = (ushort)inputArguments[4];
            uint sUB_INDEX = (uint)inputArguments[5];
            byte[] writeData = (byte[])inputArguments[6];
            uint requestId = (uint)inputArguments[7];

            byte[] readData = (byte[])outputArguments[0];
            object serviceError = (object)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    oPERATION,
                    appID,
                    objectID,
                    attrOrMethID,
                    sUB_INDEX,
                    writeData,
                    requestId,
                    ref readData,
                    ref serviceError);
            }

            outputArguments[0] = readData;
            outputArguments[1] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodISA100_WirelessMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string oPERATION,
        ushort appID,
        ushort objectID,
        ushort attrOrMethID,
        uint sUB_INDEX,
        byte[] writeData,
        uint requestId,
        ref byte[] readData,
        ref object serviceError);
    #endif
    #endregion

    #region TransferMethodGENERICMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodGENERICMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodGENERICType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodGENERICMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodGENERICMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodGENERICMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAAVHJhbnNmZXJNZXRob2RHRU5FUklD" +
           "VHlwZQEBAwgALwEBAwgDCAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQQI" +
           "AC4ARAQIAACWBQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAA" +
           "AQAqAQEVAAAABgAAAEhlYWRlcgAM/////wAAAAAAAQAqAQEaAAAACwAAAFJlcXVlc3REYXRhAA//////" +
           "AAAAAAABACoBASEAAAAQAAAAUmVxdWVzdERhdGFUeXBlcwEBAggBAAAAAAAAAAABACoBASIAAAARAAAA" +
           "UmVzcG9uc2VEYXRhVHlwZXMBAQIIAQAAAAAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAQUIAC4ARAUIAACWAwAAAAEAKgEBGwAAAAwAAABSZXNwb25zZURhdGEA" +
           "D/////8AAAAAAAEAKgEBHQAAAA4AAABSRVNQT05TRV9DT0RFUwAP/////wAAAAAAAQAqAQEbAAAADAAA" +
           "AFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodGENERICMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            string header = (string)inputArguments[1];
            byte[] requestData = (byte[])inputArguments[2];
            EddDataTypeInfo[] requestDataTypes = (EddDataTypeInfo[])ExtensionObject.ToArray(inputArguments[3], typeof(EddDataTypeInfo));
            EddDataTypeInfo[] responseDataTypes = (EddDataTypeInfo[])ExtensionObject.ToArray(inputArguments[4], typeof(EddDataTypeInfo));

            byte[] responseData = (byte[])outputArguments[0];
            byte[] rESPONSE_CODES = (byte[])outputArguments[1];
            object serviceError = (object)outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    header,
                    requestData,
                    requestDataTypes,
                    responseDataTypes,
                    ref responseData,
                    ref rESPONSE_CODES,
                    ref serviceError);
            }

            outputArguments[0] = responseData;
            outputArguments[1] = rESPONSE_CODES;
            outputArguments[2] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodGENERICMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        string header,
        byte[] requestData,
        EddDataTypeInfo[] requestDataTypes,
        EddDataTypeInfo[] responseDataTypes,
        ref byte[] responseData,
        ref byte[] rESPONSE_CODES,
        ref object serviceError);
    #endif
    #endregion

    #region GetPublishedDataMethodFFH1MethodState Class
    #if (!OPCUA_EXCLUDE_GetPublishedDataMethodFFH1MethodState)
    /// <summary>
    /// Stores an instance of the GetPublishedDataMethodFFH1Type Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetPublishedDataMethodFFH1MethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetPublishedDataMethodFFH1MethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetPublishedDataMethodFFH1MethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAeAAAAR2V0UHVibGlzaGVkRGF0YU1ldGhv" +
           "ZEZGSDFUeXBlAQHcAwAvAQHcA9wDAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEB3QMALgBE3QMAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB3gMALgBE3gMAAJYGAAAAAQAqAQEXAAAACAAAAEJsb2Nr" +
           "VGFnAAz/////AAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAAAAAAAAAEAKgEBHQAA" +
           "AA4AAABBbGFybUV2ZW50VHlwZQAR/////wAAAAAAAQAqAQEYAAAACQAAAFRpbWVTdGFtcAAN/////wAA" +
           "AAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetPublishedDataMethodFFH1MethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            uint serviceId = (uint)inputArguments[1];

            string blockTag = (string)outputArguments[0];
            byte[] alarmEventData = (byte[])outputArguments[1];
            NodeId alarmEventType = (NodeId)outputArguments[2];
            DateTime timeStamp = (DateTime)outputArguments[3];
            uint delayForNextCall = (uint)outputArguments[4];
            object serviceError = (object)outputArguments[5];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    serviceId,
                    ref blockTag,
                    ref alarmEventData,
                    ref alarmEventType,
                    ref timeStamp,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = blockTag;
            outputArguments[1] = alarmEventData;
            outputArguments[2] = alarmEventType;
            outputArguments[3] = timeStamp;
            outputArguments[4] = delayForNextCall;
            outputArguments[5] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GetPublishedDataMethodFFH1MethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        uint serviceId,
        ref string blockTag,
        ref byte[] alarmEventData,
        ref NodeId alarmEventType,
        ref DateTime timeStamp,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region GetPublishedDataMethodFFHSEMethodState Class
    #if (!OPCUA_EXCLUDE_GetPublishedDataMethodFFHSEMethodState)
    /// <summary>
    /// Stores an instance of the GetPublishedDataMethodFFHSEType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetPublishedDataMethodFFHSEMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetPublishedDataMethodFFHSEMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetPublishedDataMethodFFHSEMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAfAAAAR2V0UHVibGlzaGVkRGF0YU1ldGhv" +
           "ZEZGSFNFVHlwZQEB3wMALwEB3wPfAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAeADAC4AROADAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP////" +
           "/wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAeEDAC4AROEDAACWBgAAAAEAKgEBFwAAAAgAAABCbG9j" +
           "a1RhZwAM/////wAAAAAAAQAqAQEdAAAADgAAAEFsYXJtRXZlbnREYXRhAAMBAAAAAAAAAAABACoBAR0A" +
           "AAAOAAAAQWxhcm1FdmVudFR5cGUAEf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8A" +
           "AAAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2Vy" +
           "dmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetPublishedDataMethodFFHSEMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];
            uint serviceId = (uint)inputArguments[1];

            string blockTag = (string)outputArguments[0];
            byte[] alarmEventData = (byte[])outputArguments[1];
            NodeId alarmEventType = (NodeId)outputArguments[2];
            DateTime timeStamp = (DateTime)outputArguments[3];
            uint delayForNextCall = (uint)outputArguments[4];
            object serviceError = (object)outputArguments[5];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    serviceId,
                    ref blockTag,
                    ref alarmEventData,
                    ref alarmEventType,
                    ref timeStamp,
                    ref delayForNextCall,
                    ref serviceError);
            }

            outputArguments[0] = blockTag;
            outputArguments[1] = alarmEventData;
            outputArguments[2] = alarmEventType;
            outputArguments[3] = timeStamp;
            outputArguments[4] = delayForNextCall;
            outputArguments[5] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GetPublishedDataMethodFFHSEMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        uint serviceId,
        ref string blockTag,
        ref byte[] alarmEventData,
        ref NodeId alarmEventType,
        ref DateTime timeStamp,
        ref uint delayForNextCall,
        ref object serviceError);
    #endif
    #endregion

    #region GetPublishedDataMethodHARTMethodState Class
    #if (!OPCUA_EXCLUDE_GetPublishedDataMethodHARTMethodState)
    /// <summary>
    /// Stores an instance of the GetPublishedDataMethodHARTType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetPublishedDataMethodHARTMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetPublishedDataMethodHARTMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetPublishedDataMethodHARTMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAeAAAAR2V0UHVibGlzaGVkRGF0YU1ldGhv" +
           "ZEhBUlRUeXBlAQHiAwAvAQHiA+IDAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEB4wMALgBE4wMAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB5AMALgBE" +
           "5AMAAJYEAAAAAQAqAQEWAAAABwAAAENvbW1hbmQABf////8AAAAAAAEAKgEBFAAAAAUAAABSZXBseQAP" +
           "/////wAAAAAAAQAqAQEYAAAACQAAAFRpbWVTdGFtcAAN/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZp" +
           "Y2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetPublishedDataMethodHARTMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];

            ushort command = (ushort)outputArguments[0];
            byte[] reply = (byte[])outputArguments[1];
            DateTime timeStamp = (DateTime)outputArguments[2];
            object serviceError = (object)outputArguments[3];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    ref command,
                    ref reply,
                    ref timeStamp,
                    ref serviceError);
            }

            outputArguments[0] = command;
            outputArguments[1] = reply;
            outputArguments[2] = timeStamp;
            outputArguments[3] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GetPublishedDataMethodHARTMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        ref ushort command,
        ref byte[] reply,
        ref DateTime timeStamp,
        ref object serviceError);
    #endif
    #endregion

    #region GetPublishedDataMethodISA100_WirelessMethodState Class
    #if (!OPCUA_EXCLUDE_GetPublishedDataMethodISA100_WirelessMethodState)
    /// <summary>
    /// Stores an instance of the GetPublishedDataMethodISA100_WirelessType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetPublishedDataMethodISA100_WirelessMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetPublishedDataMethodISA100_WirelessMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetPublishedDataMethodISA100_WirelessMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQApAAAAR2V0UHVibGlzaGVkRGF0YU1ldGhv" +
           "ZElTQTEwMF9XaXJlbGVzc1R5cGUBAQYIAC8BAQYIBggAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQEHCAAuAEQHCAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQEICAAuAEQICAAAlgYAAAABACoBARQAAAAFAAAAQXBwSUQABf////8AAAAAAAEAKgEBFwAAAAgA" +
           "AABPYmplY3RJRAAF/////wAAAAAAAQAqAQEdAAAADgAAAEFsYXJtRXZlbnREYXRhAAMBAAAAAAAAAAAB" +
           "ACoBAR0AAAAOAAAAQWxhcm1FdmVudFR5cGUABf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAA" +
           "Df////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetPublishedDataMethodISA100_WirelessMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])inputArguments[0];

            ushort appID = (ushort)outputArguments[0];
            ushort objectID = (ushort)outputArguments[1];
            byte[] alarmEventData = (byte[])outputArguments[2];
            ushort alarmEventType = (ushort)outputArguments[3];
            DateTime timeStamp = (DateTime)outputArguments[4];
            object serviceError = (object)outputArguments[5];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    communicationRelationId,
                    ref appID,
                    ref objectID,
                    ref alarmEventData,
                    ref alarmEventType,
                    ref timeStamp,
                    ref serviceError);
            }

            outputArguments[0] = appID;
            outputArguments[1] = objectID;
            outputArguments[2] = alarmEventData;
            outputArguments[3] = alarmEventType;
            outputArguments[4] = timeStamp;
            outputArguments[5] = serviceError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GetPublishedDataMethodISA100_WirelessMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        ref ushort appID,
        ref ushort objectID,
        ref byte[] alarmEventData,
        ref ushort alarmEventType,
        ref DateTime timeStamp,
        ref object serviceError);
    #endif
    #endregion

    #region ServerCommunicationServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationServiceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAmAAAAU2VydmVyQ29tbXVuaWNhdGlvblNl" +
           "cnZpY2VUeXBlSW5zdGFuY2UBAekAAQHpAP////8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAewA" +
           "AwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA67AAAAP////8BAAAABGGCCgQAAAABAAoAAABE" +
           "aXNjb25uZWN0AQEsAQAvAQEsASwBAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBLQEALgBELQEAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBLgEALgBE" +
           "LgEAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAQABAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVu" +
           "aXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UA" +
           "LgBEAAEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBAQEDAAAA" +
           "AGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0" +
           "aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEAQEAAAAG" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBAgEDAAAAADAAAABOYW1lIG9m" +
           "IHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEAgEAAAAV/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQEDAQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmlj" +
           "ZQAuAEQDAQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEEAQMAAAAA" +
           "WgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRy" +
           "ZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQEAQAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAQUBAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgZGV2aWNlAC4ARAUBAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2Fy" +
           "ZVJldmlzaW9uAQEGAQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2Fy" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARAYBAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2Fy" +
           "ZVJldmlzaW9uAQEHAQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUg" +
           "ZGV2aWNlAC4ARAcBAAAADP////8BAf////8AAAAA";
        #endregion
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

    #region ServerCommunicationFFH1ServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationFFH1ServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationFFH1ServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationFFH1ServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationFFH1ServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFH1ServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SDFTZXJ2aWNlVHlwZUluc3RhbmNlAQHlAwEB5QP/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0" +
           "AQHoAwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOugDAAD/////BAAAAARhggoEAAAAAQAK" +
           "AAAARGlzY29ubmVjdAEBJQQALwEBLAElBAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBASYEAC4ARCYEAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAScE" +
           "AC4ARCcEAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBKAQALwEBKAQoBAAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBASkEAC4ARCkEAACWBgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0" +
           "aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEVAAAABgAAAExpbmtJZAAF/////wAAAAAAAQAqAQEW" +
           "AAAABwAAAEFkZHJlc3MAA/////8AAAAAAAEAKgEBHAAAAA0AAABPcmRpbmFsTnVtYmVyAAb/////AAAA" +
           "AAABACoBARwAAAANAAAAU0lGQ29ubmVjdGlvbgAB/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJ" +
           "ZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "ASoEAC4ARCoEAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoB" +
           "ARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEA" +
           "CAAAAFRyYW5zZmVyAQErBAAvAQErBCsEAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBLAQALgBELAQAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//" +
           "////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tU" +
           "YWcADP////8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9J" +
           "TkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFdyaXRlRGF0YQADAQAAAAAAAAAAAQAqAQEYAAAACQAA" +
           "AFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAS0EAC4ARC0EAACWAwAAAAEAKgEBFwAAAAgAAABSZWFkRGF0YQADAQAAAAAAAAAAAQAq" +
           "AQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJy" +
           "b3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAR2V0UHVibGlzaGVkRGF0" +
           "YQEBLgQALwEBLgQuBAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAS8EAC4A" +
           "RC8EAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBATAEAC4ARDAEAACWBgAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM////" +
           "/wAAAAAAAQAqAQEdAAAADgAAAEFsYXJtRXZlbnREYXRhAAMBAAAAAAAAAAABACoBAR0AAAAOAAAAQWxh" +
           "cm1FdmVudFR5cGUAEf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEB" +
           "HwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9y" +
           "ABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB/AMD" +
           "AAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZh" +
           "Y3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAET8AwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAP" +
           "AAAAUmV2aXNpb25Db3VudGVyAQH9AwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNh" +
           "dGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBo" +
           "YXMgYmVlbiBtb2RpZmllZAAuAET9AwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZh" +
           "Y3R1cmVyAQH+AwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhl" +
           "IGRldmljZQAuAET+AwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAf8DAwAAAAAY" +
           "AAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARP8DAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAwAAABEZXZpY2VNYW51YWwBAQAEAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUg" +
           "c3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNl" +
           "AC4ARAAEAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBAQQDAAAA" +
           "ACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEAQQAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAQIEAwAAAAA1AAAAUmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEAgQAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAQMEAwAAAAAsAAAAUmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEAwQAAAAM/////wEB/////wAAAAA=";
        #endregion
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

    #region ServerCommunicationFFHSEServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationFFHSEServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationFFHSEServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationFFHSEServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationFFHSEServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationFFHSEServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQArAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SFNFU2VydmljZVR5cGVJbnN0YW5jZQEBMQQBATEE/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNl" +
           "dAEBNAQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADo0BAAA/////wQAAAAEYYIKBAAAAAEA" +
           "CgAAAERpc2Nvbm5lY3QBAXEEAC8BASwBcQQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQFyBAAuAERyBAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQA" +
           "D/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFz" +
           "BAAuAERzBAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAXQEAC8BAXQEdAQAAAEB/////wIAAAAVYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQF1BAAuAER1BAAAlgQAAAABACoBASYAAAAXAAAAQ29tbXVuaWNh" +
           "dGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAA//////AAAAAAABACoB" +
           "ARwAAAANAAAAT3JkaW5hbE51bWJlcgAG/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXYEAC4A" +
           "RHYEAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAM" +
           "AAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRy" +
           "YW5zZmVyAQF3BAAvAQF3BHcEAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "eAQALgBEeAQAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAA" +
           "AAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP//" +
           "//8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH" +
           "/////wAAAAAAAQAqAQEYAAAACQAAAFdyaXRlRGF0YQADAQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZp" +
           "Y2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAXkEAC4ARHkEAACWAwAAAAEAKgEBFwAAAAgAAABSZWFkRGF0YQADAQAAAAAAAAAAAQAqAQEfAAAA" +
           "EAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAR2V0UHVibGlzaGVkRGF0YQEBegQA" +
           "LwEBegR6BAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXsEAC4ARHsEAACW" +
           "AgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAA" +
           "CQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAXwEAC4ARHwEAACWBgAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAAAAAA" +
           "AQAqAQEdAAAADgAAAEFsYXJtRXZlbnREYXRhAAMBAAAAAAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVu" +
           "dFR5cGUAEf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEBHwAAABAA" +
           "AABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBSAQDAAAAAE0A" +
           "AABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVy" +
           "LCBhIGRldmljZSBpbnN0YW5jZQAuAERIBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQFJBAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0" +
           "aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVl" +
           "biBtb2RpZmllZAAuAERJBAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVy" +
           "AQFKBAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmlj" +
           "ZQAuAERKBAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAUsEAwAAAAAYAAAATW9k" +
           "ZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4AREsEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABE" +
           "ZXZpY2VNYW51YWwBAUwEAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVt" +
           "IG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AREwE" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBTQQDAAAAACQAAABP" +
           "dmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBETQQAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAU4EAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBETgQAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAU8EAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBETwQAAAAM/////wEB/////wAAAAA=";
        #endregion
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

    #region ServerCommunicationPROFIBUSServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationPROFIBUSServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationPROFIBUSServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationPROFIBUSServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationPROFIBUSServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFIBUSServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAuAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJQlVTU2VydmljZVR5cGVJbnN0YW5jZQEBfQQBAX0E/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhv" +
           "ZFNldAEBgAQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADqABAAA/////wMAAAAEYYIKBAAA" +
           "AAEACgAAAERpc2Nvbm5lY3QBAb0EAC8BASwBvQQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQG+BAAuAES+BAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQG/BAAuAES/BAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAcAEAC8BAcAEwAQAAAEB/////wIAAAAVYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHBBAAuAETBBAAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVu" +
           "aWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAAP/////AAAAAAAB" +
           "ACoBAR0AAAAOAAAATWFudWZhY3R1cmVySWQABf////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHCBAAuAETCBAAAlgEAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQHD" +
           "BAAvAQHDBMMEAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBxAQALgBExAQA" +
           "AJYFAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgA" +
           "AAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARMAAAAEAAAAU0xPVAAD/////wAAAAAAAQAqAQEU" +
           "AAAABQAAAElOREVYAAP/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAcUEAC4ARMUEAACWAwAAAAEA" +
           "KgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NPREVTAA//////" +
           "AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1" +
           "YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBlAQDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVl" +
           "bHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAESU" +
           "BAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQGVBAMAAAAAaQAA" +
           "AEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBz" +
           "dGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAESVBAAAAAb/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGWBAMAAAAAMAAAAE5hbWUgb2YgdGhl" +
           "IGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESWBAAAABX/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAFAAAATW9kZWwBAZcEAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RJcEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAZgEAwAAAABaAAAA" +
           "QWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3Mp" +
           "IG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARJgEAAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAACAA4AAABEZXZpY2VSZXZpc2lvbgEBmQQDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBkZXZpY2UALgBEmQQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2" +
           "aXNpb24BAZoEAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9m" +
           "IHRoZSBkZXZpY2UALgBEmgQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2" +
           "aXNpb24BAZsEAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZp" +
           "Y2UALgBEmwQAAAAM/////wEB/////wAAAAA=";
        #endregion
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

    #region ServerCommunicationPROFINETServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationPROFINETServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationPROFINETServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationPROFINETServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationPROFINETServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationPROFINETServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAuAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJTkVUU2VydmljZVR5cGVJbnN0YW5jZQEBxgQBAcYE/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhv" +
           "ZFNldAEByQQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADrJBAAA/////wMAAAAEYYIKBAAA" +
           "AAEACgAAAERpc2Nvbm5lY3QBAQYFAC8BASwBBgUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQEHBQAuAEQHBQAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQEIBQAuAEQIBQAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAQkFAC8BAQkFCQUAAAEB/////wIAAAAVYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEKBQAuAEQKBQAAlgQAAAABACoBASYAAAAXAAAAQ29tbXVu" +
           "aWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABETlNOQU1FAAz/////AAAAAAAB" +
           "ACoBARcAAAAIAAAARGV2aWNlSUQABf////8AAAAAAAEAKgEBFwAAAAgAAABWZW5kb3JJRAAF/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQsFAC4ARAsF" +
           "AACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAQwFAC8BAQwFDAUAAAEB/////wIAAAAVYKkKAgAAAAAADgAA" +
           "AElucHV0QXJndW1lbnRzAQENBQAuAEQNBQAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJl" +
           "bGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAA" +
           "AAQAAABTTE9UAAX/////AAAAAAABACoBARYAAAAHAAAAU1VCU0xPVAAF/////wAAAAAAAQAqAQEUAAAA" +
           "BQAAAElOREVYAAX/////AAAAAAABACoBARIAAAADAAAAQVBJAAf/////AAAAAAABACoBARYAAAAHAAAA" +
           "UkVRVUVTVAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAQ4FAC4ARA4FAACWAwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAA" +
           "DgAAAFJFU1BPTlNFX0NPREVTAA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB3QQDAAAAAE0A" +
           "AABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVy" +
           "LCBhIGRldmljZSBpbnN0YW5jZQAuAETdBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQHeBAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0" +
           "aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVl" +
           "biBtb2RpZmllZAAuAETeBAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVy" +
           "AQHfBAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmlj" +
           "ZQAuAETfBAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAeAEAwAAAAAYAAAATW9k" +
           "ZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4AROAEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABE" +
           "ZXZpY2VNYW51YWwBAeEEAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVt" +
           "IG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AROEE" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB4gQDAAAAACQAAABP" +
           "dmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE4gQAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAeMEAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE4wQAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAeQEAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE5AQAAAAM/////wEB/////wAAAAA=";
        #endregion
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

    #region ServerCommunicationHARTServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationHARTServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationHARTServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationHARTServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationHARTServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationHARTServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkhB" +
           "UlRTZXJ2aWNlVHlwZUluc3RhbmNlAQEPBQEBDwX/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0" +
           "AQESBQMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOhIFAAD/////BAAAAARhggoEAAAAAQAK" +
           "AAAARGlzY29ubmVjdAEBTwUALwEBLAFPBQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAVAFAC4ARFAFAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVEF" +
           "AC4ARFEFAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBUgUALwEBUgVSBQAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAVMFAC4ARFMFAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0" +
           "aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEaAAAACwAAAExvbmdBZGRyZXNzAA//////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVAUALgBEVAUAAJYB" +
           "AAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAgAAABUcmFuc2ZlcgEBVQUALwEBVQVVBQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAVYFAC4ARFYFAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRp" +
           "b25JZAAP/////wAAAAAAAQAqAQEWAAAABwAAAENvbW1hbmQABf////8AAAAAAAEAKgEBFgAAAAcAAABS" +
           "ZXF1ZXN0AA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBVwUALgBEVwUAAJYCAAAAAQAqAQEUAAAABQAAAFJlcGx5AA//////AAAAAAABACoBARsAAAAM" +
           "AAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAEdl" +
           "dFB1Ymxpc2hlZERhdGEBAVgFAC8BAVgFWAUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQFZBQAuAERZBQAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQA" +
           "D/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFa" +
           "BQAuAERaBQAAlgQAAAABACoBARYAAAAHAAAAQ29tbWFuZAAF/////wAAAAAAAQAqAQEUAAAABQAAAFJl" +
           "cGx5AA//////AAAAAAABACoBARgAAAAJAAAAVGltZVN0YW1wAA3/////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlh" +
           "bE51bWJlcgEBJgUDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0" +
           "aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQmBQAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQEnBQMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNv" +
           "dW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4g" +
           "dGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQnBQAAAAb/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAMAAAATWFudWZhY3R1cmVyAQEoBQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51" +
           "ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQoBQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9k" +
           "ZWwBASkFAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARCkFAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBASoFAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUg" +
           "aW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZv" +
           "ciB0aGUgZGV2aWNlAC4ARCoFAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZp" +
           "c2lvbgEBKwUDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEKwUA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BASwFAwAAAAA1AAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBELAUA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAS0FAwAAAAAsAAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBELQUAAAAM/////wEB" +
           "/////wAAAAA=";
        #endregion
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

    #region ServerCommunicationISA100_WirelessServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationISA100_WirelessServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationISA100_WirelessServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationISA100_WirelessServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationISA100_WirelessServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationISA100_WirelessServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQA1AAAAU2VydmVyQ29tbXVuaWNhdGlvbklT" +
           "QTEwMF9XaXJlbGVzc1NlcnZpY2VUeXBlSW5zdGFuY2UBAQkIAQEJCP////8JAAAAJGCACgEAAAACAAkA" +
           "AABNZXRob2RTZXQBAQwIAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6DAgAAP////8EAAAA" +
           "BGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQFJCAAvAQEsAUkIAAABAf////8CAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBSggALgBESggAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25S" +
           "ZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBSwgALgBESwgAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQFMCAAvAQFMCEwIAAABAf////8C" +
           "AAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBTQgALgBETQgAAJYDAAAAAQAqAQEmAAAAFwAA" +
           "AENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAASVBBZGRyZXNzAA//" +
           "////AAAAAAABACoBARoAAAALAAAAQ29ubmVjdFR5cGUAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "ABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFOCAAuAEROCAAAlgEAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5z" +
           "ZmVyAQFPCAAvAQFPCE8IAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBUAgA" +
           "LgBEUAgAAJYIAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAAB" +
           "ACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARQAAAAFAAAAQXBwSUQABf////8AAAAA" +
           "AAEAKgEBFwAAAAgAAABPYmplY3RJRAAF/////wAAAAAAAQAqAQEbAAAADAAAAEF0dHJPck1ldGhJRAAF" +
           "/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFdyaXRl" +
           "RGF0YQADAQAAAAAAAAAAAQAqAQEYAAAACQAAAFJlcXVlc3RJZAAH/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVEIAC4ARFEIAACWAgAAAAEAKgEBFwAA" +
           "AAgAAABSZWFkRGF0YQADAQAAAAAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAABGGCCgQAAAABABAAAABHZXRQdWJsaXNoZWREYXRhAQFSCAAvAQFSCFII" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBUwgALgBEUwgAAJYBAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVAgALgBEVAgAAJYGAAAAAQAqAQEUAAAABQAA" +
           "AEFwcElEAAX/////AAAAAAABACoBARcAAAAIAAAAT2JqZWN0SUQABf////8AAAAAAAEAKgEBHQAAAA4A" +
           "AABBbGFybUV2ZW50RGF0YQADAQAAAAAAAAAAAQAqAQEdAAAADgAAAEFsYXJtRXZlbnRUeXBlAAX/////" +
           "AAAAAAABACoBARgAAAAJAAAAVGltZVN0YW1wAA3/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVy" +
           "cm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB" +
           "IAgDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFu" +
           "dWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQgCAAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAPAAAAUmV2aXNpb25Db3VudGVyAQEhCAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5k" +
           "aWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmlj" +
           "ZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQhCAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFu" +
           "dWZhY3R1cmVyAQEiCAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQg" +
           "dGhlIGRldmljZQAuAEQiCAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBASMIAwAA" +
           "AAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARCMIAAAAFf////8BAf////8AAAAANWCJCgIA" +
           "AAACAAwAAABEZXZpY2VNYW51YWwBASQIAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZp" +
           "bGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2" +
           "aWNlAC4ARCQIAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBJQgD" +
           "AAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEJQgAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BASYIAwAAAAA1AAAAUmV2aXNpb24g" +
           "bGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEJggAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAScIAwAAAAAsAAAAUmV2aXNpb24g" +
           "bGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEJwgAAAAM/////wEB/////wAAAAA=";
        #endregion
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

    #region ServerCommunicationGENERICServiceState Class
    #if (!OPCUA_EXCLUDE_ServerCommunicationGENERICServiceState)
    /// <summary>
    /// Stores an instance of the ServerCommunicationGENERICServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServerCommunicationGENERICServiceState : ServerCommunicationServiceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ServerCommunicationGENERICServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi7.ObjectTypes.ServerCommunicationGENERICServiceType, Opc.Ua.Fdi7.Namespaces.OpcUaFdi7, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvbkdF" +
           "TkVSSUNTZXJ2aWNlVHlwZUluc3RhbmNlAQFVCAEBVQj/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQFYCAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOlgIAAD/////AwAAAARhggoEAAAA" +
           "AQAKAAAARGlzY29ubmVjdAEBlQgALwEBLAGVCAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAZYIAC4ARJYIAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25J" +
           "ZAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AZcIAC4ARJcIAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBmAgALwEBmAiYCAAAAQH/////AgAAABVgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZkIAC4ARJkIAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5p" +
           "Y2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAAAEFkZHJlc3MAD/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGaCAAuAESaCAAAlgEA" +
           "AAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEACAAAAFRyYW5zZmVyAQGbCAAvAQGbCJsIAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBnAgALgBEnAgAAJYFAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlv" +
           "bklkAA//////AAAAAAABACoBARUAAAAGAAAASGVhZGVyAAz/////AAAAAAABACoBARoAAAALAAAAUmVx" +
           "dWVzdERhdGEAD/////8AAAAAAAEAKgEBIQAAABAAAABSZXF1ZXN0RGF0YVR5cGVzAQECCAEAAAAAAAAA" +
           "AAEAKgEBIgAAABEAAABSZXNwb25zZURhdGFUeXBlcwEBAggBAAAAAAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBnQgALgBEnQgAAJYDAAAAAQAqAQEbAAAADAAA" +
           "AFJlc3BvbnNlRGF0YQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NPREVTAA//////AAAA" +
           "AAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkK" +
           "AgAAAAIADAAAAFNlcmlhbE51bWJlcgEBbAgDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkg" +
           "aWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERsCAAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFtCAMAAAAAaQAAAEFu" +
           "IGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0" +
           "aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERtCAAAAAb/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQFuCAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNv" +
           "bXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAERuCAAAABX/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAFAAAATW9kZWwBAW8IAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARG8I" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAXAIAwAAAABaAAAAQWRk" +
           "cmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9m" +
           "IHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARHAIAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "AA4AAABEZXZpY2VSZXZpc2lvbgEBcQgDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBkZXZpY2UALgBEcQgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNp" +
           "b24BAXIIAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBEcggAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNp" +
           "b24BAXMIAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBEcwgAAAAM/////wEB/////wAAAAA=";
        #endregion
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
}