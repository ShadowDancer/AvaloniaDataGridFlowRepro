using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AvaloniaFlowRepro.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Obj> items;

        public MainWindowViewModel()
        {
            MakeItems(30);
        }

        private void MakeItems(int count)
        {
            Items = Enumerable.Range(0, count).Select(n => new Obj() { Name = n.ToString() }).ToList();
        }

        public List<Obj> Items { get => items; set => this.RaiseAndSetIfChanged(ref items, value); }

    }
    public class Obj
    {
        public string Name { get; set; }


        public string NullProp { get; set; }
    }
}
