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
}