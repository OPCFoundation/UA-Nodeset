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
           "AQAAAAAjAQEBCiUKAAAANWCJCgIAAAAAAAQAAABTaXplAQH3JAMAAAAAHgAAAFRoZSBzaXplIG9mIHRo" +
           "ZSBmaWxlIGluIGJ5dGVzLgAuAET3JAAAAAn/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAV3JpdGFi" +
           "bGUBAQ4zAwAAAAAdAAAAV2hldGhlciB0aGUgZmlsZSBpcyB3cml0YWJsZS4ALgBEDjMAAAAB/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAADAAAAFVzZXJXcml0YWJsZQEBDzMDAAAAADEAAABXaGV0aGVyIHRoZSBm" +
           "aWxlIGlzIHdyaXRhYmxlIGJ5IHRoZSBjdXJyZW50IHVzZXIuAC4ARA8zAAAAAf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAkAAABPcGVuQ291bnQBAfokAwAAAAAoAAAAVGhlIGN1cnJlbnQgbnVtYmVyIG9mIG9w" +
           "ZW4gZmlsZSBoYW5kbGVzLgAuAET6JAAAAAX/////AQH/////AAAAAARhggoEAAAAAAAEAAAAT3BlbgEB" +
           "+yQALwEAPC37JAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfwkAC4ARPwk" +
           "AACWAQAAAAEAKgEBEwAAAAQAAABNb2RlAAP/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/SQALgBE/SQAAJYBAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5k" +
           "bGUAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAf4kAC8BAD8t" +
           "/iQAAAEB/////wEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH/JAAuAET/JAAAlgEAAAAB" +
           "ACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAAA" +
           "AAQAAABSZWFkAQEAJQAvAQBBLQAlAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBASUALgBEASUAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEBFQAA" +
           "AAYAAABMZW5ndGgABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQECJQAuAEQCJQAAlgEAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEBAyUALwEARC0DJQAAAQH/////AQAAABVgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQQlAC4ARAQlAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFu" +
           "ZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "BGGCCgQAAAAAAAsAAABHZXRQb3NpdGlvbgEBBSUALwEARi0FJQAAAQH/////AgAAABVgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAQYlAC4ARAYlAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBByUA" +
           "LgBEByUAAJYBAAAAAQAqAQEXAAAACAAAAFBvc2l0aW9uAAn/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAAACwAAAFNldFBvc2l0aW9uAQEIJQAvAQBJLQglAAABAf////8BAAAAFWCpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBCSUALgBECSUAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUA" +
           "B/////8AAAAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "JGCACgEAAAACAAkAAABNZXRob2RTZXQBAaYkAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6" +
           "piQAAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25maWd1cmF0aW9uAQHjJAAvAQHjJOMkAAABAf//" +
           "//8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAeQkAC4AROQkAACWAQAAAAEAKgEBGQAA" +
           "AAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEAAAAFNl" +
           "dENvbmZpZ3VyYXRpb24BAeUkAC8BAeUk5SQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQHmJAAuAETmJAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAeckAC4AROckAACWAQAA" +
           "AAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAegkAC8BAegk6CQAAAEB/////wEAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB6SQALgBE6SQAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZp" +
           "Z0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAXAAAAQ29tcGFy" +
           "ZUNvbmZpZ0RhdGFEaWdlc3QBAeokAC8BAeok6iQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQHrJAAuAETrJAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAewkAC4A" +
           "ROwkAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAAAAABACgBAQAAAAEB/////wAAAAAk" +
           "YYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAe0kAwAAAAA8AAAAUmVzZXQgYWxsIEFuYWx5c2Vy" +
           "Q2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe0k7SQAAAEB/////wAA" +
           "AAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAe4kAwAAAAA8AAAAU3RhcnQgYWxsIEFuYWx5" +
           "c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAe4k7iQAAAEB////" +
           "/wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEB7yQDAAAAADsAAABTdG9wIGFsbCBBbmFs" +
           "eXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQHvJO8kAAABAf//" +
           "//8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxzAQHwJAMAAAAAPAAAAEFib3J0IGFsbCBB" +
           "bmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQHwJPAkAAAB" +
           "Af////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5nAQHxJAMAAAAAjQAAAEFuYWx5c2VyRGV2" +
           "aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlz" +
           "ZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRlIGFuZCBnbyB0byB0aGUgT3BlcmF0" +
           "aW5nIHN0YXRlLgAvAQHxJPEkAAABAf////8AAAAAJGGCCgQAAAABAA8AAABHb3RvTWFpbnRlbmFuY2UB" +
           "AfIkAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gTWFpbnRlbmFuY2Ug" +
           "c3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gU2xhdmVNb2RlIHN0YXRlLgAvAQHy" +
           "JPIkAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlmaWNhdGlvbgEBqiQDAAAAAEYAAABVc2Vk" +
           "IHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0aW9uIG9mIHRoaXMgVG9wb2xvZ3lF" +
           "bGVtZW50AC8BAu0DqiQAAAMAAAAAIwABAnMXACMAAQJ0FwAjAAECcRcAAAAANWCJCgIAAAACAAwAAABT" +
           "ZXJpYWxOdW1iZXIBAbokAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMs" +
           "IHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEuiQAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBuyQDAAAAAGkAAABBbiBpbmNyZW1lbnRh" +
           "bCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0" +
           "aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEuyQAAAAG/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBvCQDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQg" +
           "bWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEvCQAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAA" +
           "AE1vZGVsAQG9JAMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAES9JAAAABX/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQG+JAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhu" +
           "YW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVh" +
           "bCBmb3IgdGhlIGRldmljZQAuAES+JAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNl" +
           "UmV2aXNpb24BAb8kAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4A" +
           "RL8kAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQHAJAMAAAAA" +
           "NQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4A" +
           "RMAkAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQHBJAMAAAAA" +
           "LAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARMEkAAAADP//" +
           "//8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQEKJQAvAQLtAwolAAABAAAAACMA" +
           "AQH2JAAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBDCUALwEC7QMMJQAAAQAAAAAjAAEB8yQAAAAABGCA" +
           "CgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAQ4lAC8BAu0DDiUAAP////8AAAAABGCACgEAAAABABQA" +
           "AABBbmFseXNlclN0YXRlTWFjaGluZQEBECUALwEB6gMQJQAA/////wEAAAAVYIkKAgAAAAAADAAAAEN1" +
           "cnJlbnRTdGF0ZQEBESUALwEAyAoRJQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBARIl" +
           "AC4ARBIlAAAAEf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
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

        /// <summary>
        /// A description for the FactorySettings Object.
        /// </summary>
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

        /// <summary>
        /// A description for the AnalyserStateMachine Object.
        /// </summary>
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
           "dXJhdGlvbk1ldGhvZFR5cGUBAZolAC8BAZolmiUAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBmyUALgBEmyUAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAAA==";
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

            byte[] configData = (byte[])outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref configData);
            }

            outputArguments[0] = configData;

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
           "dXJhdGlvbk1ldGhvZFR5cGUBAZwlAC8BAZwlnCUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQGdJQAuAESdJQAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZ4lAC4ARJ4lAACW" +
           "AQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA=";
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

            byte[] configData = (byte[])inputArguments[0];

            string configDataDigest = (string)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    configData,
                    ref configDataDigest);
            }

            outputArguments[0] = configDataDigest;

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
           "RGF0YURpZ2VzdE1ldGhvZFR5cGUBAZ8lAC8BAZ8lnyUAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBoCUALgBEoCUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QA" +
           "DP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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

            string configDataDigest = (string)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref configDataDigest);
            }

            outputArguments[0] = configDataDigest;

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
           "bmZpZ0RhdGFEaWdlc3RNZXRob2RUeXBlAQGhJQAvAQGhJaElAAABAf////8CAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBoiUALgBEoiUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdl" +
           "c3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQGjJQAuAESjJQAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAA";
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

            string configDataDigest = (string)inputArguments[0];

            bool isEqual = (bool)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    configDataDigest,
                    ref isEqual);
            }

            outputArguments[0] = isEqual;

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
           "Z2xlQWNxdWlzaXRpb24BAeUlAC8BAeUl5SUAAAEB/////wEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQHmJQAuAETmJQAAlgMAAAABACoBAR8AAAAOAAAARXhlY3V0aW9uQ3ljbGUBAaIk/////wAA" +
           "AAAAAQAqAQEkAAAAFQAAAEV4ZWN1dGlvbkN5Y2xlU3ViY29kZQAH/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AFNlbGVjdGVkU3RyZWFtAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEABQAAAFJl" +
           "c2V0AQHnJQMAAAAAKQAAAENhdXNlcyB0cmFuc2l0aW9uIHRvIHRoZSBSZXNldHRpbmcgc3RhdGUuAC8B" +
           "Aecl5yUAAAEB/////wAAAAAkYYIKBAAAAAEABQAAAFN0YXJ0AQHoJQMAAAAAKAAAAENhdXNlcyB0cmFu" +
           "c2l0aW9uIHRvIHRoZSBTdGFydGluZyBzdGF0ZS4ALwEB6CXoJQAAAQH/////AAAAACRhggoEAAAAAQAE" +
           "AAAAU3RvcAEB6SUDAAAAACgAAABDYXVzZXMgdHJhbnNpdGlvbiB0byB0aGUgU3RvcHBpbmcgc3RhdGUu" +
           "AC8BAekl6SUAAAEB/////wAAAAAkYYIKBAAAAAEABAAAAEhvbGQBAeolAwAAAAAnAAAAQ2F1c2VzIHRy" +
           "YW5zaXRpb24gdG8gdGhlIEhvbGRpbmcgc3RhdGUuAC8BAeol6iUAAAEB/////wAAAAAkYYIKBAAAAAEA" +
           "BgAAAFVuaG9sZAEB6yUDAAAAACkAAABDYXVzZXMgdHJhbnNpdGlvbiB0byB0aGUgVW5ob2xkaW5nIHN0" +
           "YXRlLgAvAQHrJeslAAABAf////8AAAAAJGGCCgQAAAABAAcAAABTdXNwZW5kAQHsJQMAAAAAKgAAAENh" +
           "dXNlcyB0cmFuc2l0aW9uIHRvIHRoZSBTdXNwZW5kaW5nIHN0YXRlLgAvAQHsJewlAAABAf////8AAAAA" +
           "JGGCCgQAAAABAAkAAABVbnN1c3BlbmQBAe0lAwAAAAAsAAAAQ2F1c2VzIHRyYW5zaXRpb24gdG8gdGhl" +
           "IFVuc3VzcGVuZGluZyBzdGF0ZS4ALwEB7SXtJQAAAQH/////AAAAACRhggoEAAAAAQAFAAAAQWJvcnQB" +
           "Ae4lAwAAAAAoAAAAQ2F1c2VzIHRyYW5zaXRpb24gdG8gdGhlIEFib3J0aW5nIHN0YXRlLgAvAQHuJe4l" +
           "AAABAf////8AAAAAJGGCCgQAAAABAAUAAABDbGVhcgEB7yUDAAAAACgAAABDYXVzZXMgdHJhbnNpdGlv" +
           "biB0byB0aGUgQ2xlYXJpbmcgc3RhdGUuAC8BAe8l7yUAAAEB/////wAAAAAEYIAKAQAAAAEADQAAAENv" +
           "bmZpZ3VyYXRpb24BAfwlAC8BAu0D/CUAAAEAAAAAIwABAfMlAAAAAARggAoBAAAAAQAGAAAAU3RhdHVz" +
           "AQH+JQAvAQLtA/4lAAACAAAAACMAAQH2JQAjAAEB+SUAAAAAhGCACgEAAAABABMAAABDaGFubmVsU3Rh" +
           "dGVNYWNoaW5lAQEAJgAvAQHvAwAmAAAB/////wIAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEB" +
           "ASYALwEAyAoBJgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQImAC4ARAImAAAAEf//" +
           "//8BAf////8AAAAABGCACgEAAAABABgAAABPcGVyYXRpbmdTdWJTdGF0ZU1hY2hpbmUBAQwmAC8BAfAD" +
           "DCYAAP////8CAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAQ0mAC8BAMgKDSYAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEOJgAuAEQOJgAAABH/////AQH/////AAAAAARggAoBAAAA" +
           "AQAfAAAAT3BlcmF0aW5nRXhlY3V0ZVN1YlN0YXRlTWFjaGluZQEBGCYALwEB8QMYJgAA/////wEAAAAV" +
           "YIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBGSYALwEAyAoZJgAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBARomAC4ARBomAAAAEf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
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

        /// <summary>
        /// A description for the ChannelStateMachine Object.
        /// </summary>
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
           "Z2xlQWNxdWlzaXRpb25NZXRob2RUeXBlAQHMJgAvAQHMJswmAAABAf////8BAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBzSYALgBEzSYAAJYDAAAAAQAqAQEfAAAADgAAAEV4ZWN1dGlvbkN5Y2xl" +
           "AQGiJP////8AAAAAAAEAKgEBJAAAABUAAABFeGVjdXRpb25DeWNsZVN1YmNvZGUAB/////8AAAAAAAEA" +
           "KgEBHQAAAA4AAABTZWxlY3RlZFN0cmVhbQAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
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

            ExecutionCycleEnumeration executionCycle = (ExecutionCycleEnumeration)inputArguments[0];
            uint executionCycleSubcode = (uint)inputArguments[1];
            string selectedStream = (string)inputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
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
        /// <summary>
        /// A description for the OperatingSubStateMachine Object.
        /// </summary>
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

        /// <summary>
        /// A description for the LocalSubStateMachine Object.
        /// </summary>
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

        /// <summary>
        /// A description for the MaintenanceSubStateMachine Object.
        /// </summary>
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
        /// <summary>
        /// A description for the OperatingExecuteSubStateMachine Object.
        /// </summary>
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
           "bGUgc3ViY29kZSBpcyBpbiBwcm9ncmVzcwAvAQBICYEoAAAAHP////8BAQEAAAAAIwEBAcQoAQAAABVg" +
           "iQoCAAAAAAALAAAARW51bVN0cmluZ3MBAYQoAC4ARIQoAAAAFQEAAAABAf////8AAAAANWCJCgIAAAAB" +
           "AAgAAABQcm9ncmVzcwEBhSgDAAAAAHQAAABJbmRpY2F0ZXMgdGhlIHByb2dyZXNzIG9mIGFuIGFjcXVp" +
           "c2l0aW9uIGluIHRlcm1zIG9mIHBlcmNlbnRhZ2Ugb2YgY29tcGxldGlvbi4gSXRzIHZhbHVlIHNoYWxs" +
           "IGJlIGJldHdlZW4gMCBhbmQgMTAwLgAvAQA9CYUoAAAACv////8BAQEAAAAAIwEBAcQoAAAAADVgiQoC" +
           "AAAAAQASAAAAQWNxdWlzaXRpb25Db3VudGVyAQGIKAMAAAAAUwAAAFNpbXBsZSBjb3VudGVyIGluY3Jl" +
           "bWVudGVkIGFmdGVyIGVhY2ggU2FtcGxpbmcgYWNxdWlzaXRpb24gcGVyZm9ybWVkIG9uIHRoaXMgU3Ry" +
           "ZWFtAC8BAEAJiCgAAAEAIQH/////AQEBAAAAACMBAQHGKAEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AYwoAC4ARIwoAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEFjcXVpc2l0aW9uUmVzdWx0" +
           "U3RhdHVzAQGOKAMAAAAAGgAAAFF1YWxpdHkgb2YgdGhlIGFjcXVpc2l0aW9uAC8BAD0JjigAAAEBuwv/" +
           "////AQEBAAAAACMBAQHGKAAAAAA1YIkKAgAAAAEABwAAAFJhd0RhdGEBAZEoAwAAAAA/AAAAUmF3IGRh" +
           "dGEgcHJvZHVjZWQgYXMgYSByZXN1bHQgb2YgZGF0YSBhY3F1aXNpdGlvbiBvbiB0aGUgU3RyZWFtAC8B" +
           "AD0JkSgAAAAY/////wEBAQAAAAAjAQEBxigAAAAANWCJCgIAAAABAAoAAABTY2FsZWREYXRhAQGUKAMA" +
           "AAAAaAAAAFNjYWxlZCBkYXRhIHByb2R1Y2VkIGFzIGEgcmVzdWx0IG9mIGRhdGEgYWNxdWlzaXRpb24g" +
           "b24gdGhlIFN0cmVhbSBhbmQgYXBwbGljYXRpb24gb2YgdGhlIGFuYWx5c2VyIG1vZGVsAC8BAD0JlCgA" +
           "AAAY/////wEBAQAAAAAjAQEBxigAAAAANWCJCgIAAAABAAYAAABPZmZzZXQBAZcoAwAAAABgAAAARGlm" +
           "ZmVyZW5jZSBpbiBtaWxsaXNlY29uZHMgYmV0d2VlbiB0aGUgc3RhcnQgb2Ygc2FtcGxlIGV4dHJhY3Rp" +
           "b24gYW5kIHRoZSBzdGFydCBvZiB0aGUgYW5hbHlzaXMuAC8BAD0JlygAAAEAIgH/////AQEBAAAAACMB" +
           "AQHGKAAAAAA1YIkKAgAAAAEAEgAAAEFjcXVpc2l0aW9uRW5kVGltZQEBmigDAAAAAKcAAABUaGUgZW5k" +
           "IHRpbWUgb2YgdGhlIEFuYWx5c2VTYW1wbGUgb3IgQW5hbHlzZUNhbGlicmF0aW9uU2FtcGxlIG9yIEFu" +
           "YWx5c2VWYWxpZGF0aW9uU2FtcGxlIHN0YXRlIG9mIHRoZSBBbmFseXNlckNoYW5uZWxfT3BlcmF0aW5n" +
           "TW9kZUV4ZWN1dGVTdWJTdGF0ZU1hY2hpbmUgc3RhdGUgbWFjaGluZQAvAQA9CZooAAAADf////8BAQEA" +
           "AAAAIwEBAcYoAAAAADVgiQoCAAAAAQAKAAAAQ2FtcGFpZ25JZAEBnSgDAAAAABwAAABEZWZpbmVzIHRo" +
           "ZSBjdXJyZW50IGNhbXBhaWduAC8BAD0JnSgAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJCgIAAAAB" +
           "AAcAAABCYXRjaElkAQGgKAMAAAAAGQAAAERlZmluZXMgdGhlIGN1cnJlbnQgYmF0Y2gALwEAPQmgKAAA" +
           "AAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEACgAAAFN1YkJhdGNoSWQBAaMoAwAAAAAdAAAA" +
           "RGVmaW5lcyB0aGUgY3VycmVudCBzdWItYmF0Y2gALwEAPQmjKAAAAAz/////AwMBAAAAACMBAQHKKAAA" +
           "AAA1YIkKAgAAAAEABQAAAExvdElkAQGmKAMAAAAAFwAAAERlZmluZXMgdGhlIGN1cnJlbnQgbG90AC8B" +
           "AD0JpigAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJCgIAAAABAAoAAABNYXRlcmlhbElkAQGpKAMA" +
           "AAAAHAAAAERlZmluZXMgdGhlIGN1cnJlbnQgbWF0ZXJpYWwALwEAPQmpKAAAAAz/////AwMBAAAAACMB" +
           "AQHKKAAAAAA1YIkKAgAAAAEABwAAAFByb2Nlc3MBAawoAwAAAAAUAAAAQ3VycmVudCBQcm9jZXNzIG5h" +
           "bWUALwEAPQmsKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEABAAAAFVuaXQBAa8oAwAA" +
           "AAARAAAAQ3VycmVudCBVbml0IG5hbWUALwEAPQmvKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkK" +
           "AgAAAAEACQAAAE9wZXJhdGlvbgEBsigDAAAAABYAAABDdXJyZW50IE9wZXJhdGlvbiBuYW1lAC8BAD0J" +
           "sigAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJCgIAAAABAAUAAABQaGFzZQEBtSgDAAAAABIAAABD" +
           "dXJyZW50IFBoYXNlIG5hbWUALwEAPQm1KAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEA" +
           "BgAAAFVzZXJJZAEBuCgDAAAAAD0AAABMb2dpbiBuYW1lIG9mIHRoZSB1c2VyIHdobyBpcyBsb2dnZWQg" +
           "b24gYXQgdGhlIGRldmljZSBjb25zb2xlAC8BAD0JuCgAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJ" +
           "CgIAAAABAAgAAABTYW1wbGVJZAEBuygDAAAAABkAAABJZGVudGlmaWVyIGZvciB0aGUgc2FtcGxlAC8B" +
           "AD0JuygAAAAM/////wMDAQAAAAAjAQEByigAAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQG+" +
           "KAAvAQLtA74oAAACAAAAACMAAQFjKAAjAAEBZigAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAcAoAC8B" +
           "Au0DwCgAAAQAAAAAIwABAWkoACMAAQFsKAAjAAEBbygAIwABAXIoAAAAAARggAoBAAAAAQATAAAAQWNx" +
           "dWlzaXRpb25TZXR0aW5ncwEBwigALwEC7QPCKAAAAQAAAAAjAAEBdSgAAAAABGCACgEAAAABABEAAABB" +
           "Y3F1aXNpdGlvblN0YXR1cwEBxCgALwEC7QPEKAAABAAAAAAjAAEBeygAIwABAX4oACMAAQGBKAAjAAEB" +
           "hSgAAAAABGCACgEAAAABAA8AAABBY3F1aXNpdGlvbkRhdGEBAcYoAC8BAu0DxigAAAYAAAAAIwABAYgo" +
           "ACMAAQGOKAAjAAEBkSgAIwABAZQoACMAAQGXKAAjAAEBmigAAAAABGCACgEAAAABABgAAABDaGVtb21l" +
           "dHJpY01vZGVsU2V0dGluZ3MBAcgoAC8BAu0DyCgAAP////8AAAAABGCACgEAAAABAAcAAABDb250ZXh0" +
           "AQHKKAAvAQLtA8ooAAALAAAAACMAAQGdKAAjAAEBoCgAIwABAaMoACMAAQGmKAAjAAEBqSgAIwABAawo" +
           "ACMAAQGvKAAjAAEBsigAIwABAbUoACMAAQG4KAAjAAEBuygAAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
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

        /// <summary>
        /// A description for the AcquisitionSettings Object.
        /// </summary>
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

        /// <summary>
        /// A description for the AcquisitionStatus Object.
        /// </summary>
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

        /// <summary>
        /// A description for the AcquisitionData Object.
        /// </summary>
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

        /// <summary>
        /// A description for the ChemometricModelSettings Object.
        /// </summary>
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

        /// <summary>
        /// A description for the Context Object.
        /// </summary>
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
           "b2dyZXNzAC8BAEgJAikAAAAc/////wEBAQAAAAAjAQEBRSkBAAAAFWCJCgIAAAAAAAsAAABFbnVtU3Ry" +
           "aW5ncwEBBSkALgBEBSkAAAAVAQAAAAEB/////wAAAAA1YIkKAgAAAAEACAAAAFByb2dyZXNzAQEGKQMA" +
           "AAAAdAAAAEluZGljYXRlcyB0aGUgcHJvZ3Jlc3Mgb2YgYW4gYWNxdWlzaXRpb24gaW4gdGVybXMgb2Yg" +
           "cGVyY2VudGFnZSBvZiBjb21wbGV0aW9uLiBJdHMgdmFsdWUgc2hhbGwgYmUgYmV0d2VlbiAwIGFuZCAx" +
           "MDAuAC8BAD0JBikAAAAK/////wEBAQAAAAAjAQEBRSkAAAAANWCJCgIAAAABABIAAABBY3F1aXNpdGlv" +
           "bkNvdW50ZXIBAQkpAwAAAABTAAAAU2ltcGxlIGNvdW50ZXIgaW5jcmVtZW50ZWQgYWZ0ZXIgZWFjaCBT" +
           "YW1wbGluZyBhY3F1aXNpdGlvbiBwZXJmb3JtZWQgb24gdGhpcyBTdHJlYW0ALwEAQAkJKQAAAQAhAf//" +
           "//8BAQEAAAAAIwEBAUcpAQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBDSkALgBEDSkAAAEAdAP/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAXAAAAQWNxdWlzaXRpb25SZXN1bHRTdGF0dXMBAQ8pAwAAAAAaAAAA" +
           "UXVhbGl0eSBvZiB0aGUgYWNxdWlzaXRpb24ALwEAPQkPKQAAAQG7C/////8BAQEAAAAAIwEBAUcpAAAA" +
           "ADVgiQoCAAAAAQAKAAAAU2NhbGVkRGF0YQEBFSkDAAAAAGgAAABTY2FsZWQgZGF0YSBwcm9kdWNlZCBh" +
           "cyBhIHJlc3VsdCBvZiBkYXRhIGFjcXVpc2l0aW9uIG9uIHRoZSBTdHJlYW0gYW5kIGFwcGxpY2F0aW9u" +
           "IG9mIHRoZSBhbmFseXNlciBtb2RlbAAvAQA9CRUpAAAAGP////8BAQEAAAAAIwEBAUcpAAAAADVgiQoC" +
           "AAAAAQASAAAAQWNxdWlzaXRpb25FbmRUaW1lAQEbKQMAAAAApwAAAFRoZSBlbmQgdGltZSBvZiB0aGUg" +
           "QW5hbHlzZVNhbXBsZSBvciBBbmFseXNlQ2FsaWJyYXRpb25TYW1wbGUgb3IgQW5hbHlzZVZhbGlkYXRp" +
           "b25TYW1wbGUgc3RhdGUgb2YgdGhlIEFuYWx5c2VyQ2hhbm5lbF9PcGVyYXRpbmdNb2RlRXhlY3V0ZVN1" +
           "YlN0YXRlTWFjaGluZSBzdGF0ZSBtYWNoaW5lAC8BAD0JGykAAAAN/////wEBAQAAAAAjAQEBRykAAAAA" +
           "FWCJCgIAAAABABAAAABBY3RpdmVCYWNrZ3JvdW5kAQFPKQAvAQD9Lk8pAAAACv////8BAQEAAAAAIwEB" +
           "AT8pBQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBUykALgBEUykAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBVCkALgBEVCkAAAEAdwP/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAFAAAAVGl0bGUBAVUpAC4ARFUpAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABB" +
           "eGlzU2NhbGVUeXBlAQFWKQAuAERWKQAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhp" +
           "c0RlZmluaXRpb24BAVcpAC4ARFcpAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAEFjdGl2" +
           "ZUJhY2tncm91bmQxAQFYKQAvAQD9LlgpAAAACv////8BAQEAAAAAIwEBAT8pBQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBXCkALgBEXCkAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAAAQAAAARW5naW5l" +
           "ZXJpbmdVbml0cwEBXSkALgBEXSkAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAAAFAAAAVGl0bGUB" +
           "AV4pAC4ARF4pAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABBeGlzU2NhbGVUeXBlAQFfKQAu" +
           "AERfKQAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhpc0RlZmluaXRpb24BAWApAC4A" +
           "RGApAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAFNwZWN0cmFsUmFuZ2UBAWEpAC8BAD0J" +
           "YSkAAAEAdAMBAAAAAQEBAAAAACMBAQFDKQAAAAAVYIkKAgAAAAEACgAAAFJlc29sdXRpb24BAWQpAC8B" +
           "AD0JZCkAAAAY/////wEBAQAAAAAjAQEBQykAAAAAFWCJCgIAAAABABYAAABSZXF1ZXN0ZWROdW1iZXJP" +
           "ZlNjYW5zAQFnKQAvAQA9CWcpAAAABv////8BAQEAAAAAIwEBAUMpAAAAABVgiQoCAAAAAQAEAAAAR2Fp" +
           "bgEBaikALwEAPQlqKQAAABj/////AQEBAAAAACMBAQFDKQAAAAAVYIkKAgAAAAEAEwAAAFRyYW5zbWl0" +
           "dGFuY2VDdXRvZmYBAW0pAC8BAD0JbSkAAAEAdAP/////AQEBAAAAACMBAQFDKQAAAAAVYIkKAgAAAAEA" +
           "EAAAAEFic29yYmFuY2VDdXRvZmYBAXApAC8BAD0JcCkAAAEAdAP/////AQEBAAAAACMBAQFDKQAAAAAV" +
           "YIkKAgAAAAEAEQAAAE51bWJlck9mU2NhbnNEb25lAQFzKQAvAQA9CXMpAAAABv////8BAQEAAAAAIwEB" +
           "AUUpAAAAABVgiQoCAAAAAQAWAAAAVG90YWxOdW1iZXJPZlNjYW5zRG9uZQEBdikALwEAPQl2KQAAAAb/" +
           "////AQEBAAAAACMBAQFHKQAAAAAVYIkKAgAAAAEAGQAAAEJhY2tncm91bmRBY3F1aXNpdGlvblRpbWUB" +
           "AXkpAC8BAD0JeSkAAAAN/////wEBAQAAAAAjAQEBRykAAAAAFWCJCgIAAAABABEAAABQZW5kaW5nQmFj" +
           "a2dyb3VuZAEBfCkALwEA/S58KQAAAAr/////AQEBAAAAACMBAQFHKQUAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAYApAC4ARIApAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMBAYEpAC4ARIEpAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAAABQAAAFRpdGxlAQGCKQAu" +
           "AESCKQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQXhpc1NjYWxlVHlwZQEBgykALgBEgykA" +
           "AAEALS//////AQH/////AAAAABVgiQoCAAAAAAAPAAAAWEF4aXNEZWZpbml0aW9uAQGEKQAuAESEKQAA" +
           "AQAvL/////8BAf////8AAAAAFWCJCgIAAAABABIAAABQZW5kaW5nQmFja2dyb3VuZDEBAYUpAC8BAP0u" +
           "hSkAAAAK/////wEBAQAAAAAjAQEBRykFAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGJKQAuAESJKQAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQGKKQAuAESKKQAA" +
           "AQB3A/////8BAf////8AAAAAFWCJCgIAAAAAAAUAAABUaXRsZQEBiykALgBEiykAAAAV/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADQAAAEF4aXNTY2FsZVR5cGUBAYwpAC4ARIwpAAABAC0v/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADwAAAFhBeGlzRGVmaW5pdGlvbgEBjSkALgBEjSkAAAEALy//////AQH/////AAAA" +
           "AARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBPykALwEC7QM/KQAABAAAAAAjAAEB5CgAIwABAeco" +
           "ACMAAQFPKQAjAAEBWCkAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAUEpAC8BAu0DQSkAAAQAAAAAIwAB" +
           "AeooACMAAQHtKAAjAAEB8CgAIwABAfMoAAAAAARggAoBAAAAAQATAAAAQWNxdWlzaXRpb25TZXR0aW5n" +
           "cwEBQykALwEC7QNDKQAABwAAAAAjAAEB9igAIwABAWEpACMAAQFkKQAjAAEBZykAIwABAWopACMAAQFt" +
           "KQAjAAEBcCkAAAAABGCACgEAAAABABEAAABBY3F1aXNpdGlvblN0YXR1cwEBRSkALwEC7QNFKQAABQAA" +
           "AAAjAAEB/CgAIwABAf8oACMAAQECKQAjAAEBBikAIwABAXMpAAAAAARggAoBAAAAAQAPAAAAQWNxdWlz" +
           "aXRpb25EYXRhAQFHKQAvAQLtA0cpAAAKAAAAACMAAQEJKQAjAAEBDykAIwABARIpACMAAQEVKQAjAAEB" +
           "GCkAIwABARspACMAAQF2KQAjAAEBeSkAIwABAXwpACMAAQGFKQAAAAAEYIAKAQAAAAEAGAAAAENoZW1v" +
           "bWV0cmljTW9kZWxTZXR0aW5ncwEBSSkALwEC7QNJKQAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRl" +
           "eHQBAUspAC8BAu0DSykAAAsAAAAAIwABAR4pACMAAQEhKQAjAAEBJCkAIwABAScpACMAAQEqKQAjAAEB" +
           "LSkAIwABATApACMAAQEzKQAjAAEBNikAIwABATkpACMAAQE8KQAAAAAEYIAKAQAAAAEADwAAAEZhY3Rv" +
           "cnlTZXR0aW5ncwEBjikALwA6jikAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the FactorySettings Object.
        /// </summary>
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
           "cyBpbiBwcm9ncmVzcwAvAQBICUQqAAAAHP////8BAQEAAAAAIwEBAYcqAQAAABVgiQoCAAAAAAALAAAA" +
           "RW51bVN0cmluZ3MBAUcqAC4AREcqAAAAFQEAAAABAf////8AAAAANWCJCgIAAAABAAgAAABQcm9ncmVz" +
           "cwEBSCoDAAAAAHQAAABJbmRpY2F0ZXMgdGhlIHByb2dyZXNzIG9mIGFuIGFjcXVpc2l0aW9uIGluIHRl" +
           "cm1zIG9mIHBlcmNlbnRhZ2Ugb2YgY29tcGxldGlvbi4gSXRzIHZhbHVlIHNoYWxsIGJlIGJldHdlZW4g" +
           "MCBhbmQgMTAwLgAvAQA9CUgqAAAACv////8BAQEAAAAAIwEBAYcqAAAAADVgiQoCAAAAAQASAAAAQWNx" +
           "dWlzaXRpb25Db3VudGVyAQFLKgMAAAAAUwAAAFNpbXBsZSBjb3VudGVyIGluY3JlbWVudGVkIGFmdGVy" +
           "IGVhY2ggU2FtcGxpbmcgYWNxdWlzaXRpb24gcGVyZm9ybWVkIG9uIHRoaXMgU3RyZWFtAC8BAEAJSyoA" +
           "AAEAIQH/////AQEBAAAAACMBAQGJKgEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAU8qAC4ARE8qAAAB" +
           "AHQD/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEFjcXVpc2l0aW9uUmVzdWx0U3RhdHVzAQFRKgMA" +
           "AAAAGgAAAFF1YWxpdHkgb2YgdGhlIGFjcXVpc2l0aW9uAC8BAD0JUSoAAAEBuwv/////AQEBAAAAACMB" +
           "AQGJKgAAAAA1YIkKAgAAAAEACgAAAFNjYWxlZERhdGEBAVcqAwAAAABoAAAAU2NhbGVkIGRhdGEgcHJv" +
           "ZHVjZWQgYXMgYSByZXN1bHQgb2YgZGF0YSBhY3F1aXNpdGlvbiBvbiB0aGUgU3RyZWFtIGFuZCBhcHBs" +
           "aWNhdGlvbiBvZiB0aGUgYW5hbHlzZXIgbW9kZWwALwEAPQlXKgAAABj/////AQEBAAAAACMBAQGJKgAA" +
           "AAA1YIkKAgAAAAEAEgAAAEFjcXVpc2l0aW9uRW5kVGltZQEBXSoDAAAAAKcAAABUaGUgZW5kIHRpbWUg" +
           "b2YgdGhlIEFuYWx5c2VTYW1wbGUgb3IgQW5hbHlzZUNhbGlicmF0aW9uU2FtcGxlIG9yIEFuYWx5c2VW" +
           "YWxpZGF0aW9uU2FtcGxlIHN0YXRlIG9mIHRoZSBBbmFseXNlckNoYW5uZWxfT3BlcmF0aW5nTW9kZUV4" +
           "ZWN1dGVTdWJTdGF0ZU1hY2hpbmUgc3RhdGUgbWFjaGluZQAvAQA9CV0qAAAADf////8BAQEAAAAAIwEB" +
           "AYkqAAAAABVgiQoCAAAAAQAKAAAAQmFja2dyb3VuZAEBkSoALwEA/S6RKgAAAAr/////AQEBAAAAACMB" +
           "AQGJKgUAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZUqAC4ARJUqAAABAHQD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAZYqAC4ARJYqAAABAHcD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABQAAAFRpdGxlAQGXKgAuAESXKgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "QXhpc1NjYWxlVHlwZQEBmCoALgBEmCoAAAEALS//////AQH/////AAAAABVgiQoCAAAAAAAPAAAAWEF4" +
           "aXNEZWZpbml0aW9uAQGZKgAuAESZKgAAAQAvL/////8BAf////8AAAAAFWCJCgIAAAABABAAAABTaXpl" +
           "RGlzdHJpYnV0aW9uAQGaKgAvAQD9LpoqAAAACv////8BAQEAAAAAIwEBAYkqBQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBnioALgBEnioAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAAAQAAAARW5naW5l" +
           "ZXJpbmdVbml0cwEBnyoALgBEnyoAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAAAFAAAAVGl0bGUB" +
           "AaAqAC4ARKAqAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABBeGlzU2NhbGVUeXBlAQGhKgAu" +
           "AEShKgAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhpc0RlZmluaXRpb24BAaIqAC4A" +
           "RKIqAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEAGQAAAEJhY2tncm91bmRBY3F1aXNpdGlvblRp" +
           "bWUBAaMqAC8BAD0JoyoAAAAN/////wEBAQAAAAAjAQEBiSoAAAAABGCACgEAAAABAA0AAABDb25maWd1" +
           "cmF0aW9uAQGBKgAvAQLtA4EqAAACAAAAACMAAQEmKgAjAAEBKSoAAAAABGCACgEAAAABAAYAAABTdGF0" +
           "dXMBAYMqAC8BAu0DgyoAAAQAAAAAIwABASwqACMAAQEvKgAjAAEBMioAIwABATUqAAAAAARggAoBAAAA" +
           "AQATAAAAQWNxdWlzaXRpb25TZXR0aW5ncwEBhSoALwEC7QOFKgAAAQAAAAAjAAEBOCoAAAAABGCACgEA" +
           "AAABABEAAABBY3F1aXNpdGlvblN0YXR1cwEBhyoALwEC7QOHKgAABAAAAAAjAAEBPioAIwABAUEqACMA" +
           "AQFEKgAjAAEBSCoAAAAABGCACgEAAAABAA8AAABBY3F1aXNpdGlvbkRhdGEBAYkqAC8BAu0DiSoAAAkA" +
           "AAAAIwABAUsqACMAAQFRKgAjAAEBVCoAIwABAVcqACMAAQFaKgAjAAEBXSoAIwABAZEqACMAAQGaKgAj" +
           "AAEBoyoAAAAABGCACgEAAAABABgAAABDaGVtb21ldHJpY01vZGVsU2V0dGluZ3MBAYsqAC8BAu0DiyoA" +
           "AP////8AAAAABGCACgEAAAABAAcAAABDb250ZXh0AQGNKgAvAQLtA40qAAALAAAAACMAAQFgKgAjAAEB" +
           "YyoAIwABAWYqACMAAQFpKgAjAAEBbCoAIwABAW8qACMAAQFyKgAjAAEBdSoAIwABAXgqACMAAQF7KgAj" +
           "AAEBfioAAAAA";
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
           "AQA9CXgsAAABAmQY/////wEBAQAAAAAjAQEBkSwAAAAAFWCJCgIAAAABAA0AAABTcGVjdHJhbFJhbmdl" +
           "AQEfLQAvAQA9CR8tAAABAHQDAQAAAAEB/////wAAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBKywD" +
           "AAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADorLAAA/////woAAAAEYYIKBAAAAAEAEAAAAEdl" +
           "dENvbmZpZ3VyYXRpb24BAWgsAC8BAeMkaCwAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBaSwALgBEaSwAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBaiwALwEB5SRqLAAA" +
           "AQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWssAC4ARGssAACWAQAAAAEAKgEB" +
           "GQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBbCwALgBEbCwAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdl" +
           "c3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQATAAAAR2V0Q29uZmlnRGF0YURp" +
           "Z2VzdAEBbSwALwEB6CRtLAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFu" +
           "LAAuAERuLAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAABABcAAABDb21wYXJlQ29uZmlnRGF0YURpZ2VzdAEBbywALwEB6iRv" +
           "LAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXAsAC4ARHAsAACWAQAAAAEA" +
           "KgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBcSwALgBEcSwAAJYBAAAAAQAqAQEWAAAABwAAAElzRXF1" +
           "YWwAAf////8AAAAAAAEAKAEBAAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAUmVzZXRBbGxDaGFubmVs" +
           "cwEBciwDAAAAADwAAABSZXNldCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBB" +
           "bmFseXNlckRldmljZS4ALwEB7SRyLAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAU3RhcnRBbGxDaGFu" +
           "bmVscwEBcywDAAAAADwAAABTdGFydCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhp" +
           "cyBBbmFseXNlckRldmljZS4ALwEB7iRzLAAAAQH/////AAAAACRhggoEAAAAAQAPAAAAU3RvcEFsbENo" +
           "YW5uZWxzAQF0LAMAAAAAOwAAAFN0b3AgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRo" +
           "aXMgQW5hbHlzZXJEZXZpY2UuAC8BAe8kdCwAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAEFib3J0QWxs" +
           "Q2hhbm5lbHMBAXUsAwAAAAA8AAAAQWJvcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRv" +
           "IHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAfAkdSwAAAEB/////wAAAAAkYYIKBAAAAAEADQAAAEdvdG9P" +
           "cGVyYXRpbmcBAXYsAwAAAACNAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gT3Bl" +
           "cmF0aW5nIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5uZWxzIHRvIGxlYXZlIHRoZSBTbGF2" +
           "ZU1vZGUgc3RhdGUgYW5kIGdvIHRvIHRoZSBPcGVyYXRpbmcgc3RhdGUuAC8BAfEkdiwAAAEB/////wAA" +
           "AAAkYYIKBAAAAAEADwAAAEdvdG9NYWludGVuYW5jZQEBdywDAAAAAGcAAABBbmFseXNlckRldmljZVN0" +
           "YXRlTWFjaGluZSB0byBnbyB0byBNYWludGVuYW5jZSBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJD" +
           "aGFubmVscyB0byBTbGF2ZU1vZGUgc3RhdGUuAC8BAfIkdywAAAEB/////wAAAAAkYIAKAQAAAAIADgAA" +
           "AElkZW50aWZpY2F0aW9uAQEvLAMAAAAARgAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3Ig" +
           "aWRlbnRpZmljYXRpb24gb2YgdGhpcyBUb3BvbG9neUVsZW1lbnQALwEC7QMvLAAAAwAAAAAjAAECcxcA" +
           "IwABAnQXACMAAQJxFwAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBPywDAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAEQ/LAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQFALAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAERALAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQFBLAMA" +
           "AAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAERB" +
           "LAAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAUIsAwAAAAAYAAAATW9kZWwgbmFt" +
           "ZSBvZiB0aGUgZGV2aWNlAC4AREIsAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VN" +
           "YW51YWwBAUMsAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AREMsAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBRCwDAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBERCwAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAUUsAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBERSwAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAUYsAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBERiwAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAENv" +
           "bmZpZ3VyYXRpb24BAY8sAC8BAu0DjywAAAEAAAAAIwABAXssAAAAAARggAoBAAAAAQAGAAAAU3RhdHVz" +
           "AQGRLAAvAQLtA5EsAAABAAAAACMAAQF4LAAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlTZXR0aW5ncwEB" +
           "kywALwEC7QOTLAAA/////wAAAAAEYIAKAQAAAAEAFAAAAEFuYWx5c2VyU3RhdGVNYWNoaW5lAQGVLAAv" +
           "AQHqA5UsAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGWLAAvAQDICpYsAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBlywALgBElywAAAAR/////wEB/////wAAAAA=";
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
           "aWd1cmF0aW9uAQFhLQAvAQHjJGEtAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAWItAC4ARGItAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAWMtAC8BAeUkYy0AAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFkLQAuAERkLQAAlgEAAAABACoBARkAAAAK" +
           "AAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAWUtAC4ARGUtAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QB" +
           "AWYtAC8BAegkZi0AAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBZy0ALgBE" +
           "Zy0AAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAWgtAC8BAeokaC0AAAEB" +
           "/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFpLQAuAERpLQAAlgEAAAABACoBAR8A" +
           "AAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAWotAC4ARGotAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAWst" +
           "AwAAAAA8AAAAUmVzZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlz" +
           "ZXJEZXZpY2UuAC8BAe0kay0AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMB" +
           "AWwtAwAAAAA8AAAAU3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5h" +
           "bHlzZXJEZXZpY2UuAC8BAe4kbC0AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVs" +
           "cwEBbS0DAAAAADsAAABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHvJG0tAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5u" +
           "ZWxzAQFuLQMAAAAAPAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlz" +
           "IEFuYWx5c2VyRGV2aWNlLgAvAQHwJG4tAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0" +
           "aW5nAQFvLQMAAAAAjQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGlu" +
           "ZyBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2Rl" +
           "IHN0YXRlIGFuZCBnbyB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJG8tAAABAf////8AAAAAJGGC" +
           "CgQAAAABAA8AAABHb3RvTWFpbnRlbmFuY2UBAXAtAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1h" +
           "Y2hpbmUgdG8gZ28gdG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5l" +
           "bHMgdG8gU2xhdmVNb2RlIHN0YXRlLgAvAQHyJHAtAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVu" +
           "dGlmaWNhdGlvbgEBKC0DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50" +
           "aWZpY2F0aW9uIG9mIHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DKC0AAAMAAAAAIwABAnMXACMAAQJ0" +
           "FwAjAAECcRcAAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBATgtAwAAAABNAAAASWRlbnRpZmll" +
           "ciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2Ug" +
           "aW5zdGFuY2UALgBEOC0AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRl" +
           "cgEBOS0DAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBv" +
           "ZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQA" +
           "LgBEOS0AAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBOi0DAAAAADAA" +
           "AABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEOi0AAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQE7LQMAAAAAGAAAAE1vZGVsIG5hbWUgb2Yg" +
           "dGhlIGRldmljZQAuAEQ7LQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFs" +
           "AQE8LQMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8" +
           "IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQ8LQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAT0tAwAAAAAkAAAAT3ZlcmFsbCByZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARD0tAAAADP////8BAf////8AAAAANWCJCgIAAAACABAA" +
           "AABTb2Z0d2FyZVJldmlzaW9uAQE+LQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2Fy" +
           "ZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARD4tAAAADP////8BAf////8AAAAANWCJCgIAAAACABAA" +
           "AABIYXJkd2FyZVJldmlzaW9uAQE/LQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2Fy" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARD8tAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1" +
           "cmF0aW9uAQGILQAvAQLtA4gtAAABAAAAACMAAQF0LQAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBii0A" +
           "LwEC7QOKLQAAAQAAAAAjAAEBcS0AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAYwtAC8B" +
           "Au0DjC0AAP////8AAAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBji0ALwEB6gOO" +
           "LQAA/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBjy0ALwEAyAqPLQAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAZAtAC4ARJAtAAAAEf////8BAf////8AAAAA";
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
           "aW9uAQFXLgAvAQHjJFcuAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVgu" +
           "AC4ARFguAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAVkuAC8BAeUkWS4AAAEB/////wIAAAAV" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFaLgAuAERaLgAAlgEAAAABACoBARkAAAAKAAAAQ29u" +
           "ZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAVsuAC4ARFsuAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAVwuAC8B" +
           "AegkXC4AAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBXS4ALgBEXS4AAJYB" +
           "AAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAV4uAC8BAeokXi4AAAEB/////wIA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFfLgAuAERfLgAAlgEAAAABACoBAR8AAAAQAAAA" +
           "Q29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAWAuAC4ARGAuAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAWEuAwAAAAA8" +
           "AAAAUmVzZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZp" +
           "Y2UuAC8BAe0kYS4AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAWIuAwAA" +
           "AAA8AAAAU3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJE" +
           "ZXZpY2UuAC8BAe4kYi4AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEBYy4D" +
           "AAAAADsAAABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2Vy" +
           "RGV2aWNlLgAvAQHvJGMuAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxzAQFk" +
           "LgMAAAAAPAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHwJGQuAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5nAQFl" +
           "LgMAAAAAjQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0" +
           "ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRl" +
           "IGFuZCBnbyB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJGUuAAABAf////8AAAAAJGGCCgQAAAAB" +
           "AA8AAABHb3RvTWFpbnRlbmFuY2UBAWYuAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUg" +
           "dG8gZ28gdG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8g" +
           "U2xhdmVNb2RlIHN0YXRlLgAvAQHyJGYuAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlmaWNh" +
           "dGlvbgEBHi4DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0" +
           "aW9uIG9mIHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DHi4AAAMAAAAAIwABAnMXACMAAQJ0FwAjAAEC" +
           "cRcAAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAS4uAwAAAABNAAAASWRlbnRpZmllciB0aGF0" +
           "IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFu" +
           "Y2UALgBELi4AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBLy4D" +
           "AAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1l" +
           "cyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBELy4A" +
           "AAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBMC4DAAAAADAAAABOYW1l" +
           "IG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEMC4AAAAV/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQExLgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRl" +
           "dmljZQAuAEQxLgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEyLgMA" +
           "AAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBh" +
           "ZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQyLgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BATMuAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgZGV2aWNlAC4ARDMuAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0" +
           "d2FyZVJldmlzaW9uAQE0LgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJt" +
           "d2FyZSBvZiB0aGUgZGV2aWNlAC4ARDQuAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJk" +
           "d2FyZVJldmlzaW9uAQE1LgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARDUuAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9u" +
           "AQF+LgAvAQLtA34uAAABAAAAACMAAQFqLgAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBgC4ALwEC7QOA" +
           "LgAAAQAAAAAjAAEBZy4AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAYIuAC8BAu0Dgi4A" +
           "AP////8AAAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBhC4ALwEB6gOELgAA////" +
           "/wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBhS4ALwEAyAqFLgAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAYYuAC4ARIYuAAAAEf////8BAf////8AAAAA";
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
           "cmF0aW9uAQFNLwAvAQHjJE0vAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AU4vAC4ARE4vAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAU8vAC8BAeUkTy8AAAEB/////wIA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQLwAuAERQLwAAlgEAAAABACoBARkAAAAKAAAA" +
           "Q29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAVEvAC4ARFEvAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAVIv" +
           "AC8BAegkUi8AAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBUy8ALgBEUy8A" +
           "AJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAAARhggoEAAAAAQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAVQvAC8BAeokVC8AAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFVLwAuAERVLwAAlgEAAAABACoBAR8AAAAQ" +
           "AAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAVYvAC4ARFYvAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAVcvAwAA" +
           "AAA8AAAAUmVzZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJE" +
           "ZXZpY2UuAC8BAe0kVy8AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAVgv" +
           "AwAAAAA8AAAAU3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlz" +
           "ZXJEZXZpY2UuAC8BAe4kWC8AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEB" +
           "WS8DAAAAADsAAABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHvJFkvAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxz" +
           "AQFaLwMAAAAAPAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHwJFovAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5n" +
           "AQFbLwMAAAAAjQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBz" +
           "dGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0" +
           "YXRlIGFuZCBnbyB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJFsvAAABAf////8AAAAAJGGCCgQA" +
           "AAABAA8AAABHb3RvTWFpbnRlbmFuY2UBAVwvAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hp" +
           "bmUgdG8gZ28gdG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMg" +
           "dG8gU2xhdmVNb2RlIHN0YXRlLgAvAQHyJFwvAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlm" +
           "aWNhdGlvbgEBFC8DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZp" +
           "Y2F0aW9uIG9mIHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DFC8AAAMAAAAAIwABAnMXACMAAQJ0FwAj" +
           "AAECcRcAAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBASQvAwAAAABNAAAASWRlbnRpZmllciB0" +
           "aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5z" +
           "dGFuY2UALgBEJC8AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEB" +
           "JS8DAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0" +
           "aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE" +
           "JS8AAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBJi8DAAAAADAAAABO" +
           "YW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEJi8AAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQEnLwMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhl" +
           "IGRldmljZQAuAEQnLwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEo" +
           "LwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdl" +
           "YiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQoLwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BASkvAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lv" +
           "biBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARCkvAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABT" +
           "b2Z0d2FyZVJldmlzaW9uAQEqLwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9m" +
           "aXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARCovAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABI" +
           "YXJkd2FyZVJldmlzaW9uAQErLwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARCsvAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0" +
           "aW9uAQF0LwAvAQLtA3QvAAABAAAAACMAAQFgLwAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBdi8ALwEC" +
           "7QN2LwAAAQAAAAAjAAEBXS8AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAXgvAC8BAu0D" +
           "eC8AAP////8AAAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBei8ALwEB6gN6LwAA" +
           "/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBey8ALwEAyAp7LwAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAXwvAC4ARHwvAAAAEf////8BAf////8AAAAA";
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
           "ZmlndXJhdGlvbgEBQzAALwEB4yRDMAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQFEMAAuAEREMAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAABABAAAABTZXRDb25maWd1cmF0aW9uAQFFMAAvAQHlJEUwAAABAf//" +
           "//8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRjAALgBERjAAAJYBAAAAAQAqAQEZAAAA" +
           "CgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQFHMAAuAERHMAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABABMAAABHZXRDb25maWdEYXRhRGlnZXN0" +
           "AQFIMAAvAQHoJEgwAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUkwAC4A" +
           "REkwAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEAFwAAAENvbXBhcmVDb25maWdEYXRhRGlnZXN0AQFKMAAvAQHqJEowAAAB" +
           "Af////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBSzAALgBESzAAAJYBAAAAAQAqAQEf" +
           "AAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQFMMAAuAERMMAAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAJGGCCgQAAAABABAAAABSZXNldEFsbENoYW5uZWxzAQFN" +
           "MAMAAAAAPAAAAFJlc2V0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHtJE0wAAABAf////8AAAAAJGGCCgQAAAABABAAAABTdGFydEFsbENoYW5uZWxz" +
           "AQFOMAMAAAAAPAAAAFN0YXJ0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHuJE4wAAABAf////8AAAAAJGGCCgQAAAABAA8AAABTdG9wQWxsQ2hhbm5l" +
           "bHMBAU8wAwAAAAA7AAAAU3RvcCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBB" +
           "bmFseXNlckRldmljZS4ALwEB7yRPMAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAQWJvcnRBbGxDaGFu" +
           "bmVscwEBUDADAAAAADwAAABBYm9ydCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhp" +
           "cyBBbmFseXNlckRldmljZS4ALwEB8CRQMAAAAQH/////AAAAACRhggoEAAAAAQANAAAAR290b09wZXJh" +
           "dGluZwEBUTADAAAAAI0AAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBPcGVyYXRp" +
           "bmcgc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gbGVhdmUgdGhlIFNsYXZlTW9k" +
           "ZSBzdGF0ZSBhbmQgZ28gdG8gdGhlIE9wZXJhdGluZyBzdGF0ZS4ALwEB8SRRMAAAAQH/////AAAAACRh" +
           "ggoEAAAAAQAPAAAAR290b01haW50ZW5hbmNlAQFSMAMAAAAAZwAAAEFuYWx5c2VyRGV2aWNlU3RhdGVN" +
           "YWNoaW5lIHRvIGdvIHRvIE1haW50ZW5hbmNlIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5u" +
           "ZWxzIHRvIFNsYXZlTW9kZSBzdGF0ZS4ALwEB8iRSMAAAAQH/////AAAAACRggAoBAAAAAgAOAAAASWRl" +
           "bnRpZmljYXRpb24BAQowAwAAAABGAAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVu" +
           "dGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVudAAvAQLtAwowAAADAAAAACMAAQJzFwAjAAEC" +
           "dBcAIwABAnEXAAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEaMAMAAAAATQAAAElkZW50aWZp" +
           "ZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNl" +
           "IGluc3RhbmNlAC4ARBowAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50" +
           "ZXIBARswAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIg" +
           "b2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVk" +
           "AC4ARBswAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBARwwAwAAAAAw" +
           "AAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARBwwAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBHTADAAAAABgAAABNb2RlbCBuYW1lIG9m" +
           "IHRoZSBkZXZpY2UALgBEHTAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVh" +
           "bAEBHjADAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwg" +
           "fCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEHjAAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQEfMAMAAAAAJAAAAE92ZXJhbGwgcmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAEQfMAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAAU29mdHdhcmVSZXZpc2lvbgEBIDADAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdh" +
           "cmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAEQgMAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAASGFyZHdhcmVSZXZpc2lvbgEBITADAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAEQhMAAAAAz/////AQH/////AAAAAARggAoBAAAAAQANAAAAQ29uZmln" +
           "dXJhdGlvbgEBajAALwEC7QNqMAAAAQAAAAAjAAEBVjAAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAWww" +
           "AC8BAu0DbDAAAAEAAAAAIwABAVMwAAAAAARggAoBAAAAAQAPAAAARmFjdG9yeVNldHRpbmdzAQFuMAAv" +
           "AQLtA24wAAD/////AAAAAARggAoBAAAAAQAUAAAAQW5hbHlzZXJTdGF0ZU1hY2hpbmUBAXAwAC8BAeoD" +
           "cDAAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAXEwAC8BAMgKcTAAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFyMAAuAERyMAAAABH/////AQH/////AAAAAA==";
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
           "AeMkOTEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOjEALgBEOjEAAJYB" +
           "AAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBOzEALwEB5SQ7MQAAAQH/////AgAAABVgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBATwxAC4ARDwxAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBPTEA" +
           "LgBEPTEAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAAARhggoEAAAAAQATAAAAR2V0Q29uZmlnRGF0YURpZ2VzdAEBPjEALwEB6CQ+MQAAAQH/" +
           "////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE/MQAuAEQ/MQAAlgEAAAABACoBAR8A" +
           "AAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAAB" +
           "ABcAAABDb21wYXJlQ29uZmlnRGF0YURpZ2VzdAEBQDEALwEB6iRAMQAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAUExAC4AREExAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRh" +
           "RGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBQjEALgBEQjEAAJYBAAAAAQAqAQEWAAAABwAAAElzRXF1YWwAAf////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAACRhggoEAAAAAQAQAAAAUmVzZXRBbGxDaGFubmVscwEBQzEDAAAAADwAAABSZXNldCBh" +
           "bGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7SRD" +
           "MQAAAQH/////AAAAACRhggoEAAAAAQAQAAAAU3RhcnRBbGxDaGFubmVscwEBRDEDAAAAADwAAABTdGFy" +
           "dCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB" +
           "7iREMQAAAQH/////AAAAACRhggoEAAAAAQAPAAAAU3RvcEFsbENoYW5uZWxzAQFFMQMAAAAAOwAAAFN0" +
           "b3AgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8B" +
           "Ae8kRTEAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAEFib3J0QWxsQ2hhbm5lbHMBAUYxAwAAAAA8AAAA" +
           "QWJvcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2Uu" +
           "AC8BAfAkRjEAAAEB/////wAAAAAkYYIKBAAAAAEADQAAAEdvdG9PcGVyYXRpbmcBAUcxAwAAAACNAAAA" +
           "QW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gT3BlcmF0aW5nIHN0YXRlLCBmb3JjaW5n" +
           "IGFsbCBBbmFseXNlckNoYW5uZWxzIHRvIGxlYXZlIHRoZSBTbGF2ZU1vZGUgc3RhdGUgYW5kIGdvIHRv" +
           "IHRoZSBPcGVyYXRpbmcgc3RhdGUuAC8BAfEkRzEAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAEdvdG9N" +
           "YWludGVuYW5jZQEBSDEDAAAAAGcAAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBN" +
           "YWludGVuYW5jZSBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBTbGF2ZU1vZGUg" +
           "c3RhdGUuAC8BAfIkSDEAAAEB/////wAAAAAkYIAKAQAAAAIADgAAAElkZW50aWZpY2F0aW9uAQEAMQMA" +
           "AAAARgAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3IgaWRlbnRpZmljYXRpb24gb2YgdGhp" +
           "cyBUb3BvbG9neUVsZW1lbnQALwEC7QMAMQAAAwAAAAAjAAECcxcAIwABAnQXACMAAQJxFwAAAAA1YIkK" +
           "AgAAAAIADAAAAFNlcmlhbE51bWJlcgEBEDEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkg" +
           "aWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQQMQAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQERMQMAAAAAaQAAAEFu" +
           "IGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0" +
           "aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQRMQAAAAb/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQESMQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNv" +
           "bXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQSMQAAABX/////AQH/////AAAAADVg" +
           "iQoCAAAAAgAFAAAATW9kZWwBARMxAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARBMx" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBARQxAwAAAABaAAAAQWRk" +
           "cmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9m" +
           "IHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARBQxAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "AA4AAABEZXZpY2VSZXZpc2lvbgEBFTEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBkZXZpY2UALgBEFTEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNp" +
           "b24BARYxAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBEFjEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNp" +
           "b24BARcxAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBEFzEAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAWAxAC8BAu0D" +
           "YDEAAAEAAAAAIwABAUwxAAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQFiMQAvAQLtA2IxAAABAAAAACMA" +
           "AQFJMQAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlTZXR0aW5ncwEBZDEALwEC7QNkMQAA/////wAAAAAE" +
           "YIAKAQAAAAEAFAAAAEFuYWx5c2VyU3RhdGVNYWNoaW5lAQFmMQAvAQHqA2YxAAD/////AQAAABVgiQoC" +
           "AAAAAAAMAAAAQ3VycmVudFN0YXRlAQFnMQAvAQDICmcxAAAAFf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBaDEALgBEaDEAAAAR/////wEB/////wAAAAA=";
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
        /// <summary>
        /// True if an accessory can be inserted in the accessory slot while it is powered
        /// </summary>
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

        /// <summary>
        /// True if this accessory slot is capable of accepting an accessory in it
        /// </summary>
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

        /// <summary>
        /// A description for the AccessorySlotStateMachine Object.
        /// </summary>
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
        /// A description for the Status Object.
        /// </summary>
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

        /// <summary>
        /// A description for the FactorySettings Object.
        /// </summary>
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

        /// <summary>
        /// True if this accessory can be inserted in the accessory slot while it is powered
        /// </summary>
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

        /// <summary>
        /// True if this accessory is ready for use
        /// </summary>
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
        /// <summary>
        /// A description for the Name Property.
        /// </summary>
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

        /// <summary>
        /// A description for the CreationDate Property.
        /// </summary>
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

        /// <summary>
        /// A description for the ModelDescription Property.
        /// </summary>
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
        /// <summary>
        /// A description for the MainDataIndex Property.
        /// </summary>
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
           "Afsy+zIAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH8MgAuAET8MgAAlgMA" +
           "AAABACoBARoAAAALAAAAVGFyZ2V0TW9kZWwAEf////8AAAAAAAEAKgEBHAAAAA0AAABNYWluRGF0YUlu" +
           "ZGV4AAb/////AAAAAAABACoBARUAAAAGAAAASW5wdXRzABgBAAAAAAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/TIALgBE/TIAAJYBAAAAAQAqAQEWAAAABwAA" +
           "AE91dHB1dHMAGAEAAAAAAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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

            NodeId targetModel = (NodeId)inputArguments[0];
            int mainDataIndex = (int)inputArguments[1];
            Variant[] inputs = (Variant[])inputArguments[2];

            Variant[] outputs = (Variant[])outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    targetModel,
                    mainDataIndex,
                    inputs,
                    ref outputs);
            }

            outputArguments[0] = outputs;

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
        /// <summary>
        /// A description for the WarningLimits Property.
        /// </summary>
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

        /// <summary>
        /// A description for the AlarmLimits Property.
        /// </summary>
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

        /// <summary>
        /// A description for the AlarmState Property.
        /// </summary>
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

        /// <summary>
        /// A description for the VendorSpecificError Property.
        /// </summary>
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