<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# MachineVision

Normative files for the specifications below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specifications

| Directory | Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|--|
| `.` | [OPC 40100-1 Machine Vision - Control, Configuration management, recipe management, result management](https://reference.opcfoundation.org/specs/OPC-40100-1) | 1.0.0 | 2019-07-11 | [Machine Vision](https://opcfoundation.org/about/working-groups/view/17) | `Opc.Ua.MachineVision.NodeSet2.xml` |
| `AMCM/` | [OPC 40100-2 Machine Vision - Asset Mgmt and Condition Monitoring](https://reference.opcfoundation.org/specs/OPC-40100-2) | 1.00.0 | 2024-05-17 | [Machine Vision](https://opcfoundation.org/about/working-groups/view/17) | `Opc.Ua.MachineVision.AMCM.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 40100-1 Machine Vision - Control, Configuration management, recipe management, result management | [40100-1: MachineVision-1: Control and more (Mantis project 112)](https://mantis.opcfoundation.org/set_project.php?project_id=112&make_default=no) |
| OPC 40100-2 Machine Vision - Asset Mgmt and Condition Monitoring | [40100: Machine Vision (Mantis project 111)](https://mantis.opcfoundation.org/set_project.php?project_id=111&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

