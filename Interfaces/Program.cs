using Interfaces;

Documento documento = new Documento(@"C:\temp\test.txt");

documento.Leer(documento.NombreArchivo);
documento.Escribir(documento.NombreArchivo);
//Viene de Documento.cs
documento.Imprimir(documento.NombreArchivo);

IAlmacenamiento documento2 = new Documento(@"C:\temp\test.txt");
documento2.Leer(documento2.NombreArchivo);
documento2.Escribir(documento2.NombreArchivo);
// Viene de IAlmacenamiento.cs y por lo tanto no existe
//documento2.Imprimir(documento2.NombreArchivo);

IImprimir documento3 = new Documento(@"C:\temp\test.txt");
// Viene de IImprimir.cs y por lo tanto no existen
//documento3.Leer(documento2.NombreArchivo);
//documento3.Escribir(documento2.NombreArchivo);
documento3.Imprimir(documento2.NombreArchivo);

ILeerVozAlta correo = new Email(@"C:\temp\test.txt");
correo.LeerEnVozAlta("Hola Mundo");

Email documento4 = new Email(@"C:\temp\test.txt");
documento4.Leer(documento4.NombreArchivo);
documento4.Escribir(documento4.NombreArchivo);
documento4.Imprimir(documento4.NombreArchivo);
documento4.LeerEnVozAlta("Hola Mundo");
