using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga_de_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Opreraciones m1 = new Opreraciones();
            double res1 = m1.Sumar();//aqui toma el valor de el metodo suma
            double res2 = m1.Sumar(1, 2);//no ocupo istanciar varias veces 
            double res3 = m1.Sumar(1);
            Console.WriteLine("resultado 1: " + res1);
            Console.WriteLine("resultado 2: " + res2);
            Console.WriteLine("resultado 3: " + res3);
            principal d = new principal();//instancio la clase Datos para poder acceder al metodo obtener datos
            // y que ejecute todo lo que tiene el medoto 
            d.Obtener_Datos();
            Console.ReadKey();
        }
    }
}
