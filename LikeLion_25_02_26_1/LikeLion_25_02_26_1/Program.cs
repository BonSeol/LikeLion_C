using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_02_26_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[3];
            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = new int[] { 1, 2, 3 };

            //for(int i = 0; i<3; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] iKor = new int[3],
            //      iEng = new int[3],
            //      iMat = new int[3];
            //int[] sum = new int[3];
            //float[] aver = new float[3];

            //for (int i = 0; i < 3; i++)
            //{    
            //    Console.WriteLine($"학생{i + 1} 성적");

            //    Console.Write("국어 : ");
            //    iKor[i] = int.Parse(Console.ReadLine());
            //    sum[i] += iKor[i];

            //    Console.Write("영어 : ");
            //    iEng[i] = int.Parse(Console.ReadLine());
            //    sum[i] += iKor[i];

            //    Console.Write("수학 : ");
            //    iMat[i] = int.Parse(Console.ReadLine());
            //    sum[i] += iKor[i];

            //    aver[i] = (float)sum[i] / 3;
            //    Console.WriteLine("--------------");
            //}

            //for (int i = 0; i<3; i++)
            //{
            //    Console.WriteLine($"학생{i + 1}");
            //    Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMat[i]} ");
            //    Console.WriteLine($"총점 : {sum[i]}");
            //    Console.WriteLine($"평균 : {aver[i].ToString("F2")}");
            //}

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]}");

                }
                Console.WriteLine();
            }
        }
    }
}
