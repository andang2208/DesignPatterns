using System;

namespace DesignPatterns.Patterns.SubClass
{
    class Order
    {
        private State _state = null;

        public Order(State state)
        {
            this.ChangeState(state);
        }

        public void ChangeState(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        public void ConfirmOrder()
        {
            this._state.Confirm();
        }

        public void CancelOrder()
        {
            this._state.Canceled();
        }

        public void DeliveryOrder()
        {
            this._state.Delivery();
        }

        public void GetState()
        {
            Console.WriteLine($"Current state: {_state.GetType().Name}.");
        }
    }
}