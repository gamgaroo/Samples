using Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears;
using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using UnityEngine;
using UnityEngine.UI;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class ArmorSelectView : DropdownSelectionView<Armor, ArmorList, Gear>
    {
        [SerializeField]
        private Text _description;

        protected override void SetItem(Gear viewModel, Armor item)
        {
            viewModel.SetArmor(item);
        }

        protected override Armor GetItem(Gear viewModel)
        {
            return viewModel.Armor.Value;
        }

        protected override void UpdateView(Armor item)
        {
            _description.text = item.Description;
        }
    }
}