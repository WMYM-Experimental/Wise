using Wise.Models;

namespace Wise.Views;

public partial class InputInterestPage : ContentPage
{
    public InputInterestPage()
    {
        InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.interest.txt";

        LoadInterest(Path.Combine(appDataPath, randomFileName));
    }

    private void LoadInterest(string fileName)
    {
        Interest iModel = new ();
        iModel.Name = fileName;

        if (File.Exists(fileName))
        {
            iModel.Name = File.ReadAllText(fileName);
        }

        BindingContext = iModel;
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Interest i)
        {
            File.WriteAllText(i.Name, TextEditor.Text);
        }

        await Shell.Current.GoToAsync("..");
    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Interest i)
        {
            if (File.Exists(i.Name))
            {
                File.Delete(i.Name);
            }
        }

        await Shell.Current.GoToAsync("..");
    }
}