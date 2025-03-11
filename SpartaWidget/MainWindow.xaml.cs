using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace SpartaWidget
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            string filePath = "settings.txt";
            if (File.Exists(filePath))
            {
                string[] settings = File.ReadAllLines(filePath);
                if (settings.Length >= 2)
                {
                    WelcomeMessage.Text = $"{settings[0]}님 환영합니다! 오늘도 파이팅";

                    // System.Windows.Media.Color를 명확히 지정
                    WelcomeMessage.Foreground = new SolidColorBrush(
                        (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(settings[1])
                    );
                }
            }
            else
            {
                WelcomeMessage.Text = "사용자님 환영합니다! 오늘도 파이팅";
            }
        }


        private void OpenAttendancePage(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://nbcamp.spartacodingclub.kr/mypage/attendance/timer") { UseShellExecute = true });
        }

        private void OpenSlack(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://app.slack.com/client/T06B9PCLY1E/C088MT6UYER") { UseShellExecute = true });
        }

        private void OpenZep(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://zep.us/home/spaces") { UseShellExecute = true });
        }

        private void OpenAndroidStudio(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Android\\Android Studio\\bin\\studio64.exe");
        }

        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
            LoadSettings();
        }
    }
}
