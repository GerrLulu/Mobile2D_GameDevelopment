using System;

namespace GameCarTool
{
    internal sealed class SubscriptionProperty<TValue> : ISubscriptionProperty<TValue>
    {
        private TValue _value;
        private Action<TValue> _onChangeValue;

        public TValue Value
        {
            get => _value;
            set
            {
                _value = value;
                _onChangeValue?.Invoke(_value);
            }
        }

        public void SubscribeOnChange(Action<TValue> subscriptionAction) =>
            _onChangeValue += subscriptionAction;

        public void UnSubscribeOnChange(Action<TValue> unsubscriptionAction) =>
            _onChangeValue -= unsubscriptionAction;
    }
}
