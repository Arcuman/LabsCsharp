using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Board
    {
        public Board(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class ClasicBoard : Board
    {
        public ClasicBoard() : base("Classic")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
    class BorderBoard : Board
    {
        public BorderBoard()
            : base("With border")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }

    abstract class BoardDecorator : Board
    {
        protected Board board;
        public BoardDecorator(string n, Board board) : base(n)
        {
            this.board = board;
        }
    }

    class BlueandWhite : BoardDecorator
    {
        public BlueandWhite(Board p)
            : base(p.Name + ",with blue and white cells board", p)
        { }

        public override int GetCost()
        {
            return board.GetCost() + 3;
        }
    }

    class BeautySymbols : BoardDecorator
    {
        public BeautySymbols(Board p)
            : base(p.Name + ", with beautiful letters and numbers", p)
        { }

        public override int GetCost()
        {
            return board.GetCost() + 5;
        }
    }
}
