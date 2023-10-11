using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y recoge la seleccion del usuario
        /// 111023 - rpg
        /// </summary>
        /// <returns>entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
