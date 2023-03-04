namespace DesignPatterns.Patterns.Decorator
{
    class SMSDecorator : State
    {
        public SMSDecorator(BaseNotifier comp) : base(comp)
        {
        }

        public override string Send()
        {
            return $"{_base.Send()} -> SMS send!";
        }
    }

    class FacebookDecorator : State
    {
        public FacebookDecorator(BaseNotifier comp) : base(comp)
        {
        }

        public override string Send()
        {
            return $"{_base.Send()} -> Facebook send!";
        }
    }
}
