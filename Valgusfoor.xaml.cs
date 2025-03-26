namespace Mobiiliapp;

public partial class Valgusfoor : ContentPage
{
    int g = 0;
    bool i = false;
    bool nightMode = false;

    public Valgusfoor()
    {
        InitializeComponent();
    }

    private async void OnClickedBtn3(object sender, EventArgs e)
    {
        if (nightMode) return;

        i = true;
        while (i)
        {
            green.BackgroundColor = Color.FromRgb(0, 255, 0);
            red.BackgroundColor = Color.FromRgb(128, 128, 128);
            await Task.Delay(1500);
            yellow.BackgroundColor = Color.FromRgb(255, 255, 0);
            green.BackgroundColor = Color.FromRgb(128, 128, 128);
            await Task.Delay(1500);
            red.BackgroundColor = Color.FromRgb(255, 0, 0);
            yellow.BackgroundColor = Color.FromRgb(128, 128, 128);
            await Task.Delay(1500);
        }
    }

    private void OnClickedBtn4(object sender, EventArgs e)
    {
        i = false;
        nightMode = false; 
        ResetLights();
    }

    private void OnClickedBtn6(object sender, EventArgs e)
    {
        if (nightMode) return; 

        if (g == 0)
        {
            g++;
            green.BackgroundColor = Color.FromRgb(0, 255, 0);
            red.BackgroundColor = Color.FromRgb(128, 128, 128);
            yellow.BackgroundColor = Color.FromRgb(128, 128, 128);
        }
        else if (g == 1)
        {
            g++;
            yellow.BackgroundColor = Color.FromRgb(255, 255, 0);
            green.BackgroundColor = Color.FromRgb(128, 128, 128);
            red.BackgroundColor = Color.FromRgb(128, 128, 128);
        }
        else
        {
            g = 0;
            red.BackgroundColor = Color.FromRgb(255, 0, 0);
            yellow.BackgroundColor = Color.FromRgb(128, 128, 128);
            green.BackgroundColor = Color.FromRgb(128, 128, 128);
        }
    }

    private async void OnClickedNightMode(object sender, EventArgs e)
    {
        nightMode = !nightMode;

        if (nightMode)
        {
            i = false; 
            ResetLights(); 

            while (nightMode)
            {
                yellow.BackgroundColor = Color.FromRgb(255, 255, 0);
                await Task.Delay(500);
                yellow.BackgroundColor = Color.FromRgb(128, 128, 128);
                await Task.Delay(500);
            }
        }
        else
        {
            ResetLights();
        }
    }

    private void ResetLights()
    {
        red.BackgroundColor = Color.FromRgb(128, 128, 128);
        green.BackgroundColor = Color.FromRgb(128, 128, 128);
        yellow.BackgroundColor = Color.FromRgb(128, 128, 128);
    }
}
