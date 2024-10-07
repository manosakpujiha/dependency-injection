# MathApi - Calculator API with Dependency Injection

This is a simple ASP.NET Core Web API project that demonstrates **Dependency Injection (DI)** using a `CalculatorService`. The API provides four basic math operations: addition, subtraction, multiplication, and division.

## Table of Contents
- [Project Overview](#project-overview)
- [Features](#features)
- [Technologies](#technologies)
- [Setup](#setup)
- [Running the Project](#running-the-project)
- [Testing the API](#testing-the-api)
- [API Endpoints](#api-endpoints)
- [License](#license)

## Project Overview

This project is a simple **calculator** API built using **ASP.NET Core 8.0**. It demonstrates:
- How to implement **dependency injection** in ASP.NET Core using `ICalculatorService` and `CalculatorService`.
- Basic math operations: **Add**, **Subtract**, **Multiply**, and **Divide**.
- How to document and test the API using **Swagger UI**.

## Features
- **Addition**, **Subtraction**, **Multiplication**, and **Division** endpoints.
- Dependency injection using the `ICalculatorService` interface.
- Proper error handling for division by zero.
- Swagger UI for testing the API endpoints interactively.

## Technologies
- **ASP.NET Core 8.0**
- **C#**
- **Swagger/OpenAPI** for API documentation
- **Dependency Injection**

## Setup

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or any C# IDE
- [GitHub Codespaces](https://github.com/features/codespaces) (optional but recommended)

### Steps to Set Up Locally

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/dependency-injection-mathapi.git
   cd dependency-injection-mathapi/MathApi
