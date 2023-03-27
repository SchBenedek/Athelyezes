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

namespace Athelyezes
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

        private void jobbra_Nyil(object sender, RoutedEventArgs e)
        {
            object a = bal_Lista.SelectedItem;
            bal_Lista.Items.Remove(a);
            jobb_Lista.Items.Add(a);
        }
        private void balra_Nyil(object sender, RoutedEventArgs e)
        {
            object a = jobb_Lista.SelectedItem;
            jobb_Lista.Items.Remove(a);
            bal_Lista.Items.Add(a);
        }
        private void bal_Elso(object sender, RoutedEventArgs e)
        {
            bal_Lista.SelectedIndex = 0;
            bal_Lista.Focus();
        }
        private void bal_Utolso(object sender, RoutedEventArgs e)
        {
            bal_Lista.SelectedIndex=bal_Lista.Items.Count-1;
            bal_Lista.Focus();
        }
        private void jobb_Elso(object sender, RoutedEventArgs e)
        {
            jobb_Lista.SelectedIndex = 0;
            jobb_Lista.Focus();
        }
        private void jobb_Utolso(object sender, RoutedEventArgs e)
        {
            jobb_Lista.SelectedIndex = jobb_Lista.Items.Count - 1;
            jobb_Lista.Focus();
        }
        private void Hozzaadas(object sender, RoutedEventArgs e)
        {
            bal_Lista.Items.Add(text_Hozzaad.Text);
        }
    }
}
