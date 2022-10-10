namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number");
            var userinput = int.Parse(Console.ReadLine());
            int favoriteNumber = 100;
            if (userinput > favoriteNumber)
            {
                Console.WriteLine("Too High");
            }
            if (userinput < favoriteNumber)
            {
                Console.WriteLine("Too low");
            }

            else
            {
                Console.WriteLine("Nevermind");
            }

        }
    }
}

    
