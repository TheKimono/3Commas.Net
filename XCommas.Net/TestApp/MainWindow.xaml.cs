﻿using System;
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

namespace TestApp
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
            XCommasApi client = new XCommasApi("87d227a4b7b64f7bbc17d20c4806239256220f32c97c457885075abfab135554", "dfdad953e8810fef70e027eb0bc459c451ec821e8ab15369c076d40939ad3021e3b76797882995422139319a2349011b01cf89afb79344da0bb04fe680c983bd6f93875fd7c5fc8866fa61a3cd550c207cb932495cfb8ec38339a6bfee61a10c74676d53");

            var ResponseTest = await client.ChangeUserModeAsync(XCommas.Net.Objects.UserMode.Real);
            
            client.ChangeUserMode(XCommas.Net.Objects.UserMode.Paper);



            string test = "";
        }
    }
}