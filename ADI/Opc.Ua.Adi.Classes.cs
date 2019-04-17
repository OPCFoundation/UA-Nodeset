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

namespace Opc.Ua.Adi
{
    #region AnalyserDeviceState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAaAAAAQW5hbHlzZXJEZXZpY2VUeXBlSW5zdGFuY2UB" +
           "AekDAQHpAwH/////DwAAACRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQGJEwMAAAAAFwAAAEZsYXQg" +
           "bGlzdCBvZiBQYXJhbWV0ZXJzAC8AOokTAAD/////AgAAADVgiQoCAAAAAQAQAAAARGlhZ25vc3RpY1N0" +
           "YXR1cwEB8yQDAAAAACUAAABHZW5lcmFsIGhlYWx0aCBzdGF0dXMgb2YgdGhlIGFuYWx5c2VyAC8BAD0J" +
           "8yQAAAECZBj/////AQEBAAAAACMBAQEMJQAAAAAkYIAKAQAAAAEACgAAAENvbmZpZ0RhdGEBAfYkAwAA" +
           "AAAsAAAAT3B0aW9uYWwgYW5hbHlzZXIgZGV2aWNlIGxhcmdlIGNvbmZpZ3VyYXRpb24ALwEANy32JAAA" +
           "AQAAAAAjAQEBCiUKAAAAFWCJCgIAAAAAAAQAAABTaXplAQH3JAAuAET3JAAAAAn/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAIAAAAV3JpdGFibGUBAQ4zAC4ARA4zAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAwAAABVc2VyV3JpdGFibGUBAQ8zAC4ARA8zAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABP" +
           "cGVuQ291bnQBAfokAC4ARPokAAAABf////8BAf////8AAAAABGGCCgQAAAAAAAQAAABPcGVuAQH7JAAv" +
           "AQA8LfskAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB/CQALgBE/CQAAJYB" +
           "AAAAAQAqAQETAAAABAAAAE1vZGUAA/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf0kAC4ARP0kAACWAQAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "SGFuZGxlAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xv" +
           "c2UBAf4kAC8BAD8t/iQAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH/JAAu" +
           "AET/JAAAlgEAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAAABAAAAFJlYWQBAQAlAC8BAEEtACUAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQEBJQAuAEQBJQAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRs" +
           "ZQAH/////wAAAAAAAQAqAQEVAAAABgAAAExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBAiUALgBEAiUAAJYBAAAAAQAqAQET" +
           "AAAABAAAAERhdGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAAAAUA" +
           "AABXcml0ZQEBAyUALwEARC0DJQAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AQQlAC4ARAQlAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAE" +
           "AAAARGF0YQAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAEdl" +
           "dFBvc2l0aW9uAQEFJQAvAQBGLQUlAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBBiUALgBEBiUAAJYBAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQclAC4ARAclAACW" +
           "AQAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAAACwAAAFNldFBvc2l0aW9uAQEIJQAvAQBJLQglAAABAf////8BAAAAF2CpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBCSUALgBECSUAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUA" +
           "B/////8AAAAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBpiQDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0" +
           "aG9kcwAvADqmJAAA/////woAAAAEYYIKBAAAAAEAEAAAAEdldENvbmZpZ3VyYXRpb24BAeMkAC8BAeMk" +
           "4yQAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB5CQALgBE5CQAAJYBAAAA" +
           "AQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "BGGCCgQAAAABABAAAABTZXRDb25maWd1cmF0aW9uAQHlJAAvAQHlJOUkAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB5iQALgBE5iQAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0Rh" +
           "dGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAeckAC4AROckAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQATAAAAR2V0Q29uZmlnRGF0YURp" +
           "Z2VzdAEB6CQALwEB6CToJAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHp" +
           "JAAuAETpJAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAFwAAAENvbXBhcmVDb25maWdEYXRhRGlnZXN0AQHq" +
           "JAAvAQHqJOokAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB6yQALgBE6yQA" +
           "AJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAewkAC4AROwkAACWAQAAAAEA" +
           "KgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAACRhggoE" +
           "AAAAAQAQAAAAUmVzZXRBbGxDaGFubmVscwEB7SQDAAAAADwAAABSZXNldCBhbGwgQW5hbHlzZXJDaGFu" +
           "bmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7STtJAAAAQH/////AAAAACRh" +
           "ggoEAAAAAQAQAAAAU3RhcnRBbGxDaGFubmVscwEB7iQDAAAAADwAAABTdGFydCBhbGwgQW5hbHlzZXJD" +
           "aGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7iTuJAAAAQH/////AAAA" +
           "ACRhggoEAAAAAQAPAAAAU3RvcEFsbENoYW5uZWxzAQHvJAMAAAAAOwAAAFN0b3AgYWxsIEFuYWx5c2Vy" +
           "Q2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe8k7yQAAAEB/////wAA" +
           "AAAkYYIKBAAAAAEAEAAAAEFib3J0QWxsQ2hhbm5lbHMBAfAkAwAAAAA8AAAAQWJvcnQgYWxsIEFuYWx5" +
           "c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAfAk8CQAAAEB////" +
           "/wAAAAAkYYIKBAAAAAEADQAAAEdvdG9PcGVyYXRpbmcBAfEkAwAAAACNAAAAQW5hbHlzZXJEZXZpY2VT" +
           "dGF0ZU1hY2hpbmUgdG8gZ28gdG8gT3BlcmF0aW5nIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNo" +
           "YW5uZWxzIHRvIGxlYXZlIHRoZSBTbGF2ZU1vZGUgc3RhdGUgYW5kIGdvIHRvIHRoZSBPcGVyYXRpbmcg" +
           "c3RhdGUuAC8BAfEk8SQAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAEdvdG9NYWludGVuYW5jZQEB8iQD" +
           "AAAAAGcAAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBNYWludGVuYW5jZSBzdGF0" +
           "ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBTbGF2ZU1vZGUgc3RhdGUuAC8BAfIk8iQA" +
           "AAEB/////wAAAAAkYIAKAQAAAAIADgAAAElkZW50aWZpY2F0aW9uAQGqJAMAAAAARgAAAFVzZWQgdG8g" +
           "b3JnYW5pemUgcGFyYW1ldGVycyBmb3IgaWRlbnRpZmljYXRpb24gb2YgdGhpcyBUb3BvbG9neUVsZW1l" +
           "bnQALwEC7QOqJAAAAwAAAAAjAAECcxcAIwABAnQXACMAAQJxFwAAAAA1YIkKAgAAAAIADAAAAFNlcmlh" +
           "bE51bWJlcgEBuiQDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0" +
           "aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAES6JAAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQG7JAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNv" +
           "dW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4g" +
           "dGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAES7JAAAAAb/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAMAAAATWFudWZhY3R1cmVyAQG8JAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51" +
           "ZmFjdHVyZWQgdGhlIGRldmljZQAuAES8JAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9k" +
           "ZWwBAb0kAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARL0kAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAb4kAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUg" +
           "aW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZv" +
           "ciB0aGUgZGV2aWNlAC4ARL4kAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZp" +
           "c2lvbgEBvyQDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEvyQA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAcAkAwAAAAA1AAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEwCQA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAcEkAwAAAAAsAAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEwSQAAAAM/////wEB" +
           "/////wAAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAQolAC8BAu0DCiUAAAEAAAAAIwABAfYk" +
           "AAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQEMJQAvAQLtAwwlAAABAAAAACMAAQHzJAAAAAAEYIAKAQAA" +
           "AAEADwAAAEZhY3RvcnlTZXR0aW5ncwEBDiUALwEC7QMOJQAA/////wAAAAAEYIAKAQAAAAEAFAAAAEFu" +
           "YWx5c2VyU3RhdGVNYWNoaW5lAQEQJQAvAQHqAxAlAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVu" +
           "dFN0YXRlAQERJQAvAQDIChElAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBEiUALgBE" +
           "EiUAAAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
        public FunctionalGroupState Status
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

        /// <remarks />
        public FunctionalGroupState FactorySettings
        {
            get
            {
                return m_factorySettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_factorySettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_factorySettings = value;
            }
        }

        /// <remarks />
        public AnalyserDeviceStateMachineState AnalyserStateMachine
        {
            get
            {
                return m_analyserStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_analyserStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_analyserStateMachine = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_factorySettings != null)
            {
                children.Add(m_factorySettings);
            }

            if (m_analyserStateMachine != null)
            {
                children.Add(m_analyserStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.FactorySettings:
                {
                    if (createOrReplace)
                    {
                        if (FactorySettings == null)
                        {
                            if (replacement == null)
                            {
                                FactorySettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                FactorySettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = FactorySettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AnalyserStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (AnalyserStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                AnalyserStateMachine = new AnalyserDeviceStateMachineState(this);
                            }
                            else
                            {
                                AnalyserStateMachine = (AnalyserDeviceStateMachineState)replacement;
                            }
                        }
                    }

                    instance = AnalyserStateMachine;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private FunctionalGroupState m_factorySettings;
        private AnalyserDeviceStateMachineState m_analyserStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserDeviceTypeGetConfigurationMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeGetConfigurationMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeGetConfigurationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeGetConfigurationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeGetConfigurationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeGetConfigurationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAsAAAAQW5hbHlzZXJEZXZpY2VUeXBlR2V0Q29uZmln" +
           "dXJhdGlvbk1ldGhvZFR5cGUBAZolAC8BAZolmiUAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBmyUALgBEmyUAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeGetConfigurationMethodStateMethodCallHandler OnCall;
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

            byte[] configData = (byte[])_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref configData);
            }

            _outputArguments[0] = configData;

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
    public delegate ServiceResult AnalyserDeviceTypeGetConfigurationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref byte[] configData);
    #endif
    #endregion

    #region AnalyserDeviceTypeSetConfigurationMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeSetConfigurationMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeSetConfigurationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeSetConfigurationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeSetConfigurationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeSetConfigurationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAsAAAAQW5hbHlzZXJEZXZpY2VUeXBlU2V0Q29uZmln" +
           "dXJhdGlvbk1ldGhvZFR5cGUBAZwlAC8BAZwlnCUAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQGdJQAuAESdJQAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBniUA" +
           "LgBEniUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeSetConfigurationMethodStateMethodCallHandler OnCall;
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

            byte[] configData = (byte[])_inputArguments[0];

            string configDataDigest = (string)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    configData,
                    ref configDataDigest);
            }

            _outputArguments[0] = configDataDigest;

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
    public delegate ServiceResult AnalyserDeviceTypeSetConfigurationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] configData,
        ref string configDataDigest);
    #endif
    #endregion

    #region AnalyserDeviceTypeGetConfigDataDigestMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeGetConfigDataDigestMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeGetConfigDataDigestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeGetConfigDataDigestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeGetConfigDataDigestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeGetConfigDataDigestMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAvAAAAQW5hbHlzZXJEZXZpY2VUeXBlR2V0Q29uZmln" +
           "RGF0YURpZ2VzdE1ldGhvZFR5cGUBAZ8lAC8BAZ8lnyUAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBoCUALgBEoCUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QA" +
           "DP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeGetConfigDataDigestMethodStateMethodCallHandler OnCall;
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

            string configDataDigest = (string)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref configDataDigest);
            }

            _outputArguments[0] = configDataDigest;

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
    public delegate ServiceResult AnalyserDeviceTypeGetConfigDataDigestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref string configDataDigest);
    #endif
    #endregion

    #region AnalyserDeviceTypeCompareConfigDataDigestMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeCompareConfigDataDigestMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeCompareConfigDataDigestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeCompareConfigDataDigestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeCompareConfigDataDigestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeCompareConfigDataDigestMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAzAAAAQW5hbHlzZXJEZXZpY2VUeXBlQ29tcGFyZUNv" +
           "bmZpZ0RhdGFEaWdlc3RNZXRob2RUeXBlAQGhJQAvAQGhJaElAAABAf////8CAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBoiUALgBEoiUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdl" +
           "c3QADP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAaMlAC4ARKMlAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAAAAABACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeCompareConfigDataDigestMethodStateMethodCallHandler OnCall;
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

            string configDataDigest = (string)_inputArguments[0];

            bool isEqual = (bool)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    configDataDigest,
                    ref isEqual);
            }

            _outputArguments[0] = isEqual;

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
    public delegate ServiceResult AnalyserDeviceTypeCompareConfigDataDigestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string configDataDigest,
        ref bool isEqual);
    #endif
    #endregion

    #region AnalyserDeviceStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserDeviceStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAmAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmVU" +
           "eXBlSW5zdGFuY2UBAeoDAQHqAwH/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGkJQAv" +
           "AQDICqQlAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBpSUALgBEpSUAAAAR/////wEB" +
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

    #region AnalyserChannelState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAbAAAAQW5hbHlzZXJDaGFubmVsVHlwZUluc3RhbmNl" +
           "AQHrAwEB6wMB/////wUAAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEBzSUDAAAAABcAAABGbGF0" +
           "IGxpc3Qgb2YgUGFyYW1ldGVycwAvADrNJQAA/////wQAAAA1YIkKAgAAAAEACQAAAENoYW5uZWxJZAEB" +
           "8CUDAAAAABoAAABDaGFubmVsIElkIGRlZmluZWQgYnkgdXNlcgAvAQA9CfAlAAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAABAAkAAABJc0VuYWJsZWQBAfMlAwAAAAA1AAAAVHJ1ZSBpZiB0aGUgY2hhbm5lbCBp" +
           "cyBlbmFibGVkIGFuZCBhY2NlcHRpbmcgY29tbWFuZHMALwEAPQnzJQAAAAH/////AQEBAAAAACMBAQH8" +
           "JQAAAAA1YIkKAgAAAAEAEAAAAERpYWdub3N0aWNTdGF0dXMBAfYlAwAAAAAdAAAAQW5hbHlzZXJDaGFu" +
           "bmVsIGhlYWx0aCBzdGF0dXMALwEAPQn2JQAAAQJkGP////8BAQEAAAAAIwEBAf4lAAAAADVgiQoCAAAA" +
           "AQAMAAAAQWN0aXZlU3RyZWFtAQH5JQMAAAAAJgAAAEFjdGl2ZSBzdHJlYW0gZm9yIHRoaXMgQW5hbHlz" +
           "ZXJDaGFubmVsAC8BAD0J+SUAAAAM/////wEBAQAAAAAjAQEB/iUAAAAAJGCACgEAAAACAAkAAABNZXRo" +
           "b2RTZXQBAc8lAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6zyUAAP////8MAAAAJGGCCgQA" +
           "AAABAA0AAABHb3RvT3BlcmF0aW5nAQHjJQMAAAAAMgAAAFRyYW5zaXRpb25zIHRoZSBBbmFseXNlckNo" +
           "YW5uZWwgdG8gT3BlcmF0aW5nIG1vZGUuAC8BAeMl4yUAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAEdv" +
           "dG9NYWludGVuYW5jZQEB5CUDAAAAADQAAABUcmFuc2l0aW9ucyB0aGUgQW5hbHlzZXJDaGFubmVsIHRv" +
           "IE1haW50ZW5hbmNlIG1vZGUuAC8BAeQl5CUAAAEB/////wAAAAAEYYIKBAAAAAEAFgAAAFN0YXJ0U2lu" +
           "Z2xlQWNxdWlzaXRpb24BAeUlAC8BAeUl5SUAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQHmJQAuAETmJQAAlgMAAAABACoBAR8AAAAOAAAARXhlY3V0aW9uQ3ljbGUBAaIk/////wAA" +
           "AAAAAQAqAQEkAAAAFQAAAEV4ZWN1dGlvbkN5Y2xlU3ViY29kZQAH/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AFNlbGVjdGVkU3RyZWFtAAz/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAACRhggoEAAAA" +
           "AQAFAAAAUmVzZXQBAeclAwAAAAApAAAAQ2F1c2VzIHRyYW5zaXRpb24gdG8gdGhlIFJlc2V0dGluZyBz" +
           "dGF0ZS4ALwEB5yXnJQAAAQH/////AAAAACRhggoEAAAAAQAFAAAAU3RhcnQBAeglAwAAAAAoAAAAQ2F1" +
           "c2VzIHRyYW5zaXRpb24gdG8gdGhlIFN0YXJ0aW5nIHN0YXRlLgAvAQHoJeglAAABAf////8AAAAAJGGC" +
           "CgQAAAABAAQAAABTdG9wAQHpJQMAAAAAKAAAAENhdXNlcyB0cmFuc2l0aW9uIHRvIHRoZSBTdG9wcGlu" +
           "ZyBzdGF0ZS4ALwEB6SXpJQAAAQH/////AAAAACRhggoEAAAAAQAEAAAASG9sZAEB6iUDAAAAACcAAABD" +
           "YXVzZXMgdHJhbnNpdGlvbiB0byB0aGUgSG9sZGluZyBzdGF0ZS4ALwEB6iXqJQAAAQH/////AAAAACRh" +
           "ggoEAAAAAQAGAAAAVW5ob2xkAQHrJQMAAAAAKQAAAENhdXNlcyB0cmFuc2l0aW9uIHRvIHRoZSBVbmhv" +
           "bGRpbmcgc3RhdGUuAC8BAesl6yUAAAEB/////wAAAAAkYYIKBAAAAAEABwAAAFN1c3BlbmQBAewlAwAA" +
           "AAAqAAAAQ2F1c2VzIHRyYW5zaXRpb24gdG8gdGhlIFN1c3BlbmRpbmcgc3RhdGUuAC8BAewl7CUAAAEB" +
           "/////wAAAAAkYYIKBAAAAAEACQAAAFVuc3VzcGVuZAEB7SUDAAAAACwAAABDYXVzZXMgdHJhbnNpdGlv" +
           "biB0byB0aGUgVW5zdXNwZW5kaW5nIHN0YXRlLgAvAQHtJe0lAAABAf////8AAAAAJGGCCgQAAAABAAUA" +
           "AABBYm9ydAEB7iUDAAAAACgAAABDYXVzZXMgdHJhbnNpdGlvbiB0byB0aGUgQWJvcnRpbmcgc3RhdGUu" +
           "AC8BAe4l7iUAAAEB/////wAAAAAkYYIKBAAAAAEABQAAAENsZWFyAQHvJQMAAAAAKAAAAENhdXNlcyB0" +
           "cmFuc2l0aW9uIHRvIHRoZSBDbGVhcmluZyBzdGF0ZS4ALwEB7yXvJQAAAQH/////AAAAAARggAoBAAAA" +
           "AQANAAAAQ29uZmlndXJhdGlvbgEB/CUALwEC7QP8JQAAAQAAAAAjAAEB8yUAAAAABGCACgEAAAABAAYA" +
           "AABTdGF0dXMBAf4lAC8BAu0D/iUAAAIAAAAAIwABAfYlACMAAQH5JQAAAACEYIAKAQAAAAEAEwAAAENo" +
           "YW5uZWxTdGF0ZU1hY2hpbmUBAQAmAC8BAe8DACYAAAH/////AgAAABVgiQoCAAAAAAAMAAAAQ3VycmVu" +
           "dFN0YXRlAQEBJgAvAQDICgEmAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAiYALgBE" +
           "AiYAAAAR/////wEB/////wAAAAAEYIAKAQAAAAEAGAAAAE9wZXJhdGluZ1N1YlN0YXRlTWFjaGluZQEB" +
           "DCYALwEB8AMMJgAA/////wIAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBDSYALwEAyAoNJgAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQ4mAC4ARA4mAAAAEf////8BAf////8AAAAA" +
           "BGCACgEAAAABAB8AAABPcGVyYXRpbmdFeGVjdXRlU3ViU3RhdGVNYWNoaW5lAQEYJgAvAQHxAxgmAAD/" +
           "////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEZJgAvAQDIChkmAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBGiYALgBEGiYAAAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
        public FunctionalGroupState Status
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

        /// <remarks />
        public AnalyserChannelStateMachineState ChannelStateMachine
        {
            get
            {
                return m_channelStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_channelStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_channelStateMachine = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_channelStateMachine != null)
            {
                children.Add(m_channelStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.ChannelStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (ChannelStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                ChannelStateMachine = new AnalyserChannelStateMachineState(this);
                            }
                            else
                            {
                                ChannelStateMachine = (AnalyserChannelStateMachineState)replacement;
                            }
                        }
                    }

                    instance = ChannelStateMachine;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private AnalyserChannelStateMachineState m_channelStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserChannelTypeStartSingleAcquisitionMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelTypeStartSingleAcquisitionMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelTypeStartSingleAcquisitionMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelTypeStartSingleAcquisitionMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelTypeStartSingleAcquisitionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserChannelTypeStartSingleAcquisitionMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAzAAAAQW5hbHlzZXJDaGFubmVsVHlwZVN0YXJ0U2lu" +
           "Z2xlQWNxdWlzaXRpb25NZXRob2RUeXBlAQHMJgAvAQHMJswmAAABAf////8BAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBzSYALgBEzSYAAJYDAAAAAQAqAQEfAAAADgAAAEV4ZWN1dGlvbkN5Y2xl" +
           "AQGiJP////8AAAAAAAEAKgEBJAAAABUAAABFeGVjdXRpb25DeWNsZVN1YmNvZGUAB/////8AAAAAAAEA" +
           "KgEBHQAAAA4AAABTZWxlY3RlZFN0cmVhbQAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserChannelTypeStartSingleAcquisitionMethodStateMethodCallHandler OnCall;
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

            ExecutionCycleEnumeration executionCycle = (ExecutionCycleEnumeration)_inputArguments[0];
            uint executionCycleSubcode = (uint)_inputArguments[1];
            string selectedStream = (string)_inputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    executionCycle,
                    executionCycleSubcode,
                    selectedStream);
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
    public delegate ServiceResult AnalyserChannelTypeStartSingleAcquisitionMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ExecutionCycleEnumeration executionCycle,
        uint executionCycleSubcode,
        string selectedStream);
    #endif
    #endregion

    #region AnalyserChannelOperatingStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelOperatingStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelOperatingStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelOperatingStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelOperatingStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelOperatingStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQApAAAAQW5hbHlzZXJDaGFubmVsT3BlcmF0aW5nU3Rh" +
           "dGVUeXBlSW5zdGFuY2UBAewDAQHsAwEBAAAAAHUAAQHcJgEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVt" +
           "YmVyAQHOJgAuAETOJgAAAAf/////AQH/////AAAAAA==";
        #endregion
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

    #region AnalyserChannelLocalStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelLocalStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelLocalStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelLocalStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelLocalStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelLocalStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQW5hbHlzZXJDaGFubmVsTG9jYWxTdGF0ZVR5" +
           "cGVJbnN0YW5jZQEB7QMBAe0D/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHPJgAuAETP" +
           "JgAAAAf/////AQH/////AAAAAA==";
        #endregion
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

    #region AnalyserChannelMaintenanceStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelMaintenanceStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelMaintenanceStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelMaintenanceStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelMaintenanceStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelMaintenanceStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQArAAAAQW5hbHlzZXJDaGFubmVsTWFpbnRlbmFuY2VT" +
           "dGF0ZVR5cGVJbnN0YW5jZQEB7gMBAe4D/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHQ" +
           "JgAuAETQJgAAAAf/////AQH/////AAAAAA==";
        #endregion
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

    #region AnalyserChannelStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LocalSubStateMachine != null)
            {
                LocalSubStateMachine.Initialize(context, LocalSubStateMachine_InitializationString);
            }

            if (MaintenanceSubStateMachine != null)
            {
                MaintenanceSubStateMachine.Initialize(context, MaintenanceSubStateMachine_InitializationString);
            }
        }

        #region Initialization String
        private const string LocalSubStateMachine_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAUAAAATG9jYWxTdWJTdGF0ZU1hY2hpbmUBAfQmAC8B" +
           "ANMK9CYAAAEAAAAAdQEBARAnAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQH1JgAvAQDICvUm" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB9iYALgBE9iYAAAAR/////wEB/////wAA" +
           "AAA=";

        private const string MaintenanceSubStateMachine_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAaAAAATWFpbnRlbmFuY2VTdWJTdGF0ZU1hY2hpbmUB" +
           "AQAnAC8BANMKACcAAAEAAAAAdQEBARInAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEBJwAv" +
           "AQDICgEnAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAicALgBEAicAAAAR/////wEB" +
           "/////wAAAAA=";

        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAnAAAAQW5hbHlzZXJDaGFubmVsU3RhdGVNYWNoaW5l" +
           "VHlwZUluc3RhbmNlAQHvAwEB7wMB/////wQAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEB0SYA" +
           "LwEAyArRJgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAdImAC4ARNImAAAAEf////8B" +
           "Af////8AAAAABGCACgEAAAABABgAAABPcGVyYXRpbmdTdWJTdGF0ZU1hY2hpbmUBAdwmAC8BAfAD3CYA" +
           "AAEAAAAAdQEBAQ4nAgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQHdJgAvAQDICt0mAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB3iYALgBE3iYAAAAR/////wEB/////wAAAAAEYIAK" +
           "AQAAAAEAHwAAAE9wZXJhdGluZ0V4ZWN1dGVTdWJTdGF0ZU1hY2hpbmUBAegmAC8BAfED6CYAAP////8B" +
           "AAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAekmAC8BAMgK6SYAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQHqJgAuAETqJgAAABH/////AQH/////AAAAAARggAoBAAAAAQAUAAAATG9j" +
           "YWxTdWJTdGF0ZU1hY2hpbmUBAfQmAC8BANMK9CYAAAEAAAAAdQEBARAnAQAAABVgiQoCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQH1JgAvAQDICvUmAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "9iYALgBE9iYAAAAR/////wEB/////wAAAAAEYIAKAQAAAAEAGgAAAE1haW50ZW5hbmNlU3ViU3RhdGVN" +
           "YWNoaW5lAQEAJwAvAQDTCgAnAAABAAAAAHUBAQESJwEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0" +
           "ZQEBAScALwEAyAoBJwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQInAC4ARAInAAAA" +
           "Ef////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalyserChannel_OperatingModeSubStateMachineState OperatingSubStateMachine
        {
            get
            {
                return m_operatingSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingSubStateMachine = value;
            }
        }

        /// <remarks />
        public FiniteStateMachineState LocalSubStateMachine
        {
            get
            {
                return m_localSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_localSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_localSubStateMachine = value;
            }
        }

        /// <remarks />
        public FiniteStateMachineState MaintenanceSubStateMachine
        {
            get
            {
                return m_maintenanceSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenanceSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenanceSubStateMachine = value;
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
            if (m_operatingSubStateMachine != null)
            {
                children.Add(m_operatingSubStateMachine);
            }

            if (m_localSubStateMachine != null)
            {
                children.Add(m_localSubStateMachine);
            }

            if (m_maintenanceSubStateMachine != null)
            {
                children.Add(m_maintenanceSubStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.OperatingSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (OperatingSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                OperatingSubStateMachine = new AnalyserChannel_OperatingModeSubStateMachineState(this);
                            }
                            else
                            {
                                OperatingSubStateMachine = (AnalyserChannel_OperatingModeSubStateMachineState)replacement;
                            }
                        }
                    }

                    instance = OperatingSubStateMachine;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.LocalSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (LocalSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                LocalSubStateMachine = new FiniteStateMachineState(this);
                            }
                            else
                            {
                                LocalSubStateMachine = (FiniteStateMachineState)replacement;
                            }
                        }
                    }

                    instance = LocalSubStateMachine;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.MaintenanceSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (MaintenanceSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                MaintenanceSubStateMachine = new FiniteStateMachineState(this);
                            }
                            else
                            {
                                MaintenanceSubStateMachine = (FiniteStateMachineState)replacement;
                            }
                        }
                    }

                    instance = MaintenanceSubStateMachine;
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
        private AnalyserChannel_OperatingModeSubStateMachineState m_operatingSubStateMachine;
        private FiniteStateMachineState m_localSubStateMachine;
        private FiniteStateMachineState m_maintenanceSubStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserChannelOperatingExecuteStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelOperatingExecuteStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelOperatingExecuteStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelOperatingExecuteStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelOperatingExecuteStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelOperatingExecuteStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAwAAAAQW5hbHlzZXJDaGFubmVsT3BlcmF0aW5nRXhl" +
           "Y3V0ZVN0YXRlVHlwZUluc3RhbmNlAQEEIwEBBCMBAQAAAAB1AAEBNCcBAAAAFWCJCgIAAAAAAAsAAABT" +
           "dGF0ZU51bWJlcgEBKCcALgBEKCcAAAAH/////wEB/////wAAAAA=";
        #endregion
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

    #region AnalyserChannel_OperatingModeSubStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannel_OperatingModeSubStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserChannel_OperatingModeSubStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannel_OperatingModeSubStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannel_OperatingModeSubStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannel_OperatingModeSubStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQA4AAAAQW5hbHlzZXJDaGFubmVsX09wZXJhdGluZ01v" +
           "ZGVTdWJTdGF0ZU1hY2hpbmVUeXBlSW5zdGFuY2UBAfADAQHwAwH/////AgAAABVgiQoCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQEpJwAvAQDICiknAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "KicALgBEKicAAAAR/////wEB/////wAAAAAEYIAKAQAAAAEAHwAAAE9wZXJhdGluZ0V4ZWN1dGVTdWJT" +
           "dGF0ZU1hY2hpbmUBATQnAC8BAfEDNCcAAAEAAAAAdQEBAUgnAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVu" +
           "dFN0YXRlAQE1JwAvAQDICjUnAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBNicALgBE" +
           "NicAAAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalyserChannel_OperatingModeExecuteSubStateMachineState OperatingExecuteSubStateMachine
        {
            get
            {
                return m_operatingExecuteSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingExecuteSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingExecuteSubStateMachine = value;
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
            if (m_operatingExecuteSubStateMachine != null)
            {
                children.Add(m_operatingExecuteSubStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.OperatingExecuteSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (OperatingExecuteSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                OperatingExecuteSubStateMachine = new AnalyserChannel_OperatingModeExecuteSubStateMachineState(this);
                            }
                            else
                            {
                                OperatingExecuteSubStateMachine = (AnalyserChannel_OperatingModeExecuteSubStateMachineState)replacement;
                            }
                        }
                    }

                    instance = OperatingExecuteSubStateMachine;
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
        private AnalyserChannel_OperatingModeExecuteSubStateMachineState m_operatingExecuteSubStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserChannel_OperatingModeExecuteSubStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannel_OperatingModeExecuteSubStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserChannel_OperatingModeExecuteSubStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannel_OperatingModeExecuteSubStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannel_OperatingModeExecuteSubStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannel_OperatingModeExecuteSubStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQA/AAAAQW5hbHlzZXJDaGFubmVsX09wZXJhdGluZ01v" +
           "ZGVFeGVjdXRlU3ViU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQHxAwEB8QMB/////wEAAAAVYIkKAgAA" +
           "AAAADAAAAEN1cnJlbnRTdGF0ZQEBzicALwEAyArOJwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAC" +
           "AAAASWQBAc8nAC4ARM8nAAAAEf////8BAf////8AAAAA";
        #endregion
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

    #region StreamState Class
    #if (!OPCUA_EXCLUDE_StreamState)
    /// <summary>
    /// Stores an instance of the StreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StreamState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.StreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAU3RyZWFtVHlwZUluc3RhbmNlAQHyAwEB8gP/" +
           "////CAAAACRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQFNKAMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQ" +
           "YXJhbWV0ZXJzAC8AOk0oAAD/////HAAAADVgiQoCAAAAAQAJAAAASXNFbmFibGVkAQFjKAMAAAAANQAA" +
           "AFRydWUgaWYgdGhpcyBzdHJlYW0gbWF5YmUgdXNlZCB0byBwZXJmb3JtIGFjcXVpc2l0aW9uAC8BAD0J" +
           "YygAAAAB/////wEBAQAAAAAjAQEBvigAAAAANWCJCgIAAAABAAgAAABJc0ZvcmNlZAEBZigDAAAAAIIA" +
           "AABUcnVlIGlmIHRoaXMgc3RyZWFtIGlzIGZvcmNlZCwgd2hpY2ggbWVhbnMgdGhhdCBpcyB0aGUgb25s" +
           "eSBTdHJlYW0gb24gdGhpcyBBbmFseXNlckNoYW5uZWwgdGhhdCBjYW4gYmUgdXNlZCB0byBwZXJmb3Jt" +
           "IGFjcXVpc2l0aW9uAC8BAD0JZigAAAAB/////wEBAQAAAAAjAQEBvigAAAAANWCJCgIAAAABABAAAABE" +
           "aWFnbm9zdGljU3RhdHVzAQFpKAMAAAAAFAAAAFN0cmVhbSBoZWFsdGggc3RhdHVzAC8BAD0JaSgAAAEC" +
           "ZBj/////AQEBAAAAACMBAQHAKAAAAAA1YIkKAgAAAAEAEwAAAExhc3RDYWxpYnJhdGlvblRpbWUBAWwo" +
           "AwAAAAAqAAAAVGltZSBhdCB3aGljaCB0aGUgbGFzdCBjYWxpYnJhdGlvbiB3YXMgcnVuAC8BAD0JbCgA" +
           "AAAN/////wEBAQAAAAAjAQEBwCgAAAAANWCJCgIAAAABABIAAABMYXN0VmFsaWRhdGlvblRpbWUBAW8o" +
           "AwAAAAApAAAAVGltZSBhdCB3aGljaCB0aGUgbGFzdCB2YWxpZGF0aW9uIHdhcyBydW4ALwEAPQlvKAAA" +
           "AA3/////AQEBAAAAACMBAQHAKAAAAAA1YIkKAgAAAAEADgAAAExhc3RTYW1wbGVUaW1lAQFyKAMAAAAA" +
           "KgAAAFRpbWUgYXQgd2hpY2ggdGhlIGxhc3Qgc2FtcGxlIHdhcyBhY3F1aXJlZAAvAQA9CXIoAAAADf//" +
           "//8BAQEAAAAAIwEBAcAoAAAAADVgiQoCAAAAAQASAAAAVGltZUJldHdlZW5TYW1wbGVzAQF1KAMAAAAA" +
           "RAAAAE51bWJlciBvZiBtaWxsaXNlY29uZHMgYmV0d2VlbiB0d28gY29uc2VjdXRpdmUgc3RhcnRzIG9m" +
           "IGFjcXVpc2l0aW9uAC8BAEAJdSgAAAEAIgH/////AQEBAAAAACMBAQHCKAEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAXkoAC4ARHkoAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEACAAAAElzQWN0aXZl" +
           "AQF7KAMAAAAANwAAAFRydWUgaWYgdGhpcyBzdHJlYW0gaXMgYWN0dWFsbHkgcnVubmluZywgYWNxdWly" +
           "aW5nIGRhdGEALwEAPQl7KAAAAAH/////AQEBAAAAACMBAQHEKAAAAAA1YIkKAgAAAAEADgAAAEV4ZWN1" +
           "dGlvbkN5Y2xlAQF+KAMAAAAALgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3ljbGUgaXMgaW4g" +
           "cHJvZ3Jlc3MALwEAPQl+KAAAAQGiJP////8BAQEAAAAAIwEBAcQoAAAAADVgiQoCAAAAAQAVAAAARXhl" +
           "Y3V0aW9uQ3ljbGVTdWJjb2RlAQGBKAMAAAAANgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3lj" +
           "bGUgc3ViY29kZSBpcyBpbiBwcm9ncmVzcwAvAQBICYEoAAAAHP////8BAQEAAAAAIwEBAcQoAQAAABdg" +
           "iQoCAAAAAAALAAAARW51bVN0cmluZ3MBAYQoAC4ARIQoAAAAFQEAAAABAAAAAAAAAAEB/////wAAAAA1" +
           "YIkKAgAAAAEACAAAAFByb2dyZXNzAQGFKAMAAAAAdAAAAEluZGljYXRlcyB0aGUgcHJvZ3Jlc3Mgb2Yg" +
           "YW4gYWNxdWlzaXRpb24gaW4gdGVybXMgb2YgcGVyY2VudGFnZSBvZiBjb21wbGV0aW9uLiBJdHMgdmFs" +
           "dWUgc2hhbGwgYmUgYmV0d2VlbiAwIGFuZCAxMDAuAC8BAD0JhSgAAAAK/////wEBAQAAAAAjAQEBxCgA" +
           "AAAANWCJCgIAAAABABIAAABBY3F1aXNpdGlvbkNvdW50ZXIBAYgoAwAAAABTAAAAU2ltcGxlIGNvdW50" +
           "ZXIgaW5jcmVtZW50ZWQgYWZ0ZXIgZWFjaCBTYW1wbGluZyBhY3F1aXNpdGlvbiBwZXJmb3JtZWQgb24g" +
           "dGhpcyBTdHJlYW0ALwEAQAmIKAAAAQAhAf////8BAQEAAAAAIwEBAcYoAQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBjCgALgBEjCgAAAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAXAAAAQWNxdWlzaXRp" +
           "b25SZXN1bHRTdGF0dXMBAY4oAwAAAAAaAAAAUXVhbGl0eSBvZiB0aGUgYWNxdWlzaXRpb24ALwEAPQmO" +
           "KAAAAQG7C/////8BAQEAAAAAIwEBAcYoAAAAADVgiQoCAAAAAQAHAAAAUmF3RGF0YQEBkSgDAAAAAD8A" +
           "AABSYXcgZGF0YSBwcm9kdWNlZCBhcyBhIHJlc3VsdCBvZiBkYXRhIGFjcXVpc2l0aW9uIG9uIHRoZSBT" +
           "dHJlYW0ALwEAPQmRKAAAABj/////AQEBAAAAACMBAQHGKAAAAAA1YIkKAgAAAAEACgAAAFNjYWxlZERh" +
           "dGEBAZQoAwAAAABoAAAAU2NhbGVkIGRhdGEgcHJvZHVjZWQgYXMgYSByZXN1bHQgb2YgZGF0YSBhY3F1" +
           "aXNpdGlvbiBvbiB0aGUgU3RyZWFtIGFuZCBhcHBsaWNhdGlvbiBvZiB0aGUgYW5hbHlzZXIgbW9kZWwA" +
           "LwEAPQmUKAAAABj/////AQEBAAAAACMBAQHGKAAAAAA1YIkKAgAAAAEABgAAAE9mZnNldAEBlygDAAAA" +
           "AGAAAABEaWZmZXJlbmNlIGluIG1pbGxpc2Vjb25kcyBiZXR3ZWVuIHRoZSBzdGFydCBvZiBzYW1wbGUg" +
           "ZXh0cmFjdGlvbiBhbmQgdGhlIHN0YXJ0IG9mIHRoZSBhbmFseXNpcy4ALwEAPQmXKAAAAQAiAf////8B" +
           "AQEAAAAAIwEBAcYoAAAAADVgiQoCAAAAAQASAAAAQWNxdWlzaXRpb25FbmRUaW1lAQGaKAMAAAAApwAA" +
           "AFRoZSBlbmQgdGltZSBvZiB0aGUgQW5hbHlzZVNhbXBsZSBvciBBbmFseXNlQ2FsaWJyYXRpb25TYW1w" +
           "bGUgb3IgQW5hbHlzZVZhbGlkYXRpb25TYW1wbGUgc3RhdGUgb2YgdGhlIEFuYWx5c2VyQ2hhbm5lbF9P" +
           "cGVyYXRpbmdNb2RlRXhlY3V0ZVN1YlN0YXRlTWFjaGluZSBzdGF0ZSBtYWNoaW5lAC8BAD0JmigAAAAN" +
           "/////wEBAQAAAAAjAQEBxigAAAAANWCJCgIAAAABAAoAAABDYW1wYWlnbklkAQGdKAMAAAAAHAAAAERl" +
           "ZmluZXMgdGhlIGN1cnJlbnQgY2FtcGFpZ24ALwEAPQmdKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1" +
           "YIkKAgAAAAEABwAAAEJhdGNoSWQBAaAoAwAAAAAZAAAARGVmaW5lcyB0aGUgY3VycmVudCBiYXRjaAAv" +
           "AQA9CaAoAAAADP////8DAwEAAAAAIwEBAcooAAAAADVgiQoCAAAAAQAKAAAAU3ViQmF0Y2hJZAEBoygD" +
           "AAAAAB0AAABEZWZpbmVzIHRoZSBjdXJyZW50IHN1Yi1iYXRjaAAvAQA9CaMoAAAADP////8DAwEAAAAA" +
           "IwEBAcooAAAAADVgiQoCAAAAAQAFAAAATG90SWQBAaYoAwAAAAAXAAAARGVmaW5lcyB0aGUgY3VycmVu" +
           "dCBsb3QALwEAPQmmKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEACgAAAE1hdGVyaWFs" +
           "SWQBAakoAwAAAAAcAAAARGVmaW5lcyB0aGUgY3VycmVudCBtYXRlcmlhbAAvAQA9CakoAAAADP////8D" +
           "AwEAAAAAIwEBAcooAAAAADVgiQoCAAAAAQAHAAAAUHJvY2VzcwEBrCgDAAAAABQAAABDdXJyZW50IFBy" +
           "b2Nlc3MgbmFtZQAvAQA9CawoAAAADP////8DAwEAAAAAIwEBAcooAAAAADVgiQoCAAAAAQAEAAAAVW5p" +
           "dAEBrygDAAAAABEAAABDdXJyZW50IFVuaXQgbmFtZQAvAQA9Ca8oAAAADP////8DAwEAAAAAIwEBAcoo" +
           "AAAAADVgiQoCAAAAAQAJAAAAT3BlcmF0aW9uAQGyKAMAAAAAFgAAAEN1cnJlbnQgT3BlcmF0aW9uIG5h" +
           "bWUALwEAPQmyKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEABQAAAFBoYXNlAQG1KAMA" +
           "AAAAEgAAAEN1cnJlbnQgUGhhc2UgbmFtZQAvAQA9CbUoAAAADP////8DAwEAAAAAIwEBAcooAAAAADVg" +
           "iQoCAAAAAQAGAAAAVXNlcklkAQG4KAMAAAAAPQAAAExvZ2luIG5hbWUgb2YgdGhlIHVzZXIgd2hvIGlz" +
           "IGxvZ2dlZCBvbiBhdCB0aGUgZGV2aWNlIGNvbnNvbGUALwEAPQm4KAAAAAz/////AwMBAAAAACMBAQHK" +
           "KAAAAAA1YIkKAgAAAAEACAAAAFNhbXBsZUlkAQG7KAMAAAAAGQAAAElkZW50aWZpZXIgZm9yIHRoZSBz" +
           "YW1wbGUALwEAPQm7KAAAAAz/////AwMBAAAAACMBAQHKKAAAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3Vy" +
           "YXRpb24BAb4oAC8BAu0DvigAAAIAAAAAIwABAWMoACMAAQFmKAAAAAAEYIAKAQAAAAEABgAAAFN0YXR1" +
           "cwEBwCgALwEC7QPAKAAABAAAAAAjAAEBaSgAIwABAWwoACMAAQFvKAAjAAEBcigAAAAABGCACgEAAAAB" +
           "ABMAAABBY3F1aXNpdGlvblNldHRpbmdzAQHCKAAvAQLtA8IoAAABAAAAACMAAQF1KAAAAAAEYIAKAQAA" +
           "AAEAEQAAAEFjcXVpc2l0aW9uU3RhdHVzAQHEKAAvAQLtA8QoAAAEAAAAACMAAQF7KAAjAAEBfigAIwAB" +
           "AYEoACMAAQGFKAAAAAAEYIAKAQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBxigALwEC7QPGKAAABgAA" +
           "AAAjAAEBiCgAIwABAY4oACMAAQGRKAAjAAEBlCgAIwABAZcoACMAAQGaKAAAAAAEYIAKAQAAAAEAGAAA" +
           "AENoZW1vbWV0cmljTW9kZWxTZXR0aW5ncwEByCgALwEC7QPIKAAA/////wAAAAAEYIAKAQAAAAEABwAA" +
           "AENvbnRleHQBAcooAC8BAu0DyigAAAsAAAAAIwABAZ0oACMAAQGgKAAjAAEBoygAIwABAaYoACMAAQGp" +
           "KAAjAAEBrCgAIwABAa8oACMAAQGyKAAjAAEBtSgAIwABAbgoACMAAQG7KAAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
        public FunctionalGroupState Status
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

        /// <remarks />
        public FunctionalGroupState AcquisitionSettings
        {
            get
            {
                return m_acquisitionSettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acquisitionSettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acquisitionSettings = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState AcquisitionStatus
        {
            get
            {
                return m_acquisitionStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acquisitionStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acquisitionStatus = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState AcquisitionData
        {
            get
            {
                return m_acquisitionData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acquisitionData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acquisitionData = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState ChemometricModelSettings
        {
            get
            {
                return m_chemometricModelSettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_chemometricModelSettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_chemometricModelSettings = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState Context
        {
            get
            {
                return m_context;
            }

            set
            {
                if (!Object.ReferenceEquals(m_context, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_context = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_acquisitionSettings != null)
            {
                children.Add(m_acquisitionSettings);
            }

            if (m_acquisitionStatus != null)
            {
                children.Add(m_acquisitionStatus);
            }

            if (m_acquisitionData != null)
            {
                children.Add(m_acquisitionData);
            }

            if (m_chemometricModelSettings != null)
            {
                children.Add(m_chemometricModelSettings);
            }

            if (m_context != null)
            {
                children.Add(m_context);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AcquisitionSettings:
                {
                    if (createOrReplace)
                    {
                        if (AcquisitionSettings == null)
                        {
                            if (replacement == null)
                            {
                                AcquisitionSettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AcquisitionSettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AcquisitionSettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AcquisitionStatus:
                {
                    if (createOrReplace)
                    {
                        if (AcquisitionStatus == null)
                        {
                            if (replacement == null)
                            {
                                AcquisitionStatus = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AcquisitionStatus = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AcquisitionStatus;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AcquisitionData:
                {
                    if (createOrReplace)
                    {
                        if (AcquisitionData == null)
                        {
                            if (replacement == null)
                            {
                                AcquisitionData = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AcquisitionData = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AcquisitionData;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.ChemometricModelSettings:
                {
                    if (createOrReplace)
                    {
                        if (ChemometricModelSettings == null)
                        {
                            if (replacement == null)
                            {
                                ChemometricModelSettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                ChemometricModelSettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = ChemometricModelSettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.Context:
                {
                    if (createOrReplace)
                    {
                        if (Context == null)
                        {
                            if (replacement == null)
                            {
                                Context = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Context = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Context;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private FunctionalGroupState m_acquisitionSettings;
        private FunctionalGroupState m_acquisitionStatus;
        private FunctionalGroupState m_acquisitionData;
        private FunctionalGroupState m_chemometricModelSettings;
        private FunctionalGroupState m_context;
        #endregion
    }
    #endif
    #endregion

    #region SpectrometerDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_SpectrometerDeviceStreamState)
    /// <summary>
    /// Stores an instance of the SpectrometerDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SpectrometerDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SpectrometerDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAkAAAAU3BlY3Ryb21ldGVyRGV2aWNlU3RyZWFtVHlw" +
           "ZUluc3RhbmNlAQEGBAEBBgT/////CQAAACRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHOKAMAAAAA" +
           "FwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOs4oAAD/////GAAAADVgiQoCAAAAAQAJAAAASXNF" +
           "bmFibGVkAQHkKAMAAAAANQAAAFRydWUgaWYgdGhpcyBzdHJlYW0gbWF5YmUgdXNlZCB0byBwZXJmb3Jt" +
           "IGFjcXVpc2l0aW9uAC8BAD0J5CgAAAAB/////wEBAQAAAAAjAQEBPykAAAAANWCJCgIAAAABABAAAABE" +
           "aWFnbm9zdGljU3RhdHVzAQHqKAMAAAAAFAAAAFN0cmVhbSBoZWFsdGggc3RhdHVzAC8BAD0J6igAAAEC" +
           "ZBj/////AQEBAAAAACMBAQFBKQAAAAA1YIkKAgAAAAEADgAAAExhc3RTYW1wbGVUaW1lAQHzKAMAAAAA" +
           "KgAAAFRpbWUgYXQgd2hpY2ggdGhlIGxhc3Qgc2FtcGxlIHdhcyBhY3F1aXJlZAAvAQA9CfMoAAAADf//" +
           "//8BAQEAAAAAIwEBAUEpAAAAADVgiQoCAAAAAQAIAAAASXNBY3RpdmUBAfwoAwAAAAA3AAAAVHJ1ZSBp" +
           "ZiB0aGlzIHN0cmVhbSBpcyBhY3R1YWxseSBydW5uaW5nLCBhY3F1aXJpbmcgZGF0YQAvAQA9CfwoAAAA" +
           "Af////8BAQEAAAAAIwEBAUUpAAAAADVgiQoCAAAAAQAOAAAARXhlY3V0aW9uQ3ljbGUBAf8oAwAAAAAu" +
           "AAAASW5kaWNhdGVzIHdoaWNoIEV4ZWN1dGlvbiBjeWNsZSBpcyBpbiBwcm9ncmVzcwAvAQA9Cf8oAAAB" +
           "AaIk/////wEBAQAAAAAjAQEBRSkAAAAANWCJCgIAAAABABUAAABFeGVjdXRpb25DeWNsZVN1YmNvZGUB" +
           "AQIpAwAAAAA2AAAASW5kaWNhdGVzIHdoaWNoIEV4ZWN1dGlvbiBjeWNsZSBzdWJjb2RlIGlzIGluIHBy" +
           "b2dyZXNzAC8BAEgJAikAAAAc/////wEBAQAAAAAjAQEBRSkBAAAAF2CJCgIAAAAAAAsAAABFbnVtU3Ry" +
           "aW5ncwEBBSkALgBEBSkAAAAVAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoCAAAAAQAIAAAAUHJvZ3Jl" +
           "c3MBAQYpAwAAAAB0AAAASW5kaWNhdGVzIHRoZSBwcm9ncmVzcyBvZiBhbiBhY3F1aXNpdGlvbiBpbiB0" +
           "ZXJtcyBvZiBwZXJjZW50YWdlIG9mIGNvbXBsZXRpb24uIEl0cyB2YWx1ZSBzaGFsbCBiZSBiZXR3ZWVu" +
           "IDAgYW5kIDEwMC4ALwEAPQkGKQAAAAr/////AQEBAAAAACMBAQFFKQAAAAA1YIkKAgAAAAEAEgAAAEFj" +
           "cXVpc2l0aW9uQ291bnRlcgEBCSkDAAAAAFMAAABTaW1wbGUgY291bnRlciBpbmNyZW1lbnRlZCBhZnRl" +
           "ciBlYWNoIFNhbXBsaW5nIGFjcXVpc2l0aW9uIHBlcmZvcm1lZCBvbiB0aGlzIFN0cmVhbQAvAQBACQkp" +
           "AAABACEB/////wEBAQAAAAAjAQEBRykBAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQENKQAuAEQNKQAA" +
           "AQB0A/////8BAf////8AAAAANWCJCgIAAAABABcAAABBY3F1aXNpdGlvblJlc3VsdFN0YXR1cwEBDykD" +
           "AAAAABoAAABRdWFsaXR5IG9mIHRoZSBhY3F1aXNpdGlvbgAvAQA9CQ8pAAABAbsL/////wEBAQAAAAAj" +
           "AQEBRykAAAAANWCJCgIAAAABAAoAAABTY2FsZWREYXRhAQEVKQMAAAAAaAAAAFNjYWxlZCBkYXRhIHBy" +
           "b2R1Y2VkIGFzIGEgcmVzdWx0IG9mIGRhdGEgYWNxdWlzaXRpb24gb24gdGhlIFN0cmVhbSBhbmQgYXBw" +
           "bGljYXRpb24gb2YgdGhlIGFuYWx5c2VyIG1vZGVsAC8BAD0JFSkAAAAY/////wEBAQAAAAAjAQEBRykA" +
           "AAAANWCJCgIAAAABABIAAABBY3F1aXNpdGlvbkVuZFRpbWUBARspAwAAAACnAAAAVGhlIGVuZCB0aW1l" +
           "IG9mIHRoZSBBbmFseXNlU2FtcGxlIG9yIEFuYWx5c2VDYWxpYnJhdGlvblNhbXBsZSBvciBBbmFseXNl" +
           "VmFsaWRhdGlvblNhbXBsZSBzdGF0ZSBvZiB0aGUgQW5hbHlzZXJDaGFubmVsX09wZXJhdGluZ01vZGVF" +
           "eGVjdXRlU3ViU3RhdGVNYWNoaW5lIHN0YXRlIG1hY2hpbmUALwEAPQkbKQAAAA3/////AQEBAAAAACMB" +
           "AQFHKQAAAAAVYIkKAgAAAAEAEAAAAEFjdGl2ZUJhY2tncm91bmQBAU8pAC8BAP0uTykAAAAK/////wEB" +
           "AQAAAAAjAQEBPykFAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFTKQAuAERTKQAAAQB0A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQFUKQAuAERUKQAAAQB3A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAUAAABUaXRsZQEBVSkALgBEVSkAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADQAAAEF4aXNTY2FsZVR5cGUBAVYpAC4ARFYpAAABAC0v/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DwAAAFhBeGlzRGVmaW5pdGlvbgEBVykALgBEVykAAAEALy//////AQH/////AAAAABVgiQoCAAAAAQAR" +
           "AAAAQWN0aXZlQmFja2dyb3VuZDEBAVgpAC8BAP0uWCkAAAAK/////wEBAQAAAAAjAQEBPykFAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQFcKQAuAERcKQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABFbmdpbmVlcmluZ1VuaXRzAQFdKQAuAERdKQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAAAAAUA" +
           "AABUaXRsZQEBXikALgBEXikAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAEF4aXNTY2FsZVR5" +
           "cGUBAV8pAC4ARF8pAAABAC0v/////wEB/////wAAAAAVYIkKAgAAAAAADwAAAFhBeGlzRGVmaW5pdGlv" +
           "bgEBYCkALgBEYCkAAAEALy//////AQH/////AAAAABdgiQoCAAAAAQANAAAAU3BlY3RyYWxSYW5nZQEB" +
           "YSkALwEAPQlhKQAAAQB0AwEAAAABAAAAAAAAAAEBAQAAAAAjAQEBQykAAAAAFWCJCgIAAAABAAoAAABS" +
           "ZXNvbHV0aW9uAQFkKQAvAQA9CWQpAAAAGP////8BAQEAAAAAIwEBAUMpAAAAABVgiQoCAAAAAQAWAAAA" +
           "UmVxdWVzdGVkTnVtYmVyT2ZTY2FucwEBZykALwEAPQlnKQAAAAb/////AQEBAAAAACMBAQFDKQAAAAAV" +
           "YIkKAgAAAAEABAAAAEdhaW4BAWopAC8BAD0JaikAAAAY/////wEBAQAAAAAjAQEBQykAAAAAFWCJCgIA" +
           "AAABABMAAABUcmFuc21pdHRhbmNlQ3V0b2ZmAQFtKQAvAQA9CW0pAAABAHQD/////wEBAQAAAAAjAQEB" +
           "QykAAAAAFWCJCgIAAAABABAAAABBYnNvcmJhbmNlQ3V0b2ZmAQFwKQAvAQA9CXApAAABAHQD/////wEB" +
           "AQAAAAAjAQEBQykAAAAAFWCJCgIAAAABABEAAABOdW1iZXJPZlNjYW5zRG9uZQEBcykALwEAPQlzKQAA" +
           "AAb/////AQEBAAAAACMBAQFFKQAAAAAVYIkKAgAAAAEAFgAAAFRvdGFsTnVtYmVyT2ZTY2Fuc0RvbmUB" +
           "AXYpAC8BAD0JdikAAAAG/////wEBAQAAAAAjAQEBRykAAAAAFWCJCgIAAAABABkAAABCYWNrZ3JvdW5k" +
           "QWNxdWlzaXRpb25UaW1lAQF5KQAvAQA9CXkpAAAADf////8BAQEAAAAAIwEBAUcpAAAAABVgiQoCAAAA" +
           "AQARAAAAUGVuZGluZ0JhY2tncm91bmQBAXwpAC8BAP0ufCkAAAAK/////wEBAQAAAAAjAQEBRykFAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQGAKQAuAESAKQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABFbmdpbmVlcmluZ1VuaXRzAQGBKQAuAESBKQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAUAAABUaXRsZQEBgikALgBEgikAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAEF4aXNTY2Fs" +
           "ZVR5cGUBAYMpAC4ARIMpAAABAC0v/////wEB/////wAAAAAVYIkKAgAAAAAADwAAAFhBeGlzRGVmaW5p" +
           "dGlvbgEBhCkALgBEhCkAAAEALy//////AQH/////AAAAABVgiQoCAAAAAQASAAAAUGVuZGluZ0JhY2tn" +
           "cm91bmQxAQGFKQAvAQD9LoUpAAAACv////8BAQEAAAAAIwEBAUcpBQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBiSkALgBEiSkAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAAAQAAAARW5naW5lZXJpbmdV" +
           "bml0cwEBiikALgBEiikAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAAAFAAAAVGl0bGUBAYspAC4A" +
           "RIspAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABBeGlzU2NhbGVUeXBlAQGMKQAuAESMKQAA" +
           "AQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhpc0RlZmluaXRpb24BAY0pAC4ARI0pAAAB" +
           "AC8v/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAT8pAC8BAu0DPykAAAQA" +
           "AAAAIwABAeQoACMAAQHnKAAjAAEBTykAIwABAVgpAAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQFBKQAv" +
           "AQLtA0EpAAAEAAAAACMAAQHqKAAjAAEB7SgAIwABAfAoACMAAQHzKAAAAAAEYIAKAQAAAAEAEwAAAEFj" +
           "cXVpc2l0aW9uU2V0dGluZ3MBAUMpAC8BAu0DQykAAAcAAAAAIwABAfYoACMAAQFhKQAjAAEBZCkAIwAB" +
           "AWcpACMAAQFqKQAjAAEBbSkAIwABAXApAAAAAARggAoBAAAAAQARAAAAQWNxdWlzaXRpb25TdGF0dXMB" +
           "AUUpAC8BAu0DRSkAAAUAAAAAIwABAfwoACMAAQH/KAAjAAEBAikAIwABAQYpACMAAQFzKQAAAAAEYIAK" +
           "AQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBRykALwEC7QNHKQAACgAAAAAjAAEBCSkAIwABAQ8pACMA" +
           "AQESKQAjAAEBFSkAIwABARgpACMAAQEbKQAjAAEBdikAIwABAXkpACMAAQF8KQAjAAEBhSkAAAAABGCA" +
           "CgEAAAABABgAAABDaGVtb21ldHJpY01vZGVsU2V0dGluZ3MBAUkpAC8BAu0DSSkAAP////8AAAAABGCA" +
           "CgEAAAABAAcAAABDb250ZXh0AQFLKQAvAQLtA0spAAALAAAAACMAAQEeKQAjAAEBISkAIwABASQpACMA" +
           "AQEnKQAjAAEBKikAIwABAS0pACMAAQEwKQAjAAEBMykAIwABATYpACMAAQE5KQAjAAEBPCkAAAAABGCA" +
           "CgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAY4pAC8AOo4pAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState FactorySettings
        {
            get
            {
                return m_factorySettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_factorySettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_factorySettings = value;
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
            if (m_factorySettings != null)
            {
                children.Add(m_factorySettings);
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
                case Opc.Ua.Adi.BrowseNames.FactorySettings:
                {
                    if (createOrReplace)
                    {
                        if (FactorySettings == null)
                        {
                            if (replacement == null)
                            {
                                FactorySettings = new BaseObjectState(this);
                            }
                            else
                            {
                                FactorySettings = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = FactorySettings;
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
        private BaseObjectState m_factorySettings;
        #endregion
    }
    #endif
    #endregion

    #region MassSpectrometerDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_MassSpectrometerDeviceStreamState)
    /// <summary>
    /// Stores an instance of the MassSpectrometerDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassSpectrometerDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassSpectrometerDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.MassSpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAoAAAATWFzc1NwZWN0cm9tZXRlckRldmljZVN0cmVh" +
           "bVR5cGVJbnN0YW5jZQEBBwQBAQcE/////wcAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAQAq" +
           "AC8BAu0DACoAAAIAAAAAIwABAaUpACMAAQGoKQAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBAioALwEC" +
           "7QMCKgAABAAAAAAjAAEBqykAIwABAa4pACMAAQGxKQAjAAEBtCkAAAAABGCACgEAAAABABMAAABBY3F1" +
           "aXNpdGlvblNldHRpbmdzAQEEKgAvAQLtAwQqAAABAAAAACMAAQG3KQAAAAAEYIAKAQAAAAEAEQAAAEFj" +
           "cXVpc2l0aW9uU3RhdHVzAQEGKgAvAQLtAwYqAAAEAAAAACMAAQG9KQAjAAEBwCkAIwABAcMpACMAAQHH" +
           "KQAAAAAEYIAKAQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBCCoALwEC7QMIKgAABgAAAAAjAAEByikA" +
           "IwABAdApACMAAQHTKQAjAAEB1ikAIwABAdkpACMAAQHcKQAAAAAEYIAKAQAAAAEAGAAAAENoZW1vbWV0" +
           "cmljTW9kZWxTZXR0aW5ncwEBCioALwEC7QMKKgAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRleHQB" +
           "AQwqAC8BAu0DDCoAAAsAAAAAIwABAd8pACMAAQHiKQAjAAEB5SkAIwABAegpACMAAQHrKQAjAAEB7ikA" +
           "IwABAfEpACMAAQH0KQAjAAEB9ykAIwABAfopACMAAQH9KQAAAAA=";
        #endregion
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

    #region ParticleSizeMonitorDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_ParticleSizeMonitorDeviceStreamState)
    /// <summary>
    /// Stores an instance of the ParticleSizeMonitorDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ParticleSizeMonitorDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ParticleSizeMonitorDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ParticleSizeMonitorDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQArAAAAUGFydGljbGVTaXplTW9uaXRvckRldmljZVN0" +
           "cmVhbVR5cGVJbnN0YW5jZQEBCAQBAQgE/////wgAAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEB" +
           "ECoDAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADoQKgAA/////w4AAAA1YIkKAgAAAAEA" +
           "CQAAAElzRW5hYmxlZAEBJioDAAAAADUAAABUcnVlIGlmIHRoaXMgc3RyZWFtIG1heWJlIHVzZWQgdG8g" +
           "cGVyZm9ybSBhY3F1aXNpdGlvbgAvAQA9CSYqAAAAAf////8BAQEAAAAAIwEBAYEqAAAAADVgiQoCAAAA" +
           "AQAQAAAARGlhZ25vc3RpY1N0YXR1cwEBLCoDAAAAABQAAABTdHJlYW0gaGVhbHRoIHN0YXR1cwAvAQA9" +
           "CSwqAAABAmQY/////wEBAQAAAAAjAQEBgyoAAAAANWCJCgIAAAABAA4AAABMYXN0U2FtcGxlVGltZQEB" +
           "NSoDAAAAACoAAABUaW1lIGF0IHdoaWNoIHRoZSBsYXN0IHNhbXBsZSB3YXMgYWNxdWlyZWQALwEAPQk1" +
           "KgAAAA3/////AQEBAAAAACMBAQGDKgAAAAA1YIkKAgAAAAEACAAAAElzQWN0aXZlAQE+KgMAAAAANwAA" +
           "AFRydWUgaWYgdGhpcyBzdHJlYW0gaXMgYWN0dWFsbHkgcnVubmluZywgYWNxdWlyaW5nIGRhdGEALwEA" +
           "PQk+KgAAAAH/////AQEBAAAAACMBAQGHKgAAAAA1YIkKAgAAAAEADgAAAEV4ZWN1dGlvbkN5Y2xlAQFB" +
           "KgMAAAAALgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3ljbGUgaXMgaW4gcHJvZ3Jlc3MALwEA" +
           "PQlBKgAAAQGiJP////8BAQEAAAAAIwEBAYcqAAAAADVgiQoCAAAAAQAVAAAARXhlY3V0aW9uQ3ljbGVT" +
           "dWJjb2RlAQFEKgMAAAAANgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3ljbGUgc3ViY29kZSBp" +
           "cyBpbiBwcm9ncmVzcwAvAQBICUQqAAAAHP////8BAQEAAAAAIwEBAYcqAQAAABdgiQoCAAAAAAALAAAA" +
           "RW51bVN0cmluZ3MBAUcqAC4AREcqAAAAFQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAEACAAA" +
           "AFByb2dyZXNzAQFIKgMAAAAAdAAAAEluZGljYXRlcyB0aGUgcHJvZ3Jlc3Mgb2YgYW4gYWNxdWlzaXRp" +
           "b24gaW4gdGVybXMgb2YgcGVyY2VudGFnZSBvZiBjb21wbGV0aW9uLiBJdHMgdmFsdWUgc2hhbGwgYmUg" +
           "YmV0d2VlbiAwIGFuZCAxMDAuAC8BAD0JSCoAAAAK/////wEBAQAAAAAjAQEBhyoAAAAANWCJCgIAAAAB" +
           "ABIAAABBY3F1aXNpdGlvbkNvdW50ZXIBAUsqAwAAAABTAAAAU2ltcGxlIGNvdW50ZXIgaW5jcmVtZW50" +
           "ZWQgYWZ0ZXIgZWFjaCBTYW1wbGluZyBhY3F1aXNpdGlvbiBwZXJmb3JtZWQgb24gdGhpcyBTdHJlYW0A" +
           "LwEAQAlLKgAAAQAhAf////8BAQEAAAAAIwEBAYkqAQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBTyoA" +
           "LgBETyoAAAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAXAAAAQWNxdWlzaXRpb25SZXN1bHRTdGF0" +
           "dXMBAVEqAwAAAAAaAAAAUXVhbGl0eSBvZiB0aGUgYWNxdWlzaXRpb24ALwEAPQlRKgAAAQG7C/////8B" +
           "AQEAAAAAIwEBAYkqAAAAADVgiQoCAAAAAQAKAAAAU2NhbGVkRGF0YQEBVyoDAAAAAGgAAABTY2FsZWQg" +
           "ZGF0YSBwcm9kdWNlZCBhcyBhIHJlc3VsdCBvZiBkYXRhIGFjcXVpc2l0aW9uIG9uIHRoZSBTdHJlYW0g" +
           "YW5kIGFwcGxpY2F0aW9uIG9mIHRoZSBhbmFseXNlciBtb2RlbAAvAQA9CVcqAAAAGP////8BAQEAAAAA" +
           "IwEBAYkqAAAAADVgiQoCAAAAAQASAAAAQWNxdWlzaXRpb25FbmRUaW1lAQFdKgMAAAAApwAAAFRoZSBl" +
           "bmQgdGltZSBvZiB0aGUgQW5hbHlzZVNhbXBsZSBvciBBbmFseXNlQ2FsaWJyYXRpb25TYW1wbGUgb3Ig" +
           "QW5hbHlzZVZhbGlkYXRpb25TYW1wbGUgc3RhdGUgb2YgdGhlIEFuYWx5c2VyQ2hhbm5lbF9PcGVyYXRp" +
           "bmdNb2RlRXhlY3V0ZVN1YlN0YXRlTWFjaGluZSBzdGF0ZSBtYWNoaW5lAC8BAD0JXSoAAAAN/////wEB" +
           "AQAAAAAjAQEBiSoAAAAAFWCJCgIAAAABAAoAAABCYWNrZ3JvdW5kAQGRKgAvAQD9LpEqAAAACv////8B" +
           "AQEAAAAAIwEBAYkqBQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBlSoALgBElSoAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBlioALgBElioAAAEAdwP/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAFAAAAVGl0bGUBAZcqAC4ARJcqAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAA0AAABBeGlzU2NhbGVUeXBlAQGYKgAuAESYKgAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AA8AAABYQXhpc0RlZmluaXRpb24BAZkqAC4ARJkqAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "EAAAAFNpemVEaXN0cmlidXRpb24BAZoqAC8BAP0umioAAAAK/////wEBAQAAAAAjAQEBiSoFAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQGeKgAuAESeKgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABFbmdpbmVlcmluZ1VuaXRzAQGfKgAuAESfKgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAAAAAUA" +
           "AABUaXRsZQEBoCoALgBEoCoAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAEF4aXNTY2FsZVR5" +
           "cGUBAaEqAC4ARKEqAAABAC0v/////wEB/////wAAAAAVYIkKAgAAAAAADwAAAFhBeGlzRGVmaW5pdGlv" +
           "bgEBoioALgBEoioAAAEALy//////AQH/////AAAAABVgiQoCAAAAAQAZAAAAQmFja2dyb3VuZEFjcXVp" +
           "c2l0aW9uVGltZQEBoyoALwEAPQmjKgAAAA3/////AQEBAAAAACMBAQGJKgAAAAAEYIAKAQAAAAEADQAA" +
           "AENvbmZpZ3VyYXRpb24BAYEqAC8BAu0DgSoAAAIAAAAAIwABASYqACMAAQEpKgAAAAAEYIAKAQAAAAEA" +
           "BgAAAFN0YXR1cwEBgyoALwEC7QODKgAABAAAAAAjAAEBLCoAIwABAS8qACMAAQEyKgAjAAEBNSoAAAAA" +
           "BGCACgEAAAABABMAAABBY3F1aXNpdGlvblNldHRpbmdzAQGFKgAvAQLtA4UqAAABAAAAACMAAQE4KgAA" +
           "AAAEYIAKAQAAAAEAEQAAAEFjcXVpc2l0aW9uU3RhdHVzAQGHKgAvAQLtA4cqAAAEAAAAACMAAQE+KgAj" +
           "AAEBQSoAIwABAUQqACMAAQFIKgAAAAAEYIAKAQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBiSoALwEC" +
           "7QOJKgAACQAAAAAjAAEBSyoAIwABAVEqACMAAQFUKgAjAAEBVyoAIwABAVoqACMAAQFdKgAjAAEBkSoA" +
           "IwABAZoqACMAAQGjKgAAAAAEYIAKAQAAAAEAGAAAAENoZW1vbWV0cmljTW9kZWxTZXR0aW5ncwEBiyoA" +
           "LwEC7QOLKgAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRleHQBAY0qAC8BAu0DjSoAAAsAAAAAIwAB" +
           "AWAqACMAAQFjKgAjAAEBZioAIwABAWkqACMAAQFsKgAjAAEBbyoAIwABAXIqACMAAQF1KgAjAAEBeCoA" +
           "IwABAXsqACMAAQF+KgAAAAA=";
        #endregion
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

    #region AcousticSpectrometerDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_AcousticSpectrometerDeviceStreamState)
    /// <summary>
    /// Stores an instance of the AcousticSpectrometerDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AcousticSpectrometerDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AcousticSpectrometerDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AcousticSpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAsAAAAQWNvdXN0aWNTcGVjdHJvbWV0ZXJEZXZpY2VT" +
           "dHJlYW1UeXBlSW5zdGFuY2UBAQkEAQEJBP////8HAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9u" +
           "AQEXKwAvAQLtAxcrAAACAAAAACMAAQG8KgAjAAEBvyoAAAAABGCACgEAAAABAAYAAABTdGF0dXMBARkr" +
           "AC8BAu0DGSsAAAQAAAAAIwABAcIqACMAAQHFKgAjAAEByCoAIwABAcsqAAAAAARggAoBAAAAAQATAAAA" +
           "QWNxdWlzaXRpb25TZXR0aW5ncwEBGysALwEC7QMbKwAAAQAAAAAjAAEBzioAAAAABGCACgEAAAABABEA" +
           "AABBY3F1aXNpdGlvblN0YXR1cwEBHSsALwEC7QMdKwAABAAAAAAjAAEB1CoAIwABAdcqACMAAQHaKgAj" +
           "AAEB3ioAAAAABGCACgEAAAABAA8AAABBY3F1aXNpdGlvbkRhdGEBAR8rAC8BAu0DHysAAAYAAAAAIwAB" +
           "AeEqACMAAQHnKgAjAAEB6ioAIwABAe0qACMAAQHwKgAjAAEB8yoAAAAABGCACgEAAAABABgAAABDaGVt" +
           "b21ldHJpY01vZGVsU2V0dGluZ3MBASErAC8BAu0DISsAAP////8AAAAABGCACgEAAAABAAcAAABDb250" +
           "ZXh0AQEjKwAvAQLtAyMrAAALAAAAACMAAQH2KgAjAAEB+SoAIwABAfwqACMAAQH/KgAjAAEBAisAIwAB" +
           "AQUrACMAAQEIKwAjAAEBCysAIwABAQ4rACMAAQERKwAjAAEBFCsAAAAA";
        #endregion
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

    #region ChromatographDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_ChromatographDeviceStreamState)
    /// <summary>
    /// Stores an instance of the ChromatographDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChromatographDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChromatographDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ChromatographDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQ2hyb21hdG9ncmFwaERldmljZVN0cmVhbVR5" +
           "cGVJbnN0YW5jZQEBCgQBAQoE/////wcAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAZgrAC8B" +
           "Au0DmCsAAAIAAAAAIwABAT0rACMAAQFAKwAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBmisALwEC7QOa" +
           "KwAABAAAAAAjAAEBQysAIwABAUYrACMAAQFJKwAjAAEBTCsAAAAABGCACgEAAAABABMAAABBY3F1aXNp" +
           "dGlvblNldHRpbmdzAQGcKwAvAQLtA5wrAAABAAAAACMAAQFPKwAAAAAEYIAKAQAAAAEAEQAAAEFjcXVp" +
           "c2l0aW9uU3RhdHVzAQGeKwAvAQLtA54rAAAEAAAAACMAAQFVKwAjAAEBWCsAIwABAVsrACMAAQFfKwAA" +
           "AAAEYIAKAQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBoCsALwEC7QOgKwAABgAAAAAjAAEBYisAIwAB" +
           "AWgrACMAAQFrKwAjAAEBbisAIwABAXErACMAAQF0KwAAAAAEYIAKAQAAAAEAGAAAAENoZW1vbWV0cmlj" +
           "TW9kZWxTZXR0aW5ncwEBoisALwEC7QOiKwAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRleHQBAaQr" +
           "AC8BAu0DpCsAAAsAAAAAIwABAXcrACMAAQF6KwAjAAEBfSsAIwABAYArACMAAQGDKwAjAAEBhisAIwAB" +
           "AYkrACMAAQGMKwAjAAEBjysAIwABAZIrACMAAQGVKwAAAAA=";
        #endregion
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

    #region MNRDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_MNRDeviceStreamState)
    /// <summary>
    /// Stores an instance of the MNRDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MNRDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MNRDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.MNRDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAATU5SRGV2aWNlU3RyZWFtVHlwZUluc3RhbmNl" +
           "AQELBAEBCwT/////BwAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBGSwALwEC7QMZLAAAAgAA" +
           "AAAjAAEBvisAIwABAcErAAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQEbLAAvAQLtAxssAAAEAAAAACMA" +
           "AQHEKwAjAAEBxysAIwABAcorACMAAQHNKwAAAAAEYIAKAQAAAAEAEwAAAEFjcXVpc2l0aW9uU2V0dGlu" +
           "Z3MBAR0sAC8BAu0DHSwAAAEAAAAAIwABAdArAAAAAARggAoBAAAAAQARAAAAQWNxdWlzaXRpb25TdGF0" +
           "dXMBAR8sAC8BAu0DHywAAAQAAAAAIwABAdYrACMAAQHZKwAjAAEB3CsAIwABAeArAAAAAARggAoBAAAA" +
           "AQAPAAAAQWNxdWlzaXRpb25EYXRhAQEhLAAvAQLtAyEsAAAGAAAAACMAAQHjKwAjAAEB6SsAIwABAewr" +
           "ACMAAQHvKwAjAAEB8isAIwABAfUrAAAAAARggAoBAAAAAQAYAAAAQ2hlbW9tZXRyaWNNb2RlbFNldHRp" +
           "bmdzAQEjLAAvAQLtAyMsAAD/////AAAAAARggAoBAAAAAQAHAAAAQ29udGV4dAEBJSwALwEC7QMlLAAA" +
           "CwAAAAAjAAEB+CsAIwABAfsrACMAAQH+KwAjAAEBASwAIwABAQQsACMAAQEHLAAjAAEBCiwAIwABAQ0s" +
           "ACMAAQEQLAAjAAEBEywAIwABARYsAAAAAA==";
        #endregion
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

    #region SpectrometerDeviceState Class
    #if (!OPCUA_EXCLUDE_SpectrometerDeviceState)
    /// <summary>
    /// Stores an instance of the SpectrometerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SpectrometerDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SpectrometerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAeAAAAU3BlY3Ryb21ldGVyRGV2aWNlVHlwZUluc3Rh" +
           "bmNlAQHzAwEB8wMB/////w8AAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEBKSwDAAAAABcAAABG" +
           "bGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADopLAAA/////wIAAAA1YIkKAgAAAAEAEAAAAERpYWdub3N0" +
           "aWNTdGF0dXMBAXgsAwAAAAAlAAAAR2VuZXJhbCBoZWFsdGggc3RhdHVzIG9mIHRoZSBhbmFseXNlcgAv" +
           "AQA9CXgsAAABAmQY/////wEBAQAAAAAjAQEBkSwAAAAAF2CJCgIAAAABAA0AAABTcGVjdHJhbFJhbmdl" +
           "AQEfLQAvAQA9CR8tAAABAHQDAQAAAAEAAAAAAAAAAQH/////AAAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQErLAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOissAAD/////CgAAAARhggoEAAAA" +
           "AQAQAAAAR2V0Q29uZmlndXJhdGlvbgEBaCwALwEB4yRoLAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQFpLAAuAERpLAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRp" +
           "b24BAWosAC8BAeUkaiwAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFrLAAu" +
           "AERrLAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBbCwALgBEbCwAAJYBAAAAAQAq" +
           "AQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAABGGCCgQAAAABABMAAABHZXRDb25maWdEYXRhRGlnZXN0AQFtLAAvAQHoJG0sAAABAf////8BAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAW4sAC4ARG4sAACWAQAAAAEAKgEBHwAAABAAAABD" +
           "b25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAW8sAC8BAeokbywAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQFwLAAuAERwLAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0" +
           "YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBcSwALgBEcSwAAJYBAAAAAQAqAQEWAAAABwAAAElzRXF1YWwAAf////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAJGGCCgQAAAABABAAAABSZXNldEFsbENoYW5uZWxzAQFy" +
           "LAMAAAAAPAAAAFJlc2V0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHtJHIsAAABAf////8AAAAAJGGCCgQAAAABABAAAABTdGFydEFsbENoYW5uZWxz" +
           "AQFzLAMAAAAAPAAAAFN0YXJ0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHuJHMsAAABAf////8AAAAAJGGCCgQAAAABAA8AAABTdG9wQWxsQ2hhbm5l" +
           "bHMBAXQsAwAAAAA7AAAAU3RvcCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBB" +
           "bmFseXNlckRldmljZS4ALwEB7yR0LAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAQWJvcnRBbGxDaGFu" +
           "bmVscwEBdSwDAAAAADwAAABBYm9ydCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhp" +
           "cyBBbmFseXNlckRldmljZS4ALwEB8CR1LAAAAQH/////AAAAACRhggoEAAAAAQANAAAAR290b09wZXJh" +
           "dGluZwEBdiwDAAAAAI0AAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBPcGVyYXRp" +
           "bmcgc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gbGVhdmUgdGhlIFNsYXZlTW9k" +
           "ZSBzdGF0ZSBhbmQgZ28gdG8gdGhlIE9wZXJhdGluZyBzdGF0ZS4ALwEB8SR2LAAAAQH/////AAAAACRh" +
           "ggoEAAAAAQAPAAAAR290b01haW50ZW5hbmNlAQF3LAMAAAAAZwAAAEFuYWx5c2VyRGV2aWNlU3RhdGVN" +
           "YWNoaW5lIHRvIGdvIHRvIE1haW50ZW5hbmNlIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5u" +
           "ZWxzIHRvIFNsYXZlTW9kZSBzdGF0ZS4ALwEB8iR3LAAAAQH/////AAAAACRggAoBAAAAAgAOAAAASWRl" +
           "bnRpZmljYXRpb24BAS8sAwAAAABGAAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVu" +
           "dGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVudAAvAQLtAy8sAAADAAAAACMAAQJzFwAjAAEC" +
           "dBcAIwABAnEXAAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQE/LAMAAAAATQAAAElkZW50aWZp" +
           "ZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNl" +
           "IGluc3RhbmNlAC4ARD8sAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50" +
           "ZXIBAUAsAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIg" +
           "b2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVk" +
           "AC4AREAsAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAUEsAwAAAAAw" +
           "AAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4AREEsAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBQiwDAAAAABgAAABNb2RlbCBuYW1lIG9m" +
           "IHRoZSBkZXZpY2UALgBEQiwAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVh" +
           "bAEBQywDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwg" +
           "fCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEQywAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQFELAMAAAAAJAAAAE92ZXJhbGwgcmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERELAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAAU29mdHdhcmVSZXZpc2lvbgEBRSwDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdh" +
           "cmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAERFLAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAASGFyZHdhcmVSZXZpc2lvbgEBRiwDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAERGLAAAAAz/////AQH/////AAAAAARggAoBAAAAAQANAAAAQ29uZmln" +
           "dXJhdGlvbgEBjywALwEC7QOPLAAAAQAAAAAjAAEBeywAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAZEs" +
           "AC8BAu0DkSwAAAEAAAAAIwABAXgsAAAAAARggAoBAAAAAQAPAAAARmFjdG9yeVNldHRpbmdzAQGTLAAv" +
           "AQLtA5MsAAD/////AAAAAARggAoBAAAAAQAUAAAAQW5hbHlzZXJTdGF0ZU1hY2hpbmUBAZUsAC8BAeoD" +
           "lSwAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAZYsAC8BAMgKliwAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGXLAAuAESXLAAAABH/////AQH/////AAAAAA==";
        #endregion
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

    #region ParticleSizeMonitorDeviceState Class
    #if (!OPCUA_EXCLUDE_ParticleSizeMonitorDeviceState)
    /// <summary>
    /// Stores an instance of the ParticleSizeMonitorDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ParticleSizeMonitorDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ParticleSizeMonitorDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ParticleSizeMonitorDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAlAAAAUGFydGljbGVTaXplTW9uaXRvckRldmljZVR5" +
           "cGVJbnN0YW5jZQEB9AMBAfQDAf////8OAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBASQtAwAAAAAU" +
           "AAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6JC0AAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25m" +
           "aWd1cmF0aW9uAQFhLQAvAQHjJGEtAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAWItAC4ARGItAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBYy0ALwEB5SRj" +
           "LQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWQtAC4ARGQtAACWAQAAAAEA" +
           "KgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFlLQAuAERlLQAAlgEAAAABACoBAR8AAAAQAAAAQ29u" +
           "ZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEA" +
           "EwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAWYtAC8BAegkZi0AAAEB/////wEAAAAXYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBZy0ALgBEZy0AAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdl" +
           "c3QADP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABcAAABDb21wYXJl" +
           "Q29uZmlnRGF0YURpZ2VzdAEBaC0ALwEB6iRoLQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAWktAC4ARGktAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQFqLQAuAERqLQAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAWstAwAAAAA8AAAAUmVz" +
           "ZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8B" +
           "Ae0kay0AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAWwtAwAAAAA8AAAA" +
           "U3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2Uu" +
           "AC8BAe4kbC0AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEBbS0DAAAAADsA" +
           "AABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNl" +
           "LgAvAQHvJG0tAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxzAQFuLQMAAAAA" +
           "PAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2" +
           "aWNlLgAvAQHwJG4tAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5nAQFvLQMAAAAA" +
           "jQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0ZSwgZm9y" +
           "Y2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRlIGFuZCBn" +
           "byB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJG8tAAABAf////8AAAAAJGGCCgQAAAABAA8AAABH" +
           "b3RvTWFpbnRlbmFuY2UBAXAtAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28g" +
           "dG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gU2xhdmVN" +
           "b2RlIHN0YXRlLgAvAQHyJHAtAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlmaWNhdGlvbgEB" +
           "KC0DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0aW9uIG9m" +
           "IHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DKC0AAAMAAAAAIwABAnMXACMAAQJ0FwAjAAECcRcAAAAA" +
           "NWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBATgtAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1" +
           "ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE" +
           "OC0AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBOS0DAAAAAGkA" +
           "AABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUg" +
           "c3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEOS0AAAAG////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBOi0DAAAAADAAAABOYW1lIG9mIHRo" +
           "ZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEOi0AAAAV/////wEB/////wAA" +
           "AAA1YIkKAgAAAAIABQAAAE1vZGVsAQE7LQMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAu" +
           "AEQ7LQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQE8LQMAAAAAWgAA" +
           "AEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNz" +
           "KSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQ8LQAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAT0tAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBv" +
           "ZiB0aGUgZGV2aWNlAC4ARD0tAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJl" +
           "dmlzaW9uAQE+LQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARD4tAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJl" +
           "dmlzaW9uAQE/LQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARD8tAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQGILQAv" +
           "AQLtA4gtAAABAAAAACMAAQF0LQAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBii0ALwEC7QOKLQAAAQAA" +
           "AAAjAAEBcS0AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAYwtAC8BAu0DjC0AAP////8A" +
           "AAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBji0ALwEB6gOOLQAA/////wEAAAAV" +
           "YIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBjy0ALwEAyAqPLQAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBAZAtAC4ARJAtAAAAEf////8BAf////8AAAAA";
        #endregion
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

    #region ChromatographDeviceState Class
    #if (!OPCUA_EXCLUDE_ChromatographDeviceState)
    /// <summary>
    /// Stores an instance of the ChromatographDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChromatographDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChromatographDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ChromatographDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAfAAAAQ2hyb21hdG9ncmFwaERldmljZVR5cGVJbnN0" +
           "YW5jZQEB9QMBAfUDAf////8OAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBARouAwAAAAAUAAAARmxh" +
           "dCBsaXN0IG9mIE1ldGhvZHMALwA6Gi4AAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25maWd1cmF0" +
           "aW9uAQFXLgAvAQHjJFcuAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVgu" +
           "AC4ARFguAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBWS4ALwEB5SRZLgAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVouAC4ARFouAACWAQAAAAEAKgEBGQAA" +
           "AAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQFbLgAuAERbLgAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0" +
           "YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdl" +
           "dENvbmZpZ0RhdGFEaWdlc3QBAVwuAC8BAegkXC4AAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBXS4ALgBEXS4AAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABcAAABDb21wYXJlQ29uZmln" +
           "RGF0YURpZ2VzdAEBXi4ALwEB6iReLgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAV8uAC4ARF8uAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFgLgAu" +
           "AERgLgAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAWEuAwAAAAA8AAAAUmVzZXQgYWxs" +
           "IEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe0kYS4A" +
           "AAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAWIuAwAAAAA8AAAAU3RhcnQg" +
           "YWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe4k" +
           "Yi4AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEBYy4DAAAAADsAAABTdG9w" +
           "IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQHv" +
           "JGMuAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxzAQFkLgMAAAAAPAAAAEFi" +
           "b3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAv" +
           "AQHwJGQuAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5nAQFlLgMAAAAAjQAAAEFu" +
           "YWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0ZSwgZm9yY2luZyBh" +
           "bGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRlIGFuZCBnbyB0byB0" +
           "aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJGUuAAABAf////8AAAAAJGGCCgQAAAABAA8AAABHb3RvTWFp" +
           "bnRlbmFuY2UBAWYuAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gTWFp" +
           "bnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gU2xhdmVNb2RlIHN0" +
           "YXRlLgAvAQHyJGYuAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlmaWNhdGlvbgEBHi4DAAAA" +
           "AEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0aW9uIG9mIHRoaXMg" +
           "VG9wb2xvZ3lFbGVtZW50AC8BAu0DHi4AAAMAAAAAIwABAnMXACMAAQJ0FwAjAAECcRcAAAAANWCJCgIA" +
           "AAACAAwAAABTZXJpYWxOdW1iZXIBAS4uAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlk" +
           "ZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBELi4AAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBLy4DAAAAAGkAAABBbiBp" +
           "bmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGlj" +
           "IGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBELy4AAAAG/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBMC4DAAAAADAAAABOYW1lIG9mIHRoZSBjb21w" +
           "YW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEMC4AAAAV/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIABQAAAE1vZGVsAQExLgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQxLgAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEyLgMAAAAAWgAAAEFkZHJl" +
           "c3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1" +
           "c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQyLgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAO" +
           "AAAARGV2aWNlUmV2aXNpb24BATMuAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "ZGV2aWNlAC4ARDMuAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9u" +
           "AQE0LgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUg" +
           "ZGV2aWNlAC4ARDQuAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9u" +
           "AQE1LgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RDUuAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQF+LgAvAQLtA34u" +
           "AAABAAAAACMAAQFqLgAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBgC4ALwEC7QOALgAAAQAAAAAjAAEB" +
           "Zy4AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAYIuAC8BAu0Dgi4AAP////8AAAAABGCA" +
           "CgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBhC4ALwEB6gOELgAA/////wEAAAAVYIkKAgAA" +
           "AAAADAAAAEN1cnJlbnRTdGF0ZQEBhS4ALwEAyAqFLgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAC" +
           "AAAASWQBAYYuAC4ARIYuAAAAEf////8BAf////8AAAAA";
        #endregion
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

    #region MassSpectrometerDeviceState Class
    #if (!OPCUA_EXCLUDE_MassSpectrometerDeviceState)
    /// <summary>
    /// Stores an instance of the MassSpectrometerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassSpectrometerDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassSpectrometerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.MassSpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAiAAAATWFzc1NwZWN0cm9tZXRlckRldmljZVR5cGVJ" +
           "bnN0YW5jZQEB9gMBAfYDAf////8OAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBARAvAwAAAAAUAAAA" +
           "RmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6EC8AAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25maWd1" +
           "cmF0aW9uAQFNLwAvAQHjJE0vAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AU4vAC4ARE4vAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBTy8ALwEB5SRPLwAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVAvAC4ARFAvAACWAQAAAAEAKgEB" +
           "GQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFRLwAuAERRLwAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmln" +
           "RGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAA" +
           "AEdldENvbmZpZ0RhdGFEaWdlc3QBAVIvAC8BAegkUi8AAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBUy8ALgBEUy8AAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QA" +
           "DP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABcAAABDb21wYXJlQ29u" +
           "ZmlnRGF0YURpZ2VzdAEBVC8ALwEB6iRULwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAVUvAC4ARFUvAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFW" +
           "LwAuAERWLwAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAVcvAwAAAAA8AAAAUmVzZXQg" +
           "YWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe0k" +
           "Vy8AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAVgvAwAAAAA8AAAAU3Rh" +
           "cnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8B" +
           "Ae4kWC8AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEBWS8DAAAAADsAAABT" +
           "dG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAv" +
           "AQHvJFkvAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxzAQFaLwMAAAAAPAAA" +
           "AEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNl" +
           "LgAvAQHwJFovAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5nAQFbLwMAAAAAjQAA" +
           "AEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0ZSwgZm9yY2lu" +
           "ZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRlIGFuZCBnbyB0" +
           "byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJFsvAAABAf////8AAAAAJGGCCgQAAAABAA8AAABHb3Rv" +
           "TWFpbnRlbmFuY2UBAVwvAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8g" +
           "TWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gU2xhdmVNb2Rl" +
           "IHN0YXRlLgAvAQHyJFwvAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlmaWNhdGlvbgEBFC8D" +
           "AAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0aW9uIG9mIHRo" +
           "aXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DFC8AAAMAAAAAIwABAnMXACMAAQJ0FwAjAAECcRcAAAAANWCJ" +
           "CgIAAAACAAwAAABTZXJpYWxOdW1iZXIBASQvAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5" +
           "IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEJC8A" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBJS8DAAAAAGkAAABB" +
           "biBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3Rh" +
           "dGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEJS8AAAAG/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBJi8DAAAAADAAAABOYW1lIG9mIHRoZSBj" +
           "b21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEJi8AAAAV/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIABQAAAE1vZGVsAQEnLwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQn" +
           "LwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEoLwMAAAAAWgAAAEFk" +
           "ZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBv" +
           "ZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQoLwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAOAAAARGV2aWNlUmV2aXNpb24BASkvAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0" +
           "aGUgZGV2aWNlAC4ARCkvAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlz" +
           "aW9uAQEqLwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARCovAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlz" +
           "aW9uAQErLwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNl" +
           "AC4ARCsvAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQF0LwAvAQLt" +
           "A3QvAAABAAAAACMAAQFgLwAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBdi8ALwEC7QN2LwAAAQAAAAAj" +
           "AAEBXS8AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAXgvAC8BAu0DeC8AAP////8AAAAA" +
           "BGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBei8ALwEB6gN6LwAA/////wEAAAAVYIkK" +
           "AgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBey8ALwEAyAp7LwAAABX/////AQH/////AQAAABVgiQoCAAAA" +
           "AAACAAAASWQBAXwvAC4ARHwvAAAAEf////8BAf////8AAAAA";
        #endregion
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

    #region AcousticSpectrometerDeviceState Class
    #if (!OPCUA_EXCLUDE_AcousticSpectrometerDeviceState)
    /// <summary>
    /// Stores an instance of the AcousticSpectrometerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AcousticSpectrometerDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AcousticSpectrometerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AcousticSpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAmAAAAQWNvdXN0aWNTcGVjdHJvbWV0ZXJEZXZpY2VU" +
           "eXBlSW5zdGFuY2UBAfcDAQH3AwH/////DgAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQEGMAMAAAAA" +
           "FAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOgYwAAD/////CgAAAARhggoEAAAAAQAQAAAAR2V0Q29u" +
           "ZmlndXJhdGlvbgEBQzAALwEB4yRDMAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQFEMAAuAEREMAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAUUwAC8BAeUk" +
           "RTAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFGMAAuAERGMAAAlgEAAAAB" +
           "ACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBRzAALgBERzAAAJYBAAAAAQAqAQEfAAAAEAAAAENv" +
           "bmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAB" +
           "ABMAAABHZXRDb25maWdEYXRhRGlnZXN0AQFIMAAvAQHoJEgwAAABAf////8BAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAUkwAC4AREkwAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGln" +
           "ZXN0AAz/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAXAAAAQ29tcGFy" +
           "ZUNvbmZpZ0RhdGFEaWdlc3QBAUowAC8BAeokSjAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQFLMAAuAERLMAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50" +
           "cwEBTDAALgBETDAAAJYBAAAAAQAqAQEWAAAABwAAAElzRXF1YWwAAf////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAJGGCCgQAAAABABAAAABSZXNldEFsbENoYW5uZWxzAQFNMAMAAAAAPAAAAFJl" +
           "c2V0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAv" +
           "AQHtJE0wAAABAf////8AAAAAJGGCCgQAAAABABAAAABTdGFydEFsbENoYW5uZWxzAQFOMAMAAAAAPAAA" +
           "AFN0YXJ0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNl" +
           "LgAvAQHuJE4wAAABAf////8AAAAAJGGCCgQAAAABAA8AAABTdG9wQWxsQ2hhbm5lbHMBAU8wAwAAAAA7" +
           "AAAAU3RvcCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmlj" +
           "ZS4ALwEB7yRPMAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAQWJvcnRBbGxDaGFubmVscwEBUDADAAAA" +
           "ADwAAABBYm9ydCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRl" +
           "dmljZS4ALwEB8CRQMAAAAQH/////AAAAACRhggoEAAAAAQANAAAAR290b09wZXJhdGluZwEBUTADAAAA" +
           "AI0AAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBPcGVyYXRpbmcgc3RhdGUsIGZv" +
           "cmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gbGVhdmUgdGhlIFNsYXZlTW9kZSBzdGF0ZSBhbmQg" +
           "Z28gdG8gdGhlIE9wZXJhdGluZyBzdGF0ZS4ALwEB8SRRMAAAAQH/////AAAAACRhggoEAAAAAQAPAAAA" +
           "R290b01haW50ZW5hbmNlAQFSMAMAAAAAZwAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdv" +
           "IHRvIE1haW50ZW5hbmNlIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5uZWxzIHRvIFNsYXZl" +
           "TW9kZSBzdGF0ZS4ALwEB8iRSMAAAAQH/////AAAAACRggAoBAAAAAgAOAAAASWRlbnRpZmljYXRpb24B" +
           "AQowAwAAAABGAAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVudGlmaWNhdGlvbiBv" +
           "ZiB0aGlzIFRvcG9sb2d5RWxlbWVudAAvAQLtAwowAAADAAAAACMAAQJzFwAjAAECdBcAIwABAnEXAAAA" +
           "ADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEaMAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlx" +
           "dWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4A" +
           "RBowAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBARswAwAAAABp" +
           "AAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhl" +
           "IHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARBswAAAABv//" +
           "//8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBARwwAwAAAAAwAAAATmFtZSBvZiB0" +
           "aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARBwwAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAACAAUAAABNb2RlbAEBHTADAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UA" +
           "LgBEHTAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBHjADAAAAAFoA" +
           "AABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVz" +
           "cykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEHjAAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADgAAAERldmljZVJldmlzaW9uAQEfMAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwg" +
           "b2YgdGhlIGRldmljZQAuAEQfMAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVS" +
           "ZXZpc2lvbgEBIDADAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUg" +
           "b2YgdGhlIGRldmljZQAuAEQgMAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVS" +
           "ZXZpc2lvbgEBITADAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRl" +
           "dmljZQAuAEQhMAAAAAz/////AQH/////AAAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBajAA" +
           "LwEC7QNqMAAAAQAAAAAjAAEBVjAAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAWwwAC8BAu0DbDAAAAEA" +
           "AAAAIwABAVMwAAAAAARggAoBAAAAAQAPAAAARmFjdG9yeVNldHRpbmdzAQFuMAAvAQLtA24wAAD/////" +
           "AAAAAARggAoBAAAAAQAUAAAAQW5hbHlzZXJTdGF0ZU1hY2hpbmUBAXAwAC8BAeoDcDAAAP////8BAAAA" +
           "FWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAXEwAC8BAMgKcTAAAAAV/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAAAgAAAElkAQFyMAAuAERyMAAAABH/////AQH/////AAAAAA==";
        #endregion
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

    #region NMRDeviceState Class
    #if (!OPCUA_EXCLUDE_NMRDeviceState)
    /// <summary>
    /// Stores an instance of the NMRDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NMRDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public NMRDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.NMRDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAVAAAATk1SRGV2aWNlVHlwZUluc3RhbmNlAQH4AwEB" +
           "+AMB/////w4AAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEB/DADAAAAABQAAABGbGF0IGxpc3Qgb2Yg" +
           "TWV0aG9kcwAvADr8MAAA/////woAAAAEYYIKBAAAAAEAEAAAAEdldENvbmZpZ3VyYXRpb24BATkxAC8B" +
           "AeMkOTEAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOjEALgBEOjEAAJYB" +
           "AAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAABGGCCgQAAAABABAAAABTZXRDb25maWd1cmF0aW9uAQE7MQAvAQHlJDsxAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPDEALgBEPDEAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZp" +
           "Z0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAT0xAC4ARD0xAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/" +
           "////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQATAAAAR2V0Q29uZmlnRGF0" +
           "YURpZ2VzdAEBPjEALwEB6CQ+MQAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQE/MQAuAEQ/MQAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAFwAAAENvbXBhcmVDb25maWdEYXRhRGlnZXN0" +
           "AQFAMQAvAQHqJEAxAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBQTEALgBE" +
           "QTEAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUIxAC4AREIxAACWAQAA" +
           "AAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAACRh" +
           "ggoEAAAAAQAQAAAAUmVzZXRBbGxDaGFubmVscwEBQzEDAAAAADwAAABSZXNldCBhbGwgQW5hbHlzZXJD" +
           "aGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7SRDMQAAAQH/////AAAA" +
           "ACRhggoEAAAAAQAQAAAAU3RhcnRBbGxDaGFubmVscwEBRDEDAAAAADwAAABTdGFydCBhbGwgQW5hbHlz" +
           "ZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7iREMQAAAQH/////" +
           "AAAAACRhggoEAAAAAQAPAAAAU3RvcEFsbENoYW5uZWxzAQFFMQMAAAAAOwAAAFN0b3AgYWxsIEFuYWx5" +
           "c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe8kRTEAAAEB////" +
           "/wAAAAAkYYIKBAAAAAEAEAAAAEFib3J0QWxsQ2hhbm5lbHMBAUYxAwAAAAA8AAAAQWJvcnQgYWxsIEFu" +
           "YWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAfAkRjEAAAEB" +
           "/////wAAAAAkYYIKBAAAAAEADQAAAEdvdG9PcGVyYXRpbmcBAUcxAwAAAACNAAAAQW5hbHlzZXJEZXZp" +
           "Y2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gT3BlcmF0aW5nIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNl" +
           "ckNoYW5uZWxzIHRvIGxlYXZlIHRoZSBTbGF2ZU1vZGUgc3RhdGUgYW5kIGdvIHRvIHRoZSBPcGVyYXRp" +
           "bmcgc3RhdGUuAC8BAfEkRzEAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAEdvdG9NYWludGVuYW5jZQEB" +
           "SDEDAAAAAGcAAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBNYWludGVuYW5jZSBz" +
           "dGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBTbGF2ZU1vZGUgc3RhdGUuAC8BAfIk" +
           "SDEAAAEB/////wAAAAAkYIAKAQAAAAIADgAAAElkZW50aWZpY2F0aW9uAQEAMQMAAAAARgAAAFVzZWQg" +
           "dG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3IgaWRlbnRpZmljYXRpb24gb2YgdGhpcyBUb3BvbG9neUVs" +
           "ZW1lbnQALwEC7QMAMQAAAwAAAAAjAAECcxcAIwABAnQXACMAAQJxFwAAAAA1YIkKAgAAAAIADAAAAFNl" +
           "cmlhbE51bWJlcgEBEDEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywg" +
           "d2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQQMQAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQERMQMAAAAAaQAAAEFuIGluY3JlbWVudGFs" +
           "IGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRo" +
           "aW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQRMQAAAAb/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAMAAAATWFudWZhY3R1cmVyAQESMQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBt" +
           "YW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQSMQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAA" +
           "TW9kZWwBARMxAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARBMxAAAAFf////8BAf//" +
           "//8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBARQxAwAAAABaAAAAQWRkcmVzcyAocGF0aG5h" +
           "bWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFs" +
           "IGZvciB0aGUgZGV2aWNlAC4ARBQxAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VS" +
           "ZXZpc2lvbgEBFTEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE" +
           "FTEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BARYxAwAAAAA1" +
           "AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBE" +
           "FjEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BARcxAwAAAAAs" +
           "AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEFzEAAAAM////" +
           "/wEB/////wAAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAWAxAC8BAu0DYDEAAAEAAAAAIwAB" +
           "AUwxAAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQFiMQAvAQLtA2IxAAABAAAAACMAAQFJMQAAAAAEYIAK" +
           "AQAAAAEADwAAAEZhY3RvcnlTZXR0aW5ncwEBZDEALwEC7QNkMQAA/////wAAAAAEYIAKAQAAAAEAFAAA" +
           "AEFuYWx5c2VyU3RhdGVNYWNoaW5lAQFmMQAvAQHqA2YxAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3Vy" +
           "cmVudFN0YXRlAQFnMQAvAQDICmcxAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBaDEA" +
           "LgBEaDEAAAAR/////wEB/////wAAAAA=";
        #endregion
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

    #region AccessorySlotState Class
    #if (!OPCUA_EXCLUDE_AccessorySlotState)
    /// <summary>
    /// Stores an instance of the AccessorySlotType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccessorySlotState : ConfigurableObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccessorySlotState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AccessorySlotType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAZAAAAQWNjZXNzb3J5U2xvdFR5cGVJbnN0YW5jZQEB" +
           "+QMBAfkD/////wQAAAAkYIAKAQAAAAIADgAAAFN1cHBvcnRlZFR5cGVzAQHwMQMAAAAAcgAAAEZvbGRl" +
           "ciBtYWludGFpbmluZyB0aGUgc2V0IG9mIChzdWItdHlwZXMgb2YpIEJhc2VPYmplY3RUeXBlcyB0aGF0" +
           "IGNhbiBiZSBpbnN0YW50aWF0ZWQgaW4gdGhlIENvbmZpZ3VyYWJsZUNvbXBvbmVudAAvAD3wMQAA////" +
           "/wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxlAQHyMQMAAAAATgAAAFRydWUgaWYgYW4gYWNj" +
           "ZXNzb3J5IGNhbiBiZSBpbnNlcnRlZCBpbiB0aGUgYWNjZXNzb3J5IHNsb3Qgd2hpbGUgaXQgaXMgcG93" +
           "ZXJlZAAuAETyMQAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAJAAAASXNFbmFibGVkAQHzMQMAAAAA" +
           "RgAAAFRydWUgaWYgdGhpcyBhY2Nlc3Nvcnkgc2xvdCBpcyBjYXBhYmxlIG9mIGFjY2VwdGluZyBhbiBh" +
           "Y2Nlc3NvcnkgaW4gaXQALgBE8zEAAAAB/////wEB/////wAAAAAEYIAKAQAAAAEAGQAAAEFjY2Vzc29y" +
           "eVNsb3RTdGF0ZU1hY2hpbmUBAfQxAC8BAfoD9DEAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50" +
           "U3RhdGUBAfUxAC8BAMgK9TEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQH2MQAuAET2" +
           "MQAAABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> IsHotSwappable
        {
            get
            {
                return m_isHotSwappable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isHotSwappable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isHotSwappable = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsEnabled
        {
            get
            {
                return m_isEnabled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isEnabled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isEnabled = value;
            }
        }

        /// <remarks />
        public AccessorySlotStateMachineState AccessorySlotStateMachine
        {
            get
            {
                return m_accessorySlotStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accessorySlotStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accessorySlotStateMachine = value;
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
            if (m_isHotSwappable != null)
            {
                children.Add(m_isHotSwappable);
            }

            if (m_isEnabled != null)
            {
                children.Add(m_isEnabled);
            }

            if (m_accessorySlotStateMachine != null)
            {
                children.Add(m_accessorySlotStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.IsHotSwappable:
                {
                    if (createOrReplace)
                    {
                        if (IsHotSwappable == null)
                        {
                            if (replacement == null)
                            {
                                IsHotSwappable = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsHotSwappable = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsHotSwappable;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.IsEnabled:
                {
                    if (createOrReplace)
                    {
                        if (IsEnabled == null)
                        {
                            if (replacement == null)
                            {
                                IsEnabled = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsEnabled = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsEnabled;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AccessorySlotStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (AccessorySlotStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                AccessorySlotStateMachine = new AccessorySlotStateMachineState(this);
                            }
                            else
                            {
                                AccessorySlotStateMachine = (AccessorySlotStateMachineState)replacement;
                            }
                        }
                    }

                    instance = AccessorySlotStateMachine;
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
        private PropertyState<bool> m_isHotSwappable;
        private PropertyState<bool> m_isEnabled;
        private AccessorySlotStateMachineState m_accessorySlotStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AccessorySlotStateMachineState Class
    #if (!OPCUA_EXCLUDE_AccessorySlotStateMachineState)
    /// <summary>
    /// Stores an instance of the AccessorySlotStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccessorySlotStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccessorySlotStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AccessorySlotStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQWNjZXNzb3J5U2xvdFN0YXRlTWFjaGluZVR5" +
           "cGVJbnN0YW5jZQEB+gMBAfoD/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBHTIALwEA" +
           "yAodMgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAR4yAC4ARB4yAAAAEf////8BAf//" +
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

    #region AccessoryState Class
    #if (!OPCUA_EXCLUDE_AccessoryState)
    /// <summary>
    /// Stores an instance of the AccessoryType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccessoryState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccessoryState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AccessoryType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAVAAAAQWNjZXNzb3J5VHlwZUluc3RhbmNlAQH7AwEB" +
           "+wP/////BQAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBYjIALwEC7QNiMgAA/////wAAAAAE" +
           "YIAKAQAAAAEABgAAAFN0YXR1cwEBZDIALwEC7QNkMgAA/////wAAAAAEYIAKAQAAAAEADwAAAEZhY3Rv" +
           "cnlTZXR0aW5ncwEBZjIALwEC7QNmMgAA/////wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxl" +
           "AQFoMgMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGluc2VydGVkIGluIHRoZSBh" +
           "Y2Nlc3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4ARGgyAAAAAf////8BAf////8AAAAANWCJ" +
           "CgIAAAABAAcAAABJc1JlYWR5AQFpMgMAAAAAJwAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgaXMgcmVh" +
           "ZHkgZm9yIHVzZQAuAERpMgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
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

        /// <remarks />
        public FunctionalGroupState Status
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

        /// <remarks />
        public FunctionalGroupState FactorySettings
        {
            get
            {
                return m_factorySettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_factorySettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_factorySettings = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsHotSwappable
        {
            get
            {
                return m_isHotSwappable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isHotSwappable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isHotSwappable = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsReady
        {
            get
            {
                return m_isReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isReady = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_factorySettings != null)
            {
                children.Add(m_factorySettings);
            }

            if (m_isHotSwappable != null)
            {
                children.Add(m_isHotSwappable);
            }

            if (m_isReady != null)
            {
                children.Add(m_isReady);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.FactorySettings:
                {
                    if (createOrReplace)
                    {
                        if (FactorySettings == null)
                        {
                            if (replacement == null)
                            {
                                FactorySettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                FactorySettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = FactorySettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.IsHotSwappable:
                {
                    if (createOrReplace)
                    {
                        if (IsHotSwappable == null)
                        {
                            if (replacement == null)
                            {
                                IsHotSwappable = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsHotSwappable = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsHotSwappable;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.IsReady:
                {
                    if (createOrReplace)
                    {
                        if (IsReady == null)
                        {
                            if (replacement == null)
                            {
                                IsReady = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsReady = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsReady;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private FunctionalGroupState m_factorySettings;
        private PropertyState<bool> m_isHotSwappable;
        private PropertyState<bool> m_isReady;
        #endregion
    }
    #endif
    #endregion

    #region DetectorState Class
    #if (!OPCUA_EXCLUDE_DetectorState)
    /// <summary>
    /// Stores an instance of the DetectorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DetectorState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DetectorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.DetectorType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAUAAAARGV0ZWN0b3JUeXBlSW5zdGFuY2UBAYYkAQGG" +
           "JP////8FAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQGAMgAvAQLtA4AyAAD/////AAAAAARg" +
           "gAoBAAAAAQAGAAAAU3RhdHVzAQGCMgAvAQLtA4IyAAD/////AAAAAARggAoBAAAAAQAPAAAARmFjdG9y" +
           "eVNldHRpbmdzAQGEMgAvAQLtA4QyAAD/////AAAAADVgiQoCAAAAAQAOAAAASXNIb3RTd2FwcGFibGUB" +
           "AYYyAwAAAABQAAAAVHJ1ZSBpZiB0aGlzIGFjY2Vzc29yeSBjYW4gYmUgaW5zZXJ0ZWQgaW4gdGhlIGFj" +
           "Y2Vzc29yeSBzbG90IHdoaWxlIGl0IGlzIHBvd2VyZWQALgBEhjIAAAAB/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEABwAAAElzUmVhZHkBAYcyAwAAAAAnAAAAVHJ1ZSBpZiB0aGlzIGFjY2Vzc29yeSBpcyByZWFk" +
           "eSBmb3IgdXNlAC4ARIcyAAAAAf////8BAf////8AAAAA";
        #endregion
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

    #region SmartSamplingSystemState Class
    #if (!OPCUA_EXCLUDE_SmartSamplingSystemState)
    /// <summary>
    /// Stores an instance of the SmartSamplingSystemType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SmartSamplingSystemState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SmartSamplingSystemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SmartSamplingSystemType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAfAAAAU21hcnRTYW1wbGluZ1N5c3RlbVR5cGVJbnN0" +
           "YW5jZQEBjyQBAY8k/////wUAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAZ4yAC8BAu0DnjIA" +
           "AP////8AAAAABGCACgEAAAABAAYAAABTdGF0dXMBAaAyAC8BAu0DoDIAAP////8AAAAABGCACgEAAAAB" +
           "AA8AAABGYWN0b3J5U2V0dGluZ3MBAaIyAC8BAu0DojIAAP////8AAAAANWCJCgIAAAABAA4AAABJc0hv" +
           "dFN3YXBwYWJsZQEBpDIDAAAAAFAAAABUcnVlIGlmIHRoaXMgYWNjZXNzb3J5IGNhbiBiZSBpbnNlcnRl" +
           "ZCBpbiB0aGUgYWNjZXNzb3J5IHNsb3Qgd2hpbGUgaXQgaXMgcG93ZXJlZAAuAESkMgAAAAH/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAHAAAASXNSZWFkeQEBpTIDAAAAACcAAABUcnVlIGlmIHRoaXMgYWNjZXNz" +
           "b3J5IGlzIHJlYWR5IGZvciB1c2UALgBEpTIAAAAB/////wEB/////wAAAAA=";
        #endregion
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
    public partial class SourceState : AccessoryState
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
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SourceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAU291cmNlVHlwZUluc3RhbmNlAQGYJAEBmCT/" +
           "////BQAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBvDIALwEC7QO8MgAA/////wAAAAAEYIAK" +
           "AQAAAAEABgAAAFN0YXR1cwEBvjIALwEC7QO+MgAA/////wAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlT" +
           "ZXR0aW5ncwEBwDIALwEC7QPAMgAA/////wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxlAQHC" +
           "MgMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGluc2VydGVkIGluIHRoZSBhY2Nl" +
           "c3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4ARMIyAAAAAf////8BAf////8AAAAANWCJCgIA" +
           "AAABAAcAAABJc1JlYWR5AQHDMgMAAAAAJwAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgaXMgcmVhZHkg" +
           "Zm9yIHVzZQAuAETDMgAAAAH/////AQH/////AAAAAA==";
        #endregion
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

    #region GcOvenState Class
    #if (!OPCUA_EXCLUDE_GcOvenState)
    /// <summary>
    /// Stores an instance of the GcOvenType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GcOvenState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GcOvenState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.GcOvenType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAR2NPdmVuVHlwZUluc3RhbmNlAQH8AwEB/AP/" +
           "////BQAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEB2jIALwEC7QPaMgAA/////wAAAAAEYIAK" +
           "AQAAAAEABgAAAFN0YXR1cwEB3DIALwEC7QPcMgAA/////wAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlT" +
           "ZXR0aW5ncwEB3jIALwEC7QPeMgAA/////wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxlAQHg" +
           "MgMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGluc2VydGVkIGluIHRoZSBhY2Nl" +
           "c3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4AROAyAAAAAf////8BAf////8AAAAANWCJCgIA" +
           "AAABAAcAAABJc1JlYWR5AQHhMgMAAAAAJwAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgaXMgcmVhZHkg" +
           "Zm9yIHVzZQAuAEThMgAAAAH/////AQH/////AAAAAA==";
        #endregion
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

    #region EngineeringValueState Class
    #if (!OPCUA_EXCLUDE_EngineeringValueState)
    /// <summary>
    /// Stores an instance of the EngineeringValueType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EngineeringValueState : DataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EngineeringValueState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.EngineeringValueType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAcAAAARW5naW5lZXJpbmdWYWx1ZVR5cGVJbnN0YW5j" +
           "ZQEBpCQBAaQkABgBAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region EngineeringValueState<T> Class
    /// <summary>
    /// A typed version of the EngineeringValueType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class EngineeringValueState<T> : EngineeringValueState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public EngineeringValueState(NodeState parent) : base(parent)
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

    #region ChemometricModelState Class
    #if (!OPCUA_EXCLUDE_ChemometricModelState)
    /// <summary>
    /// Stores an instance of the ChemometricModelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChemometricModelState : BaseDataVariableState<byte[]>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChemometricModelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.ChemometricModelType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.ByteString, Opc.Ua.Namespaces.OpcUa, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAcAAAAQ2hlbW9tZXRyaWNNb2RlbFR5cGVJbnN0YW5j" +
           "ZQEB1wcBAdcHAA8BAf////8DAAAAFWCJCgIAAAABAAQAAABOYW1lAQHpMgAuAETpMgAAABX/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAMAAAAQ3JlYXRpb25EYXRlAQHqMgAuAETqMgAAAA3/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAQAAAATW9kZWxEZXNjcmlwdGlvbgEB6zIALgBE6zIAAAAV/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<LocalizedText> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> CreationDate
        {
            get
            {
                return m_creationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_creationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_creationDate = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> ModelDescription
        {
            get
            {
                return m_modelDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modelDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modelDescription = value;
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
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_creationDate != null)
            {
                children.Add(m_creationDate);
            }

            if (m_modelDescription != null)
            {
                children.Add(m_modelDescription);
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
                case Opc.Ua.Adi.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Name = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.CreationDate:
                {
                    if (createOrReplace)
                    {
                        if (CreationDate == null)
                        {
                            if (replacement == null)
                            {
                                CreationDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                CreationDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = CreationDate;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.ModelDescription:
                {
                    if (createOrReplace)
                    {
                        if (ModelDescription == null)
                        {
                            if (replacement == null)
                            {
                                ModelDescription = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ModelDescription = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ModelDescription;
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
        private PropertyState<LocalizedText> m_name;
        private PropertyState<DateTime> m_creationDate;
        private PropertyState<LocalizedText> m_modelDescription;
        #endregion
    }
    #endif
    #endregion

    #region ProcessVariableState Class
    #if (!OPCUA_EXCLUDE_ProcessVariableState)
    /// <summary>
    /// Stores an instance of the ProcessVariableType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProcessVariableState : DataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProcessVariableState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.ProcessVariableType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAbAAAAUHJvY2Vzc1ZhcmlhYmxlVHlwZUluc3RhbmNl" +
           "AQHYBwEB2AcAGAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ProcessVariableState<T> Class
    /// <summary>
    /// A typed version of the ProcessVariableType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProcessVariableState<T> : ProcessVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ProcessVariableState(NodeState parent) : base(parent)
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

    #region MVAModelState Class
    #if (!OPCUA_EXCLUDE_MVAModelState)
    /// <summary>
    /// Stores an instance of the MVAModelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MVAModelState : ChemometricModelState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MVAModelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.MVAModelType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.ByteString, Opc.Ua.Namespaces.OpcUa, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAUAAAATVZBTW9kZWxUeXBlSW5zdGFuY2UBAdkHAQHZ" +
           "BwAPAQH/////BAAAABVgiQoCAAAAAQAEAAAATmFtZQEB8TIALgBE8TIAAAAV/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEADAAAAENyZWF0aW9uRGF0ZQEB8jIALgBE8jIAAAAN/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAEAAAAE1vZGVsRGVzY3JpcHRpb24BAfMyAC4ARPMyAAAAFf////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AA0AAABNYWluRGF0YUluZGV4AQH2MgAuAET2MgAAAAb/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<int> MainDataIndex
        {
            get
            {
                return m_mainDataIndex;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mainDataIndex, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mainDataIndex = value;
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
            if (m_mainDataIndex != null)
            {
                children.Add(m_mainDataIndex);
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
                case Opc.Ua.Adi.BrowseNames.MainDataIndex:
                {
                    if (createOrReplace)
                    {
                        if (MainDataIndex == null)
                        {
                            if (replacement == null)
                            {
                                MainDataIndex = new PropertyState<int>(this);
                            }
                            else
                            {
                                MainDataIndex = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = MainDataIndex;
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
        private PropertyState<int> m_mainDataIndex;
        #endregion
    }
    #endif
    #endregion

    #region MVAPredictMethodState Class
    #if (!OPCUA_EXCLUDE_MVAPredictMethodState)
    /// <summary>
    /// Stores an instance of the MVAPredictMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MVAPredictMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MVAPredictMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new MVAPredictMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAUAAAATVZBUHJlZGljdE1ldGhvZFR5cGUBAfsyAC8B" +
           "Afsy+zIAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH8MgAuAET8MgAAlgMA" +
           "AAABACoBARoAAAALAAAAVGFyZ2V0TW9kZWwAEf////8AAAAAAAEAKgEBHAAAAA0AAABNYWluRGF0YUlu" +
           "ZGV4AAb/////AAAAAAABACoBARkAAAAGAAAASW5wdXRzABgBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/TIALgBE/TIAAJYBAAAA" +
           "AQAqAQEaAAAABwAAAE91dHB1dHMAGAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public MVAPredictMethodStateMethodCallHandler OnCall;
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

            NodeId targetModel = (NodeId)_inputArguments[0];
            int mainDataIndex = (int)_inputArguments[1];
            Variant[] inputs = (Variant[])_inputArguments[2];

            Variant[] outputs = (Variant[])_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    targetModel,
                    mainDataIndex,
                    inputs,
                    ref outputs);
            }

            _outputArguments[0] = outputs;

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
    public delegate ServiceResult MVAPredictMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId targetModel,
        int mainDataIndex,
        Variant[] inputs,
        ref Variant[] outputs);
    #endif
    #endregion

    #region MVAOutputParameterState Class
    #if (!OPCUA_EXCLUDE_MVAOutputParameterState)
    /// <summary>
    /// Stores an instance of the MVAOutputParameterType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MVAOutputParameterState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MVAOutputParameterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.MVAOutputParameterType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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

            if (WarningLimits != null)
            {
                WarningLimits.Initialize(context, WarningLimits_InitializationString);
            }

            if (AlarmLimits != null)
            {
                AlarmLimits.Initialize(context, AlarmLimits_InitializationString);
            }

            if (VendorSpecificError != null)
            {
                VendorSpecificError.Initialize(context, VendorSpecificError_InitializationString);
            }
        }

        #region Initialization String
        private const string WarningLimits_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAV2FybmluZ0xpbWl0cwEB/jIALgBE/jIAAAEA" +
           "dAP/////AQH/////AAAAAA==";

        private const string AlarmLimits_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAAQWxhcm1MaW1pdHMBAf8yAC4ARP8yAAABAHQD" +
           "/////wEB/////wAAAAA=";

        private const string VendorSpecificError_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQATAAAAVmVuZG9yU3BlY2lmaWNFcnJvcgEBATMALgBE" +
           "ATMAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAeAAAATVZBT3V0cHV0UGFyYW1ldGVyVHlwZUluc3Rh" +
           "bmNlAQHaBwEB2gcAGAEB/////wQAAAAVYIkKAgAAAAEADQAAAFdhcm5pbmdMaW1pdHMBAf4yAC4ARP4y" +
           "AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFsYXJtTGltaXRzAQH/MgAuAET/MgAAAQB0" +
           "A/////8BAf////8AAAAAFWCJCgIAAAABAAoAAABBbGFybVN0YXRlAQEAMwAuAEQAMwAAAQHBC/////8B" +
           "Af////8AAAAAFWCJCgIAAAABABMAAABWZW5kb3JTcGVjaWZpY0Vycm9yAQEBMwAuAEQBMwAAAAz/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<Range> WarningLimits
        {
            get
            {
                return m_warningLimits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_warningLimits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_warningLimits = value;
            }
        }

        /// <remarks />
        public PropertyState<Range> AlarmLimits
        {
            get
            {
                return m_alarmLimits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmLimits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmLimits = value;
            }
        }

        /// <remarks />
        public PropertyState<AlarmStateEnumeration> AlarmState
        {
            get
            {
                return m_alarmState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmState = value;
            }
        }

        /// <remarks />
        public PropertyState<string> VendorSpecificError
        {
            get
            {
                return m_vendorSpecificError;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vendorSpecificError, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vendorSpecificError = value;
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
            if (m_warningLimits != null)
            {
                children.Add(m_warningLimits);
            }

            if (m_alarmLimits != null)
            {
                children.Add(m_alarmLimits);
            }

            if (m_alarmState != null)
            {
                children.Add(m_alarmState);
            }

            if (m_vendorSpecificError != null)
            {
                children.Add(m_vendorSpecificError);
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
                case Opc.Ua.Adi.BrowseNames.WarningLimits:
                {
                    if (createOrReplace)
                    {
                        if (WarningLimits == null)
                        {
                            if (replacement == null)
                            {
                                WarningLimits = new PropertyState<Range>(this);
                            }
                            else
                            {
                                WarningLimits = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = WarningLimits;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AlarmLimits:
                {
                    if (createOrReplace)
                    {
                        if (AlarmLimits == null)
                        {
                            if (replacement == null)
                            {
                                AlarmLimits = new PropertyState<Range>(this);
                            }
                            else
                            {
                                AlarmLimits = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = AlarmLimits;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AlarmState:
                {
                    if (createOrReplace)
                    {
                        if (AlarmState == null)
                        {
                            if (replacement == null)
                            {
                                AlarmState = new PropertyState<AlarmStateEnumeration>(this);
                            }
                            else
                            {
                                AlarmState = (PropertyState<AlarmStateEnumeration>)replacement;
                            }
                        }
                    }

                    instance = AlarmState;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.VendorSpecificError:
                {
                    if (createOrReplace)
                    {
                        if (VendorSpecificError == null)
                        {
                            if (replacement == null)
                            {
                                VendorSpecificError = new PropertyState<string>(this);
                            }
                            else
                            {
                                VendorSpecificError = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = VendorSpecificError;
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
        private PropertyState<Range> m_warningLimits;
        private PropertyState<Range> m_alarmLimits;
        private PropertyState<AlarmStateEnumeration> m_alarmState;
        private PropertyState<string> m_vendorSpecificError;
        #endregion
    }

    #region MVAOutputParameterState<T> Class
    /// <summary>
    /// A typed version of the MVAOutputParameterType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MVAOutputParameterState<T> : MVAOutputParameterState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MVAOutputParameterState(NodeState parent) : base(parent)
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
