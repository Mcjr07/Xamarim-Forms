using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GeradorEmail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGerarEmail_Clicked(object sender, EventArgs e)
        {
            Button btnEmail = (Button)sender;
            
            string[] linha = etNome.Text.Split();
            string email;

            if (linha.Length == 1)
            {
                email = linha[0].ToLower() + "@ufn.edu.br";
            }
            else
            {
                email = linha[linha.Length - 1].ToLower() + "_" + linha[0].ToLower() + "@ufn.edu.br";
            }
            lblEmail.Text = $"E-mail gerado: {email}";
        }
    }
}
