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
            Console.WriteLine("Hello, World!");
        }
    }
}
