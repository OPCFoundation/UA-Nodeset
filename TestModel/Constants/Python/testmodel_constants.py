from enum import Enum

class Namespaces(Enum):
     Uri = "urn:opcfoundation.org:2024-01:TestModel"

class BrowseNames(Enum):
    Blue = "Blue"
    EnumUnderscoreTest = "EnumUnderscoreTest"
    ExtendedWorkOrderType = "ExtendedWorkOrderType"
    FinalWorkOrderType = "FinalWorkOrderType"
    HeaterStatus = "HeaterStatus"
    Person = "Person"
    Pink_Placeholder = "<Pink>"
    Red = "Red"
    RestrictedObjectType = "RestrictedObjectType"
    RestrictedVariableType = "RestrictedVariableType"
    SampleStructureAllowSubtypes = "SampleStructureAllowSubtypes"
    SampleStructureWithOptionalFields = "SampleStructureWithOptionalFields"
    SampleUnion = "SampleUnion"
    SampleUnionAllowSubtypes = "SampleUnionAllowSubtypes"
    Seeker = "Seeker"
    Student = "Student"
    Test_Error = "Test_Error"
    Test_ErrorComponent = "Test_ErrorComponent"
    TestAbstractStructure = "TestAbstractStructure"
    TestArrayStructure = "TestArrayStructure"
    TestConcreteStructure = "TestConcreteStructure"
    TestEnumeration = "TestEnumeration"
    TestModel_BinarySchema = "TestModel"
    TestModel_XmlSchema = "TestModel"
    TestObject = "TestObject"
    TestOptionalFields = "TestOptionalFields"
    TestOptionSet = "TestOptionSet"
    TestScalarStructure = "TestScalarStructure"
    TestStructure = "TestStructure"
    TestUnion = "TestUnion"
    Vector = "Vector"
    WithTwoDimensionalVariableType = "WithTwoDimensionalVariableType"
    WorkOrderStatusType = "WorkOrderStatusType"
    WorkOrderType = "WorkOrderType"
    X = "X"
    Y = "Y"
    Yellow = "Yellow"
    Z = "Z"

class DataTypeIds(Enum):
    TestAbstractStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=1"
    TestConcreteStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=2"
    TestUnion = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=163"
    TestOptionalFields = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=164"
    TestEnumeration = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=3"
    TestOptionSet = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=165"
    TestScalarStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=5"
    TestArrayStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=6"
    TestStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=167"
    EnumUnderscoreTest = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=214"
    HeaterStatus = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=242"
    Vector = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=244"
    WorkOrderStatusType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=245"
    WorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=246"
    ExtendedWorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=247"
    FinalWorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=248"
    SampleUnion = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=249"
    SampleStructureWithOptionalFields = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=250"
    SampleUnionAllowSubtypes = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=251"
    SampleStructureAllowSubtypes = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=252"
    Person = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=255"
    Student = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=256"

def get_DataTypeIds_name(value: str) -> str:
    try:
        return DataTypeIds(value).name
    except ValueError:
        return None


class MethodIds(Enum):
    RestrictedObjectType_Blue = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=232"
    TestObject_Blue = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=239"

def get_MethodIds_name(value: str) -> str:
    try:
        return MethodIds(value).name
    except ValueError:
        return None


class ObjectIds(Enum):
    Seeker = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=195"
    TestObject = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=233"
    Test_Error = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=240"
    Test_ErrorComponent = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=241"
    TestAbstractStructure_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=8"
    TestConcreteStructure_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=9"
    TestUnion_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=168"
    TestOptionalFields_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=169"
    TestScalarStructure_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=10"
    TestArrayStructure_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=11"
    TestStructure_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=170"
    Vector_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=257"
    WorkOrderStatusType_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=258"
    WorkOrderType_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=259"
    ExtendedWorkOrderType_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=260"
    FinalWorkOrderType_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=261"
    SampleUnion_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=262"
    SampleStructureWithOptionalFields_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=263"
    SampleUnionAllowSubtypes_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=264"
    SampleStructureAllowSubtypes_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=265"
    Person_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=266"
    Student_Encoding_DefaultBinary = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=267"
    TestAbstractStructure_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=32"
    TestConcreteStructure_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=33"
    TestUnion_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=180"
    TestOptionalFields_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=181"
    TestScalarStructure_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=34"
    TestArrayStructure_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=35"
    TestStructure_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=182"
    Vector_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=301"
    WorkOrderStatusType_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=302"
    WorkOrderType_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=303"
    ExtendedWorkOrderType_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=304"
    FinalWorkOrderType_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=305"
    SampleUnion_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=306"
    SampleStructureWithOptionalFields_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=307"
    SampleUnionAllowSubtypes_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=308"
    SampleStructureAllowSubtypes_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=309"
    Person_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=310"
    Student_Encoding_DefaultXml = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=311"
    TestAbstractStructure_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=56"
    TestConcreteStructure_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=57"
    TestUnion_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=192"
    TestOptionalFields_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=193"
    TestScalarStructure_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=58"
    TestArrayStructure_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=59"
    TestStructure_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=194"
    Vector_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=345"
    WorkOrderStatusType_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=346"
    WorkOrderType_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=347"
    ExtendedWorkOrderType_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=348"
    FinalWorkOrderType_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=349"
    SampleUnion_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=350"
    SampleStructureWithOptionalFields_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=351"
    SampleUnionAllowSubtypes_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=352"
    SampleStructureAllowSubtypes_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=353"
    Person_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=354"
    Student_Encoding_DefaultJson = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=355"

def get_ObjectIds_name(value: str) -> str:
    try:
        return ObjectIds(value).name
    except ValueError:
        return None


class ObjectTypeIds(Enum):
    RestrictedObjectType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=221"
    WithTwoDimensionalVariableType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=253"

def get_ObjectTypeIds_name(value: str) -> str:
    try:
        return ObjectTypeIds(value).name
    except ValueError:
        return None


class VariableIds(Enum):
    TestEnumeration_EnumValues = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=4"
    TestOptionSet_OptionSetValues = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=166"
    Seeker_Identities = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=196"
    Seeker_AddIdentity_InputArguments = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=203"
    Seeker_RemoveIdentity_InputArguments = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=205"
    Seeker_AddApplication_InputArguments = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=207"
    Seeker_RemoveApplication_InputArguments = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=209"
    Seeker_AddEndpoint_InputArguments = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=211"
    Seeker_RemoveEndpoint_InputArguments = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=213"
    EnumUnderscoreTest_EnumValues = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=215"
    RestrictedVariableType_Yellow = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=217"
    RestrictedVariableType_X = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=218"
    RestrictedVariableType_Y = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=219"
    RestrictedVariableType_Z = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=220"
    RestrictedObjectType_Red = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=222"
    RestrictedObjectType_Red_Yellow = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=223"
    RestrictedObjectType_Red_X = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=224"
    RestrictedObjectType_Red_Y = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=225"
    RestrictedObjectType_Red_Z = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=226"
    RestrictedObjectType_Pink_Placeholder = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=227"
    RestrictedObjectType_Pink_Placeholder_Yellow = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=228"
    RestrictedObjectType_Pink_Placeholder_X = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=229"
    RestrictedObjectType_Pink_Placeholder_Y = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=230"
    RestrictedObjectType_Pink_Placeholder_Z = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=231"
    TestObject_Red = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=234"
    TestObject_Red_Yellow = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=235"
    TestObject_Red_X = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=236"
    TestObject_Red_Y = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=237"
    TestObject_Red_Z = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=238"
    HeaterStatus_EnumStrings = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=243"
    WithTwoDimensionalVariableType_X = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=254"
    TestModel_BinarySchema = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=13"
    TestModel_BinarySchema_NamespaceUri = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=15"
    TestModel_BinarySchema_Deprecated = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=16"
    TestModel_BinarySchema_TestAbstractStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=17"
    TestModel_BinarySchema_TestConcreteStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=20"
    TestModel_BinarySchema_TestUnion = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=171"
    TestModel_BinarySchema_TestOptionalFields = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=174"
    TestModel_BinarySchema_TestScalarStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=23"
    TestModel_BinarySchema_TestArrayStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=26"
    TestModel_BinarySchema_TestStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=177"
    TestModel_BinarySchema_Vector = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=268"
    TestModel_BinarySchema_WorkOrderStatusType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=271"
    TestModel_BinarySchema_WorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=274"
    TestModel_BinarySchema_ExtendedWorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=277"
    TestModel_BinarySchema_FinalWorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=280"
    TestModel_BinarySchema_SampleUnion = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=283"
    TestModel_BinarySchema_SampleStructureWithOptionalFields = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=286"
    TestModel_BinarySchema_SampleUnionAllowSubtypes = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=289"
    TestModel_BinarySchema_SampleStructureAllowSubtypes = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=292"
    TestModel_BinarySchema_Person = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=295"
    TestModel_BinarySchema_Student = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=298"
    TestModel_XmlSchema = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=37"
    TestModel_XmlSchema_NamespaceUri = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=39"
    TestModel_XmlSchema_Deprecated = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=40"
    TestModel_XmlSchema_TestAbstractStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=41"
    TestModel_XmlSchema_TestConcreteStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=44"
    TestModel_XmlSchema_TestUnion = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=183"
    TestModel_XmlSchema_TestOptionalFields = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=186"
    TestModel_XmlSchema_TestScalarStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=47"
    TestModel_XmlSchema_TestArrayStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=50"
    TestModel_XmlSchema_TestStructure = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=189"
    TestModel_XmlSchema_Vector = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=312"
    TestModel_XmlSchema_WorkOrderStatusType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=315"
    TestModel_XmlSchema_WorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=318"
    TestModel_XmlSchema_ExtendedWorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=321"
    TestModel_XmlSchema_FinalWorkOrderType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=324"
    TestModel_XmlSchema_SampleUnion = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=327"
    TestModel_XmlSchema_SampleStructureWithOptionalFields = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=330"
    TestModel_XmlSchema_SampleUnionAllowSubtypes = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=333"
    TestModel_XmlSchema_SampleStructureAllowSubtypes = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=336"
    TestModel_XmlSchema_Person = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=339"
    TestModel_XmlSchema_Student = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=342"

def get_VariableIds_name(value: str) -> str:
    try:
        return VariableIds(value).name
    except ValueError:
        return None


class VariableTypeIds(Enum):
    RestrictedVariableType = "nsu=urn:opcfoundation.org:2024-01:TestModel;i=216"

def get_VariableTypeIds_name(value: str) -> str:
    try:
        return VariableTypeIds(value).name
    except ValueError:
        return None

