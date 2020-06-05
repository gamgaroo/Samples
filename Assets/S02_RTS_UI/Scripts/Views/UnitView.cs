using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class UnitView : MonoBehaviour, IView<Unit>
    {
        [SerializeField]
        private GearSelectView _gear;

        [SerializeField]
        private HealthView _health;

        [SerializeField]
        private IdView _id;

        private void Start()
        {
            Set(null);
        }

        public void Set(Unit viewModel)
        {
            if (viewModel != null)
            {
                gameObject.SetActive(true);

                _gear.Set(viewModel.Gear);
                _id.Set(viewModel.Id);
                _health.Set(viewModel.Health);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}