<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# OpenApi

## OpenAPI and JSON Schemas
### Overview
Starting with the 1.05.04 release of the Core specification the normative files include [OpenAPI](https://swagger.io/specification/) and [JSON schemas](https://json-schema.org/specification) for all OPC UA defined Services and DataTypes. 

### Generating Stubs for the OPC UA WebApi
These definitions can be used with the OpenAPI generator to create stubs for OPC UA WebApi in different programming languages. The OPC Foundation publishes pre-generator stubs for a common development environents as listed in the following table. 

| Language | Repository |
|--|--|
|dotnet|[https://github.com/OPCFoundation/opcua-webapi-dotnet](https://github.com/OPCFoundation/opcua-webapi-dotnet)|
|python|[https://github.com/OPCFoundation/opcua-webapi-python](https://github.com/OPCFoundation/opcua-webapi-python)|
|typescript|[https://github.com/OPCFoundation/opcua-webapi-typescript](https://github.com/OPCFoundation/opcua-webapi-typescript)|

Additional development environent will be added based on community requests.

These schema files will also be published for every Companion Specification moving forward. 

### BrowseNames and NodeIds
The specification defines many well-known NodeIds and BrowseNames. These values are defined as constants in files for different development environments. The available definitions are in the the [Constants](./Constants/) folder.

These files are generated automatically with the [OPC UA ModelCompiler](https://github.com/OPCFoundation/UA-ModelCompiler). Support for additional languages will be based on community demand (voluteers are needed to create examples for the templates and to test the published files).

These constant files will also be published for every Companion Specification moving forward.

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 10000-6 UA Part 6: Mappings | [UA Specification (Mantis project 28)](https://mantis.opcfoundation.org/set_project.php?project_id=28&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11551](https://mantis.opcfoundation.org/view.php?id=11551) | OpenAPI and JSON schemas name the DataValue status field StatusCode, not Status | [GitHub #146](https://github.com/OPCFoundation/UA-Nodeset/issues/146) |

