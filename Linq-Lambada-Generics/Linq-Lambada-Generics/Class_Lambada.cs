using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_Lambada_Generics.Models;

namespace Linq_Lambada_Generics
{
    internal class Class_Lambada
    {
    


        delegate bool IsTeenAger(Student stud);

        public   Boolean  checkTeenagerStudent()
        {

            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

  

            Student student = new Student() {
                StudentID = 1,
                StudentName = "Augustine",
                Age = 18,
                StandardID = 1
            };

             return isTeenAger(student);


        }

        delegate bool IsYoungerThan(Student stud, int youngAge);


        public Boolean checkYoungerThan18()
        {

            IsYoungerThan isYoungerThan = (s, youngAge) => { return s.Age < youngAge;          };

            Student student = new Student()
            {
                StudentID = 1,
                StudentName = "Augustine",
                Age = 18,
                StandardID = 1
            };

            return isYoungerThan(student, 25);
     

        }



        public void addStudent(Student student)
        {

             

            Action<Student> PrintStudentDetail = s => 
            Console.WriteLine
            (
                "Student ID : {0}, StudentName: {1} , Age: {2}, Standard: {3} ", 
                s.StudentID, s.StudentName, s.Age,s.StandardID
            );

            //Student student = new Student() {
            //    StudentID = 1,
            //    StudentName = "Augustine",
            //    Age = 24,
            //    StandardID = 1
            //};

            PrintStudentDetail(student);



        }




        public void   getTeenStudentNames()
        {
            Class_LINQ _studentList        = new Class_LINQ();

            
            


            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

            var teenAgerStudent = _studentList.studentList.Where(isStudentTeenAger);

            Console.WriteLine("Teen age Students:");

            foreach (Student teenStudent in teenAgerStudent)
            {
                Console.WriteLine(teenStudent.StudentName);
            }


           

        }


    }




}
