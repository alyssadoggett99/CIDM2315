namespace Homework4Q2;
class Program
{
static void pattern(int N, string shape){
    int a, b, c; 
    if(shape=="left")
    {
       for(a=1; a<=N; a++)
       {
    	for(b=1; b<=a; b++)
            Console.Write("*"); 
    	    Console.Write("\n"); 
       }
    }
    else if(shape=="right")
    {
     for (a=1; a<=N; a++)  
        {  
        for (b=1; b<=N-a; b++)  
            {
            Console.Write(" ");
            }  
            for (c=1; c<=a; c++)  
            {  
            Console.Write("*");
            }  
            Console.Write("\n");
        }  

    }}
public static void Main(){
    int N; 
    string shape; 
    Console.Write("Input N: ");
    N=Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input shape: ");
    shape=Console.ReadLine();
    Console.Write($"N is: {N}; shape is {shape}\n"); 
    pattern(N,shape); 
    }
}