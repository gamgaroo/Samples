using System;
using Gamgaroo.Reactive.Runtime;
using Gamgaroo.Reactive.Runtime.Abstractions;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts
{
    [Serializable]
    public sealed class Health
    {
        private const int DefaultValue = 100;

        private const int DeathValue = 0;
        private const int MaxValue = 100;

        private readonly IReactiveProperty<int> _value;

        public Health()
        {
            _value = new ReactiveProperty<int>(DefaultValue);
        }

        public Health(int value)
        {
            _value = new ReactiveProperty<int>(value);
        }

        public IReadOnlyReactiveProperty<int> Value => _value;

        public void AddDamage(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Damage value must be greater than 0.");

            if (_value.Value - value <= DeathValue)
                _value.Value = DeathValue;
            else
                _value.Value -= value;

            if (_value.Value == DeathValue)
                OnDeath?.Invoke();
        }

        public void Heal(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Heal value must be greater than 0.");

            if (_value.Value + value >= MaxValue)
                _value.Value = MaxValue;
            else
                _value.Value += value;
        }

        public event Action OnDeath;
    }
}