using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDefense
{

    class Player
    {
        const int W = 87, A = 65, S = 83, D = 68;
        const int UP = 72, DOWN = 80, LEFT = 75, RIGHT = 77, SPACEBAR = 32;

        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int pX, pY;
        public int pHP;

        Attack[] pAttack = new Attack[20];
        Skill pSkill = new Skill();

        public Player()
        {
            pX = 40;
            pY = 12;

            for (int i = 0; i < pAttack.Length; i++)
            {
                pAttack[i] = new Attack();
            }
        }

        public void Start()
        {
            KeyControl();
            PlayerDraw();

            foreach (var bullet in pAttack)
            {
                bullet.AttackDraw();
            }
        }

        public void KeyControl()
        {
            if (Console.KeyAvailable)
            {
                int pressKey = _getch();
                if (pressKey >= 97 && pressKey <= 122) pressKey -= 32;

                switch (pressKey)
                {
                    case W: pY = Math.Max(1, pY - 1); break;
                    case A: pX = Math.Max(0, pX - 1); break;
                    case D: pX = Math.Min(75, pX + 1); break;
                    case S: pY = Math.Min(21, pY + 1); break;

                    case UP: FireBullet(UP, 0, -1); break;
                    case LEFT: FireBullet(LEFT, -1, 0); break;
                    case RIGHT: FireBullet(RIGHT, 1, 0); break;
                    case DOWN: FireBullet(DOWN, 0, 1); break;

                    case SPACEBAR: break;
                }
            }
        }

        void FireBullet(int direction, int dx, int dy)
        {
            foreach (var bullet in pAttack)
            {
                if (!bullet.aFire)
                {
                    bullet.Fire(pX + dx, pY + dy, direction);
                    break; // 비어있는 하나만 발사하고 나감
                }
            }
        }

        public void PlayerDraw()
        {
            Console.SetCursorPosition(pX, pY);
            Console.WriteLine("◎");
        }
    }

    class Attack
    {
        const int UP = 72, DOWN = 80, LEFT = 75, RIGHT = 77;

        public int aX, aY;
        public bool aFire;
        public int view;

        public void Fire(int x, int y, int direction)
        {
            aX = x;
            aY = y;
            view = direction;
            aFire = true;
        }

        public void AttackDraw()
        {
            if (!aFire) return;

            Console.SetCursorPosition(aX, aY);
            Console.Write("○");

            switch (view)
            {
                case UP: aY--; break;
                case LEFT: aX--; break;
                case RIGHT: aX++; break;
                case DOWN: aY++; break;
            }

            if (aX < 1 || aX > 78 || aY < 1 || aY > 24) aFire = false;
        }
    }


    class Skill
    {
        public int sX, sY;
        public int sGage;
    }

    class Enemy
    {
        public int eX, eY;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player();
            Enemy[] enemy = new Enemy[50];

            int dwTime = Environment.TickCount;

            while (true)
            {
                if(dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    player.Start();
                }
            }
        }
    }
}
