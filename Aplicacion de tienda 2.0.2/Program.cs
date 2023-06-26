using Aplicacion_de_tienda_2._0._2.Entity;
using Aplicacion_de_tienda_2._0._2.Services;
using System;
namespace Aplicacion_de_tienda_2._0._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica Examen");
            Menú menu = new Menú();
           menu.MostrarMenu();
        }
    }
}