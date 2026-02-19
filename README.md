# OITech Backend API

API REST desarrollada en **ASP.NET Core 5** para la integración y consulta de información territorial, catastral y registral en Colombia, incluyendo servicios de IGAC, SNR y módulos administrativos internos.

## 📖 Descripción General

OITech API es una aplicación backend construida en .NET 5 que permite:
* Autenticación mediante JWT
* Consulta de información catastral (IGAC)
* Consulta y compra de matrículas inmobiliarias (SNR)
* Gestión territorial
* Consulta de valores multivalor vía procedimientos almacenados
* Exposición de endpoints documentados con Swagger

La arquitectura sigue un modelo en capas:

```
Controllers → Services → Entity Framework Core → SQL Server
```

## 🏗 Arquitectura

El proyecto está estructurado bajo una arquitectura por capas:

* **Controllers**: Manejan los endpoints HTTP y validación de requests.
* **Services**: Contienen la lógica de negocio e integración con servicios externos.
* **Models**: 
    *  Datos (Entity Framework) 
    *  Request / Response 
    *  DTOs 
* **Entity Framework Core**: ORM para conexión con SQL Server.
* **Autenticación**: Autenticación mediante JWT (Json Web Token).

## ⚙️ Tecnologías Utilizadas

* .NET 5 (ASP.NET Core Web API)
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger (Swashbuckle)
* Newtonsoft.Json

## 📂 Estructura del Proyecto
```
OITech/
│
├── Controllers/
│   ├── UserController.cs
│   ├── IGACController.cs
│   ├── SNRController.cs
│   ├── MultivalorController.cs
│   └── TerritorioController.cs
│
├── Models/
│   ├── Datos/
│   ├── Request/
│   └── Response/
│
├── Services/
│   ├── UserService.cs
│   ├── IGAC/
│   └── SNR/
│
├── appsettings.json
├── Startup.cs
├── Program.cs
└── OITech.csproj
```

## 🔐 Autenticación

La API utiliza autenticación basada en JWT. Todos los endpoints (excepto los explícitamente habilitados) requieren:
```
Authorization: Bearer {token}
```
El token se obtiene mediante el endpoint de autenticación en UserController.

## 🌐 Endpoints Principales

### 🔑 Autenticación
```
POST /api/User/Login
```
Genera token JWT.

### 🏢 IGAC
```
POST /api/IGAC/ConsultaNumeroPredial
POST /api/IGAC/ConsultaCoordenada
```
Permite consultar información catastral por:
* Número predial
* Coordenadas geográficas

### 🏠 SNR
```
POST /api/SNR/ConsultaNumeroMatricula
POST /api/SNR/ComprarMatricula
POST /api/SNR/BuscarMatriculaComprada
POST /api/SNR/ConsultarSaldo
```
Permite:
* Consultar estado del Certificado de Tradición y Libertad por su número de matrícula inmobiliaria
* Comprar Certificado de Tradición y Libertad
* Descargar Certificado de Tradición y Libertad
* Consultar saldo de la cuenta prepago que genera las compras

### 📊 Multivalor
```
GET /api/Multivalor/ConsultarZonas
GET /api/Multivalor/ConsultarCondicionPredio
GET /api/Multivalor/ConsultarCondicionPredioAntiguo
```
Consultas mediante procedimientos almacenados en SQL Server.

## 🗄 Base de Datos
Motor: SQL Server

La conexión se configura en:
```
appsettings.json
```

#### ⚠️ IMPORTANTE
Las credenciales de base de datos no se incluyen en el repositorio público.
Para obtener acceso, Contactar al líder técnico del proyecto.

Se recomienda utilizar variables de entorno para producción.

## 🚀 Instalación y Ejecución Local

### 1️⃣ Requisitos
* .NET 5 SDK
* SQL Server
* Visual Studio 2019+ o VS Code
* Git

### 2️⃣ Clonar el repositorio
```
git clone git@github.com:meddylex-development/OITech-NETCore-Backend.git
cd OITech-NETCore-Backend/
```
**Nota**: Se deben configurar previamente las credeciales mediante ssh para tener una comunicacion mas segura con el repositorio.

### 3️⃣ Configurar appsettings.json
Configurar la cadena de conexión:
```
"ConnectionStrings": {
  "OITechContext": "Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
}
```
#### ⚠️ Solicitar credenciales al líder técnico.

### 4️⃣ Restaurar paquetes
Para restaurar los paquetes usamos:
```
dotnet restore
```

### 5️⃣ Ejecutar la aplicación
Para ejecutar la aplicación usamos el comando:
```
dotnet run
```
Por defecto correrá en:
```
https://localhost:5001
```

## 📘 Swagger
La documentación interactiva está disponible en:
```
https://localhost:{port}/swagger
```
Desde allí se pueden probar todos los endpoints.

## 🧪 Variables de Entorno Recomendadas (Producción)
En entornos productivos se recomienda:
* No usar credenciales hardcodeadas
* Utilizar variables de entorno:
    * ConnectionStrings__OITechContext
    * Jwt__Key
    * Jwt__Issuer
    * Jwt__Audience

## ☁️ Opciones de Despliegue
La API puede desplegarse en:
* IIS (Windows Server)
* Azure App Service
* Azure VM
* Docker Container
* Linux + Nginx + Kestrel

### Publicación básica
```
dotnet publish -c Release -o ./publish
```
Luego desplegar el contenido de la carpeta /publish.

## 🔐 Consideraciones de Seguridad
* No exponer credenciales en repositorio público
* Configurar HTTPS obligatorio en producción
* Usar variables de entorno
* Restringir CORS según dominio permitido
* Validar expiración de tokens JWT

## 📌 Estado del Proyecto
Proyecto en desarrollo activo.


## 👥 Contribución y Flujo de Git (Gitflow)

Este proyecto utiliza un **Gitflow estructurado** para garantizar estabilidad, trazabilidad y orden en el desarrollo.

### 🌳 Ramas Principales

- **`master`**
  - Contiene el código en producción.
  - Siempre debe estar estable.
  - No se permite desarrollo directo sobre esta rama.

- **`release`**
  - Rama de preparación de versiones.
  - Se utiliza para validaciones finales (QA / UAT).
  - Solo recibe cambios desde `develop`.

- **`develop`**
  - Rama principal de desarrollo.
  - Contiene las funcionalidades que formarán parte del próximo release.
  - Base para crear nuevas ramas de trabajo (`feature`).

---

### 🌱 Ramas de Desarrollo

- **`feature/*`**
  - Se utilizan para desarrollar nuevas funcionalidades o tareas.
  - Siempre deben crearse a partir de la rama `develop`.
  - Una vez finalizadas, se integran nuevamente en `develop`.

  **Ejemplo:**
  ```bash
  git checkout develop
  git pull origin develop
  git checkout -b feature/status-crud
  ```

### 🚑 Ramas de Corrección Urgente (Hotfix)

- **`hotfix/*`**
  - Se utilizan para corregir errores críticos en producción.
  - Siempre se crean a partir de la rama master.

Flujo obligatorio del hotfix:
   - ```hotfix/*``` → ```master```
   - ```hotfix/*``` → ```develop```

Esto garantiza que la corrección:
* Se publique inmediatamente en producción
* Quede incluida en el flujo normal de desarrollo

```
git checkout master
git pull origin master
git checkout -b hotfix/fix-auth-token
```

### 🔁 Flujo de Publicación
* Nuevas funcionalidades:
```
develop → release → master
```
* Correcciones urgentes:
```
master → hotfix → master
                ↘ develop
```

### ✅ Reglas Generales

- No se permite hacer commit directo sobre master o release
- Todas las ramas deben actualizarse desde su rama base antes de iniciar trabajo
- Los Pull Requests deben describir claramente:
  - Qué se hizo
  - Por qué se hizo
  - Qué impacto tiene

- Este flujo garantiza:
    - Estabilidad en producción
    - Correcciones sincronizadas
    - Desarrollo ordenado y escalable

## 👥 Equipo
Proyecto desarrollado por OITech.
Para acceso, soporte o información adicional contactar al líder técnico del proyecto.