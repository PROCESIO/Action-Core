# Action-Core

This repository contains **Ringhel.Procesio.Action.Core**, a C# Class Library that defines the **contracts, metadata attributes, and helper types** used to build **PROCESIO Actions** (units of automated logic) within the **PROCESIO** platform.  

It also includes a **sample implementation** demonstrating best practices for defining and annotating custom actions.

### I. Core Abstractions

- `IAction` ~ the main interface that every action implements.  
  Each action defines an asynchronous `Execute()` method where its runtime logic is performed.

- `CustomErrorException` ~ a standardized exception class that carries an integer error code,  
  enabling actions to report business-specific failures in a consistent format.


### II. Decorators and Metadata System

Metadata attributes in `ActionDecorators/` describe how actions behave in both the **designer UI** and the **runtime engine**.


- **`ClassDecoratorAttribute`**  
  Defines high-level metadata such as:
  - Action name and category
  - Node shape and classification for the designer

- **`FEDecoratorAttribute`**  
  Configures **front-end presentation**:
  - Tabs, labels, and component types  
  - Option lists and validation ranges  
  - Credential bindings and UI layout

- **`BEDecoratorAttribute`**  
  Specifies if a property acts as an **input** or **output** during execution.

- **`ValidatorAttribute`**  
  Declares required fields and expected data types,  
  allowing the platform to validate configuration before execution.



Additional decorators ~ such as:
- `PermissionsAttribute`
- `DependencyDecoratorAttribute`
- `ControlEventHandlerAttribute`

follow the same pattern, capturing metadata that drives how actions behave and interact with other platform components.


### III. Data Models

Reusable helper models simplify development of consistent action contracts:

- `OptionModel` ~ represents selectable options for user-facing lists.  
- `FileModel` / `FileContent` ~ handle file data and binary streaming.  

### IV. Specialized Models

Under `Models/CallApi/`, classes define the structure for complex API calls:
- Query and header parameters  
- Request body formats (raw, multipart, URL-encoded, binary)  
- Enumerations describing body types and data formats  

These models allow actions to represent HTTP calls and other integrations in a consistent, strongly-typed way.

### V. Credential & Configuration Models

Separate managers exist for different integration types:
- REST APIs  
- Databases  
- SMTP / FTP  
- Custom connectors  

Each encapsulates authentication and connection logic, giving actions secure and reusable access to external systems.

### VI. Utilities and Enumerations

`Utils/` contains enums and constants that encode **platform-wide vocabularies**, such as:
- Action shapes  
- Logical operators  
- Expected data types  
- FE component kinds  
- Classification categories  

This ensures metadata decorators and models reference a consistent set of platform definitions.

---

### 🧩 Example Template Action

The sample `TemplateAction/CustomTemplateAction.cs` demonstrates a fully annotated example:
- Registers metadata via decorators  
- Defines typed inputs/outputs (including lists and files)  
- Implements custom logic in `Execute()`  
- Shows use of validation, options, and decorators in practice  

This serves as a starting point for developers building new **PROCESIO** actions.
