# AGENTS.md — Action-Core agent context

This file is the canonical entry point for any AI agent working in this repository. Read it before making changes. The human-facing overview lives in [README.md](README.md).

---

## 1. What this repo is

**Action-Core** ships the NuGet package **`Ringhel.Procesio.Action.Core`** — a .NET 8 C# class library that defines the **contracts, metadata attributes, and helper types** used to build PROCESIO Actions (units of automated logic) on the PROCESIO platform.

This repo contains **no executable actions**. It only defines the shape that real actions must implement. Real action implementations live in the **Process-Execution** service.

- **Package ID:** `Ringhel.Procesio.Action.Core`
- **Target framework:** `net8.0`
- **Root namespace:** `Ringhel.Procesio.Action.Core`
- **Sole runtime dependency:** `Newtonsoft.Json` 13.0.3
- **Distribution:** GitHub Packages NuGet feed (`https://nuget.pkg.github.com/PROCESIO/index.json`)

## 2. Position in the PROCESIO ecosystem

This package is **consumed as a NuGet dependency** by three downstream services in the PROCESIO workspace:

| Consumer service       | What it uses Action-Core for                                                                |
| ---------------------- | ------------------------------------------------------------------------------------------- |
| **Web-Api**            | Reads action metadata (decorators) to drive the designer UI and validate configurations.    |
| **Action-Execution**   | Uses the `IAction` contract and credential/model types to run actions.                      |
| **Process-Execution**  | Hosts the **concrete action implementations** that derive from this library's abstractions. |

> If you change a public type in this repo, the blast radius reaches all three services above. See §5 for the change policy.

## 3. Project layout

```
Ringhel.Procesio.Action.Core.sln
└── Ringhel.Procesio.Action.Core/                ← the only project
    ├── IAction.cs                                ← the interface every action implements
    ├── CustomErrorException.cs                   ← standardized exception with int error code
    ├── ActionDecorators/                         ← metadata attributes
    │   ├── ClassDecoratorAttribute.cs            ← action name, category, node shape
    │   ├── FEDecoratorAttribute.cs               ← front-end presentation
    │   ├── FETabDecoratorAttribute.cs            ← designer tab grouping
    │   ├── BEDecoratorAttribute.cs               ← input/output direction
    │   ├── ValidatorAttribute.cs                 ← required fields & expected types
    │   ├── PermissionsAttribute.cs
    │   ├── DependencyDecoratorAttribute.cs
    │   ├── ControlEventHandlerAttribute.cs
    │   └── ActionEventHandlerAttribute.cs
    ├── Models/
    │   ├── OptionModel.cs                        ← UI dropdown options
    │   ├── FileModel.cs / FileContent.cs         ← file & binary payloads
    │   ├── CallApi/                              ← HTTP request shapes (body, headers, params)
    │   ├── Credentials/                          ← per-integration credential managers
    │   │   ├── API/         REST
    │   │   ├── DB/          databases
    │   │   ├── SMTP/        email
    │   │   ├── FTP/         file transfer
    │   │   ├── AI-API/      LLM endpoints
    │   │   └── CUSTOM/      custom connectors
    │   └── AiDecisional/                         ← LLM response & endpoint mode models
    ├── Utils/                                    ← platform-wide enums (ActionShape, Direction,
    │                                               ExpectedType, FeComponentType, LogicalOperator, …)
    └── TemplateAction/
        └── CustomTemplateAction.cs               ← reference example, NOT a real action
```

## 4. Build, version, and publish flow

### CI workflows (`.github/workflows/`)

- **`main-build-dotnet.yml`** — runs `dotnet restore` + `dotnet build -c Release` on every PR targeting `main` or `release`.
- **`main-publish-dotnet.yml`** — triggers on git tag `v*.*.*` (or `v*.*.*-rc.*`). Rewrites `<Version>` in the csproj from the tag, packs, and pushes the `.nupkg` to GitHub Packages.

### To cut a release

1. Merge changes to `main` (or `release`).
2. Tag the commit: `git tag v1.2.3 && git push origin v1.2.3` (use `v1.2.3-rc.1` for a pre-release).
3. The publish workflow does the rest. **Never edit `<Version>` in the csproj by hand** — the tag is the source of truth, and the workflow overwrites it.

### Local build

```bash
dotnet restore
dotnet build --configuration Release
```

You need access to the `PROCESIO` GitHub Packages feed if any transitive package resolves from there (currently this repo only pulls public NuGet, but the workflow is wired for the org feed).

## 5. Change policy (READ BEFORE EDITING)

1. **Avoid breaking changes when reasonable.** This library is the contract surface for Web-Api, Action-Execution, and Process-Execution. A breaking change forces a coordinated rollout across all three.
2. **Breaking changes ARE permitted when justified** — the team can absorb a major version bump. If you must break, say so explicitly in the PR description and call out which consumer services need follow-up.
3. **Semver intent:**
   - Patch (`v1.2.x`) — bug fixes, internal-only changes, new optional metadata.
   - Minor (`v1.x.0`) — additive: new decorators, new model types, new enum members appended at the end.
   - Major (`v2.0.0`) — anything that changes `IAction`, renames/removes public types, or alters existing decorator semantics.
4. **Inserting enum values in the middle changes ordinal values** and can break serialized data — always append.
5. **Newtonsoft.Json is the serializer** — do not introduce `System.Text.Json` types in public contracts without checking how Process-Execution / Web-Api deserialize them.

## 6. What lives where (when you get a task)

| Task                                                        | Where to look                                                          |
| ----------------------------------------------------------- | ---------------------------------------------------------------------- |
| Add a new metadata attribute usable on actions              | `ActionDecorators/`                                                    |
| Add a new credential manager for a new integration type     | `Models/Credentials/<NEW_TYPE>/`                                       |
| Add a new platform-wide enum or extend one                  | `Utils/`                                                               |
| Add a reusable model used across many actions               | `Models/`                                                              |
| Change how an action is executed                            | **Wrong repo.** Go to **Process-Execution** — that's where `IAction` implementations live. |
| Change how the designer renders an action                   | Likely **Web-Api** (reads metadata) and/or the front-end repo.         |
| Change the `IAction` interface itself                       | Here, but coordinate with all three consumers (§2) and bump major.     |

## 7. Conventions

- File-scoped namespaces are not yet used everywhere — match the surrounding file's style.
- `ImplicitUsings` is **enabled** in the csproj, so common namespaces (`System`, `System.Collections.Generic`, etc.) don't need explicit `using` statements.
- The `TemplateAction/CustomTemplateAction.cs` sample is the reference for how a real action should be annotated. Keep it in sync if you introduce new decorators.
- `.editorconfig` at the repo root governs formatting — respect it.

## 8. Things that look wrong but aren't

- `<Version>0.0.0</Version>` in the csproj is intentional. The publish workflow rewrites it from the git tag at build time.
- `TemplateAction/CustomTemplateAction.cs` is **not** wired into any execution path. It's documentation-by-example.

## 9. Out of scope here

- **Concrete action implementations** → Process-Execution
- **Action execution runtime / orchestration** → Action-Execution, Process-Execution
- **Designer UI / metadata serving over HTTP** → Web-Api (and front-end repo)
- **Persistence of action configurations** → Data-Store / DataBase-Update
