using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Servicios
{
    /// <summary>
    /// Clase que se encarga del funcionamiento de los menus y submenus
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal interface MenuInterfaz
    {

        /// <summary>
        /// Metodo que muestra el menu principal de la aplicación
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        /// <returns></returns>
        public int menuYSeleccionPuntoAcceso();


        /// <summary>
        /// Método que muestra el menu de acceso a las consultas
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void accesoConsultas();


        /// <summary>
        /// Método que muestra el menu de acceso a menu de mostrar consultas
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void mostrarConsultas();

    }
}
