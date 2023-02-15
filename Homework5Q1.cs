namespace Homework5Q1;
class Program
{
    static int largest_num(int a, int b){
        if(a>b){
            return a;
        }
        else if(b>a){
            return b;
        }
        else{
            return -1;
        }
    }
    static void Main() {
        int a = 3, b = 5;
        int largest = largest_num(a, b);
        
    Console.WriteLine($"a = {a}; b={b} \nThe largest number is: " + largest);
    }
}
