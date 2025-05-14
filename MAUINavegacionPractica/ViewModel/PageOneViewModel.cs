using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUINavegacionPractica.Model;
using MAUINavegacionPractica.ViewModel.SharedService;

namespace MAUINavegacionPractica.ViewModel
{
    public partial class PageOneViewModel : ObservableObject
    {

        //TODO
        //Validar los datos de ingreso

        private readonly ContactService service;

        public PageOneViewModel(ContactService service)
        {
            this.service = service;            
        }




        [ObservableProperty] private string name;
        [ObservableProperty] private string surname;
        [ObservableProperty] private int age;
        [ObservableProperty] private string mail;

        [RelayCommand(CanExecute = nameof(CanSaveContact))]
        private async Task saveContact()
        {
            ContactoModel newContact = new ContactoModel
            {
                Name = Name,
                Surname = Surname,
                Age = Age,
                Mail = Mail
            };

            service.AddContact(newContact);
            
            Name = string.Empty;
            Surname = string.Empty;
            Age = 0;
            Mail = string.Empty;

            await Shell.Current.GoToAsync("//MainPage");
        }

        private bool CanSaveContact()
        {
            return !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Surname)
                && Age > 0
                && !string.IsNullOrWhiteSpace(Mail);
        }

        partial void OnNameChanged(string value)
        {
            saveContactCommand.NotifyCanExecuteChanged();
        }
        partial void OnSurnameChanged(string value)
        {
            saveContactCommand.NotifyCanExecuteChanged();
        }
        partial void OnAgeChanged(int value)
        {
            saveContactCommand.NotifyCanExecuteChanged();
        }
        partial void OnMailChanged(string value)
        {
            saveContactCommand.NotifyCanExecuteChanged();
        }

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
