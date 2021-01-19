using System;
using System.Collections.Generic;

namespace Delet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Volks> vw = new List<Volks>();
            List<Toyota> T = new List<Toyota>();
            try
            {
                Toyota corolla = new Toyota { Year = 2005, Model = "Corolla", Color = "REd" };
                Toyota camry = new Toyota { Year = 2015, Model = "TRD", Color = "Black" };
                Volks jetta = new Volks { Year = 2001, Model = "jetta", Color = "silver" };
                Volks Golf = new Volks { Year = 2018, Model = "GTI", Color = "Blue" };

                vw.Add(jetta);
                vw.Add(Golf);
                T.Add(camry);
                T.Add(corolla);
                vw.Display();
                T.Display();
            }
            catch
            {

            }


        }
    }
    public class Volks
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

    }
    public class Toyota
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

    }
    public static class TCarColl
    {
        public static void Display(this List<Volks> cars)
        {
            foreach(var v in cars)
            {
                Console.WriteLine($"Manufacturer Volkswagen :{v.Model}\tModel:{v.Year} ");
            }
        }
        public static void Display(this List<Toyota> cars)
        {
            foreach (Toyota T in cars)
            {
                Console.WriteLine($"Toyota the best brand:{T.Model}\tModel:{T.Year}\tYear:{T.Color}");
            }
        }
    }
}
