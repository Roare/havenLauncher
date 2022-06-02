﻿using System.Windows;
using WPFLauncher.Properties;

namespace WPFLauncher
{
    public partial class OptionsWindow : Window
    {
        public OptionsWindow()
        {
            InitializeComponent();
            LoadSavedOptions();
        }

        private void LoadSavedOptions()
        {
            PTRButton.IsChecked = Settings.Default.PTR;
            KeepOpenButton.IsChecked = Settings.Default.KeepOpen;
            SaveAccountButton.IsChecked = Settings.Default.SaveAccount;
        }

        private void OptionSaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (PTRButton.IsChecked.HasValue)
            { 
                Settings.Default.PTR = PTRButton.IsChecked.Value;
            }
            if (KeepOpenButton.IsChecked.HasValue)
            {
                Settings.Default.KeepOpen = KeepOpenButton.IsChecked.Value;
            }
            if (SaveAccountButton.IsChecked.HasValue)
            {
                Settings.Default.SaveAccount = SaveAccountButton.IsChecked.Value;
            }
            Settings.Default.Save();
            Close();
        }
    }
}