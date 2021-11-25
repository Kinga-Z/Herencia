using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante Fabricio = new Estudiante("Fabricio", "Chavez", 1314620855, "Soltero", 8);
            Fabricio.MostrarEstudiante();
            Fabricio.CambioEstadoCivil();
            Fabricio.CambiarCurso();

            Profesor Enrique = new Profesor("Enrique", "Segoviano", 1308328569, "Viudo", 34, 2006, "Matemáticas");
            Enrique.MostrarProfesor();
            Enrique.CambioEstadoCivil();
            Enrique.CambioDespacho();
            Enrique.CambioDepartamento();

            Personal Eddu = new Personal("Eddu", "Copiano", 1324571852, "Casado", 10, 2002, "Patio");
            Eddu.MostrarEmpleado();
            Eddu.CambioEstadoCivil();
            Eddu.CambioDespacho();
            Eddu.CambioSeccion();

            Fabricio.MostrarNewEstudiante();
            Enrique.MostrarNewProfesor();
            Eddu.MostrarNewEmpleado();
        }
    }
}
