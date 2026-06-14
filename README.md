# Unit Conversion API

## Overview

A RESTful ASP.NET Core Web API for converting values between different units of measurement.

Currently supported categories:

* Length
* Temperature
* Weight/Mass

The application is designed using Clean Architecture principles and follows the Strategy Pattern with Dependency Injection to allow easy extension for additional conversion categories in the future.

---

## Features

* ASP.NET Core 8 Web API
* Clean Architecture
* Dependency Injection
* Strategy Pattern
* Global Exception Handling Middleware
* FluentValidation
* Custom API Response Wrapper
* Async Service Layer
* Swagger/OpenAPI Documentation
* Unit Tests with xUnit

---

## Supported Conversions

### Length

* Meter ↔ Kilometer
* Meter ↔ Feet
* Feet ↔ Inch

### Temperature

* Celsius ↔ Fahrenheit
* Celsius ↔ Kelvin

### Weight

* Kilogram ↔ Pound
* Gram ↔ Kilogram

---

## Technologies Used

* .NET 8
* ASP.NET Core Web API
* FluentValidation
* xUnit
* Moq
* Swagger / OpenAPI

---

## Project Structure

```text
UnitConversion
│
├── UnitConversion.API
├── UnitConversion.Application
├── UnitConversion.Domain
├── UnitConversion.Infrastructure
└── UnitConversion.Tests
```

---

## Running the Project Locally

### Prerequisites

Ensure the following are installed:

* .NET 8 SDK
* Visual Studio 2022 (or later)

### Clone the Repository

```bash
git clone <repository-url>
```

### Navigate to the Solution Directory

```bash
cd UnitConversion
```

### Restore Dependencies

```bash
dotnet restore
```

### Build the Solution

```bash
dotnet build
```

### Run the API Project

```bash
dotnet run --project UnitConversion.API
```



## Sample Request

```json
{
  "category": "Length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 10
}
```

## Sample Response

```json
{
  "success": true,
  "message": "Conversion successful.",
  "data": {
    "convertedValue": 32.8084
  }
}
```

---

## Running Tests

Run all unit tests using:

```bash
dotnet test
```

---

## Design Decisions

### Clean Architecture

The solution is organized into separate projects:

* API
* Application
* Domain
* Infrastructure

This separation improves maintainability, scalability, and testability.

### Strategy Pattern

Each conversion category is implemented using a dedicated converter class that implements a common interface.

This allows the application to be easily extended with additional conversion categories without modifying existing code.

### Dependency Injection

ASP.NET Core dependency injection is used to register services and converter implementations, resulting in a loosely coupled and testable architecture.

### Validation

FluentValidation is used for request validation to keep validation logic separate from controllers and business logic.

### Exception Handling

Centralized exception handling is implemented through middleware to provide consistent API responses and avoid repetitive try-catch blocks throughout the application.

### Unit Testing

Business logic is covered using unit tests written with xUnit and Moq.

---

## Future Improvements

* Add support for additional conversion categories such as Area, Volume, Speed, and Time.
* Store conversion factors in a database instead of hardcoded values.
* Add integration tests.
* Add structured logging.
* Add caching for frequently used conversions.
* Support dynamic unit configuration.

---
