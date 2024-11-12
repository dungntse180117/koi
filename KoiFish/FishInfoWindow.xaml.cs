using System;
using System.Windows;
using System.Windows.Controls;

namespace KoiFish
{
    public partial class FishInfoWindow : Window
    {
        public FishInfoWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string currentText = textBox.Text;
                Console.WriteLine($"Text changed: {currentText}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                switch (button.Name)
                {
                    case "BtnAdd":
                        MessageBox.Show("Add button clicked!");
                        break;

                    case "btnDelete":
                        MessageBox.Show("Delete button clicked!");
                        break;

                    case "BtnUpdate":
                        MessageBox.Show("Update button clicked!");
                        break;

                    case "BtnClose":
                        this.Close();
                        break;
                }
            }
        }

        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
