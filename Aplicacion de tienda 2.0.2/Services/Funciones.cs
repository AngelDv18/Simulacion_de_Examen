using Aplicacion_de_tienda_2._0._2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Aplicacion_de_tienda_2._0._2.Services
{
    public class Funciones
    {

        public double CalcularDescuento(double totalCompra)
        {
            double descuento = 0;
            string mesesSinIntereses = "";

            try
            {
                if (totalCompra >= 10000)
                {
                    descuento = totalCompra * 0.3;
                    Console.WriteLine("¡Felicidades! Obtuviste un descuento del 30%.");
                    Console.WriteLine("Selecciona la cantidad de meses sin intereses:");
                    Console.WriteLine("1. 3 meses");
                    Console.WriteLine("2. 6 meses");
                    Console.Write("Opción: ");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has seleccionado 3 meses sin intereses y obtenido el descuento del 30%.");
                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado 6 meses sin intereses y obtenido el descuento del 30%.");
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else if (totalCompra >= 5000)
                {
                    descuento = totalCompra * 0.2;
                    Console.WriteLine("¡Enhorabuena! Obtuviste un descuento del 20% y 3 meses sin intereses.");
                }
                else
                {
                    Console.WriteLine("No aplican descuentos para esta compra.");
                }
                if (descuento > 0)
                {
                    Console.WriteLine("--------------Datos de Compra.--------------------");
                    double montoConDescuento = totalCompra - descuento;
                    Console.WriteLine($"Monto ingresado: {totalCompra:C}");
                    Console.WriteLine($"Descuento obtenido: {descuento:C}");
                    Console.WriteLine($"Monto con descuento: {montoConDescuento:C}");
                }

                return descuento;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor ingresado no es válido.");
                return 0;
            }
            {
                //public void CalcularDescuento(double totalCompra)
                //{   double descuento = 0;
                //    string mesesSinIntereses = "";

                //    if (totalCompra >= 10000)
                //    {
                //        descuento = totalCompra * 0.3;
                //        Console.WriteLine("¡Felicidades! Obtuviste un descuento del 30%.");
                //        Console.WriteLine("Selecciona la cantidad de meses sin intereses:");
                //        Console.WriteLine("1. 3 meses");
                //        Console.WriteLine("2. 6 meses");
                //        Console.Write("Opción: ");
                //        int opcion = int.Parse(Console.ReadLine());
                //        switch (opcion)
                //        {
                //            case 1:
                //                Console.WriteLine("Has seleccionado 3 meses sin intereses y obtenido el descuento del 30%.");
                //                break;
                //            case 2:
                //                Console.WriteLine("Has seleccionado 6 meses sin intereses y obtenido el descuento del 30%.");
                //                break;
                //            default:
                //                Console.WriteLine("Opción inválida.");
                //                break;
                //        }
                //    }
                //    else if (totalCompra >= 5000)
                //    {
                //        descuento = totalCompra * 0.2;
                //        Console.WriteLine("¡Enhorabuena! Obtuviste un descuento del 20% y 3 meses sin intereses.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("No aplican descuentos para esta compra.");
                //    }
                //    if (descuento > 0)
                //    {
                //        Console.WriteLine("--------------Datos de Compra.--------------------");
                //        double montoConDescuento = totalCompra - descuento;
                //        Console.WriteLine($"Monto ingresado: {totalCompra:C}");
                //        Console.WriteLine($"Descuento obtenido: {descuento:C}");
                //        Console.WriteLine($"Monto con descuento: {montoConDescuento:C}");
                //    }
            }
        }
    }
}

