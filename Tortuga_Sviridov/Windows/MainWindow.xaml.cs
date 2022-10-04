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
using Tortuga_Sviridov.Windows;

namespace Tortuga_Sviridov
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

      

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.ShowDialog();
           


        }

        private void BtnBoarding_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            BoardingWindow boardingWindow = new BoardingWindow();
            this.Close();
            boardingWindow.ShowDialog();
            
        }

       
    }
}
