namespace Homework6Q1;
class Professor{
    public string profName;
    public string classTeach;
    private double salary;
    public void SetSalary(double salary_amount){
        this.salary=salary_amount;
    }
    public double GetSalary(){
        return this.salary;
    }
class Student{
    public string studentName;
    public string classEnroll;
    private double grade;
    public void SetGrade(double newGrade){
        this.grade=newGrade;
    }
    public double GetGrade(){
        return this.grade;
    }
}
class main{
    static void Main() {
        Professor p1=new Professor();
        p1.profName="Alice";
        p1.classTeach="Java";
        p1.SetSalary(9000);

        Professor p2=new Professor();
        p2.profName="Bob";
        p2.classTeach="Math";
        p2.SetSalary(8000);
      
        Student ss1=new Student();
        ss1.studentName="Lisa";
        ss1.classEnroll="Java";
        ss1.SetGrade(90);

        Student ss2=new Student();
        ss2.studentName="Tom";
        ss2.classEnroll="Math";
        ss2.SetGrade(80);

       
    Console.WriteLine("Professor "+p1.profName+" teaches "+p1.classTeach+", and the salary is: "+p1.GetSalary());
    Console.WriteLine("Professor "+p2.profName+" teaches "+p2.classTeach+", and the salary is: "+p2.GetSalary());
    
    Console.WriteLine("Student "+ss1.studentName+" enrolls "+ss1.classEnroll+", and the grade is: "+ss1.GetGrade());
    Console.WriteLine("Student "+ss2.studentName+" enrolls "+ss2.classEnroll+", and the grade is: "+ss2.GetGrade());
    
    Console.WriteLine("The salary difference between "+p1.profName+" and "+p2.profName+" is: "+ (p1.GetSalary() - p2.GetSalary()));
    Console.WriteLine("The total grade of "+ss1.studentName+" and "+ss2.studentName+" is: "+ (ss1.GetGrade() + ss2.GetGrade()));
  }
}}
