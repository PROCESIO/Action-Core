# Ringhel.Procesio.Action.Core

> Part of the Action-Core repository. See [AGENTS.md](../AGENTS.md) for the canonical architectural context.

## Role
This is the sole project in the repo and the body of the NuGet package `Ringhel.Procesio.Action.Core` (`net8.0`, root namespace `Ringhel.Procesio.Action.Core`). It defines the **contract surface** for PROCESIO Actions: the `IAction` interface every action must implement, the `CustomErrorException` standardized error type, the metadata `*Attribute` decorators that drive the designer UI and validation, the shared model types (files, HTTP request shapes, per-integration credential managers, AI/LLM payloads), and the platform-wide enums (`ActionShape`, `Direction`, `ExpectedType`, etc.). It ships **no executable actions** — concrete `IAction` implementations live in Process-Execution; this library only describes their shape and is consumed as a NuGet dependency by Web-Api, Action-Execution, and Process-Execution.

## Key contents
- `IAction.cs` — the interface every PROCESIO action implements
- `CustomErrorException.cs` — standardized exception carrying an `int` error code
- `ActionDecorators/` — metadata attributes (`ClassDecorator`, `FEDecorator`, `FETabDecorator`, `BEDecorator`, `Validator`, `Permissions`, `DependencyDecorator`, `ControlEventHandler`, `ActionEventHandler`) that the designer and validators read via reflection
- `Models/` — shared types: `OptionModel`, `FileModel` / `FileContent`, `CallApi/` HTTP shapes, `Credentials/` managers split by integration kind (`API`, `DB`, `SMTP`, `FTP`, `AI-API`, `CUSTOM`), and `AiDecisional/` LLM payloads
- `Utils/` — platform-wide enums (`ActionShape`, `Direction`, `ExpectedType`, `FeComponentType`, `LogicalOperator`, ...)
- `TemplateAction/CustomTemplateAction.cs` — reference example showing how an action should be annotated; **not** wired into any execution path

## Dependencies
**Project references:** none (standalone class library — this is the only project in the repo)
**Notable NuGet packages:** `Newtonsoft.Json` 13.0.3 — the sole runtime dependency and the mandated serializer for all public contracts (see AGENTS.md §5; `System.Text.Json` types must not appear in public contracts without coordination with consumer services).

## Boundary
Keep this project limited to **contracts, metadata, shared models, and enums**. Do not add concrete action implementations (those belong in Process-Execution), execution/orchestration logic (Action-Execution, Process-Execution), HTTP/designer-serving code (Web-Api), or persistence of action configurations (Data-Store / DataBase-Update) — see AGENTS.md §9 "Out of scope". Because every public type here is part of the contract consumed by three downstream services, follow the change policy in AGENTS.md §5: prefer additive changes, append enum values rather than inserting them, and flag any breaking change explicitly so a coordinated major-version rollout can happen.
