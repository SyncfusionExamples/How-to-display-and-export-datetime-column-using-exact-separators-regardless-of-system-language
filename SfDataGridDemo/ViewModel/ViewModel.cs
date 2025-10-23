using SfDataGridDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", new DateTime(2025, 1, 15, 9, 30, 1))); 
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F.", new DateTime(2025, 2, 15, 12, 45, 0))); 
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", new DateTime(2025, 3, 5, 11, 15, 0))); 
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", new DateTime(2025, 4, 20, 9, 0, 0))); 
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula", new DateTime(2025, 5, 18, 10, 20, 0))); 
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", new DateTime(2025, 6, 12, 8, 10, 0)));
            _orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg", new DateTime(2025, 7, 1, 8, 50, 0))); 
            _orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", new DateTime(2025, 7, 10, 11, 25, 0))); 
            _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", new DateTime(2025, 7, 15, 10, 5, 0))); 
            _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", new DateTime(2025, 7, 16, 11, 40, 0))); 
        }
    }
}
