using System;

namespace Implicit_Explicit_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius celcius = new Celcius(-100);
            Kelvin kelvin = celcius;
            Console.WriteLine(kelvin.Kl);


     
        
        
        }
    }


    public class Kelvin
    {
        public double Kl { get; set; }

        public Kelvin(double kl)
        {
            Kl = kl;
        }
    }



    public class Celcius
    {
        public double Cl { get; set; }

        public Celcius(double cl)
        {
            Cl=cl;

        }
     
        
        public static implicit operator Kelvin (Celcius celcius)
        {
            return new Kelvin(celcius.Cl + 273.15);
        }
        
    }

}




