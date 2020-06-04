using Gamgaroo.View.Runtime.Abstractions;
using Gamgaroo.View.Runtime.Views.Primitives;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class HealthView : MonoBehaviour, IView<int>
    {
        [SerializeField]
        private HealthBarView _bar;

        [SerializeField]
        private TextView _text;

        public void Set(int viewModel)
        {
            _bar.Set(viewModel);
            _text.Set(viewModel);
        }
    }
}