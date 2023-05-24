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

        public IEnumerable<Position> TilePositions()                                                                 // public IEnumerable<Position> TilePositions() that returns the tile positions of the block.
        {
            foreach (Position p in Tiles[rotationState])                                                             // foreach loop that goes through the Tiles[rotationState].
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);                                // returns a new Position with the p.Row + offset.Row and p.Column + offset.Column.
            }
        }

        public void RotateCW()                                                                                      // public void RotateCW() that rotates the block clockwise.
        {
            rotationState = (rotationState + 1) % Tiles.Length;                                                     // rotationState is equal to (rotationState + 1) % Tiles.Length.
        }

        public void RotateCCW()                                                                                     // public void RotateCCW() that rotates the block counter clockwise.
        {
            if (rotationState == 0)                                                                                 // if statement that checks if rotationState is equal to 0.
            {
                rotationState = Tiles.Length - 1;                                                                   // rotationState is equal to Tiles.Length - 1.
            }
            else
            {
                rotationState--;                                                                                    // rotationState is equal to rotationState - 1.
            }
        }

        public void Move(int rows, int columns)                                                                     // public void Move(int rows, int columns) that moves the block.
        {
            offset.Row += rows;                                                                                     // offset.Row is equal to offset.Row + rows.
            offset.Column += columns;                                                                               // offset.Column is equal to offset.Column + columns.
        }

        public void Reset()                                                                                         // public void Reset() that resets the block.
        {
            rotationState = 0;                                                                                      // rotationState is equal to 0.
            offset.Row = StartOffset.Row;                                                                           // offset.Row is equal to StartOffset.Row.
            offset.Column = StartOffset.Column;                                                                     // offset.Column is equal to StartOffset.Column.
        }
    }
}
