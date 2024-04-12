namespace POE_recipes
{
    using System;
    using System.Collections;
    using System.Net.NetworkInformation;
    using System.Runtime.ConstrainedExecution;
    using System.Xml.Linq;
    using static System.Console;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Display
    {
        //Function used to display recipe
        public void display_Rec(string[] name_arr, string[] unit_arr, double[] quantity_arr, string[] steps, double scale)
        {
            Console.WriteLine("Ingredients");
            for (int i = 0; i
                            < name_arr.Length; i++)
            {
                if (unit_arr[i] != null)
                {
                    WriteLine("{0} {1}s of {2}", quantity_arr[i] * scale, unit_arr[i], name_arr[i]);
                }
                else
                {
                    WriteLine("{0} {1}s", quantity_arr[i] * scale, name_arr[i]);
                }

            }

            WriteLine("\nInstructions");
            for (int i = 0; i < steps.Length; i++)
            {
                WriteLine("{0}. {1}", (i + 1), steps[i]);
            }
        }

        //The Unit options
        public void unit_opt()
        {
            WriteLine("Please pick your unit of measurement:\n1. Teaspoon\n2.Tablespoon\n3.Cup\n4.No unit");
        }

        //The menu options
        public void menu()
        {
            WriteLine("Menu\n1.Enter new recipe\n2.View recipe\n3.Clear recipe\n4.Exit");

        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration of the array
            string[] name_arr = new string[] { };
            string[] unit_arr = new string[] { };
            double[] quantity_arr = new double[] { };
            string[] step_arr = new string[] { };

            //THe local variables
            int ing_count = 1, step_count = 1;
            string ingri, unit = null, step, unit_input, menu_op = "1";
            double quantity, scale = 1.0;
            bool bloop = false;

            //Calling the Display class
            Display display = new Display();

            //The welcome message
            WriteLine("Welcome to the Recipe Application");
            ReadLine();
            Clear();

            //Main menu loop
            while ((menu_op != "4"))
            {
                display.menu();
                menu_op = ReadLine();

                Clear();

                switch (menu_op)
                {
                    //Enter Recipe
                    case "1":

                        WriteLine("Number of ingredients you will need for your recipe?");
                        ing_count = Int32.Parse(ReadLine());
                        Clear();

                        //redeclaring the array once we know the length
                        name_arr = new string[ing_count];
                        unit_arr = new string[ing_count];
                        quantity_arr = new double[ing_count];

                        for (int i = 0; i < ing_count; i++)
                        {
                            //Ingredient name
                            Console.WriteLine("Ingredient " + (i + 1));
                            Console.WriteLine("Please enter the Name");
                            ingri = ReadLine();
                            name_arr[i] = ingri;

                            //Ingredient Unit
                            WriteLine("Please pick your unit of measurement:\n1.Teaspoon\n2.Tablespoon\n3.Cup\n4.No unit");
                            bloop = false;
                            while (bloop == false)
                            {
                                bloop = true;
                                unit_input = ReadLine();
                                switch (unit_input)
                                {
                                    case "1":
                                        unit = "Teaspoon";
                                        break;
                                    case "2":
                                        unit = "Tablesppon";
                                        break;
                                    case "3":
                                        unit = "Cups";
                                        break;
                                    case "4":
                                        unit = null;
                                        break;
                                    default:
                                        WriteLine("Invalid entry\nPlease pick a valid input.");
                                        bloop = false;
                                        break;
                                }
                            }
                            unit_arr[i] = unit;

                            //Ingredient Quantity
                            if (unit == null)
                            {
                                Console.WriteLine("Please the enter how many {0}(s) you will be needed", ingri);
                            }
                            else
                            {
                                Console.WriteLine("Please the enter how many {0}(s) of {1} you will be needed", unit, ingri);
                            }
                            quantity = Convert.ToDouble(ReadLine());
                            quantity_arr[i] = quantity;

                        }

                        Clear();

                        //Recipe steps
                        Console.WriteLine("Number of steps there are in your recipe?");
                        step_count = Int32.Parse(ReadLine());
                        step_arr = new string[step_count];

                        for (int i = 0; i < step_count; i++)
                        {
                            Console.WriteLine("Please enter enter step no.{0}:", (i + 1));
                            step = ReadLine();
                            step_arr[i] = step;
                        }
                        Clear();
                        break;

                    case "2":
                        //View recipe                    
                        if (name_arr.Length > 0)
                        {
                            bloop = false;
                            while (bloop == false)
                            {
                                bloop = true;
                                Console.WriteLine("Would like to scale you recipe.\n1. Orginal Measurement\n2. Double\n3. Triple\n4. Half");
                                switch (ReadLine())
                                {
                                    case "1": scale = 1; break;
                                    case "2": scale = 2; break;
                                    case "3": scale = 3; break;
                                    case "4": scale = 0.5; break;
                                    default:
                                        Clear();
                                        WriteLine("You entered an Invalid input");
                                        bloop = false;
                                        break;

                                }
                            }
                            display.display_Rec(name_arr, unit_arr, quantity_arr, step_arr, scale);
                            ReadLine();
                            Clear();

                        }
                        else
                        {
                            //Message if no recipe enter or recipe is deleted
                            WriteLine("Please enter a recipe first before returning");
                            ReadLine();
                            Clear();
                        }


                        break;

                    case "3":
                        //Function to delete recipe
                        Write("ARE YOU USRE YOU WANT TO CLEAR THE RECIPE\n1.Yes\n2.No");
                        string clear = ReadLine();
                        switch (clear)
                        {
                            case "1":
                                Array.Clear(name_arr, 0, name_arr.Length);
                                Array.Clear(unit_arr, 0, unit_arr.Length);
                                Array.Clear(quantity_arr, 0, quantity_arr.Length);
                                Array.Clear(step_arr, 0, step_arr.Length);
                                WriteLine("You have cleared the Recipe");
                                break;
                            case "2":
                                WriteLine("You see, almost lost all that information");
                                break;
                            default:
                                WriteLine("Not a valid entry");
                                break;

                        }
                        ReadLine();
                        Clear();
                        break;

                    case "4":
                        //Exit app
                        Clear();
                        WriteLine("Hope to see you again\nThanks");
                        break;


                }

            }

        }
    }
}