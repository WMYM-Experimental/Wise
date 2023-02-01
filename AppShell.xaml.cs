using Wise.Views;

namespace Wise;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
           nameof(FeedPage),
           typeof(FeedPage)
           );

        Routing.RegisterRoute(
            nameof(InterestsPage),
            typeof(InterestsPage)
            );

        Routing.RegisterRoute(
           nameof(LoginPage),
           typeof(LoginPage)
           );

        Routing.RegisterRoute(
            nameof(SignupPage),
            typeof(SignupPage)
            );
        
        Routing.RegisterRoute(
           nameof(ChatsPage),
           typeof(ChatsPage)
           );

        Routing.RegisterRoute(
            nameof(ProfileSetupPage),
            typeof(ProfileSetupPage)
            );

        Routing.RegisterRoute(
           nameof(UploadProfilePicPage),
           typeof(UploadProfilePicPage)
           );

        Routing.RegisterRoute(
            nameof(SignupPage),
            typeof(SignupPage)
            );

        Routing.RegisterRoute(
            nameof(ProfilePage),
            typeof(ProfilePage)
            );
    }
}
