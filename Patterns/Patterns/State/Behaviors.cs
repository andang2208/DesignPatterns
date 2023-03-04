namespace DesignPatterns.Patterns.SubClass
{
    class DraftState : State
    {
        public override void Canceled()
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Not allow!");
        }

        public override void Confirm()
        {
            this._context.ChangeState(new ConfirmedState());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order confirmed!");
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
            this._context.ChangeState(new CanceledState());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order canceled!");
        }

        public override void Confirm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not allow!");
        }

        public override void Delivery()
        {
            this._context.ChangeState(new DeliveredState());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order delivered!");
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