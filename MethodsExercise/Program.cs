using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetFirstName();
            GetFavoriteAnimal();
            GetFavoriteColor();
            GetFavoriteBand();

            int addExample = AddNumbers(1, 3);
            int subtractExample = SubtractNumbers(10, 2);
            int multiplyExample = MultiplyNumbers(5, 6);
            int divideExample = DivideNumbers(20, 4);
            int modulusExample = ModulusNumbers(5, 6);

            Console.WriteLine(addExample);
            Console.WriteLine(subtractExample);
            Console.WriteLine(multiplyExample);
            Console.WriteLine(divideExample);
            Console.WriteLine(modulusExample);

            int y = AddParams(12, 10, 10, 20);
            Console.WriteLine(y);
    
        }

        public static void GetFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hey, {name}, you will never believe what I saw yesterday.");
        }

        public static void GetFavoriteColor()
        {
            Console.WriteLine("Please enter your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine($"And guess what? It was {color}!");
        }

        public static void GetFavoriteAnimal()
        {
            Console.WriteLine("Please enter your favorite animal:");
            string animal = Console.ReadLine();
            Console.WriteLine($"It was a huge {animal}!");
        }

        public static void GetFavoriteBand()
        {
            Console.WriteLine("Please enter your favorite band:");
            string band = Console.ReadLine();
            Console.WriteLine($"And the craziest part, it was listening to {band}! Weird, right?"); 
        }

        public static int AddNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int SubtractNumbers(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int MultiplyNumbers(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int DivideNumbers(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int ModulusNumbers(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }

        public static int AddParams(params int[] numbers)
        {
            int total = 0;
            foreach(int i in numbers)
            {
                total += i;
            }
            return total;
        }

    }
}
