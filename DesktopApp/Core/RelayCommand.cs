using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopApp.Core
{
    class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Fun<object, bool> canExecute;

        public event EventHandler CaneExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;  }
        }

       
    }
}
