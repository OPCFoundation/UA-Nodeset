# OPC UA NodeSets, ModelDesign and Other Supporting Files <!-- omit in toc -->

## Table of Contents <!-- omit in toc -->

- [Executive Summary](#executive-summary)
- [Content](#content)
- [Contributing](#contributing)
- [See Also](#see-also)

## Executive Summary

The repository has been forked from [OPCFoundation/UA-Nodeset][UANodeset] and will be synchronized with the origin repository occasionally.

The main goal is to

- work on [OPC UA Information Models Compliance Testing][ASMDComplianceTesting]
- recover files required by the [OPCFoundation/UA-ModelCompiler][ModelCompiler] from the files provided by the origin.

I am a researcher and University associate who is passionate about applying knowledge and experience in building a Machine to Machine (M2M) meaningful interoperability based on OPC UA. Let's build it with you and for you. To join our effort and create an organizational context I have launched an open-access **Object-Oriented Internet Partnership Program**. Hence, maintenance of this repository and further development of the OPC UA Information Model Domain-Specific Language will be carried out under a broader concept described in the following article

[Object-Oriented Internet Partnership Program][Sponsorship]

**Consider joining**. Visit the section [How to be involved][SponsorshipToBeInvolved] to get more. I hope that thanks to this partnership program we will establish long-term mutually beneficial cooperation. Your participation is needed to make sure that the work will continue as expected. As a rule of thumb, the work priority is derived from community feedback.

## Content

This repository contains

- `UANodeSet` and other associated files, which are released with a specification
- outcomes of the research conducted according to the mentioned above project goals

This repository is interconnected with the origin to harmonize any change to a specification (release of a new version or errata) that may require a change of worked out outcome.

For each specification the following normative files need to be published:

- .NodeSet2.xml - The formal definition of the Nodes defined by the specification;
- .Types.xsd - The XML schema for the DataTypes defined by the specification;
- .Types.bsd - The OPC Binary schema for the DataTypes defined by the specification (obsolete);
- .NodeIds.csv - A CSV file containing the NodeIds assigned to Nodes defined by the specification;

In addition, the following non-normative support files may be published:

- .Classes.cs - C# classes for Nodes used with the [.NETStandard][NETStandard] stack;
- .DataTypes.cs - C# classes for DataTypes used with the [.NETStandard][NETStandard] stack;
- .Constants.cs - C# constant declarations used with the [.NETStandard][NETStandard] stack;
- .PredefinedNodes.uanodes - A non-normative binary representation of the `UANodeSet` for use with [.NETStandard][NETStandard] stack;

If a companion specification working group uses the [ModelCompiler][ModelCompiler] to create the `UANodeSet` then the following files are published:

- .Model.xml - The Nodes defined by the specification using the [schema](https://github.com/OPCFoundation/UA-ModelCompiler/blob/master/ModelCompiler/UA%20Model%20Design.xsd) needed by the [ModelCompiler](https://github.com/OPCFoundation/UA-ModelCompiler);
- .Model.csv - The NodeIds assigned to the Nodes defined by the specification;

If a companion specification working group doesn't use [ModelCompiler][ModelCompiler] the above-mentioned files are to be recovered from existing ones using [Address Space Prototyping Tool (asp.exe)][ASP].

The `v1.04` branch is to be synchronized with the origin. This branch contains released models according to the OPC UA specification and is occasionally updated against the origin. According to the origin repository rules, when a companion specification is released it will be added to this branch in a folder named after the release of the OPC UA specification. To get more about the origin repository organization check out the document [OPC UA NodeSets and Other Supporting Files](https://github.com/OPCFoundation/UA-Nodeset#opc-ua-nodesets-and-other-supporting-files)

The `main` branch (default) contains a merge of the `v1.04` and outcomes of the research conducted using independent branches.

## Contributing

I strongly encourage community participation and contribution to this project. First, please fork the repository and commit your changes there.
Once happy with your changes you can generate a 'pull request'.

When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

Please note we have a code of conduct, please follow it in all your interactions with the project.

## See Also

- [OPC UA Information Models Compliance Testing][ASMDComplianceTesting]
- [Address Space Prototyping Tool (asp.exe)][ASP]
- [Object-Oriented Internet Partnership Program][Sponsorship]
- [How to be involved][SponsorshipToBeInvolved]
- [OPCFoundation/UA-ModelCompiler][ModelCompiler]
- [OPC UA NodeSets and Other Supporting Files][UANodeset]
- [Official OPC UA .NET Standard Stack from the OPC Foundation][NETStandard]
- [OPC UA Makes Machine-Centric Global Village Possible – Call for Sponsors](https://mpostol.wordpress.com/2020/01/03/opc-ua-makes-machine-centric-global-village-possible-call-for-sponsors/)

[NETStandard]: https://github.com/OPCFoundation/UA-.NETStandard#official-opc-ua-net-standard-stack-from-the-opc-foundation
[ASMDComplianceTesting]: https://mpostol.github.io/ASMD/ASMD50-ModelsTesting
[Sponsorship]: https://github.commsvr.com/AboutPartnershipProgram.md.html
[SponsorshipToBeInvolved]: https://github.commsvr.com/AboutPartnershipProgram.md.html#how-to-be-involved
[ModelCompiler]: https://github.com/OPCFoundation/UA-ModelCompiler
[UANodeset]: https://github.com/OPCFoundation/UA-Nodeset#opc-ua-nodesets-and-other-supporting-files
[ASP]: https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspacecompliancetesttool

Join me at [LinkedIn](https://www.linkedin.com/in/mpostol/)