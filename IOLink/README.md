<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# IOLink

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 30120 IO-Link Devices and IO-Link Masters](https://reference.opcfoundation.org/specs/OPC-30120) | 1.00.1 | 2022-03-24 | [IO-Link](https://opcfoundation.org/about/working-groups/view/50) | `Opc.Ua.IOLink.NodeSet2.xml` |

### NodeSet versions

These NodeSets carry a version and publication date of their own, independent of the specification they accompany.

| NodeSet | Version | Publication date |
|--|--|--|
| `Opc.Ua.IOLinkIODD.NodeSet2.xml` | 1.00.1 | 2022-02-18 |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 30120 IO-Link Devices and IO-Link Masters | [30120: IO-Link (Mantis project 124)](https://mantis.opcfoundation.org/set_project.php?project_id=124&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11548](https://mantis.opcfoundation.org/view.php?id=11548) | Opc.Ua.IOLink.NodeIds.csv omits two declared identities | [GitHub #142](https://github.com/OPCFoundation/UA-Nodeset/issues/142) |
| [11557](https://mantis.opcfoundation.org/view.php?id=11557) | IO-Link: Initial Values conflict with the node declarations | [GitHub #129](https://github.com/OPCFoundation/UA-Nodeset/issues/129) |

