using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int key = 1;

            //string str;
            //str = (key == 1) ? "문이 열렸습니다." : "문을 못 열었습니다.";

            //Console.WriteLine(str);

            string sword = "";
            int att = 100;
            Console.Write("가지고 있는 소지금을 입력하세요 : ");
            int money = int.Parse(Console.ReadLine());

            if (money < 0) { Console.WriteLine("올바른 값을 입력해주세요"); }
            else if (money <= 100)
            {
                sword = "무한의대검 +1";
                att += 1;
            }
            else if (money <= 200)
            {
                sword = "카타나 +2";
                att += 2;
            }
            else if (money <= 300)
            {
                sword = "진은검 +3";
                att += 3;
            }
            else if (money <= 400)
            {
                sword = "집판검 +4";
                att += 4;
            }
            else if (money <= 500)
            {
                sword = "엑스칼리버 +5";
                att += 5;
            }
            else if (money <= 600)
            {
                sword = "유령검 +6";
                att += 6;
            }
            else
            {
                sword = "전설의검 +7";
                att += 7;
            }

            Console.WriteLine("캐릭터 : 멋사검존");
            Console.WriteLine($"무기 : {sword}");
            Console.WriteLine($"공격력 : {att}");

        }
    }
}
