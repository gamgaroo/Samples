using System.Collections.Generic;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements
{
    public abstract class SelectionItemList<TItem> : ScriptableObject, ISelectionItemList<TItem>
        where TItem : ISelectionItem
    {
        [SerializeField]
        private TItem[] _items;
        public IEnumerable<TItem> Items => _items;
    }
}