using MAUINavegacionPractica.ViewModel;

namespace MAUINavegacionPractica;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }


}
