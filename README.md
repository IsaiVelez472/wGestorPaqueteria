# 📦 wGestorPaqueteria

**wGestorPaqueteria** es una aplicación de escritorio desarrollada en **C# con Windows Forms**, orientada a la gestión de paquetes en una empresa de mensajería. Este proyecto fue desarrollado como parte de una entrega académica y cumple con los requisitos funcionales para la fecha **20 de mayo**, incluyendo:

- ✅ Un módulo completo con operaciones **CRUD** para la gestión de paquetes.
- ✅ Un módulo de **autenticación de usuarios** con control de sesión.

---

## 🎯 Propósito del Proyecto

El objetivo de este sistema es ofrecer una solución práctica para registrar, actualizar, eliminar y consultar paquetes enviados, con control sobre el estado de los mismos, incluyendo también la gestión de clientes (remitente y destinatario). Además, se controla el acceso al sistema mediante un inicio de sesión autenticado.

---

## 🛠️ Funcionalidades principales

- **Inicio de sesión** con verificación de credenciales.
- **Gestión de paquetes**:
  - Crear nuevo paquete.
  - Actualizar estado.
  - Eliminar paquete.
  - Listar paquetes con detalle.
- **Gestión de clientes** (Remitente/Destinatario).
- Validaciones de datos en formularios.
- Interface gráfica intuitiva.
- Persistencia de datos usando base de datos.

---

## 📐 Diagrama Entidad-Relación

El sistema está basado en una estructura simple de tres entidades principales:

```plaintext
+-------------+           +-------------+           +--------------+
|   Roles     |           |  Usuarios   |           |  Empleados   |
+-------------+           +-------------+           +--------------+
| IdRol       |◄────────┐ | IdUsuario   |           | EmpleadoID   |
| NombreRol   |         └►| Usuario     |           | Nombre       |
+-------------+           | Clave       |◄──────┐    | Telefono     |
                          | RolId       |       └────► RolId       |
                          +-------------+           +--------------+

+-------------+           +-------------+           +-------------------+
|  Clientes   |           |  Paquetes   |           |   Seguimiento     |
+-------------+           +-------------+           +-------------------+
| ClienteID   |◄──┐    ┌─►| PaqueteID   |◄─────┐     | SeguimientoID     |
| Nombre      |   └───►|   RemitenteID |      └────► | PaqueteID         |
| Telefono    |       └─► DestinatarioID|           | FechaEvento       |
| Email       |           | Peso        |           | DescripcionEvento |
| Direccion   |           | Dimensiones |           | Ubicacion         |
+-------------+           | ValorDeclarado|         +-------------------+
                          | Estado      |
                          +-------------+

                        +------------------+
                        |   Asignaciones   |
                        +------------------+
                        | AsignacionID     |
                        | PaqueteID        |◄─────────┐
                        | EmpleadoID       |◄────┐     │
                        | FechaAsignacion  |     │     │
                        +------------------+     │     │
                                                 │     │
                         (de Paquetes)───────────┘     │
                         (de Empleados)────────────────┘

```

## 🧰 Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Base de datos:** SQL Server
- **Acceso a datos:** ADO.NET
- **IDE:** Visual Studio
- **Control de versiones:** Git y GitHub

---

## 🖼️ Capturas de pantalla

### 1. Pantalla de Login
![image](https://github.com/user-attachments/assets/a5398605-e298-4dd9-80f3-bed962f7ade4)

### 2. Formulario de Registro de Paquete
![image](https://github.com/user-attachments/assets/62582972-8963-4ba3-b0fe-ecc046238f1b)

### 3. Vista de Paquetes
![image](https://github.com/user-attachments/assets/bd0d38b6-f70a-44c0-8837-eeb6bbcda91d)


---

## ▶️ Instrucciones para compilar y ejecutar

1. **Clonar el repositorio:**

   ```bash
   git clone https://github.com/IsaiVelez472/wGestorPaqueteria.git
