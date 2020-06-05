using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears
{
    [CreateAssetMenu(fileName = "WeaponList", menuName = "ScriptableObjects/Weapon List")]
    public sealed class WeaponList : SelectionItemList<Weapon>
    {
    }
}