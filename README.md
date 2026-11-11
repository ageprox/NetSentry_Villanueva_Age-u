# NetSentry - Proyecto UT2

**Alumno:** Ageñu Villanueva  
**Curso:** 2º SMR (Sistemas Microinformáticos y Redes)  

---

¿Qué es este proyecto?
Es una aplicación de consola en C# creada para gestionar las ventas de **NetSentry**, una empresa de servicios de ciberseguridad.

Permite registrar clientes, seleccionar un servicio principal, añadir extras opcionales, aplicar los descuentos o recargos correspondientes, calcular el cobro con el cambio y guardar las estadísticas de la sesión.

---

## Estructura del código
Todo el programa está dentro de un único archivo (`Program.cs`) siguiendo las condiciones de la práctica:
- Solo se usan variables básicas (`int`, `double`, `string`, `bool`), condicionales `if/else` y bucles `while`.
- No lleva arrays, listas, clases personalizadas ni funciones propias.
- Incluye `UTF-8` para mostrar correctamente el símbolo del euro (€) en la terminal.

---

Servicios y tarifas

Servicios principales
- Auditoría Básica: 40 €
- Desinfección de Malware: 60 €
- Bastionado de Sistema: 90 €

 Extras opcionales
- Copia de seguridad: +20 €
- Configuración Wi-Fi segura: +25 €
- Formación anti-phishing: +30 €

---

 Cómo ejecutarlo
Para probar la aplicación en local desde la terminal:

```bash
dotnet run
