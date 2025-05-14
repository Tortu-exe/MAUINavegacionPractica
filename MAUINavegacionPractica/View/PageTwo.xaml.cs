using MAUINavegacionPractica.ViewModel;

namespace MAUINavegacionPractica.View;

public partial class PageTwo : ContentPage
{
	public PageTwo()
	{
		InitializeComponent();
		BindingContext = new PageTwoViewModel();
	}
}