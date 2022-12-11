using Wise.Models;

namespace Wise.Views;

public partial class SignupPage : ContentPage
{
    //public SignupPage()
    //{
    //    InitializeComponent();

    //    string appDataPath = FileSystem.AppDataDirectory;
    //    string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

    //    LoadSignup(
    //        fileName: Path.Combine(appDataPath, randomFileName)
    //        );
    //}

    //private void LoadSignup(string fileName)
    //{
    //    WiseUser signupUserFile = new();
    //    signupUserFile.Name = fileName;

    //    if (File.Exists(fileName))
    //    {
    //        signupUserFile.LastOnline = File.GetCreationTime(fileName);
    //        signupUserFile.Bio = File.ReadAllText(fileName);
    //    }

    //    BindingContext = signupUserFile;
    //}

    //private async void SaveButton_Clicked(object sender, EventArgs e)
    //{
    //    if (BindingContext is WiseUser wuser)
    //    {
    //        File.WriteAllText(note.Filename, Email.Text);
    //    }

    //    await Shell.Current.GoToAsync("FeedPage");
    //}
}