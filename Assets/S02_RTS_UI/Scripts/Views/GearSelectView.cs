using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class GearSelectView : MonoBehaviour, IView<Gear>
    {
        [SerializeField]
        private ArmorSelectView _armor;

        [SerializeField]
        private WeaponSelectView _weapon;

        public void Set(Gear viewModel)
        {
            _armor.Set(viewModel);
            _weapon.Set(viewModel);
        }
    }
}