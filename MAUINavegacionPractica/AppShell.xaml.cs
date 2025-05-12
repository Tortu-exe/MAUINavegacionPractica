using MAUINavegacionPractica.View;

namespace MAUINavegacionPractica
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(PageOne), typeof(PageOne));
            Routing.RegisterRoute(nameof(PageTwo), typeof(PageTwo));

        }
    }
}
