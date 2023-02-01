namespace Homework3Q1;
class Program
{
    static void Main(string[] args)
    {
    bool prime = true;
    Console.WriteLine("Input an integer:");

    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);

    for(int i=2; i<number/2; i++)
    {
        if(number % i == 0)
        {
               prime = false;
               break;
        }
    }
    if(prime)
    {
        Console.WriteLine("N is Prime ");
    }
    else{
        Console.WriteLine("N is non-prime ");
    }
    
  }
}
