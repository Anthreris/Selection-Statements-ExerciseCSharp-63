namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1,101);
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Guess a favorite number between 1 and 100:");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour response: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too high!\nYour response: {response}");
                }
                else
                {
                    Console.WriteLine($"Correct\nThe number was {favNumber}!");
                }
            }
            
        }
    }
}
