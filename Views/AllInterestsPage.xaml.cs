using Wise.Models;

namespace Wise.Views;

public partial class AllInterestsPage : ContentPage
{
	public AllInterestsPage()
	{
		InitializeComponent();
        BindingContext = new AllInterests();
    }

    protected override void OnAppearing()
    {
        ((AllInterests)BindingContext).LoadInterests();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(InputInterestPage));
    }

    private async void interestsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var i = (Interest)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(InputInterestPage)}?{nameof(InputInterestPage.ItemId)}={i.Name}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }
}