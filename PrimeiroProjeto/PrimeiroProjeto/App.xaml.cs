using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeiroProjeto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraSimples();
        }

        protected override void OnStart()
        {
            // handle when your app starts
        }

        protected override void OnSleep()
        {
            // handle when your app sleeps
        }

        protected override void OnResume()
        {
            // handle when your app resumes
        }
    }
}
