using System;
using System.IO;
using System.Windows;

namespace SpartaWidget
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SaveSettings(object sender, RoutedEventArgs e)
        {
            string filePath = "settings.txt";
            string userName = UserNameTextBox.Text;

            File.WriteAllLines(filePath, new string[] { userName });

            System.Windows.MessageBox.Show("설정이 저장되었습니다. 위젯을 다시 시작해주세요.");
            Close();
        }
    }
}
