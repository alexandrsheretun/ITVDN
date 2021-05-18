using System.Windows;

namespace WPFApp_8_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0 : 255","byte");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("-128 : +127", "sbyte");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0 : 65535", "ushort");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("-32768 : +32767","short");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0u : 4294967295U","uint");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("-2147483648 : +2147483647","int");
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0ul : 18446744073709551615UL","ulong");
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("-9223372036854775808L : +9223372036854775807L","long");
        }
    }
}
