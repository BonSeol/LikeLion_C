using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_TEXTRPG_Test
{
    public class Player
    {
        public INFO m_tInfo;

        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        public void SetHp(int iHealth) { m_tInfo.iHp = iHealth; }
        public INFO GetInfo() { return m_tInfo; }
        public void SelectJob()
        {
            m_tInfo = new INFO();

            Console.Write("직업을 선택하세요 (1.기사⚔️ 2.마법사🧙 3.도둑🥷)\n입력 : ");
            int input = 0;

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    m_tInfo.strName = "기사⚔️‍";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "마법사🧙";
                    m_tInfo.iHp = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "도둑🥷";
                    m_tInfo.iHp = 85;
                    m_tInfo.iAttack = 13;
                    break;
            }
        }



        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("직업 : " + m_tInfo.strName);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 :  " + m_tInfo.iAttack);
        }


        public Player() { }

        ~Player() { }

    }
}
