using Linq_Lambada_Generics.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lambada_Generics
{
    internal class Class_LINQ
    {


            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "Augustine", Age = 18, StandardID = 1 } ,
            new Student() { StudentID = 2, StudentName = "Meera",  Age = 21, StandardID = 1 } ,
            new Student() { StudentID = 3, StudentName = "Chacko",  Age = 18, StandardID = 2 } ,
            new Student() { StudentID = 4, StudentName = "Elizabeth" , Age = 20, StandardID = 2 } ,
            new Student() { StudentID = 5, StudentName = "Evana" , Age = 15, StandardID = 2 },
            new Student() { StudentID = 5, StudentName = "Joana" , Age = 10, StandardID = 1 },
            new Student() { StudentID = 5, StudentName = "Thomas" , Age = 4}
            };  

            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

        

        public List<string> getAdulStudentNames()
        {

            List<string> adultStudentList = new List<string>();
            var AdultStudentNames = studentList.Where(s => s.Age > 18)
                                  .Select(s => s)
                                  .Where(st => st.StandardID > 0)
                                  .Select(s => s.StudentName);

            foreach(string aduldStudent in AdultStudentNames)
            {
                adultStudentList.Add(aduldStudent);

            }

            return adultStudentList;

        }

        public List<string> getTeenStudentNames()
        {

            
           var teenStudentsName = from s in studentList
                                                           where s.Age > 12 && s.Age < 20
                                                           select new { StudentName = s.StudentName };

           
            List<string> teenStudentList = teenStudentsName
                                                        .Select(s => s.StudentName.ToString())
                                                        .ToList();

     
            return teenStudentList;

        }




        public List<string> getStudentsByGroup()
        {


            var studentsGroupByStandard = from s in studentList
                                          group s by s.StandardID into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };

        
            List<string> studentsByGroup = new List<string>(); // Initialize the list

            foreach (var group in studentsGroupByStandard)
            {
                // Add the standard ID to the list
                studentsByGroup.Add($"StandardID {group.Key}:");

                // Add each student's name in the current group to the list
                group.sg.ToList().ForEach(st => studentsByGroup.Add(st.StudentName));
            }




            return studentsByGroup;

        }





        public List<string> getStudentsWithStandard()
        {
            List<string> studentsWithStandard = new List<string>(); // Initialize the list


            var studentsGroupByStandard = from s in studentList
                                          where s.StandardID > 0
                                          group s by s.StandardID into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };

            foreach (var student in studentsGroupByStandard)
            {
              
                student.sg.ToList().ForEach(st => studentsWithStandard.Add(st.StudentName));
            }


            return studentsWithStandard;

        }




        public List<string> getStudentsLeftJoinStandard()
        {
            List<string> studentsWithSTD = new List<string>(); // Initialize the list
            var studentsGroup = from stad in standardList
                                join s in studentList
                                on stad.StandardID equals s.StandardID
                                    into sg
                                select new
                                {
                                    StandardName = stad.StandardName,
                                    Students = sg
                                };


            foreach (var group in studentsGroup)
            {
               // studentsWithSTD.Add(group.StandardName+" : ");

                group.Students.ToList().ForEach(st => studentsWithSTD.Add(group.StandardName + " : "+st.StudentName));
            }

            return studentsWithSTD;
        }




        public List<string> getSortedStudents()
        {
            List<string> sortedStudentsList = new List<string>();  

            var sortedStudents = from s in studentList
                                orderby s.StandardID, s.Age
                                select new
                                {
                                    StudentName = s.StudentName,
                                    Age = s.Age,
                                    StandardID = s.StandardID
                                };

            foreach (var s in sortedStudents)
            {
                sortedStudentsList.Add($"Student Name: {s.StudentName}, Age: {s.Age}, StandardID: {s.StandardID}");
            }

  



            return sortedStudentsList;
        }



        public List<string> getStudentsInnerJoinStandard()
        {
            List<string> stuentsInnerJoinStandard = new List<string>();


            var studentWithStandard = from s in studentList
                                      join stad in standardList
                                      on s.StandardID equals stad.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardName = stad.StandardName,
                                          Age= s.Age
                                      };

            foreach (var s in studentWithStandard)
            {
                stuentsInnerJoinStandard.Add($"Student Name: {s.StudentName}, Age: {s.Age}, StandardID: {s.StandardName}");
            }

           

            return stuentsInnerJoinStandard;
        }



        public List<string> getStudentNestedQuery()
        {
            List<string> studentsNestedQuery = new List<string>();


            var nestedStudentsQueries = from s in studentList
                                where s.Age > 18 && s.StandardID ==
                                    (from std in standardList
                                    where std.StandardName == "Standard 1"
                                     select std.StandardID).FirstOrDefault()
                                select s;

             

            foreach (var s in nestedStudentsQueries)
            {
                studentsNestedQuery.Add(($"Student Name: {s.StudentName}, Age: {s.Age}, StandardID: {s.StandardID}"));
            }



            return studentsNestedQuery;
        }






    }



}



