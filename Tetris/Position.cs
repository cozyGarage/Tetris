using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Position                                   // This class is used to store a position.
    {
        public int Row { get; set; }                            //  This property contains the row of the position.
        public int Column { get; set; }                         // This property contains the column of the position.
        public Position(int row, int column)                        // This constructor initializes the position.
        {
            this.Row = row;                                     // The row is set to the row parameter.
            this.Column = column;                               // The column is set to the column parameter.
        }
    }
}
