namespace Homework4Q2;
class Program
{
    static void pattern(int N,string shape){
    int a,b,c; 
    if(shape=="left")
        {
        for(a=0 ;a<N; a++) {
            for(b=0; b<a; b++)
            {
    	   Console.Write("*"); 
            }
    	Console.WriteLine(); }
        }
    else if(shape=="right")
        {
        for(a=0; a<N; a++) {  
            for (b=0; b<N-a; b++)  
            {
            Console.Write(" ");
            }  
            for (c=0; c<a; c++)  
            {
            Console.Write("*");
            }  
            Console.WriteLine(""); }  
            Console.ReadLine();
        }
    }
    public static void Main()
    {
   int N; 
   string shape; 
   Console.Write("Input N: ");
   N = Convert.ToInt32(Console.ReadLine()); 
   Console.Write("Input shape: ");
   shape = Console.ReadLine(); 
   Console.Write($"N is: {N}; shape is {shape}\n"); 
   pattern(N, shape); 
    }
}

