using Gamgaroo.Reactive.Runtime;
using Gamgaroo.Reactive.Runtime.Abstractions;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts
{
    public sealed class Unit : MonoBehaviour
    {
        private readonly IReactiveProperty<int> _health = new ReactiveProperty<int>();
        private readonly IReactiveProperty<Weapon> _weapon = new ReactiveProperty<Weapon>();

        [SerializeField]
        private int _id;

        public int Id => _id;
        public IReadOnlyReactiveProperty<int> Health => _health;
        public IReadOnlyReactiveProperty<Weapon> Weapon => _weapon;

        private static int RandomHealth => Random.Range(0, 100);

        public void Init(int id, Weapon weapon)
        {
            _id = id;

            _health.Value = RandomHealth;
            _weapon.Value = weapon;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (_health.Value + 5 > 100)
                    _health.Value = 100;
                else
                    _health.Value += 5;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (_health.Value - 5 < 0)
                    _health.Value = 0;
                else
                    _health.Value -= 5;
            }
        }
    }
}