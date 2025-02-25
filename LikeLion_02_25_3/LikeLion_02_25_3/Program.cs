using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace LikeLion_02_25_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 기본 설정
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Clear();
            Console.SetCursorPosition(0,0);
            Console.Write("┏▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭┓");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                              ESCAPE THE TOWER                                ┃");
            Console.Write("┃                                Press Enter                                   ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┃                                                                              ┃");
            Console.Write("┗▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭▬▭┛");
            Console.ReadLine();
            for (int i = 0; i <= 25; i++)
            {
                Console.Clear();
                if (i < 1) Console.WriteLine("                                .--.     ");
                if (i < 2) Console.WriteLine("                             .-(    ).   ");
                if (i < 3) Console.WriteLine("                            (___.__)__)  ");
                if (i < 4) Console.WriteLine("                                                                  .--.     ");
                if (i < 5) Console.WriteLine("                                                               .-(    ).   ");
                if (i < 6) Console.WriteLine("                                                              (___.__)__)  ");
                if (i < 7) Console.WriteLine("               .--.     ");
                if (i < 8) Console.WriteLine("            .-(    ).   ");
                if (i < 9) Console.WriteLine("           (___.__)__)  ");
                if (i < 10) Console.WriteLine("                                     .--.     ");
                if (i < 11) Console.WriteLine("                                  .-(    ).   ");
                if (i < 12) Console.WriteLine("                                 (___.__)__)  ");
                if (i < 13) Console.WriteLine("                                                                  .--.     ");
                if (i < 14) Console.WriteLine("                                                               .-(    ).   ");
                if (i < 15) Console.WriteLine("                                                              (___.__)__)  ");
                if (i < 16) Console.WriteLine("                        .--.     ");
                if (i < 17) Console.WriteLine("                     .-(    ).   ");
                if (i < 18) Console.WriteLine("                    (___.__)__)  ");
                if (i < 19) Console.WriteLine("                                              .--.     ");
                if (i < 20) Console.WriteLine("                                           .-(    ).   ");
                if (i < 21) Console.WriteLine("                                          (___.__)__)  ");
                if (i < 22) Console.WriteLine("            .--.     ");
                if (i < 23) Console.WriteLine("         .-(    ).   ");
                if (i < 24) Console.WriteLine("        (___.__)__)  ");
                Console.WriteLine("\n\n\n");
                if (i >  1) Console.WriteLine("                    █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █");
                if (i >  2) Console.WriteLine("                    █████████████████████████████████████████");
                if (i >  3) Console.WriteLine("                    █████████████████████████████████████████");
                if (i >  4) Console.WriteLine("                      █████████████████████████████████████");
                if (i >  5) Console.WriteLine("                      █████████████████████████████████████");
                if (i >  6) Console.WriteLine("                      █████████████████████████████████████");
                if (i >  7) Console.WriteLine("                      █████████████████████████████████████");
                if (i >  8) Console.WriteLine("                      █████████████████████████████████████");
                if (i >  9) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 10) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 11) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 12) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 13) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 14) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 15) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 16) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 17) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 18) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 19) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 20) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 21) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 22) Console.WriteLine("                      █████████████████████████████████████");
                if (i > 23) Console.WriteLine("                    █████████████████████████████████████████");
                if (i > 24) Console.WriteLine("                    █████████████████████████████████████████");
                Thread.Sleep(500);
            }

            Random rand = new Random();

            int input, drinkinput, damage, crit, height = 20;
            int woodHealth = 1000;
            bool isAlive = true;

            Console.Clear();
            Console.WriteLine("숲 속을 걷고 있던 당신은 거대한 탑을 발견하였습니다.");
            Console.ReadLine();
            Console.WriteLine("당신은 호기심에 탑의 문을 두드렸습니다.");
            Console.ReadLine();
            Console.WriteLine("갑자기 문이 열리더니 무언가 날아옵니다..!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("...");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("정신을 차리고 눈을 떠보니 작은 창문과 나무 문이 있는 좁은 방 안에 갇혀있습니다..");
            Console.ReadLine();
            Console.WriteLine("이 곳을 탈출하기 위해 주변을 둘러보니 몇 개 쓸만한 게 있습니다.");
            Console.ReadLine();
            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine("1. 도끼");
                Console.WriteLine("2. 밧줄");
                Console.WriteLine("3. 수상한 물약");
                Console.Write("무엇을 고르시겠습니까? ");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

                if (input == 1)
                {
                    Console.WriteLine("도끼를 들고 근처에 부술만한 걸 찾아보니 마침 나무문이 있습니다.");
                    Console.ReadLine();
                    Console.WriteLine("하지만 이 도끼는 몇 번 쓰면 부러질 듯 합니다..");
                    Console.ReadLine();
                    Console.WriteLine("그래도 희망을 품고 문을 향해 도끼를 힘껏 내리칩니다.");
                    Console.ReadLine();
                    Console.Clear();

                    for(int n = 10; n > 0; n--)
                    {
                        damage = rand.Next(5, 16) * 10;
                        crit = rand.Next(1, 11);

                        Console.WriteLine($"나무 문 내구도 ({woodHealth}/1000)");
                        Console.WriteLine("엔터를 눌러 내려치기\n");
                        Console.ReadLine();

                        if(crit == 1)
                        {
                            Console.WriteLine($"크리티컬! 내구도 -{damage * 2}");
                            woodHealth -= damage * 2;
                        }
                        else
                        {
                            Console.WriteLine($"내구도 -{damage}");
                            woodHealth -= damage;
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (woodHealth < 0) break;
                    }

                    if(woodHealth > 0)
                    {
                        Console.WriteLine("문을 부수는데 실패했습니다.. 다른 방법을 시도해보기로 합니다.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("문을 부수는데 성공하였습니다! 당신은 문을 열고 나와 마주한 함정들을 간신히 피해 탑을 탈출하였습니다..!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("GAME CLEAR");
                        Environment.Exit(1);
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("당신은 밧줄을 들고 작은 창문 앞에 섰습니다.");
                    Console.ReadLine();
                    Console.WriteLine("고개를 내밀어 밖을 보니 이 방은 그냥 떨어진다면 몸이 남아나지 않을 높이입니다.");
                    Console.ReadLine();
                    Console.WriteLine("마음을 굳게 먹고 창문 옆에 튀어나와있는 돌에 밧줄을 걸고 창문으로 나갈 준비를 합니다.");
                    Console.ReadLine();
                    Console.WriteLine("밧줄을 잡고 창문 틀에 걸터앉으니 바람이 꽤나 강하게 붑니다..");
                    Console.ReadLine();
                    Console.WriteLine("바람이 강하게 불 때 내려갔다간 떨어질 수도 있을 것 같습니다.");
                    Console.ReadLine();
                    Console.Clear();

                    while(height > 0)
                    {
                        int wind = rand.Next(1, 11);
                        Console.WriteLine($"현재 바람 세기 : {wind}");
                        Console.WriteLine("1~6 : 안전 | 7~10 : 위험");
                        Console.WriteLine("\n");
                        Console.WriteLine($"현재 높이 : {height*10}m");
                        Console.WriteLine("내려가기 : Z | 멈추기 : X");
                        Console.Write("입력 : ");
                        string str = Console.ReadLine();

                        if (wind >= 7 && str == "z")
                        {
                            isAlive = false;
                            Console.Clear();
                            Console.WriteLine("당신은 바람에 날려 떨어지고 말았습니다..");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME OVER");
                            Environment.Exit(1);
                        }
                        else
                        {
                            if (str == "z") height--;
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("당신은 간신히 탑을 내려왔습니다..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("GAME CLEAR");
                    break;
                }
                else if (input == 3)
                {
                    Console.WriteLine("당신은 뭔지 모를 물약을 손에 들었습니다.");
                    Console.ReadLine();
                    Console.WriteLine("물약은 연기가 일렁거리며 좋지 않은 기운을 풍기고 있습니다.");
                    Console.ReadLine();
                    Console.WriteLine("정말 마시겠습니까..?");
                    Console.Write("1. 네 2. 아니오");
                    drinkinput = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if(drinkinput == 1)
                    {
                        Console.WriteLine("당신은 눈을 질끈 감고 물약을 들이켰습니다.");
                        Console.ReadLine();
                        Console.WriteLine("멀쩡한가 싶더니 서서히 정신을 잃어갑니다...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("..");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("..");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("...");
                        Thread.Sleep(1000);

                        isAlive = rand.Next(0, 2) == 1;
                        if (isAlive)
                        {
                            Console.WriteLine("정신을 차려보니 무슨 영문인지 숲을 들어오기 전으로 돌아왔습니다..!");
                            Console.ReadLine();
                            Console.WriteLine("당신은 꿈인가 싶었지만 기억이 생생하게 남아있는 것을 보니 현실인 것 같습니다..");
                            Console.ReadLine();
                            Console.WriteLine("악몽같은 경험을 다시는 하고싶지 않아 당신은 집으로 되돌아가 잠에 들었습니다.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME CLEAR!");
                            Environment.Exit(1);
                        }
                        else
                        {
                            Console.WriteLine("당신은 정신을 잃은 채로 다시는 깨어나지 않았습니다...");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME OVER");
                            Environment.Exit(1);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요");
                }
            }
        }
    }
}
