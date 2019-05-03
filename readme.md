<!-- index -->
## OPC UA NodeSets and Other Supporting Files
### Contents
* [Files Found Here](#files)
* [Release Process](#release)
* [Amendments](#amendments)

### <a name="files">Files Found Here
This repository contains UANodeSets and other normative files which are released with a specification.
Any change to a specification (release of a new version or errata) may require a change to the files in this repository.  

For each specification the following normative files need to be published:
* *.NodeSet2.xml - The formal definition of the Nodes defined by the specification;
* *.Types.xsd - The XML schema for the DataTypes defined by the specification;
* *.Types.bsd - The OPC Binary schema for the DataTypes defined by the specification (obsolete);
* *.NodeIds.csv - A CSV file containing the NodeIds assigned to Nodes defined by the specification;

In addition, the following non-normative support files may be published:
* *.Classes.cs - C# classes for Nodes used with the [.NETStandard](https://github.com/OPCFoundation/UA-.NETStandard) stack;
* *.DataTypes.cs - C# classes for DataTypes used with the [.NETStandard](https://github.com/OPCFoundation/UA-.NETStandard) stack;
* *.Constants.cs - C# constant declarations used with the [.NETStandard](https://github.com/OPCFoundation/UA-.NETStandard) stack;
* *.PredefinedNodes.uanodes - A non-normative binary representation of the UANodeSet for use with [.NETStandard](https://github.com/OPCFoundation/UA-.NETStandard) stack;

If a companion specification working group uses the ModelCompiler to create the UANodeSet then the following files are published:
* *.Model.xml - The Nodes defined by the specification using the [schema](https://github.com/OPCFoundation/UA-ModelCompiler/blob/master/ModelCompiler/UA%20Model%20Design.xsd) needed by the [ModelCompiler](https://github.com/OPCFoundation/UA-ModelCompiler);
* *.Model.csv - The NodeIds assigned to the Nodes defined by the specification;

For the core OPC UA specifications the following additional files are published:

* StatusCode.csv - The StatusCodes defined by the OPC UA specification;
* AttributeIds.csv - The identifiers for the Attributes defined by the OPC UA specification;
* UNECE_to_OPCUA.csv - The numeric codes assigned to the UNECE units (see Part 8);
* ServerCapabilities.csv - The ServerCapabilities defined by the OPC UA specification (see Part 12);
* Opc.Ua.NodeSet2.Services.xml - A UANodeSet that includes DataTypes which are used only with OPC UA Services;
* OPCBinarySchema.xsd - The OPC Binary schema definition;
* UANodeSet.xsd - The UANodeSet schema definition;
* SecuredApplication.xsd - The SecuredApplication schema definition (see Part 6);

The files for each companion specification are in a subdirectory with the short name of the specification.
The files for the core specification are in the Schema subdirectory.

### <a name="release">Release Process
This repository is used as part of the review process. 
This means files are checked into this repository before they are reviewed by the working groups and may contain errors are other problems.
If an error or problem is found it should be [reported](https://apps.opcfoundation.org/mantis/main_page.php) as a mantis issue against the appropriate specification. 

When the review process is complete the files are published to the links that can be found in the appropriate specification.
This is usually on the OPC Foundation [website](https://opcfoundation.org/UA/schemas/).
**If someone is looking for the officially released version of the UANodeSets they must follow the links in the specification.**

When the files are reviewed and published a tag will be created in this repo with the publication date specified in the UANodeSet. 
Note that adding tags is a step that was added late in the process so tags prior to 2019-05-01 do not exist and users must use the dates on the commits.

There are currently 3 branches in the repository:
* master (currently v1.05)
* v1.04
* v1.03

These branches correspond to a release of the OPC UA specification.
When a companion specification is released it will be added to the branch that matches the release of the OPC UA specification used.
If errata are later published for a companion specification the version in the appropriate branch will be updated. 

For testing purposes, files for companion specifications are updated to use the current version of the OPC UA specification,
however, these versions are not normative until the companion specification working group approves the move to the new OPC UA version.

### <a name="amendments">Amendments
The OPC UA working group publishes extensions to the 1.04 specification in the form of amendments. 
When these amendments are being developed and reviewed the Nodes are added to the UANodeSet in the master branch with 'Draft' as the ReleaseStatus.
When an amendment is ready for release the Nodes have their ReleaseStatus set to 'Released' and are added to the UANodeSet in the v1.04 branch. 
Once the WG approves, the UANodeSet is published on the OPC Foundation website and a tag is added to the v1.04 branch.

Companion specification working groups that depend on specific amendments must ensure that they reference a UANodeSet which includes the Nodes definedin the Amendment.
This is done by specifying a minimum publication date for the core UANodeSet.


