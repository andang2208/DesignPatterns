namespace DesignPatterns.Patterns.Decorator
{
    class Notifier : BaseNotifier
    {
        public override string Send()
        {
            return "Email send!";
        }
    }
}


