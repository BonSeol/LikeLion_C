using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_TEXTRPG_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MainGame mainGame = new MainGame();
            mainGame.Initialize();
            mainGame.Progress();

        }
    }
}
