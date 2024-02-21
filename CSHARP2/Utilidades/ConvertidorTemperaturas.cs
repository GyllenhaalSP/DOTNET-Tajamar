using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Double;

namespace Utilidades
{
    public class ConvertidorTemperaturas
    {
        // Crear conversor de Celsius a Farenheit
        public static double CelsiusFahrenheit(string temperaturaCelsius)
        {
            if (!TryParse(temperaturaCelsius, out var celsius))
            {
                celsius = 0;
            }
            return (celsius * 9 / 5) + 32;

        }

        // Crear conversor de Farenheit a Celsius
        public static double FahrenheitCelsius(string temperaturaFahrenheit)
        {
            if (!TryParse(temperaturaFahrenheit, out var fahrenheit))
            {
                fahrenheit = 0;
            }
            return (fahrenheit - 32) * 5 / 9;
        }

        // TODO: Crear conversor de Celsius a Kelvin
        public static double CelsiusKelvin(string temperaturaCelsius)
        {
            if (!TryParse(temperaturaCelsius, out var celsius))
            {
                celsius = 0;
            }
            return celsius + 273.15;
        }

        // TODO: Crear conversor de Kelvin a Celsius
        public static double KelvinCelsius(string temperaturaKelvin)
        {
            if (!TryParse(temperaturaKelvin, out var kelvin))
            {
                kelvin = 0;
            }
            return kelvin - 273.15;
        }
    }
}
