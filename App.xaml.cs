using Microsoft.Maui.Platform;
using Wise.Handlers;

namespace Wise;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();
        //Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(
        //    nameof(WiseEntry), (handler, view) =>
        //    {
        //        if (view is WiseEntry)
        //        {
        //            handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
        //            // handler.NativeView.Text = view.Text;
        //        }
        //    });
        MainPage = new AppShell();
    }
}
