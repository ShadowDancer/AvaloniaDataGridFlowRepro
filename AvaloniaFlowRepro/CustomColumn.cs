using Avalonia.Controls;
using Avalonia.Controls.Utils;
using Avalonia.Interactivity;

namespace AvaloniaFlowRepro
{
    public class CustomColumn : DataGridBoundColumn
    {
        protected override IControl GenerateEditingElementDirect(DataGridCell cell, object dataItem)
        {

            ListBox lb = new ListBox();
            lb.Height = 100;
            return lb;
        }

        protected override IControl GenerateElement(DataGridCell cell, object dataItem)
        {
            return new TextBlock();
        }

        protected override object PrepareCellForEdit(IControl editingElement, RoutedEventArgs editingEventArgs)
        {
            return null;
        }
    }
}
