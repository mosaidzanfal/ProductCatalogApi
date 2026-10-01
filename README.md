# Product Catalog API

A simple Product Catalog REST API built with ASP.NET Core and .NET.

## Features

- Get all products
- Get a product by ID
- Create products
- Update products
- Delete products
- Product data validation
- Custom request logging middleware
- Dependency Injection
- OpenAPI support

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get a product by ID |
| POST | /api/products | Create a new product |
| PUT | /api/products/{id} | Update an existing product |
| DELETE | /api/products/{id} | Delete a product |

## Validation

Product data is validated using Data Annotations.

- Product name is required.
- Product price must be between 0.01 and 1,000,000.
- Invalid requests return HTTP 400 Bad Request.

## Middleware

The project includes custom request logging middleware that logs:

- HTTP request method
- Request path
- HTTP response status code

## Dependency Injection

`IProductService` is registered with `ProductService` using a scoped lifetime.

## Microsoft Copilot

Microsoft Copilot was used as a development assistant during the project.

It assisted with code suggestions and debugging while implementing the API. Generated suggestions were reviewed, understood, tested, and modified when necessary before being included in the project.

For example, Copilot was used while reviewing API endpoint implementation and validation behavior. The final implementation was verified by manually testing GET, POST, PUT, and DELETE requests, including invalid requests that return HTTP 400.

Copilot was used to support development decisions, not replace them.

## Technologies

- C#
- .NET 10
- ASP.NET Core Web API
- OpenAPI
- Microsoft Copilot