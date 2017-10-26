/* ========================================================================
 * Copyright (c) 2005-2018 The OPC Foundation, Inc. All rights reserved.
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

namespace Opc.Ua.MTConnect
{
    #region ActuatorStateTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ActuatorStateTypeEnum)
    /// <summary>
    /// A description for the ActuatorStateTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum ActuatorStateTypeEnum
    {
        /// <summary>
        /// A description for the ACTIVE_1 field.
        /// </summary>
        [EnumMember(Value = "ACTIVE_1")]
        ACTIVE_1 = 1,

        /// <summary>
        /// A description for the INACTIVE_2 field.
        /// </summary>
        [EnumMember(Value = "INACTIVE_2")]
        INACTIVE_2 = 2,
    }

    #region ActuatorStateTypeEnumCollection Class
    /// <summary>
    /// A collection of ActuatorStateTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfActuatorStateTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "ActuatorStateTypeEnum")]
    #if !NET_STANDARD
    public partial class ActuatorStateTypeEnumCollection : List<ActuatorStateTypeEnum>, ICloneable
    #else
    public partial class ActuatorStateTypeEnumCollection : List<ActuatorStateTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ActuatorStateTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ActuatorStateTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ActuatorStateTypeEnumCollection(IEnumerable<ActuatorStateTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ActuatorStateTypeEnumCollection(ActuatorStateTypeEnum[] values)
        {
            if (values != null)
            {
                return new ActuatorStateTypeEnumCollection(values);
            }

            return new ActuatorStateTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ActuatorStateTypeEnum[](ActuatorStateTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ActuatorStateTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ActuatorStateTypeEnumCollection clone = new ActuatorStateTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ActuatorStateTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AlarmStateTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_AlarmStateTypeEnum)
    /// <summary>
    /// A description for the AlarmStateTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum AlarmStateTypeEnum
    {
        /// <summary>
        /// A description for the ACTIVE_1 field.
        /// </summary>
        [EnumMember(Value = "ACTIVE_1")]
        ACTIVE_1 = 1,

        /// <summary>
        /// A description for the CLEARED_2 field.
        /// </summary>
        [EnumMember(Value = "CLEARED_2")]
        CLEARED_2 = 2,
    }

    #region AlarmStateTypeEnumCollection Class
    /// <summary>
    /// A collection of AlarmStateTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAlarmStateTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "AlarmStateTypeEnum")]
    #if !NET_STANDARD
    public partial class AlarmStateTypeEnumCollection : List<AlarmStateTypeEnum>, ICloneable
    #else
    public partial class AlarmStateTypeEnumCollection : List<AlarmStateTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AlarmStateTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AlarmStateTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AlarmStateTypeEnumCollection(IEnumerable<AlarmStateTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AlarmStateTypeEnumCollection(AlarmStateTypeEnum[] values)
        {
            if (values != null)
            {
                return new AlarmStateTypeEnumCollection(values);
            }

            return new AlarmStateTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AlarmStateTypeEnum[](AlarmStateTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AlarmStateTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AlarmStateTypeEnumCollection clone = new AlarmStateTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AlarmStateTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AvailabilityTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_AvailabilityTypeEnum)
    /// <summary>
    /// A description for the AvailabilityTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum AvailabilityTypeEnum
    {
        /// <summary>
        /// A description for the AVAILABLE_1 field.
        /// </summary>
        [EnumMember(Value = "AVAILABLE_1")]
        AVAILABLE_1 = 1,

        /// <summary>
        /// A description for the UNAVAILABLE_2 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_2")]
        UNAVAILABLE_2 = 2,
    }

    #region AvailabilityTypeEnumCollection Class
    /// <summary>
    /// A collection of AvailabilityTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAvailabilityTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "AvailabilityTypeEnum")]
    #if !NET_STANDARD
    public partial class AvailabilityTypeEnumCollection : List<AvailabilityTypeEnum>, ICloneable
    #else
    public partial class AvailabilityTypeEnumCollection : List<AvailabilityTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AvailabilityTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AvailabilityTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AvailabilityTypeEnumCollection(IEnumerable<AvailabilityTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AvailabilityTypeEnumCollection(AvailabilityTypeEnum[] values)
        {
            if (values != null)
            {
                return new AvailabilityTypeEnumCollection(values);
            }

            return new AvailabilityTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AvailabilityTypeEnum[](AvailabilityTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AvailabilityTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AvailabilityTypeEnumCollection clone = new AvailabilityTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AvailabilityTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AxesCouplingTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_AxesCouplingTypeEnum)
    /// <summary>
    /// A description for the AxesCouplingTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum AxesCouplingTypeEnum
    {
        /// <summary>
        /// A description for the MASTER_1 field.
        /// </summary>
        [EnumMember(Value = "MASTER_1")]
        MASTER_1 = 1,

        /// <summary>
        /// A description for the SLAVE_2 field.
        /// </summary>
        [EnumMember(Value = "SLAVE_2")]
        SLAVE_2 = 2,

        /// <summary>
        /// A description for the SYCHRONOUS_3 field.
        /// </summary>
        [EnumMember(Value = "SYCHRONOUS_3")]
        SYCHRONOUS_3 = 3,

        /// <summary>
        /// A description for the TANDEM_4 field.
        /// </summary>
        [EnumMember(Value = "TANDEM_4")]
        TANDEM_4 = 4,

        /// <summary>
        /// A description for the UNAVAILABLE_5 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_5")]
        UNAVAILABLE_5 = 5,
    }

    #region AxesCouplingTypeEnumCollection Class
    /// <summary>
    /// A collection of AxesCouplingTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAxesCouplingTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "AxesCouplingTypeEnum")]
    #if !NET_STANDARD
    public partial class AxesCouplingTypeEnumCollection : List<AxesCouplingTypeEnum>, ICloneable
    #else
    public partial class AxesCouplingTypeEnumCollection : List<AxesCouplingTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AxesCouplingTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AxesCouplingTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AxesCouplingTypeEnumCollection(IEnumerable<AxesCouplingTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AxesCouplingTypeEnumCollection(AxesCouplingTypeEnum[] values)
        {
            if (values != null)
            {
                return new AxesCouplingTypeEnumCollection(values);
            }

            return new AxesCouplingTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AxesCouplingTypeEnum[](AxesCouplingTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AxesCouplingTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AxesCouplingTypeEnumCollection clone = new AxesCouplingTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AxesCouplingTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CategoryTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_CategoryTypeEnum)
    /// <summary>
    /// A description for the CategoryTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum CategoryTypeEnum
    {
        /// <summary>
        /// A description for the CONDITION_1 field.
        /// </summary>
        [EnumMember(Value = "CONDITION_1")]
        CONDITION_1 = 1,

        /// <summary>
        /// A description for the EVENT_2 field.
        /// </summary>
        [EnumMember(Value = "EVENT_2")]
        EVENT_2 = 2,

        /// <summary>
        /// A description for the SAMPLE_3 field.
        /// </summary>
        [EnumMember(Value = "SAMPLE_3")]
        SAMPLE_3 = 3,
    }

    #region CategoryTypeEnumCollection Class
    /// <summary>
    /// A collection of CategoryTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCategoryTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "CategoryTypeEnum")]
    #if !NET_STANDARD
    public partial class CategoryTypeEnumCollection : List<CategoryTypeEnum>, ICloneable
    #else
    public partial class CategoryTypeEnumCollection : List<CategoryTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CategoryTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CategoryTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CategoryTypeEnumCollection(IEnumerable<CategoryTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CategoryTypeEnumCollection(CategoryTypeEnum[] values)
        {
            if (values != null)
            {
                return new CategoryTypeEnumCollection(values);
            }

            return new CategoryTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CategoryTypeEnum[](CategoryTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CategoryTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CategoryTypeEnumCollection clone = new CategoryTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CategoryTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ClampStateTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ClampStateTypeEnum)
    /// <summary>
    /// A description for the ClampStateTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum ClampStateTypeEnum
    {
        /// <summary>
        /// A description for the CLOSED_1 field.
        /// </summary>
        [EnumMember(Value = "CLOSED_1")]
        CLOSED_1 = 1,

        /// <summary>
        /// A description for the INDETERMINATE_2 field.
        /// </summary>
        [EnumMember(Value = "INDETERMINATE_2")]
        INDETERMINATE_2 = 2,

        /// <summary>
        /// A description for the OPEN_3 field.
        /// </summary>
        [EnumMember(Value = "OPEN_3")]
        OPEN_3 = 3,

        /// <summary>
        /// A description for the UNAVAILABLE_4 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_4")]
        UNAVAILABLE_4 = 4,
    }

    #region ClampStateTypeEnumCollection Class
    /// <summary>
    /// A collection of ClampStateTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfClampStateTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "ClampStateTypeEnum")]
    #if !NET_STANDARD
    public partial class ClampStateTypeEnumCollection : List<ClampStateTypeEnum>, ICloneable
    #else
    public partial class ClampStateTypeEnumCollection : List<ClampStateTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ClampStateTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ClampStateTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ClampStateTypeEnumCollection(IEnumerable<ClampStateTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ClampStateTypeEnumCollection(ClampStateTypeEnum[] values)
        {
            if (values != null)
            {
                return new ClampStateTypeEnumCollection(values);
            }

            return new ClampStateTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ClampStateTypeEnum[](ClampStateTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ClampStateTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ClampStateTypeEnumCollection clone = new ClampStateTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ClampStateTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ControllerModeTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ControllerModeTypeEnum)
    /// <summary>
    /// A description for the ControllerModeTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum ControllerModeTypeEnum
    {
        /// <summary>
        /// A description for the AUTOMATIC_1 field.
        /// </summary>
        [EnumMember(Value = "AUTOMATIC_1")]
        AUTOMATIC_1 = 1,

        /// <summary>
        /// A description for the MANUAL_2 field.
        /// </summary>
        [EnumMember(Value = "MANUAL_2")]
        MANUAL_2 = 2,

        /// <summary>
        /// A description for the MANUAL_DATA_INPUT_3 field.
        /// </summary>
        [EnumMember(Value = "MANUAL_DATA_INPUT_3")]
        MANUAL_DATA_INPUT_3 = 3,

        /// <summary>
        /// A description for the SEMI_AUTOMATIC_4 field.
        /// </summary>
        [EnumMember(Value = "SEMI_AUTOMATIC_4")]
        SEMI_AUTOMATIC_4 = 4,

        /// <summary>
        /// A description for the UNAVAILABLE_5 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_5")]
        UNAVAILABLE_5 = 5,
    }

    #region ControllerModeTypeEnumCollection Class
    /// <summary>
    /// A collection of ControllerModeTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfControllerModeTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "ControllerModeTypeEnum")]
    #if !NET_STANDARD
    public partial class ControllerModeTypeEnumCollection : List<ControllerModeTypeEnum>, ICloneable
    #else
    public partial class ControllerModeTypeEnumCollection : List<ControllerModeTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ControllerModeTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ControllerModeTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ControllerModeTypeEnumCollection(IEnumerable<ControllerModeTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ControllerModeTypeEnumCollection(ControllerModeTypeEnum[] values)
        {
            if (values != null)
            {
                return new ControllerModeTypeEnumCollection(values);
            }

            return new ControllerModeTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ControllerModeTypeEnum[](ControllerModeTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ControllerModeTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ControllerModeTypeEnumCollection clone = new ControllerModeTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ControllerModeTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CoordinateSystemTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_CoordinateSystemTypeEnum)
    /// <summary>
    /// A description for the CoordinateSystemTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum CoordinateSystemTypeEnum
    {
        /// <summary>
        /// A description for the MACHINE_1 field.
        /// </summary>
        [EnumMember(Value = "MACHINE_1")]
        MACHINE_1 = 1,

        /// <summary>
        /// A description for the WORK_2 field.
        /// </summary>
        [EnumMember(Value = "WORK_2")]
        WORK_2 = 2,
    }

    #region CoordinateSystemTypeEnumCollection Class
    /// <summary>
    /// A collection of CoordinateSystemTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCoordinateSystemTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "CoordinateSystemTypeEnum")]
    #if !NET_STANDARD
    public partial class CoordinateSystemTypeEnumCollection : List<CoordinateSystemTypeEnum>, ICloneable
    #else
    public partial class CoordinateSystemTypeEnumCollection : List<CoordinateSystemTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CoordinateSystemTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CoordinateSystemTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CoordinateSystemTypeEnumCollection(IEnumerable<CoordinateSystemTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CoordinateSystemTypeEnumCollection(CoordinateSystemTypeEnum[] values)
        {
            if (values != null)
            {
                return new CoordinateSystemTypeEnumCollection(values);
            }

            return new CoordinateSystemTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CoordinateSystemTypeEnum[](CoordinateSystemTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CoordinateSystemTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CoordinateSystemTypeEnumCollection clone = new CoordinateSystemTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CoordinateSystemTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CutterStatusValueTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_CutterStatusValueTypeEnum)
    /// <summary>
    /// A description for the CutterStatusValueTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum CutterStatusValueTypeEnum
    {
        /// <summary>
        /// A description for the ALLOCATED_1 field.
        /// </summary>
        [EnumMember(Value = "ALLOCATED_1")]
        ALLOCATED_1 = 1,

        /// <summary>
        /// A description for the AVAILABLE_2 field.
        /// </summary>
        [EnumMember(Value = "AVAILABLE_2")]
        AVAILABLE_2 = 2,

        /// <summary>
        /// A description for the BROKEN_3 field.
        /// </summary>
        [EnumMember(Value = "BROKEN_3")]
        BROKEN_3 = 3,

        /// <summary>
        /// A description for the EXPIRED_4 field.
        /// </summary>
        [EnumMember(Value = "EXPIRED_4")]
        EXPIRED_4 = 4,

        /// <summary>
        /// A description for the MEASURED_5 field.
        /// </summary>
        [EnumMember(Value = "MEASURED_5")]
        MEASURED_5 = 5,

        /// <summary>
        /// A description for the NEW_6 field.
        /// </summary>
        [EnumMember(Value = "NEW_6")]
        NEW_6 = 6,

        /// <summary>
        /// A description for the NOT_REGISTERED_7 field.
        /// </summary>
        [EnumMember(Value = "NOT_REGISTERED_7")]
        NOT_REGISTERED_7 = 7,

        /// <summary>
        /// A description for the RECONDITIONED_8 field.
        /// </summary>
        [EnumMember(Value = "RECONDITIONED_8")]
        RECONDITIONED_8 = 8,

        /// <summary>
        /// A description for the TAGGED_OUT_9 field.
        /// </summary>
        [EnumMember(Value = "TAGGED_OUT_9")]
        TAGGED_OUT_9 = 9,

        /// <summary>
        /// A description for the UNALLOCATED_10 field.
        /// </summary>
        [EnumMember(Value = "UNALLOCATED_10")]
        UNALLOCATED_10 = 10,

        /// <summary>
        /// A description for the UNAVAILABLE_11 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_11")]
        UNAVAILABLE_11 = 11,

        /// <summary>
        /// A description for the UNKNOWN_12 field.
        /// </summary>
        [EnumMember(Value = "UNKNOWN_12")]
        UNKNOWN_12 = 12,

        /// <summary>
        /// A description for the USED_13 field.
        /// </summary>
        [EnumMember(Value = "USED_13")]
        USED_13 = 13,
    }

    #region CutterStatusValueTypeEnumCollection Class
    /// <summary>
    /// A collection of CutterStatusValueTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCutterStatusValueTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "CutterStatusValueTypeEnum")]
    #if !NET_STANDARD
    public partial class CutterStatusValueTypeEnumCollection : List<CutterStatusValueTypeEnum>, ICloneable
    #else
    public partial class CutterStatusValueTypeEnumCollection : List<CutterStatusValueTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CutterStatusValueTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CutterStatusValueTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CutterStatusValueTypeEnumCollection(IEnumerable<CutterStatusValueTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CutterStatusValueTypeEnumCollection(CutterStatusValueTypeEnum[] values)
        {
            if (values != null)
            {
                return new CutterStatusValueTypeEnumCollection(values);
            }

            return new CutterStatusValueTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CutterStatusValueTypeEnum[](CutterStatusValueTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CutterStatusValueTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CutterStatusValueTypeEnumCollection clone = new CutterStatusValueTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CutterStatusValueTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DataItemEnumDataType Class
    #if (!OPCUA_EXCLUDE_DataItemEnumDataType)
    /// <summary>
    /// A description for the DataItemEnumDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public partial class DataItemEnumDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public DataItemEnumDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_dataItemEnum = DataItemEnumTypeEnum.ACCELERATION_1;
            m_dataItemEnumString = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DataItemEnum field.
        /// </summary>
        [DataMember(Name = "DataItemEnum", IsRequired = false, Order = 1)]
        public DataItemEnumTypeEnum DataItemEnum
        {
            get { return m_dataItemEnum;  }
            set { m_dataItemEnum = value; }
        }

        /// <summary>
        /// A description for the DataItemEnumString field.
        /// </summary>
        [DataMember(Name = "DataItemEnumString", IsRequired = false, Order = 2)]
        public string DataItemEnumString
        {
            get { return m_dataItemEnumString;  }
            set { m_dataItemEnumString = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DataItemEnumDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DataItemEnumDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DataItemEnumDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd);

            encoder.WriteEnumerated("DataItemEnum", DataItemEnum);
            encoder.WriteString("DataItemEnumString", DataItemEnumString);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd);

            DataItemEnum = (DataItemEnumTypeEnum)decoder.ReadEnumerated("DataItemEnum", typeof(DataItemEnumTypeEnum));
            DataItemEnumString = decoder.ReadString("DataItemEnumString");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DataItemEnumDataType value = encodeable as DataItemEnumDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_dataItemEnum, value.m_dataItemEnum)) return false;
            if (!Utils.IsEqual(m_dataItemEnumString, value.m_dataItemEnumString)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (DataItemEnumDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemEnumDataType clone = (DataItemEnumDataType)base.MemberwiseClone();

            clone.m_dataItemEnum = (DataItemEnumTypeEnum)Utils.Clone(this.m_dataItemEnum);
            clone.m_dataItemEnumString = (string)Utils.Clone(this.m_dataItemEnumString);

            return clone;
        }
        #endregion

        #region Private Fields
        private DataItemEnumTypeEnum m_dataItemEnum;
        private string m_dataItemEnumString;
        #endregion
    }

    #region DataItemEnumDataTypeCollection Class
    /// <summary>
    /// A collection of DataItemEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDataItemEnumDataType", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DataItemEnumDataType")]
    #if !NET_STANDARD
    public partial class DataItemEnumDataTypeCollection : List<DataItemEnumDataType>, ICloneable
    #else
    public partial class DataItemEnumDataTypeCollection : List<DataItemEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DataItemEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DataItemEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DataItemEnumDataTypeCollection(IEnumerable<DataItemEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DataItemEnumDataTypeCollection(DataItemEnumDataType[] values)
        {
            if (values != null)
            {
                return new DataItemEnumDataTypeCollection(values);
            }

            return new DataItemEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DataItemEnumDataType[](DataItemEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DataItemEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemEnumDataTypeCollection clone = new DataItemEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DataItemEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DataItemEnumTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DataItemEnumTypeEnum)
    /// <summary>
    /// A description for the DataItemEnumTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum DataItemEnumTypeEnum
    {
        /// <summary>
        /// A description for the ACCELERATION_1 field.
        /// </summary>
        [EnumMember(Value = "ACCELERATION_1")]
        ACCELERATION_1 = 1,

        /// <summary>
        /// A description for the ACCUMULATED_TIME_2 field.
        /// </summary>
        [EnumMember(Value = "ACCUMULATED_TIME_2")]
        ACCUMULATED_TIME_2 = 2,

        /// <summary>
        /// A description for the ACTIVE_AXES_3 field.
        /// </summary>
        [EnumMember(Value = "ACTIVE_AXES_3")]
        ACTIVE_AXES_3 = 3,

        /// <summary>
        /// A description for the ACTUATOR_4 field.
        /// </summary>
        [EnumMember(Value = "ACTUATOR_4")]
        ACTUATOR_4 = 4,

        /// <summary>
        /// A description for the ACTUATOR_STATE_5 field.
        /// </summary>
        [EnumMember(Value = "ACTUATOR_STATE_5")]
        ACTUATOR_STATE_5 = 5,

        /// <summary>
        /// A description for the ALARM_6 field.
        /// </summary>
        [EnumMember(Value = "ALARM_6")]
        ALARM_6 = 6,

        /// <summary>
        /// A description for the AMPERAGE_7 field.
        /// </summary>
        [EnumMember(Value = "AMPERAGE_7")]
        AMPERAGE_7 = 7,

        /// <summary>
        /// A description for the ANGLE_8 field.
        /// </summary>
        [EnumMember(Value = "ANGLE_8")]
        ANGLE_8 = 8,

        /// <summary>
        /// A description for the ANGULAR_ACCELERATION_9 field.
        /// </summary>
        [EnumMember(Value = "ANGULAR_ACCELERATION_9")]
        ANGULAR_ACCELERATION_9 = 9,

        /// <summary>
        /// A description for the ANGULAR_VELOCITY_10 field.
        /// </summary>
        [EnumMember(Value = "ANGULAR_VELOCITY_10")]
        ANGULAR_VELOCITY_10 = 10,

        /// <summary>
        /// A description for the ASSET_CHANGED_11 field.
        /// </summary>
        [EnumMember(Value = "ASSET_CHANGED_11")]
        ASSET_CHANGED_11 = 11,

        /// <summary>
        /// A description for the AVAILABILITY_12 field.
        /// </summary>
        [EnumMember(Value = "AVAILABILITY_12")]
        AVAILABILITY_12 = 12,

        /// <summary>
        /// A description for the AXIS_COUPLING_13 field.
        /// </summary>
        [EnumMember(Value = "AXIS_COUPLING_13")]
        AXIS_COUPLING_13 = 13,

        /// <summary>
        /// A description for the AXIS_FEEDRATE_14 field.
        /// </summary>
        [EnumMember(Value = "AXIS_FEEDRATE_14")]
        AXIS_FEEDRATE_14 = 14,

        /// <summary>
        /// A description for the BLOCK_15 field.
        /// </summary>
        [EnumMember(Value = "BLOCK_15")]
        BLOCK_15 = 15,

        /// <summary>
        /// A description for the CODE_16 field.
        /// </summary>
        [EnumMember(Value = "CODE_16")]
        CODE_16 = 16,

        /// <summary>
        /// A description for the COMMUNICATIONS_17 field.
        /// </summary>
        [EnumMember(Value = "COMMUNICATIONS_17")]
        COMMUNICATIONS_17 = 17,

        /// <summary>
        /// A description for the CONCENTRATION_18 field.
        /// </summary>
        [EnumMember(Value = "CONCENTRATION_18")]
        CONCENTRATION_18 = 18,

        /// <summary>
        /// A description for the CONDUCTIVITY_19 field.
        /// </summary>
        [EnumMember(Value = "CONDUCTIVITY_19")]
        CONDUCTIVITY_19 = 19,

        /// <summary>
        /// A description for the CONTROLLER_MODE_20 field.
        /// </summary>
        [EnumMember(Value = "CONTROLLER_MODE_20")]
        CONTROLLER_MODE_20 = 20,

        /// <summary>
        /// A description for the COUPLED_AXES_21 field.
        /// </summary>
        [EnumMember(Value = "COUPLED_AXES_21")]
        COUPLED_AXES_21 = 21,

        /// <summary>
        /// A description for the DIRECTION_22 field.
        /// </summary>
        [EnumMember(Value = "DIRECTION_22")]
        DIRECTION_22 = 22,

        /// <summary>
        /// A description for the DISPLACEMENT_23 field.
        /// </summary>
        [EnumMember(Value = "DISPLACEMENT_23")]
        DISPLACEMENT_23 = 23,

        /// <summary>
        /// A description for the DOOR_STATE_24 field.
        /// </summary>
        [EnumMember(Value = "DOOR_STATE_24")]
        DOOR_STATE_24 = 24,

        /// <summary>
        /// A description for the ELECTRICAL_POWER_25 field.
        /// </summary>
        [EnumMember(Value = "ELECTRICAL_POWER_25")]
        ELECTRICAL_POWER_25 = 25,

        /// <summary>
        /// A description for the EMERGENCY_STOP_26 field.
        /// </summary>
        [EnumMember(Value = "EMERGENCY_STOP_26")]
        EMERGENCY_STOP_26 = 26,

        /// <summary>
        /// A description for the EXECUTION_27 field.
        /// </summary>
        [EnumMember(Value = "EXECUTION_27")]
        EXECUTION_27 = 27,

        /// <summary>
        /// A description for the FILL_LEVEL_28 field.
        /// </summary>
        [EnumMember(Value = "FILL_LEVEL_28")]
        FILL_LEVEL_28 = 28,

        /// <summary>
        /// A description for the FLOW_29 field.
        /// </summary>
        [EnumMember(Value = "FLOW_29")]
        FLOW_29 = 29,

        /// <summary>
        /// A description for the FREQUENCY_30 field.
        /// </summary>
        [EnumMember(Value = "FREQUENCY_30")]
        FREQUENCY_30 = 30,

        /// <summary>
        /// A description for the HARDWARE_31 field.
        /// </summary>
        [EnumMember(Value = "HARDWARE_31")]
        HARDWARE_31 = 31,

        /// <summary>
        /// A description for the LEVEL_32 field.
        /// </summary>
        [EnumMember(Value = "LEVEL_32")]
        LEVEL_32 = 32,

        /// <summary>
        /// A description for the LINE_33 field.
        /// </summary>
        [EnumMember(Value = "LINE_33")]
        LINE_33 = 33,

        /// <summary>
        /// A description for the LINEAR_FORCE_34 field.
        /// </summary>
        [EnumMember(Value = "LINEAR_FORCE_34")]
        LINEAR_FORCE_34 = 34,

        /// <summary>
        /// A description for the LOAD_35 field.
        /// </summary>
        [EnumMember(Value = "LOAD_35")]
        LOAD_35 = 35,

        /// <summary>
        /// A description for the LOGIC_PROGRAM_36 field.
        /// </summary>
        [EnumMember(Value = "LOGIC_PROGRAM_36")]
        LOGIC_PROGRAM_36 = 36,

        /// <summary>
        /// A description for the MASS_37 field.
        /// </summary>
        [EnumMember(Value = "MASS_37")]
        MASS_37 = 37,

        /// <summary>
        /// A description for the MESSAGE_38 field.
        /// </summary>
        [EnumMember(Value = "MESSAGE_38")]
        MESSAGE_38 = 38,

        /// <summary>
        /// A description for the MOTION_PROGRAM_39 field.
        /// </summary>
        [EnumMember(Value = "MOTION_PROGRAM_39")]
        MOTION_PROGRAM_39 = 39,

        /// <summary>
        /// A description for the PART_COUNT_40 field.
        /// </summary>
        [EnumMember(Value = "PART_COUNT_40")]
        PART_COUNT_40 = 40,

        /// <summary>
        /// A description for the PART_ID_41 field.
        /// </summary>
        [EnumMember(Value = "PART_ID_41")]
        PART_ID_41 = 41,
    }

    #region DataItemEnumTypeEnumCollection Class
    /// <summary>
    /// A collection of DataItemEnumTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDataItemEnumTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DataItemEnumTypeEnum")]
    #if !NET_STANDARD
    public partial class DataItemEnumTypeEnumCollection : List<DataItemEnumTypeEnum>, ICloneable
    #else
    public partial class DataItemEnumTypeEnumCollection : List<DataItemEnumTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DataItemEnumTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DataItemEnumTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DataItemEnumTypeEnumCollection(IEnumerable<DataItemEnumTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DataItemEnumTypeEnumCollection(DataItemEnumTypeEnum[] values)
        {
            if (values != null)
            {
                return new DataItemEnumTypeEnumCollection(values);
            }

            return new DataItemEnumTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DataItemEnumTypeEnum[](DataItemEnumTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DataItemEnumTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemEnumTypeEnumCollection clone = new DataItemEnumTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DataItemEnumTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DataItemStatisticsDataType Class
    #if (!OPCUA_EXCLUDE_DataItemStatisticsDataType)
    /// <summary>
    /// A description for the DataItemStatisticsDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public partial class DataItemStatisticsDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public DataItemStatisticsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_dataItemStatisticsEnum = DataItemStatisticsTypeEnum.AVERAGE_1;
            m_dataItemStatisticsString = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DataItemStatisticsEnum field.
        /// </summary>
        [DataMember(Name = "DataItemStatisticsEnum", IsRequired = false, Order = 1)]
        public DataItemStatisticsTypeEnum DataItemStatisticsEnum
        {
            get { return m_dataItemStatisticsEnum;  }
            set { m_dataItemStatisticsEnum = value; }
        }

        /// <summary>
        /// A description for the DataItemStatisticsString field.
        /// </summary>
        [DataMember(Name = "DataItemStatisticsString", IsRequired = false, Order = 2)]
        public string DataItemStatisticsString
        {
            get { return m_dataItemStatisticsString;  }
            set { m_dataItemStatisticsString = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DataItemStatisticsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DataItemStatisticsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DataItemStatisticsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd);

            encoder.WriteEnumerated("DataItemStatisticsEnum", DataItemStatisticsEnum);
            encoder.WriteString("DataItemStatisticsString", DataItemStatisticsString);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd);

            DataItemStatisticsEnum = (DataItemStatisticsTypeEnum)decoder.ReadEnumerated("DataItemStatisticsEnum", typeof(DataItemStatisticsTypeEnum));
            DataItemStatisticsString = decoder.ReadString("DataItemStatisticsString");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DataItemStatisticsDataType value = encodeable as DataItemStatisticsDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_dataItemStatisticsEnum, value.m_dataItemStatisticsEnum)) return false;
            if (!Utils.IsEqual(m_dataItemStatisticsString, value.m_dataItemStatisticsString)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (DataItemStatisticsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemStatisticsDataType clone = (DataItemStatisticsDataType)base.MemberwiseClone();

            clone.m_dataItemStatisticsEnum = (DataItemStatisticsTypeEnum)Utils.Clone(this.m_dataItemStatisticsEnum);
            clone.m_dataItemStatisticsString = (string)Utils.Clone(this.m_dataItemStatisticsString);

            return clone;
        }
        #endregion

        #region Private Fields
        private DataItemStatisticsTypeEnum m_dataItemStatisticsEnum;
        private string m_dataItemStatisticsString;
        #endregion
    }

    #region DataItemStatisticsDataTypeCollection Class
    /// <summary>
    /// A collection of DataItemStatisticsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDataItemStatisticsDataType", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DataItemStatisticsDataType")]
    #if !NET_STANDARD
    public partial class DataItemStatisticsDataTypeCollection : List<DataItemStatisticsDataType>, ICloneable
    #else
    public partial class DataItemStatisticsDataTypeCollection : List<DataItemStatisticsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DataItemStatisticsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DataItemStatisticsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DataItemStatisticsDataTypeCollection(IEnumerable<DataItemStatisticsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DataItemStatisticsDataTypeCollection(DataItemStatisticsDataType[] values)
        {
            if (values != null)
            {
                return new DataItemStatisticsDataTypeCollection(values);
            }

            return new DataItemStatisticsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DataItemStatisticsDataType[](DataItemStatisticsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DataItemStatisticsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemStatisticsDataTypeCollection clone = new DataItemStatisticsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DataItemStatisticsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DataItemStatisticsTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DataItemStatisticsTypeEnum)
    /// <summary>
    /// A description for the DataItemStatisticsTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum DataItemStatisticsTypeEnum
    {
        /// <summary>
        /// A description for the AVERAGE_1 field.
        /// </summary>
        [EnumMember(Value = "AVERAGE_1")]
        AVERAGE_1 = 1,

        /// <summary>
        /// A description for the KURTOSIS_2 field.
        /// </summary>
        [EnumMember(Value = "KURTOSIS_2")]
        KURTOSIS_2 = 2,

        /// <summary>
        /// A description for the MAXIMUM_3 field.
        /// </summary>
        [EnumMember(Value = "MAXIMUM_3")]
        MAXIMUM_3 = 3,

        /// <summary>
        /// A description for the MEAN_4 field.
        /// </summary>
        [EnumMember(Value = "MEAN_4")]
        MEAN_4 = 4,

        /// <summary>
        /// A description for the MINIMUM_5 field.
        /// </summary>
        [EnumMember(Value = "MINIMUM_5")]
        MINIMUM_5 = 5,

        /// <summary>
        /// A description for the MODE_6 field.
        /// </summary>
        [EnumMember(Value = "MODE_6")]
        MODE_6 = 6,

        /// <summary>
        /// A description for the RANGE_7 field.
        /// </summary>
        [EnumMember(Value = "RANGE_7")]
        RANGE_7 = 7,

        /// <summary>
        /// A description for the ROOT_MEAN_SQUARE_8 field.
        /// </summary>
        [EnumMember(Value = "ROOT_MEAN_SQUARE_8")]
        ROOT_MEAN_SQUARE_8 = 8,

        /// <summary>
        /// A description for the STANDARD_DEVIATION_9 field.
        /// </summary>
        [EnumMember(Value = "STANDARD_DEVIATION_9")]
        STANDARD_DEVIATION_9 = 9,
    }

    #region DataItemStatisticsTypeEnumCollection Class
    /// <summary>
    /// A collection of DataItemStatisticsTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDataItemStatisticsTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DataItemStatisticsTypeEnum")]
    #if !NET_STANDARD
    public partial class DataItemStatisticsTypeEnumCollection : List<DataItemStatisticsTypeEnum>, ICloneable
    #else
    public partial class DataItemStatisticsTypeEnumCollection : List<DataItemStatisticsTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DataItemStatisticsTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DataItemStatisticsTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DataItemStatisticsTypeEnumCollection(IEnumerable<DataItemStatisticsTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DataItemStatisticsTypeEnumCollection(DataItemStatisticsTypeEnum[] values)
        {
            if (values != null)
            {
                return new DataItemStatisticsTypeEnumCollection(values);
            }

            return new DataItemStatisticsTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DataItemStatisticsTypeEnum[](DataItemStatisticsTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DataItemStatisticsTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemStatisticsTypeEnumCollection clone = new DataItemStatisticsTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DataItemStatisticsTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DataItemSubEnumTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DataItemSubEnumTypeEnum)
    /// <summary>
    /// A description for the DataItemSubEnumTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum DataItemSubEnumTypeEnum
    {
        /// <summary>
        /// A description for the ACTUAL_1 field.
        /// </summary>
        [EnumMember(Value = "ACTUAL_1")]
        ACTUAL_1 = 1,

        /// <summary>
        /// A description for the ALL_2 field.
        /// </summary>
        [EnumMember(Value = "ALL_2")]
        ALL_2 = 2,

        /// <summary>
        /// A description for the ALTERNATING_3 field.
        /// </summary>
        [EnumMember(Value = "ALTERNATING_3")]
        ALTERNATING_3 = 3,

        /// <summary>
        /// A description for the A_SCALE_4 field.
        /// </summary>
        [EnumMember(Value = "A_SCALE_4")]
        A_SCALE_4 = 4,

        /// <summary>
        /// A description for the BAD_5 field.
        /// </summary>
        [EnumMember(Value = "BAD_5")]
        BAD_5 = 5,

        /// <summary>
        /// A description for the B_SCALE_6 field.
        /// </summary>
        [EnumMember(Value = "B_SCALE_6")]
        B_SCALE_6 = 6,

        /// <summary>
        /// A description for the COMMANDED_7 field.
        /// </summary>
        [EnumMember(Value = "COMMANDED_7")]
        COMMANDED_7 = 7,

        /// <summary>
        /// A description for the CONTROL_8 field.
        /// </summary>
        [EnumMember(Value = "CONTROL_8")]
        CONTROL_8 = 8,

        /// <summary>
        /// A description for the C_SCALE_9 field.
        /// </summary>
        [EnumMember(Value = "C_SCALE_9")]
        C_SCALE_9 = 9,

        /// <summary>
        /// A description for the DIRECT_10 field.
        /// </summary>
        [EnumMember(Value = "DIRECT_10")]
        DIRECT_10 = 10,

        /// <summary>
        /// A description for the DYNAMIC_11 field.
        /// </summary>
        [EnumMember(Value = "DYNAMIC_11")]
        DYNAMIC_11 = 11,

        /// <summary>
        /// A description for the D_SCALE_12 field.
        /// </summary>
        [EnumMember(Value = "D_SCALE_12")]
        D_SCALE_12 = 12,

        /// <summary>
        /// A description for the GOOD_13 field.
        /// </summary>
        [EnumMember(Value = "GOOD_13")]
        GOOD_13 = 13,

        /// <summary>
        /// A description for the KINETIC_14 field.
        /// </summary>
        [EnumMember(Value = "KINETIC_14")]
        KINETIC_14 = 14,

        /// <summary>
        /// A description for the LINE_15 field.
        /// </summary>
        [EnumMember(Value = "LINE_15")]
        LINE_15 = 15,

        /// <summary>
        /// A description for the MAXIMUM_16 field.
        /// </summary>
        [EnumMember(Value = "MAXIMUM_16")]
        MAXIMUM_16 = 16,

        /// <summary>
        /// A description for the MINIMUM_17 field.
        /// </summary>
        [EnumMember(Value = "MINIMUM_17")]
        MINIMUM_17 = 17,

        /// <summary>
        /// A description for the MOLE_18 field.
        /// </summary>
        [EnumMember(Value = "MOLE_18")]
        MOLE_18 = 18,

        /// <summary>
        /// A description for the NO_SCALE_19 field.
        /// </summary>
        [EnumMember(Value = "NO_SCALE_19")]
        NO_SCALE_19 = 19,

        /// <summary>
        /// A description for the OTHER_20 field.
        /// </summary>
        [EnumMember(Value = "OTHER_20")]
        OTHER_20 = 20,

        /// <summary>
        /// A description for the OVERRIDE_21 field.
        /// </summary>
        [EnumMember(Value = "OVERRIDE_21")]
        OVERRIDE_21 = 21,

        /// <summary>
        /// A description for the PROBE_22 field.
        /// </summary>
        [EnumMember(Value = "PROBE_22")]
        PROBE_22 = 22,

        /// <summary>
        /// A description for the TARGET_23 field.
        /// </summary>
        [EnumMember(Value = "TARGET_23")]
        TARGET_23 = 23,

        /// <summary>
        /// A description for the VOLUME_24 field.
        /// </summary>
        [EnumMember(Value = "VOLUME_24")]
        VOLUME_24 = 24,

        /// <summary>
        /// A description for the WEIGHT_25 field.
        /// </summary>
        [EnumMember(Value = "WEIGHT_25")]
        WEIGHT_25 = 25,
    }

    #region DataItemSubEnumTypeEnumCollection Class
    /// <summary>
    /// A collection of DataItemSubEnumTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDataItemSubEnumTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DataItemSubEnumTypeEnum")]
    #if !NET_STANDARD
    public partial class DataItemSubEnumTypeEnumCollection : List<DataItemSubEnumTypeEnum>, ICloneable
    #else
    public partial class DataItemSubEnumTypeEnumCollection : List<DataItemSubEnumTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DataItemSubEnumTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DataItemSubEnumTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DataItemSubEnumTypeEnumCollection(IEnumerable<DataItemSubEnumTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DataItemSubEnumTypeEnumCollection(DataItemSubEnumTypeEnum[] values)
        {
            if (values != null)
            {
                return new DataItemSubEnumTypeEnumCollection(values);
            }

            return new DataItemSubEnumTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DataItemSubEnumTypeEnum[](DataItemSubEnumTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DataItemSubEnumTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DataItemSubEnumTypeEnumCollection clone = new DataItemSubEnumTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DataItemSubEnumTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DefinitionFormatTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DefinitionFormatTypeEnum)
    /// <summary>
    /// A description for the DefinitionFormatTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum DefinitionFormatTypeEnum
    {
        /// <summary>
        /// A description for the EXPRESS_1 field.
        /// </summary>
        [EnumMember(Value = "EXPRESS_1")]
        EXPRESS_1 = 1,

        /// <summary>
        /// A description for the TEXT_2 field.
        /// </summary>
        [EnumMember(Value = "TEXT_2")]
        TEXT_2 = 2,

        /// <summary>
        /// A description for the UNDEFINED_3 field.
        /// </summary>
        [EnumMember(Value = "UNDEFINED_3")]
        UNDEFINED_3 = 3,

        /// <summary>
        /// A description for the XML_4 field.
        /// </summary>
        [EnumMember(Value = "XML_4")]
        XML_4 = 4,
    }

    #region DefinitionFormatTypeEnumCollection Class
    /// <summary>
    /// A collection of DefinitionFormatTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDefinitionFormatTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DefinitionFormatTypeEnum")]
    #if !NET_STANDARD
    public partial class DefinitionFormatTypeEnumCollection : List<DefinitionFormatTypeEnum>, ICloneable
    #else
    public partial class DefinitionFormatTypeEnumCollection : List<DefinitionFormatTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DefinitionFormatTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DefinitionFormatTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DefinitionFormatTypeEnumCollection(IEnumerable<DefinitionFormatTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DefinitionFormatTypeEnumCollection(DefinitionFormatTypeEnum[] values)
        {
            if (values != null)
            {
                return new DefinitionFormatTypeEnumCollection(values);
            }

            return new DefinitionFormatTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DefinitionFormatTypeEnum[](DefinitionFormatTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DefinitionFormatTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DefinitionFormatTypeEnumCollection clone = new DefinitionFormatTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DefinitionFormatTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DirectionTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DirectionTypeEnum)
    /// <summary>
    /// A description for the DirectionTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum DirectionTypeEnum
    {
        /// <summary>
        /// A description for the CLOCKWISE_1 field.
        /// </summary>
        [EnumMember(Value = "CLOCKWISE_1")]
        CLOCKWISE_1 = 1,

        /// <summary>
        /// A description for the COUNTER_CLOCKWISE_2 field.
        /// </summary>
        [EnumMember(Value = "COUNTER_CLOCKWISE_2")]
        COUNTER_CLOCKWISE_2 = 2,

        /// <summary>
        /// A description for the NEGATIVE_3 field.
        /// </summary>
        [EnumMember(Value = "NEGATIVE_3")]
        NEGATIVE_3 = 3,

        /// <summary>
        /// A description for the POSITIVE_4 field.
        /// </summary>
        [EnumMember(Value = "POSITIVE_4")]
        POSITIVE_4 = 4,

        /// <summary>
        /// A description for the UNAVAILABLE_5 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_5")]
        UNAVAILABLE_5 = 5,
    }

    #region DirectionTypeEnumCollection Class
    /// <summary>
    /// A collection of DirectionTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDirectionTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DirectionTypeEnum")]
    #if !NET_STANDARD
    public partial class DirectionTypeEnumCollection : List<DirectionTypeEnum>, ICloneable
    #else
    public partial class DirectionTypeEnumCollection : List<DirectionTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DirectionTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DirectionTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DirectionTypeEnumCollection(IEnumerable<DirectionTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DirectionTypeEnumCollection(DirectionTypeEnum[] values)
        {
            if (values != null)
            {
                return new DirectionTypeEnumCollection(values);
            }

            return new DirectionTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DirectionTypeEnum[](DirectionTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DirectionTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DirectionTypeEnumCollection clone = new DirectionTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DirectionTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DoorStateTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DoorStateTypeEnum)
    /// <summary>
    /// A description for the DoorStateTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum DoorStateTypeEnum
    {
        /// <summary>
        /// A description for the CLOSED_1 field.
        /// </summary>
        [EnumMember(Value = "CLOSED_1")]
        CLOSED_1 = 1,

        /// <summary>
        /// A description for the INDETERMINATE_2 field.
        /// </summary>
        [EnumMember(Value = "INDETERMINATE_2")]
        INDETERMINATE_2 = 2,

        /// <summary>
        /// A description for the OPEN_3 field.
        /// </summary>
        [EnumMember(Value = "OPEN_3")]
        OPEN_3 = 3,

        /// <summary>
        /// A description for the UNAVAILABLE_4 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_4")]
        UNAVAILABLE_4 = 4,
    }

    #region DoorStateTypeEnumCollection Class
    /// <summary>
    /// A collection of DoorStateTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDoorStateTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "DoorStateTypeEnum")]
    #if !NET_STANDARD
    public partial class DoorStateTypeEnumCollection : List<DoorStateTypeEnum>, ICloneable
    #else
    public partial class DoorStateTypeEnumCollection : List<DoorStateTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DoorStateTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DoorStateTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DoorStateTypeEnumCollection(IEnumerable<DoorStateTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DoorStateTypeEnumCollection(DoorStateTypeEnum[] values)
        {
            if (values != null)
            {
                return new DoorStateTypeEnumCollection(values);
            }

            return new DoorStateTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DoorStateTypeEnum[](DoorStateTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DoorStateTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DoorStateTypeEnumCollection clone = new DoorStateTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DoorStateTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EmergencyStopTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_EmergencyStopTypeEnum)
    /// <summary>
    /// A description for the EmergencyStopTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum EmergencyStopTypeEnum
    {
        /// <summary>
        /// A description for the ARMED_1 field.
        /// </summary>
        [EnumMember(Value = "ARMED_1")]
        ARMED_1 = 1,

        /// <summary>
        /// A description for the TRIGGERED_2 field.
        /// </summary>
        [EnumMember(Value = "TRIGGERED_2")]
        TRIGGERED_2 = 2,

        /// <summary>
        /// A description for the UNAVAILABLE_3 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_3")]
        UNAVAILABLE_3 = 3,
    }

    #region EmergencyStopTypeEnumCollection Class
    /// <summary>
    /// A collection of EmergencyStopTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfEmergencyStopTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "EmergencyStopTypeEnum")]
    #if !NET_STANDARD
    public partial class EmergencyStopTypeEnumCollection : List<EmergencyStopTypeEnum>, ICloneable
    #else
    public partial class EmergencyStopTypeEnumCollection : List<EmergencyStopTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public EmergencyStopTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public EmergencyStopTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public EmergencyStopTypeEnumCollection(IEnumerable<EmergencyStopTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator EmergencyStopTypeEnumCollection(EmergencyStopTypeEnum[] values)
        {
            if (values != null)
            {
                return new EmergencyStopTypeEnumCollection(values);
            }

            return new EmergencyStopTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator EmergencyStopTypeEnum[](EmergencyStopTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (EmergencyStopTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EmergencyStopTypeEnumCollection clone = new EmergencyStopTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EmergencyStopTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ExecutionTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ExecutionTypeEnum)
    /// <summary>
    /// A description for the ExecutionTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum ExecutionTypeEnum
    {
        /// <summary>
        /// A description for the ACTIVE_1 field.
        /// </summary>
        [EnumMember(Value = "ACTIVE_1")]
        ACTIVE_1 = 1,

        /// <summary>
        /// A description for the INTERRUPTED_2 field.
        /// </summary>
        [EnumMember(Value = "INTERRUPTED_2")]
        INTERRUPTED_2 = 2,

        /// <summary>
        /// A description for the READY_3 field.
        /// </summary>
        [EnumMember(Value = "READY_3")]
        READY_3 = 3,

        /// <summary>
        /// A description for the STOPPED_4 field.
        /// </summary>
        [EnumMember(Value = "STOPPED_4")]
        STOPPED_4 = 4,

        /// <summary>
        /// A description for the UNAVAILABLE_5 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_5")]
        UNAVAILABLE_5 = 5,
    }

    #region ExecutionTypeEnumCollection Class
    /// <summary>
    /// A collection of ExecutionTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfExecutionTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "ExecutionTypeEnum")]
    #if !NET_STANDARD
    public partial class ExecutionTypeEnumCollection : List<ExecutionTypeEnum>, ICloneable
    #else
    public partial class ExecutionTypeEnumCollection : List<ExecutionTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ExecutionTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ExecutionTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ExecutionTypeEnumCollection(IEnumerable<ExecutionTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ExecutionTypeEnumCollection(ExecutionTypeEnum[] values)
        {
            if (values != null)
            {
                return new ExecutionTypeEnumCollection(values);
            }

            return new ExecutionTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ExecutionTypeEnum[](ExecutionTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ExecutionTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExecutionTypeEnumCollection clone = new ExecutionTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExecutionTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region InterfaceStateTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_InterfaceStateTypeEnum)
    /// <summary>
    /// A description for the InterfaceStateTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum InterfaceStateTypeEnum
    {
        /// <summary>
        /// A description for the ACTIVE_1 field.
        /// </summary>
        [EnumMember(Value = "ACTIVE_1")]
        ACTIVE_1 = 1,

        /// <summary>
        /// A description for the COMPLETE_2 field.
        /// </summary>
        [EnumMember(Value = "COMPLETE_2")]
        COMPLETE_2 = 2,

        /// <summary>
        /// A description for the FAIL_3 field.
        /// </summary>
        [EnumMember(Value = "FAIL_3")]
        FAIL_3 = 3,

        /// <summary>
        /// A description for the READY_4 field.
        /// </summary>
        [EnumMember(Value = "READY_4")]
        READY_4 = 4,
    }

    #region InterfaceStateTypeEnumCollection Class
    /// <summary>
    /// A collection of InterfaceStateTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfInterfaceStateTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "InterfaceStateTypeEnum")]
    #if !NET_STANDARD
    public partial class InterfaceStateTypeEnumCollection : List<InterfaceStateTypeEnum>, ICloneable
    #else
    public partial class InterfaceStateTypeEnumCollection : List<InterfaceStateTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public InterfaceStateTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public InterfaceStateTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public InterfaceStateTypeEnumCollection(IEnumerable<InterfaceStateTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator InterfaceStateTypeEnumCollection(InterfaceStateTypeEnum[] values)
        {
            if (values != null)
            {
                return new InterfaceStateTypeEnumCollection(values);
            }

            return new InterfaceStateTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator InterfaceStateTypeEnum[](InterfaceStateTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (InterfaceStateTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            InterfaceStateTypeEnumCollection clone = new InterfaceStateTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((InterfaceStateTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region LocationsTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_LocationsTypeEnum)
    /// <summary>
    /// A description for the LocationsTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum LocationsTypeEnum
    {
        /// <summary>
        /// A description for the CRIB_1 field.
        /// </summary>
        [EnumMember(Value = "CRIB_1")]
        CRIB_1 = 1,

        /// <summary>
        /// A description for the POT_2 field.
        /// </summary>
        [EnumMember(Value = "POT_2")]
        POT_2 = 2,

        /// <summary>
        /// A description for the STATION_3 field.
        /// </summary>
        [EnumMember(Value = "STATION_3")]
        STATION_3 = 3,

        /// <summary>
        /// A description for the READY_4 field.
        /// </summary>
        [EnumMember(Value = "READY_4")]
        READY_4 = 4,
    }

    #region LocationsTypeEnumCollection Class
    /// <summary>
    /// A collection of LocationsTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfLocationsTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "LocationsTypeEnum")]
    #if !NET_STANDARD
    public partial class LocationsTypeEnumCollection : List<LocationsTypeEnum>, ICloneable
    #else
    public partial class LocationsTypeEnumCollection : List<LocationsTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public LocationsTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public LocationsTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public LocationsTypeEnumCollection(IEnumerable<LocationsTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator LocationsTypeEnumCollection(LocationsTypeEnum[] values)
        {
            if (values != null)
            {
                return new LocationsTypeEnumCollection(values);
            }

            return new LocationsTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator LocationsTypeEnum[](LocationsTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (LocationsTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LocationsTypeEnumCollection clone = new LocationsTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((LocationsTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region NotificationCodeTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_NotificationCodeTypeEnum)
    /// <summary>
    /// A description for the NotificationCodeTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum NotificationCodeTypeEnum
    {
        /// <summary>
        /// A description for the CRASH_1 field.
        /// </summary>
        [EnumMember(Value = "CRASH_1")]
        CRASH_1 = 1,

        /// <summary>
        /// A description for the ESTOP_2 field.
        /// </summary>
        [EnumMember(Value = "ESTOP_2")]
        ESTOP_2 = 2,

        /// <summary>
        /// A description for the FAILURE_3 field.
        /// </summary>
        [EnumMember(Value = "FAILURE_3")]
        FAILURE_3 = 3,

        /// <summary>
        /// A description for the FAULT_4 field.
        /// </summary>
        [EnumMember(Value = "FAULT_4")]
        FAULT_4 = 4,

        /// <summary>
        /// A description for the JAM_5 field.
        /// </summary>
        [EnumMember(Value = "JAM_5")]
        JAM_5 = 5,

        /// <summary>
        /// A description for the MATERIAL_6 field.
        /// </summary>
        [EnumMember(Value = "MATERIAL_6")]
        MATERIAL_6 = 6,

        /// <summary>
        /// A description for the MESSAGE_7 field.
        /// </summary>
        [EnumMember(Value = "MESSAGE_7")]
        MESSAGE_7 = 7,

        /// <summary>
        /// A description for the OTHER_8 field.
        /// </summary>
        [EnumMember(Value = "OTHER_8")]
        OTHER_8 = 8,

        /// <summary>
        /// A description for the OVERLOAD_9 field.
        /// </summary>
        [EnumMember(Value = "OVERLOAD_9")]
        OVERLOAD_9 = 9,
    }

    #region NotificationCodeTypeEnumCollection Class
    /// <summary>
    /// A collection of NotificationCodeTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfNotificationCodeTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "NotificationCodeTypeEnum")]
    #if !NET_STANDARD
    public partial class NotificationCodeTypeEnumCollection : List<NotificationCodeTypeEnum>, ICloneable
    #else
    public partial class NotificationCodeTypeEnumCollection : List<NotificationCodeTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public NotificationCodeTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public NotificationCodeTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public NotificationCodeTypeEnumCollection(IEnumerable<NotificationCodeTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator NotificationCodeTypeEnumCollection(NotificationCodeTypeEnum[] values)
        {
            if (values != null)
            {
                return new NotificationCodeTypeEnumCollection(values);
            }

            return new NotificationCodeTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator NotificationCodeTypeEnum[](NotificationCodeTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (NotificationCodeTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NotificationCodeTypeEnumCollection clone = new NotificationCodeTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((NotificationCodeTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PathModeTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_PathModeTypeEnum)
    /// <summary>
    /// A description for the PathModeTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum PathModeTypeEnum
    {
        /// <summary>
        /// A description for the INDEPENDENT_1 field.
        /// </summary>
        [EnumMember(Value = "INDEPENDENT_1")]
        INDEPENDENT_1 = 1,

        /// <summary>
        /// A description for the MIRROR_2 field.
        /// </summary>
        [EnumMember(Value = "MIRROR_2")]
        MIRROR_2 = 2,

        /// <summary>
        /// A description for the SYNCHRONOUS_3 field.
        /// </summary>
        [EnumMember(Value = "SYNCHRONOUS_3")]
        SYNCHRONOUS_3 = 3,
    }

    #region PathModeTypeEnumCollection Class
    /// <summary>
    /// A collection of PathModeTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPathModeTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "PathModeTypeEnum")]
    #if !NET_STANDARD
    public partial class PathModeTypeEnumCollection : List<PathModeTypeEnum>, ICloneable
    #else
    public partial class PathModeTypeEnumCollection : List<PathModeTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PathModeTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PathModeTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PathModeTypeEnumCollection(IEnumerable<PathModeTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PathModeTypeEnumCollection(PathModeTypeEnum[] values)
        {
            if (values != null)
            {
                return new PathModeTypeEnumCollection(values);
            }

            return new PathModeTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator PathModeTypeEnum[](PathModeTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (PathModeTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PathModeTypeEnumCollection clone = new PathModeTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PathModeTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PowerStateTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_PowerStateTypeEnum)
    /// <summary>
    /// A description for the PowerStateTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum PowerStateTypeEnum
    {
        /// <summary>
        /// A description for the OFF_1 field.
        /// </summary>
        [EnumMember(Value = "OFF_1")]
        OFF_1 = 1,

        /// <summary>
        /// A description for the ON_2 field.
        /// </summary>
        [EnumMember(Value = "ON_2")]
        ON_2 = 2,

        /// <summary>
        /// A description for the UNAVAILABLE_3 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_3")]
        UNAVAILABLE_3 = 3,
    }

    #region PowerStateTypeEnumCollection Class
    /// <summary>
    /// A collection of PowerStateTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPowerStateTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "PowerStateTypeEnum")]
    #if !NET_STANDARD
    public partial class PowerStateTypeEnumCollection : List<PowerStateTypeEnum>, ICloneable
    #else
    public partial class PowerStateTypeEnumCollection : List<PowerStateTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PowerStateTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PowerStateTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PowerStateTypeEnumCollection(IEnumerable<PowerStateTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PowerStateTypeEnumCollection(PowerStateTypeEnum[] values)
        {
            if (values != null)
            {
                return new PowerStateTypeEnumCollection(values);
            }

            return new PowerStateTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator PowerStateTypeEnum[](PowerStateTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (PowerStateTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PowerStateTypeEnumCollection clone = new PowerStateTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PowerStateTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region QualifierTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_QualifierTypeEnum)
    /// <summary>
    /// A description for the QualifierTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum QualifierTypeEnum
    {
        /// <summary>
        /// A description for the HIGH_1 field.
        /// </summary>
        [EnumMember(Value = "HIGH_1")]
        HIGH_1 = 1,

        /// <summary>
        /// A description for the LOW_2 field.
        /// </summary>
        [EnumMember(Value = "LOW_2")]
        LOW_2 = 2,
    }

    #region QualifierTypeEnumCollection Class
    /// <summary>
    /// A collection of QualifierTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfQualifierTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "QualifierTypeEnum")]
    #if !NET_STANDARD
    public partial class QualifierTypeEnumCollection : List<QualifierTypeEnum>, ICloneable
    #else
    public partial class QualifierTypeEnumCollection : List<QualifierTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public QualifierTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public QualifierTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public QualifierTypeEnumCollection(IEnumerable<QualifierTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator QualifierTypeEnumCollection(QualifierTypeEnum[] values)
        {
            if (values != null)
            {
                return new QualifierTypeEnumCollection(values);
            }

            return new QualifierTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator QualifierTypeEnum[](QualifierTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (QualifierTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            QualifierTypeEnumCollection clone = new QualifierTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((QualifierTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RotaryModeTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_RotaryModeTypeEnum)
    /// <summary>
    /// A description for the RotaryModeTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum RotaryModeTypeEnum
    {
        /// <summary>
        /// A description for the CONTOUR_1 field.
        /// </summary>
        [EnumMember(Value = "CONTOUR_1")]
        CONTOUR_1 = 1,

        /// <summary>
        /// A description for the INDEX_2 field.
        /// </summary>
        [EnumMember(Value = "INDEX_2")]
        INDEX_2 = 2,

        /// <summary>
        /// A description for the SPINDLE_3 field.
        /// </summary>
        [EnumMember(Value = "SPINDLE_3")]
        SPINDLE_3 = 3,

        /// <summary>
        /// A description for the UNAVAILABLE_4 field.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_4")]
        UNAVAILABLE_4 = 4,
    }

    #region RotaryModeTypeEnumCollection Class
    /// <summary>
    /// A collection of RotaryModeTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRotaryModeTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "RotaryModeTypeEnum")]
    #if !NET_STANDARD
    public partial class RotaryModeTypeEnumCollection : List<RotaryModeTypeEnum>, ICloneable
    #else
    public partial class RotaryModeTypeEnumCollection : List<RotaryModeTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RotaryModeTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RotaryModeTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RotaryModeTypeEnumCollection(IEnumerable<RotaryModeTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RotaryModeTypeEnumCollection(RotaryModeTypeEnum[] values)
        {
            if (values != null)
            {
                return new RotaryModeTypeEnumCollection(values);
            }

            return new RotaryModeTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RotaryModeTypeEnum[](RotaryModeTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (RotaryModeTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RotaryModeTypeEnumCollection clone = new RotaryModeTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RotaryModeTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SeverityTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_SeverityTypeEnum)
    /// <summary>
    /// A description for the SeverityTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum SeverityTypeEnum
    {
        /// <summary>
        /// A description for the CRITICAL_1 field.
        /// </summary>
        [EnumMember(Value = "CRITICAL_1")]
        CRITICAL_1 = 1,

        /// <summary>
        /// A description for the ERROR_2 field.
        /// </summary>
        [EnumMember(Value = "ERROR_2")]
        ERROR_2 = 2,

        /// <summary>
        /// A description for the INFORMATION_3 field.
        /// </summary>
        [EnumMember(Value = "INFORMATION_3")]
        INFORMATION_3 = 3,

        /// <summary>
        /// A description for the WARNING_4 field.
        /// </summary>
        [EnumMember(Value = "WARNING_4")]
        WARNING_4 = 4,
    }

    #region SeverityTypeEnumCollection Class
    /// <summary>
    /// A collection of SeverityTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSeverityTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "SeverityTypeEnum")]
    #if !NET_STANDARD
    public partial class SeverityTypeEnumCollection : List<SeverityTypeEnum>, ICloneable
    #else
    public partial class SeverityTypeEnumCollection : List<SeverityTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SeverityTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SeverityTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SeverityTypeEnumCollection(IEnumerable<SeverityTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SeverityTypeEnumCollection(SeverityTypeEnum[] values)
        {
            if (values != null)
            {
                return new SeverityTypeEnumCollection(values);
            }

            return new SeverityTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SeverityTypeEnum[](SeverityTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SeverityTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SeverityTypeEnumCollection clone = new SeverityTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SeverityTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ToolLifeDirectionTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ToolLifeDirectionTypeEnum)
    /// <summary>
    /// A description for the ToolLifeDirectionTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum ToolLifeDirectionTypeEnum
    {
        /// <summary>
        /// A description for the DOWN_1 field.
        /// </summary>
        [EnumMember(Value = "DOWN_1")]
        DOWN_1 = 1,

        /// <summary>
        /// A description for the UP_2 field.
        /// </summary>
        [EnumMember(Value = "UP_2")]
        UP_2 = 2,
    }

    #region ToolLifeDirectionTypeEnumCollection Class
    /// <summary>
    /// A collection of ToolLifeDirectionTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfToolLifeDirectionTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "ToolLifeDirectionTypeEnum")]
    #if !NET_STANDARD
    public partial class ToolLifeDirectionTypeEnumCollection : List<ToolLifeDirectionTypeEnum>, ICloneable
    #else
    public partial class ToolLifeDirectionTypeEnumCollection : List<ToolLifeDirectionTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ToolLifeDirectionTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ToolLifeDirectionTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ToolLifeDirectionTypeEnumCollection(IEnumerable<ToolLifeDirectionTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ToolLifeDirectionTypeEnumCollection(ToolLifeDirectionTypeEnum[] values)
        {
            if (values != null)
            {
                return new ToolLifeDirectionTypeEnumCollection(values);
            }

            return new ToolLifeDirectionTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ToolLifeDirectionTypeEnum[](ToolLifeDirectionTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ToolLifeDirectionTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ToolLifeDirectionTypeEnumCollection clone = new ToolLifeDirectionTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ToolLifeDirectionTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ToolLifeTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ToolLifeTypeEnum)
    /// <summary>
    /// A description for the ToolLifeTypeEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd)]
    public enum ToolLifeTypeEnum
    {
        /// <summary>
        /// A description for the MINUTES_1 field.
        /// </summary>
        [EnumMember(Value = "MINUTES_1")]
        MINUTES_1 = 1,

        /// <summary>
        /// A description for the PART_COUNT_2 field.
        /// </summary>
        [EnumMember(Value = "PART_COUNT_2")]
        PART_COUNT_2 = 2,

        /// <summary>
        /// A description for the WEAR_3 field.
        /// </summary>
        [EnumMember(Value = "WEAR_3")]
        WEAR_3 = 3,
    }

    #region ToolLifeTypeEnumCollection Class
    /// <summary>
    /// A collection of ToolLifeTypeEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfToolLifeTypeEnum", Namespace = Opc.Ua.MTConnect.Namespaces.OpcUaMTConnectXsd, ItemName = "ToolLifeTypeEnum")]
    #if !NET_STANDARD
    public partial class ToolLifeTypeEnumCollection : List<ToolLifeTypeEnum>, ICloneable
    #else
    public partial class ToolLifeTypeEnumCollection : List<ToolLifeTypeEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ToolLifeTypeEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ToolLifeTypeEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ToolLifeTypeEnumCollection(IEnumerable<ToolLifeTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ToolLifeTypeEnumCollection(ToolLifeTypeEnum[] values)
        {
            if (values != null)
            {
                return new ToolLifeTypeEnumCollection(values);
            }

            return new ToolLifeTypeEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ToolLifeTypeEnum[](ToolLifeTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ToolLifeTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ToolLifeTypeEnumCollection clone = new ToolLifeTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ToolLifeTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}
