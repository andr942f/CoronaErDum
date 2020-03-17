using System;

namespace Opgaver
{
    class LommeregnerOpg
    {
        public double Lommeregner()
        {
            while (true)
            {
                double result = 0;
                while (true)
                {
                    //"Menu" and numbers that will be divived, plus aso.
                    Console.WriteLine("Press 'ESC' to start a new equation");
                    Console.WriteLine();
                    Console.WriteLine("Enter equation");
                    var InitialValue = Console.ReadLine();
                    string[] values = InitialValue.Split('/', '+', '*', '-');

                    //connection to operator class
                    Operator op = new Operator();
                    try
                    {
                        //for each number typed and split, add to array of numbers
                        for (int i = 0; i < values.Length; i++)
                        {
                            double input = double.Parse(values[i]);

                            //view operator type used in the initial readline, add it to the end result
                            switch (InitialValue)
                            {
                                case string a when a.Contains("+"):
                                    result = op.Plus(result, input);
                                    break;
                                case string a when a.Contains("-"):
                                    result = op.Minus(result, input);
                                    break;
                                case string a when a.Contains("*"):
                                    result = op.Gange(result, input);
                                    break;
                                case string a when a.Contains("/"):
                                    result = op.Divider(result, input);
                                    break;
                            }
                        }
                        //add line to seperate result from values put in
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write("=");
                        }
                        //display result
                        Console.WriteLine();
                        Console.WriteLine($"{result}");
                        //if "esc" is pressed, break loop and begin anew from 0
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }
                        //otherwise clear and continue
                        Console.Clear();
                    }
                    catch
                    {
                        // if any problems arise (like a string in form on an "a" is entered), run and error message and try again
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
