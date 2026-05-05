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

namespace TestModel.WebApi
{
    /// <summary>
    /// The namespaces used in the model.
    /// </summary>
    public static class Namespaces
    {
        /// <remarks />
        public const string Uri = "urn:opcfoundation.org:2024-01:TestModel";
    }

    /// <summary>
    /// The browse names defined in the model.
    /// </summary>
    public static class BrowseNames
    {
        /// <remarks />
        public const string Blue = "Blue";
        /// <remarks />
        public const string EnumUnderscoreTest = "EnumUnderscoreTest";
        /// <remarks />
        public const string ExtendedWorkOrderType = "ExtendedWorkOrderType";
        /// <remarks />
        public const string FinalWorkOrderType = "FinalWorkOrderType";
        /// <remarks />
        public const string HeaterStatus = "HeaterStatus";
        /// <remarks />
        public const string Person = "Person";
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
        public const string Student = "Student";
        /// <remarks />
        public const string Test_Error = "Test_Error";
        /// <remarks />
        public const string Test_ErrorComponent = "Test_ErrorComponent";
        /// <remarks />
        public const string TestAbstractStructure = "TestAbstractStructure";
        /// <remarks />
        public const string TestArrayStructure = "TestArrayStructure";
        /// <remarks />
        public const string TestConcreteStructure = "TestConcreteStructure";
        /// <remarks />
        public const string TestEnumeration = "TestEnumeration";
        /// <remarks />
        public const string TestModel_BinarySchema = "TestModel";
        /// <remarks />
        public const string TestModel_XmlSchema = "TestModel";
        /// <remarks />
        public const string TestObject = "TestObject";
        /// <remarks />
        public const string TestOptionalFields = "TestOptionalFields";
        /// <remarks />
        public const string TestOptionSet = "TestOptionSet";
        /// <remarks />
        public const string TestScalarStructure = "TestScalarStructure";
        /// <remarks />
        public const string TestStructure = "TestStructure";
        /// <remarks />
        public const string TestUnion = "TestUnion";
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
        public const string Z = "Z";
    }

    /// <summary>
    /// The well known identifiers for DataType nodes.
    /// </summary>
    public static class DataTypeIds {
        /// <remarks />
        public const string TestAbstractStructure = "nsu=" + Namespaces.Uri + ";i=1";
        /// <remarks />
        public const string TestConcreteStructure = "nsu=" + Namespaces.Uri + ";i=2";
        /// <remarks />
        public const string TestUnion = "nsu=" + Namespaces.Uri + ";i=163";
        /// <remarks />
        public const string TestOptionalFields = "nsu=" + Namespaces.Uri + ";i=164";
        /// <remarks />
        public const string TestEnumeration = "nsu=" + Namespaces.Uri + ";i=3";
        /// <remarks />
        public const string TestOptionSet = "nsu=" + Namespaces.Uri + ";i=165";
        /// <remarks />
        public const string TestScalarStructure = "nsu=" + Namespaces.Uri + ";i=5";
        /// <remarks />
        public const string TestArrayStructure = "nsu=" + Namespaces.Uri + ";i=6";
        /// <remarks />
        public const string TestStructure = "nsu=" + Namespaces.Uri + ";i=167";
        /// <remarks />
        public const string EnumUnderscoreTest = "nsu=" + Namespaces.Uri + ";i=214";
        /// <remarks />
        public const string HeaterStatus = "nsu=" + Namespaces.Uri + ";i=242";
        /// <remarks />
        public const string Vector = "nsu=" + Namespaces.Uri + ";i=244";
        /// <remarks />
        public const string WorkOrderStatusType = "nsu=" + Namespaces.Uri + ";i=245";
        /// <remarks />
        public const string WorkOrderType = "nsu=" + Namespaces.Uri + ";i=246";
        /// <remarks />
        public const string ExtendedWorkOrderType = "nsu=" + Namespaces.Uri + ";i=247";
        /// <remarks />
        public const string FinalWorkOrderType = "nsu=" + Namespaces.Uri + ";i=248";
        /// <remarks />
        public const string SampleUnion = "nsu=" + Namespaces.Uri + ";i=249";
        /// <remarks />
        public const string SampleStructureWithOptionalFields = "nsu=" + Namespaces.Uri + ";i=250";
        /// <remarks />
        public const string SampleUnionAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=251";
        /// <remarks />
        public const string SampleStructureAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=252";
        /// <remarks />
        public const string Person = "nsu=" + Namespaces.Uri + ";i=255";
        /// <remarks />
        public const string Student = "nsu=" + Namespaces.Uri + ";i=256";

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
        public const string RestrictedObjectType_Blue = "nsu=" + Namespaces.Uri + ";i=232";
        /// <remarks />
        public const string TestObject_Blue = "nsu=" + Namespaces.Uri + ";i=239";

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
        public const string Seeker = "nsu=" + Namespaces.Uri + ";i=195";
        /// <remarks />
        public const string TestObject = "nsu=" + Namespaces.Uri + ";i=233";
        /// <remarks />
        public const string Test_Error = "nsu=" + Namespaces.Uri + ";i=240";
        /// <remarks />
        public const string Test_ErrorComponent = "nsu=" + Namespaces.Uri + ";i=241";
        /// <remarks />
        public const string TestAbstractStructure_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=8";
        /// <remarks />
        public const string TestConcreteStructure_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=9";
        /// <remarks />
        public const string TestUnion_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=168";
        /// <remarks />
        public const string TestOptionalFields_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=169";
        /// <remarks />
        public const string TestScalarStructure_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=10";
        /// <remarks />
        public const string TestArrayStructure_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=11";
        /// <remarks />
        public const string TestStructure_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=170";
        /// <remarks />
        public const string Vector_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=257";
        /// <remarks />
        public const string WorkOrderStatusType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=258";
        /// <remarks />
        public const string WorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=259";
        /// <remarks />
        public const string ExtendedWorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=260";
        /// <remarks />
        public const string FinalWorkOrderType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=261";
        /// <remarks />
        public const string SampleUnion_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=262";
        /// <remarks />
        public const string SampleStructureWithOptionalFields_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=263";
        /// <remarks />
        public const string SampleUnionAllowSubtypes_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=264";
        /// <remarks />
        public const string SampleStructureAllowSubtypes_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=265";
        /// <remarks />
        public const string Person_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=266";
        /// <remarks />
        public const string Student_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=267";
        /// <remarks />
        public const string TestAbstractStructure_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=32";
        /// <remarks />
        public const string TestConcreteStructure_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=33";
        /// <remarks />
        public const string TestUnion_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=180";
        /// <remarks />
        public const string TestOptionalFields_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=181";
        /// <remarks />
        public const string TestScalarStructure_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=34";
        /// <remarks />
        public const string TestArrayStructure_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=35";
        /// <remarks />
        public const string TestStructure_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=182";
        /// <remarks />
        public const string Vector_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=301";
        /// <remarks />
        public const string WorkOrderStatusType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=302";
        /// <remarks />
        public const string WorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=303";
        /// <remarks />
        public const string ExtendedWorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=304";
        /// <remarks />
        public const string FinalWorkOrderType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=305";
        /// <remarks />
        public const string SampleUnion_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=306";
        /// <remarks />
        public const string SampleStructureWithOptionalFields_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=307";
        /// <remarks />
        public const string SampleUnionAllowSubtypes_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=308";
        /// <remarks />
        public const string SampleStructureAllowSubtypes_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=309";
        /// <remarks />
        public const string Person_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=310";
        /// <remarks />
        public const string Student_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=311";
        /// <remarks />
        public const string TestAbstractStructure_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=56";
        /// <remarks />
        public const string TestConcreteStructure_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=57";
        /// <remarks />
        public const string TestUnion_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=192";
        /// <remarks />
        public const string TestOptionalFields_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=193";
        /// <remarks />
        public const string TestScalarStructure_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=58";
        /// <remarks />
        public const string TestArrayStructure_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=59";
        /// <remarks />
        public const string TestStructure_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=194";
        /// <remarks />
        public const string Vector_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=345";
        /// <remarks />
        public const string WorkOrderStatusType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=346";
        /// <remarks />
        public const string WorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=347";
        /// <remarks />
        public const string ExtendedWorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=348";
        /// <remarks />
        public const string FinalWorkOrderType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=349";
        /// <remarks />
        public const string SampleUnion_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=350";
        /// <remarks />
        public const string SampleStructureWithOptionalFields_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=351";
        /// <remarks />
        public const string SampleUnionAllowSubtypes_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=352";
        /// <remarks />
        public const string SampleStructureAllowSubtypes_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=353";
        /// <remarks />
        public const string Person_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=354";
        /// <remarks />
        public const string Student_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=355";

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
        public const string RestrictedObjectType = "nsu=" + Namespaces.Uri + ";i=221";
        /// <remarks />
        public const string WithTwoDimensionalVariableType = "nsu=" + Namespaces.Uri + ";i=253";

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
        public const string TestEnumeration_EnumValues = "nsu=" + Namespaces.Uri + ";i=4";
        /// <remarks />
        public const string TestOptionSet_OptionSetValues = "nsu=" + Namespaces.Uri + ";i=166";
        /// <remarks />
        public const string Seeker_Identities = "nsu=" + Namespaces.Uri + ";i=196";
        /// <remarks />
        public const string Seeker_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=203";
        /// <remarks />
        public const string Seeker_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=205";
        /// <remarks />
        public const string Seeker_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=207";
        /// <remarks />
        public const string Seeker_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=209";
        /// <remarks />
        public const string Seeker_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=211";
        /// <remarks />
        public const string Seeker_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=213";
        /// <remarks />
        public const string EnumUnderscoreTest_EnumValues = "nsu=" + Namespaces.Uri + ";i=215";
        /// <remarks />
        public const string RestrictedVariableType_Yellow = "nsu=" + Namespaces.Uri + ";i=217";
        /// <remarks />
        public const string RestrictedVariableType_X = "nsu=" + Namespaces.Uri + ";i=218";
        /// <remarks />
        public const string RestrictedVariableType_Y = "nsu=" + Namespaces.Uri + ";i=219";
        /// <remarks />
        public const string RestrictedVariableType_Z = "nsu=" + Namespaces.Uri + ";i=220";
        /// <remarks />
        public const string RestrictedObjectType_Red = "nsu=" + Namespaces.Uri + ";i=222";
        /// <remarks />
        public const string RestrictedObjectType_Red_Yellow = "nsu=" + Namespaces.Uri + ";i=223";
        /// <remarks />
        public const string RestrictedObjectType_Red_X = "nsu=" + Namespaces.Uri + ";i=224";
        /// <remarks />
        public const string RestrictedObjectType_Red_Y = "nsu=" + Namespaces.Uri + ";i=225";
        /// <remarks />
        public const string RestrictedObjectType_Red_Z = "nsu=" + Namespaces.Uri + ";i=226";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder = "nsu=" + Namespaces.Uri + ";i=227";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_Yellow = "nsu=" + Namespaces.Uri + ";i=228";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_X = "nsu=" + Namespaces.Uri + ";i=229";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_Y = "nsu=" + Namespaces.Uri + ";i=230";
        /// <remarks />
        public const string RestrictedObjectType_Pink_Placeholder_Z = "nsu=" + Namespaces.Uri + ";i=231";
        /// <remarks />
        public const string TestObject_Red = "nsu=" + Namespaces.Uri + ";i=234";
        /// <remarks />
        public const string TestObject_Red_Yellow = "nsu=" + Namespaces.Uri + ";i=235";
        /// <remarks />
        public const string TestObject_Red_X = "nsu=" + Namespaces.Uri + ";i=236";
        /// <remarks />
        public const string TestObject_Red_Y = "nsu=" + Namespaces.Uri + ";i=237";
        /// <remarks />
        public const string TestObject_Red_Z = "nsu=" + Namespaces.Uri + ";i=238";
        /// <remarks />
        public const string HeaterStatus_EnumStrings = "nsu=" + Namespaces.Uri + ";i=243";
        /// <remarks />
        public const string WithTwoDimensionalVariableType_X = "nsu=" + Namespaces.Uri + ";i=254";
        /// <remarks />
        public const string TestModel_BinarySchema = "nsu=" + Namespaces.Uri + ";i=13";
        /// <remarks />
        public const string TestModel_BinarySchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=15";
        /// <remarks />
        public const string TestModel_BinarySchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=16";
        /// <remarks />
        public const string TestModel_BinarySchema_TestAbstractStructure = "nsu=" + Namespaces.Uri + ";i=17";
        /// <remarks />
        public const string TestModel_BinarySchema_TestConcreteStructure = "nsu=" + Namespaces.Uri + ";i=20";
        /// <remarks />
        public const string TestModel_BinarySchema_TestUnion = "nsu=" + Namespaces.Uri + ";i=171";
        /// <remarks />
        public const string TestModel_BinarySchema_TestOptionalFields = "nsu=" + Namespaces.Uri + ";i=174";
        /// <remarks />
        public const string TestModel_BinarySchema_TestScalarStructure = "nsu=" + Namespaces.Uri + ";i=23";
        /// <remarks />
        public const string TestModel_BinarySchema_TestArrayStructure = "nsu=" + Namespaces.Uri + ";i=26";
        /// <remarks />
        public const string TestModel_BinarySchema_TestStructure = "nsu=" + Namespaces.Uri + ";i=177";
        /// <remarks />
        public const string TestModel_BinarySchema_Vector = "nsu=" + Namespaces.Uri + ";i=268";
        /// <remarks />
        public const string TestModel_BinarySchema_WorkOrderStatusType = "nsu=" + Namespaces.Uri + ";i=271";
        /// <remarks />
        public const string TestModel_BinarySchema_WorkOrderType = "nsu=" + Namespaces.Uri + ";i=274";
        /// <remarks />
        public const string TestModel_BinarySchema_ExtendedWorkOrderType = "nsu=" + Namespaces.Uri + ";i=277";
        /// <remarks />
        public const string TestModel_BinarySchema_FinalWorkOrderType = "nsu=" + Namespaces.Uri + ";i=280";
        /// <remarks />
        public const string TestModel_BinarySchema_SampleUnion = "nsu=" + Namespaces.Uri + ";i=283";
        /// <remarks />
        public const string TestModel_BinarySchema_SampleStructureWithOptionalFields = "nsu=" + Namespaces.Uri + ";i=286";
        /// <remarks />
        public const string TestModel_BinarySchema_SampleUnionAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=289";
        /// <remarks />
        public const string TestModel_BinarySchema_SampleStructureAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=292";
        /// <remarks />
        public const string TestModel_BinarySchema_Person = "nsu=" + Namespaces.Uri + ";i=295";
        /// <remarks />
        public const string TestModel_BinarySchema_Student = "nsu=" + Namespaces.Uri + ";i=298";
        /// <remarks />
        public const string TestModel_XmlSchema = "nsu=" + Namespaces.Uri + ";i=37";
        /// <remarks />
        public const string TestModel_XmlSchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=39";
        /// <remarks />
        public const string TestModel_XmlSchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=40";
        /// <remarks />
        public const string TestModel_XmlSchema_TestAbstractStructure = "nsu=" + Namespaces.Uri + ";i=41";
        /// <remarks />
        public const string TestModel_XmlSchema_TestConcreteStructure = "nsu=" + Namespaces.Uri + ";i=44";
        /// <remarks />
        public const string TestModel_XmlSchema_TestUnion = "nsu=" + Namespaces.Uri + ";i=183";
        /// <remarks />
        public const string TestModel_XmlSchema_TestOptionalFields = "nsu=" + Namespaces.Uri + ";i=186";
        /// <remarks />
        public const string TestModel_XmlSchema_TestScalarStructure = "nsu=" + Namespaces.Uri + ";i=47";
        /// <remarks />
        public const string TestModel_XmlSchema_TestArrayStructure = "nsu=" + Namespaces.Uri + ";i=50";
        /// <remarks />
        public const string TestModel_XmlSchema_TestStructure = "nsu=" + Namespaces.Uri + ";i=189";
        /// <remarks />
        public const string TestModel_XmlSchema_Vector = "nsu=" + Namespaces.Uri + ";i=312";
        /// <remarks />
        public const string TestModel_XmlSchema_WorkOrderStatusType = "nsu=" + Namespaces.Uri + ";i=315";
        /// <remarks />
        public const string TestModel_XmlSchema_WorkOrderType = "nsu=" + Namespaces.Uri + ";i=318";
        /// <remarks />
        public const string TestModel_XmlSchema_ExtendedWorkOrderType = "nsu=" + Namespaces.Uri + ";i=321";
        /// <remarks />
        public const string TestModel_XmlSchema_FinalWorkOrderType = "nsu=" + Namespaces.Uri + ";i=324";
        /// <remarks />
        public const string TestModel_XmlSchema_SampleUnion = "nsu=" + Namespaces.Uri + ";i=327";
        /// <remarks />
        public const string TestModel_XmlSchema_SampleStructureWithOptionalFields = "nsu=" + Namespaces.Uri + ";i=330";
        /// <remarks />
        public const string TestModel_XmlSchema_SampleUnionAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=333";
        /// <remarks />
        public const string TestModel_XmlSchema_SampleStructureAllowSubtypes = "nsu=" + Namespaces.Uri + ";i=336";
        /// <remarks />
        public const string TestModel_XmlSchema_Person = "nsu=" + Namespaces.Uri + ";i=339";
        /// <remarks />
        public const string TestModel_XmlSchema_Student = "nsu=" + Namespaces.Uri + ";i=342";

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
        public const string RestrictedVariableType = "nsu=" + Namespaces.Uri + ";i=216";

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
