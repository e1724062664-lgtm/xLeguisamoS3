namespace xLeguisamoS3.Views;

public partial class vLogin : ContentPage
{
	string usuario=" ", contrasena=" ";
	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string usurioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
		usuario = usurioNuevo;
		contrasena = contrasenaNueva;
    }

    private void btnIniciarSesión_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioIngreso = txtUsuario.Text;
			string contrasenaIngreso = txtContrasena.Text;
			if(usuarioIngreso==usuario && contrasenaIngreso ==contrasena)
			{
				Navigation.PushAsync(new vReporte(usuario));
			}
			else
			{
				DisplayAlertAsync("Alerta", "Usurio/Contraseña Incorectas", "ok");
			}
		}
		catch (Exception ex)
		{

			DisplayAlertAsync("Error", ex.Message, "Cerrar");
		}
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vRegistro());
    }
}