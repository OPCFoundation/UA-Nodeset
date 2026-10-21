<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# IJT

Normative files for the specifications below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specifications

| Directory | Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|--|
| `Base/` | [OPC 40450-1 Joining Systems Base](https://reference.opcfoundation.org/specs/OPC-40450-1) | 1.01.0 | 2025-10-06 | [Industrial Joining Technologies](https://opcfoundation.org/about/working-groups/view/84) | `Opc.Ua.Ijt.Base.NodeSet2.xml` |
| `Tightening/` | [OPC 40451-1 Tightening Systems General](https://reference.opcfoundation.org/specs/OPC-40451-1) | 2.00.1 | 2025-10-06 | [Industrial Joining Technologies](https://opcfoundation.org/about/working-groups/view/84) | `Opc.Ua.Ijt.Tightening.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 40450-1 Joining Systems Base | [40450-1: IJT Joining System – Base (Mantis project 180)](https://mantis.opcfoundation.org/set_project.php?project_id=180&make_default=no) |
| OPC 40451-1 Tightening Systems General | [40451-1: IJT Tightening System – General (Mantis project 179)](https://mantis.opcfoundation.org/set_project.php?project_id=179&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

