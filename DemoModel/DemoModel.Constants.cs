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

namespace DemoModel
{
    #region DataType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class DataTypes
    {
        public const uint EnumUnderscoreTest = 68;

        public const uint HeaterStatus = 1;

        public const uint Vector = 3;

        public const uint WorkOrderStatusType = 4;

        public const uint WorkOrderType = 5;

        public const uint ExtendedWorkOrderType = 322;

        public const uint PenultimateWorkOrderType = 354;

        public const uint FinalWorkOrderType = 332;

        public const uint SampleUnion = 41;

        public const uint SampleStructureWithOptionalFields = 42;

        public const uint SampleUnionAllowSubtypes = 43;

        public const uint SampleStructureAllowSubtypes = 44;

        public const uint Person = 222;

        public const uint Student = 223;
    }
    #endregion

    #region Method Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Methods
    {
        public const uint RestrictedObjectType_BlueType = 342;

        public const uint TestObject_BlueType = 343;
    }
    #endregion

    #region Object Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Objects
    {
        public const uint Seeker = 95;

        public const uint TestObject = 128;

        public const uint Test_Error = 93;

        public const uint Test_ErrorComponent = 94;

        public const uint BrightnessType_Amber_Placeholder = 365;

        public const uint BrightnessType_Green_Placeholder = 367;

        public const uint PictureType_Indigo_Placeholder = 380;

        public const uint Picture = 351;

        public const uint Vector_Encoding_DefaultBinary = 21;

        public const uint WorkOrderStatusType_Encoding_DefaultBinary = 22;

        public const uint WorkOrderType_Encoding_DefaultBinary = 23;

        public const uint ExtendedWorkOrderType_Encoding_DefaultBinary = 323;

        public const uint PenultimateWorkOrderType_Encoding_DefaultBinary = 355;

        public const uint FinalWorkOrderType_Encoding_DefaultBinary = 333;

        public const uint SampleUnion_Encoding_DefaultBinary = 45;

        public const uint SampleStructureWithOptionalFields_Encoding_DefaultBinary = 46;

        public const uint SampleUnionAllowSubtypes_Encoding_DefaultBinary = 47;

        public const uint SampleStructureAllowSubtypes_Encoding_DefaultBinary = 48;

        public const uint Person_Encoding_DefaultBinary = 224;

        public const uint Student_Encoding_DefaultBinary = 225;

        public const uint Vector_Encoding_DefaultXml = 6;

        public const uint WorkOrderStatusType_Encoding_DefaultXml = 7;

        public const uint WorkOrderType_Encoding_DefaultXml = 8;

        public const uint ExtendedWorkOrderType_Encoding_DefaultXml = 327;

        public const uint PenultimateWorkOrderType_Encoding_DefaultXml = 359;

        public const uint FinalWorkOrderType_Encoding_DefaultXml = 337;

        public const uint SampleUnion_Encoding_DefaultXml = 62;

        public const uint SampleStructureWithOptionalFields_Encoding_DefaultXml = 63;

        public const uint SampleUnionAllowSubtypes_Encoding_DefaultXml = 64;

        public const uint SampleStructureAllowSubtypes_Encoding_DefaultXml = 65;

        public const uint Person_Encoding_DefaultXml = 232;

        public const uint Student_Encoding_DefaultXml = 233;

        public const uint Vector_Encoding_DefaultJson = 79;

        public const uint WorkOrderStatusType_Encoding_DefaultJson = 80;

        public const uint WorkOrderType_Encoding_DefaultJson = 81;

        public const uint ExtendedWorkOrderType_Encoding_DefaultJson = 331;

        public const uint PenultimateWorkOrderType_Encoding_DefaultJson = 363;

        public const uint FinalWorkOrderType_Encoding_DefaultJson = 341;

        public const uint SampleUnion_Encoding_DefaultJson = 82;

        public const uint SampleStructureWithOptionalFields_Encoding_DefaultJson = 83;

        public const uint SampleUnionAllowSubtypes_Encoding_DefaultJson = 84;

        public const uint SampleStructureAllowSubtypes_Encoding_DefaultJson = 85;

        public const uint Person_Encoding_DefaultJson = 240;

        public const uint Student_Encoding_DefaultJson = 241;
    }
    #endregion

    #region ObjectType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypes
    {
        public const uint RestrictedObjectType = 124;

        public const uint BrightnessType = 364;

        public const uint PictureType = 348;

        public const uint WithTwoDimensionalVariableType = 120;
    }
    #endregion

    #region Variable Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Variables
    {
        public const uint Seeker_Identities = 10;

        public const uint Seeker_AddIdentity_InputArguments = 25;

        public const uint Seeker_RemoveIdentity_InputArguments = 29;

        public const uint Seeker_AddApplication_InputArguments = 32;

        public const uint Seeker_RemoveApplication_InputArguments = 35;

        public const uint Seeker_AddEndpoint_InputArguments = 52;

        public const uint Seeker_RemoveEndpoint_InputArguments = 55;

        public const uint EnumUnderscoreTest_EnumValues = 69;

        public const uint RestrictedVariableType_Yellow = 123;

        public const uint RestrictedVariableType_X = 210;

        public const uint RestrictedVariableType_Y = 211;

        public const uint RestrictedVariableType_Z = 212;

        public const uint RestrictedObjectType_Red = 125;

        public const uint RestrictedObjectType_Red_Yellow = 57;

        public const uint RestrictedObjectType_Red_X = 213;

        public const uint RestrictedObjectType_Red_Y = 214;

        public const uint RestrictedObjectType_Red_Z = 215;

        public const uint RestrictedObjectType_Pink_Placeholder = 132;

        public const uint RestrictedObjectType_Pink_Placeholder_Yellow = 58;

        public const uint RestrictedObjectType_Pink_Placeholder_X = 216;

        public const uint RestrictedObjectType_Pink_Placeholder_Y = 217;

        public const uint RestrictedObjectType_Pink_Placeholder_Z = 218;

        public const uint TestObject_Red = 60;

        public const uint TestObject_Red_Yellow = 61;

        public const uint TestObject_Red_X = 219;

        public const uint TestObject_Red_Y = 220;

        public const uint TestObject_Red_Z = 221;

        public const uint YellowType_Shade = 346;

        public const uint YellowType_DefaultInstanceBrowseName = 347;

        public const uint BrightnessType_Amber_Placeholder_StateNumber = 366;

        public const uint BrightnessType_Green_Placeholder_CurrentState = 368;

        public const uint BrightnessType_Green_Placeholder_CurrentState_Id = 369;

        public const uint BrightnessType_Green_Placeholder_LastTransition_Id = 374;

        public const uint PictureType_YellowThing = 349;

        public const uint PictureType_YellowThing_Shade = 350;

        public const uint Picture_YellowThing = 352;

        public const uint Picture_YellowThing_Shade = 353;

        public const uint HeaterStatus_EnumStrings = 2;

        public const uint WithTwoDimensionalVariableType_X = 121;

        public const uint DemoModel_BinarySchema = 24;

        public const uint DemoModel_BinarySchema_NamespaceUri = 26;

        public const uint DemoModel_BinarySchema_Deprecated = 49;

        public const uint DemoModel_BinarySchema_Vector = 27;

        public const uint DemoModel_BinarySchema_WorkOrderStatusType = 30;

        public const uint DemoModel_BinarySchema_WorkOrderType = 33;

        public const uint DemoModel_BinarySchema_ExtendedWorkOrderType = 324;

        public const uint DemoModel_BinarySchema_PenultimateWorkOrderType = 356;

        public const uint DemoModel_BinarySchema_FinalWorkOrderType = 334;

        public const uint DemoModel_BinarySchema_SampleUnion = 50;

        public const uint DemoModel_BinarySchema_SampleStructureWithOptionalFields = 53;

        public const uint DemoModel_BinarySchema_SampleUnionAllowSubtypes = 56;

        public const uint DemoModel_BinarySchema_SampleStructureAllowSubtypes = 59;

        public const uint DemoModel_BinarySchema_Person = 226;

        public const uint DemoModel_BinarySchema_Student = 229;

        public const uint DemoModel_XmlSchema = 9;

        public const uint DemoModel_XmlSchema_NamespaceUri = 11;

        public const uint DemoModel_XmlSchema_Deprecated = 66;

        public const uint DemoModel_XmlSchema_Vector = 12;

        public const uint DemoModel_XmlSchema_WorkOrderStatusType = 15;

        public const uint DemoModel_XmlSchema_WorkOrderType = 18;

        public const uint DemoModel_XmlSchema_ExtendedWorkOrderType = 328;

        public const uint DemoModel_XmlSchema_PenultimateWorkOrderType = 360;

        public const uint DemoModel_XmlSchema_FinalWorkOrderType = 338;

        public const uint DemoModel_XmlSchema_SampleUnion = 67;

        public const uint DemoModel_XmlSchema_SampleStructureWithOptionalFields = 70;

        public const uint DemoModel_XmlSchema_SampleUnionAllowSubtypes = 73;

        public const uint DemoModel_XmlSchema_SampleStructureAllowSubtypes = 76;

        public const uint DemoModel_XmlSchema_Person = 234;

        public const uint DemoModel_XmlSchema_Student = 237;
    }
    #endregion

    #region VariableType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableTypes
    {
        public const uint RestrictedVariableType = 122;

        public const uint YellowType = 345;
    }
    #endregion

    #region DataType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class DataTypeIds
    {
        public static readonly ExpandedNodeId EnumUnderscoreTest = new ExpandedNodeId(DemoModel.DataTypes.EnumUnderscoreTest, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId HeaterStatus = new ExpandedNodeId(DemoModel.DataTypes.HeaterStatus, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Vector = new ExpandedNodeId(DemoModel.DataTypes.Vector, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderStatusType = new ExpandedNodeId(DemoModel.DataTypes.WorkOrderStatusType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderType = new ExpandedNodeId(DemoModel.DataTypes.WorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType = new ExpandedNodeId(DemoModel.DataTypes.ExtendedWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PenultimateWorkOrderType = new ExpandedNodeId(DemoModel.DataTypes.PenultimateWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId FinalWorkOrderType = new ExpandedNodeId(DemoModel.DataTypes.FinalWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnion = new ExpandedNodeId(DemoModel.DataTypes.SampleUnion, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields = new ExpandedNodeId(DemoModel.DataTypes.SampleStructureWithOptionalFields, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes = new ExpandedNodeId(DemoModel.DataTypes.SampleUnionAllowSubtypes, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes = new ExpandedNodeId(DemoModel.DataTypes.SampleStructureAllowSubtypes, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Person = new ExpandedNodeId(DemoModel.DataTypes.Person, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Student = new ExpandedNodeId(DemoModel.DataTypes.Student, DemoModel.Namespaces.DemoModel);
    }
    #endregion

    #region Method Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class MethodIds
    {
        public static readonly ExpandedNodeId RestrictedObjectType_BlueType = new ExpandedNodeId(DemoModel.Methods.RestrictedObjectType_BlueType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject_BlueType = new ExpandedNodeId(DemoModel.Methods.TestObject_BlueType, DemoModel.Namespaces.DemoModel);
    }
    #endregion

    #region Object Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectIds
    {
        public static readonly ExpandedNodeId Seeker = new ExpandedNodeId(DemoModel.Objects.Seeker, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject = new ExpandedNodeId(DemoModel.Objects.TestObject, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Test_Error = new ExpandedNodeId(DemoModel.Objects.Test_Error, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Test_ErrorComponent = new ExpandedNodeId(DemoModel.Objects.Test_ErrorComponent, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType_Amber_Placeholder = new ExpandedNodeId(DemoModel.Objects.BrightnessType_Amber_Placeholder, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType_Green_Placeholder = new ExpandedNodeId(DemoModel.Objects.BrightnessType_Green_Placeholder, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PictureType_Indigo_Placeholder = new ExpandedNodeId(DemoModel.Objects.PictureType_Indigo_Placeholder, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Picture = new ExpandedNodeId(DemoModel.Objects.Picture, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Vector_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.Vector_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderStatusType_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.WorkOrderStatusType_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.WorkOrderType_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.ExtendedWorkOrderType_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PenultimateWorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.PenultimateWorkOrderType_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId FinalWorkOrderType_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.FinalWorkOrderType_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnion_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.SampleUnion_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.SampleStructureWithOptionalFields_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.SampleUnionAllowSubtypes_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.SampleStructureAllowSubtypes_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Person_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.Person_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Student_Encoding_DefaultBinary = new ExpandedNodeId(DemoModel.Objects.Student_Encoding_DefaultBinary, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Vector_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.Vector_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderStatusType_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.WorkOrderStatusType_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.WorkOrderType_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.ExtendedWorkOrderType_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PenultimateWorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.PenultimateWorkOrderType_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId FinalWorkOrderType_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.FinalWorkOrderType_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnion_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.SampleUnion_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.SampleStructureWithOptionalFields_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.SampleUnionAllowSubtypes_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.SampleStructureAllowSubtypes_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Person_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.Person_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Student_Encoding_DefaultXml = new ExpandedNodeId(DemoModel.Objects.Student_Encoding_DefaultXml, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Vector_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.Vector_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderStatusType_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.WorkOrderStatusType_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.WorkOrderType_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId ExtendedWorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.ExtendedWorkOrderType_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PenultimateWorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.PenultimateWorkOrderType_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId FinalWorkOrderType_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.FinalWorkOrderType_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnion_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.SampleUnion_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureWithOptionalFields_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.SampleStructureWithOptionalFields_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleUnionAllowSubtypes_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.SampleUnionAllowSubtypes_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId SampleStructureAllowSubtypes_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.SampleStructureAllowSubtypes_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Person_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.Person_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Student_Encoding_DefaultJson = new ExpandedNodeId(DemoModel.Objects.Student_Encoding_DefaultJson, DemoModel.Namespaces.DemoModel);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypeIds
    {
        public static readonly ExpandedNodeId RestrictedObjectType = new ExpandedNodeId(DemoModel.ObjectTypes.RestrictedObjectType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType = new ExpandedNodeId(DemoModel.ObjectTypes.BrightnessType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PictureType = new ExpandedNodeId(DemoModel.ObjectTypes.PictureType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WithTwoDimensionalVariableType = new ExpandedNodeId(DemoModel.ObjectTypes.WithTwoDimensionalVariableType, DemoModel.Namespaces.DemoModel);
    }
    #endregion

    #region Variable Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableIds
    {
        public static readonly ExpandedNodeId Seeker_Identities = new ExpandedNodeId(DemoModel.Variables.Seeker_Identities, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Seeker_AddIdentity_InputArguments = new ExpandedNodeId(DemoModel.Variables.Seeker_AddIdentity_InputArguments, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Seeker_RemoveIdentity_InputArguments = new ExpandedNodeId(DemoModel.Variables.Seeker_RemoveIdentity_InputArguments, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Seeker_AddApplication_InputArguments = new ExpandedNodeId(DemoModel.Variables.Seeker_AddApplication_InputArguments, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Seeker_RemoveApplication_InputArguments = new ExpandedNodeId(DemoModel.Variables.Seeker_RemoveApplication_InputArguments, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Seeker_AddEndpoint_InputArguments = new ExpandedNodeId(DemoModel.Variables.Seeker_AddEndpoint_InputArguments, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Seeker_RemoveEndpoint_InputArguments = new ExpandedNodeId(DemoModel.Variables.Seeker_RemoveEndpoint_InputArguments, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId EnumUnderscoreTest_EnumValues = new ExpandedNodeId(DemoModel.Variables.EnumUnderscoreTest_EnumValues, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedVariableType_Yellow = new ExpandedNodeId(DemoModel.Variables.RestrictedVariableType_Yellow, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedVariableType_X = new ExpandedNodeId(DemoModel.Variables.RestrictedVariableType_X, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedVariableType_Y = new ExpandedNodeId(DemoModel.Variables.RestrictedVariableType_Y, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedVariableType_Z = new ExpandedNodeId(DemoModel.Variables.RestrictedVariableType_Z, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Red, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_Yellow = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Red_Yellow, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_X = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Red_X, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_Y = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Red_Y, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Red_Z = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Red_Z, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Pink_Placeholder, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_Yellow = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Pink_Placeholder_Yellow, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_X = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Pink_Placeholder_X, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_Y = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Pink_Placeholder_Y, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId RestrictedObjectType_Pink_Placeholder_Z = new ExpandedNodeId(DemoModel.Variables.RestrictedObjectType_Pink_Placeholder_Z, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject_Red = new ExpandedNodeId(DemoModel.Variables.TestObject_Red, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject_Red_Yellow = new ExpandedNodeId(DemoModel.Variables.TestObject_Red_Yellow, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject_Red_X = new ExpandedNodeId(DemoModel.Variables.TestObject_Red_X, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject_Red_Y = new ExpandedNodeId(DemoModel.Variables.TestObject_Red_Y, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId TestObject_Red_Z = new ExpandedNodeId(DemoModel.Variables.TestObject_Red_Z, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId YellowType_Shade = new ExpandedNodeId(DemoModel.Variables.YellowType_Shade, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId YellowType_DefaultInstanceBrowseName = new ExpandedNodeId(DemoModel.Variables.YellowType_DefaultInstanceBrowseName, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType_Amber_Placeholder_StateNumber = new ExpandedNodeId(DemoModel.Variables.BrightnessType_Amber_Placeholder_StateNumber, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType_Green_Placeholder_CurrentState = new ExpandedNodeId(DemoModel.Variables.BrightnessType_Green_Placeholder_CurrentState, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType_Green_Placeholder_CurrentState_Id = new ExpandedNodeId(DemoModel.Variables.BrightnessType_Green_Placeholder_CurrentState_Id, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId BrightnessType_Green_Placeholder_LastTransition_Id = new ExpandedNodeId(DemoModel.Variables.BrightnessType_Green_Placeholder_LastTransition_Id, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PictureType_YellowThing = new ExpandedNodeId(DemoModel.Variables.PictureType_YellowThing, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId PictureType_YellowThing_Shade = new ExpandedNodeId(DemoModel.Variables.PictureType_YellowThing_Shade, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Picture_YellowThing = new ExpandedNodeId(DemoModel.Variables.Picture_YellowThing, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId Picture_YellowThing_Shade = new ExpandedNodeId(DemoModel.Variables.Picture_YellowThing_Shade, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId HeaterStatus_EnumStrings = new ExpandedNodeId(DemoModel.Variables.HeaterStatus_EnumStrings, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId WithTwoDimensionalVariableType_X = new ExpandedNodeId(DemoModel.Variables.WithTwoDimensionalVariableType_X, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_NamespaceUri = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_NamespaceUri, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_Deprecated = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_Deprecated, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_Vector = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_Vector, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_WorkOrderStatusType = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_WorkOrderStatusType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_WorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_WorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_ExtendedWorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_ExtendedWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_PenultimateWorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_PenultimateWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_FinalWorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_FinalWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_SampleUnion = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_SampleUnion, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_SampleStructureWithOptionalFields = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_SampleStructureWithOptionalFields, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_SampleUnionAllowSubtypes = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_SampleUnionAllowSubtypes, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_SampleStructureAllowSubtypes = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_SampleStructureAllowSubtypes, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_Person = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_Person, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_BinarySchema_Student = new ExpandedNodeId(DemoModel.Variables.DemoModel_BinarySchema_Student, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_NamespaceUri = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_NamespaceUri, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_Deprecated = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_Deprecated, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_Vector = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_Vector, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_WorkOrderStatusType = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_WorkOrderStatusType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_WorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_WorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_ExtendedWorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_ExtendedWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_PenultimateWorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_PenultimateWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_FinalWorkOrderType = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_FinalWorkOrderType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_SampleUnion = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_SampleUnion, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_SampleStructureWithOptionalFields = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_SampleStructureWithOptionalFields, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_SampleUnionAllowSubtypes = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_SampleUnionAllowSubtypes, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_SampleStructureAllowSubtypes = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_SampleStructureAllowSubtypes, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_Person = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_Person, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId DemoModel_XmlSchema_Student = new ExpandedNodeId(DemoModel.Variables.DemoModel_XmlSchema_Student, DemoModel.Namespaces.DemoModel);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableTypeIds
    {
        public static readonly ExpandedNodeId RestrictedVariableType = new ExpandedNodeId(DemoModel.VariableTypes.RestrictedVariableType, DemoModel.Namespaces.DemoModel);

        public static readonly ExpandedNodeId YellowType = new ExpandedNodeId(DemoModel.VariableTypes.YellowType, DemoModel.Namespaces.DemoModel);
    }
    #endregion

    #region BrowseName Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class BrowseNames
    {
        public const string Amber_Placeholder = "<Amber>";

        public const string BlueType = "BlueType";

        public const string BrightnessType = "BrightnessType";

        public const string DemoModel_BinarySchema = "DemoModel";

        public const string DemoModel_XmlSchema = "DemoModel";

        public const string EnumUnderscoreTest = "EnumUnderscoreTest";

        public const string ExtendedWorkOrderType = "ExtendedWorkOrderType";

        public const string FinalWorkOrderType = "FinalWorkOrderType";

        public const string Green_Placeholder = "<Green>";

        public const string HeaterStatus = "HeaterStatus";

        public const string Indigo_Placeholder = "<Indigo>";

        public const string PenultimateWorkOrderType = "PenultimateWorkOrderType";

        public const string Person = "Person";

        public const string Picture = "Picture";

        public const string PictureType = "PictureType";

        public const string Pink_Placeholder = "<Pink>";

        public const string Red = "Red";

        public const string RestrictedObjectType = "RestrictedObjectType";

        public const string RestrictedVariableType = "RestrictedVariableType";

        public const string SampleStructureAllowSubtypes = "SampleStructureAllowSubtypes";

        public const string SampleStructureWithOptionalFields = "SampleStructureWithOptionalFields";

        public const string SampleUnion = "SampleUnion";

        public const string SampleUnionAllowSubtypes = "SampleUnionAllowSubtypes";

        public const string Seeker = "Seeker";

        public const string Shade = "Shade";

        public const string Student = "Student";

        public const string Test_Error = "Test_Error";

        public const string Test_ErrorComponent = "Test_ErrorComponent";

        public const string TestObject = "TestObject";

        public const string Vector = "Vector";

        public const string WithTwoDimensionalVariableType = "WithTwoDimensionalVariableType";

        public const string WorkOrderStatusType = "WorkOrderStatusType";

        public const string WorkOrderType = "WorkOrderType";

        public const string X = "X";

        public const string Y = "Y";

        public const string Yellow = "Yellow";

        public const string YellowThing = "YellowThing";

        public const string YellowType = "YellowType";

        public const string Z = "Z";
    }
    #endregion

    #region Namespace Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the DemoModel namespace (.NET code namespace is 'DemoModel').
        /// </summary>
        public const string DemoModel = "urn:opcfoundation.org:2024-01:DemoModel";

        /// <summary>
        /// The URI for the DemoModelXsd namespace (.NET code namespace is 'DemoModel').
        /// </summary>
        public const string DemoModelXsd = "urn:opcfoundation.org:2024-01:DemoModelTypes.xsd";

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
