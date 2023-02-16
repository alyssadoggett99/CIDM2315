namespace Homework5Q3;
class Program
{
static void Main(string[] args){
    createAccount();
    Console.ReadKey(true);}
static bool checkAge(int birth_year){
    int age = 2022-birth_year;
        if(age>=18)
            return true;
        else
            return false;}
static void createAccount(){
    String username, password, retype_password;
    int birthyear;

Console.WriteLine("Enter Your Username:");
username = Console.ReadLine();

Console.WriteLine("Enter Your Password:"); 
password = Console.ReadLine();

Console.WriteLine("Enter Your Password Again:");
retype_password = Console.ReadLine(); 

Console.WriteLine("Enter Your Birthyear:"); 
birthyear = Convert.ToInt32(Console.ReadLine());
    if(checkAge(birthyear))
    {
    if(password == retype_password)
        Console.WriteLine("Account is created successfully");
    else
        Console.WriteLine("Wrong password");
    }
    else
        Console.WriteLine("Could not create an account.");}
}
