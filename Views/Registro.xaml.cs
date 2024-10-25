namespace apalizExamen.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado: " + txtUsuario;
    }

    private void btnReporte_Clicked(object sender, EventArgs e)
    {


    }
}