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
using System.Windows.Shapes;

namespace Tortuga_Sviridov.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
            
        }

        private void BtnPizza_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            PizzaWindow pizzaWindow= new PizzaWindow();
            this.Close();
            pizzaWindow.ShowDialog();

        }

        private void BtnSoup_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            SoupWindow soupWindow= new SoupWindow();
            this.Close();
            soupWindow.ShowDialog();
        }

        private void BtnBurger_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            BurgerWindow burgerWindow = new BurgerWindow();
            this.Close();
            burgerWindow.ShowDialog();
        }

        private void BtnPasta_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            BurgerWindow burgerWindow = new BurgerWindow();
            this.Close();
            burgerWindow.ShowDialog();
        }

        private void BtnHotDish_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            HotDishWindow hotDishWindow = new HotDishWindow();
            this.Close();
            hotDishWindow.ShowDialog();
        }

        private void BtnColdDish_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            ColdDishWindow coldDishWindow = new ColdDishWindow();
            this.Close();
            coldDishWindow.ShowDialog();
        }

        private void BtnDesert_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            DesertWindow desertWindow = new DesertWindow();
            this.Close();
            desertWindow.ShowDialog();
        }
    }
}
