using System;
using Gamgaroo.Reactive.Runtime;
using Gamgaroo.Reactive.Runtime.Abstractions;
using Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts
{
    [Serializable]
    public sealed class Gear
    {
        public Gear()
        {
            _armor = new ReactiveProperty<Armor>();
            _weapon = new ReactiveProperty<Weapon>();
        }

        public Gear(Armor armor, Weapon weapon)
        {
            _armor = new ReactiveProperty<Armor>(armor);
            _weapon = new ReactiveProperty<Weapon>(weapon);
        }

        private readonly IReactiveProperty<Armor> _armor;
        private readonly IReactiveProperty<Weapon> _weapon;

        public IReadOnlyReactiveProperty<Armor> Armor => _armor;
        public IReadOnlyReactiveProperty<Weapon> Weapon => _weapon;

        public void SetArmor(Armor armor)
        {
            _armor.Value = armor;
        }

        public void SetWeapon(Weapon weapon)
        {
            _weapon.Value = weapon;
        }
    }
}