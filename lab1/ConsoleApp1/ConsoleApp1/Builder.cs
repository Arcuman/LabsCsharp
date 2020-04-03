using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Director
    {
        public Board Construct(BoardBuilder board)
        {
            board.CreateBread();
            board.SetMaterial();
            board.SetColor();
            board.SetBorder();
            return board.Board;
        }
    }


    abstract class BoardBuilder
    {
        public Board Board { get; private set; }
        public void CreateBread()
        {
            Board = new Board();
        }
        public abstract void SetMaterial();
        public abstract void SetColor();
        public abstract void SetBorder();
    }



    class Board
    {
        public Material Material { get; set; }
        // соль
        public Border Border { get; set; }
        // пищевые добавки
        public Color Color { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Board: \n");

            if (Material != null)
                sb.Append("Made of  " + Material.Name + "\n");
            if (Color != null)
                sb.Append("Color is " + Color.FirstSide + " and " + Color.SecondSide + "\n");
            if (Border != null)
                sb.Append("With Border \n");
            else sb.Append("Without Border \n");
            return sb.ToString();
        }
    }
    class Material
    {
        // материал
        public string Name { get; set; }
    }
    // соль
    class Border
    { }
    // пищевые добавки
    class Color
    {
        public string FirstSide { get; set; }
        public string SecondSide { get; set; }
    }

    class ClassicBoard : BoardBuilder
    {
        Board product = new Board();


        public override void SetColor()
        {
            this.Board.Color = new Color { FirstSide = "White", SecondSide = "Black" };
        }
        public override void SetMaterial()
        {
            this.Board.Material = new Material { Name = "Wood" };
        }

        public override void SetBorder()
        {
        }
    }
    class BorderBoard : BoardBuilder
    {
        Board product = new Board();


        public override void SetColor()
        {
            this.Board.Color = new Color { FirstSide = "White", SecondSide = "Black" };
        }
        public override void SetMaterial()
        {
            this.Board.Material = new Material { Name = "Wood" };
        }

        public override void SetBorder()
        {
            this.Board.Border = new Border();   
        }
    }
}
