using Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts
{
    public sealed class Unit : MonoBehaviour
    {
        [SerializeField]
        private int _id;

        [SerializeField]
        private Gear _gear;

        [SerializeField]
        private Health _health;

        [SerializeField]
        private Armor _defaultArmor;

        [SerializeField]
        private Weapon _defaultWeapon;

        public int Id => _id;
        public Gear Gear => _gear;
        public Health Health => _health;
        
        public void Init(int id)
        {
            _id = id;

            _gear = new Gear(_defaultArmor, _defaultWeapon);
            _health = new Health(Random.Range(0, 100) + 1);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _health.Heal(5);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _health.AddDamage(5);
            }
        }
    }
}