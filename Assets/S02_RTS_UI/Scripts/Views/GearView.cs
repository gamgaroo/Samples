using Gamgaroo.MVVM.Runtime.Extensions;
using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class GearView : View<Gear>
    {
        [SerializeField]
        private ArmorView _armor;

        [SerializeField]
        private WeaponView _weapon;
        
        protected override void Bind(Gear viewModel)
        {
            _armor.Bind(viewModel.Armor);
            _weapon.Bind(viewModel.Weapon);
        }

        protected override void Unbind(Gear viewModel)
        {
            _armor.Unbind(viewModel.Armor);
            _weapon.Unbind(viewModel.Weapon);
        }
    }
}