using static Peliculas;

var mejorPelicula = Casablanca;


//if (mejorPelicula == Peliculas.ElPadrino)
//{

//} else if(mejorPelicula == Peliculas.Matrix) {

//}

switch (mejorPelicula)
{   
    case Casablanca:
        Console.WriteLine("Un clasico en blanco y negro");
        break;
    case ElPadrino:
        Console.WriteLine("Una oferta que no podrás rechazar ...");
        break;
    case Matrix:
        Console.WriteLine("Pastilla azul o roja ... ");
        break;
    case IndianaJones:
        Console.WriteLine("No pierde el sombrero...");
        break;
    case StarWars:
        Console.WriteLine("Soy tu padre...");
        break;
    default:
        Console.WriteLine("No está en la lista de peliculas a evaluar");
        break;
}

// Pascal Case
// NumeroTelefono 

// Camel Case
// numeroTelefono

enum Peliculas
{
    Casablanca,
    ElPadrino,
    Matrix,
    IndianaJones,
    StarWars
}