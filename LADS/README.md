<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# LADS

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 30500-1 Laboratory and Analytical Device Standard](https://reference.opcfoundation.org/specs/OPC-30500-1) | 1.0.0 | 2023-11-30 | [Laboratory and Analytical Devices - LADS](https://opcfoundation.org/about/working-groups/view/12) | `Opc.Ua.LADS.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 30500-1 Laboratory and Analytical Device Standard | [30500-1: LADS-Basics (Mantis project 234)](https://mantis.opcfoundation.org/set_project.php?project_id=234&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11546](https://mantis.opcfoundation.org/view.php?id=11546) | Opc.Ua.LADS.NodeIds.csv repeats three encoding names | [GitHub #140](https://github.com/OPCFoundation/UA-Nodeset/issues/140) |

