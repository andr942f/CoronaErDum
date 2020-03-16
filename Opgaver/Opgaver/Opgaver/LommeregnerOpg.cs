using System;
using System.Collections.Generic;
using System.Text;

namespace Opgaver
{
    class LommeregnerOpg
    {
        public static void Lommeregner()
        {
            while (true)
            {
                Console.WriteLine("Enter equation");
                var InitialValue = Console.ReadLine();
                string[] values = InitialValue.Split('/', '+', '*', '-');
                Operator op = new Operator();

                try
                {
                    int input1 = int.Parse(values[0]);
                    int input2 = int.Parse(values[1]);

                    Console.Clear();
                    Console.Write(InitialValue);
                    switch (InitialValue)
                    {
                        case string a when a.Contains("+"):
                            Console.Write($" = {op.Plus(input1, input2)}");
                            break;
                        case string a when a.Contains("-"):
                            Console.Write($" = {op.Minus(input1, input2)}");
                            break;
                        case string a when a.Contains("*"):
                            Console.Write($" = {op.Gange(input1, input2)}");
                            break;
                        case string a when a.Contains("/"):
                            Console.Write($" = {op.Divider(input1, input2)}");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Error, try again");
                }
            }
        }
    }
}
