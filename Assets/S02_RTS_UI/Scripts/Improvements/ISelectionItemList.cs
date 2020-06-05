using System.Collections.Generic;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Improvements
{
    public interface ISelectionItemList<out TItem>
        where TItem : ISelectionItem
    {
        IEnumerable<TItem> Items { get; }
    }
}