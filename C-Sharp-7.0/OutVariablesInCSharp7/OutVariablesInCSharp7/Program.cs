using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariablesInCSharp7
{
    internal class Student
    {
        private string Name = "Ebubekir Dogan";
        private string Scholl = "University of 19 May";
        private string Chapter = "Computer Engineering";

        public void GetStudent(out string name, out string scholl, out string chapter)
        {
            name = this.Name;
            scholl = this.Scholl;
            chapter = this.Chapter;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();

            string studentName, schollName, chapterName;

            student.GetStudent(out studentName, out schollName, out chapterName);

            DateTime bornDate;
            DateTime.TryParse("19/05/1993", out bornDate);

            Console.WriteLine($"Student Name : { studentName }\n Scholl Name : { schollName }\n Chapter Name   : { chapterName } \n Born Date : {bornDate:D}");
        }
    }
}