﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Forms; // ColorDialog를 사용하기 위해 필요

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
            string color = "#FFF";

            File.WriteAllLines(filePath, new string[] { userName, color });

            // System.Windows.MessageBox로 명확하게 지정
            System.Windows.MessageBox.Show("설정이 저장되었습니다. 위젯을 다시 시작해주세요.");
            Close();
        }
    }
}
