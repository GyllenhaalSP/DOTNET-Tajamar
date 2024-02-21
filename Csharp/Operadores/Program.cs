using Operadores;

OperadorTernario();

NullCondicional1();

NullCondicional2();

NullCoalescencia();

NullCoalescenciaEjemplo();

NullCoalescenciaLimpio();

NullCoalescenciaConAsignacion();


static void OperadorTernario()
{
    // Operador ternario

    var x = 10;
    var y = 20;

    int mayor = x > y ? x : y;
/*
    if (x > y)
    {
        mayor = x;
    }
    else
    {
        mayor = y;
    }
*/
    Console.WriteLine(mayor);
}

static void NullCondicional1()
{
    // Operador de null condicional

    string? nombre = null;

    string? nombreCompleto = nombre?.ToUpper();

    Console.WriteLine(nombreCompleto);
}

static void NullCondicional2()
{
    // Operador de null condicional
    List<string>? lista = [];
    
    var mensaje = lista?.Count > 0 ? $"La lista tiene {lista?.Count} elementos" : "La lista está vacía";

}

static void NullCoalescencia()
{
    // Operador de null coalescencia

    string? nombre = null;

    string nombreCompleto = nombre ?? "Desconocido";

    Console.WriteLine(nombreCompleto);
}

static void NullCoalescenciaEjemplo()
{
    // Operador de null coalescencia

    var mensaje = "";

    // Resultado de una consulta a BBDD
    List<string>? lista = null;

    int contadorElementos = lista?.Count ?? 0;

    mensaje = $"Operador uso combinado. Resultado: {contadorElementos}";

    Console.WriteLine(mensaje);

    lista = ["elemento1", "elemento2"];

    contadorElementos = lista?.Count ?? 0;

    mensaje = $"Operador uso combinado. Resultado: {contadorElementos}";

    mensaje = MostrarMensaje(lista);

    Console.WriteLine(mensaje);
}

static void NullCoalescenciaLimpio()
{
    // Operador de null coalescencia

    // Resultado de una consulta a BBDD
    List<string>? lista = null;
    
    Console.WriteLine(MostrarMensaje(lista));

    lista = ["elemento1", "elemento2"];

    Console.WriteLine(MostrarMensaje(lista));
}

static void NullCoalescenciaConAsignacion()
{
    Persona persona = null;

    string nombre = persona?.Nombre ?? "Desconocido";

    string mensaje = nombre != "Desconocido" ? $"'Hola! {nombre}" : "¿Y tú eras?";

    Console.WriteLine(mensaje);

    persona ??= new Persona("Juan");
    Console.WriteLine(persona.Nombre);

}

static string MostrarMensaje(List<string>? lista)
{
    return (lista?.Count ?? 0) > 0 ? $"La lista tiene {lista?.Count} elementos" : "La lista está vacía";
}