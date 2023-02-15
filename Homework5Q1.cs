namespace Homework5Q1;
class Program
{
       static int largest(int a, int b){
        if (a>b)
        {
            return a;
        }
        else
        {
            return b;
        } }
    static void Main(){
        int a = 3, b = 5;
        int largest_num = largest(a, b);
        
    Console.WriteLine($"a = {a}; b={b} \nThe largest number is: " + largest_num);}
}
