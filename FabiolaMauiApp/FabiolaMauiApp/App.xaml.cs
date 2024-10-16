using FabiolaMauiApp.Pages;

namespace FabiolaMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage = new NavigationPage(new MauiPresentationControls());

            //navPage.BarBackground = Colors.Yellow;
            //navPage.BarTextColor = Colors.Blue;

            //MainPage = new NavigationPage(new NotifyBinding());

            MainPage = new MainPage();
        }
    }
}
