# Academy Orders API

## English Instructions

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

### How to Run the Application

1. Clone the repository:
```bash
git clone https://github.com/daniela-sanvicente/Academy.Orders.git
cd Academy.Orders
```

2. Build the solution:
```bash
dotnet build
```

3. Run the API project:
```bash
dotnet run --project src/Academy.Orders.API
```

The application will start and be available at:
- HTTP: http://localhost:5140
- HTTPS: https://localhost:7140

### API Documentation
The Swagger UI documentation is available at:
- http://localhost:5140/swagger
- https://localhost:7140/swagger

---

## Instrucciones en Español

### Prerrequisitos
- SDK de .NET 8.0 o superior
- Visual Studio 2022 o Visual Studio Code

### Cómo Ejecutar la Aplicación

1. Clonar el repositorio:
```bash
git clone https://github.com/daniela-sanvicente/Academy.Orders.git
cd Academy.Orders
```

2. Compilar la solución:
```bash
dotnet build
```

3. Ejecutar el proyecto API:
```bash
dotnet run --project src/Academy.Orders.API
```

La aplicación estará disponible en:
- HTTP: http://localhost:5140
- HTTPS: https://localhost:7140

### Documentación de la API
La documentación de Swagger UI está disponible en:
- http://localhost:5140/swagger
- https://localhost:7140/swagger

## Project Structure / Estructura del Proyecto

```
Academy.Orders/
├── src/
│   ├── Academy.Orders.API/           # API Layer / Capa de API
│   ├── Academy.Orders.Application/   # Application Layer / Capa de Aplicación
│   ├── Academy.Orders.Domain/        # Domain Layer / Capa de Dominio
│   ├── Academy.Orders.Infrastructure/# Infrastructure Layer / Capa de Infraestructura
│   ├── Academy.Orders.Presentation/  # Presentation Layer / Capa de Presentación
│   └── Academy.Orders.Tests/         # Tests / Pruebas
└── Academy.Orders.sln               # Solution File / Archivo de Solución
```
