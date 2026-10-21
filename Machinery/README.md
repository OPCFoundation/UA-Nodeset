<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# Machinery

Normative files for the specifications below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specifications

| Directory | Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|--|
| `.` | [OPC 40001-1 Machinery Basic Building Blocks](https://reference.opcfoundation.org/specs/OPC-40001-1) | 1.04.2 | 2026-11-02 | [Machinery Building Blocks](https://opcfoundation.org/about/working-groups/view/15) | `Opc.Ua.Machinery.NodeSet2.xml` |
| `ProcessValues/` | [OPC 40001-2 Machinery Process Values](https://reference.opcfoundation.org/specs/OPC-40001-2) | 1.00.0 | 2023-05-01 | [Machinery Building Blocks](https://opcfoundation.org/about/working-groups/view/15) | `Opc.Ua.Machinery.ProcessValues.NodeSet2.xml` |
| `Jobs/` | [OPC 40001-3 Machinery Job Mgmt](https://reference.opcfoundation.org/specs/OPC-40001-3) | 1.0.1 | 2024-05-01 | [Machinery Building Blocks](https://opcfoundation.org/about/working-groups/view/15) | `Opc.Ua.Machinery.Jobs.Nodeset2.xml` |
| `Energy/` | [OPC 40001-4 Machinery Energy Mgmt](https://reference.opcfoundation.org/specs/OPC-40001-4) | 1.00 | 2025-11-01 | [Machinery Building Blocks](https://opcfoundation.org/about/working-groups/view/15) | `Opc.Ua.Machinery.Energy.NodeSet2.xml` |
| `Result/` | [OPC 40001-101 Machinery Result Transfer](https://reference.opcfoundation.org/specs/OPC-40001-101) | 1.01.0 | 2025-07-01 | [Machinery Building Blocks](https://opcfoundation.org/about/working-groups/view/15) | `Opc.Ua.Machinery_Result.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 40001-1 Machinery Basic Building Blocks | [40001: Machinery (Mantis project 142)](https://mantis.opcfoundation.org/set_project.php?project_id=142&make_default=no) |
| OPC 40001-2 Machinery Process Values | [40001: Machinery (Mantis project 142)](https://mantis.opcfoundation.org/set_project.php?project_id=142&make_default=no) |
| OPC 40001-3 Machinery Job Mgmt | [40001: Machinery (Mantis project 142)](https://mantis.opcfoundation.org/set_project.php?project_id=142&make_default=no) |
| OPC 40001-4 Machinery Energy Mgmt | [40001: Machinery (Mantis project 142)](https://mantis.opcfoundation.org/set_project.php?project_id=142&make_default=no) |
| OPC 40001-101 Machinery Result Transfer | [40001: Machinery (Mantis project 142)](https://mantis.opcfoundation.org/set_project.php?project_id=142&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11529](https://mantis.opcfoundation.org/view.php?id=11529) | Machinery Jobs NodeSet references an unresolvable DataType NodeId | [GitHub #121](https://github.com/OPCFoundation/UA-Nodeset/issues/121) |
| [11554](https://mantis.opcfoundation.org/view.php?id=11554) | Machinery Energy: Use a three-component ModelVersion so versions can be compared | [GitHub #123](https://github.com/OPCFoundation/UA-Nodeset/issues/123) |

