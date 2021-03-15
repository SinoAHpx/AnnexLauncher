using AnnexLauncher.Model;

namespace AnnexLauncher.ViewModel
{
    public class HomeViewVM
    {
        public string SelectedVersionName { get; set; }

        public HomeViewVM()
        {
            SelectedVersionName = "Minecraft";
        }
    }
}