using System.Threading.Tasks;

namespace MAUINavegacionPractica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
            await Shell.Current.GoToAsync("//MainPage");
            
            
            base.OnStart();

        }
    }
}
