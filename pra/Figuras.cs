using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace pra
{
    internal class Figuras
    {

        public string figu {    get; set; }
        public double f1 {  get; set; }
        public double f2 { get; set; }
        public double f3 { get; set; }
        public double f4 { get; set; }
        public double f5 { get; set; }



        public double la { get; set; }
        public double la2 { get; set; }
        public double ba { get; set; }
        public double al { get; set; }
        public double ra { get; set; }
        public double ba1 { get; set; }
        public double al1 { get; set; }
        public double ba2 { get; set; }
        public double al2 { get; set; }


        public Figuras(string fi,double f,double l, double b, double a, double r,double l2, double fe, double fo, double fu, double fb, int b1, int a1, int b2, int a2) 
        { 
          figu=fi;
          f1=f;
          la=l;
          ba=b;
          al=a;
          ra=r; 
          la2=l2;
         
            f2 = fe;
            f3 = fo;
            f4 = fu;
            f5 = fb;
            ba1 = b1;
            al1 = a1;
            ba2 = b2;
            al2 = a2;

        }
        public static void crear(List<Figuras> cada)
        {
            Console.WriteLine("INGRESE LA FIGURA QUE QUIERE UTILIZAR:");
            Console.WriteLine("Recuerde que solo hay:");
            Console.WriteLine("CUADRADO");
            Console.WriteLine("TRIANGULO");
            Console.WriteLine("ROMBOIDE");
            Console.WriteLine("RECTANGULO");
            Console.WriteLine("CIRCULO");
            Console.WriteLine("Escribir la figura con minuscula");
            string f1=Console.ReadLine();
            
            switch (f1) 
            {
                case  "cuadrado":
                    Console.WriteLine("Ingrese el lado de la figura");
                    double l=double.Parse(Console.ReadLine());

                    double f = l * l;
                    Console.WriteLine("La respuesta es:");
                    Console.WriteLine(f);
                break;
                case "triangulo":
                    Console.WriteLine("Ingrese la base de la figura");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la figura");
                    double a = double.Parse(Console.ReadLine());

                    double fe = (b * a)/2;
                    Console.WriteLine("La respuesta es:");
                    Console.WriteLine(fe);
                    break;
                case "romboide":
                    Console.WriteLine("Ingrese la base de la figura");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la figura");
                    double a1 = double.Parse(Console.ReadLine());

                    double fo = b1 * a1;
                    Console.WriteLine("La respuesta es:");
                    Console.WriteLine(fo);
                break;
                case "rectangulo":
                    Console.WriteLine("Ingrese la base de la figura");
                    double b2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la figura");
                    double a2 = double.Parse(Console.ReadLine());

                    double fu = b2 * a2;
                    Console.WriteLine("La respuesta es:");
                    Console.WriteLine(fu);
                    break;
                case "circulo":
                    Console.WriteLine("Ingrese la base de la figura");
                    double r = double.Parse(Console.ReadLine());
                  

                    double fa =r * r;
                    Console.WriteLine("La respuesta es:");
                    Console.WriteLine(fa);
                    break;


            }
        



        }
                    
       











    }
}
