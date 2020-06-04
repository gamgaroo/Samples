using System;
using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;
using UnityEngine.UI;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class HealthBarView : MonoBehaviour, IView<int>
    {
        [SerializeField]
        private Image _body;

        [SerializeField]
        private Gradient _color;

        public void Set(int health)
        {
            if (health < 0 || health > 100)
                throw new ArgumentException($"Invalid Health: {health}. Value must be between 0 and 100");

            var rect = _body.GetComponent<RectTransform>();
            var value = health / 100f;

            rect.anchorMax = new Vector2(1, value);
            rect.sizeDelta = Vector2.zero;

            _body.color = _color.Evaluate(value);
        }
    }
}