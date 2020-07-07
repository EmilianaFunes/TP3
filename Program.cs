using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Trabajo_Práctico_N_3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Curso
    {
        public static List<Curso> Cursos = new List<Curso>();
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Horario { get; set; }
        public string Aula { get; set; }
        public double CupoMAx { get; set; }
        public double CupoMin { get; set; }

        public Curso(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string horario, string aula, double cupomax, double cupomin)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Horario = horario;
            Aula = aula;
            CupoMAx = cupomax;
            CupoMin = cupomin;
        }

        static public void RegistroCurso()
        {
            Console.WriteLine("REGISTRO CURSOS");

            Console.WriteLine("Ingrese el nombre del curso: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese a quién va destinado el curso: ");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese fecha inicio del curso: ");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese fecha fin del curso: ");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese horario del curso: ");
            string horario = Console.ReadLine();

            Console.WriteLine("Ingrese aula a dictarse: ");
            string aula = Console.ReadLine();

            Console.WriteLine("Ingrese cupo mínimo de estudiantes: ");
            double cupomax = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cupo máximo de estudiantes: ");
            double cupomin = double.Parse(Console.ReadLine());
        }
   }

    class Docente 
    {
        public Especialidad Especialidad { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Docente(string nombre, string dni, string email, string telefono)
        {
            Nombre = nombre;
            DNI = dni;
            Email = email;
            Telefono = telefono;
        }
    }

    public class RegistroDocente
    {
        public static List<Docente> Docentes = new List<Docente>();

        static RegistroDocente()
        {
            Docentes.Add()
        }

    }

    class Alumno 
    {
        public static List<Alumno> Alumnos = new List<Alumno>();
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Alumno(string nombre, string dni, string email, string telefono)
        {
            Nombre = nombre;
            DNI = dni;
            Email = email;
            Telefono = telefono;
        }
    }

    class Especialidad
    {
        public static List<Especialidad> Especialidades = new List<Especialidad>();
        public string Nombre { get; set; }
        public string Area { get; set; }

        public Especialidad(string nombre, string area)
        {
            Nombre = nombre;
            Area = area;
        }
    }

    class Inscripcion
    {
        public static List<Inscripcion> Inscripciones = new List<Inscripcion>();
        public DateTime FechaInscripcion { get; set; }
        public Curso Curso { get; set; }

        public Inscripcion(DateTime fechainscripcion, Curso curso)
        {
            FechaInscripcion = fechainscripcion;
            Curso = curso;
        }
    }
}
    
    
