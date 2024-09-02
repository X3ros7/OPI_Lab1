internal class Program
{
    private static void Main(string[] args)
    {
        int first_num;
        int second_num;

        Console.WriteLine("Enter a number");
        first_num = int.Parse(Console.ReadLine());
        if (first_num % 2 == 0)
        {
            Console.WriteLine("This number is even");
        }
        else
        {
            Console.WriteLine("This number is odd");
        }

        if (first_num % 4 == 0)
        {
            Console.WriteLine("This number is divisible by 4");
        }

        Console.WriteLine("Now enter another number");
        second_num = int.Parse(Console.ReadLine());
        if (first_num % second_num == 0 || second_num % first_num == 0)
        {
            Console.WriteLine($"Number {first_num} and {second_num} are divisible");
        }
        else
        {
            Console.WriteLine($"Number {first_num} and {second_num} are not divisible");
        }
    }
}