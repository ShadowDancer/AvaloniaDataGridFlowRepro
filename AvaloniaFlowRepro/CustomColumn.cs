using Avalonia.Controls;
using Avalonia.Controls.Utils;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AvaloniaFlowRepro
{
    public class CustomColumn : DataGridBoundColumn
    {

        TextBox _lastTb;


        protected override IControl GenerateEditingElementDirect(DataGridCell cell, object dataItem)
        {
            _lastTb = new TextBox()
            {
                Foreground = Brushes.Black
            };
            return _lastTb;
        }

        protected override IControl GenerateElement(DataGridCell cell, object dataItem)
        {
            return new TextBlock();
        }

        protected override object PrepareCellForEdit(IControl editingElement, RoutedEventArgs editingEventArgs)
        {
            ((TextBox)editingElement).Text = "VEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEERY LONG TEXT";
            return "VEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEERY LONG TEXT";
        }
    }
}
