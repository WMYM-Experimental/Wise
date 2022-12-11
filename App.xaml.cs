using Microsoft.Maui.Platform;
using Wise.Handlers;

namespace Wise;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
