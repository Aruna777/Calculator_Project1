namespace Calculator;

public partial class App : Application
{
    public static HistoryVM HistoryVM { get; private set; }

    public App(HistoryVM historyVM)
	{
        NavigationPage navigation = new NavigationPage(new CalculatorMainPage());
        MainPage = navigation;
        InitializeComponent();
        HistoryVM = historyVM;
    }
}
