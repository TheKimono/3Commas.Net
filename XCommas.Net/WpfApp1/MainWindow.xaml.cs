using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XCommas.Net;


namespace WpfApp1
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            XCommasApi client = new XCommasApi("5a5f186c065f487580f496f5bd68c13aa8192a3f024b426dab11783a1ca3cd3a", "0945b1c2ef927cf4c9d507a719e210e71f74d76c829a59fd752dec17337b5deda9c6c384acada520d28835fa763798a59387651880aa211d1ba259226c14a7d1293ed243acdabab3a34c00035aac722dad3b15345c6ebc6be4de5c56d3f8ac41bf7406d7");
            var test2 = await client.ChangeUserModeAsync(XCommas.Net.Objects.User.real);

            string test = "";

            var test3 = client.ChangeUserMode(XCommas.Net.Objects.User.paper);

            test = "";


        }
    }
}
