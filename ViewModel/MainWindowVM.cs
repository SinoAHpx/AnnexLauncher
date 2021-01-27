using System.Windows;
using AnnexLauncher.Utils;
using AnnexLauncher.Utils.Commands;

namespace AnnexLauncher.ViewModel
{
    public class MainWindowVM
    {
        public DelegateCommand CloseCommand { get; set; } = new DelegateCommand
        {
            Action = () =>
            {
                WindowUtils.GetMainWindow().Close();
            }
        };
        public DelegateCommand MinimizeCommand { get; set; } = new DelegateCommand
        {
            Action = () =>
            {
                WindowUtils.GetMainWindow().WindowState = WindowState.Minimized;
            }
        };


    }
}