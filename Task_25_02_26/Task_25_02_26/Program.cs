using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_02_26
{
    class Program
    {
        static void quest1()
        {
            int[] nums = new int[5] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static void quest2()
        {
            int[] nums = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                sum += nums[i];
            }
            Console.WriteLine($"총합 : {sum}");
        }
        static void quest3()
        {
            int[] nums = new int[5] { 3, 8, 15, 6, 2 };
            int max = nums[0], temp = 0;
            for (int i = 1; i < 5; i++)
            {
                if (max < nums[i])
                {
                    temp = nums[i];
                    nums[i] = max;
                    max = temp;
                }
            }
            Console.WriteLine($"배열 3, 8, 15, 6, 2 에서 최대값 : {max}");
        }

        static void quest4()
        {
            for (int i = 1; i < 11; i++) {
                Console.WriteLine(i);
            }
        }

        static void quest5()
        {
            int i = 1;
            while(i<=10)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                i++;
            }
        }

        static void quest6()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void quest7()
        {
            int n1, n2;
            Console.Write("첫 번째 정수 입력 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 입력 : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n1}과 {n2}의 합 : {Add(n1, n2)}");
        }

        static int StrLength(string str)
        {
            return str.Length;
        }
        static void quest8()
        {
            string input;
            input = Console.ReadLine();
            Console.WriteLine($"문자열 입력 : {input}");
            Console.WriteLine($"문자열 길이 : {StrLength(input)}");
        }
        static int findMax(int n1, int n2, int n3)
        {
            int temp = 0;
            if (n2 < n3)
            {
                temp = n2;
                n2 = n3;
                n3 = temp;
            }
            if (n1 < n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }

            return n1;
        }
        static void quest9()
        {
            int n1, n2, n3;
            Console.Write("첫 번째 정수 입력 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 입력 : ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수 입력 : ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"가장 큰 수 : {findMax(n1, n2, n3)}");

        }

        static void Main(string[] args)
        {
            quest9();
        }
    }
}
