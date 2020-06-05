using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements
{
    public interface ISelectionItem
    {
        string Title { get; }
        Sprite Icon { get; }
    }
}