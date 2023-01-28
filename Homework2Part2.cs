namespace Homework2Part2;
class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Please input the first num:");
    int first_int = Convert.ToInt16(Console.ReadLine()); 
    
    Console.WriteLine("Please input the second num:");
    int second_int = Convert.ToInt16(Console.ReadLine());
    
    Console.WriteLine("Please input the third num:");
    int third_int = Convert.ToInt16(Console.ReadLine());
    
    int smallest = 0;

    if(first_int<second_int) {
        if(first_int<third_int) {
            smallest=first_int;
        }
    }
    if(second_int<first_int) {
        if(second_int<third_int) {
            smallest=second_int;
        }
    }
    if(third_int<first_int) {
        if(third_int<second_int) {
            smallest=third_int;
        }
    }
    Console.WriteLine($"The smallest value is: {smallest}");
    }
}
