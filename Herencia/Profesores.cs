using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Profesor : Empleado
    {
        public string Departamento { get; set; }
        public Profesor(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoIncorporacion, string Departamento) : base(Nombre, Apellido, Cedula, EstadoCivil, NumeroDespacho, AñoIncorporacion)
        {
            this.Departamento = Departamento;
        }
        public void MostrarProfesor()
        {
            Console.WriteLine("-----------------\nPROFESOR\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Departamento: " + Departamento);
        }
        public void CambioDepartamento()
        {
            string NuevoDepartamento;
            Console.WriteLine("Departamento al que quiera cambiar");
            NuevoDepartamento = Convert.ToString(Console.ReadLine());
            Departamento = NuevoDepartamento;
            Console.WriteLine("Departamento nuevo: " + Departamento);
        }
        public void MostrarNewProfesor()
        {
            Console.WriteLine("-----------------\nPROFESOR\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Departamento: " + Departamento);
        }
    }
}
