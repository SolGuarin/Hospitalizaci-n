using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola2
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            //AddPaciente();}
            UpdatePaciente();
            //BuscarPaciente(1);
            //EliminarPaciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Nicolay",
                Apellidos = "Perez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 N° 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };

            _repoPaciente.AddPaciente(paciente);

        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.Write(paciente.Nombre + " " + paciente.Apellidos);
        }

        private static void EliminarPaciente(int idPatiente){
            _repoPaciente.DeletePaciente(idPatiente);
            Console.Write("el paciente ha sido eliminado");
        }


        private static void UpdatePaciente(){
            var paciente = new Paciente
            {
                Id=2,
                Nombre = "Nicolay",
                Apellidos = "Perez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 N° 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.UpdatePaciente(paciente);
        }
    }
}