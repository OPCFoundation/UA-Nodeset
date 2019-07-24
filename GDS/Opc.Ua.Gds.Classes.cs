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

namespace Opc.Ua.Gds
{
    #region FindApplicationsMethodState Class
    #if (!OPCUA_EXCLUDE_FindApplicationsMethodState)
    /// <summary>
    /// Stores an instance of the FindApplicationsMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FindApplicationsMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FindApplicationsMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new FindApplicationsMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAGgAAAEZp" +
           "bmRBcHBsaWNhdGlvbnNNZXRob2RUeXBlAQECAAAvAQECAAIAAAABAf////8CAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBAwAALgBEAwAAAJYBAAAAAQAqAQEdAAAADgAAAEFwcGxpY2F0aW9uVXJp" +
           "AAz/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQEEAAAuAEQEAAAAlgEAAAABACoBASEAAAAMAAAAQXBwbGljYXRpb25zAQEBAAEAAAABAAAA" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public FindApplicationsMethodStateMethodCallHandler OnCall;
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

            string applicationUri = (string)_inputArguments[0];

            ApplicationRecordDataType[] applications = (ApplicationRecordDataType[])_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationUri,
                    ref applications);
            }

            _outputArguments[0] = applications;

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
    public delegate ServiceResult FindApplicationsMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string applicationUri,
        ref ApplicationRecordDataType[] applications);
    #endif
    #endregion

    #region RegisterApplicationMethodState Class
    #if (!OPCUA_EXCLUDE_RegisterApplicationMethodState)
    /// <summary>
    /// Stores an instance of the RegisterApplicationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RegisterApplicationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RegisterApplicationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new RegisterApplicationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAHQAAAFJl" +
           "Z2lzdGVyQXBwbGljYXRpb25NZXRob2RUeXBlAQEFAAAvAQEFAAUAAAABAf////8CAAAAF2CpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBBgAALgBEBgAAAJYBAAAAAQAqAQEcAAAACwAAAEFwcGxpY2F0aW9u" +
           "AQEBAP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAQcAAC4ARAcAAACWAQAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public RegisterApplicationMethodStateMethodCallHandler OnCall;
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

            ApplicationRecordDataType application = (ApplicationRecordDataType)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);

            NodeId applicationId = (NodeId)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    application,
                    ref applicationId);
            }

            _outputArguments[0] = applicationId;

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
    public delegate ServiceResult RegisterApplicationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ApplicationRecordDataType application,
        ref NodeId applicationId);
    #endif
    #endregion

    #region UpdateApplicationMethodState Class
    #if (!OPCUA_EXCLUDE_UpdateApplicationMethodState)
    /// <summary>
    /// Stores an instance of the UpdateApplicationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class UpdateApplicationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public UpdateApplicationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new UpdateApplicationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAGwAAAFVw" +
           "ZGF0ZUFwcGxpY2F0aW9uTWV0aG9kVHlwZQEBugAALwEBugC6AAAAAQH/////AQAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAbsAAC4ARLsAAACWAQAAAAEAKgEBHAAAAAsAAABBcHBsaWNhdGlvbgEB" +
           "AQD/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public UpdateApplicationMethodStateMethodCallHandler OnCall;
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

            ApplicationRecordDataType application = (ApplicationRecordDataType)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    application);
            }

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
    public delegate ServiceResult UpdateApplicationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ApplicationRecordDataType application);
    #endif
    #endregion

    #region UnregisterApplicationMethodState Class
    #if (!OPCUA_EXCLUDE_UnregisterApplicationMethodState)
    /// <summary>
    /// Stores an instance of the UnregisterApplicationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class UnregisterApplicationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public UnregisterApplicationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new UnregisterApplicationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAHwAAAFVu" +
           "cmVnaXN0ZXJBcHBsaWNhdGlvbk1ldGhvZFR5cGUBAQgAAC8BAQgACAAAAAEB/////wEAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQEJAAAuAEQJAAAAlgEAAAABACoBARwAAAANAAAAQXBwbGljYXRp" +
           "b25JZAAR/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public UnregisterApplicationMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId);
            }

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
    public delegate ServiceResult UnregisterApplicationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId);
    #endif
    #endregion

    #region GetApplicationMethodState Class
    #if (!OPCUA_EXCLUDE_GetApplicationMethodState)
    /// <summary>
    /// Stores an instance of the GetApplicationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetApplicationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetApplicationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetApplicationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAGAAAAEdl" +
           "dEFwcGxpY2F0aW9uTWV0aG9kVHlwZQEBzwAALwEBzwDPAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAdAAAC4ARNAAAACWAQAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/" +
           "////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQHRAAAuAETRAAAAlgEAAAABACoBARwAAAALAAAAQXBwbGljYXRpb24BAQEA/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetApplicationMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];

            ApplicationRecordDataType application = (ApplicationRecordDataType)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    ref application);
            }

            _outputArguments[0] = application;

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
    public delegate ServiceResult GetApplicationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        ref ApplicationRecordDataType application);
    #endif
    #endregion

    #region QueryServersMethodState Class
    #if (!OPCUA_EXCLUDE_QueryServersMethodState)
    /// <summary>
    /// Stores an instance of the QueryServersMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class QueryServersMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public QueryServersMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new QueryServersMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAFgAAAFF1" +
           "ZXJ5U2VydmVyc01ldGhvZFR5cGUBAQoAAC8BAQoACgAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQELAAAuAEQLAAAAlgYAAAABACoBAR8AAAAQAAAAU3RhcnRpbmdSZWNvcmRJZAAH" +
           "/////wAAAAAAAQAqAQEhAAAAEgAAAE1heFJlY29yZHNUb1JldHVybgAH/////wAAAAAAAQAqAQEeAAAA" +
           "DwAAAEFwcGxpY2F0aW9uTmFtZQAM/////wAAAAAAAQAqAQEdAAAADgAAAEFwcGxpY2F0aW9uVXJpAAz/" +
           "////AAAAAAABACoBARkAAAAKAAAAUHJvZHVjdFVyaQAM/////wAAAAAAAQAqAQElAAAAEgAAAFNlcnZl" +
           "ckNhcGFiaWxpdGllcwAMAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQwAAC4ARAwAAACWAgAAAAEAKgEBJQAAABQAAABMYXN0Q291" +
           "bnRlclJlc2V0VGltZQEAJgH/////AAAAAAABACoBARwAAAAHAAAAU2VydmVycwEAnS8BAAAAAQAAAAAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public QueryServersMethodStateMethodCallHandler OnCall;
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

            uint startingRecordId = (uint)_inputArguments[0];
            uint maxRecordsToReturn = (uint)_inputArguments[1];
            string applicationName = (string)_inputArguments[2];
            string applicationUri = (string)_inputArguments[3];
            string productUri = (string)_inputArguments[4];
            string[] serverCapabilities = (string[])_inputArguments[5];

            DateTime lastCounterResetTime = (DateTime)_outputArguments[0];
            ServerOnNetwork[] servers = (ServerOnNetwork[])_outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    startingRecordId,
                    maxRecordsToReturn,
                    applicationName,
                    applicationUri,
                    productUri,
                    serverCapabilities,
                    ref lastCounterResetTime,
                    ref servers);
            }

            _outputArguments[0] = lastCounterResetTime;
            _outputArguments[1] = servers;

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
    public delegate ServiceResult QueryServersMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        uint startingRecordId,
        uint maxRecordsToReturn,
        string applicationName,
        string applicationUri,
        string productUri,
        string[] serverCapabilities,
        ref DateTime lastCounterResetTime,
        ref ServerOnNetwork[] servers);
    #endif
    #endregion

    #region DirectoryState Class
    #if (!OPCUA_EXCLUDE_DirectoryState)
    /// <summary>
    /// Stores an instance of the DirectoryType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectoryState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DirectoryState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Gds.ObjectTypes.DirectoryType, Opc.Ua.Gds.Namespaces.OpcUaGds, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "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" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FolderState Applications
        {
            get
            {
                return m_applications;
            }

            set
            {
                if (!Object.ReferenceEquals(m_applications, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_applications = value;
            }
        }

        /// <remarks />
        public FindApplicationsMethodState FindApplications
        {
            get
            {
                return m_findApplicationsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_findApplicationsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_findApplicationsMethod = value;
            }
        }

        /// <remarks />
        public RegisterApplicationMethodState RegisterApplication
        {
            get
            {
                return m_registerApplicationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_registerApplicationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_registerApplicationMethod = value;
            }
        }

        /// <remarks />
        public UpdateApplicationMethodState UpdateApplication
        {
            get
            {
                return m_updateApplicationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_updateApplicationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_updateApplicationMethod = value;
            }
        }

        /// <remarks />
        public UnregisterApplicationMethodState UnregisterApplication
        {
            get
            {
                return m_unregisterApplicationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_unregisterApplicationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unregisterApplicationMethod = value;
            }
        }

        /// <remarks />
        public GetApplicationMethodState GetApplication
        {
            get
            {
                return m_getApplicationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getApplicationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getApplicationMethod = value;
            }
        }

        /// <remarks />
        public QueryServersMethodState QueryServers
        {
            get
            {
                return m_queryServersMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_queryServersMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_queryServersMethod = value;
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
            if (m_applications != null)
            {
                children.Add(m_applications);
            }

            if (m_findApplicationsMethod != null)
            {
                children.Add(m_findApplicationsMethod);
            }

            if (m_registerApplicationMethod != null)
            {
                children.Add(m_registerApplicationMethod);
            }

            if (m_updateApplicationMethod != null)
            {
                children.Add(m_updateApplicationMethod);
            }

            if (m_unregisterApplicationMethod != null)
            {
                children.Add(m_unregisterApplicationMethod);
            }

            if (m_getApplicationMethod != null)
            {
                children.Add(m_getApplicationMethod);
            }

            if (m_queryServersMethod != null)
            {
                children.Add(m_queryServersMethod);
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
                case Opc.Ua.Gds.BrowseNames.Applications:
                {
                    if (createOrReplace)
                    {
                        if (Applications == null)
                        {
                            if (replacement == null)
                            {
                                Applications = new FolderState(this);
                            }
                            else
                            {
                                Applications = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Applications;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.FindApplications:
                {
                    if (createOrReplace)
                    {
                        if (FindApplications == null)
                        {
                            if (replacement == null)
                            {
                                FindApplications = new FindApplicationsMethodState(this);
                            }
                            else
                            {
                                FindApplications = (FindApplicationsMethodState)replacement;
                            }
                        }
                    }

                    instance = FindApplications;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.RegisterApplication:
                {
                    if (createOrReplace)
                    {
                        if (RegisterApplication == null)
                        {
                            if (replacement == null)
                            {
                                RegisterApplication = new RegisterApplicationMethodState(this);
                            }
                            else
                            {
                                RegisterApplication = (RegisterApplicationMethodState)replacement;
                            }
                        }
                    }

                    instance = RegisterApplication;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.UpdateApplication:
                {
                    if (createOrReplace)
                    {
                        if (UpdateApplication == null)
                        {
                            if (replacement == null)
                            {
                                UpdateApplication = new UpdateApplicationMethodState(this);
                            }
                            else
                            {
                                UpdateApplication = (UpdateApplicationMethodState)replacement;
                            }
                        }
                    }

                    instance = UpdateApplication;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.UnregisterApplication:
                {
                    if (createOrReplace)
                    {
                        if (UnregisterApplication == null)
                        {
                            if (replacement == null)
                            {
                                UnregisterApplication = new UnregisterApplicationMethodState(this);
                            }
                            else
                            {
                                UnregisterApplication = (UnregisterApplicationMethodState)replacement;
                            }
                        }
                    }

                    instance = UnregisterApplication;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.GetApplication:
                {
                    if (createOrReplace)
                    {
                        if (GetApplication == null)
                        {
                            if (replacement == null)
                            {
                                GetApplication = new GetApplicationMethodState(this);
                            }
                            else
                            {
                                GetApplication = (GetApplicationMethodState)replacement;
                            }
                        }
                    }

                    instance = GetApplication;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.QueryServers:
                {
                    if (createOrReplace)
                    {
                        if (QueryServers == null)
                        {
                            if (replacement == null)
                            {
                                QueryServers = new QueryServersMethodState(this);
                            }
                            else
                            {
                                QueryServers = (QueryServersMethodState)replacement;
                            }
                        }
                    }

                    instance = QueryServers;
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
        private FolderState m_applications;
        private FindApplicationsMethodState m_findApplicationsMethod;
        private RegisterApplicationMethodState m_registerApplicationMethod;
        private UpdateApplicationMethodState m_updateApplicationMethod;
        private UnregisterApplicationMethodState m_unregisterApplicationMethod;
        private GetApplicationMethodState m_getApplicationMethod;
        private QueryServersMethodState m_queryServersMethod;
        #endregion
    }
    #endif
    #endregion

    #region ApplicationRegistrationChangedAuditEventState Class
    #if (!OPCUA_EXCLUDE_ApplicationRegistrationChangedAuditEventState)
    /// <summary>
    /// Stores an instance of the ApplicationRegistrationChangedAuditEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ApplicationRegistrationChangedAuditEventState : AuditUpdateMethodEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ApplicationRegistrationChangedAuditEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Gds.ObjectTypes.ApplicationRegistrationChangedAuditEventType, Opc.Ua.Gds.Namespaces.OpcUaGds, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIACAQAAAAEANAAAAEFw" +
           "cGxpY2F0aW9uUmVnaXN0cmF0aW9uQ2hhbmdlZEF1ZGl0RXZlbnRUeXBlSW5zdGFuY2UBARoAAQEaABoA" +
           "AAD/////EAAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBGwAALgBEGwAAAAAP/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBHAAALgBEHAAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CgAAAFNvdXJjZU5vZGUBAR0AAC4ARB0AAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3Vy" +
           "Y2VOYW1lAQEeAAAuAEQeAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBHwAALgBE" +
           "HwAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBASAAAC4ARCAAAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBIQAALgBEIQAAAAEA0CL/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBIgAALgBEIgAAAAAV/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACAAAAFNldmVyaXR5AQEjAAAuAEQjAAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAP" +
           "AAAAQWN0aW9uVGltZVN0YW1wAQEkAAAuAEQkAAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAYA" +
           "AABTdGF0dXMBASUAAC4ARCUAAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXJ2ZXJJZAEB" +
           "JgAALgBEJgAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENsaWVudEF1ZGl0RW50cnlJZAEB" +
           "JwAALgBEJwAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBKAAALgBE" +
           "KAAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAE1ldGhvZElkAQEpAAAuAEQpAAAAABH/////" +
           "AQH/////AAAAABdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBASoAAC4ARCoAAAAAGAEAAAABAAAA" +
           "AAAAAAEB/////wAAAAA=";
        #endregion
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

    #region StartSigningRequestMethodState Class
    #if (!OPCUA_EXCLUDE_StartSigningRequestMethodState)
    /// <summary>
    /// Stores an instance of the StartSigningRequestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartSigningRequestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StartSigningRequestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new StartSigningRequestMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAHQAAAFN0" +
           "YXJ0U2lnbmluZ1JlcXVlc3RNZXRob2RUeXBlAQEzAAAvAQEzADMAAAABAf////8CAAAAF2CpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBNAAALgBENAAAAJYEAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9u" +
           "SWQAEf////8AAAAAAAEAKgEBIQAAABIAAABDZXJ0aWZpY2F0ZUdyb3VwSWQAEf////8AAAAAAAEAKgEB" +
           "IAAAABEAAABDZXJ0aWZpY2F0ZVR5cGVJZAAR/////wAAAAAAAQAqAQEhAAAAEgAAAENlcnRpZmljYXRl" +
           "UmVxdWVzdAAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBNQAALgBENQAAAJYBAAAAAQAqAQEYAAAACQAAAFJlcXVlc3RJZAAR/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public StartSigningRequestMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];
            NodeId certificateGroupId = (NodeId)_inputArguments[1];
            NodeId certificateTypeId = (NodeId)_inputArguments[2];
            byte[] certificateRequest = (byte[])_inputArguments[3];

            NodeId requestId = (NodeId)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    certificateGroupId,
                    certificateTypeId,
                    certificateRequest,
                    ref requestId);
            }

            _outputArguments[0] = requestId;

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
    public delegate ServiceResult StartSigningRequestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        NodeId certificateGroupId,
        NodeId certificateTypeId,
        byte[] certificateRequest,
        ref NodeId requestId);
    #endif
    #endregion

    #region StartNewKeyPairRequestMethodState Class
    #if (!OPCUA_EXCLUDE_StartNewKeyPairRequestMethodState)
    /// <summary>
    /// Stores an instance of the StartNewKeyPairRequestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartNewKeyPairRequestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StartNewKeyPairRequestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new StartNewKeyPairRequestMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAIAAAAFN0" +
           "YXJ0TmV3S2V5UGFpclJlcXVlc3RNZXRob2RUeXBlAQEwAAAvAQEwADAAAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBMQAALgBEMQAAAJYHAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0" +
           "aW9uSWQAEf////8AAAAAAAEAKgEBIQAAABIAAABDZXJ0aWZpY2F0ZUdyb3VwSWQAEf////8AAAAAAAEA" +
           "KgEBIAAAABEAAABDZXJ0aWZpY2F0ZVR5cGVJZAAR/////wAAAAAAAQAqAQEaAAAACwAAAFN1YmplY3RO" +
           "YW1lAAz/////AAAAAAABACoBAR4AAAALAAAARG9tYWluTmFtZXMADAEAAAABAAAAAAAAAAABACoBAR8A" +
           "AAAQAAAAUHJpdmF0ZUtleUZvcm1hdAAM/////wAAAAAAAQAqAQEhAAAAEgAAAFByaXZhdGVLZXlQYXNz" +
           "d29yZAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBMgAALgBEMgAAAJYBAAAAAQAqAQEYAAAACQAAAFJlcXVlc3RJZAAR/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public StartNewKeyPairRequestMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];
            NodeId certificateGroupId = (NodeId)_inputArguments[1];
            NodeId certificateTypeId = (NodeId)_inputArguments[2];
            string subjectName = (string)_inputArguments[3];
            string[] domainNames = (string[])_inputArguments[4];
            string privateKeyFormat = (string)_inputArguments[5];
            string privateKeyPassword = (string)_inputArguments[6];

            NodeId requestId = (NodeId)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    certificateGroupId,
                    certificateTypeId,
                    subjectName,
                    domainNames,
                    privateKeyFormat,
                    privateKeyPassword,
                    ref requestId);
            }

            _outputArguments[0] = requestId;

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
    public delegate ServiceResult StartNewKeyPairRequestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        NodeId certificateGroupId,
        NodeId certificateTypeId,
        string subjectName,
        string[] domainNames,
        string privateKeyFormat,
        string privateKeyPassword,
        ref NodeId requestId);
    #endif
    #endregion

    #region FinishRequestMethodState Class
    #if (!OPCUA_EXCLUDE_FinishRequestMethodState)
    /// <summary>
    /// Stores an instance of the FinishRequestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FinishRequestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FinishRequestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new FinishRequestMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAFwAAAEZp" +
           "bmlzaFJlcXVlc3RNZXRob2RUeXBlAQE5AAAvAQE5ADkAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBOgAALgBEOgAAAJYCAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9uSWQAEf//" +
           "//8AAAAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAEf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATsAAC4ARDsAAACWAwAAAAEAKgEBGgAA" +
           "AAsAAABDZXJ0aWZpY2F0ZQAP/////wAAAAAAAQAqAQEZAAAACgAAAFByaXZhdGVLZXkAD/////8AAAAA" +
           "AAEAKgEBJQAAABIAAABJc3N1ZXJDZXJ0aWZpY2F0ZXMADwEAAAABAAAAAAAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public FinishRequestMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];
            NodeId requestId = (NodeId)_inputArguments[1];

            byte[] certificate = (byte[])_outputArguments[0];
            byte[] privateKey = (byte[])_outputArguments[1];
            byte[][] issuerCertificates = (byte[][])_outputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    requestId,
                    ref certificate,
                    ref privateKey,
                    ref issuerCertificates);
            }

            _outputArguments[0] = certificate;
            _outputArguments[1] = privateKey;
            _outputArguments[2] = issuerCertificates;

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
    public delegate ServiceResult FinishRequestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        NodeId requestId,
        ref byte[] certificate,
        ref byte[] privateKey,
        ref byte[][] issuerCertificates);
    #endif
    #endregion

    #region GetCertificateGroupsMethodState Class
    #if (!OPCUA_EXCLUDE_GetCertificateGroupsMethodState)
    /// <summary>
    /// Stores an instance of the GetCertificateGroupsMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetCertificateGroupsMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetCertificateGroupsMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetCertificateGroupsMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAHgAAAEdl" +
           "dENlcnRpZmljYXRlR3JvdXBzTWV0aG9kVHlwZQEB5gAALwEB5gDmAAAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAecAAC4AROcAAACWAQAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlv" +
           "bklkABH/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQHoAAAuAEToAAAAlgEAAAABACoBASYAAAATAAAAQ2VydGlmaWNhdGVHcm91cElkcwAR" +
           "AQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetCertificateGroupsMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];

            NodeId[] certificateGroupIds = (NodeId[])_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    ref certificateGroupIds);
            }

            _outputArguments[0] = certificateGroupIds;

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
    public delegate ServiceResult GetCertificateGroupsMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        ref NodeId[] certificateGroupIds);
    #endif
    #endregion

    #region GetTrustListMethodState Class
    #if (!OPCUA_EXCLUDE_GetTrustListMethodState)
    /// <summary>
    /// Stores an instance of the GetTrustListMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetTrustListMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetTrustListMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetTrustListMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAFgAAAEdl" +
           "dFRydXN0TGlzdE1ldGhvZFR5cGUBAb4AAC8BAb4AvgAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQG/AAAuAES/AAAAlgIAAAABACoBARwAAAANAAAAQXBwbGljYXRpb25JZAAR////" +
           "/wAAAAAAAQAqAQEhAAAAEgAAAENlcnRpZmljYXRlR3JvdXBJZAAR/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBwAAALgBEwAAAAJYBAAAA" +
           "AQAqAQEaAAAACwAAAFRydXN0TGlzdElkABH/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetTrustListMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];
            NodeId certificateGroupId = (NodeId)_inputArguments[1];

            NodeId trustListId = (NodeId)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    certificateGroupId,
                    ref trustListId);
            }

            _outputArguments[0] = trustListId;

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
    public delegate ServiceResult GetTrustListMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        NodeId certificateGroupId,
        ref NodeId trustListId);
    #endif
    #endregion

    #region GetCertificateStatusMethodState Class
    #if (!OPCUA_EXCLUDE_GetCertificateStatusMethodState)
    /// <summary>
    /// Stores an instance of the GetCertificateStatusMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetCertificateStatusMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetCertificateStatusMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetCertificateStatusMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYYIKBAAAAAEAHgAAAEdl" +
           "dENlcnRpZmljYXRlU3RhdHVzTWV0aG9kVHlwZQEB2wAALwEB2wDbAAAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAdwAAC4ARNwAAACWAwAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlv" +
           "bklkABH/////AAAAAAABACoBASEAAAASAAAAQ2VydGlmaWNhdGVHcm91cElkABH/////AAAAAAABACoB" +
           "ASAAAAARAAAAQ2VydGlmaWNhdGVUeXBlSWQAEf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAd0AAC4ARN0AAACWAQAAAAEAKgEBHQAAAA4A" +
           "AABVcGRhdGVSZXF1aXJlZAAB/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetCertificateStatusMethodStateMethodCallHandler OnCall;
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

            NodeId applicationId = (NodeId)_inputArguments[0];
            NodeId certificateGroupId = (NodeId)_inputArguments[1];
            NodeId certificateTypeId = (NodeId)_inputArguments[2];

            bool updateRequired = (bool)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    applicationId,
                    certificateGroupId,
                    certificateTypeId,
                    ref updateRequired);
            }

            _outputArguments[0] = updateRequired;

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
    public delegate ServiceResult GetCertificateStatusMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId applicationId,
        NodeId certificateGroupId,
        NodeId certificateTypeId,
        ref bool updateRequired);
    #endif
    #endregion

    #region CertificateDirectoryState Class
    #if (!OPCUA_EXCLUDE_CertificateDirectoryState)
    /// <summary>
    /// Stores an instance of the CertificateDirectoryType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CertificateDirectoryState : DirectoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CertificateDirectoryState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Gds.ObjectTypes.CertificateDirectoryType, Opc.Ua.Gds.Namespaces.OpcUaGds, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "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" +
           "bnRzAQFOAAAuAEROAAAAlgEAAAABACoBARgAAAAJAAAAUmVxdWVzdElkABH/////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQANAAAARmluaXNoUmVxdWVzdAEBVQAALwEBVQBVAAAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVYAAC4ARFYAAACWAgAAAAEAKgEB" +
           "HAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACoBARgAAAAJAAAAUmVxdWVzdElkABH/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQFXAAAuAERXAAAAlgMAAAABACoBARoAAAALAAAAQ2VydGlmaWNhdGUAD/////8AAAAAAAEAKgEBGQAA" +
           "AAoAAABQcml2YXRlS2V5AA//////AAAAAAABACoBASUAAAASAAAASXNzdWVyQ2VydGlmaWNhdGVzAA8B" +
           "AAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAFAAAAEdldENlcnRp" +
           "ZmljYXRlR3JvdXBzAQFxAQAvAQFxAXEBAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBcgEALgBEcgEAAJYBAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9uSWQAEf////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXMBAC4A" +
           "RHMBAACWAQAAAAEAKgEBJgAAABMAAABDZXJ0aWZpY2F0ZUdyb3VwSWRzABEBAAAAAQAAAAAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEADAAAAEdldFRydXN0TGlzdAEBxQAALwEBxQDF" +
           "AAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcYAAC4ARMYAAACWAgAAAAEA" +
           "KgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACoBASEAAAASAAAAQ2VydGlmaWNhdGVH" +
           "cm91cElkABH/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQHHAAAuAETHAAAAlgEAAAABACoBARoAAAALAAAAVHJ1c3RMaXN0SWQAEf////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABQAAABHZXRDZXJ0aWZpY2F0ZVN0" +
           "YXR1cwEB3gAALwEB3gDeAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAd8A" +
           "AC4ARN8AAACWAwAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACoBASEAAAAS" +
           "AAAAQ2VydGlmaWNhdGVHcm91cElkABH/////AAAAAAABACoBASAAAAARAAAAQ2VydGlmaWNhdGVUeXBl" +
           "SWQAEf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAeAAAC4AROAAAACWAQAAAAEAKgEBHQAAAA4AAABVcGRhdGVSZXF1aXJlZAAB/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CertificateGroupFolderState CertificateGroups
        {
            get
            {
                return m_certificateGroups;
            }

            set
            {
                if (!Object.ReferenceEquals(m_certificateGroups, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_certificateGroups = value;
            }
        }

        /// <remarks />
        public StartSigningRequestMethodState StartSigningRequest
        {
            get
            {
                return m_startSigningRequestMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startSigningRequestMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startSigningRequestMethod = value;
            }
        }

        /// <remarks />
        public StartNewKeyPairRequestMethodState StartNewKeyPairRequest
        {
            get
            {
                return m_startNewKeyPairRequestMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startNewKeyPairRequestMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startNewKeyPairRequestMethod = value;
            }
        }

        /// <remarks />
        public FinishRequestMethodState FinishRequest
        {
            get
            {
                return m_finishRequestMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_finishRequestMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_finishRequestMethod = value;
            }
        }

        /// <remarks />
        public GetCertificateGroupsMethodState GetCertificateGroups
        {
            get
            {
                return m_getCertificateGroupsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getCertificateGroupsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getCertificateGroupsMethod = value;
            }
        }

        /// <remarks />
        public GetTrustListMethodState GetTrustList
        {
            get
            {
                return m_getTrustListMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getTrustListMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getTrustListMethod = value;
            }
        }

        /// <remarks />
        public GetCertificateStatusMethodState GetCertificateStatus
        {
            get
            {
                return m_getCertificateStatusMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getCertificateStatusMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getCertificateStatusMethod = value;
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
            if (m_certificateGroups != null)
            {
                children.Add(m_certificateGroups);
            }

            if (m_startSigningRequestMethod != null)
            {
                children.Add(m_startSigningRequestMethod);
            }

            if (m_startNewKeyPairRequestMethod != null)
            {
                children.Add(m_startNewKeyPairRequestMethod);
            }

            if (m_finishRequestMethod != null)
            {
                children.Add(m_finishRequestMethod);
            }

            if (m_getCertificateGroupsMethod != null)
            {
                children.Add(m_getCertificateGroupsMethod);
            }

            if (m_getTrustListMethod != null)
            {
                children.Add(m_getTrustListMethod);
            }

            if (m_getCertificateStatusMethod != null)
            {
                children.Add(m_getCertificateStatusMethod);
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
                case Opc.Ua.Gds.BrowseNames.CertificateGroups:
                {
                    if (createOrReplace)
                    {
                        if (CertificateGroups == null)
                        {
                            if (replacement == null)
                            {
                                CertificateGroups = new CertificateGroupFolderState(this);
                            }
                            else
                            {
                                CertificateGroups = (CertificateGroupFolderState)replacement;
                            }
                        }
                    }

                    instance = CertificateGroups;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.StartSigningRequest:
                {
                    if (createOrReplace)
                    {
                        if (StartSigningRequest == null)
                        {
                            if (replacement == null)
                            {
                                StartSigningRequest = new StartSigningRequestMethodState(this);
                            }
                            else
                            {
                                StartSigningRequest = (StartSigningRequestMethodState)replacement;
                            }
                        }
                    }

                    instance = StartSigningRequest;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.StartNewKeyPairRequest:
                {
                    if (createOrReplace)
                    {
                        if (StartNewKeyPairRequest == null)
                        {
                            if (replacement == null)
                            {
                                StartNewKeyPairRequest = new StartNewKeyPairRequestMethodState(this);
                            }
                            else
                            {
                                StartNewKeyPairRequest = (StartNewKeyPairRequestMethodState)replacement;
                            }
                        }
                    }

                    instance = StartNewKeyPairRequest;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.FinishRequest:
                {
                    if (createOrReplace)
                    {
                        if (FinishRequest == null)
                        {
                            if (replacement == null)
                            {
                                FinishRequest = new FinishRequestMethodState(this);
                            }
                            else
                            {
                                FinishRequest = (FinishRequestMethodState)replacement;
                            }
                        }
                    }

                    instance = FinishRequest;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.GetCertificateGroups:
                {
                    if (createOrReplace)
                    {
                        if (GetCertificateGroups == null)
                        {
                            if (replacement == null)
                            {
                                GetCertificateGroups = new GetCertificateGroupsMethodState(this);
                            }
                            else
                            {
                                GetCertificateGroups = (GetCertificateGroupsMethodState)replacement;
                            }
                        }
                    }

                    instance = GetCertificateGroups;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.GetTrustList:
                {
                    if (createOrReplace)
                    {
                        if (GetTrustList == null)
                        {
                            if (replacement == null)
                            {
                                GetTrustList = new GetTrustListMethodState(this);
                            }
                            else
                            {
                                GetTrustList = (GetTrustListMethodState)replacement;
                            }
                        }
                    }

                    instance = GetTrustList;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.GetCertificateStatus:
                {
                    if (createOrReplace)
                    {
                        if (GetCertificateStatus == null)
                        {
                            if (replacement == null)
                            {
                                GetCertificateStatus = new GetCertificateStatusMethodState(this);
                            }
                            else
                            {
                                GetCertificateStatus = (GetCertificateStatusMethodState)replacement;
                            }
                        }
                    }

                    instance = GetCertificateStatus;
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
        private CertificateGroupFolderState m_certificateGroups;
        private StartSigningRequestMethodState m_startSigningRequestMethod;
        private StartNewKeyPairRequestMethodState m_startNewKeyPairRequestMethod;
        private FinishRequestMethodState m_finishRequestMethod;
        private GetCertificateGroupsMethodState m_getCertificateGroupsMethod;
        private GetTrustListMethodState m_getTrustListMethod;
        private GetCertificateStatusMethodState m_getCertificateStatusMethod;
        #endregion
    }
    #endif
    #endregion

    #region CertificateRequestedAuditEventState Class
    #if (!OPCUA_EXCLUDE_CertificateRequestedAuditEventState)
    /// <summary>
    /// Stores an instance of the CertificateRequestedAuditEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CertificateRequestedAuditEventState : AuditUpdateMethodEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CertificateRequestedAuditEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Gds.ObjectTypes.CertificateRequestedAuditEventType, Opc.Ua.Gds.Namespaces.OpcUaGds, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIACAQAAAAEAKgAAAENl" +
           "cnRpZmljYXRlUmVxdWVzdGVkQXVkaXRFdmVudFR5cGVJbnN0YW5jZQEBWwABAVsAWwAAAP////8SAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQFcAAAuAERcAAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQFdAAAuAERdAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBXgAALgBEXgAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAV8A" +
           "AC4ARF8AAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFgAAAuAERgAAAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBYQAALgBEYQAAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFiAAAuAERiAAAAAQDQIv////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQFjAAAuAERjAAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAWQAAC4ARGQAAAAABf////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABBY3Rpb25U" +
           "aW1lU3RhbXABAWUAAC4ARGUAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFN0YXR1cwEB" +
           "ZgAALgBEZgAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNlcnZlcklkAQFnAAAuAERnAAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ2xpZW50QXVkaXRFbnRyeUlkAQFoAAAuAERoAAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFpAAAuAERpAAAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAIAAAATWV0aG9kSWQBAWoAAC4ARGoAAAAAEf////8BAf////8AAAAA" +
           "F2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBawAALgBEawAAAAAYAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABVgiQoCAAAAAQAQAAAAQ2VydGlmaWNhdGVHcm91cAEBzQIALgBEzQIAAAAR/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEADwAAAENlcnRpZmljYXRlVHlwZQEBzgIALgBEzgIAAAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<NodeId> CertificateGroup
        {
            get
            {
                return m_certificateGroup;
            }

            set
            {
                if (!Object.ReferenceEquals(m_certificateGroup, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_certificateGroup = value;
            }
        }

        /// <remarks />
        public PropertyState<NodeId> CertificateType
        {
            get
            {
                return m_certificateType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_certificateType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_certificateType = value;
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
            if (m_certificateGroup != null)
            {
                children.Add(m_certificateGroup);
            }

            if (m_certificateType != null)
            {
                children.Add(m_certificateType);
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
                case Opc.Ua.Gds.BrowseNames.CertificateGroup:
                {
                    if (createOrReplace)
                    {
                        if (CertificateGroup == null)
                        {
                            if (replacement == null)
                            {
                                CertificateGroup = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                CertificateGroup = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = CertificateGroup;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.CertificateType:
                {
                    if (createOrReplace)
                    {
                        if (CertificateType == null)
                        {
                            if (replacement == null)
                            {
                                CertificateType = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                CertificateType = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = CertificateType;
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
        private PropertyState<NodeId> m_certificateGroup;
        private PropertyState<NodeId> m_certificateType;
        #endregion
    }
    #endif
    #endregion

    #region CertificateDeliveredAuditEventState Class
    #if (!OPCUA_EXCLUDE_CertificateDeliveredAuditEventState)
    /// <summary>
    /// Stores an instance of the CertificateDeliveredAuditEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CertificateDeliveredAuditEventState : AuditUpdateMethodEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CertificateDeliveredAuditEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Gds.ObjectTypes.CertificateDeliveredAuditEventType, Opc.Ua.Gds.Namespaces.OpcUaGds, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIACAQAAAAEAKgAAAENl" +
           "cnRpZmljYXRlRGVsaXZlcmVkQXVkaXRFdmVudFR5cGVJbnN0YW5jZQEBbQABAW0AbQAAAP////8SAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQFuAAAuAERuAAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQFvAAAuAERvAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBcAAALgBEcAAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAXEA" +
           "AC4ARHEAAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFyAAAuAERyAAAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBcwAALgBEcwAAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQF0AAAuAER0AAAAAQDQIv////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQF1AAAuAER1AAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAXYAAC4ARHYAAAAABf////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABBY3Rpb25U" +
           "aW1lU3RhbXABAXcAAC4ARHcAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFN0YXR1cwEB" +
           "eAAALgBEeAAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNlcnZlcklkAQF5AAAuAER5AAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ2xpZW50QXVkaXRFbnRyeUlkAQF6AAAuAER6AAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQF7AAAuAER7AAAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAIAAAATWV0aG9kSWQBAXwAAC4ARHwAAAAAEf////8BAf////8AAAAA" +
           "F2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBfQAALgBEfQAAAAAYAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABVgiQoCAAAAAQAQAAAAQ2VydGlmaWNhdGVHcm91cAEBzwIALgBEzwIAAAAR/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEADwAAAENlcnRpZmljYXRlVHlwZQEB0AIALgBE0AIAAAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<NodeId> CertificateGroup
        {
            get
            {
                return m_certificateGroup;
            }

            set
            {
                if (!Object.ReferenceEquals(m_certificateGroup, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_certificateGroup = value;
            }
        }

        /// <remarks />
        public PropertyState<NodeId> CertificateType
        {
            get
            {
                return m_certificateType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_certificateType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_certificateType = value;
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
            if (m_certificateGroup != null)
            {
                children.Add(m_certificateGroup);
            }

            if (m_certificateType != null)
            {
                children.Add(m_certificateType);
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
                case Opc.Ua.Gds.BrowseNames.CertificateGroup:
                {
                    if (createOrReplace)
                    {
                        if (CertificateGroup == null)
                        {
                            if (replacement == null)
                            {
                                CertificateGroup = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                CertificateGroup = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = CertificateGroup;
                    break;
                }

                case Opc.Ua.Gds.BrowseNames.CertificateType:
                {
                    if (createOrReplace)
                    {
                        if (CertificateType == null)
                        {
                            if (replacement == null)
                            {
                                CertificateType = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                CertificateType = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = CertificateType;
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
        private PropertyState<NodeId> m_certificateGroup;
        private PropertyState<NodeId> m_certificateType;
        #endregion
    }
    #endif
    #endregion
}
