using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Bishop : Piece // Bishop Arver alt fra klassen piece. Alt i klassen Piece skal også gjele i klassen Bishop.  

    {
    public Bishop() : base("Løper") // Denne linjen arver Symbol fra klassen Piece. Og setter Symbolet til class Bishop. 
    {
    }

    public override bool Move(string fromPosition, string toPosition) // Flytte funksjonen til Bishop
    {
        var diffCol = fromPosition[0] - toPosition[0];
        var diffRow = fromPosition[1] - toPosition[1];
        return Math.Abs(diffCol) == Math.Abs(diffRow);
        }
    }
}
