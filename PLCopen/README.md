<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# PLCopen

Normative files for the specifications below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specifications

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 30000 PLC Model based on IEC 61131-3](https://reference.opcfoundation.org/specs/OPC-30000) | 1.02 | 2020-11-25 | [PLC Model based on IEC61131 - PLCopen](https://opcfoundation.org/about/working-groups/view/11) | `Opc.Ua.PLCopen.NodeSet2_V1.02.xml` |
| [OPC 30001 PLC Client Function Blocks based on IEC 61131-3](https://reference.opcfoundation.org/specs/OPC-30001) | 1.02 | 2020-11-25 | [PLC Model based on IEC61131 - PLCopen](https://opcfoundation.org/about/working-groups/view/11) | `Opc.Ua.PLCopen.NodeSet2_V1.02.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 30000 PLC Model based on IEC 61131-3 | [3000n: PLCopen (Mantis project 84)](https://mantis.opcfoundation.org/set_project.php?project_id=84&make_default=no) |
| OPC 30001 PLC Client Function Blocks based on IEC 61131-3 | [3000n: PLCopen (Mantis project 84)](https://mantis.opcfoundation.org/set_project.php?project_id=84&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11527](https://mantis.opcfoundation.org/view.php?id=11527) | PLCopen NodeSet omits the mandatory CtrlTypes folder | [GitHub #109](https://github.com/OPCFoundation/UA-Nodeset/issues/109) |

