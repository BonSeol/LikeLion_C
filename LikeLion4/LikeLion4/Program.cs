﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting;
            //greeting = "Hello, World!";

            //Console.WriteLine(greeting);

            //int score = 100;
            //double temperature = 36.5;
            //string city = "Seoul";

            //Console.WriteLine(score);
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);

            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi : " + Pi);
            //Console.WriteLine("Max Score : " + MaxScore);

            int Att = 16755, MaxHp = 78103;
            int Crit = 36       , Specialization = 1017, Dominate = 41 ,
                Swiftness = 611 , Endurance = 22       , Expertise = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 : " + Att);
            Console.WriteLine("최대 생명력 : " + MaxHp);

            Console.WriteLine("\n전투 특성");
            Console.WriteLine("치명 : " + Crit);
            Console.WriteLine("특화 : " + Specialization);
            Console.WriteLine("제압 : " + Dominate);
            Console.WriteLine("신속 : " + Swiftness);
            Console.WriteLine("인내 : " + Endurance);
            Console.WriteLine("숙련 : " + Expertise);
        }
    }
}
