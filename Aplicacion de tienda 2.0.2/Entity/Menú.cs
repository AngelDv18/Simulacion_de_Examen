using Aplicacion_de_tienda_2._0._2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Aplicacion_de_tienda_2._0._2.Entity
{
    public class Menú
    {
        private Funciones funciones;
        private Cliente cliente;
        public Menú()
        {
            funciones = new Funciones();
            cliente = new Cliente();
        }
        public double MostrarMenu()
        {
            try
            {
                Console.WriteLine("Bienvenido al programa de compras");
                Console.WriteLine("---------------------------------");
                Console.Write("Ingresa tu nombre: ");
                cliente.Nombre = Console.ReadLine();
                Console.Write("Ingresa tu apellido: ");
                cliente.Apellido = Console.ReadLine();
                Console.Write("Ingresa tu edad: ");
                cliente.Edad = int.Parse(Console.ReadLine());
                Console.Write("Ingresa tu dirección: ");
                cliente.Direccion = Console.ReadLine();
                Console.Clear();
                if (cliente.Edad >= 18)
                {
                    Console.Clear();
                    Console.Write("Ingresa el total de compra: ");
                    double totalCompra = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("--------------Datos del Cliente.-------------------");
                    Console.WriteLine($"Cliente: {cliente.Nombre} {cliente.Apellido}");
                    Console.WriteLine($"Edad: {cliente.Edad}");
                    Console.WriteLine($"Dirección: {cliente.Direccion}");
                    Console.WriteLine("---------------------------------");
                    return funciones.CalcularDescuento(totalCompra);
                }
                else
                {
                    Console.WriteLine("Debes ser mayor de 18 años para realizar una compra.");
                    return 0;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor ingresado no es válido.");
                return 0;
            }
            finally
            {
                Console.WriteLine("--------------Total de Compra.-------------------");
                Console.WriteLine("Gracias por utilizar el programa. ¡Hasta luego!");
                Console.ReadLine();
            }
            //public void MostrarMenu()
            //{
            //    Console.WriteLine("Bienvenido al programa de compras");
            //    Console.WriteLine("---------------------------------");
            //    Console.Write("Ingresa tu nombre: ");
            //    cliente.Nombre = Console.ReadLine();
            //    Console.Write("Ingresa tu apellido: ");
            //    cliente.Apellido = Console.ReadLine();
            //    Console.Write("Ingresa tu edad: ");
            //    cliente.Edad = int.Parse(Console.ReadLine());
            //    Console.Write("Ingresa tu dirección: ");
            //    cliente.Direccion = Console.ReadLine();
            //    Console.Clear();
            //    if (cliente.Edad >= 18)
            //    {
            //        Console.Clear();
            //        Console.Write("Ingresa el total de compra: ");
            //        double totalCompra = int.Parse(Console.ReadLine());
            //        Console.Clear();
            //        Console.WriteLine("--------------Datos del Cliente.-------------------");
            //        Console.WriteLine($"Cliente: {cliente.Nombre} {cliente.Apellido}");
            //        Console.WriteLine($"Edad: {cliente.Edad}");
            //        Console.WriteLine($"Dirección: {cliente.Direccion}");
            //        Console.WriteLine("---------------------------------");
            //        funciones.CalcularDescuento(totalCompra);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Debes ser mayor de 18 años para realizar una compra.");
            //    }
            //    Console.WriteLine("--------------Total de Compra.-------------------");
            //    Console.WriteLine("Gracias por utilizar el programa. ¡Hasta luego!");
            //    Console.ReadLine();
            //}
        }
    }
}