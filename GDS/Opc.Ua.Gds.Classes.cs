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
           "bmRBcHBsaWNhdGlvbnNNZXRob2RUeXBlAQECAAAvAQECAAIAAAABAf////8CAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBAwAALgBEAwAAAJYBAAAAAQAqAQEdAAAADgAAAEFwcGxpY2F0aW9uVXJp" +
           "AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "BAAALgBEBAAAAJYBAAAAAQAqAQEdAAAADAAAAEFwcGxpY2F0aW9ucwEBAQABAAAAAAAAAAABACgBAQAA" +
           "AAEB/////wAAAAA=";
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
           "Z2lzdGVyQXBwbGljYXRpb25NZXRob2RUeXBlAQEFAAAvAQEFAAUAAAABAf////8CAAAAFWCpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBBgAALgBEBgAAAJYBAAAAAQAqAQEcAAAACwAAAEFwcGxpY2F0aW9u" +
           "AQEBAP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQEHAAAuAEQHAAAAlgEAAAABACoBARwAAAANAAAAQXBwbGljYXRpb25JZAAR/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAA";
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
           "ZGF0ZUFwcGxpY2F0aW9uTWV0aG9kVHlwZQEBugAALwEBugC6AAAAAQH/////AQAAABVgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAbsAAC4ARLsAAACWAQAAAAEAKgEBHAAAAAsAAABBcHBsaWNhdGlvbgEB" +
           "AQD/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
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
           "cmVnaXN0ZXJBcHBsaWNhdGlvbk1ldGhvZFR5cGUBAQgAAC8BAQgACAAAAAEB/////wEAAAAVYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQEJAAAuAEQJAAAAlgEAAAABACoBARwAAAANAAAAQXBwbGljYXRp" +
           "b25JZAAR/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
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
           "dEFwcGxpY2F0aW9uTWV0aG9kVHlwZQEBzwAALwEBzwDPAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAdAAAC4ARNAAAACWAQAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB0QAA" +
           "LgBE0QAAAJYBAAAAAQAqAQEcAAAACwAAAEFwcGxpY2F0aW9uAQEBAP////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAA==";
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
           "ZXJ5U2VydmVyc01ldGhvZFR5cGUBAQoAAC8BAQoACgAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQELAAAuAEQLAAAAlgYAAAABACoBAR8AAAAQAAAAU3RhcnRpbmdSZWNvcmRJZAAH" +
           "/////wAAAAAAAQAqAQEhAAAAEgAAAE1heFJlY29yZHNUb1JldHVybgAH/////wAAAAAAAQAqAQEeAAAA" +
           "DwAAAEFwcGxpY2F0aW9uTmFtZQAM/////wAAAAAAAQAqAQEdAAAADgAAAEFwcGxpY2F0aW9uVXJpAAz/" +
           "////AAAAAAABACoBARkAAAAKAAAAUHJvZHVjdFVyaQAM/////wAAAAAAAQAqAQEhAAAAEgAAAFNlcnZl" +
           "ckNhcGFiaWxpdGllcwAMAQAAAAAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAQwAAC4ARAwAAACWAgAAAAEAKgEBJQAAABQAAABMYXN0Q291bnRlclJlc2V0VGlt" +
           "ZQEAJgH/////AAAAAAABACoBARgAAAAHAAAAU2VydmVycwEAnS8BAAAAAAAAAAABACgBAQAAAAEB////" +
           "/wAAAAA=";
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIAAAQAAAAEAFQAAAERp" +
           "cmVjdG9yeVR5cGVJbnN0YW5jZQEBDQABAQ0A/////wcAAAAEYIAKAQAAAAEADAAAAEFwcGxpY2F0aW9u" +
           "cwEBDgAALwA9DgAAAP////8AAAAABGGCCgQAAAABABAAAABGaW5kQXBwbGljYXRpb25zAQEPAAAvAQEP" +
           "AA8AAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEAAALgBEEAAAAJYBAAAA" +
           "AQAqAQEdAAAADgAAAEFwcGxpY2F0aW9uVXJpAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBEQAALgBEEQAAAJYBAAAAAQAqAQEdAAAADAAAAEFwcGxp" +
           "Y2F0aW9ucwEBAQABAAAAAAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAFJlZ2lzdGVy" +
           "QXBwbGljYXRpb24BARIAAC8BARIAEgAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQETAAAuAEQTAAAAlgEAAAABACoBARwAAAALAAAAQXBwbGljYXRpb24BAQEA/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARQAAC4ARBQAAACWAQAA" +
           "AAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEAEQAAAFVwZGF0ZUFwcGxpY2F0aW9uAQG8AAAvAQG8ALwAAAABAf////8BAAAAFWCpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBvQAALgBEvQAAAJYBAAAAAQAqAQEcAAAACwAAAEFwcGxpY2F0aW9u" +
           "AQEBAP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAVAAAAVW5yZWdpc3RlckFwcGxp" +
           "Y2F0aW9uAQEVAAAvAQEVABUAAAABAf////8BAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "FgAALgBEFgAAAJYBAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9uSWQAEf////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAAARhggoEAAAAAQAOAAAAR2V0QXBwbGljYXRpb24BAdIAAC8BAdIA0gAAAAEB/////wIA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHTAAAuAETTAAAAlgEAAAABACoBARwAAAANAAAA" +
           "QXBwbGljYXRpb25JZAAR/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAdQAAC4ARNQAAACWAQAAAAEAKgEBHAAAAAsAAABBcHBsaWNhdGlvbgEBAQD/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADAAAAFF1ZXJ5U2VydmVycwEBFwAALwEBFwAX" +
           "AAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBARgAAC4ARBgAAACWBgAAAAEA" +
           "KgEBHwAAABAAAABTdGFydGluZ1JlY29yZElkAAf/////AAAAAAABACoBASEAAAASAAAATWF4UmVjb3Jk" +
           "c1RvUmV0dXJuAAf/////AAAAAAABACoBAR4AAAAPAAAAQXBwbGljYXRpb25OYW1lAAz/////AAAAAAAB" +
           "ACoBAR0AAAAOAAAAQXBwbGljYXRpb25VcmkADP////8AAAAAAAEAKgEBGQAAAAoAAABQcm9kdWN0VXJp" +
           "AAz/////AAAAAAABACoBASEAAAASAAAAU2VydmVyQ2FwYWJpbGl0aWVzAAwBAAAAAAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBGQAALgBEGQAAAJYCAAAAAQAq" +
           "AQElAAAAFAAAAExhc3RDb3VudGVyUmVzZXRUaW1lAQAmAf////8AAAAAAAEAKgEBGAAAAAcAAABTZXJ2" +
           "ZXJzAQCdLwEAAAAAAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIAAAQAAAAEANAAAAEFw" +
           "cGxpY2F0aW9uUmVnaXN0cmF0aW9uQ2hhbmdlZEF1ZGl0RXZlbnRUeXBlSW5zdGFuY2UBARoAAQEaAP//" +
           "//8QAAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQEbAAAuAEQbAAAAAA//////AQH/////AAAAABVgiQoC" +
           "AAAAAAAJAAAARXZlbnRUeXBlAQEcAAAuAEQcAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAA" +
           "U291cmNlTm9kZQEBHQAALgBEHQAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5h" +
           "bWUBAR4AAC4ARB4AAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEfAAAuAEQfAAAA" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBIAAALgBEIAAAAAEAJgH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQEhAAAuAEQhAAAAAQDQIv////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQEiAAAuAEQiAAAAABX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAIAAAAU2V2ZXJpdHkBASMAAC4ARCMAAAAABf////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABB" +
           "Y3Rpb25UaW1lU3RhbXABASQAAC4ARCQAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFN0" +
           "YXR1cwEBJQAALgBEJQAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNlcnZlcklkAQEmAAAu" +
           "AEQmAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ2xpZW50QXVkaXRFbnRyeUlkAQEnAAAu" +
           "AEQnAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEoAAAuAEQoAAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAATWV0aG9kSWQBASkAAC4ARCkAAAAAEf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBKgAALgBEKgAAAAAYAQAAAAEB/////wAA" +
           "AAA=";
        #endregion
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
           "YXJ0U2lnbmluZ1JlcXVlc3RNZXRob2RUeXBlAQEzAAAvAQEzADMAAAABAf////8CAAAAFWCpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBNAAALgBENAAAAJYEAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9u" +
           "SWQAEf////8AAAAAAAEAKgEBIQAAABIAAABDZXJ0aWZpY2F0ZUdyb3VwSWQAEf////8AAAAAAAEAKgEB" +
           "IAAAABEAAABDZXJ0aWZpY2F0ZVR5cGVJZAAR/////wAAAAAAAQAqAQEhAAAAEgAAAENlcnRpZmljYXRl" +
           "UmVxdWVzdAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBATUAAC4ARDUAAACWAQAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAEf////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAA==";
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
           "YXJ0TmV3S2V5UGFpclJlcXVlc3RNZXRob2RUeXBlAQEwAAAvAQEwADAAAAABAf////8CAAAAFWCpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBMQAALgBEMQAAAJYHAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0" +
           "aW9uSWQAEf////8AAAAAAAEAKgEBIQAAABIAAABDZXJ0aWZpY2F0ZUdyb3VwSWQAEf////8AAAAAAAEA" +
           "KgEBIAAAABEAAABDZXJ0aWZpY2F0ZVR5cGVJZAAR/////wAAAAAAAQAqAQEaAAAACwAAAFN1YmplY3RO" +
           "YW1lAAz/////AAAAAAABACoBARoAAAALAAAARG9tYWluTmFtZXMADAEAAAAAAAAAAAEAKgEBHwAAABAA" +
           "AABQcml2YXRlS2V5Rm9ybWF0AAz/////AAAAAAABACoBASEAAAASAAAAUHJpdmF0ZUtleVBhc3N3b3Jk" +
           "AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "MgAALgBEMgAAAJYBAAAAAQAqAQEYAAAACQAAAFJlcXVlc3RJZAAR/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAA";
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
           "bmlzaFJlcXVlc3RNZXRob2RUeXBlAQE5AAAvAQE5ADkAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBOgAALgBEOgAAAJYCAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9uSWQAEf//" +
           "//8AAAAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAEf////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE7AAAuAEQ7AAAAlgMAAAABACoBARoAAAALAAAAQ2Vy" +
           "dGlmaWNhdGUAD/////8AAAAAAAEAKgEBGQAAAAoAAABQcml2YXRlS2V5AA//////AAAAAAABACoBASEA" +
           "AAASAAAASXNzdWVyQ2VydGlmaWNhdGVzAA8BAAAAAAAAAAABACgBAQAAAAEB/////wAAAAA=";
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
           "dENlcnRpZmljYXRlR3JvdXBzTWV0aG9kVHlwZQEB5gAALwEB5gDmAAAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAecAAC4AROcAAACWAQAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlv" +
           "bklkABH/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50" +
           "cwEB6AAALgBE6AAAAJYBAAAAAQAqAQEiAAAAEwAAAENlcnRpZmljYXRlR3JvdXBJZHMAEQEAAAAAAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAAA==";
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
           "dFRydXN0TGlzdE1ldGhvZFR5cGUBAb4AAC8BAb4AvgAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQG/AAAuAES/AAAAlgIAAAABACoBARwAAAANAAAAQXBwbGljYXRpb25JZAAR////" +
           "/wAAAAAAAQAqAQEhAAAAEgAAAENlcnRpZmljYXRlR3JvdXBJZAAR/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAcAAAC4ARMAAAACWAQAAAAEAKgEBGgAA" +
           "AAsAAABUcnVzdExpc3RJZAAR/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
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
           "dENlcnRpZmljYXRlU3RhdHVzTWV0aG9kVHlwZQEB2wAALwEB2wDbAAAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAdwAAC4ARNwAAACWAwAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlv" +
           "bklkABH/////AAAAAAABACoBASEAAAASAAAAQ2VydGlmaWNhdGVHcm91cElkABH/////AAAAAAABACoB" +
           "ASAAAAARAAAAQ2VydGlmaWNhdGVUeXBlSWQAEf////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHdAAAuAETdAAAAlgEAAAABACoBAR0AAAAOAAAAVXBkYXRl" +
           "UmVxdWlyZWQAAf////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIAAAQAAAAEAIAAAAENl" +
           "cnRpZmljYXRlRGlyZWN0b3J5VHlwZUluc3RhbmNlAQE/AAEBPwD/////DgAAAARggAoBAAAAAQAMAAAA" +
           "QXBwbGljYXRpb25zAQFAAAAvAD1AAAAA/////wAAAAAEYYIKBAAAAAEAEAAAAEZpbmRBcHBsaWNhdGlv" +
           "bnMBAUEAAC8BAQ8AQQAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFCAAAu" +
           "AERCAAAAlgEAAAABACoBAR0AAAAOAAAAQXBwbGljYXRpb25VcmkADP////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFDAAAuAERDAAAAlgEAAAABACoBAR0A" +
           "AAAMAAAAQXBwbGljYXRpb25zAQEBAAEAAAAAAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAT" +
           "AAAAUmVnaXN0ZXJBcHBsaWNhdGlvbgEBRAAALwEBEgBEAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAUUAAC4AREUAAACWAQAAAAEAKgEBHAAAAAsAAABBcHBsaWNhdGlvbgEBAQD/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBRgAA" +
           "LgBERgAAAJYBAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9uSWQAEf////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQARAAAAVXBkYXRlQXBwbGljYXRpb24BAcEAAC8BAbwAwQAAAAEB/////wEA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHCAAAuAETCAAAAlgEAAAABACoBARwAAAALAAAA" +
           "QXBwbGljYXRpb24BAQEA/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABABUAAABVbnJl" +
           "Z2lzdGVyQXBwbGljYXRpb24BAUcAAC8BARUARwAAAAEB/////wEAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQFIAAAuAERIAAAAlgEAAAABACoBARwAAAANAAAAQXBwbGljYXRpb25JZAAR/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAA4AAABHZXRBcHBsaWNhdGlvbgEB1QAALwEB0gDV" +
           "AAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAdYAAC4ARNYAAACWAQAAAAEA" +
           "KgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEB1wAALgBE1wAAAJYBAAAAAQAqAQEcAAAACwAAAEFwcGxpY2F0" +
           "aW9uAQEBAP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAMAAAAUXVlcnlTZXJ2ZXJz" +
           "AQFJAAAvAQEXAEkAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBSgAALgBE" +
           "SgAAAJYGAAAAAQAqAQEfAAAAEAAAAFN0YXJ0aW5nUmVjb3JkSWQAB/////8AAAAAAAEAKgEBIQAAABIA" +
           "AABNYXhSZWNvcmRzVG9SZXR1cm4AB/////8AAAAAAAEAKgEBHgAAAA8AAABBcHBsaWNhdGlvbk5hbWUA" +
           "DP////8AAAAAAAEAKgEBHQAAAA4AAABBcHBsaWNhdGlvblVyaQAM/////wAAAAAAAQAqAQEZAAAACgAA" +
           "AFByb2R1Y3RVcmkADP////8AAAAAAAEAKgEBIQAAABIAAABTZXJ2ZXJDYXBhYmlsaXRpZXMADAEAAAAA" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFLAAAuAERL" +
           "AAAAlgIAAAABACoBASUAAAAUAAAATGFzdENvdW50ZXJSZXNldFRpbWUBACYB/////wAAAAAAAQAqAQEY" +
           "AAAABwAAAFNlcnZlcnMBAJ0vAQAAAAAAAAAAAQAoAQEAAAABAf////8AAAAABGCACgEAAAABABEAAABD" +
           "ZXJ0aWZpY2F0ZUdyb3VwcwEB/wEAIwEA9TX/AQAA/////wEAAAAEYIAKAQAAAAAAFwAAAERlZmF1bHRB" +
           "cHBsaWNhdGlvbkdyb3VwAQEAAgAvAQALMQACAAD/////AgAAAARggAoBAAAAAAAJAAAAVHJ1c3RMaXN0" +
           "AQEBAgAvAQDqMAECAAD/////DAAAABVgiQoCAAAAAAAEAAAAU2l6ZQEBAgIALgBEAgIAAAAJ/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACAAAAFdyaXRhYmxlAQEDAgAuAEQDAgAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAMAAAAVXNlcldyaXRhYmxlAQEEAgAuAEQEAgAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAJAAAAT3BlbkNvdW50AQEFAgAuAEQFAgAAAAX/////AQH/////AAAAAARhggoEAAAAAAAEAAAAT3Bl" +
           "bgEBBwIALwEAPC0HAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQgCAC4A" +
           "RAgCAACWAQAAAAEAKgEBEwAAAAQAAABNb2RlAAP/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBCQIALgBECQIAAJYBAAAAAQAqAQEZAAAACgAAAEZpbGVI" +
           "YW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAQoCAC8B" +
           "AD8tCgIAAAEB/////wEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQELAgAuAEQLAgAAlgEA" +
           "AAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQA" +
           "AAAAAAQAAABSZWFkAQEMAgAvAQBBLQwCAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBDQIALgBEDQIAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEB" +
           "FQAAAAYAAABMZW5ndGgABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQEOAgAuAEQOAgAAlgEAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEBDwIALwEARC0PAgAAAQH/////AQAAABVg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBARACAC4ARBACAACWAgAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "SGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAABGGCCgQAAAAAAAsAAABHZXRQb3NpdGlvbgEBEQIALwEARi0RAgAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBARICAC4ARBICAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxl" +
           "AAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "EwIALgBEEwIAAJYBAAAAAQAqAQEXAAAACAAAAFBvc2l0aW9uAAn/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAAACwAAAFNldFBvc2l0aW9uAQEUAgAvAQBJLRQCAAABAf////8BAAAAFWCpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBFQIALgBEFQIAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5k" +
           "bGUAB/////8AAAAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAAFWCJCgIAAAAAAA4AAABMYXN0VXBkYXRlVGltZQEBFgIALgBEFgIAAAEAJgH/////AQH/////AAAA" +
           "AARhggoEAAAAAAANAAAAT3BlbldpdGhNYXNrcwEBFwIALwEA/zAXAgAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBARgCAC4ARBgCAACWAQAAAAEAKgEBFAAAAAUAAABNYXNrcwAH////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARkCAC4A" +
           "RBkCAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAVYIkKAgAAAAAAEAAAAENlcnRpZmljYXRlVHlwZXMBASECAC4ARCECAAAAEQEAAAABAf////8AAAAA" +
           "BGGCCgQAAAABABMAAABTdGFydFNpZ25pbmdSZXF1ZXN0AQFPAAAvAQFPAE8AAAABAf////8CAAAAFWCp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBUAAALgBEUAAAAJYEAAAAAQAqAQEcAAAADQAAAEFwcGxp" +
           "Y2F0aW9uSWQAEf////8AAAAAAAEAKgEBIQAAABIAAABDZXJ0aWZpY2F0ZUdyb3VwSWQAEf////8AAAAA" +
           "AAEAKgEBIAAAABEAAABDZXJ0aWZpY2F0ZVR5cGVJZAAR/////wAAAAAAAQAqAQEhAAAAEgAAAENlcnRp" +
           "ZmljYXRlUmVxdWVzdAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAVEAAC4ARFEAAACWAQAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0SWQAEf////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAWAAAAU3RhcnROZXdLZXlQYWlyUmVxdWVzdAEBTAAA" +
           "LwEBTABMAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAU0AAC4ARE0AAACW" +
           "BwAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACoBASEAAAASAAAAQ2VydGlm" +
           "aWNhdGVHcm91cElkABH/////AAAAAAABACoBASAAAAARAAAAQ2VydGlmaWNhdGVUeXBlSWQAEf////8A" +
           "AAAAAAEAKgEBGgAAAAsAAABTdWJqZWN0TmFtZQAM/////wAAAAAAAQAqAQEaAAAACwAAAERvbWFpbk5h" +
           "bWVzAAwBAAAAAAAAAAABACoBAR8AAAAQAAAAUHJpdmF0ZUtleUZvcm1hdAAM/////wAAAAAAAQAqAQEh" +
           "AAAAEgAAAFByaXZhdGVLZXlQYXNzd29yZAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAU4AAC4ARE4AAACWAQAAAAEAKgEBGAAAAAkAAABSZXF1ZXN0" +
           "SWQAEf////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQANAAAARmluaXNoUmVxdWVzdAEB" +
           "VQAALwEBVQBVAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVYAAC4ARFYA" +
           "AACWAgAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACoBARgAAAAJAAAAUmVx" +
           "dWVzdElkABH/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBVwAALgBEVwAAAJYDAAAAAQAqAQEaAAAACwAAAENlcnRpZmljYXRlAA//////AAAAAAABACoB" +
           "ARkAAAAKAAAAUHJpdmF0ZUtleQAP/////wAAAAAAAQAqAQEhAAAAEgAAAElzc3VlckNlcnRpZmljYXRl" +
           "cwAPAQAAAAAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABABQAAABHZXRDZXJ0aWZpY2F0ZUdy" +
           "b3VwcwEBcQEALwEBcQFxAQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXIB" +
           "AC4ARHIBAACWAQAAAAEAKgEBHAAAAA0AAABBcHBsaWNhdGlvbklkABH/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBcwEALgBEcwEAAJYBAAAAAQAqAQEi" +
           "AAAAEwAAAENlcnRpZmljYXRlR3JvdXBJZHMAEQEAAAAAAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAMAAAAR2V0VHJ1c3RMaXN0AQHFAAAvAQHFAMUAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBxgAALgBExgAAAJYCAAAAAQAqAQEcAAAADQAAAEFwcGxpY2F0aW9uSWQAEf//" +
           "//8AAAAAAAEAKgEBIQAAABIAAABDZXJ0aWZpY2F0ZUdyb3VwSWQAEf////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHHAAAuAETHAAAAlgEAAAABACoBARoA" +
           "AAALAAAAVHJ1c3RMaXN0SWQAEf////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAUAAAA" +
           "R2V0Q2VydGlmaWNhdGVTdGF0dXMBAd4AAC8BAd4A3gAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQHfAAAuAETfAAAAlgMAAAABACoBARwAAAANAAAAQXBwbGljYXRpb25JZAAR////" +
           "/wAAAAAAAQAqAQEhAAAAEgAAAENlcnRpZmljYXRlR3JvdXBJZAAR/////wAAAAAAAQAqAQEgAAAAEQAA" +
           "AENlcnRpZmljYXRlVHlwZUlkABH/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEB4AAALgBE4AAAAJYBAAAAAQAqAQEdAAAADgAAAFVwZGF0ZVJlcXVpcmVk" +
           "AAH/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIAAAQAAAAEAKgAAAENl" +
           "cnRpZmljYXRlUmVxdWVzdGVkQXVkaXRFdmVudFR5cGVJbnN0YW5jZQEBWwABAVsA/////xIAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAVwAAC4ARFwAAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAV0AAC4ARF0AAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQFeAAAuAEReAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBXwAALgBE" +
           "XwAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAWAAAC4ARGAAAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFhAAAuAERhAAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAWIAAC4ARGIAAAABANAi/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAWMAAC4ARGMAAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBZAAALgBEZAAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAADwAAAEFjdGlvblRpbWVT" +
           "dGFtcAEBZQAALgBEZQAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAU3RhdHVzAQFmAAAu" +
           "AERmAAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2VydmVySWQBAWcAAC4ARGcAAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAABIAAABDbGllbnRBdWRpdEVudHJ5SWQBAWgAAC4ARGgAAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAWkAAC4ARGkAAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAgAAABNZXRob2RJZAEBagAALgBEagAAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFrAAAuAERrAAAAABgBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAAQ2VydGlmaWNhdGVHcm91cAEBzQIALgBEzQIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DwAAAENlcnRpZmljYXRlVHlwZQEBzgIALgBEzgIAAAAR/////wEB/////wAAAAA=";
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
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvR0RTL/////8EYIAAAQAAAAEAKgAAAENl" +
           "cnRpZmljYXRlRGVsaXZlcmVkQXVkaXRFdmVudFR5cGVJbnN0YW5jZQEBbQABAW0A/////xIAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAW4AAC4ARG4AAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAW8AAC4ARG8AAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQFwAAAuAERwAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBcQAALgBE" +
           "cQAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAXIAAC4ARHIAAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFzAAAuAERzAAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAXQAAC4ARHQAAAABANAi/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAXUAAC4ARHUAAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBdgAALgBEdgAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAADwAAAEFjdGlvblRpbWVT" +
           "dGFtcAEBdwAALgBEdwAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAU3RhdHVzAQF4AAAu" +
           "AER4AAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2VydmVySWQBAXkAAC4ARHkAAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAABIAAABDbGllbnRBdWRpdEVudHJ5SWQBAXoAAC4ARHoAAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAXsAAC4ARHsAAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAgAAABNZXRob2RJZAEBfAAALgBEfAAAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF9AAAuAER9AAAAABgBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAAQ2VydGlmaWNhdGVHcm91cAEBzwIALgBEzwIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DwAAAENlcnRpZmljYXRlVHlwZQEB0AIALgBE0AIAAAAR/////wEB/////wAAAAA=";
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
