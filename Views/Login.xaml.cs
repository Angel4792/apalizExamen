namespace apalizExamen.Views;

public partial class Login : ContentPage
{
	string[] user = {"estudiante", "uisrael"};
	string[] password = {"moviles", "2024"};
	public Login()
	{
		InitializeComponent();
		
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contrasena = txtContrasena.Text;
		bool credencialValida = false;
		for (int i = 0; i < user.Length; i++)
		{
			if (user[i] == usuario && password[i] == contrasena)
			{
				credencialValida = true;
                DisplayAlert("Bienvenido " + usuario, usuario + "ingresaste al sistema de estudiantes", "Aceptar");
            }
			if (credencialValida) 
			{
				Navigation.PushAsync(new Views.Registro(usuario));
		}
			else
			{
                DisplayAlert("Alerta", "Usuario o contraseña incorrecta", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
    }
}