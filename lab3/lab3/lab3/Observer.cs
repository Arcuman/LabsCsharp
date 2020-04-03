using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IPlayers
    {
        void Update(Subject subject);
    }
    public class Subject
    {
        public int State { get; set; } = 30;
        private List<IPlayers> _observers = new List<IPlayers>();
        public void Attach(IPlayers observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }
        public void Detach(IPlayers observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nYou are in game {0} min", this.State);
            this.Notify();
            this.State += 15;
        }
    }
    class ConcreteObserverA : IPlayers
    {
        public void Update(Subject subject)
        {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
    class ConcreteObserverB : IPlayers
    {
        public void Update(Subject subject)
        {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}
