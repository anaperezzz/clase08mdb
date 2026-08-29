# Práctica de Bases de Datos y C# (Clase 8)

Práctica desarrollada en C# (Windows Forms) y SQL Server, enfocada en la integración de interfaces gráficas por pestañas y la gestión de conexiones a bases de datos relacionales.

## Características y Puntos Agregados

- **Interfaz Unificada por Pestañas (`TabControl`):** 
  - Se centralizaron los formularios independientes (`Form1` y `Form2`) en una única ventana contenedora (`FrmMenuPrincipal`) utilizando pestañas para mejorar la experiencia de navegación.
- **Comunicación entre Pestañas:** 
  - Implementación de paso de parámetros y métodos públicos (`AsignarCodigo`) para permitir que la búsqueda realizada en el `Form2` mueva dinámicamente el foco a la pestaña del `Form1` y cargue la información correspondiente.
- **Mantenimiento y Operaciones CRUD:** 
  - Consultas, inserciones, actualizaciones y eliminaciones conectadas a la base de datos mediante `SqlConnection`, `SqlCommand` y adaptadores de datos.
- **Validaciones de Interfaz:** 
  - Control de campos vacíos obligatorios antes de procesar inserciones o eliminaciones de registros.
