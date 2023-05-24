using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block                                                                                     // class Block that is abstract the block pieces in the game.
    {
        protected abstract Position[][] Tiles { get; }                                                              // protected abstract Position[][] Tiles that is the position of the tiles in the game.
        protected abstract Position StartOffset { get; }                                                            // protected abstract Position StartOffset that is the starting position of the block.
        public abstract int Id { get; }                                                                             // public abstract int Id that is the id of the block.

        private int rotationState;                                                                                  // private int rotationState that is the rotation state of the block.
        private Position offset;                                                                                    // private Position offset that is the offset of the block.

        public Block()                                                                                              // public Block() that is the constructor for the block.
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);                                             // offset is a new Position with the StartOffset.Row and StartOffset.Column.
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}
