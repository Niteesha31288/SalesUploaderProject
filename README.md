# SalesUploader

A Blazor Server (.NET 8) app that lets users upload a sales‐export Excel file, previews only the new rows (based on `QuoteSentDate|SalesPerson|ProjectName`), and saves them into a SQLite database via Entity Framework Core. Styled with MudBlazor.

---

## 📋 Features

- **Upload Excel (.xlsx)** via a simple UI.
- **Preview new rows only** (skips duplicates already in the database).
- **Save to database** (SQLite) with a single click.
- Uses **EF Core Migrations** to manage schema.
- Built on **Blazor Server**, **MudBlazor**, **ClosedXML**, **EF Core SQLite**.

---

## 🔧 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- (Optional) `dotnet-ef` global tool:
  ```bash
  dotnet tool install --global dotnet-ef
