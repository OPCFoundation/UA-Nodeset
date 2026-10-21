# Instructions for AI agents

This repository holds the normative files released with the OPC UA specifications:
UANodeSets, type schemas, and the NodeId tables that accompany them. Files for each
specification are in a subdirectory named after its short name; the Core
specification is in `Schema`.

Before reporting anything about these files, read the `README.md` in the folder the
files belong to.

## What each folder README.md tells you

**Each directory holds one specification.** A folder with subdirectories therefore
covers several specifications, one per directory, and its README lists each with a
`Directory` column. `FDI`, `PLCopen` and `Schema` are the exceptions: those
directories carry more than one specification.

The **Specifications** table gives, for each specification in the folder:

| Column | Meaning |
|--|--|
| Specification | Document number and title, linked to the published specification |
| Version | `Version` attribute of the `<Model>` element in the NodeSet |
| Publication date | `PublicationDate` attribute of that same `<Model>` element |
| Working group | The working group responsible, linked to its page |
| NodeSets | The NodeSet files in that directory |

A **NodeSet versions** subsection appears when a NodeSet carries a version or
publication date of its own, different from the specification it accompanies.

An **IRDI dictionary** subsection appears where a folder publishes an IRDI
dictionary NodeSet. Read it: an IRDI NodeSet is a subset containing only the Nodes
referenced by the NodeSet beside it, several unrelated subsets exist under one
ModelUri, and the differences between them are by design, not defects.

A **Known issues** table lists problems already reported, with a link to each one.
Check it before reporting anything.

Supplementary files are not listed in the READMEs: superseded versions kept for
reference, example and sample NodeSets, and non-normative support files. Only the
current specifications appear.

## Where bug reports go

Every specification names the tracker its issues are reported in. That tracker is
given in the folder README under **Reporting issues**, and it is authoritative for
that specification.

- **Use the tracker the README names.** Most specifications use Mantis, against a
  project specific to that specification. Some working groups use GitHub instead,
  in a repository of their own. Where the README names a GitHub repository, that is
  the correct destination and the general Mantis rule does not apply.
- **Search that tracker for an existing report first**, and check the folder's
  Known issues table.
- **Do not open issues or pull requests on this repository.** It is not the
  reporting channel for specification content, whichever tracker a specification
  uses.
- **If a README names no tracker**, that specification has no active reporting
  channel. Do not file against it.

A report should name the file, the `NodeId` and `BrowseName` concerned, the NodeSet
`Version` and `PublicationDate`, and the clause of the specification contradicted.
File one defect per issue; do not combine findings and do not file the output of a
bulk scan.

If you have a need for a specific NodeSet that has a problem follow the Working Group link above to determine if the group is still Active. If so, email the chairman. If the group is not active and you represent a company that is a member of the OPC Foundation, you may volunteer to revise the specification and publish the NodeSet update. Please send requests to volunteer to mailto:uacomments@opcfoundation.org.
 