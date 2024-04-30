using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Servicios
{
    /// <summary>
    /// Clase que se encarga de las operaciones .
    /// </summary>
    internal interface OperativaInterfaz
    {

        /// <summary>
        /// Metodo que se encarga de confirmar la llegada del paciente
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void registroDeLlegada();


        /// <summary>
        /// Metodo que se encarga de imprimir por consola las consultas de psicologia
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void consultasPsicologia();



        /// <summary>
        /// Metodo que se encarga de imprimir por consola las consultas de traumatologia
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void consultasTraumatologia();




        /// <summary>
        /// Metodo que se encarga de imprimir por consola las consultas de fisioterapia
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        public void consultasFisioterapia();





       
    }
}
