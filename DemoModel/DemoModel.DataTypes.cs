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

namespace DemoModel
{
    #region EnumUnderscoreTest Enumeration
    #if (!OPCUA_EXCLUDE_EnumUnderscoreTest)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    
    public enum EnumUnderscoreTest
    {
        [EnumMember(Value = "x_x_1")]
        x_x = 1,

        [EnumMember(Value = "_x_2")]
        _x = 2,

        [EnumMember(Value = "x__3")]
        x_ = 3,

        [EnumMember(Value = "__4")]
        _ = 4,

        [EnumMember(Value = "Test5_-1")]
        Test5 = -1,
    }

    #region EnumUnderscoreTestCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfEnumUnderscoreTest", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "EnumUnderscoreTest")]
    public partial class EnumUnderscoreTestCollection : List<EnumUnderscoreTest>, ICloneable
    {
        #region Constructors
        public EnumUnderscoreTestCollection() {}

        public EnumUnderscoreTestCollection(int capacity) : base(capacity) {}

        public EnumUnderscoreTestCollection(IEnumerable<EnumUnderscoreTest> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator EnumUnderscoreTestCollection(EnumUnderscoreTest[] values)
        {
            if (values != null)
            {
                return new EnumUnderscoreTestCollection(values);
            }

            return new EnumUnderscoreTestCollection();
        }

        public static explicit operator EnumUnderscoreTest[](EnumUnderscoreTestCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (EnumUnderscoreTestCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnumUnderscoreTestCollection clone = new EnumUnderscoreTestCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EnumUnderscoreTest)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region HeaterStatus Enumeration
    #if (!OPCUA_EXCLUDE_HeaterStatus)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    
    public enum HeaterStatus
    {
        [EnumMember(Value = "Off_0")]
        Off = 0,

        [EnumMember(Value = "Heating_1")]
        Heating = 1,

        [EnumMember(Value = "Cooling_2")]
        Cooling = 2,
    }

    #region HeaterStatusCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfHeaterStatus", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "HeaterStatus")]
    public partial class HeaterStatusCollection : List<HeaterStatus>, ICloneable
    {
        #region Constructors
        public HeaterStatusCollection() {}

        public HeaterStatusCollection(int capacity) : base(capacity) {}

        public HeaterStatusCollection(IEnumerable<HeaterStatus> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator HeaterStatusCollection(HeaterStatus[] values)
        {
            if (values != null)
            {
                return new HeaterStatusCollection(values);
            }

            return new HeaterStatusCollection();
        }

        public static explicit operator HeaterStatus[](HeaterStatusCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (HeaterStatusCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            HeaterStatusCollection clone = new HeaterStatusCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((HeaterStatus)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region Vector Class
    #if (!OPCUA_EXCLUDE_Vector)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class Vector : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public Vector()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_x = (double)0;
            m_y = (double)0;
            m_z = (double)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "X", IsRequired = false, Order = 1)]
        public double X
        {
            get { return m_x;  }
            set { m_x = value; }
        }

        [DataMember(Name = "Y", IsRequired = false, Order = 2)]
        public double Y
        {
            get { return m_y;  }
            set { m_y = value; }
        }

        [DataMember(Name = "Z", IsRequired = false, Order = 3)]
        public double Z
        {
            get { return m_z;  }
            set { m_z = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.Vector;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.Vector_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.Vector_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.Vector;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            encoder.WriteDouble("X", X);
            encoder.WriteDouble("Y", Y);
            encoder.WriteDouble("Z", Z);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            X = decoder.ReadDouble("X");
            Y = decoder.ReadDouble("Y");
            Z = decoder.ReadDouble("Z");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Vector value = encodeable as Vector;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (Vector)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Vector clone = (Vector)base.MemberwiseClone();

            clone.m_x = (double)Utils.Clone(this.m_x);
            clone.m_y = (double)Utils.Clone(this.m_y);
            clone.m_z = (double)Utils.Clone(this.m_z);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_x;
        private double m_y;
        private double m_z;
        #endregion
    }

    #region VectorCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfVector", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "Vector")]
    public partial class VectorCollection : List<Vector>, ICloneable
    {
        #region Constructors
        public VectorCollection() {}

        public VectorCollection(int capacity) : base(capacity) {}

        public VectorCollection(IEnumerable<Vector> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator VectorCollection(Vector[] values)
        {
            if (values != null)
            {
                return new VectorCollection(values);
            }

            return new VectorCollection();
        }

        public static explicit operator Vector[](VectorCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (VectorCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            VectorCollection clone = new VectorCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Vector)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region WorkOrderStatusType Class
    #if (!OPCUA_EXCLUDE_WorkOrderStatusType)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class WorkOrderStatusType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public WorkOrderStatusType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_actor = null;
            m_timestamp = DateTime.MinValue;
            m_comment = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Actor", IsRequired = false, Order = 1)]
        public string Actor
        {
            get { return m_actor;  }
            set { m_actor = value; }
        }

        [DataMember(Name = "Timestamp", IsRequired = false, Order = 2)]
        public DateTime Timestamp
        {
            get { return m_timestamp;  }
            set { m_timestamp = value; }
        }

        [DataMember(Name = "Comment", IsRequired = false, Order = 3)]
        public LocalizedText Comment
        {
            get { return m_comment;  }
            set { m_comment = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.WorkOrderStatusType;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.WorkOrderStatusType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.WorkOrderStatusType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.WorkOrderStatusType;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            encoder.WriteString("Actor", Actor);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteLocalizedText("Comment", Comment);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            Actor = decoder.ReadString("Actor");
            Timestamp = decoder.ReadDateTime("Timestamp");
            Comment = decoder.ReadLocalizedText("Comment");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            WorkOrderStatusType value = encodeable as WorkOrderStatusType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_actor, value.m_actor)) return false;
            if (!Utils.IsEqual(m_timestamp, value.m_timestamp)) return false;
            if (!Utils.IsEqual(m_comment, value.m_comment)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (WorkOrderStatusType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WorkOrderStatusType clone = (WorkOrderStatusType)base.MemberwiseClone();

            clone.m_actor = (string)Utils.Clone(this.m_actor);
            clone.m_timestamp = (DateTime)Utils.Clone(this.m_timestamp);
            clone.m_comment = (LocalizedText)Utils.Clone(this.m_comment);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_actor;
        private DateTime m_timestamp;
        private LocalizedText m_comment;
        #endregion
    }

    #region WorkOrderStatusTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfWorkOrderStatusType", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "WorkOrderStatusType")]
    public partial class WorkOrderStatusTypeCollection : List<WorkOrderStatusType>, ICloneable
    {
        #region Constructors
        public WorkOrderStatusTypeCollection() {}

        public WorkOrderStatusTypeCollection(int capacity) : base(capacity) {}

        public WorkOrderStatusTypeCollection(IEnumerable<WorkOrderStatusType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator WorkOrderStatusTypeCollection(WorkOrderStatusType[] values)
        {
            if (values != null)
            {
                return new WorkOrderStatusTypeCollection(values);
            }

            return new WorkOrderStatusTypeCollection();
        }

        public static explicit operator WorkOrderStatusType[](WorkOrderStatusTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (WorkOrderStatusTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WorkOrderStatusTypeCollection clone = new WorkOrderStatusTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((WorkOrderStatusType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region WorkOrderType Class
    #if (!OPCUA_EXCLUDE_WorkOrderType)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class WorkOrderType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public WorkOrderType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_iD = Uuid.Empty;
            m_assetID = null;
            m_startTime = DateTime.MinValue;
            m_statusComments = new WorkOrderStatusTypeCollection();
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public Uuid ID
        {
            get { return m_iD;  }
            set { m_iD = value; }
        }

        [DataMember(Name = "AssetID", IsRequired = false, Order = 2)]
        public string AssetID
        {
            get { return m_assetID;  }
            set { m_assetID = value; }
        }

        [DataMember(Name = "StartTime", IsRequired = false, Order = 3)]
        public DateTime StartTime
        {
            get { return m_startTime;  }
            set { m_startTime = value; }
        }

        /// <remarks />
        [DataMember(Name = "StatusComments", IsRequired = false, Order = 4)]
        public WorkOrderStatusTypeCollection StatusComments
        {
            get
            {
                return m_statusComments;
            }

            set
            {
                m_statusComments = value;

                if (value == null)
                {
                    m_statusComments = new WorkOrderStatusTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.WorkOrderType;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.WorkOrderType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.WorkOrderType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.WorkOrderType;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            encoder.WriteGuid("ID", ID);
            encoder.WriteString("AssetID", AssetID);
            encoder.WriteDateTime("StartTime", StartTime);
            encoder.WriteEncodeableArray("StatusComments", StatusComments.ToArray(), typeof(WorkOrderStatusType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            ID = decoder.ReadGuid("ID");
            AssetID = decoder.ReadString("AssetID");
            StartTime = decoder.ReadDateTime("StartTime");
            StatusComments = (WorkOrderStatusTypeCollection)decoder.ReadEncodeableArray("StatusComments", typeof(WorkOrderStatusType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            WorkOrderType value = encodeable as WorkOrderType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_iD, value.m_iD)) return false;
            if (!Utils.IsEqual(m_assetID, value.m_assetID)) return false;
            if (!Utils.IsEqual(m_startTime, value.m_startTime)) return false;
            if (!Utils.IsEqual(m_statusComments, value.m_statusComments)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (WorkOrderType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WorkOrderType clone = (WorkOrderType)base.MemberwiseClone();

            clone.m_iD = (Uuid)Utils.Clone(this.m_iD);
            clone.m_assetID = (string)Utils.Clone(this.m_assetID);
            clone.m_startTime = (DateTime)Utils.Clone(this.m_startTime);
            clone.m_statusComments = (WorkOrderStatusTypeCollection)Utils.Clone(this.m_statusComments);

            return clone;
        }
        #endregion

        #region Private Fields
        private Uuid m_iD;
        private string m_assetID;
        private DateTime m_startTime;
        private WorkOrderStatusTypeCollection m_statusComments;
        #endregion
    }

    #region WorkOrderTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfWorkOrderType", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "WorkOrderType")]
    public partial class WorkOrderTypeCollection : List<WorkOrderType>, ICloneable
    {
        #region Constructors
        public WorkOrderTypeCollection() {}

        public WorkOrderTypeCollection(int capacity) : base(capacity) {}

        public WorkOrderTypeCollection(IEnumerable<WorkOrderType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator WorkOrderTypeCollection(WorkOrderType[] values)
        {
            if (values != null)
            {
                return new WorkOrderTypeCollection(values);
            }

            return new WorkOrderTypeCollection();
        }

        public static explicit operator WorkOrderType[](WorkOrderTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (WorkOrderTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WorkOrderTypeCollection clone = new WorkOrderTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((WorkOrderType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ExtendedWorkOrderType Class
    #if (!OPCUA_EXCLUDE_ExtendedWorkOrderType)
    /// <exclude />
    [Flags]
    public enum ExtendedWorkOrderFields : uint
    {
        None = 0,
        ContactY = 0x1,
        ContactZ = 0x2,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class ExtendedWorkOrderType : DemoModel.WorkOrderType
    {
        #region Constructors
        public ExtendedWorkOrderType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_contactX = (uint)0;
            m_contactY = new StringCollection();
            m_contactZ = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public virtual uint EncodingMask { get; set; }

        [DataMember(Name = "ContactX", IsRequired = false, Order = 1)]
        public uint ContactX
        {
            get { return m_contactX;  }
            set { m_contactX = value; }
        }

        /// <remarks />
        [DataMember(Name = "ContactY", IsRequired = false, Order = 2)]
        public StringCollection ContactY
        {
            get
            {
                return m_contactY;
            }

            set
            {
                m_contactY = value;

                if (value == null)
                {
                    m_contactY = new StringCollection();
                }
            }
        }

        [DataMember(Name = "ContactZ", IsRequired = false, Order = 3)]
        public byte[] ContactZ
        {
            get { return m_contactZ;  }
            set { m_contactZ = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.ExtendedWorkOrderType;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.ExtendedWorkOrderType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.ExtendedWorkOrderType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.ExtendedWorkOrderType;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);
            encoder.PopNamespace();

            base.Encode(encoder);

            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            encoder.WriteUInt32("ContactX", ContactX);
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactY) != 0) encoder.WriteStringArray("ContactY", ContactY);
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactZ) != 0) encoder.WriteByteString("ContactZ", ContactZ);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            EncodingMask = decoder.ReadEncodingMask(m_FieldNames);
            decoder.PopNamespace();
                
            base.Decode(decoder);

            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            ContactX = decoder.ReadUInt32("ContactX");
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactY) != 0) ContactY = decoder.ReadStringArray("ContactY");
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactZ) != 0) ContactZ = decoder.ReadByteString("ContactZ");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ExtendedWorkOrderType value = encodeable as ExtendedWorkOrderType;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if (!Utils.IsEqual(m_contactX, value.m_contactX)) return false;
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactY) != 0) if (!Utils.IsEqual(m_contactY, value.m_contactY)) return false;
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactZ) != 0) if (!Utils.IsEqual(m_contactZ, value.m_contactZ)) return false;

            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (ExtendedWorkOrderType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExtendedWorkOrderType clone = (ExtendedWorkOrderType)base.MemberwiseClone();
                
            clone.EncodingMask = this.EncodingMask;
            clone.m_contactX = (uint)Utils.Clone(this.m_contactX);
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactY) != 0) clone.m_contactY = (StringCollection)Utils.Clone(this.m_contactY);
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactZ) != 0) clone.m_contactZ = (byte[])Utils.Clone(this.m_contactZ);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_contactX;
        private StringCollection m_contactY;
        private byte[] m_contactZ;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(ExtendedWorkOrderFields)).Where(x => x != nameof(ExtendedWorkOrderFields.None)).ToArray();
        #endregion
    }

    #region ExtendedWorkOrderTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfExtendedWorkOrderType", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "ExtendedWorkOrderType")]
    public partial class ExtendedWorkOrderTypeCollection : List<ExtendedWorkOrderType>, ICloneable
    {
        #region Constructors
        public ExtendedWorkOrderTypeCollection() {}

        public ExtendedWorkOrderTypeCollection(int capacity) : base(capacity) {}

        public ExtendedWorkOrderTypeCollection(IEnumerable<ExtendedWorkOrderType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator ExtendedWorkOrderTypeCollection(ExtendedWorkOrderType[] values)
        {
            if (values != null)
            {
                return new ExtendedWorkOrderTypeCollection(values);
            }

            return new ExtendedWorkOrderTypeCollection();
        }

        public static explicit operator ExtendedWorkOrderType[](ExtendedWorkOrderTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (ExtendedWorkOrderTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExtendedWorkOrderTypeCollection clone = new ExtendedWorkOrderTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExtendedWorkOrderType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PenultimateWorkOrderType Class
    #if (!OPCUA_EXCLUDE_PenultimateWorkOrderType)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class PenultimateWorkOrderType : DemoModel.ExtendedWorkOrderType
    {
        #region Constructors
        public PenultimateWorkOrderType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_address = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Address", IsRequired = false, Order = 1)]
        public string Address
        {
            get { return m_address;  }
            set { m_address = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PenultimateWorkOrderType;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PenultimateWorkOrderType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PenultimateWorkOrderType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.PenultimateWorkOrderType;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            encoder.WriteString("Address", Address);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            Address = decoder.ReadString("Address");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PenultimateWorkOrderType value = encodeable as PenultimateWorkOrderType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_address, value.m_address)) return false;

            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PenultimateWorkOrderType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PenultimateWorkOrderType clone = (PenultimateWorkOrderType)base.MemberwiseClone();

            clone.m_address = (string)Utils.Clone(this.m_address);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_address;
        #endregion
    }

    #region PenultimateWorkOrderTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfPenultimateWorkOrderType", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "PenultimateWorkOrderType")]
    public partial class PenultimateWorkOrderTypeCollection : List<PenultimateWorkOrderType>, ICloneable
    {
        #region Constructors
        public PenultimateWorkOrderTypeCollection() {}

        public PenultimateWorkOrderTypeCollection(int capacity) : base(capacity) {}

        public PenultimateWorkOrderTypeCollection(IEnumerable<PenultimateWorkOrderType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator PenultimateWorkOrderTypeCollection(PenultimateWorkOrderType[] values)
        {
            if (values != null)
            {
                return new PenultimateWorkOrderTypeCollection(values);
            }

            return new PenultimateWorkOrderTypeCollection();
        }

        public static explicit operator PenultimateWorkOrderType[](PenultimateWorkOrderTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (PenultimateWorkOrderTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PenultimateWorkOrderTypeCollection clone = new PenultimateWorkOrderTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PenultimateWorkOrderType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region FinalWorkOrderType Class
    #if (!OPCUA_EXCLUDE_FinalWorkOrderType)
    /// <exclude />
    [Flags]
    public enum FinalWorkOrderFields : uint
    {
        None = 0,
        ContactY = 0x1,
        ContactZ = 0x2,
        Phone = 0x4,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class FinalWorkOrderType : DemoModel.PenultimateWorkOrderType
    {
        #region Constructors
        public FinalWorkOrderType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_phone = null;
            m_email = null;
        }
        #endregion

        #region Public Properties
        
        [DataMember(Name = "Phone", IsRequired = false, Order = 1)]
        public string Phone
        {
            get { return m_phone;  }
            set { m_phone = value; }
        }

        [DataMember(Name = "Email", IsRequired = false, Order = 2)]
        public string Email
        {
            get { return m_email;  }
            set { m_email = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.FinalWorkOrderType;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.FinalWorkOrderType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.FinalWorkOrderType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.FinalWorkOrderType;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            
            encoder.PopNamespace();

            base.Encode(encoder);

            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) encoder.WriteString("Phone", Phone);
            encoder.WriteString("Email", Email);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            
            decoder.PopNamespace();
                
            base.Decode(decoder);

            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) Phone = decoder.ReadString("Phone");
            Email = decoder.ReadString("Email");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            FinalWorkOrderType value = encodeable as FinalWorkOrderType;

            if (value == null)
            {
                return false;
            }

            

            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) if (!Utils.IsEqual(m_phone, value.m_phone)) return false;
            if (!Utils.IsEqual(m_email, value.m_email)) return false;

            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (FinalWorkOrderType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FinalWorkOrderType clone = (FinalWorkOrderType)base.MemberwiseClone();
                
            
            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) clone.m_phone = (string)Utils.Clone(this.m_phone);
            clone.m_email = (string)Utils.Clone(this.m_email);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_phone;
        private string m_email;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(FinalWorkOrderFields)).Where(x => x != nameof(FinalWorkOrderFields.None)).ToArray();
        #endregion
    }

    #region FinalWorkOrderTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfFinalWorkOrderType", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "FinalWorkOrderType")]
    public partial class FinalWorkOrderTypeCollection : List<FinalWorkOrderType>, ICloneable
    {
        #region Constructors
        public FinalWorkOrderTypeCollection() {}

        public FinalWorkOrderTypeCollection(int capacity) : base(capacity) {}

        public FinalWorkOrderTypeCollection(IEnumerable<FinalWorkOrderType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator FinalWorkOrderTypeCollection(FinalWorkOrderType[] values)
        {
            if (values != null)
            {
                return new FinalWorkOrderTypeCollection(values);
            }

            return new FinalWorkOrderTypeCollection();
        }

        public static explicit operator FinalWorkOrderType[](FinalWorkOrderTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (FinalWorkOrderTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FinalWorkOrderTypeCollection clone = new FinalWorkOrderTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FinalWorkOrderType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SampleUnion Class
    #if (!OPCUA_EXCLUDE_SampleUnion)
    /// <exclude />
    public enum SampleUnionFields : uint
    {
        None = 0,
        FieldX = 1,
        FieldY = 2,
        FieldZ = 3
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class SampleUnion : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public SampleUnion()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            SwitchField = SampleUnionFields.None;
            m_fieldX = (uint)0;
            m_fieldY = new StringCollection();
            m_fieldZ = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public SampleUnionFields SwitchField { get; set; }

        [DataMember(Name = "FieldX", IsRequired = false, Order = 1)]
        public uint FieldX
        {
            get { return m_fieldX;  }
            set { m_fieldX = value; }
        }

        /// <remarks />
        [DataMember(Name = "FieldY", IsRequired = false, Order = 2)]
        public StringCollection FieldY
        {
            get
            {
                return m_fieldY;
            }

            set
            {
                m_fieldY = value;

                if (value == null)
                {
                    m_fieldY = new StringCollection();
                }
            }
        }

        [DataMember(Name = "FieldZ", IsRequired = false, Order = 3)]
        public byte[] FieldZ
        {
            get { return m_fieldZ;  }
            set { m_fieldZ = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.SampleUnion;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.SampleUnion_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.SampleUnion_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.SampleUnion;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            encoder.WriteSwitchField((uint)SwitchField, out var fieldName);

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionFields.FieldX: { encoder.WriteUInt32(fieldName ?? "FieldX", FieldX); break; }
                case SampleUnionFields.FieldY: { encoder.WriteStringArray(fieldName ?? "FieldY", FieldY); break; }
                case SampleUnionFields.FieldZ: { encoder.WriteByteString(fieldName ?? "FieldZ", FieldZ); break; }
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            SwitchField = (SampleUnionFields)decoder.ReadSwitchField(m_FieldNames, out var fieldName);

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionFields.FieldX: { FieldX = decoder.ReadUInt32(fieldName ?? "FieldX"); break; }
                case SampleUnionFields.FieldY: { FieldY = decoder.ReadStringArray(fieldName ?? "FieldY"); break; }
                case SampleUnionFields.FieldZ: { FieldZ = decoder.ReadByteString(fieldName ?? "FieldZ"); break; }
            }

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SampleUnion value = encodeable as SampleUnion;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionFields.FieldX: { if (!Utils.IsEqual(m_fieldX, value.m_fieldX)) return false; break; }
                case SampleUnionFields.FieldY: { if (!Utils.IsEqual(m_fieldY, value.m_fieldY)) return false; break; }
                case SampleUnionFields.FieldZ: { if (!Utils.IsEqual(m_fieldZ, value.m_fieldZ)) return false; break; }
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (SampleUnion)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleUnion clone = (SampleUnion)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionFields.FieldX: { clone.m_fieldX = (uint)Utils.Clone(this.m_fieldX); break; }
                case SampleUnionFields.FieldY: { clone.m_fieldY = (StringCollection)Utils.Clone(this.m_fieldY); break; }
                case SampleUnionFields.FieldZ: { clone.m_fieldZ = (byte[])Utils.Clone(this.m_fieldZ); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_fieldX;
        private StringCollection m_fieldY;
        private byte[] m_fieldZ;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(SampleUnionFields)).Where(x => x != nameof(SampleUnionFields.None)).ToArray();
        #endregion
    }

    #region SampleUnionCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfSampleUnion", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "SampleUnion")]
    public partial class SampleUnionCollection : List<SampleUnion>, ICloneable
    {
        #region Constructors
        public SampleUnionCollection() {}

        public SampleUnionCollection(int capacity) : base(capacity) {}

        public SampleUnionCollection(IEnumerable<SampleUnion> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator SampleUnionCollection(SampleUnion[] values)
        {
            if (values != null)
            {
                return new SampleUnionCollection(values);
            }

            return new SampleUnionCollection();
        }

        public static explicit operator SampleUnion[](SampleUnionCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (SampleUnionCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleUnionCollection clone = new SampleUnionCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SampleUnion)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SampleStructureWithOptionalFields Class
    #if (!OPCUA_EXCLUDE_SampleStructureWithOptionalFields)
    /// <exclude />
    [Flags]
    public enum SampleStructureWithOptionalFieldsFields : uint
    {
        None = 0,
        FieldY = 0x1,
        FieldZ = 0x2,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class SampleStructureWithOptionalFields : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public SampleStructureWithOptionalFields()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            EncodingMask = (uint)SampleStructureWithOptionalFieldsFields.None;
            m_fieldX = (uint)0;
            m_fieldY = new StringCollection();
            m_fieldZ = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public virtual uint EncodingMask { get; set; }

        [DataMember(Name = "FieldX", IsRequired = false, Order = 1)]
        public uint FieldX
        {
            get { return m_fieldX;  }
            set { m_fieldX = value; }
        }

        /// <remarks />
        [DataMember(Name = "FieldY", IsRequired = false, Order = 2)]
        public StringCollection FieldY
        {
            get
            {
                return m_fieldY;
            }

            set
            {
                m_fieldY = value;

                if (value == null)
                {
                    m_fieldY = new StringCollection();
                }
            }
        }

        [DataMember(Name = "FieldZ", IsRequired = false, Order = 3)]
        public byte[] FieldZ
        {
            get { return m_fieldZ;  }
            set { m_fieldZ = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.SampleStructureWithOptionalFields;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.SampleStructureWithOptionalFields_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.SampleStructureWithOptionalFields_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.SampleStructureWithOptionalFields;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);

            encoder.WriteUInt32("FieldX", FieldX);
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldY) != 0) encoder.WriteStringArray("FieldY", FieldY);
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldZ) != 0) encoder.WriteByteString("FieldZ", FieldZ);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            EncodingMask = decoder.ReadEncodingMask(m_FieldNames);

            FieldX = decoder.ReadUInt32("FieldX");
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldY) != 0) FieldY = decoder.ReadStringArray("FieldY");
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldZ) != 0) FieldZ = decoder.ReadByteString("FieldZ");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SampleStructureWithOptionalFields value = encodeable as SampleStructureWithOptionalFields;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if (!Utils.IsEqual(m_fieldX, value.m_fieldX)) return false;
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldY) != 0) if (!Utils.IsEqual(m_fieldY, value.m_fieldY)) return false;
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldZ) != 0) if (!Utils.IsEqual(m_fieldZ, value.m_fieldZ)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (SampleStructureWithOptionalFields)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleStructureWithOptionalFields clone = (SampleStructureWithOptionalFields)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            clone.m_fieldX = (uint)Utils.Clone(this.m_fieldX);
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldY) != 0) clone.m_fieldY = (StringCollection)Utils.Clone(this.m_fieldY);
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldZ) != 0) clone.m_fieldZ = (byte[])Utils.Clone(this.m_fieldZ);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_fieldX;
        private StringCollection m_fieldY;
        private byte[] m_fieldZ;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(SampleStructureWithOptionalFieldsFields)).Where(x => x != nameof(SampleStructureWithOptionalFieldsFields.None)).ToArray();
        #endregion
    }

    #region SampleStructureWithOptionalFieldsCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfSampleStructureWithOptionalFields", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "SampleStructureWithOptionalFields")]
    public partial class SampleStructureWithOptionalFieldsCollection : List<SampleStructureWithOptionalFields>, ICloneable
    {
        #region Constructors
        public SampleStructureWithOptionalFieldsCollection() {}

        public SampleStructureWithOptionalFieldsCollection(int capacity) : base(capacity) {}

        public SampleStructureWithOptionalFieldsCollection(IEnumerable<SampleStructureWithOptionalFields> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator SampleStructureWithOptionalFieldsCollection(SampleStructureWithOptionalFields[] values)
        {
            if (values != null)
            {
                return new SampleStructureWithOptionalFieldsCollection(values);
            }

            return new SampleStructureWithOptionalFieldsCollection();
        }

        public static explicit operator SampleStructureWithOptionalFields[](SampleStructureWithOptionalFieldsCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (SampleStructureWithOptionalFieldsCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleStructureWithOptionalFieldsCollection clone = new SampleStructureWithOptionalFieldsCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SampleStructureWithOptionalFields)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SampleUnionAllowSubtypes Class
    #if (!OPCUA_EXCLUDE_SampleUnionAllowSubtypes)
    /// <exclude />
    public enum SampleUnionAllowSubtypesFields : uint
    {
        None = 0,
        FieldX = 1,
        FieldY = 2
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class SampleUnionAllowSubtypes : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public SampleUnionAllowSubtypes()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            SwitchField = SampleUnionAllowSubtypesFields.None;
            m_fieldX = null;
            m_fieldY = new WorkOrderStatusType();
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public SampleUnionAllowSubtypesFields SwitchField { get; set; }

        [DataMember(Name = "FieldX", IsRequired = false, Order = 1)]
        public ExtensionObject FieldX
        {
            get { return m_fieldX;  }
            set { m_fieldX = value; }
        }

        /// <remarks />
        [DataMember(Name = "FieldY", IsRequired = false, Order = 2)]
        public WorkOrderStatusType FieldY
        {
            get
            {
                return m_fieldY;
            }

            set
            {
                m_fieldY = value;

                if (value == null)
                {
                    m_fieldY = new WorkOrderStatusType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.SampleUnionAllowSubtypes;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.SampleUnionAllowSubtypes_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.SampleUnionAllowSubtypes_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.SampleUnionAllowSubtypes;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            encoder.WriteSwitchField((uint)SwitchField, out var fieldName);

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionAllowSubtypesFields.FieldX: { encoder.WriteExtensionObject(fieldName ?? "FieldX", FieldX); break; }
                case SampleUnionAllowSubtypesFields.FieldY: { encoder.WriteEncodeable(fieldName ?? "FieldY", FieldY, typeof(WorkOrderStatusType)); break; }
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            SwitchField = (SampleUnionAllowSubtypesFields)decoder.ReadSwitchField(m_FieldNames, out var fieldName);

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionAllowSubtypesFields.FieldX: { FieldX = decoder.ReadExtensionObject(fieldName ?? "FieldX"); break; }
                case SampleUnionAllowSubtypesFields.FieldY: { FieldY = (WorkOrderStatusType)decoder.ReadEncodeable(fieldName ?? "FieldY", typeof(WorkOrderStatusType)); break; }
            }

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SampleUnionAllowSubtypes value = encodeable as SampleUnionAllowSubtypes;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionAllowSubtypesFields.FieldX: { if (!Utils.IsEqual(m_fieldX, value.m_fieldX)) return false; break; }
                case SampleUnionAllowSubtypesFields.FieldY: { if (!Utils.IsEqual(m_fieldY, value.m_fieldY)) return false; break; }
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (SampleUnionAllowSubtypes)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleUnionAllowSubtypes clone = (SampleUnionAllowSubtypes)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case SampleUnionAllowSubtypesFields.FieldX: { clone.m_fieldX = (ExtensionObject)Utils.Clone(this.m_fieldX); break; }
                case SampleUnionAllowSubtypesFields.FieldY: { clone.m_fieldY = (WorkOrderStatusType)Utils.Clone(this.m_fieldY); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private ExtensionObject m_fieldX;
        private WorkOrderStatusType m_fieldY;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(SampleUnionAllowSubtypesFields)).Where(x => x != nameof(SampleUnionAllowSubtypesFields.None)).ToArray();
        #endregion
    }

    #region SampleUnionAllowSubtypesCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfSampleUnionAllowSubtypes", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "SampleUnionAllowSubtypes")]
    public partial class SampleUnionAllowSubtypesCollection : List<SampleUnionAllowSubtypes>, ICloneable
    {
        #region Constructors
        public SampleUnionAllowSubtypesCollection() {}

        public SampleUnionAllowSubtypesCollection(int capacity) : base(capacity) {}

        public SampleUnionAllowSubtypesCollection(IEnumerable<SampleUnionAllowSubtypes> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator SampleUnionAllowSubtypesCollection(SampleUnionAllowSubtypes[] values)
        {
            if (values != null)
            {
                return new SampleUnionAllowSubtypesCollection(values);
            }

            return new SampleUnionAllowSubtypesCollection();
        }

        public static explicit operator SampleUnionAllowSubtypes[](SampleUnionAllowSubtypesCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (SampleUnionAllowSubtypesCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleUnionAllowSubtypesCollection clone = new SampleUnionAllowSubtypesCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SampleUnionAllowSubtypes)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SampleStructureAllowSubtypes Class
    #if (!OPCUA_EXCLUDE_SampleStructureAllowSubtypes)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class SampleStructureAllowSubtypes : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public SampleStructureAllowSubtypes()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_fieldX = null;
            m_fieldY = new ExtensionObjectCollection();
            m_fieldZ = Variant.Null;
            m_fieldW = new WorkOrderStatusType();
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "FieldX", IsRequired = false, Order = 1)]
        public ExtensionObject FieldX
        {
            get { return m_fieldX;  }
            set { m_fieldX = value; }
        }

        [DataMember(Name = "FieldY", IsRequired = false, Order = 2)]
        public ExtensionObjectCollection FieldY
        {
            get { return m_fieldY;  }
            set { m_fieldY = value; }
        }

        [DataMember(Name = "FieldZ", IsRequired = false, Order = 3)]
        public Variant FieldZ
        {
            get { return m_fieldZ;  }
            set { m_fieldZ = value; }
        }

        /// <remarks />
        [DataMember(Name = "FieldW", IsRequired = false, Order = 4)]
        public WorkOrderStatusType FieldW
        {
            get
            {
                return m_fieldW;
            }

            set
            {
                m_fieldW = value;

                if (value == null)
                {
                    m_fieldW = new WorkOrderStatusType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.SampleStructureAllowSubtypes;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.SampleStructureAllowSubtypes_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.SampleStructureAllowSubtypes_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.SampleStructureAllowSubtypes;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            encoder.WriteExtensionObject("FieldX", FieldX);
            encoder.WriteExtensionObjectArray("FieldY", FieldY);
            encoder.WriteVariant("FieldZ", FieldZ);
            encoder.WriteEncodeable("FieldW", FieldW, typeof(WorkOrderStatusType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            FieldX = decoder.ReadExtensionObject("FieldX");
            FieldY = decoder.ReadExtensionObjectArray("FieldY");
            FieldZ = decoder.ReadVariant("FieldZ");
            FieldW = (WorkOrderStatusType)decoder.ReadEncodeable("FieldW", typeof(WorkOrderStatusType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SampleStructureAllowSubtypes value = encodeable as SampleStructureAllowSubtypes;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_fieldX, value.m_fieldX)) return false;
            if (!Utils.IsEqual(m_fieldY, value.m_fieldY)) return false;
            if (!Utils.IsEqual(m_fieldZ, value.m_fieldZ)) return false;
            if (!Utils.IsEqual(m_fieldW, value.m_fieldW)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (SampleStructureAllowSubtypes)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleStructureAllowSubtypes clone = (SampleStructureAllowSubtypes)base.MemberwiseClone();

            clone.m_fieldX = (ExtensionObject)Utils.Clone(this.m_fieldX);
            clone.m_fieldY = (ExtensionObjectCollection)Utils.Clone(this.m_fieldY);
            clone.m_fieldZ = (Variant)Utils.Clone(this.m_fieldZ);
            clone.m_fieldW = (WorkOrderStatusType)Utils.Clone(this.m_fieldW);

            return clone;
        }
        #endregion

        #region Private Fields
        private ExtensionObject m_fieldX;
        private ExtensionObjectCollection m_fieldY;
        private Variant m_fieldZ;
        private WorkOrderStatusType m_fieldW;
        #endregion
    }

    #region SampleStructureAllowSubtypesCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfSampleStructureAllowSubtypes", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "SampleStructureAllowSubtypes")]
    public partial class SampleStructureAllowSubtypesCollection : List<SampleStructureAllowSubtypes>, ICloneable
    {
        #region Constructors
        public SampleStructureAllowSubtypesCollection() {}

        public SampleStructureAllowSubtypesCollection(int capacity) : base(capacity) {}

        public SampleStructureAllowSubtypesCollection(IEnumerable<SampleStructureAllowSubtypes> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator SampleStructureAllowSubtypesCollection(SampleStructureAllowSubtypes[] values)
        {
            if (values != null)
            {
                return new SampleStructureAllowSubtypesCollection(values);
            }

            return new SampleStructureAllowSubtypesCollection();
        }

        public static explicit operator SampleStructureAllowSubtypes[](SampleStructureAllowSubtypesCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (SampleStructureAllowSubtypesCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleStructureAllowSubtypesCollection clone = new SampleStructureAllowSubtypesCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SampleStructureAllowSubtypes)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region Person Class
    #if (!OPCUA_EXCLUDE_Person)
    /// <exclude />
    [Flags]
    public enum PersonFields : uint
    {
        None = 0,
        LastName = 0x1,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class Person : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public Person()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            EncodingMask = (uint)PersonFields.None;
            m_lastName = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public virtual uint EncodingMask { get; set; }

        [DataMember(Name = "LastName", IsRequired = false, Order = 1)]
        public string LastName
        {
            get { return m_lastName;  }
            set { m_lastName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.Person;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.Person_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.Person_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.Person;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);

            if ((EncodingMask & (uint)PersonFields.LastName) != 0) encoder.WriteString("LastName", LastName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            EncodingMask = decoder.ReadEncodingMask(m_FieldNames);

            if ((EncodingMask & (uint)PersonFields.LastName) != 0) LastName = decoder.ReadString("LastName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Person value = encodeable as Person;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if ((EncodingMask & (uint)PersonFields.LastName) != 0) if (!Utils.IsEqual(m_lastName, value.m_lastName)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (Person)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Person clone = (Person)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            if ((EncodingMask & (uint)PersonFields.LastName) != 0) clone.m_lastName = (string)Utils.Clone(this.m_lastName);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_lastName;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(PersonFields)).Where(x => x != nameof(PersonFields.None)).ToArray();
        #endregion
    }

    #region PersonCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfPerson", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "Person")]
    public partial class PersonCollection : List<Person>, ICloneable
    {
        #region Constructors
        public PersonCollection() {}

        public PersonCollection(int capacity) : base(capacity) {}

        public PersonCollection(IEnumerable<Person> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator PersonCollection(Person[] values)
        {
            if (values != null)
            {
                return new PersonCollection(values);
            }

            return new PersonCollection();
        }

        public static explicit operator Person[](PersonCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (PersonCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PersonCollection clone = new PersonCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Person)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region Student Class
    #if (!OPCUA_EXCLUDE_Student)
    /// <exclude />
    [Flags]
    public enum StudentFields : uint
    {
        None = 0,
        LastName = 0x1,
        FirstName = 0x2,
        University = 0x4,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = DemoModel.Namespaces.DemoModelXsd)]
    public partial class Student : DemoModel.Person
    {
        #region Constructors
        public Student()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_firstName = null;
            m_university = null;
        }
        #endregion

        #region Public Properties
        
        [DataMember(Name = "FirstName", IsRequired = false, Order = 1)]
        public string FirstName
        {
            get { return m_firstName;  }
            set { m_firstName = value; }
        }

        [DataMember(Name = "University", IsRequired = false, Order = 2)]
        public string University
        {
            get { return m_university;  }
            set { m_university = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.Student;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.Student_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.Student_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.Student;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            
            encoder.PopNamespace();

            base.Encode(encoder);

            encoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            if ((EncodingMask & (uint)StudentFields.FirstName) != 0) encoder.WriteString("FirstName", FirstName);
            if ((EncodingMask & (uint)StudentFields.University) != 0) encoder.WriteString("University", University);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);
            
            decoder.PopNamespace();
                
            base.Decode(decoder);

            decoder.PushNamespace(DemoModel.Namespaces.DemoModelXsd);

            if ((EncodingMask & (uint)StudentFields.FirstName) != 0) FirstName = decoder.ReadString("FirstName");
            if ((EncodingMask & (uint)StudentFields.University) != 0) University = decoder.ReadString("University");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Student value = encodeable as Student;

            if (value == null)
            {
                return false;
            }

            

            if ((EncodingMask & (uint)StudentFields.FirstName) != 0) if (!Utils.IsEqual(m_firstName, value.m_firstName)) return false;
            if ((EncodingMask & (uint)StudentFields.University) != 0) if (!Utils.IsEqual(m_university, value.m_university)) return false;

            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (Student)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Student clone = (Student)base.MemberwiseClone();
                
            
            if ((EncodingMask & (uint)StudentFields.FirstName) != 0) clone.m_firstName = (string)Utils.Clone(this.m_firstName);
            if ((EncodingMask & (uint)StudentFields.University) != 0) clone.m_university = (string)Utils.Clone(this.m_university);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_firstName;
        private string m_university;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(StudentFields)).Where(x => x != nameof(StudentFields.None)).ToArray();
        #endregion
    }

    #region StudentCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfStudent", Namespace = DemoModel.Namespaces.DemoModelXsd, ItemName = "Student")]
    public partial class StudentCollection : List<Student>, ICloneable
    {
        #region Constructors
        public StudentCollection() {}

        public StudentCollection(int capacity) : base(capacity) {}

        public StudentCollection(IEnumerable<Student> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator StudentCollection(Student[] values)
        {
            if (values != null)
            {
                return new StudentCollection(values);
            }

            return new StudentCollection();
        }

        public static explicit operator Student[](StudentCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (StudentCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            StudentCollection clone = new StudentCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Student)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}
