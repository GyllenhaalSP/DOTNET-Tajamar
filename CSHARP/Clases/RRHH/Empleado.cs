using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.RRHH
{
    public class Empleado
    {
        // Constructor
        public Empleado(string nombre, string apellidos, string puesto)
        {
            Id++;   
            Nombre = nombre;
            Apellidos = apellidos;
            Puesto = puesto;
        }

        // Clave primaria o identificador
        public static int Id { get; set; }

        // Nombre del empleado
        public string? Nombre { get; set; }

        // Apellidos del empleado
        public string? Apellidos { get; set; }

        // Puesto del empleado
        public string? Puesto { get; set; }
        // Sexo
        private string _sexo;
        public string Sexo { get => _sexo; set => _sexo = value; }

        // Edad
        private int _edad;
        public int Edad { get => _edad; set => _edad = value; }

        // Estado civil
        private string _estadoCivil;
        public string EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }

        // Teléfono

        private string _telefono;
        public string Telefono
        {
            get => _telefono; 
            set => _telefono = value;
        }

        // Formación

        // Email
        private string _email;
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        // Crear una propiedad para almacenar los días de vacaciones

        public int DiasVacaciones { get; set; }

        // Crear una propiedad para almacenar los días de trabajo hasta hoy

        public int DiasTrabajados { get; set; }

        // Hacer el cálculo de los días que quedan por trabajar en el año
        // DiasTotalesAño - DiasVacaciones - DiasTrabajados
        // Días al mes = 20 días * 12 Meses = DiasTotalesAño

        public int CalcularDiasTrabajoRestantes()
        {
            const int diasTotalesAño = 20 * 12;
            var diasRestantes = diasTotalesAño - DiasTrabajados - DiasVacaciones;
            return diasRestantes;
        }

        public int CalcularDiasTrabajoRestantes(int diasTotalesAño)
        {
            if (diasTotalesAño <= 0)
            {
                diasTotalesAño = 20 * 12;
            }
            var diasRestantes = diasTotalesAño - DiasTrabajados - DiasVacaciones;
            return diasRestantes;
        }


        // Guardar el DNI de forma privada
        private string _dni;

        public string Dni
        {
            get => _dni;
            set => _dni = value;
        }

        // Crear un método para guardar el DNI de forma segura

        public void GuardarDni(string dni)
        {
            Dni = dni;
        }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellidos}";
        }
    }
}
