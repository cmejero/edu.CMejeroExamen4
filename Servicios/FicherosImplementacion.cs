using edu.CMejero.Controladores;
using edu.CMejero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejero.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz
    /// @Author=CMejero - 30/04/2024
    /// </summary>
    internal class FicherosImplementacion : FicherosInterfaz
    {

        public void leerFichero()
        {
            try { 
            StreamReader sr = new StreamReader(Program.rutaFichero);

            string[] lineas = sr.ReadToEnd();

                foreach (string linea in lineas)
                {

                    string[] pac = linea.Split(';');

                    PacientesDto paciente = new PacientesDto();
                    paciente.Id = autoincrementarID();
                    paciente.Dni = pac[0];
                    paciente.Nombre = pac[1];
                    paciente.Apellidos = pac[2];
                    paciente.Consulta = pac[3];
                    string fechaTexto = pac[4];

                    DateTime fechaDate = DateTime.Parse(fechaTexto);
                    paciente.FechaCita = fechaDate;

                    bool cita = Convert.ToBoolean(pac[5]);

                    Program.listaPacientes.Add(paciente);

                    sr.Close();

                }


            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un errar en ficheros, intentalo más tarde" + io.Message);
            }


        }
        /// <summary>
        /// Metodo que se encarga de asignar el Id de los pacientes
        /// @Author=CMejero - 30/04/2024
        /// </summary>
        /// <returns></returns>
        private long autoincrementarID()
        {
            long nuevoId;
            int tamanioLista = Program.listaPacientes.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaPacientes[tamanioLista - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }

        public void escribirFichero()
        {
            try
            {
                StreamWriter sw = new StreamWriter(Program.rutaFichero);


                foreach (PacientesDto paciente in Program.listaPacientes)
                {
                    sw.WriteLine(paciente.Dni + ';' + paciente.Nombre + ';' + paciente.Apellidos + ';' + paciente.Consulta + ';' + paciente.FechaCita + ';' + paciente.AsisteciaCita + "/n");
                }
                sw.Close();
            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un errar en ficheros, intentalo más tarde" + io.Message);
            }

        }


        public void imprimirConsultas()
        {
            try
            {

                Console.WriteLine("introduzca una fecha");
                string fechaintroducida = Console.ReadLine();

                DateTime fecha = DateTime.Parse(fechaintroducida);

                Console.WriteLine("Introduzca la consulta: Psicologia, Traumatologia o Fisioterapia");
                string consulta = Console.ReadLine();

                string rutaArchivo = "C:\\Users\\Carlos\\Desktop\\citasConAsistencia-" + fecha.ToString() + ".txt";

                foreach (PacientesDto paciente in Program.listaPacientes)
                {
                    if (paciente.AsisteciaCita == true & fecha == paciente.FechaCita)
                    {
                        if (paciente.Consulta.Equals("Psicologia"))
                        {

                            StreamWriter sw = new StreamWriter(rutaArchivo);

                            sw.WriteLine(paciente + "/n");

                        }
                        else
                        {
                            Console.WriteLine("La opcion introducida es incorrecta");
                        }

                        if (paciente.Consulta.Equals("Traumatologia"))
                        {

                            StreamWriter sw = new StreamWriter(rutaArchivo);

                            sw.WriteLine(paciente + "/n");

                        }
                        else
                        {
                            Console.WriteLine("La opcion introducida es incorrecta");

                        }



                        if (paciente.Consulta.Equals("Fisioterapia"))
                        {

                            StreamWriter sw = new StreamWriter(rutaArchivo);

                            sw.WriteLine(paciente + "/n");

                        }
                        else
                        {
                            Console.WriteLine("La opcion introducida es incorrecta");
                        }



                    }
                    else
                    {
                        Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                    }

                }
            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un errar en ficheros, intentalo más tarde" + io.Message);
            }
        }
    }
}
