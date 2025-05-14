using MAUINavegacionPractica.ViewModel;

namespace MAUINavegacionPractica.View;

public partial class PageOne : ContentPage
{
	public PageOne(PageOneViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}