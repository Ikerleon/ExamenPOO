using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionIker
{
    class Estudiante_Primaria : Estudiante, ICalcular, IMostrar
    {
        public int valoranual { get; set; }
        public Estudiante_Primaria(string nombre, string apellido, string institucion, int cedula) : base(nombre, apellido, institucion, cedula)
        {
            this.valoranual = 100;
        }
        public void imprimir()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Nombre: " + nombre + "Apellido: " + apellido);
            Console.WriteLine("Nombre de institucion: " + institucion);
            Console.WriteLine("Cedula: " + cedula);
        }
        public void Calcularvalor()
        {
            Console.WriteLine("El valor de la matricula es: "+valoranual);
        }
    }
}
