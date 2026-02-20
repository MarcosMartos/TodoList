# ToDoList API - .NET 

Una API RESTful profesional para gestionar tareas pendientes, construida con **ASP.NET Core** y **Entity Framework Core**.

## 🚀 Características
* **Arquitectura en Capas:** Separación de responsabilidades (Controllers, Services, DTOs, Models).
* **Persistencia:** Integración con SQL Server mediante EF Core.
* **Documentación:** Swagger UI integrada para pruebas rápidas.
* **Asincronía:** Uso de `Task` y `async/await` en todas las capas.

## 🛠️ Tecnologías utilizadas
* .NET Core / C#
* Entity Framework Core (Code First)
* SQL Server
* Swagger / OpenAPI

## ⚙️ Configuración rápida
1. Clonar el repositorio.
2. Configurar la cadena de conexión en `appsettings.json`.
3. Ejecutar `dotnet ef database update` para crear las tablas.
4. Ejecutar el proyecto con `F5` o `dotnet run`.