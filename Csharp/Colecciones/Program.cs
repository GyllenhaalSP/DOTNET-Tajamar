using Arrays;

var personasArray = new Persona[7];
personasArray[0] = new Persona("Juan", 25);
personasArray[1] = new Persona("Ana", 30);
personasArray[2] = new Persona("Luis", 20);
personasArray[3] = new Persona("Elena", 40);
personasArray[4] = new Persona("Carlos", 35);
personasArray[5] = new Persona("María", 28);
personasArray[6] = new Persona("Pedro", 18);
// personasArray[7] = new Persona("Sara", 22); Error: Índice fuera de los límites del array

var persona4 = personasArray[4];
personasArray[5] = persona4;
persona4 = new Persona("Gandalf", 1000);
personasArray[6] = persona4;

Console.WriteLine("Personas en el array:");
foreach (var persona in personasArray)
{
    Console.WriteLine(persona);
}