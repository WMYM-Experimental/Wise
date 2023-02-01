using System.Text.Json;
using Wise.Models;
using Wise.Services;

namespace Wise.Views;

public partial class FeedPage : ContentPage
{
	public FeedPage()
	{
		InitializeComponent();
    }

    private async void GoToChats(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChatsPage));
    }
    
    private async void GoToProfile(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ProfilePage));
    }

    private void MatchAction(object sender, EventArgs e)
    {
        var apiservice = new ApisService();
        var people = apiservice.GetAsync("https://localhost:7086/api/wiseusers").Result.Content;
        var listpeople = JsonSerializer.Deserialize<List<WiseUser>>(people.ToString());


        BindingContext = listpeople;
    }
}