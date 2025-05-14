using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINavegacionPractica.ViewModel
{
    public partial class PageTwoViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task goBack()
        {
            await Shell.Current.GoToAsync("//PageOne");
        }
        [RelayCommand]
        private async Task goHome()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
