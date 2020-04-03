using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            Creater player = Creater.getInstance("example@gmail.com");

            Console.WriteLine(player.Email);

            //Abstract Factory
            Chess Whitechesses = new Chess(new WhiteChess(),2,8);
            Whitechesses.HorseMove(2);
            Whitechesses.PawnMove(1);


            Chess Blackchesses = new Chess(new BlackChess(),2,8);
            Blackchesses.HorseMove(2);
            Blackchesses.PawnMove(4);

            //Builder
            Director director = new Director();
            BoardBuilder boardbuilder = new ClassicBoard();
            Board classicboard = director.Construct(boardbuilder);
            Console.WriteLine(classicboard.ToString());

            boardbuilder = new BorderBoard();
            Board borderboard = director.Construct(boardbuilder);
            Console.WriteLine(borderboard.ToString());

            //Prototype 
            IPrototype figure = new WhitePawn(true);
            IPrototype clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new BlackPawn(false);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
            Console.WriteLine(Singleton.text);

            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.Date);

            Console.ReadLine();


        }
    }
   
   
}
