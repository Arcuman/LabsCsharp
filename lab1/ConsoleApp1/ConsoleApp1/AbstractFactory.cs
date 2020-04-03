using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IPrototype
    {
        IPrototype Clone();
        void GetInfo();
    }
    //
    abstract class Pawn: IPrototype
    {
        public bool IsAlive { get; private set; }
        public Pawn(bool value)
        {
            this.IsAlive = value;
        }
        public Pawn()
        {
            this.IsAlive = true;
        }
        public abstract IPrototype Clone();
        public abstract void GetInfo();
        public abstract void Step();
    }
    class WhitePawn : Pawn
    {
        public WhitePawn(bool value) : base(value)
        {
        }
        public WhitePawn() : base() { }
        public override IPrototype Clone()
        {
            return new WhitePawn(IsAlive);
        }

        public override void Step()
        {
            Console.WriteLine("Белая пешка ходит");
        }
        public override void GetInfo()
        {
            Console.WriteLine("Белая пешка на шахмотной доске {0} ",IsAlive );
        }
    }
    class BlackPawn : Pawn
    {
        public BlackPawn(bool value) : base(value)
        {
        }
        public BlackPawn() : base() { }
        public override IPrototype Clone()
        {
            return new BlackPawn(IsAlive);
        }
        public override void Step()
        {
            Console.WriteLine("Черная пешка ходит");
        }
        public override void GetInfo()
        {
            Console.WriteLine("Черная пешка на шахмотной доске {0} ", IsAlive);
        }
    }

    abstract class Horse
    {
        public abstract void Step();
    }
    class WhiteHorse : Horse
    {
        public override void Step()
        {
            Console.WriteLine("Белый конь ходит");
        }
    }
    class BlackHorse : Horse
    {
        public override void Step()
        {
            Console.WriteLine("Черный конь ходит");
        }
    }

    //абстрактная фабрика
    abstract class ChessFactory
    {
        public abstract Horse CreateHorse();
        public abstract Pawn CreatePawn();
        public abstract Pawn CreatePawn(bool value);
    }
    //ConcreteFactory WhiteChess
    class WhiteChess : ChessFactory
    {
        public override Horse CreateHorse()
        {
            return new WhiteHorse();
        }
        public override Pawn CreatePawn()
        {
            return new WhitePawn();
        }
        public override Pawn CreatePawn(bool value)
        {
            return new WhitePawn(value);
        }
    }
    //ConcreteFactory BlackChess
    class BlackChess : ChessFactory
    {
        public override Horse CreateHorse()
        {
            return new BlackHorse();
        }
        public override Pawn CreatePawn()
        {
            return new BlackPawn();
        }
        public override Pawn CreatePawn(bool value)
        {
            return new BlackPawn(value);
        }
    }
    class Chess
    {
        private List<Horse> horses = new List<Horse>();
        private List<Pawn> pawns = new List<Pawn>();
        public Chess(ChessFactory factory, int countHorse, int countPawn)
        {
            for (int i = 0; i < countHorse; i++)
            {
                horses.Add(factory.CreateHorse());
            }
            for (int i = 0; i < countPawn; i++)
            {
                pawns.Add(factory.CreatePawn());
            }
        }
        public void HorseMove(int n)
        {
            Console.WriteLine($"Ходит {n} конь ");
            horses[n - 1].Step();
        }
        public void PawnMove(int n)
        {
            Console.WriteLine($"Ходит{n} пешка ");
            pawns[n - 1].Step();
        }
    }
}
