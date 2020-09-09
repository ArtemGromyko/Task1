using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfSubjects { get; set; }
        private Mark[] marks;

        public Student()
        {
            Name = "";
            Age = 0;
            NumberOfSubjects = 0;
            marks = null;
        }
        public Student(string n, int a, int N)
        {
            Name = n;
            Age = a;
            NumberOfSubjects = N;
            marks = new Mark[NumberOfSubjects];
            for (int i = 0; i < marks.Length; i++)
                marks[i] = new Mark();
        }
        public void SetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("enter subject: ");
                marks[i].Subject = Console.ReadLine();
                Console.Write("enter value: ");
                marks[i].Value = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("name: "+Name+" age: "+Age+" NumberOfMarks: "+ NumberOfSubjects);
            if(marks != null)
                for (int i = 0; i < marks.Length; i++)
                    marks[i].ShowInfo();
        }
        public int GetAvgMark()
        {
            if(marks.Length!=0)
            {
                int sum = 0;
                for (int i = 0; i < marks.Length; i++)
                    sum += marks[i].Value;
                return (int)Math.Round((double)(sum / marks.Length));
            }
            else
            {
                return 0;
            }
        }
        public void ResetAllMarks()
        {
            for (int i = 0; i < marks.Length; i++)
                marks[i].Value = 0;
        }
    }
}
