using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Player
    {
        public void Move(Figure target)
        {
            Console.WriteLine("Imagine that here we need to enter the coordinates of x and y," +
                              "\n but we entered the coordinates of letter and digit ");
            target.Move();
        }
    }
    // класс, к которому надо адаптировать другой класс   
    class Figure
    {
        public virtual void Move()
        {

        }
    }

    // Адаптер
    class Adapter : Figure
    {
        private GameObj adaptee = new GameObj();

        public override void Move()
        {
            Console.WriteLine("Here we translate  coordinates to others");
            adaptee.SpecMove();
        }
    }

    // Адаптируемый класс
    class GameObj
    {
        public void SpecMove()
        {
            Console.WriteLine("Change the location of the figure  ");
        }
    }
}
