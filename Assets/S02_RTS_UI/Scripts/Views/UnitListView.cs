using Gamgaroo.MVVM.Runtime.Extensions;
using Gamgaroo.View.Runtime.Abstractions;
using Gamgaroo.View.Runtime.Views.Primitives;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class UnitListView : MonoBehaviour, IView<Unit>
    {
        [SerializeField]
        private HealthView _health;

        [SerializeField]
        private TextView _id;

        [SerializeField]
        private WeaponView _weapon;

        public void Set(Unit viewModel)
        {
            _id.Set(viewModel.Id);

            _health.Bind(viewModel.Health);
            _weapon.Bind(viewModel.Weapon);
        }
    }
}