using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name=null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }

        }

        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Product> Products2 { get; set; }
        public ObservableCollection<AdUc> AddControls { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext= this;


            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name="SSD",
                    Price=180,
                    Image="/Image/ssd.jpg"
                },
                new Product
                {
                    Name="Ram",
                    Price=100,
                    Image="/Image/ram.jpg"
                }
            };

            Products2 = new ObservableCollection<Product>
            {
                new Product
                {
                    Name="Benotto",
                    Price=100,
                    Image="/Image/benetto.jpg"
                },

                new Product
                {
                    Name="Merkuri",
                    Price=150,
                    Image="/Image/merkuri.jpg"
                },

                new Product
                {
                    Name="Huffy",
                    Price=120,
                    Image="/Image/huffy.jpg"
                },

                new Product
                {
                    Name="RoyalBaby",
                    Price=345,
                    Image="/Image/royal.jpg"
                },

                new Product
                {
                    Name="Benotto",
                    Price=100,
                    Image="/Image/benetto2.jpg"
                },

                new Product
                {
                    Name="RoyalBaby",
                    Price=400,
                    Image="/Image/royal2.jpg"
                },
            };

            foreach (var p in Products)
            {
                var addUc = new AdUc(p);
                mywrappanel.Children.Add(addUc);
            }

            foreach (var p in Products2)
            {
                var addUc = new AdUc(p);
                mywrappanel2.Children.Add(addUc);
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            if (searchTb.Text.ToString() == "Search")
                searchTb.Text = String.Empty;
        }

        private void searchTb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (searchTb.Text.ToString() != String.Empty)
                searchTb.Text = "Search";
        }

        
    }
}
