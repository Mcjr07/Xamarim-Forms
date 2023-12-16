using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeiroProjeto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ParOuImpar : ContentPage
	{
		public ParOuImpar ()
		{
			InitializeComponent ();
            btnExecutar.Clicked += BtnExecutar_Clicked;
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(etValor.Text);
            string resposta = $"O número {numero} é: ";
            if( numero % 2 == 0 )
            {
                resposta += "par";
            }
            else
            {
                resposta += "impar";
            }
            lblResposta.Text = resposta;
        }
    }
}