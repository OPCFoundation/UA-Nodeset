<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# SurfaceTechnology

Normative files for the specifications below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specifications

| Directory | Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|--|
| `GeneralTypes/` | [OPC 40700 Surface Technology - General Types](https://reference.opcfoundation.org/specs/OPC-40700) | 1.0.0 | 2026-04-01 | [Surface Technology](https://opcfoundation.org/about/working-groups/view/24) | `Opc.Ua.STGeneralTypes.NodeSet2.xml` |
| `CleaningPretreatment/` | [OPC 40701 Surface Technology - Cleaning Pretreatment Machinery](https://reference.opcfoundation.org/specs/OPC-40701) | 1.0.0 | 2026-10-02 | [Surface Technology](https://opcfoundation.org/about/working-groups/view/24) | `Opc.Ua.ST.CleaningPretreatment.NodeSet2.xml` |
| `OCT-MSS/` | [OPC 40702 Surface Technology - Material Supply Systems](https://reference.opcfoundation.org/specs/OPC-40702) | 1.0.0 | 2026-08-01 | [Surface Technology](https://opcfoundation.org/about/working-groups/view/24) | `Opc.Ua.ST-Mss.NodeSet2.xml` |
| `Plasma/` | [OPC 40719 Surface Technology - Plasma Treatment Machinery](https://reference.opcfoundation.org/specs/OPC-40719) | 1.0.0 | 2026-01-01 | [Surface Technology](https://opcfoundation.org/about/working-groups/view/24) | `Opc.Ua.SurfaceTechnology.Plasma.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 40700 Surface Technology - General Types | [40700: Surface Technology - General Types (Mantis project 286)](https://mantis.opcfoundation.org/set_project.php?project_id=286&make_default=no) |
| OPC 40701 Surface Technology - Cleaning Pretreatment Machinery | [40701: Cleaning-Pretreatment Surface Technology (Mantis project 192)](https://mantis.opcfoundation.org/set_project.php?project_id=192&make_default=no) |
| OPC 40702 Surface Technology - Material Supply Systems | [40702: Surface Technology – Organic Coating Technology – Material Supply Systems (Mantis project 248)](https://mantis.opcfoundation.org/set_project.php?project_id=248&make_default=no) |
| OPC 40719 Surface Technology - Plasma Treatment Machinery | [40719: Surface Technology - Plasma Treatment Machinery (Mantis project 287)](https://mantis.opcfoundation.org/set_project.php?project_id=287&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

