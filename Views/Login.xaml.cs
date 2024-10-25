namespace apalizExamen.Views;

public partial class Login : ContentPage
{
	string[] user = { "estudiante", "uisrael" };
	string[] password = { "moviles", "2024" };
	public Login()
	{
		InitializeComponent();

	}

	private void btnInicio_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsario.Text;
		string contrasena = txtContrasena.Text;
		bool credencialValida = false;
		for (int i = 0; i < user.Length; i++)
		{
			if (user[i] == usuario && password[i] == contrasena)
			{
				credencialValida = true;
				DisplayAlert("Bienvenido" ,usuario, "Cerrar");
			}
			if (credencialValida)
			{
				Navigation.PushAsync(new Views.Registro(usuario));
			}
			else
			{
				DisplayAlert("Alerta", "Usuario o contraseña incorrecta", "Cerrar");
				txtUsario.Text = "";
				txtContrasena.Text = "";
			}
		}
	}
}