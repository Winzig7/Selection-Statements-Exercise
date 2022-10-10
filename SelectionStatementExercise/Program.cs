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

            
            Console.WriteLine("What is your favorite subject");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                Console.WriteLine("math is cool");
                break;

                case "English":
                    Console.WriteLine("English kinda sucks");
                    break;

                case "Science":
                    Console.WriteLine("Science is fun");
                    break;

                case "Music":
                    Console.WriteLine("Music isnt a real subject");
                    break;

                case "Physical Education":
                    Console.WriteLine("Clearly the GOAT");
                    break;

                    default:
                    Console.WriteLine("Never heard of that");
                    break;

            }
            


        }
    }
}

    
