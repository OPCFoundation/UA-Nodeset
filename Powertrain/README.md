<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# Powertrain

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 40400-1 UA for Powertrain](https://reference.opcfoundation.org/specs/OPC-40400-1) | 1.0.0 | 2024-11-01 | [Powertrain](https://opcfoundation.org/about/working-groups/view/23) | `Opc.Ua.Powertrain.NodeSet2.xml`, `powertraindictionary.nodeset2.xml` |

### NodeSet versions

These NodeSets carry a version and publication date of their own, independent of the specification they accompany.

| NodeSet | Version | Publication date |
|--|--|--|
| `powertraindictionary.nodeset2.xml` | 1.0.0 | 2024-07-11 |

### IRDI dictionary

An `IRDI` NodeSet is always a **subset**: it contains only the Nodes actually referenced by the NodeSet published beside it. Several unrelated IRDI subsets exist across this repository under the one ModelUri `http://opcfoundation.org/UA/Dictionary/IRDI`, each maintained by the working group that owns the specification it accompanies. They are **not** revisions of a single model, they are not expected to agree with one another, and the differences between them are by design.

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 40400-1 UA for Powertrain | [40400-1: Powertrain-AssetMgmt (Mantis project 225)](https://mantis.opcfoundation.org/set_project.php?project_id=225&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11550](https://mantis.opcfoundation.org/view.php?id=11550) | Powertrain PtCertificateAttributes declares two mandatory properties named Certificates | [GitHub #144](https://github.com/OPCFoundation/UA-Nodeset/issues/144) |

