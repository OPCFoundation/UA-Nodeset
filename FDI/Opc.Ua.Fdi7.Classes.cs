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
           "//8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASQAAwAAAAAYAAAATW9kZWwgbmFt" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARCQAAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEB" +
           "JQADAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UA" +
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
           "LwEBnQCdAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGeAAAuAESeAAAA" +
           "lgIAAAABACoBASEAAAASAAAAVG9wb2xvZ3lTY2FuUmVzdWx0ABD/////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAFJlc2V0" +
           "U2NhbgEBnwAALwEBnwCfAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGg" +
           "AAAuAESgAAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEADAAAAEFkZENvbXBvbmVudAEBpAAALwEBpACkAAAAAQH/////AgAAABVg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaUAAC4ARKUAAACWAwAAAAEAKgEBHQAAAA4AAABNb2R1" +
           "bGVUeXBlTmFtZQAM/////wAAAAAAAQAqAQEbAAAADAAAAEluc3RhbmNlTmFtZQAM/////wAAAAAAAQAq" +
           "AQEcAAAADQAAAEluc3RhbmNlTGFiZWwADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQGmAAAuAESmAAAAlgIAAAABACoBAR0AAAAOAAAASW5zdGFuY2VO" +
           "b2RlSWQAEf////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAAARhggoEAAAAAQAPAAAAUmVtb3ZlQ29tcG9uZW50AQGnAAAvAQGnAKcAAAABAf////8C" +
           "AAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBqAAALgBEqAAAAJYBAAAAAQAqAQEbAAAADAAA" +
           "AE1vZHVsZU5vZGVJZAAR/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAakAAC4ARKkAAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAU2VydmVyQ29tbXVuaWNhdGlvbkRl" +
           "dmljZVR5cGVJbnN0YW5jZQEBXQABAV0A/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBYAAD" +
           "AAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpgAAAA/////wQAAAAEYYIKBAAAAAEABAAAAFNj" +
           "YW4BAZ0AAC8BAZ0AnQAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBngAA" +
           "LgBEngAAAJYCAAAAAQAqAQEhAAAAEgAAAFRvcG9sb2d5U2NhblJlc3VsdAAQ/////wAAAAAAAQAqAQEb" +
           "AAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkA" +
           "AABSZXNldFNjYW4BAZ8AAC8BAZ8AnwAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBoAAALgBEoAAAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAABGGCCgQAAAABAAwAAABBZGRDb21wb25lbnQBAaQAAC8BAaQApAAAAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGlAAAuAESlAAAAlgMAAAABACoBAR0AAAAO" +
           "AAAATW9kdWxlVHlwZU5hbWUADP////8AAAAAAAEAKgEBGwAAAAwAAABJbnN0YW5jZU5hbWUADP////8A" +
           "AAAAAAEAKgEBHAAAAA0AAABJbnN0YW5jZUxhYmVsAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAV" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBpgAALgBEpgAAAJYCAAAAAQAqAQEdAAAADgAAAElu" +
           "c3RhbmNlTm9kZUlkABH/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADwAAAFJlbW92ZUNvbXBvbmVudAEBpwAALwEBpwCnAAAA" +
           "AQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAagAAC4ARKgAAACWAQAAAAEAKgEB" +
           "GwAAAAwAAABNb2R1bGVOb2RlSWQAEf////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQGpAAAuAESpAAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9y" +
           "ABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBdAAD" +
           "AAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZh" +
           "Y3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAER0AAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAP" +
           "AAAAUmV2aXNpb25Db3VudGVyAQF1AAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNh" +
           "dGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBo" +
           "YXMgYmVlbiBtb2RpZmllZAAuAER1AAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZh" +
           "Y3R1cmVyAQF2AAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAER2AAAAABX/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAXcAAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0" +
           "aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARHcAAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAwAAABEZXZpY2VNYW51YWwBAXgAAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUg" +
           "c3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNl" +
           "AC4ARHgAAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBeQADAAAA" +
           "ACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEeQAAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAXoAAwAAAAA1AAAAUmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEegAAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAXsAAwAAAAAsAAAAUmV2aXNpb24gbGV2" +
           "ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEewAAAAAM/////wEB/////wAAAAA=";
        #endregion
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
           "cwEBjgEALwEBjgGOAQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8BAC4A" +
           "RI8BAACWBgAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFQAAAAYAAABMaW5r" +
           "SWQABf////8AAAAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkAAAAKAAAA" +
           "TmV3QWRkcmVzcwAD/////wAAAAAAAQAqAQEXAAAACAAAAE5ld1BEVGFnAAz/////AAAAAAABACoBARgA" +
           "AAAJAAAAU2VydmljZUlkAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBkAEALgBEkAEAAJYCAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwA" +
           "B/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQApAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SDFEZXZpY2VUeXBlSW5zdGFuY2UBAUQBAQFEAf////8KAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQB" +
           "AUcBAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6RwEAAP////8BAAAABGGCCgQAAAABAAoA" +
           "AABTZXRBZGRyZXNzAQGOAQAvAQGOAY4BAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBjwEALgBEjwEAAJYGAAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEV" +
           "AAAABgAAAExpbmtJZAAF/////wAAAAAAAQAqAQEZAAAACgAAAE9sZEFkZHJlc3MAA/////8AAAAAAAEA" +
           "KgEBGQAAAAoAAABOZXdBZGRyZXNzAAP/////AAAAAAABACoBARcAAAAIAAAATmV3UERUYWcADP////8A" +
           "AAAAAAEAKgEBGAAAAAkAAABTZXJ2aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGQAQAuAESQAQAAlgIAAAABACoBAR8AAAAQAAAARGVsYXlG" +
           "b3JOZXh0Q2FsbAAH/////wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAVsBAwAAAABNAAAASWRlbnRp" +
           "ZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZp" +
           "Y2UgaW5zdGFuY2UALgBEWwEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291" +
           "bnRlcgEBXAEDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJl" +
           "ciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZp" +
           "ZWQALgBEXAEAAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBXQEDAAAA" +
           "ABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEXQEAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIABQAAAE1vZGVsAQFeAQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVy" +
           "ZWQgdGhlIGRldmljZQAuAEReAQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFu" +
           "dWFsAQFfAQMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVS" +
           "TCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAERfAQAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAWABAwAAAAAkAAAAT3ZlcmFsbCBy" +
           "ZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARGABAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "ABAAAABTb2Z0d2FyZVJldmlzaW9uAQFhAQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0" +
           "d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARGEBAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "ABAAAABIYXJkd2FyZVJldmlzaW9uAQFiAQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJk" +
           "d2FyZSBvZiB0aGUgZGV2aWNlAC4ARGIBAAAADP////8BAf////8AAAAABGCACgEAAAABAA8AAABTZXJ2" +
           "aWNlUHJvdmlkZXIBAZEBAC8BAeUDkQEAAP////8JAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBAZQB" +
           "AwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6lAEAAP////8BAAAABGGCCgQAAAABAAgAAABU" +
           "cmFuc2ZlcgEBvgEALwEBKwS+AQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "Ab8BAC4ARL8BAACWBwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAA" +
           "AAAAAQAqAQEYAAAACQAAAE9QRVJBVElPTgAM/////wAAAAAAAQAqAQEXAAAACAAAAEJsb2NrVGFnAAz/" +
           "////AAAAAAABACoBARQAAAAFAAAASU5ERVgAB/////8AAAAAAAEAKgEBGAAAAAkAAABTVUJfSU5ERVgA" +
           "B/////8AAAAAAAEAKgEBGAAAAAkAAABXcml0ZURhdGEAAwEAAAAAAAAAAAEAKgEBGAAAAAkAAABTZXJ2" +
           "aWNlSWQAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQHAAQAuAETAAQAAlgMAAAABACoBARcAAAAIAAAAUmVhZERhdGEAAwEAAAAAAAAAAAEAKgEBHwAA" +
           "ABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBpgEDAAAA" +
           "AE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1" +
           "cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAESmAQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAA" +
           "UmV2aXNpb25Db3VudGVyAQGnAQMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGlu" +
           "ZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMg" +
           "YmVlbiBtb2RpZmllZAAuAESnAQAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1" +
           "cmVyAQGoAQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAESoAQAAABX/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAakBAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0" +
           "IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARKkBAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwA" +
           "AABEZXZpY2VNYW51YWwBAaoBAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lz" +
           "dGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4A" +
           "RKoBAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBqwEDAAAAACQA" +
           "AABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEqwEAAAAM/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAawBAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwg" +
           "b2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBErAEAAAAM/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAa0BAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwg" +
           "b2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBErQEAAAAM/////wEB/////wAAAAA=";
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
           "cwEBDgIALwEBDgIOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQ8CAC4A" +
           "RA8CAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBFwAAAAgAAABOZXdQ" +
           "RFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARACAC4ARBACAACWAgAAAAEAKgEBHwAA" +
           "ABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAqAAAAU2VydmVyQ29tbXVuaWNhdGlvbkZG" +
           "SFNFRGV2aWNlVHlwZUluc3RhbmNlAQHEAQEBxAH/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0" +
           "AQHHAQMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOscBAAD/////AQAAAARhggoEAAAAAQAK" +
           "AAAAU2V0QWRkcmVzcwEBDgIALwEBDgIOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAQ8CAC4ARA8CAACWAwAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEB" +
           "FwAAAAgAAABOZXdQRFRhZwAM/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARACAC4ARBACAACW" +
           "AgAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2Vy" +
           "dmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51" +
           "bWJlcgEB2wEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGlu" +
           "IGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAETbAQAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQHcAQMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50" +
           "ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhl" +
           "IERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAETcAQAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAATWFudWZhY3R1cmVyAQHdAQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAETdAQAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAd4BAwAAAAAwAAAATmFtZSBvZiB0aGUg" +
           "Y29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARN4BAAAAFf////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAd8BAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4g" +
           "dGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0" +
           "aGUgZGV2aWNlAC4ARN8BAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lv" +
           "bgEB4AEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE4AEAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAeEBAwAAAAA1AAAAUmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE4QEAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAeIBAwAAAAAsAAAAUmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBE4gEAAAAM/////wEB////" +
           "/wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92aWRlcgEBEQIALwEBMQQRAgAA/////wkAAAAkYIAK" +
           "AQAAAAIACQAAAE1ldGhvZFNldAEBFAIDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoUAgAA" +
           "/////wEAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQE+AgAvAQF3BD4CAAABAf////8CAAAAFWCpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPwIALgBEPwIAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11bmlj" +
           "YXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAAB" +
           "ACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAH/////wAAAAAA" +
           "AQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFdyaXRlRGF0YQADAQAA" +
           "AAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUACAC4AREACAACWAwAAAAEAKgEBFwAAAAgAAABSZWFk" +
           "RGF0YQADAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENhbGwAB/////8AAAAAAAEAKgEB" +
           "GwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQEmAgMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARCYCAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAScCAwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARCcCAAAABv////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBASgCAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARCgCAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBKQIDAAAAADAAAABO" +
           "YW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEKQIAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBKgIDAAAAAFoAAABBZGRyZXNzIChw" +
           "YXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBt" +
           "YW51YWwgZm9yIHRoZSBkZXZpY2UALgBEKgIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERl" +
           "dmljZVJldmlzaW9uAQErAgMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmlj" +
           "ZQAuAEQrAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBLAID" +
           "AAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAEQsAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBLQID" +
           "AAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEQtAgAA" +
           "AAz/////AQH/////AAAAAA==";
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
           "cwEBjgIALwEBjgKOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8CAC4A" +
           "RI8CAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAABACoBARkAAAAKAAAATmV3" +
           "QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAZACAC4ARJACAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJQlVTRGV2aWNlVHlwZUluc3RhbmNlAQFEAgEBRAL/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQFHAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOkcCAAD/////AQAAAARhggoEAAAA" +
           "AQAKAAAAU2V0QWRkcmVzcwEBjgIALwEBjgKOAgAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAY8CAC4ARI8CAACWAgAAAAEAKgEBGQAAAAoAAABPbGRBZGRyZXNzAAP/////AAAAAAAB" +
           "ACoBARkAAAAKAAAATmV3QWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAZACAC4ARJACAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJy" +
           "b3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQFb" +
           "AgMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51" +
           "ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARFsCAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "AA8AAABSZXZpc2lvbkNvdW50ZXIBAVwCAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRp" +
           "Y2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNl" +
           "IGhhcyBiZWVuIG1vZGlmaWVkAC4ARFwCAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51" +
           "ZmFjdHVyZXIBAV0CAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARF0CAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBXgIDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55" +
           "IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEXgIAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADAAAAERldmljZU1hbnVhbAEBXwIDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmls" +
           "ZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZp" +
           "Y2UALgBEXwIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQFgAgMA" +
           "AAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERgAgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBYQIDAAAAADUAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERhAgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBYgIDAAAAACwAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERiAgAAAAz/////AQH/////AAAAAARg" +
           "gAoBAAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQGRAgAvAQF9BJECAAD/////CQAAACRggAoBAAAAAgAJ" +
           "AAAATWV0aG9kU2V0AQGUAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOpQCAAD/////AQAA" +
           "AARhggoEAAAAAQAIAAAAVHJhbnNmZXIBAb4CAC8BAcMEvgIAAAEB/////wIAAAAVYKkKAgAAAAAADgAA" +
           "AElucHV0QXJndW1lbnRzAQG/AgAuAES/AgAAlgUAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJl" +
           "bGF0aW9uSWQAD/////8AAAAAAAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAA" +
           "AAQAAABTTE9UAAP/////AAAAAAABACoBARQAAAAFAAAASU5ERVgAA/////8AAAAAAAEAKgEBFgAAAAcA" +
           "AABSRVFVRVNUAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBwAIALgBEwAIAAJYDAAAAAQAqAQEUAAAABQAAAFJFUExZAA//////AAAAAAABACoBAR0A" +
           "AAAOAAAAUkVTUE9OU0VfQ09ERVMAD/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG///" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQGmAgMAAAAA" +
           "TQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVy" +
           "ZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARKYCAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABS" +
           "ZXZpc2lvbkNvdW50ZXIBAacCAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5n" +
           "IHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBi" +
           "ZWVuIG1vZGlmaWVkAC4ARKcCAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAagCAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARKgCAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAUAAABNb2RlbAEBqQIDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQg" +
           "bWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEqQIAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAA" +
           "AERldmljZU1hbnVhbAEBqgIDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0" +
           "ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBE" +
           "qgIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQGrAgMAAAAAJAAA" +
           "AE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAESrAgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBrAIDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBv" +
           "ZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAESsAgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBrQIDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBv" +
           "ZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAEStAgAAAAz/////AQH/////AAAAAA==";
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
           "cwEBCwMALwEBCwMLAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQwDAC4A" +
           "RAwDAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoBARUAAAACAAAASVAAAwEA" +
           "AAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAqAQEdAAAACgAAAFN1Ym5l" +
           "dE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAAAAEAAAAEAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQENAwAuAEQNAwAAlgEAAAAB" +
           "ACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAtAAAAU2VydmVyQ29tbXVuaWNhdGlvblBS" +
           "T0ZJTkVURGV2aWNlVHlwZUluc3RhbmNlAQHBAgEBwQL/////CgAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQHEAgMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOsQCAAD/////AQAAAARhggoEAAAA" +
           "AQAKAAAAU2V0QWRkcmVzcwEBCwMALwEBCwMLAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAQwDAC4ARAwDAACWBQAAAAEAKgEBFgAAAAMAAABNQUMAAwEAAAABAAAABgAAAAABACoB" +
           "ARUAAAACAAAASVAAAwEAAAABAAAABAAAAAABACoBARYAAAAHAAAARE5TTkFNRQAM/////wAAAAAAAQAq" +
           "AQEdAAAACgAAAFN1Ym5ldE1hc2sAAwEAAAABAAAABAAAAAABACoBARoAAAAHAAAAR2F0ZXdheQADAQAA" +
           "AAEAAAAEAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEN" +
           "AwAuAEQNAwAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB2AIDAAAAAE0AAABJZGVudGlmaWVyIHRo" +
           "YXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0" +
           "YW5jZQAuAETYAgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQHZ" +
           "AgMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRp" +
           "bWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAETZ" +
           "AgAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQHaAgMAAAAAGAAAAE1v" +
           "ZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAETaAgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAA" +
           "TW9kZWwBAdsCAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUg" +
           "ZGV2aWNlAC4ARNsCAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAdwC" +
           "AwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2Vi" +
           "IGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARNwCAAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB3QIDAAAAACQAAABPdmVyYWxsIHJldmlzaW9u" +
           "IGxldmVsIG9mIHRoZSBkZXZpY2UALgBE3QIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNv" +
           "ZnR3YXJlUmV2aXNpb24BAd4CAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zp" +
           "cm13YXJlIG9mIHRoZSBkZXZpY2UALgBE3gIAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhh" +
           "cmR3YXJlUmV2aXNpb24BAd8CAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9m" +
           "IHRoZSBkZXZpY2UALgBE3wIAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFNlcnZpY2VQcm92" +
           "aWRlcgEBDgMALwEBxgQOAwAA/////wkAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBEQMDAAAAABQA" +
           "AABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADoRAwAA/////wEAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVy" +
           "AQE7AwAvAQEMBTsDAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPAMALgBE" +
           "PAMAAJYHAAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoB" +
           "ARgAAAAJAAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARMAAAAEAAAAU0xPVAAF/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAFNVQlNMT1QABf////8AAAAAAAEAKgEBFAAAAAUAAABJTkRFWAAF/////wAAAAAAAQAq" +
           "AQESAAAAAwAAAEFQSQAH/////wAAAAAAAQAqAQEWAAAABwAAAFJFUVVFU1QAD/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE9AwAuAEQ9AwAAlgMAAAAB" +
           "ACoBARQAAAAFAAAAUkVQTFkAD/////8AAAAAAAEAKgEBHQAAAA4AAABSRVNQT05TRV9DT0RFUwAP////" +
           "/wAAAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBASMDAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1" +
           "ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE" +
           "IwMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBJAMDAAAAAGkA" +
           "AABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUg" +
           "c3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEJAMAAAAG////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBJQMDAAAAABgAAABNb2RlbCBuYW1l" +
           "IG9mIHRoZSBkZXZpY2UALgBEJQMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQEm" +
           "AwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAu" +
           "AEQmAwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEnAwMAAAAAWgAA" +
           "AEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNz" +
           "KSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQnAwAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAOAAAARGV2aWNlUmV2aXNpb24BASgDAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBv" +
           "ZiB0aGUgZGV2aWNlAC4ARCgDAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJl" +
           "dmlzaW9uAQEpAwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARCkDAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJl" +
           "dmlzaW9uAQEqAwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARCoDAAAADP////8BAf////8AAAAA";
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
           "cwEBiAMALwEBiAOIAwAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYkDAC4A" +
           "RIkDAACWAgAAAAEAKgEBHQAAAA4AAABPbGRQb2xsQWRkcmVzcwAD/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AE5ld1BvbGxBZGRyZXNzAAP/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBigMALgBEigMAAJYBAAAAAQAqAQEbAAAADAAAAFNlcnZpY2VFcnJvcgAb////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk3Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAiAAAAU2VydmVyQ29tbXVuaWNhdGlvbkhB" +
           "UlR5cGVJbnN0YW5jZQEBPgMBAT4D/////woAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBQQMDAAAA" +
           "ABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpBAwAA/////wEAAAAEYYIKBAAAAAEACgAAAFNldEFk" +
           "ZHJlc3MBAYgDAC8BAYgDiAMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGJ" +
           "AwAuAESJAwAAlgIAAAABACoBAR0AAAAOAAAAT2xkUG9sbEFkZHJlc3MAA/////8AAAAAAAEAKgEBHQAA" +
           "AA4AAABOZXdQb2xsQWRkcmVzcwAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAYoDAC4ARIoDAACWAQAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IA" +
           "G/////8AAAAAAAEAKAEBAAAAAQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQFVAwMA" +
           "AAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFj" +
           "dHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARFUDAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8A" +
           "AABSZXZpc2lvbkNvdW50ZXIBAVYDAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0" +
           "aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhh" +
           "cyBiZWVuIG1vZGlmaWVkAC4ARFYDAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFj" +
           "dHVyZXIBAVcDAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARFcDAAAAFf////8BAf//" +
           "//8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBWAMDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRo" +
           "YXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEWAMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAERldmljZU1hbnVhbAEBWQMDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBz" +
           "eXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UA" +
           "LgBEWQMAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQFaAwMAAAAA" +
           "JAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERaAwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBWwMDAAAAADUAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERbAwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBXAMDAAAAACwAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAERcAwAAAAz/////AQH/////AAAAAARggAoB" +
           "AAAAAQAPAAAAU2VydmljZVByb3ZpZGVyAQGLAwAvAQEPBYsDAAD/////CQAAACRggAoBAAAAAgAJAAAA" +
           "TWV0aG9kU2V0AQGOAwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOo4DAAD/////AQAAAARh" +
           "ggoEAAAAAQAIAAAAVHJhbnNmZXIBAbgDAC8BAVUFuAMAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQG5AwAuAES5AwAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0" +
           "aW9uSWQAD/////8AAAAAAAEAKgEBFgAAAAcAAABDb21tYW5kAAX/////AAAAAAABACoBARYAAAAHAAAA" +
           "UmVxdWVzdAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAboDAC4ARLoDAACWAgAAAAEAKgEBFAAAAAUAAABSZXBseQAP/////wAAAAAAAQAqAQEbAAAA" +
           "DAAAAFNlcnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAANWCJCgIAAAACAAwAAABT" +
           "ZXJpYWxOdW1iZXIBAaADAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMs" +
           "IHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEoAMAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBoQMDAAAAAGkAAABBbiBpbmNyZW1lbnRh" +
           "bCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0" +
           "aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEoQMAAAAG/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBogMDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UA" +
           "LgBEogMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQGjAwMAAAAAMAAAAE5hbWUg" +
           "b2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAESjAwAAABX/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQGkAwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhu" +
           "YW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVh" +
           "bCBmb3IgdGhlIGRldmljZQAuAESkAwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNl" +
           "UmV2aXNpb24BAaUDAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4A" +
           "RKUDAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQGmAwMAAAAA" +
           "NQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RKYDAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQGnAwMAAAAA" +
           "LAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARKcDAAAADP//" +
           "//8BAf////8AAAAA";
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
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBAgEDAAAAABgAAABNb2RlbCBu" +
           "YW1lIG9mIHRoZSBkZXZpY2UALgBEAgEAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVs" +
           "AQEDAQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmlj" +
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
           "AQHoAwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOugDAAD/////AwAAAARhggoEAAAAAQAH" +
           "AAAAQ29ubmVjdAEBKAQALwEBKAQoBAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBASkEAC4ARCkEAACWBgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP////" +
           "/wAAAAAAAQAqAQEVAAAABgAAAExpbmtJZAAF/////wAAAAAAAQAqAQEWAAAABwAAAEFkZHJlc3MAA///" +
           "//8AAAAAAAEAKgEBHAAAAA0AAABPcmRpbmFsTnVtYmVyAAb/////AAAAAAABACoBARwAAAANAAAAU0lG" +
           "Q29ubmVjdGlvbgAB/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBASoEAC4ARCoEAACWAgAAAAEA" +
           "KgEBHwAAABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVy" +
           "cm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQErBAAv" +
           "AQErBCsEAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBLAQALgBELAQAAJYH" +
           "AAAAAQAqAQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJ" +
           "AAAAT1BFUkFUSU9OAAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEB" +
           "FAAAAAUAAABJTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAq" +
           "AQEYAAAACQAAAFdyaXRlRGF0YQADAQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAS0EAC4ARC0E" +
           "AACWAwAAAAEAKgEBFwAAAAgAAABSZWFkRGF0YQADAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9y" +
           "TmV4dENhbGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAR2V0UHVibGlzaGVkRGF0YQEBLgQALwEBLgQuBAAAAQH/" +
           "////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAS8EAC4ARC8EAACWAgAAAAEAKgEBJgAA" +
           "ABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJ" +
           "ZAAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "ATAEAC4ARDAEAACWBgAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AEFsYXJtRXZlbnREYXRhAAMBAAAAAAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVudFR5cGUAEf////8A" +
           "AAAAAAEAKgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEBHwAAABAAAABEZWxheUZvck5l" +
           "eHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB/AMDAAAAAE0AAABJZGVudGlmaWVy" +
           "IHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBp" +
           "bnN0YW5jZQAuAET8AwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVy" +
           "AQH9AwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9m" +
           "IHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAu" +
           "AET9AwAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQH+AwMAAAAAGAAA" +
           "AE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAET+AwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAF" +
           "AAAATW9kZWwBAf8DAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0" +
           "aGUgZGV2aWNlAC4ARP8DAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwB" +
           "AQAEAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwg" +
           "V2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARAAEAAAADP////8BAf//" +
           "//8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBAQQDAAAAACQAAABPdmVyYWxsIHJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEAQQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AFNvZnR3YXJlUmV2aXNpb24BAQIEAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJl" +
           "L2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEAgQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AEhhcmR3YXJlUmV2aXNpb24BAQMEAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJl" +
           "IG9mIHRoZSBkZXZpY2UALgBEAwQAAAAM/////wEB/////wAAAAA=";
        #endregion
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
           "dAEBNAQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADo0BAAA/////wMAAAAEYYIKBAAAAAEA" +
           "BwAAAENvbm5lY3QBAXQEAC8BAXQEdAQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQF1BAAuAER1BAAAlgQAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD///" +
           "//8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAA//////AAAAAAABACoBARwAAAANAAAAT3JkaW5hbE51" +
           "bWJlcgAG/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXYEAC4ARHYEAACWAgAAAAEAKgEBHwAA" +
           "ABAAAABEZWxheUZvck5leHRDYWxsAAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQF3BAAvAQF3BHcE" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBeAQALgBEeAQAAJYHAAAAAQAq" +
           "AQEmAAAAFwAAAENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BF" +
           "UkFUSU9OAAz/////AAAAAAABACoBARcAAAAIAAAAQmxvY2tUYWcADP////8AAAAAAAEAKgEBFAAAAAUA" +
           "AABJTkRFWAAH/////wAAAAAAAQAqAQEYAAAACQAAAFNVQl9JTkRFWAAH/////wAAAAAAAQAqAQEYAAAA" +
           "CQAAAFdyaXRlRGF0YQADAQAAAAAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXkEAC4ARHkEAACWAwAA" +
           "AAEAKgEBFwAAAAgAAABSZWFkRGF0YQADAQAAAAAAAAAAAQAqAQEfAAAAEAAAAERlbGF5Rm9yTmV4dENh" +
           "bGwAB/////8AAAAAAAEAKgEBGwAAAAwAAABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAQAAAAR2V0UHVibGlzaGVkRGF0YQEBegQALwEBegR6BAAAAQH/////AgAA" +
           "ABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXsEAC4ARHsEAACWAgAAAAEAKgEBJgAAABcAAABD" +
           "b21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAqAQEYAAAACQAAAFNlcnZpY2VJZAAH////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXwEAC4A" +
           "RHwEAACWBgAAAAEAKgEBFwAAAAgAAABCbG9ja1RhZwAM/////wAAAAAAAQAqAQEdAAAADgAAAEFsYXJt" +
           "RXZlbnREYXRhAAMBAAAAAAAAAAABACoBAR0AAAAOAAAAQWxhcm1FdmVudFR5cGUAEf////8AAAAAAAEA" +
           "KgEBGAAAAAkAAABUaW1lU3RhbXAADf////8AAAAAAAEAKgEBHwAAABAAAABEZWxheUZvck5leHRDYWxs" +
           "AAf/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBSAQDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQg" +
           "dW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5j" +
           "ZQAuAERIBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFJBAMA" +
           "AAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVz" +
           "IHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERJBAAA" +
           "AAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQFKBAMAAAAAGAAAAE1vZGVs" +
           "IG5hbWUgb2YgdGhlIGRldmljZQAuAERKBAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9k" +
           "ZWwBAUsEAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2" +
           "aWNlAC4AREsEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAUwEAwAA" +
           "AABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFk" +
           "ZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AREwEAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBTQQDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxl" +
           "dmVsIG9mIHRoZSBkZXZpY2UALgBETQQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3" +
           "YXJlUmV2aXNpb24BAU4EAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13" +
           "YXJlIG9mIHRoZSBkZXZpY2UALgBETgQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3" +
           "YXJlUmV2aXNpb24BAU8EAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBETwQAAAAM/////wEB/////wAAAAA=";
        #endregion
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
           "ZFNldAEBgAQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADqABAAA/////wIAAAAEYYIKBAAA" +
           "AAEABwAAAENvbm5lY3QBAcAEAC8BAcAEwAQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQHBBAAuAETBBAAAlgMAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQA" +
           "D/////8AAAAAAAEAKgEBFgAAAAcAAABBZGRyZXNzAAP/////AAAAAAABACoBAR0AAAAOAAAATWFudWZh" +
           "Y3R1cmVySWQABf////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQHCBAAuAETCBAAAlgEAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAFRyYW5zZmVyAQHDBAAvAQHDBMMEAAABAf////8C" +
           "AAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBxAQALgBExAQAAJYFAAAAAQAqAQEmAAAAFwAA" +
           "AENvbW11bmljYXRpb25SZWxhdGlvbklkAA//////AAAAAAABACoBARgAAAAJAAAAT1BFUkFUSU9OAAz/" +
           "////AAAAAAABACoBARMAAAAEAAAAU0xPVAAD/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAP/////" +
           "AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAcUEAC4ARMUEAACWAwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP" +
           "/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NPREVTAA//////AAAAAAABACoBARsAAAAMAAAA" +
           "U2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlh" +
           "bE51bWJlcgEBlAQDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0" +
           "aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAESUBAAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQGVBAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNv" +
           "dW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4g" +
           "dGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAESVBAAAAAb/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAMAAAATWFudWZhY3R1cmVyAQGWBAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAESW" +
           "BAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAZcEAwAAAAAwAAAATmFtZSBvZiB0" +
           "aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARJcEAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAZgEAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUg" +
           "aW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZv" +
           "ciB0aGUgZGV2aWNlAC4ARJgEAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZp" +
           "c2lvbgEBmQQDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEmQQA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAZoEAwAAAAA1AAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEmgQA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAZsEAwAAAAAsAAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEmwQAAAAM/////wEB" +
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
           "ZFNldAEByQQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADrJBAAA/////wIAAAAEYYIKBAAA" +
           "AAEABwAAAENvbm5lY3QBAQkFAC8BAQkFCQUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQEKBQAuAEQKBQAAlgQAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQA" +
           "D/////8AAAAAAAEAKgEBFgAAAAcAAABETlNOQU1FAAz/////AAAAAAABACoBARcAAAAIAAAARGV2aWNl" +
           "SUQABf////8AAAAAAAEAKgEBFwAAAAgAAABWZW5kb3JJRAAF/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQsFAC4ARAsFAACWAQAAAAEAKgEBGwAAAAwA" +
           "AABTZXJ2aWNlRXJyb3IAG/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAVHJh" +
           "bnNmZXIBAQwFAC8BAQwFDAUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEN" +
           "BQAuAEQNBQAAlgcAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAA" +
           "AAEAKgEBGAAAAAkAAABPUEVSQVRJT04ADP////8AAAAAAAEAKgEBEwAAAAQAAABTTE9UAAX/////AAAA" +
           "AAABACoBARYAAAAHAAAAU1VCU0xPVAAF/////wAAAAAAAQAqAQEUAAAABQAAAElOREVYAAX/////AAAA" +
           "AAABACoBARIAAAADAAAAQVBJAAf/////AAAAAAABACoBARYAAAAHAAAAUkVRVUVTVAAP/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQ4FAC4ARA4FAACW" +
           "AwAAAAEAKgEBFAAAAAUAAABSRVBMWQAP/////wAAAAAAAQAqAQEdAAAADgAAAFJFU1BPTlNFX0NPREVT" +
           "AA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEB3QQDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQg" +
           "dW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5j" +
           "ZQAuAETdBAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQHeBAMA" +
           "AAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVz" +
           "IHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAETeBAAA" +
           "AAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQHfBAMAAAAAGAAAAE1vZGVs" +
           "IG5hbWUgb2YgdGhlIGRldmljZQAuAETfBAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9k" +
           "ZWwBAeAEAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2" +
           "aWNlAC4AROAEAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAeEEAwAA" +
           "AABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFk" +
           "ZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AROEEAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEB4gQDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxl" +
           "dmVsIG9mIHRoZSBkZXZpY2UALgBE4gQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3" +
           "YXJlUmV2aXNpb24BAeMEAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13" +
           "YXJlIG9mIHRoZSBkZXZpY2UALgBE4wQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3" +
           "YXJlUmV2aXNpb24BAeQEAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBE5AQAAAAM/////wEB/////wAAAAA=";
        #endregion
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
           "AQESBQMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOhIFAAD/////AwAAAARhggoEAAAAAQAH" +
           "AAAAQ29ubmVjdAEBUgUALwEBUgVSBQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAVMFAC4ARFMFAACWAgAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP////" +
           "/wAAAAAAAQAqAQEaAAAACwAAAExvbmdBZGRyZXNzAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAV" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVAUALgBEVAUAAJYBAAAAAQAqAQEbAAAADAAAAFNl" +
           "cnZpY2VFcnJvcgAb/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAgAAABUcmFuc2Zl" +
           "cgEBVQUALwEBVQVVBQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVYFAC4A" +
           "RFYFAACWAwAAAAEAKgEBJgAAABcAAABDb21tdW5pY2F0aW9uUmVsYXRpb25JZAAP/////wAAAAAAAQAq" +
           "AQEWAAAABwAAAENvbW1hbmQABf////8AAAAAAAEAKgEBFgAAAAcAAABSZXF1ZXN0AA//////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVwUALgBEVwUAAJYC" +
           "AAAAAQAqAQEUAAAABQAAAFJlcGx5AA//////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAEdldFB1Ymxpc2hlZERhdGEBAVgF" +
           "AC8BAVgFWAUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFZBQAuAERZBQAA" +
           "lgEAAAABACoBASYAAAAXAAAAQ29tbXVuaWNhdGlvblJlbGF0aW9uSWQAD/////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFaBQAuAERaBQAAlgQAAAABACoB" +
           "ARYAAAAHAAAAQ29tbWFuZAAF/////wAAAAAAAQAqAQEUAAAABQAAAFJlcGx5AA//////AAAAAAABACoB" +
           "ARgAAAAJAAAAVGltZVN0YW1wAA3/////AAAAAAABACoBARsAAAAMAAAAU2VydmljZUVycm9yABv/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBJgUDAAAAAE0A" +
           "AABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVy" +
           "LCBhIGRldmljZSBpbnN0YW5jZQAuAEQmBQAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQEnBQMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0" +
           "aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVl" +
           "biBtb2RpZmllZAAuAEQnBQAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVy" +
           "AQEoBQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQoBQAAABX/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAFAAAATW9kZWwBASkFAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1h" +
           "bnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARCkFAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABE" +
           "ZXZpY2VNYW51YWwBASoFAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVt" +
           "IG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARCoF" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBKwUDAAAAACQAAABP" +
           "dmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEKwUAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BASwFAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBELAUAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAS0FAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBELQUAAAAM/////wEB/////wAAAAA=";
        #endregion
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