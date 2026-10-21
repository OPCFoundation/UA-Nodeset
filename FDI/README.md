<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# FDI

Normative files for the specifications below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specifications

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 30080-5 FDI Host](https://reference.opcfoundation.org/specs/OPC-30080-5) | 1.03.00.0001 | 2026-06-12 | [Field Device Integration - FDI](https://opcfoundation.org/about/working-groups/view/45) | `Opc.Ua.Fdi5.NodeSet2.xml` |
| [OPC 30080-7 FDI Communication Devices](https://reference.opcfoundation.org/specs/OPC-30080-7) | 1.04.01.0001 | 2020-01-24 | [Field Device Integration - FDI](https://opcfoundation.org/about/working-groups/view/45) | `Opc.Ua.Fdi7.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 30080-5 FDI Host | [30080-5: FDI Host (Mantis project 269)](https://mantis.opcfoundation.org/set_project.php?project_id=269&make_default=no) |
| OPC 30080-7 FDI Communication Devices | [30080-7: FDI Communication Devices (Mantis project 270)](https://mantis.opcfoundation.org/set_project.php?project_id=270&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11537](https://mantis.opcfoundation.org/view.php?id=11537) | FDI UIPlugInType declares an array under the scalar UIElementType | [GitHub #131](https://github.com/OPCFoundation/UA-Nodeset/issues/131) |

