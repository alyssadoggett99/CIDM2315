namespace Homework5Q2;
class Program
{
 static int largest(int a, int b){
        if (a>b){
            return a;
        }
        else
        {
            return b;}
 }
    static int maxOfFour(int a, int b, int c, int d)
    {
        int max1 = largest(a, b);
        int max2 = largest(c, d);
        int result = largest(max1, max2);
        return result;}
    static void Main(){
        int a = 3, b = 5, c = 7, d = 9;
        int largest_num = maxOfFour(a, b, c, d);

    Console.WriteLine($"a = {a}; b={b}; c = {c}; d={d}; \nThe largest number is: " + largest_num);}
}
