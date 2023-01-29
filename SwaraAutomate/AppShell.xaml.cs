namespace SwaraAutomate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("continue", typeof(login_signup_common));
    }
}
