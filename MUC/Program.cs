using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Give the word per minute number.");
        double wpm = double.Parse(ReadLine());
        WriteLine("Your Ti's length is: " + (60.0 / (50 * wpm)));
        ReadKey(true);
    }
}
