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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAVAAAARm91bmRhdGlvbl9IMUluc3RhbmNl" +
           "AQFbBQEBWwVbBQAA/////wAAAAA=";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAWAAAARm91bmRhdGlvbl9IU0VJbnN0YW5j" +
           "ZQEBXAUBAVwFXAUAAP////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQATAAAAUHJvZmlidXNfRFBJbnN0YW5jZQEB" +
           "XQUBAV0FXQUAAP////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQATAAAAUHJvZmlidXNfUEFJbnN0YW5jZQEB" +
           "XgUBAV4FXgUAAP////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQATAAAAUHJvZmluZXRfSU9JbnN0YW5jZQEB" +
           "XwUBAV8FXwUAAP////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAMAAAASEFSVEluc3RhbmNlAQFgBQEBYAVg" +
           "BQAA/////wAAAAA=";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAXAAAASVNBMTAwX1dpcmVsZXNzSW5zdGFu" +
           "Y2UBAWEFAQFhBWEFAAD/////AAAAAA==";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAXAAAAR2VuZXJpY1Byb3RvY29sSW5zdGFu" +
           "Y2UBAWIFAQFiBWIFAAD/////AQAAABVgiQoCAAAAAQASAAAAUHJvdG9jb2xJZGVudGlmaWVyAQFjBQAu" +
           "AERjBQAAAAz/////AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAlAAAAQ29ubmVjdGlvblBvaW50X0ZvdW5k" +
           "YXRpb25fSDFJbnN0YW5jZQEBZAUBAWQFZAUAAP////8EAAAAJGCACgEAAAACAA4AAABOZXR3b3JrQWRk" +
           "cmVzcwEBewUDAAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4A" +
           "LwEC7QN7BQAA/////wAAAAAVYIkKAgAAAAEABwAAAEFkZHJlc3MBAY0FAC4ARI0FAAAAA/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAA0AAABPcmRpbmFsTnVtYmVyAQGOBQAuAESOBQAAAAb/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQANAAAAU0lGQ29ubmVjdGlvbgEBjwUALgBEjwUAAAAB/////wEB/////wAAAAA=";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAmAAAAQ29ubmVjdGlvblBvaW50X0ZvdW5k" +
           "YXRpb25fSFNFSW5zdGFuY2UBAZAFAQGQBZAFAAD/////AwAAACRggAoBAAAAAgAOAAAATmV0d29ya0Fk" +
           "ZHJlc3MBAacFAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsu" +
           "AC8BAu0DpwUAAP////8AAAAAF2CJCgIAAAABAAcAAABBZGRyZXNzAQG5BQAuAES5BQAAAAMBAAAAAQAA" +
           "ABAAAAABAf////8AAAAAFWCJCgIAAAABAA0AAABPcmRpbmFsTnVtYmVyAQG6BQAuAES6BQAAAAb/////" +
           "AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAjAAAAQ29ubmVjdGlvblBvaW50X1Byb2Zp" +
           "YnVzX0RQSW5zdGFuY2UBAbsFAQG7BbsFAAD/////AgAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJl" +
           "c3MBAdIFAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8B" +
           "Au0D0gUAAP////8AAAAAFWCJCgIAAAABAAcAAABBZGRyZXNzAQHkBQAuAETkBQAAAAP/////AQH/////" +
           "AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAjAAAAQ29ubmVjdGlvblBvaW50X1Byb2Zp" +
           "bmV0X0lPSW5zdGFuY2UBAeUFAQHlBeUFAAD/////BQAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJl" +
           "c3MBAfwFAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8B" +
           "Au0D/AUAAP////8AAAAAF2CJCgIAAAABAAMAAABNQUMBAQ4GAC4ARA4GAAAAAwEAAAABAAAAEAAAAAEB" +
           "/////wAAAAAXYIkKAgAAAAEABAAAAElQdjQBAQ8GAC4ARA8GAAAAAwEAAAABAAAABAAAAAEB/////wAA" +
           "AAAVYIkKAgAAAAEABwAAAEROU05BTUUBARAGAC4ARBAGAAAADP////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAUAAABWQUxJRAEBEQYALgBEEQYAAAAB/////wEB/////wAAAAA=";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAgAAAAQ29ubmVjdGlvblBvaW50X0hBUlRf" +
           "VFA1SW5zdGFuY2UBARIGAQESBhIGAAD/////BwAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJlc3MB" +
           "ASkGAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8BAu0D" +
           "KQYAAP////8AAAAAF2CJCgIAAAABAAcAAABEZXZBZGRyAQE7BgAuAEQ7BgAAAAMBAAAAAQAAAAUAAAAB" +
           "Af////8AAAAAFWCJCgIAAAABAAYAAABEZXZNZmcBATwGAC4ARDwGAAAABf////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAAcAAABEZXZUeXBlAQE9BgAuAEQ9BgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "RGV2UmV2AQE+BgAuAEQ+BgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAARGV2VGFnAQE/BgAu" +
           "AEQ/BgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAUAGAC4AREAGAAAA" +
           "A/////8BAf////8AAAAA";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAgAAAAQ29ubmVjdGlvblBvaW50X0hBUlRf" +
           "VFA2SW5zdGFuY2UBAUEGAQFBBkEGAAD/////BwAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJlc3MB" +
           "AVgGAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8BAu0D" +
           "WAYAAP////8AAAAAF2CJCgIAAAABAAcAAABEZXZBZGRyAQFqBgAuAERqBgAAAAMBAAAAAQAAAAUAAAAB" +
           "Af////8AAAAAFWCJCgIAAAABAAYAAABEZXZNZmcBAWsGAC4ARGsGAAAABf////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAAcAAABEZXZUeXBlAQFsBgAuAERsBgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "RGV2UmV2AQFtBgAuAERtBgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAARGV2VGFnAQFuBgAu" +
           "AERuBgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAW8GAC4ARG8GAAAA" +
           "A/////8BAf////8AAAAA";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAgAAAAQ29ubmVjdGlvblBvaW50X0hBUlRf" +
           "VFA3SW5zdGFuY2UBAXAGAQFwBnAGAAD/////BwAAACRggAoBAAAAAgAOAAAATmV0d29ya0FkZHJlc3MB" +
           "AYcGAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdvcmsuAC8BAu0D" +
           "hwYAAP////8AAAAAF2CJCgIAAAABAAcAAABEZXZBZGRyAQGZBgAuAESZBgAAAAMBAAAAAQAAAAUAAAAB" +
           "Af////8AAAAAFWCJCgIAAAABAAYAAABEZXZNZmcBAZoGAC4ARJoGAAAABf////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAAcAAABEZXZUeXBlAQGbBgAuAESbBgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "RGV2UmV2AQGcBgAuAEScBgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAGAAAARGV2VGFnAQGdBgAu" +
           "AESdBgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2UG9sbEFkZHIBAZ4GAC4ARJ4GAAAA" +
           "A/////8BAf////8AAAAA";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAnAAAAQ29ubmVjdGlvblBvaW50X0lTQTEw" +
           "MF9XaXJlbGVzc0luc3RhbmNlAQGfBgEBnwafBgAA/////wcAAAAkYIAKAQAAAAIADgAAAE5ldHdvcmtB" +
           "ZGRyZXNzAQG2BgMAAAAAKgAAAFRoZSBhZGRyZXNzIG9mIHRoZSBkZXZpY2Ugb24gdGhpcyBuZXR3b3Jr" +
           "LgAvAQLtA7YGAAD/////AAAAABVgiQoCAAAAAQAJAAAASVBBZGRyZXNzAQHIBgAuAETIBgAAAA//////" +
           "AQH/////AAAAABVgiQoCAAAAAQAGAAAARGV2TWZnAQHJBgAuAETJBgAAAAf/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAARGV2VHlwZQEBygYALgBEygYAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEABgAA" +
           "AERldlJldgEBywYALgBEywYAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAERldlRhZwEBzAYA" +
           "LgBEzAYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldlBvbGxBZGRyAQHNBgAuAETNBgAA" +
           "AAP/////AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAeAAAAR2VuZXJpY0Nvbm5lY3Rpb25Qb2lu" +
           "dEluc3RhbmNlAQHOBgEBzgbOBgAA/////wMAAAAkYIAKAQAAAAIADgAAAE5ldHdvcmtBZGRyZXNzAQHl" +
           "BgMAAAAAKgAAAFRoZSBhZGRyZXNzIG9mIHRoZSBkZXZpY2Ugb24gdGhpcyBuZXR3b3JrLgAvAQLtA+UG" +
           "AAD/////AAAAABVgiQoCAAAAAQAHAAAAQWRkcmVzcwEB9wYALgBE9wYAAAAP/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEgAAAFByb3RvY29sSWRlbnRpZmllcgEB+AYALgBE+AYAAAAM/////wEB/////wAAAAA=";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAfAAAAQ29tbXVuaWNhdGlvblNlcnZlclR5" +
           "cGVJbnN0YW5jZQEBCwABAQsACwAAAP////8LAAAAJGCACgEAAAACAAwAAABQYXJhbWV0ZXJTZXQBAQwA" +
           "AwAAAAAXAAAARmxhdCBsaXN0IG9mIFBhcmFtZXRlcnMALwA6DAAAAP////8AAAAAJGCACgEAAAACAAkA" +
           "AABNZXRob2RTZXQBAQ4AAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6DgAAAP////8EAAAA" +
           "BGGCCgQAAAABAAoAAABJbml0aWFsaXplAQFLAAAvAQFLAEsAAAABAf////8BAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAUwAAC4AREwAAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IA" +
           "G/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAUAAABSZXNldAEBTQAA" +
           "LwEBTQBNAAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFOAAAuAEROAAAA" +
           "lgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAMAAAAQWRkQ29tcG9uZW50AQFPAAAvAQFPAE8AAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBUAAALgBEUAAAAJYDAAAAAQAqAQEdAAAADgAAAE1vZHVs" +
           "ZVR5cGVOYW1lAAz/////AAAAAAABACoBARsAAAAMAAAASW5zdGFuY2VOYW1lAAz/////AAAAAAABACoB" +
           "ARwAAAANAAAASW5zdGFuY2VMYWJlbAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBUQAALgBEUQAAAJYCAAAAAQAqAQEdAAAADgAAAElu" +
           "c3RhbmNlTm9kZUlkABH/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAPAAAAUmVtb3ZlQ29tcG9uZW50AQFSAAAv" +
           "AQFSAFIAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBUwAALgBEUwAAAJYB" +
           "AAAAAQAqAQEbAAAADAAAAE1vZHVsZU5vZGVJZAAR/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVAAALgBEVAAAAJYBAAAAAQAqAQEbAAAA" +
           "DAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAA" +
           "AAIADAAAAFNlcmlhbE51bWJlcgEBIgADAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRl" +
           "bnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQiAAAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQEjAAMAAAAAaQAAAEFuIGlu" +
           "Y3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMg" +
           "ZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQjAAAAAAb/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQEkAAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBh" +
           "bnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQkAAAAABX/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAFAAAATW9kZWwBASUAAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARCUAAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBASYAAwAAAABaAAAAQWRkcmVz" +
           "cyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVz" +
           "ZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARCYAAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4A" +
           "AABEZXZpY2VSZXZpc2lvbgEBJwADAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBk" +
           "ZXZpY2UALgBEJwAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24B" +
           "ASgAAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBk" +
           "ZXZpY2UALgBEKAAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24B" +
           "ASkAAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE" +
           "KQAAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACgAAAFN1YkRldmljZXMBAVUAAC8APVUAAAD/////" +
           "AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAlAAAAU2VydmVyQ29tbXVuaWNhdGlvbkRl" +
           "dmljZVR5cGVJbnN0YW5jZQEBXQABAV0AXQAAAP////8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQB" +
           "AWAAAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6YAAAAP////8EAAAABGGCCgQAAAABAAQA" +
           "AABTY2FuAQGdAAAvAQGdAJ0AAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AZ4AAC4ARJ4AAACWAgAAAAEAKgEBIQAAABIAAABUb3BvbG9neVNjYW5SZXN1bHQAEP////8AAAAAAAEA" +
           "KgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "BGGCCgQAAAABAAkAAABSZXNldFNjYW4BAZ8AAC8BAZ8AnwAAAAEB/////wEAAAAXYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBoAAALgBEoAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEADAAAAEFkZENvbXBvbmVu" +
           "dAEBpAAALwEBpACkAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaUAAC4A" +
           "RKUAAACWAwAAAAEAKgEBHQAAAA4AAABNb2R1bGVUeXBlTmFtZQAM/////wAAAAAAAQAqAQEbAAAADAAA" +
           "AEluc3RhbmNlTmFtZQAM/////wAAAAAAAQAqAQEcAAAADQAAAEluc3RhbmNlTGFiZWwADP////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaYA" +
           "AC4ARKYAAACWAgAAAAEAKgEBHQAAAA4AAABJbnN0YW5jZU5vZGVJZAAR/////wAAAAAAAQAqAQEbAAAA" +
           "DAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAEADwAAAFJlbW92ZUNvbXBvbmVudAEBpwAALwEBpwCnAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAagAAC4ARKgAAACWAQAAAAEAKgEBGwAAAAwAAABNb2R1bGVOb2RlSWQAEf//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAakAAC4ARKkAAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAXQAAwAAAABNAAAA" +
           "SWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwg" +
           "YSBkZXZpY2UgaW5zdGFuY2UALgBEdAAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlz" +
           "aW9uQ291bnRlcgEBdQADAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhl" +
           "IG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4g" +
           "bW9kaWZpZWQALgBEdQAAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEB" +
           "dgADAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UA" +
           "LgBEdgAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQF3AAMAAAAAGAAAAE1vZGVs" +
           "IG5hbWUgb2YgdGhlIGRldmljZQAuAER3AAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2" +
           "aWNlTWFudWFsAQF4AAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBv" +
           "ciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAER4AAAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAXkAAwAAAAAkAAAAT3Zl" +
           "cmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARHkAAAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQF6AAMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARHoAAAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQF7AAMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARHsAAAAADP////8BAf////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQApAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SDFEZXZpY2VUeXBlSW5zdGFuY2UBAUQBAQFEAUQBAAD/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQFHAQMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcBAAD/////AQAAAARhggoEAAAA" +
           "AQAKAAAAU2V0QWRkcmVzcwEBjgEALwEBjgGOAQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAY8BAC4ARI8BAACWBgAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEA" +
           "KgEBFQAAAAYAAABMaW5rSWQABf////8AAAAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAA" +
           "AAABACoBARkAAAAKAAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAqAQEXAAAACAAAAE5ld1BEVGFnAAz/" +
           "////AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGQAQAuAESQAQAAlgIAAAABACoBAR8A" +
           "AAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJl" +
           "cgEBWwEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEg" +
           "bWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERbAQAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFcAQMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIg" +
           "aW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERl" +
           "dmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERcAQAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAA" +
           "TWFudWZhY3R1cmVyAQFdAQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVy" +
           "ZWQgdGhlIGRldmljZQAuAERdAQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAV4B" +
           "AwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARF4BAAAAFf////8BAf////8AAAAANWCJ" +
           "CgIAAAACAAwAAABEZXZpY2VNYW51YWwBAV8BAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhl" +
           "IGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUg" +
           "ZGV2aWNlAC4ARF8BAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB" +
           "YAEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEYAEAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAWEBAwAAAAA1AAAAUmV2aXNp" +
           "b24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEYQEAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAWIBAwAAAAAsAAAAUmV2aXNp" +
           "b24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEYgEAAAAM/////wEB/////wAA" +
           "AAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92aWRlcgEBkQEALwEB5QORAQAA/////wkAAAAkYIAKAQAA" +
           "AAIACQAAAE1ldGhvZFNldAEBlAEDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADqUAQAA////" +
           "/wMAAAAEYYIKBAAAAAEACgAAAERpc2Nvbm5lY3QBAbgBAC8BASwBuAEAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQG5AQAuAES5AQAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNh" +
           "dGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAboBAC4ARLoBAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJy" +
           "b3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0" +
           "AQG7AQAvAQEoBLsBAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvAEALgBE" +
           "vAEAAJYGAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARUAAAAGAAAATGlua0lkAAX/////AAAAAAABACoBARYAAAAHAAAAQWRkcmVzcwAD/////wAAAAAAAQAq" +
           "AQEcAAAADQAAAE9yZGluYWxOdW1iZXIABv////8AAAAAAAEAKgEBHAAAAA0AAABTSUZDb25uZWN0aW9u" +
           "AAH/////AAAAAAABACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG9AQAuAES9AQAAlgIAAAABACoB" +
           "AR8AAAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJv" +
           "cgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVy" +
           "AQG+AQAvAQErBL4BAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvwEALgBE" +
           "vwEAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAA" +
           "AAEAKgEBFAAAAAUAAABJTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAA" +
           "AAAAAQAqAQEcAAAACQAAAFdyaXRlRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNl" +
           "SWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAcABAC4ARMABAACWAwAAAAEAKgEBGwAAAAgAAABSZWFkRGF0YQADAQAAAAEAAAAAAAAA" +
           "AAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2Vy" +
           "aWFsTnVtYmVyAQGmAQMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3" +
           "aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARKYBAAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAacBAwAAAABpAAAAQW4gaW5jcmVtZW50YWwg" +
           "Y291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhp" +
           "biB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARKcBAAAABv////8BAf////8AAAAANWCJCgIA" +
           "AAACAAwAAABNYW51ZmFjdHVyZXIBAagBAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1h" +
           "bnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARKgBAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABN" +
           "b2RlbAEBqQEDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEqQEAAAAV/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBqgEDAAAAAFoAAABBZGRyZXNzIChwYXRobmFt" +
           "ZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwg" +
           "Zm9yIHRoZSBkZXZpY2UALgBEqgEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJl" +
           "dmlzaW9uAQGrAQMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAESr" +
           "AQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBrAEDAAAAADUA" +
           "AABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAESs" +
           "AQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBrQEDAAAAACwA" +
           "AABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEStAQAAAAz/////" +
           "AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SFNFRGV2aWNlVHlwZUluc3RhbmNlAQHEAQEBxAHEAQAA/////woAAAAkYIAKAQAAAAIACQAAAE1ldGhv" +
           "ZFNldAEBxwEDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADrHAQAA/////wEAAAAEYYIKBAAA" +
           "AAEACgAAAFNldEFkZHJlc3MBAQ4CAC8BAQ4CDgIAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQEPAgAuAEQPAgAAlgMAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAAB" +
           "ACoBARcAAAAIAAAATmV3UERUYWcADP////8AAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "ARACAC4ARBACAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoB" +
           "ARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVg" +
           "iQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQHbAQMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVs" +
           "eSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARNsB" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAdwBAwAAAABpAAAA" +
           "QW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0" +
           "YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARNwBAAAABv////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAd0BAwAAAAAwAAAATmFtZSBvZiB0aGUg" +
           "Y29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARN0BAAAAFf////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAUAAABNb2RlbAEB3gEDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBE" +
           "3gEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEB3wEDAAAAAFoAAABB" +
           "ZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykg" +
           "b2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBE3wEAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADgAAAERldmljZVJldmlzaW9uAQHgAQMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIGRldmljZQAuAETgAQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZp" +
           "c2lvbgEB4QEDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2Yg" +
           "dGhlIGRldmljZQAuAEThAQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZp" +
           "c2lvbgEB4gEDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAETiAQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQERAgAv" +
           "AQExBBECAAD/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQEUAgMAAAAAFAAAAEZsYXQgbGlz" +
           "dCBvZiBNZXRob2RzAC8AOhQCAAD/////AwAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEBOAIALwEB" +
           "LAE4AgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATkCAC4ARDkCAACWAQAA" +
           "AAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOgIALgBEOgIAAJYBAAAA" +
           "AQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEABwAAAENvbm5lY3QBATsCAC8BAXQEOwIAAAEB/////wIAAAAXYKkKAgAAAAAADgAA" +
           "AElucHV0QXJndW1lbnRzAQE8AgAuAEQ8AgAAlgQAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJl" +
           "bGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAA//////AAAAAAABACoBARwAAAAN" +
           "AAAAT3JkaW5hbE51bWJlcgAG/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBPQIA" +
           "LgBEPQIAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAA" +
           "AAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQA" +
           "AAABAAgAAABUcmFuc2ZlcgEBPgIALwEBdwQ+AgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAT8CAC4ARD8CAACWBwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25J" +
           "ZAAP/////wAAAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEXAAAACAAAAEJs" +
           "b2NrVGFnAAz/////AAAAAAABACoBARQAAAAFAAAASU5ERVgAB/////8AAAAAAAEAKgEBGAAAAAkAAABT" +
           "VUJfSU5ERVgAB/////8AAAAAAAEAKgEBHAAAAAkAAABXcml0ZURhdGEAAwEAAAABAAAAAAAAAAABACoB" +
           "ARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFAAgAuAERAAgAAlgMAAAABACoBARsAAAAIAAAAUmVhZERh" +
           "dGEAAwEAAAABAAAAAAAAAAABACoBAR8AAAAQAAAARGVsYXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAq" +
           "AQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1" +
           "YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBJgIDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVl" +
           "bHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQm" +
           "AgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQEnAgMAAAAAaQAA" +
           "AEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBz" +
           "dGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQnAgAAAAb/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQEoAgMAAAAAMAAAAE5hbWUgb2YgdGhl" +
           "IGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQoAgAAABX/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAFAAAATW9kZWwBASkCAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RCkCAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBASoCAwAAAABaAAAA" +
           "QWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3Mp" +
           "IG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARCoCAAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAACAA4AAABEZXZpY2VSZXZpc2lvbgEBKwIDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBkZXZpY2UALgBEKwIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2" +
           "aXNpb24BASwCAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9m" +
           "IHRoZSBkZXZpY2UALgBELAIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2" +
           "aXNpb24BAS0CAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZp" +
           "Y2UALgBELQIAAAAM/////wEB/////wAAAAA=";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJQlVTRGV2aWNlVHlwZUluc3RhbmNlAQFEAgEBRAJEAgAA/////woAAAAkYIAKAQAAAAIACQAAAE1l" +
           "dGhvZFNldAEBRwIDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpHAgAA/////wEAAAAEYYIK" +
           "BAAAAAEACgAAAFNldEFkZHJlc3MBAY4CAC8BAY4CjgIAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQGPAgAuAESPAgAAlgIAAAABACoBARkAAAAKAAAAT2xkQWRkcmVzcwAD/////wAA" +
           "AAAAAQAqAQEZAAAACgAAAE5ld0FkZHJlc3MAA/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZACAC4ARJACAACWAQAAAAEAKgEBGwAAAAwA" +
           "AABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAAC" +
           "AAwAAABTZXJpYWxOdW1iZXIBAVsCAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50" +
           "aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEWwIAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBXAIDAAAAAGkAAABBbiBpbmNy" +
           "ZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRh" +
           "dGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEXAIAAAAG/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBXQIDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55" +
           "IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEXQIAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIABQAAAE1vZGVsAQFeAgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEReAgAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQFfAgMAAAAAWgAAAEFkZHJlc3Mg" +
           "KHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2Vy" +
           "IG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAERfAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAA" +
           "RGV2aWNlUmV2aXNpb24BAWACAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2" +
           "aWNlAC4ARGACAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQFh" +
           "AgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARGECAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQFi" +
           "AgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARGIC" +
           "AAAADP////8BAf////8AAAAABGCACgEAAAABAA8AAABTZXJ2aWNlUHJvdmlkZXIBAZECAC8BAX0EkQIA" +
           "AP////8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAZQCAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1l" +
           "dGhvZHMALwA6lAIAAP////8DAAAABGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQG4AgAvAQEsAbgCAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuQIALgBEuQIAAJYBAAAAAQAqAQEm" +
           "AAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG6AgAuAES6AgAAlgEAAAABACoBARsA" +
           "AAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAHAAAAQ29ubmVjdAEBuwIALwEBwAS7AgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAbwCAC4ARLwCAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25J" +
           "ZAAP/////wAAAAAAAQAqAQEWAAAABwAAAEFkZHJlc3MAA/////8AAAAAAAEAKgEBHQAAAA4AAABNYW51" +
           "ZmFjdHVyZXJJZAAF/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBvQIALgBEvQIAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQG+" +
           "AgAvAQHDBL4CAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvwIALgBEvwIA" +
           "AJYFAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgA" +
           "AAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARMAAAAEAAAAU0xPVAAD/////wAAAAAAAQAqAQEU" +
           "AAAABQAAAElOREVYAAP/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBwAIALgBEwAIA" +
           "AJYDAAAAAQAqAQEUAAAABQAAAFJFUExZAA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9OU0VfQ09E" +
           "RVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAaYCAwAAAABNAAAASWRlbnRp" +
           "ZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZp" +
           "Y2UgaW5zdGFuY2UALgBEpgIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291" +
           "bnRlcgEBpwIDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJl" +
           "ciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZp" +
           "ZWQALgBEpwIAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBqAIDAAAA" +
           "ADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEqAIA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQGpAgMAAAAAGAAAAE1vZGVsIG5hbWUg" +
           "b2YgdGhlIGRldmljZQAuAESpAgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFu" +
           "dWFsAQGqAgMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVS" +
           "TCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAESqAgAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAasCAwAAAAAkAAAAT3ZlcmFsbCBy" +
           "ZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARKsCAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "ABAAAABTb2Z0d2FyZVJldmlzaW9uAQGsAgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0" +
           "d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARKwCAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "ABAAAABIYXJkd2FyZVJldmlzaW9uAQGtAgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJk" +
           "d2FyZSBvZiB0aGUgZGV2aWNlAC4ARK0CAAAADP////8BAf////8AAAAA";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJTkVURGV2aWNlVHlwZUluc3RhbmNlAQHBAgEBwQLBAgAA/////woAAAAkYIAKAQAAAAIACQAAAE1l" +
           "dGhvZFNldAEBxAIDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADrEAgAA/////wEAAAAEYYIK" +
           "BAAAAAEACgAAAFNldEFkZHJlc3MBAQsDAC8BAQsDCwMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQEMAwAuAEQMAwAAlgUAAAABACoBARYAAAADAAAATUFDAAMBAAAAAQAAAAYAAAAA" +
           "AQAqAQEVAAAAAgAAAElQAAMBAAAAAQAAAAQAAAAAAQAqAQEWAAAABwAAAEROU05BTUUADP////8AAAAA" +
           "AAEAKgEBHQAAAAoAAABTdWJuZXRNYXNrAAMBAAAAAQAAAAQAAAAAAQAqAQEaAAAABwAAAEdhdGV3YXkA" +
           "AwEAAAABAAAABAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQENAwAuAEQNAwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQHYAgMA" +
           "AAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFj" +
           "dHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARNgCAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8A" +
           "AABSZXZpc2lvbkNvdW50ZXIBAdkCAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0" +
           "aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhh" +
           "cyBiZWVuIG1vZGlmaWVkAC4ARNkCAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFj" +
           "dHVyZXIBAdoCAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUg" +
           "ZGV2aWNlAC4ARNoCAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEB2wIDAAAAABgA" +
           "AABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBE2wIAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAERldmljZU1hbnVhbAEB3AIDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBz" +
           "eXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UA" +
           "LgBE3AIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQHdAgMAAAAA" +
           "JAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAETdAgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEB3gIDAAAAADUAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAETeAgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB3wIDAAAAACwAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAETfAgAAAAz/////AQH/////AAAAAARggAoB" +
           "AAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQEOAwAvAQHGBA4DAAD/////CQAAACRggAoBAAAAAgAJAAAA" +
           "TWV0aG9kU2V0AQERAwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOhEDAAD/////AwAAAARh" +
           "ggoEAAAAAQAKAAAARGlzY29ubmVjdAEBNQMALwEBLAE1AwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBATYDAC4ARDYDAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVs" +
           "YXRpb25JZAAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBNwMALgBENwMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QBATgDAC8B" +
           "AQkFOAMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE5AwAuAEQ5AwAAlgQA" +
           "AAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcA" +
           "AABETlNOQU1FAAz/////AAAAAAABACoBARcAAAAIAAAARGV2aWNlSUQABf////8AAAAAAAEAKgEBFwAA" +
           "AAgAAABWZW5kb3JJRAAF/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBOgMALgBEOgMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJv" +
           "cgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVy" +
           "AQE7AwAvAQEMBTsDAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPAMALgBE" +
           "PAMAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARMAAAAEAAAAU0xPVAAF/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAFNVQlNMT1QABf////8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAF/////wAAAAAAAQAq" +
           "AQESAAAAAwAAAEFQSQAH/////wAAAAAAAQAqAQEWAAAABwAAAFJFUVVFU1QAD/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAT0DAC4ARD0D" +
           "AACWAwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NP" +
           "REVTAA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEjAwMAAAAATQAAAElkZW50" +
           "aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2" +
           "aWNlIGluc3RhbmNlAC4ARCMDAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNv" +
           "dW50ZXIBASQDAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1i" +
           "ZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlm" +
           "aWVkAC4ARCQDAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASUDAwAA" +
           "AAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARCUD" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBJgMDAAAAABgAAABNb2RlbCBuYW1l" +
           "IG9mIHRoZSBkZXZpY2UALgBEJgMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1h" +
           "bnVhbAEBJwMDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBV" +
           "UkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEJwMAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQEoAwMAAAAAJAAAAE92ZXJhbGwg" +
           "cmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAEQoAwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBKQMDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29m" +
           "dHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAEQpAwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBKgMDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFy" +
           "ZHdhcmUgb2YgdGhlIGRldmljZQAuAEQqAwAAAAz/////AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAiAAAAU2VydmVyQ29tbXVuaWNhdGlvbkhB" +
           "UlR5cGVJbnN0YW5jZQEBPgMBAT4DPgMAAP////8KAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAUED" +
           "AwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6QQMAAP////8BAAAABGGCCgQAAAABAAoAAABT" +
           "ZXRBZGRyZXNzAQGIAwAvAQGIA4gDAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBiQMALgBEiQMAAJYCAAAAAQAqAQEdAAAADgAAAE9sZFBvbGxBZGRyZXNzAAP/////AAAAAAABACoB" +
           "AR0AAAAOAAAATmV3UG9sbEFkZHJlc3MAA/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYoDAC4ARIoDAACWAQAAAAEAKgEBGwAAAAwAAABT" +
           "ZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAACAAwA" +
           "AABTZXJpYWxOdW1iZXIBAVUDAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZp" +
           "ZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEVQMAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBVgMDAAAAAGkAAABBbiBpbmNyZW1l" +
           "bnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEg" +
           "d2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEVgMAAAAG/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBVwMDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRo" +
           "YXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEVwMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "BQAAAE1vZGVsAQFYAwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAERYAwAAABX/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQFZAwMAAAAAWgAAAEFkZHJlc3MgKHBh" +
           "dGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1h" +
           "bnVhbCBmb3IgdGhlIGRldmljZQAuAERZAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2" +
           "aWNlUmV2aXNpb24BAVoDAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNl" +
           "AC4ARFoDAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQFbAwMA" +
           "AAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNl" +
           "AC4ARFsDAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQFcAwMA" +
           "AAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARFwDAAAA" +
           "DP////8BAf////8AAAAABGCACgEAAAABAA8AAABTZXJ2aWNlUHJvdmlkZXIBAYsDAC8BAQ8FiwMAAP//" +
           "//8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAY4DAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhv" +
           "ZHMALwA6jgMAAP////8DAAAABGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQGyAwAvAQEsAbIDAAABAf//" +
           "//8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBswMALgBEswMAAJYBAAAAAQAqAQEmAAAA" +
           "FwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG0AwAuAES0AwAAlgEAAAABACoBARsAAAAM" +
           "AAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQAHAAAAQ29ubmVjdAEBtQMALwEBUgW1AwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAbYDAC4ARLYDAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAqAQEaAAAACwAAAExvbmdBZGRyZXNzAA//////AAAAAAABACgBAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG3AwAuAES3AwAAlgEAAAABACoB" +
           "ARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARh" +
           "ggoEAAAAAQAIAAAAVHJhbnNmZXIBAbgDAC8BAVUFuAMAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQG5AwAuAES5AwAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABDb21tYW5kAAX/////AAAAAAABACoBARYAAAAHAAAA" +
           "UmVxdWVzdAAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBugMALgBEugMAAJYCAAAAAQAqAQEUAAAABQAAAFJlcGx5AA//////AAAAAAAB" +
           "ACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQGgAwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlx" +
           "dWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4A" +
           "RKADAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAaEDAwAAAABp" +
           "AAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhl" +
           "IHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARKEDAAAABv//" +
           "//8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAaIDAwAAAAAwAAAATmFtZSBvZiB0" +
           "aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARKIDAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAUAAABNb2RlbAEBowMDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UA" +
           "LgBEowMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBpAMDAAAAAFoA" +
           "AABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVz" +
           "cykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEpAMAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADgAAAERldmljZVJldmlzaW9uAQGlAwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwg" +
           "b2YgdGhlIGRldmljZQAuAESlAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVS" +
           "ZXZpc2lvbgEBpgMDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUg" +
           "b2YgdGhlIGRldmljZQAuAESmAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVS" +
           "ZXZpc2lvbgEBpwMDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRl" +
           "dmljZQAuAESnAwAAAAz/////AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQA0AAAAU2VydmVyQ29tbXVuaWNhdGlvbklT" +
           "QTEwMF9XaXJlbGVzc0RldmljZVR5cGVJbnN0YW5jZQEB/AYBAfwG/AYAAP////8JAAAANWCJCgIAAAAC" +
           "AAwAAABTZXJpYWxOdW1iZXIBARMHAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50" +
           "aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEEwcAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBFAcDAAAAAGkAAABBbiBpbmNy" +
           "ZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRh" +
           "dGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEFAcAAAAG/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBFQcDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55" +
           "IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEFQcAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIABQAAAE1vZGVsAQEWBwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQWBwAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEXBwMAAAAAWgAAAEFkZHJlc3Mg" +
           "KHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2Vy" +
           "IG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQXBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAA" +
           "RGV2aWNlUmV2aXNpb24BARgHAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2" +
           "aWNlAC4ARBgHAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQEZ" +
           "BwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARBkHAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQEa" +
           "BwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARBoH" +
           "AAAADP////8BAf////8AAAAABGCACgEAAAABAA8AAABTZXJ2aWNlUHJvdmlkZXIBAUYHAC8BAQkIRgcA" +
           "AP////8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAUkHAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1l" +
           "dGhvZHMALwA6SQcAAP////8DAAAABGGCCgQAAAABAAoAAABEaXNjb25uZWN0AQFtBwAvAQEsAW0HAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBbgcALgBEbgcAAJYBAAAAAQAqAQEm" +
           "AAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFvBwAuAERvBwAAlgEAAAABACoBARsA" +
           "AAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAHAAAAQ29ubmVjdAEBcAcALwEBTAhwBwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAXEHAC4ARHEHAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25J" +
           "ZAAP/////wAAAAAAAQAqAQEYAAAACQAAAElQQWRkcmVzcwAP/////wAAAAAAAQAqAQEYAAAACQAAAFNl" +
           "cnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBcgcALgBEcgcAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwA" +
           "B/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAABGGCCgQAAAABAAgAAABUcmFuc2ZlcgEBcwcALwEBTwhzBwAAAQH/////AgAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXQHAC4ARHQHAACWCAAAAAEAKgEBJgAAABcAAABDb21t" +
           "dW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAA" +
           "AAAAAQAqAQEUAAAABQAAAEFwcElEAAX/////AAAAAAABACoBARcAAAAIAAAAT2JqZWN0SUQABf////8A" +
           "AAAAAAEAKgEBGwAAAAwAAABBdHRyT3JNZXRoSUQABf////8AAAAAAAEAKgEBGAAAAAkAAABTVUJfSU5E" +
           "RVgAB/////8AAAAAAAEAKgEBHAAAAAkAAABXcml0ZURhdGEAAwEAAAABAAAAAAAAAAABACoBARgAAAAJ" +
           "AAAAUmVxdWVzdElkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQF1BwAuAER1BwAAlgIAAAABACoBARsAAAAIAAAAUmVhZERhdGEAAwEA" +
           "AAABAAAAAAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQFbBwMAAAAATQAAAElkZW50aWZp" +
           "ZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNl" +
           "IGluc3RhbmNlAC4ARFsHAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50" +
           "ZXIBAVwHAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIg" +
           "b2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVk" +
           "AC4ARFwHAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAV0HAwAAAAAw" +
           "AAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARF0HAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBXgcDAAAAABgAAABNb2RlbCBuYW1lIG9m" +
           "IHRoZSBkZXZpY2UALgBEXgcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVh" +
           "bAEBXwcDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwg" +
           "fCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEXwcAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQFgBwMAAAAAJAAAAE92ZXJhbGwgcmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERgBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAAU29mdHdhcmVSZXZpc2lvbgEBYQcDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdh" +
           "cmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERhBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAASGFyZHdhcmVSZXZpc2lvbgEBYgcDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAERiBwAAAAz/////AQH/////AAAAAA==";
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAsAAAAU2VydmVyQ29tbXVuaWNhdGlvbkdF" +
           "TkVSSUNEZXZpY2VUeXBlSW5zdGFuY2UBAXkHAQF5B3kHAAD/////CwAAACRggAoBAAAAAgAJAAAATWV0" +
           "aG9kU2V0AQF8BwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOnwHAAD/////AQAAAARhggoE" +
           "AAAAAQAKAAAAU2V0QWRkcmVzcwEBxAcALwEBxAfEBwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAcUHAC4ARMUHAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAA//////AAAA" +
           "AAABACoBARkAAAAKAAAATmV3QWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBxgcALgBExgcAAJYBAAAAAQAqAQEbAAAADAAA" +
           "AFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAFNlcmlhbE51bWJlcgEBkAcDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRp" +
           "Zmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAESQBwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQGRBwMAAAAAaQAAAEFuIGluY3Jl" +
           "bWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0" +
           "YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAESRBwAAAAb/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGSBwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkg" +
           "dGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESSBwAAABX/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAFAAAATW9kZWwBAZMHAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARJMHAAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAZQHAwAAAABaAAAAQWRkcmVzcyAo" +
           "cGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIg" +
           "bWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARJQHAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABE" +
           "ZXZpY2VSZXZpc2lvbgEBlQcDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZp" +
           "Y2UALgBElQcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAZYH" +
           "AwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZp" +
           "Y2UALgBElgcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAZcH" +
           "AwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBElwcA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFByb3RvY29sSWRlbnRpZmllcgEBwwcALgBEwwcA" +
           "AAAM/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92aWRlcgEBxwcALwEBVQjHBwAA" +
           "/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBygcDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0" +
           "aG9kcwAvADrKBwAA/////wMAAAAEYYIKBAAAAAEACgAAAERpc2Nvbm5lY3QBAe4HAC8BASwB7gcAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHvBwAuAETvBwAAlgEAAAABACoBASYA" +
           "AAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAfAHAC4ARPAHAACWAQAAAAEAKgEBGwAA" +
           "AAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQA" +
           "AAABAAcAAABDb25uZWN0AQHxBwAvAQGYCPEHAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEB8gcALgBE8gcAAJYCAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklk" +
           "AA//////AAAAAAABACoBARYAAAAHAAAAQWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB8wcALgBE8wcAAJYBAAAAAQAqAQEb" +
           "AAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEACAAAAFRyYW5zZmVyAQH0BwAvAQGbCPQHAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEB9QcALgBE9QcAAJYFAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlv" +
           "bklkAA//////AAAAAAABACoBARUAAAAGAAAASGVhZGVyAAz/////AAAAAAABACoBARoAAAALAAAAUmVx" +
           "dWVzdERhdGEAD/////8AAAAAAAEAKgEBJQAAABAAAABSZXF1ZXN0RGF0YVR5cGVzAQECCAEAAAABAAAA" +
           "AAAAAAABACoBASYAAAARAAAAUmVzcG9uc2VEYXRhVHlwZXMBAQIIAQAAAAEAAAAAAAAAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAfYHAC4ARPYHAACW" +
           "AwAAAAEAKgEBGwAAAAwAAABSZXNwb25zZURhdGEAD/////8AAAAAAAEAKgEBHQAAAA4AAABSRVNQT05T" +
           "RV9DT0RFUwAP/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB3AcDAAAAAE0AAABJ" +
           "ZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBh" +
           "IGRldmljZSBpbnN0YW5jZQAuAETcBwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNp" +
           "b25Db3VudGVyAQHdBwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUg" +
           "bnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBt" +
           "b2RpZmllZAAuAETdBwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQHe" +
           "BwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAu" +
           "AETeBwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAd8HAwAAAAAYAAAATW9kZWwg" +
           "bmFtZSBvZiB0aGUgZGV2aWNlAC4ARN8HAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZp" +
           "Y2VNYW51YWwBAeAHAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9y" +
           "IGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AROAHAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB4QcDAAAAACQAAABPdmVy" +
           "YWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE4QcAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAeIHAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhl" +
           "IHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE4gcAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAeMHAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhl" +
           "IGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE4wcAAAAM/////wEB/////wAAAAA=";
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
           "//8AAAAAAAEAKgEBGAAAAAkAAABJUEFkZHJlc3MAD/////8AAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNl" +
           "SWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAfkHAC4ARPkHAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////" +
           "AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAA==";
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
            uint serviceId = (uint)_inputArguments[2];

            uint delayForNextCall = (uint)_outputArguments[0];
            object serviceError = (object)_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    communicationRelationId,
                    iPAddress,
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
    public delegate ServiceResult ConnectMethodISA100_WirelessMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] communicationRelationId,
        byte[] iPAddress,
        uint serviceId,
        ref uint delayForNextCall,
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
           "cHV0QXJndW1lbnRzAQEHCAAuAEQHCAAAlgIAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAB/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQgIAC4ARAgIAACWBgAA" +
           "AAEAKgEBFAAAAAUAAABBcHBJRAAF/////wAAAAAAAQAqAQEXAAAACAAAAE9iamVjdElEAAX/////AAAA" +
           "AAABACoBASEAAAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAABAAAAAAAAAAABACoBAR0AAAAOAAAAQWxh" +
           "cm1FdmVudFR5cGUABf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEB" +
           "GwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
            uint requestId = (uint)_inputArguments[1];

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
                    requestId,
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
        uint requestId,
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAmAAAAU2VydmVyQ29tbXVuaWNhdGlvblNl" +
           "cnZpY2VUeXBlSW5zdGFuY2UBAekAAQHpAOkAAAD/////CQAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0" +
           "AQHsAAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOuwAAAD/////AQAAAARhggoEAAAAAQAK" +
           "AAAARGlzY29ubmVjdAEBLAEALwEBLAEsAQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAS0BAC4ARC0BAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBLgEALgBELgEAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBAAEDAAAAAE0A" +
           "AABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVy" +
           "LCBhIGRldmljZSBpbnN0YW5jZQAuAEQAAQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQEBAQMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0" +
           "aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVl" +
           "biBtb2RpZmllZAAuAEQBAQAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVy" +
           "AQECAQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmlj" +
           "ZQAuAEQCAQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAQMBAwAAAAAYAAAATW9k" +
           "ZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARAMBAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABE" +
           "ZXZpY2VNYW51YWwBAQQBAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVt" +
           "IG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARAQB" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBBQEDAAAAACQAAABP" +
           "dmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEBQEAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAQYBAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEBgEAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAQcBAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEBwEAAAAM/////wEB/////wAAAAA=";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SDFTZXJ2aWNlVHlwZUluc3RhbmNlAQHlAwEB5QPlAwAA/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhv" +
           "ZFNldAEB6AMDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADroAwAA/////wQAAAAEYYIKBAAA" +
           "AAEACgAAAERpc2Nvbm5lY3QBASUEAC8BASwBJQQAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQEmBAAuAEQmBAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAScEAC4ARCcEAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQEoBAAvAQEoBCgE" +
           "AAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBKQQALgBEKQQAAJYGAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARUAAAAGAAAATGlu" +
           "a0lkAAX/////AAAAAAABACoBARYAAAAHAAAAQWRkcmVzcwAD/////wAAAAAAAQAqAQEcAAAADQAAAE9y" +
           "ZGluYWxOdW1iZXIABv////8AAAAAAAEAKgEBHAAAAA0AAABTSUZDb25uZWN0aW9uAAH/////AAAAAAAB" +
           "ACoBARgAAAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEqBAAuAEQqBAAAlgIAAAABACoBAR8AAAAQAAAARGVs" +
           "YXlGb3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQErBAAvAQErBCsE" +
           "AAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBLAQALgBELAQAAJYHAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BF" +
           "UkFUSU9OAAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEBFAAAAAUA" +
           "AABJTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEcAAAA" +
           "CQAAAFdyaXRlRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAS0E" +
           "AC4ARC0EAACWAwAAAAEAKgEBGwAAAAgAAABSZWFkRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBHwAAABAA" +
           "AABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAR2V0UHVibGlzaGVkRGF0" +
           "YQEBLgQALwEBLgQuBAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAS8EAC4A" +
           "RC8EAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBMAQALgBEMAQAAJYGAAAAAQAqAQEXAAAACAAAAEJsb2Nr" +
           "VGFnAAz/////AAAAAAABACoBASEAAAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAABAAAAAAAAAAABACoB" +
           "AR0AAAAOAAAAQWxhcm1FdmVudFR5cGUAEf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf//" +
           "//8AAAAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQH8AwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARPwDAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAf0DAwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARP0DAAAABv////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAf4DAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0" +
           "aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARP4DAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAUAAABNb2RlbAEB/wMDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBE/wMAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBAAQDAAAAAFoAAABBZGRyZXNzIChw" +
           "YXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBt" +
           "YW51YWwgZm9yIHRoZSBkZXZpY2UALgBEAAQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERl" +
           "dmljZVJldmlzaW9uAQEBBAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmlj" +
           "ZQAuAEQBBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBAgQD" +
           "AAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAEQCBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBAwQD" +
           "AAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEQDBAAA" +
           "AAz/////AQH/////AAAAAA==";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQArAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SFNFU2VydmljZVR5cGVJbnN0YW5jZQEBMQQBATEEMQQAAP////8JAAAAJGCACgEAAAACAAkAAABNZXRo" +
           "b2RTZXQBATQEAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6NAQAAP////8EAAAABGGCCgQA" +
           "AAABAAoAAABEaXNjb25uZWN0AQFxBAAvAQEsAXEEAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBcgQALgBEcgQAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlv" +
           "bklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQFzBAAuAERzBAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBdAQALwEBdAR0" +
           "BAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXUEAC4ARHUEAACWBAAAAAEA" +
           "KgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAAAEFk" +
           "ZHJlc3MAD/////8AAAAAAAEAKgEBHAAAAA0AAABPcmRpbmFsTnVtYmVyAAb/////AAAAAAABACoBARgA" +
           "AAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQF2BAAuAER2BAAAlgIAAAABACoBAR8AAAAQAAAARGVsYXlGb3JO" +
           "ZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQF3BAAvAQF3BHcEAAABAf//" +
           "//8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBeAQALgBEeAQAAJYHAAAAAQAqAQEmAAAA" +
           "FwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9O" +
           "AAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEBFAAAAAUAAABJTkRF" +
           "WAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEcAAAACQAAAFdy" +
           "aXRlRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXkEAC4ARHkE" +
           "AACWAwAAAAEAKgEBGwAAAAgAAABSZWFkRGF0YQADAQAAAAEAAAAAAAAAAAEAKgEBHwAAABAAAABEZWxh" +
           "eUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAR2V0UHVibGlzaGVkRGF0YQEBegQA" +
           "LwEBegR6BAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXsEAC4ARHsEAACW" +
           "AgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAA" +
           "CQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBfAQALgBEfAQAAJYGAAAAAQAqAQEXAAAACAAAAEJsb2NrVGFnAAz/" +
           "////AAAAAAABACoBASEAAAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAABAAAAAAAAAAABACoBAR0AAAAO" +
           "AAAAQWxhcm1FdmVudFR5cGUAEf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAA" +
           "AAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2Vydmlj" +
           "ZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2Vy" +
           "aWFsTnVtYmVyAQFIBAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3" +
           "aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4AREgEAAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAUkEAwAAAABpAAAAQW4gaW5jcmVtZW50YWwg" +
           "Y291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhp" +
           "biB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4AREkEAAAABv////8BAf////8AAAAANWCJCgIA" +
           "AAACAAwAAABNYW51ZmFjdHVyZXIBAUoEAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1h" +
           "bnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4AREoEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABN" +
           "b2RlbAEBSwQDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBESwQAAAAV/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBTAQDAAAAAFoAAABBZGRyZXNzIChwYXRobmFt" +
           "ZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwg" +
           "Zm9yIHRoZSBkZXZpY2UALgBETAQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJl" +
           "dmlzaW9uAQFNBAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERN" +
           "BAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBTgQDAAAAADUA" +
           "AABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERO" +
           "BAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBTwQDAAAAACwA" +
           "AABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERPBAAAAAz/////" +
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAuAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJQlVTU2VydmljZVR5cGVJbnN0YW5jZQEBfQQBAX0EfQQAAP////8JAAAAJGCACgEAAAACAAkAAABN" +
           "ZXRob2RTZXQBAYAEAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6gAQAAP////8DAAAABGGC" +
           "CgQAAAABAAoAAABEaXNjb25uZWN0AQG9BAAvAQEsAb0EAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBvgQALgBEvgQAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxh" +
           "dGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQG/BAAuAES/BAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBwAQALwEB" +
           "wATABAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcEEAC4ARMEEAACWAwAA" +
           "AAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAA" +
           "AEFkZHJlc3MAA/////8AAAAAAAEAKgEBHQAAAA4AAABNYW51ZmFjdHVyZXJJZAAF/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBwgQALgBE" +
           "wgQAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQHDBAAvAQHDBMMEAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBxAQALgBExAQAAJYFAAAAAQAqAQEmAAAAFwAAAENvbW11" +
           "bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAA" +
           "AAABACoBARMAAAAEAAAAU0xPVAAD/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAP/////AAAAAAAB" +
           "ACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBxQQALgBExQQAAJYDAAAAAQAqAQEUAAAABQAAAFJFUExZ" +
           "AA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9OU0VfQ09ERVMAD/////8AAAAAAAEAKgEBGwAAAAwA" +
           "AABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAANWCJCgIAAAAC" +
           "AAwAAABTZXJpYWxOdW1iZXIBAZQEAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50" +
           "aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBElAQAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBlQQDAAAAAGkAAABBbiBpbmNy" +
           "ZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRh" +
           "dGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBElQQAAAAG/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBlgQDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55" +
           "IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBElgQAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIABQAAAE1vZGVsAQGXBAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAESXBAAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQGYBAMAAAAAWgAAAEFkZHJlc3Mg" +
           "KHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2Vy" +
           "IG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAESYBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAA" +
           "RGV2aWNlUmV2aXNpb24BAZkEAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2" +
           "aWNlAC4ARJkEAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQGa" +
           "BAMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARJoEAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQGb" +
           "BAMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARJsE" +
           "AAAADP////8BAf////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAuAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJTkVUU2VydmljZVR5cGVJbnN0YW5jZQEBxgQBAcYExgQAAP////8JAAAAJGCACgEAAAACAAkAAABN" +
           "ZXRob2RTZXQBAckEAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6yQQAAP////8DAAAABGGC" +
           "CgQAAAABAAoAAABEaXNjb25uZWN0AQEGBQAvAQEsAQYFAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBBwUALgBEBwUAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxh" +
           "dGlvbklkAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQEIBQAuAEQIBQAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAQ29ubmVjdAEBCQUALwEB" +
           "CQUJBQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQoFAC4ARAoFAACWBAAA" +
           "AAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAABwAA" +
           "AEROU05BTUUADP////8AAAAAAAEAKgEBFwAAAAgAAABEZXZpY2VJRAAF/////wAAAAAAAQAqAQEXAAAA" +
           "CAAAAFZlbmRvcklEAAX/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQELBQAuAEQLBQAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9y" +
           "ABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJhbnNmZXIB" +
           "AQwFAC8BAQwFDAUAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQENBQAuAEQN" +
           "BQAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEB" +
           "GAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9UAAX/////AAAAAAABACoB" +
           "ARYAAAAHAAAAU1VCU0xPVAAF/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAX/////AAAAAAABACoB" +
           "ARIAAAADAAAAQVBJAAf/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBDgUALgBEDgUA" +
           "AJYDAAAAAQAqAQEUAAAABQAAAFJFUExZAA//////AAAAAAABACoBAR0AAAAOAAAAUkVTUE9OU0VfQ09E" +
           "RVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAd0EAwAAAABNAAAASWRlbnRp" +
           "ZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZp" +
           "Y2UgaW5zdGFuY2UALgBE3QQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291" +
           "bnRlcgEB3gQDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJl" +
           "ciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZp" +
           "ZWQALgBE3gQAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEB3wQDAAAA" +
           "ADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBE3wQA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQHgBAMAAAAAGAAAAE1vZGVsIG5hbWUg" +
           "b2YgdGhlIGRldmljZQAuAETgBAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFu" +
           "dWFsAQHhBAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVS" +
           "TCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEThBAAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAeIEAwAAAAAkAAAAT3ZlcmFsbCBy" +
           "ZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4AROIEAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "ABAAAABTb2Z0d2FyZVJldmlzaW9uAQHjBAMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0" +
           "d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4AROMEAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "ABAAAABIYXJkd2FyZVJldmlzaW9uAQHkBAMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJk" +
           "d2FyZSBvZiB0aGUgZGV2aWNlAC4AROQEAAAADP////8BAf////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkhB" +
           "UlRTZXJ2aWNlVHlwZUluc3RhbmNlAQEPBQEBDwUPBQAA/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhv" +
           "ZFNldAEBEgUDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoSBQAA/////wQAAAAEYYIKBAAA" +
           "AAEACgAAAERpc2Nvbm5lY3QBAU8FAC8BASwBTwUAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQFQBQAuAERQBQAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAVEFAC4ARFEFAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQFSBQAvAQFSBVIF" +
           "AAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBUwUALgBEUwUAAJYCAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARoAAAALAAAATG9u" +
           "Z0FkZHJlc3MAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAVQFAC4ARFQFAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAgAAABUcmFuc2ZlcgEBVQUA" +
           "LwEBVQVVBQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVYFAC4ARFYFAACW" +
           "AwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEWAAAA" +
           "BwAAAENvbW1hbmQABf////8AAAAAAAEAKgEBFgAAAAcAAABSZXF1ZXN0AA//////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFXBQAuAERXBQAA" +
           "lgIAAAABACoBARQAAAAFAAAAUmVwbHkAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IA" +
           "G/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABAAAABHZXRQdWJsaXNo" +
           "ZWREYXRhAQFYBQAvAQFYBVgFAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "WQUALgBEWQUAAJYBAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFa" +
           "BQAuAERaBQAAlgQAAAABACoBARYAAAAHAAAAQ29tbWFuZAAF/////wAAAAAAAQAqAQEUAAAABQAAAFJl" +
           "cGx5AA//////AAAAAAABACoBARgAAAAJAAAAVGltZVN0YW1wAA3/////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQEmBQMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARCYFAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAScFAwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARCcFAAAABv////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASgFAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0" +
           "aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARCgFAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAUAAABNb2RlbAEBKQUDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEKQUAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBKgUDAAAAAFoAAABBZGRyZXNzIChw" +
           "YXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBt" +
           "YW51YWwgZm9yIHRoZSBkZXZpY2UALgBEKgUAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERl" +
           "dmljZVJldmlzaW9uAQErBQMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmlj" +
           "ZQAuAEQrBQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBLAUD" +
           "AAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAEQsBQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBLQUD" +
           "AAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEQtBQAA" +
           "AAz/////AQH/////AAAAAA==";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQA1AAAAU2VydmVyQ29tbXVuaWNhdGlvbklT" +
           "QTEwMF9XaXJlbGVzc1NlcnZpY2VUeXBlSW5zdGFuY2UBAQkIAQEJCAkIAAD/////CQAAACRggAoBAAAA" +
           "AgAJAAAATWV0aG9kU2V0AQEMCAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOgwIAAD/////" +
           "BAAAAARhggoEAAAAAQAKAAAARGlzY29ubmVjdAEBSQgALwEBLAFJCAAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAUoIAC4AREoIAACWAQAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0" +
           "aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBSwgALgBESwgAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJv" +
           "cgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbm5lY3QB" +
           "AUwIAC8BAUwITAgAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFNCAAuAERN" +
           "CAAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEB" +
           "GAAAAAkAAABJUEFkZHJlc3MAD/////8AAAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAU4I" +
           "AC4ARE4IAACWAgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsA" +
           "AAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAIAAAAVHJhbnNmZXIBAU8IAC8BAU8ITwgAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQFQCAAuAERQCAAAlggAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9u" +
           "SWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFAAAAAUAAABB" +
           "cHBJRAAF/////wAAAAAAAQAqAQEXAAAACAAAAE9iamVjdElEAAX/////AAAAAAABACoBARsAAAAMAAAA" +
           "QXR0ck9yTWV0aElEAAX/////AAAAAAABACoBARgAAAAJAAAAU1VCX0lOREVYAAf/////AAAAAAABACoB" +
           "ARwAAAAJAAAAV3JpdGVEYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEYAAAACQAAAFJlcXVlc3RJZAAH////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50" +
           "cwEBUQgALgBEUQgAAJYCAAAAAQAqAQEbAAAACAAAAFJlYWREYXRhAAMBAAAAAQAAAAAAAAAAAQAqAQEb" +
           "AAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEAEAAAAEdldFB1Ymxpc2hlZERhdGEBAVIIAC8BAVIIUggAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQFTCAAuAERTCAAAlgIAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlv" +
           "blJlbGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAB/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVQIAC4ARFQI" +
           "AACWBgAAAAEAKgEBFAAAAAUAAABBcHBJRAAF/////wAAAAAAAQAqAQEXAAAACAAAAE9iamVjdElEAAX/" +
           "////AAAAAAABACoBASEAAAAOAAAAQWxhcm1FdmVudERhdGEAAwEAAAABAAAAAAAAAAABACoBAR0AAAAO" +
           "AAAAQWxhcm1FdmVudFR5cGUABf////8AAAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAA" +
           "AAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBASAIAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVu" +
           "aXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UA" +
           "LgBEIAgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBIQgDAAAA" +
           "AGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0" +
           "aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEIQgAAAAG" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBIggDAAAAADAAAABOYW1lIG9m" +
           "IHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEIggAAAAV/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQEjCAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmlj" +
           "ZQAuAEQjCAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEkCAMAAAAA" +
           "WgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRy" +
           "ZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQkCAAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BASUIAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgZGV2aWNlAC4ARCUIAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2Fy" +
           "ZVJldmlzaW9uAQEmCAMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2Fy" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARCYIAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2Fy" +
           "ZVJldmlzaW9uAQEnCAMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUg" +
           "ZGV2aWNlAC4ARCcIAAAADP////8BAf////8AAAAA";
        #endregion
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
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvbkdF" +
           "TkVSSUNTZXJ2aWNlVHlwZUluc3RhbmNlAQFVCAEBVQhVCAAA/////wkAAAAkYIAKAQAAAAIACQAAAE1l" +
           "dGhvZFNldAEBWAgDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpYCAAA/////wMAAAAEYYIK" +
           "BAAAAAEACgAAAERpc2Nvbm5lY3QBAZUIAC8BASwBlQgAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQGWCAAuAESWCAAAlgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAZcIAC4ARJcIAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAcAAABDb25uZWN0AQGYCAAvAQGY" +
           "CJgIAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBmQgALgBEmQgAAJYCAAAA" +
           "AQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARYAAAAHAAAA" +
           "QWRkcmVzcwAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBmggALgBEmggAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQGbCAAv" +
           "AQGbCJsIAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBnAgALgBEnAgAAJYF" +
           "AAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARUAAAAG" +
           "AAAASGVhZGVyAAz/////AAAAAAABACoBARoAAAALAAAAUmVxdWVzdERhdGEAD/////8AAAAAAAEAKgEB" +
           "JQAAABAAAABSZXF1ZXN0RGF0YVR5cGVzAQECCAEAAAABAAAAAAAAAAABACoBASYAAAARAAAAUmVzcG9u" +
           "c2VEYXRhVHlwZXMBAQIIAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZ0IAC4ARJ0IAACWAwAAAAEAKgEBGwAAAAwAAABSZXNwb25z" +
           "ZURhdGEAD/////8AAAAAAAEAKgEBHQAAAA4AAABSRVNQT05TRV9DT0RFUwAP/////wAAAAAAAQAqAQEb" +
           "AAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkK" +
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
