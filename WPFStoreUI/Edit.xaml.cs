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
using WPFStoreUI.Model;

namespace WPFStoreUI
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Product Prroduct { get; set; }

        public Edit(Product p)
        {
            InitializeComponent();
            Prroduct = new Product();
            Prroduct = p;
        }

        public Edit()
        {

        }

        private void addStore(object sender, RoutedEventArgs e)
        {
            try
            {
                Prroduct.Price = double.Parse(ProductPrize.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}","Informaion", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }

            DialogResult = true;
        }
    }
}
