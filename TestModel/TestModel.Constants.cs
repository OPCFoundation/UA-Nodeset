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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1707 // Identifiers should not contain underscores

namespace TestModel
{
    #region DataType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class DataTypes
    {
        public const uint TestAbstractStructure = 1;

        public const uint TestConcreteStructure = 2;

        public const uint TestUnion = 163;

        public const uint TestOptionalFields = 164;

        public const uint TestEnumeration = 3;

        public const uint TestOptionSet = 165;

        public const uint TestScalarStructure = 5;

        public const uint TestArrayStructure = 6;

        public const uint TestStructure = 167;

        public const uint EnumUnderscoreTest = 214;

        public const uint HeaterStatus = 242;

        public const uint Vector = 244;

        public const uint WorkOrderStatusType = 245;

        public const uint WorkOrderType = 246;

        public const uint ExtendedWorkOrderType = 247;

        public const uint FinalWorkOrderType = 248;

        public const uint SampleUnion = 249;

        public const uint SampleStructureWithOptionalFields = 250;

        public const uint SampleUnionAllowSubtypes = 251;

        public const uint SampleStructureAllowSubtypes = 252;

        public const uint Person = 255;

        public const uint Student = 256;
    }
    #endregion

    #region Method Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Methods
    {
        public const uint RestrictedObjectType_Blue = 232;

        public const uint TestObject_Blue = 239;
    }
    #endregion

    #region Object Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Objects
    {
        public const uint Seeker = 195;

        public const uint TestObject = 233;

        public const uint Test_Error = 240;

        public const uint Test_ErrorComponent = 241;

        public const uint TestAbstractStructure_Encoding_DefaultBinary = 8;

        public const uint TestConcreteStructure_Encoding_DefaultBinary = 9;

        public const uint TestUnion_Encoding_DefaultBinary = 168;

        public const uint TestOptionalFields_Encoding_DefaultBinary = 169;

        public const uint TestScalarStructure_Encoding_DefaultBinary = 10;

        public const uint TestArrayStructure_Encoding_DefaultBinary = 11;

        public const uint TestStructure_Encoding_DefaultBinary = 170;

        public const uint Vector_Encoding_DefaultBinary = 257;

        public const uint WorkOrderStatusType_Encoding_DefaultBinary = 258;

        public const uint WorkOrderType_Encoding_DefaultBinary = 259;

        public const uint ExtendedWorkOrderType_Encoding_DefaultBinary = 260;

        public const uint FinalWorkOrderType_Encoding_DefaultBinary = 261;

        public const uint SampleUnion_Encoding_DefaultBinary = 262;

        public const uint SampleStructureWithOptionalFields_Encoding_DefaultBinary = 263;

        public const uint SampleUnionAllowSubtypes_Encoding_DefaultBinary = 264;

        public const uint SampleStructureAllowSubtypes_Encoding_DefaultBinary = 265;

        public const uint Person_Encoding_DefaultBinary = 266;

        public const uint Student_Encoding_DefaultBinary = 267;

        public const uint TestAbstractStructure_Encoding_DefaultXml = 32;

        public const uint TestConcreteStructure_Encoding_DefaultXml = 33;

        public const uint TestUnion_Encoding_DefaultXml = 180;

        public const uint TestOptionalFields_Encoding_DefaultXml = 181;

        public const uint TestScalarStructure_Encoding_DefaultXml = 34;

        public const uint TestArrayStructure_Encoding_DefaultXml = 35;

        public const uint TestStructure_Encoding_DefaultXml = 182;

        public const uint Vector_Encoding_DefaultXml = 301;

        public const uint WorkOrderStatusType_Encoding_DefaultXml = 302;

        public const uint WorkOrderType_Encoding_DefaultXml = 303;

        public const uint ExtendedWorkOrderType_Encoding_DefaultXml = 304;

        public const uint FinalWorkOrderType_Encoding_DefaultXml = 305;

        public const uint SampleUnion_Encoding_DefaultXml = 306;

        public const uint SampleStructureWithOptionalFields_Encoding_DefaultXml = 307;

        public const uint SampleUnionAllowSubtypes_Encoding_DefaultXml = 308;

        public const uint SampleStructureAllowSubtypes_Encoding_DefaultXml = 309;

        public const uint Person_Encoding_DefaultXml = 310;

        public const uint Student_Encoding_DefaultXml = 311;

        public const uint TestAbstractStructure_Encoding_DefaultJson = 56;

        public const uint TestConcreteStructure_Encoding_DefaultJson = 57;

        public const uint TestUnion_Encoding_DefaultJson = 192;

        public const uint TestOptionalFields_Encoding_DefaultJson = 193;

        public const uint TestScalarStructure_Encoding_DefaultJson = 58;

        public const uint TestArrayStructure_Encoding_DefaultJson = 59;

        public const uint TestStructure_Encoding_DefaultJson = 194;

        public const uint Vector_Encoding_DefaultJson = 345;

        public const uint WorkOrderStatusType_Encoding_DefaultJson = 346;

        public const uint WorkOrderType_Encoding_DefaultJson = 347;

        public const uint ExtendedWorkOrderType_Encoding_DefaultJson = 348;

        public const uint FinalWorkOrderType_Encoding_DefaultJson = 349;

        public const uint SampleUnion_Encoding_DefaultJson = 350;

        public const uint SampleStructureWithOptionalFields_Encoding_DefaultJson = 351;

        public const uint SampleUnionAllowSubtypes_Encoding_DefaultJson = 352;

        public const uint SampleStructureAllowSubtypes_Encoding_DefaultJson = 353;

        public const uint Person_Encoding_DefaultJson = 354;

        public const uint Student_Encoding_DefaultJson = 355;
    }
    #endregion

    #region ObjectType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypes
    {
        public const uint RestrictedObjectType = 221;

        public const uint WithTwoDimensionalVariableType = 253;
    }
    #endregion

    #region Variable Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Variables
    {
        public const uint TestEnumeration_EnumValues = 4;

        public const uint TestOptionSet_OptionSetValues = 166;

        public const uint Seeker_Identities = 196;

        public const uint Seeker_AddIdentity_InputArguments = 203;

        public const uint Seeker_RemoveIdentity_InputArguments = 205;

        public const uint Seeker_AddApplication_InputArguments = 207;

        public const uint Seeker_RemoveApplication_InputArguments = 209;

        public const uint Seeker_AddEndpoint_InputArguments = 211;

        public const uint Seeker_RemoveEndpoint_InputArguments = 213;

        public const uint EnumUnderscoreTest_EnumValues = 215;

        public const uint RestrictedVariableType_Yellow = 217;

        public const uint RestrictedVariableType_X = 218;

        public const uint RestrictedVariableType_Y = 219;

        public const uint RestrictedVariableType_Z = 220;

        public const uint RestrictedObjectType_Red = 222;

        public const uint RestrictedObjectType_Red_Yellow = 223;

        public const uint RestrictedObjectType_Red_X = 224;

        public const uint RestrictedObjectType_Red_Y = 225;

        public const uint RestrictedObjectType_Red_Z = 226;

        public const uint RestrictedObjectType_Pink_Placeholder = 227;

        public const uint RestrictedObjectType_Pink_Placeholder_Yellow = 228;

        public const uint RestrictedObjectType_Pink_Placeholder_X = 229;

        public const uint RestrictedObjectType_Pink_Placeholder_Y = 230;

        public const uint RestrictedObjectType_Pink_Placeholder_Z = 231;

        public const uint TestObject_Red = 234;

        public const uint TestObject_Red_Yellow = 235;

        public const uint TestObject_Red_X = 236;

        public const uint TestObject_Red_Y = 237;

        public const uint TestObject_Red_Z = 238;

        public const uint HeaterStatus_EnumStrings = 243;

        public const uint WithTwoDimensionalVariableType_X = 254;

        public const uint TestModel_BinarySchema = 13;

        public const uint TestModel_BinarySchema_NamespaceUri = 15;

        public const uint TestModel_BinarySchema_Deprecated = 16;

        public const uint TestModel_BinarySchema_TestAbstractStructure = 17;

        public const uint TestModel_BinarySchema_TestConcreteStructure = 20;

        public const uint TestModel_BinarySchema_TestUnion = 171;

        public const uint TestModel_BinarySchema_TestOptionalFields = 174;

        public const uint TestModel_BinarySchema_TestScalarStructure = 23;

        public const uint TestModel_BinarySchema_TestArrayStructure = 26;

        public const uint TestModel_BinarySchema_TestStructure = 177;

        public const uint TestModel_BinarySchema_Vector = 268;

        public const uint TestModel_BinarySchema_WorkOrderStatusType = 271;

        public const uint TestModel_BinarySchema_WorkOrderType = 274;

        public const uint TestModel_BinarySchema_ExtendedWorkOrderType = 277;

        public const uint TestModel_BinarySchema_FinalWorkOrderType = 280;

        public const uint TestModel_BinarySchema_SampleUnion = 283;

        public const uint TestModel_BinarySchema_SampleStructureWithOptionalFields = 286;

        public const uint TestModel_BinarySchema_SampleUnionAllowSubtypes = 289;

        public const uint TestModel_BinarySchema_SampleStructureAllowSubtypes = 292;

        public const uint TestModel_BinarySchema_Person = 295;

        public const uint TestModel_BinarySchema_Student = 298;

        public const uint TestModel_XmlSchema = 37;

        public const uint TestModel_XmlSchema_NamespaceUri = 39;

        public const uint TestModel_XmlSchema_Deprecated = 40;

        public const uint TestModel_XmlSchema_TestAbstractStructure = 41;

        public const uint TestModel_XmlSchema_TestConcreteStructure = 44;

        public const uint TestModel_XmlSchema_TestUnion = 183;

        public const uint TestModel_XmlSchema_TestOptionalFields = 186;

        public const uint TestModel_XmlSchema_TestScalarStructure = 47;

        public const uint TestModel_XmlSchema_TestArrayStructure = 50;

        public const uint TestModel_XmlSchema_TestStructure = 189;

        public const uint TestModel_XmlSchema_Vector = 312;

        public const uint TestModel_XmlSchema_WorkOrderStatusType = 315;

        public const uint TestModel_XmlSchema_WorkOrderType = 318;

        public const uint TestModel_XmlSchema_ExtendedWorkOrderType = 321;

        public const uint TestModel_XmlSchema_FinalWorkOrderType = 324;

        public const uint TestModel_XmlSchema_SampleUnion = 327;

        public const uint TestModel_XmlSchema_SampleStructureWithOptionalFields = 330;

        public const uint TestModel_XmlSchema_SampleUnionAllowSubtypes = 333;

        public const uint TestModel_XmlSchema_SampleStructureAllowSubtypes = 336;

        public const uint TestModel_XmlSchema_Person = 339;

        public const uint TestModel_XmlSchema_Student = 342;
    }
    #endregion

    #region VariableType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableTypes
    {
        public const uint RestrictedVariableType = 216;
    }
    #endregion

    #region DataType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class DataTypeIds
    {
        public static readonly ExpandedNodeId TestAbstractStructure = new ExpandedNodeId(TestModel.DataTypes.TestAbstractStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestConcreteStructure = new ExpandedNodeId(TestModel.DataTypes.TestConcreteStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestUnion = new ExpandedNodeId(TestModel.DataTypes.TestUnion, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestOptionalFields = new ExpandedNodeId(TestModel.DataTypes.TestOptionalFields, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestEnumeration = new ExpandedNodeId(TestModel.DataTypes.TestEnumeration, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestOptionSet = new ExpandedNodeId(TestModel.DataTypes.TestOptionSet, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestScalarStructure = new ExpandedNodeId(TestModel.DataTypes.TestScalarStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestArrayStructure = new ExpandedNodeId(TestModel.DataTypes.TestArrayStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestStructure = new ExpandedNodeId(TestModel.DataTypes.TestStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId EnumUnderscoreTest = new ExpandedNodeId(TestModel.DataTypes.EnumUnderscoreTest, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId HeaterStatus = new ExpandedNodeId(TestModel.DataTypes.HeaterStatus, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Vector = new ExpandedNodeId(TestModel.DataTypes.Vector, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderStatusType = new ExpandedNodeId(TestModel.DataTypes.WorkOrderStatusType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderType = new ExpandedNodeId(TestModel.DataTypes.WorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType = new ExpandedNodeId(TestModel.DataTypes.ExtendedWorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId FinalWorkOrderType = new ExpandedNodeId(TestModel.DataTypes.FinalWorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnion = new ExpandedNodeId(TestModel.DataTypes.SampleUnion, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields = new ExpandedNodeId(TestModel.DataTypes.SampleStructureWithOptionalFields, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes = new ExpandedNodeId(TestModel.DataTypes.SampleUnionAllowSubtypes, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes = new ExpandedNodeId(TestModel.DataTypes.SampleStructureAllowSubtypes, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Person = new ExpandedNodeId(TestModel.DataTypes.Person, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Student = new ExpandedNodeId(TestModel.DataTypes.Student, TestModel.Namespaces.TestModel);
    }
    #endregion

    #region Method Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class MethodIds
    {
        public static readonly ExpandedNodeId RestrictedObjectType_Blue = new ExpandedNodeId(TestModel.Methods.RestrictedObjectType_Blue, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject_Blue = new ExpandedNodeId(TestModel.Methods.TestObject_Blue, TestModel.Namespaces.TestModel);
    }
    #endregion

    #region Object Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectIds
    {
        public static readonly ExpandedNodeId Seeker = new ExpandedNodeId(TestModel.Objects.Seeker, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject = new ExpandedNodeId(TestModel.Objects.TestObject, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Test_Error = new ExpandedNodeId(TestModel.Objects.Test_Error, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Test_ErrorComponent = new ExpandedNodeId(TestModel.Objects.Test_ErrorComponent, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestAbstractStructure_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestAbstractStructure_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestConcreteStructure_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestConcreteStructure_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestUnion_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestUnion_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestOptionalFields_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestOptionalFields_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestScalarStructure_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestScalarStructure_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestArrayStructure_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestArrayStructure_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestStructure_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.TestStructure_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Vector_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.Vector_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderStatusType_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.WorkOrderStatusType_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.WorkOrderType_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.ExtendedWorkOrderType_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId FinalWorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.FinalWorkOrderType_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnion_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.SampleUnion_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.SampleStructureWithOptionalFields_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.SampleUnionAllowSubtypes_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.SampleStructureAllowSubtypes_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Person_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.Person_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Student_Encoding_DefaultBinary = new ExpandedNodeId(TestModel.Objects.Student_Encoding_DefaultBinary, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestAbstractStructure_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestAbstractStructure_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestConcreteStructure_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestConcreteStructure_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestUnion_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestUnion_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestOptionalFields_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestOptionalFields_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestScalarStructure_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestScalarStructure_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestArrayStructure_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestArrayStructure_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestStructure_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.TestStructure_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Vector_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.Vector_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderStatusType_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.WorkOrderStatusType_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.WorkOrderType_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.ExtendedWorkOrderType_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId FinalWorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.FinalWorkOrderType_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnion_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.SampleUnion_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.SampleStructureWithOptionalFields_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.SampleUnionAllowSubtypes_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.SampleStructureAllowSubtypes_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Person_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.Person_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Student_Encoding_DefaultXml = new ExpandedNodeId(TestModel.Objects.Student_Encoding_DefaultXml, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestAbstractStructure_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestAbstractStructure_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestConcreteStructure_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestConcreteStructure_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestUnion_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestUnion_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestOptionalFields_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestOptionalFields_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestScalarStructure_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestScalarStructure_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestArrayStructure_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestArrayStructure_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestStructure_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.TestStructure_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Vector_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.Vector_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderStatusType_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.WorkOrderStatusType_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.WorkOrderType_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.ExtendedWorkOrderType_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId FinalWorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.FinalWorkOrderType_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnion_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.SampleUnion_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.SampleStructureWithOptionalFields_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.SampleUnionAllowSubtypes_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.SampleStructureAllowSubtypes_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Person_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.Person_Encoding_DefaultJson, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Student_Encoding_DefaultJson = new ExpandedNodeId(TestModel.Objects.Student_Encoding_DefaultJson, TestModel.Namespaces.TestModel);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypeIds
    {
        public static readonly ExpandedNodeId RestrictedObjectType = new ExpandedNodeId(TestModel.ObjectTypes.RestrictedObjectType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WithTwoDimensionalVariableType = new ExpandedNodeId(TestModel.ObjectTypes.WithTwoDimensionalVariableType, TestModel.Namespaces.TestModel);
    }
    #endregion

    #region Variable Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableIds
    {
        public static readonly ExpandedNodeId TestEnumeration_EnumValues = new ExpandedNodeId(TestModel.Variables.TestEnumeration_EnumValues, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestOptionSet_OptionSetValues = new ExpandedNodeId(TestModel.Variables.TestOptionSet_OptionSetValues, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_Identities = new ExpandedNodeId(TestModel.Variables.Seeker_Identities, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_AddIdentity_InputArguments = new ExpandedNodeId(TestModel.Variables.Seeker_AddIdentity_InputArguments, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_RemoveIdentity_InputArguments = new ExpandedNodeId(TestModel.Variables.Seeker_RemoveIdentity_InputArguments, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_AddApplication_InputArguments = new ExpandedNodeId(TestModel.Variables.Seeker_AddApplication_InputArguments, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_RemoveApplication_InputArguments = new ExpandedNodeId(TestModel.Variables.Seeker_RemoveApplication_InputArguments, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_AddEndpoint_InputArguments = new ExpandedNodeId(TestModel.Variables.Seeker_AddEndpoint_InputArguments, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId Seeker_RemoveEndpoint_InputArguments = new ExpandedNodeId(TestModel.Variables.Seeker_RemoveEndpoint_InputArguments, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId EnumUnderscoreTest_EnumValues = new ExpandedNodeId(TestModel.Variables.EnumUnderscoreTest_EnumValues, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedVariableType_Yellow = new ExpandedNodeId(TestModel.Variables.RestrictedVariableType_Yellow, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedVariableType_X = new ExpandedNodeId(TestModel.Variables.RestrictedVariableType_X, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedVariableType_Y = new ExpandedNodeId(TestModel.Variables.RestrictedVariableType_Y, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedVariableType_Z = new ExpandedNodeId(TestModel.Variables.RestrictedVariableType_Z, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Red, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_Yellow = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Red_Yellow, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_X = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Red_X, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_Y = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Red_Y, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_Z = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Red_Z, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Pink_Placeholder, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_Yellow = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Pink_Placeholder_Yellow, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_X = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Pink_Placeholder_X, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_Y = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Pink_Placeholder_Y, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_Z = new ExpandedNodeId(TestModel.Variables.RestrictedObjectType_Pink_Placeholder_Z, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject_Red = new ExpandedNodeId(TestModel.Variables.TestObject_Red, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject_Red_Yellow = new ExpandedNodeId(TestModel.Variables.TestObject_Red_Yellow, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject_Red_X = new ExpandedNodeId(TestModel.Variables.TestObject_Red_X, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject_Red_Y = new ExpandedNodeId(TestModel.Variables.TestObject_Red_Y, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestObject_Red_Z = new ExpandedNodeId(TestModel.Variables.TestObject_Red_Z, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId HeaterStatus_EnumStrings = new ExpandedNodeId(TestModel.Variables.HeaterStatus_EnumStrings, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId WithTwoDimensionalVariableType_X = new ExpandedNodeId(TestModel.Variables.WithTwoDimensionalVariableType_X, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_NamespaceUri = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_NamespaceUri, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_Deprecated = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_Deprecated, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestAbstractStructure = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestAbstractStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestConcreteStructure = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestConcreteStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestUnion = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestUnion, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestOptionalFields = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestOptionalFields, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestScalarStructure = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestScalarStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestArrayStructure = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestArrayStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_TestStructure = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_TestStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_Vector = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_Vector, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_WorkOrderStatusType = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_WorkOrderStatusType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_WorkOrderType = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_WorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_ExtendedWorkOrderType = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_ExtendedWorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_FinalWorkOrderType = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_FinalWorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_SampleUnion = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_SampleUnion, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_SampleStructureWithOptionalFields = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_SampleStructureWithOptionalFields, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_SampleUnionAllowSubtypes = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_SampleUnionAllowSubtypes, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_SampleStructureAllowSubtypes = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_SampleStructureAllowSubtypes, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_Person = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_Person, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_BinarySchema_Student = new ExpandedNodeId(TestModel.Variables.TestModel_BinarySchema_Student, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_NamespaceUri = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_NamespaceUri, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_Deprecated = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_Deprecated, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestAbstractStructure = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestAbstractStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestConcreteStructure = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestConcreteStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestUnion = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestUnion, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestOptionalFields = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestOptionalFields, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestScalarStructure = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestScalarStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestArrayStructure = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestArrayStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_TestStructure = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_TestStructure, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_Vector = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_Vector, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_WorkOrderStatusType = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_WorkOrderStatusType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_WorkOrderType = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_WorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_ExtendedWorkOrderType = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_ExtendedWorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_FinalWorkOrderType = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_FinalWorkOrderType, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_SampleUnion = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_SampleUnion, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_SampleStructureWithOptionalFields = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_SampleStructureWithOptionalFields, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_SampleUnionAllowSubtypes = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_SampleUnionAllowSubtypes, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_SampleStructureAllowSubtypes = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_SampleStructureAllowSubtypes, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_Person = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_Person, TestModel.Namespaces.TestModel);

        public static readonly ExpandedNodeId TestModel_XmlSchema_Student = new ExpandedNodeId(TestModel.Variables.TestModel_XmlSchema_Student, TestModel.Namespaces.TestModel);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableTypeIds
    {
        public static readonly ExpandedNodeId RestrictedVariableType = new ExpandedNodeId(TestModel.VariableTypes.RestrictedVariableType, TestModel.Namespaces.TestModel);
    }
    #endregion

    #region BrowseName Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class BrowseNames
    {
        public const string Blue = "Blue";

        public const string EnumUnderscoreTest = "EnumUnderscoreTest";

        public const string ExtendedWorkOrderType = "ExtendedWorkOrderType";

        public const string FinalWorkOrderType = "FinalWorkOrderType";

        public const string HeaterStatus = "HeaterStatus";

        public const string Person = "Person";

        public const string Pink_Placeholder = "<Pink>";

        public const string Red = "Red";

        public const string RestrictedObjectType = "RestrictedObjectType";

        public const string RestrictedVariableType = "RestrictedVariableType";

        public const string SampleStructureAllowSubtypes = "SampleStructureAllowSubtypes";

        public const string SampleStructureWithOptionalFields = "SampleStructureWithOptionalFields";

        public const string SampleUnion = "SampleUnion";

        public const string SampleUnionAllowSubtypes = "SampleUnionAllowSubtypes";

        public const string Seeker = "Seeker";

        public const string Student = "Student";

        public const string Test_Error = "Test_Error";

        public const string Test_ErrorComponent = "Test_ErrorComponent";

        public const string TestAbstractStructure = "TestAbstractStructure";

        public const string TestArrayStructure = "TestArrayStructure";

        public const string TestConcreteStructure = "TestConcreteStructure";

        public const string TestEnumeration = "TestEnumeration";

        public const string TestModel_BinarySchema = "TestModel";

        public const string TestModel_XmlSchema = "TestModel";

        public const string TestObject = "TestObject";

        public const string TestOptionalFields = "TestOptionalFields";

        public const string TestOptionSet = "TestOptionSet";

        public const string TestScalarStructure = "TestScalarStructure";

        public const string TestStructure = "TestStructure";

        public const string TestUnion = "TestUnion";

        public const string Vector = "Vector";

        public const string WithTwoDimensionalVariableType = "WithTwoDimensionalVariableType";

        public const string WorkOrderStatusType = "WorkOrderStatusType";

        public const string WorkOrderType = "WorkOrderType";

        public const string X = "X";

        public const string Y = "Y";

        public const string Yellow = "Yellow";

        public const string Z = "Z";
    }
    #endregion

    #region Namespace Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the TestModel namespace (.NET code namespace is 'TestModel').
        /// </summary>
        public const string TestModel = "urn:opcfoundation.org:2024-01:TestModel";

        /// <summary>
        /// The URI for the TestModelXsd namespace (.NET code namespace is 'TestModel').
        /// </summary>
        public const string TestModelXsd = "urn:opcfoundation.org:2024-01:TestModelTypes.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}
