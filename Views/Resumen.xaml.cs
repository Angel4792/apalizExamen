namespace apalizExamen.Views;

public partial class Resumen : ContentPage
{
    public Resumen(string nombre1, string apellido1, string edad1, string fecha1, string pais1, string ciudad1, string usuarioIngresado, double montoInicial, double pagoMensual)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario conectado: " + usuarioIngresado;

        nombre.Text = nombre1;
        apellido.Text = apellido1;
        edad.Text = edad1;
        fecha.Text = fecha1;
        pais.Text = pais1;
        lblciudad.Text = ciudad1;
        lblUsuario.Text = usuarioIngresado;
        lblmonto.Text = $"{montoInicial}";
        lblpagoM.Text = $"{pagoMensual}";
        lblpagoT.Text = $"{pagoMensual}";


    }
}