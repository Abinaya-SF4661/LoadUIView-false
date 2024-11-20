using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLinebreakMode
{
    using IImage = Microsoft.Maui.Graphics.IImage;
    public class Model : INotifyPropertyChanged
    {
        private string _orderId = string.Empty;
        private string _customerId = string.Empty;
        private string _customer = string.Empty;
        private string _city = string.Empty;
        //private string _country;
        private ImageSource _image;
        //private string _imageSource;

        public event PropertyChangedEventHandler? RecordePropertyChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string OrderId
        {
            get { return _orderId; }
            set
            {
                _orderId = value;
                RecordePropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OrderId)));
            }
        }
        public string CustomerId { get { return _customerId; } set { _customerId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerId))); } }
        public string Customer { get { return _customer; } set { _customer = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Customer))); } }
        public string City { get { return _city; } set { _city = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(City))); } }
        public ImageSource CustomerImage { get { return _image; } set { _image = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerImage))); } }
        

        public Model(string orderId, string customerId,string customer, string city, string country, ImageSource customerImage)
        {
            OrderId = orderId;
            CustomerId = customerId;
            Customer = customer; 
            City = city;   
            CustomerImage = customerImage;
        }
    }
}
