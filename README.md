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

###4. Vista de Clientes
![{FF2BF94D-107F-4C88-9315-69B565B5041D}](https://github.com/user-attachments/assets/a8a405d4-cbd0-4d55-81a8-91da4b9dbd76)

###5. Vista Empleados
![{51D5B619-4E80-4E25-AB25-C03E84E054FB}](https://github.com/user-attachments/assets/29349fa2-9e70-4fc9-9a05-d6a2ee053b0e)

###6. Vista seguimiento
![{38CE4583-CBF1-4B90-A78B-1A78393569FA}](https://github.com/user-attachments/assets/1ade025d-93d4-47ad-9b45-109c9c78ea65)

###7. Vista Reporte
![{77543BF8-24FB-4014-A3F0-9846FC05F5E0}](https://github.com/user-attachments/assets/c8a18b24-79a5-40e6-a8e0-24d8247aa73c)

###8. Vista Asignaciones
![{5AC65282-F05A-4A89-A6C3-4B9A8C9A27E0}](https://github.com/user-attachments/assets/0d289b86-8238-4cf9-8238-91c2cfb8be5e)

###9.Vista Conductor
![{039CE5C6-57C5-496F-946F-27E5A8C71F35}](https://github.com/user-attachments/assets/e53595fa-c243-4b64-a583-f85a1c761bd6)

###10. Vista Despachador
![{040872E5-2946-46E5-868C-997472AD9824}](https://github.com/user-attachments/assets/9b3c3ffd-a11a-4427-8cb3-a04c60480371)

---
##▶️ Video de ejecución
https://drive.google.com/file/d/1lH7l2f4T2uyu0YHnouksKd2U8Ojcu15a/view?usp=sharing
---

## ▶️ Instrucciones para compilar y ejecutar

1. **Clonar el repositorio:**

   ```bash
   git clone https://github.com/IsaiVelez472/wGestorPaqueteria.git
