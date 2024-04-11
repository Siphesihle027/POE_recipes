namespace POE_recipes
{
    using System;
    using System.Collections;
    using System.Net.NetworkInformation;
    using System.Xml.Linq;
    using static System.Console;

    class Ingridents
    {
        public string[] name { get; set; }
        public string[] unit { get; set; }
        public int[] quantity { get; set; }

        private int scale = 1;

        public Ingridents(string name, string unit, double quantity)
        {
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
        }


    }

    class Steps: Ingridents
    {
        public string[] steps { get; set; }

        public void Step(string steps)
        {
            this.steps = steps;
        }


    }

    class Display : Steps
    {
        List<Ingridents> ingridents = new List<Ingridents>();
        public void displayR()
        {
            foreach (var ing in ingridents)
            {
                WriteLine("{0}{1} of {2}", ing.quantity, ing.unit, ing.name);
            }

            for (int i = 0; i < steps.Length; i++)
            {
                WriteLine("{0}. {1}",(i+1), steps[i]);
            }
        }

        public void options()
        {
            WriteLine("Please pick your unit of measurement:\n1. Teaspoon\n2.Tablespoon\n3.Cup\n4.No unit");
        }

        public void menu()
        {
            WriteLine("Menu\n1.Enter new recipe\n2.View recipe");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int ing_count = 1, step_count = 1;
            string ingri, unit, step;
            double quantity;


            List<Ingridents> ingridents = new List<Ingridents>();

            WriteLine("Welcome to the Recipe Application");
            ReadLine();

            WriteLine("How many ingridients will you need for your recipe?");
            ing_count = Int32.Parse(ReadLine());


            for (int i = 0; i < ing_count; i++)
            {
                Console.WriteLine("Please enter the Name");
                ingri = ReadLine();
                Console.WriteLine("Please enter the Unit used");
                unit = ReadLine();
                Console.WriteLine("Please the enter how many {0}(s) of {1} you will be needed", unit, ingri);
                quantity = Convert.ToDouble(ReadLine());

                var ing = new Ingridents(ingri, unit, quantity);
                ingridents.Add(ing);

            }


            Console.WriteLine("How many steps are there in your recipe?");
            step_count = Int32.Parse(ReadLine());

            for (int i = 0; i < step_count; i++)
            {
                Console.WriteLine("Please enter enter step no.{1}",(step_count + 1));
                step = ReadLine();
                
         
            }


        }
    }
}
