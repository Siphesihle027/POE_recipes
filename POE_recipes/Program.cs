namespace POE_recipes
{
    using System;
    using System.Collections;
    using System.Xml.Linq;

    class Ingridents
    {
        public string name { get; set; }
        public string unit { get; set; }
        public double quantity { get; set; }

        public Ingridents(string name, string unit, double quantity)
        {
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ingridents> ingridents = new List<Ingridents>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter the Name");
                string ingri = Console.ReadLine();
                Console.WriteLine("Please enter the Unit used");
                string unit = Console.ReadLine();
                Console.WriteLine("Please the enter how many {0}(s) of {1} you will be needed", unit, ingri);
                double quantity = Convert.ToDouble(Console.ReadLine());

                var ing = new Ingridents(ingri, unit, quantity);
                ingridents.Add(ing);
            }

            foreach (var i in ingridents)
            {
                Console.WriteLine("{0} {1} of {2}", i.quantity, i.unit, i.name);
            }
        }
    }
}
