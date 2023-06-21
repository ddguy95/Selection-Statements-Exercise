namespace SelectionStatementExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //RandomNumberGuessingGame

            var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 999;

            Console.WriteLine("Try to guess my favorite number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high.");
            }
            else
            {
                Console.WriteLine("You guessed it. Great job!");
            }
        }
    }
}
