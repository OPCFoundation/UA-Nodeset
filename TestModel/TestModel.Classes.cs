/* ========================================================================
 * Copyright (c) 2005-2026 The OPC Foundation, Inc. All rights reserved.
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
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Threading;
using Opc.Ua;


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1515 // Consider making public types internal
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1028 // Enum Storage should be Int32

namespace TestModel
{
    #region RestrictedVariableState Class
    #if (!OPCUA_EXCLUDE_RestrictedVariableState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class RestrictedVariableState : BaseDataVariableState
    {
        #region Constructors
        public RestrictedVariableState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TestModel.VariableTypes.RestrictedVariableType, TestModel.Namespaces.TestModel, namespaceUris);
        }

        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Any;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAAB1cm46b3BjZm91bmRhdGlvbi5vcmc6MjAyNC0wMTpUZXN0TW9kZWz/////FWCBAgIAAAAB" +
           "AB4AAABSZXN0cmljdGVkVmFyaWFibGVUeXBlSW5zdGFuY2UBAdgAAQHYANgAAAAADAEB/////wQAAAAV" +
           "YIkKAgAAAAEABgAAAFllbGxvdwEB2QAALwBE2QAAAAAG/////wEB/////wAAAAAVYIkKAgAAAAEAAQAA" +
           "AFgBAdoAAC8ARNoAAAAABv////8BAf////8AAAAAFWCJCgIAAAABAAEAAABZAQHbAAAvAETbAAAAAAb/" +
           "////AQH/////AAAAABVgiQoCAAAAAQABAAAAWgEB3AAALwBE3AAAAAAG/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<int> Yellow
        {
            get => m_yellow;

            set
            {
                if (!Object.ReferenceEquals(m_yellow, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow = value;
            }
        }

        public PropertyState<int> X
        {
            get => m_x;

            set
            {
                if (!Object.ReferenceEquals(m_x, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_x = value;
            }
        }

        public PropertyState<int> Y
        {
            get => m_y;

            set
            {
                if (!Object.ReferenceEquals(m_y, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_y = value;
            }
        }

        public PropertyState<int> Z
        {
            get => m_z;

            set
            {
                if (!Object.ReferenceEquals(m_z, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_z = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_yellow != null)
            {
                children.Add(m_yellow);
            }

            if (m_x != null)
            {
                children.Add(m_x);
            }

            if (m_y != null)
            {
                children.Add(m_y);
            }

            if (m_z != null)
            {
                children.Add(m_z);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_yellow, child))
            {
                m_yellow = null;
                return;
            }

            if (Object.ReferenceEquals(m_x, child))
            {
                m_x = null;
                return;
            }

            if (Object.ReferenceEquals(m_y, child))
            {
                m_y = null;
                return;
            }

            if (Object.ReferenceEquals(m_z, child))
            {
                m_z = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
                case TestModel.BrowseNames.Yellow:
                {
                    if (createOrReplace)
                    {
                        if (Yellow == null)
                        {
                            if (replacement == null)
                            {
                                Yellow = new PropertyState<int>(this);
                            }
                            else
                            {
                                Yellow = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = Yellow;
                    break;
                }

                case TestModel.BrowseNames.X:
                {
                    if (createOrReplace)
                    {
                        if (X == null)
                        {
                            if (replacement == null)
                            {
                                X = new PropertyState<int>(this);
                            }
                            else
                            {
                                X = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = X;
                    break;
                }

                case TestModel.BrowseNames.Y:
                {
                    if (createOrReplace)
                    {
                        if (Y == null)
                        {
                            if (replacement == null)
                            {
                                Y = new PropertyState<int>(this);
                            }
                            else
                            {
                                Y = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = Y;
                    break;
                }

                case TestModel.BrowseNames.Z:
                {
                    if (createOrReplace)
                    {
                        if (Z == null)
                        {
                            if (replacement == null)
                            {
                                Z = new PropertyState<int>(this);
                            }
                            else
                            {
                                Z = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = Z;
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
        private PropertyState<int> m_yellow;
        private PropertyState<int> m_x;
        private PropertyState<int> m_y;
        private PropertyState<int> m_z;
        #endregion
    }

    #region RestrictedVariableState<T> Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class RestrictedVariableState<T> : RestrictedVariableState
    {
        #region Constructors
        public RestrictedVariableState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region RestrictedObjectState Class
    #if (!OPCUA_EXCLUDE_RestrictedObjectState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class RestrictedObjectState : BaseObjectState
    {
        #region Constructors
        public RestrictedObjectState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TestModel.ObjectTypes.RestrictedObjectType, TestModel.Namespaces.TestModel, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAAB1cm46b3BjZm91bmRhdGlvbi5vcmc6MjAyNC0wMTpUZXN0TW9kZWz/////BGCAAgEAAAAB" +
           "ABwAAABSZXN0cmljdGVkT2JqZWN0VHlwZUluc3RhbmNlAQHdAAEB3QDdAAAA/////wMAAAAVYIkKAgAA" +
           "AAEAAwAAAFJlZAEB3gAALwEB2ADeAAAAAAz/////AQH/////BAAAABVgiQoCAAAAAQAGAAAAWWVsbG93" +
           "AQHfAAAvAETfAAAAAAb/////AQH/////AAAAABVgiQoCAAAAAQABAAAAWAEB4AAALwBE4AAAAAAG////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAAQAAAFkBAeEAAC8AROEAAAAABv////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAEAAABaAQHiAAAvAETiAAAAAAb/////AQH/////AAAAABVgyQoCAAAAEAAAAFBpbmtfUGxhY2Vo" +
           "b2xkZXIBAAYAAAA8UGluaz4BAeMAAC8BAdgA4wAAAAAM/////wEB/////wQAAAAVYIkKAgAAAAEABgAA" +
           "AFllbGxvdwEB5AAALwBE5AAAAAAG/////wEB/////wAAAAAVYIkKAgAAAAEAAQAAAFgBAeUAAC8AROUA" +
           "AAAABv////8BAf////8AAAAAFWCJCgIAAAABAAEAAABZAQHmAAAvAETmAAAAAAb/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQABAAAAWgEB5wAALwBE5wAAAAAG/////wEB/////wAAAAAEYYIKBAAAAAEABAAAAEJs" +
           "dWUBAegAAC8BAegA6AAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public RestrictedVariableState<string> Red
        {
            get => m_red;

            set
            {
                if (!Object.ReferenceEquals(m_red, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red = value;
            }
        }

        public MethodState Blue
        {
            get => m_blueMethod;

            set
            {
                if (!Object.ReferenceEquals(m_blueMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_blueMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_red != null)
            {
                children.Add(m_red);
            }

            if (m_blueMethod != null)
            {
                children.Add(m_blueMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_red, child))
            {
                m_red = null;
                return;
            }

            if (Object.ReferenceEquals(m_blueMethod, child))
            {
                m_blueMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
                case TestModel.BrowseNames.Red:
                {
                    if (createOrReplace)
                    {
                        if (Red == null)
                        {
                            if (replacement == null)
                            {
                                Red = new RestrictedVariableState<string>(this);
                            }
                            else
                            {
                                Red = (RestrictedVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Red;
                    break;
                }

                case TestModel.BrowseNames.Blue:
                {
                    if (createOrReplace)
                    {
                        if (Blue == null)
                        {
                            if (replacement == null)
                            {
                                Blue = new MethodState(this);
                            }
                            else
                            {
                                Blue = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Blue;
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
        private RestrictedVariableState<string> m_red;
        private MethodState m_blueMethod;
        #endregion
    }
    #endif
    #endregion

    #region WithTwoDimensionalVariableState Class
    #if (!OPCUA_EXCLUDE_WithTwoDimensionalVariableState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class WithTwoDimensionalVariableState : BaseObjectState
    {
        #region Constructors
        public WithTwoDimensionalVariableState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TestModel.ObjectTypes.WithTwoDimensionalVariableType, TestModel.Namespaces.TestModel, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (X != null)
            {
                X.Initialize(context, X_InitializationString);
            }
        }

        #region Initialization String
        private const string X_InitializationString =
           "AQAAACcAAAB1cm46b3BjZm91bmRhdGlvbi5vcmc6MjAyNC0wMTpUZXN0TW9kZWz/////F2CJCgIAAAAB" +
           "AAEAAABYAQH+AAAvAD/+AAAAAAYCAAAAAgAAAAAAAAAAAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACcAAAB1cm46b3BjZm91bmRhdGlvbi5vcmc6MjAyNC0wMTpUZXN0TW9kZWz/////BGCAAgEAAAAB" +
           "ACYAAABXaXRoVHdvRGltZW5zaW9uYWxWYXJpYWJsZVR5cGVJbnN0YW5jZQEB/QABAf0A/QAAAP////8B" +
           "AAAAF2CJCgIAAAABAAEAAABYAQH+AAAvAD/+AAAAAAYCAAAAAgAAAAAAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState X
        {
            get => m_x;

            set
            {
                if (!Object.ReferenceEquals(m_x, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_x = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_x != null)
            {
                children.Add(m_x);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_x, child))
            {
                m_x = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
                case TestModel.BrowseNames.X:
                {
                    if (createOrReplace)
                    {
                        if (X == null)
                        {
                            if (replacement == null)
                            {
                                X = new BaseDataVariableState(this);
                            }
                            else
                            {
                                X = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = X;
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
        private BaseDataVariableState m_x;
        #endregion
    }
    #endif
    #endregion
}
