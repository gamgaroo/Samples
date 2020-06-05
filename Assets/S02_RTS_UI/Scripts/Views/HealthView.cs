using Gamgaroo.MVVM.Runtime.Extensions;
using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using Gamgaroo.View.Runtime.Views.Primitives;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class HealthView : View<Health>
    {
        [SerializeField]
        private HealthBarView _bar;

        [SerializeField]
        private TextView _text;
        
        protected override void Bind(Health viewModel)
        {
            _bar.Bind(viewModel.Value);
            _text.Bind(viewModel.Value);
        }

        protected override void Unbind(Health viewModel)
        {
            _bar.Unbind(viewModel.Value);
            _text.Unbind(viewModel.Value);
        }
    }
}