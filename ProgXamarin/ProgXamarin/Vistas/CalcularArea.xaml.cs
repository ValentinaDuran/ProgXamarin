using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularArea : ContentPage
    {
        decimal a;
        decimal b;
        decimal c;
        decimal basexaltura;
        public CalcularArea()
        {
            InitializeComponent();
        }
        private void Calcular() 
        {
            a = Convert.ToDecimal(Altura.Text);
            b = Convert.ToDecimal(Base.Text);
            c = a * b;
            basexaltura = c / 2;
            lblresultado.Text = basexaltura.ToString();

        }


        private void btncalculararea_Clicked(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}