using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            Button btnEmail = (Button)sender;

            string nome = etNome.Text;
            int idade = int.Parse(etIdade.Text);
            double peso = double.Parse(etPeso.Text);
            double altura = double.Parse(etAltura.Text);

            double imc = peso / (altura * altura);

            string resultado = $"IMC: {imc:F2}";

            lblIMC.Text = resultado;
        }
    }
}
