using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요 : ");
            int iKor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요 : ");
            int iEng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요 : ");
            int iMat = int.Parse(Console.ReadLine());

            int sum = 0;
            float aver = 0.0f;

            sum = iKor + iEng + iMat;
            aver = (float)sum / 3;

            Console.WriteLine($"총점 : {sum}");
            Console.WriteLine($"평균 : {aver.ToString("F2")}");

            Console.Write("정수 입력 : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(~n);
        }
    }
}
