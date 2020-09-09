using System;
using System.Data.SqlTypes;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Artem", 20, 3);
            s1.SetMarks();
            s1.ShowInfo();
            Console.WriteLine(s1.GetAvgMark());
            s1.ResetAllMarks();
            s1.ShowInfo();
        }
    }
}
