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
	public partial class CalculadoraSimples : ContentPage
	{
		public CalculadoraSimples ()
		{
			InitializeComponent ();
		}

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
			double a = Convert.ToDouble(etValorA.Text);	
			double b = Convert.ToDouble(etValorB.Text);
			double total = 0;

            Button bt = (Button)sender;
			if(bt.Text == "+")
			{
				total = a + b;
			}
            if (bt.Text == "-")
            {
                total = a - b;
            }
            if (bt.Text == "/")
            {
                total = a / b;
            }
            if (bt.Text == "*")
            {
                total = a * b;
            }
            lblResposta .Text = total.ToString();
        }
    }
}