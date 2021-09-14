using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Rook : Piece // Rook Arver alt fra klassen piece. Alt i klassen Piece skal også gjele i klassen Rook
    {
        public Rook() : base("TRN") { } // Denne linjen arver Symbol fra klassen Piece. Og setter Symbolet til class Rook.

        public override bool Move(string fromPosition, string toPosition) // Flytte funksjonen til Rook
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }


}
