namespace apalizExamen.Views;

public partial class Registro : ContentPage
{
	public Registro(string usuarioIngresado)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado: " + usuarioIngresado;
    }


  

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double.TryParse(txtMonto.Text, out double monto);
        double inicial = 1500;
        double iva = (inicial * 4 / 100);
        double total1 = (inicial - monto);
        double total2 = (total1 / 4 + iva);
        txtMensual.Text = total2.ToString();
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        int monto = int.Parse(txtMonto.Text);
        int pagoMensual = int.Parse(txtMensual.Text);
        string fecha = dpFecha.Date.ToString();
        string pais = pkPais.Items[pkPais.SelectedIndex].ToString();
        string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        Navigation.PushAsync(new Resumen(txtNombre.Text, txtApellido.Text, txtEdad.Text, fecha, pais, ciudad, lblUsuario.Text, monto, pagoMensual));
    }
}