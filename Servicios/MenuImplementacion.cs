using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 111023 - rpg
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("##############################");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Igualdad");
            Console.WriteLine("2. Desigualdad");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }
    }
}
