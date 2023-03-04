//using RefactoringGuru.DesignPatterns.State.Conceptual;
//using System;

//namespace DesignPatterns.Patterns.SubClass
//{
//    class DraftState : State
//    {
//        public override void CancelOrder()
//        {
//            throw new NotImplementedException();
//        }

//        public override void CreateOrder()
//        {
//            throw new NotImplementedException();
//        }

//        public override void DeliveryOrder()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Handle1()
//        {
//            Console.WriteLine("ConcreteStateA handles request1.");
//            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
//            this._context.TransitionTo(new ConcreteStateB());
//        }

//        public override void Handle2()
//        {
//            Console.WriteLine("ConcreteStateA handles request2.");
//        }
//    }

//    class NewState : State
//    {
//        public override void Handle1()
//        {
//            Console.Write("ConcreteStateB handles request1.");
//        }

//        public override void Handle2()
//        {
//            Console.WriteLine("ConcreteStateB handles request2.");
//            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
//            this._context.TransitionTo(new ConcreteStateA());
//        }
//    }

//    class DeliveredState : State
//    {
//        public override void Handle1()
//        {
//            Console.Write("ConcreteStateB handles request1.");
//        }

//        public override void Handle2()
//        {
//            Console.WriteLine("ConcreteStateB handles request2.");
//            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
//            this._context.TransitionTo(new ConcreteStateA());
//        }
//    }

//    class CancelledState : State
//    {
//        public override void Handle1()
//        {
//            Console.Write("ConcreteStateB handles request1.");
//        }

//        public override void Handle2()
//        {
//            Console.WriteLine("ConcreteStateB handles request2.");
//            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
//            this._context.TransitionTo(new ConcreteStateA());
//        }
//    }
//}