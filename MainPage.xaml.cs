namespace TrianguloEquilatero;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(LadoA.Text) && !string.IsNullOrEmpty(LadoB.Text) &&
            !string.IsNullOrEmpty(LadoC.Text))
        {
            double LA, LB, LC, semiperimetro, area;
            LA = Convert.ToDouble(LadoA.Text);
            LB = Convert.ToDouble(LadoB.Text);
            LC = Convert.ToDouble(LadoC.Text);

            
            semiperimetro = (LA + LB + LC) / 2;
            area = Math.Sqrt(semiperimetro * (semiperimetro - LA) * (semiperimetro - LB) * (semiperimetro - LC));

            Aarea.Text = Convert.ToString(area);
           //semiperi.Text = semiperimetro.ToString();
        }
        else
        {
            DisplayAlert("ERROR", "Ocurrio un error al introducir los datos","OK");
        }
    }
}

