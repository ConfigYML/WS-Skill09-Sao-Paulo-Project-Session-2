using Microsoft.UI.Xaml;

namespace Session_2_Dennis_Hilfinger;

public partial class RunnerPage : ContentPage, IQueryAttributable
{
    DispatcherTimer timer = new DispatcherTimer();
    User user;
	public RunnerPage()
	{
		InitializeComponent();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += timerTick;
        timer.Start();
    }

    private void timerTick(object? sender, object e)
    {
        DateTime targetTime = new DateTime(2026, 9, 5, 6, 0, 0);
        DateTime currentTime = DateTime.Now;
        TimeSpan timeDiff = targetTime - currentTime;

        TimerLabel.Text = string.Format("{0} days {1} hours and {2} minutes until the race starts!",
            timeDiff.Days,
            timeDiff.Hours,
            timeDiff.Minutes);
    }

    private void Logout(object? sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("//MainPage");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        user = (User)query["User"];
    }

    public async void RegisterForEvent(object? sender, EventArgs e)
    {
        await DisplayAlert("Work in progress", "This feature is not implemented yet", "Ok");
        //AppShell.Current.GoToAsync("//RegisterEventPage");
    }

    public async void MyRaceResults(object? sender, EventArgs e)
    {
        await DisplayAlert("Work in progress", "This feature is not implemented yet", "Ok");
        //AppShell.Current.GoToAsync("//MyRaceResultsPage");
    }

    public async void EditYourProfile(object? sender, EventArgs e)
    {
        await DisplayAlert("Work in progress", "This feature is not implemented yet", "Ok");
        //AppShell.Current.GoToAsync("//EditProfilePage");
    }

    public async void MySponsorship(object? sender, EventArgs e)
    {
        await DisplayAlert("Work in progress", "This feature is not implemented yet", "Ok");
        //AppShell.Current.GoToAsync("//MySponsorshipPage");
    }

    public async void ContactInformation(object? sender, EventArgs e)
    {
        Microsoft.Maui.Controls.Window window = new Microsoft.Maui.Controls.Window(new ContactInformationPage());
        window.Width = 600;
        window.Height = 400;
        Microsoft.Maui.Controls.Application.Current.OpenWindow(window);
    }
}