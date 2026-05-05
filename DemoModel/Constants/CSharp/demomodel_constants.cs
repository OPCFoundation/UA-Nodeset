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
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1515 // Types can be made internal

namespace DemoModel.WebApi
{
    /// <summary>
    /// The namespaces used in the model.
    /// </summary>
    public static class Namespaces
    {
        /// <remarks />
        public const string Uri = "urn:opcfoundation.org:2024-01:DemoModel";
    }

    /// <summary>
    /// The browse names defined in the model.
    /// </summary>
    public static class BrowseNames
    {
        /// <remarks />
        public const string Amber_Placeholder = "<Amber>";
        /// <remarks />
        public const string BlueType = "BlueType";
        /// <remarks />
        public const string BrightnessType = "BrightnessType";
        /// <remarks />
        public const string DemoModel_BinarySchema = "DemoModel";
        /// <remarks />
        public const string DemoModel_XmlSchema = "DemoModel";
        /// <remarks />
        public const string EnumUnderscoreTest = "EnumUnderscoreTest";
        /// <remarks />
        public const string ExtendedWorkOrderType = "ExtendedWorkOrderType";
        /// <remarks />
        public const string FinalWorkOrderType = "FinalWorkOrderType";
        /// <remarks />
        public const string Green_Placeholder = "<Green>";
        /// <remarks />
        public const string HeaterStatus = "HeaterStatus";
        /// <remarks />
        public const string Indigo_Placeholder = "<Indigo>";
        /// <remarks />
        public const string PenultimateWorkOrderType = "PenultimateWorkOrderType";
        /// <remarks />
        public const string Person = "Person";
        /// <remarks />
        public const string Picture = "Picture";
        /// <remarks />
        public const string PictureType = "PictureType";
        /// <remarks />
        public const string Pink_Placeholder = "<Pink>";
        /// <remarks />
        public const string Red = "Red";
        /// <remarks />
        public const string RestrictedObjectType = "RestrictedObjectType";
        /// <remarks />
        public const string RestrictedVariableType = "RestrictedVariableType";
        /// <remarks />
        public const string SampleStructureAllowSubtypes = "SampleStructureAllowSubtypes";
        /// <remarks />
        public const string SampleStructureWithOptionalFields = "SampleStructureWithOptionalFields";
        /// <remarks />
        public const string SampleUnion = "SampleUnion";
        /// <remarks />
        public const string SampleUnionAllowSubtypes = "SampleUnionAllowSubtypes";
        /// <remarks />
        public const string Seeker = "Seeker";
        /// <remarks />
        public const string Shade = "Shade";
        /// <remarks />
        public const string Student = "Student";
        /// <remarks />
        public const string Test_Error = "Test_Error";
        /// <remarks />
        public const string Test_ErrorComponent = "Test_ErrorComponent";
        /// <remarks />
        public const string TestObject = "TestObject";
        /// <remarks />
        public const string Vector = "Vector";
        /// <remarks />
        public const string WithTwoDimensionalVariableType = "WithTwoDimensionalVariableType";
        /// <remarks />
        public const string WorkOrderStatusType = "WorkOrderStatusType";
        /// <remarks />
        public const string WorkOrderType = "WorkOrderType";
        /// <remarks />
        public const string X = "X";
        /// <remarks />
        public const string Y = "Y";
        /// <remarks />
        public const string Yellow = "Yellow";
        /// <remarks />
        public const string YellowThing = "YellowThing";
        /// <remarks />
        public const string YellowType = "YellowType";
        /// <remarks />
        public const string Z = "Z";
    }

    /// <summary>
    /// The well known identifiers for DataType nodes.
    /// </summary>
    public static class DataTypeIds {
        /// <remarks />
        public const string EnumUnderscoreTest = "nsu=" + Namespaces.Uri + ";i=68";
        /// <remarks />
        public const string HeaterStatus = "nsu=" + Namespaces.Uri + ";i=1";
        /// <remarks />
        public const string Vector = "nsu=" + Namespaces.Uri + ";i=3";
        /// <remarks />
        public const string WorkOrderStatusType = "nsu=" + Namespaces.Uri + ";i=4";
        /// <remarks />
        public const string WorkOrderType = "nsu=" + Namespaces.Uri + ";i=5";
        /// <remarks />
        public const string ExtendedWorkOrderType = "nsu=" + Namespaces.Uri + ";i=322";
        /// <remarks />
        public const string PenultimateWorkOrderType = "nsu=" + Namespaces.Uri + ";i=354";
        /// <remarks />
        public const string FinalWorkOrderType = "nsu=" + Namespaces.Uri + ";i=332";
        /// <remarks />
        public const string SampleUnion = "nsu=" + Namespaces.Uri + ";i=41";
        /// <remarks />
        public const string SampleStructureWithOptionalFields = "nsu=" + Namespaces.Uri + ";i=42";
        /// <remarks />
        public const string SampleUnionAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=43";
        /// <remarks />
        public const string SampleStructureAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=44";
        /// <remarks />
        public const string Person = "nsu=" + Namespaces.Uri + ";i=222";
        /// <remarks />
        public const string Student = "nsu=" + Namespaces.Uri + ";i=223";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(DataTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Method nodes.
    /// </summary>
    public static class MethodIds {
        /// <remarks />
        public const string RestrictedObjectType_BlueType = "nsu=" + Namespaces.Uri + ";i=342";
        /// <remarks />
        public const string TestObject_BlueType = "nsu=" + Namespaces.Uri + ";i=343";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(MethodIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Object nodes.
    /// </summary>
    public static class ObjectIds {
        /// <remarks />
        public const string Seeker = "nsu=" + Namespaces.Uri + ";i=95";
        /// <remarks />
        public const string TestObject = "nsu=" + Namespaces.Uri + ";i=128";
        /// <remarks />
        public const string Test_Error = "nsu=" + Namespaces.Uri + ";i=93";
        /// <remarks />
        public const string Test_ErrorComponent = "nsu=" + Namespaces.Uri + ";i=94";
        /// <remarks />
        public const string BrightnessType_Amber_Placeholder = "nsu=" + Namespaces.Uri + ";i=365";
        /// <remarks />
        public const string BrightnessType_Green_Placeholder = "nsu=" + Namespaces.Uri + ";i=367";
        /// <remarks />
        public const string PictureType_Indigo_Placeholder = "nsu=" + Namespaces.Uri + ";i=380";
        /// <remarks />
        public const string Picture = "nsu=" + Namespaces.Uri + ";i=351";
        /// <remarks />
        public const string Vector_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=21";
        /// <remarks />
        public const string WorkOrderStatusType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=22";
        /// <remarks />
        public const string WorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=23";
        /// <remarks />
        public const string ExtendedWorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=323";
        /// <remarks />
        public const string PenultimateWorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=355";
        /// <remarks />
        public const string FinalWorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=333";
        /// <remarks />
        public const string SampleUnion_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=45";
        /// <remarks />
        public const string SampleStructureWithOptionalFields_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=46";
        /// <remarks />
        public const string SampleUnionAllowSubtypes_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=47";
        /// <remarks />
        public const string SampleStructureAllowSubtypes_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=48";
        /// <remarks />
        public const string Person_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=224";
        /// <remarks />
        public const string Student_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=225";
        /// <remarks />
        public const string Vector_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=6";
        /// <remarks />
        public const string WorkOrderStatusType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=7";
        /// <remarks />
        public const string WorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=8";
        /// <remarks />
        public const string ExtendedWorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=327";
        /// <remarks />
        public const string PenultimateWorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=359";
        /// <remarks />
        public const string FinalWorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=337";
        /// <remarks />
        public const string SampleUnion_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=62";
        /// <remarks />
        public const string SampleStructureWithOptionalFields_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=63";
        /// <remarks />
        public const string SampleUnionAllowSubtypes_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=64";
        /// <remarks />
        public const string SampleStructureAllowSubtypes_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=65";
        /// <remarks />
        public const string Person_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=232";
        /// <remarks />
        public const string Student_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=233";
        /// <remarks />
        public const string Vector_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=79";
        /// <remarks />
        public const string WorkOrderStatusType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=80";
        /// <remarks />
        public const string WorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=81";
        /// <remarks />
        public const string ExtendedWorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=331";
        /// <remarks />
        public const string PenultimateWorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=363";
        /// <remarks />
        public const string FinalWorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=341";
        /// <remarks />
        public const string SampleUnion_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=82";
        /// <remarks />
        public const string SampleStructureWithOptionalFields_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=83";
        /// <remarks />
        public const string SampleUnionAllowSubtypes_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=84";
        /// <remarks />
        public const string SampleStructureAllowSubtypes_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=85";
        /// <remarks />
        public const string Person_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=240";
        /// <remarks />
        public const string Student_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=241";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for ObjectType nodes.
    /// </summary>
    public static class ObjectTypeIds {
        /// <remarks />
        public const string RestrictedObjectType = "nsu=" + Namespaces.Uri + ";i=124";
        /// <remarks />
        public const string BrightnessType = "nsu=" + Namespaces.Uri + ";i=364";
        /// <remarks />
        public const string PictureType = "nsu=" + Namespaces.Uri + ";i=348";
        /// <remarks />
        public const string WithTwoDimensionalVariableType = "nsu=" + Namespaces.Uri + ";i=120";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Variable nodes.
    /// </summary>
    public static class VariableIds {
        /// <remarks />
        public const string Seeker_Identities = "nsu=" + Namespaces.Uri + ";i=10";
        /// <remarks />
        public const string Seeker_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=25";
        /// <remarks />
        public const string Seeker_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=29";
        /// <remarks />
        public const string Seeker_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=32";
        /// <remarks />
        public const string Seeker_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=35";
        /// <remarks />
        public const string Seeker_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=52";
        /// <remarks />
        public const string Seeker_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=55";
        /// <remarks />
        public const string EnumUnderscoreTest_EnumValues = "nsu=" + Namespaces.Uri + ";i=69";
        /// <remarks />
        public const string RestrictedVariableType_Yellow = "nsu=" + Namespaces.Uri + ";i=123";
        /// <remarks />
        public const string RestrictedVariableType_X = "nsu=" + Namespaces.Uri + ";i=210";
        /// <remarks />
        public const string RestrictedVariableType_Y = "nsu=" + Namespaces.Uri + ";i=211";
        /// <remarks />
        public const string RestrictedVariableType_Z = "nsu=" + Namespaces.Uri + ";i=212";
        /// <remarks />
        public const string RestrictedObjectType_Red = "nsu=" + Namespaces.Uri + ";i=125";
        /// <remarks />
        public const string RestrictedObjectType_Red_Yellow = "nsu=" + Namespaces.Uri + ";i=57";
        /// <remarks />
        public const string RestrictedObjectType_Red_X = "nsu=" + Namespaces.Uri + ";i=213";
        /// <remarks />
        public const string RestrictedObjectType_Red_Y = "nsu=" + Namespaces.Uri + ";i=214";
        /// <remarks />
        public const string RestrictedObjectType_Red_Z = "nsu=" + Namespaces.Uri + ";i=215";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder = "nsu=" + Namespaces.Uri + ";i=132";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_Yellow = "nsu=" + Namespaces.Uri + ";i=58";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_X = "nsu=" + Namespaces.Uri + ";i=216";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_Y = "nsu=" + Namespaces.Uri + ";i=217";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_Z = "nsu=" + Namespaces.Uri + ";i=218";
        /// <remarks />
        public const string TestObject_Red = "nsu=" + Namespaces.Uri + ";i=60";
        /// <remarks />
        public const string TestObject_Red_Yellow = "nsu=" + Namespaces.Uri + ";i=61";
        /// <remarks />
        public const string TestObject_Red_X = "nsu=" + Namespaces.Uri + ";i=219";
        /// <remarks />
        public const string TestObject_Red_Y = "nsu=" + Namespaces.Uri + ";i=220";
        /// <remarks />
        public const string TestObject_Red_Z = "nsu=" + Namespaces.Uri + ";i=221";
        /// <remarks />
        public const string YellowType_Shade = "nsu=" + Namespaces.Uri + ";i=346";
        /// <remarks />
        public const string YellowType_DefaultInstanceBrowseName = "nsu=" + Namespaces.Uri + ";i=347";
        /// <remarks />
        public const string BrightnessType_Amber_Placeholder_StateNumber = "nsu=" + Namespaces.Uri + ";i=366";
        /// <remarks />
        public const string BrightnessType_Green_Placeholder_CurrentState = "nsu=" + Namespaces.Uri + ";i=368";
        /// <remarks />
        public const string BrightnessType_Green_Placeholder_CurrentState_Id = "nsu=" + Namespaces.Uri + ";i=369";
        /// <remarks />
        public const string BrightnessType_Green_Placeholder_LastTransition_Id = "nsu=" + Namespaces.Uri + ";i=374";
        /// <remarks />
        public const string PictureType_YellowThing = "nsu=" + Namespaces.Uri + ";i=349";
        /// <remarks />
        public const string PictureType_YellowThing_Shade = "nsu=" + Namespaces.Uri + ";i=350";
        /// <remarks />
        public const string Picture_YellowThing = "nsu=" + Namespaces.Uri + ";i=352";
        /// <remarks />
        public const string Picture_YellowThing_Shade = "nsu=" + Namespaces.Uri + ";i=353";
        /// <remarks />
        public const string HeaterStatus_EnumStrings = "nsu=" + Namespaces.Uri + ";i=2";
        /// <remarks />
        public const string WithTwoDimensionalVariableType_X = "nsu=" + Namespaces.Uri + ";i=121";
        /// <remarks />
        public const string DemoModel_BinarySchema = "nsu=" + Namespaces.Uri + ";i=24";
        /// <remarks />
        public const string DemoModel_BinarySchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=26";
        /// <remarks />
        public const string DemoModel_BinarySchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=49";
        /// <remarks />
        public const string DemoModel_BinarySchema_Vector = "nsu=" + Namespaces.Uri + ";i=27";
        /// <remarks />
        public const string DemoModel_BinarySchema_WorkOrderStatusType = "nsu=" + Namespaces.Uri + ";i=30";
        /// <remarks />
        public const string DemoModel_BinarySchema_WorkOrderType = "nsu=" + Namespaces.Uri + ";i=33";
        /// <remarks />
        public const string DemoModel_BinarySchema_ExtendedWorkOrderType = "nsu=" + Namespaces.Uri + ";i=324";
        /// <remarks />
        public const string DemoModel_BinarySchema_PenultimateWorkOrderType = "nsu=" + Namespaces.Uri + ";i=356";
        /// <remarks />
        public const string DemoModel_BinarySchema_FinalWorkOrderType = "nsu=" + Namespaces.Uri + ";i=334";
        /// <remarks />
        public const string DemoModel_BinarySchema_SampleUnion = "nsu=" + Namespaces.Uri + ";i=50";
        /// <remarks />
        public const string DemoModel_BinarySchema_SampleStructureWithOptionalFields = "nsu=" + Namespaces.Uri + ";i=53";
        /// <remarks />
        public const string DemoModel_BinarySchema_SampleUnionAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=56";
        /// <remarks />
        public const string DemoModel_BinarySchema_SampleStructureAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=59";
        /// <remarks />
        public const string DemoModel_BinarySchema_Person = "nsu=" + Namespaces.Uri + ";i=226";
        /// <remarks />
        public const string DemoModel_BinarySchema_Student = "nsu=" + Namespaces.Uri + ";i=229";
        /// <remarks />
        public const string DemoModel_XmlSchema = "nsu=" + Namespaces.Uri + ";i=9";
        /// <remarks />
        public const string DemoModel_XmlSchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=11";
        /// <remarks />
        public const string DemoModel_XmlSchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=66";
        /// <remarks />
        public const string DemoModel_XmlSchema_Vector = "nsu=" + Namespaces.Uri + ";i=12";
        /// <remarks />
        public const string DemoModel_XmlSchema_WorkOrderStatusType = "nsu=" + Namespaces.Uri + ";i=15";
        /// <remarks />
        public const string DemoModel_XmlSchema_WorkOrderType = "nsu=" + Namespaces.Uri + ";i=18";
        /// <remarks />
        public const string DemoModel_XmlSchema_ExtendedWorkOrderType = "nsu=" + Namespaces.Uri + ";i=328";
        /// <remarks />
        public const string DemoModel_XmlSchema_PenultimateWorkOrderType = "nsu=" + Namespaces.Uri + ";i=360";
        /// <remarks />
        public const string DemoModel_XmlSchema_FinalWorkOrderType = "nsu=" + Namespaces.Uri + ";i=338";
        /// <remarks />
        public const string DemoModel_XmlSchema_SampleUnion = "nsu=" + Namespaces.Uri + ";i=67";
        /// <remarks />
        public const string DemoModel_XmlSchema_SampleStructureWithOptionalFields = "nsu=" + Namespaces.Uri + ";i=70";
        /// <remarks />
        public const string DemoModel_XmlSchema_SampleUnionAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=73";
        /// <remarks />
        public const string DemoModel_XmlSchema_SampleStructureAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=76";
        /// <remarks />
        public const string DemoModel_XmlSchema_Person = "nsu=" + Namespaces.Uri + ";i=234";
        /// <remarks />
        public const string DemoModel_XmlSchema_Student = "nsu=" + Namespaces.Uri + ";i=237";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(VariableIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for VariableType nodes.
    /// </summary>
    public static class VariableTypeIds {
        /// <remarks />
        public const string RestrictedVariableType = "nsu=" + Namespaces.Uri + ";i=122";
        /// <remarks />
        public const string YellowType = "nsu=" + Namespaces.Uri + ";i=345";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(VariableTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }
    
}
