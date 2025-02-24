using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------문제1--------");

            int temp = 0;

            Console.Write("첫번째 정수를 입력하세요 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("두번째 정수를 입력하세요 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("세번째 정수를 입력하세요 : ");
            int n3 = int.Parse(Console.ReadLine());


            if (n3 > n2)
            {
                temp = n3   ;
                n3   = n2   ;
                n2   = temp ;
            }
            if (n2 > n1)
            {
                temp = n2   ;
                n2   = n1   ;
                n1   = temp ;
            }
            Console.WriteLine($"최대값 : {n1}");

            Console.WriteLine("--------문제2--------");

            string grade = "";

            Console.Write("점수를 입력하세요");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90) grade = "A";
            else if (score >= 80) grade = "B";
            else if (score >= 70) grade = "C";
            else if (score >= 60) grade = "D";
            else grade = "F";

            Console.WriteLine($"{grade} 학점");

            Console.WriteLine("--------문제3--------");

            int result = 0;

            Console.Write("첫번째 정수를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("두번째 정수를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("연산자를 입력하세요 : ");
            string oper = Console.ReadLine();

            if (oper == "+")
            {
                result = num1 + num2;
            }
            else if (oper == "-")
            {
                result = num1 - num2;
            }
            else if (oper == "*")
            {
                result = num1 * num2;
            }
            else if (oper == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    result = num1 / num2;
                }
            }

            Console.WriteLine($"결과 : {result}");

        }
    }
}
