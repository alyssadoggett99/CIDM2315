namespace Homework5Q2;
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
    static int largest(int a, int b, int c, int d)
    {
        return largest(largest(a, b), largest(c, d));}
    static void Main(){
        int a = 3, b = 5, c = 7, d = 9;
        int largest_num = largest(a, b, c, d);
       
    Console.WriteLine($"a = {a}; b={b}; c = {c}; d={d}; \nThe largest number is: " + largest_num);}
}