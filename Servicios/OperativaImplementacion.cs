using edu.CMejero.Controladores;
using edu.CMejero.Dtos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Servicios
{

    /// <summary>
    /// Clase que implementa la operativa interfaz
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void registroDeLlegada()
        {
            try {
                Console.WriteLine("Introduce su dni");
                string dniIntrodunido = Console.ReadLine();
                DateTime fechaHoy = DateTime.Today;

                foreach (PacientesDto paciente in Program.listaPacientes)
                {
                    if (paciente.Dni.Equals(dniIntrodunido))
                    {
                        if (paciente.FechaCita.CompareTo(fechaHoy) == 0)
                        {
                            paciente.AsisteciaCita = true;

                            Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                        }
                        else
                        {
                            Console.WriteLine("No dispone de cita previa para hoy.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No dispone de cita previa para hoy.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void consultasPsicologia()
        {
            try
            {
                foreach (PacientesDto paciente in Program.listaPacientes)
                {
                    if (paciente.Consulta.Equals("Psicologia"))
                    {
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        string fechaIntroducida = Console.ReadLine();

                        DateTime fecha = DateTime.Parse(fechaIntroducida);

                        if (paciente.FechaCita == fecha)
                        {
                            Console.WriteLine("Nombre completo: " + paciente.Nombre + " " + paciente.Apellidos + " Hora: " + paciente.FechaCita.ToShortTimeString);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void consultasTraumatologia()
        {
            try
            {
                foreach (PacientesDto paciente in Program.listaPacientes)
                {
                    if (paciente.Consulta.Equals("Traumatología"))
                    {
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        string fechaIntroducida = Console.ReadLine();

                        DateTime fecha = DateTime.Parse(fechaIntroducida);

                        if (paciente.FechaCita == fecha)
                        {
                            Console.WriteLine("Nombre completo: " + paciente.Nombre + " " + paciente.Apellidos + "Hora: " + paciente.FechaCita.ToShortTimeString);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void consultasFisioterapia()
        {
            try
            {

                foreach (PacientesDto paciente in Program.listaPacientes)
                {
                    if (paciente.Consulta.Equals("Fisioterapia"))
                    {
                        Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                        string fechaIntroducida = Console.ReadLine();

                        DateTime fecha = DateTime.Parse(fechaIntroducida);

                        if (paciente.FechaCita == fecha)
                        {
                            Console.WriteLine("Nombre completo: " + paciente.Nombre + " " + paciente.Apellidos + "Hora: " + paciente.FechaCita.ToShortTimeString);
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        



        
    }
}
