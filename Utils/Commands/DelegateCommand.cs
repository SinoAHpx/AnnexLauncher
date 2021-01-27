using System;
using System.Windows.Input;

namespace AnnexLauncher.Utils.Commands
{
    public class DelegateCommand  : ICommand
    {
        public Action Action { get; set; }
        public bool Available { get; set; } = true;

        public bool CanExecute(object parameter)
        {
            return Available;
        }

        public void Execute(object parameter)
        {
            Action();
        }

        public event EventHandler CanExecuteChanged;
    }
}