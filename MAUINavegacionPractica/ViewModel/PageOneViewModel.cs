using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINavegacionPractica.ViewModel
{
    public partial class PageOneViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task goToPage2()
        {
            await Shell.Current.GoToAsync("//PageTwo");
        }
        [RelayCommand]
        private async Task goBack()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
