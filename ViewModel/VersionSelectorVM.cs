using System.Collections.ObjectModel;
using AnnexLauncher.Model;

namespace AnnexLauncher.ViewModel
{
    public class VersionSelectorVM
    {
        public ObservableCollection<VersionModel> VersionCollection { get; set; } =
            new ObservableCollection<VersionModel>();

        public VersionSelectorVM()
        {
            // for (int i = 0; i < 100; i++)
            // {
            //     VersionCollection.Add(new VersionModel
            //     {
            //         VersionIcon = "this is a icon",
            //         VersionName = "this is a name",
            //         VersionRootName = "this is a root name",
            //         VersionType = "this is a version type"
            //     });
            // }
        }
    }
}