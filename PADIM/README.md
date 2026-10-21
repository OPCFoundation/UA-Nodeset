<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# PADIM

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 30081 Process Automation Devices - PADIM](https://reference.opcfoundation.org/specs/OPC-30081) | 1.02.0 | 2025-11-26 | [Process Automation Devices - PADIM](https://opcfoundation.org/about/working-groups/view/10) | `Opc.Ua.IRDI.NodeSet2.xml`, `Opc.Ua.PADIM.NodeSet2.xml` |

### IRDI dictionary

An `IRDI` NodeSet is always a **subset**: it contains only the Nodes actually referenced by the NodeSet published beside it. Several unrelated IRDI subsets exist across this repository under the one ModelUri `http://opcfoundation.org/UA/Dictionary/IRDI`, each maintained by the working group that owns the specification it accompanies. They are **not** revisions of a single model, they are not expected to agree with one another, and the differences between them are by design.

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 30081 Process Automation Devices - PADIM | [30081: PADIM (Mantis project 149)](https://mantis.opcfoundation.org/set_project.php?project_id=149&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11528](https://mantis.opcfoundation.org/view.php?id=11528) | PADIM 1.02.0 EnumDictionaryEntries changed to Matrix breaks code generation | [GitHub #118](https://github.com/OPCFoundation/UA-Nodeset/issues/118) |
| [11536](https://mantis.opcfoundation.org/view.php?id=11536) | PADIM Value uses ListOfInt32 for a UInt32 DataType | [GitHub #130](https://github.com/OPCFoundation/UA-Nodeset/issues/130) |
| [11540](https://mantis.opcfoundation.org/view.php?id=11540) | Opc.Ua.PADIM.NodeIds.csv is not a comma-separated identity table | [GitHub #134](https://github.com/OPCFoundation/UA-Nodeset/issues/134) |
| [11562](https://mantis.opcfoundation.org/view.php?id=11562) | PADIM: Initial Values conflict with the node declarations | [GitHub #129](https://github.com/OPCFoundation/UA-Nodeset/issues/129) |

