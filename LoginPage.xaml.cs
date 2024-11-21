using Microsoft.Maui.Controls;

namespace YogaStudioApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (usernameEntry.Text == "customer" && passwordEntry.Text == "welcome")
            {
                Navigation.PushAsync(new ClassesPage());
            }
            else
            {
                DisplayAlert("Error", "Invalid credentials", "OK");
            }
        }
    }
}
