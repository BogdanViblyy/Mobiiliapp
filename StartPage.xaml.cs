namespace Mobiiliapp;

public partial class StartPage : ContentPage
{
	public List<ContentPage> lehed = new List<ContentPage>() { new TextPage(), new FigurePage(), new Valgusfoor()};
	public List<string> tekstid = new List<string> { "Tee lahti tekstPage", "Tee lahti FigutePage", "Tee lahti Valgusfoor"};
	ScrollView sv;
	VerticalStackLayout vsl;
	public StartPage()
	{
		Title = "Avaleht";
		vsl = new VerticalStackLayout { BackgroundColor = Color.FromRgb(128, 128, 128) };
		for (int i = 0; i < tekstid.Count; i++)
		{
			Button nupp = new Button
			{
				Text= tekstid[1],
				BackgroundColor=Color.FromRgb(64, 64, 64),
				TextColor= Color.FromRgb(255, 255, 255),
				FontSize= 40,
				BorderWidth=10,
				ZIndex=i,
				FontFamily="Times New Roman"
			};
			vsl.Add(nupp);
			nupp.Clicked += Lehte_avamine;
		}
		sv=new ScrollView { Content=vsl};
		Content = sv;
	}
	private async void Lehte_avamine(object? sender, EventArgs e)
	{
		Button btn = (Button)sender;
		await Navigation.PushAsync(lehed[btn.ZIndex]);
	}
}