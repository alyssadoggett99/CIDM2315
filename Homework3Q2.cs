namespace Homework3Q2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int n = int.Parse(Console.ReadLine());

        for(int row = 0; row<n; row++){
            for(int col = 0; col<n; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
