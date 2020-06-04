using System.Collections.Generic;
using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;
using UnityEngine.UI;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class PlayerView : MonoBehaviour, IView<Player>
    {
        private readonly IDictionary<Unit, UnitListView> _unitListViews = new Dictionary<Unit, UnitListView>();

        [SerializeField]
        private UnitView _selectedUnitView;

        [SerializeField]
        private GridLayoutGroup _unitListGridLayoutGroup;

        [SerializeField]
        private UnitListView _unitListViewPrefab;

        public void Set(Player viewModel)
        {
            viewModel.SelectedUnit.OnValueChanged += OnSelectedUnitChanged;

            viewModel.Units.OnItemAdded += OnUnitAdded;
            viewModel.Units.OnItemRemoved += OnUnitRemoved;
        }

        private void Awake()
        {
            SetListGridLayoutGroupCellSize();
        }

        private void SetListGridLayoutGroupCellSize()
        {
            var cellSizeX = _unitListGridLayoutGroup.GetComponent<RectTransform>().rect.width;
            var cellSizeY = cellSizeX / 4;

            _unitListGridLayoutGroup.cellSize = new Vector2(cellSizeX, cellSizeY);
        }

        private void OnSelectedUnitChanged(Unit unit)
        {
            _selectedUnitView.Set(unit);
        }

        private void OnUnitAdded(Unit unit)
        {
            var view = InstantiateUnitView();

            view.Set(unit);

            _unitListViews.Add(unit, view);
        }

        private void OnUnitRemoved(Unit unit)
        {
            var view = _unitListViews[unit];

            _unitListViews.Remove(unit);

            Destroy(view.gameObject);
        }

        private UnitListView InstantiateUnitView()
        {
            return Instantiate(_unitListViewPrefab, _unitListGridLayoutGroup.transform);
        }
    }
}