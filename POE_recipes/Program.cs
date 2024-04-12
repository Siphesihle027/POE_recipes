namespace POE_recipes
{
    using System;
    using System.Collections;
    using System.Net.NetworkInformation;
    using System.Runtime.ConstrainedExecution;
    using System.Xml.Linq;
    using static System.Console;
    
    class Display
    {
        public void displayR(ArrayList name_arr, ArrayList unit_arr, ArrayList quantity_arr, ArrayList steps)
        {
            for (int i = 0; i < name_arr.Length; i++)
            {
                WriteLine("{0}{1} of {2}", name_arr[i], unit_arr[i], quantity_arr[i]);
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
            WriteLine("Menu\n1.Enter new recipe\n2.View recipe\n3.Exit");
            ReadLine();

        }

        public void option()
        {
            WriteLine("Please pick your unit of measurement:\n1. Teaspoon\n2.Tablespoon\n3.Cup\n4.No unit");
        }
       

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var name_arr = new ArrayList();
            var unit_arr = new ArrayList();
            var quantity_arr = new ArrayList();
            var step_arr = new ArrayList();

            int? ing_count = 1, step_count = 1;
            string ingri, unit, step;
            double? quantity;


            WriteLine("Welcome to the Recipe Application");
            ReadLine();
            Clear();

            

            WriteLine("How many ingridients will you need for your recipe?");
            ing_count = Int32.Parse(ReadLine());
            Clear();    


            for (int i = 0; i < ing_count; i++)
            {
                Console.WriteLine("Ingredient " + (i+1));
                Console.WriteLine("Please enter the Name");
                ingri = ReadLine();
                Console.WriteLine("Please enter the Unit used");
                unit = ReadLine();
                Console.WriteLine("Please the enter how many {0}(s) of {1} you will be needed", unit, ingri);
                quantity = Convert.ToDouble(ReadLine());
            }


            Console.WriteLine("How many steps are there in your recipe?");
            step_count = Int32.Parse(ReadLine());

            for (int i = 0; i < step_count; i++)
            {
                Console.WriteLine("Please enter enter step no.{0}:",(i + 1));
                step = ReadLine();                
         
            }


        }
    }
}
