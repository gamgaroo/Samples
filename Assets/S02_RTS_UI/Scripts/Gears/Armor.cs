using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears
{
    [CreateAssetMenu(fileName = "Armor", menuName = "ScriptableObjects/Armor")]
    public sealed class Armor : ScriptableObject, ISelectionItem
    {
        [SerializeField]
        private Sprite _icon;

        [SerializeField]
        private string _title;

        [SerializeField]
        private string _description;

        public string Title => _title;
        public Sprite Icon => _icon;
        public string Description => _description;
    }
}