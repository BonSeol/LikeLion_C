using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Block
    {
        BlockData[] Blocks = new BlockData[50]; 

        public Block()
        {
            for(int i = 0; i < Blocks.Length; i++)
            {
                Blocks[i] = new BlockData();
                Blocks[i].nX = 0;
                Blocks[i].nY = 0;
                Blocks[i].nLife = 0;
            }
        }
    }
}
