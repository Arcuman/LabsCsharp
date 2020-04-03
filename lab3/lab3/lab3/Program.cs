using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Hero elf = new Hero("Elf");
            player.SetCommand(new JumpCommand(elf));
            player.PressButton();
            player.SetCommand(new FireCommand(elf));
            player.PressButton();
            player.SetCommand(new FireCommand(new Hero("Sniper")));
            player.PressButton();
            Console.WriteLine();


            MyObject myObject = new MyObject(new StandingState());
            myObject.HandleInput("DOWN");
            myObject.HandleInput("DOWN");
            myObject.HandleInput("B");
            myObject.HandleInput("DOWN");
            myObject.HandleInput("DOWN");
            Console.WriteLine();


            player.SetCommand(new FireCommand(elf));
            GameHistory game = new GameHistory();
            game.History.Push(elf.SaveState());
            player.PressButton();
            player.PressButton();
            elf.RestoreState(game.History.Pop());
            Console.WriteLine();


            Subject subject = new Subject();
            ConcreteObserverA observerA = new ConcreteObserverA();
            subject.Attach(observerA);
            ConcreteObserverB observerB = new ConcreteObserverB();
            subject.Attach(observerB);
            subject.SomeBusinessLogic();
            subject.Detach(observerB);
            subject.SomeBusinessLogic();
            Console.WriteLine();


            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
            Console.Read();
        }
    }
}
