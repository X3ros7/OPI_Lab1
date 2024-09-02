internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        int num;

        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Now, enter your age");
        age = int.Parse(Console.ReadLine());
        if (age <= 0)
        {
            Console.WriteLine("Error! Age can`t be negative or 0");
            return;
        }

        Console.WriteLine($"You'll reach 100 years old in {2024 - age + 100}");
        Console.WriteLine("Now enter a random inreger number");

        num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"You'll reach 100 years old in {2024 - age + 100}");
        }
    }
}