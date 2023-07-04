namespace BaseAltura;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void BtnCalcular_Clicked(object sender, EventArgs e)
	{
		if  (!string.IsNullOrEmpty(Base.Text) || (!String.IsNullOrEmpty(Altura.Text)))
		{
			double xBase, xAltura, xResultado;

			xBase = Convert.ToDouble(Base.Text);
			xAltura = Convert.ToDouble(Altura.Text);

			xResultado = xBase * xAltura;

			calcular.Text=Convert.ToString(xResultado);
		}
		else
		{
			DisplayAlert("Eror", "Ingrese la informacion correcta", "OK");
		}
	}
}

