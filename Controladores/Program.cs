using edu.CMejero.Dtos;
using edu.CMejero.Servicios;

namespace edu.CMejero.Controladores
{
    /// <summary>
    /// Clase principal de nuestra aplicacion
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal class Program
    {
        static public string rutaFichero = "C:\\Users\\Carlos\\Desktop\\citas.txt";
        static public List<PacientesDto> listaPacientes = new List<PacientesDto>();
        static public string rutaPasos;


        /// <summary>
        /// Metodo principal de entrada de nuestra aplicación
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicherosInterfaz fi = new FicherosImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcionUsuario;
            bool cerrarMenu = false;
            DateTime fecha = DateTime.Now;

            rutaPasos = "C:\\Users\\Carlos\\Desktop\\log-" + fecha.ToString("ddMMyyyy") + ".txt";

            try
            {
                fi.leerFichero();

                while (!cerrarMenu)
                {
                    opcionUsuario = mi.menuYSeleccionPuntoAcceso();

                    switch (opcionUsuario)
                    {
                        case 0:
                            Console.WriteLine("Has indicado Cerrar Menu");
                            fi.escribirFichero();
                            cerrarMenu = true;
                            StreamWriter sw = new StreamWriter(rutaPasos, true);
                            sw.WriteLine("ha indicado cerrar Menu");
                            sw.Close();
                            break;
                            
                        case 1:
                            Console.WriteLine("Has indicado registro de llegada");
                            oi.registroDeLlegada();
                            StreamWriter sx = new StreamWriter(rutaPasos, true);
                            sx.WriteLine("ha indicado registro de llegada");
                            sx.Close();
                            break;

                        case 2:
                            Console.WriteLine("Has indicado listado de consultas");
                            mi.accesoConsultas();
                            StreamWriter si = new StreamWriter(rutaPasos, true);
                            si.WriteLine("ha indicado listado de consultas");
                            si.Close();
                            break;

                        default:
                            Console.WriteLine("La opción indicada no corresponde con ninguna");
                            StreamWriter so = new StreamWriter(rutaPasos, true);
                            so.WriteLine("ha indicado una respuesta erronea en menu y seleccion de punto de acceso");
                            so.Close();
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error, intentalo más tarde" + ex.Message);
                StreamWriter sw = new StreamWriter(rutaPasos, true);
                sw.WriteLine("ha habido un error tipo: " +ex.Message);
                sw.Close();
            }






        }
    }
}
