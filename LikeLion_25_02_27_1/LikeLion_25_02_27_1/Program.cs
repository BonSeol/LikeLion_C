using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_02_27_1
{
    struct Student
    {
        public string Name;
        public int iKor;
        public int iEng;
        public int iMat;
        public void Print()
        {
            Console.WriteLine($"{Name,-3} {iKor,5} {iEng,7}{iMat,8}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            for(int i = 0; i < 3; i++)
            {
                Console.Write($"학생{i + 1} 이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write($"국어 성적 : ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write($"영어 성적 : ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write($"수학 성적 : ");
                students[i].iMat = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름    국어    영어    수학");

            foreach (Student std in students)
            {
                std.Print();
            }
        }
    }
}
