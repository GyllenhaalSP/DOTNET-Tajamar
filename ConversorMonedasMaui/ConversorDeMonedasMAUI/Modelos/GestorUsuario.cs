using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos;

public class GestorUsuario
{
    public List<Usuario> Usuarios { get; set; }

    public GestorUsuario()
    {
        Usuarios =
        [
            new Usuario("Juan", "Pérez García", 'V'),
            new Usuario("María", "López Sáez", 'M'),
            new Usuario("Pedro", "García Aguado", 'V'),
            new Usuario("Ana", "Martinez Sevilla", 'M'),
            new Usuario("Luis", "Sánchez Santos", 'V'),
            new Usuario("Elena", "Gómez Illescas", 'M'),
        ];
    }
}
