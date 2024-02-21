using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class Excel(string archivo) : Documento(archivo), IExcel
    {
        public void IrCelda(int fila, string columna)
        {
            Console.WriteLine("Ir a la celda {0}{1}", columna, fila);
        }
    }
}