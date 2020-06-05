using System.Linq;
using Gamgaroo.Reactive.Runtime;
using Gamgaroo.Reactive.Runtime.Abstractions;
using Gamgaroo.Samples.S02_RTS_UI.Scripts.Views;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts
{
    public sealed class Player : MonoBehaviour
    {
        private readonly IReactiveProperty<Unit> _selectedUnit = new ReactiveProperty<Unit>();
        private readonly IReactiveList<Unit> _units = new ReactiveList<Unit>();

        [SerializeField]
        private Unit _unitPrefab;

        [SerializeField]
        private int _unitCount;
        
        public IReadOnlyReactiveProperty<Unit> SelectedUnit => _selectedUnit;
        public IReadOnlyReactiveList<Unit> Units => _units;

        private void Start()
        {
            // Setting View here is not a best practice. This should be improved. 
            SetView();

            var unitsContainer = CreateUnitsContainer();

            for (var i = 0; i < _unitCount; i++)
            {
                var unit = Instantiate(_unitPrefab, unitsContainer);

                unit.Init(i + 1);

                _units.Add(unit);
            }
        }

        private void Update()
        {
            HandleInput();
        }

        private void SetView()
        {
            FindObjectsOfType<PlayerView>().Single().Set(this);
        }

        private void HandleInput()
        {
            if (int.TryParse(Input.inputString, out var unitId))
                SelectUnit(unitId - 1);
        }

        private void SelectUnit(int id)
        {
            _selectedUnit.Value = HasUnitWithId(id) ? _units.Items[id] : null;
        }

        private bool HasUnitWithId(int id)
        {
            return id >= 0 && id < _units.Items.Count;
        }

        private Transform CreateUnitsContainer()
        {
            var unitsContainer = new GameObject("Units");

            unitsContainer.transform.SetParent(transform);

            return unitsContainer.transform;
        }
    }
}