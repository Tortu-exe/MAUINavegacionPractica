using MAUINavegacionPractica.ViewModel;

namespace MAUINavegacionPractica.View;

public partial class PageOne : ContentPage
{
	public PageOne()
	{
		InitializeComponent();
		BindingContext = new PageOneViewModel();
	}
}