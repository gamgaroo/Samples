using System;
using System.Linq;
using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;
using UnityEngine.UI;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements
{
    // TODO: Refactor this
    /// <summary>
    ///     We have to use TItemList generic argument at class level because Unity can not render open generic fields in
    ///     Inspector. This may be fixed in 2020.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <typeparam name="TItemList"></typeparam>
    /// <typeparam name="TViewModel"></typeparam>
    public abstract class DropdownSelectionView<TItem, TItemList, TViewModel> : MonoBehaviour, IView<TViewModel>
        where TItem : ISelectionItem
        where TItemList : ISelectionItemList<TItem>
    {
        [SerializeField]
        private Dropdown _dropdown;

        [SerializeField]
        private TItemList _list;
        
        protected void Awake()
        {
            _dropdown.options = _list.Items.Select(w => new Dropdown.OptionData(w.Title, w.Icon)).ToList();
        }

        private int IndexOf(TItem item)
        {
            return Array.IndexOf(_list.Items.ToArray(), item);
        }

        private void SetItemById(TViewModel viewModel, int id)
        {
            var item = _list.Items.ElementAt(id);

            SetItem(viewModel, item);
            UpdateView(item);

            Set(viewModel);
        }

        protected abstract void SetItem(TViewModel viewModel, TItem item);
        protected abstract TItem GetItem(TViewModel viewModel);

        protected abstract void UpdateView(TItem item);

        public void Set(TViewModel viewModel)
        {
            _dropdown.onValueChanged.RemoveAllListeners();
            _dropdown.onValueChanged.AddListener(id => SetItemById(viewModel, id));

            UpdateView(GetItem(viewModel));

            _dropdown.value = IndexOf(GetItem(viewModel));
        }
    }
}