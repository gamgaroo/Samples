using Gamgaroo.View.Runtime.Abstractions;
using Gamgaroo.View.Runtime.Views.Primitives;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class IdView : MonoBehaviour, IView<int>
    {
        [SerializeField]
        private TextView _text;

        public void Set(int viewModel)
        {
            _text.Set(viewModel);
        }
    }
}