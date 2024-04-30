using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Dtos
{
    /// <summary>
    /// Clase que se encarga de los datos de los pacientes
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal class PacientesDto
    {
        long id;
        string dni = "aaaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string consulta = "aaaaa";
        DateTime fechaCita;
        bool asisteciaCita = false;

       

        public PacientesDto()
        {
        }

        public PacientesDto(long id, string dni, string nombre, string apellidos, string consulta, DateTime fechaCita, bool asisteciaCita)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.consulta = consulta;
            this.fechaCita = fechaCita;
            this.asisteciaCita = asisteciaCita;
        }

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Consulta { get => consulta; set => consulta = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AsisteciaCita { get => asisteciaCita; set => asisteciaCita = value; }
    }
}
