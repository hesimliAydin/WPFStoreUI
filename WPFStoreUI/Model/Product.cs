using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFStoreUI.Model
{
    public class Product:INotifyCompletion
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void OnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged(); }
        }
    }
}
