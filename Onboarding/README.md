<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# Onboarding

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 10000-21 UA Part 21: Device Onboarding](https://reference.opcfoundation.org/specs/OPC-10000-21) | 1.05.04 | 2025-01-08 | [Unified Architecture Core - UA](https://opcfoundation.org/about/working-groups/view/1) | `Opc.Ua.Onboarding.NodeSet2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 10000-21 UA Part 21: Device Onboarding | [10000-021: Device Onboarding (Mantis project 160)](https://mantis.opcfoundation.org/set_project.php?project_id=160&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11530](https://mantis.opcfoundation.org/view.php?id=11530) | EncodedTicket is modelled as String instead of ByteString | [GitHub #122](https://github.com/OPCFoundation/UA-Nodeset/issues/122) |

