using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Adapter adapter = new Adapter();
            player.Move(adapter);

            Board board = new ClasicBoard();
            board = new BlueandWhite(board);
            board = new BeautySymbols(board);
            Console.WriteLine("Name: {0}", board.Name);
            Console.WriteLine("Price: {0}", board.GetCost());

            IComponent map1 = new Map("Global Map");
            IComponent map2 = new Map("Belarus Map");
            IComponent settl1 = new Settlements("Mogilev");
            IComponent settl2 = new Settlements("Minsk");
            IComponent settl3 = new Settlements("Molodechno");
            ((Map)map1).Add(map2);
            ((Map)map1).Add(settl1);
            ((Map)map2).Add(settl2);
            ((Map)map2).Add(settl3);

            Console.WriteLine("Trace of Found:");
            Console.WriteLine(map1.Find("Minsk"));
            Console.WriteLine("Trace of Found:");
            Console.WriteLine(map1.Find("Mogilev"));
            Console.Read();
        }
    }
   
}
