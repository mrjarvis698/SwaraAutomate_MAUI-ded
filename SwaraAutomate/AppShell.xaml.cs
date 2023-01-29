namespace SwaraAutomate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("login", typeof(login_page));
        Routing.RegisterRoute("signup", typeof(signup_page));
    }
}
