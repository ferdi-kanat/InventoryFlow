# InventoryFlow

A Windows Forms-based inventory management system built with .NET 8, Entity Framework Core, and a clean layered architecture.

## 📋 Overview

InventoryFlow is a desktop application for managing products, sales, and customers. It features a 4-layer architecture with clear separation of concerns, validation, and Excel reporting capabilities.

## 🏗️ Architecture

The application follows a strict 4-layer architecture:

```
InventoryFlow.Entities      → Domain models and DTOs
InventoryFlow.DataAccess    → EF Core repositories and database context
InventoryFlow.Business      → Business logic, validation, and services
InventoryFlow.UI            → WinForms user interface
```

### Key Principles

- **Thin UI Layer**: Forms communicate only with Business services, never directly with Data Access Layer (DAL)
- **Manual Dependency Resolution**: Uses `InstanceFactory` instead of a DI container
- **Validation First**: FluentValidation rules enforced before any persistence
- **Fresh Context Pattern**: Each repository operation creates a new `DbContext` instance

## 🚀 Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server LocalDB (or SQL Server instance)
- Windows OS (for WinForms)

### Building the Project

```bash
# Clone the repository
git clone https://github.com/ferdi-kanat/InventoryFlow.git
cd InventoryFlow

# Build the solution
dotnet build InventoryFlow.sln
```

### Running the Application

```bash
dotnet run --project InventoryFlow.UI/InventoryFlow.UI.csproj
```

### Database Setup

The application uses SQL Server LocalDB with database name `InventoryFlowDB`.

#### Apply Migrations

```bash
# Create a new migration (from repository root)
dotnet ef migrations add <MigrationName> --project InventoryFlow.DataAccess --startup-project InventoryFlow.UI

# Update the database
dotnet ef database update --project InventoryFlow.DataAccess --startup-project InventoryFlow.UI
```

## 📁 Project Structure

### InventoryFlow.Entities

Contains domain models and Data Transfer Objects (DTOs):

- **Concrete**: Entity models (`Product`, `Category`, `Sale`, `Customer`)
- **DTOs**: View models for UI binding (`ProductDetailDto`, `SaleDetailDto`)

### InventoryFlow.DataAccess

Handles data persistence with Entity Framework Core:

- **Abstract**: Repository interfaces (`IProductDal`, `ICategoryDal`, etc.)
- **Concrete/EntityFramework**: EF Core implementations
  - `InventoryContext`: DbContext configuration
  - `EfEntityRepositoryBase<T>`: Generic repository base class
  - Entity-specific DALs with custom queries and projections

### InventoryFlow.Business

Business logic layer with services and validation:

- **Abstract**: Service interfaces (`IProductService`, `ISaleService`, etc.)
- **Concrete**: Service implementations (managers)
- **ValidationRules**: FluentValidation validators
- **Utilities**: `ValidationTool` for executing validation
- **Policies**: Business rules (`StockPolicy`, `PricingPolicy`, `CustomerLinkPolicy`)
- **DependencyResolvers**: `InstanceFactory` for manual dependency wiring

### InventoryFlow.UI

Windows Forms application:

- **Forms**: Product, Category, Sale, and Customer management forms
- **Reports**: `ExcelReporter` using ClosedXML for Excel exports

## ✨ Features

### Product Management
- Add, update, and delete products
- Category assignment
- Stock quantity tracking
- Unit price management
- Search products by name (case-insensitive)
- View detailed product information with category

### Sales Management
- Record sales with automatic stock deduction
- Support for walk-in customers (no customer assignment required)
- Automatic total price calculation
- Sales history with product and customer details
- Excel export for sales data

### Customer Management
- Add, update, and delete customers
- Customer contact information
- Link customers to sales transactions

### Category Management
- Organize products by categories
- Category-based product filtering

### Reporting
- Excel export functionality using ClosedXML
- Auto-fitted columns for better readability
- Support for exporting various data types

## 🔧 Technology Stack

- **.NET 8**: Target framework
- **Windows Forms**: Desktop UI framework
- **Entity Framework Core**: ORM for data access
- **SQL Server LocalDB**: Database engine
- **FluentValidation**: Input validation
- **ClosedXML**: Excel generation

## 💡 Design Patterns & Conventions

### Service Layer Pattern
Business logic encapsulated in service classes (managers) that implement service interfaces.

### Repository Pattern
Data access abstracted through repository interfaces with EF Core implementations.

### DTO Pattern
Separate DTOs for complex queries with joined data to optimize UI binding.

### Validation Pattern
All business operations validated using FluentValidation before persistence. Validation errors thrown as exceptions with meaningful messages.

### Data Conventions
- `decimal` type for monetary values (configured as `decimal(18,2)` in database)
- `int` for quantities
- Business layer sets timestamps (`AddedDate`, `Date`)
- DAL remains free of business logic

### Dependency Resolution
`InstanceFactory` provides fully configured service instances:
```csharp
var productService = InstanceFactory.GetProductService();
```

## 🔐 Key Implementation Details

### Stock Management
- Sales automatically decrement product stock
- Stock validation enforced before sale completion
- Insufficient stock prevents sale transaction

### Customer Handling
- Sales support optional customer assignment
- `CustomerId = null` represents walk-in customers
- UI displays "Walk-in Customer" for anonymous sales

### Search Functionality
- Product search uses case-insensitive matching
- Category filtering available in product views
- SQL `CONTAINS` used in DAL for name searches

### Database Context
- Fresh `DbContext` instance per repository operation
- Connection string: `(localdb)\MSSQLLocalDB`
- Database name: `InventoryFlowDB`
- Integrated Security with TrustServerCertificate

## 📝 Development Guidelines

### Adding a New Feature

1. **Define the entity** in `InventoryFlow.Entities/Concrete`
2. **Create DAL interface** in `InventoryFlow.DataAccess/Abstract`
3. **Implement EF DAL** in `InventoryFlow.DataAccess/Concrete/EntityFramework`
4. **Create service interface** in `InventoryFlow.Business/Abstract`
5. **Implement manager** in `InventoryFlow.Business/Concrete`
6. **Add validator** in `InventoryFlow.Business/ValidationRules`
7. **Register in `InstanceFactory`** for dependency resolution
8. **Create/update UI forms** in `InventoryFlow.UI`

### Running Migrations

Always run migration commands from the repository root:

```bash
# Add a new migration
dotnet ef migrations add <MigrationName> --project InventoryFlow.DataAccess --startup-project InventoryFlow.UI

# Apply migrations to database
dotnet ef database update --project InventoryFlow.DataAccess --startup-project InventoryFlow.UI

# Remove last migration (if not applied)
dotnet ef migrations remove --project InventoryFlow.DataAccess --startup-project InventoryFlow.UI
```

## 📄 License

This project is available for educational and reference purposes.
