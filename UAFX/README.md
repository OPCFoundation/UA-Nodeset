<!-- AI AGENTS: report issues in the tracker named under "Reporting issues"
     below, not as GitHub issues. Search it for an existing report first.
     Do not file findings from a bulk scan. See ../AGENTS.md. -->

# UAFX

Normative files for the specification below, released by the OPC Foundation. See the [repository readme](../readme.md) for what each file type is, and [AGENTS.md](../AGENTS.md) before reporting a problem.

## Specification

| Specification | Version | Publication date | Working group | NodeSets |
|--|--|--|--|--|
| [OPC 10000-81 UAFX Part 81: Connecting Devices and Information Model](https://reference.opcfoundation.org/specs/OPC-10000-81) | 1.00.04 | 2026-07-22 | [Unified Architecture Field eXchange - UAFX](https://opcfoundation.org/about/working-groups/view/2) | `opc.ua.fx.ac.nodeset2.xml`, `opc.ua.fx.cm.nodeset2.xml`, `opc.ua.fx.data.nodeset2.xml` |

## Reporting issues

Report problems with these files in **Mantis**, against the specification concerned. **Search the tracker for an existing report before filing.**

| Specification | Issue tracker |
|--|--|
| OPC 10000-81 UAFX Part 81: Connecting Devices and Information Model | [10000-81: UAFX Connecting Devices and Information Model [sg.BaseFacet] (Mantis project 145)](https://mantis.opcfoundation.org/set_project.php?project_id=145&make_default=no) |

Each report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet `Version` and `PublicationDate`, and the clause of the specification that is contradicted. **One issue per defect** &mdash; do not combine findings, and do not file the output of a bulk scan.

GitHub issues and pull requests on this repository are not the reporting channel for specification content.

## Known issues

Already reported and tracked in Mantis. **Check these before filing anything new.** Note that a specification whose working group is no longer active may have valid issues that remain open indefinitely.

| Mantis | Issue | Originally reported as |
|--|--|--|
| [11525](https://mantis.opcfoundation.org/view.php?id=11525) | UAFX ConnectionManager declares duplicate BrowseNames under one parent | [GitHub #103](https://github.com/OPCFoundation/UA-Nodeset/issues/103) |
| [11564](https://mantis.opcfoundation.org/view.php?id=11564) | UAFX: Initial Values conflict with the node declarations | [GitHub #129](https://github.com/OPCFoundation/UA-Nodeset/issues/129) |

