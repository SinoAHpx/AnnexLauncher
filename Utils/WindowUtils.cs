using AnnexLauncher.View;
using System.Windows;

namespace AnnexLauncher.Utils
{
    public static class WindowUtils
    {
        public static MainWindow GetMainWindow()
        {
            return Application.Current.MainWindow as MainWindow;
        }

        public static HomeView GetHomeView()
        {
            return GetMainWindow().MainHomeView;
        }
    }
}