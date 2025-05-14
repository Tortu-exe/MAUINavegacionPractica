using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUINavegacionPractica.Model;
using MAUINavegacionPractica.ViewModel.SharedService;
using System.Collections.ObjectModel;


namespace MAUINavegacionPractica.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly ContactService service;

        public MainPageViewModel(ContactService service)
        {
            this.service = service;
        }

        public ObservableCollection<ContactoModel> Contactos => service.Contactos;


        [RelayCommand]
        private async Task Start()
        {
            await Shell.Current.GoToAsync("//PageOne");
        }
    }
}
