using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnnexLauncher.ViewModel;
using MaterialDesignColors;
using MaterialDesignColors.ColorManipulation;
using MaterialDesignThemes.Wpf;

namespace AnnexLauncher.View
{
    /// <summary>
    /// HomeView.xaml 的交互逻辑
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

            DataContext = new HomeViewVM();
        }

        private void HomeView_OnLoaded(object sender, RoutedEventArgs e)
        {
            var helper = new PaletteHelper();
            var theme = helper.GetTheme();

            theme.PrimaryLight = new ColorPair(Colors.White.Lighten());
            theme.PrimaryMid = new ColorPair(Colors.White);
            theme.PrimaryDark = new ColorPair(Colors.White.Darken());

            HomeTheme.SetTheme(theme);
        }
    }
}
