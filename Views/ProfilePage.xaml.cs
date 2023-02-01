using Newtonsoft.Json;
using Wise.Models;
using Wise.Services;

namespace Wise.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

	private void getdata(object sender, EventArgs e)
	{
		var apir = new ApisService();
		var d = apir.GetAsync("https://localhost:7086/wiseusercontroller").Result.Content;
        var data = JsonConvert.DeserializeObject<List<WiseUser>>(d.ToString());

		name.Text = data[0].Name;
    }
}