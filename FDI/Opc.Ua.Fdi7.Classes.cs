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
        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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

        /// <remarks />
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
        /// <remarks />
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

        /// <remarks />
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
           "cGVJbml0aWFsaXplTWV0aG9kVHlwZQEBAQAALwEBAQABAAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQECAAAuAEQCAAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "cGVSZXNldE1ldGhvZFR5cGUBAQMAAC8BAQMAAwAAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBBAAALgBEBAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "ZQEBBQAALwEBBQAFAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQYAAC4A" +
           "RAYAAACWAwAAAAEAKgEBHQAAAA4AAABNb2R1bGVUeXBlTmFtZQAM/////wAAAAAAAQAqAQEbAAAADAAA" +
           "AEluc3RhbmNlTmFtZQAM/////wAAAAAAAQAqAQEcAAAADQAAAEluc3RhbmNlTGFiZWwADP////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQcA" +
           "AC4ARAcAAACWAgAAAAEAKgEBHQAAAA4AAABJbnN0YW5jZU5vZGVJZAAR/////wAAAAAAAQAqAQEbAAAA" +
           "DAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string moduleTypeName = (string)_inputArguments[0];
            string instanceName = (string)_inputArguments[1];
            string instanceLabel = (string)_inputArguments[2];

            NodeId instanceNodeId = (NodeId)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    moduleTypeName,
                    instanceName,
                    instanceLabel,
                    ref instanceNodeId,
                    ref serviceError);
            }

            _outputArguments[0] = instanceNodeId;
            _outputArguments[1] = serviceError;

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
           "VHlwZQEBCAAALwEBCAAIAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQkA" +
           "AC4ARAkAAACWAQAAAAEAKgEBGwAAAAwAAABNb2R1bGVOb2RlSWQAEf////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQoAAC4ARAoAAACWAQAA" +
           "AAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            NodeId moduleNodeId = (NodeId)_inputArguments[0];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    moduleNodeId,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "BAAAAAEACgAAAEluaXRpYWxpemUBAUsAAC8BAUsASwAAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBTAAALgBETAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEABQAAAFJlc2V0AQFNAAAvAQFN" +
           "AE0AAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAU4AAC4ARE4AAACWAQAA" +
           "AAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAABGGCCgQAAAABAAwAAABBZGRDb21wb25lbnQBAU8AAC8BAU8ATwAAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQFQAAAuAERQAAAAlgMAAAABACoBAR0AAAAOAAAATW9kdWxlVHlw" +
           "ZU5hbWUADP////8AAAAAAAEAKgEBGwAAAAwAAABJbnN0YW5jZU5hbWUADP////8AAAAAAAEAKgEBHAAA" +
           "AA0AAABJbnN0YW5jZUxhYmVsAAz/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFRAAAuAERRAAAAlgIAAAABACoBAR0AAAAOAAAASW5zdGFu" +
           "Y2VOb2RlSWQAEf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAA8AAABSZW1vdmVDb21wb25lbnQBAVIAAC8BAVIA" +
           "UgAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFTAAAuAERTAAAAlgEAAAAB" +
           "ACoBARsAAAAMAAAATW9kdWxlTm9kZUlkABH/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "ABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFUAAAuAERUAAAAlgEAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQEiAAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARCIAAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBASMAAwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARCMAAAAABv////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASQAAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0" +
           "aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARCQAAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAUAAABNb2RlbAEBJQADAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEJQAAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBJgADAAAAAFoAAABBZGRyZXNzIChw" +
           "YXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBt" +
           "YW51YWwgZm9yIHRoZSBkZXZpY2UALgBEJgAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERl" +
           "dmljZVJldmlzaW9uAQEnAAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmlj" +
           "ZQAuAEQnAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBKAAD" +
           "AAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAEQoAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBKQAD" +
           "AAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEQpAAAA" +
           "AAz/////AQH/////AAAAAARggAoBAAAAAQAKAAAAU3ViRGV2aWNlcwEBVQAALwA9VQAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AVYAVgAAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVwAALgBEVwAAAJYC" +
           "AAAAAQAqAQEhAAAAEgAAAFRvcG9sb2d5U2NhblJlc3VsdAAQ/////wAAAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            XmlElement topologyScanResult = (XmlElement)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref topologyScanResult,
                    ref serviceError);
            }

            _outputArguments[0] = topologyScanResult;
            _outputArguments[1] = serviceError;

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
           "WAAALwEBWABYAAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFZAAAuAERZ" +
           "AAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "eXBlAQE1AQAvAQE1ATUBAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBNgEA" +
           "LgBENgEAAJYGAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEVAAAABgAAAExp" +
           "bmtJZAAF/////wAAAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAA/////8AAAAAAAEAKgEBGQAAAAoA" +
           "AABOZXdBZGRyZXNzAAP/////AAAAAAABACoBARcAAAAIAAAATmV3UERUYWcADP////8AAAAAAAEAKgEB" +
           "GAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATcBAC4ARDcBAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZv" +
           "ck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string oPERATION = (string)_inputArguments[0];
            ushort linkId = (ushort)_inputArguments[1];
            byte oldAddress = (byte)_inputArguments[2];
            byte newAddress = (byte)_inputArguments[3];
            string newPDTag = (string)_inputArguments[4];
            uint serviceId = (uint)_inputArguments[5];

            uint delayForNextCall = (uint)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    oPERATION,
                    linkId,
                    oldAddress,
                    newAddress,
                    newPDTag,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            _outputArguments[0] = delayForNextCall;
            _outputArguments[1] = serviceError;

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
           "VHlwZQEBOAEALwEBOAE4AQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATkB" +
           "AC4ARDkBAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABO" +
           "ZXdQRFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOgEALgBEOgEAAJYC" +
           "AAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string oPERATION = (string)_inputArguments[0];
            string newPDTag = (string)_inputArguments[1];
            uint serviceId = (uint)_inputArguments[2];

            uint delayForNextCall = (uint)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    oPERATION,
                    newPDTag,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            _outputArguments[0] = delayForNextCall;
            _outputArguments[1] = serviceError;

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
           "QlVTVHlwZQEBOwEALwEBOwE7AQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "ATwBAC4ARDwBAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkAAAAK" +
           "AAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBPQEALgBEPQEAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJv" +
           "cgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte oldAddress = (byte)_inputArguments[0];
            byte newAddress = (byte)_inputArguments[1];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    oldAddress,
                    newAddress,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "TkVUVHlwZQEBPgEALwEBPgE+AQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AT8BAC4ARD8BAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoBARUAAAACAAAA" +
           "SVAAAwEAAAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAqAQEdAAAACgAA" +
           "AFN1Ym5ldE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAAAAEAAAAEAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUAB" +
           "AC4AREABAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] mAC = (byte[])_inputArguments[0];
            byte[] iP = (byte[])_inputArguments[1];
            string dNSNAME = (string)_inputArguments[2];
            byte[] subnetMask = (byte[])_inputArguments[3];
            byte[] gateway = (byte[])_inputArguments[4];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    mAC,
                    iP,
                    dNSNAME,
                    subnetMask,
                    gateway,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "eXBlAQFBAQAvAQFBAUEBAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBQgEA" +
           "LgBEQgEAAJYCAAAAAQAqAQEdAAAADgAAAE9sZFBvbGxBZGRyZXNzAAP/////AAAAAAABACoBAR0AAAAO" +
           "AAAATmV3UG9sbEFkZHJlc3MAA/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUMBAC4AREMBAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNl" +
           "RXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte oldPollAddress = (byte)_inputArguments[0];
            byte newPollAddress = (byte)_inputArguments[1];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    oldPollAddress,
                    newPollAddress,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "SUNUeXBlAQH5BgAvAQH5BvkGAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "+gYALgBE+gYAAJYCAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAD/////8AAAAAAAEAKgEBGQAAAAoA" +
           "AABOZXdBZGRyZXNzAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQH7BgAuAET7BgAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9y" +
           "ABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] oldAddress = (byte[])_inputArguments[0];
            byte[] newAddress = (byte[])_inputArguments[1];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    oldAddress,
                    newAddress,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOmAAAAD/////BAAAAARhggoEAAAAAQAEAAAAU2NhbgEBnQAA" +
           "LwEBnQCdAAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGeAAAuAESeAAAA" +
           "lgIAAAABACoBASEAAAASAAAAVG9wb2xvZ3lTY2FuUmVzdWx0ABD/////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAJ" +
           "AAAAUmVzZXRTY2FuAQGfAAAvAQGfAJ8AAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAaAAAC4ARKAAAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAwAAABBZGRDb21wb25lbnQBAaQAAC8BAaQA" +
           "pAAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGlAAAuAESlAAAAlgMAAAAB" +
           "ACoBAR0AAAAOAAAATW9kdWxlVHlwZU5hbWUADP////8AAAAAAAEAKgEBGwAAAAwAAABJbnN0YW5jZU5h" +
           "bWUADP////8AAAAAAAEAKgEBHAAAAA0AAABJbnN0YW5jZUxhYmVsAAz/////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGmAAAuAESmAAAAlgIA" +
           "AAABACoBAR0AAAAOAAAASW5zdGFuY2VOb2RlSWQAEf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNl" +
           "RXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAA8AAABSZW1v" +
           "dmVDb21wb25lbnQBAacAAC8BAacApwAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQGoAAAuAESoAAAAlgEAAAABACoBARsAAAAMAAAATW9kdWxlTm9kZUlkABH/////AAAAAAABACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGpAAAuAESp" +
           "AAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAU2VydmVyQ29tbXVuaWNhdGlvbkRl" +
           "dmljZVR5cGVJbnN0YW5jZQEBXQABAV0A/////woAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBYAAD" +
           "AAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpgAAAA/////wQAAAAEYYIKBAAAAAEABAAAAFNj" +
           "YW4BAZ0AAC8BAZ0AnQAAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBngAA" +
           "LgBEngAAAJYCAAAAAQAqAQEhAAAAEgAAAFRvcG9sb2d5U2NhblJlc3VsdAAQ/////wAAAAAAAQAqAQEb" +
           "AAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEACQAAAFJlc2V0U2NhbgEBnwAALwEBnwCfAAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQGgAAAuAESgAAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAMAAAAQWRkQ29tcG9uZW50AQGk" +
           "AAAvAQGkAKQAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpQAALgBEpQAA" +
           "AJYDAAAAAQAqAQEdAAAADgAAAE1vZHVsZVR5cGVOYW1lAAz/////AAAAAAABACoBARsAAAAMAAAASW5z" +
           "dGFuY2VOYW1lAAz/////AAAAAAABACoBARwAAAANAAAASW5zdGFuY2VMYWJlbAAM/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBpgAALgBE" +
           "pgAAAJYCAAAAAQAqAQEdAAAADgAAAEluc3RhbmNlTm9kZUlkABH/////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAP" +
           "AAAAUmVtb3ZlQ29tcG9uZW50AQGnAAAvAQGnAKcAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBqAAALgBEqAAAAJYBAAAAAQAqAQEbAAAADAAAAE1vZHVsZU5vZGVJZAAR/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "qQAALgBEqQAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBdAADAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAER0AAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQF1AAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAER1AAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQF2AAMA" +
           "AAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAER2" +
           "AAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAXcAAwAAAAAYAAAATW9kZWwgbmFt" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARHcAAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VN" +
           "YW51YWwBAXgAAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARHgAAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBeQADAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEeQAAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAXoAAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEegAAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAXsAAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEewAAAAAM/////wEB/////wAAAAAXYIkKAgAAAAEAGwAAAExp" +
           "c3RPZkNvbW11bmljYXRpb25Qcm9maWxlcwEBmToALgBEmToAAAAMAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string[]> ListOfCommunicationProfiles
        {
            get
            {
                return m_listOfCommunicationProfiles;
            }

            set
            {
                if (!Object.ReferenceEquals(m_listOfCommunicationProfiles, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_listOfCommunicationProfiles = value;
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
            if (m_listOfCommunicationProfiles != null)
            {
                children.Add(m_listOfCommunicationProfiles);
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
                case Opc.Ua.Fdi7.BrowseNames.ListOfCommunicationProfiles:
                {
                    if (createOrReplace)
                    {
                        if (ListOfCommunicationProfiles == null)
                        {
                            if (replacement == null)
                            {
                                ListOfCommunicationProfiles = new PropertyState<string[]>(this);
                            }
                            else
                            {
                                ListOfCommunicationProfiles = (PropertyState<string[]>)replacement;
                            }
                        }
                    }

                    instance = ListOfCommunicationProfiles;
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
        private PropertyState<string[]> m_listOfCommunicationProfiles;
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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcBAAD/////AQAAAARhggoEAAAAAQAKAAAAU2V0QWRkcmVz" +
           "cwEBjgEALwEBjgGOAQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8BAC4A" +
           "RI8BAACWBgAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFQAAAAYAAABMaW5r" +
           "SWQABf////8AAAAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkAAAAKAAAA" +
           "TmV3QWRkcmVzcwAD/////wAAAAAAAQAqAQEXAAAACAAAAE5ld1BEVGFnAAz/////AAAAAAABACoBARgA" +
           "AAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQGQAQAuAESQAQAAlgIAAAABACoBAR8AAAAQAAAARGVsYXlGb3JO" +
           "ZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQApAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SDFEZXZpY2VUeXBlSW5zdGFuY2UBAUQBAQFEAf////8LAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQB" +
           "AUcBAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6RwEAAP////8BAAAABGGCCgQAAAABAAoA" +
           "AABTZXRBZGRyZXNzAQGOAQAvAQGOAY4BAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBjwEALgBEjwEAAJYGAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEV" +
           "AAAABgAAAExpbmtJZAAF/////wAAAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAA/////8AAAAAAAEA" +
           "KgEBGQAAAAoAAABOZXdBZGRyZXNzAAP/////AAAAAAABACoBARcAAAAIAAAATmV3UERUYWcADP////8A" +
           "AAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZABAC4ARJABAACWAgAAAAEAKgEBHwAAABAA" +
           "AABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQFb" +
           "AQMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51" +
           "ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARFsBAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "AA8AAABSZXZpc2lvbkNvdW50ZXIBAVwBAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRp" +
           "Y2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNl" +
           "IGhhcyBiZWVuIG1vZGlmaWVkAC4ARFwBAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51" +
           "ZmFjdHVyZXIBAV0BAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0" +
           "aGUgZGV2aWNlAC4ARF0BAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBXgEDAAAA" +
           "ABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEXgEAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADAAAAERldmljZU1hbnVhbAEBXwEDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmls" +
           "ZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZp" +
           "Y2UALgBEXwEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQFgAQMA" +
           "AAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERgAQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBYQEDAAAAADUAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERhAQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBYgEDAAAAACwAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERiAQAAAAz/////AQH/////AAAAABdg" +
           "iQoCAAAAAQAbAAAATGlzdE9mQ29tbXVuaWNhdGlvblByb2ZpbGVzAQGaOgAuAESaOgAAAAwBAAAAAQAA" +
           "AAAAAAABAf////8AAAAABGCACgEAAAABAA8AAABTZXJ2aWNlUHJvdmlkZXIBAZEBAC8BAeUDkQEAAP//" +
           "//8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAZQBAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhv" +
           "ZHMALwA6lAEAAP////8DAAAABGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQG4AQAvAQEsAbgBAAABAf//" +
           "//8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuQEALgBEuQEAAJYBAAAAAQAqAQEmAAAA" +
           "FwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG6AQAuAES6AQAAlgEAAAABACoBARsAAAAM" +
           "AAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQAHAAAAQ29ubmVjdAEBuwEALwEBKAS7AQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAbwBAC4ARLwBAACWBgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAqAQEVAAAABgAAAExpbmtJZAAF/////wAAAAAAAQAqAQEWAAAABwAAAEFkZHJlc3MA" +
           "A/////8AAAAAAAEAKgEBHAAAAA0AAABPcmRpbmFsTnVtYmVyAAb/////AAAAAAABACoBARwAAAANAAAA" +
           "U0lGQ29ubmVjdGlvbgAB/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBvQEALgBE" +
           "vQEAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwA" +
           "AABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAB" +
           "AAgAAABUcmFuc2ZlcgEBvgEALwEBKwS+AQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAb8BAC4ARL8BAACWBwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEXAAAACAAAAEJsb2Nr" +
           "VGFnAAz/////AAAAAAABACoBARQAAAAFAAAASU5ERVgAB/////8AAAAAAAEAKgEBGAAAAAkAAABTVUJf" +
           "SU5ERVgAB/////8AAAAAAAEAKgEBHAAAAAkAAABXcml0ZURhdGEAAwEAAAABAAAAAAAAAAABACoBARgA" +
           "AAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQHAAQAuAETAAQAAlgMAAAABACoBARsAAAAIAAAAUmVhZERhdGEA" +
           "AwEAAAABAAAAAAAAAAABACoBAR8AAAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEb" +
           "AAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkK" +
           "AgAAAAIADAAAAFNlcmlhbE51bWJlcgEBpgEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkg" +
           "aWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAESmAQAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQGnAQMAAAAAaQAAAEFu" +
           "IGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0" +
           "aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAESnAQAAAAb/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGoAQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNv" +
           "bXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESoAQAAABX/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAFAAAATW9kZWwBAakBAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARKkB" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAaoBAwAAAABaAAAAQWRk" +
           "cmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9m" +
           "IHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARKoBAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "AA4AAABEZXZpY2VSZXZpc2lvbgEBqwEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBkZXZpY2UALgBEqwEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNp" +
           "b24BAawBAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBErAEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNp" +
           "b24BAa0BAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBErQEAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOscBAAD/////AQAAAARhggoEAAAAAQAKAAAAU2V0QWRkcmVz" +
           "cwEBDgIALwEBDgIOAgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQ8CAC4A" +
           "RA8CAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABOZXdQ" +
           "RFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBEAIALgBEEAIAAJYCAAAA" +
           "AQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNl" +
           "RXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SFNFRGV2aWNlVHlwZUluc3RhbmNlAQHEAQEBxAH/////CwAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0" +
           "AQHHAQMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOscBAAD/////AQAAAARhggoEAAAAAQAK" +
           "AAAAU2V0QWRkcmVzcwEBDgIALwEBDgIOAgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAQ8CAC4ARA8CAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEB" +
           "FwAAAAgAAABOZXdQRFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBEAIA" +
           "LgBEEAIAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAA" +
           "AAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIA" +
           "AAACAAwAAABTZXJpYWxOdW1iZXIBAdsBAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlk" +
           "ZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE2wEAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEB3AEDAAAAAGkAAABBbiBp" +
           "bmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGlj" +
           "IGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE3AEAAAAG/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEB3QEDAAAAADAAAABOYW1lIG9mIHRoZSBjb21w" +
           "YW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBE3QEAAAAV/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIABQAAAE1vZGVsAQHeAQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAETeAQAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQHfAQMAAAAAWgAAAEFkZHJl" +
           "c3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1" +
           "c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAETfAQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAO" +
           "AAAARGV2aWNlUmV2aXNpb24BAeABAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "ZGV2aWNlAC4AROABAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9u" +
           "AQHhAQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUg" +
           "ZGV2aWNlAC4AROEBAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9u" +
           "AQHiAQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "ROIBAAAADP////8BAf////8AAAAAF2CJCgIAAAABABsAAABMaXN0T2ZDb21tdW5pY2F0aW9uUHJvZmls" +
           "ZXMBAZs6AC4ARJs6AAAADAEAAAABAAAAAAAAAAEB/////wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQ" +
           "cm92aWRlcgEBEQIALwEBMQQRAgAA/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBFAIDAAAA" +
           "ABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoUAgAA/////wMAAAAEYYIKBAAAAAEACgAAAERpc2Nv" +
           "bm5lY3QBATgCAC8BASwBOAIAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE5" +
           "AgAuAEQ5AgAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAToC" +
           "AC4ARDoCAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQE7AgAvAQF0BDsCAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPAIALgBEPAIAAJYEAAAAAQAqAQEmAAAAFwAAAENv" +
           "bW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAAQWRkcmVzcwAP/////wAA" +
           "AAAAAQAqAQEcAAAADQAAAE9yZGluYWxOdW1iZXIABv////8AAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNl" +
           "SWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAT0CAC4ARD0CAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////" +
           "AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAT4CAC8BAXcEPgIAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQE/AgAuAEQ/AgAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNh" +
           "dGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEA" +
           "KgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAf/////AAAAAAAB" +
           "ACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////AAAAAAABACoBARwAAAAJAAAAV3JpdGVEYXRhAAMBAAAA" +
           "AQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBQAIALgBEQAIAAJYDAAAAAQAqAQEb" +
           "AAAACAAAAFJlYWREYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwA" +
           "B/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBASYCAwAAAABNAAAASWRlbnRpZmll" +
           "ciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2Ug" +
           "aW5zdGFuY2UALgBEJgIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRl" +
           "cgEBJwIDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBv" +
           "ZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQA" +
           "LgBEJwIAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBKAIDAAAAADAA" +
           "AABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEKAIAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQEpAgMAAAAAGAAAAE1vZGVsIG5hbWUgb2Yg" +
           "dGhlIGRldmljZQAuAEQpAgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFs" +
           "AQEqAgMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8" +
           "IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQqAgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BASsCAwAAAAAkAAAAT3ZlcmFsbCByZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARCsCAAAADP////8BAf////8AAAAANWCJCgIAAAACABAA" +
           "AABTb2Z0d2FyZVJldmlzaW9uAQEsAgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2Fy" +
           "ZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARCwCAAAADP////8BAf////8AAAAANWCJCgIAAAACABAA" +
           "AABIYXJkd2FyZVJldmlzaW9uAQEtAgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2Fy" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARC0CAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcCAAD/////AQAAAARhggoEAAAAAQAKAAAAU2V0QWRkcmVz" +
           "cwEBjgIALwEBjgKOAgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8CAC4A" +
           "RI8CAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkAAAAKAAAATmV3" +
           "QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBkAIALgBEkAIAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJQlVTRGV2aWNlVHlwZUluc3RhbmNlAQFEAgEBRAL/////CwAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQFHAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcCAAD/////AQAAAARhggoEAAAA" +
           "AQAKAAAAU2V0QWRkcmVzcwEBjgIALwEBjgKOAgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAY8CAC4ARI8CAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAAB" +
           "ACoBARkAAAAKAAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBkAIALgBEkAIAAJYBAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAA" +
           "AFNlcmlhbE51bWJlcgEBWwIDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmll" +
           "cywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERbAgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFcAgMAAAAAaQAAAEFuIGluY3JlbWVu" +
           "dGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3" +
           "aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERcAgAAAAb/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQFdAgMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhh" +
           "dCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAERdAgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAF" +
           "AAAATW9kZWwBAV4CAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARF4CAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAV8CAwAAAABaAAAAQWRkcmVzcyAocGF0" +
           "aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFu" +
           "dWFsIGZvciB0aGUgZGV2aWNlAC4ARF8CAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZp" +
           "Y2VSZXZpc2lvbgEBYAIDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UA" +
           "LgBEYAIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAWECAwAA" +
           "AAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBEYQIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAWICAwAA" +
           "AAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEYgIAAAAM" +
           "/////wEB/////wAAAAAXYIkKAgAAAAEAGwAAAExpc3RPZkNvbW11bmljYXRpb25Qcm9maWxlcwEBnDoA" +
           "LgBEnDoAAAAMAQAAAAEAAAAAAAAAAQH/////AAAAAARggAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVy" +
           "AQGRAgAvAQF9BJECAAD/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQGUAgMAAAAAFAAAAEZs" +
           "YXQgbGlzdCBvZiBNZXRob2RzAC8AOpQCAAD/////AwAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEB" +
           "uAIALwEBLAG4AgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbkCAC4ARLkC" +
           "AACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBugIALgBEugIA" +
           "AJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAbsCAC8BAcAEuwIAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQG8AgAuAES8AgAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNh" +
           "dGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAAP/////AAAAAAABACoB" +
           "AR0AAAAOAAAATWFudWZhY3R1cmVySWQABf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAb0CAC4ARL0CAACWAQAAAAEAKgEBGwAAAAwAAABT" +
           "ZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAgA" +
           "AABUcmFuc2ZlcgEBvgIALwEBwwS+AgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAb8CAC4ARL8CAACWBQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP////" +
           "/wAAAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQETAAAABAAAAFNMT1QAA///" +
           "//8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAD/////wAAAAAAAQAqAQEWAAAABwAAAFJFUVVFU1QAD///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAcACAC4ARMACAACWAwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AFJFU1BPTlNFX0NPREVTAA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQGmAgMA" +
           "AAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFj" +
           "dHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARKYCAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8A" +
           "AABSZXZpc2lvbkNvdW50ZXIBAacCAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0" +
           "aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhh" +
           "cyBiZWVuIG1vZGlmaWVkAC4ARKcCAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFj" +
           "dHVyZXIBAagCAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUg" +
           "ZGV2aWNlAC4ARKgCAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBqQIDAAAAABgA" +
           "AABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEqQIAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAERldmljZU1hbnVhbAEBqgIDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBz" +
           "eXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UA" +
           "LgBEqgIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQGrAgMAAAAA" +
           "JAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAESrAgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBrAIDAAAAADUAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAESsAgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBrQIDAAAAACwAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEStAgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOsQCAAD/////AQAAAARhggoEAAAAAQAKAAAAU2V0QWRkcmVz" +
           "cwEBCwMALwEBCwMLAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQwDAC4A" +
           "RAwDAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoBARUAAAACAAAASVAAAwEA" +
           "AAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAqAQEdAAAACgAAAFN1Ym5l" +
           "dE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAAAAEAAAAEAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQ0DAC4ARA0D" +
           "AACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJTkVURGV2aWNlVHlwZUluc3RhbmNlAQHBAgEBwQL/////CwAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQHEAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOsQCAAD/////AQAAAARhggoEAAAA" +
           "AQAKAAAAU2V0QWRkcmVzcwEBCwMALwEBCwMLAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAQwDAC4ARAwDAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoB" +
           "ARUAAAACAAAASVAAAwEAAAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAq" +
           "AQEdAAAACgAAAFN1Ym5ldE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAA" +
           "AAEAAAAEAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAQ0DAC4ARA0DAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAdgCAwAAAABN" +
           "AAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJl" +
           "ciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE2AIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJl" +
           "dmlzaW9uQ291bnRlcgEB2QIDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcg" +
           "dGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJl" +
           "ZW4gbW9kaWZpZWQALgBE2QIAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJl" +
           "cgEB2gIDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZp" +
           "Y2UALgBE2gIAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQHbAgMAAAAAGAAAAE1v" +
           "ZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAETbAgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAA" +
           "RGV2aWNlTWFudWFsAQHcAgMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3Rl" +
           "bSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAETc" +
           "AgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAd0CAwAAAAAkAAAA" +
           "T3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARN0CAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQHeAgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARN4CAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQHfAgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARN8CAAAADP////8BAf////8AAAAAF2CJCgIAAAAB" +
           "ABsAAABMaXN0T2ZDb21tdW5pY2F0aW9uUHJvZmlsZXMBAZ06AC4ARJ06AAAADAEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92aWRlcgEBDgMALwEBxgQOAwAA/////wkAAAAk" +
           "YIAKAQAAAAIACQAAAE1ldGhvZFNldAEBEQMDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoR" +
           "AwAA/////wMAAAAEYYIKBAAAAAEACgAAAERpc2Nvbm5lY3QBATUDAC8BASwBNQMAAAEB/////wIAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE2AwAuAEQ2AwAAlgEAAAABACoBASYAAAAXAAAAQ29t" +
           "bXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATcDAC4ARDcDAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABD" +
           "b25uZWN0AQE4AwAvAQEJBTgDAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "OQMALgBEOQMAAJYEAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAA" +
           "AAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAqAQEXAAAACAAAAERldmljZUlEAAX/////" +
           "AAAAAAABACoBARcAAAAIAAAAVmVuZG9ySUQABf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAToDAC4ARDoDAACWAQAAAAEAKgEBGwAAAAwA" +
           "AABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAB" +
           "AAgAAABUcmFuc2ZlcgEBOwMALwEBDAU7AwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBATwDAC4ARDwDAACWBwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQETAAAABAAAAFNMT1QA" +
           "Bf////8AAAAAAAEAKgEBFgAAAAcAAABTVUJTTE9UAAX/////AAAAAAABACoBARQAAAAFAAAASU5ERVgA" +
           "Bf////8AAAAAAAEAKgEBEgAAAAMAAABBUEkAB/////8AAAAAAAEAKgEBFgAAAAcAAABSRVFVRVNUAA//" +
           "////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQE9AwAuAEQ9AwAAlgMAAAABACoBARQAAAAFAAAAUkVQTFkAD/////8AAAAAAAEAKgEBHQAAAA4A" +
           "AABSRVNQT05TRV9DT0RFUwAP/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBIwMD" +
           "AAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZh" +
           "Y3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQjAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAP" +
           "AAAAUmV2aXNpb25Db3VudGVyAQEkAwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNh" +
           "dGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBo" +
           "YXMgYmVlbiBtb2RpZmllZAAuAEQkAwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZh" +
           "Y3R1cmVyAQElAwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhl" +
           "IGRldmljZQAuAEQlAwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBASYDAwAAAAAY" +
           "AAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARCYDAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAwAAABEZXZpY2VNYW51YWwBAScDAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUg" +
           "c3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNl" +
           "AC4ARCcDAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBKAMDAAAA" +
           "ACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEKAMAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BASkDAwAAAAA1AAAAUmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEKQMAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BASoDAwAAAAAsAAAAUmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEKgMAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkEDAAD/////AQAAAARhggoEAAAAAQAKAAAAU2V0QWRkcmVz" +
           "cwEBiAMALwEBiAOIAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYkDAC4A" +
           "RIkDAACWAgAAAAEAKgEBHQAAAA4AAABPbGRQb2xsQWRkcmVzcwAD/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AE5ld1BvbGxBZGRyZXNzAAP/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQGKAwAuAESKAwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVy" +
           "cm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAiAAAAU2VydmVyQ29tbXVuaWNhdGlvbkhB" +
           "UlR5cGVJbnN0YW5jZQEBPgMBAT4D/////wsAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBQQMDAAAA" +
           "ABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpBAwAA/////wEAAAAEYYIKBAAAAAEACgAAAFNldEFk" +
           "ZHJlc3MBAYgDAC8BAYgDiAMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGJ" +
           "AwAuAESJAwAAlgIAAAABACoBAR0AAAAOAAAAT2xkUG9sbEFkZHJlc3MAA/////8AAAAAAAEAKgEBHQAA" +
           "AA4AAABOZXdQb2xsQWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBigMALgBEigMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZp" +
           "Y2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNl" +
           "cmlhbE51bWJlcgEBVQMDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywg" +
           "d2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERVAwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFWAwMAAAAAaQAAAEFuIGluY3JlbWVudGFs" +
           "IGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRo" +
           "aW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERWAwAAAAb/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAMAAAATWFudWZhY3R1cmVyAQFXAwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBt" +
           "YW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAERXAwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAA" +
           "TW9kZWwBAVgDAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARFgDAAAAFf////8BAf//" +
           "//8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAVkDAwAAAABaAAAAQWRkcmVzcyAocGF0aG5h" +
           "bWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFs" +
           "IGZvciB0aGUgZGV2aWNlAC4ARFkDAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VS" +
           "ZXZpc2lvbgEBWgMDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE" +
           "WgMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAVsDAwAAAAA1" +
           "AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE" +
           "WwMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAVwDAwAAAAAs" +
           "AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEXAMAAAAM////" +
           "/wEB/////wAAAAAXYIkKAgAAAAEAGwAAAExpc3RPZkNvbW11bmljYXRpb25Qcm9maWxlcwEBnjoALgBE" +
           "njoAAAAMAQAAAAEAAAAAAAAAAQH/////AAAAAARggAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQGL" +
           "AwAvAQEPBYsDAAD/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQGOAwMAAAAAFAAAAEZsYXQg" +
           "bGlzdCBvZiBNZXRob2RzAC8AOo4DAAD/////AwAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEBsgMA" +
           "LwEBLAGyAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbMDAC4ARLMDAACW" +
           "AQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBtAMALgBEtAMAAJYB" +
           "AAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAbUDAC8BAVIFtQMAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQG2AwAuAES2AwAAlgIAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlv" +
           "blJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGgAAAAsAAABMb25nQWRkcmVzcwAP/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBtwMALgBE" +
           "twMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQG4AwAvAQFVBbgDAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuQMALgBEuQMAAJYDAAAAAQAqAQEmAAAAFwAAAENvbW11" +
           "bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAAQ29tbWFuZAAF/////wAAAAAA" +
           "AQAqAQEWAAAABwAAAFJlcXVlc3QAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAboDAC4ARLoDAACWAgAAAAEAKgEBFAAAAAUAAABSZXBs" +
           "eQAP/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBoAMDAAAAAE0AAABJZGVudGlm" +
           "aWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmlj" +
           "ZSBpbnN0YW5jZQAuAESgAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3Vu" +
           "dGVyAQGhAwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVy" +
           "IG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmll" +
           "ZAAuAEShAwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGiAwMAAAAA" +
           "MAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESiAwAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAaMDAwAAAAAYAAAATW9kZWwgbmFtZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARKMDAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51" +
           "YWwBAaQDAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJM" +
           "IHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARKQDAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBpQMDAAAAACQAAABPdmVyYWxsIHJl" +
           "dmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEpQMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "EAAAAFNvZnR3YXJlUmV2aXNpb24BAaYDAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3" +
           "YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEpgMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "EAAAAEhhcmR3YXJlUmV2aXNpb24BAacDAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3" +
           "YXJlIG9mIHRoZSBkZXZpY2UALgBEpwMAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "QTEwMF9XaXJlbGVzc0RldmljZVR5cGVJbnN0YW5jZQEB/AYBAfwG/////woAAAA1YIkKAgAAAAIADAAA" +
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
           "/////wEB/////wAAAAAXYIkKAgAAAAEAGwAAAExpc3RPZkNvbW11bmljYXRpb25Qcm9maWxlcwEBnzoA" +
           "LgBEnzoAAAAMAQAAAAEAAAAAAAAAAQH/////AAAAAARggAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVy" +
           "AQFGBwAvAQEJCEYHAAD/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQFJBwMAAAAAFAAAAEZs" +
           "YXQgbGlzdCBvZiBNZXRob2RzAC8AOkkHAAD/////AwAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEB" +
           "bQcALwEBLAFtBwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAW4HAC4ARG4H" +
           "AACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBbwcALgBEbwcA" +
           "AJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAXAHAC8BAUwIcAcAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQFxBwAuAERxBwAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNh" +
           "dGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABJUEFkZHJlc3MAD/////8AAAAAAAEA" +
           "KgEBGgAAAAsAAABDb25uZWN0VHlwZQAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBcgcALgBEcgcAAJYBAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAA" +
           "AFRyYW5zZmVyAQFzBwAvAQFPCHMHAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBdAcALgBEdAcAAJYIAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARQAAAAFAAAAQXBwSUQABf//" +
           "//8AAAAAAAEAKgEBFwAAAAgAAABPYmplY3RJRAAF/////wAAAAAAAQAqAQEbAAAADAAAAEF0dHJPck1l" +
           "dGhJRAAF/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEcAAAACQAA" +
           "AFdyaXRlRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAB/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXUHAC4A" +
           "RHUHAACWAgAAAAEAKgEBGwAAAAgAAABSZWFkRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGwAAAAwAAABT" +
           "ZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwA" +
           "AABTZXJpYWxOdW1iZXIBAVsHAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZp" +
           "ZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEWwcAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBXAcDAAAAAGkAAABBbiBpbmNyZW1l" +
           "bnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEg" +
           "d2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEXAcAAAAG/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBXQcDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRo" +
           "YXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEXQcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "BQAAAE1vZGVsAQFeBwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEReBwAAABX/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQFfBwMAAAAAWgAAAEFkZHJlc3MgKHBh" +
           "dGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1h" +
           "bnVhbCBmb3IgdGhlIGRldmljZQAuAERfBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2" +
           "aWNlUmV2aXNpb24BAWAHAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNl" +
           "AC4ARGAHAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQFhBwMA" +
           "AAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNl" +
           "AC4ARGEHAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQFiBwMA" +
           "AAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARGIHAAAA" +
           "DP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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
           "AEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOnwHAAD/////AQAAAARhggoEAAAAAQAKAAAAU2V0QWRkcmVz" +
           "cwEBxAcALwEBxAfEBwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcUHAC4A" +
           "RMUHAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAA//////AAAAAAABACoBARkAAAAKAAAATmV3" +
           "QWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBxgcALgBExgcAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAsAAAAU2VydmVyQ29tbXVuaWNhdGlvbkdF" +
           "TkVSSUNEZXZpY2VUeXBlSW5zdGFuY2UBAXkHAQF5B/////8MAAAAJGCACgEAAAACAAkAAABNZXRob2RT" +
           "ZXQBAXwHAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6fAcAAP////8BAAAABGGCCgQAAAAB" +
           "AAoAAABTZXRBZGRyZXNzAQHEBwAvAQHEB8QHAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBxQcALgBExQcAAJYCAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAD/////8AAAAAAAEA" +
           "KgEBGQAAAAoAAABOZXdBZGRyZXNzAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHGBwAuAETGBwAAlgEAAAABACoBARsAAAAMAAAAU2Vy" +
           "dmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAA" +
           "U2VyaWFsTnVtYmVyAQGQBwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVz" +
           "LCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARJAHAAAADP////8BAf//" +
           "//8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAZEHAwAAAABpAAAAQW4gaW5jcmVtZW50" +
           "YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdp" +
           "dGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARJEHAAAABv////8BAf////8AAAAANWCJ" +
           "CgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAZIHAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0" +
           "IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARJIHAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUA" +
           "AABNb2RlbAEBkwcDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEkwcAAAAV/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBlAcDAAAAAFoAAABBZGRyZXNzIChwYXRo" +
           "bmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51" +
           "YWwgZm9yIHRoZSBkZXZpY2UALgBElAcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmlj" +
           "ZVJldmlzaW9uAQGVBwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAu" +
           "AESVBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBlgcDAAAA" +
           "ADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAu" +
           "AESWBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBlwcDAAAA" +
           "ACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAESXBwAAAAz/" +
           "////AQH/////AAAAABdgiQoCAAAAAQAbAAAATGlzdE9mQ29tbXVuaWNhdGlvblByb2ZpbGVzAQGgOgAu" +
           "AESgOgAAAAwBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABABIAAABQcm90b2NvbElkZW50aWZp" +
           "ZXIBAcMHAC4ARMMHAAAADP////8BAf////8AAAAABGCACgEAAAABAA8AAABTZXJ2aWNlUHJvdmlkZXIB" +
           "AccHAC8BAVUIxwcAAP////8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAcoHAwAAAAAUAAAARmxh" +
           "dCBsaXN0IG9mIE1ldGhvZHMALwA6ygcAAP////8DAAAABGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQHu" +
           "BwAvAQEsAe4HAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB7wcALgBE7wcA" +
           "AJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHwBwAuAETwBwAA" +
           "lgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEB8QcALwEBmAjxBwAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAfIHAC4ARPIHAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0" +
           "aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAAAEFkZHJlc3MAD/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAfMHAC4ARPMH" +
           "AACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAABGGCCgQAAAABAAgAAABUcmFuc2ZlcgEB9AcALwEBmwj0BwAAAQH/////AgAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfUHAC4ARPUHAACWBQAAAAEAKgEBJgAAABcAAABDb21tdW5p" +
           "Y2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEVAAAABgAAAEhlYWRlcgAM/////wAAAAAAAQAq" +
           "AQEaAAAACwAAAFJlcXVlc3REYXRhAA//////AAAAAAABACoBASUAAAAQAAAAUmVxdWVzdERhdGFUeXBl" +
           "cwEBAggBAAAAAQAAAAAAAAAAAQAqAQEmAAAAEQAAAFJlc3BvbnNlRGF0YVR5cGVzAQECCAEAAAABAAAA" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQH2BwAuAET2BwAAlgMAAAABACoBARsAAAAMAAAAUmVzcG9uc2VEYXRhAA//////AAAAAAABACoBAR0A" +
           "AAAOAAAAUkVTUE9OU0VfQ09ERVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIB" +
           "AdwHAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1h" +
           "bnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE3AcAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADwAAAFJldmlzaW9uQ291bnRlcgEB3QcDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGlu" +
           "ZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZp" +
           "Y2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE3QcAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1h" +
           "bnVmYWN0dXJlcgEB3gcDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVk" +
           "IHRoZSBkZXZpY2UALgBE3gcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQHfBwMA" +
           "AAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAETfBwAAABX/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAMAAAARGV2aWNlTWFudWFsAQHgBwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBm" +
           "aWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRl" +
           "dmljZQAuAETgBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAeEH" +
           "AwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4AROEHAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQHiBwMAAAAANQAAAFJldmlzaW9u" +
           "IGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4AROIHAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQHjBwMAAAAALAAAAFJldmlzaW9u" +
           "IGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4AROMHAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
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
           "AQG+AwAvAQG+A74DAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvwMALgBE" +
           "vwMAAJYGAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARUAAAAGAAAATGlua0lkAAX/////AAAAAAABACoBARYAAAAHAAAAQWRkcmVzcwAD/////wAAAAAAAQAq" +
           "AQEcAAAADQAAAE9yZGluYWxOdW1iZXIABv////8AAAAAAAEAKgEBHAAAAA0AAABTSUZDb25uZWN0aW9u" +
           "AAH/////AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHAAwAuAETAAwAAlgIAAAABACoB" +
           "AR8AAAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJv" +
           "cgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            ushort linkId = (ushort)_inputArguments[1];
            byte address = (byte)_inputArguments[2];
            int ordinalNumber = (int)_inputArguments[3];
            bool sIFConnection = (bool)_inputArguments[4];
            uint serviceId = (uint)_inputArguments[5];

            uint delayForNextCall = (uint)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    linkId,
                    address,
                    ordinalNumber,
                    sIFConnection,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            _outputArguments[0] = delayForNextCall;
            _outputArguments[1] = serviceError;

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
           "ZQEBwQMALwEBwQPBAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcIDAC4A" +
           "RMIDAACWBAAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAEFkZHJlc3MAD/////8AAAAAAAEAKgEBHAAAAA0AAABPcmRpbmFsTnVtYmVyAAb/////" +
           "AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHDAwAuAETDAwAAlgIAAAABACoBAR8AAAAQ" +
           "AAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            byte[] address = (byte[])_inputArguments[1];
            int ordinalNumber = (int)_inputArguments[2];
            uint serviceId = (uint)_inputArguments[3];

            uint delayForNextCall = (uint)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    address,
                    ordinalNumber,
                    serviceId,
                    ref delayForNextCall,
                    ref serviceError);
            }

            _outputArguments[0] = delayForNextCall;
            _outputArguments[1] = serviceError;

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
           "VHlwZQEBxAMALwEBxAPEAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcUD" +
           "AC4ARMUDAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAA" +
           "AQAqAQEWAAAABwAAAEFkZHJlc3MAA/////8AAAAAAAEAKgEBHQAAAA4AAABNYW51ZmFjdHVyZXJJZAAF" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBxgMALgBExgMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            byte address = (byte)_inputArguments[1];
            ushort manufacturerId = (ushort)_inputArguments[2];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    address,
                    manufacturerId,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "VHlwZQEBxwMALwEBxwPHAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcgD" +
           "AC4ARMgDAACWBAAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAA" +
           "AQAqAQEWAAAABwAAAEROU05BTUUADP////8AAAAAAAEAKgEBFwAAAAgAAABEZXZpY2VJRAAF/////wAA" +
           "AAAAAQAqAQEXAAAACAAAAFZlbmRvcklEAAX/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "ABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHJAwAuAETJAwAAlgEAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string dNSNAME = (string)_inputArguments[1];
            ushort deviceID = (ushort)_inputArguments[2];
            ushort vendorID = (ushort)_inputArguments[3];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    dNSNAME,
                    deviceID,
                    vendorID,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "AQHKAwAvAQHKA8oDAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBywMALgBE" +
           "ywMAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARoAAAALAAAATG9uZ0FkZHJlc3MAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAcwDAC4ARMwDAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            byte[] longAddress = (byte[])_inputArguments[1];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    longAddress,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "aXJlbGVzc1R5cGUBAfcHAC8BAfcH9wcAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQH4BwAuAET4BwAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD///" +
           "//8AAAAAAAEAKgEBGAAAAAkAAABJUEFkZHJlc3MAD/////8AAAAAAAEAKgEBGgAAAAsAAABDb25uZWN0" +
           "VHlwZQAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEB+QcALgBE+QcAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            byte[] iPAddress = (byte[])_inputArguments[1];
            uint connectType = (uint)_inputArguments[2];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    iPAddress,
                    connectType,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "eXBlAQH6BwAvAQH6B/oHAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB+wcA" +
           "LgBE+wcAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAAB" +
           "ACoBARYAAAAHAAAAQWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/AcALgBE/AcAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZp" +
           "Y2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            byte[] address = (byte[])_inputArguments[1];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    address,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "AeAAAC8BAeAA4AAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHhAAAuAETh" +
           "AAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAeIAAC4AROIA" +
           "AACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];

            object serviceError = (object)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    ref serviceError);
            }

            _outputArguments[0] = serviceError;

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
           "ZQEBzQMALwEBzQPNAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAc4DAC4A" +
           "RM4DAACWBwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEXAAAACAAAAEJsb2NrVGFnAAz/////AAAA" +
           "AAABACoBARQAAAAFAAAASU5ERVgAB/////8AAAAAAAEAKgEBGAAAAAkAAABTVUJfSU5ERVgAB/////8A" +
           "AAAAAAEAKgEBHAAAAAkAAABXcml0ZURhdGEAAwEAAAABAAAAAAAAAAABACoBARgAAAAJAAAAU2Vydmlj" +
           "ZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQHPAwAuAETPAwAAlgMAAAABACoBARsAAAAIAAAAUmVhZERhdGEAAwEAAAABAAAAAAAA" +
           "AAABACoBAR8AAAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZp" +
           "Y2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string oPERATION = (string)_inputArguments[1];
            string blockTag = (string)_inputArguments[2];
            uint iNDEX = (uint)_inputArguments[3];
            uint sUB_INDEX = (uint)_inputArguments[4];
            byte[] writeData = (byte[])_inputArguments[5];
            uint serviceId = (uint)_inputArguments[6];

            byte[] readData = (byte[])_outputArguments[0];
            uint delayForNextCall = (uint)_outputArguments[1];
            object serviceError = (object)_outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
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

            _outputArguments[0] = readData;
            _outputArguments[1] = delayForNextCall;
            _outputArguments[2] = serviceError;

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
           "cGUBAdADAC8BAdAD0AMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHRAwAu" +
           "AETRAwAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEA" +
           "KgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAA" +
           "AAAAAQAqAQEUAAAABQAAAElOREVYAAf/////AAAAAAABACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////" +
           "AAAAAAABACoBARwAAAAJAAAAV3JpdGVEYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZp" +
           "Y2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEB0gMALgBE0gMAAJYDAAAAAQAqAQEbAAAACAAAAFJlYWREYXRhAAMBAAAAAQAAAAAA" +
           "AAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string oPERATION = (string)_inputArguments[1];
            string blockTag = (string)_inputArguments[2];
            uint iNDEX = (uint)_inputArguments[3];
            uint sUB_INDEX = (uint)_inputArguments[4];
            byte[] writeData = (byte[])_inputArguments[5];
            uint serviceId = (uint)_inputArguments[6];

            byte[] readData = (byte[])_outputArguments[0];
            uint delayForNextCall = (uint)_outputArguments[1];
            object serviceError = (object)_outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
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

            _outputArguments[0] = readData;
            _outputArguments[1] = delayForNextCall;
            _outputArguments[2] = serviceError;

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
           "U1R5cGUBAdMDAC8BAdMD0wMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHU" +
           "AwAuAETUAwAAlgUAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAA" +
           "AAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9UAAP/////AAAA" +
           "AAABACoBARQAAAAFAAAASU5ERVgAA/////8AAAAAAAEAKgEBFgAAAAcAAABSRVFVRVNUAA//////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHV" +
           "AwAuAETVAwAAlgMAAAABACoBARQAAAAFAAAAUkVQTFkAD/////8AAAAAAAEAKgEBHQAAAA4AAABSRVNQ" +
           "T05TRV9DT0RFUwAP/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAA=";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string oPERATION = (string)_inputArguments[1];
            byte sLOT = (byte)_inputArguments[2];
            byte iNDEX = (byte)_inputArguments[3];
            byte[] rEQUEST = (byte[])_inputArguments[4];

            byte[] rEPLY = (byte[])_outputArguments[0];
            byte[] rESPONSE_CODES = (byte[])_outputArguments[1];
            object serviceError = (object)_outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    oPERATION,
                    sLOT,
                    iNDEX,
                    rEQUEST,
                    ref rEPLY,
                    ref rESPONSE_CODES,
                    ref serviceError);
            }

            _outputArguments[0] = rEPLY;
            _outputArguments[1] = rESPONSE_CODES;
            _outputArguments[2] = serviceError;

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
           "VFR5cGUBAdYDAC8BAdYD1gMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHX" +
           "AwAuAETXAwAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAA" +
           "AAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9UAAX/////AAAA" +
           "AAABACoBARYAAAAHAAAAU1VCU0xPVAAF/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAX/////AAAA" +
           "AAABACoBARIAAAADAAAAQVBJAAf/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB2AMA" +
           "LgBE2AMAAJYDAAAAAQAqAQEUAAAABQAAAFJFUExZAA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9O" +
           "U0VfQ09ERVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string oPERATION = (string)_inputArguments[1];
            ushort sLOT = (ushort)_inputArguments[2];
            ushort sUBSLOT = (ushort)_inputArguments[3];
            ushort iNDEX = (ushort)_inputArguments[4];
            uint aPI = (uint)_inputArguments[5];
            byte[] rEQUEST = (byte[])_inputArguments[6];

            byte[] rEPLY = (byte[])_outputArguments[0];
            byte[] rESPONSE_CODES = (byte[])_outputArguments[1];
            object serviceError = (object)_outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
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

            _outputArguments[0] = rEPLY;
            _outputArguments[1] = rESPONSE_CODES;
            _outputArguments[2] = serviceError;

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
           "ZQEB2QMALwEB2QPZAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAdoDAC4A" +
           "RNoDAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAENvbW1hbmQABf////8AAAAAAAEAKgEBFgAAAAcAAABSZXF1ZXN0AA//////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHbAwAu" +
           "AETbAwAAlgIAAAABACoBARQAAAAFAAAAUmVwbHkAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNl" +
           "RXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            ushort command = (ushort)_inputArguments[1];
            byte[] request = (byte[])_inputArguments[2];

            byte[] reply = (byte[])_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    command,
                    request,
                    ref reply,
                    ref serviceError);
            }

            _outputArguments[0] = reply;
            _outputArguments[1] = serviceError;

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
           "V2lyZWxlc3NUeXBlAQH9BwAvAQH9B/0HAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEB/gcALgBE/gcAAJYIAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//" +
           "////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARQAAAAFAAAAQXBwSUQA" +
           "Bf////8AAAAAAAEAKgEBFwAAAAgAAABPYmplY3RJRAAF/////wAAAAAAAQAqAQEbAAAADAAAAEF0dHJP" +
           "ck1ldGhJRAAF/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEcAAAA" +
           "CQAAAFdyaXRlRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAB/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf8H" +
           "AC4ARP8HAACWAgAAAAEAKgEBGwAAAAgAAABSZWFkRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGwAAAAwA" +
           "AABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string oPERATION = (string)_inputArguments[1];
            ushort appID = (ushort)_inputArguments[2];
            ushort objectID = (ushort)_inputArguments[3];
            ushort attrOrMethID = (ushort)_inputArguments[4];
            uint sUB_INDEX = (uint)_inputArguments[5];
            byte[] writeData = (byte[])_inputArguments[6];
            uint requestId = (uint)_inputArguments[7];

            byte[] readData = (byte[])_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
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

            _outputArguments[0] = readData;
            _outputArguments[1] = serviceError;

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
           "VHlwZQEBAwgALwEBAwgDCAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQQI" +
           "AC4ARAQIAACWBQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAA" +
           "AQAqAQEVAAAABgAAAEhlYWRlcgAM/////wAAAAAAAQAqAQEaAAAACwAAAFJlcXVlc3REYXRhAA//////" +
           "AAAAAAABACoBASUAAAAQAAAAUmVxdWVzdERhdGFUeXBlcwEBAggBAAAAAQAAAAAAAAAAAQAqAQEmAAAA" +
           "EQAAAFJlc3BvbnNlRGF0YVR5cGVzAQECCAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEFCAAuAEQFCAAAlgMAAAABACoBARsAAAAM" +
           "AAAAUmVzcG9uc2VEYXRhAA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9OU0VfQ09ERVMAD/////8A" +
           "AAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            string header = (string)_inputArguments[1];
            byte[] requestData = (byte[])_inputArguments[2];
            EddDataTypeInfo[] requestDataTypes = (EddDataTypeInfo[])ExtensionObject.ToArray(_inputArguments[3], typeof(EddDataTypeInfo));
            EddDataTypeInfo[] responseDataTypes = (EddDataTypeInfo[])ExtensionObject.ToArray(_inputArguments[4], typeof(EddDataTypeInfo));

            byte[] responseData = (byte[])_outputArguments[0];
            byte[] rESPONSE_CODES = (byte[])_outputArguments[1];
            object serviceError = (object)_outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    header,
                    requestData,
                    requestDataTypes,
                    responseDataTypes,
                    ref responseData,
                    ref rESPONSE_CODES,
                    ref serviceError);
            }

            _outputArguments[0] = responseData;
            _outputArguments[1] = rESPONSE_CODES;
            _outputArguments[2] = serviceError;

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
           "ZEZGSDFUeXBlAQHcAwAvAQHcA9wDAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEB3QMALgBE3QMAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHeAwAuAETeAwAAlgYAAAABACoBARcAAAAI" +
           "AAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEBIQAAAA4AAABBbGFybUV2ZW50RGF0YQADAQAAAAEAAAAA" +
           "AAAAAAEAKgEBHQAAAA4AAABBbGFybUV2ZW50VHlwZQAR/////wAAAAAAAQAqAQEYAAAACQAAAFRpbWVT" +
           "dGFtcAAN/////wAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEB" +
           "GwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            uint serviceId = (uint)_inputArguments[1];

            string blockTag = (string)_outputArguments[0];
            byte[] alarmEventData = (byte[])_outputArguments[1];
            NodeId alarmEventType = (NodeId)_outputArguments[2];
            DateTime timeStamp = (DateTime)_outputArguments[3];
            uint delayForNextCall = (uint)_outputArguments[4];
            object serviceError = (object)_outputArguments[5];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    serviceId,
                    ref blockTag,
                    ref alarmEventData,
                    ref alarmEventType,
                    ref timeStamp,
                    ref delayForNextCall,
                    ref serviceError);
            }

            _outputArguments[0] = blockTag;
            _outputArguments[1] = alarmEventData;
            _outputArguments[2] = alarmEventType;
            _outputArguments[3] = timeStamp;
            _outputArguments[4] = delayForNextCall;
            _outputArguments[5] = serviceError;

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
           "ZEZGSFNFVHlwZQEB3wMALwEB3wPfAwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAeADAC4AROADAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP////" +
           "/wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB4QMALgBE4QMAAJYGAAAAAQAqAQEXAAAA" +
           "CAAAAEJsb2NrVGFnAAz/////AAAAAAABACoBASEAAAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAABAAAA" +
           "AAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVudFR5cGUAEf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1l" +
           "U3RhbXAADf////8AAAAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoB" +
           "ARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];
            uint serviceId = (uint)_inputArguments[1];

            string blockTag = (string)_outputArguments[0];
            byte[] alarmEventData = (byte[])_outputArguments[1];
            NodeId alarmEventType = (NodeId)_outputArguments[2];
            DateTime timeStamp = (DateTime)_outputArguments[3];
            uint delayForNextCall = (uint)_outputArguments[4];
            object serviceError = (object)_outputArguments[5];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    serviceId,
                    ref blockTag,
                    ref alarmEventData,
                    ref alarmEventType,
                    ref timeStamp,
                    ref delayForNextCall,
                    ref serviceError);
            }

            _outputArguments[0] = blockTag;
            _outputArguments[1] = alarmEventData;
            _outputArguments[2] = alarmEventType;
            _outputArguments[3] = timeStamp;
            _outputArguments[4] = delayForNextCall;
            _outputArguments[5] = serviceError;

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
           "ZEhBUlRUeXBlAQHiAwAvAQHiA+IDAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEB4wMALgBE4wMAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQHkAwAuAETkAwAAlgQAAAABACoBARYAAAAHAAAAQ29tbWFuZAAF/////wAAAAAAAQAqAQEUAAAABQAA" +
           "AFJlcGx5AA//////AAAAAAABACoBARgAAAAJAAAAVGltZVN0YW1wAA3/////AAAAAAABACoBARsAAAAM" +
           "AAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];

            ushort command = (ushort)_outputArguments[0];
            byte[] reply = (byte[])_outputArguments[1];
            DateTime timeStamp = (DateTime)_outputArguments[2];
            object serviceError = (object)_outputArguments[3];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    ref command,
                    ref reply,
                    ref timeStamp,
                    ref serviceError);
            }

            _outputArguments[0] = command;
            _outputArguments[1] = reply;
            _outputArguments[2] = timeStamp;
            _outputArguments[3] = serviceError;

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
           "ZElTQTEwMF9XaXJlbGVzc1R5cGUBAQYIAC8BAQYIBggAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQEHCAAuAEQHCAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAQgIAC4ARAgIAACWBgAAAAEAKgEBFAAAAAUAAABBcHBJRAAF/////wAAAAAAAQAq" +
           "AQEXAAAACAAAAE9iamVjdElEAAX/////AAAAAAABACoBASEAAAAOAAAAQWxhcm1FdmVudERhdGEAAwEA" +
           "AAABAAAAAAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVudFR5cGUABf////8AAAAAAAEAKgEBGAAAAAkA" +
           "AABUaW1lU3RhbXAADf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte[] communicationRelationId = (byte[])_inputArguments[0];

            ushort appID = (ushort)_outputArguments[0];
            ushort objectID = (ushort)_outputArguments[1];
            byte[] alarmEventData = (byte[])_outputArguments[2];
            ushort alarmEventType = (ushort)_outputArguments[3];
            DateTime timeStamp = (DateTime)_outputArguments[4];
            object serviceError = (object)_outputArguments[5];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    ref appID,
                    ref objectID,
                    ref alarmEventData,
                    ref alarmEventType,
                    ref timeStamp,
                    ref serviceError);
            }

            _outputArguments[0] = appID;
            _outputArguments[1] = objectID;
            _outputArguments[2] = alarmEventData;
            _outputArguments[3] = alarmEventType;
            _outputArguments[4] = timeStamp;
            _outputArguments[5] = serviceError;

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
           "aXNjb25uZWN0AQEsAQAvAQEsASwBAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBLQEALgBELQEAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQEuAQAuAEQuAQAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEAAQMAAAAATQAAAElk" +
           "ZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEg" +
           "ZGV2aWNlIGluc3RhbmNlAC4ARAABAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lv" +
           "bkNvdW50ZXIBAQEBAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBu" +
           "dW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1v" +
           "ZGlmaWVkAC4ARAEBAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAQIB" +
           "AwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4A" +
           "RAIBAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBAwEDAAAAABgAAABNb2RlbCBu" +
           "YW1lIG9mIHRoZSBkZXZpY2UALgBEAwEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmlj" +
           "ZU1hbnVhbAEBBAEDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3Ig" +
           "YSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEBAEAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQEFAQMAAAAAJAAAAE92ZXJh" +
           "bGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAEQFAQAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBBgEDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "c29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAEQGAQAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBBwEDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "aGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEQHAQAAAAz/////AQH/////AAAAAA==";
        #endregion
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
           "AAAARGlzY29ubmVjdAEBJQQALwEBLAElBAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBASYEAC4ARCYEAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBJwQALgBEJwQAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBASgEAC8BASgEKAQAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEpBAAuAEQpBAAAlgYAAAABACoBASYA" +
           "AAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFQAAAAYAAABMaW5rSWQA" +
           "Bf////8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAAP/////AAAAAAABACoBARwAAAANAAAAT3JkaW5h" +
           "bE51bWJlcgAG/////wAAAAAAAQAqAQEcAAAADQAAAFNJRkNvbm5lY3Rpb24AAf////8AAAAAAAEAKgEB" +
           "GAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBASoEAC4ARCoEAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZv" +
           "ck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBASsEAC8BASsEKwQAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEsBAAuAEQsBAAAlgcAAAABACoBASYA" +
           "AAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJ" +
           "T04ADP////8AAAAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAAAAAAAQAqAQEUAAAABQAAAElO" +
           "REVYAAf/////AAAAAAABACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////AAAAAAABACoBARwAAAAJAAAA" +
           "V3JpdGVEYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBLQQALgBE" +
           "LQQAAJYDAAAAAQAqAQEbAAAACAAAAFJlYWREYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERl" +
           "bGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABAAAABHZXRQdWJsaXNoZWREYXRhAQEu" +
           "BAAvAQEuBC4EAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBLwQALgBELwQA" +
           "AJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgA" +
           "AAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQEwBAAuAEQwBAAAlgYAAAABACoBARcAAAAIAAAAQmxvY2tUYWcA" +
           "DP////8AAAAAAAEAKgEBIQAAAA4AAABBbGFybUV2ZW50RGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBHQAA" +
           "AA4AAABBbGFybUV2ZW50VHlwZQAR/////wAAAAAAAQAqAQEYAAAACQAAAFRpbWVTdGFtcAAN/////wAA" +
           "AAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABT" +
           "ZXJpYWxOdW1iZXIBAfwDAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMs" +
           "IHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE/AMAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEB/QMDAAAAAGkAAABBbiBpbmNyZW1lbnRh" +
           "bCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0" +
           "aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE/QMAAAAG/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADAAAAE1hbnVmYWN0dXJlcgEB/gMDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQg" +
           "bWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBE/gMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAA" +
           "AE1vZGVsAQH/AwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAET/AwAAABX/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEABAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhu" +
           "YW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVh" +
           "bCBmb3IgdGhlIGRldmljZQAuAEQABAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNl" +
           "UmV2aXNpb24BAQEEAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4A" +
           "RAEEAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQECBAMAAAAA" +
           "NQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RAIEAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQEDBAMAAAAA" +
           "LAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARAMEAAAADP//" +
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
           "CgAAAERpc2Nvbm5lY3QBAXEEAC8BASwBcQQAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQFyBAAuAERyBAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQA" +
           "D/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAXMEAC4ARHMEAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQF0BAAvAQF0BHQEAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBdQQALgBEdQQAAJYEAAAAAQAqAQEm" +
           "AAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAAQWRkcmVz" +
           "cwAP/////wAAAAAAAQAqAQEcAAAADQAAAE9yZGluYWxOdW1iZXIABv////8AAAAAAAEAKgEBGAAAAAkA" +
           "AABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAXYEAC4ARHYEAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRD" +
           "YWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAXcEAC8BAXcEdwQAAAEB/////wIA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF4BAAuAER4BAAAlgcAAAABACoBASYAAAAXAAAA" +
           "Q29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP//" +
           "//8AAAAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAf/" +
           "////AAAAAAABACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////AAAAAAABACoBARwAAAAJAAAAV3JpdGVE" +
           "YXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBeQQALgBEeQQAAJYD" +
           "AAAAAQAqAQEbAAAACAAAAFJlYWREYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9y" +
           "TmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABAAAABHZXRQdWJsaXNoZWREYXRhAQF6BAAvAQF6" +
           "BHoEAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBewQALgBEewQAAJYCAAAA" +
           "AQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAA" +
           "U2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQF8BAAuAER8BAAAlgYAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8A" +
           "AAAAAAEAKgEBIQAAAA4AAABBbGFybUV2ZW50RGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBHQAAAA4AAABB" +
           "bGFybUV2ZW50VHlwZQAR/////wAAAAAAAQAqAQEYAAAACQAAAFRpbWVTdGFtcAAN/////wAAAAAAAQAq" +
           "AQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJy" +
           "b3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxO" +
           "dW1iZXIBAUgEAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhp" +
           "biBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBESAQAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBSQQDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3Vu" +
           "dGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRo" +
           "ZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBESQQAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAE1hbnVmYWN0dXJlcgEBSgQDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZh" +
           "Y3R1cmVkIHRoZSBkZXZpY2UALgBESgQAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVs" +
           "AQFLBAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAERLBAAAABX/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQFMBAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGlu" +
           "IHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3Ig" +
           "dGhlIGRldmljZQAuAERMBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNp" +
           "b24BAU0EAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARE0EAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQFOBAMAAAAANQAAAFJl" +
           "dmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARE4EAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQFPBAMAAAAALAAAAFJl" +
           "dmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARE8EAAAADP////8BAf//" +
           "//8AAAAA";
        #endregion
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
           "AAEACgAAAERpc2Nvbm5lY3QBAb0EAC8BASwBvQQAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQG+BAAuAES+BAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAb8EAC4ARL8EAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQHABAAvAQHABMAE" +
           "AAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBwQQALgBEwQQAAJYDAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAAQWRk" +
           "cmVzcwAD/////wAAAAAAAQAqAQEdAAAADgAAAE1hbnVmYWN0dXJlcklkAAX/////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHCBAAuAETCBAAA" +
           "lgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAcMEAC8BAcMEwwQAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQHEBAAuAETEBAAAlgUAAAABACoBASYAAAAXAAAAQ29tbXVuaWNh" +
           "dGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEA" +
           "KgEBEwAAAAQAAABTTE9UAAP/////AAAAAAABACoBARQAAAAFAAAASU5ERVgAA/////8AAAAAAAEAKgEB" +
           "FgAAAAcAAABSRVFVRVNUAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQHFBAAuAETFBAAAlgMAAAABACoBARQAAAAFAAAAUkVQTFkAD///" +
           "//8AAAAAAAEAKgEBHQAAAA4AAABSRVNQT05TRV9DT0RFUwAP/////wAAAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAA" +
           "AFNlcmlhbE51bWJlcgEBlAQDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmll" +
           "cywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAESUBAAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQGVBAMAAAAAaQAAAEFuIGluY3JlbWVu" +
           "dGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3" +
           "aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAESVBAAAAAb/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGWBAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhh" +
           "dCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESWBAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAF" +
           "AAAATW9kZWwBAZcEAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARJcEAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAZgEAwAAAABaAAAAQWRkcmVzcyAocGF0" +
           "aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFu" +
           "dWFsIGZvciB0aGUgZGV2aWNlAC4ARJgEAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZp" +
           "Y2VSZXZpc2lvbgEBmQQDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UA" +
           "LgBEmQQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAZoEAwAA" +
           "AAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBEmgQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAZsEAwAA" +
           "AAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEmwQAAAAM" +
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
           "AAEACgAAAERpc2Nvbm5lY3QBAQYFAC8BASwBBgUAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQEHBQAuAEQHBQAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAQgFAC4ARAgFAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQEJBQAvAQEJBQkF" +
           "AAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBCgUALgBECgUAAJYEAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAARE5T" +
           "TkFNRQAM/////wAAAAAAAQAqAQEXAAAACAAAAERldmljZUlEAAX/////AAAAAAABACoBARcAAAAIAAAA" +
           "VmVuZG9ySUQABf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAQsFAC4ARAsFAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAgAAABUcmFuc2ZlcgEBDAUA" +
           "LwEBDAUMBQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQ0FAC4ARA0FAACW" +
           "BwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAA" +
           "CQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQETAAAABAAAAFNMT1QABf////8AAAAAAAEAKgEBFgAA" +
           "AAcAAABTVUJTTE9UAAX/////AAAAAAABACoBARQAAAAFAAAASU5ERVgABf////8AAAAAAAEAKgEBEgAA" +
           "AAMAAABBUEkAB/////8AAAAAAAEAKgEBFgAAAAcAAABSRVFVRVNUAA//////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEOBQAuAEQOBQAAlgMA" +
           "AAABACoBARQAAAAFAAAAUkVQTFkAD/////8AAAAAAAEAKgEBHQAAAA4AAABSRVNQT05TRV9DT0RFUwAP" +
           "/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB3QQDAAAAAE0AAABJZGVudGlmaWVy" +
           "IHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBp" +
           "bnN0YW5jZQAuAETdBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVy" +
           "AQHeBAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9m" +
           "IHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAu" +
           "AETeBAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQHfBAMAAAAAMAAA" +
           "AE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAETfBAAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAeAEAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0" +
           "aGUgZGV2aWNlAC4AROAEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwB" +
           "AeEEAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwg" +
           "V2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AROEEAAAADP////8BAf//" +
           "//8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB4gQDAAAAACQAAABPdmVyYWxsIHJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE4gQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AFNvZnR3YXJlUmV2aXNpb24BAeMEAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJl" +
           "L2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE4wQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AEhhcmR3YXJlUmV2aXNpb24BAeQEAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJl" +
           "IG9mIHRoZSBkZXZpY2UALgBE5AQAAAAM/////wEB/////wAAAAA=";
        #endregion
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
           "AAAARGlzY29ubmVjdAEBTwUALwEBLAFPBQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAVAFAC4ARFAFAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBUQUALgBEUQUAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAVIFAC8BAVIFUgUAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFTBQAuAERTBQAAlgIAAAABACoBASYA" +
           "AAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGgAAAAsAAABMb25nQWRk" +
           "cmVzcwAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBVAUALgBEVAUAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQFVBQAvAQFV" +
           "BVUFAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBVgUALgBEVgUAAJYDAAAA" +
           "AQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAA" +
           "Q29tbWFuZAAF/////wAAAAAAAQAqAQEWAAAABwAAAFJlcXVlc3QAD/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVcFAC4ARFcFAACWAgAA" +
           "AAEAKgEBFAAAAAUAAABSZXBseQAP/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAEdldFB1Ymxpc2hlZERh" +
           "dGEBAVgFAC8BAVgFWAUAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFZBQAu" +
           "AERZBQAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVoFAC4A" +
           "RFoFAACWBAAAAAEAKgEBFgAAAAcAAABDb21tYW5kAAX/////AAAAAAABACoBARQAAAAFAAAAUmVwbHkA" +
           "D/////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2" +
           "aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABT" +
           "ZXJpYWxOdW1iZXIBASYFAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMs" +
           "IHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEJgUAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBJwUDAAAAAGkAAABBbiBpbmNyZW1lbnRh" +
           "bCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0" +
           "aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEJwUAAAAG/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBKAUDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQg" +
           "bWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEKAUAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAA" +
           "AE1vZGVsAQEpBQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQpBQAAABX/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEqBQMAAAAAWgAAAEFkZHJlc3MgKHBhdGhu" +
           "YW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVh" +
           "bCBmb3IgdGhlIGRldmljZQAuAEQqBQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNl" +
           "UmV2aXNpb24BASsFAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4A" +
           "RCsFAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQEsBQMAAAAA" +
           "NQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RCwFAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQEtBQMAAAAA" +
           "LAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARC0FAAAADP//" +
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
           "BGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQFJCAAvAQEsAUkIAAABAf////8CAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBSggALgBESggAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25S" +
           "ZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQFLCAAuAERLCAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBTAgA" +
           "LwEBTAhMCAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAU0IAC4ARE0IAACW" +
           "AwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAA" +
           "CQAAAElQQWRkcmVzcwAP/////wAAAAAAAQAqAQEaAAAACwAAAENvbm5lY3RUeXBlAAf/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFOCAAu" +
           "AEROCAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAU8IAC8BAU8ITwgAAAEB/////wIAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQCAAuAERQCAAAlggAAAABACoBASYAAAAXAAAAQ29t" +
           "bXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8A" +
           "AAAAAAEAKgEBFAAAAAUAAABBcHBJRAAF/////wAAAAAAAQAqAQEXAAAACAAAAE9iamVjdElEAAX/////" +
           "AAAAAAABACoBARsAAAAMAAAAQXR0ck9yTWV0aElEAAX/////AAAAAAABACoBARgAAAAJAAAAU1VCX0lO" +
           "REVYAAf/////AAAAAAABACoBARwAAAAJAAAAV3JpdGVEYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEYAAAA" +
           "CQAAAFJlcXVlc3RJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBUQgALgBEUQgAAJYCAAAAAQAqAQEbAAAACAAAAFJlYWREYXRhAAMB" +
           "AAAAAQAAAAAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAEdldFB1Ymxpc2hlZERhdGEBAVIIAC8BAVIIUggAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFTCAAuAERTCAAAlgEAAAABACoBASYA" +
           "AAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVQIAC4ARFQIAACWBgAAAAEAKgEBFAAA" +
           "AAUAAABBcHBJRAAF/////wAAAAAAAQAqAQEXAAAACAAAAE9iamVjdElEAAX/////AAAAAAABACoBASEA" +
           "AAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAABAAAAAAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVudFR5" +
           "cGUABf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEBGwAAAAwAAABT" +
           "ZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwA" +
           "AABTZXJpYWxOdW1iZXIBASAIAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZp" +
           "ZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEIAgAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBIQgDAAAAAGkAAABBbiBpbmNyZW1l" +
           "bnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEg" +
           "d2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEIQgAAAAG/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBIggDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRo" +
           "YXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEIggAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "BQAAAE1vZGVsAQEjCAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQjCAAAABX/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEkCAMAAAAAWgAAAEFkZHJlc3MgKHBh" +
           "dGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1h" +
           "bnVhbCBmb3IgdGhlIGRldmljZQAuAEQkCAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2" +
           "aWNlUmV2aXNpb24BASUIAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNl" +
           "AC4ARCUIAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQEmCAMA" +
           "AAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNl" +
           "AC4ARCYIAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQEnCAMA" +
           "AAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARCcIAAAA" +
           "DP////8BAf////8AAAAA";
        #endregion
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
           "AQAKAAAARGlzY29ubmVjdAEBlQgALwEBLAGVCAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAZYIAC4ARJYIAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25J" +
           "ZAAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBlwgALgBElwgAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBAZgIAC8BAZgImAgA" +
           "AAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGZCAAuAESZCAAAlgIAAAABACoB" +
           "ASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABBZGRy" +
           "ZXNzAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQGaCAAuAESaCAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAZsIAC8BAZsI" +
           "mwgAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGcCAAuAEScCAAAlgUAAAAB" +
           "ACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFQAAAAYAAABI" +
           "ZWFkZXIADP////8AAAAAAAEAKgEBGgAAAAsAAABSZXF1ZXN0RGF0YQAP/////wAAAAAAAQAqAQElAAAA" +
           "EAAAAFJlcXVlc3REYXRhVHlwZXMBAQIIAQAAAAEAAAAAAAAAAAEAKgEBJgAAABEAAABSZXNwb25zZURh" +
           "dGFUeXBlcwEBAggBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBnQgALgBEnQgAAJYDAAAAAQAqAQEbAAAADAAAAFJlc3BvbnNlRGF0" +
           "YQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NPREVTAA//////AAAAAAABACoBARsAAAAM" +
           "AAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAA" +
           "AgAMAAAAU2VyaWFsTnVtYmVyAQFsCAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVu" +
           "dGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARGwIAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAW0IAwAAAABpAAAAQW4gaW5j" +
           "cmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBk" +
           "YXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARG0IAAAABv////8BAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAW4IAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFu" +
           "eSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARG4IAAAAFf////8BAf////8AAAAANWCJCgIA" +
           "AAACAAUAAABNb2RlbAEBbwgDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEbwgAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBcAgDAAAAAFoAAABBZGRyZXNz" +
           "IChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNl" +
           "ciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEcAgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAA" +
           "AERldmljZVJldmlzaW9uAQFxCAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRl" +
           "dmljZQAuAERxCAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEB" +
           "cggDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRl" +
           "dmljZQAuAERyCAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB" +
           "cwgDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERz" +
           "CAAAAAz/////AQH/////AAAAAA==";
        #endregion
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
