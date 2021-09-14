using System;
using System.Collections.Immutable;
using System.Net.Mime;
using System.Text;

namespace SimpleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var board = new Board(); // Lager selve brettet med gitte posisjoner til brikkene.
            var queen = new Queen();
            var king = new King();
            var bishop = new Bishop(); // Lager løper brikke som står på bordet.
            var rook = new Rook(); // Lager Tårn brikke som står på bordet.
            board.Set("e4", bishop); // Her settes posisjonen til Bishop
            board.Set("f7", rook); // Her settes posisjonen til Rook
            board.Set("d1", king); // Her settes posisjonen til King
            board.Set("c8", queen); // Her settes posisjonen til queen
            while (true)
            {
                board.Show(); //Board show funksjonen. 
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                var positionFrom = Ask("Hvilken rute vil du flytte fra?");
                var positionTo = Ask("Hvilken rute vil du flytte til?");
                board.Move(positionFrom, positionTo);
            }
        }

        private static string Ask(string question)
        {
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }
    }

    
}
