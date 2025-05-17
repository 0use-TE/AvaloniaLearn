using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaLearn.ViewModels
{
    class ButtonViewModel: ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> RepeatButton { get; }

        public ButtonViewModel() 
        {
            RepeatButton = ReactiveCommand.Create(() => Debug.WriteLine("Button Clicked"));
        }
    }
}
