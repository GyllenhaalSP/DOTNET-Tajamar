using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface ILeerVozAlta
    {
        int Duracion { get; set; }
        void LeerEnVozAlta(string texto);
    }
}