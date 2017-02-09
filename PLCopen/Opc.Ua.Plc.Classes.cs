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
using Opc.Ua;
using Opc.Ua.Di;

namespace Opc.Ua.Plc
{
    #region CtrlConfigurationState Class
    #if (!OPCUA_EXCLUDE_CtrlConfigurationState)
    /// <summary>
    /// Stores an instance of the CtrlConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlConfigurationState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlConfigurationType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAHQAAAEN0cmxDb25maWd1cmF0aW9uVHlwZUlu" +
           "c3RhbmNlAQLpAwEC6QP/////DwAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQKKEwMAAAAAFAAAAEZs" +
           "YXQgbGlzdCBvZiBNZXRob2RzAC8AOooTAAD/////AgAAAARhggoEAAAAAgAFAAAAU3RhcnQBAlkbAC8B" +
           "AlkbWRsAAAEB/////wAAAAAEYYIKBAAAAAIABAAAAFN0b3ABAlobAC8BAlobWhsAAAEB/////wAAAAA1" +
           "YIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgECCwADAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVl" +
           "bHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQL" +
           "AAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAPAAAAUmV2aXNpb25Db3VudGVyAQIMAAMAAAAAaQAA" +
           "AEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBz" +
           "dGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQMAAAAAAb/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAQINAAMAAAAAMAAAAE5hbWUgb2YgdGhl" +
           "IGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQNAAAAABX/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAFAAAATW9kZWwBAg4AAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RA4AAAAAFf////8BAf////8AAAAANWCJCgIAAAABAAwAAABEZXZpY2VNYW51YWwBAg8AAwAAAABaAAAA" +
           "QWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3Mp" +
           "IG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARA8AAAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAABAA4AAABEZXZpY2VSZXZpc2lvbgECEAADAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9m" +
           "IHRoZSBkZXZpY2UALgBEEAAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2" +
           "aXNpb24BAhEAAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9m" +
           "IHRoZSBkZXZpY2UALgBEEQAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAEAAAAEhhcmR3YXJlUmV2" +
           "aXNpb24BAhIAAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZp" +
           "Y2UALgBEEgAAAAAM/////wEB/////wAAAAAEYIAKAQAAAAIACQAAAFJlc291cmNlcwECjBMALwEB7AOM" +
           "EwAA/////wEAAAAkYIAKAQAAAAEADgAAAFN1cHBvcnRlZFR5cGVzAQKNEwMAAAAAcgAAAEZvbGRlciBt" +
           "YWludGFpbmluZyB0aGUgc2V0IG9mIChzdWItdHlwZXMgb2YpIEJhc2VPYmplY3RUeXBlcyB0aGF0IGNh" +
           "biBiZSBpbnN0YW50aWF0ZWQgaW4gdGhlIENvbmZpZ3VyYWJsZUNvbXBvbmVudAAvAD2NEwAA/////wAA" +
           "AAAEYIAKAQAAAAIACgAAAEdsb2JhbFZhcnMBAo4TAC8BAe0DjhMAAP////8AAAAABGCACgEAAAACAAoA" +
           "AABBY2Nlc3NWYXJzAQKPEwAvAQHtA48TAAD/////AAAAAARggAoBAAAAAgAKAAAAQ29uZmlnVmFycwEC" +
           "kBMALwEB7QOQEwAA/////wAAAAAEYIAKAQAAAAIADQAAAENvbmZpZ3VyYXRpb24BApETAC8BAe0DkRMA" +
           "AP////8AAAAABGCACgEAAAACAAoAAABEaWFnbm9zdGljAQKSEwAvAQHtA5ITAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Resources Object.
        /// </summary>
        public ConfigurableObjectState Resources
        {
            get
            {
                return m_resources;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resources, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resources = value;
            }
        }

        /// <summary>
        /// A description for the GlobalVars Object.
        /// </summary>
        public FunctionalGroupState GlobalVars
        {
            get
            {
                return m_globalVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_globalVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_globalVars = value;
            }
        }

        /// <summary>
        /// A description for the AccessVars Object.
        /// </summary>
        public FunctionalGroupState AccessVars
        {
            get
            {
                return m_accessVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accessVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accessVars = value;
            }
        }

        /// <summary>
        /// A description for the ConfigVars Object.
        /// </summary>
        public FunctionalGroupState ConfigVars
        {
            get
            {
                return m_configVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configVars = value;
            }
        }

        /// <summary>
        /// A description for the Configuration Object.
        /// </summary>
        public FunctionalGroupState Configuration
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
        /// A description for the Diagnostic Object.
        /// </summary>
        public FunctionalGroupState Diagnostic
        {
            get
            {
                return m_diagnostic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_diagnostic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_diagnostic = value;
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
            if (m_resources != null)
            {
                children.Add(m_resources);
            }

            if (m_globalVars != null)
            {
                children.Add(m_globalVars);
            }

            if (m_accessVars != null)
            {
                children.Add(m_accessVars);
            }

            if (m_configVars != null)
            {
                children.Add(m_configVars);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_diagnostic != null)
            {
                children.Add(m_diagnostic);
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
                case Opc.Ua.Plc.BrowseNames.Resources:
                {
                    if (createOrReplace)
                    {
                        if (Resources == null)
                        {
                            if (replacement == null)
                            {
                                Resources = new ConfigurableObjectState(this);
                            }
                            else
                            {
                                Resources = (ConfigurableObjectState)replacement;
                            }
                        }
                    }

                    instance = Resources;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.GlobalVars:
                {
                    if (createOrReplace)
                    {
                        if (GlobalVars == null)
                        {
                            if (replacement == null)
                            {
                                GlobalVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                GlobalVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = GlobalVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.AccessVars:
                {
                    if (createOrReplace)
                    {
                        if (AccessVars == null)
                        {
                            if (replacement == null)
                            {
                                AccessVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AccessVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AccessVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.ConfigVars:
                {
                    if (createOrReplace)
                    {
                        if (ConfigVars == null)
                        {
                            if (replacement == null)
                            {
                                ConfigVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                ConfigVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = ConfigVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Configuration = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Diagnostic:
                {
                    if (createOrReplace)
                    {
                        if (Diagnostic == null)
                        {
                            if (replacement == null)
                            {
                                Diagnostic = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Diagnostic = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Diagnostic;
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
        private ConfigurableObjectState m_resources;
        private FunctionalGroupState m_globalVars;
        private FunctionalGroupState m_accessVars;
        private FunctionalGroupState m_configVars;
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_diagnostic;
        #endregion
    }
    #endif
    #endregion

    #region CtrlResourceState Class
    #if (!OPCUA_EXCLUDE_CtrlResourceState)
    /// <summary>
    /// Stores an instance of the CtrlResourceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlResourceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlResourceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlResourceType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
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

            if (GlobalVars != null)
            {
                GlobalVars.Initialize(context, GlobalVars_InitializationString);
            }

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }

            if (Diagnostic != null)
            {
                Diagnostic.Initialize(context, Diagnostic_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8kYIAKAQAAAAIACQAAAE1ldGhvZFNldAEClBMDAAAAABQAAABG" +
           "bGF0IGxpc3Qgb2YgTWV0aG9kcwAvADqUEwAA/////wIAAAAEYYIKBAAAAAIABQAAAFN0YXJ0AQJbGwAv" +
           "AQJbG1sbAAABAf////8AAAAABGGCCgQAAAACAAQAAABTdG9wAQJcGwAvAQJcG1wbAAABAf////8AAAAA";

        private const string GlobalVars_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAKAQAAAAIACgAAAEdsb2JhbFZhcnMBApoTAC8BAe0DmhMA" +
           "AP////8AAAAA";

        private const string Configuration_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAKAQAAAAIADQAAAENvbmZpZ3VyYXRpb24BApsTAC8BAe0D" +
           "mxMAAP////8AAAAA";

        private const string Diagnostic_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAKAQAAAAIACgAAAERpYWdub3N0aWMBApwTAC8BAe0DnBMA" +
           "AP////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAGAAAAEN0cmxSZXNvdXJjZVR5cGVJbnN0YW5j" +
           "ZQEC6gMBAuoD/////w4AAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEClBMDAAAAABQAAABGbGF0IGxp" +
           "c3Qgb2YgTWV0aG9kcwAvADqUEwAA/////wIAAAAEYYIKBAAAAAIABQAAAFN0YXJ0AQJbGwAvAQJbG1sb" +
           "AAABAf////8AAAAABGGCCgQAAAACAAQAAABTdG9wAQJcGwAvAQJcG1wbAAABAf////8AAAAANWCJCgIA" +
           "AAABAAwAAABTZXJpYWxOdW1iZXIBAiAAAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlk" +
           "ZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEIAAAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEADwAAAFJldmlzaW9uQ291bnRlcgECIQADAAAAAGkAAABBbiBp" +
           "bmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGlj" +
           "IGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEIQAAAAAG/////wEB////" +
           "/wAAAAA1YIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgECIgADAAAAADAAAABOYW1lIG9mIHRoZSBjb21w" +
           "YW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEIgAAAAAV/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEABQAAAE1vZGVsAQIjAAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQjAAAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAQAMAAAARGV2aWNlTWFudWFsAQIkAAMAAAAAWgAAAEFkZHJl" +
           "c3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1" +
           "c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQkAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAO" +
           "AAAARGV2aWNlUmV2aXNpb24BAiUAAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "ZGV2aWNlAC4ARCUAAAAADP////8BAf////8AAAAANWCJCgIAAAABABAAAABTb2Z0d2FyZVJldmlzaW9u" +
           "AQImAAMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUg" +
           "ZGV2aWNlAC4ARCYAAAAADP////8BAf////8AAAAANWCJCgIAAAABABAAAABIYXJkd2FyZVJldmlzaW9u" +
           "AQInAAMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RCcAAAAADP////8BAf////8AAAAABGCACgEAAAACAAUAAABUYXNrcwEClhMALwEB7AOWEwAA/////wEA" +
           "AAAkYIAKAQAAAAEADgAAAFN1cHBvcnRlZFR5cGVzAQKXEwMAAAAAcgAAAEZvbGRlciBtYWludGFpbmlu" +
           "ZyB0aGUgc2V0IG9mIChzdWItdHlwZXMgb2YpIEJhc2VPYmplY3RUeXBlcyB0aGF0IGNhbiBiZSBpbnN0" +
           "YW50aWF0ZWQgaW4gdGhlIENvbmZpZ3VyYWJsZUNvbXBvbmVudAAvAD2XEwAA/////wAAAAAEYIAKAQAA" +
           "AAIACAAAAFByb2dyYW1zAQKYEwAvAQHsA5gTAAD/////AQAAACRggAoBAAAAAQAOAAAAU3VwcG9ydGVk" +
           "VHlwZXMBApkTAwAAAAByAAAARm9sZGVyIG1haW50YWluaW5nIHRoZSBzZXQgb2YgKHN1Yi10eXBlcyBv" +
           "ZikgQmFzZU9iamVjdFR5cGVzIHRoYXQgY2FuIGJlIGluc3RhbnRpYXRlZCBpbiB0aGUgQ29uZmlndXJh" +
           "YmxlQ29tcG9uZW50AC8APZkTAAD/////AAAAAARggAoBAAAAAgAKAAAAR2xvYmFsVmFycwECmhMALwEB" +
           "7QOaEwAA/////wAAAAAEYIAKAQAAAAIADQAAAENvbmZpZ3VyYXRpb24BApsTAC8BAe0DmxMAAP////8A" +
           "AAAABGCACgEAAAACAAoAAABEaWFnbm9zdGljAQKcEwAvAQHtA5wTAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Tasks Object.
        /// </summary>
        public ConfigurableObjectState Tasks
        {
            get
            {
                return m_tasks;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tasks, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tasks = value;
            }
        }

        /// <summary>
        /// A description for the Programs Object.
        /// </summary>
        public ConfigurableObjectState Programs
        {
            get
            {
                return m_programs;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programs, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programs = value;
            }
        }

        /// <summary>
        /// A description for the GlobalVars Object.
        /// </summary>
        public FunctionalGroupState GlobalVars
        {
            get
            {
                return m_globalVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_globalVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_globalVars = value;
            }
        }

        /// <summary>
        /// A description for the Configuration Object.
        /// </summary>
        public FunctionalGroupState Configuration
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
        /// A description for the Diagnostic Object.
        /// </summary>
        public FunctionalGroupState Diagnostic
        {
            get
            {
                return m_diagnostic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_diagnostic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_diagnostic = value;
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
            if (m_tasks != null)
            {
                children.Add(m_tasks);
            }

            if (m_programs != null)
            {
                children.Add(m_programs);
            }

            if (m_globalVars != null)
            {
                children.Add(m_globalVars);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_diagnostic != null)
            {
                children.Add(m_diagnostic);
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
                case Opc.Ua.Plc.BrowseNames.Tasks:
                {
                    if (createOrReplace)
                    {
                        if (Tasks == null)
                        {
                            if (replacement == null)
                            {
                                Tasks = new ConfigurableObjectState(this);
                            }
                            else
                            {
                                Tasks = (ConfigurableObjectState)replacement;
                            }
                        }
                    }

                    instance = Tasks;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Programs:
                {
                    if (createOrReplace)
                    {
                        if (Programs == null)
                        {
                            if (replacement == null)
                            {
                                Programs = new ConfigurableObjectState(this);
                            }
                            else
                            {
                                Programs = (ConfigurableObjectState)replacement;
                            }
                        }
                    }

                    instance = Programs;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.GlobalVars:
                {
                    if (createOrReplace)
                    {
                        if (GlobalVars == null)
                        {
                            if (replacement == null)
                            {
                                GlobalVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                GlobalVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = GlobalVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Configuration = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Diagnostic:
                {
                    if (createOrReplace)
                    {
                        if (Diagnostic == null)
                        {
                            if (replacement == null)
                            {
                                Diagnostic = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Diagnostic = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Diagnostic;
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
        private ConfigurableObjectState m_tasks;
        private ConfigurableObjectState m_programs;
        private FunctionalGroupState m_globalVars;
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_diagnostic;
        #endregion
    }
    #endif
    #endregion

    #region CtrlProgramOrganizationUnitState Class
    #if (!OPCUA_EXCLUDE_CtrlProgramOrganizationUnitState)
    /// <summary>
    /// Stores an instance of the CtrlProgramOrganizationUnitType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlProgramOrganizationUnitState : BlockState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlProgramOrganizationUnitState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlProgramOrganizationUnitType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Body != null)
            {
                Body.Initialize(context, Body_InitializationString);
            }
        }

        #region Initialization String
        private const string Body_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIABAAAAEJvZHkBAnEXAC8AP3EXAAAAEP////8B" +
           "Af////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAJwAAAEN0cmxQcm9ncmFtT3JnYW5pemF0aW9u" +
           "VW5pdFR5cGVJbnN0YW5jZQEC6wMBAusD/////wEAAAAVYIkKAgAAAAIABAAAAEJvZHkBAnEXAC8AP3EX" +
           "AAAAEP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Body Variable.
        /// </summary>
        public BaseDataVariableState<XmlElement> Body
        {
            get
            {
                return m_body;
            }

            set
            {
                if (!Object.ReferenceEquals(m_body, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_body = value;
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
            if (m_body != null)
            {
                children.Add(m_body);
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
                case Opc.Ua.Plc.BrowseNames.Body:
                {
                    if (createOrReplace)
                    {
                        if (Body == null)
                        {
                            if (replacement == null)
                            {
                                Body = new BaseDataVariableState<XmlElement>(this);
                            }
                            else
                            {
                                Body = (BaseDataVariableState<XmlElement>)replacement;
                            }
                        }
                    }

                    instance = Body;
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
        private BaseDataVariableState<XmlElement> m_body;
        #endregion
    }
    #endif
    #endregion

    #region CtrlProgramState Class
    #if (!OPCUA_EXCLUDE_CtrlProgramState)
    /// <summary>
    /// Stores an instance of the CtrlProgramType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlProgramState : CtrlProgramOrganizationUnitState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlProgramState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlProgramType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Program != null)
            {
                Program.Initialize(context, Program_InitializationString);
            }
        }

        #region Initialization String
        private const string Program_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIABwAAAFByb2dyYW0BAnIXAC8AP3IXAAAAFv//" +
           "//8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAFwAAAEN0cmxQcm9ncmFtVHlwZUluc3RhbmNl" +
           "AQLsAwEC7AP/////AQAAABVgiQoCAAAAAgAHAAAAUHJvZ3JhbQECchcALwA/chcAAAAW/////wEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Program Variable.
        /// </summary>
        public BaseDataVariableState<ExtensionObject> Program
        {
            get
            {
                return m_program;
            }

            set
            {
                if (!Object.ReferenceEquals(m_program, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_program = value;
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
            if (m_program != null)
            {
                children.Add(m_program);
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
                case Opc.Ua.Plc.BrowseNames.Program:
                {
                    if (createOrReplace)
                    {
                        if (Program == null)
                        {
                            if (replacement == null)
                            {
                                Program = new BaseDataVariableState<ExtensionObject>(this);
                            }
                            else
                            {
                                Program = (BaseDataVariableState<ExtensionObject>)replacement;
                            }
                        }
                    }

                    instance = Program;
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
        private BaseDataVariableState<ExtensionObject> m_program;
        #endregion
    }
    #endif
    #endregion

    #region CtrlFunctionBlockState Class
    #if (!OPCUA_EXCLUDE_CtrlFunctionBlockState)
    /// <summary>
    /// Stores an instance of the CtrlFunctionBlockType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlFunctionBlockState : CtrlProgramOrganizationUnitState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlFunctionBlockState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlFunctionBlockType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (FunctionBlock != null)
            {
                FunctionBlock.Initialize(context, FunctionBlock_InitializationString);
            }
        }

        #region Initialization String
        private const string FunctionBlock_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIADQAAAEZ1bmN0aW9uQmxvY2sBAnMXAC8AP3MX" +
           "AAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAHQAAAEN0cmxGdW5jdGlvbkJsb2NrVHlwZUlu" +
           "c3RhbmNlAQLtAwEC7QP/////AQAAABVgiQoCAAAAAgANAAAARnVuY3Rpb25CbG9jawECcxcALwA/cxcA" +
           "AAAY/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the FunctionBlock Variable.
        /// </summary>
        public BaseDataVariableState FunctionBlock
        {
            get
            {
                return m_functionBlock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionBlock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionBlock = value;
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
            if (m_functionBlock != null)
            {
                children.Add(m_functionBlock);
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
                case Opc.Ua.Plc.BrowseNames.FunctionBlock:
                {
                    if (createOrReplace)
                    {
                        if (FunctionBlock == null)
                        {
                            if (replacement == null)
                            {
                                FunctionBlock = new BaseDataVariableState(this);
                            }
                            else
                            {
                                FunctionBlock = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = FunctionBlock;
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
        private BaseDataVariableState m_functionBlock;
        #endregion
    }
    #endif
    #endregion

    #region CtrlTaskState Class
    #if (!OPCUA_EXCLUDE_CtrlTaskState)
    /// <summary>
    /// Stores an instance of the CtrlTaskType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlTaskState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlTaskState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlTaskType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Interval != null)
            {
                Interval.Initialize(context, Interval_InitializationString);
            }

            if (Single != null)
            {
                Single.Initialize(context, Single_InitializationString);
            }
        }

        #region Initialization String
        private const string Interval_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIACAAAAEludGVydmFsAQJ1FwAuAER1FwAAAAz/" +
           "////AQH/////AAAAAA==";

        private const string Single_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIABgAAAFNpbmdsZQECdhcALgBEdhcAAAAM////" +
           "/wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAFAAAAEN0cmxUYXNrVHlwZUluc3RhbmNlAQLu" +
           "AwEC7gP/////AwAAABVgiQoCAAAAAgAIAAAAUHJpb3JpdHkBAnQXAC4ARHQXAAAAB/////8BAf////8A" +
           "AAAAFWCJCgIAAAACAAgAAABJbnRlcnZhbAECdRcALgBEdRcAAAAM/////wEB/////wAAAAAVYIkKAgAA" +
           "AAIABgAAAFNpbmdsZQECdhcALgBEdhcAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Priority Property.
        /// </summary>
        public PropertyState<uint> Priority
        {
            get
            {
                return m_priority;
            }

            set
            {
                if (!Object.ReferenceEquals(m_priority, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_priority = value;
            }
        }

        /// <summary>
        /// A description for the Interval Property.
        /// </summary>
        public PropertyState<string> Interval
        {
            get
            {
                return m_interval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_interval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_interval = value;
            }
        }

        /// <summary>
        /// A description for the Single Property.
        /// </summary>
        public PropertyState<string> Single
        {
            get
            {
                return m_single;
            }

            set
            {
                if (!Object.ReferenceEquals(m_single, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_single = value;
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
            if (m_priority != null)
            {
                children.Add(m_priority);
            }

            if (m_interval != null)
            {
                children.Add(m_interval);
            }

            if (m_single != null)
            {
                children.Add(m_single);
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
                case Opc.Ua.Plc.BrowseNames.Priority:
                {
                    if (createOrReplace)
                    {
                        if (Priority == null)
                        {
                            if (replacement == null)
                            {
                                Priority = new PropertyState<uint>(this);
                            }
                            else
                            {
                                Priority = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = Priority;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Interval:
                {
                    if (createOrReplace)
                    {
                        if (Interval == null)
                        {
                            if (replacement == null)
                            {
                                Interval = new PropertyState<string>(this);
                            }
                            else
                            {
                                Interval = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Interval;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Single:
                {
                    if (createOrReplace)
                    {
                        if (Single == null)
                        {
                            if (replacement == null)
                            {
                                Single = new PropertyState<string>(this);
                            }
                            else
                            {
                                Single = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Single;
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
        private PropertyState<uint> m_priority;
        private PropertyState<string> m_interval;
        private PropertyState<string> m_single;
        #endregion
    }
    #endif
    #endregion

    #region SFCState Class
    #if (!OPCUA_EXCLUDE_SFCState)
    /// <summary>
    /// Stores an instance of the SFCType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SFCState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SFCState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.SFCType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIADwAAAFNGQ1R5cGVJbnN0YW5jZQEC7wMBAu8D" +
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
}