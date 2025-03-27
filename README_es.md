# HotelSol - PMS con conexión a Odoo

## Resumen del Proyecto

### Propósito

HotelSol es un Sistema de Gestión Hotelera (PMS) básico diseñado para gestionar operaciones hoteleras con integración al ERP Odoo. El sistema proporciona herramientas para gestionar reservas, check-ins/check-outs, gestión de habitaciones e inventario de productos, manteniendo la sincronización con Odoo para mejorar las operaciones comerciales.

### Stack Tecnológico

- **Lenguaje**: C# (.NET)
- **Plataforma**: Aplicación de Escritorio Windows
- **Arquitectura**: MVC (Modelo-Vista-Controlador)
- **Tecnologías Principales**:
  - Entity Framework Core para operaciones de base de datos
  - SQL Server para almacenamiento de datos
  - Scripts Python para integración con Odoo
  - Windows Forms para la interfaz de usuario

### Características

- **Autenticación**:

  - Sistema básico de autenticación de usuarios
  - Control de acceso basado en roles
  - Gestión de sesiones

- **Características de Gestión Hotelera**:

  - Gestión y asignación de habitaciones
  - Procesamiento de check-in/check-out
  - Gestión de reservas
  - Gestión de información de huéspedes
  - Seguimiento del estado de las habitaciones
  - Gestión de precios y tarifas

- **Interfaz de Usuario**:

  - Interfaz Windows Forms
  - Visualización del estado de habitaciones
  - Panel de gestión de reservas
  - Formularios de información de huéspedes
  - Gestión de inventario de productos
  - Interfaz de integración con Odoo

- **Características Técnicas**:
  - Sincronización en tiempo real con Odoo
  - Importación/exportación de datos XML
  - Gestión de inventario de productos
  - Actualizaciones automáticas de stock
  - Gestión de datos de clientes
  - Seguimiento de reservas
  - Facturación

### Seguridad

- **Seguridad de Autenticación**:

  - Sistema básico de autenticación de usuarios
  - Encriptación de contraseñas usando AES
  - Control de acceso basado en roles (Administrador, Recepcionista, Mantenimiento)
  - Gestión de sesiones

- **Seguridad de Datos**:

  - Base de datos SQL Server con conexiones encriptadas
  - Comunicaciones seguras con API de Odoo
  - Validación básica de datos
  - Registro de errores

- **Mejores Prácticas**:
  - Validación de entrada de datos
  - Manejo básico de errores
  - Almacenamiento seguro de contraseñas
  - Gestión de sesiones de usuario

### Co-Desarrolladores

- **Desarrolladores Principales**:
  - Iker López Iribas
  - Damià Belles Sampera
  - César Flores Carrera

## Configuración del Entorno

### Prerrequisitos

- Windows 10 o superior
- SDK de .NET Core
- Python 3.x
- SQL Server
- Instancia de Odoo
- Visual Studio 2022 (recomendado)

### API Keys Requeridas

1. **Credenciales de API de Odoo**
   - URL
   - Nombre de la base de datos
   - Nombre de usuario
   - Contraseña

### Instrucciones de Configuración

1. **Clonar el Repositorio**

   ```bash
   git clone https://github.com/ikerloir35/HotelSol.git
   ```

2. **Configuración del Entorno**

   - Configurar cadena de conexión en `App.config`
   - Configurar credenciales de API de Odoo
   - Configurar rutas de archivos XML

3. **Configuración de Compilación**

   - Abrir solución en Visual Studio
   - Restaurar paquetes NuGet
   - Compilar la solución

4. **Ejecutar la Aplicación**
   - Ejecutar desde Visual Studio
   - O usar el paquete instalador

### Mejores Prácticas de Seguridad

1. **Gestión de API Keys**

   - Almacenar credenciales en configuración segura
   - Usar variables de entorno para datos sensibles
   - Rotación regular de credenciales

2. **Seguridad del Código**

   - Auditorías regulares de seguridad
   - Validación de entrada de datos
   - Manejo de errores
   - Protocolos de comunicación seguros

3. **Flujo de Desarrollo**
   - Control de versiones
   - Proceso de revisión de código
   - Procedimientos de prueba
   - Actualizaciones de documentación

### Solución de Problemas

1. **Problemas de Compilación**

   - Verificar versión del SDK de .NET
   - Verificar versiones de paquetes NuGet
   - Comprobar instalación de Python

2. **Problemas de Ejecución**

   - Problemas de conexión a base de datos
   - Conectividad con API de Odoo
   - Problemas de permisos de archivos

3. **Problemas de Autenticación**
   - Verificar credenciales de API
   - Comprobar conectividad de red
   - Validar permisos de usuario

## Licencia

Este proyecto está licenciado bajo la Licencia Universal Creative Commons CC0 1.0. Esto significa que:

- La obra está dedicada al dominio público
- Puedes usar, modificar y distribuir la obra libremente para cualquier propósito
- No se requiere atribución
- La obra se proporciona "tal cual" sin garantías
- La licencia es irrevocable y no puede ser terminada

Para más detalles, consulta el archivo [LICENSE](LICENSE) en el directorio raíz de este proyecto.
