using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        //최대 아이템 개수(배열 크기)
        const int MAX_ITEMS = 10;

        struct Player // 플레이어 구조체
        {
            public string Name;
            public string[] itemNames;
            public int[] itemCounts;
        }


        //아이템 추가 함수
        static void AddItem(string name, int count, string[] itemNames, int[] itemCounts)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)  //이미 있는 아이템이면 개수 증가
                {
                    itemCounts[i] += count;
                    return;
                }
            }

            //빈 슬롯에 새로운 아이템 추가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");

        }

        //아이템 제거 함수
        static void RemoveItem(string name, int count, string[] itemNames, int[] itemCounts)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name) //이름하고 같은지
                {
                    if (itemCounts[i] >= count) //개수가 충분하면 차감
                    {
                        itemCounts[i] -= count;
                        if (itemCounts[i] == 0) //개수가 0이면 삭제
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다!");
                        return;
                    }
                }
            }

            Console.WriteLine("아이템을 찾을 수 없습니다!");

        }


        //인벤토리 출력 함수
        static void ShowInventory(string[] itemNames, int[] itemCounts)
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            string input;

            //플레이어 인벤토리 생성
            player.itemNames = new string[MAX_ITEMS];
            player.itemCounts = new int[MAX_ITEMS];

            while (true)
            {
                Console.Clear();

                Console.WriteLine("상점");
                Console.WriteLine("1. 구매");
                Console.WriteLine("2. 판매");
                Console.WriteLine("----------------------------------------------");
                ShowInventory(player.itemNames, player.itemCounts);
                Console.WriteLine("----------------------------------------------");
                Console.Write("입력 : ");

                input = Console.ReadLine();

                if(input == "1")
                {
                    while (true)
                    {
                        int count = 0;

                        Console.Clear();
                        Console.WriteLine("물건 목록");
                        Console.WriteLine("1. HP 포션");
                        Console.WriteLine("2. MP 포션");
                        Console.WriteLine("3. 녹슨 검");
                        Console.WriteLine("4. 나무 방패");
                        Console.WriteLine("나가기 : x");
                        Console.WriteLine("----------------------------------------------");
                        ShowInventory(player.itemNames, player.itemCounts);
                        Console.WriteLine("----------------------------------------------");
                        Console.Write("입력 : ");

                        input = Console.ReadLine();

                        if(input != "x")
                        {
                            Console.Write("개수 입력 : ");
                            count = int.Parse(Console.ReadLine());
                        }

                        if (input == "1") AddItem("HP 포션", count, player.itemNames, player.itemCounts);
                        else if (input == "2") AddItem("MP 포션", count, player.itemNames, player.itemCounts);
                        else if (input == "3") AddItem("녹슨 검", count, player.itemNames, player.itemCounts);
                        else if (input == "4") AddItem("나무 방패", count, player.itemNames, player.itemCounts);
                        else if (input == "x") break;
                        else Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요");
                    }
                }
                else if (input == "2")
                {
                    while (true)
                    {
                        int count = 0;

                        Console.Clear();
                        Console.WriteLine("판매할 물건");
                        Console.WriteLine("1. HP 포션");
                        Console.WriteLine("2. MP 포션");
                        Console.WriteLine("3. 녹슨 검");
                        Console.WriteLine("4. 나무 방패");
                        Console.WriteLine("나가기 : x");
                        Console.WriteLine("----------------------------------------------");
                        ShowInventory(player.itemNames, player.itemCounts);
                        Console.WriteLine("----------------------------------------------");
                        Console.Write("입력 : ");

                        input = Console.ReadLine();

                        if (input != "x")
                        {
                            Console.Write("개수 입력 : ");
                            count = int.Parse(Console.ReadLine());
                        }

                        if (input == "1") RemoveItem("HP 포션", count, player.itemNames, player.itemCounts);
                        else if (input == "2") RemoveItem("MP 포션", count, player.itemNames, player.itemCounts);
                        else if (input == "3") RemoveItem("녹슨 검", count, player.itemNames, player.itemCounts);
                        else if (input == "4") RemoveItem("나무 방패", count, player.itemNames, player.itemCounts);
                        else if (input == "x") break;
                        else Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요");
                    }
                }
            }


        }
    }
}