
using Microsoft.UI.Xaml;

namespace Session_2_Dennis_Hilfinger;

public partial class RegisterEventPage : ContentPage, IQueryAttributable
{
    DispatcherTimer timer = new DispatcherTimer();
    User user;
    public RegisterEventPage()
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

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        user = query["User"] as User; 
    }

    private void Register(object sender, EventArgs e)
    {
        DisplayAlert("Feature not implemented yet", "Event registration is not implemented yet.", "Ok");
    }

    private void Cancel(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("//MainPage");
    }
}