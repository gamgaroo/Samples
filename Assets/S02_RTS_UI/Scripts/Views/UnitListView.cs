using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class UnitListView : MonoBehaviour, IView<Unit>
    {
        [SerializeField]
        private GearView _gear;

        [SerializeField]
        private HealthView _health;

        [SerializeField]
        private IdView _id;

        public void Set(Unit viewModel)
        {
            _gear.Set(viewModel.Gear);
            _id.Set(viewModel.Id);
            _health.Set(viewModel.Health);
        }
    }
}