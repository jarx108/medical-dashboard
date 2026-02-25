# CLAUDE.md — Medical Dashboard (PMR)

## Project Overview

**Personal Medical Records (PMR)** is a Windows desktop application for managing personal medical data. It is also an educational project designed to teach C# and OOP fundamentals.

- **Platform:** .NET 9.0 / Windows Forms (WinForms)
- **Language:** C#
- **Database:** Microsoft SQL Server
- **Data access:** Direct ADO.NET via `Microsoft.Data.SqlClient` (no ORM)

---

## Repository Structure

```
/
├── prgPMR/           # Main WinForms application
│   ├── Abstraction/  # Abstract base classes
│   ├── DataObjects/  # DTOs and interfaces
│   ├── images/       # UI assets
│   └── *.cs / *.Designer.cs  # Forms and controls
├── PMRdbProj/        # SQL Server database project (.sqlproj)
│   ├── dbo/Tables/   # Table definitions (.sql)
│   └── Scripts/      # DB creation and migration scripts
└── prgPMR.sln        # Visual Studio solution
```

---

## Key Files

| File | Purpose |
|------|---------|
| `prgPMR/pgmPMRMain.cs` | Application entry point (`Program.Main`) |
| `prgPMR/MainForm.cs` | Primary window; tab/control management |
| `prgPMR/ControlManager.cs` | Navigation and control visibility logic |
| `prgPMR/LoginForm.cs` | Authentication UI |
| `prgPMR/MedicalControl.cs` | Abstract base class for all medical panels |

Each UI panel follows the pattern:
- `ControlName.cs` — logic
- `ControlName.Designer.cs` — auto-generated layout (do not edit manually)
- `ControlName.resx` — resources

---

## Database

Tables use `tbl` prefix. Core tables:
- `tblUsers` — authentication and user profile
- `tblBloodwork`, `tblDoctorVisits`, `tblHospitalizations`, `tblImmunizationDetails`, `tblMedicationLists`, `tblSurgeries`, `tblTests`, `tblFamilyHistories`, `tblFamilyMembers`

Lookup/reference tables use `tblSelect*` prefix (e.g., `tblSelectDoctors`, `tblSelectFacilities`).

Database creation scripts are in `PMRdbProj/Scripts/`.

---

## Build & Run

```bash
# Build
dotnet build prgPMR.sln

# Run (Windows only — WinForms)
dotnet run --project prgPMR/prgPMR.csproj
```

Visual Studio is the primary development environment.

---

## Coding Conventions

- Nullable reference types are **enabled** — use `?` annotations appropriately
- Implicit usings are **enabled**
- All new controls should inherit from `MedicalControl` (abstract base)
- Designer files (`*.Designer.cs`) are auto-generated — make layout changes through the Visual Studio designer, not by hand
- Educational comments are present throughout the codebase; preserve or extend them for learners
- No test project exists — changes should be manually verified

---

## No Test Suite

There is no automated test framework. When making changes:
- Manually test affected forms and database interactions
- Ensure SQL scripts in `PMRdbProj/Scripts/` stay in sync with table changes in `dbo/Tables/`

---

## Connection String

No `.env` or `appsettings.json` exists. The SQL Server connection string is managed within the application code. When helping with database connectivity, look for `SqlConnection` instantiation in the source files.
