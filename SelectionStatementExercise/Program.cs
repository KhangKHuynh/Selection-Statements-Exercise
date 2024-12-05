namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 11);
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Give me a number between 1-10:");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Too Low!");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too High!");
                }
                else
                {
                    Console.WriteLine($"You're a beast!");
                } 
            }

          
        }
    }
}
