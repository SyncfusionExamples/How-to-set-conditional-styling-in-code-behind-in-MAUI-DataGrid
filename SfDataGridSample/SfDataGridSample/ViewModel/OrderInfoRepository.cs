
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfDataGridSample
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public bool IsDeleted { get; set; }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo("1001", "Maria", "Germany", "ALFKI", "Berlin",true));
            orderInfo.Add(new OrderInfo("1002", "Anne", "Mexico", "ANATR", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("1003", "Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo("1004", "Thomas", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo("1005", "Adams", "Sweden", "BERGS", "London"));
            orderInfo.Add(new OrderInfo("1006", "Hanna", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo("1007", "Andrew", "France", "BLONP", "Strasbourg",true));
            orderInfo.Add(new OrderInfo("1008", "Irene", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo("1009", "Lenny", "France", "BONAP", "Marsiella", true));
            orderInfo.Add(new OrderInfo("1010", "John", "Canada", "BOTTM", "Lenny Lin"));
            orderInfo.Add(new OrderInfo("1011", "Laura", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo("1012", "Wilson", "Germany", "BLAUS", "Mannheim", true));
            orderInfo.Add(new OrderInfo("1013", "Martin", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo("1014", "Gina", "UK", "AROUT", "London", true));
        }
    }
}
