using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal interface ICommand
    {
        void Execute();
    };

    internal class JumpCommand : ICommand
    {

        Hero hero;
        public JumpCommand(Hero _hero)
        {
            hero = _hero;
        }
        public void Execute()
        {
            hero.Jump();
        }
        
    };

    internal class FireCommand : ICommand
    {
        Hero hero;
        public FireCommand(Hero _hero)
        {
            hero = _hero;
        }
        public void Execute()
        {
            hero.Fire();
        }
    };

    internal class Player
    {
        private ICommand command;
        public Player()
        { }
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void PressButton()
        {
            command.Execute();
        }
    }

    internal class Hero
    {
        public string Name { get; private set; }
        private int patrons = 10; // кол-во патронов
        public Hero(string _name)
        {
            Name = _name;
        }
        public void Jump()
        {
            Console.WriteLine($"Hero: {Name} jump");
        }
        public void Fire()
        {

            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Производим выстрел. Осталось {0} патронов у персонажа {1}", patrons, Name);
            }
            else
                Console.WriteLine("Патронов больше нет");
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Сохранение игры. Параметры: {0} патронов у персонажа {1}", patrons, Name);
            return new HeroMemento(patrons);
        }

        // восстановление состояния
        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            Console.WriteLine("Восстановление игры. Параметры: {0} патронвов у персонажа {1}", patrons, Name);
        }
    }
    class HeroMemento
    {
        public int Patrons { get; private set; }
        public HeroMemento(int patrons)
        {
            this.Patrons = patrons;
        }
    }
  
    class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }

}
