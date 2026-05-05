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
    #region TestAbstractStructure Class
    #if (!OPCUA_EXCLUDE_TestAbstractStructure)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestAbstractStructure : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public TestAbstractStructure()
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
            m_a = (short)0;
            m_b = (double)0;
            m_c = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public short A
        {
            get { return m_a;  }
            set { m_a = value; }
        }

        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public double B
        {
            get { return m_b;  }
            set { m_b = value; }
        }

        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public string C
        {
            get { return m_c;  }
            set { m_c = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.TestAbstractStructure;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.TestAbstractStructure_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.TestAbstractStructure_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.TestAbstractStructure;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteInt16("A", A);
            encoder.WriteDouble("B", B);
            encoder.WriteString("C", C);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            A = decoder.ReadInt16("A");
            B = decoder.ReadDouble("B");
            C = decoder.ReadString("C");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TestAbstractStructure value = encodeable as TestAbstractStructure;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if (!Utils.IsEqual(m_c, value.m_c)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TestAbstractStructure)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestAbstractStructure clone = (TestAbstractStructure)base.MemberwiseClone();

            clone.m_a = (short)Utils.Clone(this.m_a);
            clone.m_b = (double)Utils.Clone(this.m_b);
            clone.m_c = (string)Utils.Clone(this.m_c);

            return clone;
        }
        #endregion

        #region Private Fields
        private short m_a;
        private double m_b;
        private string m_c;
        #endregion
    }

    #region TestAbstractStructureCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestAbstractStructure", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestAbstractStructure")]
    public partial class TestAbstractStructureCollection : List<TestAbstractStructure>, ICloneable
    {
        #region Constructors
        public TestAbstractStructureCollection() {}

        public TestAbstractStructureCollection(int capacity) : base(capacity) {}

        public TestAbstractStructureCollection(IEnumerable<TestAbstractStructure> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestAbstractStructureCollection(TestAbstractStructure[] values)
        {
            if (values != null)
            {
                return new TestAbstractStructureCollection(values);
            }

            return new TestAbstractStructureCollection();
        }

        public static explicit operator TestAbstractStructure[](TestAbstractStructureCollection values)
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
            return (TestAbstractStructureCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestAbstractStructureCollection clone = new TestAbstractStructureCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestAbstractStructure)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestConcreteStructure Class
    #if (!OPCUA_EXCLUDE_TestConcreteStructure)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestConcreteStructure : TestModel.TestAbstractStructure
    {
        #region Constructors
        public TestConcreteStructure()
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
            m_d = (short)0;
            m_e = (double)0;
            m_f = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "D", IsRequired = false, Order = 1)]
        public short D
        {
            get { return m_d;  }
            set { m_d = value; }
        }

        [DataMember(Name = "E", IsRequired = false, Order = 2)]
        public double E
        {
            get { return m_e;  }
            set { m_e = value; }
        }

        [DataMember(Name = "F", IsRequired = false, Order = 3)]
        public string F
        {
            get { return m_f;  }
            set { m_f = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.TestConcreteStructure;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.TestConcreteStructure_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.TestConcreteStructure_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.TestConcreteStructure;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteInt16("D", D);
            encoder.WriteDouble("E", E);
            encoder.WriteString("F", F);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            D = decoder.ReadInt16("D");
            E = decoder.ReadDouble("E");
            F = decoder.ReadString("F");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TestConcreteStructure value = encodeable as TestConcreteStructure;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_d, value.m_d)) return false;
            if (!Utils.IsEqual(m_e, value.m_e)) return false;
            if (!Utils.IsEqual(m_f, value.m_f)) return false;

            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (TestConcreteStructure)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestConcreteStructure clone = (TestConcreteStructure)base.MemberwiseClone();

            clone.m_d = (short)Utils.Clone(this.m_d);
            clone.m_e = (double)Utils.Clone(this.m_e);
            clone.m_f = (string)Utils.Clone(this.m_f);

            return clone;
        }
        #endregion

        #region Private Fields
        private short m_d;
        private double m_e;
        private string m_f;
        #endregion
    }

    #region TestConcreteStructureCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestConcreteStructure", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestConcreteStructure")]
    public partial class TestConcreteStructureCollection : List<TestConcreteStructure>, ICloneable
    {
        #region Constructors
        public TestConcreteStructureCollection() {}

        public TestConcreteStructureCollection(int capacity) : base(capacity) {}

        public TestConcreteStructureCollection(IEnumerable<TestConcreteStructure> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestConcreteStructureCollection(TestConcreteStructure[] values)
        {
            if (values != null)
            {
                return new TestConcreteStructureCollection(values);
            }

            return new TestConcreteStructureCollection();
        }

        public static explicit operator TestConcreteStructure[](TestConcreteStructureCollection values)
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
            return (TestConcreteStructureCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestConcreteStructureCollection clone = new TestConcreteStructureCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestConcreteStructure)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestUnion Class
    #if (!OPCUA_EXCLUDE_TestUnion)
    /// <exclude />
    public enum TestUnionFields : uint
    {
        None = 0,
        A = 1,
        B = 2,
        C = 3
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestUnion : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public TestUnion()
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
            SwitchField = TestUnionFields.None;
            m_a = (short)0;
            m_b = (double)0;
            m_c = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public TestUnionFields SwitchField { get; set; }

        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public short A
        {
            get { return m_a;  }
            set { m_a = value; }
        }

        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public double B
        {
            get { return m_b;  }
            set { m_b = value; }
        }

        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public string C
        {
            get { return m_c;  }
            set { m_c = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.TestUnion;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.TestUnion_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.TestUnion_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.TestUnion;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            encoder.WriteSwitchField((uint)SwitchField, out var fieldName);

            switch (SwitchField)
            {
                default: { break; }
                case TestUnionFields.A: { encoder.WriteInt16(fieldName ?? "A", A); break; }
                case TestUnionFields.B: { encoder.WriteDouble(fieldName ?? "B", B); break; }
                case TestUnionFields.C: { encoder.WriteString(fieldName ?? "C", C); break; }
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            SwitchField = (TestUnionFields)decoder.ReadSwitchField(m_FieldNames, out var fieldName);

            switch (SwitchField)
            {
                default: { break; }
                case TestUnionFields.A: { A = decoder.ReadInt16(fieldName ?? "A"); break; }
                case TestUnionFields.B: { B = decoder.ReadDouble(fieldName ?? "B"); break; }
                case TestUnionFields.C: { C = decoder.ReadString(fieldName ?? "C"); break; }
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

            TestUnion value = encodeable as TestUnion;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case TestUnionFields.A: { if (!Utils.IsEqual(m_a, value.m_a)) return false; break; }
                case TestUnionFields.B: { if (!Utils.IsEqual(m_b, value.m_b)) return false; break; }
                case TestUnionFields.C: { if (!Utils.IsEqual(m_c, value.m_c)) return false; break; }
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TestUnion)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestUnion clone = (TestUnion)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case TestUnionFields.A: { clone.m_a = (short)Utils.Clone(this.m_a); break; }
                case TestUnionFields.B: { clone.m_b = (double)Utils.Clone(this.m_b); break; }
                case TestUnionFields.C: { clone.m_c = (string)Utils.Clone(this.m_c); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private short m_a;
        private double m_b;
        private string m_c;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(TestUnionFields)).Where(x => x != nameof(TestUnionFields.None)).ToArray();
        #endregion
    }

    #region TestUnionCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestUnion", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestUnion")]
    public partial class TestUnionCollection : List<TestUnion>, ICloneable
    {
        #region Constructors
        public TestUnionCollection() {}

        public TestUnionCollection(int capacity) : base(capacity) {}

        public TestUnionCollection(IEnumerable<TestUnion> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestUnionCollection(TestUnion[] values)
        {
            if (values != null)
            {
                return new TestUnionCollection(values);
            }

            return new TestUnionCollection();
        }

        public static explicit operator TestUnion[](TestUnionCollection values)
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
            return (TestUnionCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestUnionCollection clone = new TestUnionCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestUnion)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestOptionalFields Class
    #if (!OPCUA_EXCLUDE_TestOptionalFields)
    /// <exclude />
    [Flags]
    public enum TestOptionalFieldsFields : uint
    {
        None = 0,
        A = 0x1,
        B = 0x2,
        C = 0x4,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestOptionalFields : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public TestOptionalFields()
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
            EncodingMask = (uint)TestOptionalFieldsFields.None;
            m_a = (short)0;
            m_b = (double)0;
            m_c = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public virtual uint EncodingMask { get; set; }

        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public short A
        {
            get { return m_a;  }
            set { m_a = value; }
        }

        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public double B
        {
            get { return m_b;  }
            set { m_b = value; }
        }

        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public string C
        {
            get { return m_c;  }
            set { m_c = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.TestOptionalFields;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.TestOptionalFields_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.TestOptionalFields_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.TestOptionalFields;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);

            if ((EncodingMask & (uint)TestOptionalFieldsFields.A) != 0) encoder.WriteInt16("A", A);
            if ((EncodingMask & (uint)TestOptionalFieldsFields.B) != 0) encoder.WriteDouble("B", B);
            if ((EncodingMask & (uint)TestOptionalFieldsFields.C) != 0) encoder.WriteString("C", C);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            EncodingMask = decoder.ReadEncodingMask(m_FieldNames);

            if ((EncodingMask & (uint)TestOptionalFieldsFields.A) != 0) A = decoder.ReadInt16("A");
            if ((EncodingMask & (uint)TestOptionalFieldsFields.B) != 0) B = decoder.ReadDouble("B");
            if ((EncodingMask & (uint)TestOptionalFieldsFields.C) != 0) C = decoder.ReadString("C");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TestOptionalFields value = encodeable as TestOptionalFields;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if ((EncodingMask & (uint)TestOptionalFieldsFields.A) != 0) if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if ((EncodingMask & (uint)TestOptionalFieldsFields.B) != 0) if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if ((EncodingMask & (uint)TestOptionalFieldsFields.C) != 0) if (!Utils.IsEqual(m_c, value.m_c)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TestOptionalFields)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestOptionalFields clone = (TestOptionalFields)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            if ((EncodingMask & (uint)TestOptionalFieldsFields.A) != 0) clone.m_a = (short)Utils.Clone(this.m_a);
            if ((EncodingMask & (uint)TestOptionalFieldsFields.B) != 0) clone.m_b = (double)Utils.Clone(this.m_b);
            if ((EncodingMask & (uint)TestOptionalFieldsFields.C) != 0) clone.m_c = (string)Utils.Clone(this.m_c);

            return clone;
        }
        #endregion

        #region Private Fields
        private short m_a;
        private double m_b;
        private string m_c;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(TestOptionalFieldsFields)).Where(x => x != nameof(TestOptionalFieldsFields.None)).ToArray();
        #endregion
    }

    #region TestOptionalFieldsCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestOptionalFields", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestOptionalFields")]
    public partial class TestOptionalFieldsCollection : List<TestOptionalFields>, ICloneable
    {
        #region Constructors
        public TestOptionalFieldsCollection() {}

        public TestOptionalFieldsCollection(int capacity) : base(capacity) {}

        public TestOptionalFieldsCollection(IEnumerable<TestOptionalFields> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestOptionalFieldsCollection(TestOptionalFields[] values)
        {
            if (values != null)
            {
                return new TestOptionalFieldsCollection(values);
            }

            return new TestOptionalFieldsCollection();
        }

        public static explicit operator TestOptionalFields[](TestOptionalFieldsCollection values)
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
            return (TestOptionalFieldsCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestOptionalFieldsCollection clone = new TestOptionalFieldsCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestOptionalFields)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_TestEnumeration)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    
    public enum TestEnumeration
    {
        [EnumMember(Value = "Invalid_0")]
        Invalid = 0,

        [EnumMember(Value = "Red_2")]
        Red = 2,

        [EnumMember(Value = "Green_4")]
        Green = 4,

        [EnumMember(Value = "Blue_6")]
        Blue = 6,
    }

    #region TestEnumerationCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestEnumeration", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestEnumeration")]
    public partial class TestEnumerationCollection : List<TestEnumeration>, ICloneable
    {
        #region Constructors
        public TestEnumerationCollection() {}

        public TestEnumerationCollection(int capacity) : base(capacity) {}

        public TestEnumerationCollection(IEnumerable<TestEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestEnumerationCollection(TestEnumeration[] values)
        {
            if (values != null)
            {
                return new TestEnumerationCollection(values);
            }

            return new TestEnumerationCollection();
        }

        public static explicit operator TestEnumeration[](TestEnumerationCollection values)
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
            return (TestEnumerationCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestEnumerationCollection clone = new TestEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestOptionSet Enumeration
    #if (!OPCUA_EXCLUDE_TestOptionSet)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    [Flags]
    public enum TestOptionSet : UInt64
    {
        [EnumMember(Value = "None_0")]
        None = 0,

        [EnumMember(Value = "A_1")]
        A = 1,

        [EnumMember(Value = "B_2")]
        B = 2,

        [EnumMember(Value = "C_4")]
        C = 4,

        [EnumMember(Value = "D_8")]
        D = 8,

        [EnumMember(Value = "E_16")]
        E = 16,

        [EnumMember(Value = "F_32")]
        F = 32,

        [EnumMember(Value = "G_64")]
        G = 64,

        [EnumMember(Value = "H_128")]
        H = 128,

        [EnumMember(Value = "I_256")]
        I = 256,

        [EnumMember(Value = "J_512")]
        J = 512,

        [EnumMember(Value = "K_1024")]
        K = 1024,

        [EnumMember(Value = "L_2048")]
        L = 2048,

        [EnumMember(Value = "M_4096")]
        M = 4096,

        [EnumMember(Value = "N_8192")]
        N = 8192,

        [EnumMember(Value = "O_16384")]
        O = 16384,

        [EnumMember(Value = "P_32768")]
        P = 32768,

        [EnumMember(Value = "Q_65536")]
        Q = 65536,

        [EnumMember(Value = "R_131072")]
        R = 131072,

        [EnumMember(Value = "S_262144")]
        S = 262144,

        [EnumMember(Value = "T_524288")]
        T = 524288,

        [EnumMember(Value = "U_1048576")]
        U = 1048576,

        [EnumMember(Value = "V_2097152")]
        V = 2097152,

        [EnumMember(Value = "W_4194304")]
        W = 4194304,

        [EnumMember(Value = "X_8388608")]
        X = 8388608,

        [EnumMember(Value = "Z_16777216")]
        Z = 16777216,

        [EnumMember(Value = "A1_33554432")]
        A1 = 33554432,

        [EnumMember(Value = "B1_67108864")]
        B1 = 67108864,

        [EnumMember(Value = "C1_134217728")]
        C1 = 134217728,

        [EnumMember(Value = "D1_268435456")]
        D1 = 268435456,

        [EnumMember(Value = "E1_536870912")]
        E1 = 536870912,

        [EnumMember(Value = "F1_1073741824")]
        F1 = 1073741824,

        [EnumMember(Value = "G1_2147483648")]
        G1 = 2147483648,

        [EnumMember(Value = "H1_4294967296")]
        H1 = 4294967296,

        [EnumMember(Value = "I1_8589934592")]
        I1 = 8589934592,
    }

    #region TestOptionSetCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestOptionSet", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestOptionSet")]
    public partial class TestOptionSetCollection : List<TestOptionSet>, ICloneable
    {
        #region Constructors
        public TestOptionSetCollection() {}

        public TestOptionSetCollection(int capacity) : base(capacity) {}

        public TestOptionSetCollection(IEnumerable<TestOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestOptionSetCollection(TestOptionSet[] values)
        {
            if (values != null)
            {
                return new TestOptionSetCollection(values);
            }

            return new TestOptionSetCollection();
        }

        public static explicit operator TestOptionSet[](TestOptionSetCollection values)
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
            return (TestOptionSetCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestOptionSetCollection clone = new TestOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestScalarStructure Class
    #if (!OPCUA_EXCLUDE_TestScalarStructure)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestScalarStructure : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public TestScalarStructure()
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
            m_a = true;
            m_b = (sbyte)0;
            m_c = (byte)0;
            m_d = (short)0;
            m_e = (ushort)0;
            m_f = (int)0;
            m_g = (uint)0;
            m_h = (long)0;
            m_i = (ulong)0;
            m_j = (float)0;
            m_k = (double)0;
            m_l = Uuid.Empty;
            m_m = DateTime.MinValue;
            m_n = null;
            m_o = null;
            m_p = null;
            m_q = null;
            m_r = null;
            m_s = null;
            m_t = StatusCodes.Good;
            m_u = null;
            m_v = Variant.Null;
            m_w = null;
            m_x = new TestConcreteStructure();
            m_y = TestEnumeration.Invalid;
            m_z = 0;
            m_a1 = new TestUnion();
            m_b1 = new TestOptionalFields();
            m_c1 = new DataValue();
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public bool A
        {
            get { return m_a;  }
            set { m_a = value; }
        }

        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public sbyte B
        {
            get { return m_b;  }
            set { m_b = value; }
        }

        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public byte C
        {
            get { return m_c;  }
            set { m_c = value; }
        }

        [DataMember(Name = "D", IsRequired = false, Order = 4)]
        public short D
        {
            get { return m_d;  }
            set { m_d = value; }
        }

        [DataMember(Name = "E", IsRequired = false, Order = 5)]
        public ushort E
        {
            get { return m_e;  }
            set { m_e = value; }
        }

        [DataMember(Name = "F", IsRequired = false, Order = 6)]
        public int F
        {
            get { return m_f;  }
            set { m_f = value; }
        }

        [DataMember(Name = "G", IsRequired = false, Order = 7)]
        public uint G
        {
            get { return m_g;  }
            set { m_g = value; }
        }

        [DataMember(Name = "H", IsRequired = false, Order = 8)]
        public long H
        {
            get { return m_h;  }
            set { m_h = value; }
        }

        [DataMember(Name = "I", IsRequired = false, Order = 9)]
        public ulong I
        {
            get { return m_i;  }
            set { m_i = value; }
        }

        [DataMember(Name = "J", IsRequired = false, Order = 10)]
        public float J
        {
            get { return m_j;  }
            set { m_j = value; }
        }

        [DataMember(Name = "K", IsRequired = false, Order = 11)]
        public double K
        {
            get { return m_k;  }
            set { m_k = value; }
        }

        [DataMember(Name = "L", IsRequired = false, Order = 12)]
        public Uuid L
        {
            get { return m_l;  }
            set { m_l = value; }
        }

        [DataMember(Name = "M", IsRequired = false, Order = 13)]
        public DateTime M
        {
            get { return m_m;  }
            set { m_m = value; }
        }

        [DataMember(Name = "N", IsRequired = false, Order = 14)]
        public string N
        {
            get { return m_n;  }
            set { m_n = value; }
        }

        [DataMember(Name = "O", IsRequired = false, Order = 15)]
        public byte[] O
        {
            get { return m_o;  }
            set { m_o = value; }
        }

        [DataMember(Name = "P", IsRequired = false, Order = 16)]
        public NodeId P
        {
            get { return m_p;  }
            set { m_p = value; }
        }

        [DataMember(Name = "Q", IsRequired = false, Order = 17)]
        public ExpandedNodeId Q
        {
            get { return m_q;  }
            set { m_q = value; }
        }

        [DataMember(Name = "R", IsRequired = false, Order = 18)]
        public QualifiedName R
        {
            get { return m_r;  }
            set { m_r = value; }
        }

        [DataMember(Name = "S", IsRequired = false, Order = 19)]
        public LocalizedText S
        {
            get { return m_s;  }
            set { m_s = value; }
        }

        [DataMember(Name = "T", IsRequired = false, Order = 20)]
        public StatusCode T
        {
            get { return m_t;  }
            set { m_t = value; }
        }

        [DataMember(Name = "U", IsRequired = false, Order = 21)]
        public XmlElement U
        {
            get { return m_u;  }
            set { m_u = value; }
        }

        [DataMember(Name = "V", IsRequired = false, Order = 22)]
        public Variant V
        {
            get { return m_v;  }
            set { m_v = value; }
        }

        [DataMember(Name = "W", IsRequired = false, Order = 23)]
        public ExtensionObject W
        {
            get { return m_w;  }
            set { m_w = value; }
        }

        /// <remarks />
        [DataMember(Name = "X", IsRequired = false, Order = 24)]
        public TestConcreteStructure X
        {
            get
            {
                return m_x;
            }

            set
            {
                m_x = value;

                if (value == null)
                {
                    m_x = new TestConcreteStructure();
                }
            }
        }

        [DataMember(Name = "Y", IsRequired = false, Order = 25)]
        public TestEnumeration Y
        {
            get { return m_y;  }
            set { m_y = value; }
        }

        [DataMember(Name = "Z", IsRequired = false, Order = 26)]
        public ulong Z
        {
            get { return m_z;  }
            set { m_z = value; }
        }

        /// <remarks />
        [DataMember(Name = "A1", IsRequired = false, Order = 27)]
        public TestUnion A1
        {
            get
            {
                return m_a1;
            }

            set
            {
                m_a1 = value;

                if (value == null)
                {
                    m_a1 = new TestUnion();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "B1", IsRequired = false, Order = 28)]
        public TestOptionalFields B1
        {
            get
            {
                return m_b1;
            }

            set
            {
                m_b1 = value;

                if (value == null)
                {
                    m_b1 = new TestOptionalFields();
                }
            }
        }

        [DataMember(Name = "C1", IsRequired = false, Order = 29)]
        public DataValue C1
        {
            get { return m_c1;  }
            set { m_c1 = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.TestScalarStructure;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.TestScalarStructure_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.TestScalarStructure_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.TestScalarStructure;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteBoolean("A", A);
            encoder.WriteSByte("B", B);
            encoder.WriteByte("C", C);
            encoder.WriteInt16("D", D);
            encoder.WriteUInt16("E", E);
            encoder.WriteInt32("F", F);
            encoder.WriteUInt32("G", G);
            encoder.WriteInt64("H", H);
            encoder.WriteUInt64("I", I);
            encoder.WriteFloat("J", J);
            encoder.WriteDouble("K", K);
            encoder.WriteGuid("L", L);
            encoder.WriteDateTime("M", M);
            encoder.WriteString("N", N);
            encoder.WriteByteString("O", O);
            encoder.WriteNodeId("P", P);
            encoder.WriteExpandedNodeId("Q", Q);
            encoder.WriteQualifiedName("R", R);
            encoder.WriteLocalizedText("S", S);
            encoder.WriteStatusCode("T", T);
            encoder.WriteXmlElement("U", U);
            encoder.WriteVariant("V", V);
            encoder.WriteExtensionObject("W", W);
            encoder.WriteEncodeable("X", X, typeof(TestConcreteStructure));
            encoder.WriteEnumerated("Y", Y);
            encoder.WriteUInt64("Z", Z);
            encoder.WriteEncodeable("A1", A1, typeof(TestUnion));
            encoder.WriteEncodeable("B1", B1, typeof(TestOptionalFields));
            encoder.WriteDataValue("C1", C1);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            A = decoder.ReadBoolean("A");
            B = decoder.ReadSByte("B");
            C = decoder.ReadByte("C");
            D = decoder.ReadInt16("D");
            E = decoder.ReadUInt16("E");
            F = decoder.ReadInt32("F");
            G = decoder.ReadUInt32("G");
            H = decoder.ReadInt64("H");
            I = decoder.ReadUInt64("I");
            J = decoder.ReadFloat("J");
            K = decoder.ReadDouble("K");
            L = decoder.ReadGuid("L");
            M = decoder.ReadDateTime("M");
            N = decoder.ReadString("N");
            O = decoder.ReadByteString("O");
            P = decoder.ReadNodeId("P");
            Q = decoder.ReadExpandedNodeId("Q");
            R = decoder.ReadQualifiedName("R");
            S = decoder.ReadLocalizedText("S");
            T = decoder.ReadStatusCode("T");
            U = decoder.ReadXmlElement("U");
            V = decoder.ReadVariant("V");
            W = decoder.ReadExtensionObject("W");
            X = (TestConcreteStructure)decoder.ReadEncodeable("X", typeof(TestConcreteStructure));
            Y = (TestEnumeration)decoder.ReadEnumerated("Y", typeof(TestEnumeration));
            Z = decoder.ReadUInt64("Z");
            A1 = (TestUnion)decoder.ReadEncodeable("A1", typeof(TestUnion));
            B1 = (TestOptionalFields)decoder.ReadEncodeable("B1", typeof(TestOptionalFields));
            C1 = decoder.ReadDataValue("C1");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TestScalarStructure value = encodeable as TestScalarStructure;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if (!Utils.IsEqual(m_c, value.m_c)) return false;
            if (!Utils.IsEqual(m_d, value.m_d)) return false;
            if (!Utils.IsEqual(m_e, value.m_e)) return false;
            if (!Utils.IsEqual(m_f, value.m_f)) return false;
            if (!Utils.IsEqual(m_g, value.m_g)) return false;
            if (!Utils.IsEqual(m_h, value.m_h)) return false;
            if (!Utils.IsEqual(m_i, value.m_i)) return false;
            if (!Utils.IsEqual(m_j, value.m_j)) return false;
            if (!Utils.IsEqual(m_k, value.m_k)) return false;
            if (!Utils.IsEqual(m_l, value.m_l)) return false;
            if (!Utils.IsEqual(m_m, value.m_m)) return false;
            if (!Utils.IsEqual(m_n, value.m_n)) return false;
            if (!Utils.IsEqual(m_o, value.m_o)) return false;
            if (!Utils.IsEqual(m_p, value.m_p)) return false;
            if (!Utils.IsEqual(m_q, value.m_q)) return false;
            if (!Utils.IsEqual(m_r, value.m_r)) return false;
            if (!Utils.IsEqual(m_s, value.m_s)) return false;
            if (!Utils.IsEqual(m_t, value.m_t)) return false;
            if (!Utils.IsEqual(m_u, value.m_u)) return false;
            if (!Utils.IsEqual(m_v, value.m_v)) return false;
            if (!Utils.IsEqual(m_w, value.m_w)) return false;
            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;
            if (!Utils.IsEqual(m_a1, value.m_a1)) return false;
            if (!Utils.IsEqual(m_b1, value.m_b1)) return false;
            if (!Utils.IsEqual(m_c1, value.m_c1)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TestScalarStructure)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestScalarStructure clone = (TestScalarStructure)base.MemberwiseClone();

            clone.m_a = (bool)Utils.Clone(this.m_a);
            clone.m_b = (sbyte)Utils.Clone(this.m_b);
            clone.m_c = (byte)Utils.Clone(this.m_c);
            clone.m_d = (short)Utils.Clone(this.m_d);
            clone.m_e = (ushort)Utils.Clone(this.m_e);
            clone.m_f = (int)Utils.Clone(this.m_f);
            clone.m_g = (uint)Utils.Clone(this.m_g);
            clone.m_h = (long)Utils.Clone(this.m_h);
            clone.m_i = (ulong)Utils.Clone(this.m_i);
            clone.m_j = (float)Utils.Clone(this.m_j);
            clone.m_k = (double)Utils.Clone(this.m_k);
            clone.m_l = (Uuid)Utils.Clone(this.m_l);
            clone.m_m = (DateTime)Utils.Clone(this.m_m);
            clone.m_n = (string)Utils.Clone(this.m_n);
            clone.m_o = (byte[])Utils.Clone(this.m_o);
            clone.m_p = (NodeId)Utils.Clone(this.m_p);
            clone.m_q = (ExpandedNodeId)Utils.Clone(this.m_q);
            clone.m_r = (QualifiedName)Utils.Clone(this.m_r);
            clone.m_s = (LocalizedText)Utils.Clone(this.m_s);
            clone.m_t = (StatusCode)Utils.Clone(this.m_t);
            clone.m_u = (XmlElement)Utils.Clone(this.m_u);
            clone.m_v = (Variant)Utils.Clone(this.m_v);
            clone.m_w = (ExtensionObject)Utils.Clone(this.m_w);
            clone.m_x = (TestConcreteStructure)Utils.Clone(this.m_x);
            clone.m_y = (TestEnumeration)Utils.Clone(this.m_y);
            clone.m_z = (ulong)Utils.Clone(this.m_z);
            clone.m_a1 = (TestUnion)Utils.Clone(this.m_a1);
            clone.m_b1 = (TestOptionalFields)Utils.Clone(this.m_b1);
            clone.m_c1 = (DataValue)Utils.Clone(this.m_c1);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_a;
        private sbyte m_b;
        private byte m_c;
        private short m_d;
        private ushort m_e;
        private int m_f;
        private uint m_g;
        private long m_h;
        private ulong m_i;
        private float m_j;
        private double m_k;
        private Uuid m_l;
        private DateTime m_m;
        private string m_n;
        private byte[] m_o;
        private NodeId m_p;
        private ExpandedNodeId m_q;
        private QualifiedName m_r;
        private LocalizedText m_s;
        private StatusCode m_t;
        private XmlElement m_u;
        private Variant m_v;
        private ExtensionObject m_w;
        private TestConcreteStructure m_x;
        private TestEnumeration m_y;
        private ulong m_z;
        private TestUnion m_a1;
        private TestOptionalFields m_b1;
        private DataValue m_c1;
        #endregion
    }

    #region TestScalarStructureCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestScalarStructure", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestScalarStructure")]
    public partial class TestScalarStructureCollection : List<TestScalarStructure>, ICloneable
    {
        #region Constructors
        public TestScalarStructureCollection() {}

        public TestScalarStructureCollection(int capacity) : base(capacity) {}

        public TestScalarStructureCollection(IEnumerable<TestScalarStructure> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestScalarStructureCollection(TestScalarStructure[] values)
        {
            if (values != null)
            {
                return new TestScalarStructureCollection(values);
            }

            return new TestScalarStructureCollection();
        }

        public static explicit operator TestScalarStructure[](TestScalarStructureCollection values)
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
            return (TestScalarStructureCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestScalarStructureCollection clone = new TestScalarStructureCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestScalarStructure)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestArrayStructure Class
    #if (!OPCUA_EXCLUDE_TestArrayStructure)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestArrayStructure : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public TestArrayStructure()
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
            m_a = new BooleanCollection();
            m_b = new SByteCollection();
            m_c = new ByteCollection();
            m_d = new Int16Collection();
            m_e = new UInt16Collection();
            m_f = new Int32Collection();
            m_g = new UInt32Collection();
            m_h = new Int64Collection();
            m_i = new UInt64Collection();
            m_j = new FloatCollection();
            m_k = new DoubleCollection();
            m_l = new UuidCollection();
            m_m = new DateTimeCollection();
            m_n = new StringCollection();
            m_o = new ByteStringCollection();
            m_p = new NodeIdCollection();
            m_q = new ExpandedNodeIdCollection();
            m_r = new QualifiedNameCollection();
            m_s = new LocalizedTextCollection();
            m_t = new StatusCodeCollection();
            m_u = new XmlElementCollection();
            m_v = new VariantCollection();
            m_w = new ExtensionObjectCollection();
            m_x = new TestConcreteStructureCollection();
            m_y = new TestEnumerationCollection();
            m_z = new UInt64Collection();
            m_a1 = new TestUnionCollection();
            m_b1 = new TestOptionalFieldsCollection();
            m_c1 = new DataValueCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public BooleanCollection A
        {
            get
            {
                return m_a;
            }

            set
            {
                m_a = value;

                if (value == null)
                {
                    m_a = new BooleanCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public SByteCollection B
        {
            get
            {
                return m_b;
            }

            set
            {
                m_b = value;

                if (value == null)
                {
                    m_b = new SByteCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public ByteCollection C
        {
            get
            {
                return m_c;
            }

            set
            {
                m_c = value;

                if (value == null)
                {
                    m_c = new ByteCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "D", IsRequired = false, Order = 4)]
        public Int16Collection D
        {
            get
            {
                return m_d;
            }

            set
            {
                m_d = value;

                if (value == null)
                {
                    m_d = new Int16Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "E", IsRequired = false, Order = 5)]
        public UInt16Collection E
        {
            get
            {
                return m_e;
            }

            set
            {
                m_e = value;

                if (value == null)
                {
                    m_e = new UInt16Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "F", IsRequired = false, Order = 6)]
        public Int32Collection F
        {
            get
            {
                return m_f;
            }

            set
            {
                m_f = value;

                if (value == null)
                {
                    m_f = new Int32Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "G", IsRequired = false, Order = 7)]
        public UInt32Collection G
        {
            get
            {
                return m_g;
            }

            set
            {
                m_g = value;

                if (value == null)
                {
                    m_g = new UInt32Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "H", IsRequired = false, Order = 8)]
        public Int64Collection H
        {
            get
            {
                return m_h;
            }

            set
            {
                m_h = value;

                if (value == null)
                {
                    m_h = new Int64Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "I", IsRequired = false, Order = 9)]
        public UInt64Collection I
        {
            get
            {
                return m_i;
            }

            set
            {
                m_i = value;

                if (value == null)
                {
                    m_i = new UInt64Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "J", IsRequired = false, Order = 10)]
        public FloatCollection J
        {
            get
            {
                return m_j;
            }

            set
            {
                m_j = value;

                if (value == null)
                {
                    m_j = new FloatCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "K", IsRequired = false, Order = 11)]
        public DoubleCollection K
        {
            get
            {
                return m_k;
            }

            set
            {
                m_k = value;

                if (value == null)
                {
                    m_k = new DoubleCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "L", IsRequired = false, Order = 12)]
        public UuidCollection L
        {
            get
            {
                return m_l;
            }

            set
            {
                m_l = value;

                if (value == null)
                {
                    m_l = new UuidCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "M", IsRequired = false, Order = 13)]
        public DateTimeCollection M
        {
            get
            {
                return m_m;
            }

            set
            {
                m_m = value;

                if (value == null)
                {
                    m_m = new DateTimeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "N", IsRequired = false, Order = 14)]
        public StringCollection N
        {
            get
            {
                return m_n;
            }

            set
            {
                m_n = value;

                if (value == null)
                {
                    m_n = new StringCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "O", IsRequired = false, Order = 15)]
        public ByteStringCollection O
        {
            get
            {
                return m_o;
            }

            set
            {
                m_o = value;

                if (value == null)
                {
                    m_o = new ByteStringCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "P", IsRequired = false, Order = 16)]
        public NodeIdCollection P
        {
            get
            {
                return m_p;
            }

            set
            {
                m_p = value;

                if (value == null)
                {
                    m_p = new NodeIdCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Q", IsRequired = false, Order = 17)]
        public ExpandedNodeIdCollection Q
        {
            get
            {
                return m_q;
            }

            set
            {
                m_q = value;

                if (value == null)
                {
                    m_q = new ExpandedNodeIdCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "R", IsRequired = false, Order = 18)]
        public QualifiedNameCollection R
        {
            get
            {
                return m_r;
            }

            set
            {
                m_r = value;

                if (value == null)
                {
                    m_r = new QualifiedNameCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "S", IsRequired = false, Order = 19)]
        public LocalizedTextCollection S
        {
            get
            {
                return m_s;
            }

            set
            {
                m_s = value;

                if (value == null)
                {
                    m_s = new LocalizedTextCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "T", IsRequired = false, Order = 20)]
        public StatusCodeCollection T
        {
            get
            {
                return m_t;
            }

            set
            {
                m_t = value;

                if (value == null)
                {
                    m_t = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "U", IsRequired = false, Order = 21)]
        public XmlElementCollection U
        {
            get
            {
                return m_u;
            }

            set
            {
                m_u = value;

                if (value == null)
                {
                    m_u = new XmlElementCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "V", IsRequired = false, Order = 22)]
        public VariantCollection V
        {
            get
            {
                return m_v;
            }

            set
            {
                m_v = value;

                if (value == null)
                {
                    m_v = new VariantCollection();
                }
            }
        }

        [DataMember(Name = "W", IsRequired = false, Order = 23)]
        public ExtensionObjectCollection W
        {
            get { return m_w;  }
            set { m_w = value; }
        }

        /// <remarks />
        [DataMember(Name = "X", IsRequired = false, Order = 24)]
        public TestConcreteStructureCollection X
        {
            get
            {
                return m_x;
            }

            set
            {
                m_x = value;

                if (value == null)
                {
                    m_x = new TestConcreteStructureCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Y", IsRequired = false, Order = 25)]
        public TestEnumerationCollection Y
        {
            get
            {
                return m_y;
            }

            set
            {
                m_y = value;

                if (value == null)
                {
                    m_y = new TestEnumerationCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Z", IsRequired = false, Order = 26)]
        public UInt64Collection Z
        {
            get
            {
                return m_z;
            }

            set
            {
                m_z = value;

                if (value == null)
                {
                    m_z = new UInt64Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "A1", IsRequired = false, Order = 27)]
        public TestUnionCollection A1
        {
            get
            {
                return m_a1;
            }

            set
            {
                m_a1 = value;

                if (value == null)
                {
                    m_a1 = new TestUnionCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "B1", IsRequired = false, Order = 28)]
        public TestOptionalFieldsCollection B1
        {
            get
            {
                return m_b1;
            }

            set
            {
                m_b1 = value;

                if (value == null)
                {
                    m_b1 = new TestOptionalFieldsCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "C1", IsRequired = false, Order = 29)]
        public DataValueCollection C1
        {
            get
            {
                return m_c1;
            }

            set
            {
                m_c1 = value;

                if (value == null)
                {
                    m_c1 = new DataValueCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.TestArrayStructure;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.TestArrayStructure_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.TestArrayStructure_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.TestArrayStructure;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteBooleanArray("A", A);
            encoder.WriteSByteArray("B", B);
            encoder.WriteByteArray("C", C);
            encoder.WriteInt16Array("D", D);
            encoder.WriteUInt16Array("E", E);
            encoder.WriteInt32Array("F", F);
            encoder.WriteUInt32Array("G", G);
            encoder.WriteInt64Array("H", H);
            encoder.WriteUInt64Array("I", I);
            encoder.WriteFloatArray("J", J);
            encoder.WriteDoubleArray("K", K);
            encoder.WriteGuidArray("L", L);
            encoder.WriteDateTimeArray("M", M);
            encoder.WriteStringArray("N", N);
            encoder.WriteByteStringArray("O", O);
            encoder.WriteNodeIdArray("P", P);
            encoder.WriteExpandedNodeIdArray("Q", Q);
            encoder.WriteQualifiedNameArray("R", R);
            encoder.WriteLocalizedTextArray("S", S);
            encoder.WriteStatusCodeArray("T", T);
            encoder.WriteXmlElementArray("U", U);
            encoder.WriteVariantArray("V", V);
            encoder.WriteExtensionObjectArray("W", W);
            encoder.WriteEncodeableArray("X", X.ToArray(), typeof(TestConcreteStructure));
            encoder.WriteEnumeratedArray("Y", Y.ToArray(), typeof(TestEnumeration));
            encoder.WriteUInt64Array("Z", Z);
            encoder.WriteEncodeableArray("A1", A1.ToArray(), typeof(TestUnion));
            encoder.WriteEncodeableArray("B1", B1.ToArray(), typeof(TestOptionalFields));
            encoder.WriteDataValueArray("C1", C1);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            A = decoder.ReadBooleanArray("A");
            B = decoder.ReadSByteArray("B");
            C = decoder.ReadByteArray("C");
            D = decoder.ReadInt16Array("D");
            E = decoder.ReadUInt16Array("E");
            F = decoder.ReadInt32Array("F");
            G = decoder.ReadUInt32Array("G");
            H = decoder.ReadInt64Array("H");
            I = decoder.ReadUInt64Array("I");
            J = decoder.ReadFloatArray("J");
            K = decoder.ReadDoubleArray("K");
            L = decoder.ReadGuidArray("L");
            M = decoder.ReadDateTimeArray("M");
            N = decoder.ReadStringArray("N");
            O = decoder.ReadByteStringArray("O");
            P = decoder.ReadNodeIdArray("P");
            Q = decoder.ReadExpandedNodeIdArray("Q");
            R = decoder.ReadQualifiedNameArray("R");
            S = decoder.ReadLocalizedTextArray("S");
            T = decoder.ReadStatusCodeArray("T");
            U = decoder.ReadXmlElementArray("U");
            V = decoder.ReadVariantArray("V");
            W = decoder.ReadExtensionObjectArray("W");
            X = (TestConcreteStructureCollection)decoder.ReadEncodeableArray("X", typeof(TestConcreteStructure));
            Y = (TestEnumerationCollection)decoder.ReadEnumeratedArray("Y", typeof(TestEnumeration));
            Z = decoder.ReadUInt64Array("Z");
            A1 = (TestUnionCollection)decoder.ReadEncodeableArray("A1", typeof(TestUnion));
            B1 = (TestOptionalFieldsCollection)decoder.ReadEncodeableArray("B1", typeof(TestOptionalFields));
            C1 = decoder.ReadDataValueArray("C1");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TestArrayStructure value = encodeable as TestArrayStructure;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if (!Utils.IsEqual(m_c, value.m_c)) return false;
            if (!Utils.IsEqual(m_d, value.m_d)) return false;
            if (!Utils.IsEqual(m_e, value.m_e)) return false;
            if (!Utils.IsEqual(m_f, value.m_f)) return false;
            if (!Utils.IsEqual(m_g, value.m_g)) return false;
            if (!Utils.IsEqual(m_h, value.m_h)) return false;
            if (!Utils.IsEqual(m_i, value.m_i)) return false;
            if (!Utils.IsEqual(m_j, value.m_j)) return false;
            if (!Utils.IsEqual(m_k, value.m_k)) return false;
            if (!Utils.IsEqual(m_l, value.m_l)) return false;
            if (!Utils.IsEqual(m_m, value.m_m)) return false;
            if (!Utils.IsEqual(m_n, value.m_n)) return false;
            if (!Utils.IsEqual(m_o, value.m_o)) return false;
            if (!Utils.IsEqual(m_p, value.m_p)) return false;
            if (!Utils.IsEqual(m_q, value.m_q)) return false;
            if (!Utils.IsEqual(m_r, value.m_r)) return false;
            if (!Utils.IsEqual(m_s, value.m_s)) return false;
            if (!Utils.IsEqual(m_t, value.m_t)) return false;
            if (!Utils.IsEqual(m_u, value.m_u)) return false;
            if (!Utils.IsEqual(m_v, value.m_v)) return false;
            if (!Utils.IsEqual(m_w, value.m_w)) return false;
            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;
            if (!Utils.IsEqual(m_a1, value.m_a1)) return false;
            if (!Utils.IsEqual(m_b1, value.m_b1)) return false;
            if (!Utils.IsEqual(m_c1, value.m_c1)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TestArrayStructure)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestArrayStructure clone = (TestArrayStructure)base.MemberwiseClone();

            clone.m_a = (BooleanCollection)Utils.Clone(this.m_a);
            clone.m_b = (SByteCollection)Utils.Clone(this.m_b);
            clone.m_c = (ByteCollection)Utils.Clone(this.m_c);
            clone.m_d = (Int16Collection)Utils.Clone(this.m_d);
            clone.m_e = (UInt16Collection)Utils.Clone(this.m_e);
            clone.m_f = (Int32Collection)Utils.Clone(this.m_f);
            clone.m_g = (UInt32Collection)Utils.Clone(this.m_g);
            clone.m_h = (Int64Collection)Utils.Clone(this.m_h);
            clone.m_i = (UInt64Collection)Utils.Clone(this.m_i);
            clone.m_j = (FloatCollection)Utils.Clone(this.m_j);
            clone.m_k = (DoubleCollection)Utils.Clone(this.m_k);
            clone.m_l = (UuidCollection)Utils.Clone(this.m_l);
            clone.m_m = (DateTimeCollection)Utils.Clone(this.m_m);
            clone.m_n = (StringCollection)Utils.Clone(this.m_n);
            clone.m_o = (ByteStringCollection)Utils.Clone(this.m_o);
            clone.m_p = (NodeIdCollection)Utils.Clone(this.m_p);
            clone.m_q = (ExpandedNodeIdCollection)Utils.Clone(this.m_q);
            clone.m_r = (QualifiedNameCollection)Utils.Clone(this.m_r);
            clone.m_s = (LocalizedTextCollection)Utils.Clone(this.m_s);
            clone.m_t = (StatusCodeCollection)Utils.Clone(this.m_t);
            clone.m_u = (XmlElementCollection)Utils.Clone(this.m_u);
            clone.m_v = (VariantCollection)Utils.Clone(this.m_v);
            clone.m_w = (ExtensionObjectCollection)Utils.Clone(this.m_w);
            clone.m_x = (TestConcreteStructureCollection)Utils.Clone(this.m_x);
            clone.m_y = (TestEnumerationCollection)Utils.Clone(this.m_y);
            clone.m_z = (UInt64Collection)Utils.Clone(this.m_z);
            clone.m_a1 = (TestUnionCollection)Utils.Clone(this.m_a1);
            clone.m_b1 = (TestOptionalFieldsCollection)Utils.Clone(this.m_b1);
            clone.m_c1 = (DataValueCollection)Utils.Clone(this.m_c1);

            return clone;
        }
        #endregion

        #region Private Fields
        private BooleanCollection m_a;
        private SByteCollection m_b;
        private ByteCollection m_c;
        private Int16Collection m_d;
        private UInt16Collection m_e;
        private Int32Collection m_f;
        private UInt32Collection m_g;
        private Int64Collection m_h;
        private UInt64Collection m_i;
        private FloatCollection m_j;
        private DoubleCollection m_k;
        private UuidCollection m_l;
        private DateTimeCollection m_m;
        private StringCollection m_n;
        private ByteStringCollection m_o;
        private NodeIdCollection m_p;
        private ExpandedNodeIdCollection m_q;
        private QualifiedNameCollection m_r;
        private LocalizedTextCollection m_s;
        private StatusCodeCollection m_t;
        private XmlElementCollection m_u;
        private VariantCollection m_v;
        private ExtensionObjectCollection m_w;
        private TestConcreteStructureCollection m_x;
        private TestEnumerationCollection m_y;
        private UInt64Collection m_z;
        private TestUnionCollection m_a1;
        private TestOptionalFieldsCollection m_b1;
        private DataValueCollection m_c1;
        #endregion
    }

    #region TestArrayStructureCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestArrayStructure", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestArrayStructure")]
    public partial class TestArrayStructureCollection : List<TestArrayStructure>, ICloneable
    {
        #region Constructors
        public TestArrayStructureCollection() {}

        public TestArrayStructureCollection(int capacity) : base(capacity) {}

        public TestArrayStructureCollection(IEnumerable<TestArrayStructure> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestArrayStructureCollection(TestArrayStructure[] values)
        {
            if (values != null)
            {
                return new TestArrayStructureCollection(values);
            }

            return new TestArrayStructureCollection();
        }

        public static explicit operator TestArrayStructure[](TestArrayStructureCollection values)
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
            return (TestArrayStructureCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestArrayStructureCollection clone = new TestArrayStructureCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestArrayStructure)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region TestStructure Class
    #if (!OPCUA_EXCLUDE_TestStructure)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class TestStructure : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public TestStructure()
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
            m_a = new TestScalarStructure();
            m_b = new TestArrayStructure();
            m_c = new TestScalarStructureCollection();
            m_d = new TestArrayStructureCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "A", IsRequired = false, Order = 1)]
        public TestScalarStructure A
        {
            get
            {
                return m_a;
            }

            set
            {
                m_a = value;

                if (value == null)
                {
                    m_a = new TestScalarStructure();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "B", IsRequired = false, Order = 2)]
        public TestArrayStructure B
        {
            get
            {
                return m_b;
            }

            set
            {
                m_b = value;

                if (value == null)
                {
                    m_b = new TestArrayStructure();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "C", IsRequired = false, Order = 3)]
        public TestScalarStructureCollection C
        {
            get
            {
                return m_c;
            }

            set
            {
                m_c = value;

                if (value == null)
                {
                    m_c = new TestScalarStructureCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "D", IsRequired = false, Order = 4)]
        public TestArrayStructureCollection D
        {
            get
            {
                return m_d;
            }

            set
            {
                m_d = value;

                if (value == null)
                {
                    m_d = new TestArrayStructureCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.TestStructure;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.TestStructure_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.TestStructure_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.TestStructure;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteEncodeable("A", A, typeof(TestScalarStructure));
            encoder.WriteEncodeable("B", B, typeof(TestArrayStructure));
            encoder.WriteEncodeableArray("C", C.ToArray(), typeof(TestScalarStructure));
            encoder.WriteEncodeableArray("D", D.ToArray(), typeof(TestArrayStructure));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            A = (TestScalarStructure)decoder.ReadEncodeable("A", typeof(TestScalarStructure));
            B = (TestArrayStructure)decoder.ReadEncodeable("B", typeof(TestArrayStructure));
            C = (TestScalarStructureCollection)decoder.ReadEncodeableArray("C", typeof(TestScalarStructure));
            D = (TestArrayStructureCollection)decoder.ReadEncodeableArray("D", typeof(TestArrayStructure));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TestStructure value = encodeable as TestStructure;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if (!Utils.IsEqual(m_c, value.m_c)) return false;
            if (!Utils.IsEqual(m_d, value.m_d)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TestStructure)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestStructure clone = (TestStructure)base.MemberwiseClone();

            clone.m_a = (TestScalarStructure)Utils.Clone(this.m_a);
            clone.m_b = (TestArrayStructure)Utils.Clone(this.m_b);
            clone.m_c = (TestScalarStructureCollection)Utils.Clone(this.m_c);
            clone.m_d = (TestArrayStructureCollection)Utils.Clone(this.m_d);

            return clone;
        }
        #endregion

        #region Private Fields
        private TestScalarStructure m_a;
        private TestArrayStructure m_b;
        private TestScalarStructureCollection m_c;
        private TestArrayStructureCollection m_d;
        #endregion
    }

    #region TestStructureCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfTestStructure", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "TestStructure")]
    public partial class TestStructureCollection : List<TestStructure>, ICloneable
    {
        #region Constructors
        public TestStructureCollection() {}

        public TestStructureCollection(int capacity) : base(capacity) {}

        public TestStructureCollection(IEnumerable<TestStructure> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator TestStructureCollection(TestStructure[] values)
        {
            if (values != null)
            {
                return new TestStructureCollection(values);
            }

            return new TestStructureCollection();
        }

        public static explicit operator TestStructure[](TestStructureCollection values)
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
            return (TestStructureCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TestStructureCollection clone = new TestStructureCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TestStructure)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EnumUnderscoreTest Enumeration
    #if (!OPCUA_EXCLUDE_EnumUnderscoreTest)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    
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
    [CollectionDataContract(Name = "ListOfEnumUnderscoreTest", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "EnumUnderscoreTest")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    
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
    [CollectionDataContract(Name = "ListOfHeaterStatus", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "HeaterStatus")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteDouble("X", X);
            encoder.WriteDouble("Y", Y);
            encoder.WriteDouble("Z", Z);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfVector", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "Vector")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteString("Actor", Actor);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteLocalizedText("Comment", Comment);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfWorkOrderStatusType", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "WorkOrderStatusType")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteGuid("ID", ID);
            encoder.WriteString("AssetID", AssetID);
            encoder.WriteDateTime("StartTime", StartTime);
            encoder.WriteEncodeableArray("StatusComments", StatusComments.ToArray(), typeof(WorkOrderStatusType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfWorkOrderType", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "WorkOrderType")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class ExtendedWorkOrderType : TestModel.WorkOrderType
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);
            encoder.PopNamespace();

            base.Encode(encoder);

            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteUInt32("ContactX", ContactX);
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactY) != 0) encoder.WriteStringArray("ContactY", ContactY);
            if ((EncodingMask & (uint)ExtendedWorkOrderFields.ContactZ) != 0) encoder.WriteByteString("ContactZ", ContactZ);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            EncodingMask = decoder.ReadEncodingMask(m_FieldNames);
            decoder.PopNamespace();
                
            base.Decode(decoder);

            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfExtendedWorkOrderType", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "ExtendedWorkOrderType")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class FinalWorkOrderType : TestModel.ExtendedWorkOrderType
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
            m_address = null;
            m_phone = null;
        }
        #endregion

        #region Public Properties
        
        [DataMember(Name = "Address", IsRequired = false, Order = 1)]
        public string Address
        {
            get { return m_address;  }
            set { m_address = value; }
        }

        [DataMember(Name = "Phone", IsRequired = false, Order = 2)]
        public string Phone
        {
            get { return m_phone;  }
            set { m_phone = value; }
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            
            encoder.PopNamespace();

            base.Encode(encoder);

            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteString("Address", Address);
            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) encoder.WriteString("Phone", Phone);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            
            decoder.PopNamespace();
                
            base.Decode(decoder);

            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            Address = decoder.ReadString("Address");
            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) Phone = decoder.ReadString("Phone");

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

            

            if (!Utils.IsEqual(m_address, value.m_address)) return false;
            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) if (!Utils.IsEqual(m_phone, value.m_phone)) return false;

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
                
            
            clone.m_address = (string)Utils.Clone(this.m_address);
            if ((EncodingMask & (uint)FinalWorkOrderFields.Phone) != 0) clone.m_phone = (string)Utils.Clone(this.m_phone);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_address;
        private string m_phone;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(FinalWorkOrderFields)).Where(x => x != nameof(FinalWorkOrderFields.None)).ToArray();
        #endregion
    }

    #region FinalWorkOrderTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfFinalWorkOrderType", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "FinalWorkOrderType")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
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
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfSampleUnion", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "SampleUnion")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);

            encoder.WriteUInt32("FieldX", FieldX);
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldY) != 0) encoder.WriteStringArray("FieldY", FieldY);
            if ((EncodingMask & (uint)SampleStructureWithOptionalFieldsFields.FieldZ) != 0) encoder.WriteByteString("FieldZ", FieldZ);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfSampleStructureWithOptionalFields", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "SampleStructureWithOptionalFields")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
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
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfSampleUnionAllowSubtypes", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "SampleUnionAllowSubtypes")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            encoder.WriteExtensionObject("FieldX", FieldX);
            encoder.WriteExtensionObjectArray("FieldY", FieldY);
            encoder.WriteVariant("FieldZ", FieldZ);
            encoder.WriteEncodeable("FieldW", FieldW, typeof(WorkOrderStatusType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfSampleStructureAllowSubtypes", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "SampleStructureAllowSubtypes")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            encoder.WriteEncodingMask((uint)EncodingMask);

            if ((EncodingMask & (uint)PersonFields.LastName) != 0) encoder.WriteString("LastName", LastName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfPerson", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "Person")]
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
    [DataContract(Namespace = TestModel.Namespaces.TestModelXsd)]
    public partial class Student : TestModel.Person
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
            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            
            encoder.PopNamespace();

            base.Encode(encoder);

            encoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

            if ((EncodingMask & (uint)StudentFields.FirstName) != 0) encoder.WriteString("FirstName", FirstName);
            if ((EncodingMask & (uint)StudentFields.University) != 0) encoder.WriteString("University", University);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);
            
            decoder.PopNamespace();
                
            base.Decode(decoder);

            decoder.PushNamespace(TestModel.Namespaces.TestModelXsd);

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
    [CollectionDataContract(Name = "ListOfStudent", Namespace = TestModel.Namespaces.TestModelXsd, ItemName = "Student")]
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
