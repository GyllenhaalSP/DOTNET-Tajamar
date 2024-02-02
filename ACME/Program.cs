using ACME;

/* TODO
 *
 * La empresa ACME tiene 2 tipos de empleados cada empleado tiene unos días de vacaciones.
 * Se debería poder mostrar por pantalla la información relativa a cada empleado: Nombre y
 * días de vacaciones.
 * Todos los empleados tienen 25 días de vacaciones.
 * 
 * - Administrador
 *  Tiene o no plaza de parking.
 *  Si tiene plaza de parking, guarda la matrícula del coche.
 *  Tiene 5 días más de vacaciones.
 *  Mostrar:
 *      Nombre, días de vacaciones y si tiene plaza de parking, la matrícula del coche.
 *      
 * 
 * - Operario
 *  Guardaremos el turno en el que trabaja. (Mañana, tarde o noche)
 *  Tiene 6 días más de vacaciones.
 *  Mostrar:
 *      Nombre, días de vacaciones y turno.
 *
 * - Externo
 *  Guardaremos la empresa para la que trabaja.
 *  Mostrar:
 *      Nombre y nombre de empresa.
 */

var acme = new Empresa("ACME", "Calle Falsa 123");

Empleado empleado = new Operario("Pepe", Turno.Mañana, acme);
acme.Empleados.Add(empleado);
Empleado empleado2 = new Operario("Juan", Turno.Tarde, acme);
acme.Empleados.Add(empleado2);
Empleado empleado3 = new Operario("Luis", Turno.Noche, acme);
acme.Empleados.Add(empleado3);
Empleado empleado4 = new Administrador("Luis", acme, true, "1234ABC");
acme.Empleados.Add(empleado4);
Empleado empleado5 = new Administrador("Ana", acme, false, "");
acme.Empleados.Add(empleado5);

Externo externo = new Externo("Pedro", acme);

acme.Externos.Add(externo);

Console.WriteLine(acme);