using System;

namespace Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            EdabitOpg edabitOpg = new EdabitOpg();
            LommeregnerOpg lommeregnerOpg = new LommeregnerOpg();

            edabitOpg.Edabit();
            lommeregnerOpg.Lommeregner();
        }
    }
}
