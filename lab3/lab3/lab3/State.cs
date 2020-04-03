using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal interface ObjectState
    {
        void HandleInput(MyObject hero, string input);
        void Update(MyObject hero);
    };
    class DuckingState : ObjectState
    {
        public DuckingState() { }

        public void HandleInput(MyObject hero, string input)
        {
            if (input == "DOWN")
            {
                Console.WriteLine("Transition to standing state");
                hero.ChangeState(new StandingState());
            }          
        }
        public void Update(MyObject hero) { }
    }
    class StandingState : ObjectState
    {
        public StandingState() { }

        public void HandleInput(MyObject hero, string input)
        {
            if (input == "B")
            {
                Console.WriteLine("Transition to jumping state");
                hero.ChangeState(new JumpingState());
            }         
            if (input == "DOWN")
            {
                Console.WriteLine("Transition to ducking state");
                hero.ChangeState(new DuckingState());
            }         //... 
        }
        public void Update(MyObject hero) { }
    }
    class JumpingState : ObjectState
    {
        public JumpingState() { }

        public void HandleInput(MyObject hero, string input)
        {
            if (input == "DOWN")
            {
                Console.WriteLine("Transition to diving state");
                hero.ChangeState(new DivingState());
            }         //...  
        }
        public void Update(MyObject hero){}
    }
    class DivingState : ObjectState
    {
        public DivingState() { }

        public void HandleInput(MyObject hero, string input)
        {
            Console.WriteLine("Impossible to switch to another state");
        }
        public void Update(MyObject hero) { }
    }
    class MyObject
    {

        private ObjectState _state;
        public MyObject(ObjectState state)
        {
            this._state = state;
        }
        public void HandleInput(string input)
        {
            _state.HandleInput(this, input);
        }
        void Update()
        {
            _state.Update(this);
        }
        public void ChangeState(ObjectState state)
        {
            this._state = state;
        }         
    };


}
