using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class BlockQueue                             // This class is used to generate the next block and update the current block.
    {
        private readonly Block[] blocks = new Block[]               // This array contains all the blocks that can be generated.
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };

        private readonly Random random = new Random();                  // This random object is used to generate a random block.

        public Block NextBlock { get; private set; }                    // This property contains the next block.

        public BlockQueue()                                             // This constructor initializes the next block.
        {
            NextBlock = RandomBlock();                                  // The next block is set to a random block.
        }

        private Block RandomBlock()                                     // This method returns a random block.
        {
            return blocks[random.Next(blocks.Length)];                  // A random block is returned.
        }

        public Block GetAndUpdate()                                     // This method returns the next block and updates the next block.
        {
            Block block = NextBlock;                                    // The next block is stored in a variable.

            do                                                          // A new next block is generated until it is not the same as the current next block.
            {
                NextBlock = RandomBlock();
            }
            while (block.Id == NextBlock.Id);                           // The loop continues until the next block is not the same as the current next block.

            return block;
        }
    }
}
