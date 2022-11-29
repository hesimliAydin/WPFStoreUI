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
using WPFStoreUI.Model;

namespace WPFStoreUI
{
    /// <summary>
    /// Interaction logic for AdUc.xaml
    /// </summary>
    public partial class AdUc : UserControl
    {
        
        public Product Product { get; set; }

        
        public AdUc(Product product)
        {
            InitializeComponent();
            this.DataContext = this;
            this.Product = product;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var product =sender as Product;

            
        }
    }
}
