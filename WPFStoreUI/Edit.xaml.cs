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
        public Product Product { get; set; }

        public Edit(Product p)
        {
            InitializeComponent();
            this.DataContext = this;
            Product = new Product();
            Product = p;
        }

        

        private void addStore(object sender, RoutedEventArgs e)
        {
            try
            {
                Product.Price = double.Parse(ProductPrize.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}","Informaion", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }

            DialogResult = true;
        }
    }
}
