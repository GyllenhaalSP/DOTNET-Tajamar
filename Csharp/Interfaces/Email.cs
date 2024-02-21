using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces;

public class Email(string archivo) : Documento(archivo), ILeerVozAlta
{
    public int Duracion { get; set; }

    public void LeerEnVozAlta(string texto)
    {
    }
}
