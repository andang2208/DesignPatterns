//using System;

//namespace DesignPatterns.Patterns.SubClass
//{
//    class Order
//    {
//        private State _state = null;

//        public Order(State state)
//        {
//            this.TransitionTo(state);
//        }

//        public void TransitionTo(State state)
//        {
//            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
//            this._state = state;
//            this._state.SetContext(this);
//        }

//        public void Request1()
//        {
//            this._state.Handle1();
//        }

//        public void Request2()
//        {
//            this._state.Handle2();
//        }
//    }
//}