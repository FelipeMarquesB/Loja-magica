using System;
using System.Collections.Generic;

namespace Aula10
{
    class Program
    {
        static List<object> _Figuras;

        static private string GetProperty(Object obj, string PropertyName)
        {
             var propertyInfo = obj.GetType().GetProperty(PropertyName);
             var perimetro = propertyInfo.GetValue(obj, null);
             return perimetro.ToString();
        }

        static void Main(string[] args)
        {
            _Figuras = new List<Object>();
        
            _Figuras.Add(new Circulo(raio: 3));
         
            _Figuras.Add(new Retangulo(altura: 10, largura:20 ) );

            foreach (Object p in _Figuras)
            {     
                Console.WriteLine("");
                Console.WriteLine("Nome:{0}", GetProperty(p,"Nome"));
                Console.WriteLine("Area:{0}", GetProperty(p,"Area"));
                Console.WriteLine("Perimetro:{0}", GetProperty(p,"Perimetro"));
            }
        }
    }
}
