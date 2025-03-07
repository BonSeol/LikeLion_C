using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_TEXTRPG_Test
{
    public class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;

        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }


        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                input = int.Parse(Console.ReadLine());

                if (input == 4)
                    break;

                if (input <= 3)
                {
                    //1번일때 초보몬스터
                    //2번일때 중급몬스터
                    //3번일때 고급몬스터
                    CreateMonster(input);
                    Fight();
                }




            }


        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster);

        }



        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;
            }


        }

        public void Fight()
        {
            int input = 0;

            while (true)
            {
                Console.Clear(); 
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.Write("1. ⚔️공격 2. 🏃도망\n입력 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    //플레이어 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    //몬스터 데미지
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        Console.WriteLine("☠️사망☠️");
                        Console.Write("다시 하려면 엔터");
                        Console.ReadLine();
                        break;
                    }



                }


                if (input == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }


        public void DrawMap()
        {
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Normal");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. 돌아가기");
            Console.WriteLine("=========================");
            Console.Write("맵 선택 : ");
        }

        public Field() { }
        ~Field() { }


    }
}
