namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //String UserName = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("How old are you?");
            //String UserAge = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("What is your dog's name?");
            //String DogName = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("What color is your dog?");
            //String DogColor = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine($"{UserName} is {UserAge} years old. {UserName} has a {DogColor} dog named {DogName}. {UserName} and {DogName} like to go on walks every day.");

            Console.WriteLine("Give me a number to add.");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Give me another number to add to the first number.");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = Add(Num1, Num2);
            Console.WriteLine($"The sum of {Num1} and {Num2} is {sum}");
            Console.WriteLine();


            Console.WriteLine("Give me a number.");
            int Num3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Give me another number to multiply the first number by.");
            int Num4 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int product = Multiply(Num3, Num4);
            Console.WriteLine($"The product of {Num3} and {Num4} is {product}.");
            Console.WriteLine();
        }

        public static int Add(int Num1, int Num2)
        {
            int Sum = Num1 + Num2;

            return Sum;
        }

        public static int Multiply(int Num3, int Num4)
        {
            return Num3 * Num4;
        }

    }
}