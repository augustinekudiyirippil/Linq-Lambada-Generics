    // See https://aka.ms/new-console-template for more information
    using Linq_Lambada_Generics;
using Linq_Lambada_Generics.Models;

    Console.WriteLine("Student list");

    Class_LINQ class_LINQ = new Class_LINQ();

    List<string> adultStudents= class_LINQ.getAdulStudentNames();
    Console.WriteLine("Adult Students:");
    foreach (string aduldStudent in adultStudents)
    {
         Console.WriteLine(aduldStudent);

    }

    Console.WriteLine("------------------------------");


    List<string> teenStudents = class_LINQ.getTeenStudentNames();
    Console.WriteLine("Teen Students:");
    foreach (string teenStudent in teenStudents)
    {
        Console.WriteLine(teenStudent);

    }

    Console.WriteLine("------------------------------");
    List<string> studentsByGroups = class_LINQ.getStudentsByGroup();
    Console.WriteLine("Students by Group:");
    foreach (string studentsByGroup in studentsByGroups)
    {
        Console.WriteLine(studentsByGroup);

    }

    Console.WriteLine("------------------------------");
    List<string> studentsWithStandard = class_LINQ.getStudentsWithStandard();
    Console.WriteLine("Students with Standard:");
    foreach (string studentWithStandard in studentsWithStandard)
    {
        Console.WriteLine(studentWithStandard);

    }


    Console.WriteLine("------------------------------");
    List<string> studentsLeftjoinSTD = class_LINQ.getStudentsLeftJoinStandard();
    Console.WriteLine("Students with Standard Left join:");
    foreach (string studentLeftjoinSTD in studentsLeftjoinSTD)
    {
        Console.WriteLine(studentLeftjoinSTD);

    }







    Console.WriteLine("------------------------------");
    List<string> studentsSorted = class_LINQ.getSortedStudents();
    Console.WriteLine("Students - sorted list");
    foreach (string studentSorted in studentsSorted)
    {
    Console.WriteLine(studentSorted);

    }







    Console.WriteLine("------------------------------");
    List<string> studentsStandardInnerJoin = class_LINQ.getStudentsInnerJoinStandard();
    Console.WriteLine("Students - Standard  list inner join");
    foreach (string studentStandardInnerJoin in studentsStandardInnerJoin)
    {
    Console.WriteLine(studentStandardInnerJoin);

    }




    Console.WriteLine("------------------------------");
    List<string> studentsNestedQuery = class_LINQ.getStudentNestedQuery();
    Console.WriteLine("Students - Standard nested Query");
    foreach (string studentNestedQuery in studentsNestedQuery)
    {
    Console.WriteLine(studentNestedQuery);

    }


try
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("Student extension");

    Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "Rachel", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Evana",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Joseph",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Thomas" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Joana" , Age = 31 } ,
            new Student() { StudentID = 6, StudentName = "Raphael",  Age = 17 } ,
            new Student() { StudentID = 7, StudentName = "Isabell",Age = 19  }
        };

    Student[] students = StudentExtension.where(studentArray, delegate (Student std) {
        return std.Age > 12 && std.Age < 25;
    });


    foreach (Student student in studentArray)
    {
        Console.WriteLine("Name: "+student.StudentName + "  Age: "+ student.Age );
    }

    

}
catch(Exception ex)
{

    Console.WriteLine(ex.Message.ToString());
}


Console.WriteLine("------------------------------");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");



try
{
     

    Class_Lambada class_Lambada = new Class_Lambada();
    Console.WriteLine("The Student is Teenager ?   " + class_Lambada.checkTeenagerStudent().ToString()) ;


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());

}


Console.WriteLine("------------------------------");
try
{


    Class_Lambada class_Lambada = new Class_Lambada();
    Console.WriteLine("The Student is younger than 18 ?   " + class_Lambada.checkYoungerThan18().ToString());


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());

}



Console.WriteLine("------------------------------");
try
{

    Student student = new Student()
    {
        StudentID = 1,
        StudentName = "Augustine",
        Age = 24,
        StandardID = 1
    };

    Class_Lambada class_Lambada = new Class_Lambada();
    class_Lambada.addStudent( student);

    Console.WriteLine("The Student Added "); 

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());

}

try
{

    
    Class_Lambada class_Lambada = new Class_Lambada();
    class_Lambada.getTeenStudentNames();

     

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());

}


Console.WriteLine("------------------------------");
Class_Generics  class_Generics     = new Class_Generics();
class_Generics.genericsMethod();


