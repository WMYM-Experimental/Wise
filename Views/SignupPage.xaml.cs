using Wise.Models;

namespace Wise.Views;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string userPath = $"{Name}.user.txt";

        LoadSignup(
            fileName: Path.Combine(appDataPath, userPath)
            );
    }

    private void LoadSignup(string fileName)
    {
        WiseUser signupUserFile = new();
        signupUserFile.Name = Name.Text;
        signupUserFile.Name = fileName;

        if (File.Exists(fileName))
        {
            signupUserFile.LastOnline = File.GetCreationTime(fileName);
            //signupUserFile = File.ReadAllText(fileName);
        }

        BindingContext = signupUserFile;
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is WiseUser wuser)
        {
            File.WriteAllText($"{wuser.Name}, {wuser.Email}, {wuser.Password},", Email.Text);
        }

        await Shell.Current.GoToAsync("..");
    }
}