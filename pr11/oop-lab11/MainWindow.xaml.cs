using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Library_oop_lab11;


namespace oop_lab11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Initialized(object sender, EventArgs e)
        {
            RefreshWeather();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshWeather();
        }

        private void RefreshWeather()
        {
            Weather weather = new Weather();
            Temperature.Content = "Температура: " + weather.Temperature + " °";
            Wind.Content = "Вітер: " + weather.Wind + " м/с";
            Humidity.Content = "Вологість: " + weather.Humidity + " %";
            Pressure.Content = "Тиск: " + weather.Pressure + " мм рт. ст.";
            SkyStatus.Content = weather.SkyStatus;
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri(weather.PictureURL);
            img.EndInit();
            Picture.Source = img;
        }
    }
}
