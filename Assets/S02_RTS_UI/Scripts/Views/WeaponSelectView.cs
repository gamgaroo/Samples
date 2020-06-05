using Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears;
using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using UnityEngine;
using UnityEngine.UI;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class WeaponSelectView : DropdownSelectionView<Weapon, WeaponList, Gear>
    {
        [SerializeField]
        private Text _description;

        protected override void SetItem(Gear viewModel, Weapon item)
        {
            viewModel.SetWeapon(item);
        }

        protected override Weapon GetItem(Gear viewModel)
        {
            return viewModel.Weapon.Value;
        }

        protected override void UpdateView(Weapon item)
        {
            _description.text = item.Description;
        }
    }
}