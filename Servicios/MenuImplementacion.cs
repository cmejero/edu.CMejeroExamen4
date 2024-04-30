using edu.CMejero.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Servicios
{
    /// <summary>
    /// Clase que implementa el menu interfaz
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        OperativaInterfaz oi = new OperativaImplementacion();
        FicherosInterfaz fi = new FicherosImplementacion();

        public int menuYSeleccionPuntoAcceso()
        {
            int opcionUsuario;

            Console.WriteLine("########################");
            Console.WriteLine("0. Cerrar Aplicación");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado de Consultas");
            Console.WriteLine("########################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }

        /// <summary>
        /// Metodo donde muestra las diferentes opciones del menu consultas
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        /// <returns></returns>
        private int menuYSeleccionConsultas()
        {
            int opcionUsuario;

            Console.WriteLine("########################");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Mostrar consultas");
            Console.WriteLine("2. Imprimir Consultas");
            Console.WriteLine("########################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;

        }

        public void accesoConsultas()
        {
            int opcionUsuario;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionUsuario = menuYSeleccionConsultas();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has indicado Volver");
                        cerrarMenu = true;
                        StreamWriter sw = new StreamWriter(Program.rutaPasos, true);
                        sw.WriteLine("ha indicado volver a menu principal");
                        sw.Close();
                        break;

                    case 1:
                        Console.WriteLine("Has indicado mostrar consultas");
                        menuYSeleccionMostrarConsultas();
                        StreamWriter so = new StreamWriter(Program.rutaPasos, true);
                        so.WriteLine("ha indicado mostrar consultas");
                        so.Close();
                        break;

                    case 2:
                        Console.WriteLine("Has indicado imprimir consultas");
                        fi.imprimirConsultas();
                        StreamWriter sx = new StreamWriter(Program.rutaPasos, true);
                        sx.WriteLine("ha indicado imprimir consultas");
                        sx.Close();
                        break;

                    default:
                        Console.WriteLine("La opción indicada no corresponde con ninguna");
                        StreamWriter st = new StreamWriter(Program.rutaPasos, true);
                        st.WriteLine("ha indicado una opcion erronea en menu y seleccion de consultas");
                        st.Close();
                        break;
                }

            }

        }



        /// <summary>
        /// Metodo donde muestra las diferentes opciones del menu mostrar consultas
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        /// <returns></returns>
        private int menuYSeleccionMostrarConsultas()
        {
            int opcionUsuario;

            

            Console.WriteLine("########################");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Psicologia");
            Console.WriteLine("2. Traumatologia");
            Console.WriteLine("2. Fisioterapia");
            Console.WriteLine("########################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }


        public void mostrarConsultas()
        {
            
            int opcionUsuario;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionUsuario = menuYSeleccionMostrarConsultas();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has indicado Volver");
                        cerrarMenu = true;
                        StreamWriter sw = new StreamWriter(Program.rutaPasos, true);
                        sw.WriteLine("ha indicado volver");
                        sw.Close();
                        break;

                    case 1:
                        Console.WriteLine("Has indicado Psicologia");
                        oi.consultasPsicologia();
                        StreamWriter so = new StreamWriter(Program.rutaPasos, true);
                        so.WriteLine("ha indicado psicologia");
                        so.Close();
                        break;

                    case 2:
                        Console.WriteLine("Has indicado Traumatologia");
                        oi.consultasTraumatologia();
                        StreamWriter sx = new StreamWriter(Program.rutaPasos, true);
                        sx.WriteLine("ha indicado traumatologia");
                        sx.Close();
                        break;

                    case 3:
                        Console.WriteLine("Has indicado Fisioterapia");
                        oi.consultasFisioterapia();
                        StreamWriter sq = new StreamWriter(Program.rutaPasos, true);
                        sq.WriteLine("ha indicado volver a menu Fisioterapia");
                        sq.Close();
                        break;

                    default:
                        Console.WriteLine("La opción indicada no corresponde con ninguna");
                             StreamWriter sh = new StreamWriter(Program.rutaPasos, true);
                        sh.WriteLine("ha indicado incorrectamenta la opcion de menu y seleccion mostrar consultas ");
                        sh.Close(); ;
                        break;
                }

            }

        }

    }
}
