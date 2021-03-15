using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AnnexLauncher.Model;

namespace AnnexLauncher.ViewModel
{
    class AccountVM
    {
        public ObservableCollection<AccountModel> Accounts { get; set; }
        
        public AccountVM()
        {
            Accounts = new ObservableCollection<AccountModel>();
            for (var i = 0; i < 12; i++)
            {
                Accounts.Add(new AccountModel
                {
                    AccountAvatar = @"C:\Users\ahpx\Desktop\download.png",
                    AccountMail = "AHpx@yandex.com" + i,
                    AccountName = "A" + i + "H",
                    AccountSkin = i % 2 == 0
                        ? @"pack://application:,,,/Assets/Skins/steve.png"
                        : @"pack://application:,,,/Assets/Skins/alex.png",
                    AccountType = "Offline",
                    AccountUuid = Guid.NewGuid().ToString("N"),
                    AccountAccessToken = Guid.NewGuid().ToString("N")
                });
            }
        }
    }
}
