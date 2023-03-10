namespace DesignPatterns.Patterns.State
{
    class DraftState : State
    {
        public override void Canceled()
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine($"Not allow!");
        }

        public override void Confirm()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order confirmed!");

            this._order.ChangeState(new ConfirmedState());
        }

        public override void Delivery()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }
    }

    class ConfirmedState : State
    {
        public override void Canceled()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order canceled!");

            this._order.ChangeState(new CanceledState());
        }

        public override void Confirm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }

        public override void Delivery()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order delivered!");

            this._order.ChangeState(new DeliveredState());
        }
    }

    class CanceledState : State
    {
        public override void Canceled()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }

        public override void Confirm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }

        public override void Delivery()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }
    }

    class DeliveredState : State
    {
        public override void Canceled()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }

        public override void Confirm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }

        public override void Delivery()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }
    }
}