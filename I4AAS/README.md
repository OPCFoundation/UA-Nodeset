<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# I4AAS

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 30270 Industry 4.0 Asset Administration Shell (deprecated)](https://reference.opcfoundation.org/specs/OPC-30270) | 5.0.0 | 2021-06-04 | [Industry 4.0 Asset Administration Shell - AAS](https://opcfoundation.org/about/working-groups/view/38) | `Opc.Ua.I4AAS.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 30270 Industry 4.0 Asset Administration Shell (deprecated) | [30270: Industry 4.0 Asset Administration Shell (deprecated) (Mantis project 274)](https://mantis.opcfoundation.org/set_project.php?project_id=274&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11520](https://mantis.opcfoundation.org/view.php?id=11520) | AASDataTypeIEC61360DataType EnumString lists 11 of 15 DataTypes | [GitHub #86](https://github.com/OPCFoundation/UA-Nodeset/issues/86) |
| [11524](https://mantis.opcfoundation.org/view.php?id=11524) | I4AAS NodeSet import fails on Type value AccessPermissionRule_0 | [GitHub #100](https://github.com/OPCFoundation/UA-Nodeset/issues/100) |
| [11556](https://mantis.opcfoundation.org/view.php?id=11556) | I4AAS: Initial Values conflict with the node declarations | [GitHub #129](https://github.com/OPCFoundation/UA-Nodeset/issues/129) |

