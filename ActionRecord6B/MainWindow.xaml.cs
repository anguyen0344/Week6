using System.Windows;

namespace ActionRecord6B
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterDome_Click(object sender, RoutedEventArgs e)
        {
            string characterName = CharacterNameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(characterName))
            {
                ResponseText.Text = "Please enter your character's name.";
                return;
            }

            ResponseText.Text =
                $"Welcome, {characterName}! The Civic Archive Dome awaits you.";
        }
    }
}