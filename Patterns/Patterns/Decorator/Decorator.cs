using System;
using System.ComponentModel;

namespace DesignPatterns.Patterns.Decorator
{
    public abstract class BaseNotifier
    {
        public abstract string Send();
    }

    class State : BaseNotifier
    {
        protected BaseNotifier _base;

        public State(BaseNotifier component)
        {
            this._base = component;
        }

        public override string Send()
        {
            if (this._base != null)
            {
                return this._base.Send();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}


