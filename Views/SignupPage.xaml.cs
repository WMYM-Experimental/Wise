using Newtonsoft.Json;
using Wise.Models;
using Wise.Services;

namespace Wise.Views;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private void LoadSignup(string fileName)
    {
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        var apir = new ApisService();
        string json = JsonConvert.SerializeObject(new WiseUser() {
            Email= wEmail.Text,
            Password=wPaassword.Text,
            Name=wName.Text,
        });

        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        await apir.PostAsync("https://localhost:7086/wiseusercontroller", httpContent);
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    private async void LoginSecSignup(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}