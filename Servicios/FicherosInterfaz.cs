using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Servicios
{
    /// <summary>
    /// Clase que se encarga de la operativa con ficheros
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de leer un fichero e introducir sus valores a lista de pacientes
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void leerFichero();


        /// <summary>
        /// Metodo que se encargar de escribir en ficheros
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void escribirFichero();


        /// <summary>
        /// Metodo que se encarga de imprimir a ficheros las consultas del dia introducido.
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void imprimirConsultas();
    }
}
