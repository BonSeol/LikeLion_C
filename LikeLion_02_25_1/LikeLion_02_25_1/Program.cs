using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LikeLion_02_25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input       ;
            int rnd         ;

            Thread.Sleep(500);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 나무캐기");
                Console.WriteLine("2. 장비뽑기");
                Console.WriteLine("3. 나가기");

                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

                if      (input == 1) //나무캐기
                {
                    while (true)
                    {
                        Console.WriteLine("엔터를 눌러 나무캐기");
                        Console.WriteLine("       뒤로 가기 [X]");

                        string str = Console.ReadLine();

                        if (str == "x")
                        {
                            Console.WriteLine("뒤로 가기");
                            break;
                        }

                        pmoney += 100;
                        Console.WriteLine($"소지금 : {pmoney}\n");
                    }
                }
                else if (input == 2) //장비뽑기
                {
                    if(pmoney >= 1000)
                    {
                        pmoney -= 1000;

                        for(int i = 1; i<=20; i++)
                        {
                            rnd = rand.Next(1, 101);
                            if(rnd == 1)
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 16)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 17 && rnd <= 36)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 37 && rnd <= 66)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(500);
                        }
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3) //나가기
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
                else { Console.WriteLine("잘못된 입력입니다."); }
            }
        }
    }
}
