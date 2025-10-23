using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo.Model
{
    public class OrderInfo  : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        DateTime orderDate;        

        public int OrderID 
        {
            get { return orderID; }
            set { orderID = value; OnPropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; OnPropertyChanged("CustomerID"); }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; OnPropertyChanged("CustomerName"); }
        }

        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged("Country"); }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; OnPropertyChanged("ShipCity"); }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; OnPropertyChanged("OrderDate"); }
        }      

        public OrderInfo()
        {
            
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity,DateTime orderDate)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.OrderDate = orderDate;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
