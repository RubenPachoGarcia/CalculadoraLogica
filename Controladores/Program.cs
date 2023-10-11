using CalculadoraLogica.Servicios;

namespace CalculadoraLogica
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicacion
        /// Contiene el flujo de la aplicacion
        /// 111023 - rpg
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Llamada al metodo. Imprime el mensaje por consola
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            //Variable que controla la entrada y salida del while
            bool cerrarMenu = false;
            //Opcion del usuario
            int opcionElegida;

            while (!cerrarMenu)
            {
                opcionElegida = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionElegida);

                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se cierra el menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado igualar. ");

                        Console.WriteLine("Introduzca la primera expresion: ");
                        string primeraExpresion=Convert.ToString(Console.ReadLine());
                       
                        Console.WriteLine("Introduzca la segunda expresion: ");
                        string segundaExpresion = Convert.ToString(Console.ReadLine());

                        bool esIgual = false;

                        if (primeraExpresion==segundaExpresion)
                        {
                            Console.WriteLine("Resultado de la igualdad: ");
                            Console.WriteLine(!esIgual);

                        }
                        else
                        {
                            Console.WriteLine("Resultado de la igualdad: ");
                            Console.WriteLine(esIgual);
                        }                                             

                        break;

                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado desigualar. ");

                        Console.WriteLine("Introduzca la primera expresion: ");
                        string terceraExpresion = Convert.ToString(Console.ReadLine());


                        Console.WriteLine("Introduzca la segunda expresion: ");
                        string cuartaExpresion = Convert.ToString(Console.ReadLine());

                        bool esDesigual = false;

                        if (terceraExpresion == cuartaExpresion)
                        {
                            Console.WriteLine("Resultado de la desigualdad: ");
                            Console.WriteLine(esDesigual);

                        }
                        else
                        {
                            Console.WriteLine("Resultado de la desigualdad: ");
                            Console.WriteLine(!esDesigual);
                        }

                        break;                                           

                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}