using Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears
{
    [CreateAssetMenu(fileName = "ArmorList", menuName = "ScriptableObjects/Armor List")]
    public sealed class ArmorList : SelectionItemList<Armor>
    {
    }
}