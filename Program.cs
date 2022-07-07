namespace selection_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            int userInput;

            do
            {
                Console.WriteLine("Pick a number 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }
            } while (userInput != favNumber);

            //Switch-case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                
                case "science":
                    Console.WriteLine("I love science!");
                    break;
                
                case "pe":
                    Console.WriteLine("PE is the best!");
                    break;

                case "history":
                    Console.WriteLine("History is fun!");
                    break;

                case "english":
                    Console.WriteLine("English is boring!");
                    break;
                
                default: Console.WriteLine("I don't know that subject");
                    break;
            }


        }
    }
}